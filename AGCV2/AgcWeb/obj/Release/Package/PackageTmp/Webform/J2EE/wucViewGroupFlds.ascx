<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewGroupFlds.ascx.cs"
    Inherits="AGC.Webform.wucViewGroupFlds" %>
<table id="tabwucViewGroupFlds" cellspacing="1" cellpadding="1" width="600" border="0">
    <tr>
        <td>
            <asp:Label ID="lblViewGroupId" runat="server" >������ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlViewGroupId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblTabFldId" runat="server" >���ֶ�ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtTabFldId" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server" >�ؼ����ͺ�</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDdlItemsOptionId" runat="server" >�������б�ѡ��ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDdlItemsOptionId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsCondStr" runat="server" >����Դ������</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsCondStr" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataTextFieldId" runat="server" >����Դ�ı��ֶ�Id</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataTextFieldId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsDataValueFieldId" runat="server" >����Դֵ�ֶ�Id</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsDataValueFieldId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsSqlStr" runat="server" >����ԴSQL��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtDsSqlStr" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDsTabId" runat="server" >����Դ��ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlDsTabId" runat="server" 
                Width="194px">
            </asp:DropDownList>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblItemsString" runat="server" >�б��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtItemsString" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSeqNum" runat="server" >�ֶ����</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server" 
                Width="195px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_SeqNum" runat="server" 
                ErrorMessage="������������ֵ!" ControlToValidate="txtSeqNum" Type="Integer" Operator="DataTypeCheck"
                EnableClientScript="false"></asp:CompareValidator>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server" >˵��</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMemo" runat="server" 
                Width="194px"></asp:TextBox>
        </td>
        <td>
        </td>
        <td>
            
        </td>
    </tr>
</table>
