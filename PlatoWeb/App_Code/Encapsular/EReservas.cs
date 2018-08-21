using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EReservas
/// </summary>
public class EReservas
{
    public EReservas()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private String dia;
    private Int32 cant;
    private Int32 puntos;
    private Int32 id_usuario;
    private Int32 id_plato;
    private Int32 id_reserva;
    private Int32 estado;

    public int Cant
    {
        get
        {
            return cant;
        }

        set
        {
            cant = value;
        }
    }
    
    public string Dia
    {
        get
        {
            return dia;
        }

        set
        {
            dia = value;
        }
    }

    public int Puntos
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

    public int Id_reserva
    {
        get
        {
            return id_reserva;
        }

        set
        {
            id_reserva = value;
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