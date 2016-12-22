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
        public Catalog(Store st)
        {
            InitializeComponent();
            store = st;
            listBox1.Items.Add("setCons");
            listBox1.Items.Add(store.getUser("John"));

            //listBox1.Items.Add(store.getProducts().Select(p=>p.ProdName).First());
            foreach (var prod in store.getProducts())
                listBox1.Items.Add(prod.ProdName);
        }

        private void listBox1_Load(object sender, EventArgs e)
        {
            foreach (var prod in store.getProducts())
                listBox1.Items.Add(prod);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
