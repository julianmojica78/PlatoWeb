using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ListaComentarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        LUser dato = new LUser();
        GV_Listar.DataSource = dato.ListaComentarios();
        GV_Listar.DataBind();
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
        //DAOUsuario dato = new DAOUsuario();
        //DataTable datos = dato.buscarUsuario(TB_Filtrar.Text.ToString());
        //GV_Listar.DataSource = datos;
        //GV_Listar.DataBind();
    }

    protected void TB_Filtrar_TextChanged(object sender, EventArgs e)
    {
                   LUser dato = new LUser();
            UUsuario datos = new UUsuario();
            ClientScriptManager cm = this.ClientScript;
            DataTable usuario;

            datos.Nombre = TB_Filtrar.Text.ToString();
            //datos = dato.BuscarEmpleado(datos);
            usuario = dato.BuscarEmpleado(datos);

            GV_Listar.DataSource = usuario;
            GV_Listar.DataBind();
        
            //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");

        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}