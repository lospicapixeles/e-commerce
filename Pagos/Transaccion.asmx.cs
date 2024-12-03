using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Pagos
{
    /// <summary>
    /// Descripción breve de Transaccion
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Transaccion : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
   

        [WebMethod(Description = "Pagos seguros")]
        public string PagoSeguro(string nro, string fecha, string ccv, decimal monto)
        {
            try
            {
                // Instancia del contexto de la base de datos
                using (var tarjetaContext = new BDTarjetaEntities())
                {
                    // Buscar la tarjeta que coincida con los datos proporcionados
                    var tarjeta = tarjetaContext.Tarjeta.FirstOrDefault(t =>
                        t.nro_tarjeta == nro &&
                        t.fecha == fecha &&
                        t.ccv == ccv);

                    // Validar si la tarjeta fue encontrada
                    if (tarjeta == null)
                    {
                        return "Error: Tarjeta no encontrada o datos incorrectos.";
                    }

                    // Validar si el saldo es suficiente
                    if (tarjeta.saldo < monto)
                    {
                        return "Error: Saldo insuficiente.";
                    }

                    // Restar el monto del saldo
                    tarjeta.saldo -= monto;

                    // Guardar los cambios en la base de datos
                    tarjetaContext.SaveChanges();

                    return "Success: El pago fue realizado correctamente.";
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return $"Error: {ex.Message}";
            }
        }

    }
}
