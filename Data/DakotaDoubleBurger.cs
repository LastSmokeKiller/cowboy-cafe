using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger:Entree
    {
        /// <summary>
        /// The class representing the Dakota Double Burger entree
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// If Dakota has buns
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        private bool ketchup = true;
        /// <summary>
        /// If Dakota brought ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        private bool mustard = true;
        /// <summary>
        /// If Dakota didn't forget the mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        private bool pickle = true;
        /// <summary>
        /// If Dakota has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        private bool cheese = true;
        /// <summary>
        /// If Dakota has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool tomato = true;
        /// <summary>
        /// If Dakota has nicely sliced tomatos
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value; }
        }
        /// <summary>
        /// If Dakota has Lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If Dakota slapped some Mayo in there
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// How much you pay for Dakota
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// How much you pay for Dakota
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }


        /// <summary>
        /// How Dakota wants to be prepared
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                return instructions;
            }
        }

        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
