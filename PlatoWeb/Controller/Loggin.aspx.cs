using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;


public partial class View_Loggin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LB_Recuperar_Click(object sender, EventArgs e)
    {
        Response.Redirect("Generar_Token.aspx");
    }

    protected void B_Registrarse_Click(object sender, EventArgs e)
    {
        Response.Redirect("Registro.aspx");
    }

    protected void Button8_Click(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();

        datos.User_name = UserName.Text.ToString();
        datos.Clave = Password.Text.ToString();
        datos.Session = Session.SessionID;
        
       
        datos = user.logear(datos);
        Session["nombre"] = (datos.User_name);
        Session["user_id"] = (datos.UserId);
        Response.Redirect(datos.Url);
        ////DataTable registros = .Login(usuario);
    }
}