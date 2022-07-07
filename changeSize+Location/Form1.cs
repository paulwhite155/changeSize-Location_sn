using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeSize_Location
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Size = new Size(700, 358);
            int h;
            h = this.Size.Height;
            this.Size = new Size(700, h);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int h;
            h = this.Size.Height;
            this.Size = new Size(500, h);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size=new Size(this.pictureBox1.Width + 15, this.pictureBox1.Height + 15);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Size= new Size(this.pictureBox1.Width - 20, this.pictureBox1.Height-20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location =new Point(this.pictureBox1.Location.X+15, this.pictureBox1.Location.Y);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X - 25, this.pictureBox1.Location.Y);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X, this.pictureBox1.Location.Y + 15);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Location = new Point(this.pictureBox1.Location.X, this.pictureBox1.Location.Y - 15);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text=e.X.ToString() + ";" + e.Y.ToString();
            //this.pictureBox1.Location = new Point(e.X, e.Y);       
        }
    }
}
