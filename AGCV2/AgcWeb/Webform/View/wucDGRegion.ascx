<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucDGRegion.ascx.cs"
    Inherits="AGC.Webform.wucDGRegion" %>

<table id="tabwucDGRegion" cellspacing="1" cellpadding="1" width="600" border="0"
    style="width: 600px; height: 408px">
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 212px">
                    <asp:Label ID="Label27" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" Font-Names="��Բ" runat="server" Width="616px">1��DataGrid������Ϣ</asp:Label>
                    <table id="Table6" style="z-index: 106; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 40px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 95px" valign="top">
                                <asp:Label ID="lblViewDgName" CssClass="col-form-label text-right"
                                    runat="server">����Dg����</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtViewDgName" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 255px; height: 18px">
                                    ���ɵ�DataGrid������</font></div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblDGStyleId" CssClass="col-form-label text-right"
                                    runat="server">DGģʽID</asp:Label></td>
                            <td>
                                <asp:DropDownList ID="ddlDGStyleId" runat="server"
                                    Width="200px">
                                </asp:DropDownList></td>
                            <td>
                                
                                    <div class="MemoStyle1" style="display: inline; width: 286px; height: 32px">
                                        ����Աѡ��һ��ģʽ����Ծ���DataGrid�Ĳ�������</div>
                                </font>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblRunat" runat="server">������</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtRunat" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    һ��Ĭ��ΪServer,˵���Ƿ������˿ؼ���</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblFontName" runat="server">����</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtFontName" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    DataGrid������</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:Label ID="lblFontSize" CssClass="col-form-label text-right"
                                    runat="server">�ֺ�</asp:Label></td>
                            <td>
                                <asp:TextBox ID="txtFontSize" runat="server"
                                    Width="200px"></asp:TextBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    DataGrid���ֺ�</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 95px">
                                <asp:CheckBox ID="chkAutoGenerateColumns"
                                    runat="server" Text="�Զ�������" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 287px; height: 15px">
                                    DataGrid�Ƿ��������Դ���ֶ���</div>
                            </td>
                        </tr>
                    </table>
                </div>
            </font></font>
        </td>
    </tr>
    <tr>
        <td>
            
        </td>
        <td>
        </td>
        <td>
            
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 155px">
                    
                    <asp:Label ID="Label22" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" Font-Names="��Բ" runat="server" Width="616px">2����ҳ������</asp:Label>
                    <table id="Table5" style="z-index: 106; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 40px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 81px" valign="top">
                                <asp:Label ID="Label18" runat="server" CssClass="col-form-label text-right">�����ҳ</asp:Label></td>
                            <td style="width: 225px">
                                <asp:CheckBox ID="chkAllowPaging" runat="server"
                                    Text="�����ҳ" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 288px; height: 32px">
                                    DataGrid�Ƿ���Է�ҳ��ʹDataGrid���Զ�ҳ��ʾ���ݱ�ļ�¼��</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px">
                                <asp:Label ID="lblPageSize" runat="server" CssClass="col-form-label text-right">ҳ��С</asp:Label></td>
                            <td style="width: 225px">
                                <asp:TextBox ID="txtPageSize" runat="server"
                                    ></asp:TextBox>
                                <asp:CompareValidator ID="ComValid_PageSize"
                                    runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                    ControlToValidate="txtPageSize" ErrorMessage="������������ֵ!" CssClass="text-warning"></asp:CompareValidator></td>
                            <td>
                                
                                    <div class="MemoStyle1" style="display: inline; width: 288px; height: 24px">
                                        DataGrid����ҳ������ÿһҳ�Ĵ�С</div>
                                </font>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px">
                                <asp:CheckBox ID="chkIsJumpPage" runat="server"
                                    Text="�Ƿ���ҳ" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td style="width: 225px">
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 288px; height: 15px">
                                    ��DataGrid���·����Ƿ���ʾ��ҳ�ؼ������磺&lt;��һҳ&gt;��&lt;��һҳ&gt;��&lt;��һҳ&gt;��&lt;���һҳ&gt;��</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 81px">
                                <asp:CheckBox ID="chkAllowSorting" runat="server"
                                    Text="��������" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td style="width: 225px">
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 288px; height: 15px">
                                    DataGrid�Ƿ���������ܡ�</div>
                            </td>
                        </tr>
                    </table>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <div style="width: 632px; position: relative; height: 114px">
                
                <asp:Label ID="Label1" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                    CssClass="RegionTitleH3" Font-Names="��Բ" runat="server" Width="616px">3��ѡȡ��¼�ķ�ʽ</asp:Label>
                <table id="Table1" style="z-index: 106; left: 16px; width: 616px; position: absolute;
                    top: 32px; height: 76px" cellspacing="1" cellpadding="1" width="616" border="0">
                    <tr>
                        <td style="width: 81px" valign="top">
                            <asp:RadioButton ID="rbIsCheck" runat="server"
                                Text="��ѡ��" GroupName="SelRecordMode" CssClass="Radio_DEfa"></asp:RadioButton></td>
                        <td>
                            <asp:Label ID="Label2" CssClass="MemoStyle1"
                                runat="server">DataGridʹ�ø�ѡ����ѡȡ��¼����һ��ѡȡ������¼������ѡʱֻ�޸�ѡȡ�ĵ�һ����¼��</asp:Label></td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 81px">
                            <asp:RadioButton ID="rbIsRadio" runat="server"
                                Text="��ѡ��" GroupName="SelRecordMode" CssClass="Radio_DEfa"></asp:RadioButton></td>
                        <td>
                            <asp:Label ID="Label3" CssClass="MemoStyle1"
                                runat="server">DataGridʹ�õ�ѡ����ѡȡ��¼��һ��ֻ��ѡȡһ����¼��</asp:Label></td>
                        <td>
                            
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 81px">
                            <asp:RadioButton ID="rbNoSelRecordMode"
                                runat="server" Text="�޵���ѡ" GroupName="SelRecordMode" CssClass="Radio_DEfa"></asp:RadioButton></td>
                        <td>
                            
                                <asp:Label ID="Label4" CssClass="MemoStyle1"
                                    runat="server">DataGrid��ʹ�õ�ѡ��Ҳ��ʹ�ø�ѡ��</asp:Label></font></td>
                        <td>
                            
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 116px">
                    <asp:Label ID="Label5" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" runat="server" Width="616px">4��DataGrid�İ�ť���</asp:Label>
                    <table id="Table2" style="z-index: 103; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 77px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 124px">
                                <asp:CheckBox ID="chkIsHaveUpdBtn" runat="server"
                                    Text="�Ƿ����޸İ�ť" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 472px; height: 19px">
                                    ��DataGrid�У�ר������һ������&lt;�޸�&gt;����������Դ����޸ļ�¼���¼�����</div>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 124px">
                                <asp:CheckBox ID="chkIsHaveDelBtn" runat="server"
                                    Text="�Ƿ���ɾ����ť" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 70px; height: 15px">
                                    <div class="MemoStyle1" style="display: inline; width: 472px; height: 19px">
                                        ��DataGrid�У����ɹ�����&lt;ɾ��&gt;����������Դ���ɾ����¼���¼�����</div>
                                </div>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 124px">
                                <asp:CheckBox ID="chkIsHaveDetailBtn" runat="server"
                                    Text="�Ƿ�����ϸ��ť" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 472px; height: 19px">
                                    ��DataGrid�У����ɹ�����&lt;��ϸ��Ϣ&gt;�����Դ�����ʾ��ϸ��Ϣ���¼�����</div>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            <div style="width: 632px; position: relative; height: 225px">
                <asp:Label ID="Label12" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                    CssClass="RegionTitleH3" runat="server" Width="616px">5��DataGrid�Ĵ�С��λ��</asp:Label>
                <table id="Table3" style="z-index: 103; left: 16px; width: 616px; position: absolute;
                    top: 32px; height: 77px" cellspacing="1" cellpadding="1" width="616" border="0">
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblWidth" runat="server" CssClass="text-secondary">��</asp:Label></td>
                        <td>
                            
                                <asp:TextBox ID="txtWidth" runat="server"
                                    Width="120px"></asp:TextBox>
                                <asp:CompareValidator ID="ComValid_Width"
                                    runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                    ControlToValidate="txtWidth" ErrorMessage="������������ֵ!" CssClass="text-warning"></asp:CompareValidator></font></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 21px">
                                DataGrid�Ŀ��</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblHeight" runat="server" CssClass="text-secondary">�߶�</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtHeight" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Height"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtHeight" ErrorMessage="������������ֵ!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                DataGrid�ĸ߶�</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            
                                <asp:Label ID="lblStyle_Zindex" runat="server" CssClass="text-secondary">Style_Zindex</asp:Label></font></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Zindex" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Style_Zindex"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtStyle_Zindex" ErrorMessage="������������ֵ!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                ˵��</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblStyle_Position" runat="server" CssClass="text-secondary">Style_Position</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Position" runat="server"
                                Width="120px"></asp:TextBox></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 220px; height: 32px">
                                DataGrid��λ�����ͣ����ԡ���Ե�</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblStyle_Left" runat="server" CssClass="text-secondary">Style_Left</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Left" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Style_Left"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtStyle_Left" ErrorMessage="������������ֵ!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                DataGrid�ľ���ҳ�ߵľ���</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                            <asp:Label ID="lblStyle_Top" runat="server" CssClass="text-secondary">Style_Top</asp:Label></td>
                        <td>
                            <asp:TextBox ID="txtStyle_Top" runat="server"
                                Width="120px"></asp:TextBox>
                            <asp:CompareValidator ID="ComValid_Style_Top"
                                runat="server" EnableClientScript="false" Operator="DataTypeCheck" Type="Integer"
                                ControlToValidate="txtStyle_Top" ErrorMessage="������������ֵ!" CssClass="text-warning"></asp:CompareValidator></td>
                        <td>
                            <div class="MemoStyle1" style="display: inline; width: 168px; height: 15px">
                                DataGrid�ľ���ҳ�ߵľ���</div>
                        </td>
                        <td>
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 124px">
                        </td>
                        <td>
                        </td>
                        <td>
                            
                        </td>
                        <td>
                        </td>
                    </tr>
                </table>
            </div>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="4">
            
                <div style="width: 632px; position: relative; height: 117px">
                    <asp:Label ID="Label19" Style="z-index: 101; left: 8px; position: absolute; top: 8px"
                        CssClass="RegionTitleH3" runat="server" Width="616px">6����������</asp:Label>
                    <table id="Table4" style="z-index: 103; left: 16px; width: 616px; position: absolute;
                        top: 32px; height: 24px" cellspacing="1" cellpadding="1" width="616" border="0">
                        <tr>
                            <td style="width: 145px">
                                <asp:CheckBox ID="chkIsInTab" runat="server"
                                    Text="�Ƿ�����DG�ڱ���" CssClass="Check_Defa"></asp:CheckBox></td>
                            <td>
                            </td>
                            <td>
                                <div class="MemoStyle1" style="display: inline; width: 254px; height: 15px">
                                    DataGrid�Ƿ����һ������С�</div>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 145px">
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
        </td>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td class="NameTD">
            <asp:Label ID="lblMemo" runat="server" >˵��</asp:Label>
        </td>
        <td colspan="3">
            
                <asp:TextBox ID="txtMemo" runat="server" 
                    Width="402px" Height="74px" TextMode="MultiLine"></asp:TextBox></font></td>
    </tr>
    <tr>
        <td width="120">
            
        </td>
        <td width="150" colspan="1" rowspan="1">
            
        </td>
        <td width="150">
            
        </td>
        <td width="150" colspan="1" rowspan="1">
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblStyle" runat="server"  CssClass="col-form-label text-right"
                >����</asp:Label></td>
        <td>
            <asp:TextBox ID="txtStyle" runat="server"
                Visible="False"></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
</table>
