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
    public partial class HistoryByPrice : Form
    {
        private User user;
        public HistoryByPrice(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void ByPrice_button_Click(object sender, EventArgs e)
        {
            double startPrice = Convert.ToDouble(textBox1.Text);
            double endPrice = Convert.ToDouble(textBox2.Text);
            var prods = user.getPurchases().Where(p => p.TotalPrice() >= startPrice && p.TotalPrice() <= endPrice);
            Form f1 = new PriorPurchasesList(prods);
            f1.Visible = true;
            this.Close();
        }
    }
}