<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucPrjProcess.ascx.cs"
    Inherits="AGC.Webform.wucPrjProcess" %>
<table id="tabwucPrjProcess" cellspacing="1" cellpadding="1" width="368" border="0"
    style="width: 368px; height: 107px">
    <tr>
        <td>
            <asp:Label ID="lblPrjProcessId" runat="server" >��Ŀ����ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjProcessId" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjProcessName" runat="server" >��Ŀ��������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtPrjProcessName" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjProcessTypeId" runat="server" >��Ŀ���̷���ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjProcessTypeId" runat="server" 
                Width="158px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="241px" Height="152px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
