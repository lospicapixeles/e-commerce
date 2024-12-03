using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Tienda
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //CargarProductos();
                CargarCatergorias();
            }
        }

        private void CargarCatergorias()
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