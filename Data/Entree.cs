/* Author: Cole Griem
 * Class: Entree
 * Purpose: Base class for Entrees
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {

        public abstract double Price { get; }
        public abstract uint Calories { get; }
        public abstract List<string> SpecialInstructions { get; }
    }
}
