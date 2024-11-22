<%@ Register TagPrefix="uc1" TagName="wucExportExcelSetB" Src="wucExportExcelSetB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmExportExcelSetB_QUDI.aspx.cs"
    Inherits="AGC.Webform.wfmExportExcelSetB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>����Excel����</title>
    <link href="../../css/taishweb2.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">



        <script language="javascript" src="../../../JS/Resource.js" type="text/javascript"></script>
        <link href="../../css/taishweb2.css" rel="stylesheet" type="text/css" />
        <table id="Table1" style="position: static; width: 100%;" cellspacing="2" cellpadding="2"
            border="0" runat="server">
            <tr>
                <td>
                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >����Excel����ά��
                        </asp:Label>
                        <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table style="width: 100%">
                        <tr>
                            <td>
                                <asp:Label ID="lblViewNameq"  runat="server" Width="70px"
                                    CssClass="text-secondary">��������</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtViewNameq"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblTabNameq"  runat="server"
                                    CssClass="text-secondary">����</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtTabNameq"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblUserIDq"  runat="server" Width="70px"
                                    CssClass="text-secondary">�û�ID</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtUserIDq"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="lblUserNameq"  runat="server"
                                    CssClass="text-secondary">�û���</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtUserNameq"  runat="server" Width="200px"
                                     CssClass="TextBox_Defa"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Button ID="btnQuery" Style="z-index: 116;" runat="server"  
                                    Text="��ѯ" CssClass="btn btn-outline-warning btn-sm" OnClick="btnQuery_Click"></asp:Button>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabExportExcelSetGridView" style="width: 100%" runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblExportExcelSetList" runat="server"  CssClass="h6"
                                                Width="250px">����Excel�����б�</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                                 CssClass="btn btn-outline-info btn-sm" Text="���"></asp:Button>
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
                                            <asp:Button ID="btnEditExportExcel4User" OnClick="btnEditExportExcel4User_Click"
                                                runat="server" Width="134px" CssClass="btn btn-outline-info btn-sm" Text="�༭�û������ֶ�"></asp:Button>
                                        </td>
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
                                <asp:GridView ID="gvExportExcelSet" Style="z-index: 117;" runat="server" Width="100%"
                                    AutoGenerateColumns="False" PageSize="10" AllowPaging="true" AllowSorting="true"
                                    OnSorting="gvExportExcelSet_Sorting" OnPageIndexChanging="gvExportExcelSet_PageIndexChanging"
                                    OnRowCreated="gvExportExcelSet_RowCreated" OnRowCommand="gvExportExcelSet_RowCommand"
                                    OnRowDeleting="gvExportExcelSet_RowDeleting" OnRowUpdating="gvExportExcelSet_RowUpdating"
                                    BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
                                    CellPadding="3" GridLines="Horizontal" Height="1px" DataKeyNames="id_ExportExcel4Users"
                                    CssClass="table table-striped table-bordered table-condensed">
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
                                        <asp:BoundField DataField="id_ExportExcel4Users" SortExpression="id_ExportExcel4Users"
                                            HeaderText="��ˮ��"></asp:BoundField>
                                        <asp:BoundField DataField="ViewName" SortExpression="ViewName" HeaderText="��������"></asp:BoundField>
                                        <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="����"></asp:BoundField>
                                        <asp:BoundField DataField="IsDefaultUser" SortExpression="IsDefaultUser" HeaderText="ȱʡ�û�?"></asp:BoundField>
                                        <asp:BoundField DataField="UserID" SortExpression="UserID" HeaderText="�û�ID"></asp:BoundField>
                                        <asp:BoundField DataField="UserName" SortExpression="UserName" HeaderText="�û���"></asp:BoundField>
                                        <asp:BoundField DataField="ExportFileName" SortExpression="ExportFileName" HeaderText="�����ļ���"></asp:BoundField>
                                        <asp:BoundField DataField="UpdUserId" SortExpression="UpdUserId" HeaderText="�޸��û�Id"></asp:BoundField>
                                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="�޸�����"></asp:BoundField>
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
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditExportExcelSetRegion" style="z-index: 117; width: 100%" cellspacing="1"
                        cellpadding="1" width="100%" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditExportExcelSet"  runat="server" CssClass="h6">����Excel���ñ༭����</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsgEdit"  runat="server" Width="208px" 
                                    CssClass="text-warning"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd"  runat="server"  Text="���"
                                    OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelExportExcelSetEdit"  runat="server"
                                    Width="100px" CssClass="btn btn-outline-info btn-sm" Text="ȡ���༭" OnClick="btnCancelExportExcelSetEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucExportExcelSetB ID="wucExportExcelSetB1" runat="server" />
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>

