using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionAutoMapVS2022
{
    public class Products
    {
        public int Id { get; set; }
        public int Stok { get; set; }
        public string ProductName { get; set; }
        public decimal Discount { get; set; }
    }
    public class ProductDTO
    {
        public int Stok { get; set; }
        public string ProductName { get; set; }
        public decimal Discount { get; set; }
    }
}

