using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_pago : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"]==null)
        {
            Response.Redirect("Inicio.aspx");
        }
    }

    protected void BT_Pagar_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        DAOUsuario user = new DAOUsuario();
        EReservas datos = new EReservas();


        datos.Id_usuario = int.Parse(Session["user_id"].ToString());
        System.Data.DataTable validez1 = user.obtenerReserva(datos.Id_usuario);
        datos.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());
        datos.Id_usuario = int.Parse(validez1.Rows[0]["id_usuario"].ToString());
        user.actualizarReserva(datos);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Pago Realizado con Exito');window.location=\"Inicio.aspx\"</script>");

        Session["user_id"] = null;

    }
}