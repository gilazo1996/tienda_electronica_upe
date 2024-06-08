using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class DetalleFactura
    {
        public int _cantidad;
        public int id_factura;
        public string producto_comprado;
        public double _subtotal;


        public DetalleFactura()
        {

        }
        public override string ToString()
        {
            return $"Producto comprado: {producto_comprado} \t cantidad: {_cantidad}  \t\t Subtotal ${_subtotal}";
        }

    }
   }
