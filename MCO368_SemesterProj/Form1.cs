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

namespace MCO368_SemesterProj
{
    public partial class Form1 : Form
    {
        private Store store;
        Product item1= new Product("Item1",100);
        Product item2 = new Product("Item2", 200);
        Product item3 = new Product("Item3", 300);
        Product item4 = new Product("Item4", 400);
        /*List<User> users = new List<User>
        {
            new User("John", "Doe",400 , new List<Purchase>() {new Purchase(,2)}),
            new User("Mayer", "347", 500)
        };*/

        private List<Product> products ;//= new List<Product>
      /*  {
            new Product("Item1", 100),
            new Product("Item2", 200)
        };*/


        public Form1(List<Product> products )
        {
            InitializeComponent();
            //this.products = products;
            List<User> users = new List<User>
            {
            new User("John", "Doe",400 , new List<Purchase>() {new Purchase(item3,2), new Purchase(item2,3)}),
            new User("Mayer", "347", 500,  new List<Purchase>() {new Purchase(item3,2), new Purchase(item2,3)})
            };
            store = new Store(users, products);
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
            User user = store.getUser(userEntry.Text);
            if (user == null)
            {
                MessageBox.Show("Invalid Username");
                userEntry.Clear();
                passwordEntry.Clear();
            }
            if (user != null)
            {
                string pass = user.Password;
                if (passwordEntry.Text == pass)
                {
                    Form f2 = new MainMenu(user,store);
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

        private void passwordEntry_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
