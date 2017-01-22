using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class Purchase
    {
        public int id { get; set; }
        public DateTime DatePurchased { get; set; }
        public Product ProdPurchased { get; set; }
        public int Quantity { get; set; }

        public double TotalPrice()
        {
            return ProdPurchased.Price*Quantity;
        }

        public Purchase(Product prod, int quant)
        {
            ProdPurchased = prod;
            Quantity = quant;
            DatePurchased = DateTime.Now;
        }

        public Purchase(Product prod, int quant, DateTime dt)
        {
            ProdPurchased = prod;
            Quantity = quant;
            DatePurchased = dt;
        }
        
        public override string ToString()
        {
            return ProdPurchased.ProdName + " " + Quantity + " " + TotalPrice();
        }
    }
}
