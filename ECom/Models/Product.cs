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
<<<<<<< HEAD
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

=======
        public int Id { get; set; }
        public string Name { get; set; }
        public int Serial { get; set; }
        public int MyProperty { get; set; }
>>>>>>> f80889a6a8e2ce6c6bde131f80699e0b84ff4a3f
    }
}
