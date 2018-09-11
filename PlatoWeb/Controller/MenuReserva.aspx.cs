using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Utilitarios;
using Logica;

public partial class View_MenuReserva : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }

    protected void DataList1_SelectedIndexChanged(object sender, DataListCommandEventArgs e)
    {
        UuserReservas pla = new UuserReservas();
        LUser inse = new LUser();

        //DataTable registro = inse.Insertarpreserva();


        int res = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());

    }

    protected void B_volver_Click(object sender, EventArgs e)
    {

        Response.Redirect("Resrvas.aspx");
    }

    protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserReservas dato = new UuserReservas();
        LUser doc = new LUser();
        ClientScriptManager cm = this.ClientScript;
        string nombre = Session["usuario"].ToString();
        System.Data.DataTable validez1 = doc.obteberidres(nombre);
        Int32 id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        TextBox guardar = (TextBox)item.FindControl("TB_insertarPedido");
        dato.Cant = int.Parse(guardar.Text);
        Label lblid = (Label)item.FindControl("Label1");
        dato.Id_plato = int.Parse(lblid.Text);
        dato.Id_reserva = id_reserva;

        doc.insertarplares(dato);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Pedido insertado con exito');</script>");

    }
}