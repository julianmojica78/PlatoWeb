using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Pedido : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void B_guardar_Click(object sender, EventArgs e)
    {
        EPedido dato = new EPedido();
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario doc = new DAOUsuario();

        dato.Id_usuario = int.Parse(Session["user_id"].ToString());
        System.Data.DataTable validez1 = doc.obtenerPedido(dato.Id_usuario);
        dato.Id_pedido = int.Parse(validez1.Rows[0]["id_pedido"].ToString());
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        TextBox guardar = (TextBox)item.FindControl("TB_insertarPedido");
        dato.Cantidad = int.Parse(guardar.Text);
        Label lblid = (Label)item.FindControl("Label1");
        dato.Id_plato = int.Parse(lblid.Text);

        doc.insertarPedido(dato);
        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Pedido insertado con exito');</script>");


    }

    protected void BT_Mesa_Click(object sender, EventArgs e)
    {
        EPedido dato = new EPedido();
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario doc = new DAOUsuario();
        dato.Id_mesa = int.Parse(DDL_Ubicacion.SelectedValue.ToString());
        dato.Id_mesero = int.Parse(Session["user_id"].ToString());
        doc.InsertPedido(dato);
    }
}