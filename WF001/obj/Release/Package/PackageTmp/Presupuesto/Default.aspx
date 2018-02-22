<%@ Page Title="" Language="C#" MasterPageFile="~/Site_2n.master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WF001.Presupuesto.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Presupuesto</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    <h4 class="">Presupuesto</h4>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="form" runat="server">
    <form id="form1" runat="server">
        <div class="row">
            <div class="input-field col s6 m2 l2">
                <input id="bukrs" type="text" class="validate" value="KCMX" />
                <label for="bukrs">Company Code</label>
            </div>
            <div class="input-field col s6 m3 l3">
                <select id="waers">
                    <option value="1">MXN</option>
                    <option value="2">USD</option>
                    <option value="3">EUR</option>
                </select>
                <label>Moneda</label>
            </div>
            <script>
                var elem = document.getElementById('waers');
                var options = [];
                var instance = M.Select.init(elem, options);
            </script>
        </div>
        <div class="row">
            <div class="col s12">
                <table class="striped">
                    <thead>
                        <tr>
                            <th>Cuenta</th>
                            <th>Presupuesto</th>
                            <th>Consumido</th>
                            <th>Disponible</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td>4100126</td>
                            <td>$ 120,000.00</td>
                            <td>$ 100,000.00</td>
                            <td>$ 2,000.00</td>
                        </tr>
                        <tr>
                            <td>410076</td>
                            <td>$ 120,000.00</td>
                            <td>$ 100,000.00</td>
                            <td>$ 2,000.00</td>
                        </tr>
                        <tr>
                            <td>4100112</td>
                            <td>$ 120,000.00</td>
                            <td>$ 100,000.00</td>
                            <td>$ 2,000.00</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </form>
</asp:Content>
