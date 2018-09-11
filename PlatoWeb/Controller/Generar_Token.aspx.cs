using System;
using Utilitarios;
using Logica;




public partial class View_Generar_Token : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Aceptar_Click(object sender, EventArgs e)
    {
        LUser Lau = new LUser();
        UUserToken user = new UUserToken();

        user = Lau.GenerarToken(TB_generar_token.Text);
        L_Mensaje.Text = (user.Mensaje);

        this.RegisterStartupScript("mensaje", user.Url);


    }
}