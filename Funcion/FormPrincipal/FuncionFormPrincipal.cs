using AplicacionCarroComidas.Forms.FormCaja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionCarroComidas.Funcion.FormPrincipal {
    public class FuncionFormPrincipal {
        private static Form formActivo = null;

        public static void AbrirFormNuevo(Panel panelContenedor, Form formHijo) {
            if (formActivo != null) {
                formActivo.Close();
            }

            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            panelContenedor.Tag = formHijo;
            formHijo.Show();
        }

        public static void MoverPanel(ReaLTaiizor.Controls.ParrotButton botonActual,ReaLTaiizor.Controls.Panel Panel) {
            Panel.Visible = true;
            Panel.Height = botonActual.Height;
            Panel.Top = botonActual.Top;
            Panel.Left = botonActual.Left - 32;

            Panel.BringToFront();
        }
    }
}
