using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class that represents the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs
    {
       

        /// <summary>
        /// The price of the Rustler's Ribs
        /// </summary>
        public double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The amount of calories in the Rustler's Ribs
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// The Special Instructions on how to prepare the Rustler's Ribs, which is empty
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

    }
}
