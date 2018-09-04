using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Contactenos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BT_Enviar_Click1(object sender, EventArgs e)
    {
        EContacto contacto = new EContacto();
        DAOUsuario dato = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;
        contacto.Nombre = TB_Nombre.Text.ToString();
        contacto.Email = TB_Email.Text.ToString();
        contacto.Detalle = TB_Detalle.Text.ToString();
        contacto.Telefono = TB_Telefono.Text.ToString();
        dato.insertarContacto(contacto);

        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Mensaje Enviado Correctamente');window.location=\"Contactenos.aspx\"</script>");

    }
}