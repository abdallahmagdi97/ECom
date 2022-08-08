using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models
{
    public class Product_category
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Product")]
        public int ProductID { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
    }
}
