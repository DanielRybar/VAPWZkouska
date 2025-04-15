using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Semafor.Components
{
    public class Semaphore : TableLayoutPanel, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        private readonly Panel panel1;
        private readonly Panel panel2;
        private readonly Panel panel3;

        private Color successColor;
        private Color warningColor;
        private Color dangerColor;
        private readonly Color defaultColor = Properties.Colors.Default.DefaultColor;

        private byte counter = 0;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color SuccessColor
        {
            get => successColor;
            set
            {
                successColor = value;
                panel1.BackColor = value;
                OnPropertyChanged();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color WarningColor
        {
            get => warningColor;
            set
            {
                warningColor = value;
                panel2.BackColor = value;
                OnPropertyChanged();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Color DangerColor
        {
            get => dangerColor;
            set
            {
                dangerColor = value;
                panel3.BackColor = value;
                OnPropertyChanged();
            }
        }

        public Semaphore()
        {
            panel1 = new Panel() { Dock = DockStyle.Fill };
            panel2 = new Panel() { Dock = DockStyle.Fill };
            panel3 = new Panel() { Dock = DockStyle.Fill };

            ResetColors();

            this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.ColumnCount = 1;
            this.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            this.RowCount = 3;
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 33F));
            this.RowStyles.Add(new RowStyle(SizeType.Percent, 34F));
            this.Controls.Add(panel1, 0, 0);
            this.Controls.Add(panel2, 0, 1);
            this.Controls.Add(panel3, 0, 2);
        }

        private void ResetColors()
        {
            SuccessColor = defaultColor;
            WarningColor = defaultColor;
            DangerColor = defaultColor;
        }

        public void LightSemaphore(object? sender, EventArgs e)
        {
            switch (counter++)
            {
                case 0:
                    ResetColors();
                    SuccessColor = Properties.Colors.Default.SuccessColor;
                    break;
                case 1:
                    ResetColors();
                    WarningColor = Properties.Colors.Default.WarningColor;
                    break;
                case 2:
                    ResetColors();
                    DangerColor = Properties.Colors.Default.DangerColor;
                    counter = 0;
                    break;
            }
        }
    }
}