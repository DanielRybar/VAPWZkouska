using Elektrarna.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elektrarna.Components
{
    public partial class PowerSourceUserControl : UserControl
    {
        private PowerSource _source;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PowerSource Source 
        { 
            get => _source;
            set
            {
                _source = value;
                if (value != null)
                    timer1.Start();
                else
                    timer1.Stop();
            }
        }
        public PowerSourceUserControl()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = $"Power: {Source.PowerCapacityKw} kW";
            label2.Text = $"Consumed: {Source.PowerConsumedKwh.ToString("0000.0")} kWh";
            label3.Text = $"Loads: {Source.LoadCount}";
        }
    }
}
