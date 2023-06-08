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
    
    <div class="actionBar">
        <asp:Button runat="server" ID="goToCheckOut" Text="CheckOut" class="CheckOut-button" OnClick="GoToCheckOut"/>
        <div class="totalOrder">
            <img src="./Content/cart.png" alt="Icon cart" style="height: 35px">
            <asp:Label runat="server" ID="totalCart">0</asp:Label>
        </div>
        
    </div>

</asp:Content>
