﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_ListaEmpleados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Cache.SetCacheability(HttpCacheability.ServerAndNoCache);
        Response.Cache.SetAllowResponseInBrowserHistory(false);
        Response.Cache.SetNoStore();

        LUser dato = new LUser();
            GV_Empleados.DataSource = dato.ListaEmpleado();
            GV_Empleados.DataBind();
        //}
    }

     protected void BT_Nuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("RegistroEmpleados.aspx");
    }

    protected void GV_Empleados_SelectedIndexChanged(object sender, EventArgs e)
    {
        UUsuario user = new UUsuario();
        Session["nombre"] = GV_Empleados.SelectedRow.Cells[7].Text;


   }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("ModificarEmpleado.aspx");
    }

    

    protected void BT_Eliminar_Click1(object sender, EventArgs e)
    {
        UUsuario datos = new UUsuario();
        LUser user = new LUser();
        ClientScriptManager cm = this.ClientScript;

        String nombre = Session["nombre"].ToString();
        datos = user.ObtenerId(nombre);
        datos.User_id = (datos.User_id);

        datos = user.EliminarEmpleado(datos);
        this.RegisterStartupScript("mensaje", datos.Mensaje);


    }

    protected void BT_Buscar_Click(object sender, EventArgs e)
    {
        //DAOUsuario dato = new DAOUsuario();
        //DataTable datos = dato.buscarEmpleados(TB_Filtro.Text.ToString());


        //GV_Resultado.DataSource = datos;
        //GV_Resultado.DataBind();

    }

    protected void TB_Filtro_TextChanged(object sender, EventArgs e)
    {
  
            LUser dato = new LUser();
            UUsuario datos = new UUsuario();
            ClientScriptManager cm = this.ClientScript;
            DataTable usuario;

            datos.Nombre = TB_Filtro.Text.ToString();

        try
        {
            usuario = dato.BuscarEmpleado(datos);

            GV_Empleados.DataSource = usuario;
            GV_Empleados.DataBind();

        }
        catch
        {
            usuario = dato.BuscarEmpleado(datos);
            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");


        }
        ////datos = dato.BuscarEmpleado(datos);
        //usuario = dato.BuscarEmpleado(datos);

        //GV_Empleados.DataSource = usuario;
        //GV_Empleados.DataBind();

        //this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Empleado no Existe');window.location=\"ListaEmpleados.aspx\"</script>");




    }

    protected void GV_Resultado_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}