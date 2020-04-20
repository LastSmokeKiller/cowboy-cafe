using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Helps create the menu for the web interface
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// creates an entree list
        /// </summary>
        private static List<IOrderItem> entrees = new List<IOrderItem>();

        /// <summary>
        /// Gets the list for the Entrees
        /// </summary>
        /// <returns>Entrees IEnumerable</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            var temp = new List<IOrderItem>();
            temp.Add(new AngryChicken());
            temp.Add(new CowpokeChili());
            temp.Add(new DakotaDoubleBurger());
            temp.Add(new PecosPulledPork());
            temp.Add(new RustlersRibs());
            temp.Add(new TexasTripleBurger());
            temp.Add(new TrailBurger());
            entrees = temp;
            return entrees;
        }

        /// <summary>
        /// gets entree items for the web interface
        /// </summary>
        public static IEnumerable<IOrderItem> AllEntrees { get { return entrees; } }

        /// <summary>
        /// creates a sides list
        /// </summary>
        private static List<IOrderItem> sides = new List<IOrderItem>();

        /// <summary>
        /// Gets List for Sides
        /// </summary>
        /// <returns> sides IEnumerable</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            var temp = new List<IOrderItem>();
            temp.Add(new BakedBeans());
            temp.Add(new ChiliCheeseFries());
            temp.Add(new CornDodgers());
            temp.Add(new PanDeCampo());
            sides = temp;
            return sides;
        }

        /// <summary>
        /// gets drink for web interface
        /// </summary>
        public static IEnumerable<IOrderItem> AllSides { get { return sides; } }

        /// <summary>
        /// creates a drinks list
        /// </summary>
        private static List<IOrderItem> drinks = new List<IOrderItem>();

        /// <summary>
        /// gets list for drinks
        /// </summary>
        /// <returns> drinks IEnumerable</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            var temp = new List<IOrderItem>();
            temp.Add(new JerkedSoda());
            temp.Add(new CowboyCoffee());
            temp.Add(new TexasTea());
            temp.Add(new Water());
            drinks = temp;
            return drinks;
        }
        
        /// <summary>
        /// Gets the drinks for the web interface
        /// </summary>
        public static IEnumerable<IOrderItem> AllDrinks { get { return drinks; } }

        /// <summary>
        /// Creates a list for the entire menu
        /// </summary>
        private static List<IOrderItem> menu = new List<IOrderItem>();

        /// <summary>
        /// gets list for all menu items
        /// </summary>
        /// <returns> The complete menu </returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            var temp = new List<IOrderItem>();
            foreach(IOrderItem i in entrees)
            {
                temp.Add(i);
            }
            foreach(IOrderItem i in sides)
            {
                temp.Add(i);
            }
            foreach(IOrderItem i in drinks)
            {
                temp.Add(i);
            }
            menu = temp;
            return menu;
        }

        /// <summary>
        /// Returns the whole menu
        /// </summary>
        public static IEnumerable<IOrderItem> All { get { return menu; } }

        /// <summary>
        /// static method that sets up the entrees, sides, drinks, and complete menu item
        /// </summary>
        static Menu()
        {
            Entrees();
            Sides();
            Drinks();
            CompleteMenu();
        }

    }
}
