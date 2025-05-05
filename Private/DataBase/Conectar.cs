using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionCarroComidas.Private.DataBase {
    internal class Conectar {


        private static string pathDB = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "AplicacionCarroComidasRepas.db");
        private static string cadena = $"Data Source={Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "AplicacionCarroComidasRepas.db")};Version=3;";

        private static string cadenaAppData = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repas", "AplicacionCarroComidasRepas.db")};Version=3;";
        private static string pathDBAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repas", "AplicacionCarroComidasRepas.db");
        private static string BackUp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BackUpAllResto", "AplicacionCarroComidasRepas.db");

        public string datos = string.Empty;

        public static void Comprobar() {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Predits");

            // Verificar si la carpeta "Predits" existe, si no, crearla
            if (!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("La carpeta no existía, fue creada con éxito");
            }
            Console.WriteLine("Carpeta encontrada con éxito");

            string repasFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Repas");

            // Verificar si la carpeta "Repas" existe, si no, crearla
            if (!Directory.Exists(repasFolderPath)) {
                Directory.CreateDirectory(repasFolderPath);
                Console.WriteLine("La carpeta 'Repas' no existía, fue creada con éxito");
            }

            // Verificar si la base de datos existe en la ubicación esperada
            if (!File.Exists(pathDBAppData)) {
                if (File.Exists(pathDB)) {
                    File.Copy(pathDB, pathDBAppData, true);
                    Console.WriteLine("Base de datos copiada correctamente a AppData.");
                } else {
                    Console.WriteLine("El archivo de base de datos original no se encuentra en la ruta especificada.");
                }
            }
        }

        public static string CrearBackUp() {
            try {
                string backupFolderPath = Path.GetDirectoryName(BackUp);

                if (!Directory.Exists(backupFolderPath)) {
                    Directory.CreateDirectory(backupFolderPath);
                    Console.WriteLine("La carpeta de respaldo no existía, fue creada con éxito");
                }


                if (!File.Exists(BackUp)) {

                    if (File.Exists(pathDBAppData)) {
                        File.Copy(pathDBAppData, BackUp, true);
                    } else {
                        Console.WriteLine("El archivo no se encuentra en ruta especificada");
                    }
                    Console.WriteLine("backUpCreado");

                } else {


                }

            } catch (Exception ex) {

                Console.WriteLine("HUBO UN ERROR" + ex);
                return "error";
            }

            return BackUp;
        }
        public static SQLiteConnection ObtenerConexion() {
            try {
                string cadenaConexion = cadenaAppData;
                var conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();

                return conexion;

            } catch (Exception ex) {
                Console.WriteLine($"Error al obtener la conexión: {ex.Message}");
                throw;
            }
        }

    }
}

