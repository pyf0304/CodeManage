﻿<%@ Page Title="表ExcelExportRegionFlds的查询、修改、删除、添加记录" Language="C#" MasterPageFile="~/Webform/MasterPage/ViewRegionEdit.Master" CodeBehind="wfmExcelExportRegionFlds_Edit.aspx.cs" ValidateRequest="false"
    AutoEventWireup="True" Inherits="AGC.Webform.wfmExcelExportRegionFlds_Edit" %>

<%@ Register TagPrefix="uc1" TagName="wucExcelExportRegionFlds" Src="../View/wucExcelExportRegionFlds.ascx" %>
<%@ Register Src="~/Webform/RegionManage/wucvExcelExportRegionFlds4Gv.ascx" TagPrefix="uc2" TagName="wucvExcelExportRegionFlds4Gv" %>
<%@ Register Src="~/Webform/CommonControl/wucExcelExportRegion4Preview.ascx" TagPrefix="uc1" TagName="wucExcelExportRegion4Preview" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function GeneCode(strCodeTypeId, strTabId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"' + strTabId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":""}',
                url: "wfmExcelExportRegionFlds_QUDI2.aspx/GeneCode",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }
        function GeneCode4Func(strCodeTypeId, strViewId, strFuncId, intApplicationTypeId) {
            //返回长度超过一定数量就不能返回了，怎么办？
            $.ajax({
                type: "post",
                datatype: "json",
                data: '{"strCodeTypeId":"' + strCodeTypeId + '",' +
                    '"strTabId":"",' +
                    '"strFuncId":"' + strFuncId + '",' +
                    '"intApplicationTypeId":"' + intApplicationTypeId + '",' +
                    '"strViewId":"' + strViewId + '"}',
                url: "wfmExcelExportRegionFlds_QUDI2.aspx/GeneCode4Func",
                contentType: "application/json",
                success: function (result) {
                    ShowCode(result.d);
                }
            });
        }

        function ShowCode(strCode) {
            var txtCode = document.getElementById("txtCode");
            var objJSON = JSON.parse(strCode)
            txtCode.value = objJSON.Code;
            var txtClassName4GC = document.getElementById("txtClassName4GC");
            if (txtClassName4GC != null) {
                txtClassName4GC.value = objJSON.ClassName;
            }
            if (txtFileName4GC != null) {
                txtFileName4GC.value = objJSON.FileName;
            }
            //$('#txtCode').val(strCode);
        }

    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="panel panel-info mt-2 mb-2">
        <div class="panel-body">
            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="lblTitle" runat="server" Text="区域信息" Width="100px" CssClass="h6 text-warning"></asp:Label>
                </li>
                 <li class="nav-item ml-2">
                    <div class="btn-group" role="group" aria-label="Basic example">
                        <asp:Label ID="Label5" runat="server" Text="区域宽度:" CssClass="text-primary"></asp:Label>
                        <asp:TextBox ID="txtWidth" runat="server" Width="50px"></asp:TextBox>
                        <%--<asp:Label ID="Label4" runat="server" Text="每行列数:" CssClass="text-primary ml-3"></asp:Label>
                        <asp:TextBox ID="txtColNum" runat="server" Width="50px"></asp:TextBox>--%>
                        <asp:Button ID="btnSetColNum" runat="server"
                            Text="确定" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetColNum_Click"></asp:Button>
                    </div>
                </li>
       <%--         <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkInUse" Text="是否使用" runat="server" AutoPostBack="True" OnCheckedChanged="chkInUse_CheckedChanged" />
                </li>--%>
            </ul>
        </div>
    </div>

    <div id="tabExcelExportRegionFldsDataGrid" cellspacing="0" cellpadding="0" width="100%" border="0" runat="server">
        <div style="width: 100%; height: 40px">

            <ul class="nav">
                <li class="nav-item">
                    <asp:Label ID="Label3" runat="server" CssClass="h6"
                        Width="200px">Excel导出区域字段列表</asp:Label>
                </li>
           
                <li class="nav-item ml-2">
                    <asp:Button ID="btnDelete4Dg" runat="server"
                        Text="删除" CssClass="btn btn-outline-info btn-sm" OnClick="btnDelete4Dg_Click"></asp:Button>
                </li>
                <li class="nav-item ml-2">
                    <asp:Button ID="btnUpdate4Dg" runat="server"
                        Text="修改" CssClass="btn btn-outline-info btn-sm" OnClick="btnUpdate4Dg_Click"></asp:Button>
                </li>
                <li class="nav-item ml-2">
                    <div class="btn-group" role="group" aria-label="Basic example">
                        <asp:Button ID="btnSetInUse" runat="server"
                            Text="启用" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetInUse_Click"></asp:Button>
                        <asp:Button ID="btnSetNotInUse" runat="server"
                            Text="不用" CssClass="btn btn-outline-info btn-sm" OnClick="btnSetNotInUse_Click"></asp:Button>
                    </div>
                </li>
                <li class="nav-item ml-2">
                    <asp:Button ID="btnCopyFldFromRelaTab" runat="server" Text="复制表字段" CssClass="btn btn-outline-info btn-sm"
                        OnClick="btnCopyFldFromRelaTab_Click"></asp:Button>
                </li>

                <li class="nav-item ml-2">
                    <div class="btn-group" role="group" aria-label="Basic example">
                        <asp:Button ID="btnGoFirstLine" runat="server"
                            Text="首行" CssClass="btn btn-outline-info btn-sm"
                            OnClick="btnGoFirstLine_Click"></asp:Button>
                        <asp:Button ID="btnUpMove" runat="server" Text="上移" CssClass="btn btn-outline-info btn-sm"
                            OnClick="btnUpMove_Click"></asp:Button>
                        <asp:Button ID="btnDownMove" runat="server" Text="下移" CssClass="btn btn-outline-info btn-sm"
                            OnClick="btnDownMove_Click"></asp:Button>
                        <asp:Button ID="btnGoLastLine" runat="server"
                            Text="尾行" CssClass="btn btn-outline-info btn-sm"
                            OnClick="btnGoLastLine_Click"></asp:Button>
                    </div>
                </li>
                <li class="nav-item ml-2">
                    <asp:Button ID="btnReOrder" runat="server" Text="重序" CssClass="btn btn-outline-info btn-sm"
                        OnClick="btnReOrder_Click"></asp:Button>
                </li>
                <li class="nav-item ml-2">
                    <asp:CheckBox ID="chkOnlyShowFldInUse" runat="server" Text="仅显使用字段" Width="115px" Checked="false" OnCheckedChanged="chkOnlyShowFldInUse_CheckedChanged" AutoPostBack="True" />
                </li>
                <li class="nav-item ml-2">
                    <asp:Button ID="btnExportExcel4Dg" Style="z-index: 103;" runat="server"
                        Text="导出Excel" CssClass="btn btn-outline-warning btn-sm" OnClick="btnExportExcel4Dg_Click"></asp:Button>
                </li>
                <li class="nav-item ml-2">
                    <asp:Label ID="lblMsg1" runat="server" Width="248px" ForeColor="Red"></asp:Label>
                </li>

            </ul>
        </div>
         <div style="width:100%">
        <div class="float-left" >
                <div style="width:1000px;overflow:scroll ">
                    <div class="panel-body">
                        <uc1:wucExcelExportRegion4Preview runat="server" ID="wucExcelExportRegion4Preview1" />
                    </div>
                </div>
                <%-- 列表层 --%>
                <div>
                    <ul class="nav nav-tabs" role="navigation">
                        <li class="nav-item active"><a class="nav-link active" href="#tab1" data-toggle="tab" role="tab">列表区字段</a></li>
                        <li class="nav-item"><a class="nav-link" href="#tab2" data-toggle="tab" role="tab">生成代码</a>         </li>
                        <%--                    <li class="<%=CurrTabClass(2) %>"><a class="nav-link" href="#tab3" data-toggle="tab" role="tab">列表区</a>                     </li>
                    <li class="<%=CurrTabClass(3) %>"><a class="nav-link" href="#tab4" data-toggle="tab" role="tab">编辑区</a></li>--%>
                    </ul>
                    <div class="tab-content">
                        <div class="tab-pane active" id="tab1">
                            <div class="panel panel-default">
                                <div id="divList" class="div_List" runat="server">
                                    <uc2:wucvExcelExportRegionFlds4Gv runat="server" ID="wucvExcelExportRegionFlds4Gv1"
                                        OnGvUpdateClick="wucvExcelExportRegionFlds4Gv1_GvUpdateClick"
                                        OnGvDeleteClick="wucvExcelExportRegionFlds4Gv1_GvDeleteClick" />
                                </div>

                            </div>
                        </div>
                        <div class="tab-pane" id="tab2">
                            <div class="panel panel-default">
                                <div id="Table1" style="width: 100%; float: left;">
                                    <div style="width: 100%; float: left; min-height: 30px;">
                                        <asp:Panel ID="pnlCodeTypeLst" Style="width: 100%; left: 0px; text-align: left; min-height: 30px; line-height: 40px;" runat="server">
                                        </asp:Panel>
                                    </div>
                                    <div style="width: 100%" class="mt-4">
                                        <div id="divCodeRegion" style="width: 100%;" runat="server">
                                            <div id="divCode" style="width: 100%;" class="mt-2">
                                                <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                                <textarea id="txtCode" style="width: 99%; height: 1000px;" rows="2"></textarea>

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>

                        </div>
                    </div>
                </div>

            </div>


            <div id="tabEditExcelExportRegionFldsRegion" style="width:400px" class="float-right mr-2 border border-info">
                <div>
                    <ul class="nav">
                          <li class="nav-item">
                            <asp:Label ID="Label1" runat="server" Width="128px" CssClass="h6" >编辑字段属性</asp:Label>
                        </li>
                        <li class="nav-item  ml-2">
                            <asp:Button ID="btnOKUpd" runat="server" Text="添加" OnClick="btnOKUpd_Click"></asp:Button>
                        </li>
                        <li class="nav-item ml-2">
                            <asp:Label ID="lblMsg" runat="server" Width="178px"></asp:Label>
                        </li>
                      
                    </ul>
                </div>
                <div>
                    <uc1:wucExcelExportRegionFlds ID="wucExcelExportRegionFlds1" runat="server"></uc1:wucExcelExportRegionFlds>
                </div>

            </div>
        </div>
    </div>

    <asp:HiddenField ID="hidCtrlId" runat="server" />
    <script>
        setTimeout(ReSelectCtrl(), 1000);
    </script>

</asp:Content>

