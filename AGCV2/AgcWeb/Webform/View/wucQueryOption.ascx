<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucQueryOption.ascx.cs"
    Inherits="AGC.Webform.wucQueryOption" %>
<table id="tabwucQueryOption" cellspacing="1" cellpadding="1" width="352" border="0"
    style="width: 352px; height: 244px">
    <tr>
        <td>
            <asp:Label ID="lblQueryOptionId" runat="server">�ؼ���ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtQueryOptionId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblQueryOption" runat="server">��������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtQueryOption" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server">��ע</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="288px" Height="184px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
