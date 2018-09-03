using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UuserReservas
    {
        private String dia;
        private Int32 cant;
        private Int32 puntos;
        private Int32 id_usuario;
        private Int32 id_plato;
        private Int32 id_reserva;
        private Int32 estado;
        private Boolean est1;
        private Boolean est2;

        public string Dia { get => dia; set => dia = value; }
        public int Cant { get => cant; set => cant = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_plato { get => id_plato; set => id_plato = value; }
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public int Estado { get => estado; set => estado = value; }
        public bool Est1 { get => est1; set => est1 = value; }
        public bool Est2 { get => est2; set => est2 = value; }
    }
}

