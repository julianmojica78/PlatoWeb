using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_MenuMesero : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DataList1_SelectedIndexChanged(object sender, DataListCommandEventArgs e)
    {
        UuserPedido dato = new UuserPedido();
        Luser ins = new Luser();

        ins.obtenerPlato();        
        int res = Convert.ToInt32(DataList1.DataKeys[e.Item.ItemIndex].ToString());

    }
    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserPedido dato = new UuserPedido();
        ClientScriptManager cm = this.ClientScript;
        Luser doc = new Luser();
        dato.Id_usuario = int.Parse(Session["user_id"].ToString());
        DataTable validez1 = doc.obtenerpe(dato.Id_usuario);
        dato.Id_pedido = int.Parse(validez1.Rows[0]["id_pedido"].ToString());
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        TextBox guardar = (TextBox)item.FindControl("TB_insertarPedido");
        dato.Cantidad = int.Parse(guardar.Text);
        Label lblid = (Label)item.FindControl("Label1");
        dato.Id_plato = int.Parse(lblid.Text);

        doc.guardarPedido(dato);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Pedido insertado con exito');</script>");


    }

    protected void DataList1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}