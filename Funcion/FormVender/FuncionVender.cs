using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionCarroComidas.Forms.Vender;
using AplicacionCarroComidas.Private.DataBase;
using AplicacionCarroComidas.Private.DataBase.Logic;

namespace AplicacionCarroComidas.Funcion.FormVender {
    public class FuncionVender {
        int ProductoID;
        string ProductoNombre;
        decimal Precio;


        public bool CargarDetalle(int id, ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_DetalleVenta) {

            foreach (var dato in LogicaComida.Instancia.MostrarComida()) {
                if (id == dato.ComidaID) {
                    ProductoID = dato.ComidaID;
                    ProductoNombre = dato.NombreComida;
                    Precio = dato.Precio;

                    // Agregar al DataGridView sin borrar
                    CargarDataGreed(poisonDataGridView_DetalleVenta);
                    return true;
                }
            }
            return false;
        }


        public void CargarDataGreed(ReaLTaiizor.Controls.PoisonDataGridView dataGreed) {
            dataGreed.Rows.Add(ProductoID, ProductoNombre, Precio);
        }


    }



}
