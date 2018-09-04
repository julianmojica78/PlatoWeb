using System;
using System.Web;
using System.Web.UI;
using Utilitarios;
using Logica;

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
        Uuser datos = new Uuser();
        Luser user = new Luser();
        ClientScriptManager cm = this.ClientScript;

        datos.Id_Rol = int.Parse(TB_Cantidad.Text.ToString());
        datos.Apellido = TB_Ubicacion.Text.ToString();

        user.insertmesa(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Ingresada');window.location=\"ListarMesas.aspx\"</script>");

    }
}