using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_PatronFlyweightConsole
{
    class ProductoFactory
    {
        private List<IProducto> productos = new List<IProducto>();

        public IProducto ObtenerProducto(string nombre, string descripcion, decimal precio)
        {
            IProducto productoExistente = productos.Find(p => p.GetType() == typeof(Producto) &&
                                                             ((Producto)p).nombre == nombre &&
                                                             ((Producto)p).descripcion == descripcion &&
                                                             ((Producto)p).precio == precio);

            if (productoExistente != null)
            {
                Console.WriteLine("Obteniendo producto existente: {0}", productoExistente);
                return productoExistente;
            }

            Console.WriteLine("Creando nuevo producto");
            Producto nuevoProducto = new Producto(nombre, descripcion, precio);
            productos.Add(nuevoProducto);
            return nuevoProducto;
        }

        public List<IProducto> GetProductos()
        {
            return productos;
        }
    }
}



