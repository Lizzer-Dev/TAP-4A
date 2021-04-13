using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio8
{
    public partial class Form1 : Form
    {
        Image megaman=null;
        int x, y;
        int figura=0;
        int fx, fy;
        bool tipo = false;
        private void timer1_Tick(object sender, EventArgs e)
        {
            figura++;
            if (figura>=3)
            {
                figura = 0;
            }
            if (tipo) fy = 1;
            else
                fy = 0;
            area_pintable.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine(e.KeyChar.ToString());
            if (e.KeyChar == 'a') { 
                x--;
                tipo = true;
             }
             if(e.KeyChar == 'd'){
                x++;
                tipo = true;
             }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Console.WriteLine("Liberando");
            tipo = false;
        }

        public Form1()
        {
            x = y = 0;
            fx = fy = 0;
            tipo = false;
            InitializeComponent();
            megaman = Image.FromFile("Recursos\\imagen.png");
            timer1.Enabled = true;
            timer1.Start();
        }

        private void area_pintable_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(megaman,
                new Rectangle(x,y,250,250),
                fx+figura*250,fy,250,255,GraphicsUnit.Pixel);
        }
    }
}
