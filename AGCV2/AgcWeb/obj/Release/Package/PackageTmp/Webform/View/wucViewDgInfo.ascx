<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewDgInfo.ascx.cs"
    Inherits="AGC.Webform.wucViewDgInfo" %>
<table id="tabwucViewDgInfo" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblViewDgID" runat="server" >����DgId</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewDgID" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewDgName" runat="server" >����Dg����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewDgName" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server" >����ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtViewId" runat="server" ></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSqlDsTypeId" runat="server" >����Դ����</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlSqlDsTypeId" runat="server" 
                Width="152px" AutoPostBack="True">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSqlDsId" runat="server" >����Դ��/��ͼId</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlSqlDsId" runat="server" 
                Width="159px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDgStyleId" runat="server" >DGģʽID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDgStyleId" runat="server" 
                Width="159px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblWidth" runat="server" >��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtWidth" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Width" runat="server" 
                ErrorMessage="������������ֵ!" ControlToValidate="txtWidth" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblHeight" runat="server" >�߶�</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtHeight" runat="server" ></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_Height" runat="server" 
                ErrorMessage="������������ֵ!" ControlToValidate="txtHeight" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
</table>
