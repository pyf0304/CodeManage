<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucElecDict.ascx.cs"
    Inherits="AGC.Webform.wucElecDict" %>
<table id="tabwucElecDict" cellspacing="1" cellpadding="1" width="304" border="0"
    style="width: 304px; height: 253px">
    <tr>
        <td>
            <asp:Label ID="lblWordTypeId" runat="server" >���ʷ���</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlWordTypeId" runat="server" 
                Width="160px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblEnglishWord" runat="server" >Ӣ�ĵ���</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEnglishWord" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblChineseWord" runat="server" >���ĵ���</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtChineseWord" runat="server" ></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="236px" TextMode="MultiLine" Height="168px"></asp:TextBox>
        </td>
    </tr>
</table>
