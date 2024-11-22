(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduTools/SysScoreSummary_QUDI_TS.js", "../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js", "../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreSummary_QUDI_TSEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:SysScoreSummary_QUDI_TSEx
    表名:SysScoreSummary(01120628)
    生成代码版本:2020.04.17.1
    生成日期:2020/04/22 17:34:27
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEdu
    框架-层名:WA_界面脚本后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const SysScoreSummary_QUDI_TS_js_1 = require("../GraduateEduTools/SysScoreSummary_QUDI_TS.js");
    const clsvSysScoreSummaryEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js");
    const clsSysScoreTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js");
    const clsvSysScoreSummaryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* SysScoreSummary_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class SysScoreSummary_QUDI_TSEx extends SysScoreSummary_QUDI_TS_js_1.SysScoreSummary_QUDI_TS {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvSysScoreSummaryBy: string = "mId";
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
                    //const arrSchoolYear_Cache = await SchoolYear_GetObjLstAsync("1=1");//查询区域
                    //const arrSysScoreType_Cache = await SysScoreType_GetObjLstAsync("1=1");//查询区域
                    //const arrvSysScoreSummary_Cache = await vSysScoreSummary_GetObjLstAsync("1=1");
                    //var objSchoolYear_Cond: clsSchoolYearEN = new clsSchoolYearEN();//查询区域
                    var objSysScoreType_Cond = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN(); //查询区域
                    const ddlSchoolYear_q = this.BindDdl_SchoolYear("ddlSchoolYear_q"); //查询区域
                    //const ddlScoreTypeId_q = SysScoreType_BindDdl_ScoreTypeId_Cache("ddlScoreTypeId_q", objSysScoreType_Cond);//查询区域
                    const ddlSchoolYear = this.BindDdl_SchoolYear("ddlSchoolYear"); //编辑区域
                    //const ddlScoreTypeId = SysScoreType_BindDdl_ScoreTypeId_Cache("ddlScoreTypeId", objSysScoreType_Cond);//编辑区域
                    this.hidSortvSysScoreSummaryBy = "schoolYear Asc";
                    var strWhereCond = this.CombinevSysScoreSummaryCondition();
                    //const responseText = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysScoreSummary();
                    $("#divLoading").hide();
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
        //查询
        async btnQuery_Click(strListDiv) {
            try {
                const gvResult = await this.BindGv_vSysScoreSummary();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        //总分核算
        async btnTotalRevalidation_Click() {
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            try {
                $("#divLoading").show();
                const responseText2 = await (0, clsSysCommentExWApi_js_1.SysCommentEx_GetTotalRevalidationAsync)(strUserId);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `总分核算成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                else {
                    var strInfo = `总分核算不成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $("#divLoading").hide();
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `总分核算异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        <returns>条件串(strWhereCond)</returns>
      */
        CombinevSysScoreSummaryCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.UserName_q != "") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName} like '% ${this.UserName_q}%'`;
                }
                if (this.SchoolYear_q != null && this.SchoolYear_q != "0") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear} = '${this.SchoolYear_q}'`;
                }
                //学生 判断角色 
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId() == "00620003") {
                    strWhereCond += " and userId ='" + clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() + "'";
                }
                else {
                    //管理员 教师 
                    $("#btnTotalRevalidation").show();
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls()}'`;
                }
                strWhereCond += " order by Score Desc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysScoreSummaryCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vSysScoreSummary() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevSysScoreSummaryCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            //var arrvSysScoreSummaryNumObjLst: Array<clsvSysScoreSummaryEN> = [];
            var arrvSysScoreSummaryObjLst = [];
            var arrvSysScoreSummaryObjLst1 = [];
            var arrvSysScoreSummaryObjLst2 = [];
            try {
                //const responseRecCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //    this.RecCount = jsonData;
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvSysScoreSummaryBy,
                    sortFun: (x, y) => { return 0; }
                };
                //const responseObjLst1 = await vSysScoreSummaryEx_GetUserNumObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrvSysScoreSummaryNumObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
                //});
                //const responseObjLst = await vSysScoreSummary_GetObjLstByPagerAsync(objPagerPara).then((jsonData) => {
                //    arrvSysScoreSummaryObjLst = <Array<clsvSysScoreSummaryEN>>jsonData;
                //});
                const responseObjLst = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvSysScoreSummaryObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            //if (arrvSysScoreSummaryObjLst.length == 0) {
            //    var strMsg: string = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
            //    alert(strMsg);
            //    return;
            //}
            try {
                var strhtml = "";
                var cateid = 0;
                //$('#tbList tr').remove();
                arrvSysScoreSummaryObjLst1 = arrvSysScoreSummaryObjLst.filter(x => x.scoreTypeId == "0009");
                for (var i = 0; i < arrvSysScoreSummaryObjLst1.length; i++) {
                    var strUserId = arrvSysScoreSummaryObjLst1[i].userId;
                    var strUserName = arrvSysScoreSummaryObjLst1[i].userName;
                    var strcollegeName = arrvSysScoreSummaryObjLst1[i].collegeName;
                    var strmajorName = arrvSysScoreSummaryObjLst1[i].majorName;
                    var strSchoolYear = arrvSysScoreSummaryObjLst1[i].schoolYear;
                    var strgradeBaseName = arrvSysScoreSummaryObjLst1[i].gradeBaseName;
                    var streduClsName = arrvSysScoreSummaryObjLst1[i].eduClsName;
                    //var streduClsName: string = "教育大数据";
                    var PaperSubviewsS = "0";
                    var PersonalViewsS = "0";
                    var ExpertViewsS = "0";
                    var ConceptsS = "0";
                    var ObjectiveFactsS = "0";
                    var ObjectiveDataS = "0";
                    var OthersCommentS = "0";
                    var UserS = "0";
                    var ViewpointRatioS = "0";
                    var ViewpointConversionS = "0"; //各观点折算分
                    var SkillS = "0"; //技能
                    var SocialRelationsS = "0"; //社会关系
                    var PaperSubviewsR = "0";
                    var PersonalViewsR = "0";
                    var ExpertViewsR = "0";
                    var ConceptsR = "0";
                    var ObjectiveFactsR = "0";
                    var ObjectiveDataR = "0";
                    var OthersCommentR = "0";
                    var UserR = "0";
                    var ViewpointRatioR = "0"; //各观点占比分
                    var TotalScoreR = "0";
                    var SkillR = "0"; //技能
                    var SocialRelationsR = "0"; //社会关系
                    arrvSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.userId == strUserId);
                    for (var j = 0; j < arrvSysScoreSummaryObjLst2.length; j++) {
                        var strScoreTypeId = arrvSysScoreSummaryObjLst2[j].scoreTypeId;
                        switch (strScoreTypeId) {
                            case "0001":
                                PaperSubviewsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0002":
                                PersonalViewsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0003":
                                ExpertViewsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0004":
                                ConceptsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0005":
                                ObjectiveFactsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0006":
                                ObjectiveDataS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0007":
                                OthersCommentS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0008":
                                UserS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0009":
                                ViewpointRatioS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0010": //各观点占比分
                                ViewpointRatioR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0011":
                                PaperSubviewsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0012":
                                PersonalViewsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0013":
                                ExpertViewsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0014":
                                ConceptsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0015":
                                ObjectiveFactsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0016":
                                ObjectiveDataR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0017":
                                OthersCommentR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0018":
                                UserR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0019": //各观点折算分
                                ViewpointConversionS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0020":
                                TotalScoreR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0021":
                                SkillS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0022":
                                SkillR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0023": //各观点折算分
                                SocialRelationsS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0024":
                                SocialRelationsR = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            default:
                                break;
                        }
                    }
                    strhtml += '<tr>';
                    strhtml += '<td>' + strUserName + '</br>' + strSchoolYear + '</td><td>' + streduClsName + '</br>' + strmajorName + '</td>';
                    strhtml += '<td>统计分：' + PaperSubviewsS + '</br>占比分：' + PaperSubviewsR + '</td><td>统计分：' + PersonalViewsS + '</br>占比分：' + PersonalViewsR + '</td>';
                    strhtml += '<td>统计分：' + ExpertViewsS + '</br>占比分：' + ExpertViewsR + '</td><td>统计分：' + ConceptsS + '</br>占比分：' + ConceptsR + '</td>';
                    strhtml += '<td>统计分：' + ObjectiveFactsS + '</br>占比分：' + ObjectiveFactsR + '</td><td>统计分：' + ObjectiveDataS + '</br>占比分：' + ObjectiveDataR + '</td>';
                    strhtml += '<td>统计分：' + SkillS + '</br>占比分：' + SkillR + '</td><td>统计分：' + SocialRelationsS + '</br>占比分：' + SocialRelationsR + '</td>';
                    strhtml += '<td>统计分：' + OthersCommentS + '</br>占比分：' + OthersCommentR + '</td><td>统计分：' + ViewpointRatioS + '</br>占比分：' + ViewpointRatioR + '</br>折算分：' + ViewpointConversionS + '</td>';
                    strhtml += '<td>评分：' + UserS + '</br>折算分：' + UserR + '</td><td style="font-weight:bold;color:red;">折算总分：' + TotalScoreR + '</td>';
                    //strhtml += '<td>' + ExpertViewsS + '</td><td>' + ConceptsS + '</td>';
                    //strhtml += '<td>' + ObjectiveFactsS + '</td><td>' + ObjectiveDataS + '</td>';
                    //strhtml += '<td>' + OthersCommentS + '</td><td>' + UserS + '</td>';
                    //strhtml += '<td>' + ViewpointRatioS + '</td><td>' + TotalScoreS + '</td>';
                    strhtml += '</tr>';
                }
                //拼接；
                //$("#tbList").append(strhtml);
                $("#divDataLst").html(strhtml);
                //this.BindTab_vSysScoreSummary(strListDiv, arrvSysScoreSummaryObjLst);
                console.log("完成BindGv_vSysScoreSummary!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
    }
    exports.SysScoreSummary_QUDI_TSEx = SysScoreSummary_QUDI_TSEx;
});
