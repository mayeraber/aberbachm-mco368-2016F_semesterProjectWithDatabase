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

        private List<User> users = new List<User>
        {
            new User("John", "Doe",400 ),
            new User("Mayer", "347", 500)
        };

        private List<Product> products = new List<Product>
        {
            new Product("Item1", 100),
            new Product("Item2", 200)
        };


        public Form1()
        {
            InitializeComponent();
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
            }
        }
    }
}
