using System;
using System.Web;
using System.Web.UI;
using Logica;
using Utilitarios;

public partial class View_EliminarMesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        //if (!IsPostBack)
        //{

            UUser datos = new UUser();
            LUser user = new LUser();
            ClientScriptManager cm = this.ClientScript;

            TB_id_mesa.Text = Session["id_mesa"].ToString();
            TB_Cantidad.Text = Session["descripcion"].ToString();
        //}
    }

    protected void BT_Modificar_Click(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();

        ClientScriptManager cm = this.ClientScript;

        datos.User_id = int.Parse(Session["id_mesa"].ToString());
        user.eliminarmesa(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Eliminada Correctamente');window.location=\"ListarMesas.aspx\"</script>");

    }
}