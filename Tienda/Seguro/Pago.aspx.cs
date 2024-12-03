using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Script.Serialization;
using System.Linq.Expressions;

namespace Tienda.Seguro
{
    public partial class Pago : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPagar_Click(object sender, EventArgs e)
        {

            ServiceReference1.TransaccionSoapClient servicio = new ServiceReference1.TransaccionSoapClient();

            string nro = txtTarjetaNumero.Text.Trim();
            string fecha = ddlMesExpiracion.SelectedValue + '/' + ddlAnioExpiracion.SelectedValue;
            string ccv = txtCVV.Text.Trim();

            // Obtener el total desde el HiddenField
            decimal total = Convert.ToDecimal(hfTotal.Value);


                // Llamar al servicio y obtener la respuesta
                string respuesta = servicio.PagoSeguro(nro, fecha, ccv, total);

                // Verificar la respuesta y redirigir o mostrar el error
                if (respuesta.Equals("Success: El pago fue realizado correctamente.", StringComparison.OrdinalIgnoreCase))
                {
                    
                    //descontar stock
                    using (DBEcommerceEntities ecommerce = new DBEcommerceEntities())
                    {
                        Pedidos pedidos = new Pedidos()
                        {
                            id_cliente = 1006,
                            fecha_pedido = DateTime.Now, //fecha actual,
                            estado = "Enviado",
                            total = total
                        };

                        ecommerce.Pedidos.Add(pedidos);
                        // Guardar cambios: se actualiza el stock y se agregan los detalles del pedido
                        ecommerce.SaveChanges();

                        //descontar stock y crear pedido detalle con el numero id de pedidos
                        // Deserializar el carrito
                        var carrito = new JavaScriptSerializer().Deserialize<List<ProductoCarrito>>(hfCarrito.Value);

                        // Crear los detalles del pedido
                        foreach (var producto in carrito)
                        {
                            // Crear el detalle del pedido
                            DetallesPedido detalle = new DetallesPedido()
                            {
                                id_pedido = pedidos.id, // El ID del pedido recién creado
                                id_producto = producto.id, // ID del producto
                                cantidad = Convert.ToInt16(producto.cantidad),
                                precio = Convert.ToDecimal(producto.precio),
                                subtotal = producto.cantidad * Convert.ToDecimal(producto.precio)
                            };

                            // Descontar el stock
                            var productoDB = ecommerce.Productos.FirstOrDefault(p => p.id == producto.id);
                            if (productoDB != null)
                            {
                                productoDB.stock -= producto.cantidad; // Descontar la cantidad comprada
                            }

                            ecommerce.DetallesPedido.Add(detalle);
                        }

                        Pagos pago = new Pagos()
                        {
                            id_pedido = pedidos.id,
                            id_metodo_pago = 1,
                            fecha_pago = DateTime.Now, //fecha actual,
                            monto = total
                        };

                        ecommerce.Pagos.Add(pago);

                        // Guardar cambios: se actualiza el stock y se agregan los detalles del pedido
                        ecommerce.SaveChanges();
                    }

                    Response.Redirect("~/Seguro/Success.aspx");
                }
                else
                {
                    // Mostrar el mensaje de error en la misma página
                    lblError.Text = "Hubo un problema con el pago: " + respuesta;
                    lblError.Visible = true;
                    // Manejar errores
                    //lblError.Text = hfCarrito.Value;
                    //lblError.Visible = true;
                }
            
        }
    }
}