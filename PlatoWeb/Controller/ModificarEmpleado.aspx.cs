using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ModificarEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


            UUsuario datos = new UUsuario();
            LUser user = new LUser();
            ClientScriptManager cm = this.ClientScript;
            string nombre = Session["nombre"].ToString();
            datos = user.ObtenerIds(nombre);
            if (!IsPostBack) {
            TB_Nombre.Text = (datos.Nombre);
            TB_Apellido.Text = (datos.Apellido);
            TB_Email.Text = (datos.Email);
            TB_Celular.Text = (datos.Telefono);
            TB_Cedula.Text = (datos.Cedula);
            TB_Usuario.Text = (datos.User_Name1);
            TB_Contrasena.Text = (datos.Clave);
            TB_CConrasena.Text = (datos.Rclave);
            Int32 rol = (datos.Id_Rol);
            datos = user.rol(rol);
            DDL_Rol.SelectedValue = (datos.Url);
             }
    }



    protected void B_Crear_Click(object sender, EventArgs e)
    {

        UUsuario datos = new UUsuario();
        LUser user = new LUser();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        datos = user.ObtenerId(nombre);

        datos.Nombre = TB_Nombre.Text.ToString();
        datos.Apellido = TB_Apellido.Text.ToString();
        datos.Email = TB_Email.Text.ToString();
        datos.Telefono = TB_Celular.Text.ToString();
        datos.Cedula = TB_Cedula.Text.ToString();
        datos.Id_Rol = int.Parse(DDL_Rol.SelectedValue.ToString());
        datos.User_Name1 = TB_Usuario.Text.ToString();
        datos.Clave = TB_Contrasena.Text.ToString();
        datos.Rclave = TB_CConrasena.Text.ToString();
        datos.User_id = (datos.User_id);
        //datos.User_id = int.Parse(Session["codigo"].ToString());

        datos = user.ModificarEmpleado(datos);
        this.RegisterStartupScript("mensaje",datos.Mensaje);

    }



    protected void TB_Email_TextChanged(object sender, EventArgs e)
    {

    }
}