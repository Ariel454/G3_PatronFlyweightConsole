using G3_PatronFlyweightConsole;

class Cliente
{
    static void Main(string[] args)
    {
        ProductoFactory factory = new ProductoFactory();

        // Agregamos productos manualmente
        IngresarProducto(factory);
        IngresarProducto(factory);
        IngresarProducto(factory);

        // Mostramos la información de todos los productos
        MostrarInformacionProductos(factory);
    }

    static void IngresarProducto(ProductoFactory factory)
    {
        Console.WriteLine("Ingrese el nombre del producto:");
        string nombre = Console.ReadLine();

        Console.WriteLine("Ingrese la descripción del producto:");
        string descripcion = Console.ReadLine();

        Console.WriteLine("Ingrese el precio del producto:");
        decimal precio = decimal.Parse(Console.ReadLine());

        IProducto producto = factory.ObtenerProducto(nombre, descripcion, precio);
        Console.WriteLine("Producto ingresado: {0}", producto);
        Console.WriteLine();
    }

    static void MostrarInformacionProductos(ProductoFactory factory)
    {
        Console.WriteLine("Información de todos los productos:");
        Console.WriteLine("----------------------------------");

        List<IProducto> productos = factory.GetProductos();

        Console.WriteLine("Cantidad de productos: {0}", productos.Count);

        foreach (var producto in productos)
        {
            producto.MostrarInformacion();
        }
    }
}