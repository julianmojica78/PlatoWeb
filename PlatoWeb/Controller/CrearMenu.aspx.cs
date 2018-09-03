using System;
using System.Web.UI;
using Utilitarios;
using Logica;

public partial class View_CrearMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserCrear datos = new UuserCrear();
        Luser ins = new Luser();

        datos.Nomplato = TB_nompla.Text.ToString();
        datos.Descripcion = TB_desc.Text.ToString();
        datos.Precio = TB_precio.Text.ToString();
        datos.Imagen = cargarImagen();

        ins.insertmenu(datos); /*aca llamo la funcion de logica*/
    }

    protected String cargarImagen()
    {
        Luser datos = new Luser();
        Uuser info = new Uuser();
        
        ClientScriptManager cm = this.ClientScript;
        info.Nombre = (FU_imagen.PostedFile.FileName);
        info.Ruta = (FU_imagen.PostedFile.FileName);
        //String nombreArchivo = System.IO.Path.GetFileName(FU_imagen.PostedFile.FileName);
        //String extension = System.IO.Path.GetExtension(FU_imagen.PostedFile.FileName);
        //String saveLocation = "";
        datos.cargaImage(info);
        //if (!(string.Compare(extension, ".jpg", true) == 0 || string.Compare(extension, ".jpeg", true) == 0 || string.Compare(extension, ".gif", true) == 0 || string.Compare(extension, ".jpe", true) == 0))
        //{
        //    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>");
        //    return null;
        //}

        info.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + info.Nombre;


        //if (System.IO.File.Exists(saveLocation))
        //{
        //    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>");
        //    return null;
        //}

        FU_imagen.PostedFile.SaveAs(info.Ubicacion);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Plato Creado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");

        return "~\\Imagen" + "\\" + info.Nombre;
    }


}