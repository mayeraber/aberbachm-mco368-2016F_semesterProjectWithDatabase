using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class User
    {
        private readonly string username;
        private readonly string password;
        private List<Purchase> purchases;

        public User(string user, string pass, double bal)
        {
            username = user;
            password = pass;
            Balance = bal;
            purchases= new List<Purchase>();
        }
        public User(string user, string pass, double bal, List<Purchase> purch )
        {
            username = user;
            password = pass;
            Balance = bal;
            purchases = purch;
        }
        public double Balance { get ; set; }
        public string Username => username;
        public string Password => password;

        public void addPurchase(Purchase purchase)
        {
            Balance = Balance + purchase.TotalPrice();
            purchases.Add(purchase);
        }

        public IEnumerable<Purchase> getPurchases()
        {
            return purchases;
        }
    }
}
