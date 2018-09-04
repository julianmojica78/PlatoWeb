using System;
using System.Web.UI;
using System.Data;
using Utilitarios;
using Logica;

public partial class View_ListadePlatos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool x = Session["user_id"] == null;

        Luser dato = new Luser();
        Uuser datos = new Uuser();
        GV_Platos.DataSource = dato.listarmenu();
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
        UuserCrear datos = new UuserCrear();
        Luser dato = new Luser();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        DataTable validez1 = dato.obtenerMesa(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_plato"].ToString());
        datos.Id_plato = User_id;
        dato.eliminarPlato(datos);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Eliminado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
        Luser dato = new Luser();
        Uuser datos = new Uuser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = TB_Filtro.Text.ToString();
       // datos.Nombre = nombre;
        DataTable validez = dato.validarbuscarM(nombre);

        datos.X = int.Parse(validez.Rows[0]["id_plato"].ToString());
        GV_Platos.DataSource = dato.buscarPla((TB_Filtro.Text.ToString()));
        GV_Platos.DataBind();

    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
    }
}