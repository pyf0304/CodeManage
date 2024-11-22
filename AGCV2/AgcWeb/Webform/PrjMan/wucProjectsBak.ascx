<%@ Control Language="C#" AutoEventWireup="True" CodeBehind="wucProjectsBak.ascx.cs" Inherits="AGC.Webform.wucProjectsBak" %>

<table id="tabwucProjects" cellspacing="1" cellpadding="1" border="0" style="width: 663px">
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblPrjId" runat="server" CssClass="col-form-label text-right">����ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjId" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblPrjName" runat="server" CssClass="col-form-label text-right">��������</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtPrjName" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblPrjDomain" runat="server" CssClass="col-form-label text-right">��/����</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtPrjDomain" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblUserId0" runat="server" CssClass="col-form-label text-right">��Ŀ���ݿ�</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlPrjDataBaseId" runat="server" 
                class="form-control-sm" Width="200px">
            </asp:DropDownList>
        </td>
        <td style="text-align:right">
            &nbsp;</td>
        <td style="width: 199px">
            &nbsp;</td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblUpdDate" runat="server" CssClass="col-form-label text-right">����ܹ�</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlSoftStructureId" runat="server" 
                class="form-control-sm" Width="200px">
            </asp:DropDownList>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblUserId" runat="server" CssClass="col-form-label text-right">Ӧ�ó�������</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:DropDownList ID="ddlApplicationTypeId" runat="server" 
                class="form-control-sm" Width="200px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblDataBaseTypeId" runat="server" CssClass="col-form-label text-right">���ݿ�����</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlDataBaseTypeId" runat="server" class="form-control-sm" Width="200px">
            </asp:DropDownList>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblIpAddress" runat="server" CssClass="col-form-label text-right">������</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtIpAddress" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblPrjDataBaseName" runat="server" CssClass="col-form-label text-right">�����ݿ�</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtPrjDataBaseName" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblDatabaseOwner" runat="server" CssClass="col-form-label text-right">���ݿ�ӵ����</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtDatabaseOwner" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblSid" runat="server" CssClass="col-form-label text-right">Sid</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtSid" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblTableSpace" runat="server" CssClass="col-form-label text-right">��ռ�</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtTableSpace" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblDataBaseUserId" runat="server" CssClass="col-form-label text-right" Width="100px">���ݿ���û�ID</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:TextBox ID="txtDataBaseUserId" runat="server" class="form-control-sm" Width="200px"></asp:TextBox>
        </td>
                <td style="text-align:right">
            <asp:Label ID="lblDataBasePwd" runat="server" CssClass="col-form-label text-right" Width="110px">���ݿ���û�����</asp:Label>
        </td>
        <td style="width: 199px">
            <asp:TextBox ID="txtDataBasePwd" runat="server" class="form-control-sm" 
                Width="200px" TextMode="Password"  AUTOCOMPLETE="off"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="Label1" runat="server" CssClass="col-form-label text-right">����Ŀ¼</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtVirtualDirectory" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 26px; width: 100px;" align="right">
            <asp:Label ID="Label2" runat="server" CssClass="col-form-label text-right">���̸�Ŀ¼</asp:Label>
        </td>
        <td colspan="3" style="height: 26px">
            <asp:TextBox ID="txtPrjRootDirectory" runat="server" class="form-control-sm" Width="538px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="height: 26px; width: 100px;" align="right">
            <asp:Label ID="Label3" runat="server" CssClass="col-form-label text-right">�Ƿ�������ݿ�</asp:Label>
        </td>
        <td colspan="1" style="height: 26px">
            <asp:CheckBox ID="chkIsRelaDataBase" runat="server" />
        </td>
   
         <td class="style1" align="right">
            <asp:Label ID="lblDataBaseUserId0" runat="server" CssClass="col-form-label text-right">ʹ��״̬</asp:Label>
        </td>
        <td class="ValueTD">
            <asp:DropDownList ID="ddlUseStateId" runat="server" class="form-control-sm" 
                Width="200px" 
               >
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="NameTD" style="width: 100px; text-align:right">
            <asp:Label ID="lblMemo" runat="server" CssClass="col-form-label text-right">˵��</asp:Label>
        </td>
        <td class="ValueTD" colspan="3">
            <asp:TextBox ID="txtMemo" runat="server" class="form-control-sm" Width="536px" Height="50px"
                TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
