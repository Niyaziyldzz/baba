using System;

namespace xquant.Models
{
    public class Medicines
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }

        public decimal UnitPrice { get; set; }
        public int Discount { get; set; }

        public DateTime ExpDate { get; set; }

        public string ImageUrl { get; set; }

        public int Status { get; set; }

    }
}
