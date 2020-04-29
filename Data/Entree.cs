/* Author: Cole Griem
 * Class: Entree
 * Purpose: Base class for Entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree:IOrderItem
    {

        public abstract double Price { get; }
        public abstract uint Calories { get; }
        public abstract List<string> SpecialInstructions { get; }
        public virtual string ItemType { get { return "Entree"; } }
    }
}
