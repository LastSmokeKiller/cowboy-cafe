﻿/* Author: Cole Griem
 * Class: OrderControl.xaml.cs
 * Purpose: Control the top 3 buttons
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
using Point_of_Sale.ExtentionMethods;
using Point_of_Sale.Customization;
using CashRegister;

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
            var data = new Order();
            this.DataContext = data;
        }

        public CashDrawer drawer = new CashDrawer();
        
        /// <summary>
        /// Completes the order and makes a new one
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            
            if(DataContext is Order data)
            {
                var screen = new TransactionControl();
                screen.DataContext = data;
                SwapScreen(screen);
                
            }
        }

        /// <summary>
        /// Cancels the order and creates a new one
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                data = new Order();
                this.DataContext = data;
            }
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Doesn't have an effect yet
        /// </summary>
        /// <param name="sender">button</param>
        /// <param name="e">click</param>
        private void ItemSelection_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        public void SwapScreen(FrameworkElement element)
        {
            Container.Child = element;
        }
    }
}
