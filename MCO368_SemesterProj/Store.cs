﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCO368_SemesterProj
{
    public class Store
    {
        private IEnumerable<User> users;
        private IEnumerable<Product> products;

        public Store(IEnumerable<User> users, IEnumerable<Product> products)
        {
            this.users = new List<User>(users);
            this.products = new List<Product>();
        }

        public Store()
        {
            users = new List<User>();
            products = new List<Product>();
        }

        public User getUser(string userName)
        {
            if (users.Any(u => u.Username == userName))
                return users.FirstOrDefault(u => u.Username == userName);
            return null;
        }

        public IEnumerable<Product> getProducts()
        {
            return products;
        }
    }
}