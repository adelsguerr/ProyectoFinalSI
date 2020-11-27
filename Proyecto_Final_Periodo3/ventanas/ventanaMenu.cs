using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Periodo3.Clases;

namespace Proyecto_Final_Periodo3.ventanas
{
    public partial class ventanaMenu : Form
    {
        claseManejoArchivo archivoMenu = new claseManejoArchivo();
        List<claseMenu> listaMenu = new List<claseMenu>();
        internal List<claseMenu> ListaMenu { get => listaMenu; set => listaMenu = value; }

        public ventanaMenu()
        {
            InitializeComponent();
        }

        private void tsbAgregar_Click(object sender, EventArgs e)
        {
            
            ventanaAgregarMenu ventanaAgregarMenu = new ventanaAgregarMenu(this);
            ventanaAgregarMenu.StartPosition = FormStartPosition.CenterParent;
            ventanaAgregarMenu.ShowDialog();
        }

        private void dgvMenu_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void ventanaMenu_Load(object sender, EventArgs e)
        {
            listaMenu.Clear();
            listaMenu = archivoMenu.cargarMenu();
            dgvMenu.DataSource = listaMenu;
        }

        private void tsbGuardar_Click(object sender, EventArgs e)
        {
            archivoMenu.guardarMenu(listaMenu);
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.Rows.Count == 0)
                {

                    MessageBox.Show("No puede eliminar, no existen platillos en stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    int index = dgvMenu.CurrentRow.Index;
                    listaMenu.RemoveAt(index);
                    dgvMenu.DataSource = null;
                    dgvMenu.DataSource = listaMenu;
                    archivoMenu.guardarMenu(listaMenu);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error desconocido!!!\n" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMenu.Rows.Count == 0 )
                {

                    MessageBox.Show("No puede editar, no existen platillos en stock", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
                else
                {
                    List<claseMenu> listaMenu = new List<claseMenu>();
                    claseMenu menu = new claseMenu();
                    menu.Nombre = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[0].Value);
                    menu.Tipo = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[1].Value);
                    menu.Precio = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[2].Value);

                    ventanaEditarMenu ventanaEditar = new ventanaEditarMenu(this, menu);
                    ventanaEditar.StartPosition = FormStartPosition.CenterParent;
                    ventanaEditar.ShowDialog();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error desconocido!!!\n" + error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void actualizarGuardado(claseMenu menu)
        {
            listaMenu.Add(menu);
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listaMenu;
            archivoMenu.guardarMenu(listaMenu);
        }

        public void actualizarEdicion(claseMenu menu)
        {
            listaMenu.ElementAt(dgvMenu.CurrentRow.Index).Nombre = menu.Nombre;
            listaMenu.ElementAt(dgvMenu.CurrentRow.Index).Tipo = menu.Tipo;
            listaMenu.ElementAt(dgvMenu.CurrentRow.Index).Precio = menu.Precio;
            dgvMenu.DataSource = null;
            dgvMenu.DataSource = listaMenu;
            archivoMenu.guardarMenu(listaMenu);
        }
    }
}
