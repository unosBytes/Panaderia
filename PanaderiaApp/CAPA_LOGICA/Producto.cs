using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanaderiaApp.CAPA_DATOS;

namespace PanaderiaApp.CAPA_LOGICA
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }

        public void AgregarProducto(string nombre, decimal precio, int cantidad)
        {
            
            CAPA_DATOS.productoDatos.InsertarProducto(nombre, precio, cantidad);
        }
    }
}
