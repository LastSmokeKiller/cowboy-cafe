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
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// Checks if there are any sides in the item list
        /// </summary>
        public bool EntreeCheck { get; set; } = false;

        /// <summary>
        /// Checks if there are any sides in the item list
        /// </summary>
        public bool SideCheck { get; set; } = false;

        /// <summary>
        /// Checks if there are any drinks in the item list
        /// </summary>
        public bool DrinkCheck { get; set; } = false;

        /// <summary>
        /// items list that can be edited
        /// </summary>
        public IEnumerable<IOrderItem> items { get; protected set; }

        /// <summary>
        /// categories items can fall under
        /// </summary>
        public string[] itemType { get; set; }

        /// <summary>
        /// price min range
        /// </summary>
        public double? CMin { get; set; }

        /// <summary>
        /// price max range
        /// </summary>
        public double? CMax { get; set; }

        /// <summary>
        /// Price min range
        /// </summary>
        public double? PMin { get; set; }

        /// <summary>
        /// Price max range
        /// </summary>
        public double? PMax { get; set; }

        /// <summary>
        /// Lets you search for new items
        /// </summary>
        /// <param name="CMin"> Calories min </param>
        /// <param name="CMax"> Calories max </param>
        /// <param name="PMin"> Price min </param>
        /// <param name="PMax"> Price max</param>
        public void OnGet(double? CMin, double? CMax, double? PMin, double? PMax)
        {
            items = Menu.CompleteMenu();
            this.CMin = CMin;
            this.CMax = CMax;
            this.PMin = PMin;
            this.PMax = PMax;
            SearchTerms = Request.Query["SearchTerms"];
            itemType = Request.Query["itemType"];
            items = Menu.Search(items, SearchTerms);
            items = Menu.FilterByCategory(items, itemType);
            items = Menu.FilterByCalories(items, CMin, CMax);
            items = Menu.FilterByPrice(items, PMin, PMax);

        }
    }
}
