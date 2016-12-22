using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class User
    {
        private readonly string username=null;
        private readonly string password;
        private double balance;
        private IEnumerable<Purchase> purchases;

        public User(string user, string pass, double bal)
        {
            username = user;
            password = pass;
            balance = bal;
        }
        public double Balance { get; set; }
        public string Username => username;
        public string Password => password;
    }
}
