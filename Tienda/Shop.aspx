<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Shop.aspx.cs" Inherits="Tienda.Shop" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <!-- Modal -->
    <div class="modal fade bg-white" id="templatemo_search" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
        <div class="modal-dialog modal-lg" role="document">
            <div class="w-100 pt-1 mb-5 text-right">
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <form action="" method="get" class="modal-content modal-body border-0 p-0">
                <div class="input-group mb-2">
                    <input type="text" class="form-control" id="inputModalSearch" name="q" placeholder="Search ...">
                    <button type="submit" class="input-group-text bg-success text-light">
                        <i class="fa fa-fw fa-search text-white"></i>
                    </button>
                </div>
            </form>
        </div>
    </div>



    <!-- Start Content -->
    <div class="container py-5">
        <div class="row">

            <div class="col-lg-3">
                <h1 class="h2 pb-4">Categories</h1>
                <ul class="list-unstyled templatemo-accordion">
                     <asp:Repeater ID="repiterCategoria" runat="server">
                        <ItemTemplate> 
                            <li class="pb-3">
                                   <butto onclick="actualizarCategoria('<%# Eval("nombre") %>')" class="collapsed d-flex justify-content-between h3 text-decoration-none" href="/Shop.aspx?categoria=<%# Eval("nombre") %>">
                                        <%# Eval("nombre") %>
                                   </butto>
                            </li>
                        </ItemTemplate>
                    </asp:Repeater>
                </ul>
            </div>

            <div class="col-lg-9">
                <div class="row">
                    <asp:Repeater ID="repiterItems" runat="server">
                        <ItemTemplate>
                            <div class="col-md-4">
                                <div class="card mb-4 product-wap rounded-0">
                                    <div class="card rounded-0">
                                        <img class="card-img rounded-0 img-fluid" src="<%# Eval("imagen_url") %>">
                                        <div class="card-img-overlay rounded-0 product-overlay d-flex align-items-center justify-content-center">
                                            <ul class="list-unstyled">
                                                <li><a class="btn btn-success text-white" href="shop-single.html"><i class="far fa-heart"></i></a></li>
                                                <li><a class="btn btn-success text-white mt-2" href="shop-single.html"><i class="far fa-eye"></i></a></li>
                                                <li><button 
                                                    onclick="addCart({
                                                        id: '<%# Eval("id") %>',
                                                        nombre: '<%# Eval("nombre") %>',
                                                        descripcion: '<%# Eval("descripcion") %>',
                                                        precio: '<%# Eval("precio") %>',
                                                        stock: '<%# Eval("stock") %>',
                                                        imagen_url:  '<%# Eval("imagen_url") %>'
                                                    })"
                                                    class="btn btn-success text-white mt-2"><i class="fas fa-cart-plus"></i></button></li>
                                            </ul>
                                        </div>
                                    </div>
                                    <div class="card-body">
                                        <a href="shop-single.html" class="h3 text-decoration-none"> <%# Eval("nombre") %></a>
                                        <ul class="w-100 list-unstyled d-flex justify-content-between mb-0">
                                            <li>Stock: <%# Eval("stock") %></li>
                                            <li class="pt-2">
                                                <span class="product-color-dot color-dot-red float-left rounded-circle ml-1"></span>
                                                <span class="product-color-dot color-dot-blue float-left rounded-circle ml-1"></span>
                                                <span class="product-color-dot color-dot-black float-left rounded-circle ml-1"></span>
                                                <span class="product-color-dot color-dot-light float-left rounded-circle ml-1"></span>
                                                <span class="product-color-dot color-dot-green float-left rounded-circle ml-1"></span>
                                            </li>
                                        </ul>
                                        <ul class="list-unstyled d-flex justify-content-center mb-1">
                                            <li>
                                                <i class="text-warning fa fa-star"></i>
                                                <i class="text-warning fa fa-star"></i>
                                                <i class="text-warning fa fa-star"></i>
                                                <i class="text-warning fa fa-star"></i>
                                                <i class="text-muted fa fa-star"></i>
                                            </li>
                                        </ul>
                                        <p class="text-center mb-0"><%# Eval("precio") %></p>
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
            </div>

        </div>
    </div>
    <!-- End Content -->
        <script type="text/javascript">
            // Detectar el cambio en la URL y forzar una recarga completa
            function actualizarCategoria(categoria) {
                window.location.href = `Shop.aspx?categoria=${categoria}`;
            }

            const addCart = (item) => {
                // Obtener el carrito actual desde localStorage o inicializarlo vacío si no existe
                let carrito = JSON.parse(localStorage.getItem('carrito')) || [];

                // Buscar si el ítem ya existe en el carrito
                const index = carrito.findIndex(producto => producto.id === item.id);

                if (index !== -1) {
                    // Si el ítem ya existe, incrementar la cantidad
                    carrito[index].cantidad += 1;
                } else {
                    // Si no existe, agregar el nuevo ítem con cantidad inicial 1
                    carrito.push({
                        ...item,
                        cantidad: 1
                    });
                }

                // Guardar el carrito actualizado en localStorage
                localStorage.setItem('carrito', JSON.stringify(carrito));
                actualizarContadorCarrito()
            }
        </script>
</asp:Content>
