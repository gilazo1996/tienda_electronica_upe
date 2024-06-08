using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AdministradorBLL
    {
        private readonly AdministradorDAL _administradorDAL;

        public AdministradorBLL()
        {
            _administradorDAL = new AdministradorDAL();
        }

        public DataTable ObtenerTodosLosUsuarios()
        {
            return _administradorDAL.ObtenerTodosLosUsuarios();
        }

        public bool BloquearUsuario(int idUsuario)
        {
            return _administradorDAL.BloquearUsuario(idUsuario);
        }
        public bool DesbloquearUsuario(int idUsuario)
        {
            return _administradorDAL.DesbloquearUsuario(idUsuario);
        }

        public DataTable ObtenerUsuariosPorNombreYCorreo(string name, string mail)
        {
            return _administradorDAL.ObtenerUsuariosPorNombreYCorreo(name, mail);
        }

        public bool AsignarRolUsuario(int idUsuario, int idRol)
        {
            return _administradorDAL.AsignarRolUsuario(idUsuario, idRol);
        }

        public bool CrearUsuario(string nombre, string email, string password, int idRol, out string mensaje)
        {
            try
            {
                int idUsuario = _administradorDAL.CrearUsuario(nombre, email, password);
                if (idUsuario > 0)
                {
                    if (_administradorDAL.AsignarRolUsuario(idUsuario, idRol))
                    {
                        mensaje = "Usuario creado con éxito.";
                        return true;
                    }
                    else
                    {
                        mensaje = "Error al asignar el rol al usuario.";
                        return false;
                    }
                }
                else
                {
                    mensaje = "Error al crear el usuario.";
                    return false;
                }
            }
            catch (Exception ex)
            {
                mensaje = ex.Message;
                return false;
            }
        }

        public DataTable ObtenerRoles()
        {
            return _administradorDAL.ObtenerRoles();
        }

        public bool ModificarUsuarioCampo(int idUsuario, string campo, string valor, out string mensaje)
        {
            try
            {
                bool resultado = _administradorDAL.ModificarUsuarioCampo(idUsuario, campo, valor);
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
