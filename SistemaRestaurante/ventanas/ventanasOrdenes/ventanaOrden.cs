using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Proyecto_Final_Periodo3.ventanas.ventanasOrdenes
{
    public partial class ventanaOrden : Form
    {
        List<Clases.claseOrden> listaOrden = new List<Clases.claseOrden>();
        Clases.claseManejoArchivo archivoOrden = new Clases.claseManejoArchivo();
        Clases.claseManejoArchivo archivoMesas = new Clases.claseManejoArchivo();
        Orden ventanaO;

        public ventanaOrden(int num, Orden v)
        {
            InitializeComponent();
            lblMesaNum.Text = Convert.ToString(num);
            ventanaO = v;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Clases.claseMenu> listaMenu = new List<Clases.claseMenu>();
            Clases.claseManejoArchivo archivoMenu = new Clases.claseManejoArchivo();

            listaMenu = archivoMenu.cargarMenu();
            dgvMenu.Columns.Clear();

            switch (cmbTipo.Text)
            {
                case "Entradas":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Entrada");
                    break;

                case "Platos fuertes":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Plato fuerte");
                    break;

                case "Bebidas":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Bebida");
                    break;

                case "Postres":
                    dgvMenu.DataSource = null;
                    listaMenu = listaMenu.FindAll(item => item.Tipo == "Postre");
                    break;
            }

            dgvMenu.DataSource = listaMenu;
            dgvMenu.Columns[0].Width = 160;
            dgvMenu.Columns[1].Visible = false;
            dgvMenu.Columns[2].Visible = false;

            DataGridViewButtonColumn columna = new DataGridViewButtonColumn();
            dgvMenu.Columns.Add(columna);
            dgvMenu.Columns[3].Width = 60;

            foreach (DataGridViewRow dgr in dgvMenu.Rows)
            {
                DataGridViewCell buttonCell = dgr.Cells[3];
                buttonCell.Value = "Agregar";
            }
        }


        private void dgvMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.claseOrden objetoOrden = new Clases.claseOrden();

            dgvOrden.Columns.Clear();
            dgvOrden.DataSource = null;
            if (dgvMenu.CurrentCell.ColumnIndex == 3)
            {
                objetoOrden.Nombre = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[0].Value);
                objetoOrden.Cantidad = Convert.ToInt32(nudCantidad.Value);
                objetoOrden.Precio = Convert.ToDecimal(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[2].Value);
                objetoOrden.Subtotal = objetoOrden.Cantidad * objetoOrden.Precio;
                listaOrden.Add(objetoOrden);
            }
            dgvOrden.DataSource = listaOrden;
            archivoOrden.guardarOrden(listaOrden, Convert.ToInt32(lblMesaNum.Text));
            VentaTotal();
        }

        private void VentaTotal()
        {
            decimal total = 0;
            for (int i = 0; i < dgvOrden.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvOrden.Rows[i].Cells[3].Value);
            }
            Clases.claseMesa PropinaOrden = archivoMesas.cargarMesa();
            lblPropina.Text = "(" + PropinaOrden.Propina + "%)";
            decimal subtotal = (PropinaOrden.Propina * total) / 100;
            lblSubTotal.Text = "$" + total;
            lblTotal.Text = "$" + Venta(total, PropinaOrden.Propina);
        }

        public static decimal Venta(decimal total, decimal propina)
        {
            decimal subtotal = (propina * total) / 100;
            decimal ventaTotal = total + subtotal;
            return decimal.Round(ventaTotal, 2);
        }

        private void btbCerrar_Click(object sender, EventArgs e)
        {
            ventanaO.colorear();
            Close();
        }

        private void ventanaOrden_Load(object sender, EventArgs e)
        {
            Clases.claseManejoArchivo ordenes = new Clases.claseManejoArchivo();
            listaOrden = ordenes.cargarOrden(Convert.ToInt32(lblMesaNum.Text));
            if (listaOrden.Count != 0)
            {
                dgvOrden.DataSource = listaOrden;
            }
            VentaTotal();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            listaOrden.RemoveAt(dgvOrden.CurrentCell.ColumnIndex);
            dgvOrden.DataSource = null;
            dgvOrden.DataSource = listaOrden;

            archivoOrden.guardarOrden(listaOrden, Convert.ToInt32(lblMesaNum.Text));
            VentaTotal();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if (listaOrden.Count == 0)
            {
                MessageBox.Show("La orden está vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogR = MessageBox.Show("¿El cliente pagará la cuenta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogR == DialogResult.Yes)
                {

                    MessageBox.Show("La cuenta es de " + lblTotal.Text, "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += Imprimir;
                    printDocument1.Print();
                    listaOrden.Clear();
                    archivoOrden.guardarOrden(listaOrden, Convert.ToInt32(lblMesaNum.Text));
                    ventanaO.colorear();
                    Close();
                }
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            StringFormat stringFormatCenter = new StringFormat();
            stringFormatCenter.Alignment = StringAlignment.Center;

            //LOGO
            Bitmap logo = new Bitmap(@"C:\MyProjects\SI\ProyectoFinalSI\SistemaRestaurante\Imgs\seasons-logo.jpg");
            Graphics ticket = e.Graphics;
            ticket.DrawImage(logo, 35, 30, 250, 121);

            string borde1 = "- - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -";
            string borde2 = "=========================================";

            SolidBrush color = new SolidBrush(Color.Black);
      
            ticket.DrawString("29 Calle Poniente y 4 Avenida Sur Barrio Nuevo, contiguo a Colegio Militar Coronel Milton Antonio Andrade.", new Font("Arial", 10, FontStyle.Regular), color, new Rectangle(0, 170, 340, 200), stringFormatCenter);
            ticket.DrawString(borde1, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 220, 340, 250), stringFormatCenter);
            ticket.DrawString("FECHA Y HORA: " + DateTime.Now, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 240, 340, 300), stringFormatCenter);
            ticket.DrawString("MESA: #" + lblMesaNum.Text, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 255, 340, 250), stringFormatCenter);
            ticket.DrawString(">>> ORDEN PAGADA <<<", new Font("Arial", 9, FontStyle.Bold), color, new Rectangle(0, 275, 340, 250), stringFormatCenter);
            ticket.DrawString(borde2, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 290, 340, 250), stringFormatCenter);

            int left = 20, top = 310, alturaDgv = 0;
            foreach (DataGridViewColumn col in dgvOrden.Columns)
            {
                e.Graphics.DrawString(col.HeaderText, new Font("Arial", 9, FontStyle.Regular), Brushes.Black, left, top);
                left += 82;
            }

            ticket.DrawString(borde1, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 318, 340, 250), stringFormatCenter);

            foreach (DataGridViewRow row in dgvOrden.Rows)
            {
                if (row.Index == dgvOrden.RowCount) break;
                left = 20;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawString(Convert.ToString(cell.Value), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, left, top + 25);
                    left += 82;
                }
                top += 20;
                alturaDgv = top;
            }
            ticket.DrawString(borde1, new Font("Arial", 9, FontStyle.Regular), color, 20, alturaDgv + 20);
            ticket.DrawString("Sub Total:                                                     " + lblSubTotal.Text, new Font("Arial", 9, FontStyle.Regular), color, 20, alturaDgv + 40);
            ticket.DrawString("Propina:                                                        " + lblPropina.Text, new Font("Arial", 9, FontStyle.Regular), color, 20, alturaDgv + 60);
            ticket.DrawString("TOTAL:                                           " + lblTotal.Text, new Font("Arial", 11, FontStyle.Bold), color, 20, alturaDgv + 85);
            ticket.DrawString(borde2, new Font("Arial", 9, FontStyle.Regular), color, 20, alturaDgv + 110);
            ticket.DrawString("- - - - - - - - - GRACIAS POR SU VISITA - - - - - - - - -", new Font("Arial", 9, FontStyle.Regular), color, 25, alturaDgv + 125);
            ticket.DrawString(borde2, new Font("Arial", 9, FontStyle.Regular), color, 20, alturaDgv + 140);


        }
    }
}
