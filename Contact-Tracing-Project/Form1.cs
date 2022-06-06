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
            file.WriteLine("");
            file.Close();

            Pnametxbx.Text = "";
            Pagetxbx.Text = "";
            Pbdaytxbx.Text = "";
            Pgendertxbx.Text = "";
            Paddrstxbx.Text = "";
            Pstarttxbx.Text = "";
            Pendtxbx.Text = "";

            n1txbx.Text = "";
            d1txbx.Text = "";
            Cbdaytxbx.Text = "";
            Cgendertxbx.Text = "";
            a1txbx.Text = "";
            Cstarttxbx.Text = "";
            Cendtxbx.Text = "";
            MessageBox.Show("Your response has been recorded, thanks for filling out!");
        }
    }
}