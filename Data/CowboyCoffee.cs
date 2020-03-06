/* Author: Cole Griem
 *  Class: Cowboy Coffee
 *  Purpose: A class for some coffee
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This is the Class for the Cowboy Coffee Drink
    /// </summary>
    public class CowboyCoffee:Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private bool roomForCream = false;
        /// <summary>
        /// This checks if there is room for cream and is defaulted to false
        /// </summary>
        public bool RoomForCream { get { return roomForCream; } set {
                roomForCream = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("RoomForCream"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } }

        private bool ice = false;

        /// <summary>
        /// This checks if you want an iced coffee
        /// </summary>
        public override bool Ice { get { return ice;} set { 
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } }

        private bool decaf = false;

        /// <summary>
        /// This checks if you actually want a good coffee, automatically set to give you a real coffee
        /// </summary>
        public bool Decaf { get { return decaf; } set {
                decaf = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Decaf"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } }


        /// <summary>
        /// This gets the price for the coffee 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.60;
                    case Size.Medium:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.10;
                    case Size.Small:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 0.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets how many calories are in your coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 7;
                    case Size.Medium:
                        return 5;
                    case Size.Small:
                        return 3;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Checks if there is any special requests on the peparation of your coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instr = new List<string>();
                if (Ice) instr.Add("Add Ice");
                if (RoomForCream) instr.Add("Room for Cream");
                return instr;
            }
        }

        /// <summary>
        /// Prints correct term with Decaf and size
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            if (this.Decaf) return this.Size.ToString() + " Decaf Cowboy Coffee";
            else return this.Size.ToString() + " Cowboy Coffee";
        }
    }
}
