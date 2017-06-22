using System.Collections.Generic;

namespace CarShop.Mvc.Common.Models.Meta
{
    public class MetaTags
    {
        public string Description { get; set; }
        public string Keywords { get; set; }
        public string Title { get; set; }
        public string Language { get; set; }
        public List<string> ImageUrls { get; set; }
    }
}
