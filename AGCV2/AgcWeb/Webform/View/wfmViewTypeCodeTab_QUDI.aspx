<%@ Register TagPrefix="uc1" TagName="wucViewTypeCodeTab" Src="wucViewTypeCodeTab.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewTypeCodeTab_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewTypeCodeTab_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>��ViewTypeCodeTab�Ĳ�ѯ���޸ġ�ɾ������Ӽ�¼</title>
    
    <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
    <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body>
    <form id="Form1" method="post" runat="server">

        <table id="tabTitle" style="z-index: 102; left: 8px; position: absolute; top: 8px"
            cellspacing="1" cellpadding="1" width="100%"  border="0">
            <tr>
                <td>
                    <asp:Label ID="lblViewTile" runat="server" class="h5">ϵͳ����-->����������ά��</asp:Label>
                </td>
            </tr>
        </table>
        <table id="tabLayout" style="z-index: 105; left: 4px; position: absolute; top: 38px"
            cellspacing="2" cellpadding="2" width="100%" border="0" runat="server">
            <tr>
                <td>
                    <ul class="nav">
                        <li class="nav-item">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Label ID="lblViewTypeCodeq"  runat="server" Width="70px">����������</asp:Label>

                                <asp:TextBox ID="txtViewTypeCodeq" runat="server" Width="70px"></asp:TextBox>
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Label ID="lblViewTypeNameq"  runat="server" Width="87px">������������</asp:Label>
                                <asp:TextBox ID="txtViewTypeNameq"  runat="server" Width="136px"></asp:TextBox>
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Label ID="lblApplicationTypeIdq"  runat="server" Width="88px">Ӧ�ó�������</asp:Label>
                                <asp:DropDownList ID="ddlApplicationTypeIdq"  runat="server" Width="144px">
                                </asp:DropDownList>
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Label ID="lblIsWebq" Style="z-index: 131;"
                                    runat="server" CssClass="text-secondary">WebӦ��?</asp:Label>
                                <asp:DropDownList ID="ddlIsWebq" Style="z-index: 132;"
                                    runat="server" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Label ID="lblIsWinq" Style="z-index: 134;" runat="server" CssClass="text-secondary">WinӦ��?</asp:Label>
                                <asp:DropDownList ID="ddlIsWinq" Style="z-index: 135;"
                                    runat="server" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Label ID="lblIsMobileAppq" Style="z-index: 137;" runat="server" CssClass="text-secondary">�ƶ��ն�Ӧ��?</asp:Label>
                                <asp:DropDownList ID="ddlIsMobileAppq" Style="z-index: 138;"
                                    runat="server" CssClass="TextBox_Defa">
                                </asp:DropDownList>
                            </div>
                        </li>
                        <li class="nav-item ml-3">
                            <div class="btn-group" role="group" aria-label="Basic example">
                                <asp:Button ID="btnQuery"  runat="server" Text="��ѯ" OnClick="btnQuery_Click" CssClass="btn btn-outline-warning btn-sm"></asp:Button>
                            </div>
                        </li>

                    </ul>

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
                    <table id="tabViewTypeCodeTabDataGrid" style="z-index: 225; width: 100%"
                        cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
                        <tr>
                            <td>
                                <ul class="nav">
                                    <li class="nav-item">

                                        <asp:Label ID="lblViewTypeCodeTabList"
                                            runat="server" CssClass="h6" Width="200px">�����������б�</asp:Label>
                                    </li>
                                    <li class="nav-item ml-3">
                                        <asp:Button ID="btnAddNewRec4Dg1" 
                                            runat="server" Text="���" OnClick="btnAddNewRec4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    </li>
                                    <li class="nav-item ml-3">
                                        <asp:Button ID="btnClone" 
                                            runat="server" Text="��¡" OnClick="btnClone_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    </li>
                                    <li class="nav-item ml-3">
                                        <asp:Button ID="btnDelete4Dg" 
                                            runat="server" Text="ɾ��" OnClick="btnDelete4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    </li>
                                    <li class="nav-item ml-3">
                                        <asp:Button ID="btnUpdate4Dg"
                                            runat="server" Text="�޸�" OnClick="btnUpdate4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                    </li>
                                    <li class="nav-item ml-3">
                                        <div class="btn-group" role="group" aria-label="Basic example">
                                            <asp:Button ID="btnGoTop" runat="server" Text="�ƶ�"  OnClick="btnGoTop_Click" CssClass="btn btn-outline-info btn-sm" />
                                            <asp:Button ID="btnUpMove" runat="server" OnClick="btnUpMove_Click" Text="����"  CssClass="btn btn-outline-info btn-sm ml-1" />
                                            <asp:Button ID="btnDownMove" runat="server" OnClick="btnDownMove_Click" Text="����"  CssClass="btn btn-outline-info btn-sm ml-1" />
                                            <asp:Button ID="btnGoBottum" runat="server" Text="�Ƶ�"  OnClick="btnGoBottum_Click" CssClass="btn btn-outline-info btn-sm ml-1" />
                                            <asp:Button ID="btnReOrder" runat="server" OnClick="btnReOrder_Click" Text="����" CssClass="btn btn-outline-info btn-sm ml-1" />
                                        </div>
                                    </li>
                                    <li class="nav-item ml-3">
                                        <asp:Button ID="btnExportExcel4Dg" 
                                            runat="server" Text="����Excel" OnClick="btnExportExcel4Dg_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>
                                    </li>
                                    <li class="nav-item ml-3">
                                        <asp:Label ID="lblMsgList" runat="server" Width="208px" CssClass="text-warning"></asp:Label>
                                    </li>

                                </ul>

                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:DataGrid ID="dgViewTypeCodeTab" Style="z-index: 114; left: 260px; top: 115px"
                                    runat="server" Width="100%" AutoGenerateColumns="False" AllowPaging="True"
                                    AllowSorting="True" GridLines="Horizontal" CellPadding="3"
                                    BackColor="White" BorderWidth="1px" BorderStyle="None" BorderColor="#E7E7FF" OnItemCommand="dgViewTypeCodeTab_ItemCommand" OnItemCreated="dgViewTypeCodeTab_ItemCreated" OnItemDataBound="dgViewTypeCodeTab_ItemDataBound" OnPageIndexChanged="dgViewTypeCodeTab_PageIndexChanged" OnSortCommand="dgViewTypeCodeTab_SortCommand" DataKeyField="ViewTypeCode">
                                    <SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
                                    <AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
                                    <ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
                                    <FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
                                    <Columns>
                                        <asp:TemplateColumn HeaderText="ѡ��">
                                            <HeaderStyle Width="30px"></HeaderStyle>
                                            <HeaderTemplate>
                                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server">ȫѡ</asp:LinkButton>
                                            </HeaderTemplate>
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                        <asp:BoundColumn DataField="OrderNum" SortExpression="OrderNum" HeaderText="���"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewTypeCode" SortExpression="ViewTypeCode" HeaderText="����������"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewTypeName" SortExpression="ViewTypeName" HeaderText="������������"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewTypeENName" SortExpression="ViewTypeENName" HeaderText="Ӣ������"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ApplicationTypeName" SortExpression="ApplicationTypeName"
                                            HeaderText="��������"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewFunction" SortExpression="ViewFunction" HeaderText="���湦��"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ViewDetail" SortExpression="ViewDetail"
                                            HeaderText="����˵��"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="OptProcess" SortExpression="OptProcess"
                                            HeaderText="��������"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsWinApp" SortExpression="IsWinApp" HeaderText="WinӦ��?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsWebApp" SortExpression="IsWebApp" HeaderText="WebӦ��?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsMobileApp" SortExpression="IsMobileApp" HeaderText="�ƶ��ն�Ӧ��?"></asp:BoundColumn>

                                        <asp:BoundColumn DataField="IsHaveMainView" SortExpression="IsHaveMainView" HeaderText="������?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveSubView" SortExpression="IsHaveSubView" HeaderText="�ӽ���?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveAdd" SortExpression="IsHaveAdd" HeaderText="���?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveUpdate" SortExpression="IsHaveUpdate" HeaderText="�޸�?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveDel" SortExpression="IsHaveDel" HeaderText="ɾ��?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveQuery" SortExpression="IsHaveQuery" HeaderText="��ѯ?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveDetail" SortExpression="IsHaveDetail" HeaderText="��ϸ?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveExcelExport" SortExpression="IsHaveExcelExport"
                                            HeaderText="XLS����?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveSetExportExcel" SortExpression="IsHaveSetExportExcel"
                                            HeaderText="����XLS����?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveExeAdd" SortExpression="IsHaveExeAdd" HeaderText="�����?"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="IsHaveExeUpdate" SortExpression="IsHaveExeUpdate" HeaderText="���޸�?"></asp:BoundColumn>

                                        <asp:ButtonColumn Text="�޸�" CommandName="Update"></asp:ButtonColumn>
                                        <asp:TemplateColumn>
                                            <ItemTemplate>
                                                <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="ɾ��"></asp:LinkButton>
                                            </ItemTemplate>
                                        </asp:TemplateColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
                                </asp:DataGrid>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 655px">
                                <table id="tabViewTypeCodeTabJumpPage" style="width: 568px; font-family: Verdana; height: 26px"
                                    cellspacing="0" cellpadding="0" width="568" border="1" runat="server">
                                    <tr>
                                        <td>
                                            <span style="background-color: #c0c0c0">���м�¼:</span>
                                            <asp:Label ID="lblViewTypeCodeTabRecCount" runat="server" Width="16px" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px"></div>
                                            <span style="background-color: #c0c0c0">��ҳ��:</span>
                                            <asp:Label ID="lblViewTypeCodeTabAllPages" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px"></div>
                                            <span style="background-color: #c0c0c0">��ǰҳ:</span>
                                            <asp:Label ID="lblViewTypeCodeTabCurrentPage" runat="server" ForeColor="#000066">0</asp:Label>
                                            <div style="display: inline; width: 16px; height: 13px"></div>
                                            <asp:Button ID="btnViewTypeCodeTabPrevPage" runat="server"
                                                 CssClass="btn btn-outline-warning btn-sm small" Text="��һҳ" OnClick="btnViewTypeCodeTabPrevPage_Click"></asp:Button>
                                            <asp:Button ID="btnViewTypeCodeTabNextPage" runat="server"
                                                 CssClass="btn btn-outline-warning btn-sm small" Text="��һҳ" OnClick="btnViewTypeCodeTabNextPage_Click"></asp:Button>
                                            ����
                                                        <asp:TextBox ID="txtViewTypeCodeTabJump2Page" runat="server"
                                                            Width="35px"></asp:TextBox>ҳ
                                                        <asp:Button ID="btnViewTypeCodeTabJumpPage" runat="server"
                                                             CssClass="btn btn-outline-warning btn-sm small" Text="ȷ��" OnClick="btnViewTypeCodeTabJumpPage_Click"></asp:Button>
                                            <asp:CompareValidator ID="ViewTypeCodeTabCompareValidator1" runat="server" ForeColor="DarkOrange"
                                                ErrorMessage="����" ControlToValidate="txtViewTypeCodeTabJump2Page" Type="Integer"
                                                Operator="DataTypeCheck"></asp:CompareValidator>
                                        </td>
                                    </tr>
                                </table>
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
                    <table id="tabEditViewTypeCodeTabRegion" style="z-index: 229; width: 750px; height: 200px"
                        cellspacing="1" cellpadding="1" width="750" border="1" runat="server">
                        <tr>
                            <td>
                                <div style="width: 792px; position: relative; height: 42px">
                                    <asp:Label ID="lblEditViewTypeCodeTab" Style="z-index: 104; left: 8px; position: absolute; top: 4px"
                                        runat="server" CssClass="h6">����������༭����</asp:Label>
                                    <asp:Button ID="btnOKUpd" Style="z-index: 106; left: 576px; position: absolute; top: 8px"
                                        runat="server" CssClass="btn btn-outline-info btn-sm" Text="���" OnClick="btnOKUpd_Click"></asp:Button>
                                    <asp:Label ID="lblMsg" Style="z-index: 105; left: 360px; position: absolute; top: 8px"
                                        runat="server" Width="208px"
                                        CssClass="text-warning"></asp:Label>
                                    <asp:LinkButton ID="lbDispViewTypeCodeTabList" Style="z-index: 107; left: 664px; position: absolute; top: 8px"
                                        runat="server" Width="137px" OnClick="lbDispViewTypeCodeTabList_Click">��ʾ�����������б�</asp:LinkButton>
                                </div>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <uc1:wucViewTypeCodeTab ID="wucViewTypeCodeTab1" runat="server"></uc1:wucViewTypeCodeTab>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
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
