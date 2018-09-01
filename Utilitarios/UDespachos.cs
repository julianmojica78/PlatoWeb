using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UDespachos
    {
        private Int32 pedidos;
        private Int32 mesa;
        private String plato;
        private Int32 cantidad;
        private String url;

        public int Pedidos { get => pedidos; set => pedidos = value; }
        public int Mesa { get => mesa; set => mesa = value; }
        public string Plato { get => plato; set => plato = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public string Url { get => url; set => url = value; }
    }
}
