namespace Ejercicios456.Ejercicios4
{
    partial class Ejercicio2
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxElevar = new System.Windows.Forms.TextBox();
            this.textBoxPotencia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hacer un programa que calcule el resultado de un número\r\nelevado a cualquier pote" +
    "ncia.\r\n\r\n";
            // 
            // textBoxElevar
            // 
            this.textBoxElevar.Location = new System.Drawing.Point(150, 77);
            this.textBoxElevar.Name = "textBoxElevar";
            this.textBoxElevar.Size = new System.Drawing.Size(125, 20);
            this.textBoxElevar.TabIndex = 2;
            // 
            // textBoxPotencia
            // 
            this.textBoxPotencia.Location = new System.Drawing.Point(150, 139);
            this.textBoxPotencia.Name = "textBoxPotencia";
            this.textBoxPotencia.Size = new System.Drawing.Size(125, 20);
            this.textBoxPotencia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese el numero a elevar ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese la potencia";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPotencia);
            this.Controls.Add(this.textBoxElevar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxElevar;
        private System.Windows.Forms.TextBox textBoxPotencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}