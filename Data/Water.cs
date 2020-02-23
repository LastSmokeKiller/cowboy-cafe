/* Author: Cole Griem
 * Class: Water
 * Purpose: A cheap drink that rehydrates you
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class for the Drink of Water
    /// </summary>
    public class Water : Drink
    {
        /// <summary>
        /// Checks if you want a lemon in your water
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Checks how much the water costs
        /// </summary>
        public override double Price
        {
            get { return .12; }
        }

        /// <summary>
        /// Checks how many of zero calories are in your water
        /// </summary>
        public override uint Calories
        {
            get { return 0; }
        }

        /// <summary>
        /// Checks if there are any special instructions for your water
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
        /// Prints the drink and size
        /// </summary>
        /// <returns> size and water </returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Water";
        }
    }
}
