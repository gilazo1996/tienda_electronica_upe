using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GerenteDAL
    {
        private Conexion objConexion = new Conexion();

        public void MostrarFacturas(List<ClienteBE> clientes)
        {
            string sqlvisualizarfacturas = "select CONVERT(varchar,fecha_compra,3) AS fecha_compra, Factura.id, Factura.total, clientes.nombre from Factura, clientes where Factura.id_usuario=clientes.id_usuario_creador";

            DataTable tabla = objConexion.LeerPorComando(sqlvisualizarfacturas);

            foreach (DataRow row in tabla.Rows)
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                ClienteBE clienteBE = new ClienteBE();
                clienteBE.NombreCliente = row["nombre"].ToString();
                FacturaBE venta = new FacturaBE()
                {
                    IDFactura = Convert.ToInt32(row["id"]),
                    Total = Convert.ToDouble(row["total"]),
                    Fecha = row["fecha_compra"].ToString(),                 
                };
                usuarioDAL.VerDetallesFactura(venta, venta.IDFactura);
                clienteBE.ListaFacturas.Add(venta);
                clientes.Add(clienteBE);             
            }
        }

        public void BuscarFactura(List<ClienteBE> clientes, DateTime fecha)
        {          
            string sqlvisualizarfacturas = $"select CONVERT(varchar,fecha_compra,3) AS fecha_compra, Factura.total, Factura.id, clientes.nombre from Factura, clientes where Factura.id_usuario=clientes.id_usuario_creador and Factura.fecha_compra= '{fecha.ToString("yyyy-MM-dd")}'";

            DataTable tabla = objConexion.LeerPorComando(sqlvisualizarfacturas);

            foreach (DataRow row in tabla.Rows)
            {
                UsuarioDAL usuarioDAL =new UsuarioDAL();
                ClienteBE clienteBE = new ClienteBE();
                clienteBE.NombreCliente = row["nombre"].ToString();
                FacturaBE venta = new FacturaBE()
                {
                    Total = Convert.ToDouble(row["total"]),
                    Fecha = row["fecha_compra"].ToString(),
                    IDFactura = Convert.ToInt32(row["id"]),
                };
                usuarioDAL.VerDetallesFactura(venta, venta.IDFactura);
                clienteBE.ListaFacturas.Add(venta);

                clientes.Add(clienteBE);
            }
        }
    }
}