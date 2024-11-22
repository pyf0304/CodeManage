<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSqlViewFldB.ascx.cs" Inherits="AGC.Webform.wucSqlViewFldB" %>

<table id="tabwucSqlViewFld" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlViewId" runat="server" CssClass="col-form-label text-right">Sql��ͼId</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSqlViewId" runat="server" class="form-control-sm" AutoPostBack="True" OnSelectedIndexChanged="ddlSqlViewId_SelectedIndexChanged" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRelaTabId" runat="server" CssClass="col-form-label text-right">��ر�Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRelaTabId" runat="server" class="form-control-sm" OnSelectedIndexChanged="ddlRelaTabId_SelectedIndexChanged" AutoPostBack="True" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldID" runat="server" CssClass="col-form-label text-right">�ֶ�ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldID" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFieldAliases" runat="server" CssClass="col-form-label text-right">�ֶα���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFieldAliases" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFilters" runat="server" CssClass="col-form-label text-right">ɸѡ��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFilters" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="������������ֵ!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Rows="4" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
