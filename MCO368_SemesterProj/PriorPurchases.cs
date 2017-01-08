using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace MCO368_SemesterProj
{
    public partial class PriorPurchases : Form
    {
        private User user;
        public PriorPurchases(User us)
        {
            InitializeComponent();
            user = us;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new PriorPurchasesList(user.getPurchases());
            f1.Visible = true;
            this.Close();
            
            //purchasesList.Visible = true;
           // foreach (var purchase in user.getPurchases())
              
                    //  purchasesList.Items.Add(purchase.ProdPurchased.ProdName+purchase.DatePurchased);
        }

        private void PriorPurchases_Load(object sender, EventArgs e)
        {
           
        }

        private void Date_Range_Click(object sender, EventArgs e)
        {
            Form f1 = new HistoryByDate(this,user);
            f1.Visible = true;
            Visible = false;
        }

        private void Price_Range_Click(object sender, EventArgs e)
        {
            Form f1 = new HistoryByPrice(user);
            f1.Visible = true;
            Visible = false;
        }
    }
}
