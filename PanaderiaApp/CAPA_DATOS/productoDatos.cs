using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Management;

namespace PanaderiaApp.CAPA_DATOS
{
    public class productoDatos
    {
        public static void InsertarProducto(string nombre, decimal precio, int cantidad)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-H5LC7P4\\SQLEXPRESS;database=PANIFICACION;integrated security = true");

            SqlCommand comando = new SqlCommand("INSERT INTO PRODUCTO (nombre, precio, cantidad) VALUES (@nombre, @precio, @cantidad)", conexion);

            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@cantidad", cantidad);

            //abro conexion
            conexion.Open();
            //aca devuelvo las filas
            comando.ExecuteNonQuery();

        } 
    }
}





