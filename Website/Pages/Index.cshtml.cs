using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;


namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// The Search term
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// Checks if there are any sides in the item list
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public bool EntreeCheck { get; set; } = false;

        /// <summary>
        /// Checks if there are any sides in the item list
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public bool SideCheck { get; set; } = false;

        /// <summary>
        /// Checks if there are any drinks in the item list
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public bool DrinkCheck { get; set; } = false;

        /// <summary>
        /// items list that can be edited
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public IEnumerable<IOrderItem> items { get; protected set; }

        /// <summary>
        /// categories items can fall under
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] itemType { get; set; }

        /// <summary>
        /// price min range
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? CMin { get; set; }

        /// <summary>
        /// price max range
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? CMax { get; set; }

        /// <summary>
        /// Price min range
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PMin { get; set; }

        /// <summary>
        /// Price max range
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PMax { get; set; }

        /// <summary>
        /// Lets you search for new items
        /// </summary>
        /// <param name="CMin"> Calories min </param>
        /// <param name="CMax"> Calories max </param>
        /// <param name="PMin"> Price min </param>
        /// <param name="PMax"> Price max</param>
        public void OnGet()
        {
            

            items = Menu.All;
            if(SearchTerms != null)
            {
                items = items.Where(items => items.ToString() != null && items.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));
            }
            if(itemType != null && itemType.Length != 0)
            {
                items = items.Where(items => items.ItemType != null && itemType.Contains(items.ItemType));
            }
            if(CMax != null && CMin != null)
            {
                if(CMin == null)
                {
                    items = items.Where(items => items.Calories <= CMax);
                }
                else if(CMax == null)
                {
                    items = items.Where(items => items.Calories >= CMin);
                }
                else
                {
                    items = items.Where(items => items.Calories <= CMax && items.Calories >= CMin);
                }
            }
            if(PMin != null && PMax != null)
            {
                if(PMin == null)
                {
                    items = items.Where(items => items.Price <= PMax);
                }
                else if(PMax == null)
                {
                    items = items.Where(items => items.Price >= PMin);
                }
                else
                {
                    items = items.Where(items => items.Price <= PMax && items.Price >= PMin);
                }
                
            }
        }
    }
}
