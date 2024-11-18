using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }

        }

        private void CargarProductos()
        {
            using (DBEcommerceEntities ecommerce = new DBEcommerceEntities())
            {
                var productos = (from P in ecommerce.Productos
                                 select new
                                 {
                                     P.nombre,
                                     P.precio,
                                     P.stock,
                                     P.imagen_url
                                 }).ToList();

                RepeaterProductos.DataSource = productos;
                RepeaterProductos.DataBind();
            }
        }

    }
}