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
    public partial class HistoryByDate : Form
    {
        private Form priorPurchases;
        private User user;
        public HistoryByDate(Form priorPurch,User user)
        {
            InitializeComponent();
            priorPurchases = priorPurch;
            this.user = user;
        }

        private void To_Label_Click(object sender, EventArgs e)
        {

        }

        private void HistoryByDate_Load(object sender, EventArgs e)
        {

        }

        private void ByDate_button_Click(object sender, EventArgs e)
        {
            var startDate = monthCalendar1.SelectionRange.Start;
            var endDate = monthCalendar1.SelectionRange.End;
            var prods = user.getPurchases().Where(p => p.DatePurchased >= startDate && p.DatePurchased <= endDate);
            Form f1= new PriorPurchasesList(prods);
            f1.Visible = true;
            this.Close();
            /*foreach (var product in prods)
            {
                listBox1.Items.Add(product.ProdPurchased + " " + product.DatePurchased);//.ToString());
            }*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}