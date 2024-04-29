using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class UsuarioBE //usuarioBE es una clase abstracta porque de ella derivaran los demas usuarios según corresponda el rol asignado.
    {
        #region Atributos
        
        private string _nombre;
        private string _email;
        private string _password;
        public List<RolBE> _roles;
        public static int _IdUsuario; //este es un atributo static para tomar el ID del usuario

        public static int IdUsuario  //propiedad para tomar el valor del id del usuario, es para trabajar con el inicio de sesion
        {
            get { return _IdUsuario; }
            set { _IdUsuario = value; }
        }

        #endregion

        #region Propiedades  
        //propiedades especificas de cada atributo para su futuro uso, quizá el muestreo de estos datos en pantalla desde la base
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }


        public List<RolBE> Roles
        {
            get { return _roles; }
            set { _roles = value; }
        }
        #endregion
    }
}
