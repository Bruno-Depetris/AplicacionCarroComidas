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
            if (disposing && ( components != null )) {
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
            this.parrotButton_Dashboard = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Separador3 = new System.Windows.Forms.Panel();
            this.parrotButton_Movimiento = new ReaLTaiizor.Controls.ParrotButton();
            this.parrotButton_Historial = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Separador2 = new System.Windows.Forms.Panel();
            this.parrotButton_Caja = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Separador1 = new System.Windows.Forms.Panel();
            this.parrotButton_Ventas = new ReaLTaiizor.Controls.ParrotButton();
            this.panel_Senializador = new ReaLTaiizor.Controls.Panel();
            this.parrotPictureBox_Logo = new ReaLTaiizor.Controls.ParrotPictureBox();
            this.lblNombreApp = new System.Windows.Forms.Label();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.nightForm1.SuspendLayout();
            this.panel_ContenedorLateral.SuspendLayout();
            //( (System.ComponentModel.ISupportInitialize)( this.parrotPictureBox_Logo ) ).BeginInit();
            this.SuspendLayout();
            // 
            // nightForm1
            // 
            this.nightForm1.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ));
            this.nightForm1.Controls.Add(this.panel1);
            this.nightForm1.Controls.Add(this.panel_ContenedorFormularios);
            this.nightForm1.Controls.Add(this.panel_ContenedorLateral);
            this.nightForm1.Controls.Add(this.nightControlBox1);
            this.nightForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightForm1.DrawIcon = false;
            this.nightForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nightForm1.HeadColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 20 ) ) ) ), ( (int)( ( (byte)( 20 ) ) ) ), ( (int)( ( (byte)( 20 ) ) ) ));
            this.nightForm1.Location = new System.Drawing.Point(0, 0);
            this.nightForm1.MinimumSize = new System.Drawing.Size(100, 42);
            this.nightForm1.Name = "nightForm1";
            this.nightForm1.Padding = new System.Windows.Forms.Padding(0, 31, 0, 0);
            this.nightForm1.Size = new System.Drawing.Size(1200, 700);
            this.nightForm1.TabIndex = 0;
            this.nightForm1.Text = "REPAS - Sistema de Gestión";
            this.nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            this.nightForm1.TitleBarTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(220, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 669);
            this.panel1.TabIndex = 3;
            // 
            // panel_ContenedorFormularios
            // 
            this.panel_ContenedorFormularios.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ), ( (int)( ( (byte)( 30 ) ) ) ));
            this.panel_ContenedorFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_ContenedorFormularios.Location = new System.Drawing.Point(220, 31);
            this.panel_ContenedorFormularios.Name = "panel_ContenedorFormularios";
            this.panel_ContenedorFormularios.Size = new System.Drawing.Size(980, 669);
            this.panel_ContenedorFormularios.TabIndex = 2;
            // 
            // panel_ContenedorLateral
            // 
            this.panel_ContenedorLateral.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Dashboard);
            this.panel_ContenedorLateral.Controls.Add(this.panel_Separador3);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Movimiento);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Historial);
            this.panel_ContenedorLateral.Controls.Add(this.panel_Separador2);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Caja);
            this.panel_ContenedorLateral.Controls.Add(this.panel_Separador1);
            this.panel_ContenedorLateral.Controls.Add(this.parrotButton_Ventas);
            this.panel_ContenedorLateral.Controls.Add(this.panel_Senializador);
            this.panel_ContenedorLateral.Controls.Add(this.lblNombreApp);
            this.panel_ContenedorLateral.Controls.Add(this.parrotPictureBox_Logo);
            this.panel_ContenedorLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_ContenedorLateral.Location = new System.Drawing.Point(0, 31);
            this.panel_ContenedorLateral.Name = "panel_ContenedorLateral";
            this.panel_ContenedorLateral.Size = new System.Drawing.Size(220, 669);
            this.panel_ContenedorLateral.TabIndex = 1;
            // 
            // parrotButton_Dashboard
            // 
            this.parrotButton_Dashboard.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.parrotButton_Dashboard.ButtonImage = ( (System.Drawing.Image)( resources.GetObject("parrotButton_Dashboard.ButtonImage") ) );
            this.parrotButton_Dashboard.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Dashboard.ButtonText = "Dashboard";
            this.parrotButton_Dashboard.ClickBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Dashboard.ClickTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 151 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.parrotButton_Dashboard.CornerRadius = 8;
            this.parrotButton_Dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Dashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Dashboard.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.parrotButton_Dashboard.HoverBackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Dashboard.HoverTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.parrotButton_Dashboard.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Dashboard.Location = new System.Drawing.Point(12, 175);
            this.parrotButton_Dashboard.Name = "parrotButton_Dashboard";
            this.parrotButton_Dashboard.Size = new System.Drawing.Size(200, 45);
            this.parrotButton_Dashboard.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Dashboard.TabIndex = 10;
            this.parrotButton_Dashboard.TextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ));
            this.parrotButton_Dashboard.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Dashboard.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Dashboard.Click += new System.EventHandler(this.parrotPictureBox_Logo_Click);
            // 
            // panel_Separador3
            // 
            this.panel_Separador3.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ));
            this.panel_Separador3.Location = new System.Drawing.Point(25, 396);
            this.panel_Separador3.Name = "panel_Separador3";
            this.panel_Separador3.Size = new System.Drawing.Size(170, 1);
            this.panel_Separador3.TabIndex = 9;
            // 
            // parrotButton_Movimiento
            // 
            this.parrotButton_Movimiento.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.parrotButton_Movimiento.ButtonImage = ( (System.Drawing.Image)( resources.GetObject("parrotButton_Movimiento.ButtonImage") ) );
            this.parrotButton_Movimiento.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Movimiento.ButtonText = "Movimientos";
            this.parrotButton_Movimiento.ClickBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Movimiento.ClickTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 151 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.parrotButton_Movimiento.CornerRadius = 8;
            this.parrotButton_Movimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Movimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Movimiento.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.parrotButton_Movimiento.HoverBackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Movimiento.HoverTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.parrotButton_Movimiento.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Movimiento.Location = new System.Drawing.Point(12, 345);
            this.parrotButton_Movimiento.Name = "parrotButton_Movimiento";
            this.parrotButton_Movimiento.Size = new System.Drawing.Size(200, 45);
            this.parrotButton_Movimiento.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Movimiento.TabIndex = 5;
            this.parrotButton_Movimiento.TextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ));
            this.parrotButton_Movimiento.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Movimiento.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Movimiento.Click += new System.EventHandler(this.parrotButton_Movimiento_Click);
            // 
            // parrotButton_Historial
            // 
            this.parrotButton_Historial.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.parrotButton_Historial.ButtonImage = ( (System.Drawing.Image)( resources.GetObject("parrotButton_Historial.ButtonImage") ) );
            this.parrotButton_Historial.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Historial.ButtonText = "Historial";
            this.parrotButton_Historial.ClickBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Historial.ClickTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 151 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.parrotButton_Historial.CornerRadius = 8;
            this.parrotButton_Historial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Historial.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Historial.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.parrotButton_Historial.HoverBackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Historial.HoverTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.parrotButton_Historial.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Historial.Location = new System.Drawing.Point(12, 403);
            this.parrotButton_Historial.Name = "parrotButton_Historial";
            this.parrotButton_Historial.Size = new System.Drawing.Size(200, 45);
            this.parrotButton_Historial.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Historial.TabIndex = 6;
            this.parrotButton_Historial.TextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ));
            this.parrotButton_Historial.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Historial.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Historial.Click += new System.EventHandler(this.parrotButton_Historial_Click);
            // 
            // panel_Separador2
            // 
            this.panel_Separador2.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ));
            this.panel_Separador2.Location = new System.Drawing.Point(25, 338);
            this.panel_Separador2.Name = "panel_Separador2";
            this.panel_Separador2.Size = new System.Drawing.Size(170, 1);
            this.panel_Separador2.TabIndex = 8;
            // 
            // parrotButton_Caja
            // 
            this.parrotButton_Caja.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.parrotButton_Caja.ButtonImage = ( (System.Drawing.Image)( resources.GetObject("parrotButton_Caja.ButtonImage") ) );
            this.parrotButton_Caja.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Caja.ButtonText = "Caja";
            this.parrotButton_Caja.ClickBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Caja.ClickTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 151 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.parrotButton_Caja.CornerRadius = 8;
            this.parrotButton_Caja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Caja.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Caja.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.parrotButton_Caja.HoverBackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Caja.HoverTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.parrotButton_Caja.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Caja.Location = new System.Drawing.Point(12, 287);
            this.parrotButton_Caja.Name = "parrotButton_Caja";
            this.parrotButton_Caja.Size = new System.Drawing.Size(200, 45);
            this.parrotButton_Caja.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Caja.TabIndex = 4;
            this.parrotButton_Caja.TextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ));
            this.parrotButton_Caja.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Caja.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Caja.Click += new System.EventHandler(this.parrotButton_Caja_Click);
            // 
            // panel_Separador1
            // 
            this.panel_Separador1.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ), ( (int)( ( (byte)( 45 ) ) ) ));
            this.panel_Separador1.Location = new System.Drawing.Point(25, 280);
            this.panel_Separador1.Name = "panel_Separador1";
            this.panel_Separador1.Size = new System.Drawing.Size(170, 1);
            this.panel_Separador1.TabIndex = 7;
            // 
            // parrotButton_Ventas
            // 
            this.parrotButton_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.parrotButton_Ventas.ButtonImage = ( (System.Drawing.Image)( resources.GetObject("parrotButton_Ventas.ButtonImage") ) );
            this.parrotButton_Ventas.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Ventas.ButtonText = "Vender";
            this.parrotButton_Ventas.ClickBackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Ventas.ClickTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 151 ) ) ) ), ( (int)( ( (byte)( 60 ) ) ) ));
            this.parrotButton_Ventas.CornerRadius = 8;
            this.parrotButton_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Ventas.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.parrotButton_Ventas.Horizontal_Alignment = System.Drawing.StringAlignment.Near;
            this.parrotButton_Ventas.HoverBackgroundColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ), ( (int)( ( (byte)( 35 ) ) ) ));
            this.parrotButton_Ventas.HoverTextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.parrotButton_Ventas.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Ventas.Location = new System.Drawing.Point(12, 229);
            this.parrotButton_Ventas.Name = "parrotButton_Ventas";
            this.parrotButton_Ventas.Size = new System.Drawing.Size(200, 45);
            this.parrotButton_Ventas.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Ventas.TabIndex = 3;
            this.parrotButton_Ventas.TextColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ), ( (int)( ( (byte)( 200 ) ) ) ));
            this.parrotButton_Ventas.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Ventas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.Click += new System.EventHandler(this.parrotButton_Ventas_Click);
            // 
            // panel_Senializador
            // 
            this.panel_Senializador.BackColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.panel_Senializador.EdgeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ), ( (int)( ( (byte)( 25 ) ) ) ));
            this.panel_Senializador.Location = new System.Drawing.Point(0, 229);
            this.panel_Senializador.Name = "panel_Senializador";
            this.panel_Senializador.Padding = new System.Windows.Forms.Padding(5);
            this.panel_Senializador.Size = new System.Drawing.Size(4, 45);
            this.panel_Senializador.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel_Senializador.TabIndex = 2;
            this.panel_Senializador.Text = "panel1";
            // 
            // parrotPictureBox_Logo
            // 
            this.parrotPictureBox_Logo.ColorLeft = System.Drawing.Color.Transparent;
            this.parrotPictureBox_Logo.ColorRight = System.Drawing.Color.Transparent;
            this.parrotPictureBox_Logo.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotPictureBox_Logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotPictureBox_Logo.FilterAlpha = 200;
            this.parrotPictureBox_Logo.FilterEnabled = false;
            this.parrotPictureBox_Logo.Image = ( (System.Drawing.Image)( resources.GetObject("parrotPictureBox_Logo.Image") ) );
            this.parrotPictureBox_Logo.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotPictureBox_Logo.IsElipse = false;
            this.parrotPictureBox_Logo.IsParallax = false;
            this.parrotPictureBox_Logo.Location = new System.Drawing.Point(60, 20);
            this.parrotPictureBox_Logo.Name = "parrotPictureBox_Logo";
            this.parrotPictureBox_Logo.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotPictureBox_Logo.Size = new System.Drawing.Size(100, 100);
            this.parrotPictureBox_Logo.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotPictureBox_Logo.TabIndex = 0;
            this.parrotPictureBox_Logo.TabStop = false;
            this.parrotPictureBox_Logo.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotPictureBox_Logo.Click += new System.EventHandler(this.parrotPictureBox_Logo_Click);
            // 
            // lblNombreApp
            // 
            this.lblNombreApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNombreApp.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNombreApp.ForeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.lblNombreApp.Location = new System.Drawing.Point(0, 123);
            this.lblNombreApp.Name = "lblNombreApp";
            this.lblNombreApp.Size = new System.Drawing.Size(220, 35);
            this.lblNombreApp.TabIndex = 1;
            this.lblNombreApp.Text = "REPAS";
            this.lblNombreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNombreApp.Click += new System.EventHandler(this.parrotPictureBox_Logo_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ( (System.Windows.Forms.AnchorStyles)( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 199 ) ) ) ), ( (int)( ( (byte)( 80 ) ) ) ), ( (int)( ( (byte)( 80 ) ) ) ));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 105 ) ) ) ), ( (int)( ( (byte)( 105 ) ) ) ), ( (int)( ( (byte)( 105 ) ) ) ));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 105 ) ) ) ), ( (int)( ( (byte)( 105 ) ) ) ), ( (int)( ( (byte)( 105 ) ) ) ));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 251 ) ) ) ), ( (int)( ( (byte)( 111 ) ) ) ), ( (int)( ( (byte)( 26 ) ) ) ));
            this.nightControlBox1.Location = new System.Drawing.Point(1061, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(( (int)( ( (byte)( 15 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ), ( (int)( ( (byte)( 255 ) ) ) ));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.nightForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ( (System.Drawing.Icon)( resources.GetObject("$this.Icon") ) );
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1200, 700);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repas - Sistema de Gestión";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.nightForm1.ResumeLayout(false);
            this.panel_ContenedorLateral.ResumeLayout(false);
            //( (System.ComponentModel.ISupportInitialize)( this.parrotPictureBox_Logo ) ).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel panel_ContenedorFormularios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_ContenedorLateral;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Dashboard;
        private System.Windows.Forms.Panel panel_Separador3;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Historial;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Movimiento;
        private System.Windows.Forms.Panel panel_Separador2;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Caja;
        private System.Windows.Forms.Panel panel_Separador1;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Ventas;
        private ReaLTaiizor.Controls.Panel panel_Senializador;
        private System.Windows.Forms.Label lblNombreApp;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox_Logo;
    }
}