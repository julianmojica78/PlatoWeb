using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ModificarEmpleado : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        if (!IsPostBack){

            EUser datos = new EUser();
            DAOUsuario user = new DAOUsuario();
            ClientScriptManager cm = this.ClientScript;
            
            TB_Nombre.Text = Session["nombre"].ToString();
            TB_Apellido.Text = Session["apellido"].ToString();
            TB_Email.Text = Session["email"].ToString();
            TB_Celular.Text = Session["telefono"].ToString();
            TB_Cedula.Text = Session["cedula"].ToString();
            if (Session["rol"].ToString() == "Cocinero")
            {
                DDL_Rol.SelectedValue = "2";
            }
            else
            {
                DDL_Rol.SelectedValue = "3";
            }

            TB_Usuario.Text = Session["usuario"].ToString();
            TB_Contrasena.Text = Session["clave"].ToString();
            TB_CConrasena.Text = Session["clave"].ToString();


        }
    }



    protected void B_Crear_Click(object sender, EventArgs e)
    {

        EUser datos = new EUser();
        DAOUsuario user = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        System.Data.DataTable validez1 = user.obtenerId(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_usuario"].ToString());

        datos.Nombre = TB_Nombre.Text.ToString();
        datos.Apellido = TB_Apellido.Text.ToString();
        datos.Email = TB_Email.Text.ToString();
        datos.Telefono = TB_Celular.Text.ToString();
        datos.Cedula = TB_Cedula.Text.ToString();
        datos.Id_Rol = int.Parse(DDL_Rol.SelectedValue.ToString());
        datos.User_Name1 = TB_Usuario.Text.ToString();
        datos.Clave = TB_Contrasena.Text.ToString();
        datos.Rclave = TB_CConrasena.Text.ToString();
        datos.User_id = User_id;
        //datos.User_id = int.Parse(Session["codigo"].ToString());
        user.modificarEmpleado(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Modificado Correctamente');window.location=\"ListaEmpleados.aspx\"</script>");

    }
}