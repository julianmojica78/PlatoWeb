using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_CrearMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {
        ECrear datos = new ECrear();
        DAOUsuario ins = new DAOUsuario();

        datos.Nomplato = TB_nompla.Text.ToString();
        datos.Descripcion = TB_desc.Text.ToString();
        datos.Precio = TB_precio.Text.ToString();
        datos.Imagen = cargarImagen();

        if (datos.Imagen != null)
        {
            ins.insertarMenu(datos);
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

        FU_imagen.PostedFile.SaveAs(saveLocation);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Plato Creado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");

        return "~\\Imagen" + "\\" + nombreArchivo;
    }

}