using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;
using System.Data;
using System.Configuration;
using Utilitarios;



namespace Datos
{
     public class DUser
    {
        public DataTable loggin(UUser datos)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("seguridad.f_loggin", conection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add("_user_name", NpgsqlDbType.Varchar, 100).Value = datos.User_name;
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

        public DataTable guardadoSession(UUser datos)
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

        public void InsertarUsuario(UUsuario datos)
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

        public void InsertReserva(UReserva datos)
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

        public DataTable obtenerReserva(Int32 user_id)
        {
            DataTable Usuario = new DataTable();
            NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Postgres"].ConnectionString);

            try
            {
                NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuario.f_obtener_reserva", conection);
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

        public DataTable actualizarReserva(UReserva datos)
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
    
    }




}
