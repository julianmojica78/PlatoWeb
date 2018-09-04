using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ListaClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        GridView1.DataSource = dato.obteneruser();
        GridView1.DataBind();

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
        DAOUsuario dato = new DAOUsuario();
        DataTable datos = dato.buscarUsuario(TB_Filtro.Text.ToString());
        GridView1.DataSource = datos;
        GridView1.DataBind();
    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
        datos.Nombre = nombre;
        System.Data.DataTable validez = dato.validarBusare(datos.Nombre);
        if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
        {
            GridView1.DataSource = dato.buscarUsuario(TB_Filtro.Text.ToString());
            GridView1.DataBind();
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario no Existe');window.location=\"ListaClientes.aspx\"</script>");
        }
    }

}