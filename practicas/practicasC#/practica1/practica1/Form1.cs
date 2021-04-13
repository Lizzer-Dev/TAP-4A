using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1 : Form
    {
        int num1, num2;
        String operacion;
        String texto;
        int cont = 0;

        private void btn_1_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 1 ";
            if(cont == 1) {
                num1 = 1;
            }
            else{
                num2 = 1;
            }
            txt_entrada.Text = texto;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 2 ";
            if (cont == 1)
            {
                num1 = 2;
            }
            else
            {
                num2 = 2;
            }
            txt_entrada.Text = texto;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 3 ";
            if (cont == 1)
            {
                num1 = 3;
            }
            else
            {
                num2 = 3;
            }
            txt_entrada.Text = texto;
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " + ";
            operacion = "+";
            txt_entrada.Text = texto;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 4 ";
            if (cont == 1)
            {
                num1 = 4;
            }
            else
            {
                num2 = 4;
            }
            txt_entrada.Text = texto;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 5 ";
            if (cont == 1)
            {
                num1 = 5;
            }
            else
            {
                num2 = 5;
            }
            txt_entrada.Text = texto;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 6 ";
            if (cont == 1)
            {
                num1 = 6;
            }
            else
            {
                num2 = 6;
            }
            txt_entrada.Text = texto;
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " - ";
            operacion = "-";
            txt_entrada.Text = texto;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 7 ";
            if (cont == 1)
            {
                num1 = 7;
            }
            else
            {
                num2 = 7;
            }
            txt_entrada.Text = texto;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 8 ";
            if (cont == 1)
            {
                num1 = 8;
            }
            else
            {
                num2 = 8;
            }
            txt_entrada.Text = texto;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 9 ";
            if (cont == 1)
            {
                num1 = 9;
            }
            else
            {
                num2 = 9;
            }
            txt_entrada.Text = texto;
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " / ";
            operacion = "/";
            txt_entrada.Text = texto;
        }

        private void btn_mult_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " * ";
            operacion = "*";
            txt_entrada.Text = texto;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " 0 ";
            if (cont == 1)
            {
                num1 = 0;
            }
            else
            {
                num2 = 0;
            }
            txt_entrada.Text = texto;
        }

        private void btn_potencia_Click(object sender, EventArgs e)
        {
            cont++;
            texto += " ^ ";
            operacion = "^";
            txt_entrada.Text = texto;
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            String res=""+logica(operacion,num1,num2);
            txt_entrada.Text = res;
        }

        public double logica(String op,int numI,int numJ)
        {
            double resultado=0;
            switch (op)
            {
                case "+":
                    resultado = numI + numJ;
                    break;
                case "*":
                    resultado = numI * numJ;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        resultado = -0;
                    }
                    else
                    {
                        resultado = numI / numJ;
                    }
                    break;
                case "-":
                    resultado = numI - numJ;
                    break;
                case "^":
                    resultado = Math.Pow(numI,numJ);
                    break;
                default:
                    break;
            }
            return resultado;
        }

        private void txt_entrada_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_entrada_MouseClick(object sender, MouseEventArgs e)
        {
            txt_entrada.Text = "";
            txt_entrada.ForeColor=Color.Black;
            texto = "";
        }

        public Form1()
        {
            InitializeComponent();
        }

    }
}
