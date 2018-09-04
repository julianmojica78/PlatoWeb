using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Crear_Click(object sender, EventArgs e)
    {
        ClientScriptManager cm = this.ClientScript;
        UUsuario datos = new UUsuario();
        LUser user = new LUser();
        UUser mensaje = new UUser();

        datos.Nombre = TB_Nombre.Text.ToString();
        datos.Apellido = TB_Apellido.Text.ToString();
        datos.Email = TB_Email.Text.ToString();
        datos.Telefono = TB_Celular.Text.ToString();
        datos.Cedula = TB_Cedula.Text.ToString();
        datos.Puntos = 0;
        datos.Id_Rol = 4;
        datos.User_Name1 = TB_Usuario.Text.ToString();
        datos.Clave = TB_Contrasena.Text.ToString();
        datos.Rclave = TB_CConrasena.Text.ToString();
        datos.Session = "a";


        datos = user.Registro(datos);
        this.RegisterStartupScript("mensaje",datos.Mensaje);

        //Response.Redirect(datos.Url);





    }
}