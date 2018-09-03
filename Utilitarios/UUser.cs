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
    }
}
