namespace SemaforII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateControls();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            semaforUserControl1.Zapnuto = !semaforUserControl1.Zapnuto;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void UpdateControls()
        {
            semaforUserControl1.Interval = trackBar1.Value;
            label1.Text = semaforUserControl1.Interval.ToString();
        }
    }
}