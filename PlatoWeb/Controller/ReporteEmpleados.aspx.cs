using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_ReporteEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            Reportes reporte = ObtenerInforme();
            CRS_Empleados.ReportDocument.SetDataSource(reporte);
            CRV_Empleados.ReportSource = CRS_Empleados;
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

        informacion = datos.Tables["Empleados"];
        DAOUsuario usuario = new DAOUsuario();

        DataTable intermedio = usuario.obtenerEmpleado();

        for (int i = 0; i < intermedio.Rows.Count; i++)
        {
            fila = informacion.NewRow();
            
            fila["Nombre"] = intermedio.Rows[i]["nombre"].ToString();
            fila["Apellido"] = intermedio.Rows[i]["apellido"].ToString();
            fila["Correo"] = intermedio.Rows[i]["correo"].ToString();
            fila["Cedula"] = intermedio.Rows[i]["cedula"].ToString();
            fila["Rol"] = intermedio.Rows[i]["rol"].ToString();
            //fila["Fotos"] = streamFile(intermedio.Rows[i]["foto"].ToString());

            informacion.Rows.Add(fila);
        }

        return datos;
    }
}