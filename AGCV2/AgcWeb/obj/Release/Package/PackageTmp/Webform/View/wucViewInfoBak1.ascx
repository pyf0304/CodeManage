<%@ Control Language="c#" AutoEventWireup="True" CodeBehind="wucViewInfoBak1.ascx.cs"
    Inherits="AGC.Webform.wucViewInfoBak" %>
<table id="tabwucViewInfo" cellspacing="1" cellpadding="1" width="744" border="0"
    style="width: 744px; height: 448px">
    <tr>
        <td colspan="6" style="width: 75px">
            
                <asp:Label ID="Label1" runat="server" Width="96px"  ForeColor="#004040">���������Ϣ:</asp:Label></font></td>
    </tr>
    <tr>
        <td colspan="6" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="768"></td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblViewName" runat="server">��������</asp:Label>
        </td>
        <td style="width: 123px">
            <asp:TextBox ID="txtViewName" runat="server"  Width="200px" AutoPostBack="True"></asp:TextBox>
        </td>
        <td style="width: 59px">
            
                <asp:Label ID="lblViewCnName" runat="server">��������</asp:Label></font>
        </td>
        <td style="width: 120px">
            <asp:TextBox ID="txtViewCnName" runat="server" Width="181px" AutoPostBack="True"></asp:TextBox></td>

    </tr>
    <tr>
        <td style="width: 75px">
            <asp:Label ID="lblFileName" runat="server">�ļ���</asp:Label></td>
        <td style="width: 123px">
            <asp:TextBox ID="txtFileName" runat="server" Width="200px"></asp:TextBox></td>
        <td style="width: 59px">
            
                <asp:Label ID="lblFilePath" runat="server">�ļ�·��</asp:Label></font></td>
        <td style="width: 120px">
            <asp:TextBox ID="txtFilePath" runat="server" Width="181"></asp:TextBox></td>
        <td style="width: 70px">
            <asp:Label ID="lblFuncModuleId" runat="server">����ģ��Id</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlFuncModuleId" runat="server" Width="128px">
            </asp:DropDownList></td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="2">
            <asp:CheckBox ID="chkIsNeedSort" runat="server" Text="DataGrid�Ƿ���Ҫ����" Width="160px">
            </asp:CheckBox></td>
        <td style="width: 83px" colspan="2">
            <asp:CheckBox ID="chkIsNeedTransCode" runat="server" Width="208px" Text="DataGrid���Ƿ���Ҫת������">
            </asp:CheckBox></td>
        <td style="width: 70px">
            
                <asp:Label ID="lblDefaMenuName" runat="server">Ĭ�ϲ˵���</asp:Label></font></td>
        <td>
            
                <asp:TextBox ID="txtDefaMenuName" runat="server" Width="136px"></asp:TextBox></font></td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="6">
            
                <asp:Label ID="Label3" runat="server" Width="128px"  ForeColor="#004040">������ر���Ϣ:</asp:Label></font></td>
    </tr>
    <tr>
        <td style="width: 75px" colspan="6">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="768"></td>
    </tr>
    <tr>
        <td style="width: 75px">
            <asp:RadioButtonList ID="rblMainTabType" Width="55px" runat="server" AutoPostBack="True">
                <asp:ListItem Value="��" Selected="True">��</asp:ListItem>
                <asp:ListItem Value="��ͼ">��ͼ</asp:ListItem>
            </asp:RadioButtonList></td>
        <td style="width: 123px">
            <div style="width: 185px; position: relative; height: 22px" id="divMainTab" runat="server">
                <asp:Label ID="lblMainTabName" runat="server" Style="z-index: 101; left: 0px; position: absolute;
                    top: 0px">������</asp:Label>
                <asp:DropDownList ID="ddlMainTabId" runat="server" Width="128px" Style="z-index: 102;
                    left: 56px; position: absolute; top: 0px">
                </asp:DropDownList>
            </div>
            <div style="width: 185px; position: relative; height: 22px" id="divMainView" runat="server">
                <asp:Label ID="lblMainViewName" runat="server" Style="z-index: 101; left: 0px; position: absolute;
                    top: 0px">����ͼ��</asp:Label>
                <asp:DropDownList ID="ddlMainViewId" runat="server" Width="128px" Style="z-index: 102;
                    left: 56px; position: absolute; top: 0px">
                </asp:DropDownList>
            </div>
        </td>
        <td style="width: 123px">
        </td>
        <td colspan="3" align="left">
            
                <div style="width: 376px; position: relative; height: 32px">
                    <asp:Label ID="lblKeyForMainTab" Style="z-index: 101; left: 16px; position: absolute;
                        top: 0px" runat="server">����ؼ���</asp:Label>
                    <asp:TextBox ID="txtKeyForMainTab" Style="z-index: 102; left: 80px; position: absolute;
                        top: 0px"  Width="168px" runat="server"></asp:TextBox>
                </div>
            </font>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDetailTabName" runat="server">��ϸ����</asp:Label>
        </td>
        <td style="width: 123px">
            
                <asp:DropDownList ID="ddlDetailTabId" runat="server" Width="152px">
                </asp:DropDownList></font></td>
        <td style="width: 123px">
            
                <asp:RadioButtonList ID="rblDetailTabType" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="��" Selected="True">��</asp:ListItem>
                    <asp:ListItem Value="��ͼ">��ͼ</asp:ListItem>
                </asp:RadioButtonList></font>
        </td>
        <td colspan="4" align="left">
            <div style="width: 444px; position: relative; height: 32px">
                <asp:Label ID="lblKeyForDetailTab" Style="z-index: 101; left: 0px; position: absolute;
                    top: 0px" runat="server">��ϸ��ؼ���</asp:Label>
                <asp:TextBox ID="txtKeyForDetailTab" Style="z-index: 102; left: 80px; position: absolute;
                    top: 0px"  Width="168px" runat="server"></asp:TextBox>
            </div>
        </td>
    </tr>
    <tr>
        <td colspan="6" style="width: 75px">
            
                <asp:Label ID="Label5" runat="server" Width="128px"  ForeColor="#004040">���湦�ܼ�˵��:</asp:Label></font></td>
    </tr>
    <tr>
        <td colspan="6" style="width: 75px">
            <img style="width: 700px; height: 3px" height="3" alt="" src="../../pic/��ɫֱ��1.gif"
                width="768"></td>
    </tr>
    <tr>
        <td style="width: 75px" valign="top">
            <asp:Label ID="lblViewFunction" runat="server">���湦��</asp:Label>
        </td>
        <td colspan="5">
            <asp:TextBox ID="txtViewFunction" runat="server" Width="568px" Height="168px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 75px" valign="top" colspan="1" rowspan="1">
            <asp:Label ID="lblViewDetail" runat="server">����˵��</asp:Label>
        </td>
        <td colspan="5" rowspan="1">
            <asp:TextBox ID="txtViewDetail" runat="server" Width="568px" Height="80px" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
</table>
<table id="tabHidden" cellspacing="1" cellpadding="1" width="300" border="1" runat="server">
    <tr>
        <td>
            <asp:Label ID="lblUserId" runat="server">�û�ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtUserId" runat="server"  ></asp:TextBox></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblPrjId" runat="server">����ID</asp:Label></td>
        <td>
            <asp:DropDownList ID="ddlPrjId" runat="server" Width="120px">
            </asp:DropDownList></td>
        <td>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblDataBaseName" runat="server">���ݿ���</asp:Label></td>
        <td>
            <asp:TextBox ID="txtDataBaseName" runat="server" Width="120px" ></asp:TextBox></td>
        <td>
            
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblViewId" runat="server">����ID</asp:Label></td>
        <td>
            <asp:TextBox ID="txtViewId" runat="server" Width="120px" ></asp:TextBox></td>
        <td>
        </td>
    </tr>
</table>
