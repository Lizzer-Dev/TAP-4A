using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio7
{
    public partial class Form1 : Form
    {
        float x, y;
        float w = 100, h = 100;
        public void setX(float x)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void area_pintable_MouseClick(object sender, MouseEventArgs e)
        {
            setX(e.X);
            setY(e.Y);
            area_pintable.Invalidate();
        }

        private void area_pintable_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush GreenBrush = new SolidBrush(Color.Green);
            SolidBrush BlackBrush = new SolidBrush(Color.Black);
            SolidBrush RedBrush = new SolidBrush(Color.Red);
            Graphics g = e.Graphics;
            g.FillEllipse(GreenBrush, x, y, w, h);
            g.FillEllipse(BlackBrush, x + 10, y + 15, 30, 30);
            g.FillEllipse(BlackBrush, x + 60, y + 15, 30, 30);
            g.FillEllipse(RedBrush, x*10, y*30, w, h);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'a' || e.KeyChar == 'A')
            {
                x += -10;
            }
            if (e.KeyChar == 'd' || e.KeyChar == 'D')
            {
                x += 10;
            }
            if (e.KeyChar == 's' || e.KeyChar == 'S')
            {
                y += 10;
            }
            if (e.KeyChar == 'w' || e.KeyChar == 'W')
            {
                y += -10;
            }
            area_pintable.Invalidate();
        }
    }
}
