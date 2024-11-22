<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucTabFieldRelaB.ascx.cs" Inherits="AGC.Webform.wucTabFieldRelaB" %>

<table id="tabwucTabFieldRela" class="tab_wucEdit">
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFldID" runat="server" CssClass="col-form-label text-right">�ֶ�ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFldID" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSqlFldName" runat="server" CssClass="col-form-label text-right">Sql�ֶ�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSqlFldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblExcelFieldName" runat="server" CssClass="col-form-label text-right">Excel�ֶ�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtExcelFieldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblDefaultValue" runat="server" CssClass="col-form-label text-right">ȱʡֵ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDefaultValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedTrans" runat="server" Text="�Ƿ���Ҫת��" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransWayId" runat="server" CssClass="col-form-label text-right">ת����ʽID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransWayId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransTabName" runat="server" CssClass="col-form-label text-right">ת������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransTabName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransInFldName" runat="server" CssClass="col-form-label text-right">ת��IN�ֶ���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransInFldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransOutFldName" runat="server" CssClass="col-form-label text-right">ת��Out�ֶ���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransOutFldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabPrimary" runat="server" Text="�Ƿ���Ϊ��������" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabForeignKey" runat="server" Text="�Ƿ�����" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryTypeId" runat="server" CssClass="col-form-label text-right">��������ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrimaryTypeId" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsIdentity" runat="server" Text="�Ƿ�Identity" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabUnique" runat="server" Text="�Ƿ����Ψһ" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsTabNullable" runat="server" Text="�Ƿ���пɿ�" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblFieldTypeId" runat="server" CssClass="col-form-label text-right">�ֶ�����Id</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlFieldTypeId" runat="server" class="form-control-sm"></asp:DropDownList>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsNeedCheckPriForeignKey" runat="server" Text="�Ƿ��������" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryKeyTabName" runat="server" CssClass="col-form-label text-right">������</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrimaryKeyTabName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblPrimaryKeyFieldName" runat="server" CssClass="col-form-label text-right">�����ֶ���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrimaryKeyFieldName" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>   
   
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransMissingValue" runat="server" CssClass="col-form-label text-right">ת��ʧ��ֵ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransMissingValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblTransNullValue" runat="server" CssClass="col-form-label text-right">ת����ֵ</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtTransNullValue" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td></td>
        <td></td>
    </tr>
  
   
    <tr>
        <td class="NameTD">
            &nbsp;</td>
        <td class="ValueTD">
            &nbsp;</td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td>
            <asp:CheckBox ID="chkIsVisible" runat="server" Text="�Ƿ���ʾ" CssClass="Check_Defa"></asp:CheckBox>
        </td>
        <td></td>
        <td></td>
        <td></td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblSequenceNumber" runat="server" CssClass="col-form-label text-right">˳���</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSequenceNumber" runat="server" class="form-control-sm"></asp:TextBox>
        </td>
        <td>
            <asp:CompareValidator ID="ComValid_SequenceNumber" runat="server" CssClass="text-warning" ErrorMessage="������������ֵ!" ControlToValidate="txtSequenceNumber"
                Type="Integer" Operator="DataTypeCheck" EnableClientScript="false">
            </asp:CompareValidator>
        </td>
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
