<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucUsersBak.ascx.cs" Inherits="AGC.wucUsersBak" %>
<table id="tabwucUsers" cellspacing="1" cellpadding="1" width="456" border="0" style="width: 456px; height: 368px">
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblUserId" runat="server" Height="10px"
                ForeColor="Teal">�û�ID</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:TextBox ID="txtUserId" runat="server"></asp:TextBox>
        </td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblUserName" runat="server" Height="10px"
                ForeColor="Teal">�û�����</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblDepartmentId" runat="server" Height="10px"
                ForeColor="Teal">���ź�</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:DropDownList ID="ddlDepartmentId" runat="server" Width="152px">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblUserStateId" runat="server" Height="10px"
                ForeColor="Teal">�û�״̬��</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:DropDownList ID="ddlUserStateId" runat="server" Width="152px">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblPassWord" runat="server" Height="10px"
                ForeColor="Teal">����</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:TextBox ID="txtPassWord" runat="server" Width="152px" TextMode="Password" AUTOCOMPLETE="off"></asp:TextBox>
        </td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblRoleId" runat="server" Height="10px"
                ForeColor="Teal">�û���ɫ</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:DropDownList ID="ddlRoleId" runat="server" Width="152px">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblQXDJ" runat="server" Height="10px"
                ForeColor="Teal">Ȩ�޵ȼ�</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:TextBox ID="txtQXDJ" runat="server" Width="152px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_QXDJ" runat="server" ErrorMessage="������������ֵ!" ControlToValidate="txtQXDJ"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="False"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td style="width: 70px">
            <asp:Label ID="lblMemo" runat="server" Height="10px"
                ForeColor="Teal">��ע</asp:Label>
        </td>
        <td style="width: 198px">
            <asp:TextBox ID="txtMemo" runat="server" Width="273px" TextMode="MultiLine" Height="177px"></asp:TextBox>
        </td>
        <td></td>
    </tr>
</table>
