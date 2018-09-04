using System;
using System.Data;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_CanjePuntos : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

        int Id = int.Parse(Session["user_id"].ToString());
        Luser dao = new Luser();
        DataTable tabla = new DataTable();

        int id_usuario = int.Parse(Session["user_id"].ToString());
        GridView1.DataSource = dao.obtenerReservas(id_usuario);
        GridView1.DataBind();

        

        tabla = dao.obtenerPuntos(Id);
        //DataTable obtepuntos = dao.canje(id_usuario, Id);
        UuserReservas dato = dao.canje(tabla);
        LB_puntos.Text = dato.Cant.ToString();
        Label5.Visible = dato.Est1;
        DataList1.Visible = dato.Est2;
    }

    protected void BT_MReservas_Click(object sender, EventArgs e)
    {
        Response.Redirect("Resrvas.aspx");
    }

    protected void BT_Canje_Click(object sender, EventArgs e)
    {
        Luser datos = new Luser();
        int Id = int.Parse(Session["user_id"].ToString());
        DataTable data = datos.redimir(Id);
        Button btn = (Button)sender;
        DataListItem item = (DataListItem)btn.NamingContainer;
        Label lblid = (Label)item.FindControl("Label1");
        int x = int.Parse(lblid.Text);

        datos.cortesia(x);
        this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Reservado');window.location=\"Resrvas.aspx\"</script>");

    }
}