using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Corn Dodgers side
    /// </summary>
    public class CornDodgers:Side
    {
        /// <summary>
        /// The Calories in each size of the CD
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException();

                }
            }
        }
        /// <summary>
        /// The price of each size of the CD
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException();

                }
            }
        }

        /// <summary>
        /// Prints correct term
        /// </summary>
        /// <returns> string</returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Corn Dodgers";
        }
    }
}
