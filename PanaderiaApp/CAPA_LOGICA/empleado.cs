using PanaderiaApp.CAPA_DATOS;

namespace PanaderiaApp.CAPA_LOGICA
{
    public class empleado
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }

        public void MostrarEmpleado(string nombre, string apellido, int edad)
        {

            empleadoDatos.SeleccionarEmpleado(nombre, apellido, edad);
        }
    }
}
