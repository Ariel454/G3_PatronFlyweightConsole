using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_PatronFlyweightConsole
{
class Producto : IProducto
{
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; }

        public Producto(string nombre, string descripcion, decimal precio)
    {
        this.nombre = nombre;
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine("Nombre: {0}", nombre);
        Console.WriteLine("Descripción: {0}", descripcion);
        Console.WriteLine("Precio: {0}", precio);
        Console.WriteLine("--------------------------------------");
    }
}
}
