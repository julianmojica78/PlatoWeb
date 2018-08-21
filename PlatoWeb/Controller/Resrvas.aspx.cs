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

public partial class View_Resrvas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["nombre"] == null)
        {
            BT_MReservas.Visible = false;
        }
        else
        {
            BT_MReservas.Visible = true;
        }
    }

    protected void DDL_Cantp_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void obtenerUser()
    {
    }
    private string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        EReservas datos = new EReservas();
        DAOUsuario user = new DAOUsuario();
        if (Session["nombre"] != null)
        {
            Int32 id_usuario = int.Parse(Session["user_id"].ToString());
            datos.Dia = TB_Fecha.Text.ToString() + ' ' + int.Parse(DDL_Hora.SelectedItem.ToString()) + ":00";
            datos.Cant = int.Parse(DDL_Cantp.SelectedValue.ToString());
            datos.Id_usuario = id_usuario;
            user.InsertReserva(datos);
            System.Data.DataTable validez1 = user.obtenerReserva(datos.Id_usuario);
            datos.Id_reserva = int.Parse(validez1.Rows[0]["id_reserva"].ToString());

            System.Data.DataTable validez = user.generarTokenReserva(datos.Id_reserva);
            if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
            {
                EUserToken token = new EUserToken();
                token.Id = int.Parse(validez.Rows[0]["id_reserva"].ToString());
                token.Id_usuario = int.Parse(validez.Rows[0]["id_usuario"].ToString());
                token.Id_Mesa = int.Parse(validez.Rows[0]["id_mesa"].ToString());
                token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());
                token.Correo = validez.Rows[0]["email"].ToString();
                token.Fecha = DateTime.Now.ToFileTimeUtc();

                String userToken = encriptar(JsonConvert.SerializeObject(token));
                user.almacenarTokenReserva(userToken, token.Id);

                CorreoR correo = new CorreoR();

                String mensaje = "su link de acceso es: " + "http://localhost:52368/View/pago.aspx?" + userToken;
                correo.enviarCorreo(token.Correo, userToken, mensaje);

                //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Para Confirmar su reseva por favor pague el valor de la reserva');</script>");
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Para Confirmar su reseva,por favor pague el valor de la reserva');window.location=\"Resrvas.aspx\"</script>");

            }
            else if (int.Parse(validez.Rows[0]["id"].ToString()) == -2)
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya extsite un token, por favor verifique su correo.');</script>");

            }
            else
            {
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('La Reserva no existe');</script>");

            }

        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');window.location=\"Loggin.aspx\"</script>");

            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('No puede reservas si no esta Logueado');</script>");
            ////Response.Redirect("Loggin.aspx");

        }

    
    }


    protected void BT_MReservas_Click(object sender, EventArgs e)
    {
        Response.Redirect("CanjePuntos.aspx");
 
            }
}
