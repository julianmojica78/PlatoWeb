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
        Luser ins = new Luser();
        
        Uuser info = new Uuser();
        {

            
            
            ClientScriptManager cm = this.ClientScript;

            //datos.A = TB_nompla.Text;
            //datos.B = Session["nombre"].ToString();
            //datos.C = TB_desc.Text;
            //datos.D = Session["descripcion"].ToString();
            //datos.E = TB_precio.Text;
            //datos.F = Session["precio"].ToString();

            //TB_nompla.Text = Session["nombre"].ToString();
            //TB_desc.Text = Session["descripcion"].ToString();
            //TB_precio.Text = Session["precio"].ToString();
            

        }
    }
    protected void B_Modificar_Click(object sender, EventArgs e)
    {
        UuserCrear data = new UuserCrear();
        data.Ispos = IsPostBack;
        Luser user = new Luser();
        Luser ins = new Luser();
        user.ispost1(data);
        Uuser info = new Uuser();

        info.Ruta = (FU_imagen.PostedFile.FileName);
        data.Imagen = cargarImagen();
        data.Ispos = prueba(info);
        
        user.ispost1(data);
        String nombre = Session["nombre"].ToString();
        DataTable validez1 = user.obtenerMesa(nombre);
        Int32 User_id = int.Parse(validez1.Rows[0]["id_plato"].ToString());
        data.Id_plato = User_id;
        data.A = TB_nompla.Text;
        data.B = Session["nombre"].ToString();
        data.C = TB_desc.Text;
        data.D = Session["descripcion"].ToString();
        data.E = TB_precio.Text;
        data.F = Session["precio"].ToString();
        ins.aux1(data);
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
        info.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + info.Nombre;
        info = datos.cargaImage(info);
        info.Nombre = (FU_imagen.PostedFile.FileName);
        //if (!(string.Compare(extension, ".jpg", true) == 0 || string.Compare(extension, ".jpeg", true) == 0 || string.Compare(extension, ".gif", true) == 0 || string.Compare(extension, ".jpe", true) == 0))
        //{
        //    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>");
        //    return null;
        //}

        //if (System.IO.File.Exists(saveLocation))
        //{
        //    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>");
        //    return null;
        //}
        //string  a= FU_imagen.ToString();
        //string b =FU_imagen.PostedFile.SaveAs(info.Ubicacion).ToString();
        this.RegisterStartupScript("mensaje", info.Url);

        return "~\\Imagen" + "\\" + info.Nombre;
    }
    public Boolean prueba(Uuser info)
    {
        Luser datos = new Luser();
        info = datos.cargaImage(info);
        return info.Ispos;
    }





    protected void TB_codigo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TB_imagen_TextChanged(object sender, EventArgs e)
    {
        
    }
}
