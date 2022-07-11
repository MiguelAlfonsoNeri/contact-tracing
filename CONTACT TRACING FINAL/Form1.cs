using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CONTACT_TRACING_FINAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsubmit_Click(object sender, EventArgs e)
        {

            StreamWriter file = new StreamWriter(@"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\" + datelbl.Text + ".txt", true);
            file.WriteLine("First Name:" + fntxbx.Text);
            file.WriteLine("Second Name:" + mntxbx.Text);
            file.WriteLine("Last Name:" + lntxbx.Text);
            file.WriteLine("Age:" + agetxbx.Text);
            file.WriteLine("Birthday:" + bdaytxbx.Text);
            file.WriteLine("Gender:" + gendertxbx.Text);
            file.WriteLine("Address:" + addresstxbx.Text);
            file.WriteLine("Contact:" + contactnotxbx.Text);
            file.WriteLine("Email:" + emailtxbx.Text);
            file.WriteLine("Experiencing or experienced the following symptoms?:" + q1txbx.Text);
            file.WriteLine("If yes, specify the date when these symptoms started:" + q2txbx.Text);
            file.WriteLine("Exposed with someone positive:" + q3txbx.Text);
            file.WriteLine("fully-vaccinated:" + q4txbx.Text);
            file.WriteLine("");
            file.Flush();
            file.Close();

            fntxbx.Text = "";
            mntxbx.Text = "";
            lntxbx.Text = "";
            agetxbx.Text = "";
            bdaytxbx.Text = "";
            gendertxbx.Text = "";
            emailtxbx.Text = "";
            q1txbx.Text = "";
            q2txbx.Text = "";
            q3txbx.Text = "";
            q4txbx.Text = "";
            MessageBox.Show("Your response has been recorded, thanks for filling out!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            reeltimelbl.Text = DateTime.Now.ToLongTimeString();
            datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            if (usernametxbx.Text == "admin" && passtxbx.Text == "migo")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Show();

                usernametxbx.Text = "";
                passtxbx.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect Credentials!");
            }
        }
    }
}
