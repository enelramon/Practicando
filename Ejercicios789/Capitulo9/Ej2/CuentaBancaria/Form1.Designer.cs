namespace CuentaBancaria
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.DineroCuenta = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.Label();
            this.Contraseña = new System.Windows.Forms.Label();
            this.NumeroCuentamasked = new System.Windows.Forms.MaskedTextBox();
            this.NombreText = new System.Windows.Forms.TextBox();
            this.UsuarioCuenta = new System.Windows.Forms.TextBox();
            this.DineroText = new System.Windows.Forms.MaskedTextBox();
            this.Passtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(186, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "FINALIZAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero de Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Propietario de Cuenta";
            // 
            // DineroCuenta
            // 
            this.DineroCuenta.AutoSize = true;
            this.DineroCuenta.Location = new System.Drawing.Point(31, 175);
            this.DineroCuenta.Name = "DineroCuenta";
            this.DineroCuenta.Size = new System.Drawing.Size(90, 13);
            this.DineroCuenta.TabIndex = 3;
            this.DineroCuenta.Text = "Dinero de Cuenta";
            // 
            // Usuario
            // 
            this.Usuario.AutoSize = true;
            this.Usuario.Location = new System.Drawing.Point(31, 227);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(43, 13);
            this.Usuario.TabIndex = 4;
            this.Usuario.Text = "Usuario";
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(31, 274);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 5;
            this.Contraseña.Text = "Contraseña";
            // 
            // NumeroCuentamasked
            // 
            this.NumeroCuentamasked.Location = new System.Drawing.Point(186, 52);
            this.NumeroCuentamasked.Mask = "0000-0000-0000-0000";
            this.NumeroCuentamasked.Name = "NumeroCuentamasked";
            this.NumeroCuentamasked.Size = new System.Drawing.Size(121, 20);
            this.NumeroCuentamasked.TabIndex = 6;
            // 
            // NombreText
            // 
            this.NombreText.Location = new System.Drawing.Point(186, 112);
            this.NombreText.Name = "NombreText";
            this.NombreText.Size = new System.Drawing.Size(121, 20);
            this.NombreText.TabIndex = 7;
            // 
            // UsuarioCuenta
            // 
            this.UsuarioCuenta.Location = new System.Drawing.Point(186, 227);
            this.UsuarioCuenta.Name = "UsuarioCuenta";
            this.UsuarioCuenta.Size = new System.Drawing.Size(121, 20);
            this.UsuarioCuenta.TabIndex = 8;
            // 
            // DineroText
            // 
            this.DineroText.Location = new System.Drawing.Point(186, 175);
            this.DineroText.Mask = "99999";
            this.DineroText.Name = "DineroText";
            this.DineroText.Size = new System.Drawing.Size(121, 20);
            this.DineroText.TabIndex = 9;
            this.DineroText.ValidatingType = typeof(int);
            // 
            // Passtext
            // 
            this.Passtext.Location = new System.Drawing.Point(186, 274);
            this.Passtext.Name = "Passtext";
            this.Passtext.Size = new System.Drawing.Size(121, 20);
            this.Passtext.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CUENTA BANCARIA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 372);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Passtext);
            this.Controls.Add(this.DineroText);
            this.Controls.Add(this.UsuarioCuenta);
            this.Controls.Add(this.NombreText);
            this.Controls.Add(this.NumeroCuentamasked);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.DineroCuenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DineroCuenta;
        private System.Windows.Forms.Label Usuario;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.MaskedTextBox NumeroCuentamasked;
        private System.Windows.Forms.TextBox NombreText;
        private System.Windows.Forms.TextBox UsuarioCuenta;
        private System.Windows.Forms.MaskedTextBox DineroText;
        private System.Windows.Forms.TextBox Passtext;
        private System.Windows.Forms.Label label3;
    }
}

