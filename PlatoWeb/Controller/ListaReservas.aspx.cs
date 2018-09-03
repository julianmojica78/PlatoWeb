using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;
using System.Data;

public partial class View_ListaReservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["user_id"] == null)
        //{
        //    Response.Redirect("Loggin.aspx");
        //}
        LUser dato = new LUser(); ;
        GridView2.DataSource = dato.ListaReservas();
        GridView2.DataBind();
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

        GridView2.DataSource = usuario;
        GridView2.DataBind();

        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }
}