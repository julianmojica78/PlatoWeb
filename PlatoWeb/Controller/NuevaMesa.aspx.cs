using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_NuevaMesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        EUser datos = new EUser();
        DAOUsuario user = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;

        datos.Id_Rol = int.Parse(TB_Cantidad.Text.ToString());
        datos.Apellido = TB_Ubicacion.Text.ToString();

            user.insertarMesa(datos);
        //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Ingresada');window.location=\"ListarMesas.aspx\"</script>");

    }
}