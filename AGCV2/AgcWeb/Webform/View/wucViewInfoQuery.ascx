<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewInfoQuery.ascx.cs"
    Inherits="AGC.Webform.wucViewInfoQuery" %>

<table id="tabQuery" style="width: 560px; height: 65px" bordercolor="#666666" cellspacing="1"
    cellpadding="1" width="560" border="4">
    <tr>
        <td>
            <asp:Label ID="lblViewNameq" Width="56px" 
                runat="server" CssClass="text-secondary">��������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtViewName" Width="112px" 
                runat="server"></asp:TextBox></td>
        <td style="width: 62px">
            <asp:Label ID="Label2" runat="server" CssClass="text-secondary">Ӧ������</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlApplicationTypeId_SelectedIndexChanged"
                Width="167px">
            </asp:DropDownList></td>
        <td>
            <asp:Label ID="Label1" Width="56px" 
                runat="server" CssClass="text-secondary">����ģ��</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlFuncModuleId" Width="104px"  runat="server">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMainTabNameq" Width="56px" 
                 runat="server" CssClass="text-secondary">�������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtMainTabName" Width="112px" 
                 runat="server"></asp:TextBox></td>

        <td>
            <asp:Label ID="lblDetailTabNameq" Width="56px" 
                 runat="server" CssClass="text-secondary">��ϸ����</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDetailTabName" Width="104px" 
                 runat="server"></asp:TextBox></td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td style="width: 61px">
            <asp:Label ID="lblUserIdq"  
                runat="server">�û�ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUserId" Width="49px" 
                runat="server"></asp:TextBox></td>
        <td>
            <asp:Label ID="lblPrjIdq"  
                runat="server">����ID</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPrjId" Width="112px" 
                 runat="server">
            </asp:DropDownList></td>
    </tr>
</table>
