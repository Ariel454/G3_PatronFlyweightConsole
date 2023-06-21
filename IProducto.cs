using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_PatronFlyweightConsole
{
    interface IProducto
    {
        string nombre { get; }
        string descripcion { get; }
        decimal precio { get; }

        void MostrarInformacion();
    }

}
