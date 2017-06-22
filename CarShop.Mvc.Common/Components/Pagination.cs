using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CarShop.Mvc.Common.Components
{
    public class Pagination : ViewComponent
    {
        public IViewComponentResult Invoke(int total)
        {
            // Default to page 1 if no page number specified
            int page = 1;
            var query = HttpContext.Request.Query["page"];
            if (query.FirstOrDefault() != null)
            {
                // Try to get the page number from the query string
                int.TryParse(query.ToString(), out page);
            }

            var model = new PaginationModel
            {
                CurrentPage = page,
                NextPage = page + 1,
                PreviousPage = page - 1,
                TotalResults = total
            };

            return View(model);
        }
    }

    public class PaginationModel
    {
        public int CurrentPage { get; set; }
        public int TotalResults { get; set; }
        public int NextPage { get; set; }
        public int PreviousPage { get; set; }
    }
}
