using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // key
using System.ComponentModel.DataAnnotations.Schema; // Foriegn key
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SerialNumber { get; set; }
        public int Price { get; set; }
        public int Rating { get; set; }

        [ForeignKey("Seller")]
        public int SellerId { get; set; }

        [ForeignKey("Product_Category")]
        public int CategoryID { get; set; }

    }
}
