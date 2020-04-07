using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace Point_of_Sale
{
    public class CashRegisterModelView: INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        CashDrawer drawer = new CashDrawer();

        public double TotalValue => drawer.TotalValue;

        public void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
        }
    }
}
