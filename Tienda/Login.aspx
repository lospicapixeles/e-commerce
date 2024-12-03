<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Tienda.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Login</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="formLogin" runat="server" class="container mt-5 mb-5">
        <div class="row justify-content-center">
            <div class="col-md-4">
                <div class="card shadow">
                    <div class="card-body">
                        <h2 class="text-center mb-4">Iniciar Sesión</h2>

                        <asp:Label ID="lblError" runat="server" CssClass="text-danger d-block text-center mb-3" Visible="false"></asp:Label>

                        <div class="form-group mb-3">
                            <asp:Label ID="lblUsername" runat="server" Text="Usuario:" CssClass="form-label"></asp:Label>
                            <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="form-group mb-4">
                            <asp:Label ID="lblPassword" runat="server" Text="Contraseña:" CssClass="form-label"></asp:Label>
                            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                        </div>

                        <div class="d-grid">
                            <asp:Button ID="btnLogin" runat="server" Text="Ingresar" CssClass="btn btn-primary" OnClick="btnLogin_Click" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>

