using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de EPedido
/// </summary>
public class EPedido
{
    public EPedido()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }
    private Int32 id_pedido;
    private Int32 id_plato;
    private Int32 cantidad;
    private Int32 id_mesero;
    private Int32 id_mesa;
    private Int32 id_usuario;
    private Int32 id_pedido1;

    public int Id_pedido
    {
        get
        {
            return id_pedido;
        }

        set
        {
            id_pedido = value;
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

    public int Cantidad
    {
        get
        {
            return cantidad;
        }

        set
        {
            cantidad = value;
        }
    }

    public int Id_mesero
    {
        get
        {
            return id_mesero;
        }

        set
        {
            id_mesero = value;
        }
    }

    public int Id_mesa
    {
        get
        {
            return id_mesa;
        }

        set
        {
            id_mesa = value;
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

    public int Id_pedido1
    {
        get
        {
            return id_pedido1;
        }

        set
        {
            id_pedido1 = value;
        }
    }
}