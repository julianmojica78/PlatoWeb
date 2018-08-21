using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_EliminarPlato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["id_plato"] = GridView1.SelectedRow.Cells[1].Text;
        Session["nombre"] = GridView1.SelectedRow.Cells[2].Text;
        Session["descripcion"] = GridView1.SelectedRow.Cells[3].Text;
        Session["precio"] = GridView1.SelectedRow.Cells[4].Text;
        Session["imagen"] = GridView1.SelectedRow.Cells[5].Text;

    }

    protected void B_eliminar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Eliminar_Plato.aspx");
    }
}