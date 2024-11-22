(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsDropDownList.js", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js", "../TS/L0_Entity/InteractManage/clsqa_PushEN.js", "../TS/L0_Entity/InteractManage/clsvqa_QuestionsEN.js", "../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js", "../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js", "../TS/L3_ForWApi/InteractManage/clsvqa_PushWApi.js", "../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js", "../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js", "../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "./qa_PaperCRUD.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_PaperCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:qa_PaperCRUDEx
    表名:qa_Paper(01120643)
    生成代码版本:2020.05.28.1
    生成日期:2020/06/02 01:10:24
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:互动管理
    模块英文名:InteractManage
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsvPaperEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperEN.js");
    const clsqa_PushEN_js_1 = require("../TS/L0_Entity/InteractManage/clsqa_PushEN.js");
    const clsvqa_QuestionsEN_js_1 = require("../TS/L0_Entity/InteractManage/clsvqa_QuestionsEN.js");
    const clsgs_ShareEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsgs_ShareEN.js");
    const clsLiteratureTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsqa_PushWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsqa_PushWApi.js");
    const clsvqa_PushWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_PushWApi.js");
    const clsvqa_QuestionsWApi_js_1 = require("../TS/L3_ForWApi/InteractManage/clsvqa_QuestionsWApi.js");
    const clsgs_ShareWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ShareWApi.js");
    const clsLiteratureTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsLiteratureTypeWApi.js");
    const clsgs_UserConfigExWApi_js_1 = require("../TS/L3_ForWApiEx/ExamManage/clsgs_UserConfigExWApi.js");
    const clsvPaperExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsvPaperExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const qa_PaperCRUD_js_1 = require("./qa_PaperCRUD.js");
    /* qa_PaperCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class qa_PaperCRUDEx extends qa_PaperCRUD_js_1.qa_PaperCRUD {
        constructor() {
            super(...arguments);
            //论文列表
            this.mstrListDivPaper = "divPaperDataLst";
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
                    //建立缓存
                    //
                    // 为查询区绑定下拉框
                    //const gvBindDdl = await this.BindDdl4QueryRegion();
                    this.hidSortvqa_PaperBy = "updDate Desc";
                    this.hidSortvPaperBy = "updDate Desc";
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult1 = await this.BindGv_vqa_Paper();
                    const gvResult2 = await this.Bind_QuestionsCount();
                    if ($("#hidQuestionsCount").val() > 0) {
                        const gvResult3 = await this.BindGv_vqa_Push();
                    }
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /****************************************************答疑邀请相关 Start***************************************************/
        Combinevqa_PushCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                strWhereCond += " and id_CurrEduCls=" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                strWhereCond += " and receiveUser='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "' and isReceive=0";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //答疑被邀请数
        async Bind_QuestionsCount() {
            try {
                //var strWhereCond = " 1=1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                //strWhereCond += " and receiveUser='" + clsPubSessionStorage.GetSession_UserId() + "' and isReceive=0";
                var strWhereCond = this.Combinevqa_PushCondition();
                var intQuestionsCount = await (0, clsqa_PushWApi_js_1.qa_Push_GetRecCountByCondAsync)(strWhereCond);
                $("#questionsCount").html(intQuestionsCount);
                $("#hidQuestionsCount").val(intQuestionsCount);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定答疑被邀请列表
        async BindGv_vqa_Push() {
            var strWhereCond = this.Combinevqa_PushCondition();
            strWhereCond += " order by updDate Asc";
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            var arrvqa_PushObjLst = [];
            try {
                //const responseRecCount = await vqa_Push_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                //var objPagerPara: stuPagerPara = {
                //    pageIndex: intCurrPageIndex,
                //    pageSize: this.pageSize,
                //    whereCond: strWhereCond,
                //    orderBy: "updDate Asc"
                //};
                //const responseObjLst = await vqa_Push_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvqa_PushObjLst = <Array<clsvqa_PushEN>>jsonData;
                //});
                const responseObjLst = await (0, clsvqa_PushWApi_js_1.vqa_Push_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvqa_PushObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定推送数据不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvqa_PushObjLst.length > 10) {
            //    $("#divPager").show();
            //}
            try {
                var strhtml = "";
                strhtml += '<div class="info" id="infoSubViewpoint">';
                //strhtml += '<div class="title btn-2">';
                //strhtml += '<a href="#" title="当前pdf论文上的第几页一共有几个问题">第' + arrvqa_PdfPageNumObjLst[j].pdfPageNum + '页上的' + arrvqa_QuestionsObjLst.length + '个问题</a>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加问题" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewQuestions_Click();> <i class="layui-icon" ></i>添加问题</button></div>';
                //strhtml += '</div><ul class="artlist">';
                strhtml += '<ul class="artlist">';
                var k = 0;
                for (var i = 0; i < arrvqa_PushObjLst.length; i++) {
                    k++;
                    strhtml += '<li id="li' + arrvqa_PushObjLst[i].questionsId + '">&nbsp;&nbsp;&nbsp;<span class="rowtit color1">' + k + '、</span>';
                    //strhtml += '&nbsp;<span class="rowtit color2" title="该问题在pdf的第' + arrvqa_PushObjLst[i].pdfPageNum + '页有标注">[' + arrvqa_PushObjLst[i].pdfPageNum + ']</span>';
                    strhtml += '<span class="title btn-1"><a href="#"  class="abstract-text">' + arrvqa_PushObjLst[i].questionsContent + '</a></span>';
                    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span title="当前问题已经有' + arrvqa_PushObjLst[i].answerCount + '个回答" class="badge badge-info">' + arrvqa_PushObjLst[i].answerCount + '</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="badge badge-primary" title="该问题在pdf的第' + arrvqa_PushObjLst[i].pdfPageNum + '页有标注">' + arrvqa_PushObjLst[i].pdfPageNum + '页</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="badge badge-pill badge-success" title="当前问题已经有' + arrvqa_PushObjLst[i].answerCount + '个回答" >' + arrvqa_PushObjLst[i].answerCount + '</span>';
                    //回复
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="回复" class="layui-btn layui-btn layui-btn-xs" onclick=btnQA_PushRecord_Click("' + arrvqa_PushObjLst[i].paperId + '","' + arrvqa_PushObjLst[i].questionsId + '","' + arrvqa_PushObjLst[i].pushId + '")><i class="layui-icon">&#xe6b2;</i></button>';
                    //忽略
                    strhtml += '&nbsp;<button title="忽略" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btnUpdQA_Push_Click("' + arrvqa_PushObjLst[i].pushId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                    strhtml += '</li>';
                    strhtml += '<li style="text-align:right;>';
                    strhtml += '<span class="rowtit color5">[提问人]：</span>' + arrvqa_PushObjLst[i].userName + '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[提问时间]：</span>' + arrvqa_PushObjLst[i].updDate;
                    strhtml += '</li>';
                    //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div>';
                    //strhtml += '<li> <div style="border-bottom: 1px solid #eee;"></div></li>';
                }
                strhtml += '</ul>';
                strhtml += '</div>';
                //拼接；
                $("#home").html(strhtml);
                console.log("完成BindGv_vqa_Push!");
                //历史答疑邀请
                const responseList = await this.BindGv_History_vqa_Push();
                console.log("完成BindGv_History_vqa_Push!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定推送列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //绑定历史答疑被邀请列表
        async BindGv_History_vqa_Push() {
            var strWhereCond = "1=1";
            strWhereCond += " and id_CurrEduCls=" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            strWhereCond += " and receiveUser='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "' and isReceive=1";
            strWhereCond += " order by updDate Desc";
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            var arrvqa_PushObjLst = [];
            try {
                //const responseRecCount = await vqa_Push_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                //var objPagerPara: stuPagerPara = {
                //    pageIndex: intCurrPageIndex,
                //    pageSize: this.pageSize,
                //    whereCond: strWhereCond,
                //    orderBy: "updDate Asc"
                //};
                //const responseObjLst = await vqa_Push_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvqa_PushObjLst = <Array<clsvqa_PushEN>>jsonData;
                //});
                const responseObjLst = await (0, clsvqa_PushWApi_js_1.vqa_Push_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvqa_PushObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定推送数据不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvqa_PushObjLst.length > 10) {
            //    $("#divPager").show();
            //}
            try {
                var strhtml = "";
                strhtml += '<div class="info" id="infoSubViewpoint">';
                //strhtml += '<div class="title btn-2">';
                //strhtml += '<a href="#" title="当前pdf论文上的第几页一共有几个问题">第' + arrvqa_PdfPageNumObjLst[j].pdfPageNum + '页上的' + arrvqa_QuestionsObjLst.length + '个问题</a>';
                ////strhtml += '<div style="float:right; margin-right:20px;"><button style="color:#666" title="添加问题" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnAddNewQuestions_Click();> <i class="layui-icon" ></i>添加问题</button></div>';
                //strhtml += '</div><ul class="artlist">';
                strhtml += '<ul class="artlist">';
                var k = 0;
                for (var i = 0; i < arrvqa_PushObjLst.length; i++) {
                    k++;
                    strhtml += '<li id="li' + arrvqa_PushObjLst[i].questionsId + '">&nbsp;&nbsp;&nbsp;<span class="rowtit color3">' + k + '、</span>';
                    strhtml += '<span class="title btn-3"><a href="#"  class="abstract-text">' + arrvqa_PushObjLst[i].questionsContent + '</a></span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="badge badge-primary" title="该问题在pdf的第' + arrvqa_PushObjLst[i].pdfPageNum + '页有标注">' + arrvqa_PushObjLst[i].pdfPageNum + '页</span>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="badge badge-pill badge-success" title="当前问题已经有' + arrvqa_PushObjLst[i].answerCount + '个回答" >' + arrvqa_PushObjLst[i].answerCount + '</span>';
                    //回复
                    //strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="回复" class="layui-btn layui-btn layui-btn-xs" onclick=btnQA_PushRecord_Click("' + arrvqa_PushObjLst[i].qa_PaperId + '","' + arrvqa_PushObjLst[i].questionsId + '","' + arrvqa_PushObjLst[i].pushId + '")><i class="layui-icon">&#xe6b2;</i></button>';
                    strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="回复" class="layui-btn layui-btn layui-btn-xs" onclick=btnQA_PushRecord_Click("' + arrvqa_PushObjLst[i].paperId + '","' + arrvqa_PushObjLst[i].questionsId + '","' + arrvqa_PushObjLst[i].pushId + '","' + arrvqa_PushObjLst[i].id_CurrEduCls + '")><i class="layui-icon">&#xe6b2;</i></button>';
                    strhtml += '</li>';
                    strhtml += '<li style="text-align:right;>';
                    strhtml += '<span class="rowtit color5">[提问人]：</span>' + arrvqa_PushObjLst[i].userName + '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[提问时间]：</span>' + arrvqa_PushObjLst[i].updDate;
                    if (arrvqa_PushObjLst[i].isReply == true) {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[已回复]：</span>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span class="rowtit color2">[已忽略]：</span>';
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color5">[回复时间]：</span>' + arrvqa_PushObjLst[i].replyDate;
                    strhtml += '</li>';
                    //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div>';
                    //strhtml += '<li> <div style="border-bottom: 1px solid #eee;"></div></li>';
                }
                strhtml += '</ul>';
                strhtml += '</div>';
                //拼接；
                $("#menu1").html(strhtml);
                console.log("完成BindGv_vqa_Push!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定推送列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //被邀请跳转到pdf答疑页面并回复
        //public async btnQA_PushRecord_Click(strqa_PaperId: string, strQuestionsId: string, strPushId: string) {
        //    var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        //    var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        //    var objqa_Paper: clsqa_PaperEN;
        //    var objPaperAttachment: clsPaperAttachmentEN;
        //    var strWhereCond1 = " 1=1 and qa_PaperId ='" + strqa_PaperId + "'";
        //    try {
        //        const responseText1 = await qa_Paper_GetFirstObjAsync(strWhereCond1);
        //        objqa_Paper = <clsqa_PaperEN>responseText1;
        //        var strWhereCond2 = " 1=1 and paperId ='" + objqa_Paper.paperId + "'";
        //        const responseText2 = await PaperAttachment_GetFirstObjAsync(strWhereCond2);
        //        objPaperAttachment = <clsPaperAttachmentEN>responseText2;
        //        var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
        //        if (objPaperAttachment != null) {
        //            var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
        //            window.location.href = "../InteractManage/Pdf_QA?zoom=1.1&id_CurrEduCls=" + strid_CurrEduCls + "&qa_PaperId=" + strqa_PaperId + "&questionsId=" + strQuestionsId + "&pushId=" + strPushId + "&file=" + strfilepath;
        //        } else {
        //            window.location.href = "../InteractManage/Pdf_QA?zoom=1.1&id_CurrEduCls=" + strid_CurrEduCls + "&qa_PaperId=" + strqa_PaperId + "&questionsId=" + strQuestionsId + "&pushId=" + strPushId;
        //        }
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /* 忽略被邀请，
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
      */
        async btnUpdQA_Push_Click(pushId) {
            var objqa_PushEN = new clsqa_PushEN_js_1.clsqa_PushEN();
            objqa_PushEN.pushId = pushId;
            objqa_PushEN.isReceive = true;
            objqa_PushEN.isReply = false;
            objqa_PushEN.replyDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate();
            objqa_PushEN.receiveDate = clsPubFun4Web_js_1.clsPubFun4Web.getNowDate();
            objqa_PushEN.sf_UpdFldSetStr = objqa_PushEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objqa_PushEN.pushId == 0 || objqa_PushEN.pushId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsqa_PushWApi_js_1.qa_Push_UpdateRecordAsync)(objqa_PushEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    Alert1("当前邀请已经被忽略！");
                    const responseCount = await this.Bind_QuestionsCount();
                    const responseList = await this.BindGv_vqa_Push();
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `修改记录不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
        /****************************************************答疑邀请相关 End***************************************************/
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        Combinevqa_PaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //strWhereCond += " and isPublic=1";
            strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperTitle_q != "") {
                    strWhereCond += ` And ${clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle} like '% ${this.PaperTitle_q}%'`;
                }
                if (this.questionsContent != "") {
                    strWhereCond += ` And ${clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent} like '% ${this.questionsContent}%'`;
                }
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                }
                if ($('#hidTypeId').val() == "2") {
                    $('#MyQA').hide();
                    $('#FunInfo').show();
                    //$('#btnAddNewRecord').show();
                    //$('#btnDelRecord').show();
                    strWhereCond += " and updUser='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "'";
                }
                else {
                    $('#MyQA').show();
                    $('#FunInfo').hide();
                    //$('#btnDelRecord').hide();
                    //$('#btnAddNewRecord').hide();
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        async btnQuery_Click() {
            const gvResult = await this.BindGv_vqa_Paper();
        }
        /* 根据条件获取相应的对象列表
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
     */
        async BindGv_vqa_Paper() {
            //var strListDiv: string = this.mstrListDiv;
            //var strWhereCond = this.Combinevqa_PaperCondition();
            //var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager);//获取当前页
            //var arrvqa_PaperObjLst: Array<clsvqa_PaperEN> = [];
            //try {
            //    const responseRecCount = await vqa_Paper_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
            //        this.RecCount = jsonData;
            //    });
            //    var objPagerPara: stuPagerPara = {
            //        pageIndex: intCurrPageIndex,
            //        pageSize: this.pageSize,
            //        whereCond: strWhereCond,
            //        orderBy: this.hidSortvqa_PaperBy
            //    };
            //    const responseObjLst = await vqa_Paper_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
            //        arrvqa_PaperObjLst = <Array<clsvqa_PaperEN>>jsonData;
            //    });
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定GridView不成功,${e}.`;
            //    alert(strMsg);
            //}
            //if (arrvqa_PaperObjLst.length > 10) {
            //    $("#divPager").show();
            //}
            //try {
            //    this.BindTab_vqa_Paper(strListDiv, arrvqa_PaperObjLst);
            //    console.log("完成BindGv_vqa_Paper!");
            //}
            //catch (e) {
            //    console.error('catch(e)=');
            //    console.error(e);
            //    var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
            //    alert(strMsg);
            //}
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinevqa_PaperCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvqa_QuestionsObjLst = [];
            try {
                const responseRecCount = await (0, clsvqa_QuestionsWApi_js_1.vqa_Questions_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvqa_PaperBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvqa_QuestionsWApi_js_1.vqa_Questions_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvqa_QuestionsObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvqa_QuestionsObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vqa_Questions(strListDiv, arrvqa_QuestionsObjLst);
                console.log("完成BindGv_vqa_Questions!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vqa_Questions对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrqa_QuestionsObjLst">需要绑定的对象列表</param>
       */
        BindTab_vqa_Questions(divContainer, arrvqa_QuestionsObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "questionsContent",
                    ColHeader: "提问内容",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "answerCount",
                    ColHeader: "回答计数",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userName",
                    ColHeader: "提问用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "提问日期",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "解答",
                    Text: "解答", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnAnswer_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                //{
                //    FldName: "",
                //    ColHeader: "删除",
                //    Text: "删除", TdClass: "text-left", SortBy: "",
                //    ColumnType: "Button",
                //    orderNum: 1,
                //    FuncName: (strKeyId: string, strText: string) => {
                //        var btn1: HTMLElement = document.createElement("button");
                //        btn1.innerText = strText;
                //        btn1.className = "btn btn-outline-info btn-sm";
                //        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                //        return btn1;
                //    }
                //},
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvqa_QuestionsObjLst, arrDataColumn, "questionsId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        async btnAnswer_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText1 = (0, clsvqa_QuestionsWApi_js_1.vqa_Questions_GetObjByQuestionsIdAsync)(strKeyId).then((jsonData) => {
                    var objvqa_QuestionsEN = jsonData;
                    if (objvqa_QuestionsEN != null) {
                        var strPaperId = objvqa_QuestionsEN.paperId;
                        var strQuestionsId = strKeyId;
                        var strid_CurrEduCls = objvqa_QuestionsEN.id_CurrEduCls;
                        var strHref = "../GraduateEduEx/PaperSubViewpoint_pdf?Type=02&paperId=" + strPaperId + "&questionsId=" + strQuestionsId + "&questionsTypeId=01&id_CurrEduCls=" + strid_CurrEduCls;
                        xadminopen("Pdf论文答疑", strHref);
                    }
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vqa_Paper对象的所有属性值
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        <param name = "divContainer">显示容器</param>
        <param name = "arrqa_PaperObjLst">需要绑定的对象列表</param>
      */
        //public BindTab_vqa_Paper(divContainer: string, arrvqa_PaperObjLst: Array<clsvqa_PaperEN>) {
        //    var o: HTMLDivElement = document.getElementById(divContainer) as HTMLDivElement;
        //    if (o == null) {
        //        alert(`${divContainer}不存在！`);
        //        return;
        //    }
        //    var arrDataColumn: Array<clsDataColumn> =
        //        [
        //            {
        //                FldName: "",
        //                ColHeader: "",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "CheckBox",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "paperTitle",
        //                ColHeader: "论文标题",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            //{
        //            //    FldName: "isPublic",
        //            //    ColHeader: "是否公开",
        //            //    Text: "",TdClass: "text-left",SortBy: "",
        //            //    ColumnType: "Label",
        //            //    orderNum: 1,
        //            //    FuncName: () => { }
        //            //},
        //            {
        //                FldName: "isSubmit",
        //                ColHeader: "是否提交",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "userName",
        //                ColHeader: "用户",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "updDate",
        //                ColHeader: "修改日期",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "attachmentCount",
        //                ColHeader: "附件计数",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "tagsCount",
        //                ColHeader: "标记数",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "questionsCount",
        //                ColHeader: "提问数",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "answerCount",
        //                ColHeader: "回答数",
        //                Text: "", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Label",
        //                orderNum: 1,
        //                FuncName: () => { }
        //            },
        //            {
        //                FldName: "",
        //                ColHeader: "参与答疑",
        //                Text: "参与答疑", TdClass: "text-left", SortBy: "",
        //                ColumnType: "Button",
        //                orderNum: 1,
        //                FuncName: (strKeyId: string, strText: string) => {
        //                    var btn1: HTMLElement = document.createElement("button");
        //                    btn1.innerText = strText;
        //                    btn1.className = "btn btn-outline-info btn-sm";
        //                    btn1.setAttribute("onclick", `btnQARecord_Click('${strKeyId}');`);
        //                    return btn1;
        //                }
        //            },
        //        ];
        //    clsCommonFunc4Web.BindTabV2(o, arrvqa_PaperObjLst, arrDataColumn, "qa_PaperId");
        //    this.objPager.RecCount = this.RecCount;
        //    this.objPager.pageSize = this.pageSize;
        //    this.objPager.ShowPagerV2(this, this.divName4Pager);
        //}
        //答疑主界面列表正常跳转到pdf答疑页面
        //public async btnQARecord_Click(strKeyId: string) {
        //    //this.OpType = "Update";
        //    var strReadWriteTypeId = $("#hidReadWriteTypeId").val();
        //    var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
        //    var objqa_Paper: clsqa_PaperEN;
        //    var objPaperAttachment: clsPaperAttachmentEN;
        //    var strWhereCond1 = " 1=1 and qa_PaperId ='" + strKeyId + "'";
        //    try {
        //        const responseText1 = await qa_Paper_GetFirstObjAsync(strWhereCond1);
        //        objqa_Paper = <clsqa_PaperEN>responseText1;
        //        var strPaperId = objqa_Paper.paperId;
        //        var strWhereCond2 = " 1=1 and paperId ='" + strPaperId + "'";
        //        const responseText2 = await PaperAttachment_GetFirstObjAsync(strWhereCond2);
        //        objPaperAttachment = <clsPaperAttachmentEN>responseText2;
        //        var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
        //        if (objPaperAttachment != null) {
        //            var strfilepath = strAddressAndPort + objPaperAttachment.filePath;
        //            window.location.href = "../InteractManage/Pdf_QA?id_CurrEduCls=" + strid_CurrEduCls + "&qa_PaperId=" + strKeyId + "&paperId=" + strPaperId + "&file=" + strfilepath;
        //        } else {
        //            window.location.href = "../InteractManage/Pdf_QA?id_CurrEduCls=" + strid_CurrEduCls + "&qa_PaperId=" + strKeyId + "&paperId=" + strPaperId;
        //        }
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `绑定对象列表不成功.Error Massage:${e}.`;
        //        alert(strMsg);
        //    }
        //}
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new qa_PaperCRUDEx();
            switch (strCommandName) {
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //ShowDialog('AddWithMaxId');
                    console.log('进入了btn_Click事件');
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //ShowDialog('AddWithMaxId');
                    objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
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
                    var strMsg = '命令:' + strCommandName + "在函数(WA_Users_QUDI_CacheEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    console.log('开始添加AddDPV_Edit界面');
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    console.log('结束AddDPV_Edit界面');
                    const conBindDdl = await this.BindDdl4EditRegion();
                    console.log('结束BindDdl4EditRegion绑定');
                    ShowDialog('Add');
                    //获取分享Id
                    const responseText = await (0, clsgs_UserConfigExWApi_js_1.gs_UserConfigEx_GetNewReturnShareIdEx)("11", clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                    var strShareId = responseText;
                    //var returnBool: boolean = !!responseText2;
                    if (strShareId != "") {
                        this.shareId = strShareId;
                    }
                    this.BindGv_vPaper();
                    this.bolIsLoadEditRegion = true; //
                }
                else {
                    ShowDialog('Add');
                    console.log('开始绑定BindGv_vPaper');
                    this.BindGv_vPaper();
                    console.log('结束绑定BindGv_vPaper');
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            var objUsers_Cond = new clsvUsersSimEN_js_1.clsvUsersSimEN(); //查询区域
            const ddlDepartmentId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_UsersInvPaper_Cache("ddlUserId", objUsers_Cond); //用户查询区域
            const ddl_LiteratureTypeId_q = await this.BindDdl_LiteratureTypeId_Cache("ddlLiteratureTypeId", new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN);
            var objgs_Share_Cond = new clsgs_ShareEN_js_1.clsgs_ShareEN(); //编辑区域
            const ddl_gs_Share = await (0, clsgs_ShareWApi_js_1.gs_Share_BindDdl_ShareIdInDiv_Cache)(this.divName4List, "ddlShareId");
        }
        async BindDdl_LiteratureTypeId_Cache(ddlLiteratureTypeId, objLiteratureType_Cond) {
            //var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(ddlLiteratureTypeId);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlLiteratureTypeId} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsLiteratureTypeWApi_js_1.LiteratureType_GetSubObjLst_Cache)(objLiteratureType_Cond);
                arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId]);
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlLiteratureTypeId, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
                console.log("完成BindDdl_LiteratureTypeId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        CombinevPaperCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strPaperTypeId = $("#hidPaperTypeId").val();
            var strTopicId = $("#hidTopicRelaId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle != "") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle} like '% ${this.paperTitle}%'`;
                }
                if (this.literatureTypeId != "" && this.literatureTypeId != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId} = '${this.literatureTypeId}'`;
                }
                //用户
                if (this.PaperUser != "" && this.PaperUser != "0") {
                    strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_UpdUser} = '${this.PaperUser}'`;
                }
                //只查询提交后的论文数据
                strWhereCond += ` And ${clsvPaperEN_js_1.clsvPaperEN.con_IsSubmit} = 'true'`;
                //获取论文条件 02代表 小组成员论文数据；
                //var strType = $("#hidstrType").val();
                //if (strType == "02") {
                //    //小组成员的论文数据；
                //    strWhereCond += ` And updUser in (select UserID from RTUserRela where topicId = '${strTopicId}')`;
                //    //排除获取已存在的关系数据
                //    strWhereCond += ` And paperId not in (select paperId from RTResearchResult where topicId = '${strTopicId}')`;
                //}
                //else {
                //    //排除获取已存在的关系数据
                //    strWhereCond += ` And paperId not in (select paperId from RTPaperRela where topicId = '${strTopicId}')`;
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombinevPaperConditionobj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            //var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
            var objvPaper_Cond = new clsvPaperEN_js_1.clsvPaperEN();
            //objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_CurrEduCls, clsPublocalStorage.Getid_CurrEduCls(), "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperTitle != "") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_PaperTitle, this.paperTitle, "like");
                }
                if (this.literatureTypeId != "" && this.literatureTypeId != "0") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_LiteratureTypeId, this.literatureTypeId, "=");
                }
                if (this.PaperUser != "" && this.PaperUser != "0") {
                    objvPaper_Cond.SetCondFldValue(clsvPaperEN_js_1.clsvPaperEN.con_UpdUser, this.PaperUser, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombineUsersConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvPaper_Cond;
        }
        /* 根据条件获取相应的记录对象的列表
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
    */
        async BindGv_vPaper() {
            //var strListDiv: string = this.mstrListDiv;
            var strListDiv = this.mstrListDivPaper;
            //var strWhereCond = this.CombinevPaperCondition();
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            var strWhereCond2 = "";
            var objvPaper_Cond = this.CombinevPaperConditionobj();
            //objvPaper_Cond.SetCondFldValue(clsvPaperEN.con_id_XzMajor, this.id_XzMajor_q, "=");
            strWhereCond2 = JSON.stringify(objvPaper_Cond);
            var intCurrPageIndex = this.CurrPageIndex2; //获取当前页
            var arrvPaperObjLst = [];
            var objPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond2,
                orderBy: this.hidSortvPaperBy,
                sortFun: (x, y) => { return 0; }
            };
            try {
                this.RecCount = await (0, clsvPaperExWApi_js_1.vPaperEx_GetRecCountByCondById_CurrEduCls_Cache)(objvPaper_Cond, strid_CurrEduCls);
                console.log("完成计数!");
                arrvPaperObjLst = await (0, clsvPaperExWApi_js_1.vPaperEx_GetObjLstByPagerById_CurrEduCls_Cache)(objPagerPara, strid_CurrEduCls);
                console.log("完成对象列表获取!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvPaperObjLst.length == 0) {
            //    var strMsg: string = `根据条件获取的对象列表数为空！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                this.BindTab_vPaper(strListDiv, arrvPaperObjLst);
                console.log("完成BindGv_vPaper!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaper对象的所有属性值
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
       <param name = "divContainer">显示容器</param>
       <param name = "arrPaperObjLst">需要绑定的对象列表</param>
     */
        BindTab_vPaper(divContainer, arrvPaperObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paperTitle",
                    ColHeader: "论文标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "periodical",
                    ColHeader: "期刊",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "author",
                    ColHeader: "作者",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "keyword",
                    ColHeader: "关键字",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "literatureSources",
                //    ColHeader: "文献来源",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "updDate",
                //    ColHeader: "提交日期",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "userName",
                    ColHeader: "用户",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                //{
                //    FldName: "pcount",
                //    ColHeader: "读写数",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                //{
                //    FldName: "attachmentCount",
                //    ColHeader: "附件数",
                //    Text: "",TdClass: "text-left",SortBy: "",
                //    ColumnType: "Label",
                //    orderNum: 1,
                //    FuncName: () => { }
                //},
                {
                    FldName: "",
                    ColHeader: "添加",
                    Text: "添加", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnPaperRecordInTab_Click("${strKeyId}");`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2Where(o, arrvPaperObjLst, arrDataColumn, "paperId", "TopicPaper");
            //clsCommonFunc4Web.BindTabV2(o, arrvPaperObjLst, arrDataColumn, "paperId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //添加论文关系
        async btnAddPaperRela_Click(strType) {
            //存放类型区分 论文相关条件；
            $("#hidstrType").val(strType);
            const responseObjList = await this.BindGv_vPaper();
        }
        //查询论列表
        async btnPaperQuery_Click() {
            const responseObjList = await this.BindGv_vPaper();
        }
        //确定选择的论文 并添加到关系表中
        async btnPaperRecordInTab_Click(strkeyId) {
            //存放Id
            $("#hidPaperId").val(strkeyId);
            //判断是否选择分配权限；没选择给出提示；
            //需要提示选择角色
            if (this.shareId != "" && this.shareId != "0") {
                const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                    var returnBool2 = jsonData;
                    if (returnBool2 == true) {
                        HideDialog();
                        this.BindGv_vqa_Paper();
                    }
                });
            }
            else {
                var strInfo = `请选择分配权限下拉框!`;
                //显示信息框
                alert(strInfo);
                return;
            }
        }
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        //public async AddNewRecordWithMaxIdSave() {
        //    this.DivName = "divAddNewRecordWithMaxIdSave";
        //    var objqa_PaperEN: clsqa_PaperEN = new clsqa_PaperEN();
        //    this.PutDataToqa_PaperClass(objqa_PaperEN);
        //    try {
        //        const responseText2 = await qa_Paper_AddNewRecordWithMaxIdAsync(objqa_PaperEN);
        //        var returnBool: boolean = !!responseText2;
        //        if (returnBool == true) {
        //            var strInfo: string = `添加记录成功!`;
        //            $('#lblResult47').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //        }
        //        else {
        //            var strInfo: string = `添加记录不成功!`;
        //            $('#lblResult47').val(strInfo);
        //            //显示信息框
        //            alert(strInfo);
        //        }
        //        return responseText2;//一定要有一个返回值，否则会出错！
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `添加记录不成功,${e}.`;
        //        alert(strMsg);
        //        return false;
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        //public PutDataToqa_PaperClass(pobjqa_PaperEN: clsqa_PaperEN) {
        //    pobjqa_PaperEN.paperId = $("#hidPaperId").val();// 论文Id
        //    pobjqa_PaperEN.isPublic = true;// 是否公开
        //    pobjqa_PaperEN.isSubmit = false;// 是否公开
        //    pobjqa_PaperEN.questionsCount = 0;
        //    pobjqa_PaperEN.answerCount = 0;
        //    pobjqa_PaperEN.shareId = this.shareId;
        //    pobjqa_PaperEN.updDate = clsPubFun4Web.getNowDate();// 修改日期
        //    pobjqa_PaperEN.updUser = clsPubSessionStorage.GetSession_UserId();// 修改日期
        //    pobjqa_PaperEN.id_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();//教学班id
        //    pobjqa_PaperEN.memo = this.memo;// 备注
        //}
        /* 函数功能:在数据 列表中跳转到某一页
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
       <param name = "intPageIndex">页序号</param>
     */
        IndexPageOne(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.CurrPageIndex2 = intPageIndex;
            this.BindGv_vPaper();
        }
        //////////////////////////////////////////////////////论文部分/////////////////////////////////////////////////
        /*
        * 论文标题
       */
        get paperTitle() {
            return $("#txtPaperTitle").val();
        }
        ///////////////////////论文列表条件
        get PaperUser() {
            return $("#ddlUserId").val();
        }
        /*
        * 文献类型Id
       */
        get literatureTypeId() {
            return $("#ddlLiteratureTypeId").val();
        }
        /*
       * 设置排序字段-相当使用ViewState功能
      */
        set hidSortvPaperBy(value) {
            $("#hidSortvPaperBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvPaperBy() {
            return $("#hidSortvPaperBy").val();
        }
        /*
     * 分享
     */
        set shareId(value) {
            $("#ddlShareId").val(value);
        }
        /*
        * 分享
        */
        get shareId() {
            return $("#ddlShareId").val();
        }
        /*
     * 论文标题
    */
        get questionsContent() {
            return $("#txtQuestionsContent_q").val();
        }
    }
    exports.qa_PaperCRUDEx = qa_PaperCRUDEx;
    qa_PaperCRUDEx.mstrListDiv = "divDataLst";
});
