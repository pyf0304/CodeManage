<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDataTypeAbbr.ascx.cs"
    Inherits="AGC.Webform.wucDataTypeAbbr" %>

<table id="tabwucDataTypeAbbr" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblDataTypeId" runat="server" CssClass="text-secondary" >��������ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataTypeId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataTypeName" runat="server" CssClass="text-secondary" >DataTypeName</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataTypeName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataCnName" runat="server" CssClass="text-secondary" >����������������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataCnName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataTypeAbbr" runat="server" CssClass="text-secondary" >����������д</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDataTypeAbbr" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblNetSysType" runat="server" CssClass="text-secondary" >NETϵͳ����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtNetSysType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblVBNETType" runat="server" CssClass="text-secondary" >VBNET����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtVBNETType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCSType" runat="server" CssClass="text-secondary" >CS����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtCSType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblJavaType" runat="server" CssClass="text-secondary" >JAVA����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtJavaType" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" CssClass="text-secondary">Ora��������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtOraDbType" runat="server"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" CssClass="text-secondary">Sql��������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSqlParaType" runat="server"></asp:TextBox></td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedQuote" runat="server" 
                Text="�Ƿ���Ҫ����" CssClass="text-secondary"></asp:CheckBox>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" CssClass="text-secondary" >˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
