using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ECrear
/// </summary>
public class ECrear
{
    public ECrear()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private String nomplato;
    private String descripcion;
    private String precio;
    private String imagen;
    private Int32 id_plato;

    public string Nomplato
    {
        get
        {
            return nomplato;
        }

        set
        {
            nomplato = value;
        }
    }

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

    public string Precio
    {
        get
        {
            return precio;
        }

        set
        {
            precio = value;
        }
    }

    public string Imagen
    {
        get
        {
            return imagen;
        }

        set
        {
            imagen = value;
        }
    }

    public int Id_plato
    {
        get
        {
            return id_plato;
        }

        set
        {
            id_plato = value;
        }
    }
}