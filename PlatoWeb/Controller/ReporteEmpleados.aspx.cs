using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ReporteEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();


        try
        {
            UReportes reporte = ObtenerInforme();
            CRS_Empleados.ReportDocument.SetDataSource(reporte);
            CRV_Empleados.ReportSource = CRS_Empleados;
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

        datos = report.obtenerinformeE();

        return datos;
    }
}