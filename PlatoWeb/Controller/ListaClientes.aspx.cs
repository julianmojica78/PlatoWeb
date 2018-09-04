using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ListaClientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        LUser dato = new LUser();

        GridView1.DataSource = dato.ListaClientes();
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
        LUser dato = new LUser();
        UUsuario datos = new UUsuario();
        ClientScriptManager cm = this.ClientScript;
        DataTable usuario;

        datos.Nombre = TB_Filtro.Text.ToString();
        //datos = dato.BuscarEmpleado(datos);
        usuario = dato.BuscarCliente(datos);

        GridView1.DataSource = usuario;
        GridView1.DataBind();

        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");


    }

}