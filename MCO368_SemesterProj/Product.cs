using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class Product
    {
        private string prodName;
        private double price;

        public Product(string prodName, double price)
        {
            ProdName = prodName;
            Price = price;
        }

        public string ProdName { get; set; }
        public  double Price { get; set; }
    
    }
}
