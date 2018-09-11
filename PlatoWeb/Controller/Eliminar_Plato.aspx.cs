using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Eliminar_Plato : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //EUser datos = new EUser();
            //DAOUsuario user = new DAOUsuario();
            //ClientScriptManager cm = this.ClientScript;
            //TB_codigo.Text = Session["id_plato"].ToString();
            //TB_nompla.Text = Session["nombre"].ToString();
            //TB_desc.Text = Session["descripcion"].ToString();
            //TB_precio.Text = Session["precio"].ToString();
            //TB_imagen.Text = Session["imagen"].ToString();
        }
    }


    protected void B_eliminar_Click(object sender, EventArgs e)
    {
        {
            //ECrear datos = new ECrear();
            //DAOUsuario dato = new DAOUsuario();
            //ClientScriptManager cm = this.ClientScript;

            //datos.Id_plato = int.Parse(Session["id_plato"].ToString());
            //datos.Nomplato = TB_nompla.Text.ToString();
            //datos.Descripcion = TB_desc.Text.ToString();
            //datos.Precio = TB_precio.Text.ToString();
            //datos.Imagen = TB_imagen.Text.ToString();

            //dato.EliminarPlato(datos);
            //cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('El resgistro ha sido eliminado');</script>");
            //Response.Redirect("EliminarPlato.aspx");
        }
    }
}