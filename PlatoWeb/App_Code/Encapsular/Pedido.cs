using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Pedido
/// </summary>
public class Pedido
{
    public Pedido()
    {
        
    }

    private long fecha_despacho;
    private Int32 cantidad;
    private Int32 id_pedido;

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

    public long Fecha_despacho
    {
        get
        {
            return fecha_despacho;
        }

        set
        {
            fecha_despacho = value;
        }
    }
}