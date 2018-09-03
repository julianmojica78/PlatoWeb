using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class View_Generar_Token : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Aceptar_Click(object sender, EventArgs e)
    {
        DAOUsuario dao = new DAOUsuario();
        System.Data.DataTable validez = dao.generarToken(TB_generar_token.Text);
        if (int.Parse(validez.Rows[0]["id_usuario"].ToString()) > 0)
        {
            EUserToken token = new EUserToken();
            token.Id = int.Parse(validez.Rows[0]["id_usuario"].ToString());
            token.Nombre = validez.Rows[0]["nombre"].ToString();
            token.Apellido = validez.Rows[0]["apellido"].ToString();
            token.Correo = validez.Rows[0]["email"].ToString();
            token.Telefono = validez.Rows[0]["telefono"].ToString();
            token.Cedula = validez.Rows[0]["cedula"].ToString();
            token.Puntos = validez.Rows[0]["puntos"].ToString();
            token.Id_rol = validez.Rows[0]["id_rol"].ToString();
            token.User_name = validez.Rows[0]["user_name"].ToString();
            token.Clave = validez.Rows[0]["clave"].ToString();
            token.Session = validez.Rows[0]["session"].ToString();
            //token.Id_contacto = int.Parse(validez.Rows[0]["id_contacto"].ToString());
            token.Estado = int.Parse(validez.Rows[0]["estado"].ToString());
            
            token.Fecha = DateTime.Now.ToFileTimeUtc();

            String userToken = encriptar(JsonConvert.SerializeObject(token));
            dao.almacenarToken(userToken, token.Id);

            Correo correo = new Correo();

            String mensaje = "su link de acceso es: " + "http://localhost:52368/View/Recuperar_Contraseña.aspx?" + userToken;
            correo.enviarCorreo(token.Correo, userToken, mensaje);

            this.RegisterStartupScript("mensaje", "<script type='text/javascript'>alert('Su nueva contraseña ha sido enviada exitosamente a su correo');window.location=\"Loggin.aspx\"</script>");

        }
        else if (int.Parse(validez.Rows[0]["id"].ToString()) == -2)
        {
            L_Mensaje.Text = "Ya existe un token, por favor verifique su correo.";
        }
        else
        {
            L_Mensaje.Text = "El usurio digitado no existe";
        }
    }

    private string encriptar(string input)
    {
        SHA256CryptoServiceProvider provider = new SHA256CryptoServiceProvider();

        byte[] inputBytes = Encoding.UTF8.GetBytes(input);
        byte[] hashedBytes = provider.ComputeHash(inputBytes);

        StringBuilder output = new StringBuilder();

        for (int i = 0; i < hashedBytes.Length; i++)
            output.Append(hashedBytes[i].ToString("x2").ToLower());

        return output.ToString();
    }
}