using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica2
{
    public partial class Form1 : Form
    {
        float x, y;
        float w, h;
        String texto ="Boton 1";
        public void setX(float x)
        {
            this.x = x;
        }
        public void setY(float y)
        {
            this.y = y;
        }
        public void setTexto(String y)
        {
            this.texto = y;
        }

        private void contenedor_MouseClick(object sender, MouseEventArgs e)
        {
            setX(e.X);
            setY(e.Y);
            setTexto("Moviendo a: [" + e.X + ", " + e.Y + "]");
            contenedor.Invalidate();
        }

        public Form1()
        {
            w = h= 50;
            InitializeComponent();
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {
            float c = 12;
            SolidBrush Green = new SolidBrush(Color.Green);
            SolidBrush black = new SolidBrush(Color.Black);
            SolidBrush white = new SolidBrush(Color.White);
            Graphics g = e.Graphics;
            g.FillEllipse(Green, 30,300, 50, 50);
            g.DrawString(texto,new Font("Bold",c), black, new Point(29, 280));
            g.FillRectangle(white,x,y,w,h);
            g.FillEllipse(black, x+5, y, 20, 20);
            g.FillEllipse(black, x +30, y, 20, 20);

        }
    }
}
