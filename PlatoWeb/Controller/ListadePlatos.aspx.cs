using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ListadePlatos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if (Session["user_id"] == null)
        //{
        //    Response.Redirect("Loggin.aspx");
        //}

        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        GV_Platos.DataSource = dato.obtenerPlato();
        GV_Platos.DataBind();
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {
        Session["id_plato"] = GV_Platos.SelectedRow.Cells[1].Text;
        Session["nombre"] = GV_Platos.SelectedRow.Cells[2].Text;
        Session["descripcion"] = GV_Platos.SelectedRow.Cells[3].Text;
        Session["precio"] = GV_Platos.SelectedRow.Cells[4].Text;
        Session["imagen"] = GV_Platos.SelectedRow.Cells[5].Text;
    }

    protected void B_modificar_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarMenu.aspx");
    }

    protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("CrearMenu.aspx");
    }

    protected void BT_Eliminar_Click(object sender, EventArgs e)
    {
        ECrear datos = new ECrear();
        DAOUsuario dato = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        System.Data.DataTable validez1 = dato.obtenerIdm(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_plato"].ToString());

        datos.Id_plato= User_id;

        dato.EliminarPlato(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Eliminado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        DAOUsuario dato = new DAOUsuario();
        EUser datos = new EUser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
        datos.Nombre = nombre;
        System.Data.DataTable validez = dato.validarBuscarm(datos.Nombre);
        if (int.Parse(validez.Rows[0]["id_plato"].ToString()) > 0)
        {
            GV_Platos.DataSource = dato.buscarPlato(TB_Filtro.Text.ToString());
            GV_Platos.DataBind();
        }
        else
        {
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Plato no Existe');window.location=\"ListadePlatos.aspx\"</script>");
        }

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
        //DAOUsuario dato = new DAOUsuario();
        //DataTable datos = dato.buscarEmpleados(TB_Filtro.Text.ToString());


        //GV_Resultado.DataSource = datos;
        //GV_Resultado.DataBind();

    }
}