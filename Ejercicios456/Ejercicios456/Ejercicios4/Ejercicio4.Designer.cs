namespace Ejercicios456.Ejercicios4
{
    partial class Ejercicio4
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxPrimo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer un programa que encuentre los números \r\nprimos que existen entre el 1 y el " +
    "1000.";
            // 
            // listBoxPrimo
            // 
            this.listBoxPrimo.FormattingEnabled = true;
            this.listBoxPrimo.Location = new System.Drawing.Point(27, 82);
            this.listBoxPrimo.Name = "listBoxPrimo";
            this.listBoxPrimo.Size = new System.Drawing.Size(229, 95);
            this.listBoxPrimo.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxPrimo);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio4";
            this.Text = "Ejercicio4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxPrimo;
        private System.Windows.Forms.Button button1;
    }
}