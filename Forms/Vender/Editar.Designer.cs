namespace AplicacionCarroComidas.Forms.Vender {
    partial class Editar {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.airForm1 = new ReaLTaiizor.Forms.AirForm();
            this.parrotButton_Ventas = new ReaLTaiizor.Controls.ParrotButton();
            this.hopeTextBox_NuevoPrecio = new ReaLTaiizor.Controls.HopeTextBox();
            this.hopeComboBox_Productos = new ReaLTaiizor.Controls.HopeComboBox();
            this.airForm1.SuspendLayout();
            this.SuspendLayout();
            // 
            // airForm1
            // 
            this.airForm1.BackColor = System.Drawing.Color.White;
            this.airForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.airForm1.Controls.Add(this.hopeComboBox_Productos);
            this.airForm1.Controls.Add(this.parrotButton_Ventas);
            this.airForm1.Controls.Add(this.hopeTextBox_NuevoPrecio);
            this.airForm1.Customization = "AAAA/1paWv9ycnL/";
            this.airForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airForm1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.airForm1.Image = null;
            this.airForm1.Location = new System.Drawing.Point(0, 0);
            this.airForm1.MinimumSize = new System.Drawing.Size(112, 35);
            this.airForm1.Movable = true;
            this.airForm1.Name = "airForm1";
            this.airForm1.NoRounding = false;
            this.airForm1.Sizable = true;
            this.airForm1.Size = new System.Drawing.Size(474, 212);
            this.airForm1.SmartBounds = true;
            this.airForm1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.airForm1.TabIndex = 0;
            this.airForm1.Text = "Editar Producto";
            this.airForm1.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.Transparent = false;
            // 
            // parrotButton_Ventas
            // 
            this.parrotButton_Ventas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.ButtonImage = ((System.Drawing.Image)(resources.GetObject("parrotButton_Ventas.ButtonImage")));
            this.parrotButton_Ventas.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.parrotButton_Ventas.ButtonText = "Editar";
            this.parrotButton_Ventas.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.ClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(151)))), ((int)(((byte)(60)))));
            this.parrotButton_Ventas.CornerRadius = 5;
            this.parrotButton_Ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.parrotButton_Ventas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parrotButton_Ventas.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parrotButton_Ventas.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.parrotButton_Ventas.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.parrotButton_Ventas.Location = new System.Drawing.Point(0, 162);
            this.parrotButton_Ventas.Name = "parrotButton_Ventas";
            this.parrotButton_Ventas.Size = new System.Drawing.Size(474, 50);
            this.parrotButton_Ventas.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.parrotButton_Ventas.TabIndex = 5;
            this.parrotButton_Ventas.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(111)))), ((int)(((byte)(26)))));
            this.parrotButton_Ventas.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotButton_Ventas.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.parrotButton_Ventas.Click += new System.EventHandler(this.parrotButton_Ventas_Click);
            // 
            // hopeTextBox_NuevoPrecio
            // 
            this.hopeTextBox_NuevoPrecio.BackColor = System.Drawing.Color.White;
            this.hopeTextBox_NuevoPrecio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox_NuevoPrecio.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.hopeTextBox_NuevoPrecio.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox_NuevoPrecio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeTextBox_NuevoPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox_NuevoPrecio.Hint = "Precio";
            this.hopeTextBox_NuevoPrecio.Location = new System.Drawing.Point(12, 103);
            this.hopeTextBox_NuevoPrecio.MaxLength = 32767;
            this.hopeTextBox_NuevoPrecio.Multiline = false;
            this.hopeTextBox_NuevoPrecio.Name = "hopeTextBox_NuevoPrecio";
            this.hopeTextBox_NuevoPrecio.PasswordChar = '\0';
            this.hopeTextBox_NuevoPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox_NuevoPrecio.SelectedText = "";
            this.hopeTextBox_NuevoPrecio.SelectionLength = 0;
            this.hopeTextBox_NuevoPrecio.SelectionStart = 0;
            this.hopeTextBox_NuevoPrecio.Size = new System.Drawing.Size(450, 38);
            this.hopeTextBox_NuevoPrecio.TabIndex = 1;
            this.hopeTextBox_NuevoPrecio.TabStop = false;
            this.hopeTextBox_NuevoPrecio.UseSystemPasswordChar = false;
            // 
            // hopeComboBox_Productos
            // 
            this.hopeComboBox_Productos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hopeComboBox_Productos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.hopeComboBox_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hopeComboBox_Productos.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeComboBox_Productos.FormattingEnabled = true;
            this.hopeComboBox_Productos.ItemHeight = 30;
            this.hopeComboBox_Productos.Location = new System.Drawing.Point(12, 47);
            this.hopeComboBox_Productos.Name = "hopeComboBox_Productos";
            this.hopeComboBox_Productos.Size = new System.Drawing.Size(450, 36);
            this.hopeComboBox_Productos.TabIndex = 6;
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 212);
            this.ControlBox = false;
            this.Controls.Add(this.airForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(112, 35);
            this.Name = "Editar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.airForm1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.AirForm airForm1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox_NuevoPrecio;
        private ReaLTaiizor.Controls.ParrotButton parrotButton_Ventas;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBox_Productos;
    }
}