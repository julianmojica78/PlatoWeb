using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ModificarMesa : System.Web.UI.Page
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
            TB_Ubicacion.Text = Session["ubicacion"].ToString();
        }
    }

    protected void BT_Modificar_Click(object sender, EventArgs e)
    {
        EUser datos = new EUser();
        DAOUsuario user = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;


        datos.User_id = int.Parse(Session["id_mesa"].ToString());
        datos.Nombre = TB_Cantidad.Text.ToString();
        datos.Apellido = TB_Ubicacion.Text.ToString();



        user.modificarMesas(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Modificada Correctamente');window.location=\"ListarMesas.aspx\"</script>");

    }
}