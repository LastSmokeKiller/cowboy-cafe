/* Author: Cole Griem
 *  Class: Cowboy Coffee
 *  Purpose: A class for some coffee
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// This is the Class for the Cowboy Coffee Drink
    /// </summary>
    public class CowboyCoffee:Drink
    {
        /// <summary>
        /// This checks if there is room for cream and is defaulted to false
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// This checks if you want an iced coffee
        /// </summary>
        public override bool Ice { get; set; } = false;
        
        /// <summary>
        /// This checks if you actually want a good coffee, automatically set to give you a real coffee
        /// </summary>
        public bool Decaf { get; set; } = false;


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
                        return 1.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Small:
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
        /// <returns> the drink with its size and if its decaf </returns>
        public override string ToString()
        {
            if (this.Decaf) return this.Size.ToString() + " Decaf Cowboy Coffee";
            else return this.Size.ToString() + " Cowboy Coffee";
        }
    }
}
