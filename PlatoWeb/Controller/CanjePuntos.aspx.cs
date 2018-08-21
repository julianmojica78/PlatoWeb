using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_CanjePuntos : System.Web.UI.Page
{
    /// <summary>
    /// la
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

        int Id = int.Parse(Session["user_id"].ToString());
        DAOUsuario dao = new DAOUsuario();
        DataTable tabla = new DataTable();

        int id_usuario = int.Parse(Session["user_id"].ToString());
        GridView1.DataSource = dao.obtenerMisReservas(id_usuario);
        GridView1.DataBind();

        if (!IsPostBack)
        {
            EReservas datos = new EReservas();
            DAOUsuario user = new DAOUsuario();
            ClientScriptManager cm = this.ClientScript;
            //TB_puntos.Text = Session["puntos"].ToString();
        }
        tabla = dao.obtenerPuntos(Id);
        int sum=0;
        int p = 0;

       foreach (DataRow fila in tabla.Rows)
       {
            string punto = tabla.Rows[0]["puntos"].ToString();

            p=int.Parse(punto);
            sum = p;
              

        }


        LB_puntos.Text = sum.ToString();

        if (sum < 100) {
            Label5.Visible = true;
            DataList1.Visible = false;
        }
        else {
            Label5.Visible = false;
            DataList1.Visible = true;
        }
    }

    protected void BT_MReservas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Resrvas.aspx");
    }

    protected void BT_Canje_Click(object sender, EventArgs e)
    {
        DAOUsuario datos = new DAOUsuario();
        int Id = int.Parse(Session["user_id"].ToString());
        datos.redimir(Id);
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        Label lblid = (Label)item.FindControl("Label1");
        int x = int.Parse(lblid.Text);

        datos.Insertarcortesia(x);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Reservado');window.location=\"Resrvas.aspx\"</script>");

    }
}