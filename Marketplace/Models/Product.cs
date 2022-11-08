using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceFactory.Models
{
    public class Product
    {
        public int time1 { get; set; }
        public int time2 { get; set; }
        public int dist { get; set; }
        public int id { get; set; }
        public int root { get; set; }
        public int kindId { get; set; }
        public int subjectId { get; set; }
        public int subjectParentId { get; set; }
        public string? name { get; set; }
        public string? brand { get; set; }
        public int brandId { get; set; }
        public int siteBrandId { get; set; }
        public int sale { get; set; }
        public int priceU { get; set; }
        public int salePriceU { get; set; }
        public int averagePrice { get; set; }
        public int benefit { get; set; }
        public int pics { get; set; }
        public int rating { get; set; }
        public int feedbacks { get; set; }
        public int panelPromoId { get; set; }
        public string? promoTextCat { get; set; }
        public IEnumerable<Color>? colors { get; set; }
        public IEnumerable<Size>? sizes { get; set; }
        public bool diffPrice { get; set; }
    }
}
