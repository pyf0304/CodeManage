<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjProcessType.ascx.cs"
    Inherits="AGC.Webform.wucPrjProcessType" %>
<table id="tabwucPrjProcessType" cellspacing="1" cellpadding="1" width="328" border="0"
    style="width: 328px; height: 236px">
    <tr>
        <td>
            <asp:Label ID="lblPrjProcessTypeId" runat="server" >���̷���ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjProcessTypeId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjProcessTypeName" runat="server" >���̷���</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjProcessTypeName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="251px" Height="176px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
