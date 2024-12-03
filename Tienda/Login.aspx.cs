using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblError.Text = "Por favor, ingrese su usuario y contraseña.";
                lblError.Visible = true;
                return;
            }

            // Conexión a la base de datos para validar usuario
            using (DBEcommerceEntities db = new DBEcommerceEntities())
            {
                var user = db.Usuarios
                    .Where(u => u.username == username && u.estado == "Activo")
                    .Select(u => new
                    {
                        u.id_cliente,
                        u.username,
                        u.email,
                        u.password_hash,
                        u.id_rol,
                        u.fecha_registro
                    })
                    .FirstOrDefault();

                if (user != null && user.password_hash == password) // Comparar hash si es necesario
                {
                    // Usuario autenticado: guardar datos en Session
                    Session["UserId"] = user.id_cliente;
                    Session["Username"] = user.username;
                    Session["Email"] = user.email;
                    Session["RoleId"] = user.id_rol;
                    Session["RegistrationDate"] = user.fecha_registro;

                    // Redirigir al perfil
                    FormsAuthentication.RedirectFromLoginPage(username, false);
                }
                else
                {
                    // Error de autenticación
                    lblError.Text = "Usuario o contraseña incorrectos.";
                    lblError.Visible = true;
                }
            }

        }
    }
}