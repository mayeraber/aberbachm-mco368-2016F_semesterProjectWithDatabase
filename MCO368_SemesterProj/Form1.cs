using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Application;
using System.Data.Entity;

namespace MCO368_SemesterProj
{
    public partial class Form1 : Form
    {
        private Store store;
      
        private List<Product> products ;//= new List<Product>
     
        public Form1(List<Product> products )
        {
            using (var ctx = new StoreContext())
            {
                Product item1 = new Product("Item9", 100);
                Product item2 = new Product("Item2", 200);
                Product item3 = new Product("Item3", 300);
                Product item4 = new Product("Item4", 400);
                ctx.Products.Add(item1);
                ctx.Products.Add(item2);
                ctx.Products.Add(item3);
                ctx.Products.Add(item4);
                ctx.SaveChanges();

                User u1 = new User("John", "Doe", 400,
                    new List<Purchase>() {new Purchase(item1, 2), new Purchase(item2, 3)});
                User u2 = new User("Mayer", "347", 500,
                    new List<Purchase>() {new Purchase(item3, 2), new Purchase(item2, 3)});

                ctx.Users.Add(u1);
                ctx.Users.Add(u2);
                //ctx.SaveChanges();
            }

            InitializeComponent();
            //this.products = products;
           /* List<User> users = new List<User>
            {
            new User("John", "Doe",400 , new List<Purchase>() {new Purchase(item3,2), new Purchase(item2,3)}),
            new User("Mayer", "347", 500,  new List<Purchase>() {new Purchase(item3,2), new Purchase(item2,3)})
            };*/
            //put this in the 'using'
            //store = new Store(users, products);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void PasswordLabel_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            using (var ctx = new StoreContext())
            {
                //var user = ctx.Users.First(u=>u.Username.Equals(userEntry.Text));
                var user = ctx.Users.Find(userEntry.Text);
                //User user = store.getUser(userEntry.Text);
                if (user == null)
                {
                    MessageBox.Show("Invalid Username");
                    userEntry.Clear();
                    passwordEntry.Clear();
                }
                if (user != null)
                {
                    string pass = user.Password;
                    if (ctx.Users.Find(userEntry.Text).Password==pass)
                    {
                        Form f2 = new MainMenu(user, store);
                        f2.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password\nTry again");
                        passwordEntry.Clear();
                    }
                }
            }
        }

        private void passwordEntry_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}