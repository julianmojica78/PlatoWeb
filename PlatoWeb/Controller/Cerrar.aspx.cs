using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_Cerrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        Session["user_id"] = null;
        Session["nombre"] = null;

        LUser user = new LUser();
        UUsuario datos = new UUsuario();
        datos.Session = Session.SessionID;
        datos = user.Cerrar(datos);
        Response.Redirect(datos.Mensaje);
    }
}