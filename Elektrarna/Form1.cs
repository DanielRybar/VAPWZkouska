using Elektrarna.Components;
using Elektrarna.Models;

namespace Elektrarna
{
    public partial class Form1 : Form
    {
        private Random _random = new Random();
        private PowerSource _ps = new PowerSource(200);
        //private ChargingLoad _cl1 = new ChargingLoad(50, 87, 25);
        //private ChargingLoad _cl2 = new ChargingLoad(22, 54, 11);
        public Form1()
        {
            InitializeComponent();

            //_ps.AttachLoad(_cl1);
            //_ps.AttachLoad(_cl2);

            powerSourceUserControl1.Source = _ps;
            //chargingLoadUserControl1.Load = _cl1;
            //chargingLoadUserControl2.Load = _cl2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var load = new ChargingLoad(
                10 + _random.NextInt64(80), 
                20 + _random.NextInt64(60), 
                _random.NextInt64(60));

            _ps.AttachLoad(load);

            var loadControl = new ChargingLoadUserControl
            {
                Dock = DockStyle.Top,
                Load = load
            };
            loadControl.Parent = flowLayoutPanel1;
            loadControl.Load = load;
        }
    }
}
