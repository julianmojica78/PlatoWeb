using System;
using System.Web;
using System.Web.UI;
using Utilitarios;
using Logica;

public partial class View_ModificarMesa : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        UUser datos = new UUser();
        datos.Ispos = IsPostBack;
        LUser info = new LUser();
        //TB_id_mesa.Text = Session["id_mesa"].ToString();
        //TB_Cantidad.Text = Session["descripcion"].ToString();
        //TB_Ubicacion.Text = Session["ubicacion"].ToString();

        info.ispost(datos);
        { 
            ClientScriptManager cm = this.ClientScript;
            datos.A = TB_id_mesa.Text;
            datos.B = Session["id_mesa"].ToString();
            datos.C = TB_Cantidad.Text;
            datos.D = Session["descripcion"].ToString();
            datos.E = TB_Ubicacion.Text;
            datos.F = Session["ubicacion"].ToString();
        }



        

    }

        protected void BT_Modificar_Click(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();
        ClientScriptManager cm = this.ClientScript;


        datos.User_id = int.Parse(Session["id_mesa"].ToString());
        datos.Nombre = TB_Cantidad.Text.ToString();
        datos.Apellido = TB_Ubicacion.Text.ToString();



        user.mofifimesas(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mesa Modificada Correctamente');window.location=\"ListarMesas.aspx\"</script>");

    }
}