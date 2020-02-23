using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken:Entree
    {
        /// <summary>
        /// A class representing the Angry Chicken entree
        /// </summary>
        private bool bread = true;
        /// <summary>
        /// If the Angry Chicken is served with Bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// if the Angry Chicken has pickles on it
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// The price of the Angry Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The amount of calories in the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
            
        }

        /// <summary>
        /// Special instructions for how to prepare the Angry Chicken
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
        /// <returns>Angry Chicken</returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
