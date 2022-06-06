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
            file.WriteLine("Name:" + Pnametxbx.Text);
            file.WriteLine("Age:" + Pagetxbx.Text);
            file.WriteLine("Birthday:" + Pbdaytxbx.Text);
            file.WriteLine("Gender:" + Pgendertxbx.Text);
            file.WriteLine("Address:" + Paddrstxbx.Text);
            file.WriteLine("Start of contact:" + Pstarttxbx.Text);
            file.WriteLine("End of contact:" + Pendtxbx.Text);
            file.Close();
        }
    }
}