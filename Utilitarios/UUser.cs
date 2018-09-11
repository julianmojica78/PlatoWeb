using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilitarios
{
    public class UUser
    {
        private String url;
        private Int32 userId;
        private Int32 rolId;
        private String mensaje;
        private String session;
        private String ip;
        private String mac;
        private String clave;
        private String user_name;
        private bool isPostBack;
        private String nombre;
        private String telefono;
        private String email;
        private String detalle;
        private String ruta;
        private String ubicacion;
        private Int32 x;
        private Int32 user_id;
        private String apellido;
        private String cedula;
        private int puntos;
        private int id_Rol;
        private String User_Name;
        private String rclave;
        private Boolean ispos;
        private String a;
        private String b;
        private String c;
        private String d;
        private String e;
        private String f;
        private String extension;


        public int UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }

        public int RolId
        {
            get
            {
                return rolId;
            }

            set
            {
                rolId = value;
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

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public string Mac
        {
            get
            {
                return mac;
            }

            set
            {
                mac = value;
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

        public string User_name
        {
            get
            {
                return user_name;
            }

            set
            {
                user_name = value;
            }
        }

        public string Mensaje { get => mensaje; set => mensaje = value; }
        public string Url { get => url; set => url = value; }
        public bool IsPostBack { get => isPostBack; set => isPostBack = value;}
        public string Nombre { get => nombre; set => nombre = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Email { get => email; set => email = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string Ruta { get => ruta; set => ruta = value; }
        public string Ubicacion { get => ubicacion; set => ubicacion = value; }
        public int X { get => x; set => x = value; }
        public int User_id { get => user_id; set => user_id = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int Id_Rol { get => id_Rol; set => id_Rol = value; }
        public string User_Name1 { get => User_Name; set => User_Name = value; }
        public string Rclave { get => rclave; set => rclave = value; }
        public bool Ispos { get => ispos; set => ispos = value; }
        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
        public string C { get => c; set => c = value; }
        public string D { get => d; set => d = value; }
        public string E { get => e; set => e = value; }
        public string F { get => f; set => f = value; }
        public string Extension { get => extension; set => extension = value; }
    }
}
