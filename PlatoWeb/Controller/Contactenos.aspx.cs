using System;
using System.Web.UI;
using Utilitarios;
using Logica;

public partial class View_Contactenos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BT_Enviar_Click1(object sender, EventArgs e)
    {
        Uuser dato = new Uuser();
        Luser contacto = new Luser();
        ClientScriptManager cm = this.ClientScript;
        dato = contacto.contactenos(TB_Nombre.Text, TB_Telefono.Text, TB_Email.Text, TB_Detalle.Text);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mensaje Enviado Correctamente');window.location=\"Inicio.aspx\"</script>");

    }
}