namespace Ejercicios456.Ejercicios5
{
    partial class Ejer3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCantidaLados = new System.Windows.Forms.TextBox();
            this.textBoxTamano = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hacer una función que calcule el perímetro de\r\n cualquier polígono regular dando " +
    "el número \r\nde lados y sus dimensiones.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad de lados";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tamano";
            // 
            // textBoxCantidaLados
            // 
            this.textBoxCantidaLados.Location = new System.Drawing.Point(111, 70);
            this.textBoxCantidaLados.Name = "textBoxCantidaLados";
            this.textBoxCantidaLados.Size = new System.Drawing.Size(135, 20);
            this.textBoxCantidaLados.TabIndex = 3;
            // 
            // textBoxTamano
            // 
            this.textBoxTamano.Location = new System.Drawing.Point(111, 111);
            this.textBoxTamano.Name = "textBoxTamano";
            this.textBoxTamano.Size = new System.Drawing.Size(135, 20);
            this.textBoxTamano.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTamano);
            this.Controls.Add(this.textBoxCantidaLados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ejer3";
            this.Text = "Ejer3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCantidaLados;
        private System.Windows.Forms.TextBox textBoxTamano;
        private System.Windows.Forms.Button button1;
    }
}