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
    public partial class AcountBalance : Form
    {
        private User user;
        public AcountBalance(User user)
        {
            this.user= user;
            InitializeComponent();
            label1.Text = ("" + user.Username);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text=("aaaa"+user.Balance);
            Refresh();
        }
    }
}