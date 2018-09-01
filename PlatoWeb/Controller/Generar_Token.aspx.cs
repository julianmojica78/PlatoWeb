using Newtonsoft.Json;
using System;
using System.Data;
using Utilitarios;
using System.Text;
using Data;
using Logica;




public partial class View_Generar_Token : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Aceptar_Click(object sender, EventArgs e)
    {
        Luser Lau = new Luser();
        UuserToken user = new UuserToken();

       user = Lau.GenerarToken(TB_generar_token.Text);
       L_Mensaje.Text = (user.Mensaje);

       this.RegisterStartupScript("mensaje",user.Url);


    }
}