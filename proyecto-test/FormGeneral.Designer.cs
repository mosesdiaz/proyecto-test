﻿namespace proyecto_test
{
    partial class FormGeneral
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDeduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeIngresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDePuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeTiposDeNominasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.salidaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EmpleadosToolStripMenuItem,
            this.gestionDeDepartamentosToolStripMenuItem,
            this.gestionDeDeduccionesToolStripMenuItem,
            this.gestionDeIngresosToolStripMenuItem,
            this.gestionDePuestosToolStripMenuItem,
            this.gestionDeTiposDeNominasToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // EmpleadosToolStripMenuItem
            // 
            this.EmpleadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem1,
            this.asignacionDeDeduccionesToolStripMenuItem,
            this.asignacionDeToolStripMenuItem});
            this.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem";
            this.EmpleadosToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.EmpleadosToolStripMenuItem.Text = "Empleados";
            this.EmpleadosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeEmpleadosToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem1
            // 
            this.gestionToolStripMenuItem1.Name = "gestionToolStripMenuItem1";
            this.gestionToolStripMenuItem1.Size = new System.Drawing.Size(265, 26);
            this.gestionToolStripMenuItem1.Text = "Gestion de empleados";
            this.gestionToolStripMenuItem1.Click += new System.EventHandler(this.gestionToolStripMenuItem1_Click);
            // 
            // asignacionDeDeduccionesToolStripMenuItem
            // 
            this.asignacionDeDeduccionesToolStripMenuItem.Name = "asignacionDeDeduccionesToolStripMenuItem";
            this.asignacionDeDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.asignacionDeDeduccionesToolStripMenuItem.Text = "Asignacion de deducciones";
            // 
            // asignacionDeToolStripMenuItem
            // 
            this.asignacionDeToolStripMenuItem.Name = "asignacionDeToolStripMenuItem";
            this.asignacionDeToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.asignacionDeToolStripMenuItem.Text = "Asignacion de ingresos";
            // 
            // gestionDeDeduccionesToolStripMenuItem
            // 
            this.gestionDeDeduccionesToolStripMenuItem.Name = "gestionDeDeduccionesToolStripMenuItem";
            this.gestionDeDeduccionesToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.gestionDeDeduccionesToolStripMenuItem.Text = "Gestion de deducciones";
            this.gestionDeDeduccionesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDeduccionesToolStripMenuItem_Click);
            // 
            // gestionDeIngresosToolStripMenuItem
            // 
            this.gestionDeIngresosToolStripMenuItem.Name = "gestionDeIngresosToolStripMenuItem";
            this.gestionDeIngresosToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.gestionDeIngresosToolStripMenuItem.Text = "Gestion de ingresos";
            this.gestionDeIngresosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeIngresosToolStripMenuItem_Click);
            // 
            // gestionDePuestosToolStripMenuItem
            // 
            this.gestionDePuestosToolStripMenuItem.Name = "gestionDePuestosToolStripMenuItem";
            this.gestionDePuestosToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.gestionDePuestosToolStripMenuItem.Text = "Gestion de puestos";
            this.gestionDePuestosToolStripMenuItem.Click += new System.EventHandler(this.gestionDePuestosToolStripMenuItem_Click);
            // 
            // gestionDeTiposDeNominasToolStripMenuItem
            // 
            this.gestionDeTiposDeNominasToolStripMenuItem.Name = "gestionDeTiposDeNominasToolStripMenuItem";
            this.gestionDeTiposDeNominasToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.gestionDeTiposDeNominasToolStripMenuItem.Text = "Gestion de tipos de nominas";
            this.gestionDeTiposDeNominasToolStripMenuItem.Click += new System.EventHandler(this.gestionDeTiposDeNominasToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // gestionDeDepartamentosToolStripMenuItem
            // 
            this.gestionDeDepartamentosToolStripMenuItem.Name = "gestionDeDepartamentosToolStripMenuItem";
            this.gestionDeDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(273, 26);
            this.gestionDeDepartamentosToolStripMenuItem.Text = "Gestion de departamentos";
            this.gestionDeDepartamentosToolStripMenuItem.Click += new System.EventHandler(this.gestionDeDepartamentosToolStripMenuItem_Click);
            // 
            // FormGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormGeneral";
            this.Text = "Sistema de nomina";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDeduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeIngresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDePuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeTiposDeNominasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeDeduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeDepartamentosToolStripMenuItem;
    }
}