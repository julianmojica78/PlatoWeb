using System;
using System.Data;
using Utilitarios;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;
using Datos;

namespace Logica
{
    public class Luser
    {
        public Uuser contactenos(String nombre, String telefono, String email, String detalle)
        {
            Duser data = new Duser();
            DataTable datos = data.insertarContacto(nombre, telefono, email, detalle);
            Uuser user = new Uuser();

            return user;
        }
        public UuserToken GenerarToken(String user_name)
        {
            Duser data = new Duser();
            DataTable validez = data.generarToken(user_name);
            UuserToken token = new UuserToken();

            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {

                token.Id = int.Parse(validez.Rows[0]["id_usuario"].ToString());
                token.Nombre = validez.Rows[0]["nombre"].ToString();
                token.Apellido = validez.Rows[0]["apellido"].ToString();
                token.Correo = validez.Rows[0]["email"].ToString();
                token.Telefono = validez.Rows[0]["telefono"].ToString();
                token.Cedula = validez.Rows[0]["cedula"].ToString();
                token.Puntos = validez.Rows[0]["puntos"].ToString();
                token.Id_rol = validez.Rows[0]["id_rol"].ToString();
                token.User_name = validez.Rows[0]["user_name"].ToString();
                token.Clave = validez.Rows[0]["clave"].ToString();
                token.Session = validez.Rows[0]["session"].ToString();
                token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());

                token.Fecha = DateTime.Now.ToFileTimeUtc();

                String userToken = encriptar(JsonConvert.SerializeObject(token));
                data.almacenarToken(userToken, token.Id);

                Correo correo = new Correo();


                String mensaje = "su link de acceso es: " + "http://localhost:54080/View/Recuperar_Contraseña.aspx?" + userToken;
                correo.enviarCorreo(token.Correo, userToken, mensaje);

                token.Url = "<script type='text/javascript'>alert('Su nueva contraseña ha sido enviada exitosamente a su correo');window.location=\"Loggin.aspx\"</script>";

            }
            else if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) == -2)
            {
                token.Mensaje = "Ya existe un token, por favor verifique su correo.";
            }
            else
            {
                token.Mensaje = "El usurio digitado no existe";
            }
            return token;
        }
        private string encriptar(string input)
        {
            SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashedBytes = provider.ComputeHash(inputBytes);

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < hashedBytes.Length; i++)
                output.Append(hashedBytes[i].ToString("x2").ToLower());

            return output.ToString();
        }
        public int Recuperar(int x, string y)
        {
            Duser user = new Duser();
            UuserToken token = new UuserToken();
            int sesion = 0;
            if (x > 0)
            {

                DataTable info = user.obtenerUsusarioToken(y);

                if (int.Parse(info.Rows[0][0].ToString()) == -1)
                    token.Url = "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>";
                else if (int.Parse(info.Rows[0][0].ToString()) == -1)
                    token.Url = "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>";
                else
                    sesion = int.Parse(info.Rows[0][0].ToString());
            }
            else
                token.Url = "Inicio.aspx";

            return sesion;
        }
        public void guardarcontra(int x, string y)
        {
            UuserToken datos = new UuserToken();
            Duser user = new Duser();

            datos.User_id = x;
            datos.Clave = y;
            user.actualziarContrasena(datos);
            datos.Url = "<script type='text/javascript'>alert('Su Contraseña ha sido actualizada.');window.location=\"Loggin.aspx\"</script>";

        }

        public DataTable listarmenu()
        {
            Duser data = new Duser();
            DataTable datos = data.obtenerPlato();


            return datos;
        }
        public DataTable Listadomesas()
        {
            Duser dato = new Duser();
            DataTable data = dato.obtenerMesas();

            return data;
        }
        public UuserReservas canje(DataTable tabla)
        {
            Duser data = new Duser();
            UuserReservas dato = new UuserReservas();

            int sum = 0;
            int p = 0;

            foreach (DataRow fila in tabla.Rows)
            {
                string punto = tabla.Rows[0]["puntos"].ToString();
                p = int.Parse(punto);
                sum = p;
            }
            dato.Cant = sum;

            if (sum < 100)
            {
                dato.Est1 = true;
                dato.Est2 = false;
            }
            else
            {
                dato.Est1 = false;
                dato.Est2 = true;
            }
            return dato;
        }
        public DataTable obtenerReservas(int id_usuario)
        {
            Duser dao = new Duser();
            DataTable reser = dao.obtenerMisReservas(id_usuario);
            return reser;
        }
        public DataTable obtenerPuntos(int id)
        {
            Duser dao = new Duser();
            DataTable reser = dao.obtenerPuntos(id);
            return reser;
        }
        public DataTable redimir(int id)
        {
            Duser dato = new Duser();
            DataTable redimi = dato.redimir(id);
            return redimi;
        }
        public void cortesia(int id)
        {
            Duser dato = new Duser();
            dato.Insertarcortesia(id);

        }
        public void obtenerPlato()
        {
            Duser dato = new Duser();
            dato.obtenerPlato();
        }
        public DataTable guardarPedido(UuserPedido pedido)
        {
            Duser dato = new Duser();
            DataTable data = dato.insertarPedido(pedido);
            return data;
        }
        public DataTable obtenerpe(int user_id)
        {
            Duser dato = new Duser();
            DataTable data = dato.obtenerPedido(user_id);
            return data;
        }
        public DataTable guardarPedido1(UuserPedido pedido)
        {
            Duser dato = new Duser();
            DataTable data = dato.InsertPedido(pedido);
            return data;
        }
        public void listaplatos(bool x)
        {
            Duser dato = new Duser();
            Uuser data = new Uuser();
            if (x)
            {
                data.Url = "Loggin.aspx";
            }
            DataTable tabla = dato.obtenerPlato();
        }
        public DataTable obtenerMesa(string nombre)
        {
            Duser dato = new Duser();
            DataTable data = dato.obtenerIdm(nombre);
            return data;
        }
        public void eliminarPlato(UuserCrear datos)
        {
            Duser dato = new Duser();
            DataTable data = dato.EliminarPlato(datos);
        }
        public DataTable validarbuscarM(string nombre)
        {
            Duser dato = new Duser();
            DataTable data = dato.validarBuscarm(nombre);
            Uuser datos = new Uuser();

            return data;
        }
        public DataTable buscarPla(string nombre)
        {
            Duser dato = new Duser();
            DataTable tabla = new DataTable();
            Uuser datos = new Uuser();

            if (datos.X > 0)
            {
                dato.buscarPlato(nombre);
            }
            else
            {
                datos.Url ="<script type='text/javascript'>alert('Plato no Existe');window.location=\"ListadePlatos.aspx\"</script>";
            }
            return tabla;
        }
        public void insertmenu(UuserCrear datos)
        {
            Duser dato = new Duser();
            DataTable data = dato.insertarMenu(datos);
            if (datos.Imagen != null)
            {
                dato.insertarMenu(datos);
            }
        }


        public Uuser cargaImage(Uuser info)
        {
            Duser dato = new Duser();
            Uuser mensaje = new Uuser();
            String nombreArchivo = System.IO.Path.GetFileName(info.Nombre);
            String extension = System.IO.Path.GetExtension(info.Ruta);
            String saveLocation = "";
            if (!(string.Compare(extension, ".jpg", true) == 0 || string.Compare(extension, ".jpeg", true) == 0 || string.Compare(extension, ".gif", true) == 0 || string.Compare(extension, ".jpe", true) == 0))
            {
                mensaje.Url ="<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>";
                return null;
            }
            
            saveLocation = info.Ubicacion;


            if (System.IO.File.Exists(saveLocation))
            {
                mensaje.Url ="<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>";
                return null;
            }
            return mensaje;
        }
        public DataTable insertmesa(Uuser datos)
        {
            Duser data = new Duser();
            DataTable dato = data.insertarMesa(datos);
            return dato;
        }
        public DataTable mofifimesas(Uuser datos)
        {
            Duser data = new Duser();
            DataTable dato = data.modificarMesas(datos);
            return dato;            
        }
        public void ispost(Uuser info)
        {            
            if (!info.Ispos)
            {
                Duser data = new Duser();
                Uuser datos = new Uuser();
                info.A = info.B;
                info.C = info.D;
                info.E = info.F;
            }
        }
        public DataTable listadoComentario()
        {
            Duser data = new Duser();
            Uuser datos = new Uuser();
            DataTable tabla = data.obtenerComentarios();
            return tabla;
        }
        public DataTable buscarcomen(string Nombre)
        {
            Duser data = new Duser();
            Uuser datos = new Uuser();
            DataTable tabla = data.validarBuscarco(Nombre);
            return tabla;
        }
        public DataTable buscarUser(string nombre)
        {
            Duser data = new Duser();
            Uuser datos = new Uuser();
            DataTable tabla = new DataTable();

            if (datos.X > 0)
            {
                data.buscarUsuario(nombre);
            }
            else
            {
                datos.Url = "<script type='text/javascript'>alert('Plato no Existe');window.location=\"ListaComentarios.aspx\"</script>";
            }
            return tabla;
        }
        public DataTable eliminarmesa(Uuser datos)
        {
            Duser dato = new Duser();
            DataTable data = dato.eliminarMesa(datos);
            return data;
        }
    }
    
}
