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
    public class CategoriaBLL
    {
        CategoriaDAL ObjCategorias = new CategoriaDAL(); 

        public DataTable CargarCategoria()
        {
            return ObjCategorias.CargarCategorias();
        }

        public DataTable ObtenerValorProductosPorCatego(int categoReceiv, string contextBusqueda)
        {
            ProductoDAL ObjProducto = new ProductoDAL();
            return ObjProducto.DevolverDatosdeProducto(categoReceiv, contextBusqueda);
        }
    }
}
