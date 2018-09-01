using System;
using System.Web.UI;
using Utilitarios;
using Data;


public partial class View_MisReservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        UuserReservas datos = new UuserReservas();
        Duser user = new Duser();
        int id_usuario = int.Parse(Session["user_id"].ToString());

       // GV_misreservas.DataSource = user.obtenerMisReservas(id_usuario);
        //GV_misreservas.DataBind();
    }



    //protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    //{
    //    ClientScriptManager cm = this.ClientScript;
    //    EReservas datos = new EReservas();
    //    DAOUsuario user = new DAOUsuario();
    //    int id_usuario = int.Parse(Session["user_id"].ToString());

    //    GV_misreservas.DataSource = user.obtenerMisReservas(id_usuario);
    //    GV_misreservas.DataBind();
        
    //}

    protected void BT_Regresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Resrvas.aspx");
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}