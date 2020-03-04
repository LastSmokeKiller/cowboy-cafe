using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// The Corn Dodgers side
    /// </summary>
    public class CornDodgers:Side, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

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
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.99;
                    case Size.Medium:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                        return 1.79;
                    case Size.Small:
                        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
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
