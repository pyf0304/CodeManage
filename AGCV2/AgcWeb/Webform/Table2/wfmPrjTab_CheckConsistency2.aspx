<%@ Page Title="" Language="C#" MasterPageFile="~/Webform/Table2/EditTable.master"
    AutoEventWireup="True" CodeBehind="wfmPrjTab_CheckConsistency2.aspx.cs" Inherits="AGC.Webform.wfmPrjTab_CheckConsistency2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <title>���ϵͳ����SQL���һ����</title>
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <table id="tabLayout" style="z-index: 105; "
        cellspacing="2" cellpadding="2" width="300" border="0" runat="server">
        <tr>
            <td colspan="2">
                <div style="position: relative; width: 844px; height: 25px; left: 0px; top: 0px;">
                    <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >���ֶι���-->���һ����
                    </asp:Label>
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="z-index: 102; left: 191px;
                        position: absolute; top: 3px" Text="����:"></asp:Label>
                    <asp:Label ID="lblTabName" runat="server" Font-Bold="False" Style="z-index: 102;
                        left: 230px; position: absolute; top: 3px" Text="����"></asp:Label>
                    <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning" Style="z-index: 101;
                        left: 165px; position: relative; top: 5px" Width="347px"></asp:Label>
                    <asp:LinkButton ID="lbReturn" runat="server" OnClick="lbReturn_Click"
                        Style="z-index: 106; left: 767px; position: absolute; top: 10px" 
                        Width="32px" Visible="False">����</asp:LinkButton>
                </div>
            </td>
        </tr>
        <tr>
            <td style="width: 772px" valign="top">
                <table id="tabPrjTabFldGridView" style="width: 450px" runat="server">
                    <tr>
                        <td style="width: 548px">
                            <div style="width: 484px; position: relative; left: 0px; top: 0px;" 
                                id="divGridFunction">
                                <table style="width: 482px">
                                    <tr>
                                        <td colspan="2">
                                            <asp:Label ID="lblPrjTabFldList" runat="server" CssClass="h6">����ϵͳ�б��ֶ��б�</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSetFldProperty" runat="server" OnClick="btnSetFldProperty_Click"
                                                Text="�����ֶ�����" Width="100px" />
                                        </td>
                                        <td style="width: 340px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnAddNewField" runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm"
                                                Text="������ֶ�" OnClick="btnAddNewField_Click"></asp:Button>
                                        </td>
                                        <td style="width: 340px">
                                            <asp:Label ID="Label3" runat="server" CssClass="MemoStyle1" Width="328px">����ѡSQL�����ֶ���ӵ����ɴ���ϵͳ�С�</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnSynchFldInfoToAgc" runat="server" CssClass="btn btn-outline-info btn-sm" Text="ͬ���ֶ���Ϣ"
                                                Width="100px" OnClick="btnSynchFldInfoToAgc_Click" />
                                        </td>
                                        <td style="width: 340px">
                                            <asp:Label ID="Label7" runat="server" CssClass="MemoStyle1" Width="329px">ͬ���ֶΣ�����ѡSQL���ݱ��ֶ�ͬ����ϵͳ���ֶ��С�</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:Button ID="btnDelRec" runat="server" OnClick="btnDelRec_Click" Text="ɾ�����ֶ�"
                                                Width="100px" />
                                        </td>
                                        <td style="width: 340px">
                                            <asp:Label ID="Label8" runat="server" CssClass="MemoStyle1" Width="327px">ɾ��������ѡ����ϵͳ���ֶ�ɾ����</asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 548px">
                            <asp:GridView ID="gvPrjTabFld_Agc" 
                                Style="z-index: 113; position: relative; top: 0px; left: 0px; width: 523px;" 
                                runat="server" AutoGenerateColumns="False" AllowSorting="True" OnSorting="gvPrjTabFld_Sorting"
                                OnPageIndexChanging="gvPrjTabFld_PageIndexChanging" OnRowCreated="gvPrjTabFld_RowCreated"
                                OnRowCommand="gvPrjTabFld_RowCommand" BackColor="White" BorderColor="#E7E7FF"
                                BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                GridLines="Horizontal" Height="1px"
                                DataKeyNames="mId" CssClass="table table-striped table-bordered table-condensed">
                                <PagerTemplate>
                                    <span class="text-secondary">���м�¼:</span>
                                    <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                        Width="46px">0</asp:Label>
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
                                    <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                        ErrorMessage="����" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                </PagerTemplate>
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <Columns>
                                    <asp:TemplateField HeaderText="ȫѡ">
                                        <HeaderTemplate>
                                            <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">ȫѡ</asp:LinkButton>
                                        </HeaderTemplate>
                                        <HeaderStyle Width="35px" />
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="mId" SortExpression="mId" HeaderText="mId" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="SequenceNumber" SortExpression="SequenceNumber" HeaderText="˳���"
                                        Visible="False"></asp:BoundField>
                                    <asp:BoundField DataField="TabName" SortExpression="TabName" HeaderText="����" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="TabId" SortExpression="TabId" HeaderText="��ID" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FldName" SortExpression="FldName" HeaderText="�ֶ���"></asp:BoundField>
                                    <asp:BoundField DataField="DataTypeName" SortExpression="DataTypeName" HeaderText="����">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="FldLength" SortExpression="FldLength" HeaderText="����">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="IsTabNullable" SortExpression="IsTabNullable" HeaderText="�ɿ�">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="Caption" SortExpression="Caption" HeaderText="����"></asp:BoundField>
                                    
                                    <asp:BoundField DataField="FldId" SortExpression="FldId" HeaderText="�ֶ�ID" Visible="False">
                                    </asp:BoundField>
                                    <asp:BoundField DataField="DefaultValue" SortExpression="DefaultValue" HeaderText="ȱʡֵ"
                                        Visible="False"></asp:BoundField>
                                    <asp:BoundField HeaderText="���" />
                                </Columns>
                            </asp:GridView>
                        </td>
                    </tr>
                </table>
            </td>
            <td style="width: 762px" valign="top">
                <table id="tabSQL" style="width: 460px" runat="server">
                    <tr>
                        <td style="width: 423px" valign="top">
                            <div style="width: 451px; position: relative; left: 0px; top: 0px;" id="divSQL" runat="server">
                                <table style="width: 432px">
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="Label2" runat="server" CssClass="h6">SQL���ݿ���ֶ��б�</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 70px">
                                            <asp:Button ID="btnReCheckConSistency" runat="server" CssClass="btn btn-outline-info btn-sm" Text="���¼��һ����"
                                                Width="114px" OnClick="btnReCheckConSistency_Click" />
                                        </td>
                                        <td style="width: 5px">
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 70px">
                                            <asp:Button ID="btnAddFieldToSqlTable" runat="server" CssClass="btn btn-outline-info btn-sm" OnClick="btnAddFieldToSqlTable_Click"
                                                Text="������ֶ�" Width="100px" />
                                        </td>
                                        <td style="width: 5px">
                                            <asp:Label ID="Label4" runat="server" CssClass="MemoStyle1" Width="293px">��ϵͳ���ֶ���ӵ�SQL���ݱ��С�</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 70px">
                                            <asp:Button ID="btnSynchFldInfo" runat="server" CssClass="btn btn-outline-info btn-sm" Text="ͬ���ֶ���Ϣ"
                                                Width="100px" OnClick="btnSynchFldInfo_Click" />
                                        </td>
                                        <td style="width: 5px">
                                            <asp:Label ID="Label6" runat="server" CssClass="MemoStyle1" Width="293px">��ϵͳ���ֶ�����ͬ����SQL���ݱ��С�</asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td style="width: 70px">
                                            <asp:Button ID="btnDelField_Sql" runat="server" OnClick="btnDelField_Sql_Click" Text="ɾ�����ֶ�"
                                                Width="100px" />
                                        </td>
                                        <td style="width: 5px">
                                            <asp:Label ID="Label9" runat="server" CssClass="MemoStyle1" Width="327px">ɾ��������ѡSql�ֶ�ɾ����</asp:Label>
                                        </td>
                                    </tr>
                                </table>
                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 423px;" valign="top">
                            <asp:GridView ID="gvPrjTabFld_Sql" 
                                Style="z-index: 113; position: relative; top: 0px; left: 0px; width: 447px;" 
                                runat="server" AutoGenerateColumns="False" AllowSorting="True" OnSorting="gvPrjTabFld_Sql_Sorting"
                                OnPageIndexChanging="gvPrjTabFld_Sql_PageIndexChanging" OnRowCreated="gvPrjTabFld_Sql_RowCreated"
                                OnRowCommand="gvPrjTabFld_Sql_RowCommand" BackColor="White" BorderColor="#E7E7FF"
                                BorderStyle="None" BorderWidth="1px" CellPadding="3" 
                                GridLines="Horizontal" Height="1px"
                                DataKeyNames="Column_Name" CssClass="table table-striped table-bordered table-condensed">
                                <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
                                <Columns>
                                    <asp:TemplateField HeaderText="ȫѡ">
                                        <HeaderTemplate>
                                            <asp:LinkButton ID="lbSelAll" runat="server" CommandName="lbSelAll" CssClass="btn btn-link btn-sm text-nowrap">ȫѡ</asp:LinkButton>
                                        </HeaderTemplate>
                                        <HeaderStyle Width="35px" />
                                        <ItemTemplate>
                                            <asp:CheckBox ID="chkCheckRec" runat="server" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:BoundField DataField="Column_Name" HeaderText="�ֶ���" SortExpression="Column_Name" />
                                    <asp:BoundField DataField="Type_Name" HeaderText="����" SortExpression="Type_Name" />
                                    <asp:BoundField DataField="Length" HeaderText="����" SortExpression="Length" />
                                    <asp:BoundField DataField="Is_Nullable" HeaderText="�ɿ�" SortExpression="Is_Nullable" />
                                    <asp:BoundField HeaderText="�����" />
                                </Columns>
                                <PagerTemplate>
                                    <span class="text-secondary">���м�¼:</span>
                                    <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066"
                                        Width="46px">0</asp:Label>
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
                                    <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                                        ErrorMessage="����" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                                </PagerTemplate>
                                <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
                                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
                                <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
                                <AlternatingRowStyle BackColor="#F7F7F7" />
                            </asp:GridView>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 423px" valign="top">
                            <div style="width: 445px; position: relative; height: 32px; left: 0px; top: 3px;"
                                id="divNewTab" runat="server">
                                <asp:Label ID="lblMsg2" runat="server" CssClass="text-warning" Height="35px" Style="z-index: 105;
                                    left: 0px; position: relative; top: 0px">SQL���ݿ��в�������Ӧ��</asp:Label>
                                &nbsp;
                                <asp:Button ID="btnGenNewTabInSQL" runat="server" CssClass="btn btn-outline-info btn-sm" Style="z-index: 105;
                                    left: 197px; position: absolute; top: 4px" Text="�����±�" Width="71px" OnClick="btnGenNewTabInSQL_Click" />
                                &nbsp;
                                <asp:Label ID="Label5" runat="server" CssClass="MemoStyle1" Height="25px" Style="z-index: 105;
                                    left: 82px; position: relative; top: 1px">��SQL���ݿ������ر�</asp:Label></div>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td style="width: 772px">
            </td>
            <td style="width: 762px" valign="top">
            </td>
        </tr>
        <tr>
            <td style="width: 772px">
            </td>
            <td style="width: 762px">
            </td>
        </tr>
    </table>
</asp:Content>
