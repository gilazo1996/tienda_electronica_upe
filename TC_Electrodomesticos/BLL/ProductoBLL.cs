using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class ProductoBLL
    {
        ProductoDAL ObjProducto = new ProductoDAL();

        public DataTable ObtenerValorIDproduct(int idReceived, string contextBusqueda)
        {
            return ObjProducto.DevolverDatosdeProducto(idReceived, contextBusqueda);
        }

        public bool ActualizarProdPorID(int id, string nombre, double precio, int unidades, string descripcion, int categoria)
        {
            return ObjProducto.UpdateProductoPorID(id, nombre, precio, unidades, descripcion, categoria);
        }

        public bool EliminarProductoPorID(int idReceived)
        {
            return ObjProducto.EliminarProductoPorID(idReceived);
        }
    }
}
