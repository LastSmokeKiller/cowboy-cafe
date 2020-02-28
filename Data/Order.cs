using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double Subtotal { get
            {
                double sub = 0;
                foreach(IOrderItem e in items)
                {
                    sub += e.Price;
                }
                return sub;
            } }

        private static uint lastOrderNumber;

        public uint OrderNumber { get
            {
                Random r = new Random();
                int number = r.Next(99);
                while (number == lastOrderNumber)
                {
                    number = r.Next(99);
                }                    
                uint use = (uint)number;
                lastOrderNumber = use;
                return use;
                
            } }
            
                
                
            
                
            

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
    }
}
