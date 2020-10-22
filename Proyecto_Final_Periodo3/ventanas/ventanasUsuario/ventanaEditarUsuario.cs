using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasUsuario
{
    public partial class ventanaEditarUsuario : Form
    {
        private ventanas.ventanasUsuario.ventanaUsuario ventanaUsuario;
        private Clases.claseUsuarios objetoUsuarios = new Clases.claseUsuarios();
        public ventanaEditarUsuario(ventanaUsuario vUser, Clases.claseUsuarios user)
        {
            InitializeComponent();
            ventanaUsuario = vUser;
            txtNombre.Text = user.Nombre;
            txtTelefono.Text = user.Telefono;
            txtDireccion.Text = user.Direccion;
            cmbPuesto.Text = user.Puesto;
            chkAdministrador.Checked = user.Administrador;
  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || cmbPuesto.Text == "" || txtPassword1.Text == "")
            {
                MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            { 
            if (txtPassword1.Text != txtPassword2.Text)
            {
                MessageBox.Show("La contraseña no coincide.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                objetoUsuarios.Nombre = txtNombre.Text;
                objetoUsuarios.Telefono = txtTelefono.Text;
                objetoUsuarios.Direccion = txtDireccion.Text;
                objetoUsuarios.Puesto = cmbPuesto.Text;
                objetoUsuarios.Administrador = chkAdministrador.Checked;
                objetoUsuarios.Password = txtPassword1.Text;

                    ventanaUsuario.actualizarEdicion(objetoUsuarios);

                this.Close();
                }
            }
            
        }

        private void ventanaEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
