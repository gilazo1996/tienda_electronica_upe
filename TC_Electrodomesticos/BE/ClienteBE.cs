using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class ClienteBE:UsuarioBE
    {

		private string _nombreCliente;
		private string _cuilCliente;
		private int _idUserCreator;

		public int IdUsuarioCreador
		{
			get { return _idUserCreator; }
			set { _idUserCreator = value; }
		}

		public string CuilCliente
		{
			get { return _cuilCliente; }
			set { _cuilCliente = value; }
		}

		public string NombreCliente
		{
			get { return _nombreCliente; }
			set { _nombreCliente = value; }
		}
	}
}
