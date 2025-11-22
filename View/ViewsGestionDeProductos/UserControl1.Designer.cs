namespace ViewsGestionDeProductos
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.nombrelbl = new System.Windows.Forms.Label();
            this.preciolbl = new System.Windows.Forms.Label();
            this.nombretxt = new System.Windows.Forms.TextBox();
            this.preciotxt = new System.Windows.Forms.TextBox();
            this.NombreBtn = new System.Windows.Forms.Button();
            this.EditarBtn = new System.Windows.Forms.Button();
            this.EliminarBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nombrelbl
            // 
            this.nombrelbl.AutoSize = true;
            this.nombrelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombrelbl.Location = new System.Drawing.Point(90, 85);
            this.nombrelbl.Name = "nombrelbl";
            this.nombrelbl.Size = new System.Drawing.Size(107, 29);
            this.nombrelbl.TabIndex = 0;
            this.nombrelbl.Text = "Nombre";
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciolbl.Location = new System.Drawing.Point(93, 168);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(89, 29);
            this.preciolbl.TabIndex = 1;
            this.preciolbl.Text = "Precio";
            // 
            // nombretxt
            // 
            this.nombretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombretxt.Location = new System.Drawing.Point(288, 78);
            this.nombretxt.Name = "nombretxt";
            this.nombretxt.Size = new System.Drawing.Size(150, 34);
            this.nombretxt.TabIndex = 2;
            // 
            // preciotxt
            // 
            this.preciotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciotxt.Location = new System.Drawing.Point(288, 161);
            this.preciotxt.Name = "preciotxt";
            this.preciotxt.Size = new System.Drawing.Size(150, 34);
            this.preciotxt.TabIndex = 3;
            // 
            // NombreBtn
            // 
            this.NombreBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreBtn.Location = new System.Drawing.Point(74, 356);
            this.NombreBtn.Name = "NombreBtn";
            this.NombreBtn.Size = new System.Drawing.Size(160, 73);
            this.NombreBtn.TabIndex = 4;
            this.NombreBtn.Text = "Nombre";
            this.NombreBtn.UseVisualStyleBackColor = true;
            // 
            // EditarBtn
            // 
            this.EditarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarBtn.Location = new System.Drawing.Point(319, 356);
            this.EditarBtn.Name = "EditarBtn";
            this.EditarBtn.Size = new System.Drawing.Size(149, 73);
            this.EditarBtn.TabIndex = 5;
            this.EditarBtn.Text = "Editar";
            this.EditarBtn.UseVisualStyleBackColor = true;
            // 
            // EliminarBtn
            // 
            this.EliminarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarBtn.Location = new System.Drawing.Point(568, 356);
            this.EliminarBtn.Name = "EliminarBtn";
            this.EliminarBtn.Size = new System.Drawing.Size(140, 73);
            this.EliminarBtn.TabIndex = 6;
            this.EliminarBtn.Text = "Eliminar";
            this.EliminarBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(545, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EliminarBtn);
            this.Controls.Add(this.EditarBtn);
            this.Controls.Add(this.NombreBtn);
            this.Controls.Add(this.preciotxt);
            this.Controls.Add(this.nombretxt);
            this.Controls.Add(this.preciolbl);
            this.Controls.Add(this.nombrelbl);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(842, 513);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombrelbl;
        private System.Windows.Forms.Label preciolbl;
        private System.Windows.Forms.TextBox nombretxt;
        private System.Windows.Forms.TextBox preciotxt;
        private System.Windows.Forms.Button NombreBtn;
        private System.Windows.Forms.Button EditarBtn;
        private System.Windows.Forms.Button EliminarBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
