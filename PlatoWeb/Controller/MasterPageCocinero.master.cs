﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_MasterPageCocinero : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        UUser datos = new UUser();
        LUser user = new LUser();


        try
        {

            datos.User_name = Session["nombre"].ToString();
            user.validarlogin(datos);
            datos.User_name = Session["nombre"].ToString();
        }
        catch
        {
            datos = user.validarlogin(datos);
            Response.Redirect(datos.Url);

        }
    }
}
