namespace Contact_Tracing_Project
{
    public partial class CovidPatientlbl : Form
    {
        public CovidPatientlbl()
        {
            InitializeComponent();
        }

        private void bnSub_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\" + datelbl.Text + ".txt", true);
    
            file.WriteLine("First Name:" + Pfntxbx.Text);
            file.WriteLine("Second Name:" + Pmntxbx.Text);
            file.WriteLine("Last Name:" + Plntxbx.Text);
            file.WriteLine("Age:" + Pagetxbx.Text);
            file.WriteLine("Birthday");
            file.WriteLine("month:" + Pmbday.Text);
            file.WriteLine("day:" + Pdbday.Text);
            file.WriteLine("year:" + Pybday.Text);
            file.WriteLine("Gender:" + Pgendertxbx.Text);
            file.WriteLine("Address:");
            file.WriteLine("street:" + streettxbx.Text);
            file.WriteLine("barangay:" + brngytxbx.Text);
            file.WriteLine("House Number:" + hntxbx.Text);
            file.WriteLine("Lot:" + lottxbx.Text);
            file.WriteLine("Municipality:" + munitxbx.Text);
            file.WriteLine("Block:" + textBox1.Text);
            file.WriteLine("Contact:" + C1txbx.Text);
            file.WriteLine("Email:" + emailtxbx.Text);
            file.WriteLine("Experiencing or experienced the following symptoms?:" + symptompstxbx.Text);
            file.WriteLine("If yes, specify the date when these symptoms started:");
            file.WriteLine("month:" + symmonth.Text);
            file.WriteLine("day:" + sympday.Text);
            file.WriteLine("year:" + sympyear.Text);
            file.WriteLine("Exposed with someone positive:" + exposedtxbx.Text);
            file.WriteLine("fully-vaccinated:" + vaccinatedtxbx.Text);
            file.WriteLine("");
            file.Flush();
            file.Close();

            Pfntxbx.Text = "";
            Pmntxbx.Text = "";
            Plntxbx.Text = "";
            Pagetxbx.Text = "";
            Pmbday.Text = "";
            Pdbday.Text = "";
            Pybday.Text = "";
            Pgendertxbx.Text = "";
            streettxbx.Text = "";
            brngytxbx.Text = "";
            hntxbx.Text = "";
            lottxbx.Text = "";
            textBox1.Text = "";
            munitxbx.Text = "";
            C1txbx.Text = "";
            emailtxbx.Text = "";
            symptompstxbx.Text = "";
            exposedtxbx.Text = "";
            symmonth.Text = "";
            sympday.Text = "";
            sympyear.Text = "";
            exposedtxbx.Text = "";
            vaccinatedtxbx.Text = "";
            MessageBox.Show("Your response has been recorded, thanks for filling out!");

        }
        private void showbtn_Click_1(object sender, EventArgs e)
        {
            if (usernametb.Text == "admin" && passtb.Text == "migo")
            {
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
                this.Show();

                usernametb.Text = "";
                passtb.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect Credentials!");
            }
        }

        private void CovidPatientlbl_Load(object sender, EventArgs e)
        {
            datetimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           reeltimelbl.Text = DateTime.Now.ToLongTimeString();
           datelbl.Text = DateTime.Now.ToLongDateString();
        }

        private void btnqr_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }
    }
}