using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The class for the Jerked Soda Drink
    /// </summary>
    public class JerkedSoda:Drink
    {

        /// <summary>
        /// Checks what flavor you want your soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Checks the price for the Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 2.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// Checks how many calories are in the soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 198;
                    case Size.Medium:
                        return 146;
                    case Size.Small:
                        return 110;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Sees if you have any requests on your soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }
    }
}
