﻿<%@ Register TagPrefix="uc1" TagName="wucWebSrvFunctionsB" Src="wucWebSrvFunctionsB.ascx" %>

<%@ Page Language="c#" AutoEventWireup="True" CodeBehind="wfmWebSrvFunctionsB_QUDI.aspx.cs" Inherits="AGC.Webform.wfmWebSrvFunctionsB_QUDI" ValidateRequest="false" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset = utf-8" />
    <title>WebSrv函数维护的维护</title>
    
    <%--  <script type="text/javascript" src="../../JS/tzPubFun.js"></script>--%>
    <link href="../../css/tz_MenuButton/tz_sccl.css" rel="stylesheet" />

    <script src="../../js/PubFun/jsPubVar.js"></script>
    <script src="../../js/PubFun/jsPubFun.js"></script>
    <script src="../../js/PubFun/jsGetElement.js"></script>
    <script src="../../js/PubFun/TzCtrlCls.js"></script>
    <script type="text/javascript">
        var txtCode = new TzTextArea("txtCode");
        //var txtCode_Sim = new TzTextArea("txtCode_Sim");
        function GenControlCode() {
            txtCode.setText("");
            txtCode_Sim.setText("");

            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenControlCode|1!", divCode);
        }
        function GenCtlControlCode() {
            txtCode.setText("");
            txtCode_Sim.setText("");
            var divCode = getObjByTagAndId("div", "divCode");
            CallServer("GenCtlControlCode|1!", divCode);
        }
        function ClearText() {
            txtCode.setText("");
            //txtCode_Sim.setText("");
        }
    </script>
    <script type="text/javascript">


        function ChangeLangType(strFunName, strLangType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            var lblLangTypeName = getObjByTagAndId("span", "lblLangTypeName");
            if (lblLangTypeName != null) {
                lblLangTypeName.innerHTML = strLangType;
            }
            else {
                alert("找不到lblLangTypeName");
            }
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidLangType.value = strLangType;

            document.forms[0].submit();
            //}
        }
        function ChangeDataBaseType(strFunName, strDataBaseType) {
            //if (event.keyCode == 13) {
            //event.cancelBubble = true;
            //event.returnValue = false;
            document.all.FunName.value = strFunName;// "enter";
            document.all.hidDataBaseType.value = strDataBaseType;

            document.forms[0].submit();
            //}
        }
    </script>

   

</head>
<body>
    <form id="form1" runat="server">
        <div id="tabLayout" class="tab_layout"
            runat="server">
            <%-- 标题层 --%>

            <div style="position: relative; width: 648px; height: 37px; left: 0px; top: 0px;">
                <asp:Label ID="lblViewTitle" runat="server" CssClass="h5" >WebSrv函数维护
                </asp:Label>
                <asp:Label ID="lblMsgList" runat="server" CssClass="text-warning"  Style="z-index: 105; left: 54px; position: relative; top: 4px"
                    Width="347px"></asp:Label>
            </div>
            <%-- 查询层 --%>

            <div id="divQuery" class="div_query">
                <table class="auto-style2">
                    <tr>

                        <td>
                            <asp:Label ID="lblFunctionNameq" 
                                runat="server" CssClass="text-secondary">函数名称</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtFunctionNameq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:TextBox>
                        </td>

                        <td>
                            <asp:Label ID="lblWebSrvClassIdq" 
                                runat="server" CssClass="text-secondary">WebSrv类</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlWebSrvClassIdq" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>

                        <td>
                            <asp:Label ID="lblWebSrvUrlq" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">地址</asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtWebSrvUrlq" Style="z-index: 117;"
                                runat="server" CssClass="TextBox_Defa" Width="400px"></asp:TextBox>
                        </td>
                        <td>
                            <asp:Label ID="lblWebSrvUrl_q0" Style="z-index: 116;"
                                runat="server" CssClass="text-secondary">异步?</asp:Label>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlIsAsyncFunc" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnQuery"
                                Style="z-index: 119; width: 80px;"
                                runat="server"
                                Text="查询" CssClass="btn btn-outline-warning btn-sm"
                                OnClick="btnQuery_Click"></asp:Button>
                        </td>
                    </tr>
                </table>
            </div>
            <%-- 列表层 --%>
            <div id="divBaseOperate" class="tz-layout-menu" runat="server" style="width: 100%; height: 40px">
                <span class="menu-logo">基本操作:</span>
                <a class="menu-menu-btn" href="javascript:;"><i class="icon-font">&#xe600;</i></a>
                <ul class="menu-bar">
                    <li class="menu-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="lblLangTypeName" Width="50px" CssClass="btn btn-outline-info btn-sm" runat="server" Text="DotNet"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                        <ul class="menu-dropdown-menu">

                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'DotNet');">DotNet</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Java');">Java</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Swift');">Swift</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Swift3');">Swift3</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'Swift4');">Swift4</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'JavaScript');">JavaScript</a></li>
                            <li><a href="javascript:ChangeLangType('ChangeLangType', 'SilverLight');">SilverLight</a></li>
                            <li></li>
                        </ul>
                    </li>
                    <li class="menu-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="lblDataBaseType" Width="50px" CssClass="btn btn-outline-info btn-sm" runat="server" Text="Ms Sql"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                        <ul class="menu-dropdown-menu">

                            <li><a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'Ms Sql');">Ms Sql</a></li>
                            <li><a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'Oracle');">Oracle</a></li>
                            <li><a href="javascript:ChangeDataBaseType('ChangeDataBaseType', 'MySql');">MySql</a></li>
                            <li></li>
                        </ul>
                    </li>
                    <li class="menu-bar-nav">
                        <a href="javascript:;">
                            <asp:Label ID="Label2" CssClass="btn btn-outline-info btn-sm" runat="server" Text="生成代码"></asp:Label>
                            <i class="icon-font" style="margin-left: 5px;">&#xe60c;</i></a>

                        <ul class="menu-dropdown-menu">
                            <li>
                                <asp:LinkButton ID="lbGeneWebServiceTransCode"
                                    runat="server" OnClick="lbGeneWebServiceTransCode_Click" Text="WEB服务转换层"></asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="lbGeneControllerInvokeWS"
                                    runat="server" OnClick="lbGeneControllerInvokeWS_Click" CssClass="btn btn-outline-info btn-sm" Text="控制层(调Web服务转换)" Width="160px"></asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="lbGeneController"
                                    runat="server" OnClick="lbGeneController_Click" Text="控制层"></asp:LinkButton>
                            </li>
                            <li>
                                <asp:LinkButton ID="lbGeneController4UnitTest"
                                    runat="server" OnClick="lbGeneController4UnitTest_Click" Text="控制层4调试"></asp:LinkButton>
                            </li>

                            <li></li>
                        </ul>
                    </li>

                    <li class="menu-bar-nav"></li>

                    <%-- <li class="ChildDiv2">
                        <asp:Button ID="lbAddField" runat="server" OnClick="lbAddField_Click" CssClass="btn btn-outline-info btn-sm"
                            Width="73px" Text="维护表字段"></asp:Button>
                    </li>--%>
                    <li class="menu-bar-nav"></li>
                    <li class="menu-bar-nav"></li>
                    <li class="menu-bar-nav"></li>


                    <li class="menu-bar-nav"></li>
                </ul>
            </div>

            <div id="divList" class="div_List"
                runat="server">
                <table id="tabGridFunction" style="width: 100%; height: 32px" class="msgtable">
                    <tr>
                        <td>
                            <asp:Label ID="lblWebSrvFunctionsList" runat="server" 
                                CssClass="h6" Width="250px">WebSrv函数列表</asp:Label>
                        </td>
                        <td>
                            <asp:Button ID="btnAddToSelfDefDataType" runat="server" OnClick="btnAddToSelfDefDataType_Click"
                                Width="125px" CssClass="auto-style1" Text="添加到自定义类型" ToolTip="添加参数类型到自定义类型"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnAddNewRec4Gv" runat="server" OnClick="btnAddNewRec4Gv_Click" 
                                 CssClass="btn btn-outline-info btn-sm" Text="添加"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnDelete4Gv" OnClick="btnDelete4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="删除"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnUpdate4Gv" OnClick="btnUpdate4Gv_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="修改"></asp:Button>
                        </td>
                        <td>
                            <asp:DropDownList ID="ddlFuncTypeID" 
                                runat="server" CssClass="TextBox_Defa">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnSetFuncType" OnClick="btnSetFuncType_Click"  runat="server"
                                 CssClass="btn btn-outline-info btn-sm" Text="设置函数类型"></asp:Button>
                        </td>
                        <td>
                            <asp:Button ID="btnExportExcel4Gv" OnClick="btnExportExcel4Gv_Click" 
                                runat="server"  CssClass="btn btn-outline-warning btn-sm" Text="导出Excel"></asp:Button>
                        </td>
                    </tr>
                </table>
                <asp:GridView ID="gvWebSrvFunctions" Style="z-index: 120;" runat="server"
                    Width="100%" AutoGenerateColumns="False"
                    PageSize="10" AllowPaging="true"
                    AllowSorting="true"
                    OnSorting="gvWebSrvFunctions_Sorting"
                    OnPageIndexChanging="gvWebSrvFunctions_PageIndexChanging"
                    OnRowCreated="gvWebSrvFunctions_RowCreated"
                    OnRowCommand="gvWebSrvFunctions_RowCommand"
                    OnRowDeleting="gvWebSrvFunctions_RowDeleting"
                    OnRowUpdating="gvWebSrvFunctions_RowUpdating"
                    BackColor="White"
                    BorderColor="#E7E7FF"
                    BorderStyle="None"
                    BorderWidth="1px"
                    CellPadding="3"
                    GridLines="Horizontal"
                    Height="1px"
                    DataKeyNames="WebSrvFunctionId"
                    CssClass="table table-striped table-bordered table-condensed">
                    <Columns>
                        <asp:TemplateField HeaderText="全选">
                            <HeaderStyle Width="35px" />
                            <HeaderTemplate>
                                <asp:LinkButton ID="lbSelAll" CommandName="lbSelAll" runat="server" CssClass="btn btn-link btn-sm text-nowrap" Text="全选"></asp:LinkButton>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <a name="A_WebSrvFunctions<%# Eval("WebSrvFunctionId").ToString().Trim() %>"></a>
                                <asp:CheckBox ID="chkCheckRec" runat="server"></asp:CheckBox>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="WebSrvFunctionId" SortExpression="WebSrvFunctionId" HeaderText="函数Id"></asp:BoundField>
                        <asp:BoundField DataField="WebSrvClassId" SortExpression="WebSrvClassId" HeaderText="类Id" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="NameSpace" SortExpression="NameSpace" HeaderText="域名" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ClassName" SortExpression="ClassName" HeaderText="类名"></asp:BoundField>
                        <asp:BoundField DataField="WebSrvUrl" SortExpression="WebSrvUrl" HeaderText="WebSrv地址" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FunctionName" SortExpression="FunctionName" HeaderText="功能名称" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="GetCustomAttributes" SortExpression="GetCustomAttributes" HeaderText="定制属性数" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="FunctionSignature" SortExpression="FunctionSignature" HeaderText="函数签名"></asp:BoundField>
                        <asp:BoundField DataField="FuncTypeId" SortExpression="FuncTypeId" HeaderText="函数类型ID" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="ReturnType" SortExpression="ReturnType" HeaderText="返回类型"></asp:BoundField>
                        <asp:BoundField DataField="IsAsyncFunc" SortExpression="IsAsyncFunc" HeaderText="异步?"></asp:BoundField>
                        <asp:BoundField DataField="IsKnownType" SortExpression="IsKnownType" HeaderText="已知?"></asp:BoundField>
                        <asp:BoundField DataField="IsGeneCode" SortExpression="IsGeneCode" HeaderText="生成?"></asp:BoundField>

                        <asp:BoundField DataField="ReturnTypeID" SortExpression="ReturnTypeID" HeaderText="类型Id"></asp:BoundField>
                        <asp:BoundField DataField="UpdDate" SortExpression="UpdDate" HeaderText="修改日期" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="UpdUser" SortExpression="UpdUser" HeaderText="修改者" Visible="false"></asp:BoundField>
                        <asp:BoundField DataField="Memo" SortExpression="Memo" HeaderText="说明" Visible="false"></asp:BoundField>
                        <asp:TemplateField HeaderText="修改">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbUpdate" runat="Server" CommandName="Update" Text="修改" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="删除">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbDelete" runat="Server" CommandName="Delete" Text="删除" CssClass="LinkButton_DefaInGv"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                    <PagerTemplate>
                        <span class="text-secondary">共有记录:</span>
                        <asp:Label ID="lblRecCount" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066" Width="36px">0</asp:Label>
                        <span style="background-color: #c0c0c0">
                            <div style="display: inline; width: 16px; height: 13px">
                            </div>
                        </span><span class="text-secondary">总页数:</span>
                        <asp:Label ID="lblAllPages" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px; height: 13px">
                        </div>
                        <span class="text-secondary">当前页:</span>
                        <asp:Label ID="lblCurrentPage" runat="server" CssClass="Label_DefaInPager" ForeColor="#000066">0</asp:Label>
                        <div style="display: inline; width: 16px; height: 13px">
                        </div>
                        <asp:Button ID="btnPrevPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="上一页"
                            CommandArgument="Prev" CommandName="Page" /><span style="font-family: Verdana">
                            </span>
                        <asp:Button ID="btnNextPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" Text="下一页"
                            CommandArgument="Next" CommandName="Page" />
                        到第
                        <asp:TextBox ID="txtJump2Page" runat="server" CssClass="TextBox_DefaInPager" Width="35px"></asp:TextBox>页
                        <asp:Button ID="btnJumpPage" runat="server" CssClass="btn btn-outline-warning btn-sm small" OnClick="btnJumpPage_Click"
                            Text="确定" Width="45px" CommandName="Page" />
                        <span class="text-secondary">页记录数:</span>
                        <asp:DropDownList ID="ddlPagerRecCount" runat="server" CssClass="DropDown_DefaInPager"
                            Width="55px" AutoPostBack="True" OnSelectedIndexChanged="ddlPagerRecCount_SelectedIndexChanged">
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
<asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                            <asp:ListItem>30</asp:ListItem>
                            <asp:ListItem>50</asp:ListItem>
                            <asp:ListItem>100</asp:ListItem>
                            <asp:ListItem>1000</asp:ListItem>
                        </asp:DropDownList>
                        <asp:CompareValidator ID="CompareValidator" runat="server" ControlToValidate="txtJump2Page"
                            ErrorMessage="错误!" ForeColor="DarkOrange" Operator="DataTypeCheck" Type="Integer"></asp:CompareValidator>
                    </PagerTemplate>
                    <FooterStyle CssClass="FooterStyle" />
                    <RowStyle CssClass="RowStyle" />
                    <EmptyDataRowStyle CssClass="EmptyDataRowStyle" />
                    <SelectedRowStyle CssClass="SelectedRowStyle" />
                    <PagerStyle CssClass="PagerStyle" />
                    <HeaderStyle CssClass="HeaderStyle" />
                    <EditRowStyle CssClass="EditRowStyle" />
                    <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                </asp:GridView>
            </div>
            <%-- 编辑层 --%>
            <div id="tabEditWebSrvFunctionsRegion" class="tab_Edit"
                runat="server">
                <div>
                    <table style="width: 100%;" class="msgtable">
                        <tr>
                            <th style="text-align: left">
                                <asp:Label ID="lblEditWebSrvFunctions"  runat="server"
                                    CssClass="h6">WebSrv函数编辑区域</asp:Label>
                                <asp:Label ID="lblMsgEdit"  runat="server"
                                    Width="208px"  CssClass="text-warning"></asp:Label>
                            </th>
                            <th style="text-align: right">
                                <asp:Button ID="btnOKUpd"  runat="server"
                                     Text="添加" OnClick="btnOKUpd_Click" CssClass="btn btn-outline-info btn-sm"></asp:Button>

                                <asp:Button ID="btnCancelWebSrvFunctionsEdit" 
                                    runat="server" Width="100px" CssClass="btn btn-outline-info btn-sm" Text="取消编辑" OnClick="btnCancelWebSrvFunctionsEdit_Click"></asp:Button>
                            </th>
                        </tr>
                    </table>
                </div>
                <div>
                    <uc1:wucWebSrvFunctionsB ID="wucWebSrvFunctionsB1" runat="server" />
                </div>
            </div>
            <div id="divCode" runat="server">
                <div id="divGeneCodeMenu" style="float: left; width: 30%">
                    <asp:ImageMap ID="imGeneCode_Java" runat="server" ImageUrl="~/pic/GeneCode_Java.jpg" HotSpotMode="PostBack" OnClick="ImageMap1_Click">

                        <asp:RectangleHotSpot Bottom="43" Left="5" Right="350" Top="8" HotSpotMode="PostBack" PostBackValue="Entity" />
                        <asp:RectangleHotSpot Bottom="108" Left="5" Right="350" Top="73" HotSpotMode="PostBack" PostBackValue="Business" />
                        <asp:RectangleHotSpot Bottom="172" Left="5" Right="285" Top="137" HotSpotMode="PostBack" PostBackValue="WS_Access" />
                        <asp:RectangleHotSpot Bottom="237" Left="5" Right="285" Top="202" HotSpotMode="PostBack" PostBackValue="WS_AccessHigh" />
                        <asp:RectangleHotSpot Bottom="301" Left="5" Right="285" Top="266" HotSpotMode="PostBack" PostBackValue="AppController" />
                        <asp:RectangleHotSpot Bottom="366" Left="5" Right="285" Top="331" HotSpotMode="PostBack" PostBackValue="AppViewUnitTest" />
                        <asp:RectangleHotSpot Bottom="430" Left="5" Right="285" Top="395" HotSpotMode="PostBack" PostBackValue="AppViewUTScript" />
                        <asp:RectangleHotSpot Bottom="430" Left="295" Right="350" Top="395" HotSpotMode="PostBack" PostBackValue="AppViewUTScriptCS" />
                    </asp:ImageMap>
                    <asp:ImageMap ID="imGeneCode_Swift" runat="server" ImageUrl="~/pic/GeneCode_Swift.jpg" HotSpotMode="PostBack" OnClick="ImageMap1_Click">

                        <asp:RectangleHotSpot Bottom="43" Left="5" Right="350" Top="8" HotSpotMode="PostBack" PostBackValue="Entity" />
                        <asp:RectangleHotSpot Bottom="108" Left="5" Right="350" Top="73" HotSpotMode="PostBack" PostBackValue="Business" />
                        <asp:RectangleHotSpot Bottom="172" Left="5" Right="285" Top="137" HotSpotMode="PostBack" PostBackValue="WS_Access" />
                        <asp:RectangleHotSpot Bottom="237" Left="5" Right="285" Top="202" HotSpotMode="PostBack" PostBackValue="WS_AccessHigh" />
                        <asp:RectangleHotSpot Bottom="301" Left="5" Right="285" Top="266" HotSpotMode="PostBack" PostBackValue="AppController" />
                        <asp:RectangleHotSpot Bottom="366" Left="5" Right="285" Top="331" HotSpotMode="PostBack" PostBackValue="AppViewUnitTest" />
                        <asp:RectangleHotSpot Bottom="430" Left="5" Right="285" Top="395" HotSpotMode="PostBack" PostBackValue="AppViewUTScript" />
                        <asp:RectangleHotSpot Bottom="430" Left="295" Right="350" Top="395" HotSpotMode="PostBack" PostBackValue="AppViewUTScriptCS" />
                    </asp:ImageMap>
                    <asp:ImageMap ID="imGeneCode_JavaScript" runat="server" ImageUrl="~/pic/GeneCode_JavaScript.jpg" HotSpotMode="PostBack" OnClick="ImageMap1_Click">

                        <asp:RectangleHotSpot Bottom="43" Left="5" Right="350" Top="8" HotSpotMode="PostBack" PostBackValue="Entity" />
                        <asp:RectangleHotSpot Bottom="108" Left="5" Right="350" Top="73" HotSpotMode="PostBack" PostBackValue="Business" />
                        <asp:RectangleHotSpot Bottom="172" Left="5" Right="285" Top="137" HotSpotMode="PostBack" PostBackValue="WS_Access" />
                        <asp:RectangleHotSpot Bottom="237" Left="5" Right="285" Top="202" HotSpotMode="PostBack" PostBackValue="WS_AccessHigh" />
                        <asp:RectangleHotSpot Bottom="301" Left="5" Right="285" Top="266" HotSpotMode="PostBack" PostBackValue="AppController" />
                        <asp:RectangleHotSpot Bottom="366" Left="5" Right="285" Top="331" HotSpotMode="PostBack" PostBackValue="AppViewUnitTest" />
                        <asp:RectangleHotSpot Bottom="430" Left="5" Right="285" Top="395" HotSpotMode="PostBack" PostBackValue="AppViewUTScript" />
                        <asp:RectangleHotSpot Bottom="430" Left="295" Right="350" Top="395" HotSpotMode="PostBack" PostBackValue="AppViewUTScriptCS" />
                    </asp:ImageMap>
                    <asp:ImageMap ID="imGeneCode_CSharp" runat="server" ImageUrl="~/pic/GeneCode_CSharp.jpg" HotSpotMode="PostBack" OnClick="ImageMap1_Click">

                        <asp:RectangleHotSpot Bottom="43" Left="5" Right="350" Top="8" HotSpotMode="PostBack" PostBackValue="Entity" />
                        <asp:RectangleHotSpot Bottom="108" Left="5" Right="350" Top="73" HotSpotMode="PostBack" PostBackValue="DAL" />
                        <asp:RectangleHotSpot Bottom="172" Left="5" Right="285" Top="137" HotSpotMode="PostBack" PostBackValue="DALEx" />
                        <asp:RectangleHotSpot Bottom="237" Left="5" Right="285" Top="202" HotSpotMode="PostBack" PostBackValue="Business" />
                        <asp:RectangleHotSpot Bottom="301" Left="5" Right="285" Top="266" HotSpotMode="PostBack" PostBackValue="BusinessEx" />
                        <asp:RectangleHotSpot Bottom="366" Left="5" Right="285" Top="331" HotSpotMode="PostBack" PostBackValue="CommFun4BL" />
                        <asp:RectangleHotSpot Bottom="430" Left="5" Right="285" Top="395" HotSpotMode="PostBack" PostBackValue="WebService" />
                        <asp:RectangleHotSpot Bottom="495" Left="5" Right="285" Top="460" HotSpotMode="PostBack" PostBackValue="WS_Access" />
                        <asp:RectangleHotSpot Bottom="559" Left="5" Right="285" Top="524" HotSpotMode="PostBack" PostBackValue="Dict_PageName_Dir" />
                    </asp:ImageMap>

                </div>
                <div id="divCodeIn" style="float: right; width: 70%">

                    <table id="tabCode" runat="server" border="1" cellpadding="1" cellspacing="1" style="width: 90%; height: 618px">
                        <tr>
                            <td>
                                <asp:Label ID="Label4" runat="server" Font-Names="宋体" Font-Size="Smaller"
                                    Width="144px">生成的逻辑层代码：</asp:Label>
                                <asp:TextBox ID="txtFileName4GenCode" runat="server" Width="528px"></asp:TextBox>
                            </td>
                            <td>
                                <asp:LinkButton ID="lbDispTabList" runat="server" Width="150px" CssClass="btn btn-outline-info btn-sm" OnClick="lbDispTabList_Click">显示表名列表</asp:LinkButton>
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2">

                                  <asp:Literal ID="litCode" runat="server"></asp:Literal>
                            </td>
                        </tr>

                    </table>
                </div>
            </div>
        </div>
        
        <script src="../../Scripts/jquery-3.6.0.min.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl.js"></script>
        <script type="text/javascript" src="../../js/tz_MenuButton/tz_sccl-util.js"></script>
        <input type="hidden" name="FunName" />
        <input type="hidden" name="hidLangType" />
        <input type="hidden" name="hidDataBaseType" />
    </form>
</body>
</html>
