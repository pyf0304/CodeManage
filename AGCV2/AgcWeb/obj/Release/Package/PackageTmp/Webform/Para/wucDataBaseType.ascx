<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDataBaseType.ascx.cs"
    Inherits="AGC.Webform.wucDataBaseType" %>


<table id="tabwucDataBaseType" cellspacing="1" cellpadding="1" width="720" border="0"
    style="width: 720px; height: 172px">
    <tr>
        <td class="NameTD" style="width: 88px">
            <asp:Label ID="lblDataBaseTypeId" runat="server" 
                CssClass="col-form-label text-right">���ݿ�����ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseTypeId" runat="server" 
                class="form-control-sm" Width="248px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 88px">
            <asp:Label ID="lblDataBaseTypeName" runat="server" 
                CssClass="col-form-label text-right">���ݿ�������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseTypeName" runat="server" 
                class="form-control-sm" Width="248px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 88px">
            <asp:Label ID="lblMemo" runat="server"  CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" 
                class="form-control-sm" Height="112px" TextMode="MultiLine" Width="248px"></asp:TextBox>
        </td>
    </tr>
</table>
