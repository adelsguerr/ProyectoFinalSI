using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas
{
    public partial class ventanaAgregarMenu : Form
    {
        private ventanas.ventanaMenu ventanaMenu;
        private Clases.claseMenu objetoMenu = new Clases.claseMenu();
        private Clases.Validaciones val = new Clases.Validaciones();
        public ventanaAgregarMenu(ventanas.ventanaMenu ventana)
        {
            ventanaMenu = ventana;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtPrecio.Text == "" || txtNombre.Text == "" || cmbTipo.Text == "")
            {
                MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //else if (Convert.ToDecimal(txtPrecio)<=0)
            //{
            //    MessageBox.Show("El precio debe ser monetario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                objetoMenu.Nombre = txtNombre.Text;
                objetoMenu.Tipo = cmbTipo.Text;
                objetoMenu.Precio = txtPrecio.Text;

                ventanaMenu.actualizarGuardado(objetoMenu);

                txtNombre.Text = "";
                txtPrecio.Text = "";
                cmbTipo.SelectedIndex = -1;
                this.Close();
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPrecio_Leave(object sender, EventArgs e)
        {
            try
            {
                double i = Convert.ToDouble(txtPrecio.Text);
            }
            catch
            {
                MessageBox.Show("Ingrese un precio correcto", "Error de precio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.precio(txtPrecio, e);
        }
    }
}
