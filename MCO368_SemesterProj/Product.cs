using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class Product
    {
        public double Price { get; set; }
        public string ProdName { get; }

        public Product(string prodNam, double pric)
        {
            ProdName = prodNam;
            Price = pric;
        }
    }
}
