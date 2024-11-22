<%@ Register TagPrefix="uc1" TagName="wucPlatDefaRoleB" Src="wucPlatDefaRoleB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmPlatDefaRoleB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmPlatDefaRoleB_QUDI" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ƽ̨Ĭ�Ͻ�ɫά����ά��</title>
    <link rel="stylesheet" type="text/css" href="../../Webform/css/taishweb1.css" />
    
</head>
<body>
    <form id="form1" runat="server">
        <table id="tabLayout" style="z-index: 105; left: 0px; position: absolute; top: 0px; width: 100%;" cellspacing="2"
            cellpadding="2" border="0" runat="server">
            <tr>
                <td>

                    <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                        <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >ƽ̨Ĭ�Ͻ�ɫά��
                        </asp:Label>
                        <asp:Label ID="lblMsg_List" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; "
                            Width="347px"></asp:Label>
                    </div>
                </td>
            </tr>
            <tr>
                <td>

                    <table>
                        <tr>

                            <td>
                                <asp:Label ID="lblid_School_q" 
                                    runat="server" Width="54px" CssClass="text-secondary">ѧУ��</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlid_School_q" 
                                    runat="server" Width="100px"  CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </td>

                            <td>
                                <asp:Label ID="lblPersonType_q" 
                                    runat="server" Width="67px" CssClass="text-secondary">��Ա���</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPersonType_q" 
                                    runat="server" Width="100px"  CssClass="TextBox_Defa">
                                </asp:TextBox>
                            </td>
                      

                            <td>
                                <asp:Label ID="lblPrjId_q" 
                                    runat="server" Width="58px" CssClass="text-secondary">����Id</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="txtPrjId_q" 
                                    runat="server" Width="100px"  CssClass="TextBox_Defa">
                                </asp:TextBox>
                            </td>
                            <td>

                                <asp:Button ID="btnQuery"
                                    
                                    runat="server"
                                     
                                    Text="��ѯ" CssClass="btn btn-outline-warning btn-sm"
                                    OnClick="btnQuery_Click"></asp:Button>
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

                    <table id="tabPlatDefaRoleGridView" style="width: 100%"
                        runat="server">
                        <tr>
                            <td>
                                <table style="width: 100%; height: 32px" id="tabGridFunction">
                                    <tr>
                                        <td>
                                            <asp:Label ID="lblPlatDefaRoleList" runat="server" 
                                                CssClass="h6" Width="250px">ƽ̨Ĭ�Ͻ�ɫ�б�</asp:Label>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                                 CssClass="btn btn-outline-info btn-sm" Text="���"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                                 CssClass="btn btn-outline-info btn-sm" Text="ɾ��"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                                 CssClass="btn btn-outline-info btn-sm" Text="�޸�"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="����Excel"></asp:Button>
                                        </td>
                                        <td>
                                            <asp:Button ID="btnSetExportExcel4User" OnClick="btnSetExportExcel4User_Click" 
                                                runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="���õ����ֶ�"></asp:Button>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:GridView ID="gvPlatDefaRole"  runat="server"
                                    Width="100%" AutoGenerateColumns="False"
                                    PageSize="10" AllowPaging="true"
                                    AllowSorting="true"
                                    OnSorting="gvPlatDefaRole_Sorting"
                                    OnPageIndexChanging="gvPlatDefaRole_PageIndexChanging"
                                    OnRowCreated="gvPlatDefaRole_RowCreated"
                                    OnRowCommand="gvPlatDefaRole_RowCommand"
                                    OnRowDeleting="gvPlatDefaRole_RowDeleting"
                                    OnRowUpdating="gvPlatDefaRole_RowUpdating"
                                    BackColor="White"
                                    BorderColor="#E7E7FF"
                                    BorderStyle="None"
                                    BorderWidth="1px"
                                    CellPadding="3"
                                    GridLines="Horizontal"
                                    Height="1px"
                                    DataKeyNames="mId"
                                    CssClass="table table-striped table-bordered table-condensed">
                                    <Columns>
                                        <asp:TemplateField HeaderText="ȫѡ">
                                            <HeaderStyle Width="35px" />
                                            <HeaderTemplate>
                                                 <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="GoStyle_SelAll" Text="ȫѡ" ></asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId"></asp:BoundField>
                                        <asp:BoundField DataField="id_School" SortExpression="id_School" HeaderText="ѧУ��ˮ��"></asp:BoundField>
                                        <asp:BoundField DataField="SchoolId" SortExpression="SchoolId" HeaderText="ѧУId"></asp:BoundField>
                                        <asp:BoundField DataField="IsCurrentUse" SortExpression="IsCurrentUse" HeaderText="�Ƿ�ǰʹ��"></asp:BoundField>
                                        <asp:BoundField DataField="SchoolName" SortExpression="SchoolName" HeaderText="ѧУ����"></asp:BoundField>
                                        <asp:BoundField DataField="PersonType" SortExpression="PersonType" HeaderText="��Ա���"></asp:BoundField>
                                        <asp:BoundField DataField="PrjId" SortExpression="PrjId" HeaderText="����Id"></asp:BoundField>
                                        <asp:BoundField DataField="RoleID" SortExpression="RoleID" HeaderText="��ɫID"></asp:BoundField>
                                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="��ע"></asp:BoundField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                  <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="�޸�" CssClass="GoStyle"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="ɾ��" CssClass="GoStyle"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerTemplate>
                                        <span class="text-secondary">���м�¼:</span>
                                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="22px">0</asp:Label>
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
                    <table id="tabEditPlatDefaRoleRegion" style="z-index: 114; width: 100%"
                        cellspacing="1" cellpadding="1" border="1" runat="server">
                        <tr>
                            <td>
                                <asp:Label ID="lblEditPlatDefaRole"  runat="server"
                                    CssClass="h6">ƽ̨Ĭ�Ͻ�ɫ�༭����</asp:Label>
                            </td>
                            <td>
                                <asp:Label ID="lblMsg_Edit"  runat="server"
                                    Width="208px" CssClass="text-warning"></asp:Label>
                            </td>
                            <td>
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="���" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                            </td>
                            <td>
                                <asp:Button ID="btnCancelPlatDefaRoleEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="ȡ���༭" OnClick="btnCancelPlatDefaRoleEdit_Click"></asp:Button>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="4">
                                <uc1:wucPlatDefaRoleB ID="wucPlatDefaRoleB1" runat="server" />
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
