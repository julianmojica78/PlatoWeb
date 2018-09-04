using System;
using Logica;
using Utilitarios;

public partial class View_EliminarPlato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id_plato"] = GV_eliminarPato.SelectedRow.Cells[1].Text;
        Session["nombre"] = GV_eliminarPato.SelectedRow.Cells[2].Text;
        Session["descripcion"] = GV_eliminarPato.SelectedRow.Cells[3].Text;
        Session["precio"] = GV_eliminarPato.SelectedRow.Cells[4].Text;
        Session["imagen"] = GV_eliminarPato.SelectedRow.Cells[5].Text;

    }

    protected void B_eliminar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Eliminar_Plato.aspx");
    }
}