<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucUserDefaValue.ascx.cs"
    Inherits="AGC.Webform.wucUserDefaValue" %>
<table id="tabwucUserDefaValue" cellspacing="1" cellpadding="1" width="352" border="0"
    style="width: 352px; height: 109px">
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server">�û���</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server" ReadOnly="True"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDefaValNameId" runat="server">ȱʡֵ���</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlDefaValNameId" runat="server" Width="160px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblUserDefaValue" runat="server">�û�����ȱʡֵ</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtUserDefaValue" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server">˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server"
                Width="240px" Height="152px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
