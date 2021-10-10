
namespace Proyecto_Final_Periodo3.ventanas.ventanasConfiguracion
{
    partial class ventanaConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaConfiguracion));
            this.pcbMesasPropina = new System.Windows.Forms.PictureBox();
            this.pcbBackupRecovery = new System.Windows.Forms.PictureBox();
            this.lblMesasPropina = new System.Windows.Forms.Label();
            this.lblBackupRecovery = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMesasPropina)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackupRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMesasPropina
            // 
            this.pcbMesasPropina.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpProvider1.SetHelpString(this.pcbMesasPropina, "De un click en el icono para acceder a la configuración de cantidad de mesas y el" +
        " porcentaje de propina.");
            this.pcbMesasPropina.Image = global::Proyecto_Final_Periodo3.Properties.Resources.ToolBar;
            this.pcbMesasPropina.Location = new System.Drawing.Point(81, 76);
            this.pcbMesasPropina.Name = "pcbMesasPropina";
            this.helpProvider1.SetShowHelp(this.pcbMesasPropina, true);
            this.pcbMesasPropina.Size = new System.Drawing.Size(139, 135);
            this.pcbMesasPropina.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbMesasPropina.TabIndex = 0;
            this.pcbMesasPropina.TabStop = false;
            this.pcbMesasPropina.Click += new System.EventHandler(this.pcbMesasPropina_Click);
            // 
            // pcbBackupRecovery
            // 
            this.pcbBackupRecovery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpProvider1.SetHelpString(this.pcbBackupRecovery, "De click al icono para acceder al respaldo y recuperación del sistema.");
            this.pcbBackupRecovery.Image = global::Proyecto_Final_Periodo3.Properties.Resources.Save;
            this.pcbBackupRecovery.Location = new System.Drawing.Point(344, 76);
            this.pcbBackupRecovery.Name = "pcbBackupRecovery";
            this.helpProvider1.SetShowHelp(this.pcbBackupRecovery, true);
            this.pcbBackupRecovery.Size = new System.Drawing.Size(138, 135);
            this.pcbBackupRecovery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBackupRecovery.TabIndex = 1;
            this.pcbBackupRecovery.TabStop = false;
            this.pcbBackupRecovery.Click += new System.EventHandler(this.pcbBackupRecovery_Click);
            // 
            // lblMesasPropina
            // 
            this.lblMesasPropina.AutoSize = true;
            this.lblMesasPropina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesasPropina.Location = new System.Drawing.Point(65, 30);
            this.lblMesasPropina.Name = "lblMesasPropina";
            this.lblMesasPropina.Size = new System.Drawing.Size(173, 25);
            this.lblMesasPropina.TabIndex = 2;
            this.lblMesasPropina.Text = "Mesas y Propina";
            // 
            // lblBackupRecovery
            // 
            this.lblBackupRecovery.AutoSize = true;
            this.lblBackupRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBackupRecovery.Location = new System.Drawing.Point(283, 30);
            this.lblBackupRecovery.Name = "lblBackupRecovery";
            this.lblBackupRecovery.Size = new System.Drawing.Size(257, 25);
            this.lblBackupRecovery.TabIndex = 3;
            this.lblBackupRecovery.Text = "Respaldo y Recuperación";
            // 
            // ventanaConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 285);
            this.Controls.Add(this.lblBackupRecovery);
            this.Controls.Add(this.lblMesasPropina);
            this.Controls.Add(this.pcbBackupRecovery);
            this.Controls.Add(this.pcbMesasPropina);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaConfiguracion";
            this.Text = "Configuración";
            ((System.ComponentModel.ISupportInitialize)(this.pcbMesasPropina)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBackupRecovery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMesasPropina;
        private System.Windows.Forms.PictureBox pcbBackupRecovery;
        private System.Windows.Forms.Label lblMesasPropina;
        private System.Windows.Forms.Label lblBackupRecovery;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}