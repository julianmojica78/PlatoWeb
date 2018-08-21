using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ListaComentarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        GV_Listar.DataSource = dato.obtenerComentarios();
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
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        String nombre = TB_Filtrar.Text.ToString();
        datos.Nombre = nombre;
        System.Data.DataTable validez = dato.validarBuscarco(datos.Nombre);
        if (int.Parse(validez.Rows[0]["id_comentarios"].ToString()) > 0)
        {
            GV_Listar.DataSource = dato.buscarUsuario(TB_Filtrar.Text.ToString());
            GV_Listar.DataBind();
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Comentario no Existe');window.location=\"ListaComentarios.aspx\"</script>");
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}