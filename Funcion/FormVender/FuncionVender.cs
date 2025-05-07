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
        double Precio;


        public bool CargarDetalle(int id, ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView_DetalleVenta) {
            foreach (var dato in LogicaProducto.Instancia.Mostrar()) {
                if (id == dato.IdProducto) {
                    ProductoID = dato.IdProducto;
                    ProductoNombre = dato.Nombre;
                    Precio = dato.Precio;

                    // Agregar al DataGridView sin borrar
                    CargarDataGreed(poisonDataGridView_DetalleVenta);
                    return true;
                }
            }
            return false;
        }


        public void CargarDataGreed(ReaLTaiizor.Controls.PoisonDataGridView dataGreed) {
            dataGreed.Rows.Add (ProductoID, ProductoNombre, Precio);
        }

        
    }



}

