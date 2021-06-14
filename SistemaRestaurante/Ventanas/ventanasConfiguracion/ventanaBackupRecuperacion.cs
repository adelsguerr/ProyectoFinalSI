using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasConfiguracion
{
    public partial class ventanaBackupRecuperacion : Form
    {
        string fecha = DateTime.Now.ToString("yyyy-MM-dd");
        public ventanaBackupRecuperacion()
        {
            InitializeComponent();
        }

        private void btnBuscarRespaldo_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {
                txtRutaRespaldo.Text = folder.SelectedPath + @"\Respaldo_Restaurante_" + fecha + ".bak";
            }

        }

        private void btnBuscarRecuperacion_Click(object sender, EventArgs e)
        {

            OpenFileDialog file = new OpenFileDialog();

            //if (file.ShowDialog() == DialogResult.OK)
            //{
            //    txtRutaRespaldo.Text = file;
            //}



            file.InitialDirectory = "c:\\";
            file.Filter = "bak files (*.bak)|*.bak";
            file.FilterIndex = 2;
            file.RestoreDirectory = true;

            if (file.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                txtRutaRecuperacion.Text = file.FileName;         
            }
        }
    }
}
