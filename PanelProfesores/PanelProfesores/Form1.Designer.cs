namespace PanelProfesores
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calificaciones = new System.Windows.Forms.Button();
            this.bttnInfoProf = new System.Windows.Forms.Button();
            this.bttnTerminados = new System.Windows.Forms.Button();
            this.btn_niveles = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calificaciones
            // 
            this.btn_calificaciones.Location = new System.Drawing.Point(76, 18);
            this.btn_calificaciones.Name = "btn_calificaciones";
            this.btn_calificaciones.Size = new System.Drawing.Size(99, 25);
            this.btn_calificaciones.TabIndex = 0;
            this.btn_calificaciones.Text = "Calificaciones";
            this.btn_calificaciones.UseVisualStyleBackColor = true;
            this.btn_calificaciones.Click += new System.EventHandler(this.btn_calificaciones_Click);
            // 
            // bttnInfoProf
            // 
            this.bttnInfoProf.Location = new System.Drawing.Point(201, 210);
            this.bttnInfoProf.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnInfoProf.Name = "bttnInfoProf";
            this.bttnInfoProf.Size = new System.Drawing.Size(74, 41);
            this.bttnInfoProf.TabIndex = 1;
            this.bttnInfoProf.Text = "Información del Profesor";
            this.bttnInfoProf.UseVisualStyleBackColor = true;
            this.bttnInfoProf.Click += new System.EventHandler(this.bttnInfoProf_Click);
            // 
            // bttnTerminados
            // 
            this.bttnTerminados.Location = new System.Drawing.Point(122, 215);
            this.bttnTerminados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnTerminados.Name = "bttnTerminados";
            this.bttnTerminados.Size = new System.Drawing.Size(74, 30);
            this.bttnTerminados.TabIndex = 2;
            this.bttnTerminados.Text = "Terminados";
            this.bttnTerminados.UseVisualStyleBackColor = true;
            this.bttnTerminados.Click += new System.EventHandler(this.bttnTerminados_Click);
            // 
            // btn_niveles
            // 
            this.btn_niveles.Location = new System.Drawing.Point(77, 60);
            this.btn_niveles.Name = "btn_niveles";
            this.btn_niveles.Size = new System.Drawing.Size(97, 22);
            this.btn_niveles.TabIndex = 3;
            this.btn_niveles.Text = "Subir niveles";
            this.btn_niveles.UseVisualStyleBackColor = true;
            this.btn_niveles.Click += new System.EventHandler(this.btn_niveles_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_niveles);
            this.Controls.Add(this.bttnTerminados);
            this.Controls.Add(this.bttnInfoProf);
            this.Controls.Add(this.btn_calificaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calificaciones;
        private System.Windows.Forms.Button bttnInfoProf;
        private System.Windows.Forms.Button bttnTerminados;
        private System.Windows.Forms.Button btn_niveles;
    }
}

