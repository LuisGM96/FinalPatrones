namespace Patrones {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.spaceShipButton = new System.Windows.Forms.Button();
            this.dragAndDropButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "GAMES";
            // 
            // spaceShipButton
            // 
            this.spaceShipButton.Location = new System.Drawing.Point(122, 134);
            this.spaceShipButton.Name = "spaceShipButton";
            this.spaceShipButton.Size = new System.Drawing.Size(181, 48);
            this.spaceShipButton.TabIndex = 1;
            this.spaceShipButton.Text = "Space Ship Game";
            this.spaceShipButton.UseVisualStyleBackColor = true;
            this.spaceShipButton.Click += new System.EventHandler(this.spaceShipButton_Click);
            // 
            // dragAndDropButton
            // 
            this.dragAndDropButton.Location = new System.Drawing.Point(122, 207);
            this.dragAndDropButton.Name = "dragAndDropButton";
            this.dragAndDropButton.Size = new System.Drawing.Size(181, 48);
            this.dragAndDropButton.TabIndex = 2;
            this.dragAndDropButton.Text = "Drag and Drop Game";
            this.dragAndDropButton.UseVisualStyleBackColor = true;
            this.dragAndDropButton.Click += new System.EventHandler(this.dragAndDropButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 308);
            this.Controls.Add(this.dragAndDropButton);
            this.Controls.Add(this.spaceShipButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button spaceShipButton;
        private System.Windows.Forms.Button dragAndDropButton;
    }
}

