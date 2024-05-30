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
    public class LoginUsuario //clase para que el usuario se logee
    {

         public bool IniciarSesion(string email, string password) //recibo los valores de texbox
         {
             Conexion objConexion = new Conexion();

             string consulta = $"SELECT * FROM usuarios WHERE email = '{email}' AND password = '{password}' AND estado = 'activo'"; //tomando los valores que ingresé en los texbox, verifico que exista en la tabla
             DataTable dt = objConexion.LeerPorComando(consulta); //invoco al metodo de la conexion q lee por comando

             if (dt.Rows.Count > 0) //verifico q se encuentre un usuario con los campos q obtuve
             {
                int idUsuario = Convert.ToInt32(dt.Rows[0]["id"]);
                UsuarioBE._IdUsuario = idUsuario;
                 return true; // campos valido
             }

             return false; // campos invalidos
         }
    }
}
