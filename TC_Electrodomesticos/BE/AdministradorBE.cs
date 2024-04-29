using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class AdministradorBE:UsuarioBE
    {
        private int _idUsuarioCreador;
        private string _nombreAdmin;
        private string _cuilAdmin;

        public string CuilAdmin
        {
            get { return _cuilAdmin; }
            set { _cuilAdmin = value; }
        }

        public string NombreAdmin
        {
            get { return _nombreAdmin; }
            set { _nombreAdmin = value; }
        }

        public int IdUsuarioCreador
        {
            get { return _idUsuarioCreador; }
            set { _idUsuarioCreador = value; }
        }
    }
}
