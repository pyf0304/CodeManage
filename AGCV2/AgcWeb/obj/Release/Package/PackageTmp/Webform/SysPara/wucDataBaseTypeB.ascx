<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucDataBaseTypeB.ascx.cs" Inherits="AGC.Webform.wucDataBaseTypeB" %>

<table id="tabwucDataBaseType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseTypeId" runat="server" CssClass="col-form-label text-right">���ݿ�����ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDataBaseTypeName" runat="server" CssClass="col-form-label text-right">���ݿ�������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseTypeName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
