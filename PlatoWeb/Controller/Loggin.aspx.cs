using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Loggin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Generar_Token.aspx");
    }

    protected void B_Registrarse_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        EUsuario usuario = new EUsuario();
        DAOUsuario datos = new DAOUsuario();
        usuario.User_name = UserName.Text.ToString();
        usuario.Clave = Password.Text.ToString();

        DataTable registros = datos.loggin(usuario);
        if (registros.Rows.Count > 0)
        {
            switch (int.Parse(registros.Rows[0]["user_rol"].ToString()))
            {
                case 1:
                    Session["user_id"] = registros.Rows[0]["user_id"].ToString();
                    Session["nombre"] = registros.Rows[0]["nombre"].ToString();

                    EUsuario datosUsuario = new EUsuario();
                    MAC datosConexion = new MAC();

                    /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                     mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                    datosUsuario.UserId = int.Parse(Session["user_id"].ToString());
                    datosUsuario.Ip = datosConexion.ip();
                    datosUsuario.Mac = datosConexion.mac();
                    datosUsuario.Session = Session.SessionID;

                    datos.guardadoSession(datosUsuario);

                    Response.Redirect("ListadePlatos.aspx");
                    break;

                case 2:
                    Session["user_id"] = registros.Rows[0]["user_id"].ToString();
                    Session["nombre"] = registros.Rows[0]["nombre"].ToString();

                    EUsuario datosUsuario1 = new EUsuario();
                    MAC datosConexion1 = new MAC();

                    /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                     mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                    datosUsuario1.UserId = int.Parse(Session["user_id"].ToString());
                    datosUsuario1.Ip = datosConexion1.ip();
                    datosUsuario1.Mac = datosConexion1.mac();
                    datosUsuario1.Session = Session.SessionID;

                    datos.guardadoSession(datosUsuario1);

                    Response.Redirect("Despachos.aspx");
                    break;

                case 3:
                    Session["user_id"] = registros.Rows[0]["user_id"].ToString();
                    Session["nombre"] = registros.Rows[0]["nombre"].ToString();

                    EUsuario datosUsuario2 = new EUsuario();
                    MAC datosConexion2 = new MAC();

                    /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                     mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                    datosUsuario2.UserId = int.Parse(Session["user_id"].ToString());
                    datosUsuario2.Ip = datosConexion2.ip();
                    datosUsuario2.Mac = datosConexion2.mac();
                    datosUsuario2.Session = Session.SessionID;

                    datos.guardadoSession(datosUsuario2);

                    Response.Redirect("Pedido.aspx");
                    break;


                case 4:
                    Session["user_id"] = registros.Rows[0]["user_id"].ToString();
                    Session["nombre"] = registros.Rows[0]["nombre"].ToString();

                    EUsuario datosUsuario3 = new EUsuario();
                    MAC datosConexion3 = new MAC();

                    /* ipAddress = HttpContext.Current.Request.UserHostAddress;
                     mac = Utilidades.Mac.GetMAC(ref ipAddress);*/

                    datosUsuario3.UserId = int.Parse(Session["user_id"].ToString());
                    datosUsuario3.Ip = datosConexion3.ip();
                    datosUsuario3.Mac = datosConexion3.mac();
                    datosUsuario3.Session = Session.SessionID;

                    datos.guardadoSession(datosUsuario3);

                    Response.Redirect("Inicio.aspx");
                    break;
            }
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario o Contraseña Incorrectos');window.location=\"Loggin.aspx\"</script>");

        }

    }
}