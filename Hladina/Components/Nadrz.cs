using System.ComponentModel;

namespace Hladina.Components
{
    public class Nadrz : TableLayoutPanel
    {
        private int vyskaHladiny = 0;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int VyskaHladiny
        {
            get => vyskaHladiny;
            set
            {
                vyskaHladiny = value;
                voda.Height = value;
            }
        }
        private readonly Panel voda;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool NadrzJePlna { get; private set; } = false;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool NadrzJePrazdna { get; private set; } = true;
        public Nadrz()
        {
            voda = new Panel() { BackColor = Color.Blue, Height = VyskaHladiny, Dock = DockStyle.Bottom };
            this.ColumnCount = 1;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RowCount = 1;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            this.Controls.Add(voda, 0, 0);
            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
        }

        public event Action<string>? Naplneno;
        public event Action<string>? Vypusteno;

        public void Napust(int kolik = 10)
        {
            if (!NadrzJePlna)
            {
                VyskaHladiny += kolik;
                if (VyskaHladiny >= this.Height)
                {
                    VyskaHladiny = this.Height;
                    NadrzJePlna = true;
                    NadrzJePrazdna = false;
                    Naplneno?.Invoke("Nadrz je plna");
                }
            }
        }

        public void Vypust(int kolik = 10)
        {
            if (!NadrzJePrazdna)
            {
                VyskaHladiny -= kolik;
                if (VyskaHladiny <= 0)
                {
                    VyskaHladiny = 0;
                    NadrzJePrazdna = true;
                    NadrzJePlna = false;
                    Vypusteno?.Invoke("Nadrz je prazdna");
                }
            }
        }
    }
}