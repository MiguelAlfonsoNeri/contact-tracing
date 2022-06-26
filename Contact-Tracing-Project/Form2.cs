using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dateFiles = Directory.GetFiles(@"C:\Users\Migo\OneDrive\Documents\Contact tracing");
            foreach (String file in dateFiles)
            {
                string dates = File.ReadAllText(file);

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            showtxbx.Text = "";
        }
    }
}
