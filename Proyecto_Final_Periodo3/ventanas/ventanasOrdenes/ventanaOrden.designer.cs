namespace Proyecto_Final_Periodo3.ventanas.ventanasOrdenes
{
    partial class ventanaOrden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaOrden));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.dgvOrden = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblPropina = new System.Windows.Forms.Label();
            this.lblPalabraPropina = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblPalabraSubTotal = new System.Windows.Forms.Label();
            this.lblMesaNum = new System.Windows.Forms.Label();
            this.lblMesaTexto = new System.Windows.Forms.Label();
            this.btbCerrar = new System.Windows.Forms.Button();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPalabraTotal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1103, 636);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dgvOrden, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1095, 546);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.dgvMenu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(320, 538);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // dgvMenu
            // 
            this.dgvMenu.AllowUserToAddRows = false;
            this.dgvMenu.AllowUserToDeleteRows = false;
            this.dgvMenu.AllowUserToResizeColumns = false;
            this.dgvMenu.AllowUserToResizeRows = false;
            this.dgvMenu.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.ColumnHeadersVisible = false;
            this.dgvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMenu.Location = new System.Drawing.Point(4, 43);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvMenu.MultiSelect = false;
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.ReadOnly = true;
            this.dgvMenu.RowHeadersVisible = false;
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMenu.Size = new System.Drawing.Size(312, 491);
            this.dgvMenu.TabIndex = 0;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTipo);
            this.panel1.Controls.Add(this.cmbTipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 31);
            this.panel1.TabIndex = 1;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(7, 5);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(125, 25);
            this.lblTipo.TabIndex = 2;
            this.lblTipo.Text = "Tipo de plato";
            // 
            // cmbTipo
            // 
            this.cmbTipo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Entradas",
            "Platos fuertes",
            "Bebidas",
            "Postres"});
            this.cmbTipo.Location = new System.Drawing.Point(151, 1);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(155, 28);
            this.cmbTipo.TabIndex = 0;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dgvOrden
            // 
            this.dgvOrden.AllowUserToAddRows = false;
            this.dgvOrden.AllowUserToDeleteRows = false;
            this.dgvOrden.AllowUserToResizeColumns = false;
            this.dgvOrden.AllowUserToResizeRows = false;
            this.dgvOrden.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvOrden.ColumnHeadersHeight = 29;
            this.dgvOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvOrden.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrden.Location = new System.Drawing.Point(441, 4);
            this.dgvOrden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvOrden.Name = "dgvOrden";
            this.dgvOrden.ReadOnly = true;
            this.dgvOrden.RowHeadersVisible = false;
            this.dgvOrden.RowHeadersWidth = 51;
            this.dgvOrden.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrden.Size = new System.Drawing.Size(650, 538);
            this.dgvOrden.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCantidad);
            this.panel2.Controls.Add(this.nudCantidad);
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(332, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 538);
            this.panel2.TabIndex = 2;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(4, 15);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(91, 25);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.BackColor = System.Drawing.SystemColors.Window;
            this.nudCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidad.Location = new System.Drawing.Point(4, 43);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(92, 34);
            this.nudCantidad.TabIndex = 1;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminar.Location = new System.Drawing.Point(11, 105);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 117);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar\r\nplato";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblPropina);
            this.panel3.Controls.Add(this.lblPalabraPropina);
            this.panel3.Controls.Add(this.lblSubTotal);
            this.panel3.Controls.Add(this.lblPalabraSubTotal);
            this.panel3.Controls.Add(this.lblMesaNum);
            this.panel3.Controls.Add(this.lblMesaTexto);
            this.panel3.Controls.Add(this.btbCerrar);
            this.panel3.Controls.Add(this.btnCobrar);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblPalabraTotal);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 558);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1095, 74);
            this.panel3.TabIndex = 1;
            // 
            // lblPropina
            // 
            this.lblPropina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPropina.AutoSize = true;
            this.lblPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropina.Location = new System.Drawing.Point(624, 19);
            this.lblPropina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPropina.Name = "lblPropina";
            this.lblPropina.Size = new System.Drawing.Size(43, 18);
            this.lblPropina.TabIndex = 6;
            this.lblPropina.Text = "(0%)";
            // 
            // lblPalabraPropina
            // 
            this.lblPalabraPropina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalabraPropina.AutoSize = true;
            this.lblPalabraPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabraPropina.Location = new System.Drawing.Point(525, 19);
            this.lblPalabraPropina.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalabraPropina.Name = "lblPalabraPropina";
            this.lblPalabraPropina.Size = new System.Drawing.Size(66, 18);
            this.lblPalabraPropina.TabIndex = 5;
            this.lblPalabraPropina.Text = "Propina";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(624, -1);
            this.lblSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 18);
            this.lblSubTotal.TabIndex = 4;
            this.lblSubTotal.Text = "$0.00";
            // 
            // lblPalabraSubTotal
            // 
            this.lblPalabraSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalabraSubTotal.AutoSize = true;
            this.lblPalabraSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabraSubTotal.Location = new System.Drawing.Point(525, -1);
            this.lblPalabraSubTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalabraSubTotal.Name = "lblPalabraSubTotal";
            this.lblPalabraSubTotal.Size = new System.Drawing.Size(75, 18);
            this.lblPalabraSubTotal.TabIndex = 3;
            this.lblPalabraSubTotal.Text = "SubTotal";
            // 
            // lblMesaNum
            // 
            this.lblMesaNum.AutoSize = true;
            this.lblMesaNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaNum.Location = new System.Drawing.Point(144, 23);
            this.lblMesaNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaNum.Name = "lblMesaNum";
            this.lblMesaNum.Size = new System.Drawing.Size(74, 31);
            this.lblMesaNum.TabIndex = 2;
            this.lblMesaNum.Text = "Num";
            // 
            // lblMesaTexto
            // 
            this.lblMesaTexto.AutoSize = true;
            this.lblMesaTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesaTexto.Location = new System.Drawing.Point(4, 27);
            this.lblMesaTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesaTexto.Name = "lblMesaTexto";
            this.lblMesaTexto.Size = new System.Drawing.Size(132, 25);
            this.lblMesaTexto.TabIndex = 2;
            this.lblMesaTexto.Text = "Mesa número";
            // 
            // btbCerrar
            // 
            this.btbCerrar.Image = global::Proyecto_Final_Periodo3.Properties.Resources.Exit;
            this.btbCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbCerrar.Location = new System.Drawing.Point(955, 9);
            this.btbCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btbCerrar.Name = "btbCerrar";
            this.btbCerrar.Size = new System.Drawing.Size(128, 62);
            this.btbCerrar.TabIndex = 1;
            this.btbCerrar.Text = "Salir";
            this.btbCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btbCerrar.UseVisualStyleBackColor = true;
            this.btbCerrar.Click += new System.EventHandler(this.btbCerrar_Click);
            // 
            // btnCobrar
            // 
            this.btnCobrar.Image = global::Proyecto_Final_Periodo3.Properties.Resources.ok;
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(767, 9);
            this.btnCobrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(128, 62);
            this.btnCobrar.TabIndex = 1;
            this.btnCobrar.Text = "Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = true;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(623, 38);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(76, 29);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "$0.00";
            // 
            // lblPalabraTotal
            // 
            this.lblPalabraTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPalabraTotal.AutoSize = true;
            this.lblPalabraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabraTotal.Location = new System.Drawing.Point(521, 37);
            this.lblPalabraTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPalabraTotal.Name = "lblPalabraTotal";
            this.lblPalabraTotal.Size = new System.Drawing.Size(73, 29);
            this.lblPalabraTotal.TabIndex = 0;
            this.lblPalabraTotal.Text = "Total";
            // 
            // ventanaOrden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1103, 636);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaOrden";
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.ventanaOrden_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrden)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.DataGridView dgvOrden;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPalabraTotal;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Button btbCerrar;
        private System.Windows.Forms.Label lblMesaNum;
        private System.Windows.Forms.Label lblMesaTexto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPropina;
        private System.Windows.Forms.Label lblPalabraPropina;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblPalabraSubTotal;
    }
}