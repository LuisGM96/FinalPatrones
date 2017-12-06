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
            this.SuspendLayout();
            // 
            // btn_calificaciones
            // 
            this.btn_calificaciones.Location = new System.Drawing.Point(76, 18);
            this.btn_calificaciones.Name = "btn_calificaciones";
            this.btn_calificaciones.Size = new System.Drawing.Size(99, 25);
            this.btn_calificaciones.TabIndex = 0;
            this.btn_calificaciones.Text = "calificaciones";
            this.btn_calificaciones.UseVisualStyleBackColor = true;
            this.btn_calificaciones.Click += new System.EventHandler(this.btn_calificaciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_calificaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calificaciones;
    }
}

