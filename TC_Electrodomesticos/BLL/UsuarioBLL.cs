using DAL;
using System;
using System.Collections.Generic;
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
    }
}
