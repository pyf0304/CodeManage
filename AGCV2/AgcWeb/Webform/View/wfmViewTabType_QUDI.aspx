<%@ Page Language="c#" CodeBehind="wfmViewTabType_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewTabType_QUDI" %>

<%@ Register TagPrefix="uc1" TagName="wucViewTabType" Src="wucViewTabType.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>��ViewTabType�Ĳ�ѯ���޸ġ�ɾ������Ӽ�¼</title>
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
        
            <asp:Label ID="Label3" Style="z-index: 112; left: 8px; position: absolute; top: 8px"
                runat="server" Font-Size="Larger" Font-Names="����" Width="256px"
                ForeColor="Blue">��Ŀ�������->���������ά��</asp:Label>
            <asp:Label ID="Label2" Style="z-index: 103; left: 272px; position: absolute; top: 8px"
                runat="server"  Width="42px"
                ForeColor="#004040" Font-Bold="True">˵����</asp:Label>
            <asp:Label ID="Label4" Style="z-index: 101; left: 328px; position: absolute; top: 8px"
                runat="server"  Height="32px" Width="464px"
                ForeColor="#004040">��Ҫά���������صı�����ͣ����磺�༭����������ϸ����ر��ο����Դ˱�ʶ�����Ĺ��ܡ�</asp:Label>
            <table id="tabLayout" style="z-index: 109; left: 464px; width: 373px; position: absolute;
                top: 48px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="4"
                bordercolor="#333333">
                <tr>
                    <td valign="top">
                        <asp:Button ID="btnOKUpd" runat="server"   Text="���"></asp:Button>
                        <asp:Label ID="lblMsg" runat="server" Width="215px" ></asp:Label></td>
                </tr>
                <tr>
                    <td valign="top">
                        <uc1:wucViewTabType id="wucViewTabType1" runat="server">
                        </uc1:wucViewTabType></td>
                </tr>
            </table>
            <table id="tabQuery" style="z-index: 113; left: 2px; position: absolute; top: 48px"
                bordercolor="#666666" cellspacing="1" cellpadding="1" width="300" border="4">
                <tr>
                    <td>
                        <asp:Label ID="lblViewTabTypeNameq" runat="server" Width="100px"  
                            >�������������</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtViewTabTypeNameq" runat="server" Width="100px" ></asp:TextBox></td>
                    <td>
                        <asp:Button ID="btnQuery" runat="server"  Text="��ѯ"></asp:Button></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:DataGrid ID="dgViewTabType" runat="server" Width="448px" Height="154px" AutoGenerateColumns="False"
                            AllowPaging="True" Font-Names="����" Font-Size="Smaller" BorderColor="White" BorderStyle="Ridge"
                            BorderWidth="2px" CellSpacing="1" BackColor="White" CellPadding="3" GridLines="None">
                            <FooterStyle ForeColor="Black" BackColor="#C6C3C6"></FooterStyle>
                            <SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#9471DE"></SelectedItemStyle>
                            <ItemStyle ForeColor="Black" BackColor="#DEDFDE"></ItemStyle>
                            <HeaderStyle Font-Bold="True" ForeColor="#E7E7FF" BackColor="#4A3C8C"></HeaderStyle>
                            <Columns>
                                <asp:BoundColumn DataField="ViewTabTypeId" HeaderText="�����������"></asp:BoundColumn>
                                <asp:BoundColumn DataField="ViewTabTypeName" HeaderText="�������������"></asp:BoundColumn>
                                <asp:ButtonColumn Text="�޸�" CommandName="Update"></asp:ButtonColumn>
                                <asp:TemplateColumn>
                                    <ItemTemplate>
                                        <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="ɾ��"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateColumn>
                            </Columns>
                            <PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#C6C3C6" Mode="NumericPages">
                            </PagerStyle>
                        </asp:DataGrid></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblRecCount" runat="server" Width="110px"  Font-Names="����"
                            Font-Size="Smaller">��ѯ�����¼����</asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtRecCount" runat="server" Width="111px"  Font-Names="����"
                            Font-Size="Smaller" ReadOnly="True"></asp:TextBox></td>
                    <td>
                    </td>
                </tr>
            </table>
        </font>
    </form>
</body>
</html>
