﻿/* Author: Cole Griem
 * Class: OrderControl.xaml.cs
 * Purpose: Control the buttons
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

namespace Point_of_Sale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        /// <summary>
        /// Initializes program
        /// </summary>
        public OrderControl()
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
            OrderSummaryControl.OrderList.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Adds Cowpoke Chili
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddCowpokeChili_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Adds Dakota Double Burger
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddDakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Adds Pecos Pulled Pork
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Adds Texas Triple Burger
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Adds Trail Burger
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Adds Chili Cheese Fries
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddChiliCheeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Adds Jerked Soda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Adds Corn Dodgers
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Adds Pan De Campo
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Adds Baked Beans
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Adds Texas Tea
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Adds Cowboy Coffee
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddCowboyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Adds Water
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }

        /// <summary>
        /// Adds Rustlers Rib
        /// </summary>
        /// <param name="sender">button </param>
        /// <param name="e">click </param>
        private void AddRustlerRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }
    }
}
