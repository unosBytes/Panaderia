using System;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;using System.Collections.Generic;

namespace PanaderiaApp.CAPA_PRESENTACION
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
                string consulta = "SELECT * FROM EMPLEADO";

                // Crear un DataTable para almacenar los resultados
                DataTable dt = new DataTable();

                SqlConnection conexion = new SqlConnection("server=DESKTOP-H5LC7P4\\SQLEXPRESS;database=PANIFICACION;integrated security = true");
                SqlCommand comando = new SqlCommand(consulta, conexion);
                conexion.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);

                adaptador.Fill(dt);
                tabla_Empleados.DataSource = dt;
            

        }
    }
}
