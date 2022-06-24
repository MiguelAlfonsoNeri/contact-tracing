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
            file.WriteLine("Name:" + Pfntxbx.Text);
            file.WriteLine("Age:" + Pagetxbx.Text);
            file.WriteLine("Birthday:" + Pmbday.Text);
            file.WriteLine("Gender:" + Pgendertxbx.Text);
            file.WriteLine("Address:" + streettxbx.Text);
            file.WriteLine("Contact:" + C1txbx.Text);
            file.WriteLine("");
            file.Close();
            MessageBox.Show("Your response has been recorded, thanks for filling out!");
        }
    }
}