using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class Product
    {
        //public int id { get; set; }
        
       // [Key]
       public int Id { get; set; }
        public string ProdName { get; set; }
        public double Price { get; set; }
        //public virtual Product Produc { get; set; }
        public Product(string prodNam, double pric)
        {
            ProdName = prodNam;
            Price = pric;
        }
    }
}
