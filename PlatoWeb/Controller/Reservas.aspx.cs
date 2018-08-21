using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Reservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["usuario"] = GV_Reserva.SelectedRow.Cells[1].Text;
        Session["mesa"] = GV_Reserva.SelectedRow.Cells[2].Text;
        Session["dia"] = GV_Reserva.SelectedRow.Cells[3].Text;

        String nombre = Session["usuario"].ToString();
        String mesa = Session["mesa"].ToString();
    }

    protected void BT_Platos_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuReserva.aspx");
    }
}