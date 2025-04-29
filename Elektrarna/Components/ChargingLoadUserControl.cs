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
    public partial class ChargingLoadUserControl : UserControl
    {
        private ChargingLoad _load;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public ChargingLoad Load
        {
            get => _load;
            set
            {
                _load = value;
                if (_load is not null)
                {
                    _load.ChargingStateChanged += ChargingStateChanged;
                }
            }
        }

        private void ChargingStateChanged(object? sender, float e)
        {
            this.Invoke(() =>
            {
                label1.Text = $"{(e * 100).ToString("0.0")}%";
                panel2.Height = (int)(e * (panel1.Height - 2 * panel2.Margin.Bottom));
            });
        }

        public ChargingLoadUserControl()
        {
            InitializeComponent();
        }
    }
}
