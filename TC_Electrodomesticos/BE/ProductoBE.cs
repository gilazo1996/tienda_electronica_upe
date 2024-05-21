using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ProductoBE
    {

        public int IDproducto { get; set; }
        public string NombreProducto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"{NombreProducto} - {Categoria} - ${Precio}";
        }
    }
}
