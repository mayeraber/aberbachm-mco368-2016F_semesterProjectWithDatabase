using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public List<Purchase> purchases { get; set; }
        //private List<Purchase> purchases;
        //private readonly string password;
        //public string Password => password;
        //public string Username => username;
        //private readonly string username;
        public User()
        {
            
        }
        public User(string user, string pass, double bal)
        {
            Username = user;
            Password = pass;
            Balance = bal;
            purchases= new List<Purchase>();
        }
        public User(string user, string pass, double bal, List<Purchase> purch )
        {
            Username = user;
            Password = pass;
            Balance = bal;
            purchases = purch;
        }
       
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
