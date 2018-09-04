using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ListaVentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("Loggin.aspx");
        }
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        GridView1.DataSource = dato.obtenerplatopedido();
        GridView1.DataBind();

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
        datos.Nombre = nombre;
        System.Data.DataTable validez = dato.validarBusarpp(datos.Nombre);
        if (int.Parse(validez.Rows[0]["id_pedido"].ToString()) > 0)
        {
            GridView1.DataSource = dato.buscarPedidoplato(TB_Filtro.Text.ToString());
            GridView1.DataBind();
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Pedido no Existe');window.location=\"ListaVentas.aspx\"</script>");
        }
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }
}