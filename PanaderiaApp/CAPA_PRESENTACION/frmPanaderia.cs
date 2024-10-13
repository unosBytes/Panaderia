using PanaderiaApp.CAPA_LOGICA;
using PanaderiaApp.CAPA_PRESENTACION;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanaderiaApp
{
    public partial class frmPanaderia : Form
    {
        public frmPanaderia()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.Nombre = txtbox_nombre.Text;
            producto.Precio = Convert.ToDecimal(txtbox_precio.Text);
            producto.Cantidad = Convert.ToInt32(txtbox_cantidad.Text);
            producto.AgregarProducto(producto.Nombre, producto.Precio, producto.Cantidad);
        }
        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT * FROM PRODUCTO";

            // Crear un DataTable para almacenar los resultados
            DataTable dt = new DataTable();

            SqlConnection conexion = new SqlConnection("server=DESKTOP-H5LC7P4\\SQLEXPRESS;database=PANIFICACION;integrated security = true");
            SqlCommand comando = new SqlCommand(consulta, conexion);
            conexion.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(dt);
            dgv_productos.DataSource = dt;
        }

        private void btn_refrescar_click(object sender, EventArgs e)
        {
            txtbox_nombre.Clear();
            txtbox_precio.Clear();
            txtbox_cantidad.Clear();
        }

        


        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desarrollar\r\nuna aplicación de una Panadería en Visual C#·y SQL Server Express que cumpla\r\ncon las  siguientes condiciones: Capa\r\nde presentación: (formulario) Altas de Productos. Capa\r\nde lógica del negocio:  agregar los\r\natributos del Producto. Capa\r\nde lógica del datos: Agregar el método de Insertar()");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtbox_precio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmEmpleados empleado = new frmEmpleados();
            empleado.Show();
        }
    }
}
