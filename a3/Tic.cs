using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace a3
{
    public partial class Tic : Form
    {
        private Form prevForm;
        public Tic(Form a, string b)
        {
            InitializeComponent();
            this.prevForm = a;
            label4.Text = b;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            prevForm.Visible = true;


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int red = trackBar1.Value;
            int green = trackBar2.Value;
            int blue = trackBar3.Value;
            label4.ForeColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            int red = trackBar1.Value;
            int green = trackBar2.Value;
            int blue = trackBar3.Value;
            label4.ForeColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            int red = trackBar1.Value;
            int green = trackBar2.Value;
            int blue = trackBar3.Value;
            label4.ForeColor = Color.FromArgb(red, green, blue);
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label4.Font = new Font(label4.Font.Name, trackBar4.Value);
        }
    }
}
