namespace PictureBoxDemo.Components
{
    public partial class PictureBoxUserControl : UserControl
    {
        private readonly Random _rand = new();
        private readonly Color[] _colors = [Color.Red, Color.Green, Color.Purple, Color.Gray, Color.Cyan];
        public PictureBoxUserControl()
        {
            InitializeComponent();
        }

        public void Redraw() => pictureBox1.Invalidate();

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // zde mam objekt predany jako parametr, neni dobre vytvaret novy
            using Pen pen = new(_colors[_rand.Next(0,_colors.Length)], _rand.Next(1,4));
            int wh = _rand.Next(1, this.Height);
            g.DrawEllipse(pen, _rand.Next(0,this.Width), _rand.Next(0, this.Height), wh, wh);
            wh = _rand.Next(1, this.Height);
            g.DrawLine(pen, wh, wh, _rand.Next(1,this.Height), _rand.Next(1, this.Width));
        }
    }
}