using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;

namespace DAL
{
    public class CategoriaDAL
    {
        public DataTable CargarCategorias()
        {
            Conexion connect = new Conexion();
            connect.Conectar();   string sentenciaSQL = "SELECT id, nombre FROM Categoria_Producto";
            return connect.LeerPorComando(sentenciaSQL);
        }
    }
}
