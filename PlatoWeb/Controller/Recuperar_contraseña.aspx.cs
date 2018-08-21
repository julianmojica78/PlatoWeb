using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Recuperar_contraseña : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetNoStore();

        if (Request.QueryString.Count > 0)
        {
            DAOUsuario user = new DAOUsuario();
            DataTable info = user.obtenerUsusarioToken(Request.QueryString[0]);

            if (int.Parse(info.Rows[0][0].ToString()) == -1)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token es invalido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>");
            else if (int.Parse(info.Rows[0][0].ToString()) == -1)
                this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('El Token esta vencido. Genere uno nuevo');window.location=\"Loggin.aspx\"</script>");
            else
                Session["user_id"] = int.Parse(info.Rows[0][0].ToString());
        }
        else
            Response.Redirect("Inicio.aspx");
    }

    protected void Guardar_new_pass_Click(object sender, EventArgs e)
    {
        DAOUsuario user = new DAOUsuario();
        EUsuario eUser = new EUsuario();

        eUser.UserId = int.Parse(Session["user_id"].ToString());
        eUser.Clave = TB_newPass.Text;
        user.actualziarContrasena(eUser);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su Contraseña ha sido actualizada.');window.location=\"Loggin.aspx\"</script>");
    }
}