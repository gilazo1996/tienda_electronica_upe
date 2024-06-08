using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class FacturaBE

    {

        public int IDFactura { get; set; }

        public string Fecha { get; set; }
        public double Total { get; set; }
        private List<DetalleFactura> listaDetalles;


        public FacturaBE()
        {
            listaDetalles = new List<DetalleFactura>();
        }
        public List<DetalleFactura> ListaDetalles { get; set; } = new List<DetalleFactura>();
        public override string ToString()
        {
            return $"Fecha:{Fecha} \t\t\t Total de la compra ${Total}";
        }
    }
}
