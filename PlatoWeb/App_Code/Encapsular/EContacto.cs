using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EContacto
/// </summary>
public class EContacto
{
    public EContacto()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private Int32 id_contactenos;
    private String asunto;
    private String email;
    private String detalle;
    private String nombre;
    private String telefono;

    public int Id_contactenos
    {
        get
        {
            return id_contactenos;
        }

        set
        {
            id_contactenos = value;
        }
    }

    public string Asunto
    {
        get
        {
            return asunto;
        }

        set
        {
            asunto = value;
        }
    }

    public string Email
    {
        get
        {
            return email;
        }

        set
        {
            email = value;
        }
    }

    public string Detalle
    {
        get
        {
            return detalle;
        }

        set
        {
            detalle = value;
        }
    }

    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string Telefono
    {
        get
        {
            return telefono;
        }

        set
        {
            telefono = value;
        }
    }
}