/* Author: Cole Griem
 * Class: OrderSummaryControl.xaml.cs
 * Purpose: Keeps track of items ordered and prices
 */
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

namespace Point_of_Sale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {

        

        public OrderSummaryControl()
        {
            
            InitializeComponent();
            
        }

        public void Selected(object sender, SelectionChangedEventArgs args)
        {
            IOrderItem i = ((sender as ListBox).SelectedItem as IOrderItem);
            var ordercontrol = this.FindAncestor<OrderControl>();
            if(i is AngryChicken)
            {
                
                if (DataContext is Order data)
                {
                    var screen = new AngryChickenCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is BakedBeans)
            {
                if (DataContext is Order data)
                {
                    var screen = new BakedBeansCustomization(DataContext);
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is ChiliCheeseFries)
            {
                if (DataContext is Order data)
                {
                    var screen = new ChiliCheeseFriesCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is CornDodgers)
            {
                if (DataContext is Order data)
                {
                    var screen = new CornDodgersCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is CowboyCoffee)
            {
                if (DataContext is Order data)
                {
                    var screen = new CowpokeCoffeeCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is CowpokeChili)
            {
                if (DataContext is Order data)
                {
                    var screen = new CowpokeChiliCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is DakotaDoubleBurger)
            {
                if (DataContext is Order data)
                {
                    var screen = new DakotaDoubleCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is JerkedSoda)
            {
                if (DataContext is Order data)
                {
                    var screen = new JerkedSodaCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is PanDeCampo)
            {
                if (DataContext is Order data)
                {
                    var screen = new PanDeCampoCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is PecosPulledPork)
            {
                if (DataContext is Order data)
                {
                    var screen = new PecosPulledPorkCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is RustlersRibs)
            {
                if (DataContext is Order data)
                {
                    var screen = new RustlersRibsCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is TexasTea)
            {
                if (DataContext is Order data)
                {
                    var screen = new TexasTeaCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is TexasTripleBurger)
            {
                if (DataContext is Order data)
                {
                    var screen = new TexasTripleBurgerCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is TrailBurger)
            {
                if (DataContext is Order data)
                {
                    var screen = new TrailBurgerCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
            else if (i is Water)
            {
                if (DataContext is Order data)
                {
                    var screen = new WaterCustomization();
                    screen.DataContext = i;
                    ordercontrol.SwapScreen(screen);
                }
            }
        }

        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                if(sender is Button button)
                {
                    data.Remove((IOrderItem)button.DataContext);
                }
            }
        }
    }
}
