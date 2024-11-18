<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Tienda.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Security CORP</title>
    <style>
        .product-grid {
            display: flex;
            flex-wrap: wrap;
            gap: 20px;
            justify-content: center;
        }
        .product-item {
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 10px;
            width: 200px;
            text-align: center;
            box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
        }
        .product-item img {
            width: 100%;
            height: auto;
            border-radius: 4px;
        }
        .product-item h3 {
            font-size: 18px;
            margin: 10px 0;
        }
        .product-item p {
            margin: 5px 0;
            font-size: 14px;
        }
        .product-item .price {
            font-weight: bold;
            color: #28a745;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
       <div class="product-grid">
            <asp:Repeater ID="RepeaterProductos" runat="server">
                <ItemTemplate>
                    <div class="product-item">
                        <img src='<%# Eval("imagen_url") %>' alt='<%# Eval("nombre") %>' />
                        <h3><%# Eval("nombre") %></h3>
                        <p class="price">S/ <%# Eval("precio") %></p>
                        <p>Stock: <%# Eval("stock") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
