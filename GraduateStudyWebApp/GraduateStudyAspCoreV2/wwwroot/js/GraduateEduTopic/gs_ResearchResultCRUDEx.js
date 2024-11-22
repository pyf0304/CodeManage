(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/gs_ResearchResultCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubConfig/clsSysPara4WebApi.js", "./gs_ResearchResult_EditEx.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../PagesBase/GraduateEduTopic/gs_ResearchResult_Edit.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchResultCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_ResearchResultCRUDEx
    表名:gs_ResearchResult(01120780)
    生成代码版本:2020.12.17.1
    生成日期:2020/12/22 22:18:41
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
    const gs_ResearchResultCRUD_js_1 = require("../PagesBase/GraduateEduTopic/gs_ResearchResultCRUD.js");
    const clsvgs_ResearchResultEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchResultEN.js");
    const clsgs_ResearchResultAttachmentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultAttachmentWApi.js");
    const clsgs_ResearchResultWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchResultWApi.js");
    const clsvgs_ResearchResultWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchResultWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const gs_ResearchResult_EditEx_js_1 = require("./gs_ResearchResult_EditEx.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const gs_ResearchResult_Edit_js_1 = require("../PagesBase/GraduateEduTopic/gs_ResearchResult_Edit.js");
    /* gs_ResearchResultCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_ResearchResultCRUDEx extends gs_ResearchResultCRUD_js_1.gs_ResearchResultCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvgs_ResearchResultBy: string = "resultId";
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
                case "vgs_ResearchResult":
                    alert('该类没有绑定该函数：[this.BindGv_vgs_ResearchResult_Cache]！');
                    //this.BindGv_vgs_ResearchResult_Cache();
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_ResearchResultCRUDEx();
            var objPage_Edit = new gs_ResearchResult_EditEx_js_1.gs_ResearchResult_EditEx(objPage);
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
                    var strMsg = '命令:' + strCommandName + "在函数(gs_ResearchResultCRUDExEx.btn_Click)中没有被处理！";
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
                gs_ResearchResult_Edit_js_1.gs_ResearchResult_Edit.id_CurrEduCls_Static = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                //this.divName4Pager = "divPager_ResearchResult";  //列表中的分页区的层Id
                this.divName4Query = "divResearchResult";
                //if (this.bolIsInitShow == false)  //
                //{
                //    this.objPager.InitShow(this.divName4Pager);
                //    this.bolIsInitShow = true;  //
                //}
                const responseBindGv = await this.Bind_ResearchResultList();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        async Combinevgs_ResearchResultCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = " 1 = 1 and topicId='" + strTopicId + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.resultName_q != "") {
                    strWhereCond += ` And ${clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_ResultName} like '% ${this.resultName_q}%'`;
                }
                if (this.updDate_q != "") {
                    strWhereCond += ` And ${clsvgs_ResearchResultEN_js_1.clsvgs_ResearchResultEN.con_UpdDate} like '% ${this.updDate_q}%'`;
                }
                strWhereCond += ` order by updDate Desc`;
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(Combinegs_ResearchResultCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //研究成果列表绑定
        async Bind_ResearchResultList() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            var strAddressAndPort = `${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort}/${clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx_Local}/`;
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = await this.Combinevgs_ResearchResultCondition();
            //var strWhereCond = " topicId='" + strTopicId + "' and year='" + $("#hidYear").val() + "' and month='" + $("#hidMonth").val() + "'";
            //声明主题变量
            //var arrgs_ResultDateNumObjLst: Array<clsgs_ResearchResultEN> = [];
            var arrgs_ResearchResultObjLst1 = [];
            var arrgs_ResearchResultObjLst2 = [];
            var arrgs_ResearchResultAttachmentObjLst = [];
            //const responseObjLst1 = await gs_ResearchResultEx_GetResultDateNumObjLstAsync(strWhereCond).then((jsonData) => {
            //    arrgs_ResultDateNumObjLst = <Array<clsgs_ResearchResultEN>>jsonData;
            //});
            const responseObjLst1 = await (0, clsvgs_ResearchResultWApi_js_1.vgs_ResearchResult_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_ResearchResultObjLst1 = jsonData;
            });
            //获取图片
            var strWhereCond = " 1=1 and topicId ='" + strTopicId + "'";
            const responseObjLst2 = await (0, clsgs_ResearchResultAttachmentWApi_js_1.gs_ResearchResultAttachment_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_ResearchResultAttachmentObjLst = jsonData;
            });
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            var strhtml = "";
            //for (var i = 0; i < arrgs_ResultDateNumObjLst.length; i++) {
            //    var strResultDate = arrgs_ResultDateNumObjLst[i].updDate;
            //    strhtml += '<li class="layui-timeline-item">';
            //    strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
            //    strhtml += '<div class="layui-timeline-content layui-text">';
            //    strhtml += '<h3 class="layui-timeline-title">' + strResultDate + '</h3>';
            //arrgs_ResearchResultObjLst1 = arrgs_ResearchResultObjLst1.filter(x => x.updDate == strResultDate);
            for (var j = 0; j < arrgs_ResearchResultObjLst1.length; j++) {
                var strResultDate = arrgs_ResearchResultObjLst1[j].updDate;
                strhtml += '<li class="layui-timeline-item">';
                strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
                strhtml += '<div class="layui-timeline-content layui-text">';
                strhtml += '<h3 class="layui-timeline-title">' + strResultDate + '</h3>';
                var strKeyId = arrgs_ResearchResultObjLst1[j].resultId;
                var strResultName = arrgs_ResearchResultObjLst1[j].resultName;
                var strResultContent = arrgs_ResearchResultObjLst1[j].resultContent;
                var strAuthor = arrgs_ResearchResultObjLst1[j].author;
                var strDivision = arrgs_ResearchResultObjLst1[j].division;
                //处理换行
                strResultContent = strResultContent.replace(/\r\n/g, strBr);
                strResultContent = strResultContent.replace(/\n/g, strBr);
                //var strPPT = arrgs_ResearchResultObjLst1[j].ppTUrl;
                //var strPDF = arrgs_ResearchResultObjLst1[j].pdFUrl;
                var strUpdUser = arrgs_ResearchResultObjLst1[j].updUser;
                //var isSubmit = arrgs_ResearchResultObjLst1[j].isSubmit;
                var versionCount = arrgs_ResearchResultObjLst1[j].versionCount;
                //var strResultUser = arrgs_ResearchResultObjLst1[j].ResultUser;
                //var strResultPaper = arrgs_ResearchResultObjLst1[j].paperTitle;
                var strUpdDate = arrgs_ResearchResultObjLst1[j].updDate;
                var strResultTypeId = arrgs_ResearchResultObjLst1[j].resultTypeId;
                //strhtml += '<div>汇报论文:' + strResultPaper + '</div>';
                strhtml += '<div><span class="rowtit color1">[成果名称]：</span>' + strResultName + '</div>';
                strhtml += '<div><span class="rowtit color2">[研究说明]：</span>' + strResultContent + '</div>';
                strhtml += '<div><span class="rowtit color3">[作者]：</span>' + strAuthor + '</div>';
                strhtml += '<div><span class="rowtit color4">[研究分工]：</span>' + strDivision + '</div>';
                var strResultType = "";
                var strResultLink = 'resultId=' + strKeyId + '&resultTypeId=' + strResultTypeId;
                switch (strResultTypeId) {
                    case "01": //选择论文
                        strResultType = "选择论文";
                        strResultLink += '&paperId=' + arrgs_ResearchResultObjLst1[j].paperId;
                        break;
                    case "02": //pdf
                        strResultType = "上传论文";
                        break;
                    case "03": //图片
                        strResultType = "图片展示";
                        break;
                    case "04": //压缩文件
                        strResultType = "压缩文件";
                        break;
                    case "05": //压缩文件
                        strResultType = "Word";
                        break;
                    case "06": //压缩文件
                        strResultType = "PPT";
                        break;
                }
                strhtml += '<div><span class="rowtit color5">[成果类型]：</span>' + strResultType;
                //strhtml += '<div>';
                if (strResultTypeId == "04" || strResultTypeId == "05" || strResultTypeId == "06") {
                    var objgs_ResearchResultAttachment = arrgs_ResearchResultAttachmentObjLst.find(x => x.resultId == strKeyId);
                    if (objgs_ResearchResultAttachment != null) {
                        var strfilepath = strAddressAndPort + objgs_ResearchResultAttachment.filePath;
                        strResultDate = strResultDate.substring(0, 10);
                        var strfilename = strResultDate + strResultType + "附件";
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<button title="下载附件" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDownLoad_ResearchResult_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载附件</button>';
                    }
                }
                else {
                    strhtml += "&nbsp;&nbsp;&nbsp;&nbsp;<button class=\"layui-btn layui-btn-normal layui-btn-xs\" onclick=\"xadmin.open('研究成果详情', '../GraduateEduTopic/ResearchResultDetail?" + strResultLink + "')\"> <i class=\"layui-icon\" >&#xe705;</i>研究成果详情</button >";
                }
                strhtml += '</div>';
                strhtml += '<div style="width:100%;height:40px;">';
                strhtml += '<div style="float:left;">';
                var objUser = arrUsers.find(x => x.userId == strUpdUser);
                if (objUser != null) {
                    strhtml += '<span class="rowtit color1">[编辑用户]：</span>' + objUser.userName;
                }
                if (arrgs_ResearchResultObjLst1[j].score != 0) {
                    //评分
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;综合评分：' + arrgs_ResearchResultObjLst1[j].score;
                }
                if (arrgs_ResearchResultObjLst1[j].teaScore != 0) {
                    strhtml += '&nbsp;&nbsp;教师评分：' + arrgs_ResearchResultObjLst1[j].teaScore;
                }
                if (arrgs_ResearchResultObjLst1[j].stuScore != 0) {
                    strhtml += '&nbsp;&nbsp;学生评分：' + arrgs_ResearchResultObjLst1[j].stuScore + '&nbsp;&nbsp;';
                }
                strhtml += "&nbsp;&nbsp;&nbsp;&nbsp;<button class=\"layui-btn layui-btn layui-btn-xs\" onclick=\"xadmin.open('研究成果评论', '../GraduateEduTools/SysComment?Key=" + strKeyId + "&Type=13&User=" + strUpdUser + "&pubParentId=" + strTopicId + "&scoreType=3')\"> <i class=\"layui-icon\" >&#xe642;</i>添加评论<span class=\"layui-badge\">" + arrgs_ResearchResultObjLst1[j].appraiseCount + "</span></button >";
                //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[编辑时间]：</span>' + strUpdDate;
                //strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[汇报人]：</span>' + strResultUser;
                //if (arrgs_ResearchResultObjLst2[j].ppTUrl != "") {
                //    var strfilepath = strAddressAndPort + arrgs_ResearchResultObjLst2[j].ppTUrl;
                //    var strfilename = arrgs_ResearchResultObjLst2[i].ResultDate + "汇报的PPT";
                //    strhtml += '<button title="下载PPT" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoad_ResearchResult_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载PPT</button>';
                //}
                //if (arrgs_ResearchResultObjLst2[j].pdFUrl != "") {
                //    var strfilepath = strAddressAndPort + arrgs_ResearchResultObjLst2[j].pdFUrl;
                //    var strfilename = arrgs_ResearchResultObjLst2[j].ResultDate + "汇报的PDF";
                //    strhtml += '<button title="下载PDF" class="layui-btn layui-btn layui-btn-xs" onclick=btnDownLoad_ResearchResult_Click("' + strfilepath + '","' + strfilename + '")><i class="layui-icon">&#xe601;</i>下载PDF</button>';
                //    strhtml += "<span class=\"colorRed\" style=\"padding-left:50px;\" onclick=\"xadmin.open('pdf查看', '../GraduateEduEx/Pdf?file=" + strfilepath + "')\">pdf查看</span>";
                //}
                strhtml += '</div>';
                strhtml += '<div style="float:right; margin-right:20px;">';
                if (strUserId == strUpdUser) {
                    //编辑
                    strhtml += '<button title="编辑研究成果" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_ResearchResult_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';
                    //删除
                    strhtml += '<button title="删除研究成果" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_ResearchResult_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                }
                //if (isSubmit == false) {
                //    strhtml += '&nbsp;<span class="rowtit color2">未提交</span>&nbsp;&nbsp;';
                //    if (strUserId == strUpdUser) {
                //        //删除
                //        strhtml += '<button title="提交研究成果" class="layui-btn layui-btn-danger layui-btn-xs" onclick=UpdateIsSubmit_Click("' + strKeyId + '",1) href="javascript:;"><i class="layui-icon">&#x1005;</i>提交</button>';
                //        //编辑
                //        strhtml += '<button title="编辑研究成果" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_ResearchResult_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';
                //    }
                //    if (strRoleId != "00620003") {
                //        //删除
                //        strhtml += '<button title="删除研究成果" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_ResearchResult_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                //    }
                //} else {
                //    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[已提交]</span>';
                //    if (strRoleId == "00620001") {
                //        //删除
                //        strhtml += '<button title="撤销提交" class="layui-btn layui-btn-danger layui-btn-xs" onclick=UpdateIsSubmit_Click("' + strKeyId + '",0) href="javascript:;"><i class="layui-icon">&#xe9aa;</i>撤销提交</button>';
                //    }
                //}
                //判断角色
                //不等于学生，其他角色都可以添加问题
                strhtml += '</div>';
                strhtml += '</div>';
                //strhtml += '</br>';
                strhtml += '<div style="border-bottom: 1px solid #eee;"></div>';
                //}
                strhtml += '</div>';
                strhtml += '</li>';
            }
            $("#ResearchResultList").html(strhtml);
        }
        //public GetResearchResult_PPT_PDF() {
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
        //研究成果提交
        //public async UpdateIsSubmit_Click(strKeyId: string, stata: number) {
        //    var objgs_ResearchResultEN: clsgs_ResearchResultEN = new clsgs_ResearchResultEN();
        //    objgs_ResearchResultEN.SetResultId(strKeyId;
        //    if (stata == 0) {
        //        objgs_ResearchResultEN.SetIsSubmit(false;
        //    } else {
        //        objgs_ResearchResultEN.SetIsSubmit(true;
        //    }
        //    objgs_ResearchResultEN.sf_UpdFldSetStr = objgs_ResearchResultEN.updFldString;//设置哪些字段被修改(脏字段)
        //    if (objgs_ResearchResultEN.resultId == "" || objgs_ResearchResultEN.resultId == undefined) {
        //         throw Format("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
        //    }
        //    try {
        //        const responseText = await gs_ResearchResult_UpdateRecordAsync(objgs_ResearchResultEN);
        //        var returnBool: boolean = !!responseText;
        //        if (returnBool == true) {
        //            if (stata == 0) {
        //                layui_Alert(1, "提交撤销成功！")
        //            } else {
        //                layui_Alert(1, "会议提交成功！")
        //            }
        //            const responseBindGv = await this.Bind_ResearchResultList();
        //            //gs_ResearchResult_ReFreshCache();
        //        }
        //        return returnBool;
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `会议提交不成功,${e}.`;
        //        alert(strMsg);
        //        return false;
        //    }
        //}
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
                const responseBindGv = await this.Bind_ResearchResultList();
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
        async DelRecord(strResultId) {
            try {
                const responseText = await (0, clsgs_ResearchResultWApi_js_1.gs_ResearchResult_DelRecordAsync)(strResultId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_ResearchResult_ReFreshCache();
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
    exports.gs_ResearchResultCRUDEx = gs_ResearchResultCRUDEx;
});
