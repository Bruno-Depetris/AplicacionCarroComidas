namespace AplicacionCarroComidas.Forms.FormMovimientos {
    partial class Movimientos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimientos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_Senializador = new ReaLTaiizor.Controls.Panel();
            this.parrotButton_CargarMovimiento = new ReaLTaiizor.Controls.ParrotButton();
            this.hopeRichTextBox_Motivo = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.poisonDataGridView_HistorialMovimientos = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.hopeComboBox_Tipo = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeComboBox_Metodo = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeTextBox_Monto = new ReaLTaiizor.Controls.HopeTextBox();
            this.Column_MovimientoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Medio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_Senializador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_HistorialMovimientos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Senializador
            // 
            this.panel_Senializador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Senializador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.panel_Senializador.Controls.Add(this.hopeTextBox_Monto);
            this.panel_Senializador.Controls.Add(this.hopeComboBox_Metodo);
            this.panel_Senializador.Controls.Add(this.hopeComboBox_Tipo);
            this.panel_Senializador.Controls.Add(this.parrotButton_CargarMovimiento);
            this.panel_Senializador.Controls.Add(this.hopeRichTextBox_Motivo);
            this.panel_Senializador.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_Senializador.Location = new System.Drawing.Point(12, 327);
            this.panel_Senializador.Name = "panel_Senializador";
            this.panel_Senializador.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Senializador.Size = new System.Drawing.Size(826, 144);
            this.panel_Senializador.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_Senializador.TabIndex = 4;
            this.panel_Senializador.Text = "panel1";
            // 
            // parrotButton_CargarMovimiento
            // 
            this.parrotButton_CargarMovimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.parrotButton_CargarMovimiento.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_CargarMovimiento.ButtonImage")));
            this.parrotButton_CargarMovimiento.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_CargarMovimiento.ButtonText = "";
            this.parrotButton_CargarMovimiento.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_CargarMovimiento.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_CargarMovimiento.CornerRadius = 5;
            this.parrotButton_CargarMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_CargarMovimiento.Dock = System.Windows.Forms.DockStyle.Right;
            this.parrotButton_CargarMovimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_CargarMovimiento.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_CargarMovimiento.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_CargarMovimiento.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_CargarMovimiento.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_CargarMovimiento.Location = new System.Drawing.Point(695, 5);
            this.parrotButton_CargarMovimiento.Name = "parrotButton_CargarMovimiento";
            this.parrotButton_CargarMovimiento.Size = new System.Drawing.Size(126, 134);
            this.parrotButton_CargarMovimiento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_CargarMovimiento.TabIndex = 8;
            this.parrotButton_CargarMovimiento.TextColor = System.Drawing.Color.Black;
            this.parrotButton_CargarMovimiento.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_CargarMovimiento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_CargarMovimiento.Click += new System.EventHandler(this.parrotButton_CargarMovimiento_Click);
            // 
            // hopeRichTextBox_Motivo
            // 
            this.hopeRichTextBox_Motivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeRichTextBox_Motivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hopeRichTextBox_Motivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hopeRichTextBox_Motivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRichTextBox_Motivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.hopeRichTextBox_Motivo.Hint = "Motivo";
            this.hopeRichTextBox_Motivo.HoverBorderColor = System.Drawing.Color.Black;
            this.hopeRichTextBox_Motivo.Location = new System.Drawing.Point(8, 63);
            this.hopeRichTextBox_Motivo.MaxLength = 32767;
            this.hopeRichTextBox_Motivo.Multiline = true;
            this.hopeRichTextBox_Motivo.Name = "hopeRichTextBox_Motivo";
            this.hopeRichTextBox_Motivo.PasswordChar = '\0';
            this.hopeRichTextBox_Motivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeRichTextBox_Motivo.SelectedText = "";
            this.hopeRichTextBox_Motivo.SelectionLength = 0;
            this.hopeRichTextBox_Motivo.SelectionStart = 0;
            this.hopeRichTextBox_Motivo.Size = new System.Drawing.Size(678, 73);
            this.hopeRichTextBox_Motivo.TabIndex = 5;
            this.hopeRichTextBox_Motivo.TabStop = false;
            this.hopeRichTextBox_Motivo.UseSystemPasswordChar = false;
            // 
            // poisonDataGridView_HistorialMovimientos
            // 
            this.poisonDataGridView_HistorialMovimientos.AllowUserToAddRows = false;
            this.poisonDataGridView_HistorialMovimientos.AllowUserToResizeRows = false;
            this.poisonDataGridView_HistorialMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonDataGridView_HistorialMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.poisonDataGridView_HistorialMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_HistorialMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_HistorialMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_HistorialMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_HistorialMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_HistorialMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MovimientoID,
            this.Column_Accion,
            this.Column_Monto,
            this.Column_Medio,
            this.Column_Motivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.poisonDataGridView_HistorialMovimientos.DefaultCellStyle = dataGridViewCellStyle2;
            this.poisonDataGridView_HistorialMovimientos.EnableHeadersVisualStyles = false;
            this.poisonDataGridView_HistorialMovimientos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.poisonDataGridView_HistorialMovimientos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_HistorialMovimientos.Location = new System.Drawing.Point(12, 12);
            this.poisonDataGridView_HistorialMovimientos.Name = "poisonDataGridView_HistorialMovimientos";
            this.poisonDataGridView_HistorialMovimientos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_HistorialMovimientos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.poisonDataGridView_HistorialMovimientos.RowHeadersVisible = false;
            this.poisonDataGridView_HistorialMovimientos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.poisonDataGridView_HistorialMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.poisonDataGridView_HistorialMovimientos.Size = new System.Drawing.Size(826, 309);
            this.poisonDataGridView_HistorialMovimientos.TabIndex = 9;
            // 
            // hopeComboBox_Tipo
            // 
            this.hopeComboBox_Tipo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Tipo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Tipo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Tipo.ForeColor = System.Drawing.Color.Black;
            this.hopeComboBox_Tipo.FormattingEnabled = true;
            this.hopeComboBox_Tipo.ItemHeight = 30;
            this.hopeComboBox_Tipo.Location = new System.Drawing.Point(8, 21);
            this.hopeComboBox_Tipo.Name = "hopeComboBox_Tipo";
            this.hopeComboBox_Tipo.Size = new System.Drawing.Size(276, 36);
            this.hopeComboBox_Tipo.TabIndex = 9;
            // 
            // hopeComboBox_Metodo
            // 
            this.hopeComboBox_Metodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Metodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Metodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Metodo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Metodo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.hopeComboBox_Metodo.FormattingEnabled = true;
            this.hopeComboBox_Metodo.ItemHeight = 30;
            this.hopeComboBox_Metodo.Location = new System.Drawing.Point(291, 22);
            this.hopeComboBox_Metodo.Name = "hopeComboBox_Metodo";
            this.hopeComboBox_Metodo.Size = new System.Drawing.Size(221, 36);
            this.hopeComboBox_Metodo.TabIndex = 10;
            // 
            // hopeTextBox_Monto
            // 
            this.hopeTextBox_Monto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeTextBox_Monto.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_Monto.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.hopeTextBox_Monto.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox_Monto.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_Monto.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox_Monto.ForeColor = System.Drawing.Color.Black;
            this.hopeTextBox_Monto.Hint = "Monto";
            this.hopeTextBox_Monto.Location = new System.Drawing.Point(518, 23);
            this.hopeTextBox_Monto.MaxLength = 32767;
            this.hopeTextBox_Monto.Multiline = false;
            this.hopeTextBox_Monto.Name = "hopeTextBox_Monto";
            this.hopeTextBox_Monto.PasswordChar = '\0';
            this.hopeTextBox_Monto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Monto.SelectedText = "";
            this.hopeTextBox_Monto.SelectionLength = 0;
            this.hopeTextBox_Monto.SelectionStart = 0;
            this.hopeTextBox_Monto.Size = new System.Drawing.Size(168, 38);
            this.hopeTextBox_Monto.TabIndex = 11;
            this.hopeTextBox_Monto.TabStop = false;
            this.hopeTextBox_Monto.UseSystemPasswordChar = false;
            // 
            // Column_MovimientoID
            // 
            this.Column_MovimientoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_MovimientoID.HeaderText = "MovimientoID";
            this.Column_MovimientoID.Name = "Column_MovimientoID";
            // 
            // Column_Accion
            // 
            this.Column_Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Accion.HeaderText = "Tipo";
            this.Column_Accion.Name = "Column_Accion";
            // 
            // Column_Monto
            // 
            this.Column_Monto.HeaderText = "Monto";
            this.Column_Monto.Name = "Column_Monto";
            // 
            // Column_Medio
            // 
            this.Column_Medio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Medio.HeaderText = "Motivo";
            this.Column_Medio.Name = "Column_Medio";
            // 
            // Column_Motivo
            // 
            this.Column_Motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Motivo.HeaderText = "Detalles";
            this.Column_Motivo.Name = "Column_Motivo";
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(850, 483);
            this.Controls.Add(this.poisonDataGridView_HistorialMovimientos);
            this.Controls.Add(this.panel_Senializador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Movimientos";
            this.Text = "Movimientos";
            this.panel_Senializador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.poisonDataGridView_HistorialMovimientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel_Senializador;
        private ReaLTaiizor.Controls.HopeRichTextBox hopeRichTextBox_Motivo;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_CargarMovimiento;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_HistorialMovimientos;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Metodo;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Tipo;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MovimientoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Motivo;
    }
}