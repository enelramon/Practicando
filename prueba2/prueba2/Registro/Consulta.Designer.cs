namespace prueba2.Registro
{
    partial class Consulta
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
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.textBoxBusqueda = new System.Windows.Forms.TextBox();
            this.dataGridViewMostrar = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFiltrar
            // 
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Items.AddRange(new object[] {
            "TipoId",
            "Descripcion"});
            this.comboBoxFiltrar.Location = new System.Drawing.Point(12, 36);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFiltrar.TabIndex = 0;
            // 
            // textBoxBusqueda
            // 
            this.textBoxBusqueda.Location = new System.Drawing.Point(163, 36);
            this.textBoxBusqueda.Name = "textBoxBusqueda";
            this.textBoxBusqueda.Size = new System.Drawing.Size(262, 20);
            this.textBoxBusqueda.TabIndex = 1;
            // 
            // dataGridViewMostrar
            // 
            this.dataGridViewMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMostrar.Location = new System.Drawing.Point(12, 79);
            this.dataGridViewMostrar.Name = "dataGridViewMostrar";
            this.dataGridViewMostrar.Size = new System.Drawing.Size(529, 150);
            this.dataGridViewMostrar.TabIndex = 2;
            this.dataGridViewMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Buscar por";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Filtro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(466, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewMostrar);
            this.Controls.Add(this.textBoxBusqueda);
            this.Controls.Add(this.comboBoxFiltrar);
            this.Name = "Consulta";
            this.Text = "Consulta";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFiltrar;
        private System.Windows.Forms.TextBox textBoxBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}