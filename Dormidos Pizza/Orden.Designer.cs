namespace Dormidos_Pizza
{
    partial class Orden
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
            this.comboSucursales = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboPizzas = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DescripcionText = new System.Windows.Forms.TextBox();
            this.dataGridViewOrden = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butordenar = new System.Windows.Forms.Button();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrden)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sucursal:";
            // 
            // comboSucursales
            // 
            this.comboSucursales.FormattingEnabled = true;
            this.comboSucursales.Location = new System.Drawing.Point(114, 52);
            this.comboSucursales.Name = "comboSucursales";
            this.comboSucursales.Size = new System.Drawing.Size(121, 21);
            this.comboSucursales.TabIndex = 1;
            this.comboSucursales.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pizza:";
            // 
            // comboPizzas
            // 
            this.comboPizzas.FormattingEnabled = true;
            this.comboPizzas.Location = new System.Drawing.Point(542, 66);
            this.comboPizzas.Name = "comboPizzas";
            this.comboPizzas.Size = new System.Drawing.Size(121, 21);
            this.comboPizzas.TabIndex = 3;
            this.comboPizzas.SelectedIndexChanged += new System.EventHandler(this.comboPizzas_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // DescripcionText
            // 
            this.DescripcionText.Location = new System.Drawing.Point(42, 165);
            this.DescripcionText.Multiline = true;
            this.DescripcionText.Name = "DescripcionText";
            this.DescripcionText.Size = new System.Drawing.Size(399, 47);
            this.DescripcionText.TabIndex = 5;
            this.DescripcionText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridViewOrden
            // 
            this.dataGridViewOrden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Pizza,
            this.Descripcion,
            this.Sucursal});
            this.dataGridViewOrden.Location = new System.Drawing.Point(42, 240);
            this.dataGridViewOrden.Name = "dataGridViewOrden";
            this.dataGridViewOrden.Size = new System.Drawing.Size(729, 111);
            this.dataGridViewOrden.TabIndex = 7;
            this.dataGridViewOrden.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Pizza
            // 
            this.Pizza.HeaderText = "Pizza";
            this.Pizza.Name = "Pizza";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Sucursal
            // 
            this.Sucursal.HeaderText = "Sucursal";
            this.Sucursal.Name = "Sucursal";
            // 
            // butordenar
            // 
            this.butordenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butordenar.Location = new System.Drawing.Point(634, 182);
            this.butordenar.Name = "butordenar";
            this.butordenar.Size = new System.Drawing.Size(117, 30);
            this.butordenar.TabIndex = 9;
            this.butordenar.Text = "Ordenar";
            this.butordenar.UseVisualStyleBackColor = true;
            this.butordenar.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(463, 182);
            this.textBoxPrecio.Multiline = true;
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(112, 30);
            this.textBoxPrecio.TabIndex = 10;
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.butordenar);
            this.Controls.Add(this.dataGridViewOrden);
            this.Controls.Add(this.DescripcionText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboPizzas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboSucursales);
            this.Controls.Add(this.label1);
            this.Name = "Orden";
            this.Text = "Orden";
            this.Load += new System.EventHandler(this.Orden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboSucursales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboPizzas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DescripcionText;
        private System.Windows.Forms.DataGridView dataGridViewOrden;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sucursal;
        private System.Windows.Forms.Button butordenar;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}