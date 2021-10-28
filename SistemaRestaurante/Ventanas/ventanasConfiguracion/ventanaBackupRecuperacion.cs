using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasConfiguracion
{
    public partial class ventanaBackupRecuperacion : Form
    {
        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
        string path;
        public ventanaBackupRecuperacion()
        {
            InitializeComponent();
        }

        private void btnBuscarRespaldo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtRutaRespaldo.Text = folder.SelectedPath;
                path = txtRutaRespaldo.Text;
            }
            else
            {
                MessageBox.Show("La ruta no existe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (txtRutaRespaldo.Text == "")
            {
                MessageBox.Show("No ha seleccionado la ruta para el respaldo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validacion(txtRutaRespaldo.Text))
            {
                MessageBox.Show("La ruta no es válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream(txtRutaRespaldo.Text + @"\Respaldo_Restaurante_" + fecha + ".bak", FileMode.Create);
                    MessageBox.Show("Respaldo generado correctamente", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: "+ error, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBuscarRecuperacion_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            file.InitialDirectory = "c:\\";
            file.Filter = "bak files (*.bak)|*.bak";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtRutaRecuperacion.Text = file.FileName;
            }
        }

        public static bool validacion(string rutaRespaldo)
        {
            Regex rx = new Regex(@"[A-Z]:[-!#$%&'*+0-9=?A-Z^_a-z{|}]*\\.+");
            return rx.IsMatch(rutaRespaldo);
        }

        public static bool validacionRecuperacion(string rutaRecuperacion)
        {
            Regex rx = new Regex(@"[A-Z]:[-!#$%&'*+0-9=?A-Z^_a-z{|}]*\\.+\\*(.bak)");
            return rx.IsMatch(rutaRecuperacion);
        }

        private void btnRecuperacion_Click(object sender, EventArgs e)
        {
            if (txtRutaRecuperacion.Text == "")
            {
                MessageBox.Show("No ha seleccionado el archivo de respaldo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validacionRecuperacion(txtRutaRecuperacion.Text))
            {
                MessageBox.Show("La ruta no es válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Recuperación exitosa de:\n"+@"Respaldo_Restaurante_" + fecha + ".bak", "ÉXITO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
