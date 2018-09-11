using System;

using System.Web;
using System.Web.UI;

using Utilitarios;
using Logica;
using System.Linq;

public partial class View_CrearMenu : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
    }

    protected void B_guardar_Click(object sender, EventArgs e)
    {
        UuserCrear datos = new UuserCrear();
        LMenu ins = new LMenu();
        UUser info = new UUser();
        datos.Nomplato = TB_nompla.Text.ToString();
        datos.Descripcion = TB_desc.Text.ToString();
        datos.Precio = TB_precio.Text.ToString();
        info.Ruta = (FU_imagen.PostedFile.FileName);
        datos.Imagen = cargarImagen();

        ins.insertmenu(datos);

    }

    protected String cargarImagen()
    {
        UUser enca = new UUser();
        LMenu user = new LMenu();
        ClientScriptManager cm = this.ClientScript;
        String nombreArchivo = System.IO.Path.GetFileName(FU_imagen.PostedFile.FileName);
        enca.A = System.IO.Path.GetExtension(FU_imagen.PostedFile.FileName);



        UUser mensaje = new UUser();
        try
        {

            enca.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;
            mensaje = user.CargaImagen(enca);
            //cm.RegisterClientScriptBlock(this.GetType(), "", mensaje.Url);

            enca.Ubicacion = mensaje.Ubicacion;

            FU_imagen.PostedFile.SaveAs(enca.Ubicacion);
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Plato Creado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");


        }
        catch
        {
            enca.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;
            //mensaje = user.cargaImage();
            //enca.Ubicacion = mensaje.B;
            nombreArchivo = mensaje.Ubicacion;
            cm.RegisterClientScriptBlock(this.GetType(), "", mensaje.Url);

        }

        return "~\\Imagen" + "\\" + nombreArchivo;
    }
}