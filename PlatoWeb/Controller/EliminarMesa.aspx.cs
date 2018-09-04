using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_EliminarMesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        if (!IsPostBack)
        {

            EUser datos = new EUser();
            DAOUsuario user = new DAOUsuario();
            ClientScriptManager cm = this.ClientScript;

            TB_id_mesa.Text = Session["id_mesa"].ToString();
            TB_Cantidad.Text = Session["descripcion"].ToString();
        }
    }

    protected void BT_Modificar_Click(object sender, EventArgs e)
    {
        EUser datos = new EUser();
        DAOUsuario dato = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;

        datos.User_id = int.Parse(Session["id_mesa"].ToString());
        dato.eliminarMesa(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Eliminada Correctamente');window.location=\"ListarMesas.aspx\"</script>");

    }
}