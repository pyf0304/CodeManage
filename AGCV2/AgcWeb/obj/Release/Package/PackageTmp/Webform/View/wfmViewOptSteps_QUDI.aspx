<%@ Page Language="c#" CodeBehind="wfmViewOptSteps_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewOptSteps_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucViewOptSteps" Src="wucViewOptSteps.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>�����������</title>
    

    <script language="javascript" type="text/javascript">
		<!--
	function radioClick()
	{
		if (document.Form1.RadioName !=null)
		{
			for (i=0; i<document.Form1.RadioName.length; i++)
			{
			    if (document.Form1.RadioName[i].checked == true)
			    {
					document.Form1.rd.value = document.Form1.RadioName[i].value;
					document.getElementById("TextBox1").value = document.Form1.rd.value;
				}
			}
		}
	}
		//-->
    </script>

    
      <script type="text/javascript" src="../../Scripts/jquery-3.6.0.min.js"></script>
    <link href="../../Content/bootstrap.min.css" rel="stylesheet" />
    <script type="text/javascript" src="../../Scripts/bootstrap.min.js"></script>
      <style type="text/css">
        body {
            font-size: 0.875rem;
        }
    </style>
</head>
<body vlink="#000000">
    <form id="Form1" method="post" runat="server">
        <input style="visibility: hidden" onclick="radioClick()" type="radio" value="0" name="RadioName">
        <table style="z-index: 108; left: 2px; width: 382px; position: absolute; top: 2px"
            id="tabLayout">
            <tr>
                <td>
                    <div id="divHead" style="width: 530px; height: 41px; position: relative;">
                        <asp:Label ID="Label3" Style="z-index: 100; left: 8px; position: absolute; top: 8px"
                            runat="server" Width="240px" CssClass="h5">��Ŀ�������->�����������</asp:Label>
                        <asp:LinkButton ID="lbReturn" Style="z-index: 101; left: 805px; position: absolute;
                            top: 20px" runat="server" Width="32px" OnClick="lbReturn_Click">����</asp:LinkButton>
                        <asp:Label ID="Label2" Style="z-index: 102; left: 272px; position: absolute; top: 8px"
                            runat="server" Width="42px" Font-Bold="False" CssClass="MemoStyleH5">˵����</asp:Label>
                        <asp:Label ID="Label4" Style="z-index: 103; left: 328px; position: absolute; top: 8px"
                            runat="server" Height="32px" Width="464px" CssClass="MemoStyle1">��Ҫά���ڽ�����ƹ����У�����������̵�ά�����Դ����������������Ա��Ϊ�ý�����ƴ��롣</asp:Label>
                        <input id="rd" style="z-index: 106; left: 896px; position: absolute; top: 8px" type="hidden"
                            name="rd" runat="server">
                    </div>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabDataGrid" style="width: 677px; height: 418px" bordercolor="#999966"
                        cellspacing="0" cellpadding="0" border="1">
                        <tr>
                            <td style="width: 64px">
                                <asp:Label ID="Label1" runat="server" Width="58px" Font-Bold="False"
                                    CssClass="text-secondary">��������</asp:Label></td>
                            <td style="width: 75px">
                                <asp:Label ID="lblViewName" runat="server" Width="70px">Label</asp:Label></td>
                            <td style="width: 84px">
                                <asp:Label ID="Label5" runat="server" Width="58px" Font-Bold="False"
                                    CssClass="text-secondary">��������</asp:Label></td>
                            <td style="width: 80px">
                                <asp:Label ID="lblPrjName" runat="server" Width="70px">Label</asp:Label></td>
                            <td>
                                <asp:Label ID="Label8" runat="server" Width="58px" Font-Bold="False"
                                    CssClass="text-secondary">��������</asp:Label></td>
                            <td>
                                <asp:Label ID="lblViewTypeName" runat="server" Width="70px">Label</asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 64px">
                                <asp:Label ID="Label9" runat="server" Width="70px" Font-Bold="True"
                                    CssClass="text-secondary">���湦�ܣ�</asp:Label></td>
                            <td style="width: 45px" colspan="5">
                                <asp:Label ID="lblViewFunction" runat="server" Width="376px">Label</asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 64px; height: 122px">
                                <asp:Label ID="Label10" runat="server" Width="70px" Font-Bold="True"
                                    CssClass="text-secondary">��ر�</asp:Label></td>
                            <td style="width: 45px; height: 122px" colspan="5">
                                <asp:DataGrid ID="dgViewRelaTab" runat="server" Font-Names="����" Height="88px" Width="384px"
                                    AutoGenerateColumns="False" PageSize="5" AllowPaging="True" BorderColor="White"
                                    BorderStyle="Ridge" BorderWidth="0px" BackColor="White" CellPadding="0" GridLines="None"
                                    CssClass="table table-striped table-bordered table-condensed">
                                    <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                    <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                    <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                    <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                    <Columns>
                                        <asp:BoundColumn Visible="False" DataField="MId" HeaderText="�ؼ���ID"></asp:BoundColumn>
                                        <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="����ID"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="ViewTabTypeViewTabTypeName" HeaderText="�����������"></asp:BoundColumn>
                                        <asp:BoundColumn DataField="PrjTabTabName" HeaderText="��ر�����"></asp:BoundColumn>
                                    </Columns>
                                    <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                                    </PagerStyle>
                                </asp:DataGrid></td>
                        </tr>
                        <tr>
                            <td style="width: 64px">
                            </td>
                            <td style="width: 75px">
                            </td>
                            <td style="width: 84px">
                            </td>
                            <td style="width: 80px">
                            </td>
                            <td>
                            </td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 149px" colspan="2" rowspan="1">
                                <asp:Label ID="Label6" runat="server" Width="112px" Font-Bold="False"
                                    CssClass="h6">����������̣�</asp:Label></td>
                            <td style="width: 45px">
                            </td>
                            <td style="width: 80px">
                            </td>
                            <td>
                                <asp:Button ID="btnUpdStep" runat="server"  Text="�޸Ĳ���"
                                    OnClick="btnUpdStep_Click"></asp:Button></td>
                            <td>
                                <asp:Button ID="btnDelStep" runat="server"  Text="ɾ������"
                                    OnClick="btnDelStep_Click"></asp:Button></td>
                        </tr>
                        <tr>
                            <td style="width: 67px" colspan="6">
                                <table id="Table2" style="width: 456px; height: 168px" cellspacing="0" cellpadding="0"
                                    width="456" border="0">
                                    <tr>
                                        <td>
                                            <asp:ImageButton ID="ibUp" runat="server" Height="28px" Width="24px" ImageUrl="~/pic/Up.JPG">
                                            </asp:ImageButton></td>
                                        <td rowspan="2">
                                            <asp:DataGrid ID="dgViewOptSteps" runat="server" Font-Names="����" Height="152px" Width="432px"
                                                DataKeyField="mId" AutoGenerateColumns="False" PageSize="5" AllowPaging="True"
                                                BorderColor="White" BorderStyle="Ridge" BorderWidth="0px" BackColor="White" CellPadding="0"
                                                GridLines="None" CssClass="table table-striped table-bordered table-condensed">
                                                <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                                                <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                                                <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                                                <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                                                <Columns>
                                                    <asp:TemplateColumn>
                                                        <ItemTemplate>
                                                            <input type="radio" onclick="radioClick()" value='<%# DataBinder.Eval(Container.DataItem, "StepIndex")%>'
                                                                name="RadioName">
                                                        </ItemTemplate>
                                                    </asp:TemplateColumn>
                                                    <asp:BoundColumn Visible="False" DataField="MId" HeaderText="����ID"></asp:BoundColumn>
                                                    <asp:BoundColumn Visible="False" DataField="ViewInfoViewName" HeaderText="����ID"></asp:BoundColumn>
                                                    <asp:BoundColumn DataField="StepIndex" HeaderText="�������"></asp:BoundColumn>
                                                    <asp:BoundColumn DataField="StepName" HeaderText="��������"></asp:BoundColumn>
                                                    <asp:BoundColumn DataField="StepDetail" HeaderText="������ϸ˵��"></asp:BoundColumn>
                                                </Columns>
                                                <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                                                </PagerStyle>
                                            </asp:DataGrid></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:ImageButton ID="ibDown" runat="server" Height="28px" Width="24px" ImageUrl="~/pic/Down.JPG">
                                            </asp:ImageButton></td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 149px" colspan="2" rowspan="1">
                                <asp:Label ID="lblRecCount" runat="server" Font-Names="����"  Width="110px"
                                    CssClass="text-secondary">��ѯ�����¼����</asp:Label></td>
                            <td style="width: 173px" colspan="2" rowspan="1">
                                <asp:TextBox ID="txtRecCount" runat="server" Font-Names="����"  Width="111px"
                                    ReadOnly="True"></asp:TextBox></td>
                            <td style="width: 84px">
                            </td>
                            <td>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td>
                    <table id="tabEditRegion" style="width: 649px; height: 200px" bordercolor="#660033"
                        cellspacing="1" cellpadding="1" border="1">
                        <tr>
                            <td style="width: 497px" valign="top" colspan="1" rowspan="1">
                                <asp:Button ID="btnOKUpd" runat="server"   Text="���" OnClick="btnOKUpd_Click">
                                </asp:Button><asp:Label ID="lblMsg" runat="server"  Width="215px" CssClass="text-warning"></asp:Label></td>
                        </tr>
                        <tr>
                            <td style="width: 497px" valign="top">
                                <uc1:wucViewOptSteps ID="wucViewOptSteps1" runat="server"></uc1:wucViewOptSteps>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
