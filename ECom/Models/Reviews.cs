using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECom.Models
{
    public class Reviews
    {
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string comment { get; set; }
        public int rate { get; set; }

    }
}
