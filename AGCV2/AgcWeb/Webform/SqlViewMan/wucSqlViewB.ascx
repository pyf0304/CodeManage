<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucSqlViewB.ascx.cs" Inherits="AGC.Webform.wucSqlViewB" %>

<table id="tabwucSqlView" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlViewId" runat="server" CssClass="col-form-label text-right">Sql��ͼId</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlViewId" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
        <td></td>
        <td></td>
    </tr>
    
    <tr>
        <td class="NameTD">
            &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlViewText" runat="server" CssClass="col-form-label text-right">Sql��ͼ�ı�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlViewText" runat="server" class="form-control-sm" Width="400px" Rows="20" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTextResouce" runat="server" CssClass="col-form-label text-right">�ı���Դ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTextResouce" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTextResourceTypeId" runat="server" CssClass="col-form-label text-right">�ı���Դ����Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlTextResourceTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
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
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="60px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
