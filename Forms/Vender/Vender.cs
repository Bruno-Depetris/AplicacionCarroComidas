using AplicacionCarroComidas.Forms.Notificacion;
using AplicacionCarroComidas.Private.DataBase.Logic;
using AplicacionCarroComidas.Private.DataBase.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Forms.Vender {
    public partial class Vender : Form {
        public Vender() {
            InitializeComponent();
            ConfigurarEstilosModernos();
            label_TotalDetalle.Text = "0.00";
            CargarProductos();
        }

        private void ConfigurarEstilosModernos() {
            // Configurar el fondo oscuro del form
            this.BackColor = Color.FromArgb(30, 30, 30);

            // Configurar el FlowLayoutPanel de productos
            flowLayoutPanel_Productos.BackColor = Color.FromArgb(35, 35, 35);
            flowLayoutPanel_Productos.Padding = new Padding(15);
            flowLayoutPanel_Productos.AutoScroll = true;

            // Configurar el DataGridView con tema oscuro
            ConfigurarDataGridViewOscuro();
        }

        private void ConfigurarDataGridViewOscuro() {
            poisonDataGridView_DetalleVenta.BackgroundColor = Color.FromArgb(40, 40, 40);
            poisonDataGridView_DetalleVenta.GridColor = Color.FromArgb(60, 60, 60);
            poisonDataGridView_DetalleVenta.BorderStyle = BorderStyle.None;
            
            poisonDataGridView_DetalleVenta.DefaultCellStyle.BackColor = Color.FromArgb(45, 45, 45);
            poisonDataGridView_DetalleVenta.DefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            poisonDataGridView_DetalleVenta.DefaultCellStyle.SelectionBackColor = Color.FromArgb(251, 111, 26);
            poisonDataGridView_DetalleVenta.DefaultCellStyle.SelectionForeColor = Color.White;
            poisonDataGridView_DetalleVenta.DefaultCellStyle.Font = new Font("Segoe UI", 10F);

            poisonDataGridView_DetalleVenta.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(35, 35, 35);
            poisonDataGridView_DetalleVenta.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(251, 111, 26);
            poisonDataGridView_DetalleVenta.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            poisonDataGridView_DetalleVenta.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(35, 35, 35);

            poisonDataGridView_DetalleVenta.EnableHeadersVisualStyles = false;
            poisonDataGridView_DetalleVenta.RowHeadersVisible = false;
            poisonDataGridView_DetalleVenta.AllowUserToAddRows = false;
            poisonDataGridView_DetalleVenta.RowTemplate.Height = 40;
        }

        public void CargarProductos() {
            flowLayoutPanel_Productos.Controls.Clear();
            var productos = LogicaComida.Instancia.MostrarComida();

            foreach (var p in productos) {
                var btn = CrearBotonProductoModerno(p);
                flowLayoutPanel_Productos.Controls.Add(btn);
            }
        }

        private Control CrearBotonProductoModerno(Comida producto) {
            var cardWidth = 180;
            var cardHeight = 140;

            // Panel principal con estilo moderno
            var panel = new Panel {
                Width = cardWidth,
                Height = cardHeight,
                BackColor = Color.FromArgb(45, 45, 48),
                Margin = new Padding(8),
                Cursor = Cursors.Hand
            };

            // Contenedor para hover effect
            var hoverIndicator = new Panel {
                Dock = DockStyle.Top,
                Height = 3,
                BackColor = Color.Transparent
            };
            panel.Controls.Add(hoverIndicator);

            // Nombre del producto
            var nameLabel = new Label {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 35),
                Size = new Size(cardWidth - 20, 60),
                Text = producto.NombreComida,
                Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(240, 240, 240),
                BackColor = Color.Transparent
            };

            // Precio con estilo destacado
            var priceLabel = new Label {
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(10, 100),
                Size = new Size(cardWidth - 20, 30),
                Text = "$" + producto.Precio.ToString("N0"),
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(251, 111, 26),
                BackColor = Color.Transparent
            };

            panel.Controls.Add(nameLabel);
            panel.Controls.Add(priceLabel);
            panel.Tag = producto;
            
            // Eventos de clic
            panel.Click += Producto_Click;
            nameLabel.Click += (s, e) => Producto_Click(panel, e);
            priceLabel.Click += (s, e) => Producto_Click(panel, e);

            // Botón Editar moderno
            var btnEdit = new Button {
                Size = new Size(32, 28),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(60, 60, 65),
                ForeColor = Color.FromArgb(200, 200, 200),
                Text = "✎",
                Font = new Font("Segoe UI", 10F),
                Tag = producto,
                Cursor = Cursors.Hand
            };
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 70, 75);
            btnEdit.Location = new Point(cardWidth - 38, 8);
            btnEdit.Click += (s, e) => {
                e = e ?? EventArgs.Empty;
                var p = (Comida)((Button)s).Tag;
                using (var form = new Editar(p.ComidaID)) {
                    form.ShowDialog();
                    CargarProductos();
                }
            };

            // Botón Borrar moderno
            var btnDelete = new Button {
                Size = new Size(32, 28),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(60, 60, 65),
                ForeColor = Color.FromArgb(220, 80, 80),
                Text = "✖",
                Font = new Font("Segoe UI", 10F),
                Tag = producto,
                Cursor = Cursors.Hand
            };
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 50, 50);
            btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(150, 40, 40);
            btnDelete.Location = new Point(cardWidth - 74, 8);
            btnDelete.Click += (s, e) => {
                e = e ?? EventArgs.Empty;
                var p = (Comida)((Button)s).Tag;
                var msg = $"¿Desea eliminar el producto \"{p.NombreComida}\"?";
                var dr = MessageBox.Show(msg, "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes) {
                    try {
                        var eliminado = LogicaComida.Instancia.EliminarComida(p);
                        if (eliminado) {
                            Mensaje msj = new Mensaje();
                            msj.Show("Exito", "producto borrado", Color.Green, Color.White, Mensaje.TipoIcono.Ok, Mensaje.TipoSonido.Confirmacion);
                            CargarProductos();
                        } else {
                            MessageBox.Show("No se pudo eliminar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    } catch (Exception ex) {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            panel.Controls.Add(btnEdit);
            panel.Controls.Add(btnDelete);
            btnEdit.BringToFront();
            btnDelete.BringToFront();

            // Efectos hover
            panel.MouseEnter += (s, e) => {
                panel.BackColor = Color.FromArgb(55, 55, 58);
                hoverIndicator.BackColor = Color.FromArgb(251, 111, 26);
            };
            panel.MouseLeave += (s, e) => {
                panel.BackColor = Color.FromArgb(45, 45, 48);
                hoverIndicator.BackColor = Color.Transparent;
            };

            // Borde sutil
            panel.Paint += (s, e) => {
                var g = e.Graphics;
                using (var pen = new Pen(Color.FromArgb(60, 60, 60))) {
                    g.DrawRectangle(pen, 0, 0, panel.Width - 1, panel.Height - 1);
                }
            };

            return panel;
        }

        private void Producto_Click(object sender, EventArgs e) {
            Comida producto = null;
            if (sender is Panel panel && panel.Tag is Comida) {
                producto = (Comida)panel.Tag;
            } else if (sender is Control ctl && ctl.Tag is Comida) {
                producto = (Comida)ctl.Tag;
            }

            if (producto == null) return;

            poisonDataGridView_DetalleVenta.Rows.Add(producto.ComidaID, producto.NombreComida, producto.Precio.ToString("0.00"));
            ActualizarTotal();

            // Feedback visual
            if (sender is Panel p) {
                var originalColor = p.BackColor;
                p.BackColor = Color.FromArgb(251, 111, 26);
                var timer = new Timer { Interval = 150 };
                timer.Tick += (s, ev) => {
                    p.BackColor = originalColor;
                    timer.Stop();
                    timer.Dispose();
                };
                timer.Start();
            }
        }

        private void ActualizarTotal() {
            decimal total = 0;

            foreach (DataGridViewRow row in poisonDataGridView_DetalleVenta.Rows) {
                if (row.Cells["Column_Precio"].Value != null) {
                    if (decimal.TryParse(row.Cells["Column_Precio"].Value.ToString(), out decimal precio)) {
                        total += precio;
                    }
                }
            }

            label_TotalDetalle.Text = total.ToString("N0");
        }

        private void poisonDataGridView_DetalleVenta_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0) {
                string columnName = poisonDataGridView_DetalleVenta.Columns[e.ColumnIndex].Name;
                if (columnName == "Column_Eliminar") {
                    Borrar(e.RowIndex);
                }
            }
        }

        private void Borrar(int rowIndex) {
            if (rowIndex < 0 || rowIndex >= poisonDataGridView_DetalleVenta.Rows.Count) return;
            poisonDataGridView_DetalleVenta.Rows.RemoveAt(rowIndex);
            ActualizarTotal();
        }

        private void parrotButton1_Click(object sender, EventArgs e) {
            int totalFilas = poisonDataGridView_DetalleVenta.Rows.Count;
            if (totalFilas > 0) {
                int ultimoIndice = totalFilas - 1;
                Borrar(ultimoIndice);
            } else {
                MessageBox.Show("No hay productos en la lista para eliminar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Restaurar() {
            poisonDataGridView_DetalleVenta.Rows.Clear();
            label_TotalDetalle.Text = "0.00";
        }

        private void parrotButton_Ventas_Click(object sender, EventArgs e) {
            if (poisonDataGridView_DetalleVenta.Rows.Count == 0) {
                MessageBox.Show("No hay productos seleccionados para vender.", "Carrito vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CargarVenta _CargarVenta = new CargarVenta(this);
            _CargarVenta.Total = Convert.ToDouble(label_TotalDetalle.Text.Replace(",", ""));
            string productosConcatenados = "";

            foreach (DataGridViewRow fila in poisonDataGridView_DetalleVenta.Rows) {
                if (fila.Cells["Column_Producto"].Value != null) {
                    productosConcatenados += fila.Cells["Column_Producto"].Value.ToString() + " - ";
                }
            }
            if (productosConcatenados.EndsWith(" - ")) {
                productosConcatenados = productosConcatenados.Substring(0, productosConcatenados.Length - 3);
            }
            _CargarVenta.Productos = productosConcatenados;
            _CargarVenta.Show();
        }

        private void parrotButton_AgregarProducto_Click(object sender, EventArgs e) {
            AbrirAgregarProducto();
        }

        public void AbrirAgregarProducto() {
            using (var form = new AgregarProducto()) {
                var dr = form.ShowDialog();
                if (dr == DialogResult.OK) {
                    CargarProductos();
                }
            }
        }

        private void label_TotalDetalle_Click(object sender, EventArgs e) { }

        private void parrotButton_AgregarProducto_Click_1(object sender, EventArgs e) {
            AbrirAgregarProducto();
        }
    }
}