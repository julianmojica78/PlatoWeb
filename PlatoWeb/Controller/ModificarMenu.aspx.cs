using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Data;

public partial class View_ModificarMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UuserCrear datos = new UuserCrear();
        datos.Ispos = IsPostBack;
        Luser user = new Luser();
        user.ispost1(datos);
        {

            
            
            ClientScriptManager cm = this.ClientScript;

            datos.A = TB_nompla.Text;
            datos.B = Session["nombre"].ToString();
            datos.C = TB_desc.Text;
            datos.D = Session["descripcion"].ToString();
            datos.E = TB_precio.Text;
            datos.F = Session["precio"].ToString();

            //TB_nompla.Text = Session["nombre"].ToString();
            //TB_desc.Text = Session["descripcion"].ToString();
            //TB_precio.Text = Session["precio"].ToString();

        }
    }
        protected void B_Modificar_Click(object sender, EventArgs e)
        {
        UuserCrear datos = new UuserCrear();
        Luser dato = new Luser();
        ClientScriptManager cm = this.ClientScript;
        String nombre = Session["nombre"].ToString();
        DataTable validez1 = dato.obtenerMesa(nombre);
        Int32 Id_plato = int.Parse(validez1.Rows[0]["id_plato"].ToString());
        datos.Id_plato = Id_plato;
        datos.Nomplato = TB_nompla.Text.ToString();
        datos.Descripcion = TB_desc.Text.ToString();
        datos.Precio = TB_precio.Text.ToString();
        datos.Imagen = cargarImagen();
        dato.modifimenu(datos); 
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
