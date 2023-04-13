﻿<%@ Page Title="CheckOut" Language="C#" MasterPageFile="~/Site.Master" CodeBehind="CheckOut.aspx.cs" Inherits="StrategyPattern.CheckOut" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="checkout-container">
        <h2>Check Out</h2>
        <div class="details">
            <div class="details-item">
                <span>Product Cost</span>
                <asp:Label runat="server" class="r-detail">600</asp:Label>
            </div>
            
            <div class="details-item">
                <span>Payment</span>
                <span class="r-detail">Visa</span>
            </div>
            
            <div class="details-item">
                <span>Shipping Method</span>
                
                <asp:DropDownList ID="shipping" runat="server">
                    <asp:ListItem Value="free">Free Shipping ($0.00)</asp:ListItem>
                    <asp:ListItem Value="local">Local Shipping ($10.00)</asp:ListItem>
                    <asp:ListItem Value="world">Worldwide Shipping ($50.00)</asp:ListItem>
                </asp:DropDownList>
            </div>
            
            <asp:Button runat="server" Text="CheckOut" OnClick="checkOut"/>
            
            <div class="details-item total">
                <span>Total</span>
                <asp:Label runat="server" class="r-detail" ID="lblTotal">600</asp:Label>
            </div>
            
        </div>
    </div>
    
</asp:Content>