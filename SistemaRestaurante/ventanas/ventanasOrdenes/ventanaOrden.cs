using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;

namespace Proyecto_Final_Periodo3.ventanas.ventanasOrdenes
{
    public partial class ventanaOrden : Form
    {
        List<Clases.claseOrden> listaOrden = new List<Clases.claseOrden>();
        Clases.claseManejoArchivo archivoOrden = new Clases.claseManejoArchivo();
        Clases.claseManejoArchivo archivoMesas = new Clases.claseManejoArchivo();
        Orden ventanaO;
        
        

        public ventanaOrden(int num,Orden v) 
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

            foreach(DataGridViewRow dgr in dgvMenu.Rows)
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
            for(int i = 0;i < dgvOrden.Rows.Count; i++)
            {
                total += Convert.ToDecimal(dgvOrden.Rows[i].Cells[3].Value);
            }
            Clases.claseMesa PropinaOrden = archivoMesas.cargarMesa();
            lblPropina.Text = "("+ PropinaOrden.Propina + "%)";
            decimal subtotal = (PropinaOrden.Propina * total)/100;
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

            archivoOrden.guardarOrden(listaOrden,Convert.ToInt32(lblMesaNum.Text));
            VentaTotal();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            if(listaOrden.Count == 0)
            {
                MessageBox.Show("La orden está vacía", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogR = MessageBox.Show("¿El cliente pagará la cuenta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogR == DialogResult.Yes)
                {
                   
                    MessageBox.Show("La cuenta es de " + lblTotal.Text, "Total", MessageBoxButtons.OK, MessageBoxIcon.Information);                   
                    listaOrden.Clear();
                    archivoOrden.guardarOrden(listaOrden,Convert.ToInt32(lblMesaNum.Text));
                    ventanaO.colorear();
                    printDocument1 = new PrintDocument();
                    PrinterSettings ps = new PrinterSettings();
                    printDocument1.PrinterSettings = ps;
                    printDocument1.PrintPage += Imprimir;
                    printDocument1.Print();
                    Close();
                }
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Bitmap logo;
            logo = new Bitmap(Properties.Resources.seasons_logo);
            Graphics ticket = e.Graphics;
            Font titulo = new Font("Arial", 12, FontStyle.Bold);
            string borde = "**********************************";
            int x = 0;
            int y = 0;
            int newline = 0;

            var srcRect = new Rectangle(0, 0, logo.Width, logo.Height);
            var desRect = new Rectangle(40, 40, 195, 80);
            using(var bpm = new Bitmap(srcRect.Width, srcRect.Height))
            {
                ticket.DrawImage(bpm, desRect, srcRect, GraphicsUnit.Pixel);
            }
            newline = newline + 60;

            StringFormat formt0 = new StringFormat();
            StringFormat formt3 = new StringFormat();
            SolidBrush color = new SolidBrush(Color.Black);
            formt3 = new StringFormat(StringFormatFlags.DirectionVertical);
            formt0 = new StringFormat(StringFormatFlags.DirectionRightToLeft);
            ticket.DrawString("Seasons Frozen, Snacks & Coffe", titulo, color, new Rectangle(0,10,200,200));

            ticket.DrawString("29 calle poninete y 4 avenida sur Barrio Nuevo, contiguo a Colegio Militar Coronel Milton Antonio Andrade.",new Font("Arial", 10, FontStyle.Regular), color,new Rectangle(0, 50,200, 200));
            ticket.DrawString("FECHA Y HORA:" + DateTime.Now,new Font("Arial", 9, FontStyle.Regular), color,new Rectangle(0, 120,200, 300));
            ticket.DrawString("MESA: #" + lblMesaNum.Text,new Font("Arial", 9, FontStyle.Regular), color,new Rectangle(0, 155, 200, 250));
            ticket.DrawString(borde, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 165, 200, 250));
            ticket.DrawString(">> ORDEN PAGADA <<", new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 180, 200, 250));
            //ticket.DrawString("PRODUCTO   CNT   P.UNIT   SUBTOTAL", new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 200, 200, 500));
            ticket.DrawString("SUBTOTAL: " + lblSubTotal.Text, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 200, 200, 250));
            ticket.DrawString("PROPINA: " + lblPropina.Text, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 220, 200, 250));

            ticket.DrawString("TOTAL A PAGAR: "+lblTotal.Text, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 240, 200, 250));
            ticket.DrawString(borde, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 260, 200, 250));
            ticket.DrawString("Gracias por preferirnos", new Font("Arial", 10, FontStyle.Regular), color, new Rectangle(0, 280, 200, 200));



            //if (dgvMenu.CurrentCell.ColumnIndex == 3)
            //{
            //    objetoOrden.Nombre = Convert.ToString(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[0].Value);
            //    objetoOrden.Cantidad = Convert.ToInt32(nudCantidad.Value);
            //    objetoOrden.Precio = Convert.ToDecimal(dgvMenu.Rows[dgvMenu.CurrentRow.Index].Cells[2].Value);
            //    objetoOrden.Subtotal = objetoOrden.Cantidad * objetoOrden.Precio;
            //    listaOrden.Add(objetoOrden);
            //}
            //foreach (DataGridViewRow row in dgvOrden.Rows)
            //{
            //    ticket.DrawString(
            //        dgvOrden.Rows[0].Cells[0].Value+" "+
            //        dgvOrden.Rows[0].Cells[1].Value + " "+
            //        dgvOrden.Rows[0].Cells[2].Value+" "+
            //        dgvOrden.Rows[0].Cells[3].Value, new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 300, 200, 250));
            //}


            //for (int i = 0; i < dgvOrden.Rows.Count; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i == 0)
            //            ticket.DrawString(dgvOrden.Rows[0].Cells[j].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 300, 200, 250));
            //        else
            //            ticket.DrawString(dgvOrden.Rows[0].Cells[j].Value.ToString(), new Font("Arial", 9, FontStyle.Regular), color, new Rectangle(0, 300, 200, 250));
            //    }

            //    y += 26;
            //}



        }


    }
}
