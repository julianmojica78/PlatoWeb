using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ListaReservas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("Loggin.aspx");
        }
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        GridView2.DataSource = dato.obtenerReservaplato();
        GridView2.DataBind();
    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
        datos.Nombre = nombre;
        System.Data.DataTable validez = dato.validarBusarrp(datos.Nombre);
        if (int.Parse(validez.Rows[0]["id_reserva"].ToString()) > 0)
        {
            GridView2.DataSource = dato.buscarreservapla(TB_Filtro.Text.ToString());
            GridView2.DataBind();
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('reserva no Existe');window.location=\"ListaReservas.aspx\"</script>");
        }
    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {

    }
}