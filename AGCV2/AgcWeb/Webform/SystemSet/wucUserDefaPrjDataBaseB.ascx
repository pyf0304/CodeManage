<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucUserDefaPrjDataBaseB.ascx.cs" Inherits="AGC.Webform.wucUserDefaPrjDataBaseB" %>

<table id="tabwucUserDefaPrjDataBase" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">����ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">�û�ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUserId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjDataBaseId" runat="server" CssClass="col-form-label text-right">��Ŀ���ݿ�Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjDataBaseId" runat="server" class="form-control-sm"></asp:DropDownList>
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
