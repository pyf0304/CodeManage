<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSqlViewRelaTabB.ascx.cs" Inherits="AGC.Webform.wucSqlViewRelaTabB" %>

<table id="tabwucSqlViewRelaTab" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlViewId" runat="server" CssClass="col-form-label text-right">Sql��ͼId</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSqlViewId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblRelaTabId" runat="server" CssClass="col-form-label text-right">��ر�Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlRelaTabId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabAliases" runat="server" CssClass="col-form-label text-right">�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabAliases" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSvRelaTabTypeId" runat="server" CssClass="col-form-label text-right" Width="120px">Sql��ͼ��ر�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSvRelaTabTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabRelationTypeId" runat="server" CssClass="col-form-label text-right">���ϵ����Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTabRelationTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTabRelationText" runat="server" CssClass="col-form-label text-right">���ϵ�ı�</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTabRelationText" runat="server" class="form-control-sm" Rows="4" TextMode="MultiLine" Width="400px"></asp:TextBox>
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
