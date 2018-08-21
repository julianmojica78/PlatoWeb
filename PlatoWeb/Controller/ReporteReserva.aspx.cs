using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ReporteReserva : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Reportes reporte = ObtenerInforme();
            CRS_Reserva.ReportDocument.SetDataSource(reporte);
            CRV_Reserva.ReportSource = CRS_Reserva;
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected Reportes ObtenerInforme()
    {
        DataRow fila;  //dr
        DataTable informacion = new DataTable(); //dt
        Reportes datos = new Reportes();

        informacion = datos.Tables["Reservas"];
        DAOUsuario usuario = new DAOUsuario();

        DataTable intermedio = usuario.obtenerRes();

        for (int i = 0; i < intermedio.Rows.Count; i++)
        {
            fila = informacion.NewRow();

            fila["Reserva"] = int.Parse(intermedio.Rows[i]["id_reserva"].ToString());
            fila["Usuario"] = intermedio.Rows[i]["user_name"].ToString();
            fila["Dia"] = intermedio.Rows[i]["dia"].ToString();
            //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

            informacion.Rows.Add(fila);
        }

        return datos;
    }
}