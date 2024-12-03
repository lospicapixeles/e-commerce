using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class Shop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Captura la categoría de la URL
                string categoriaSeleccionada = Request.QueryString["categoria"];

                // Cargar productos según la categoría seleccionada
                CargarProductos(categoriaSeleccionada);
                CargarCategorias();
            }
        }

        // Cargar productos filtrados por categoría
        private void CargarProductos(string categoriaSeleccionada)
        {
            using (DBEcommerceEntities ecommerce = new DBEcommerceEntities())
            {
                var productos = (from c in ecommerce.Productos
                                 where string.IsNullOrEmpty(categoriaSeleccionada) || c.Categorias.nombre == categoriaSeleccionada
                                 select new
                                 {
                                     c.id,
                                     c.nombre,
                                     c.descripcion,
                                     c.precio,
                                     c.stock,
                                     c.imagen_url
                                 }).ToList();

                repiterItems.DataSource = productos;
                repiterItems.DataBind();
            }
        }

        // Cargar todas las categorías
        private void CargarCategorias()
        {
            using (DBEcommerceEntities ecommerce = new DBEcommerceEntities())
            {
                var categorias = (from c in ecommerce.Categorias
                                  select new
                                  {
                                      c.id,
                                      c.nombre,
                                      c.descripcion
                                  }).ToList();

                repiterCategoria.DataSource = categorias;
                repiterCategoria.DataBind();
            }
        }
    }
}
