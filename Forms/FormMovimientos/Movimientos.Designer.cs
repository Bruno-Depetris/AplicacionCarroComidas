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
            this.hopeComboBox_TipoMovimiento = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeComboBox_Medio = new ReaLTaiizor.Controls.HopeComboBox();
            this.hopeRichTextBox_Motivo = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.parrotButton_CargarMovimiento = new ReaLTaiizor.Controls.ParrotButton();
            this.poisonDataGridView_HistorialMovimientos = new ReaLTaiizor.Controls.PoisonDataGridView();
            this.Column_MovimientoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Accion = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel_Senializador.Controls.Add(this.parrotButton_CargarMovimiento);
            this.panel_Senializador.Controls.Add(this.hopeRichTextBox_Motivo);
            this.panel_Senializador.Controls.Add(this.hopeComboBox_Medio);
            this.panel_Senializador.Controls.Add(this.hopeComboBox_TipoMovimiento);
            this.panel_Senializador.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel_Senializador.Location = new System.Drawing.Point(12, 327);
            this.panel_Senializador.Name = "panel_Senializador";
            this.panel_Senializador.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Senializador.Size = new System.Drawing.Size(826, 144);
            this.panel_Senializador.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_Senializador.TabIndex = 4;
            this.panel_Senializador.Text = "panel1";
            // 
            // hopeComboBox_TipoMovimiento
            // 
            this.hopeComboBox_TipoMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeComboBox_TipoMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_TipoMovimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_TipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_TipoMovimiento.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_TipoMovimiento.FormattingEnabled = true;
            this.hopeComboBox_TipoMovimiento.ItemHeight = 30;
            this.hopeComboBox_TipoMovimiento.Location = new System.Drawing.Point(8, 21);
            this.hopeComboBox_TipoMovimiento.Name = "hopeComboBox_TipoMovimiento";
            this.hopeComboBox_TipoMovimiento.Size = new System.Drawing.Size(381, 36);
            this.hopeComboBox_TipoMovimiento.TabIndex = 0;
            // 
            // hopeComboBox_Medio
            // 
            this.hopeComboBox_Medio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeComboBox_Medio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Medio.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Medio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Medio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Medio.FormattingEnabled = true;
            this.hopeComboBox_Medio.ItemHeight = 30;
            this.hopeComboBox_Medio.Location = new System.Drawing.Point(395, 21);
            this.hopeComboBox_Medio.Name = "hopeComboBox_Medio";
            this.hopeComboBox_Medio.Size = new System.Drawing.Size(423, 36);
            this.hopeComboBox_Medio.TabIndex = 1;
            // 
            // hopeRichTextBox_Motivo
            // 
            this.hopeRichTextBox_Motivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hopeRichTextBox_Motivo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeRichTextBox_Motivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeRichTextBox_Motivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeRichTextBox_Motivo.Hint = "Motivo";
            this.hopeRichTextBox_Motivo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRichTextBox_Motivo.Location = new System.Drawing.Point(8, 63);
            this.hopeRichTextBox_Motivo.MaxLength = 32767;
            this.hopeRichTextBox_Motivo.Multiline = true;
            this.hopeRichTextBox_Motivo.Name = "hopeRichTextBox_Motivo";
            this.hopeRichTextBox_Motivo.PasswordChar = '\0';
            this.hopeRichTextBox_Motivo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeRichTextBox_Motivo.SelectedText = "";
            this.hopeRichTextBox_Motivo.SelectionLength = 0;
            this.hopeRichTextBox_Motivo.SelectionStart = 0;
            this.hopeRichTextBox_Motivo.Size = new System.Drawing.Size(687, 73);
            this.hopeRichTextBox_Motivo.TabIndex = 5;
            this.hopeRichTextBox_Motivo.TabStop = false;
            this.hopeRichTextBox_Motivo.Text = "hopeRichTextBox1";
            this.hopeRichTextBox_Motivo.UseSystemPasswordChar = false;
            // 
            // parrotButton_CargarMovimiento
            // 
            this.parrotButton_CargarMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.parrotButton_CargarMovimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_CargarMovimiento.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_CargarMovimiento.ButtonImage")));
            this.parrotButton_CargarMovimiento.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_CargarMovimiento.ButtonText = "";
            this.parrotButton_CargarMovimiento.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_CargarMovimiento.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_CargarMovimiento.CornerRadius = 5;
            this.parrotButton_CargarMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_CargarMovimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_CargarMovimiento.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_CargarMovimiento.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_CargarMovimiento.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_CargarMovimiento.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_CargarMovimiento.Location = new System.Drawing.Point(722, 63);
            this.parrotButton_CargarMovimiento.Name = "parrotButton_CargarMovimiento";
            this.parrotButton_CargarMovimiento.Size = new System.Drawing.Size(75, 73);
            this.parrotButton_CargarMovimiento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_CargarMovimiento.TabIndex = 8;
            this.parrotButton_CargarMovimiento.TextColor = System.Drawing.Color.Black;
            this.parrotButton_CargarMovimiento.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_CargarMovimiento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // poisonDataGridView_HistorialMovimientos
            // 
            this.poisonDataGridView_HistorialMovimientos.AllowUserToAddRows = false;
            this.poisonDataGridView_HistorialMovimientos.AllowUserToResizeRows = false;
            this.poisonDataGridView_HistorialMovimientos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poisonDataGridView_HistorialMovimientos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.poisonDataGridView_HistorialMovimientos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.poisonDataGridView_HistorialMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.poisonDataGridView_HistorialMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.poisonDataGridView_HistorialMovimientos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.poisonDataGridView_HistorialMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.poisonDataGridView_HistorialMovimientos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_MovimientoID,
            this.Column_Fecha,
            this.Column_Accion,
            this.Column_Medio,
            this.Column_Motivo});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
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
            // Column_MovimientoID
            // 
            this.Column_MovimientoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_MovimientoID.HeaderText = "MovimientoID";
            this.Column_MovimientoID.Name = "Column_MovimientoID";
            // 
            // Column_Fecha
            // 
            this.Column_Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Fecha.HeaderText = "Fecha";
            this.Column_Fecha.Name = "Column_Fecha";
            // 
            // Column_Accion
            // 
            this.Column_Accion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Accion.HeaderText = "Accion";
            this.Column_Accion.Name = "Column_Accion";
            // 
            // Column_Medio
            // 
            this.Column_Medio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Medio.HeaderText = "Medio";
            this.Column_Medio.Name = "Column_Medio";
            // 
            // Column_Motivo
            // 
            this.Column_Motivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column_Motivo.HeaderText = "Motivo";
            this.Column_Motivo.Name = "Column_Motivo";
            // 
            // Movimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Medio;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_TipoMovimiento;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_CargarMovimiento;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_HistorialMovimientos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_MovimientoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Accion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Medio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Motivo;
    }
}