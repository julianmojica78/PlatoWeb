using System;
using System.Web;
using Logica;
using Utilitarios;
using System.Data;
public partial class View_ListaComentarios : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        Luser dato = new Luser();
        Uuser datos = new Uuser();
        GV_Listar.DataSource = dato.listadoComentario();
        GV_Listar.DataBind();
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
    }

    protected void TB_Filtrar_TextChanged(object sender, EventArgs e)
    {
        Luser dato = new Luser();
        Uuser datos = new Uuser();
        String nombre = TB_Filtrar.Text.ToString();
        datos.Nombre = nombre;
        DataTable validez = dato.buscarcomen(datos.Nombre);

            datos.X = int.Parse(validez.Rows[0]["id_comentarios"].ToString());        
            GV_Listar.DataSource = dato.buscarUser(TB_Filtrar.Text.ToString());
            GV_Listar.DataBind();
        
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}