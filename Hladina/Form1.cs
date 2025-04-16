namespace Hladina
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            static void handler(string msg) => MessageBox.Show(msg);
            nadrz1.Naplneno += handler;
            nadrz1.Vypusteno += handler;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nadrz1.NadrzJePlna)
            {
                nadrz1.Vypust();
            }
            else if (nadrz1.NadrzJePrazdna)
            {
                nadrz1.Napust();
            }
        }
    }
}