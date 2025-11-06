namespace AplicacionCarroComidas.Forms.Vender {
    partial class Vender {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_TotalDetalle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.poisonDataGridView_DetalleVenta = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column_PorductoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.parrotButton1 = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Ventas = new ReaLTaiizor.Controls.ParrotButton();
            this.panel20 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel_Productos = new System.Windows.Forms.FlowLayoutPanel();
            this.parrotButton_AgregarProducto = new ReaLTaiizor.Controls.ParrotButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_DetalleVenta)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_TotalDetalle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.poisonDataGridView_DetalleVenta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.parrotButton1);
            this.panel1.Controls.Add(this.parrotButton_Ventas);
            this.panel1.Controls.Add(this.panel20);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(588, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 519);
            this.panel1.TabIndex = 21;
            // 
            // label_TotalDetalle
            // 
            this.label_TotalDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_TotalDetalle.AutoSize = true;
            this.label_TotalDetalle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label_TotalDetalle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_TotalDetalle.ForeColor = System.Drawing.Color.White;
            this.label_TotalDetalle.Location = new System.Drawing.Point(69, 394);
            this.label_TotalDetalle.Name = "label_TotalDetalle";
            this.label_TotalDetalle.Size = new System.Drawing.Size(37, 20);
            this.label_TotalDetalle.TabIndex = 9;
            this.label_TotalDetalle.Text = "0.00";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 394);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total: $";
            // 
            // poisonDataGridView_DetalleVenta
            // 
            this.poisonDataGridView_DetalleVenta.AccessibleDescription = "Public";
            this.poisonDataGridView_DetalleVenta.AllowUserToAddRows = false;
            this.poisonDataGridView_DetalleVenta.AllowUserToResizeRows = false;
            this.poisonDataGridView_DetalleVenta.BackgroundColor = System.Drawing.Color.White;
            this.poisonDataGridView_DetalleVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_DetalleVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_DetalleVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_DetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_DetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_DetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_PorductoID,
            this.Column_Producto,
            this.Column_Precio,
            this.Column_Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_DetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_DetalleVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.poisonDataGridView_DetalleVenta.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_DetalleVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_DetalleVenta.GridColor = System.Drawing.Color.White;
            this.poisonDataGridView_DetalleVenta.Location = new System.Drawing.Point(1, 55);
            this.poisonDataGridView_DetalleVenta.Name = "poisonDataGridView_DetalleVenta";
            this.poisonDataGridView_DetalleVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_DetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_DetalleVenta.RowHeadersVisible = false;
            this.poisonDataGridView_DetalleVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView_DetalleVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_DetalleVenta.Size = new System.Drawing.Size(240, 321);
            this.poisonDataGridView_DetalleVenta.TabIndex = 7;
            this.poisonDataGridView_DetalleVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.poisonDataGridView_DetalleVenta_CellContentClick);
            // 
            // Column_PorductoID
            // 
            this.Column_PorductoID.HeaderText = "ProductoID";
            this.Column_PorductoID.Name = "Column_PorductoID";
            this.Column_PorductoID.Visible = false;
            // 
            // Column_Producto
            // 
            this.Column_Producto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Producto.FillWeight = 200F;
            this.Column_Producto.HeaderText = "Producto";
            this.Column_Producto.Name = "Column_Producto";
            // 
            // Column_Precio
            // 
            this.Column_Precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Precio.HeaderText = "Precio";
            this.Column_Precio.Name = "Column_Precio";
            // 
            // Column_Eliminar
            // 
            this.Column_Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Eliminar.HeaderText = "Eliminar";
            this.Column_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Eliminar.Image")));
            this.Column_Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Eliminar.Name = "Column_Eliminar";
            this.Column_Eliminar.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bigLabel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 55);
            this.panel3.TabIndex = 6;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel1.ForeColor = System.Drawing.Color.Silver;
            this.bigLabel1.Location = new System.Drawing.Point(42, 5);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(139, 46);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Detalles";
            // 
            // parrotButton1
            // 
            this.parrotButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.parrotButton1.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton1.ButtonImage")));
            this.parrotButton1.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton1.ButtonText = "Volver";
            this.parrotButton1.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton1.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton1.CornerRadius = 5;
            this.parrotButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotButton1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.parrotButton1.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton1.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton1.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton1.Location = new System.Drawing.Point(1, 419);
            this.parrotButton1.Name = "parrotButton1";
            this.parrotButton1.Size = new System.Drawing.Size(240, 50);
            this.parrotButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton1.TabIndex = 5;
            this.parrotButton1.TextColor = System.Drawing.Color.Black;
            this.parrotButton1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton1.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton1.Click += new System.EventHandler(this.parrotButton1_Click);
            // 
            // parrotButton_Ventas
            // 
            this.parrotButton_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.parrotButton_Ventas.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Ventas.ButtonImage")));
            this.parrotButton_Ventas.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Ventas.ButtonText = "Cargar";
            this.parrotButton_Ventas.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Ventas.CornerRadius = 5;
            this.parrotButton_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Ventas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotButton_Ventas.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.parrotButton_Ventas.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Ventas.Location = new System.Drawing.Point(1, 469);
            this.parrotButton_Ventas.Name = "parrotButton_Ventas";
            this.parrotButton_Ventas.Size = new System.Drawing.Size(240, 50);
            this.parrotButton_Ventas.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Ventas.TabIndex = 4;
            this.parrotButton_Ventas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Ventas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.Click += new System.EventHandler(this.parrotButton_Ventas_Click);
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel20.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1, 519);
            this.panel20.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.flowLayoutPanel_Productos);
            this.panel12.Controls.Add(this.parrotButton_AgregarProducto);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(12);
            this.panel12.Size = new System.Drawing.Size(588, 519);
            this.panel12.TabIndex = 24;
            // 
            // flowLayoutPanel_Productos
            // 
            this.flowLayoutPanel_Productos.AutoScroll = true;
            this.flowLayoutPanel_Productos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel_Productos.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel_Productos.Name = "flowLayoutPanel_Productos";
            this.flowLayoutPanel_Productos.Padding = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanel_Productos.Size = new System.Drawing.Size(564, 455);
            this.flowLayoutPanel_Productos.TabIndex = 0;
            // 
            // parrotButton_AgregarProducto
            // 
            this.parrotButton_AgregarProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.parrotButton_AgregarProducto.ButtonImage = null;
            this.parrotButton_AgregarProducto.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_AgregarProducto.ButtonText = "Agregar producto";
            this.parrotButton_AgregarProducto.ClickBackColor = System.Drawing.Color.White;
            this.parrotButton_AgregarProducto.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_AgregarProducto.CornerRadius = 6;
            this.parrotButton_AgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_AgregarProducto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotButton_AgregarProducto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.parrotButton_AgregarProducto.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_AgregarProducto.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.parrotButton_AgregarProducto.HoverTextColor = System.Drawing.Color.DodgerBlue;
            this.parrotButton_AgregarProducto.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_AgregarProducto.Location = new System.Drawing.Point(12, 467);
            this.parrotButton_AgregarProducto.Name = "parrotButton_AgregarProducto";
            this.parrotButton_AgregarProducto.Size = new System.Drawing.Size(564, 40);
            this.parrotButton_AgregarProducto.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_AgregarProducto.TabIndex = 1;
            this.parrotButton_AgregarProducto.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_AgregarProducto.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_AgregarProducto.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_AgregarProducto.Click += new System.EventHandler(this.parrotButton_AgregarProducto_Click_1);
            // 
            // Vender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 519);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vender";
            this.Text = "Vender";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_DetalleVenta)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_DetalleVenta;
        private System.Windows.Forms.Panel panel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Ventas;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label label_TotalDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_PorductoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Precio;
        private System.Windows.Forms.DataGridViewImageColumn Column_Eliminar;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_AgregarProducto;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Productos;
    }
}