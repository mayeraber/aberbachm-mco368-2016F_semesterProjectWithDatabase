using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    class Purchase
    {
        private DateTime datePurchased;
        private IEnumerable<Product> prodsPurchased;

        public IEnumerable<Product> ProdsPurchased { get; set; }
    }
}
