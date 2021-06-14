namespace Dormidos_Pizza
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.btonadmon = new System.Windows.Forms.Button();
            this.btonorden = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(252, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 65);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dormidos pizza";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btonadmon
            // 
            this.btonadmon.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonadmon.ForeColor = System.Drawing.Color.Red;
            this.btonadmon.Location = new System.Drawing.Point(353, 111);
            this.btonadmon.Name = "btonadmon";
            this.btonadmon.Size = new System.Drawing.Size(237, 93);
            this.btonadmon.TabIndex = 3;
            this.btonadmon.Text = "Administracion";
            this.btonadmon.UseVisualStyleBackColor = true;
            this.btonadmon.Click += new System.EventHandler(this.button1_Click);
            // 
            // btonorden
            // 
            this.btonorden.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonorden.ForeColor = System.Drawing.Color.Blue;
            this.btonorden.Location = new System.Drawing.Point(353, 229);
            this.btonorden.Name = "btonorden";
            this.btonorden.Size = new System.Drawing.Size(237, 85);
            this.btonorden.TabIndex = 4;
            this.btonorden.Text = "Orden";
            this.btonorden.UseVisualStyleBackColor = true;
            this.btonorden.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Dormidos_Pizza.Properties.Resources.apps_32173_13849716860089408_3802651d_7622_47c7_bcb5_d2b6ad47b5fc;
            this.pictureBox1.Location = new System.Drawing.Point(703, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 694);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btonorden);
            this.Controls.Add(this.btonadmon);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.Text = "dormidos pizza";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btonadmon;
        private System.Windows.Forms.Button btonorden;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

