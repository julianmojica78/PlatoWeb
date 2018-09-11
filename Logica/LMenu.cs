using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitarios;
using Datos;
using System.Data;

namespace Logica
{
    public class LMenu
    {
        public UUser CargaImagen(UUser enca)
        {
            DUser dato = new DUser();
            UUser mensaje = new UUser();
            String saveLocation = "";
            mensaje.Ispos = true;
            if (!(string.Compare(enca.A, ".JPG", true) == 0 || string.Compare(enca.A, ".jpeg", true) == 0 || string.Compare(enca.A, ".gif", true) == 0 || string.Compare(enca.A, ".jpe", true) == 0))
            {
                mensaje.Url = "<script type='text/javascript'>alert('Solo se admiten imagenes en formato Jpeg o Gif');</script>";
                mensaje.Ubicacion = null;

                return mensaje;
            }
            // else
            //{
            //  mensaje.Ubicacion = enca.Ubicacion;
            //}
            saveLocation = enca.Ubicacion;
            if (System.IO.File.Exists(saveLocation))
            {
                mensaje.Url = "<script type='text/javascript'>alert('Ya existe una imagen en el servidor con ese nombre');</script>";
                mensaje.Ubicacion = null;
                //return null;
            }
            else
            {
                mensaje.Ubicacion = enca.Ubicacion;
            }
            return mensaje;
        }

        public void insertmenu(UuserCrear datos)
        {
            DUser dato = new DUser();
            //DataTable data = dato.insertarMenu(datos);
            String xD = "~\\Imagen\\";
            if (datos.Imagen != xD)
            {
                dato.insertarMenu(datos);
            }
        }
        public void ispost1(UuserCrear info)
        {
            if (info.Ispos)
            {
                DUser data = new DUser();
                UUser datos = new UUser();
                info.A = info.B;
                info.C = info.D;
                info.E = info.F;
            }

        }
        public void modifimenu(UuserCrear datos)
        {
            DUser dato = new DUser();
            if (datos.Imagen != null)
            {
                dato.modificarMenu(datos);
            }
        }
        public void aux1(UuserCrear info)
        {
            DUser dato = new DUser();
            if (info.Ispos)
            {
                modifimenu(info);
            }
            else
            {
                info.A = "<script type='text/javascript'>alert('ERROR..');</script>";

            }
        }
        public DataTable obtenerMesa(string nombre)
        {
            DUser dato = new DUser();
            DataTable data = dato.obtenerIdm(nombre);
            return data;
        }

    }
}
