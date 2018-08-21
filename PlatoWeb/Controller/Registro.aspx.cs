using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_Crear_Click(object sender, EventArgs e)
    {
        EUser datos = new EUser();
        DAOUsuario user = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;

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


        System.Data.DataTable validez = user.validarRegistro(datos.User_Name1,datos.Email);
        if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
        {
            user.InsertarUsuario(datos);
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario Creado Correctamente');</script>");
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Usuario Creado Correctamente');window.location=\"Loggin.aspx\"</script>");

        }
        else
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Usuario o Correo ya existente');</script>");
        }


    }
}