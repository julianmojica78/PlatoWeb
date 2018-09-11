using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ReporteVentas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();
        try
        {
            UReportes reporte = ObtenerInforme();
            CRS_ReporteVentas.ReportDocument.SetDataSource(reporte);
            CRV_Reportev.ReportSource = CRS_ReporteVentas;
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected UReportes ObtenerInforme()
    {
        LUser report = new LUser();
        UReportes datos = new UReportes();

        datos = report.obtenerinfomeV();

        return datos;
    }
}