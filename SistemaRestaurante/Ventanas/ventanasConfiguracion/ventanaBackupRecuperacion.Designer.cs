
namespace Proyecto_Final_Periodo3.ventanas.ventanasConfiguracion
{
    partial class ventanaBackupRecuperacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaBackupRecuperacion));
            this.lblRespaldo = new System.Windows.Forms.Label();
            this.txtRutaRespaldo = new System.Windows.Forms.TextBox();
            this.btnBuscarRespaldo = new System.Windows.Forms.Button();
            this.btnRespaldo = new System.Windows.Forms.Button();
            this.btnRecuperacion = new System.Windows.Forms.Button();
            this.btnBuscarRecuperacion = new System.Windows.Forms.Button();
            this.txtRutaRecuperacion = new System.Windows.Forms.TextBox();
            this.lblRecuperacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRespaldo
            // 
            this.lblRespaldo.AutoSize = true;
            this.lblRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRespaldo.Location = new System.Drawing.Point(24, 42);
            this.lblRespaldo.Name = "lblRespaldo";
            this.lblRespaldo.Size = new System.Drawing.Size(298, 25);
            this.lblRespaldo.TabIndex = 0;
            this.lblRespaldo.Text = "Ruta para almacenar el respaldo:";
            // 
            // txtRutaRespaldo
            // 
            this.txtRutaRespaldo.Location = new System.Drawing.Point(27, 74);
            this.txtRutaRespaldo.Multiline = true;
            this.txtRutaRespaldo.Name = "txtRutaRespaldo";
            this.txtRutaRespaldo.Size = new System.Drawing.Size(471, 35);
            this.txtRutaRespaldo.TabIndex = 1;
            // 
            // btnBuscarRespaldo
            // 
            this.btnBuscarRespaldo.Location = new System.Drawing.Point(504, 74);
            this.btnBuscarRespaldo.Name = "btnBuscarRespaldo";
            this.btnBuscarRespaldo.Size = new System.Drawing.Size(75, 37);
            this.btnBuscarRespaldo.TabIndex = 2;
            this.btnBuscarRespaldo.Text = "...";
            this.btnBuscarRespaldo.UseVisualStyleBackColor = true;
            this.btnBuscarRespaldo.Click += new System.EventHandler(this.btnBuscarRespaldo_Click);
            // 
            // btnRespaldo
            // 
            this.btnRespaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRespaldo.Location = new System.Drawing.Point(27, 127);
            this.btnRespaldo.Name = "btnRespaldo";
            this.btnRespaldo.Size = new System.Drawing.Size(162, 36);
            this.btnRespaldo.TabIndex = 3;
            this.btnRespaldo.Text = "Generar Respaldo";
            this.btnRespaldo.UseVisualStyleBackColor = true;
            this.btnRespaldo.Click += new System.EventHandler(this.btnRespaldo_Click);
            // 
            // btnRecuperacion
            // 
            this.btnRecuperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperacion.Location = new System.Drawing.Point(27, 281);
            this.btnRecuperacion.Name = "btnRecuperacion";
            this.btnRecuperacion.Size = new System.Drawing.Size(162, 36);
            this.btnRecuperacion.TabIndex = 7;
            this.btnRecuperacion.Text = "Recuperar";
            this.btnRecuperacion.UseVisualStyleBackColor = true;
            this.btnRecuperacion.Click += new System.EventHandler(this.btnRecuperacion_Click);
            // 
            // btnBuscarRecuperacion
            // 
            this.btnBuscarRecuperacion.Location = new System.Drawing.Point(504, 228);
            this.btnBuscarRecuperacion.Name = "btnBuscarRecuperacion";
            this.btnBuscarRecuperacion.Size = new System.Drawing.Size(75, 37);
            this.btnBuscarRecuperacion.TabIndex = 6;
            this.btnBuscarRecuperacion.Text = "...";
            this.btnBuscarRecuperacion.UseVisualStyleBackColor = true;
            this.btnBuscarRecuperacion.Click += new System.EventHandler(this.btnBuscarRecuperacion_Click);
            // 
            // txtRutaRecuperacion
            // 
            this.txtRutaRecuperacion.Location = new System.Drawing.Point(27, 228);
            this.txtRutaRecuperacion.Multiline = true;
            this.txtRutaRecuperacion.Name = "txtRutaRecuperacion";
            this.txtRutaRecuperacion.Size = new System.Drawing.Size(471, 35);
            this.txtRutaRecuperacion.TabIndex = 5;
            // 
            // lblRecuperacion
            // 
            this.lblRecuperacion.AutoSize = true;
            this.lblRecuperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperacion.Location = new System.Drawing.Point(24, 196);
            this.lblRecuperacion.Name = "lblRecuperacion";
            this.lblRecuperacion.Size = new System.Drawing.Size(294, 25);
            this.lblRecuperacion.TabIndex = 4;
            this.lblRecuperacion.Text = "Ruta para hacer la recuperación:";
            // 
            // ventanaBackupRecuperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 334);
            this.Controls.Add(this.btnRecuperacion);
            this.Controls.Add(this.btnBuscarRecuperacion);
            this.Controls.Add(this.txtRutaRecuperacion);
            this.Controls.Add(this.lblRecuperacion);
            this.Controls.Add(this.btnRespaldo);
            this.Controls.Add(this.btnBuscarRespaldo);
            this.Controls.Add(this.txtRutaRespaldo);
            this.Controls.Add(this.lblRespaldo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ventanaBackupRecuperacion";
            this.Text = "Respaldo y Recuperación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRespaldo;
        private System.Windows.Forms.TextBox txtRutaRespaldo;
        private System.Windows.Forms.Button btnBuscarRespaldo;
        private System.Windows.Forms.Button btnRespaldo;
        private System.Windows.Forms.Button btnRecuperacion;
        private System.Windows.Forms.Button btnBuscarRecuperacion;
        private System.Windows.Forms.TextBox txtRutaRecuperacion;
        private System.Windows.Forms.Label lblRecuperacion;
    }
}