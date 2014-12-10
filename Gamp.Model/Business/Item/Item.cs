using System;

namespace Gamp.Model.Business.Item
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double SellingPrice { get; set; }
        public double Discount { get; set; }
        public DateTime PromoStartDate { get; set; }
        public DateTime PromoEndDate { get; set; }
    }
}