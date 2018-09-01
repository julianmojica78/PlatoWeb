using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UuserCrear
    {
        private String nomplato;
        private String descripcion;
        private String precio;
        private String imagen;
        private Int32 id_plato;

        public string Nomplato { get => nomplato; set => nomplato = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Precio { get => precio; set => precio = value; }
        public string Imagen { get => imagen; set => imagen = value; }
        public int Id_plato { get => id_plato; set => id_plato = value; }
    }
}
