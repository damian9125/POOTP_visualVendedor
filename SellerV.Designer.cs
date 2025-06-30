namespace POOTP_visualVendedor
{
    partial class Seller
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
            this.Dgv_Articulos = new System.Windows.Forms.DataGridView();
            this.Articulos = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Busqueda = new System.Windows.Forms.Label();
            this.vendedor = new System.Windows.Forms.Label();
            this.Txt_Busqueda = new System.Windows.Forms.TextBox();
            this.Txt_Vendedor = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_SiguienteUno = new System.Windows.Forms.Button();
            this.Dgv_Pedido = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Articulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pedido)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Articulos
            // 
            this.Dgv_Articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Articulos.Location = new System.Drawing.Point(48, 134);
            this.Dgv_Articulos.Name = "Dgv_Articulos";
            this.Dgv_Articulos.Size = new System.Drawing.Size(476, 256);
            this.Dgv_Articulos.TabIndex = 0;
            // 
            // Articulos
            // 
            this.Articulos.AutoSize = true;
            this.Articulos.BackColor = System.Drawing.Color.White;
            this.Articulos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Articulos.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Articulos.Location = new System.Drawing.Point(48, 72);
            this.Articulos.Name = "Articulos";
            this.Articulos.Size = new System.Drawing.Size(122, 25);
            this.Articulos.TabIndex = 2;
            this.Articulos.Text = "Articulos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(577, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pedido:";
            // 
            // Busqueda
            // 
            this.Busqueda.AutoSize = true;
            this.Busqueda.BackColor = System.Drawing.Color.White;
            this.Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Busqueda.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Busqueda.Location = new System.Drawing.Point(45, 31);
            this.Busqueda.Name = "Busqueda";
            this.Busqueda.Size = new System.Drawing.Size(67, 13);
            this.Busqueda.TabIndex = 4;
            this.Busqueda.Text = "Busqueda:";
            // 
            // vendedor
            // 
            this.vendedor.AutoSize = true;
            this.vendedor.BackColor = System.Drawing.Color.White;
            this.vendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedor.Location = new System.Drawing.Point(901, 17);
            this.vendedor.Name = "vendedor";
            this.vendedor.Size = new System.Drawing.Size(65, 13);
            this.vendedor.TabIndex = 5;
            this.vendedor.Text = "Vendedor:";
            // 
            // Txt_Busqueda
            // 
            this.Txt_Busqueda.Location = new System.Drawing.Point(118, 28);
            this.Txt_Busqueda.Name = "Txt_Busqueda";
            this.Txt_Busqueda.Size = new System.Drawing.Size(121, 20);
            this.Txt_Busqueda.TabIndex = 7;
            // 
            // Txt_Vendedor
            // 
            this.Txt_Vendedor.Location = new System.Drawing.Point(972, 14);
            this.Txt_Vendedor.Name = "Txt_Vendedor";
            this.Txt_Vendedor.Size = new System.Drawing.Size(111, 20);
            this.Txt_Vendedor.TabIndex = 8;
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.BackColor = System.Drawing.Color.White;
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(800, 393);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(72, 24);
            this.Total.TabIndex = 9;
            this.Total.Text = "TOTAL:";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Location = new System.Drawing.Point(878, 395);
            this.Txt_Total.Multiline = true;
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(203, 22);
            this.Txt_Total.TabIndex = 10;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Agregar.Location = new System.Drawing.Point(443, 393);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(81, 33);
            this.Btn_Agregar.TabIndex = 11;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(577, 396);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(81, 33);
            this.Btn_Eliminar.TabIndex = 12;
            this.Btn_Eliminar.Text = "ELIMINAR";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(12, 471);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(81, 33);
            this.Btn_Cancelar.TabIndex = 13;
            this.Btn_Cancelar.Text = "CANCELAR";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_SiguienteUno
            // 
            this.Btn_SiguienteUno.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SiguienteUno.Location = new System.Drawing.Point(1002, 471);
            this.Btn_SiguienteUno.Name = "Btn_SiguienteUno";
            this.Btn_SiguienteUno.Size = new System.Drawing.Size(81, 33);
            this.Btn_SiguienteUno.TabIndex = 14;
            this.Btn_SiguienteUno.Text = "SIGUENTE";
            this.Btn_SiguienteUno.UseVisualStyleBackColor = true;
            // 
            // Dgv_Pedido
            // 
            this.Dgv_Pedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Pedido.Location = new System.Drawing.Point(577, 134);
            this.Dgv_Pedido.Name = "Dgv_Pedido";
            this.Dgv_Pedido.Size = new System.Drawing.Size(506, 256);
            this.Dgv_Pedido.TabIndex = 15;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1105, 516);
            this.Controls.Add(this.Dgv_Pedido);
            this.Controls.Add(this.Btn_SiguienteUno);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Agregar);
            this.Controls.Add(this.Txt_Total);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Txt_Vendedor);
            this.Controls.Add(this.Txt_Busqueda);
            this.Controls.Add(this.vendedor);
            this.Controls.Add(this.Busqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Articulos);
            this.Controls.Add(this.Dgv_Articulos);
            this.Name = "Seller";
            this.Text = "Seller";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Articulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Pedido)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Articulos;
        private System.Windows.Forms.Label Articulos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Busqueda;
        private System.Windows.Forms.Label vendedor;
        private System.Windows.Forms.TextBox Txt_Busqueda;
        private System.Windows.Forms.TextBox Txt_Vendedor;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_SiguienteUno;
        private System.Windows.Forms.DataGridView Dgv_Pedido;
    }
}

