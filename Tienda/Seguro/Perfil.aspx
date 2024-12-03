<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Perfil.aspx.cs" Inherits="Tienda.Seguro.Perfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formPerfil" runat="server">
        <div class="container mt-5 mb-5">
            <div class="row justify-content-center">
                <div class="col-md-6">
                    <div class="card shadow-sm">
                        <div class="card-header bg-primary text-white text-center">
                            <h3>Perfil del Usuario</h3>
                        </div>
                        <div class="card-body">
                            <div class="mb-3">
                                <label for="lblUserId" class="form-label">ID Cliente</label>
                                <asp:Label ID="lblUserId" runat="server" CssClass="form-control" />
                            </div>
                            <div class="mb-3">
                                <label for="lblUsername" class="form-label">Usuario</label>
                                <asp:Label ID="lblUsername" runat="server" CssClass="form-control" />
                            </div>
                            <div class="mb-3">
                                <label for="lblEmail" class="form-label">Email</label>
                                <asp:Label ID="lblEmail" runat="server" CssClass="form-control" />
                            </div>
                            <div class="mb-3">
                                <label for="lblRole" class="form-label">Rol</label>
                                <asp:Label ID="lblRole" runat="server" CssClass="form-control" />
                            </div>
                            <div class="mb-3">
                                <label for="lblRegistrationDate" class="form-label">Fecha de Registro</label>
                                <asp:Label ID="lblRegistrationDate" runat="server" CssClass="form-control" />
                            </div>
                        </div>
                        <div class="card-footer text-center">
                            <asp:Button ID="btnLogout" runat="server" CssClass="btn btn-danger btn-sm" Text="Cerrar Sesión" OnClick="btnLogout_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
            <!-- Mostrar los productos en el Repeater -->
            <div class="container my-5">
                <h1>Mis pedidos</h1>
                <asp:Repeater ID="rptPedidos" runat="server">
                    <ItemTemplate>
                        <div class="card mb-3">
                            <div class="row no-gutters">
                                <div class="col-md-4">
                                    <img src='<%# Eval("imagen_url") %>' class="card-img" alt="Imagen Producto" />
                                </div>
                                <div class="col-md-8">
                                    <div class="card-body">
                                        <h5 class="card-title"><%# Eval("nombre") %></h5>
                                        <p class="card-text">Precio Unitario: $<%# Eval("precio") %></p>
                                        <p class="card-text">Cantidad: <%# Eval("cantidad") %></p>
                                        <p class="card-text">Total: $<%# Eval("total") %></p>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
    </form>
    
</asp:Content>
