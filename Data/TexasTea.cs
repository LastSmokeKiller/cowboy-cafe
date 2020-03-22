/* Author: Cole Griem
 * Class: TexasTea
 * Purpose: A Tea drink that is either sweet or tastes bad
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class for the Texas Tea Drink
    /// </summary>
    public class TexasTea:Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;


        private bool lemon = false;
        /// <summary>
        /// Checks if you want to put a lemon in your tea
        /// </summary>
        public bool Lemon { get { return lemon; } set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool sweet = true;

        /// <summary>
        /// Checks if you want your tea to actually taste good with sugar or without sugar
        /// </summary>
        public bool Sweet { get { return sweet; } set {
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } } 

        /// <summary>
        /// Checks the price for the tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Small:
                        return 1.00;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Checks how many Calories are in your tea depending on if it is sweet or not
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 36;
                        case Size.Medium:
                            return 22;
                        case Size.Small:
                            return 10;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Large:
                            return 18;
                        case Size.Medium:
                            return 11;
                        case Size.Small:
                            return 5;
                        default:
                            throw new NotImplementedException();
                    }
                }
                
            }
        }

        /// <summary>
        /// Checks to see how you want your tea prepared
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Prints the tea's size and if it is sweet
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string sweet;
            if (this.Sweet) sweet = "Sweet";
            else sweet = "Plain";

            return this.Size.ToString() + " Texas " + sweet + " Tea";
        }
    }
}
