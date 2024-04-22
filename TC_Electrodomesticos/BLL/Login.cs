using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class Login
    {
        private string _usuario;
        private string _clave;
        public bool IniciarSesion(string email, string password)
        {
            Conexion objConexion = new Conexion();

            string consulta = $"SELECT * FROM usuarios WHERE email = '{email}' AND password = '{password}'";
            DataTable dt = objConexion.LeerPorComando(consulta); //invoco al metodo de la conexion q lee por comando

            if (dt.Rows.Count > 0) //verifico q se encuentre un usuario con los campos q obtuve
            {
                return true; // campos valido
            }

            return false; // campos invalidos
        }
    }
}
