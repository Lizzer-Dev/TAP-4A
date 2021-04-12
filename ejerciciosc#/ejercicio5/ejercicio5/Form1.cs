using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        float x, y;
        float w=100, h=100;
        public void setX(float x)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }

        private void area_pintable_Click(object sender, EventArgs e)
        {
            x = 20;
            y = 40;
        }

        private void area_pintable_MouseClick(object sender, MouseEventArgs e)
        {
            setX(e.X);
            setY(e.Y);
        }

        private void area_pintable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            setX(e.X);
            setY(e.Y);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void area_pintable_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush RedBrush = new SolidBrush(Color.Red);
            SolidBrush YellowBrush = new SolidBrush(Color.Yellow);
            Graphics g = e.Graphics;
            g.FillEllipse(RedBrush, x, y, w, h);
            g.FillRectangle(YellowBrush, x+100, y+100, w, h);
        }
    }
}
