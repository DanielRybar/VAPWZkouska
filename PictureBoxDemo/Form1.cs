namespace PictureBoxDemo
{
    public partial class Form1 : Form
    {
        private Bitmap _bitmap;

        public Form1()
        {
            InitializeComponent();
            _bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = _bitmap;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(_bitmap))
            using (Pen pen = new(Color.Red, 2))
            {
                g.DrawEllipse(pen, 50, 50, 100, 100); // kruh (elipsa)
            }
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(_bitmap))
            using (Pen pen = new(Color.Blue, 2))
            {
                g.DrawLine(pen, 10, 10, 200, 150); // cara
            }
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(_bitmap))
            {
                g.Clear(this.BackColor); // vycisteni
            }
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var f2 = new Form2();
            f2.Show(); // nebo f2.ShowDialog(); pokud chci modal
        }
    }
}