<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewBtnOptSteps.ascx.cs"
    Inherits="AGC.Webform.wucViewBtnOptSteps" %>

<table id="tabwucViewBtnOptSteps" cellspacing="0" cellpadding="0" border="0"
    style="width: 706px; height: 227px">
    <tr>
        <td>
            <asp:Label ID="lblBtnName" runat="server" CssClass="text-secondary">��ť����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBtnName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblBtnOptFunction" runat="server" CssClass="text-secondary">��ť��������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBtnOptFunction" runat="server" Width="594px" 
                 Height="107px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblBtnStepDetail" runat="server" CssClass="text-secondary">��ť������ϸ˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtBtnStepDetail" runat="server" Width="594px" 
                 Height="140px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server" CssClass="text-secondary">����ID</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlViewId" runat="server" Width="152px" 
                >
            </asp:DropDownList></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
