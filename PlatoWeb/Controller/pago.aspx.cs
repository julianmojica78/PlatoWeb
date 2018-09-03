using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

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
        LUser user = new LUser();
        UReserva datos = new UReserva();


        datos.Id_usuario = int.Parse(Session["user_id"].ToString());
        datos = user.pago(datos);

        this.RegisterStartupScript("mensaje",datos.Mensaje);

        Session["user_id"] = null;

    }
}