<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Carrito.aspx.cs" Inherits="Tienda.Carrito" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Carrito</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <h1 class="text-center mb-4">Carrito de Compras</h1>
        <div id="carritoContainer" class="row">
            <!-- Aquí se cargará el contenido del carrito -->
        </div>
        <div class="text-center mt-4 mb-4">
            <button id="vaciarCarrito" class="btn btn-danger" onclick="vaciarCarrito()">Vaciar Carrito</button>
            <button id="irAPagar" class="btn btn-primary ms-3" onclick="irAPagar()">Ir a Pagar</button>
        </div>
    </div>

    <!-- Bootstrap JS Bundle -->
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha3/dist/js/bootstrap.bundle.min.js"></script>
    <script type="text/javascript">
        let carrito = JSON.parse(localStorage.getItem('carrito')) || []; // Recuperar carrito desde localStorage

        const mostrarCarrito = () => {
            const carritoContainer = document.getElementById('carritoContainer');
            carritoContainer.innerHTML = ''; // Limpiar contenido previo

            if (carrito.length > 0) {
                carrito.forEach((item, index) => {
                    const itemElement = document.createElement('div');
                    itemElement.className = "col-12 mb-3"; // Mostrar en lista
                    itemElement.innerHTML = `
                        <div class="d-flex align-items-center justify-content-between border p-3">
                            <div class="d-flex align-items-center">
                                <img src="${item.imagen_url}" alt="${item.nombre}" style="width: 80px; height: 80px; object-fit: cover; margin-right: 20px;">
                                <div>
                                    <h5>${item.nombre}</h5>
                                    <p><strong>Precio:</strong> S/${item.precio}</p>
                                    <p><strong>Stock:</strong> ${item.stock}</p>
                                </div>
                            </div>
                            <div class="d-flex align-items-center">
                                <button class="btn btn-outline-secondary me-2" onclick="disminuirCantidad(${index})">-</button>
                                <span>${item.cantidad}</span>
                                <button class="btn btn-outline-secondary ms-2" onclick="aumentarCantidad(${index})">+</button>
                            </div>
                            <button class="btn btn-danger ms-3" onclick="eliminarItem(${index})">Eliminar</button>
                        </div>
                    `;
                    carritoContainer.appendChild(itemElement);
                });
            } else {
                carritoContainer.innerHTML = `
                    <div class="col-12">
                        <div class="alert alert-warning text-center" role="alert">
                            No hay productos en el carrito.
                        </div>
                    </div>
                `;
            }
        };

        const aumentarCantidad = (index) => {
            if (carrito[index].cantidad < carrito[index].stock) {
                carrito[index].cantidad += 1; // Incrementar cantidad
                localStorage.setItem('carrito', JSON.stringify(carrito)); // Actualizar localStorage
                mostrarCarrito(); // Refrescar la vista
                actualizarContadorCarrito();
            } else {
                alert("No hay más stock disponible.");
            }
        };

        const disminuirCantidad = (index) => {
            if (carrito[index].cantidad > 1) {
                carrito[index].cantidad -= 1; // Reducir cantidad
                localStorage.setItem('carrito', JSON.stringify(carrito)); // Actualizar localStorage
                mostrarCarrito(); // Refrescar la vista
                actualizarContadorCarrito();
            }
        };

        const eliminarItem = (index) => {
            carrito.splice(index, 1); // Eliminar el producto según el índice
            localStorage.setItem('carrito', JSON.stringify(carrito)); // Actualizar localStorage
            mostrarCarrito(); // Refrescar la vista
            actualizarContadorCarrito();
        };

        const vaciarCarrito = () => {
            localStorage.removeItem('carrito'); // Eliminar carrito del localStorage
            carrito = []; // Reiniciar carrito en memoria
            mostrarCarrito(); // Refrescar la vista
            actualizarContadorCarrito();
        };

        const irAPagar = () => {
            if (carrito.length > 0) {
                // Lógica para redirigir a la página de pago
                window.location.href = "/Seguro/Pago.aspx";
            } else {
                alert("El carrito está vacío.");
            }
        };

        // Llamar la función para mostrar el carrito cuando se carga la página
        mostrarCarrito();
    </script>
</asp:Content>
