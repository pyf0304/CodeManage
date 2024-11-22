(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/gs_PaperReportCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_PaperReportEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_PaperReportWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_PaperReportWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_PaperReportExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubConfig/clsSysPara4WebApi.js", "./gs_PaperReport_EditEx.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../PagesBase/GraduateEduTopic/gs_PaperReport_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperReportCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_PaperReportCRUDEx
    表名:gs_PaperReport(01120772)
    生成代码版本:2020.11.22.1
    生成日期:2020/12/01 00:55:27
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //
    //import * as QQ from "q";
    const gs_PaperReportCRUD_js_1 = require("../PagesBase/GraduateEduTopic/gs_PaperReportCRUD.js");
    const clsgs_PaperReportEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_PaperReportEN.js");
    const clsgs_PaperReportWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_PaperReportWApi.js");
    const clsvgs_PaperReportWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_PaperReportWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsgs_PaperReportExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_PaperReportExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const gs_PaperReport_EditEx_js_1 = require("./gs_PaperReport_EditEx.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const gs_PaperReport_Edit_js_1 = require("../PagesBase/GraduateEduTopic/gs_PaperReport_Edit.js");
    /* gs_PaperReportCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_PaperReportCRUDEx extends gs_PaperReportCRUD_js_1.gs_PaperReportCRUD {
        constructor() {
            super(...arguments);
            this.divName4Pager_ReportEdit = "divPaperReportEdit";
        }
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvgs_PaperReportBy: string = "reportId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        BindGv(strType, strPara) {
            this.Page_Load();
        }
        BindGv_Cache(strType, strPara) {
            switch (strType) {
                case "vgs_PaperReport":
                    alert('该类没有绑定该函数：[this.BindGv_vgs_PaperReport_Cache]！');
                    //this.BindGv_vgs_PaperReport_Cache();
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_PaperReportCRUDEx();
            var objPage_Edit = new gs_PaperReport_EditEx_js_1.gs_PaperReport_EditEx(objPage);
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "UpdateRecordInTab": //修改记录InTab
                    objPage_Edit.btnUpdateRecordInTab_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordInTab": //删除记录InTab 
                    objPage.btnDelRecordInTab_Click(strKeyId);
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = (0, clsCommFunc4Web_js_1.GetCheckedKeyIds)();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(gs_PaperReportCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                gs_PaperReport_Edit_js_1.gs_PaperReport_Edit.id_CurrEduCls_Static = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                //if (this.bolIsInitShow == false)  //
                //{
                //    this.objPager.InitShow(this.divName4Pager_ReportEdit);
                //    this.bolIsInitShow = true;  //
                //}
                const responseBindGv1 = await this.Bind_PaperReportTree();
                const responseBindGv2 = await this.Bind_PaperReportList();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        //论文汇报树绑定
        async Bind_PaperReportTree() {
            var strWhereCond = " topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            //声明主题变量
            var arrgs_ReportYearNumObjLst = [];
            var arrgs_ReportMonthNumObjLst1 = [];
            var arrgs_ReportMonthNumObjLst2 = [];
            const responseObjLst1 = await (0, clsgs_PaperReportExWApi_js_1.gs_PaperReportEx_GetReportYearNumObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_ReportYearNumObjLst = jsonData;
            });
            const responseObjLst2 = await (0, clsgs_PaperReportExWApi_js_1.gs_PaperReportEx_GetReportMonthNumObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_ReportMonthNumObjLst1 = jsonData;
            });
            var strhtml = "";
            for (var i = 0; i < arrgs_ReportYearNumObjLst.length; i++) {
                var strYear = arrgs_ReportYearNumObjLst[i].year;
                strhtml += '<li class="li">';
                strhtml += '<a href="#" id="' + strYear + '" class="main" title="' + strYear + '" onclick=main_Click("' + strYear + '")>' + strYear + '年</a>';
                strhtml += '<ul class="submenu" id="ul' + strYear + '">';
                arrgs_ReportMonthNumObjLst2 = arrgs_ReportMonthNumObjLst1.filter(x => x.year == strYear);
                //循环数据
                for (var j = 0; j < arrgs_ReportMonthNumObjLst2.length; j++) {
                    var strMonth = arrgs_ReportMonthNumObjLst2[j].month;
                    strhtml += '<li id="' + strYear + strMonth + '" onclick=btnSelectMonth("' + strYear + '","' + strMonth + '")>';
                    //默认存放第一条数据显示；
                    //判断存放的id控件是否为空；
                    if ($("#hidYear").val() == "") {
                        //存放Id
                        $("#hidYear").val(strYear);
                        $("#hidMonth").val(strMonth);
                        strhtml += '<a style="float:left;" href="#" title="' + strMonth + '" class="selected">' + strMonth + '月</a>';
                    }
                    else {
                        strhtml += '<a style="float:left;" href="#" title="' + strMonth + '">' + strMonth + '月</a>';
                    }
                    strhtml += '<div>';
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="badge badge-primary" title="论文汇报' + arrgs_ReportMonthNumObjLst2[j].memo + '条">' + arrgs_ReportMonthNumObjLst2[j].memo + '</span>';
                    strhtml += '</div>';
                    strhtml += '</li>';
                }
                strhtml += '</ul>';
                strhtml += '</li>';
            }
            $("#PaperReportTreeBind").html(strhtml);
        }
        //论文汇报列表绑定
        async Bind_PaperReportList() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = " topicId='" + strTopicId + "' and year='" + $("#hidYear").val() + "' and month='" + $("#hidMonth").val() + "'";
            //声明主题变量
            var arrgs_ReportDateNumObjLst = [];
            var arrgs_PaperReportObjLst1 = [];
            var arrgs_PaperReportObjLst2 = [];
            try {
                const responseObjLst1 = await (0, clsgs_PaperReportExWApi_js_1.gs_PaperReportEx_GetReportDateNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_ReportDateNumObjLst = jsonData;
                });
                const responseObjLst2 = await (0, clsvgs_PaperReportWApi_js_1.vgs_PaperReport_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_PaperReportObjLst1 = jsonData;
                });
                //获取用户缓存数据
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                var strhtml = "";
                for (var i = 0; i < arrgs_ReportDateNumObjLst.length; i++) {
                    var strReportDate = arrgs_ReportDateNumObjLst[i].reportDate;
                    strhtml += '<li class="layui-timeline-item">';
                    strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
                    strhtml += '<div class="layui-timeline-content layui-text">';
                    strhtml += '<h3 class="layui-timeline-title">' + strReportDate + '</h3>';
                    arrgs_PaperReportObjLst2 = arrgs_PaperReportObjLst1.filter(x => x.reportDate == strReportDate);
                    for (var j = 0; j < arrgs_PaperReportObjLst2.length; j++) {
                        var strKeyId = arrgs_PaperReportObjLst2[j].reportId;
                        var strReportContent = arrgs_PaperReportObjLst2[j].reportContent;
                        //处理换行
                        strReportContent = strReportContent.replace(/\r\n/g, strBr);
                        strReportContent = strReportContent.replace(/\n/g, strBr);
                        var strPPT = arrgs_PaperReportObjLst2[j].ppTUrl;
                        var strPDF = arrgs_PaperReportObjLst2[j].pdFUrl;
                        var strUpdUser = arrgs_PaperReportObjLst2[j].updUser;
                        var isSubmit = arrgs_PaperReportObjLst2[j].isSubmit;
                        var versionCount = arrgs_PaperReportObjLst2[j].versionCount;
                        var strReportUser = arrgs_PaperReportObjLst2[j].reportUser;
                        var strReportPaper = arrgs_PaperReportObjLst2[j].paperTitle;
                        var strUpdDate = arrgs_PaperReportObjLst2[j].updDate;
                        //strhtml += '<div>汇报论文:' + strReportPaper + '</div>';
                        strhtml += '<span class="rowtit color1">[汇报论文]：</span>' + strReportPaper;
                        strhtml += '<div>' + strReportContent + '</div>';
                        strhtml += '<div>';
                        if (arrgs_PaperReportObjLst2[j].score != 0) {
                            //评分
                            strhtml += '综合评分：' + arrgs_PaperReportObjLst2[j].score;
                        }
                        if (arrgs_PaperReportObjLst2[j].teaScore != 0) {
                            strhtml += '&nbsp;&nbsp;教师评分：' + arrgs_PaperReportObjLst2[j].teaScore;
                        }
                        if (arrgs_PaperReportObjLst2[j].stuScore != 0) {
                            strhtml += '&nbsp;&nbsp;学生评分：' + arrgs_PaperReportObjLst2[j].stuScore + '&nbsp;&nbsp;';
                        }
                        strhtml += "<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('论文汇报评论', '../GraduateEduTools/SysComment?Key=" + strKeyId + "&Type=12&User=" + strUpdUser + "&pubParentId=" + strTopicId + "')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrgs_PaperReportObjLst2[j].appraiseCount + "</span></button >";
                        strhtml += '</div>';
                        strhtml += '<div style="width:100%;height:40px;">';
                        strhtml += '<div style="float:left;">';
                        var objUser = arrUsers.find(x => x.userId == strUpdUser);
                        if (objUser != null) {
                            strhtml += '<span class="rowtit color1">[编辑用户]：</span>' + objUser.userName;
                        }
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[编辑时间]：</span>' + strUpdDate;
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[汇报人]：</span>' + strReportUser;
                        if (arrgs_PaperReportObjLst2[j].ppTUrl != "") {
                            var strfilepath = strAddressAndPort + arrgs_PaperReportObjLst2[j].ppTUrl;
                            var strfilename = strReportDate + "汇报的PPT";
                            strhtml += '<button title="下载PPT" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoad_PaperReport_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载PPT</button>';
                        }
                        if (arrgs_PaperReportObjLst2[j].pdFUrl != "") {
                            var strfilepath = strAddressAndPort + arrgs_PaperReportObjLst2[j].pdFUrl;
                            var strfilename = strReportDate + "汇报的PDF";
                            strhtml += '<button title="下载PDF" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoad_PaperReport_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载PDF</button>';
                            strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/Pdf?file=" + strfilepath + "')\">pdf查看</span>";
                        }
                        strhtml += '</div>';
                        strhtml += '<div style="float:right; margin-right:20px;">';
                        if (isSubmit == false) {
                            strhtml += '&nbsp;<span class="rowtit color2">未提交</span>&nbsp;&nbsp;';
                            if (strUserId == strUpdUser) {
                                //删除
                                strhtml += '<button title="提交论文汇报" class="layui-btn layui-btn-danger layui-btn-xs" onclick=UpdateIsSubmit_Click("' + strKeyId + '",1) href="javascript:;"><i class="layui-icon">&#x1005;</i>提交</button>';
                                //编辑
                                strhtml += '<button title="编辑论文汇报" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_PaperReport_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';
                            }
                            if (strRoleId != "00620003") {
                                //删除
                                strhtml += '<button title="删除论文汇报" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_PaperReport_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                            }
                        }
                        else {
                            strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[已提交]</span>';
                            if (strRoleId == "00620001") {
                                //删除
                                strhtml += '<button title="撤销提交" class="layui-btn layui-btn-danger layui-btn-xs" onclick=UpdateIsSubmit_Click("' + strKeyId + '",0) href="javascript:;"><i class="layui-icon">&#xe9aa;</i>撤销提交</button>';
                            }
                        }
                        //判断角色
                        //不等于学生，其他角色都可以添加问题
                        strhtml += '</div>';
                        strhtml += '</div>';
                        //strhtml += '</br>';
                        strhtml += '<div style="border-bottom: 1px solid #eee;"></div>';
                    }
                    strhtml += '</div>';
                    strhtml += '</li>';
                }
                $("#PaperReportList").html(strhtml);
            }
            catch (e) {
                console.error(e);
                var strMsg = `获取论文汇报列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //public GetPaperReport_PPT_PDF() {
        //    var strPapeId = $("#hidPaperId").val();
        //    //this.keyId = strPaperRWId;
        //    var strWhereCond = ` ${clsPaperAttachmentEN.con_PaperId} =  ${strPapeId}`;
        //    var arrPaperAttachmentObjLst: Array<clsPaperAttachmentEN> = [];
        //    try {
        //        const responseText = PaperAttachment_GetObjLstAsync(strWhereCond).then((jsonData) => {
        //            arrPaperAttachmentObjLst = <Array<clsPaperAttachmentEN>>jsonData;
        //            for (var i = 0; i < arrPaperAttachmentObjLst.length; i++) {
        //                var strfilepath = strAddressAndPort + arrPaperAttachmentObjLst[i].filePath;
        //                doDownLoad(strfilepath, arrPaperAttachmentObjLst[i].paperAttachmentName);
        //            }
        //        });
        //    }
        //    catch (e) {
        //        console.error(e);
        //        var strMsg: string = `根据关键字获取相应的记录的对象不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //论文汇报提交
        async UpdateIsSubmit_Click(strKeyId, stata) {
            const strThisFuncName = this.UpdateIsSubmit_Click.name;
            var objgs_PaperReportEN = new clsgs_PaperReportEN_js_1.clsgs_PaperReportEN();
            objgs_PaperReportEN.reportId = strKeyId;
            if (stata == 0) {
                objgs_PaperReportEN.SetIsSubmit(false);
            }
            else {
                objgs_PaperReportEN.SetIsSubmit(true);
            }
            objgs_PaperReportEN.sf_UpdFldSetStr = objgs_PaperReportEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_PaperReportEN.reportId == "" || objgs_PaperReportEN.reportId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsgs_PaperReportWApi_js_1.gs_PaperReport_UpdateRecordAsync)(objgs_PaperReportEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    if (stata == 0) {
                        layui_Alert(1, "提交撤销成功！");
                    }
                    else {
                        layui_Alert(1, "会议提交成功！");
                    }
                    const responseBindGv = await this.Bind_PaperReportList();
                    //gs_PaperReport_ReFreshCache();
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `会议提交不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /*
       在数据表里删除记录
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
      */
        async btnDelRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelRecord(strKeyId);
                const responseBindGv = await this.Bind_PaperReportList();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
       根据关键字删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
      */
        async DelRecord(strReportId) {
            try {
                const responseText = await (0, clsgs_PaperReportWApi_js_1.gs_PaperReport_DelRecordAsync)(strReportId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_PaperReport_ReFreshCache();
                    var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                    //显示信息框
                    //alert();
                    layui_Alert(1, strInfo);
                }
                else {
                    var strInfo = `删除记录不成功!`;
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.gs_PaperReportCRUDEx = gs_PaperReportCRUDEx;
});
