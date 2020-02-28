/* Author: Cole Griem
 * Class: Drink
 * Purpose: To set a base Drink class to be inherited from.
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink:IOrderItem
    {
        /// <summary>
        /// Gets an inherited size for any drink
        /// </summary>
        public virtual Size Size{get;set;}

        /// <summary>
        /// gets a price for any drink
        /// </summary>
        public abstract double Price {get;}

        /// <summary>
        /// Gets the calories for any drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Makes special instructions for any drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Sets if the 
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }
}
