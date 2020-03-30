/* Author: Cole Griem
 * Class: MenuItemSelectionControl.xaml.cs
 * Purpose: Has all the food items, used to be OrderControl but I changed that to this
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        

        /// <summary>
        /// Adds the Angry Chicken
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new AngryChicken();
                var screen = new AngryChickenCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }

        }

        /// <summary>
        /// Adds Cowpoke Chili
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new CowpokeChili();
                var screen = new CowpokeChiliCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }

        }

        /// <summary>
        /// Adds Dakota Double Burger
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new DakotaDoubleBurger();
                var screen = new DakotaDoubleCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Pecos Pulled Pork
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new PecosPulledPork();
                var screen = new PecosPulledPorkCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Texas Triple Burger
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new TexasTripleBurger();
                var screen = new TexasTripleBurgerCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Trail Burger
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new TrailBurger();
                var screen = new TrailBurgerCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Chili Cheese Fries
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new ChiliCheeseFries();
                var screen = new ChiliCheeseFriesCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new JerkedSoda();
                var screen = new JerkedSodaCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Corn Dodgers
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new CornDodgers();
                var screen = new CornDodgersCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Pan De Campo
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new PanDeCampo();
                var screen = new PanDeCampoCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Baked Beans
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new BakedBeans();
                var screen = new BakedBeansCustomization(DataContext);
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Texas Tea
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new TexasTea();
                var screen = new TexasTeaCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Cowboy Coffee
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new CowboyCoffee();
                var screen = new CowpokeCoffeeCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Water
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new Water();
                var screen = new WaterCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        /// <summary>
        /// Adds Rustlers Rib
        /// </summary>
        /// <param name="sender">button </param>
        /// <param name="e">click </param>
        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                var item = new RustlersRibs();
                var screen = new RustlersRibsCustomization();
                screen.DataContext = item;
                data.Add(item);
                ordercontrol.SwapScreen(screen);
            }
        }

        public void Remove(IOrderItem item)
        {
            var ordercontrol = this.FindAncestor<OrderControl>();
            if (DataContext is Order data)
            {
                data.Remove(item);
                
            }
        }

    }
}
