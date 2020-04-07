/* Author: Cole Griem
 * Class: Order.cs
 * Purpose: has all the order information
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace CowboyCafe.Data
{
    /// <summary>
    /// Lets you order food
    /// </summary>
    public class Order:INotifyPropertyChanged
    {
        /// <summary>
        /// Checks whenever a food item is added or removed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        


        /// <summary>
        /// The total before purchase
        /// </summary>
        public double Subtotal { get
            {
                double sub = 0;
                foreach(IOrderItem e in items)
                {
                    sub += e.Price;
                }
                return sub;
            } }

        public double Total { get
            {
                double total = Subtotal * 1.16;
                return total;
            } }

        /// <summary>
        /// Keeps track of the last number that was used for order number
        /// </summary>
        private static uint lastOrderNumber;

        /// <summary>
        /// Gets random number to order from
        /// </summary>
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
            
                
                
            
                
            
        /// <summary>
        /// A list of food items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// the items list as an array
        /// </summary>
        public IEnumerable<IOrderItem> Items { get { return items.ToArray(); } }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            if(item is INotifyPropertyChanged pcitem)pcitem.PropertyChanged += OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
           
        }
        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            if (item is INotifyPropertyChanged pcitem) pcitem.PropertyChanged -= OnItemChanged;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

        }

        private void OnItemChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));

            }
        }

    }
}
