<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucDataBaseModuleRelaB.ascx.cs" Inherits="AGC.Webform.wucDataBaseModuleRelaB" %>

<table id="tabwucDataBaseModuleRela" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">����ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjId" runat="server" class="form-control-sm" AutoPostBack="True" OnSelectedIndexChanged="ddlPrjId_SelectedIndexChanged" Width="400px"></asp:DropDownList>
        </td>
    
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrjDataBaseId" runat="server" CssClass="col-form-label text-right">��Ŀ���ݿ�Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjDataBaseId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
 
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFuncModuleId" runat="server" CssClass="col-form-label text-right">����ģ��Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFuncModuleId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
     
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsVisible" runat="server" Text="�Ƿ���ʾ" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
       
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Height="84px" TextMode="MultiLine" Width="400px"></asp:TextBox>
        </td>
     
    </tr>
</table>
