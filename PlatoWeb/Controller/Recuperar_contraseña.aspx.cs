using System;
using Logica;

using Utilitarios;

public partial class View_Recuperar_contraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Luser recu = new Luser();
        Response.Cache.SetNoStore();
        int x = Request.QueryString.Count;
        string y = Request.QueryString[0];
        Session["user_id"] = recu.Recuperar(x, y);

    }

    protected void Guardar_new_pass_Click(object sender, EventArgs e)
    {
        Luser user = new Luser();
        UuserToken datos = new UuserToken();
        int x = int.Parse(Session["user_id"].ToString());
        string y = TB_newPass.Text;
        user.guardarcontra(x, y);


    }
}