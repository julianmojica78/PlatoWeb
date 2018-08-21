using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ListaEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user_id"] == null)
        {
            Response.Redirect("Loggin.aspx");
        }

        if (!IsPostBack)
        {
            DAOUsuario dato = new DAOUsuario();
            EUser datos = new EUser();
            GV_Empleados.DataSource = dato.obtenerEmpleado();
            GV_Empleados.DataBind();
        }
    }

     protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroEmpleados.aspx");
    }

    protected void GV_Empleados_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["codigo"] = GV_Empleados.SelectedRow.Cells[1].Text;
        Session["nombre"] = GV_Empleados.SelectedRow.Cells[2].Text;
        Session["apellido"] = GV_Empleados.SelectedRow.Cells[3].Text;
        Session["email"] = GV_Empleados.SelectedRow.Cells[4].Text;
        Session["telefono"] = GV_Empleados.SelectedRow.Cells[5].Text;
        Session["cedula"] = GV_Empleados.SelectedRow.Cells[6].Text;
        Session["usuario"] = GV_Empleados.SelectedRow.Cells[7].Text;
        Session["rol"] = GV_Empleados.SelectedRow.Cells[8].Text;
        Session["clave"] = GV_Empleados.SelectedRow.Cells[9].Text;


   }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarEmpleado.aspx");
    }

    

    protected void BT_Eliminar_Click1(object sender, EventArgs e)
    {
        EUser datos = new EUser();
        DAOUsuario user = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        System.Data.DataTable validez1 = user.obtenerId(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_usuario"].ToString());

        datos.User_id = User_id;

        user.eliminarEmpleado(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Eliminado Correctamente');window.location=\"ListaEmpleados.aspx\"</script>");


    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
        //DAOUsuario dato = new DAOUsuario();
        //DataTable datos = dato.buscarEmpleados(TB_Filtro.Text.ToString());


        //GV_Resultado.DataSource = datos;
        //GV_Resultado.DataBind();

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
        datos.Nombre = nombre;
        System.Data.DataTable validez = dato.validarBusare(datos.Nombre);
        if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
        {
            GV_Empleados.DataSource = dato.buscarEmpleados(TB_Filtro.Text.ToString());
            GV_Empleados.DataBind();
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");
        }

    }

    protected void GV_Resultado_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}