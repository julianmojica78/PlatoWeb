using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UReserva
    {
        private String dia;
        private String mensaje;
        private String nombre;
        private Int32 cant;
        private Int32 puntos;
        private Int32 id_usuario;
        private Int32 id_plato;
        private Int32 id_reserva;
        private Int32 estado;

        public string Dia { get => dia; set => dia = value; }
        public int Cant { get => cant; set => cant = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Id_plato { get => id_plato; set => id_plato = value; }
        public int Id_reserva { get => id_reserva; set => id_reserva = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
