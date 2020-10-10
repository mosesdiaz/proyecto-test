namespace proyecto_test
{
    partial class FormEdDepartamentos
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInputUbicacion = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtInputNombre = new System.Windows.Forms.TextBox();
            this.cbResponsable = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(484, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(154, 47);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar❌";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(144, 340);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 47);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar💾";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.cbResponsable);
            this.panel3.Controls.Add(this.txtInputNombre);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.textId);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtInputUbicacion);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(132, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 283);
            this.panel3.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(32, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Ubicacion:";
            // 
            // txtInputUbicacion
            // 
            this.txtInputUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputUbicacion.Location = new System.Drawing.Point(147, 140);
            this.txtInputUbicacion.Name = "txtInputUbicacion";
            this.txtInputUbicacion.Size = new System.Drawing.Size(284, 30);
            this.txtInputUbicacion.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "ID:";
            // 
            // textId
            // 
            this.textId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textId.Location = new System.Drawing.Point(125, 33);
            this.textId.Name = "textId";
            this.textId.ReadOnly = true;
            this.textId.Size = new System.Drawing.Size(132, 30);
            this.textId.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 188);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 25);
            this.label14.TabIndex = 6;
            this.label14.Text = "Responsable:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(32, 98);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 25);
            this.label16.TabIndex = 12;
            this.label16.Text = "Nombre:";
            // 
            // txtInputNombre
            // 
            this.txtInputNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInputNombre.Location = new System.Drawing.Point(125, 98);
            this.txtInputNombre.Name = "txtInputNombre";
            this.txtInputNombre.Size = new System.Drawing.Size(284, 30);
            this.txtInputNombre.TabIndex = 13;
            // 
            // cbResponsable
            // 
            this.cbResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbResponsable.FormattingEnabled = true;
            this.cbResponsable.Location = new System.Drawing.Point(170, 188);
            this.cbResponsable.Name = "cbResponsable";
            this.cbResponsable.Size = new System.Drawing.Size(286, 33);
            this.cbResponsable.TabIndex = 14;
            // 
            // FormEdDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 443);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormEdDepartamentos";
            this.Text = "Edicion de Departamentos";
            this.Load += new System.EventHandler(this.FormEdDepartamentos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cbResponsable;
        private System.Windows.Forms.TextBox txtInputNombre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInputUbicacion;
        private System.Windows.Forms.Label label11;
    }
}