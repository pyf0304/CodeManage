<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucCtlType.ascx.cs"
    Inherits="AGC.Webform.wucCtlTypeAbbr" %>
<table id="tabwucCtlTypeAbbr" cellspacing="1" cellpadding="1" width="376" border="0"
    style="width: 376px; height: 306px">
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server" >�ؼ�����ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlTypeId" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeName" runat="server" >��������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlTypeName" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlCnName" runat="server" >�ؼ���������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlCnName" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeAbbr" runat="server" >�ؼ�������д</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCtlTypeAbbr" runat="server" Width="280px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td valign="top">
            <asp:Label ID="lblMemo" runat="server" >��ע</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" Width="280px" Height="192px"></asp:TextBox>
        </td>
    </tr>
</table>
