<%@ Register Src="wucSetFieldVisibilityBBak.ascx" TagName="wucSetFieldVisibilityB" TagPrefix="uc1" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmSetFieldVisibilityB_QUDIBak.aspx.cs"
    Inherits="AGC.Webform.wfmSetFieldVisibilityB_QUDIBak" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>�����ֶο�����ά����ά��</title>
    <link href="../css/taishweb2.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <table id="Table1" style="z-index: 105; width:810px" cellspacing="2" cellpadding="2" width="810px"
            border="0" runat="server">
            <tr>
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >�����ֶο�����ά��
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 732px">
                        <tr>
                            <td>
                                <asp:Label ID="lblid_School_q"  runat="server" Width="90px"
                                    CssClass="text-secondary">ѧУ</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlid_School_q"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblViewName_q"  runat="server" Width="90px"
                                    CssClass="text-secondary">��������</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtViewName_q"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblCtrlType_q"  runat="server" Width="90px"
                                    CssClass="text-secondary">�ؼ�����</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtCtrlType_q"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblFieldName_q"  runat="server" Width="90px"
                                    CssClass="text-secondary">�ֶ���</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtFieldName_q"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 116;" runat="server"  
                                    Text="��ѯ" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabSetFieldVisibilityGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblSetFieldVisibilityList" runat="server"  CssClass="h6"
                                                Width="250px">�����ֶο������б�</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                                 CssClass="btn btn-outline-info btn-sm" Text="���"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnCloneNewRec4Gv" runat="server" OnClick="btnCloneNewRec4Gv_Click"
                                                  CssClass="btn btn-outline-info btn-sm" Text="��¡"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click" 
                                                runat="server"  CssClass="btn btn-outline-info btn-sm" Text="ɾ��"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click" 
                                                runat="server"  CssClass="btn btn-outline-info btn-sm" Text="�޸�"></asp:Button>
                                        </td>
                                        <td>
                                                        <asp:Button ID="btnSetIsVisible" runat="server"  
                                                            Text="���ÿɼ�" OnClick="btnSetIsVisible_Click" /></td>
                                                    <td>
                                                        <asp:Button ID="btnSetIsNotVisible" runat="server" 
                                                             Text="���ò��ɼ�" OnClick="btnSetIsNotVisible_Click" /></td>
                                        <td>
                                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="����Excel"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvSetFieldVisibility" Style="z-index: 117;" runat="server" Width="100%"
                                    AutoGenerateColumns="False" PageSize="10" AllowPaging="true" AllowSorting="true"
                                    OnSorting="gvSetFieldVisibility_Sorting" OnPageIndexChanging="gvSetFieldVisibility_PageIndexChanging"
                                    OnRowCreated="gvSetFieldVisibility_RowCreated" OnRowCommand="gvSetFieldVisibility_RowCommand"
                                    OnRowDeleting="gvSetFieldVisibility_RowDeleting" OnRowUpdating="gvSetFieldVisibility_RowUpdating"
                                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="mId" CssClass="table table-striped table-bordered table-condensed">
                                    <Columns>
                                        <asp:TemplateField HeaderText="ȫѡ">
                                            <HeaderStyle Width="35px" />
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap">ȫѡ</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundField>
                                        <asp:BoundField DataField="id_School" SortExpression="id_School" HeaderText="ѧУ��ˮ��"></asp:BoundField>
                                        <asp:BoundField DataField="SchoolId" SortExpression="SchoolId" HeaderText="ѧУId"></asp:BoundField>
                                        <asp:BoundField DataField="SchoolName" SortExpression="SchoolName" HeaderText="ѧУ����"></asp:BoundField>
                                        <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="��������"></asp:BoundField>
                                        <asp:BoundField DataField="CtrlType" SortExpression="CtrlType" HeaderText="�ؼ�����"></asp:BoundField>
                                        <asp:BoundField DataField="FieldName" SortExpression="FieldName" HeaderText="�ֶ���"></asp:BoundField>
                                        <asp:BoundField DataField="IsVisible" SortExpression="IsVisible" HeaderText="�Ƿ���ʾ"></asp:BoundField>
                                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="��ע"></asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="�޸�"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="ɾ��"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span class="text-secondary">���м�¼:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                            Width="22px">0</asp:Label>
                                        <span style="background-color: #c0c0c0">
                                            <div style="display: inline; width: 16px; height: 13px">
                                            </div>
                                        </span><span class="text-secondary">��ҳ��:</span>
                                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <span class="text-secondary">��ǰҳ:</span>
                                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                                        <div style="display: inline; width: 16px; height: 13px">
                                        </div>
                                        <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="��һҳ"
                                            CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                                            </span>
                                        <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="��һҳ"
                                            CommandArgument="Next" CommandName="Page" />
                                        ����
                                    <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>ҳ
                                    <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
                                        Text="ȷ��" Width="45px" CommandName="Page" />
                                        <span class="text-secondary">ҳ��¼��:</span>
                                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                                            Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                                            <asp:ListItem>5</asp:ListItem>
                                            <asp:ListItem>10</asp:ListItem>
                                            <asp:ListItem>20</asp:ListItem>
                                            <asp:ListItem>30</asp:ListItem>
                                            <asp:ListItem>50</asp:ListItem>
                                            <asp:ListItem>100</asp:ListItem>
                                            <asp:ListItem>1000</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                            ErrorMessage="����" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                    </PagerTemplate>
                                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                    <AlternatingRowStyle BackColor="#F7F7F7" />
                                </asp:GridView>
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td></td>
                <td></td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditSetFieldVisibilityRegion" style="z-index: 117; width: 100%" cellspacing="1"
                        cellpadding="1" width="100%" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditSetFieldVisibility"  runat="server" CssClass="h6">�����ֶο����Ա༭����</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsg_Edit"  runat="server" Width="208px" 
                                    CssClass="text-warning"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd"  runat="server"  Text="���"
                                    OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelSetFieldVisibilityEdit"  runat="server"
                                    Width="100px" CssClass="btn btn-outline-info btn-sm" Text="ȡ���༭" OnClick="btnCancelSetFieldVisibilityEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucSetFieldVisibilityB ID="wucSetFieldVisibilityB1" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
                <td></td>
                <td></td>
            </tr>
        </table>
    </form>
</body>
</html>
