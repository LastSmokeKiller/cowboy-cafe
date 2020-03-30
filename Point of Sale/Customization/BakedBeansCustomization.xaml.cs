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
using Size = CowboyCafe.Data.Size;

namespace Point_of_Sale.Customization
{
    /// <summary>
    /// Interaction logic for BakedBeansCustomization.xaml
    /// </summary>
    public partial class BakedBeansCustomization : UserControl
    {
        private Order linkToOrder;
        public BakedBeansCustomization(object dc)
        {
            linkToOrder = (Order)dc;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BakedBeans bb = (BakedBeans)DataContext;
            /*switch (((Button)sender).Name)
            {
                
            }*/
        }
    }
}
