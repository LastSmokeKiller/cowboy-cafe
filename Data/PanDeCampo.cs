/* Author: Cole Griem
 * Class: PanDeCampo
 * Purpose: I'm not really sure what this item is :/
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class PanDeCampo:Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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

        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Prints correct term with size
        /// </summary>
        /// <returns> string </returns>
        public override string ToString()
        {
            return this.Size.ToString() + " Pan de Campo";
        }
    }
}
