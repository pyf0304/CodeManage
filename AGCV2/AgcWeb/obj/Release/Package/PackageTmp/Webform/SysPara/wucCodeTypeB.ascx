<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucCodeTypeB.ascx.cs" Inherits="AGC.Webform.wucCodeTypeB" %>



<table id="tabwucCodeType" style="width: 600px; padding: 1px;" border="0">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeId" runat="server" CssClass="col-form-label text-right">��������Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeId" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeName" runat="server" CssClass="col-form-label text-right">����������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">���ͼ��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeSimName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtGroupName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblProgLangTypeId" runat="server" CssClass="col-form-label text-right">��������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlProgLangTypeId" runat="server" class="form-control-sm" Width="400px"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>

    <tr>
        <td class="NameTD">
            <asp:Label ID="lblCodeTypeENName" runat="server" CssClass="col-form-label text-right">��������Ӣ����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtCodeTypeENName" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFrontOrBack" runat="server" CssClass="col-form-label text-right">ǰ̨Or��̨</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtFrontOrBack" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">������ʽ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtClassNameFormat" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsCSharp" runat="server" Text="�Ƿ�CSharp����" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsJava" runat="server" Text="�Ƿ�Java����" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsJavaScript" runat="server" Text="�Ƿ�JavaScript����" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsSilverLight" runat="server" Text="�Ƿ�SilverLight����" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsSwift" runat="server" Text="�Ƿ�Swift����" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsPubApp4WinWeb" runat="server" Text="�Ƿ�Ӧ�ú�̨" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsWeb" runat="server" Text="�Ƿ�WebӦ��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsAspMvc" runat="server" Text="�Ƿ�AspMvcӦ��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsWin" runat="server" Text="�Ƿ�WinӦ��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsMobileApp" runat="server" Text="�Ƿ��ƶ��ն�Ӧ��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblOrderNum" runat="server" CssClass="col-form-label text-right">���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtOrderNum" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_OrderNum" runat="server" CssClass="text-warning" ErrorMessage="������������ֵ!" ControlToValidate="txtOrderNum"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDefaultOverride" runat="server" Text="�Ƿ�Ĭ�ϸ���" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsDirByTabName" runat="server" Text="�Ƿ��ñ�����Ϊ·��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="400px"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
</table>
