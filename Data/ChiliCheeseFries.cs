using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Chili Cheese Fries Side
    /// </summary>
    public class ChiliCheeseFries:Side
    {
        /// <summary>
        /// How many Calories are in each size of the CCF
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException();
                }
                
            } 
        }
        /// <summary>
        /// The price of each size of the CCF
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        public override string ToString()
        {
            return this.Size.ToString() + " Chili Cheese Fries";
        }
    }
}
