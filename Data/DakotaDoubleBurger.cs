using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger:Entree,INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;
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
            set { bun = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bun"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool ketchup = true;
        /// <summary>
        /// If Dakota brought ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ketchup"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If Dakota didn't forget the mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mustard"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If Dakota has pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If Dakota has cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Cheese"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool tomato = true;
        /// <summary>
        /// If Dakota has nicely sliced tomatos
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set { tomato = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tomato"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
        private bool lettuce = true;
        /// <summary>
        /// If Dakota has Lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lettuce"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool mayo = true;

        /// <summary>
        /// If Dakota slapped some Mayo in there
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            {
                mayo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Mayo"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

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

        /// <summary>
        /// Prints correct term
        /// </summary>
        /// <returns>string </returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
