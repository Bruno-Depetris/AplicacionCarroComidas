namespace Repas {
    partial class FormPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.nightForm1 = new ReaLTaiizor.Forms.NightForm();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_ContenedorFormularios = new System.Windows.Forms.Panel();
            this.panel_ContenedorLateral = new System.Windows.Forms.Panel();
            this.parrotButton_Historial = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Movimiento = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Caja = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Ventas = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Senializador = new ReaLTaiizor.Controls.Panel();
            this.parrotPictureBox_Logo = new ReaLTaiizor.Controls.ParrotPictureBox();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.nightForm1.SuspendLayout();
            this.panel_ContenedorLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.nightForm1.Controls.Add(this.panel1);
            this.nightForm1.Controls.Add(this.panel_ContenedorFormularios);
            this.nightForm1.Controls.Add(this.panel_ContenedorLateral);
            this.nightForm1.Controls.Add(this.nightControlBox1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(1029, 550);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.Text = "Repas";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(200, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 519);
            this.panel1.TabIndex = 3;
            // 
            // panel_ContenedorFormularios
            // 
            this.panel_ContenedorFormularios.BackColor = System.Drawing.Color.White;
            this.panel_ContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContenedorFormularios.Location = new System.Drawing.Point(200, 31);
            this.panel_ContenedorFormularios.Name = "panel_ContenedorFormularios";
            this.panel_ContenedorFormularios.Size = new System.Drawing.Size(829, 519);
            this.panel_ContenedorFormularios.TabIndex = 2;
            // 
            // panel_ContenedorLateral
            // 
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Movimiento);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Historial);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Caja);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Ventas);
            this.panel_ContenedorLateral.Controls.Add(this.panel_Senializador);
            this.panel_ContenedorLateral.Controls.Add(this.parrotPictureBox_Logo);
            this.panel_ContenedorLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ContenedorLateral.Location = new System.Drawing.Point(0, 31);
            this.panel_ContenedorLateral.Name = "panel_ContenedorLateral";
            this.panel_ContenedorLateral.Size = new System.Drawing.Size(200, 519);
            this.panel_ContenedorLateral.TabIndex = 1;
            // 
            // parrotButton_Historial
            // 
            this.parrotButton_Historial.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Historial.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Historial.ButtonImage")));
            this.parrotButton_Historial.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Historial.ButtonText = "Historial";
            this.parrotButton_Historial.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Historial.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Historial.CornerRadius = 5;
            this.parrotButton_Historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Historial.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Historial.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Historial.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Historial.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Historial.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Historial.Location = new System.Drawing.Point(5, 212);
            this.parrotButton_Historial.Name = "parrotButton_Historial";
            this.parrotButton_Historial.Size = new System.Drawing.Size(195, 50);
            this.parrotButton_Historial.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Historial.TabIndex = 6;
            this.parrotButton_Historial.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Historial.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Historial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Historial.Click += new System.EventHandler(this.parrotButton_Historial_Click);
            // 
            // parrotButton_Movimiento
            // 
            this.parrotButton_Movimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Movimiento.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Movimiento.ButtonImage")));
            this.parrotButton_Movimiento.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Movimiento.ButtonText = "Movimiento";
            this.parrotButton_Movimiento.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Movimiento.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Movimiento.CornerRadius = 5;
            this.parrotButton_Movimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Movimiento.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Movimiento.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Movimiento.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Movimiento.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Movimiento.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Movimiento.Location = new System.Drawing.Point(5, 268);
            this.parrotButton_Movimiento.Name = "parrotButton_Movimiento";
            this.parrotButton_Movimiento.Size = new System.Drawing.Size(195, 50);
            this.parrotButton_Movimiento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Movimiento.TabIndex = 5;
            this.parrotButton_Movimiento.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Movimiento.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Movimiento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Movimiento.Click += new System.EventHandler(this.parrotButton_Movimiento_Click);
            // 
            // parrotButton_Caja
            // 
            this.parrotButton_Caja.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Caja.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Caja.ButtonImage")));
            this.parrotButton_Caja.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Caja.ButtonText = "Caja";
            this.parrotButton_Caja.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Caja.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Caja.CornerRadius = 5;
            this.parrotButton_Caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Caja.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Caja.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Caja.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Caja.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Caja.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Caja.Location = new System.Drawing.Point(6, 324);
            this.parrotButton_Caja.Name = "parrotButton_Caja";
            this.parrotButton_Caja.Size = new System.Drawing.Size(195, 50);
            this.parrotButton_Caja.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Caja.TabIndex = 4;
            this.parrotButton_Caja.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Caja.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Caja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Caja.Click += new System.EventHandler(this.parrotButton_Caja_Click);
            // 
            // parrotButton_Ventas
            // 
            this.parrotButton_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Ventas.ButtonImage")));
            this.parrotButton_Ventas.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Ventas.ButtonText = "Vender";
            this.parrotButton_Ventas.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Ventas.CornerRadius = 5;
            this.parrotButton_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Ventas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Ventas.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Ventas.Location = new System.Drawing.Point(5, 156);
            this.parrotButton_Ventas.Name = "parrotButton_Ventas";
            this.parrotButton_Ventas.Size = new System.Drawing.Size(195, 50);
            this.parrotButton_Ventas.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Ventas.TabIndex = 3;
            this.parrotButton_Ventas.TextColor = System.Drawing.Color.Black;
            this.parrotButton_Ventas.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Ventas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.Click += new System.EventHandler(this.parrotButton_Ventas_Click);
            // 
            // panel_Senializador
            // 
            this.panel_Senializador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.panel_Senializador.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panel_Senializador.Location = new System.Drawing.Point(-28, 156);
            this.panel_Senializador.Name = "panel_Senializador";
            this.panel_Senializador.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Senializador.Size = new System.Drawing.Size(34, 63);
            this.panel_Senializador.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_Senializador.TabIndex = 2;
            this.panel_Senializador.Text = "panel1";
            // 
            // parrotPictureBox_Logo
            // 
            this.parrotPictureBox_Logo.ColorLeft = System.Drawing.Color.DodgerBlue;
            this.parrotPictureBox_Logo.ColorRight = System.Drawing.Color.DodgerBlue;
            this.parrotPictureBox_Logo.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotPictureBox_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotPictureBox_Logo.FilterAlpha = 200;
            this.parrotPictureBox_Logo.FilterEnabled = false;
            this.parrotPictureBox_Logo.Image = ((System.Drawing.Image)(resources.GetObject("parrotPictureBox_Logo.Image")));
            this.parrotPictureBox_Logo.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotPictureBox_Logo.IsElipse = false;
            this.parrotPictureBox_Logo.IsParallax = false;
            this.parrotPictureBox_Logo.Location = new System.Drawing.Point(25, 0);
            this.parrotPictureBox_Logo.Name = "parrotPictureBox_Logo";
            this.parrotPictureBox_Logo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotPictureBox_Logo.Size = new System.Drawing.Size(150, 150);
            this.parrotPictureBox_Logo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotPictureBox_Logo.TabIndex = 0;
            this.parrotPictureBox_Logo.Text = "parrotPictureBox1";
            this.parrotPictureBox_Logo.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotPictureBox_Logo.Click += new System.EventHandler(this.parrotPictureBox_Logo_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.nightControlBox1.Location = new System.Drawing.Point(890, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 550);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repas Aplicación";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            this.panel_ContenedorLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel_ContenedorFormularios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ContenedorLateral;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Historial;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Movimiento;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Caja;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Ventas;
        private ReaLTaiizor.Controls.Panel panel_Senializador;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox_Logo;
    }
}

