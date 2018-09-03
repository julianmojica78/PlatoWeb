using System.Text;
using Datos;
using Utilitarios;
using System.Data;
using System.Security.Cryptography;
using Newtonsoft.Json;
using System;

namespace Logica
{
    public class LUser
    {
        public UUser logear(UUser datos)
        {
            DUser data = new DUser();
            DataTable registros = data.loggin(datos);
            UUser user = new UUser();


            if (registros.Rows.Count > 0)
            {
                user.RolId = int.Parse(registros.Rows[0]["user_rol"].ToString());
                switch (int.Parse(registros.Rows[0]["user_rol"].ToString()))
                {
                    case 1:


                        user.User_name = registros.Rows[0]["nombre"].ToString();
                        user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());



                        UUser datosUsuario = new UUser();
                        Mac datosConexion = new Mac();

                        /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                         mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                        datosUsuario.UserId = user.UserId;
                        datosUsuario.Ip = datosConexion.ip();
                        datosUsuario.Mac = datosConexion.mac();
                        datosUsuario.Session = datos.Session;

                        data.guardadoSession(datosUsuario);
                        user.Url = "ListadePlatos.aspx";
                        break;

                    case 2:

                        user.User_name = registros.Rows[0]["nombre"].ToString();
                        user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());

                        UUser datosUsuario1 = new UUser();
                        Mac datosConexion1 = new Mac();

                        /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                         mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                        datosUsuario1.UserId = user.UserId;
                        datosUsuario1.Ip = datosConexion1.ip();
                        datosUsuario1.Mac = datosConexion1.mac();
                        datosUsuario1.Session = datos.Session;

                        data.guardadoSession(datosUsuario1);

                        user.Url = "Despachos.aspx";
                        break;

                    case 3:

                        user.User_name = registros.Rows[0]["nombre"].ToString();
                        user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());

                        UUser datosUsuario2 = new UUser();
                        Mac datosConexion2 = new Mac();

                        /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                         mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                        datosUsuario2.UserId = user.UserId;
                        datosUsuario2.Ip = datosConexion2.ip();
                        datosUsuario2.Mac = datosConexion2.mac();
                        datosUsuario2.Session = datos.Session;

                        data.guardadoSession(datosUsuario2);

                        user.Url = "Pedido.aspx";
                        break;


                    case 4:

                        user.User_name = registros.Rows[0]["nombre"].ToString();
                        user.UserId = int.Parse(registros.Rows[0]["user_id"].ToString());


                        UUser datosUsuario3 = new UUser();
                        Mac datosConexion3 = new Mac();


                        /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                         mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                        datosUsuario3.UserId = user.UserId;
                        datosUsuario3.Ip = datosConexion3.ip();
                        datosUsuario3.Mac = datosConexion3.mac();
                        datosUsuario3.Session = datos.Session;

                        data.guardadoSession(datosUsuario3);

                        user.Url = "inicio.aspx";
                        break;

                }
            }
            else
            {
                //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario o Contraseña Incorrectos');window.location=\"Loggin.aspx\"</script>");
                user.Url = "Loggin.aspx";
            }
            return user;
        }

        public UUsuario Cerrar (UUsuario datos)
        {
            DUser data = new DUser();
            UUsuario user = new UUsuario();


            data.cerrarSession(datos);
            user.Mensaje = "Loggin.aspx";

            return user;
        }

        public UUsuario Registro (UUsuario datos)
        {
            DUser data = new DUser();
            UUsuario user = new UUsuario();


            System.Data.DataTable validez = data.validarRegistro(datos.User_Name1, datos.Email);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                data.InsertarUsuario(datos);
                user.Mensaje ="<script type='text/javascript'>alert('Usuario Creado Correctamente');window.location=\"Loggin.aspx\"</script>";
                ////cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
                //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario Creado Correctamente');window.location=\"Loggin.aspx\"</script>");

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('Usuario o Correo Ya Esta Registrado');window.location=\"Registro.aspx\"</script>";
            }
            
            return user;
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

        public UReserva Reserva(UReserva datos)
        {
            DUser data = new DUser();
            UReserva user = new UReserva();

            if (datos.Nombre != null)
            {
                data.InsertReserva(datos);
                System.Data.DataTable validez1 = data.obtenerReserva(datos.Id_usuario);
                user.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());

                System.Data.DataTable validez = data.generarTokenReserva(user.Id_reserva);
                if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
                {
                    UUserToken token = new UUserToken();
                    token.Id = int.Parse(validez.Rows[0]["id_reserva"].ToString());
                    token.Id_usuario = int.Parse(validez.Rows[0]["id_usuario"].ToString());
                    token.Id_Mesa = int.Parse(validez.Rows[0]["id_mesa"].ToString());
                    token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());
                    token.Correo = validez.Rows[0]["email"].ToString();
                    token.Fecha = DateTime.Now.ToFileTimeUtc();

                    String userToken = encriptar(JsonConvert.SerializeObject(token));
                    data.almacenarTokenReserva(userToken, token.Id);

                    CorreoR correo = new CorreoR();

                    String mensaje = "su link de acceso es: " + "http://localhost:4167/View/pago.aspx?" + userToken;
                    correo.enviarCorreo(token.Correo, userToken, mensaje);

                    //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Para Confirmar su reseva por favor pague el valor de la reserva');</script>");
                    user.Mensaje = "<script type='text/javascript'>alert('Para Confirmar su reseva,por favor pague el valor de la reserva');window.location=\"Resrvas.aspx\"</script>";

                }
                else if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) == -2)
                {
                    user.Mensaje = "<script type='text/javascript'>alert('Ya existe un token, por favor verifique su correo.');</script>";

                }
                else
                {
                    user.Mensaje = "<script type='text/javascript'>alert('La Reserva no existe');</script>";

                }

            }
            else
            {
                user.Mensaje = "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');window.location=\"Loggin.aspx\"</script>";

                //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');window.location=\"Loggin.aspx\"</script>");

                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');</script>");
                ////Response.Redirect("Loggin.aspx");

            }

            return user;

        }

        public UReserva pago (UReserva datos)
        {
            DUser user = new DUser();
            UReserva data = new UReserva();


            System.Data.DataTable validez1 = user.obtenerReserva(datos.Id_usuario);
            data.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
            data.Id_usuario = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
            user.actualizarReserva(datos);

            data.Mensaje = "<script type='text/javascript'>alert('Pago Realizado con Exito');window.location=\"Inicio.aspx\"</script>";

            return data;
        }

        public DataTable depacho ()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerdatos();

            return dat;
            
        }
        public DataTable depacho1()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerdatos1();

            return dat;

        }
        public DataTable infoplato(Int32 id_pedido)
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.informacionPlato(id_pedido);

            return dat;

        }
        public DataTable infoplato1(Int32 id_pedido)
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.informacionPlato1(id_pedido);

            return dat;

        }

        public UDespachos despachos (Int32 id_pedido, DateTime fecha_despacho)
        {
            DUser llamar = new DUser();
            UDespachos desp = new UDespachos();

            llamar.despacho(id_pedido,fecha_despacho);

            desp.Url = "Despachos.aspx";

            return desp;

        }

        public UDespachos despachos1(Int32 id_pedido, DateTime fecha_despacho)
        {
            DUser llamar = new DUser();
            UDespachos desp = new UDespachos();

            llamar.despacho1(id_pedido, fecha_despacho);

            desp.Url = "Despachos.aspx";

            return desp;

        }

        public Estado estado (UUser datos)
        {
            Estado desp = new Estado();

            if (datos.User_name == null)
            {
                desp.Esstado =false;
            }
            else
            {
                desp.Esstado = true;
                desp.Estado1 = false;
            }
            
            return desp;

        }

        public DataTable ListaEmpleado()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerEmpleado();

            return dat;

        }

        public UUser rol(string rol)
        {
            UUser user = new UUser();
            if (rol == "Cocinero")
            {
                user.Url = "2";
            }
            else
            {
                user.Url = "3";
            }
            return user;

        }
        public UUsuario ObtenerId(string nombre)
        {
            DUser user = new DUser();
            UUsuario id = new UUsuario();
            System.Data.DataTable validez1 = user.obtenerId(nombre);
            id.User_id= int.Parse(validez1.Rows[0]["id_usuario"].ToString());

            return id;

        }
        public UUsuario ModificarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            UUsuario usuario = new UUsuario();

            user.modificarEmpleado(datos);
            usuario.Mensaje = "<script type='text/javascript'>alert('Modificado Correctamente');window.location=\"ListaEmpleados.aspx\"</script>";

            return usuario;

        }
        public UUsuario EliminarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            UUsuario usuario = new UUsuario();

            user.eliminarEmpleado(datos);
            usuario.Mensaje = "<script type='text/javascript'>alert('Eliminado Correctamente');window.location=\"ListaEmpleados.aspx\"</script>";

            return usuario;

        }
        public DataTable BuscarEmpleado(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusare(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
               usuario = user.buscarEmpleados(nombre);

            }
            return usuario;
        }
        public DataTable ListaClientes()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obteneruser();

            return dat;

        }
        public DataTable BuscarCliente(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusare(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                usuario = user.buscarUsuario(nombre);

            }
            return usuario;
        }
        public DataTable ListaVentas()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerplatopedido();

            return dat;

        }
        public DataTable BuscarVentas(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusarpp(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_pedido"].ToString()) > 0)
            {
                usuario = user.buscarPedidoplato(nombre);

            }
            return usuario;
        }
        public DataTable ListaReservas()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerReservaplato();

            return dat;

        }
        public DataTable BuscarReserva(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBusarrp(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_reserva"].ToString()) > 0)
            {
                usuario = user.validarBusarrp(nombre);

            }
            return usuario;
        }

        public DataTable ListaComentarios()
        {
            DUser llamar = new DUser();

            DataTable dat = llamar.obtenerComentarios();

            return dat;

        }

        public DataTable BuscarComentarios(UUsuario datos)
        {
            DUser user = new DUser();
            DataTable usuario = new DataTable();
            UUsuario men = new UUsuario();
            string nombre = datos.Nombre;
            System.Data.DataTable validez = user.validarBuscarco(datos.Nombre);
            if (int.Parse(validez.Rows[0]["id_reserva"].ToString()) > 0)
            {
                usuario = user.buscarUsuario(nombre);

            }
            return usuario;
        }

        public UComentarios InsertarComentario (UComentarios datos)
        {

            UComentarios comentario = new UComentarios();
            DUser data = new DUser();

            data.insertarComentarios(datos);

            comentario.Mensaje = "<script type='text/javascript'>alert('Comentario Enviado Correctamente');window.location=\"Inicio.aspx\"</script>";

            return comentario;
        }
    }

}
