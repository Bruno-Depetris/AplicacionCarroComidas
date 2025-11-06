namespace AplicacionCarroComidas.Forms.Vender {
    partial class AgregarProducto {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent() {
            this.panel_Principal = new System.Windows.Forms.Panel();
            this.panel_Contenido = new System.Windows.Forms.Panel();
            this.lblDescripcionPrecio = new System.Windows.Forms.Label();
            this.hopeTextBox_Precio = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblDescripcionNombre = new System.Windows.Forms.Label();
            this.hopeTextBox_Nombre = new ReaLTaiizor.Controls.HopeTextBox();
            this.panel_Footer = new System.Windows.Forms.Panel();
            this.parrotButton_Cancelar = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Agregar = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Header = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel_Principal.SuspendLayout();
            this.panel_Contenido.SuspendLayout();
            this.panel_Footer.SuspendLayout();
            this.panel_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Principal
            // 
            this.panel_Principal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel_Principal.Controls.Add(this.panel_Contenido);
            this.panel_Principal.Controls.Add(this.panel_Footer);
            this.panel_Principal.Controls.Add(this.panel_Header);
            this.panel_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Principal.Location = new System.Drawing.Point(0, 0);
            this.panel_Principal.Name = "panel_Principal";
            this.panel_Principal.Padding = new System.Windows.Forms.Padding(2);
            this.panel_Principal.Size = new System.Drawing.Size(500, 320);
            this.panel_Principal.TabIndex = 0;
            // 
            // panel_Contenido
            // 
            this.panel_Contenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel_Contenido.Controls.Add(this.lblDescripcionPrecio);
            this.panel_Contenido.Controls.Add(this.hopeTextBox_Precio);
            this.panel_Contenido.Controls.Add(this.lblDescripcionNombre);
            this.panel_Contenido.Controls.Add(this.hopeTextBox_Nombre);
            this.panel_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Contenido.Location = new System.Drawing.Point(2, 52);
            this.panel_Contenido.Name = "panel_Contenido";
            this.panel_Contenido.Padding = new System.Windows.Forms.Padding(20);
            this.panel_Contenido.Size = new System.Drawing.Size(496, 196);
            this.panel_Contenido.TabIndex = 1;
            // 
            // lblDescripcionPrecio
            // 
            this.lblDescripcionPrecio.AutoSize = true;
            this.lblDescripcionPrecio.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDescripcionPrecio.Location = new System.Drawing.Point(23, 105);
            this.lblDescripcionPrecio.Name = "lblDescripcionPrecio";
            this.lblDescripcionPrecio.Size = new System.Drawing.Size(48, 19);
            this.lblDescripcionPrecio.TabIndex = 2;
            this.lblDescripcionPrecio.Text = "Precio";
            // 
            // hopeTextBox_Precio
            // 
            this.hopeTextBox_Precio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hopeTextBox_Precio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hopeTextBox_Precio.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.hopeTextBox_Precio.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hopeTextBox_Precio.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hopeTextBox_Precio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hopeTextBox_Precio.Hint = "Ej: 2500";
            this.hopeTextBox_Precio.Location = new System.Drawing.Point(23, 130);
            this.hopeTextBox_Precio.MaxLength = 10;
            this.hopeTextBox_Precio.Multiline = false;
            this.hopeTextBox_Precio.Name = "hopeTextBox_Precio";
            this.hopeTextBox_Precio.PasswordChar = '\0';
            this.hopeTextBox_Precio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Precio.SelectedText = "";
            this.hopeTextBox_Precio.SelectionLength = 0;
            this.hopeTextBox_Precio.SelectionStart = 0;
            this.hopeTextBox_Precio.Size = new System.Drawing.Size(450, 36);
            this.hopeTextBox_Precio.TabIndex = 3;
            this.hopeTextBox_Precio.TabStop = false;
            this.hopeTextBox_Precio.UseSystemPasswordChar = false;
            // 
            // lblDescripcionNombre
            // 
            this.lblDescripcionNombre.AutoSize = true;
            this.lblDescripcionNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblDescripcionNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblDescripcionNombre.Location = new System.Drawing.Point(23, 25);
            this.lblDescripcionNombre.Name = "lblDescripcionNombre";
            this.lblDescripcionNombre.Size = new System.Drawing.Size(144, 19);
            this.lblDescripcionNombre.TabIndex = 0;
            this.lblDescripcionNombre.Text = "Nombre del producto";
            // 
            // hopeTextBox_Nombre
            // 
            this.hopeTextBox_Nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hopeTextBox_Nombre.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.hopeTextBox_Nombre.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.hopeTextBox_Nombre.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.hopeTextBox_Nombre.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.hopeTextBox_Nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.hopeTextBox_Nombre.Hint = "Ej: Hamburguesa Completa";
            this.hopeTextBox_Nombre.Location = new System.Drawing.Point(23, 50);
            this.hopeTextBox_Nombre.MaxLength = 100;
            this.hopeTextBox_Nombre.Multiline = false;
            this.hopeTextBox_Nombre.Name = "hopeTextBox_Nombre";
            this.hopeTextBox_Nombre.PasswordChar = '\0';
            this.hopeTextBox_Nombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_Nombre.SelectedText = "";
            this.hopeTextBox_Nombre.SelectionLength = 0;
            this.hopeTextBox_Nombre.SelectionStart = 0;
            this.hopeTextBox_Nombre.Size = new System.Drawing.Size(450, 36);
            this.hopeTextBox_Nombre.TabIndex = 1;
            this.hopeTextBox_Nombre.TabStop = false;
            this.hopeTextBox_Nombre.UseSystemPasswordChar = false;
            // 
            // panel_Footer
            // 
            this.panel_Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel_Footer.Controls.Add(this.parrotButton_Cancelar);
            this.panel_Footer.Controls.Add(this.parrotButton_Agregar);
            this.panel_Footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Footer.Location = new System.Drawing.Point(2, 248);
            this.panel_Footer.Name = "panel_Footer";
            this.panel_Footer.Padding = new System.Windows.Forms.Padding(20, 15, 20, 15);
            this.panel_Footer.Size = new System.Drawing.Size(496, 70);
            this.panel_Footer.TabIndex = 2;
            // 
            // parrotButton_Cancelar
            // 
            this.parrotButton_Cancelar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.parrotButton_Cancelar.ButtonImage = null;
            this.parrotButton_Cancelar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Cancelar.ButtonText = "Cancelar";
            this.parrotButton_Cancelar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.parrotButton_Cancelar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Cancelar.CornerRadius = 8;
            this.parrotButton_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Cancelar.Dock = System.Windows.Forms.DockStyle.Right;
            this.parrotButton_Cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Cancelar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Cancelar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.parrotButton_Cancelar.HoverTextColor = System.Drawing.Color.White;
            this.parrotButton_Cancelar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Cancelar.Location = new System.Drawing.Point(256, 15);
            this.parrotButton_Cancelar.Name = "parrotButton_Cancelar";
            this.parrotButton_Cancelar.Size = new System.Drawing.Size(110, 40);
            this.parrotButton_Cancelar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Cancelar.TabIndex = 1;
            this.parrotButton_Cancelar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.parrotButton_Cancelar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Cancelar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotButton_Agregar
            // 
            this.parrotButton_Agregar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Agregar.ButtonImage = null;
            this.parrotButton_Agregar.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Agregar.ButtonText = "Agregar Producto";
            this.parrotButton_Agregar.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(91)))), ((int)(((byte)(6)))));
            this.parrotButton_Agregar.ClickTextColor = System.Drawing.Color.White;
            this.parrotButton_Agregar.CornerRadius = 8;
            this.parrotButton_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Agregar.Dock = System.Windows.Forms.DockStyle.Right;
            this.parrotButton_Agregar.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Agregar.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Agregar.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(101)))), ((int)(((byte)(16)))));
            this.parrotButton_Agregar.HoverTextColor = System.Drawing.Color.White;
            this.parrotButton_Agregar.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Agregar.Location = new System.Drawing.Point(366, 15);
            this.parrotButton_Agregar.Name = "parrotButton_Agregar";
            this.parrotButton_Agregar.Size = new System.Drawing.Size(110, 40);
            this.parrotButton_Agregar.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Agregar.TabIndex = 0;
            this.parrotButton_Agregar.TextColor = System.Drawing.Color.White;
            this.parrotButton_Agregar.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Agregar.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Agregar.Click += new System.EventHandler(this.parrotButton_Agregar_Click);
            // 
            // panel_Header
            // 
            this.panel_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel_Header.Controls.Add(this.btnCerrar);
            this.panel_Header.Controls.Add(this.lblTitulo);
            this.panel_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Header.Location = new System.Drawing.Point(2, 2);
            this.panel_Header.Name = "panel_Header";
            this.panel_Header.Size = new System.Drawing.Size(496, 50);
            this.panel_Header.TabIndex = 0;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCerrar.Location = new System.Drawing.Point(446, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.Text = "✕";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.lblTitulo.Location = new System.Drawing.Point(20, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(174, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agregar Producto";
            // 
            // AgregarProducto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(500, 320);
            this.Controls.Add(this.panel_Principal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AgregarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar Producto";
            this.panel_Principal.ResumeLayout(false);
            this.panel_Contenido.ResumeLayout(false);
            this.panel_Contenido.PerformLayout();
            this.panel_Footer.ResumeLayout(false);
            this.panel_Header.ResumeLayout(false);
            this.panel_Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Principal;
        private System.Windows.Forms.Panel panel_Header;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel_Contenido;
        private System.Windows.Forms.Label lblDescripcionPrecio;
        private System.Windows.Forms.Label lblDescripcionNombre;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Nombre;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_Precio;
        private System.Windows.Forms.Panel panel_Footer;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Cancelar;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Agregar;
    }
}