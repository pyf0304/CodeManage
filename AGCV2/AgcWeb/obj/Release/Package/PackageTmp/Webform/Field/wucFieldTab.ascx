<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucFieldTab.ascx.cs"
    Inherits="AGC.Webform.wucFieldTab" %>
<script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
<link href="../../Content/bootstrap.min.css" rel="stylesheet" />
<script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
<table id="tabwucFieldTab" style="width: 828px" cellspacing="1" cellpadding="1" border="0">
    <tr>
        <td colspan="6">
            <asp:Label ID="Label4" runat="server" CssClass="RegionTitleH2" Width="160px">�ֶλ�����Ϣ:</asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="6" style="height: 5px">

            <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 785px">
                <tr>
                    <td style="width: 85px">
                        <asp:Label ID="lblFldName" runat="server" CssClass="text-secondary">�ֶ�����</asp:Label>
                    </td>
                    <td style="width: 143px">
                        <asp:TextBox ID="txtFldName" CssClass="form-control-sm" runat="server" Width="280px"></asp:TextBox>
                    </td>
                    <td style="width: 57px">
                        <asp:Label ID="lblFldStateId" runat="server" Width="80px" CssClass="text-secondary">�ֶ�״̬</asp:Label>
                    </td>
                    <td style="width: 78px">

                        <asp:DropDownList ID="ddlFldStateId" Width="144px" CssClass="form-control-sm" runat="server"></asp:DropDownList>

                    </td>

                </tr>
                <tr>
                    <td style="width: 85px">
                        <asp:Label ID="lblCaption" runat="server" CssClass="text-secondary">��������</asp:Label>
                    </td>
                    <td style="width: 143px">
                        <asp:TextBox ID="txtCaption" runat="server" CssClass="form-control-sm" Width="280px"></asp:TextBox>
                    </td>
                    <td style="width: 157px" colspan="2">
                        <div style="width: 288px; position: relative; height: 20px" class="btn-group" role="group" aria-label="Basic example">
                            <asp:CheckBox ID="chkIsPrimaryKey" runat="server" Text="�Ƿ�����" CssClass="form-control-sm"></asp:CheckBox>
                            <asp:CheckBox ID="chkIsIdentity" runat="server" Text="�Ƿ�Identity" CssClass="form-control-sm"></asp:CheckBox>

                        </div>
                    </td>

                </tr>
                <tr>
                    <td style="width: 65px">
                        <asp:Label ID="Label10" runat="server" CssClass="text-secondary">�ֶ�����</asp:Label>
                    </td>
                    <td style="width: 143px">
                        <asp:DropDownList ID="ddlFieldTypeId" runat="server" CssClass="form-control-sm" Width="150px"></asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="lblFldStateId0" runat="server" Width="80px" CssClass="text-secondary">ͬԴ�ֶ�</asp:Label>
                    </td>
                    <td>

                        <asp:DropDownList ID="ddlHomologousFldId" Width="202px" CssClass="form-control-sm" runat="server" ></asp:DropDownList>

                    </td>
                </tr>

            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label5" runat="server" Width="132px" CssClass="RegionTitleH2">�ֶ�������Ϣ:</asp:Label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="�ֶγ��Ȳ���Ϊ��!"
                ControlToValidate="txtFldLength" CssClass="text-warning" Width="159px"></asp:RequiredFieldValidator><font
                    face="����"></font>
        </td>
    </tr>
    <tr>
        <td colspan="6">

            <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="768">
        </td>
    </tr>
    <tr>
        <td>
            <table style="width: 910px">
                <tr>
                    <td style="width: 85px">
                        <asp:Label ID="lblFldType" Width="80px" runat="server" CssClass="text-secondary">��������</asp:Label>
                    </td>
                    <td style="width: 127px">
                        <asp:DropDownList ID="ddlFldType" runat="server" CssClass="form-control-sm" Width="150px"></asp:DropDownList>
                    </td>
                    <td style="width: 77px">
                        <asp:Label ID="lblFldLength" runat="server" Width="80px" CssClass="text-secondary">�ֶγ���</asp:Label>
                    </td>
                    <td style="width: 68px">
                        <asp:TextBox ID="txtFldLength" runat="server" CssClass="form-control-sm" Width="150px"></asp:TextBox>
                    </td>
                    <td style="width: 58px">
                        <asp:Label ID="lblMaxValue0" runat="server" CssClass="text-secondary" Width="70px">С��λ��</asp:Label>
                    </td>
                    <td style="width: 98px">
                        <asp:TextBox ID="txtFldPrecision" runat="server" CssClass="form-control-sm"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 65px">
                        <asp:Label ID="lblIsNull" runat="server" CssClass="text-secondary">�Ƿ�ɿ�</asp:Label>
                    </td>
                    <td style="width: 127px">
                        <asp:DropDownList ID="ddlIsNull" runat="server" CssClass="form-control-sm" Width="150px">
                        </asp:DropDownList>
                    </td>
                    <td style="width: 77px">
                        <asp:Label ID="lblDefaultValue" runat="server" CssClass="text-secondary">ȱʡֵ</asp:Label>
                    </td>
                    <td style="width: 68px">
                        <asp:TextBox ID="txtDefaultValue" runat="server" CssClass="form-control-sm" Width="150px"></asp:TextBox>
                    </td>
                    <td style="width: 58px">
                        <asp:Label ID="lblMinValue" runat="server" CssClass="text-secondary">��Сֵ</asp:Label>
                    </td>
                    <td style="width: 98px">
                        <asp:TextBox ID="txtMinValue" runat="server" CssClass="form-control-sm"></asp:TextBox>
                    </td>
                    <td style="width: 98px">
                        <asp:Label ID="lblMaxValue" runat="server" Width="60px" CssClass="text-secondary">���ֵ</asp:Label>
                    </td>
                    <td style="width: 98px">
                        <asp:TextBox ID="txtMaxValue" runat="server" CssClass="form-control-sm"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" CssClass="RegionTitleH2">��ض���:</asp:Label>
        </td>
    </tr>
    <tr>
        <td colspan="6">
            <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="680">
        </td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <div style="width: 747px; position: relative; height: 140px; left: 11px; top: 8px;">
                        <asp:Label ID="Label8" Style="z-index: 102; left: 8px; position: absolute; top: 0px"
                            runat="server" CssClass="text-secondary">Դ���б�</asp:Label>
                        <asp:ListBox ID="lstTabList" Style="z-index: 103; left: 304px; position: absolute; top: 26px"
                            Width="209" runat="server" Height="104" SelectionMode="Multiple"></asp:ListBox>
                        <asp:Label ID="Label9" Style="z-index: 104; left: 304px; position: absolute; top: 0px"
                            runat="server" CssClass="text-secondary">��ѡ���б�</asp:Label>
                        <asp:LinkButton ID="lbAddRelaTab" Style="z-index: 105; left: 248px; position: absolute; top: 40px; height: 16px;"
                            runat="server" OnClick="lbAddRelaTab_Click">>></asp:LinkButton>
                        <asp:LinkButton ID="lbDelRelaTab" Style="z-index: 106; left: 248px; position: absolute; top: 72px"
                            runat="server" OnClick="lbDelRelaTab_Click"><<</asp:LinkButton>
                        <asp:ListBox ID="lstSouTabList" Style="z-index: 107; left: 8px; position: absolute; top: 26px"
                            Width="209px" runat="server" Height="104"></asp:ListBox>
                        <asp:LinkButton ID="lbEditTab" OnClick="lbEditTab_Click" Style="z-index: 107; left: 534px; position: absolute; top: 18px"
                            runat="server">�༭��ѡ���̱�</asp:LinkButton>
                    </div>
                </ContentTemplate>
            </asp:UpdatePanel>
        </td>
    </tr>
    <tr>
        <td>

            <asp:Label ID="Label2" runat="server" CssClass="RegionTitleH2">����ת��:</asp:Label></font>
        </td>
    </tr>
    <tr>
        <td colspan="6">

            <img style="width: 600px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="768"></font>
        </td>
    </tr>
    <tr>
        <td>
            <asp:UpdatePanel ID="FieldTabUpdatePanel" runat="server" UpdateMode="Conditional">
                <ContentTemplate>
                    <table>
                        <tr>
                            <td colspan="2">
                                <asp:CheckBox ID="chkIsNeedTransCode" runat="server" Width="244px" Text="�Ƿ���Ҫ����ת����"
                                    AutoPostBack="True" CssClass="text-secondary" OnCheckedChanged="chkIsNeedTransCode_CheckedChanged"></asp:CheckBox>
                            </td>
                            <td>
                                <asp:Label ID="lblCodeTab" runat="server" CssClass="text-secondary">�����</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCodeTab" runat="server" Width="300px" AutoPostBack="True"
                                    Visible="False"
                                    OnSelectedIndexChanged="ddlCodeTab_SelectedIndexChanged">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="lblCodeTabCode" runat="server"
                                    CssClass="text-secondary">�����ֶ�</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCodeTabCode" runat="server" Width="280px"
                                    Visible="False">
                                </asp:DropDownList>
                            </td>
                            <td>
                                <asp:Label ID="lblCodeTabName" runat="server"
                                    CssClass="text-secondary" Width="70px">�����ֶ�</asp:Label>
                            </td>
                            <td>
                                <asp:DropDownList ID="ddlCodeTabName" runat="server" Width="280px"
                                    Visible="False" Style="z-index: 103;">
                                </asp:DropDownList>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:UpdatePanel>
            &nbsp; &nbsp;
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" CssClass="RegionTitleH2">�ֶ�˵��:</asp:Label>
        </td>
    </tr>
    <tr>
        <td>

            <img style="width: 574px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"></font>
        </td>
    </tr>
    <tr>
        <td>
            <asp:TextBox ID="txtFldInfo" runat="server" Width="575px" Height="80px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>

            <asp:CompareValidator ID="ComValid_FldLength" runat="server" Width="160px" EnableClientScript="False"
                Operator="DataTypeCheck" Type="Integer" ControlToValidate="txtFldLength" ErrorMessage="������������ֵ!"
                CssClass="text-warning"></asp:CompareValidator>&nbsp;
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="0" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server" CssClass="text-secondary">����ID</asp:Label>
        </td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="150px">
            </asp:DropDownList>
        </td>
        <td></td>
    </tr>

    <tr>
        <td>
            <asp:Label ID="lblFldID" runat="server" CssClass="text-secondary">�ֶ�ID</asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtFldID" Width="96px" runat="server"></asp:TextBox>
        </td>
        <td></td>
    </tr>
</table>
