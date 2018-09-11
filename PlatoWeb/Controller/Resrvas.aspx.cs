using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_Resrvas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Estado est = new Estado();
        UUser datos = new UUser();
        LUser user = new LUser();

        try
        {
            datos.User_name = Session["nombre"].ToString();
            est = user.estado(datos);
            BT_MReservas.Visible = est.Esstado;

        }
        catch
        {
            est = user.estado(datos);
            BT_MReservas.Visible = est.Esstado;

        }
        //if (Session["nombre"] == null)
        //{
        //    BT_MReservas.Visible = false;
        //}
        //else
        //{
        //    BT_MReservas.Visible = true;
        //}
    }

    protected void DDL_Cantp_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void obtenerUser()
    {
    }
   

    protected void Button8_Click(object sender, EventArgs e)
    {
        UReserva datos = new UReserva();
        LUser user = new LUser();


        
        datos.Dia = TB_Fecha.Text.ToString() + ' ' + int.Parse(DDL_Hora.SelectedItem.ToString()) + ":00";
        datos.Cant = int.Parse(DDL_Cantp.SelectedValue.ToString());
        try
        {
            datos.Id_usuario = int.Parse(Session["user_id"].ToString());
            datos.Nombre = Session["nombre"].ToString(); ;

            datos = user.Reserva(datos);
            this.RegisterStartupScript("mensaje", datos.Mensaje);
        }
        catch
        {
            datos = user.Reserva(datos);
            this.RegisterStartupScript("mensaje", datos.Mensaje);
        }


    }     


    protected void BT_MReservas_Click(object sender, EventArgs e)
    {
        Response.Redirect("CanjePuntos.aspx");
 
            }
}
