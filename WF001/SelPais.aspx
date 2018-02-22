<%@ Page Title="" Language="C#" MasterPageFile="~/Site_1n.master" AutoEventWireup="true" CodeBehind="SelPais.aspx.cs" Inherits="WF001.SelPais" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Seleccionar país</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="title" runat="server">
    <h4>Seleccionar país</h4>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="form" runat="server">
    <form runat="server">
        <div class="row">
            <div class="col s12 m6 l4">
                <div class="row">
                </div>
            </div>
            <div class=" col s12 m6 l8">
                <div class="row">
                    <div class="col s12 m6 l4">
                        <asp:ImageButton ID="mx" runat="server" ImageUrl="images/flags/1x1/mx.svg" CssClass="circle" Height="100px" Width="100px" OnClick="mx_Click" />
                    </div>
                    <div class="col s12 m6 l4">
                        <asp:ImageButton ID="pr" runat="server" ImageUrl="images/flags/1x1/pr.svg" CssClass="circle" Height="100px" Width="100px" OnClick="mx_Click" />
                    </div>
                    <div class="col s12 m6 l4">
                        <asp:ImageButton ID="ec" runat="server" ImageUrl="images/flags/1x1/ec.svg" CssClass="circle" Height="100px" Width="100px" OnClick="mx_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
