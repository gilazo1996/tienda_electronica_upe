using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class GestorStock:UsuarioBE
    {
        private string _nombreGestor;
        private string _cuilGestor;
        private int _idUserCreator;
        private List<ProductoBE> _listaProductos;

        public GestorStock()
        {
            _listaProductos = new List<ProductoBE>();
        }
        public List<ProductoBE> ListaProductos { get; set; } = new List<ProductoBE>();


        public int IdUsuarioCreador
        {
            get { return _idUserCreator; }
            set { _idUserCreator = value; }
        }

        public string CuilGestor
        {
            get { return _cuilGestor; }
            set { _cuilGestor = value; }
        }

        public string NombreGestor
        {
            get { return _nombreGestor; }
            set { _nombreGestor = value; }
        }


    }
}
