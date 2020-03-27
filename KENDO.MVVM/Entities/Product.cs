using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KENDO.MVVM.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
    }
}
