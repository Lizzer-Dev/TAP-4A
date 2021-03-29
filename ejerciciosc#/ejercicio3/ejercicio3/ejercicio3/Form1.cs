using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio3
{
    public partial class Form1 : Form
    {
        private int suma;
        public Form1()
        {
            InitializeComponent();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            suma = 0;
            txt_in.ResetText();
            caja.Items.Clear();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            String g = txt_in.Text;
            caja.Items.Add(g);
            if (txt_in.Text=="SUMAR"){
                caja.Items.Add("Total de la suma: "+suma);
            }
            try
            {
                int i = Convert.ToInt32(g);
                suma += i; ;
            }
            catch (Exception w)
            {
                _ = w.StackTrace;
            }
            txt_in.ResetText();
        }
    }
}
