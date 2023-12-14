using Microsoft.AspNetCore.Mvc;
using ejemplo.Modelo;
using System.Security.Cryptography;
using System.Text;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Web;

namespace ejemplo.Controlador
{
    public class AccesoController : Controller
    {/*
        static string cadena = "Data Source=(LAPTOP-UDJRLAAC\\SQLEXPRESS); Initial Catalog= Proyecto_ASPX; Integrated Security= true";
        public ActionResult Login()
        {
            return View();

        }

        public ActionResult Registrar()
        {
            return View();

        }
        /*
        [HttpPost]
        public ActionResult Registrar(Usuario oUsuario)
        {
            bool registrado;
            string mensaje;

            if (oUsuario.Clave == oUsuario.ConfirmarClave)
            {
                oUsuario.Clave = ConvertirSha256(oUsuario.Clave);
            }else
            {
                ViewData["Mensaje"] = "Las contraseñas no coinciden";
                return View();
            }

            using (SqlConnection cn = new SqlConnection(cadena)) {
                SqlCommand cmd = new SqlCommand("sp_RegistrarUsuario", cn );
                cmd.Parameters.AddWithValue("Correo", oUsuario.Correo);
                cmd.Parameters.AddWithValue("Clave", oUsuario.Clave);
                cmd.Parameters.Add("Registrado", System.Data.SqlDbType.Bit).Direction = System.Data.ParameterDirection.Output;
                cmd.Parameters.Add("Mensaje", System.Data.SqlDbType.VarChar,100).Direction = System.Data.ParameterDirection.Output;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Open();
                cmd.ExecuteNonQuery();

                registrado = Convert.ToBoolean(cmd.Parameters["Registrado"].Value);
                mensaje = cmd.Parameters["Mensaje"].Value.ToString();
            }
            
            ViewData["Mensaje"] = mensaje;

            if(registrado)
            {
                return RedirectToAction("Login","Acceso");
            
            }else {

                return View();
            
            }

            return View();

        }*/
        /*
        [HttpPost]
        public ActionResult Login(Usuario oUsuario)
        {
            oUsuario.Clave = ConvertirSha256(oUsuario.Clave);

            using (SqlConnection cn = new SqlConnection(cadena))
            {

                SqlCommand cmd = new SqlCommand("sp_ValidarUsuario", cn);
                cmd.Parameters.AddWithValue("Correo",oUsuario.Correo);
                cmd.Parameters.AddWithValue("Clave", oUsuario.Clave);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cn.Open();

                oUsuario.Id_Usuario = Convert.ToInt32(cmd.ExecuteScalar().ToString);
            }

            if (oUsuario.Id_Usuario != 0)
            {
                Session["usuario"] = oUsuario;
            }

        }*/
        /*

        public static string ConvertirSha256(string texto)
        {
            StringBuilder Sb = new StringBuilder();
            using (SHA256 hash = SHA256Managed.Create()) 
            { 
                Encoding enc = Encoding.UTF8;
                byte[] result = hash.ComputeHash(Encoding.UTF8.GetBytes(texto));

                foreach (byte b in result)
                {
                    Sb.Append(b.ToString("x2"));
                }
            }
            return Sb.ToString();
        }*/
    }
}
     