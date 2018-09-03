using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UuserPedido
    {
        private Int32 id_pedido;
        private Int32 id_plato;
        private Int32 cantidad;
        private Int32 id_mesero;
        private Int32 id_mesa;
        private Int32 id_usuario;
        private Int32 id_pedido1;

        public int Id_pedido { get => id_pedido; set => id_pedido = value; }
        public int Id_plato { get => id_plato; set => id_plato = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Id_mesero { get => id_mesero; set => id_mesero = value; }
        public int Id_mesa { get => id_mesa; set => id_mesa = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_pedido1 { get => id_pedido1; set => id_pedido1 = value; }
    }
}

