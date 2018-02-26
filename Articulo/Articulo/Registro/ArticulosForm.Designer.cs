namespace Articulo.Registro
{
    partial class ArticulosForm
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
            this.IdAnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DescrpciontextBox = new System.Windows.Forms.TextBox();
            this.PreciotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdAnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // IdAnumericUpDown
            // 
            this.IdAnumericUpDown.Location = new System.Drawing.Point(12, 41);
            this.IdAnumericUpDown.Name = "IdAnumericUpDown";
            this.IdAnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdAnumericUpDown.TabIndex = 0;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(164, 30);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 38);
            this.Buscarbutton.TabIndex = 1;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar por ID";
            // 
            // DescrpciontextBox
            // 
            this.DescrpciontextBox.Location = new System.Drawing.Point(12, 138);
            this.DescrpciontextBox.Multiline = true;
            this.DescrpciontextBox.Name = "DescrpciontextBox";
            this.DescrpciontextBox.Size = new System.Drawing.Size(355, 58);
            this.DescrpciontextBox.TabIndex = 3;
            // 
            // PreciotextBox
            // 
            this.PreciotextBox.Location = new System.Drawing.Point(12, 230);
            this.PreciotextBox.Name = "PreciotextBox";
            this.PreciotextBox.Size = new System.Drawing.Size(130, 20);
            this.PreciotextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descripcion";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(258, 291);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 38);
            this.Guardarbutton.TabIndex = 7;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(12, 291);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(75, 38);
            this.Nuevobutton.TabIndex = 9;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // ArticulosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 354);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PreciotextBox);
            this.Controls.Add(this.DescrpciontextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.IdAnumericUpDown);
            this.Name = "ArticulosForm";
            this.Text = "ArticulosForm";
            ((System.ComponentModel.ISupportInitialize)(this.IdAnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IdAnumericUpDown;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescrpciontextBox;
        private System.Windows.Forms.TextBox PreciotextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Nuevobutton;
    }
}