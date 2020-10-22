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
    public partial class agregarUsuario : Form
    {
        ventanasUsuario.ventanaUsuario ventanaUsuarios = new ventanaUsuario();
        private Clases.claseUsuarios objetoUsuarios = new Clases.claseUsuarios();
        public agregarUsuario(ventanas.ventanasUsuario.ventanaUsuario vUsuarios)
        {
           
            InitializeComponent();
            ventanaUsuarios = vUsuarios; 
        }

        private void agregarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || cmbPuesto.Text == "" || txtPassword1.Text == "")
            {
                MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(txtPassword1.Text != txtPassword2.Text)
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

                    ventanaUsuarios.actualizarGuardado(objetoUsuarios);

                    foreach(Control controles in this.Controls)
                    {
                        if(controles is TextBox) controles.Text = "";
                    }

                    chkAdministrador.Checked = false;

                }

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargar(string nombre, string telefono, string direccion, string puesto, bool administrador, string password)
        {
           
            
        }
    }
}
