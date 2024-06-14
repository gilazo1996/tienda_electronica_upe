using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBLL
    {
        private readonly UsuarioDAL _usuarioDAL;

        public UsuarioBLL()
        {
            _usuarioDAL = new UsuarioDAL();
        }

        public bool RegistrarUsuario(string nombre, string email, string password)
        {
            return _usuarioDAL.RegistrarUsuario(nombre, email, password);

        }

        public bool RegistrarCliente(string nombreCompleto, string CUIL, int id, out bool clienteQueExiste)
        {
            return _usuarioDAL.RegistrarCliente(nombreCompleto, CUIL, id, out clienteQueExiste);
        }

        public int ObtenerIdUsuarioPorEmail(string email)
        {
            return _usuarioDAL.ObtenerIdUsuarioPorEmail(email);
        }

        public DataTable UsuarioActual(int idUsuario)
        {
            return _usuarioDAL.UsuarioActual(idUsuario);
        }

        public bool ModificarUsuari(int idUsuario, string nombre, string mail, string pass, out string mensaje)
        {
            try
            {
                bool resultado = _usuarioDAL.ModificarUsuari(idUsuario, nombre, mail, pass);
                if (resultado)
                {
                    mensaje = "Usuario modificado con éxito.";
                    return true;
                }
                else
                {
                    mensaje = "Error al modificar el usuario.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }
    }
}
