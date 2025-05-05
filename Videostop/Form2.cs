using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videostop.Models;

namespace Videostop
{
    public partial class Form2 : Form
    {
        private readonly Hrac hrac;
        private readonly BindingSource b;
        public Form2(Hrac h, BindingSource b)
        {
            InitializeComponent();
            hrac = h;
            this.b = b;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            hrac.Jmeno = textBox1.Text;
            b.ResetBindings(false);
        }
    }
}
