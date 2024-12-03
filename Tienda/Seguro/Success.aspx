<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Success.aspx.cs" Inherits="Tienda.Seguro.Success" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container text-center mb-5 mt-5">
        <h1>Pago completado con exito 😎</h1>
    </div>
    <script type="text/javascript">
        const vaciarCarrito = () => {
            localStorage.removeItem('carrito'); // Eliminar carrito del localStorage
            carrito = []; // Reiniciar carrito en memoria
            mostrarCarrito(); // Refrescar la vista
            actualizarContadorCarrito();
        };

        vaciarCarrito();
    </script>
</asp:Content>
