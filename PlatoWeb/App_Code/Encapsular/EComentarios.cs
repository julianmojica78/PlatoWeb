using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EComentarios
/// </summary>
public class EComentarios
{
    public EComentarios()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    private string descripcion;
    private Int32 user_id;

    public string Descripcion
    {
        get
        {
            return descripcion;
        }

        set
        {
            descripcion = value;
        }
    }

    public int User_id
    {
        get
        {
            return user_id;
        }

        set
        {
            user_id = value;
        }
    }
}