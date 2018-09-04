using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Cerrar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

            //Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
            //Response.Cache.SetAllowResponseInBrowserHistory(false);
            //Response.Cache.SetNoStore();
        

        Session["user_id"] = null;
        Session["nombre"] = null;

        DAOUsuario user = new DAOUsuario();
        EUsuario datos = new EUsuario();
        datos.Session = Session.SessionID;
        user.cerrarSession(datos);
        Response.Redirect("Loggin.aspx");
    }
}