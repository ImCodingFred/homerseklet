namespace homerseklet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void adatokRögzítéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdatokFrm adatok = new AdatokFrm();
            adatok.ShowDialog();
        }

        private void statisztikaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stat statfrm = new stat();
            statfrm.ShowDialog();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
