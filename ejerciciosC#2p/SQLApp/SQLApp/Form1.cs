using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLApp.Controllers;
using SQLApp.Models;
namespace SQLApp
{
    public partial class Form1 : Form
    {
        EstadoController ctrl;

        public Form1()
        {
            InitializeComponent();
            ctrl = new EstadoController();
            var list = ctrl.listar();
            if (list.Count > 0)
            {
                foreach(Estado e in list)
                {
                    cmbEstado.Items.Add(e);
                }
                clean();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Services.DbContext.Up();
        }

        private Estado UserInterfaceToData()
        {
            var estado = new Estado();
            estado.Id = Convert.ToInt32(txtId.Text);
            estado.Name = txtNombre.Text;
            estado.Surface = Convert.ToDouble(txtSuperficie.Text);
            return estado;
        }

        private void DataToUserInterface(Estado estado)
        {
            txtId.Text = estado.Id.ToString();
            txtNombre.Text = estado.Name;
            txtSuperficie.Text = estado.Surface.ToString();
        }

        private void clean()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtSuperficie.Text = "";
            btnGuardar.Enabled = true;
            btnActualizar.Enabled = false;
        }

        private bool validate()
        {
            if (!int.TryParse(txtId.Text, out _))
            {
                MessageBox.Show("Debe proprocionar un ID válido");
                return false;
            }

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("Debe proporcionar un Nombre válido");
                return false;
            }

            if (txtSuperficie.Text.IndexOf('.')<0)
            {
                txtSuperficie.Text = txtSuperficie.Text + ".00";
            }
            if (!double.TryParse(txtSuperficie.Text, out _))
            {
                MessageBox.Show("Debe proporcionar una superifice válida");
                return false;
            }
            return true;
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Estado estado = (Estado)cmbEstado.SelectedItem;
            DataToUserInterface(estado);
            btnGuardar.Enabled = false;
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            var estado = UserInterfaceToData();
            try
            {
                ctrl.actualizar(estado);
                cmbEstado.Refresh();
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!validate()) return;
            var estado = UserInterfaceToData();
            try
            {
                ctrl.guardar(estado);
                cmbEstado.Items.Add(estado);
                clean();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
