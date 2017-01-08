using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCO368_SemesterProj
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        static void Main()
        {
            Product item1 = new Product("Item1", 100);
            Product item2 = new Product("Item2", 200);
            Product item3 = new Product("Item3", 300);
            Product item4 = new Product("Item4", 400);
            List<Product> products= new List<Product>();
            products.Add(item1);
            products.Add(item2);
            products.Add(item3);
            products.Add(item4);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(products));
        }
    }
}
