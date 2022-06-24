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
            file.WriteLine("Email:" + emailtxbx.Text);
            file.WriteLine("Have you experiencing or experienced the following symptoms?:" + symptompstxbx.Text);
            file.WriteLine("If yes, specify the date when these symptoms started:");
            file.WriteLine("month:" + symmonth.Text);
            file.WriteLine("day:" + sympday.Text);
            file.WriteLine("year:" + sympyear.Text);
            file.WriteLine("Have you been with someone who has been exposed?:" + exposedtxbx.Text);
            file.WriteLine("Are you fully-vaccinated?:" + vaccinatedtxbx.Text);
            file.WriteLine("");
            file.WriteLine("Visitation Date:");
            file.WriteLine("month:" + monthvisittxbx.Text);
            file.WriteLine("day:" + dayvisittxbx.Text);
            file.WriteLine("year:" + yearvisittxbx.Text);
            file.Close();

            Pfntxbx.Text = "";
            Pagetxbx.Text = "";
            Pmbday.Text = "";
            Pgendertxbx.Text = "";
            streettxbx.Text = "";
            C1txbx.Text = "";
            emailtxbx.Text = "";
            symmonth.Text = "";
            sympday.Text = "";
            sympyear.Text = "";
            exposedtxbx.Text = "";
            vaccinatedtxbx.Text = "";
            monthvisittxbx.Text = "";
            dayvisittxbx.Text = "";
            yearvisittxbx.Text = "";
            MessageBox.Show("Your response has been recorded, thanks for filling out!");
        }
    }
}