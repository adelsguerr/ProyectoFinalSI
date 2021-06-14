﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            try
            {
                if (txtPrecio.Text == "" || txtNombre.Text == "" || cmbTipo.Text == "")
                {
                    MessageBox.Show("Los datos no están completos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (!validacion(txtPrecio.Text))
                    {
                        MessageBox.Show("Sólo se admiten números", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
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
            }
            catch (Exception)
            {

                throw;
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
        public static bool validacion(string precio)
        {
            Regex rx = new Regex(
            @"^([1-9][0-9]{,2}(,[0-9]{3})*|[0-9]+)(.[0-9]{1,9})?$");
            return rx.IsMatch(precio);

        }
    }
}