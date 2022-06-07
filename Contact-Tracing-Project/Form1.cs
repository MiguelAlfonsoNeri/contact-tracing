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
            StreamWriter file = new StreamWriter(@"C:\Users\Migo\OneDrive\Documents\Contact tracing\test.txt", true);
            file.WriteLine("Personal Information");
            file.WriteLine("Name:" + Pnametxbx.Text);
            file.WriteLine("Age:" + Pagetxbx.Text);
            file.WriteLine("Birthday:" + Pbdaytxbx.Text);
            file.WriteLine("Gender:" + Pgendertxbx.Text);
            file.WriteLine("Address:" + Paddrstxbx.Text);
            file.WriteLine("Start of contact:" + Pstarttxbx.Text);
            file.WriteLine("End of contact:" + Pendtxbx.Text);
            file.WriteLine("Contact:" + C1txbx.Text);
            file.WriteLine("");
            file.WriteLine("List of people with contact exposure");
            file.WriteLine("Name:" + n1txbx.Text);
            file.WriteLine("Date Exposed:" + d1txbx.Text);
            file.WriteLine("Address:" + a1txbx.Text);
            file.WriteLine("Contact:" + C2txbx.Text);
            file.WriteLine("");
            file.WriteLine("Name:" + n2txbx.Text);
            file.WriteLine("Date Exposed:" + d2txbx.Text);
            file.WriteLine("Address:" + a2txbx.Text);
            file.WriteLine("Contact:" + C3txbx.Text);
            file.WriteLine("");
            file.WriteLine("Name:" + n3txbx.Text);
            file.WriteLine("Date Exposed:" + d3txbx.Text);
            file.WriteLine("Address:" + a3txbx.Text);
            file.WriteLine("Contact:" + C4txbx.Text);
            file.WriteLine("");
            file.WriteLine("Name:" + n4txbx.Text);
            file.WriteLine("Date Exposed:" + d4txbx.Text);
            file.WriteLine("Address:" + a4txbx.Text);
            file.WriteLine("Contact:" + C5txbx.Text);
            file.WriteLine("");
            file.WriteLine("Name:" + n5txbx.Text);
            file.WriteLine("Date Exposed:" + d5txbx.Text);
            file.WriteLine("Address:" + a5txbx.Text);
            file.WriteLine("Contact:" + C6txbx.Text);
            file.WriteLine("---------------");
            file.Close();

            Pnametxbx.Text = "";
            Pagetxbx.Text = "";
            Pbdaytxbx.Text = "";
            Pgendertxbx.Text = "";
            Paddrstxbx.Text = "";
            Pstarttxbx.Text = "";
            Pendtxbx.Text = "";
            C1txbx.Text = "";

            n1txbx.Text = "";
            d1txbx.Text = "";
            a1txbx.Text = "";
            C2txbx.Text = "";

            n2txbx.Text = "";
            d2txbx.Text = "";
            a2txbx.Text = "";
            C3txbx.Text = "";



            n3txbx.Text = "";
            d3txbx.Text = "";
            a3txbx.Text = "";
            C4txbx.Text = "";

            n4txbx.Text = "";
            d4txbx.Text = "";
            a4txbx.Text = "";
            C5txbx.Text = "";

            n5txbx.Text = "";
            d5txbx.Text = "";
            a5txbx.Text = "";
            C6txbx.Text = "";
            MessageBox.Show("Your response has been recorded, thanks for filling out!");
        }
    }
}