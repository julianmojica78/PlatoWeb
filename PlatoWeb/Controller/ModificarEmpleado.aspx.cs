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

       if (!IsPostBack){

            UUser datos = new UUser();
            LUser user = new LUser();
            ClientScriptManager cm = this.ClientScript;

            TB_Nombre.Text = Session["nombre"].ToString();
            TB_Apellido.Text = Session["apellido"].ToString();
            TB_Email.Text = Session["email"].ToString();
            TB_Celular.Text = Session["telefono"].ToString();
            TB_Cedula.Text = Session["cedula"].ToString();
            string rol = Session["rol"].ToString();
            datos = user.rol(rol);
            DDL_Rol.SelectedValue = (datos.Url);
            //if (Session["rol"].ToString() == "Cocinero")
            //{
            //    DDL_Rol.SelectedValue = "2";
            //}
            //else
            //{
            //    DDL_Rol.SelectedValue = "3";
            //}

            TB_Usuario.Text = Session["usuario"].ToString();
            TB_Contrasena.Text = Session["clave"].ToString();
            TB_CConrasena.Text = Session["clave"].ToString();
        }
        //try
        //{

        //}
        //catch(PostBackOptions )
        //{

        //}
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