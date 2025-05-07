namespace AplicacionCarroComidas.Forms.Notificacion {
    partial class Mensaje {
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mensaje));
            this.parrotPictureBox1 = new ReaLTaiizor.Controls.ParrotPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.label_Mensaje = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.panel_Color = new System.Windows.Forms.Panel();
            this.parrotPictureBox_ImagenNot = new System.Windows.Forms.PictureBox();
            this.timer_Muestra = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.parrotPictureBox_ImagenNot)).BeginInit();
            this.SuspendLayout();
            // 
            // parrotPictureBox1
            // 
            this.parrotPictureBox1.BackColor = System.Drawing.Color.Black;
            this.parrotPictureBox1.ColorLeft = System.Drawing.Color.DodgerBlue;
            this.parrotPictureBox1.ColorRight = System.Drawing.Color.DodgerBlue;
            this.parrotPictureBox1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotPictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.parrotPictureBox1.FilterAlpha = 200;
            this.parrotPictureBox1.FilterEnabled = false;
            this.parrotPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("parrotPictureBox1.Image")));
            this.parrotPictureBox1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotPictureBox1.IsElipse = false;
            this.parrotPictureBox1.IsParallax = false;
            this.parrotPictureBox1.Location = new System.Drawing.Point(249, 0);
            this.parrotPictureBox1.Name = "parrotPictureBox1";
            this.parrotPictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotPictureBox1.Size = new System.Drawing.Size(78, 78);
            this.parrotPictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotPictureBox1.TabIndex = 1;
            this.parrotPictureBox1.Text = "parrotPictureBox1";
            this.parrotPictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(248, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 78);
            this.panel1.TabIndex = 2;
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.Black;
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(238, 0);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(10, 78);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Vertical;
            this.parrotGradientPanel1.TabIndex = 3;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.White;
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // label_Mensaje
            // 
            this.label_Mensaje.AutoSize = true;
            this.label_Mensaje.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mensaje.Location = new System.Drawing.Point(17, 30);
            this.label_Mensaje.Name = "label_Mensaje";
            this.label_Mensaje.Size = new System.Drawing.Size(103, 20);
            this.label_Mensaje.TabIndex = 4;
            this.label_Mensaje.Text = "label_Mensaje";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(16, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(51, 21);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "label1";
            // 
            // panel_Color
            // 
            this.panel_Color.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Color.Location = new System.Drawing.Point(0, 0);
            this.panel_Color.Name = "panel_Color";
            this.panel_Color.Size = new System.Drawing.Size(10, 78);
            this.panel_Color.TabIndex = 6;
            // 
            // parrotPictureBox_ImagenNot
            // 
            this.parrotPictureBox_ImagenNot.Location = new System.Drawing.Point(182, 12);
            this.parrotPictureBox_ImagenNot.Name = "parrotPictureBox_ImagenNot";
            this.parrotPictureBox_ImagenNot.Size = new System.Drawing.Size(50, 50);
            this.parrotPictureBox_ImagenNot.TabIndex = 7;
            this.parrotPictureBox_ImagenNot.TabStop = false;
            // 
            // timer_Muestra
            // 
            this.timer_Muestra.Enabled = true;
            this.timer_Muestra.Interval = 1;
            this.timer_Muestra.Tick += new System.EventHandler(this.timer_Muestra_Tick);
            // 
            // Mensaje
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(327, 78);
            this.Controls.Add(this.parrotPictureBox_ImagenNot);
            this.Controls.Add(this.panel_Color);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.label_Mensaje);
            this.Controls.Add(this.parrotGradientPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parrotPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Mensaje";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Mensaje_Load);
            ((System.ComponentModel.ISupportInitialize)(this.parrotPictureBox_ImagenNot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.Label label_Mensaje;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Panel panel_Color;
        private System.Windows.Forms.PictureBox parrotPictureBox_ImagenNot;
        private System.Windows.Forms.Timer timer_Muestra;
    }
}