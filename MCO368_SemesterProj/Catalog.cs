using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCO368_SemesterProj
{
    public partial class Catalog : Form
    {
        private Store store;
        private User user;

        public Catalog(Store st, User us)
        {
            InitializeComponent();
            store = st;
            user = us;
           // listBox1.Items.Add("Item   Price");
            foreach (var prod in store.getProducts())
                listBox1.Items.Add(prod.ProdName);//+("  $"+prod.Price));
        }

        private void listBox1_Load(object sender, EventArgs e)
        {
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalAmount.Text = "$ " + (store.getProduct(listBox1.Text).Price * ((int)numericUpDown1.Value));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (user.Balance > 1500)
            {
                MessageBox.Show("Your balance is: " + user.Balance +
                                " It exceeds the $1500 limit. Please submit a payment to continue shopping.");
                Close();
            }
            else
            {
                MessageBox.Show(listBox1.Text);
                Product selected = store.getProduct(listBox1.Text);
                Purchase purchase = new Purchase(selected, (int) numericUpDown1.Value, DateTime.Now);
                user.addPurchase(purchase);
                Close();
                //MessageBox.Show("" + purchase.ProdPurchased.ProdName + " " + purchase.ProdPurchased.Price + " " + store.getUser(user.Username).Balance);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            totalAmount.Text = "$ " + (store.getProduct(listBox1.Text).Price* ((int)numericUpDown1.Value));
        }

        private void Catalog_Load(object sender, EventArgs e)
        {

        }
    }
}
