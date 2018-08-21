using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EUserToken
/// </summary>
public class EUserToken
{
    public EUserToken()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private Int32 id;
    private String nombre;
    private String apellido;
    private String telefono;
    private String puntos;
    private String id_rol;
    private String correo;
    private String user_name;
    private String clave;
    private Int32 estado;
    private Int32 id_Mesa;
    private Int32 id_usuario;
    private String cedula;
    private String session;
    private long fecha;

    public int Id
    {
        get
        {
            return id;
        }

        set
        {
            id = value;
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

    public string User_name
    {
        get
        {
            return user_name;
        }

        set
        {
            user_name = value;
        }
    }

    public long Fecha
    {
        get
        {
            return fecha;
        }

        set
        {
            fecha = value;
        }
    }

    public string Clave
    {
        get
        {
            return clave;
        }

        set
        {
            clave = value;
        }
    }

    public int Estado
    {
        get
        {
            return estado;
        }

        set
        {
            estado = value;
        }
    }

    public int Id_Mesa
    {
        get
        {
            return id_Mesa;
        }

        set
        {
            id_Mesa = value;
        }
    }

    public string Apellido
    {
        get
        {
            return apellido;
        }

        set
        {
            apellido = value;
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

    public string Puntos
    {
        get
        {
            return puntos;
        }

        set
        {
            puntos = value;
        }
    }

    public string Id_rol
    {
        get
        {
            return id_rol;
        }

        set
        {
            id_rol = value;
        }
    }

    public string Correo
    {
        get
        {
            return correo;
        }

        set
        {
            correo = value;
        }
    }

    public string Cedula
    {
        get
        {
            return cedula;
        }

        set
        {
            cedula = value;
        }
    }

    public string Session
    {
        get
        {
            return session;
        }

        set
        {
            session = value;
        }
    }

    public int Id_usuario
    {
        get
        {
            return id_usuario;
        }

        set
        {
            id_usuario = value;
        }
    }
}

