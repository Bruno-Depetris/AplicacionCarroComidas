namespace AplicacionCarroComidas.Forms.FormHistorial {
    partial class Historial {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Historial));
            this.panel_Senializador = new ReaLTaiizor.Controls.Panel();
            this.poisonDateTime_Desde = new ReaLTaiizor.Controls.PoisonDateTime();
            this.poisonDateTime_Hasta = new ReaLTaiizor.Controls.PoisonDateTime();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.poisonDataGridView_HistorialVenta = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.parrotButton_Ventas = new ReaLTaiizor.Controls.ParrotButton();
            this.Column_VentaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_FormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Cobrar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column_Imprimir = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel_Senializador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_HistorialVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Senializador
            // 
            this.panel_Senializador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Senializador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.panel_Senializador.Controls.Add(this.parrotButton_Ventas);
            this.panel_Senializador.Controls.Add(this.label2);
            this.panel_Senializador.Controls.Add(this.label1);
            this.panel_Senializador.Controls.Add(this.poisonDateTime_Hasta);
            this.panel_Senializador.Controls.Add(this.poisonDateTime_Desde);
            this.panel_Senializador.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel_Senializador.Location = new System.Drawing.Point(0, -35);
            this.panel_Senializador.Name = "panel_Senializador";
            this.panel_Senializador.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Senializador.Size = new System.Drawing.Size(875, 84);
            this.panel_Senializador.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_Senializador.TabIndex = 3;
            this.panel_Senializador.Text = "panel1";
            // 
            // poisonDateTime_Desde
            // 
            this.poisonDateTime_Desde.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.poisonDateTime_Desde.Location = new System.Drawing.Point(87, 44);
            this.poisonDateTime_Desde.MinimumSize = new System.Drawing.Size(0, 29);
            this.poisonDateTime_Desde.Name = "poisonDateTime_Desde";
            this.poisonDateTime_Desde.Size = new System.Drawing.Size(200, 29);
            this.poisonDateTime_Desde.TabIndex = 4;
            // 
            // poisonDateTime_Hasta
            // 
            this.poisonDateTime_Hasta.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            this.poisonDateTime_Hasta.Location = new System.Drawing.Point(466, 44);
            this.poisonDateTime_Hasta.MinimumSize = new System.Drawing.Size(0, 29);
            this.poisonDateTime_Hasta.Name = "poisonDateTime_Hasta";
            this.poisonDateTime_Hasta.Size = new System.Drawing.Size(200, 29);
            this.poisonDateTime_Hasta.TabIndex = 5;
            this.poisonDateTime_Hasta.ValueChanged += new System.EventHandler(this.poisonDateTime2_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // poisonDataGridView_HistorialVenta
            // 
            this.poisonDataGridView_HistorialVenta.AllowUserToAddRows = false;
            this.poisonDataGridView_HistorialVenta.AllowUserToResizeRows = false;
            this.poisonDataGridView_HistorialVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonDataGridView_HistorialVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_HistorialVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_HistorialVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_HistorialVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_HistorialVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_HistorialVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_HistorialVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_VentaID,
            this.Column_Fecha,
            this.Column_FormaPago,
            this.Column_Pedido,
            this.Column_Total,
            this.Column_Eliminar,
            this.Column_Cobrar,
            this.Column_Imprimir});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_HistorialVenta.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_HistorialVenta.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_HistorialVenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_HistorialVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_HistorialVenta.Location = new System.Drawing.Point(0, 55);
            this.poisonDataGridView_HistorialVenta.Name = "poisonDataGridView_HistorialVenta";
            this.poisonDataGridView_HistorialVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_HistorialVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_HistorialVenta.RowHeadersVisible = false;
            this.poisonDataGridView_HistorialVenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView_HistorialVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_HistorialVenta.Size = new System.Drawing.Size(875, 432);
            this.poisonDataGridView_HistorialVenta.TabIndex = 8;
            // 
            // parrotButton_Ventas
            // 
            this.parrotButton_Ventas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotButton_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Ventas.ButtonImage")));
            this.parrotButton_Ventas.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Ventas.ButtonText = "";
            this.parrotButton_Ventas.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Ventas.CornerRadius = 5;
            this.parrotButton_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Ventas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Ventas.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Ventas.Location = new System.Drawing.Point(815, 36);
            this.parrotButton_Ventas.Name = "parrotButton_Ventas";
            this.parrotButton_Ventas.Size = new System.Drawing.Size(48, 48);
            this.parrotButton_Ventas.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Ventas.TabIndex = 7;
            this.parrotButton_Ventas.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Ventas.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Ventas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // Column_VentaID
            // 
            this.Column_VentaID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_VentaID.HeaderText = "VentaID";
            this.Column_VentaID.Name = "Column_VentaID";
            // 
            // Column_Fecha
            // 
            this.Column_Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Fecha.HeaderText = "Fecha";
            this.Column_Fecha.Name = "Column_Fecha";
            // 
            // Column_FormaPago
            // 
            this.Column_FormaPago.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column_FormaPago.HeaderText = "Forma Pago";
            this.Column_FormaPago.Name = "Column_FormaPago";
            this.Column_FormaPago.Width = 91;
            // 
            // Column_Pedido
            // 
            this.Column_Pedido.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Pedido.HeaderText = "Pedido";
            this.Column_Pedido.Name = "Column_Pedido";
            // 
            // Column_Total
            // 
            this.Column_Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Total.HeaderText = "Total";
            this.Column_Total.Name = "Column_Total";
            // 
            // Column_Eliminar
            // 
            this.Column_Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Eliminar.HeaderText = "Eliminar";
            this.Column_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Eliminar.Image")));
            this.Column_Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column_Eliminar.Name = "Column_Eliminar";
            // 
            // Column_Cobrar
            // 
            this.Column_Cobrar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Cobrar.HeaderText = "Cobrar";
            this.Column_Cobrar.Image = ((System.Drawing.Image)(resources.GetObject("Column_Cobrar.Image")));
            this.Column_Cobrar.Name = "Column_Cobrar";
            this.Column_Cobrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Cobrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column_Imprimir
            // 
            this.Column_Imprimir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Imprimir.HeaderText = "Imprimir";
            this.Column_Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Column_Imprimir.Image")));
            this.Column_Imprimir.Name = "Column_Imprimir";
            this.Column_Imprimir.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column_Imprimir.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 487);
            this.Controls.Add(this.poisonDataGridView_HistorialVenta);
            this.Controls.Add(this.panel_Senializador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.panel_Senializador.ResumeLayout(false);
            this.panel_Senializador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_HistorialVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel_Senializador;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime_Hasta;
        private ReaLTaiizor.Controls.PoisonDateTime poisonDateTime_Desde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_HistorialVenta;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Ventas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_VentaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Total;
        private System.Windows.Forms.DataGridViewImageColumn Column_Eliminar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Cobrar;
        private System.Windows.Forms.DataGridViewImageColumn Column_Imprimir;
    }
}