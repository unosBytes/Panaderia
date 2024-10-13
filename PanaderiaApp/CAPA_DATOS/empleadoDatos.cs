using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PanaderiaApp.CAPA_DATOS
{
    public class empleadoDatos
    {
        public static void SeleccionarEmpleado(string nombre, string apellido, int edad)
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-H5LC7P4\\SQLEXPRESS;database=PANIFICACION;integrated security = true");

            SqlCommand comando = new SqlCommand("SELECT * FROM EMPLEADO)", conexion);

            //abro conexion
            conexion.Open();
            //aca devuelvo las filas
            comando.ExecuteNonQuery();

        }
    }
}
