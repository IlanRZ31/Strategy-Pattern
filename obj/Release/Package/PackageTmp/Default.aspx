<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StrategyPattern._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div>
        <asp:GridView runat="server" ID="gvProduct" AutoGenerateColumns="True"></asp:GridView>
    </div>
    
    <div class="box-container">

        <asp:Repeater runat="server" ID="rpProducts">
            <ItemTemplate>
                <div class="box">
                    <img src="<%# Eval("ImgUrl") %>" alt="Producto img" />
                    <div class="product-details">
                        <span><%# Eval("name") %></span>
                        <span class="price">$<%# Eval("price") %></span>
                    </div>
                    
                    <asp:Button runat="server" class="add" OnClick="AddToCart" Text="Add to cart" CommandArgument='<%# Eval("price") %>'/>
                </div>
            </ItemTemplate>
        </asp:Repeater>
        </div>

    <%--<div class="checkout-container">
        <div class="checkout">
            <h1 class="display-4 m-3 text-center">Checkout</h1>
    
            <% using (Html.BeginForm("Index", "Home", FormMethod.Post)) { %>
                <input type="hidden" id="OrderTotal" name="OrderTotal" value="<%= Model.OrderTotal %>" />
                <%= Html.HiddenFor(x => x.OrderTotal) %>
    
                <table cellpadding="0" cellspacing="0" class="table">
                    <tr>
                        <th>Order Total:</th>
                        <td class="total">$<%= Model.OrderTotal %></td>
                    </tr>
                    <tr>
                        <th>Shipping Method:</th>
                        <td>
                            <%= Html.DropDownListFor(x => x.SelectedMethod,
                                new SelectList(Model.ShippingMethods, "Id", "Name"),
                                "- Select -",
                                new { @class = "form-control" }) %>
                        </td>
                    </tr>
    
                    <tr class="button-container">
                        <td>
                            <input class="btn" type="submit" value="Calculate" />
                        </td>
                    </tr>
                    <% if (Model.FinalTotal > 0) { %>
                        <tr>
                            <th>Final Total:</th>
                            <td>$<%= Model.FinalTotal %></td>
                        </tr>
                    <% } %>
                </table>
            <% } %>
        </div>
    </div>--%>
    
    <div class="actionBar">
        <asp:Button runat="server" ID="goToCheckOut" Text="CheckOut" class="CheckOut-button" OnClick="GoToCheckOut"/>
        <div class="totalOrder">
            <span>i</span>
            <asp:Label runat="server" ID="totalCart">0</asp:Label>
        </div>
        
    </div>

</asp:Content>
