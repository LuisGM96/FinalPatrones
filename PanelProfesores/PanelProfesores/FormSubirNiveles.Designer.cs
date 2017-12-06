namespace PanelProfesores
{
    partial class FormSubirNiveles
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
            this.btn_LvlAlumnos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LvlAlumnos
            // 
            this.btn_LvlAlumnos.Location = new System.Drawing.Point(157, 27);
            this.btn_LvlAlumnos.Name = "btn_LvlAlumnos";
            this.btn_LvlAlumnos.Size = new System.Drawing.Size(120, 24);
            this.btn_LvlAlumnos.TabIndex = 0;
            this.btn_LvlAlumnos.Text = "Ver alumnos";
            this.btn_LvlAlumnos.UseVisualStyleBackColor = true;
            this.btn_LvlAlumnos.Click += new System.EventHandler(this.btn_LvlAlumnos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // FormSubirNiveles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 311);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LvlAlumnos);
            this.Name = "FormSubirNiveles";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSubirNiveles_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LvlAlumnos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}