namespace Semafor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Tick += semafor1.LightSemaphore;

            semafor2.DataBindings.Add(nameof(semafor2.SuccessColor), semafor1, nameof(semafor1.SuccessColor));
            semafor2.DataBindings.Add(nameof(semafor2.WarningColor), semafor1, nameof(semafor1.WarningColor));
            semafor2.DataBindings.Add(nameof(semafor2.DangerColor), semafor1, nameof(semafor1.DangerColor));
        }

        private void button1_Click(object sender, EventArgs e) => timer1.Enabled = !timer1.Enabled;
    }
}