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
            label1.Text = user.Balance>=0?("Your current balance is: $"+ user.Balance):"You have a credit of: $"+user.Balance*-1;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // label1.Text=("aaaa"+user.Balance);
           // Refresh();
        }

        private void AcountBalance_Load(object sender, EventArgs e)
        {

        }

        private void pay_button_Click(object sender, EventArgs e)
        {
            user.Balance = user.Balance - Double.Parse(pay_Amount.Text);
            label1.Text = "Your balance has been credited with $" + pay_Amount.Text+"\n"+(user.Balance >= 0 ? ("Your current balance is: $" + user.Balance) : "You have a credit of: $" + user.Balance*-1);
          pay_Amount.Clear();
            
        }
    }
}