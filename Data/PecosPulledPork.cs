/* Author: Cole Griem
 * Class: PecosPulledPork
 * Purpose: Smoked Pulled Pork for good ole fashioned BBQ
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork:Entree
    {
        /// <summary>
        /// The class that represents the Pecos Pulled Pork entree
        /// </summary>
        private bool bread = true;
        /// <summary>
        /// If Pecos has buns
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If Pecos has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// How much Pecos cost
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }
        
        /// <summary>
        /// The amount of Calories in Pecos
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// How to prepare Pecos
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }

        /// <summary>
        /// Prints correct term
        /// </summary>
        /// <returns> Pecos Pulled Pork </returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
