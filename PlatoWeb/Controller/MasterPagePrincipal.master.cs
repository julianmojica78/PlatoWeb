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


        Estado user = new Estado();
        LUser datos = new LUser();
        UUser usuario = new UUser();

        //Response.Redirect(datos.Url);

        //string usu = Session["nombre"].ToString();
        //Session["user_id"].ToString(); 
        //try
        //{
        //    usuario.User_name = Session["nombre"].ToString();
        //    datos.estado(usuario);

        //    BT_Cerrar.Visible = (user.Esstado);
        //    BT_Login.Visible = (user.Estado1);
        //    L_Comentario.Visible = (user.Esstado);
        //    TB_Comentario.Visible = (user.Esstado);
        //    BT_Enviar.Visible = (user.Esstado);
        //}
        //catch
        //{
        //    datos.estado(usuario);
        //    BT_Cerrar.Visible = (user.Esstado);
        //    L_Comentario.Visible = (user.Esstado);
        //    TB_Comentario.Visible = (user.Esstado);
        //    BT_Enviar.Visible = (user.Esstado);
        //}


        if (Session["nombre"] == null)
        {
            BT_Cerrar.Visible = false;
            L_Comentario.Visible = false;
            TB_Comentario.Visible = false;
            BT_Enviar.Visible = false;
        }
        else
        {
            BT_Cerrar.Visible = true;
            BT_Login.Visible = false;

            L_Comentario.Visible = true;
            TB_Comentario.Visible = true;
            BT_Enviar.Visible = true;
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
        Response.Cache.SetNoStore();
        Session["user_id"] = null;
        Session["nombre"] = null;

        DAOUsuario user = new DAOUsuario();
        EUsuario datos = new EUsuario();
        datos.Session = Session.SessionID;
        user.cerrarSession(datos);

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
    }
}
