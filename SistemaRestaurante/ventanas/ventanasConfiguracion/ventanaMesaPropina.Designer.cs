﻿namespace Proyecto_Final_Periodo3
{
    partial class ventanaMesaPropina
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventanaMesaPropina));
            this.lblNumberTable = new System.Windows.Forms.Label();
            this.nudNumberTable = new System.Windows.Forms.NumericUpDown();
            this.lblTip = new System.Windows.Forms.Label();
            this.nudTip = new System.Windows.Forms.NumericUpDown();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errConfig = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumberTable
            // 
            this.lblNumberTable.AutoSize = true;
            this.lblNumberTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberTable.Location = new System.Drawing.Point(58, 103);
            this.lblNumberTable.Name = "lblNumberTable";
            this.lblNumberTable.Size = new System.Drawing.Size(331, 44);
            this.lblNumberTable.TabIndex = 0;
            this.lblNumberTable.Text = "Número de mesas";
            // 
            // nudNumberTable
            // 
            this.nudNumberTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.nudNumberTable, "Use el click o el teclado para incrementar o decrementar la cantidad de mesas.");
            this.nudNumberTable.Location = new System.Drawing.Point(453, 103);
            this.nudNumberTable.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudNumberTable.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumberTable.Name = "nudNumberTable";
            this.helpProvider1.SetShowHelp(this.nudNumberTable, true);
            this.nudNumberTable.Size = new System.Drawing.Size(51, 49);
            this.nudNumberTable.TabIndex = 1;
            this.nudNumberTable.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTip.Location = new System.Drawing.Point(159, 160);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(230, 46);
            this.lblTip.TabIndex = 2;
            this.lblTip.Text = "Propina (%)";
            // 
            // nudTip
            // 
            this.nudTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTip.Location = new System.Drawing.Point(453, 157);
            this.nudTip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTip.Name = "nudTip";
            this.nudTip.Size = new System.Drawing.Size(51, 49);
            this.nudTip.TabIndex = 3;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(108, 323);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 58);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Actualizar";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(361, 323);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(143, 58);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errConfig
            // 
            this.errConfig.ContainerControl = this;
            // 
            // ventanaMesaPropina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(620, 419);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.nudTip);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.nudNumberTable);
            this.Controls.Add(this.lblNumberTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ventanaMesaPropina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.Configuración_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumberTable;
        private System.Windows.Forms.NumericUpDown nudNumberTable;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.NumericUpDown nudTip;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errConfig;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}