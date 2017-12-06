namespace PanelProfesores
{
    partial class FormCalificaciones
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
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_VerCalificaciones = new System.Windows.Forms.Button();
            this.lPuntaje = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(204, 197);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(75, 21);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Text = "cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // btn_VerCalificaciones
            // 
            this.btn_VerCalificaciones.Location = new System.Drawing.Point(204, 12);
            this.btn_VerCalificaciones.Name = "btn_VerCalificaciones";
            this.btn_VerCalificaciones.Size = new System.Drawing.Size(110, 22);
            this.btn_VerCalificaciones.TabIndex = 1;
            this.btn_VerCalificaciones.Text = "Ver calificaciones";
            this.btn_VerCalificaciones.UseVisualStyleBackColor = true;
            this.btn_VerCalificaciones.Click += new System.EventHandler(this.btn_VerCalificaciones_Click);
            // 
            // lPuntaje
            // 
            this.lPuntaje.AutoSize = true;
            this.lPuntaje.Location = new System.Drawing.Point(33, 65);
            this.lPuntaje.Name = "lPuntaje";
            this.lPuntaje.Size = new System.Drawing.Size(35, 13);
            this.lPuntaje.TabIndex = 2;
            this.lPuntaje.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label1";
            // 
            // FormCalificaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 307);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lPuntaje);
            this.Controls.Add(this.btn_VerCalificaciones);
            this.Controls.Add(this.btn_cerrar);
            this.Name = "FormCalificaciones";
            this.Text = "FormCalificaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.Button btn_VerCalificaciones;
        private System.Windows.Forms.Label lPuntaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}