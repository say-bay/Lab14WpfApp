using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp
{
    public enum productCategories
    {
        Food,
        Technic
    }
    public class Product
    {
        public string productName { get; set; }
        public int productPrice { get; set; }
        public string productImage { get; set; }
        public productCategories productCategory { get; set; }

        public override string ToString()
        {
            return productName;
        }
    }
}
