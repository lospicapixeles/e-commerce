using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda.Seguro
{
    public partial class Perfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    // Redirigir al login si no hay sesión activa
                    Response.Redirect("/Login.aspx");
                }
                else
                {
                    // Mostrar información del usuario
                    lblUserId.Text = Session["UserId"].ToString();
                    lblUsername.Text = Session["Username"].ToString();
                    lblEmail.Text = Session["Email"].ToString();
                    lblRole.Text = Session["RoleId"].ToString(); // Mapea el ID del rol a un nombre si es necesario
                    lblRegistrationDate.Text = Convert.ToDateTime(Session["RegistrationDate"]).ToString("dd/MM/yyyy");
                }
                MostrarPedidos();
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            // Cerrar sesión
            Session.Clear();
            Response.Redirect("/Login.aspx");
        }

        private void MostrarPedidos()
        {
            using (var context = new DBEcommerceEntities())
            {
                var pedidos = from p in context.Pedidos
                              join dp in context.DetallesPedido on p.id equals dp.id_pedido
                              join pr in context.Productos on dp.id_producto equals pr.id
                              where p.id_cliente == 1006
                              group new { pr.id, pr.nombre, pr.precio, pr.imagen_url, dp.cantidad } by new { pr.id, pr.nombre, pr.precio, pr.imagen_url } into g
                              select new
                              {
                                  g.Key.id,
                                  g.Key.nombre,
                                  g.Key.precio,
                                  g.Key.imagen_url,
                                  cantidad = g.Sum(x => x.cantidad), // Sumar las cantidades de productos en los pedidos
                                  total = g.Sum(x => x.precio * x.cantidad) // Precio total por producto, multiplicando por la cantidad
                              };

                // Asigna los resultados al Repeater
                rptPedidos.DataSource = pedidos.ToList();
                rptPedidos.DataBind();
            }
        }
    }
}