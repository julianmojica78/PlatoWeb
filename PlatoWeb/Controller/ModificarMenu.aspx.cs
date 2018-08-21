using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class View_ModificarMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            ECrear datos = new ECrear();
            DAOUsuario user = new DAOUsuario();
            ClientScriptManager cm = this.ClientScript;
            TB_nompla.Text = Session["nombre"].ToString();
            TB_desc.Text = Session["descripcion"].ToString();
            TB_precio.Text = Session["precio"].ToString();
         //   TB_imagen.Text = Session["imagen"].ToString();
        }
    }
        protected void B_Modificar_Click(object sender, EventArgs e)
        {
        ECrear datos = new ECrear();
        DAOUsuario dato = new DAOUsuario();
        ClientScriptManager cm = this.ClientScript;
        String nombre = Session["nombre"].ToString();
        System.Data.DataTable validez1 = dato.obtenerIdm(nombre);
        Int32 Id_plato = int.Parse(validez1.Rows[0]["id_plato"].ToString());


        datos.Id_plato = Id_plato;
        datos.Nomplato = TB_nompla.Text.ToString();
        datos.Descripcion = TB_desc.Text.ToString();
        datos.Precio = TB_precio.Text.ToString();
        //datos.Imagen = TB_imagen.Text.ToString();
        datos.Imagen = cargarImagen();

        if (datos.Imagen != null)
        {
            dato.modificarMenu(datos);
        }
    }

    protected String cargarImagen()
    {
        ClientScriptManager cm = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileName(FU_imagen.PostedFile.FileName);
        String extension = System.IO.Path.GetExtension(FU_imagen.PostedFile.FileName);
        String saveLocation = "";
        
        if (!(string.Compare(extension, ".jpg", true) == 0 || string.Compare(extension, ".jpeg", true) == 0 || string.Compare(extension, ".gif", true) == 0 || string.Compare(extension, ".jpe", true) == 0))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>");
            return null;
        }

        saveLocation = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;


        if (System.IO.File.Exists(saveLocation))
        {
            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>");
            return null;
        }

        //String Fu_imagen = Path.GetFileName()

        FU_imagen.PostedFile.SaveAs(saveLocation);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Modificado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");

        return "~\\Imagen" + "\\" + nombreArchivo;
    }


    protected void TB_codigo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TB_imagen_TextChanged(object sender, EventArgs e)
    {
        
    }
}
