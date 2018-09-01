using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UUserToken
    {
        private Int32 id;
        private String nombre;
        private String apellido;
        private String telefono;
        private String puntos;
        private String id_rol;
        private String correo;
        private String user_name;
        private String clave;
        private Int32 estado;
        private Int32 id_Mesa;
        private Int32 id_usuario;
        private String cedula;
        private String session;
        private long fecha;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Puntos { get => puntos; set => puntos = value; }
        public string Id_rol { get => id_rol; set => id_rol = value; }
        public string Correo { get => correo; set => correo = value; }
        public string User_name { get => user_name; set => user_name = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Estado { get => estado; set => estado = value; }
        public int Id_Mesa { get => id_Mesa; set => id_Mesa = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Session { get => session; set => session = value; }
        public long Fecha { get => fecha; set => fecha = value; }
    }
}
