using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ReporteVentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Reportes reporte = ObtenerInforme();
            CRS_ReporteVentas.ReportDocument.SetDataSource(reporte);
            CRV_Reportev.ReportSource = CRS_ReporteVentas;
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

        informacion = datos.Tables["Pedido"];
        DAOUsuario usuario = new DAOUsuario();

        DataTable intermedio = usuario.obtenerVenta();

        for (int i = 0; i < intermedio.Rows.Count; i++)
        {
            fila = informacion.NewRow();

            fila["Pedido"] = int.Parse(intermedio.Rows[i]["id_pedido"].ToString());
            fila["Nombre"] = intermedio.Rows[i]["nombre"].ToString();
            fila["Cantidad"] = int.Parse(intermedio.Rows[i]["cantidad"].ToString());
            fila["Fecha ingreso"] = intermedio.Rows[i]["fecha_ingreso"].ToString();
            fila["Fecha despacho"] = intermedio.Rows[i]["fecha_despacho"].ToString();
            fila["Precio"] = intermedio.Rows[i]["precio"].ToString();
            //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

            informacion.Rows.Add(fila);
        }

        return datos;
    }
}