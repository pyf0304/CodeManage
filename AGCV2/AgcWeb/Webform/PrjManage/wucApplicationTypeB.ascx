<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucApplicationTypeB.ascx.cs" Inherits="AGC.Webform.wucApplicationTypeB" %>

<table id="tabwucApplicationType" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblApplicationTypeId" runat="server" CssClass="col-form-label text-right">Ӧ�ó�������ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtApplicationTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 200px">
            <asp:Label ID="lblApplicationTypeName" runat="server" CssClass="col-form-label text-right">Ӧ�ó�����������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtApplicationTypeName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">Ӧ�ó�������Ӣ������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtApplicationTypeENName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">��������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">��������2</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId2" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">��������3</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId3" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
       <tr>
        <td class="NameTD">
            <asp:Label ID="Label4" runat="server" CssClass="col-form-label text-right">��������4</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId4" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
        <tr>
        <td class="NameTD">
            <asp:Label ID="Label5" runat="server" CssClass="col-form-label text-right">�Ƿ���ʾ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:CheckBox ID="chkIsVible" runat="server" />
           
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
