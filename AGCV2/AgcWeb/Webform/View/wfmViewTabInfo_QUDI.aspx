<%@ Register TagPrefix="uc1" TagName="wucViewTabInfo" Src="wucViewTabInfo.ascx" %>

<%@ Page Language="c#" CodeBehind="wfmViewTabInfo_QUDI.aspx.cs" AutoEventWireup="True"
    Inherits="AGC.Webform.wfmViewTabInfo_QUDI" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd" >
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>��ViewTabInfo�Ĳ�ѯ���޸ġ�ɾ������Ӽ�¼</title>
      <script type="text/javascript" src="../../Scripts/jquery-3.4.1.min.js"></script>
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
        
            <asp:Label ID="lblTitle" Style="z-index: 101; left: 200px; position: absolute; top: 20px"
                runat="server" Width="432px" Height="33px" Font-Names="����" Font-Size="Larger">ViewTabInfo��Ĳ�ѯ���޸ġ�ɾ�������</asp:Label>
            <asp:Label ID="lblViewId_q" Style="z-index: 103; left: 200px; position: absolute;
                top: 85px" runat="server" Width="100px" >����ID</asp:Label>
            <asp:DropDownList ID="ddlViewId_q" Style="z-index: 104; left: 300px; position: absolute;
                top: 85px" runat="server" Width="128px" >
            </asp:DropDownList>
            <asp:Label ID="lblDataBaseName_q" Style="z-index: 105; left: 200px; position: absolute;
                top: 110px" runat="server" Width="100px" >���ݿ���</asp:Label>
            <asp:TextBox ID="txtDataBaseName_q" Style="z-index: 106; left: 300px; position: absolute;
                top: 110px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Label ID="lblTabName_q" Style="z-index: 107; left: 200px; position: absolute;
                top: 135px" runat="server" Width="100px" >����</asp:Label>
            <asp:TextBox ID="txtTabName_q" Style="z-index: 108; left: 300px; position: absolute;
                top: 135px" runat="server" Width="100px" ></asp:TextBox>
            <asp:Button ID="btnQuery" Style="z-index: 109; left: 452px; position: absolute; top: 160px"
                runat="server" Width="78px" Height="28px" Text="��ѯ"></asp:Button>
            <asp:DataGrid ID="dgViewTabInfo" Style="z-index: 110; left: 67px; position: absolute;
                top: 200px" runat="server" Width="463px" Height="154px" AutoGenerateColumns="False"
                PageSize="5" AllowPaging="True" Font-Names="����" >
                <Columns>
                    <asp:BoundColumn DataField="MId" HeaderText="����ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="ViewId" HeaderText="����ID"></asp:BoundColumn>
                    <asp:BoundColumn DataField="DataBaseName" HeaderText="���ݿ���"></asp:BoundColumn>
                    <asp:BoundColumn DataField="TabName" HeaderText="����"></asp:BoundColumn>
                    <asp:HyperLinkColumn Text="��������" HeaderText="��������" NavigateUrl='wfmViewOptSteps.aspx?ViewId=<% #Container.DataItem("ViewId") %>'>
                    </asp:HyperLinkColumn>
                    <asp:ButtonColumn Text="�޸�" CommandName="Update"></asp:ButtonColumn>
                    <asp:TemplateColumn>
                        <ItemTemplate>
                            <asp:LinkButton ID="lbnDelete" runat="Server" CommandName="Delete" Text="ɾ��"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateColumn>
                </Columns>
                <PagerStyle Mode="NumericPages"></PagerStyle>
            </asp:DataGrid>
            <asp:Label ID="lblRecCount" Style="z-index: 111; left: 137px; position: absolute;
                top: 360px" runat="server" Width="110px"  Font-Names="����" >��ѯ�����¼����</asp:Label>
            <asp:TextBox ID="txtRecCount" Style="z-index: 112; left: 259px; position: absolute;
                top: 360px" runat="server" Width="111px"  Font-Names="����" 
                ReadOnly="True"></asp:TextBox>
            <table id="tabLayout" style="z-index: 113; left: 65px; width: 373px; position: absolute;
                top: 385px; height: 200px" cellspacing="1" cellpadding="1" width="373" border="1">
                <tr>
                    <td>
                        <uc1:wucViewTabInfo id="wucViewTabInfo1" runat="server">
                        </uc1:wucViewTabInfo></td>
                </tr>
            </table>
            <asp:Button ID="btnOKUpd" Style="z-index: 114; left: 460px; position: absolute; top: 385px"
                runat="server" Width="83px" Height="31px" Text="���"></asp:Button>
            <asp:Label ID="lblMsg" Style="z-index: 115; left: 461px; position: absolute; top: 420px"
                runat="server" Width="215px" Height="27px"></asp:Label>
        </font>
    </form>
</body>
</html>
