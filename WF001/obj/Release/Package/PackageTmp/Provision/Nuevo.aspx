<%@ Page Title="" Language="C#" MasterPageFile="~/Site_2n.Master" AutoEventWireup="true" CodeBehind="Nuevo.aspx.cs" Inherits="WF001.Provision.Nuevo1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Crear Provisión</title>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="title" runat="server">
    <h4 class="">Crear Provisión</h4>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="form" runat="server">
    <form id="form1" runat="server" action="~/Models/post.asmx/Post" method="post">
        <div class="row" style="margin-bottom: 0;">
            <div class="input-field col s6 m2 l2">
                <input id="user" type="text" class="disabled black-text" value="mxklic01" disabled="disabled" runat="server" />
                <label for="user">Usuario</label>
            </div>
            <div class="input-field col s6 m2 l2">
                <input id="manager" type="text" class="disabled black-text" value="mxkpgt01" disabled="disabled" runat="server" />
                <label for="manager">Manager</label>
            </div>
            <div class="input-field col s6 m2 l2">
                <input id="backup" type="text" class="disabled black-text" value="mxkback01" disabled="disabled" runat="server" />
                <label for="backup">Backup</label>
            </div>
            <div class="input-field col s6 m2 l2">
                <input id="bu" type="text" class="disabled black-text" value="PRGA" disabled="disabled" runat="server" />
                <label for="bu">BU</label>
            </div>
            <div class="col s12 m4 l4 right">
                <input type="button" class="btn-small" value="Cancelar" runat="server" style="margin-top: 1.5rem;" />
                <input type="button" class="btn-small" value="Borrador" runat="server" style="margin-top: 1.5rem;" />
                <input type="button" class="btn-small" value="Guardar" runat="server" style="margin-top: 1.5rem;" />
            </div>
        </div>
        <div class="divider pink darken-1"></div>
        <div class="row">
            <div class="col s12 m6 l6">
                <div class="card-panel hoverable">
                    <div class="row">
                        <div class="input-field col s6 m6 l6">
                            <input id="fecha" type="text" class="validate" value="28/02/2018" />
                            <label for="fecha">Fecha</label>
                        </div>
                        <div class="input-field col s3 m3 l3">
                            <input id="mes" type="text" class="validate" value="02" disabled="disabled" />
                            <label for="mes">Mes</label>
                        </div>
                        <div class="input-field col s3 m3 l3">
                            <input id="anio" type="text" class="validate" value="2018" disabled="disabled" />
                            <label for="anio">Año</label>
                        </div>
                        <div class="input-field col s12 m12 l12">
                            <input id="cliente" type="text" class="validate" value="43000 BERMUDA GENERAL AGENCIES GR OF" />
                            <label for="cliente">Cliente</label>
                        </div>
                        <div class="input-field col s12 m6 l6">
                            <input id="canal" type="text" class="validate" value="PRI1PB Canal Puerto Rico Plaza 1" disabled="disabled" />
                            <label for="canal">Canal</label>
                        </div>
                        <div class="input-field col s6 m12 l6 offset-m6">
                            <input id="cta" type="text" class="validate" value="999999999999 Cuenta pasivo" disabled="disabled" />
                            <label for="cta">Cuenta pasivo</label>
                        </div>
                        <div class="input-field col s12 m6 l6 offset-m6">
                            <input id="cta_pl" type="text" class="validate" value="1111111111111 Cuenta P & L" disabled="disabled" />
                            <label for="cta_pl">Cuenta P&L</label>
                        </div>
                        <div class="input-field col s12">
                            <textarea id="textarea1" class="materialize-textarea"></textarea>
                            <label for="textarea1">Comentarios</label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col s12 m6 l6">
                <div class="card-panel hoverable">
                    <div class="row">
                        <div class="input-field col  s12 m6 l6">
                            <input id="presup" type="text" class="disabled" value="2000012" disabled="disabled" />
                            <label for="presup">Presupuesto</label>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</asp:Content>
