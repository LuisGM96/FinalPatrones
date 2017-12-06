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
            this.historyButton = new System.Windows.Forms.Button();
            this.btn_niveles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calificaciones
            // 
            this.btn_calificaciones.Location = new System.Drawing.Point(101, 22);
            this.btn_calificaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_calificaciones.Name = "btn_calificaciones";
            this.btn_calificaciones.Size = new System.Drawing.Size(183, 31);
            this.btn_calificaciones.TabIndex = 0;
            this.btn_calificaciones.Text = "Calificaciones";
            this.btn_calificaciones.UseVisualStyleBackColor = true;
            this.btn_calificaciones.Click += new System.EventHandler(this.btn_calificaciones_Click);
            // 
            // bttnInfoProf
            // 
            this.bttnInfoProf.Location = new System.Drawing.Point(101, 169);
            this.bttnInfoProf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnInfoProf.Name = "bttnInfoProf";
            this.bttnInfoProf.Size = new System.Drawing.Size(183, 32);
            this.bttnInfoProf.TabIndex = 1;
            this.bttnInfoProf.Text = "Información del Profesor";
            this.bttnInfoProf.UseVisualStyleBackColor = true;
            this.bttnInfoProf.Click += new System.EventHandler(this.bttnInfoProf_Click);
            // 
            // bttnTerminados
            // 
            this.bttnTerminados.Location = new System.Drawing.Point(101, 133);
            this.bttnTerminados.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bttnTerminados.Name = "bttnTerminados";
            this.bttnTerminados.Size = new System.Drawing.Size(183, 32);
            this.bttnTerminados.TabIndex = 2;
            this.bttnTerminados.Text = "Terminados";
            this.bttnTerminados.UseVisualStyleBackColor = true;
            this.bttnTerminados.Click += new System.EventHandler(this.bttnTerminados_Click);
            // 
            // historyButton
            // 
            this.historyButton.Location = new System.Drawing.Point(101, 61);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(183, 28);
            this.historyButton.TabIndex = 3;
            this.historyButton.Text = "Historial de Actividades";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // btn_niveles
            // 
            this.btn_niveles.Location = new System.Drawing.Point(101, 96);
            this.btn_niveles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_niveles.Name = "btn_niveles";
            this.btn_niveles.Size = new System.Drawing.Size(183, 28);
            this.btn_niveles.TabIndex = 4;
            this.btn_niveles.Text = "Subir niveles";
            this.btn_niveles.UseVisualStyleBackColor = true;
            this.btn_niveles.Click += new System.EventHandler(this.btn_niveles_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Puntuaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 244);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 32);
            this.button2.TabIndex = 6;
            this.button2.Text = "Nivel de Ingles Alumnos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.btn_niveles);
            this.Controls.Add(this.bttnTerminados);
            this.Controls.Add(this.bttnInfoProf);
            this.Controls.Add(this.btn_calificaciones);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calificaciones;
        private System.Windows.Forms.Button bttnInfoProf;
        private System.Windows.Forms.Button bttnTerminados;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button btn_niveles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

