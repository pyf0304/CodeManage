<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucCaseType.ascx.cs"
    Inherits="AGC.Webform.wucCaseType" %>
<table id="tabwucCaseType" cellspacing="0" cellpadding="0" width="304" border="0"
    style="width: 304px; height: 218px">
    <tr>
        <td>
            <asp:Label ID="lblCaseTypeId" runat="server">�������ͺ�</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCaseTypeId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCaseType" runat="server">������������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCaseType" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server">��ע</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server"
                Width="222px" Height="168px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
