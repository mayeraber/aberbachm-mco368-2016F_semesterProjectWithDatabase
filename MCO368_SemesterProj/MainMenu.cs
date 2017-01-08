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
    public partial class MainMenu : Form
    {
        private User user;
        private Store store;
        public MainMenu(User user,Store store)
        {
            this.user = user;
            this.store =store;
            InitializeComponent();
        }

        private void balance_Click(object sender, EventArgs e)
        {
            Form f1 = new AcountBalance(user);
            f1.Visible = true;
           // this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f1 = new Catalog(store,user);
            f1.Visible = true;
            //this.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f1 = new PriorPurchases(user);
            f1.Visible = true;
            //Visible = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
