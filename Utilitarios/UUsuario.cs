using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UUsuario
    {
        private Int32 user_id;
        private String nombre;
        private String apellido;
        private String email;
        private String telefono;
        private String cedula;
        private Int32 puntos;
        private Int32 id_Rol;
        private String User_Name;
        private String clave;
        private String rclave;
        private String session;
        private String mensaje;
        private Boolean isPostBack;
        private String url;
        private String rol;

        public int User_id
        {
            get
            {
                return user_id;
            }

            set
            {
                user_id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return apellido;
            }

            set
            {
                apellido = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public int Puntos
        {
            get
            {
                return puntos;
            }

            set
            {
                puntos = value;
            }
        }

        public int Id_Rol
        {
            get
            {
                return id_Rol;
            }

            set
            {
                id_Rol = value;
            }
        }

        public string User_Name1
        {
            get
            {
                return User_Name;
            }

            set
            {
                User_Name = value;
            }
        }

        public string Clave
        {
            get
            {
                return clave;
            }

            set
            {
                clave = value;
            }
        }

        public string Rclave
        {
            get
            {
                return rclave;
            }

            set
            {
                rclave = value;
            }
        }

        public string Session
        {
            get
            {
                return session;
            }

            set
            {
                session = value;
            }
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }
        public bool IsPostBack { get => isPostBack; set => isPostBack = value; }
        public string Url { get => url; set => url = value; }
        public string Rol { get => rol; set => rol = value; }
    }
}
