using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Data;

public partial class View_ListaVentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        LUser dato = new LUser();
        GridView1.DataSource = dato.ListaVentas();
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
        usuario = dato.BuscarVentas(datos);

        GridView1.DataSource = usuario;
        GridView1.DataBind();

        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}