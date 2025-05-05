using SemaforII.Models;
using System.ComponentModel;

namespace SemaforII.Components
{
    public partial class SemaforUserControl : UserControl
    {
        private readonly Semafor semafor = new();

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int Interval
        {
            get => timer1.Interval;
            set => timer1.Interval = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool Zapnuto
        {
            get => timer1.Enabled;
            set => timer1.Enabled = value;
        }
        public SemaforUserControl()
        {
            InitializeComponent();
            semafor.Zmeneno += Semafor_Zmeneno;
            timer1.Tick += (s, e) => semafor.Prepni();
        }

        private void Semafor_Zmeneno(bool[] obj)
        {
            panel1.BackColor = obj[0] ? Color.Red : Color.Transparent;
            panel2.BackColor = obj[1] ? Color.Orange : Color.Transparent;
            panel3.BackColor = obj[2] ? Color.Green : Color.Transparent;
        }
    }
}