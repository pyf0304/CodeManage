(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTools/SysScoreSummaryCRUD.js", "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js", "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataTypeEN.js", "../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TotalDataStatisticsDetail = void 0;
    const SysScoreSummaryCRUD_js_1 = require("../PagesBase/GraduateEduTools/SysScoreSummaryCRUD.js");
    const clsgs_TotalDataStatisticsEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js");
    const clsgs_TotalDataTypeEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataTypeEN.js");
    const clsvSysScoreSummaryEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsgs_TotalDataStatisticsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js");
    const clsgs_TotalDataTypeWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js");
    const clsvSysScoreSummaryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class TotalDataStatisticsDetail extends SysScoreSummaryCRUD_js_1.SysScoreSummaryCRUD {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.recCount = 0;
        }
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        BindGv(strType, strPara) {
            //this.BindGv_vgs_TeachingDate();
            this.Bind_AllData();
        }
        BindGv_Cache(strType, strPara) {
            switch (strType) {
                case "vgs_TeachingDate":
                    alert('该类没有绑定该函数：[this.BindGv_vgs_TeachingDate_Cache]！');
                    //this.BindGv_vgs_TeachingDate_Cache();
                    break;
            }
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls != "" || strId_CurrEduCls != "") {
                    var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                    if (strId_CurrEduCls != "") {
                        $("#topTitle").hide();
                    }
                    //  const ddl_TotalDataTypeId_q = await clsDropDownList.BindDdl_TotalTypeId("ddlTotalDataTypeId_q");
                    this.hidSortTotalBy = "updDate Desc";
                    clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                    if (this.bolIsInitShow == false) //
                     {
                        this.objPager.InitShow(this.divName4Pager);
                        this.bolIsInitShow = true; //
                    }
                    //总数据显示
                    const gvResult2 = await this.BindGv_vSysScoreSummary();
                    //默认显示数据
                    const gvResult1 = await this.Bind_AllData();
                    //默认显示数据
                    const gvResult3 = await this.ExportDetail();
                    $("#divLoading").hide();
                }
                else {
                    window.top.location.href = "../Web/Login";
                }
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
        async CombinevSysScoreSummaryCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.userName_q != "") {
                //    strWhereCond += ` And ${clsvSysScoreSummaryEN.con_UserName} like '% ${this.userName_q}%'`;
                //}
                //if (this.schoolYear_q != null && this.schoolYear_q != "0") {
                //    strWhereCond += ` And ${clsvSysScoreSummaryEN.con_SchoolYear} = '${this.schoolYear_q}'`;
                //}
                //学生 判断角色 
                if (clsPublocalStorage_js_1.clsPublocalStorage.roleId == "00620003") {
                    var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    if (strUserId == "") {
                        strWhereCond += " and userId ='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                    }
                    else {
                        strWhereCond += " and userId ='" + strUserId + "'";
                    }
                    var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                    if (strId_CurrEduCls == "") {
                        strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls}'`;
                    }
                    else {
                        strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    }
                }
                else {
                    //管理员 教师 
                    //$("#btnTotalRevalidation").show();
                    //strWhereCond += ` And ${clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                    var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                    if (strId_CurrEduCls == "") {
                        strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls}'`;
                    }
                    else {
                        strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    }
                    var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    if (strUserId == "") {
                        strWhereCond += " and userId ='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                    }
                    else {
                        strWhereCond += " and userId ='" + strUserId + "'";
                    }
                }
                strWhereCond += " order by Score Desc";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineSysScoreSummaryCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        Combinegs_TotalConditionObj() {
            var objgs_TotalDataStatistics_Cond = new clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN();
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var strUserId = clsPublocalStorage.userId;
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                    // strWhereCond += ` And ${clsgs_TotalDataStatisticsEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                    $("#hidId_CurrEduClspara").val(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                }
                else {
                    //strWhereCond += ` And ${clsgs_TotalDataStatisticsEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    $("#hidId_CurrEduClspara").val(strId_CurrEduCls);
                }
                objgs_TotalDataStatistics_Cond.SetCondFldValue(clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objgs_TotalDataStatistics_Cond;
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
      */
        async BindGv_vSysScoreSummary() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = await this.CombinevSysScoreSummaryCondition();
            var objgs_TotalDataStatistics_Cond = this.Combinegs_TotalConditionObj();
            var hidId_CurrEduCls = $("#hidId_CurrEduClspara").val();
            if (hidId_CurrEduCls == "") {
                hidId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            var strWhere_Cond = JSON.stringify(objgs_TotalDataStatistics_Cond);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            //var arrvSysScoreSummaryNumObjLst: Array<clsvSysScoreSummaryEN> = [];
            var arrvSysScoreSummaryObjLst = [];
            var arrvSysScoreSummaryObjLst1 = [];
            var arrvSysScoreSummaryObjLst2 = [];
            //教学班学生
            var arrvCurrEduClsObjLst = [];
            //观点数量统计
            var arrgs_TotalDataStatisticsObjLst0 = [];
            var arrgs_TotalDataStatisticsObjLst = [];
            //观点类型
            var arrObjLst_Sel = [];
            try {
                //this.recCount = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                //});
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: SysScoreSummaryCRUD_js_1.SysScoreSummaryCRUD.sortvSysScoreSummaryBy,
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
                //var strWhereCond1 = " 1=1 ";
                //var hidId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                //if (hidId_CurrEduCls == "") {
                //    strWhereCond1 += " And id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
                //}
                //else {
                //    strWhereCond1 += " And id_CurrEduCls='" + hidId_CurrEduCls + "'";
                //}
                // 获取教学班学生数据；
                const responseObjLst3 = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLst_Cache)(hidId_CurrEduCls).then((jsonData) => {
                    arrvCurrEduClsObjLst = jsonData;
                });
                //获取各类型观点数量数据；
                const responseObjLst4 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx)(objgs_TotalDataStatistics_Cond, hidId_CurrEduCls).then((jsonData) => {
                    arrgs_TotalDataStatisticsObjLst0 = jsonData;
                });
                console.log("完成对象列表获取!");
                //类型数据；
                //var strWhereCond3 = " totalDataTypeId !='02'";
                //arrObjLst_Sel = await gs_TotalDataType_GetObjLstAsync(strWhereCond3);
                arrObjLst_Sel = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLst_Cache)();
                arrObjLst_Sel = arrObjLst_Sel.filter(x => x.totalDataTypeId != "02");
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
                var CountTotal = 0; //存放教学班学生人数；
                arrvSysScoreSummaryObjLst1 = arrvSysScoreSummaryObjLst.filter(x => x.scoreTypeId == "0009");
                for (var i = 0; i < arrvSysScoreSummaryObjLst1.length; i++) {
                    var strUserId = arrvSysScoreSummaryObjLst1[i].userId;
                    var strUserName = arrvSysScoreSummaryObjLst1[i].userName;
                    var strcollegeName = arrvSysScoreSummaryObjLst1[i].collegeName;
                    var strmajorName = arrvSysScoreSummaryObjLst1[i].majorName;
                    var strSchoolYear = arrvSysScoreSummaryObjLst1[i].schoolYear;
                    var strgradeBaseName = arrvSysScoreSummaryObjLst1[i].gradeBaseName;
                    var streduClsName = arrvSysScoreSummaryObjLst1[i].eduClsName;
                    var strId_CurrEduCls = arrvSysScoreSummaryObjLst1[i].id_CurrEduCls;
                    var arrvCurrEduObjList = arrvCurrEduClsObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls);
                    CountTotal = arrvCurrEduObjList.length; //获取教学班人数
                    //var PaperSubviewsS: string = "0";
                    //var PersonalViewsS: string = "0";
                    //var ExpertViewsS: string = "0";
                    //var ConceptsS: string = "0";
                    //var ObjectiveFactsS: string = "0";
                    //var ObjectiveDataS: string = "0";
                    //var OthersCommentS: string = "0";
                    //var UserS: string = "0";
                    //var ViewpointRatioS = 0;
                    //var ViewpointConversionS: string = "0";//各观点折算分
                    //var SkillS: string = "0"; //技能
                    //var SocialRelationsS: string = "0";  //社会关系
                    //var qa_AnswerS: string = "0";//问题回答
                    var PaperSubviewsS = 0;
                    var NumberPaperSubviewsS = 0; //教师子观点名次
                    var PersonalViewsS = 0;
                    var NumberPersonalViewsS = 0; //个人观点名次
                    var ExpertViewsS = 0;
                    var NumberExpertViewsS = 0; //专家观点名次
                    var ConceptsS = 0;
                    var NumberConceptsS = 0; //概念名次
                    var ObjectiveFactsS = 0;
                    var NumberObjectiveFactsS = 0; //客观事实名次
                    var ObjectiveDataS = 0;
                    var NumberObjectiveDataS = 0; //客观数据名次
                    var OthersCommentS = 0;
                    var UserS = "0";
                    var ViewpointRatioS = 0;
                    var ViewpointConversionS = 0; //各观点折算分
                    var SkillS = 0; //技能
                    var NumberSkillS = 0; //技能名次
                    var SocialRelationsS = 0; //社会关系
                    var NumberSocialRelationsS = 0; //社会关系名次
                    var qa_AnswerS = 0; //问题回答
                    var Numberqa_AnswerS = 0; //问题回答名次
                    //讨论教师总打分 、 评价教师总打分；
                    var AnswerTotal = 0;
                    var SysCommentTotal = 0;
                    //标志教师总打分
                    var TagTotal = 0;
                    //var PaperSubviewsR: string = "0"; //学生分数 以下参数雷同；都是存放学生分数；
                    //var PersonalViewsR: string = "0";
                    //var ExpertViewsR: string = "0";
                    //var ConceptsR: string = "0";
                    //var ObjectiveFactsR: string = "0";
                    //var ObjectiveDataR: string = "0";
                    //var OthersCommentR: string = "0";
                    //var UserR: string = "0";
                    ////var ViewpointRatioR: string = "0";//各观点占学生分数
                    ////var TotalScoreR: string = "0"; //学生分数
                    //var SkillR: string = "0"; //技能
                    //var SocialRelationsR: string = "0";  //社会关系
                    //var qa_AnswerR: string = "0";//学生分数  问题回答
                    var PaperSubviewsR = 0; //生分数 以下参数雷同；都是存放生分数；
                    var NumberPaperSubviewsR = 0; //学生子观点名次
                    var PersonalViewsR = 0;
                    var NumberPersonalViewsR = 0; //个人观点名次
                    var ExpertViewsR = 0;
                    var NumberExpertViewsR = 0; //专家观点名次
                    var ConceptsR = 0;
                    var NumberConceptsR = 0; //概念名次
                    var ObjectiveFactsR = 0;
                    var NumberObjectiveFactsR = 0; //客观事实名次
                    var ObjectiveDataR = 0;
                    var NumberObjectiveDataR = 0; //客观数据名次
                    var OthersCommentR = 0;
                    var UserR = "0";
                    //var ViewpointRatioR: string = "0";//各观点占生分数
                    //var TotalScoreR: string = "0"; //生分数
                    var SkillR = 0; //技能
                    var NumberSkillR = 0; //技能名次
                    var SocialRelationsR = 0; //社会关系
                    var NumberSocialRelationsR = 0; //社会关系名次
                    var qa_AnswerR = 0; //生分数  问题回答
                    var Numberqa_AnswerR = 0; //问题回答名次
                    var stuScoreTotal = 0; //学生分 总分
                    //各类型观点数量数据参数；
                    var PaperCount = 0; //01
                    var PaperViewpointCount = 0; //03
                    var ViewpointCount = 0; //04
                    var ExpertViewpointCount = 0; //05
                    var ConceptCount = 0; //06
                    var TopicObjectiveCount = 0; //07
                    var ObjectiveBasisCount = 0; //08
                    var SkillCount = 0; //09
                    var SysSocialCount = 0; //10
                    var QaAnswerCount = 0; //11
                    //得到各观点数据类型数据、
                    for (var k = 0; k < arrObjLst_Sel.length; k++) {
                        var TypeName = arrObjLst_Sel[k].totalDataTypeName;
                        var strTypeId = arrObjLst_Sel[k].totalDataTypeId;
                        //查询过滤等于ID数据；
                        arrgs_TotalDataStatisticsObjLst = arrgs_TotalDataStatisticsObjLst0.filter(x => x.totalDataTypeId == strTypeId && x.dataUser == strUserId);
                        if (arrgs_TotalDataStatisticsObjLst.length > 0) {
                            //存放数据各类型的数据统计；
                            switch (strTypeId) {
                                case "01":
                                    PaperCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "03":
                                    PaperViewpointCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "04":
                                    ViewpointCount = arrgs_TotalDataStatisticsObjLst.length;
                                case "05":
                                    ExpertViewpointCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "06":
                                    ConceptCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "07":
                                    TopicObjectiveCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "08":
                                    ObjectiveBasisCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "09":
                                    SkillCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "10":
                                    SysSocialCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                case "11":
                                    QaAnswerCount = arrgs_TotalDataStatisticsObjLst.length;
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    arrvSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.userId == strUserId);
                    for (var j = 0; j < arrvSysScoreSummaryObjLst2.length; j++) {
                        var strScoreTypeId = arrvSysScoreSummaryObjLst2[j].scoreTypeId;
                        switch (strScoreTypeId) {
                            case "0001":
                                PaperSubviewsS = arrvSysScoreSummaryObjLst2[j].score;
                                //子观点   学生 名次
                                break;
                            case "0002":
                                PersonalViewsS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0003":
                                ExpertViewsS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0004":
                                ConceptsS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0005":
                                ObjectiveFactsS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0006":
                                ObjectiveDataS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0007":
                                OthersCommentS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0008":
                                UserS = arrvSysScoreSummaryObjLst2[j].score.toString();
                                break;
                            case "0009":
                                ViewpointRatioS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0021": //技能；
                                SkillS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0023": //社会关系
                                SocialRelationsS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0025": //问题回答
                                qa_AnswerS = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0041": //讨论教师打分
                                AnswerTotal = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0042": //评价教师打分
                                SysCommentTotal = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0045": //标志教师打分
                                TagTotal = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0031": //从这里开始 得到是学生评价分汇总
                                PaperSubviewsR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0032":
                                PersonalViewsR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0033":
                                ExpertViewsR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0034":
                                ConceptsR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0035":
                                ObjectiveFactsR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0036":
                                ObjectiveDataR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0037":
                                SkillR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0038":
                                SocialRelationsR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0039": //问题回答 生分
                                qa_AnswerR = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            case "0040": //生分 总分
                                stuScoreTotal = arrvSysScoreSummaryObjLst2[j].score;
                                break;
                            default:
                                break;
                        }
                    }
                    //得到标志名次，通过标志教师打分分数；
                    //标记名次
                    var TagIndexNumber = 0;
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0045" && x.score > TagTotal);
                    if (TagTotal == 0) {
                        TagIndexNumber = CountTotal;
                    }
                    else {
                        TagIndexNumber = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    //得到讨论名次，通过分数；
                    var qaIndexNumber = 0;
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0041" && x.score > AnswerTotal);
                    if (AnswerTotal == 0) {
                        qaIndexNumber = CountTotal;
                    }
                    else {
                        qaIndexNumber = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    //得到评价名次，通过分数；
                    var CommentIndexNumber = 0;
                    var arrSysScoreSummaryObjLst4 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0042" && x.score > SysCommentTotal);
                    if (SysCommentTotal == 0) {
                        CommentIndexNumber = CountTotal;
                    }
                    else {
                        CommentIndexNumber = arrSysScoreSummaryObjLst4.length + 1; //加1代表当前排名；
                    }
                    //教师分、排名
                    var TeaIndexNumber = 0;
                    var arrSysScoreSummaryObjLst1 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0009" && x.score > ViewpointRatioS);
                    if (ViewpointRatioS == 0) {
                        TeaIndexNumber = CountTotal;
                    }
                    else {
                        TeaIndexNumber = arrSysScoreSummaryObjLst1.length + 1; //加1代表当前排名；
                    }
                    //学生分 、排名
                    var StuIndexNumber = 0;
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0040" && x.score > stuScoreTotal);
                    if (stuScoreTotal == 0) {
                        StuIndexNumber = CountTotal;
                    }
                    else {
                        StuIndexNumber = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    //教师排名
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0001" && x.score > PaperSubviewsS);
                    if (PaperSubviewsS == 0) {
                        NumberPaperSubviewsS = CountTotal;
                    }
                    else {
                        NumberPaperSubviewsS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0002" && x.score > PersonalViewsS);
                    if (PersonalViewsS == 0) {
                        NumberPersonalViewsS = CountTotal;
                    }
                    else {
                        NumberPersonalViewsS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0003" && x.score > ExpertViewsS);
                    if (ExpertViewsS == 0) {
                        NumberExpertViewsS = CountTotal;
                    }
                    else {
                        NumberExpertViewsS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0004" && x.score > ConceptsS);
                    if (ConceptsS == 0) {
                        NumberConceptsS = CountTotal;
                    }
                    else {
                        NumberConceptsS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0005" && x.score > ObjectiveFactsS);
                    if (ObjectiveFactsS == 0) {
                        NumberObjectiveFactsS = CountTotal;
                    }
                    else {
                        NumberObjectiveFactsS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0006" && x.score > ObjectiveDataS);
                    if (ObjectiveDataS == 0) {
                        NumberObjectiveDataS = CountTotal;
                    }
                    else {
                        NumberObjectiveDataS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0021" && x.score > SkillS);
                    if (SkillS == 0) {
                        NumberSkillS = CountTotal;
                    }
                    else {
                        NumberSkillS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0023" && x.score > SocialRelationsS);
                    if (SocialRelationsS == 0) {
                        NumberSocialRelationsS = CountTotal;
                    }
                    else {
                        NumberSocialRelationsS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0025" && x.score > qa_AnswerS);
                    if (qa_AnswerS == 0) {
                        Numberqa_AnswerS = CountTotal;
                    }
                    else {
                        Numberqa_AnswerS = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    //学生排名；
                    //名次 学生
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0031" && x.score > PaperSubviewsR);
                    if (PaperSubviewsR == 0) {
                        NumberPaperSubviewsR = CountTotal;
                    }
                    else {
                        NumberPaperSubviewsR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0032" && x.score > PersonalViewsR);
                    if (PersonalViewsR == 0) {
                        NumberPersonalViewsR = CountTotal;
                    }
                    else {
                        NumberPersonalViewsR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0033" && x.score > ExpertViewsR);
                    if (ExpertViewsR == 0) {
                        NumberExpertViewsR = CountTotal;
                    }
                    else {
                        NumberExpertViewsR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0034" && x.score > ConceptsR);
                    if (ConceptsR == 0) {
                        NumberConceptsR = CountTotal;
                    }
                    else {
                        NumberConceptsR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0035" && x.score > ObjectiveFactsR);
                    if (ObjectiveFactsR == 0) {
                        NumberObjectiveFactsR = CountTotal;
                    }
                    else {
                        NumberObjectiveFactsR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0036" && x.score > ObjectiveDataR);
                    if (ObjectiveDataR == 0) {
                        NumberObjectiveDataR = CountTotal;
                    }
                    else {
                        NumberObjectiveDataR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0037" && x.score > SkillR);
                    if (SkillR == 0) {
                        NumberSkillR = CountTotal;
                    }
                    else {
                        NumberSkillR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0038" && x.score > SocialRelationsR);
                    if (SocialRelationsR == 0) {
                        NumberSocialRelationsR = CountTotal;
                    }
                    else {
                        NumberSocialRelationsR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    var arrSysScoreSummaryObjLst2 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0039" && x.score > qa_AnswerR);
                    if (qa_AnswerR == 0) {
                        Numberqa_AnswerR = CountTotal;
                    }
                    else {
                        Numberqa_AnswerR = arrSysScoreSummaryObjLst2.length + 1; //加1代表当前排名；
                    }
                    strhtml += '<tr>';
                    //strhtml += '<td>' + strUserName + '</br>' + strSchoolYear + '</td><td>' + streduClsName + '</br>' + strmajorName + '</td>';
                    //strhtml += '<td>教师分：' + PaperSubviewsS + '</br>学生分：' + PaperSubviewsR + '</td><td>教师分：' + PersonalViewsS + '</br>学生分：' + PersonalViewsR + '</td>';
                    //strhtml += '<td>教师分：' + ExpertViewsS + '</br>学生分：' + ExpertViewsR + '</td><td>教师分：' + ConceptsS + '</br>学生分：' + ConceptsR + '</td>';
                    //strhtml += '<td>教师分：' + ObjectiveFactsS + '</br>学生分：' + ObjectiveFactsR + '</td><td>教师分：' + ObjectiveDataS + '</br>学生分：' + ObjectiveDataR + '</td>';
                    //strhtml += '<td>教师分：' + SkillS + '</br>学生分：' + SkillR + '</td><td>教师分：' + SocialRelationsS + '</br>学生分：' + SocialRelationsR + '</td>';
                    //strhtml += '<td>教师分：' + qa_AnswerS + '</br>学生分：' + qa_AnswerR + '</td>';
                    //strhtml += '<td>教师分：' + OthersCommentS + '</br></td>';
                    //strhtml += '<td>教师分：' + AnswerTotal + '</br>名次：' + qaIndexNumber + '</td>';
                    //strhtml += '<td>教师分：' + SysCommentTotal + '</br>名次：' + CommentIndexNumber + '</td>';
                    //strhtml += '<td>教师：' + TeaIndexNumber + '</br>学生：' + StuIndexNumber + '</td>';
                    //strhtml += '<td>教师分：' + ViewpointRatioS + '</br>学生分：' + stuScoreTotal + '</td>';
                    strhtml += '<td>' + strUserName + '</br>' + strSchoolYear + '</td><td>' + streduClsName + '</br>' + strmajorName + '</td>';
                    //strhtml += '<td>师分：' + PaperSubviewsS + '/' + NumberPaperSubviewsS + '</br>生分：' + PaperSubviewsR + '/' + NumberPaperSubviewsR + '</td>';
                    //strhtml += '<td>师分：' + PersonalViewsS + '/' + NumberPersonalViewsS + '</br>生分：' + PersonalViewsR + '/' + NumberPersonalViewsR + '</td>';
                    //strhtml += '<td>师分：' + ExpertViewsS + '/' + NumberExpertViewsS + '</br>生分：' + ExpertViewsR + '/' + NumberExpertViewsR + '</td>';
                    //strhtml += '<td>师分：' + ConceptsS + '/' + NumberConceptsS + '</br>生分：' + ConceptsR + '/' + NumberConceptsR + '</td>';
                    //strhtml += '<td>师分：' + ObjectiveFactsS + '/' + NumberObjectiveFactsS + '</br>生分：' + ObjectiveFactsR + '/' + NumberObjectiveFactsR + '</td>';
                    //strhtml += '<td>师分：' + ObjectiveDataS + '/' + NumberObjectiveDataS + '</br>生分：' + ObjectiveDataR + '/' + NumberObjectiveDataR + '</td>';
                    //strhtml += '<td>师分：' + SkillS + '/' + NumberSkillS + '</br>生分：' + SkillR + '/' + NumberSkillR + '</td>';
                    //strhtml += '<td>师分：' + SocialRelationsS + '/' + NumberSocialRelationsS + '</br>生分：' + SocialRelationsR + '/' + NumberSocialRelationsR + '</td>';
                    //strhtml += '<td>师分：' + qa_AnswerS + '/' + Numberqa_AnswerS + '</br>生分：' + qa_AnswerR + '/' + Numberqa_AnswerR + '</td>';
                    strhtml += '<td>师分：' + PaperSubviewsS + '/' + NumberPaperSubviewsS + '</br>生分：' + PaperSubviewsR + '/' + NumberPaperSubviewsR + '</br>数量：' + PaperViewpointCount + '</td>';
                    strhtml += '<td>师分：' + PersonalViewsS + '/' + NumberPersonalViewsS + '</br>生分：' + PersonalViewsR + '/' + NumberPersonalViewsR + '</br>数量：' + ViewpointCount + '</td>';
                    strhtml += '<td>师分：' + ExpertViewsS + '/' + NumberExpertViewsS + '</br>生分：' + ExpertViewsR + '/' + NumberExpertViewsR + '</br>数量：' + ExpertViewpointCount + '</td>';
                    strhtml += '<td>师分：' + ConceptsS + '/' + NumberConceptsS + '</br>生分：' + ConceptsR + '/' + NumberConceptsR + '</br>数量：' + ConceptCount + '</td>';
                    strhtml += '<td>师分：' + ObjectiveFactsS + '/' + NumberObjectiveFactsS + '</br>生分：' + ObjectiveFactsR + '/' + NumberObjectiveFactsR + '</br>数量：' + TopicObjectiveCount + '</td>';
                    strhtml += '<td>师分：' + ObjectiveDataS + '/' + NumberObjectiveDataS + '</br>生分：' + ObjectiveDataR + '/' + NumberObjectiveDataR + '</br>数量：' + ObjectiveBasisCount + '</td>';
                    strhtml += '<td>师分：' + SkillS + '/' + NumberSkillS + '</br>生分：' + SkillR + '/' + NumberSkillR + '</br>数量：' + SkillCount + '</td>';
                    strhtml += '<td>师分：' + SocialRelationsS + '/' + NumberSocialRelationsS + '</br>生分：' + SocialRelationsR + '/' + NumberSocialRelationsR + '</br>数量：' + SysSocialCount + '</td>';
                    strhtml += '<td>师分：' + qa_AnswerS + '/' + Numberqa_AnswerS + '</br>生分：' + qa_AnswerR + '/' + Numberqa_AnswerR + '</br>数量：' + QaAnswerCount + '</td>';
                    //strhtml += '<td>师分：' + OthersCommentS + '</br>生分：' + OthersCommentR + '</td><td>师分：' + ViewpointRatioS + '</br>生分：' + ViewpointRatioR + '</br>折算分：' + ViewpointConversionS + '</td>';
                    strhtml += '<td>师分：' + OthersCommentS + '</br></td>';
                    strhtml += '<td>师分：' + AnswerTotal + '</br>名次：' + qaIndexNumber + '</td>';
                    strhtml += '<td>师分：' + SysCommentTotal + '</br>名次：' + CommentIndexNumber + '</td>';
                    strhtml += '<td>师分：' + TagTotal + '</br>名次：' + TagIndexNumber + '</td>'; //标志打分排名
                    strhtml += '<td>师分：' + ViewpointRatioS + '</br>生分：' + stuScoreTotal + '</td>';
                    strhtml += '<td>教师：' + TeaIndexNumber + '</br>学生：' + StuIndexNumber + '</td>';
                    strhtml += '</tr>';
                }
                //拼接；
                //$("#tbList").append(strhtml);
                $("#divScoreTotalDataLst").html(strhtml);
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
        /* 把所有的查询控件内容组合成一个条件串
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
       <returns>条件串(strWhereCond)</returns>
     */
        Combinegs_TotalDetailCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var strUserId = clsPublocalStorage.userId;
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls}'`;
                }
                else {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                if (strUserId == "") {
                    strWhereCond += " and dataUser ='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                }
                else {
                    //获取当前用户自己数据
                    strWhereCond += " And dataUser='" + strUserId + "'";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
    <returns>条件串(strWhereCond)</returns>
    */
        Combinegs_TotalConditionDetailObj() {
            var objgs_TotalDataStatistics_Cond = new clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN();
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var strUserId = clsPublocalStorage.userId;
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                    // strWhereCond += ` And ${clsgs_TotalDataStatisticsEN.con_id_CurrEduCls} = '${clsPublocalStorage.id_CurrEduCls}'`;
                    $("#hidId_CurrEduClspara").val(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
                }
                else {
                    //strWhereCond += ` And ${clsgs_TotalDataStatisticsEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    $("#hidId_CurrEduClspara").val(strId_CurrEduCls);
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                if (strUserId == "") {
                    //  strWhereCond += " and dataUser ='" + clsPublocalStorage.userId + "'";
                    var strSessionUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                    objgs_TotalDataStatistics_Cond.SetCondFldValue(clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN.con_DataUser, strSessionUserId, "=");
                }
                else {
                    //获取当前用户自己数据
                    //   strWhereCond += " And dataUser='" + strUserId + "'";
                    objgs_TotalDataStatistics_Cond.SetCondFldValue(clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN.con_DataUser, strUserId, "=");
                }
                objgs_TotalDataStatistics_Cond.SetCondFldValue(clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objgs_TotalDataStatistics_Cond;
        }
        //导出的详细数据；
        async ExportDetail() {
            var strListDiv = this.mstrListDiv;
            var strid_CurrEducls = $("#hidId_CurrEduClspara").val();
            if (strid_CurrEducls == "") {
                strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            // var strid_CurrEducls = clsPublocalStorage.id_CurrEduCls;
            //var objgs_TotalDataStatistics_Cond = this.Combinegs_TotalDetailCondition();
            var objgs_TotalDataStatistics_Cond = this.Combinegs_TotalConditionDetailObj();
            var strWhereCond = JSON.stringify(objgs_TotalDataStatistics_Cond);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrgs_TotalDataStatisticsObjLst0 = [];
            var arrgs_TotalDataStatisticsObjLst = [];
            var arrObjLst_Sel = [];
            var objPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: strWhereCond,
                orderBy: this.hidSortTotalBy,
                sortFun: (x, y) => { return 0; }
            };
            try {
                //this.recCount = await gs_TotalDataStatisticsEx_GetObjLstEx(objgs_TotalDataStatistics_Cond);
                // console.log("完成计数!");
                const responseObjLst = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx)(objgs_TotalDataStatistics_Cond, strid_CurrEducls).then((jsonData) => {
                    // const responseObjLst = await gs_TotalDataStatisticsEx_GetObjLstEx(objgs_TotalDataStatistics_Cond).then((jsonData) => {
                    arrgs_TotalDataStatisticsObjLst0 = jsonData;
                });
                console.log("完成对象列表获取!");
                //var strWhereCond = " totalDataTypeId !='02'";
                //arrObjLst_Sel = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
                arrObjLst_Sel = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLst_Cache)();
                arrObjLst_Sel = arrObjLst_Sel.filter(x => x.totalDataTypeId != "02");
                var arrvUserStuNameObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoDetailTotal">';
                for (var k = 0; k < arrObjLst_Sel.length; k++) {
                    var TypeName = arrObjLst_Sel[k].totalDataTypeName;
                    var strTypeId = arrObjLst_Sel[k].totalDataTypeId;
                    //查询过滤等于ID数据；
                    arrgs_TotalDataStatisticsObjLst = arrgs_TotalDataStatisticsObjLst0.filter(x => x.totalDataTypeId == strTypeId);
                    if (arrgs_TotalDataStatisticsObjLst.length > 0) {
                        //存放数据各类型的数据统计；
                        switch (strTypeId) {
                            case "01":
                                $('#PaperCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "03":
                                $('#PaperViewpointCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "04":
                                $('#ViewpointCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "05":
                                $('#ExpertViewpointCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "06":
                                $('#ConceptCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "07":
                                $('#TopicObjectiveCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "08":
                                $('#ObjectiveBasisCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "09":
                                $('#SkillCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "10":
                                $('#SysSocialCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            case "11":
                                $('#QaAnswerCount').html(arrgs_TotalDataStatisticsObjLst.length);
                                break;
                            default:
                                break;
                        }
                        strhtml += '<div><span class="color3">' + TypeName + '</span>';
                        strhtml += ' </br><span class="color4">数量：&nbsp;&nbsp;</span><span class="abstract-text">' + arrgs_TotalDataStatisticsObjLst.length + '</span> </div></br > ';
                        //strhtml += '<div class="title btn-3"><div style="float:left;"><a href="#" title="各类型表数据详情">' + TypeName + '</a></div></div></br>';
                        //strhtml += '<div class="title btn-3"><div style="float:left;"></div></div></br>';
                        //strhtml += '<ul class="artlist">';
                        //var v = 0;//给内容加个序号
                        //for (var i = 0; i < arrgs_TotalDataStatisticsObjLst.length; i++) {
                        //    v++;
                        //    //对内容进行换行替换
                        //    var strTotalContent = arrgs_TotalDataStatisticsObjLst[i].memo;
                        //    var strWeek = arrgs_TotalDataStatisticsObjLst[i].week;
                        //    var strWeekRange = arrgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                        //    strTotalContent = strTotalContent.replace(/\r\n/g, strBr);
                        //    strTotalContent = strTotalContent.replace(/\n/g, strBr);
                        //    strhtml += '<li><span class="rowtit color4">名称&nbsp;&nbsp;</span><span class="abstract-text">' + strTotalContent + '</span></li>';
                        //    strhtml += '<li><span class="rowtit color5">统计&nbsp;&nbsp;教师分数：' + arrgs_TotalDataStatisticsObjLst[i].teaScore + '';
                        //    strhtml += '&nbsp;&nbsp;学生分数：' + arrgs_TotalDataStatisticsObjLst[i].stuScore + '</span></li>'
                        //    strhtml += '<li><span class="rowtit color2">时间&nbsp;&nbsp;当前周：' + strWeek + '';
                        //    strhtml += '&nbsp;&nbsp;周时间范围：' + strWeekRange + '</span></li></br>'
                        //    //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                        //}
                        //    strhtml += '</ul>';
                        strhtml += '';
                        var v = 0; //给内容加个序号
                        for (var i = 0; i < arrgs_TotalDataStatisticsObjLst.length; i++) {
                            v++;
                            //对内容进行换行替换
                            var strTotalContent = arrgs_TotalDataStatisticsObjLst[i].memo;
                            var strWeek = arrgs_TotalDataStatisticsObjLst[i].week;
                            var strWeekRange = arrgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                            strTotalContent = strTotalContent.replace(/\r\n/g, strBr);
                            strTotalContent = strTotalContent.replace(/\n/g, strBr);
                            strhtml += '<span class="color4">名称&nbsp;&nbsp;</span><span class="abstract-text">' + strTotalContent + '</span></br>';
                            strhtml += '<span class="color5">统计&nbsp;&nbsp;教师分数：' + arrgs_TotalDataStatisticsObjLst[i].teaScore + '';
                            strhtml += '&nbsp;&nbsp;学生分数：' + arrgs_TotalDataStatisticsObjLst[i].stuScore + '</span></br>';
                            strhtml += '<span class="color6">时间&nbsp;&nbsp;当前周：' + strWeek + '';
                            strhtml += '&nbsp;&nbsp;周时间范围：' + strWeekRange + '</span></br></br>';
                            //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                        }
                        strhtml += '';
                    }
                }
                strhtml += '</div>';
                ////根据tab点击 加载不同的数据；
                //var strTabKeyId = $('#hidTabNum').val();
                //if (strTabKeyId == "01") {
                //    //拼接；
                //    $("#divli_PaperDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "03") {
                //    //拼接；
                //    $("#divli_PaperViewpointDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "04") {
                //    //拼接；
                //    $("#divli_ViewpointLst").html(strhtml);
                //}
                //else if (strTabKeyId == "05") {
                //    //拼接；
                //    $("#divli_ExpertViewpointDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "06") {
                //    //拼接；
                //    $("#divli_ConceptDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "07") {
                //    //拼接；
                //    $("#divli_TopicObjectiveDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "08") {
                //    //拼接；
                //    $("#divli_ObjectiveBasisDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "09") {
                //    //拼接；
                //    $("#divli_SkillDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "10") {
                //    //拼接；
                //    $("#divli_SysSocialRelationsDataLst").html(strhtml);
                //}
                //else if (strTabKeyId == "11") {
                //    //拼接；
                //    $("#divli_QaAnswerDataLst").html(strhtml);
                //}
                //else {
                //    //拼接；
                //    $("#divli_PaperDataLst").html(strhtml);
                //}
                //拼接；
                $("#ExportDetail").html(strhtml);
                //if (this.recCount >= 10) {
                //    $("#divPager").show();
                //    this.objPager.recCount = this.recCount;
                //    this.objPager.pageSize = this.pageSize;
                //    this.objPager.ShowPagerV2(this, this.divName4Pager);
                //}
                (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_ReFreshCache)(strid_CurrEducls);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinegs_TotalCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var strUserId = clsPublocalStorage.userId;
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                ////各个表数据类型
                //if (this.TotalDataTypeId_q != "" && this.TotalDataTypeId_q != "0") {
                //    strWhereCond += ` And ${clsgs_TotalDataTypeEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                //}
                //获取点击tab切换后值；根据值查询数据；
                var strTotalDataTypeId = $('#hidTabNum').val();
                if (strTotalDataTypeId != "") {
                    strWhereCond += ` And ${clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId} = '${strTotalDataTypeId}'`;
                }
                else {
                    strWhereCond += ` And ${clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId} = '01'`; //如果tab值为空 默认显示论文；
                }
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls}'`;
                }
                else {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                }
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                if (strUserId == "") {
                    strWhereCond += " and dataUser ='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                }
                else {
                    //获取当前用户自己数据
                    strWhereCond += " And dataUser='" + strUserId + "'";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //   /* 把所有的查询控件内容组合成一个条件串
        // (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        //  <returns>条件串(strWhereCond)</returns>
        //*/
        //   public Combineobjgs_TotalDataStatistics_CondObj(): clsgs_TotalDataStatisticsEN {
        //       //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //       //例如 1 = 1 && userName = '张三'
        //       var strWhereCond: string = " 1 = 1 ";
        //       var strUserId = clsPublocalStorage.userId;
        //       var objgs_TotalDataStatistics_Cond: clsgs_TotalDataStatisticsEN = new clsgs_TotalDataStatisticsEN();
        //       //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        //       try {
        //           if (this.TotalDataTypeId_q != "" && this.TotalDataTypeId_q != "0") {
        //               strWhereCond += ` And ${clsgs_TotalDataTypeEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
        //               objgs_TotalDataStatistics_Cond.SetCondFldValue(clsgs_TotalDataTypeEN.con_TotalDataTypeId, this.TotalDataTypeId_q, "=");
        //           }
        //           //读取session角色 来判断绑定不同数据列表
        //           var strRoleId = clsPublocalStorage.roleId;
        //           //根据当前登录人查询所属自己的各表类型数据；
        //           objgs_TotalDataStatistics_Cond.SetCondFldValue(clsgs_TotalDataStatisticsEN.con_DataUser, strUserId, "=");
        //           ////判断角色 
        //           ////管理员
        //           //if (strRoleId == "00620001") {
        //           //    $("#btnCancelSubmit").show();
        //           //}
        //           //else if (strRoleId == "00620002") {
        //           //}
        //           //else {
        //           //}
        //       }
        //       catch (objException) {
        //           var strMsg: string = `(errid:WiTsCs0005)在组合查询条件对象(CombineTotalConditionObj)时出错!请联系管理员!${objException}`;
        //           throw strMsg;
        //       }
        //       return objgs_TotalDataStatistics_Cond;
        //   }
        /* 总数统计 查询
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        //public async liTotalDataNum_Click() {
        //    try {
        //        const gvResult1 = await this.Bind_AllData();
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        async Bind_AllData() {
            var strListDiv = this.mstrListDiv;
            var strid_CurrEducls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var objgs_TotalDataStatistics_Cond = this.Combinegs_TotalCondition();
            //var strWhereCond = JSON.stringify(objgs_TotalDataStatistics_Sim);
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            var arrgs_TotalDataStatisticsObjLst0 = [];
            var arrgs_TotalDataStatisticsObjLst = [];
            var arrObjLst_Sel = [];
            var objPagerPara = {
                pageIndex: intCurrPageIndex,
                pageSize: this.pageSize,
                whereCond: objgs_TotalDataStatistics_Cond,
                orderBy: this.hidSortTotalBy,
                sortFun: (x, y) => { return 0; }
            };
            try {
                this.recCount = await (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_GetRecCountByCondAsync)(objgs_TotalDataStatistics_Cond);
                console.log("完成计数!");
                const responseObjLst = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetObjLstByPagerAsyncEx)(objPagerPara).then((jsonData) => {
                    arrgs_TotalDataStatisticsObjLst = jsonData;
                });
                console.log("完成对象列表获取!");
                //var strWhereCond = " totalDataTypeId !='02'";
                //arrObjLst_Sel = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取论文视图的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            try {
                //换行符
                var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
                //个人观点
                strhtml += '<div class="info" id="infoTotal">';
                //for (var k = 0; k < arrObjLst_Sel.length; k++) {
                //    var TypeName = arrObjLst_Sel[k].totalDataTypeName;
                //    var strTypeId = arrObjLst_Sel[k].totalDataTypeId;
                //查询过滤等于ID数据；
                //arrgs_TotalDataStatisticsObjLst = arrgs_TotalDataStatisticsObjLst0.filter(x => x.totalDataTypeId == strTypeId)
                if (arrgs_TotalDataStatisticsObjLst.length > 0) {
                    //strhtml += '<div class="title btn-3"><div style="float:left;"><a href="#" title="各类型表数据详情">' + TypeName + '</a></div></div></br>';
                    strhtml += '<div class="title btn-3"><div style="float:left;"></div></div></br>';
                    strhtml += '<ul class="artlist">';
                    var v = 0; //给内容加个序号
                    for (var i = 0; i < arrgs_TotalDataStatisticsObjLst.length; i++) {
                        v++;
                        //对内容进行换行替换
                        var strTotalContent = arrgs_TotalDataStatisticsObjLst[i].memo;
                        var strWeek = arrgs_TotalDataStatisticsObjLst[i].week;
                        var strWeekRange = arrgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                        strTotalContent = strTotalContent.replace(/\r\n/g, strBr);
                        strTotalContent = strTotalContent.replace(/\n/g, strBr);
                        strhtml += '<li><span class="rowtit color4">[名称]：&nbsp;&nbsp;</span><span class="abstract-text">' + strTotalContent + '</span></li>';
                        strhtml += '<li><span class="rowtit color5">[统计]：&nbsp;&nbsp;教师分数：' + arrgs_TotalDataStatisticsObjLst[i].teaScore + '';
                        strhtml += '&nbsp;&nbsp;学生分数：' + arrgs_TotalDataStatisticsObjLst[i].stuScore + '</span></li>';
                        strhtml += '<li><span class="rowtit color2">[时间]：&nbsp;&nbsp;当前周：' + strWeek + '';
                        strhtml += '&nbsp;&nbsp;周时间范围：' + strWeekRange + '</span></li>';
                        strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                    }
                    strhtml += '</ul>';
                }
                //}
                strhtml += '</div>';
                //根据tab点击 加载不同的数据；
                var strTabKeyId = $('#hidTabNum').val();
                if (strTabKeyId == "01") {
                    //拼接；
                    $("#divli_PaperDataLst").html(strhtml);
                }
                else if (strTabKeyId == "03") {
                    //拼接；
                    $("#divli_PaperViewpointDataLst").html(strhtml);
                }
                else if (strTabKeyId == "04") {
                    //拼接；
                    $("#divli_ViewpointLst").html(strhtml);
                }
                else if (strTabKeyId == "05") {
                    //拼接；
                    $("#divli_ExpertViewpointDataLst").html(strhtml);
                }
                else if (strTabKeyId == "06") {
                    //拼接；
                    $("#divli_ConceptDataLst").html(strhtml);
                }
                else if (strTabKeyId == "07") {
                    //拼接；
                    $("#divli_TopicObjectiveDataLst").html(strhtml);
                }
                else if (strTabKeyId == "08") {
                    //拼接；
                    $("#divli_ObjectiveBasisDataLst").html(strhtml);
                }
                else if (strTabKeyId == "09") {
                    //拼接；
                    $("#divli_SkillDataLst").html(strhtml);
                }
                else if (strTabKeyId == "10") {
                    //拼接；
                    $("#divli_SysSocialRelationsDataLst").html(strhtml);
                }
                else if (strTabKeyId == "11") {
                    //拼接；
                    $("#divli_QaAnswerDataLst").html(strhtml);
                }
                else {
                    //拼接；
                    $("#divli_PaperDataLst").html(strhtml);
                }
                ////拼接；
                //$("#divDataLst").html(strhtml);
                //if (this.recCount >= 10) {
                $("#divPager").show();
                this.objPager.recCount = this.recCount;
                this.objPager.pageSize = this.pageSize;
                this.objPager.ShowPagerV2(this, this.divName4Pager);
                //}
                (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_ReFreshCache)(strid_CurrEducls);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        <param name = "strSortByFld">排序的字段</param>
      */
        async SortBy(strSortByFld) {
            if (this.hidSortTotalBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortTotalBy.indexOf("Asc") >= 0) {
                    this.hidSortTotalBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortTotalBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortTotalBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = this.Bind_AllData();
        }
        /* 函数功能:在数据 列表中跳转到某一页
    (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
    <param name = "intPageIndex">页序号</param>
    */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            const gvResult = await this.Bind_AllData();
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        //--------------------------------------------------------------------------tab页切换事件
        //论文
        async li_Paper_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计论文列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //论文子观点
        async li_PaperViewpoint_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计论文子观点列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //个人观点
        async li_Viewpoint_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计个人观点列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //专家观点
        async li_ExpertViewpoint_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计专家列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //概念
        async li_Concept_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计概念列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //客观事实
        async li_TopicObjective_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计客观事实列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //客观数据
        async li_ObjectiveBasis_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计客观数据列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //技能
        async li_Skill_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计技能列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //社会关系
        async li_SysSocialRelations_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计社会关系列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //问题回答
        async li_QaAnswer_Click() {
            try {
                const gvResultPaper = await this.Bind_AllData();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取统计问题回答列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //    /*
        //* 数据类型
        //*/
        //    public get TotalDataTypeId_q(): string {
        //        return $("#ddlTotalDataTypeId_q").val();
        //    }
        //    /*
        //    * 数据类型
        //   */
        //    public set TotalDataTypeId_q(value: string) {
        //        $("#ddlTotalDataTypeId_q").val(value);
        //    }
        /*
    * 获取当前页序号
    */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
     * 设置排序字段-相当使用ViewState功能
    */
        set hidSortTotalBy(value) {
            $("#hidSortTotalBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortTotalBy() {
            return $("#hidSortTotalBy").val();
        }
        /*
    * 设置排序字段-相当使用ViewState功能
    */
        set hidSortvSysScoreSummaryBy(value) {
            $("#hidSortvSysScoreSummaryBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvSysScoreSummaryBy() {
            return $("#hidSortvSysScoreSummaryBy").val();
        }
    }
    exports.TotalDataStatisticsDetail = TotalDataStatisticsDetail;
});
