using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Searches the a list of items for anything that matches the string
        /// </summary>
        /// <param name="items"> items list </param>
        /// <param name="term"> item to search </param>
        /// <returns> list with items in the search results </returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string term)
        {
            List<IOrderItem> results = new List<IOrderItem>();
            if (term == null) return items;
            foreach(IOrderItem item in items)
            {
                if(item.ToString() != null && item.ToString().Contains(term, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by what category the item falls in
        /// </summary>
        /// <param name="items"> items list</param>
        /// <param name="s"> categories to search </param>
        /// <returns> list with items in the category </returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> s)
        {
            if (s == null || s.Count() == 0) return items;
            List<IOrderItem> results = new List<IOrderItem>();
            foreach(IOrderItem item in items)
            {
                if(item.ItemType != null && s.Contains(item.ItemType))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by Calories max and min
        /// </summary>
        /// <param name="items"> items list </param>
        /// <param name="min"> minimum search number </param>
        /// <param name="max"> maximum search number </param>
        /// <returns> list with items in the number range </returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();
            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }
            foreach (IOrderItem item in items)
            {
                if (item.Calories >= min & item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by Price min and max
        /// </summary>
        /// <param name="items"> list of items </param>
        /// <param name="min"> min search number </param>
        /// <param name="max"> max search number </param>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;
            var results = new List<IOrderItem>();
            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }
            if(max == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }
            foreach(IOrderItem item in items)
            {
                if(item.Price >= min & item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// List of categories items can fall in
        /// </summary>
        public static string[] itemType
        {
            get => new string[]
            {
                "Entree",
                "Side",
                "Drink"
            };
        }
    }
}
