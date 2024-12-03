<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Pago.aspx.cs" Inherits="Tienda.Seguro.Pago" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <h2 class="text-center">Formulario de Pago</h2>
        <form id="formPago" runat="server">
            <asp:HiddenField ID="hfCarrito" runat="server" />
            <!-- Tabla con productos del carrito -->
            <table class="table table-bordered table-striped">
                <thead>
                    <tr>
                        <th>Imagen</th>
                        <th>Producto</th>
                        <th>Precio Unitario</th>
                        <th>Cantidad</th>
                        <th>Total</th>
                    </tr>
                </thead>
                <tbody id="itemsCarrito">
                    <!-- Aquí se llenarán los productos -->
                </tbody>
            </table>

            <!-- Subtotal -->
            <div class="row mb-3">
                <div class="col-md-6 offset-md-6 text-end">
                    <h4>Subtotal: <span id="subtotal">S/. 0.00</span></h4>
                </div>
            </div>

            <!-- Total -->
            <div class="row mb-3">
                <div class="col-md-6 offset-md-6 text-end">
                    <h4>Total (con IGV): <span id="total">S./ 0.00</span></h4>
                </div>
            </div>

            <!-- Datos de tarjeta -->
            <div class="row mb-3">
                <!-- Número de tarjeta -->
                <div class="col-md-6">
                    <asp:Label ID="lblTarjetaNumero" runat="server" Text="Número de tarjeta" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtTarjetaNumero" runat="server" CssClass="form-control" Placeholder="1111 2222 3333 4444" MaxLength="19" required="true"></asp:TextBox>
                </div>

                <!-- Fecha de expiración (mes y año separados) -->
                <div class="col-md-3">
                    <asp:Label ID="lblFechaExpiracion" runat="server" Text="Mes de expiración" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlMesExpiracion" runat="server" CssClass="form-control" required="true">
                        <asp:ListItem Value="01">Enero</asp:ListItem>
                        <asp:ListItem Value="02">Febrero</asp:ListItem>
                        <asp:ListItem Value="03">Marzo</asp:ListItem>
                        <asp:ListItem Value="04">Abril</asp:ListItem>
                        <asp:ListItem Value="05">Mayo</asp:ListItem>
                        <asp:ListItem Value="06">Junio</asp:ListItem>
                        <asp:ListItem Value="07">Julio</asp:ListItem>
                        <asp:ListItem Value="08">Agosto</asp:ListItem>
                        <asp:ListItem Value="09">Septiembre</asp:ListItem>
                        <asp:ListItem Value="10">Octubre</asp:ListItem>
                        <asp:ListItem Value="11">Noviembre</asp:ListItem>
                        <asp:ListItem Value="12">Diciembre</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <asp:Label ID="lblAnioExpiracion" runat="server" Text="Año de expiración" CssClass="form-label"></asp:Label>
                    <asp:DropDownList ID="ddlAnioExpiracion" runat="server" CssClass="form-control" required="true">
                        <asp:ListItem Value="24">2024</asp:ListItem>
                        <asp:ListItem Value="25">2025</asp:ListItem>
                        <asp:ListItem Value="26">2026</asp:ListItem>
                        <asp:ListItem Value="27">2027</asp:ListItem>
                        <asp:ListItem Value="28">2028</asp:ListItem>
                        <asp:ListItem Value="29">2029</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <!-- CVV -->
            <div class="row mb-3">
                <div class="col-md-3">
                    <asp:Label ID="lblCVV" runat="server" Text="CVV" CssClass="form-label"></asp:Label>
                    <asp:TextBox ID="txtCVV" runat="server" CssClass="form-control" Placeholder="123" MaxLength="3" required="true"></asp:TextBox>
                </div>
            </div>
            <asp:HiddenField ID="hfTotal" runat="server" />
            <asp:Label ID="lblError" runat="server" CssClass="text-danger" Visible="false"></asp:Label>

            <!-- Botón de pago -->
            <div class="row mb-3">
                <div class="col-md-6 offset-md-6 text-end">
                    <asp:Button Text="Pagar" runat="server" id="btnPagar" OnClick="btnPagar_Click"/>
                </div>
            </div>
        </form>
    </div>
    <script type="text/javascript">
        // Función para cargar los productos desde el localStorage y calcular el subtotal
        function cargarCarrito() {

            const carrito = JSON.parse(localStorage.getItem('carrito')) || [];
            document.getElementById('<%= hfCarrito.ClientID %>').value = JSON.stringify(carrito);

            let subtotal = 0;
            let itemsHtml = '';

            carrito.forEach(producto => {
                let precio = parseFloat(producto.precio);
                let cantidad = producto.cantidad;
                let totalProducto = precio * cantidad;
                subtotal += totalProducto;

                itemsHtml += `
                    <tr>
                        <td><img src="${producto.imagen_url}" alt="${producto.nombre}" width="50"></td>
                        <td>${producto.nombre}</td>
                        <td>S/. ${precio.toFixed(2)}</td>
                        <td>${cantidad}</td>
                        <td>S/. ${totalProducto.toFixed(2)}</td>
                    </tr>
                `;
            });

            // Mostrar los productos en la tabla
            document.getElementById('itemsCarrito').innerHTML = itemsHtml;
            // Mostrar el subtotal
            document.getElementById('subtotal').textContent = `S/. ${subtotal.toFixed(2)}`;
            // Calcular el total (con IGV por ejemplo)
            const iva = subtotal * 0.18;
            const total = subtotal + iva;
            document.getElementById('total').textContent = `S/. ${total.toFixed(2)}`

            // Pasar el valor del total al HiddenField
            document.getElementById('<%= hfTotal.ClientID %>').value = total.toFixed(2);
        }

        // Función para manejar el envío del formulario de pago
        function procesarPago(event) {
            event.preventDefault();
            alert("Pago procesado con éxito.");
            // Aquí podrías integrar una API de pago o manejar el pago de manera más compleja
        }

        cargarCarrito();
    </script>
</asp:Content>
