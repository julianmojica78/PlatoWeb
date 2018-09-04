using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_MisReservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        EReservas datos = new EReservas();
        DAOUsuario user = new DAOUsuario();
        int id_usuario = int.Parse(Session["user_id"].ToString());

        GridView1.DataSource = user.obtenerMisReservas(id_usuario);
        GridView1.DataBind();
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        EReservas datos = new EReservas();
        DAOUsuario user = new DAOUsuario();
        int id_usuario = int.Parse(Session["user_id"].ToString());

        GridView1.DataSource = user.obtenerMisReservas(id_usuario);
        GridView1.DataBind();
        
    }

    protected void BT_Regresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Resrvas.aspx");
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}