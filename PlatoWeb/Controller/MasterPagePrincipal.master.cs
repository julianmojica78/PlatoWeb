﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilitarios;
using Logica;

public partial class View_MasterPagePrincipal : System.Web.UI.MasterPage
{
   
    protected void Page_Load(object sender, EventArgs e)
    {


        Estado est = new Estado();
        UUser datos = new UUser();
        LUser user = new LUser();


        //string usu = Session["nombre"].ToString();
        //Session["user_id"].ToString();
        try
        {
            datos.User_name = Session["nombre"].ToString();
            est = user.estado(datos);

            BT_Cerrar.Visible = (est.Esstado);
            BT_Login.Visible = (est.Estado1);
            L_Comentario.Visible = (est.Esstado);
            TB_Comentario.Visible = (est.Esstado);
            BT_Enviar.Visible = (est.Esstado);
        }
        catch
        {
            est = user.estado(datos);
            BT_Cerrar.Visible = (est.Esstado);
            L_Comentario.Visible = (est.Esstado);
            TB_Comentario.Visible = (est.Esstado);
            BT_Enviar.Visible = (est.Esstado);
        }
    }

    protected void B_inicio_Click(object sender, EventArgs e)
    {
        Response.Redirect("Inicio.aspx");
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Loggin.aspx");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Contactenos.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Resrvas.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuPrincipal.aspx");
    }


    protected void BT_Cerrar_Click(object sender, EventArgs e)
    {
        Session["user_id"] = null;
        Session["nombre"] = null;

        LUser user = new LUser();
        UUsuario datos = new UUsuario();
        datos.Session = Session.SessionID;
        datos = user.Cerrar(datos);
        Response.Redirect(datos.Mensaje);

        Response.Redirect("Loggin.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("resrvas.aspx");
    }

    protected void BT_Enviar_Click(object sender, EventArgs e)
    {

        UComentarios datos = new UComentarios();
        LUser user = new LUser();

        datos.Descripcion = TB_Comentario.Text.ToString();
        datos.User_id = int.Parse(Session["user_id"].ToString());
                

        datos = user.InsertarComentario(datos);
        this.Page.Response.Write(datos.Mensaje);
    }
}
