using System;
using System.Data;
using System.Web;
using Logica;
using Utilitarios;


public partial class View_menuPrincipal : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Uuser dato = new Uuser();
        Luser menu = new Luser();
        //DataTable data = menu.listarmenu();  
        //GridView1.DataSource = menu.listarmenu();
        ///GridView1.DataBind();
        //if (!IsPostBack)
        //{

        //    Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        //    Response.Cache.SetAllowResponseInBrowserHistory(false);
        //    Response.Cache.SetNoStore();
        //}
    }
}