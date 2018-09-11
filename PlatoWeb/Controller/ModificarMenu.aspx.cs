using System;
using System.Web.UI;
using Utilitarios;
using Logica;
using System.Data;
using System.Web;

public partial class View_ModificarMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        UuserCrear datos = new UuserCrear();
        datos.Ispos = IsPostBack;
        LUser user = new LUser();
        LUser ins = new LUser();

        UUser info = new UUser();
        {
            ClientScriptManager cm = this.ClientScript;
        }
    }
    protected void B_Modificar_Click(object sender, EventArgs e)
    {
        UuserCrear data = new UuserCrear();
        data.Ispos = IsPostBack;
        LUser user = new LUser();
        LUser ins = new LUser();
        //user.ispost1(data);
        UUser info = new UUser();

        info.Ruta = (FU_imagen.PostedFile.FileName);
        data.Imagen = cargarImagen();


        //user.ispost1(data);
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
        //data.Ispos = prueba(info);
        ins.aux1(data);
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

            enca.Ubicacion = enca.Ubicacion;

            FU_imagen.PostedFile.SaveAs(enca.Ubicacion);
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Plato Modificado Correctamente');window.location=\"ListadePlatos.aspx\"</script>");


        }
        catch
        {

            enca.Ubicacion = Server.MapPath("~\\Imagen") + "\\" + nombreArchivo;
            //mensaje = user.cargaImage(enca,extension);
            //enca.Ubicacion = mensaje.B;
            nombreArchivo = mensaje.Ubicacion;
            cm.RegisterClientScriptBlock(this.GetType(), "", mensaje.Url);

        }

        return "~\\Imagen" + "\\" + nombreArchivo;
    }
    //public Boolean prueba(Uuser info)
    //{
    //    Luser datos = new Luser();
    //    info = datos.cargaImage(info);
    //    return info.Ispos;
    //}





    protected void TB_codigo_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TB_imagen_TextChanged(object sender, EventArgs e)
    {

    }
}
