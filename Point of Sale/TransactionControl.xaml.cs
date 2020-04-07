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

        /// <summary>
        /// Lets you pay with Card
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void CardPay(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
           if(DataContext is Order data)
           {
                var item = data;
                var result = card.ProcessTransaction(item.Total);
                switch(result)
                {
                    case ResultCode.Success:
                        string print = Print(item.OrderNumber, item.Items, item.Subtotal, item.Total, "Credit/Debit Card");
                        receipt.Print(print);
                        data = new Order();
                        this.DataContext = data;
                        var screen = new MenuItemSelectionControl();
                        ordercontrol.SwapScreen(screen);
                        ordercontrol.DataContext = data;
                        break;
                    case ResultCode.UnknownErrror:
                        MessageBox.Show("Unknown Card Error");
                        break;
                    case ResultCode.CancelledCard:
                        MessageBox.Show("Cancelled Card");
                        break;
                    case ResultCode.InsufficentFunds:
                        MessageBox.Show("Insufficent Funds");
                        break;
                    case ResultCode.ReadError:
                        MessageBox.Show("Card Reading Error");
                        break;
                }
                
           }
        }

        /// <summary>
        /// This is not finished but merely what it should look like
        /// This method should get an amount above what is owed or equal to what is
        /// owed and give changed based on that amount
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void CashPay(object sender, RoutedEventArgs e)
        {
            //should take the total and have you insert how many of bill and coins you want to pay with
            //and have you hit another button to say thats the amount you want to insert
            //then it should tell you if the amount was enough
            //after that it should tell the casher to give change based on the total - amountGiven
            // it then should print that all to the reciept, unfortunately I do not have the time to figure
            //all of this out before it is due along with many other errors I am having
        }

        /// <summary>
        /// cancels the transaction and creates a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelTransaction(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if(DataContext is Order data)
            {
                data = new Order();
                this.DataContext = data;
                ordercontrol.DataContext = data;
                var screen = new MenuItemSelectionControl();
                ordercontrol.SwapScreen(screen);
            }
            
        }

        /// <summary>
        /// Print helper for cards
        /// </summary>
        /// <param name="orderNum">int</param>
        /// <param name="item">IEnumerable<IOrderItem></param>
        /// <param name="sub">double</param>
        /// <param name="total">double</param>
        /// <param name="paymentType">string</param>
        /// <returns></returns>
        public string Print(uint orderNum, IEnumerable<IOrderItem> item, double sub, double total, string paymentType)
        {
            string print = "Order " + orderNum.ToString() + "\n";
            foreach(IOrderItem e in item)
            {
                print += e.ToString() + " " + string.Format("{0:0.00}",e.Price) + "\n";
                if(e.SpecialInstructions.Count != 0)
                {
                    foreach(string s in e.SpecialInstructions)
                    {
                        print += s.ToString() + "\n";
                    }
                }
            }
            string printEnd = "\n" + string.Format("Subtotal: {0:0.00}",sub) + "\n" + string.Format("Total: {0:0.00}",total) + "\n" + paymentType + "\n";
            return print + printEnd;
        }

        /// <summary>
        /// Printer helper for cash
        /// </summary>
        /// <param name="orderNum">uint</param>
        /// <param name="item">IEnumerable</param>
        /// <param name="sub">double</param>
        /// <param name="total">double</param>
        /// <param name="paymentType">string</param>
        /// <param name="amountPaid">double</param>
        /// <param name="Change">double</param>
        /// <returns></returns>
        public string PrintCash(uint orderNum, IEnumerable<IOrderItem> item, double sub, double total, string paymentType, double amountPaid, double Change)
        {
            string print = "Order " + orderNum.ToString() + "\n";
            foreach (IOrderItem e in item)
            {
                print += e.ToString() + " " + string.Format("{0:0.00}", e.Price) + " ";
                if (e.SpecialInstructions.Count != 0)
                {
                    foreach (string s in e.SpecialInstructions)
                    {
                        print += " " + s.ToString() + "\n";
                    }
                }
            }
            string printMid = "\n" + string.Format("Subtotal: {0:0.00}", sub) + "\n" + string.Format("Total: {0:0.00}", total) + "\n" + paymentType + "\n";
            string printEnd = string.Format("Amount Paid: {0:0.00}", amountPaid) + "\n" + string.Format("Change given: {0:0.00}", Change); 
            return print + printMid + printEnd;
        }
    }
}
