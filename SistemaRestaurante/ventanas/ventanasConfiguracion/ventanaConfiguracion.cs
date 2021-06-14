using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Final_Periodo3.ventanas.ventanasConfiguracion;

namespace Proyecto_Final_Periodo3.ventanas.ventanasConfiguracion
{
    public partial class ventanaConfiguracion : Form
    {
        public ventanaConfiguracion()
        {
            InitializeComponent();
        }
        private void pcbMesasPropina_Click(object sender, EventArgs e)
        {
            ventanaMesaPropina a = new ventanaMesaPropina();
            a.Show();
        }

        private void pcbBackupRecovery_Click(object sender, EventArgs e)
        {
            ventanaBackupRecuperacion b = new ventanaBackupRecuperacion();
            b.Show();
        }
    }
}
