namespace Practicando.Registro
{
    partial class FormAddPersonas
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
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewTelefonos = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.ColumnTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonos)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(12, 42);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(88, 20);
            this.numericUpDownId.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(15, 103);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(190, 20);
            this.textBoxNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "Casa",
            "Telefonos",
            "Celular"});
            this.comboBoxTipo.Location = new System.Drawing.Point(15, 157);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo";
            // 
            // textBoxNumero
            // 
            this.textBoxNumero.Location = new System.Drawing.Point(157, 158);
            this.textBoxNumero.Name = "textBoxNumero";
            this.textBoxNumero.Size = new System.Drawing.Size(151, 20);
            this.textBoxNumero.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(154, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(120, 34);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(64, 33);
            this.buttonBuscar.TabIndex = 8;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTelefonos
            // 
            this.dataGridViewTelefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTelefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTipo,
            this.ColumnNumero});
            this.dataGridViewTelefonos.Location = new System.Drawing.Point(15, 190);
            this.dataGridViewTelefonos.Name = "dataGridViewTelefonos";
            this.dataGridViewTelefonos.Size = new System.Drawing.Size(384, 150);
            this.dataGridViewTelefonos.TabIndex = 9;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(335, 151);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(64, 33);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Location = new System.Drawing.Point(100, 369);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(64, 33);
            this.buttonNuevo.TabIndex = 11;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(186, 369);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(64, 33);
            this.buttonEliminar.TabIndex = 12;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(266, 369);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(64, 33);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // ColumnTipo
            // 
            this.ColumnTipo.HeaderText = "Tipo";
            this.ColumnTipo.Name = "ColumnTipo";
            this.ColumnTipo.Width = 130;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Numero";
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.Width = 210;
            // 
            // FormAddPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 424);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridViewTelefonos);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxNumero);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownId);
            this.Name = "FormAddPersonas";
            this.Text = "FormAddPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTelefonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.DataGridView dataGridViewTelefonos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}