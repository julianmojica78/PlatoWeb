using System;
using System.Web;

public partial class View_ListarMesas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarMesa.aspx");
    }

    protected void BT_Eliminar_Click1(object sender, EventArgs e)
    {
        Response.Redirect("EliminarMesa.aspx");
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("Loggin.aspx");
        }
        DAOUsuario dato = new DAOUsuario();
        GV_Resultado.DataSource = dato.buscarMesas(TB_Filtro.Text.ToString());
        GV_Resultado.DataBind();
    }

    protected void GV_Empleados_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id_mesa"] = GV_Mesas.SelectedRow.Cells[1].Text;
        Session["descripcion"] = GV_Mesas.SelectedRow.Cells[2].Text;
        Session["ubicacion"] = GV_Mesas.SelectedRow.Cells[3].Text;
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("NuevaMesa.aspx");
    }
}