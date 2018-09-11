using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_Despachos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
       
   
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
    }

        protected void GV_Pedidos_ShowDeleteButton(object sender, EventArgs e)
    {
        
    }



    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UDespachos datos = new UDespachos();
        LUser user = new LUser();

        Session["pedido"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["reserva"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["plato"]= GridView1.SelectedRow.Cells[1].Text;
        Int32 id_pedido = int.Parse(Session["pedido"].ToString());
        //Int32 id_plato = int.Parse(Session["plato"].ToString());
        DateTime fecha_despacho = DateTime.Now;

       datos = user.despachos(id_pedido,fecha_despacho);
        Response.Redirect(datos.Url);


    }
    protected void GridView2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UDespachos datos = new UDespachos();
        LUser user = new LUser();

        Session["pedido"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["reserva"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["plato"]= GridView1.SelectedRow.Cells[1].Text;
        Int32 id_pedido = int.Parse(Session["pedido"].ToString());
        //Int32 id_plato = int.Parse(Session["plato"].ToString());
        DateTime fecha_despacho = DateTime.Now;

        datos = user.despachos(id_pedido, fecha_despacho);
        Response.Redirect(datos.Url);


    }

    protected void GridView3_SelectedIndexChanged(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UDespachos datos = new UDespachos();
        LUser user = new LUser();

        Session["pedido"] = GridView3.SelectedRow.Cells[0].Text;
        //Session["reserva"] = GridView1.SelectedRow.Cells[0].Text;
        //Session["plato"]= GridView1.SelectedRow.Cells[1].Text;
        Int32 id_pedido = int.Parse(Session["pedido"].ToString());
        //Int32 id_plato = int.Parse(Session["plato"].ToString());
        DateTime fecha_despacho = DateTime.Now;

        datos = user.despachos1(id_pedido, fecha_despacho);
        Response.Redirect(datos.Url);
    }


}
