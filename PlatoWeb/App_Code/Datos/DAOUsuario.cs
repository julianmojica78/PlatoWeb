using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Descripción breve de DAOUsuario
/// </summary>
public class DAOUsuario
{
    public ClientScriptManager ClientScript { get; private set; }

    public DAOUsuario()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //


    }

    public DataTable loggin(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_loggin", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar, 100).Value =datos.User_name;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar, 100).Value = datos.Clave;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable guardadoSession(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_guardado_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_ip", NpgsqlDbType.Varchar, 100).Value = datos.Ip;
            dataAdapter.SelectCommand.Parameters.Add("_mac", NpgsqlDbType.Varchar, 100).Value = datos.Mac;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable actualziarContrasena(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_contrasena", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.UserId;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Varchar).Value = datos.Clave;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable cerrarSession(EUsuario datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_cerrar_session", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerUsuarios(String filtro)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_filtro", NpgsqlDbType.Text).Value = filtro;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable generarToken(String user_name)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = user_name;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable almacenarToken(String token, Int32 userId)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_almacenar_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = userId;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerUsusarioToken(String token)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_usuario_token", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerPlato()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_plato", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerRe()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_re", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerVenta()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_venta", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerRes()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_res", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerplatopedido()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_pedidoplato", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerReservaplato()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reservaplato", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }


    public void InsertarUsuario(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = datos.Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Text).Value = datos.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_puntos", NpgsqlDbType.Integer).Value = datos.Puntos;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = datos.Id_Rol;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_rclave", NpgsqlDbType.Text).Value = datos.Rclave;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {   
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public void InsertReserva(EReservas datos)
    {

        DataTable Reserva = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Cant;
            dataAdapter.SelectCommand.Parameters.Add("_dia", NpgsqlDbType.Timestamp).Value = datos.Dia;
            dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = datos.Id_usuario;
            conection.Open();
            dataAdapter.Fill(Reserva);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

public DataTable obtenerMesa()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_mesa", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerUbicacion()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_ubicacion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable verificarMesa()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.verificar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable generarTokenReserva(Int32 user_id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = user_id;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable actualizarReserva(EReservas datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_reserva", NpgsqlDbType.Integer).Value = datos.Id_reserva;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.Id_usuario;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

        
    public DataTable obtenerPedido(Int32 user_id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_pedido", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = user_id;
            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable verificarReserva(Int32 cant,String dia)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cant", NpgsqlDbType.Integer).Value = cant;
            dataAdapter.SelectCommand.Parameters.Add("_dia", NpgsqlDbType.Timestamp).Value =dia ;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerId(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_Id", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerIdre(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_idre", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerIdm(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_Idm", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerMisReservas(Int32 id_usuario)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_misreserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = id_usuario;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable almacenarTokenReserva(String token, Int32 userId)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_almacenar_token_reserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_token", NpgsqlDbType.Text).Value = token;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = userId;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable validarRegistro(String user_name, String correo)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_registro", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = user_name;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = correo;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable validarBusare(String Nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarve", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable validarBusarrp(String Nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarrp", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable validarBusarpp(String Nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarpp", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable validarBuscarm(String Nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarm", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable validarBuscarco(String Nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_validar_buscarcom", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = Nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerdatos()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_cocinero", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obtenerdatos1()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_cocinero1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable obteneruser()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_listar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable informacionPlato(Int32 id_pedido)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_platos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }
    public DataTable informacionPlato1(Int32 id_pedido)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_platos1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }
    public DataTable despacho(Int32 id_pedido, DateTime fecha_despacho)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_despacho", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;
            //dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = id_plato;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_despacho", NpgsqlDbType.Timestamp).Value = fecha_despacho;


            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }
    public DataTable despacho1(Int32 id_pedido, DateTime fecha_despacho)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_despacho1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = id_pedido;
            //dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = id_plato;
            dataAdapter.SelectCommand.Parameters.Add("_fecha_despacho", NpgsqlDbType.Timestamp).Value = fecha_despacho;


            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }

    public DataTable obtenerEmpleado()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_listar_empleado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable obtenerPuntos(Int32 Id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_puntos", conection);
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = Id;

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public DataTable redimir(Int32 Id)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_redimir", conection);
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = Id;

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }
    public void insertarEmpleado(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_empleado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = datos.Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Text).Value = datos.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = datos.Id_Rol;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_rclave", NpgsqlDbType.Text).Value = datos.Rclave;
            dataAdapter.SelectCommand.Parameters.Add("_session", NpgsqlDbType.Text).Value = datos.Session;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void modificarEmpleado(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_empleado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_apellido", NpgsqlDbType.Text).Value = datos.Apellido;
            dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_cedula", NpgsqlDbType.Text).Value = datos.Cedula;
            dataAdapter.SelectCommand.Parameters.Add("_id_rol", NpgsqlDbType.Integer).Value = datos.Id_Rol;
            dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Text).Value = datos.User_Name1;
            dataAdapter.SelectCommand.Parameters.Add("_clave", NpgsqlDbType.Text).Value = datos.Clave;
            dataAdapter.SelectCommand.Parameters.Add("_rclave", NpgsqlDbType.Text).Value = datos.Rclave;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public void eliminarEmpleado(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable buscarEmpleados(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_empleado", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }
    public DataTable buscarreservapla(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_reservaplato", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }
    public DataTable buscarPedidoplato(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_pedidoplato", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }

    public DataTable buscarPlato(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_platos", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }

    public DataTable buscarUsuario(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_clientes", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }

    public void eliminarMesa(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminar_mesa", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public void insertarComentarios(EComentarios datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_comentario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_detalle", NpgsqlDbType.Text).Value = datos.Descripcion;
            dataAdapter.SelectCommand.Parameters.Add("_user_id", NpgsqlDbType.Integer).Value = datos.User_id;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public DataTable obtenerComentarios()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_comentarios", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable buscarComentario(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_comentario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }

    public DataTable obtenerMesas()
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_mesas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public DataTable buscarMesas(String nombre)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_buscar_mesas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = nombre;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;

    }

    public void insertarMesa(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertar_mesas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Id_Rol;
            dataAdapter.SelectCommand.Parameters.Add("_ubicacion", NpgsqlDbType.Text).Value = datos.Apellido;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void modificarMesas(EUser datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_actualizar_mesas", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_mesa", NpgsqlDbType.Integer).Value = datos.User_id;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = datos.Nombre;

            dataAdapter.SelectCommand.Parameters.Add("_ubicacion", NpgsqlDbType.Text).Value = datos.Apellido;
            //dataAdapter.SelectCommand.Parameters.Add("_datos", NpgsqlDbType.Text).Value = json;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void insertarMenu(ECrear datos)
    {
        DataTable Registro = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarmenu", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nomplato;
            dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Text).Value = datos.Descripcion;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Text).Value = datos.Precio;
            dataAdapter.SelectCommand.Parameters.Add("_imagen", NpgsqlDbType.Text).Value = datos.Imagen;
            conection.Open();
            dataAdapter.Fill(Registro);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public void insertarContacto(EContacto datos)
    {
        DataTable contacto = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarcontacto", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;


            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nombre;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = datos.Telefono;
            dataAdapter.SelectCommand.Parameters.Add("_email", NpgsqlDbType.Text).Value = datos.Email;
            dataAdapter.SelectCommand.Parameters.Add("_detalle", NpgsqlDbType.Text).Value = datos.Detalle;

            conection.Open();
            dataAdapter.Fill(contacto);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public DataTable EliminarPlato(ECrear datos)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_eliminarmenu", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = datos.Id_plato;

            conection.Open();
            dataAdapter.Fill(Usuario);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
        return Usuario;
    }

    public void InsertPedido(EPedido pedido)
    {

        DataTable Pedido1 = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarpedido1", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = datos.Id_pedido1;
            dataAdapter.SelectCommand.Parameters.Add("_id_mesa", NpgsqlDbType.Integer).Value = pedido.Id_mesa;
            dataAdapter.SelectCommand.Parameters.Add("_id_usuario", NpgsqlDbType.Integer).Value = pedido.Id_mesero;
            conection.Open();
            dataAdapter.Fill(Pedido1);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void insertarPedido(EPedido pedido)
    {

        DataTable Pedido1 = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarpedido", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = pedido.Id_pedido;
            dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = pedido.Id_plato;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = pedido.Cantidad;
            conection.Open();
            dataAdapter.Fill(Pedido1);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }

    public void Insertarcortesia(Int32 Id)
    {

        DataTable Pedido1 = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarpedidocortesia", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //dataAdapter.SelectCommand.Parameters.Add("_id_pedido", NpgsqlDbType.Integer).Value = datos.Id_pedido1;
            dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = Id;
            conection.Open();
            dataAdapter.Fill(Pedido1);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
    public void modificarMenu(ECrear datos)
    {
        DataTable platos = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["postgres"].ConnectionString);

        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_modificarMenu", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = datos.Id_plato;
            dataAdapter.SelectCommand.Parameters.Add("_nombre", NpgsqlDbType.Text).Value = datos.Nomplato;
            dataAdapter.SelectCommand.Parameters.Add("_descripcion", NpgsqlDbType.Text).Value = datos.Descripcion;
            dataAdapter.SelectCommand.Parameters.Add("_precio", NpgsqlDbType.Text).Value = datos.Precio;
            dataAdapter.SelectCommand.Parameters.Add("_imagen", NpgsqlDbType.Text).Value = datos.Imagen;


            conection.Open();
            dataAdapter.Fill(platos);
        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

    }

    public void Insertarpreserva(EReservas plato)
    {

        DataTable Plato = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_insertarplatoreserva", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_id_reserva", NpgsqlDbType.Integer).Value = plato.Id_reserva;
            dataAdapter.SelectCommand.Parameters.Add("_id_plato", NpgsqlDbType.Integer).Value = plato.Id_plato;
            dataAdapter.SelectCommand.Parameters.Add("_cantidad", NpgsqlDbType.Integer).Value = plato.Cant;
            conection.Open();
            dataAdapter.Fill(Plato);


        }
        catch (Exception Ex)
        {
            throw Ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }
    }
}