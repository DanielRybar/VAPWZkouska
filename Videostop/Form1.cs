using Videostop.Models;

namespace Videostop
{
    public partial class Form1 : Form
    {
        private BindingSource bindingSource = new BindingSource();
        private readonly Random _rand = new();
        private readonly byte[] _numbers = [1, 2, 3];
        private List<Hrac> _hraci = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            var value = (sender as TrackBar).Value;
            timer1.Interval = value;
            label4.Text = value.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = _numbers[_rand.Next(0, _numbers.Length)].ToString();
            label2.Text = _numbers[_rand.Next(0, _numbers.Length)].ToString();
            label3.Text = _numbers[_rand.Next(0, _numbers.Length)].ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = _hraci;
            listBox1.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var input = textBox1.Text;
            if (!(int.TryParse(input, out var pocet)) || pocet <= 0)
            {
                MessageBox.Show("Zadejte validni hodnotu!");
                return;
            }
            else
            {
                for (int i = 0; i < pocet; i++)
                {
                    var novyIndex = i + 1;
                    var hr = new Hrac() { Jmeno = $"Hráè ({novyIndex})" };
                    Form f = new Form2(hr, bindingSource) { Text = $"Formuláø - {novyIndex}" };
                    _hraci.Add(hr);
                    f.Show();
                }
                bindingSource.ResetBindings(false);
            }
        }
    }
}