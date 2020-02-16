using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        public bool Lemon { get; set; } = false;

        public override bool Ice { get; set; } = true;

        public override double Price
        {
            get { return .12; }
        }

        public override uint Calories
        {
            get { return 0; }
        }

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

    }
}
