namespace PanelProfesores
{
    partial class FormBuilder
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
            this.testTimesListBox = new System.Windows.Forms.ListBox();
            this.testTimesTextBox = new System.Windows.Forms.TextBox();
            this.addTestTimeButton = new System.Windows.Forms.Button();
            this.calTimeButton = new System.Windows.Forms.Button();
            this.calTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createGameScoreButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // testTimesListBox
            // 
            this.testTimesListBox.FormattingEnabled = true;
            this.testTimesListBox.ItemHeight = 16;
            this.testTimesListBox.Location = new System.Drawing.Point(16, 34);
            this.testTimesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testTimesListBox.Name = "testTimesListBox";
            this.testTimesListBox.Size = new System.Drawing.Size(159, 116);
            this.testTimesListBox.TabIndex = 0;
            // 
            // testTimesTextBox
            // 
            this.testTimesTextBox.Location = new System.Drawing.Point(16, 180);
            this.testTimesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.testTimesTextBox.Name = "testTimesTextBox";
            this.testTimesTextBox.Size = new System.Drawing.Size(132, 22);
            this.testTimesTextBox.TabIndex = 1;
            // 
            // addTestTimeButton
            // 
            this.addTestTimeButton.Location = new System.Drawing.Point(16, 212);
            this.addTestTimeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addTestTimeButton.Name = "addTestTimeButton";
            this.addTestTimeButton.Size = new System.Drawing.Size(100, 28);
            this.addTestTimeButton.TabIndex = 2;
            this.addTestTimeButton.Text = "Agregar";
            this.addTestTimeButton.UseVisualStyleBackColor = true;
            this.addTestTimeButton.Click += new System.EventHandler(this.addTestTimeButton_Click);
            // 
            // calTimeButton
            // 
            this.calTimeButton.Enabled = false;
            this.calTimeButton.Location = new System.Drawing.Point(184, 66);
            this.calTimeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calTimeButton.Name = "calTimeButton";
            this.calTimeButton.Size = new System.Drawing.Size(133, 50);
            this.calTimeButton.TabIndex = 3;
            this.calTimeButton.Text = "Calcular puntuación";
            this.calTimeButton.UseVisualStyleBackColor = true;
            this.calTimeButton.Click += new System.EventHandler(this.calTimeButton_Click);
            // 
            // calTimeTextBox
            // 
            this.calTimeTextBox.Location = new System.Drawing.Point(184, 34);
            this.calTimeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calTimeTextBox.Name = "calTimeTextBox";
            this.calTimeTextBox.Size = new System.Drawing.Size(132, 22);
            this.calTimeTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tiempos prueba";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Agregar tiempo prueba";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Location = new System.Drawing.Point(184, 149);
            this.score.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(60, 17);
            this.score.TabIndex = 7;
            this.score.Text = "Puntos: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(188, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiempo a calcular";
            // 
            // createGameScoreButton
            // 
            this.createGameScoreButton.Enabled = false;
            this.createGameScoreButton.Location = new System.Drawing.Point(16, 247);
            this.createGameScoreButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createGameScoreButton.Name = "createGameScoreButton";
            this.createGameScoreButton.Size = new System.Drawing.Size(100, 28);
            this.createGameScoreButton.TabIndex = 9;
            this.createGameScoreButton.Text = "Crear escala";
            this.createGameScoreButton.UseVisualStyleBackColor = true;
            this.createGameScoreButton.Click += new System.EventHandler(this.createGameScoreButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 286);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createGameScoreButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calTimeTextBox);
            this.Controls.Add(this.calTimeButton);
            this.Controls.Add(this.addTestTimeButton);
            this.Controls.Add(this.testTimesTextBox);
            this.Controls.Add(this.testTimesListBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormBuilder";
            this.Text = "FormBuilder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testTimesListBox;
        private System.Windows.Forms.TextBox testTimesTextBox;
        private System.Windows.Forms.Button addTestTimeButton;
        private System.Windows.Forms.Button calTimeButton;
        private System.Windows.Forms.TextBox calTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createGameScoreButton;
        private System.Windows.Forms.Button button1;
    }
}