namespace ExamenDetalles.Register
{
    partial class ClienteTelefonos
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
            this.NumerosdataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.NumerotextBox = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.TiposcomboBox = new System.Windows.Forms.ComboBox();
            this.IdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumerosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NumerosdataGridView
            // 
            this.NumerosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NumerosdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTipo,
            this.ColumnNumero});
            this.NumerosdataGridView.Location = new System.Drawing.Point(71, 185);
            this.NumerosdataGridView.Name = "NumerosdataGridView";
            this.NumerosdataGridView.Size = new System.Drawing.Size(446, 150);
            this.NumerosdataGridView.TabIndex = 0;
            this.NumerosdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NumerosdataGridView_CellContentClick);
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Numero";
            this.ColumnNumero.Name = "ColumnNumero";
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(194, 357);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 1;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(506, 125);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(75, 23);
            this.Addbutton.TabIndex = 2;
            this.Addbutton.Text = "Add";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // NumerotextBox
            // 
            this.NumerotextBox.Location = new System.Drawing.Point(359, 128);
            this.NumerotextBox.Name = "NumerotextBox";
            this.NumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.NumerotextBox.TabIndex = 3;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 407);
            this.splitter1.TabIndex = 4;
            this.splitter1.TabStop = false;
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(210, 84);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(249, 20);
            this.NombretextBox.TabIndex = 5;
            // 
            // TiposcomboBox
            // 
            this.TiposcomboBox.FormattingEnabled = true;
            this.TiposcomboBox.Items.AddRange(new object[] {
            "Casa",
            "Telefono",
            "Celular"});
            this.TiposcomboBox.Location = new System.Drawing.Point(106, 126);
            this.TiposcomboBox.Name = "TiposcomboBox";
            this.TiposcomboBox.Size = new System.Drawing.Size(121, 21);
            this.TiposcomboBox.TabIndex = 6;
            // 
            // IdnumericUpDown
            // 
            this.IdnumericUpDown.Location = new System.Drawing.Point(62, 34);
            this.IdnumericUpDown.Name = "IdnumericUpDown";
            this.IdnumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.IdnumericUpDown.TabIndex = 7;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Location = new System.Drawing.Point(381, 30);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechadateTimePicker.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "label5";
            // 
            // ClienteTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 407);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.IdnumericUpDown);
            this.Controls.Add(this.TiposcomboBox);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.NumerotextBox);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.NumerosdataGridView);
            this.Name = "ClienteTelefonos";
            this.Text = "ClienteTelefonos";
            ((System.ComponentModel.ISupportInitialize)(this.NumerosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdnumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView NumerosdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.TextBox NumerotextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.ComboBox TiposcomboBox;
        private System.Windows.Forms.NumericUpDown IdnumericUpDown;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}