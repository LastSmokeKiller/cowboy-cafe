/* Author: Cole Griem
 * Class: JerkedSoda
 * Purpose: To allow a customer to order soda
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class for the Jerked Soda Drink
    /// </summary>
    public class JerkedSoda:Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private bool ice = true;

        /// <summary>
        /// This checks if you want ice in Soda
        /// </summary>
        public override bool Ice
        {
            get { return ice; }
            set
            {
                ice = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ice"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Checks what flavor you want your soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Checks the price for the Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// Checks how many calories are in the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Sees if you have any requests on your soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Gets what soda and size and prints
        /// </summary>
        /// <returns> string</returns>
        public override string ToString()
        {
            if (this.Flavor.ToString() == "OrangeSoda")
            {
                return this.Size.ToString() + " Orange Soda Jerked Soda";
            }
            else if (this.Flavor.ToString() == "CreamSoda") return this.Size.ToString() + " Cream Soda Jerked Soda";
            else if (this.Flavor.ToString() == "BirchBeer") return this.Size.ToString() + " Birch Beer Jerked Soda";
            else if (this.Flavor.ToString() == "RootBeer") return this.Size.ToString() + " Root Beer Jerked Soda";

            else return this.Size.ToString() + " " + this.Flavor.ToString() + " "  + "Jerked Soda";
        }


    }
}
