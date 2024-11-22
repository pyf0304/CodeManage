<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDGRegionFlds.ascx.cs"
    Inherits="AGC.Webform.wucDGRegionFlds" %>

<table id="tabwucDGRegionFlds" style="width: 400px; ">
    <tr>
        <td>
            <asp:Label ID="lblFldId1" runat="server" Width="100px">���ֶ�</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlFldId1" runat="server" Width="300px"></asp:DropDownList>

        </td>
    </tr>

    <tr>
        <td>
            <asp:Label ID="Label1" runat="server">Out����</asp:Label></td>
        <td>
            <asp:Label ID="lblDataNodeInfo" CssClass="text-warning" runat="server">���ݽ����Ϣ</asp:Label>
            <asp:DropDownList ID="ddlDataNodeId" runat="server"
                Width="300px" AutoPostBack="True" OnSelectedIndexChanged="ddlDataNodeId_SelectedIndexChanged">
            </asp:DropDownList></td>
    </tr>

    <tr>
        <td>
            <asp:Label ID="Label2" runat="server">������</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDataPropertyName" runat="server" Width="300px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server">������ʽ</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSortExpression" runat="server" Width="300px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblColCaption" runat="server">�б���</asp:Label></td>
        <td>
            <asp:TextBox ID="txtColCaption" runat="server" Width="300px"></asp:TextBox></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCtlTypeId" runat="server">�ؼ�����</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlCtlTypeId" runat="server"
                Width="300px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDgFuncTypeId" runat="server">Dg��������</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlDgFuncTypeId" runat="server"
                Width="300px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsFuncFld" runat="server"
                Text="�Ƿ����ֶ�"></asp:CheckBox></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsVisible" runat="server"
                Text="�Ƿ���ʾ"></asp:CheckBox></td>

    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsNeedSort" runat="server"
                Text="�Ƿ���Ҫ����"></asp:CheckBox></td>
    </tr>
    <tr>
        <td colspan="2">
            <asp:CheckBox ID="chkIsTransToChkBox" runat="server"
                Text="�Ƿ�ת����CheckBox"></asp:CheckBox></td>

    </tr>
    <tr>
        <td>
            <asp:Label ID="lblSeqNum" runat="server">���</asp:Label></td>
        <td>
            <asp:TextBox ID="txtSeqNum" runat="server" Width="300px"></asp:TextBox><asp:CompareValidator ID="ComValid_SeqNum"
                runat="server" EnableClientScript="false" Operator="DataTypeCheck"
                Type="Integer" ControlToValidate="txtSeqNum" ErrorMessage="������������ֵ!"></asp:CompareValidator></td>

    </tr>
    <tr>
        <td>
            <asp:Label ID="lblMemo" runat="server">˵��</asp:Label></td>
        <td>

            <asp:TextBox ID="txtMemo" runat="server"
                Width="300px" Height="72px" TextMode="MultiLine"></asp:TextBox></td>
    </tr>
</table>

