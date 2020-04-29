/* Author: Cole Griem
 * Class: IOrderItem.cs
 * Purpose: Allows Order class to access Order items
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Iterface for order items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// List of special instructions
        /// </summary>
        List<string> SpecialInstructions { get; }
        /// <summary>
        /// price of an item
        /// </summary>
        double Price { get; }

        uint Calories { get; }

        string ItemType { get; }

    }
}
