using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using Point_of_Sale.Customization;
using Point_of_Sale.ExtentionMethods;
using CashRegister;

namespace Point_of_Sale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {
        public TransactionControl()
        {
            InitializeComponent();
        }

        CashDrawer drawer = new CashDrawer();

        CardTerminal card = new CardTerminal();

        ReceiptPrinter receipt = new ReceiptPrinter();

        private void CardPay(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
           if(DataContext is Order data)
           {
                var item = data;
                var result = card.ProcessTransaction(item.Total);
                if(result == ResultCode.Success)
                {
                    string print = Print(item.OrderNumber, item.Items, item.Subtotal, item.Total, "card");
                    receipt.Print(print);
                }
                else
                {
                    receipt.Print(result.ToString() + "\n");
                }
                data = new Order();
                this.DataContext = data;
                var screen = new MenuItemSelectionControl();
                ordercontrol.SwapScreen(screen);
           }
        }

        private void CashPay(object sender, RoutedEventArgs e)
        {

        }

        private void CancelTransaction(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if(DataContext is Order data)
            {
                data = new Order();
                this.DataContext = data;
                var screen = new MenuItemSelectionControl();
                ordercontrol.SwapScreen(screen);
            }
            
        }

        public string Print(uint orderNum, IEnumerable<IOrderItem> item, double sub, double total, string paymentType)
        {
            string print = orderNum.ToString() + "\n";
            foreach(IOrderItem e in item)
            {
                print += e.ToString() + " " + e.Price;
                if(e.SpecialInstructions.ToString() != "")
                {
                    print += e.SpecialInstructions.ToString();
                }
            }
            string printEnd = "\n" + sub.ToString() + "\n" + total.ToString() + "\n" + paymentType + "\n";
            return print + printEnd;
        }
    }
}
