<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSV_RelaTabTypeB.ascx.cs" Inherits="AGC.Webform.wucSV_RelaTabTypeB" %>

<table id="tabwucSV_RelaTabType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSvRelaTabTypeId" runat="server" CssClass="col-form-label text-right" Width="140px">Sql��ͼ��ر�����Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSvRelaTabTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSvRelaTabTypeName" runat="server" CssClass="col-form-label text-right">Sql��ͼ��ر�������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSvRelaTabTypeName" runat="server" class="form-control-sm"></asp:TextBox>
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
