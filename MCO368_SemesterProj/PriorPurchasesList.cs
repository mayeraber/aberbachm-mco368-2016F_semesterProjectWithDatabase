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
    public partial class PriorPurchasesList : Form
    {
        private IEnumerable<Purchase> purchases;
        public PriorPurchasesList(IEnumerable<Purchase> purchases )
        {
            //this.purchases = purchases;
            InitializeComponent();
            //listView1.View=View.Details;
            listView1.Columns.Add("Product", 60);
            listView1.Columns.Add("Quantity", 65);
            listView1.Columns.Add("Total Price", 70);
            listView1.Columns.Add("Date Purchased", 150);
            string[] array= new string[4];
            foreach (var purchase in purchases)
            {
                array[0] = purchase.ProdPurchased.ProdName;
                array[1] = purchase.Quantity.ToString();
                array[2]= purchase.TotalPrice().ToString();
                array[3]= purchase.DatePurchased.ToString();
                listView1.Items.Add(new ListViewItem(array));
            }
           /* foreach (var purchase in purchases)
            {
                listView1.Items.Add(new ListViewItem(purchase.ToString()));
            }*/
        }

        private void PriorPurchasesList_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
