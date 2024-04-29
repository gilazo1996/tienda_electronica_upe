using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Vendedor:UsuarioBE
    {
        private int _idUsuarioCreador;
        private string _nombreVendedor;
        private string _cuilVendedor;

        public string CuilVendedor
        {
            get { return _cuilVendedor; }
            set { _cuilVendedor = value; }
        }

        public string NombreVendedor
        {
            get { return _nombreVendedor; }
            set { _nombreVendedor = value; }
        }

        public int IdUsuarioCreador
        {
            get { return _idUsuarioCreador; }
            set { _idUsuarioCreador = value; }
        }

    }
}
