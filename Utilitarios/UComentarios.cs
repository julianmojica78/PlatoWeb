using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UComentarios
    {
        private String descripcion;
        private Int32 user_id;
        private String mensaje;

        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
    }
}
