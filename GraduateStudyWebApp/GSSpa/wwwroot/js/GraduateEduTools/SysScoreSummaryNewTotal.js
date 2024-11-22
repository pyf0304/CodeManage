(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../GraduateEduTools/SysScoreSummary_QUDI_TS.js", "../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js", "../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js", "../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js", "../TS/L0_Entity/SysPara/clsSchoolYearEN.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_UserRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js", "../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsSysPara4WebApi2.js", "./gs_UserRela.js", "./TotalDataStatisticsEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreSummaryNewTotal = void 0;
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
    const clsgs_TotalDataStatisticsEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TotalDataStatisticsEN.js");
    const clsvSysScoreSummaryEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js");
    const clsSysScoreTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSysScoreTypeEN.js");
    const clsSchoolYearEN_js_1 = require("../TS/L0_Entity/SysPara/clsSchoolYearEN.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsStuWApi.js");
    const clsvCurrEduClsTeacherWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsvCurrEduClsTeacherWApi.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsgs_TotalDataStatisticsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataStatisticsWApi.js");
    const clsgs_TotalDataTypeWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js");
    const clsgs_UserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_UserRelaWApi.js");
    const clsvSysScoreSummaryWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvSysScoreSummaryWApi.js");
    const clsSchoolYearWApi_js_1 = require("../TS/L3_ForWApi/SysPara/clsSchoolYearWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsvgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsSysPara4WebApi2_js_1 = require("../TS/PubFun/clsSysPara4WebApi2.js");
    const gs_UserRela_js_1 = require("./gs_UserRela.js");
    const TotalDataStatisticsEx_js_1 = require("./TotalDataStatisticsEx.js");
    /* SysScoreSummary_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class SysScoreSummaryNewTotal extends SysScoreSummary_QUDI_TS_js_1.SysScoreSummary_QUDI_TS {
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
                    //  const ddlSchoolYear = this.BindDdl_SchoolYear("ddlSchoolYear");//编辑区域
                    //const ddlScoreTypeId = SysScoreType_BindDdl_ScoreTypeId_Cache("ddlScoreTypeId", objSysScoreType_Cond);//编辑区域
                    this.hidSortvSysScoreSummaryBy = "schoolYear Asc";
                    var strWhereCond = this.CombinevSysScoreSummaryCondition();
                    //const responseText = await vSysScoreSummary_GetRecCountByCondAsync(strWhereCond).then((jsonData) => {
                    //    this.RecCount = jsonData;
                    //});
                    //默认显示智能排序；
                    $("#hidQueryStata").val("1");
                    $("#li_IntelligenceArray").addClass("btn-info");
                    //2、显示无条件的表内容在GridView中
                    const gvResult = await this.BindGv_vSysScoreSummary();
                    //教学班人员关系展示
                    const gvResult1 = await this.GetUserRela();
                    $("#divLoading").hide();
                    //教学班各种图形 以及人员关系图 布局；
                    const gvResult9 = await this.GetCurrEduClsUserRela();
                    //生成教学班人员智能排序关系图
                    const gvResult11 = await this.Bind_UserRelaOne();
                    //生成教学班图表图片数据以及个人数据：；
                    const gvResult3 = await this.BindGv_TotalDataNum();
                    //教学班各种图形
                    const gvResult2 = await this.GetBind_AllData();
                    //各学生详细内容；
                    const gvResult8 = await this.ExportDetail();
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
        /// <summary>
        /// 为下拉框获取数据,从表:[schoolYear]中获取
        /// (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DdlBind_Cache)
        /// </summary>
        /// <returns>获取主键字段、名称字段两列的所有记录记录的dataTable</returns>
        BindDdl_SchoolYear(strDdlName) {
            var strWhereCond = " 1 =1 ";
            var objDdl = document.getElementById(strDdlName);
            if (objDdl == null) {
                var strMsg = `下拉框：${strDdlName} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            return new Promise((resolve, reject) => {
                try {
                    //const responseText = SchoolYear_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    const responseText = (0, clsSchoolYearWApi_js_1.SchoolYear_GetObjLst_Cache)().then((jsonData) => {
                        var arrSchoolYearObjLst = jsonData;
                        clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrSchoolYearObjLst, clsSchoolYearEN_js_1.clsSchoolYearEN.con_SchoolYear, clsSchoolYearEN_js_1.clsSchoolYearEN.con_SchoolYearName, "学年");
                        console.log("完成BindDdl_SchoolYearId!");
                        resolve(jsonData);
                    });
                    //var arrObjLst_Sel: Array<clsSchoolYearEN> = SchoolYear_GetObjLstAsync(strWhereCond);
                    //clsCommonFunc4Web.BindDdl_ObjLst(strDdlName, arrObjLst_Sel, clsSchoolYearEN.con_SchoolYear, clsSchoolYearEN.con_SchoolYearName, "学年");
                    console.log("完成BindDdl_SchoolYear!");
                }
                catch (e) {
                    var strMsg = `使用缓存对象列表绑定下拉框出错,${e}.`;
                    alert(strMsg);
                }
            });
        }
        //关于用户关系数据
        async GetUserRela() {
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                }
                var objgs_UserRela = new gs_UserRela_js_1.gs_UserRela();
                objgs_UserRela.Bind_UserRela(strId_CurrEduCls);
            }
            catch (e) {
                var strMsg = `用户关系获取不成功,${e}.`;
                alert(strMsg);
            }
        }
        //教学班各种图片绑定Bind_AllData
        async GetBind_AllData() {
            var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
            if (strId_CurrEduCls == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            }
            var objTotalDataStatisticsEx = new TotalDataStatisticsEx_js_1.TotalDataStatisticsEx();
            //canvas02//绑定教学班 周观点数统计
            objTotalDataStatisticsEx.BindGv_TeaClassNum(strId_CurrEduCls, "02", "canvas02");
            //教学班周评论数统计图 Canvas5
            //绑定教学班周评论统计
            objTotalDataStatisticsEx.BindChart_TeaClassComment(strId_CurrEduCls, "05", "canvas05");
            //教学班周均分趋势图 Canvas4
            //获取教学班周教师打分平均分
            objTotalDataStatisticsEx.BindGv_AVGTeaScore(strId_CurrEduCls, "04", "canvas04");
            //用户周评论数统计图 canvas06
            //绑定当前教学班用户周期评论数据
            objTotalDataStatisticsEx.BindChart_UserCommentNum(strId_CurrEduCls, "06", "canvas06");
            //用户周讨论回答统计图canvas07
            //绑定当前教学班用户讨论回答统计数据
            objTotalDataStatisticsEx.BindChart_UserDiscussNum(strId_CurrEduCls, "07", "canvas07");
        }
        catch(e) {
            var strMsg = `用户关系获取不成功,${e}.`;
            alert(strMsg);
        }
        //同步总数据统计
        async btnSynUserRelaNum_Click() {
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                }
                var objgs_UserRela = new gs_UserRela_js_1.gs_UserRela();
                objgs_UserRela.btnSynUserRelaNum_Click(strId_CurrEduCls);
            }
            catch (e) {
                var strMsg = `用户关系获取不成功,${e}.`;
                alert(strMsg);
            }
        }
        //保存当前排列关系图
        async btnSaveUserRela_Click(strUserRelax_y) {
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                }
                var objgs_UserRela = new gs_UserRela_js_1.gs_UserRela();
                objgs_UserRela.btnSaveUserRela_Click(strUserRelax_y, strId_CurrEduCls);
            }
            catch (e) {
                var strMsg = `用户关系获取不成功,${e}.`;
                alert(strMsg);
            }
        }
        async GetCurrEduClsUserRela() {
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                }
                var strhtmlPic = "";
                //服务器展示
                var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                //本地展示；
                //  var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort_LocalPic}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
                //教学班人员关系图
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas03.png";
                //strhtmlPic += '<div class="info" id="UserRelaSingle"  style="position:fixed;margin-top:200px;"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>用户成员关系图<span style="color:crimson;line-height:40px;">(提示：该图表示当前教学班中学生用户之间的关系数据,例如观点参与、问题的讨论等等！)</span></div>';
                strhtmlPic += '<div class="info" id="UserRelaSingle"  style="display:none;"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>用户成员关系图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图表示当前教学班中学生用户之间的关系数据,例如观点参与、问题的讨论等等！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPathcanvas03" style="width:97%;"/></div>';
                //教学班用户周观点数统计图
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/" + strId_CurrEduCls + ".png";
                strhtmlPic += '<div class="info"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>教学班用户周观点数统计图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图表示以用户为主体,展示当前教学班所有用户每周观点统计数量,能够具体看到学生每周观点数量！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="width:97%;"/></div>';
                //教学班周观点数统计图
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas02.png";
                strhtmlPic += '<div class="info"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>教学班周观点数统计图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图表示当前教学班每周总体观点数量的一个趋势图,能够清楚看到当前班观点数的分布！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="width:97%;"/></div>';
                //教学班周均分趋势图
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas04.png";
                strhtmlPic += '<div class="info"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>教学班周均分趋势图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图以教学班为主体展示每周平均分趋势图！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="width:97%;"/></div>';
                //教学班周评论数统计图
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas05.png";
                strhtmlPic += '<div class="info"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>教学班周评论数统计图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图以教学班为主体,展示每周评论数量的统计趋势图！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="width:97%;"/></div>';
                //用户周评论数统计图 
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas06.png";
                strhtmlPic += '<div class="info"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>用户周评论数统计图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图以用户为主体,展示当前教学班每周各用户评论数量的统计趋势图！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="width:97%;"/></div>';
                //用户周讨论回答统计图
                var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas07.png";
                strhtmlPic += '<div class="info"><div class="panel-heading title btn-1"><i class="fa fa-bar-chart fa-lg" style = "padding-right: 5px;" > </i>用户周讨论回答统计图<span style="color:crimson;line-height:40px;font-size:14px;">(提示：该图以用户为主体,展示当前教学班每周各用户关于问题回答、讨论数量的统计趋势图！)</span></div>';
                strhtmlPic += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="width:97%;"/></div>';
                $("#CurrEduclsUserRela").append(strhtmlPic);
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定用户关系图
        async Bind_UserRelaOne() {
            var strSeUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            //var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            //var strWhereCond = "id_CurrEduCls=" + strid_CurrEduCls;
            var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
            if (strId_CurrEduCls == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            }
            var strSeUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            // var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            var strWhereCond = "id_CurrEduCls='" + strId_CurrEduCls + "'";
            var arrvCurrEduClsStuObjLst = [];
            var arrvCurrEduClsTeacherObjLst = [];
            var arrgs_UserRelaObjLst = [];
            var arrgs_UserRelaPositionObjLst = [];
            try {
                //教学班学生
                const responseText1 = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLst_Cache)(strId_CurrEduCls).then((jsonData) => {
                    //const responseText1 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsStuObjLst = jsonData;
                    console.log("1");
                });
                //教学班教师
                const responseText2 = await (0, clsvCurrEduClsTeacherWApi_js_1.vCurrEduClsTeacher_GetObjLst_Cache)(strId_CurrEduCls).then((jsonData) => {
                    //const responseText2 = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrvCurrEduClsTeacherObjLst = jsonData;
                    console.log("2");
                });
                //用户关系
                const responseText3 = await (0, clsgs_UserRelaWApi_js_1.gs_UserRela_GetObjLst_Cache)(strId_CurrEduCls).then((jsonData) => {
                    //const responseText3 = await gs_UserRela_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrgs_UserRelaObjLst = jsonData;
                    console.log("3");
                });
                ////计算出圆形坐标
                //var nodeSize = arrvCurrEduClsTeacherObjLst.length + arrvCurrEduClsStuObjLst.length;
                //var center_x = 600;
                //var center_y = 500;
                //var radius = 360;
                //var ii, _i, _layouts: any = [];
                //for (ii = _i = 0; _i < nodeSize; ii = ++_i) {
                //    var x = center_x + radius * Math.sin(2 * Math.PI * ii / nodeSize),
                //        y = center_y + radius * Math.cos(2 * Math.PI * ii / nodeSize);
                //    _layouts.push({ 'x': x, 'y': y });
                //}
                //计算出教师圆形坐标
                var t_nodeSize = arrvCurrEduClsTeacherObjLst.length;
                var t_center_x = 600;
                var t_center_y = 400;
                var t_radius = 60;
                var t_ii, t_i, t_layouts = [];
                // if ($("#hidQueryStata").val() == "1") {
                for (t_ii = t_i = 0; t_i < t_nodeSize; t_ii = ++t_i) {
                    var x = t_center_x + t_radius * Math.sin(2 * Math.PI * t_ii / t_nodeSize), y = t_center_y + t_radius * Math.cos(2 * Math.PI * t_ii / t_nodeSize);
                    t_layouts.push({ 'x': x, 'y': y });
                }
                //   }
                //else if ($("#hidQueryStata").val() == "3") {
                //    var strWhereCond4 = "id_CurrEduCls='" + strid_CurrEduCls + "' and updUser ='" + strSeUserId + "'";
                //    //用户关系
                //    const responseText4 = await gs_UserRelaPosition_GetObjLstAsync(strWhereCond4).then((jsonData) => {
                //        arrgs_UserRelaPositionObjLst = <Array<clsgs_UserRelaPositionEN>>jsonData;
                //        console.log("3");
                //    });
                //    //如果用户关系排列数据为空
                //    if (arrgs_UserRelaPositionObjLst.length == 0) {
                //        Alert_layer(2, "用户关系排列数据为空!");
                //        $("#hidQueryStata").val("2");
                //    }
                //}
                var strUserInfo1 = "";
                var strUserInfo2 = "";
                var strUserRela = "";
                var j = 0;
                strUserInfo1 += "[";
                strUserInfo2 += "[";
                //教学班教师
                for (var i = 0; i < arrvCurrEduClsTeacherObjLst.length; i++) {
                    var strUserId = arrvCurrEduClsTeacherObjLst[i].teacherID;
                    var strUserName = arrvCurrEduClsTeacherObjLst[i].teacherName;
                    var strcolor = this.getRandomColor();
                    strUserInfo1 += '{ "id": "' + strUserId + '", "name": "' + strUserName + '", "attributes": { "modularity_class": ' + j + ' } },';
                    //  if ($("#hidQueryStata").val() == "1") {
                    var f_x = t_layouts[i].x;
                    var f_y = t_layouts[i].y;
                    strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + f_x + ",y:" + f_y + "},";
                    //  }
                    //else if ($("#hidQueryStata").val() == "2") {
                    //    strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42]},";
                    //}
                    //else if ($("#hidQueryStata").val() == "3") {
                    //    var objgs_UserRelaPosition = arrgs_UserRelaPositionObjLst.find(x => x.userId == strUserId)
                    //    if (objgs_UserRelaPosition != null) {
                    //        strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + objgs_UserRelaPosition.x_Position + ",y:" + objgs_UserRelaPosition.y_Position + "},";
                    //    }
                    //}
                    j++;
                }
                //计算出学生圆形坐标
                var s_nodeSize = arrvCurrEduClsStuObjLst.length;
                var s_center_x = 600;
                var s_center_y = 400;
                var s_radius = 330;
                var s_ii, s_i, s_layouts = [];
                //if ($("#hidQueryStata").val() == "1") {
                for (s_ii = s_i = 0; s_i < s_nodeSize; s_ii = ++s_i) {
                    var x = s_center_x + s_radius * Math.sin(2 * Math.PI * s_ii / s_nodeSize), y = s_center_y + s_radius * Math.cos(2 * Math.PI * s_ii / s_nodeSize);
                    s_layouts.push({ 'x': x, 'y': y });
                }
                //}
                //教学班学生
                for (var i = 0; i < arrvCurrEduClsStuObjLst.length; i++) {
                    var strUserId = arrvCurrEduClsStuObjLst[i].stuID;
                    var strUserName = arrvCurrEduClsStuObjLst[i].stuName;
                    var strcolor = this.getRandomColor();
                    strUserInfo1 += '{ "id": "' + strUserId + '", "name": "' + strUserName + '", "attributes": { "modularity_class": ' + j + ' } },';
                    //   if ($("#hidQueryStata").val() == "1") {
                    var f_x = s_layouts[i].x;
                    var f_y = s_layouts[i].y;
                    strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + f_x + ",y:" + f_y + "},";
                    //   }
                    //else if ($("#hidQueryStata").val() == "2") {
                    //    strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42]},";
                    //}
                    //else if ($("#hidQueryStata").val() == "3") {
                    //    var objgs_UserRelaPosition = arrgs_UserRelaPositionObjLst.find(x => x.userId == strUserId)
                    //    if (objgs_UserRelaPosition != null) {
                    //        strUserInfo2 += "{id: " + j + ",name: '" + strUserName + "',itemStyle: { normal: { color: '" + strcolor + "' } },symbolSize: [42, 42],x:" + objgs_UserRelaPosition.x_Position + ",y:" + objgs_UserRelaPosition.y_Position + "},";
                    //    }
                    //}
                    j++;
                }
                strUserInfo1 = strUserInfo1.substr(0, strUserInfo1.length - 1);
                strUserInfo2 = strUserInfo2.substr(0, strUserInfo2.length - 1);
                strUserInfo1 += "]";
                strUserInfo2 += "]";
                var strUserInfo1Json = eval(strUserInfo1);
                var strUserInfo2Json = eval(strUserInfo2);
                //用户关系数据
                //如果用户关系有数据那么就显示关系图
                if (arrgs_UserRelaObjLst.length > 0) {
                    strUserRela += "[";
                    for (var i = 0; i < arrgs_UserRelaObjLst.length; i++) {
                        var strUserId = arrgs_UserRelaObjLst[i].userId;
                        var strUserRelaId = arrgs_UserRelaObjLst[i].userRelaId;
                        strUserRela += '{ "id": "' + i + '", "source": "' + strUserId + '", "target": "' + strUserRelaId + '" },';
                    }
                    strUserRela = strUserRela.substr(0, strUserRela.length - 1);
                    strUserRela += "]";
                    var strUserRelaJson = eval(strUserRela);
                    UserRelaCanvasUpload(strUserInfo1Json, strUserInfo2Json, strUserRelaJson, strSeUserId);
                }
                //else {
                //    //如果没用户关系数据就去同步
                //    const gvResult1 = await this.btnSynUserRelaNum_Click();
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        async GetExportCurrEduclsID(strId_CurrEducls) {
            GetExportCurrEduclsID(strId_CurrEducls);
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
        //学生总分核算
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
                    var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                    if (strId_CurrEduCls == "") {
                        strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls()}'`;
                        $("#hidId_CurrEduClspara").val(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                    }
                    else {
                        strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    }
                    //strWhereCond += ` And ${clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage.Getid_CurrEduCls()}'`;
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
            var Id_CurrEduCls = $("#hidId_CurrEduClspara").val();
            if (Id_CurrEduCls == "") {
                Id_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            }
            var objgs_TotalDataStatistics_Cond = this.Combinegs_TotalConditionObj();
            //var strid_CurrEducls = $("#hidId_CurrEduClspara").val();;
            var strWhere_Cond = JSON.stringify(objgs_TotalDataStatistics_Cond);
            var strWhereCond = this.CombinevSysScoreSummaryCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
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
                const responseObjLst = await (0, clsvSysScoreSummaryWApi_js_1.vSysScoreSummary_GetObjLst_Cache)(Id_CurrEduCls).then((jsonData) => {
                    //const responseObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrvSysScoreSummaryObjLst = jsonData;
                });
                //var strWhereCond1 = " 1=1 ";
                //var hidId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                //if (hidId_CurrEduCls == "") {
                //    strWhereCond1 += " And id_CurrEduCls='" + clsPublocalStorage.Getid_CurrEduCls() + "'";
                //}
                //else {
                //    strWhereCond1 += " And id_CurrEduCls='" + hidId_CurrEduCls + "'";
                //}
                // 获取教学班学生数据；
                const responseObjLst3 = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetObjLst_Cache)(Id_CurrEduCls).then((jsonData) => {
                    arrvCurrEduClsObjLst = jsonData;
                });
                ////获取各类型观点数量数据；
                //const responseObjLst4 = await gs_TotalDataStatisticsEx_GetObjLstEx(strWhereCond1).then((jsonData) => {
                //    arrgs_TotalDataStatisticsObjLst0 = <Array<clsgs_TotalDataStatisticsEN>>jsonData;
                //});
                const responseObjLst4 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx)(objgs_TotalDataStatistics_Cond, Id_CurrEduCls).then((jsonData) => {
                    arrgs_TotalDataStatisticsObjLst0 = jsonData;
                });
                console.log("完成对象列表获取!");
                //类型数据；
                var strWhereCond3 = " totalDataTypeId !='02'";
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
                var strId_CurrEduCls = "";
                var strhtml = "";
                var cateid = 0;
                var CountTotal = 0; //存放教学班学生人数；
                //$('#tbList tr').remove();
                arrvCurrEduClsObjLst;
                arrvSysScoreSummaryObjLst1 = arrvSysScoreSummaryObjLst.filter(x => x.scoreTypeId == "0009");
                var strFullNajorName = "专业：";
                var strSchoolYearName = "学年：";
                for (var i = 0; i < arrvSysScoreSummaryObjLst1.length; i++) {
                    var strUserId = arrvSysScoreSummaryObjLst1[i].userId;
                    var strUserName = arrvSysScoreSummaryObjLst1[i].userName;
                    var strcollegeName = arrvSysScoreSummaryObjLst1[i].collegeName;
                    var strmajorName = arrvSysScoreSummaryObjLst1[i].majorName;
                    var strSchoolYear = arrvSysScoreSummaryObjLst1[i].schoolYear;
                    var strgradeBaseName = arrvSysScoreSummaryObjLst1[i].gradeBaseName;
                    var streduClsName = arrvSysScoreSummaryObjLst1[i].eduClsName;
                    //教学班
                    if ($("#CurreduClsName").val() == "") {
                        var strEduClsFullName = "教学班：" + streduClsName;
                        $("#CurreduClsName").html(strEduClsFullName);
                    }
                    //学年
                    if (strSchoolYear != "") {
                        //检索值没有出现，那么则拼接；
                        if (strSchoolYearName.indexOf(strSchoolYear) == -1) {
                            strSchoolYearName += strSchoolYear + ',';
                        }
                    }
                    //专业不能为空
                    if (strmajorName != "") {
                        //检索值没有出现，那么则拼接；
                        if (strFullNajorName.indexOf(strmajorName) == -1) {
                            strFullNajorName += strmajorName + ',';
                        }
                    }
                    //相等说明循环完毕，那么直接存放数据
                    if (i + 1 == arrvSysScoreSummaryObjLst1.length) {
                        $("#majorName").html(strFullNajorName);
                        $("#ShoolYear").html(strSchoolYearName);
                    }
                    strId_CurrEduCls = arrvSysScoreSummaryObjLst1[i].id_CurrEduCls;
                    //var streduClsName: string = "教育大数据";
                    //判断该成员是否是教学班学生，只有学生才显示数据；
                    var arrvCurrEduStuObjList = arrvCurrEduClsObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.stuID == strUserId);
                    if (arrvCurrEduStuObjList.length > 0) {
                        //判断教学班
                        var arrvCurrEduObjList = arrvCurrEduClsObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls);
                        CountTotal = arrvCurrEduObjList.length; //获取教学班人数
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
                        var stuScoreTotal = 0; //生分 总分
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
                                    //子观点 
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
                                    //名次 学生
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
                        //师分、总排名
                        var TeaIndexNumber = 0;
                        var arrSysScoreSummaryObjLst1 = arrvSysScoreSummaryObjLst.filter(x => x.id_CurrEduCls == strId_CurrEduCls && x.scoreTypeId == "0009" && x.score > ViewpointRatioS);
                        if (ViewpointRatioS == 0) {
                            TeaIndexNumber = CountTotal;
                        }
                        else {
                            TeaIndexNumber = arrSysScoreSummaryObjLst1.length + 1; //加1代表当前排名；
                        }
                        //生分 、总排名
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
                        //strhtml += '<td>' + strUserName + '</br>' + strSchoolYear + '</td>';
                        strhtml += '<td>' + strUserName + '</td>';
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
                        strhtml += '<td>师分：' + AnswerTotal + '</br>名次：' + qaIndexNumber + '</td>'; //讨论打分排名
                        strhtml += '<td>师分：' + SysCommentTotal + '</br>名次：' + CommentIndexNumber + '</td>'; //评论打分排名
                        strhtml += '<td>师分：' + TagTotal + '</br>名次：' + TagIndexNumber + '</td>'; //标志打分排名
                        strhtml += '<td>师分：' + ViewpointRatioS + '</br>生分：' + stuScoreTotal + '</td>';
                        strhtml += '<td>教师：' + TeaIndexNumber + '</br>学生：' + StuIndexNumber + '</td>';
                        //strhtml += '<td>评分：' + UserS + '</br>折算分：' + UserR + '</td><td style="font-weight:bold;color:red;">折算总分：' + TotalScoreR + '</td>';
                        strhtml += '<td><button class="btn btn-info btn-sm text-nowrap" onclick=btnStuDetail("' + strUserId + '","' + strId_CurrEduCls + '")>详情</button></td>';
                        //strhtml += '<td>' + ObjectiveFactsS + '</td><td>' + ObjectiveDataS + '</td>';
                        //strhtml += '<td>' + OthersCommentS + '</td><td>' + UserS + '</td>';
                        //strhtml += '<td>' + ViewpointRatioS + '</td><td>' + TotalScoreS + '</td>';
                        strhtml += '</tr>';
                    }
                }
                //拼接；
                //$("#tbList").append(strhtml);
                $("#divDataLst").html(strhtml);
                //var strhtmlPic = "";
                ////服务器展示
                // var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
                ////本地展示；教学班学生数据图
                ////var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort_LocalPic}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
                //var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/" + strId_CurrEduCls + ".png";
                //strhtmlPic = '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strId_CurrEduCls + '" style="display:none;"/>';
                ////教学班人员关系图
                //var strAddressUserRelafull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strId_CurrEduCls + "/canvas03.png";
                //strhtmlPic += '<br/><br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressUserRelafull + '" alt="" id="txtImgPathcanvas03" style="display:none;"/>';
                //$("#CurrEduClsPic").append(strhtmlPic);
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
        Combinegs_TotalCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var strUserId = clsPubSessionStorage.GetSession_UserId();
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls()}'`;
                    $("#hidId_CurrEduClspara").val(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                }
                else {
                    strWhereCond += ` And ${clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    $("#hidId_CurrEduClspara").val(strId_CurrEduCls);
                }
                //var strUserId = $("#hidUserId").val();
                //if (strUserId == "") {
                //    strWhereCond += " and dataUser ='" + clsPubSessionStorage.GetSession_UserId() + "'";
                //}
                //else {
                //    //获取当前用户自己数据
                //    strWhereCond += " And dataUser='" + strUserId + "'";
                //}
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
        Combinegs_TotalConditionObj() {
            var objgs_TotalDataStatistics_Cond = new clsgs_TotalDataStatisticsEN_js_1.clsgs_TotalDataStatisticsEN();
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            // var strUserId = clsPubSessionStorage.GetSession_UserId();
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                if (strId_CurrEduCls == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                    // strWhereCond += ` And ${clsgs_TotalDataStatisticsEN.con_id_CurrEduCls} = '${clsPublocalStorage.Getid_CurrEduCls()}'`;
                    $("#hidId_CurrEduClspara").val(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                }
                else {
                    //strWhereCond += ` And ${clsgs_TotalDataStatisticsEN.con_id_CurrEduCls} = '${strId_CurrEduCls}'`;
                    $("#hidId_CurrEduClspara").val(strId_CurrEduCls);
                }
                //var strUserId = $("#hidUserId").val();
                //if (strUserId == "") {
                //    strWhereCond += " and dataUser ='" + clsPubSessionStorage.GetSession_UserId() + "'";
                //}
                //else {
                //    //获取当前用户自己数据
                //    strWhereCond += " And dataUser='" + strUserId + "'";
                //}
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
            var objWhere_Cond = this.Combinegs_TotalCondition();
            var objgs_TotalDataStatistics_Cond = this.Combinegs_TotalConditionObj();
            var strid_CurrEducls = $("#hidId_CurrEduClspara").val();
            ;
            var strWhereCond = JSON.stringify(objgs_TotalDataStatistics_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_TotalDataStatisticsObjLst = [];
            var arrvUserStuNameObjLst = [];
            var arrgs_TotalDataStatisticsObjLst0 = [];
            var arrgs_TotalDataStatisticsObjLst = [];
            var arrObjLst_Sel = [];
            //var objPagerPara: stuPagerPara = {
            //    pageIndex: intCurrPageIndex,
            //    pageSize: this.pageSize,
            //    whereCond: objgs_TotalDataStatistics_Cond,
            //    orderBy: this.hidSortTotalBy
            //};
            try {
                //this.RecCount = await gs_TotalDataStatisticsEx_GetObjLstEx(objgs_TotalDataStatistics_Cond);
                // console.log("完成计数!");
                const responseObjLst = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetSubObjLst_CacheEx)(objgs_TotalDataStatistics_Cond, strid_CurrEducls).then((jsonData) => {
                    arrgs_TotalDataStatisticsObjLst0 = jsonData;
                });
                console.log("完成对象列表获取!");
                //var strWhereCond = " totalDataTypeId !='02'";
                //arrObjLst_Sel = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
                arrObjLst_Sel = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLst_Cache)();
                arrObjLst_Sel = arrObjLst_Sel.filter(x => x.totalDataTypeId != "02");
                var arrvUserStuNameObjLst = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                var arrvgs_TotalDataStatisticsObjLst = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync)(objWhere_Cond);
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
                //声明参数 用来判断是否有数据；
                var strDataContent = "";
                //动态显示对应的数据
                var strhtml = "";
                var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                var strRoleId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_RoleId();
                //个人观点
                strhtml += '<div class="info" id="infoDetailTotal">';
                //循环教学班人数
                for (var y = 0; y < arrvgs_TotalDataStatisticsObjLst.length; y++) {
                    var strUserId = arrvgs_TotalDataStatisticsObjLst[y].dataUser;
                    var arrvUsers = [];
                    var UpdUserName = ""; //编辑人
                    arrvUsers = arrvUserStuNameObjLst.filter(x => x.userId == strUserId); //
                    for (var j = 0; j < arrvUsers.length; j++) {
                        UpdUserName = arrvUsers[j].userName;
                        break;
                    }
                    for (var k = 0; k < arrObjLst_Sel.length; k++) {
                        var TypeName = arrObjLst_Sel[k].totalDataTypeName;
                        var strTypeId = arrObjLst_Sel[k].totalDataTypeId;
                        //查询过滤等于ID数据；
                        //arrgs_TotalDataStatisticsObjLst0 = arrgs_TotalDataStatisticsObjLst0.filter(x => x.dataUser == '0310276' || x.dataUser == 's1')
                        //如果用户表不存在次数据，那么则不用查询总表，不显示此数据；
                        if (UpdUserName != "") {
                            arrgs_TotalDataStatisticsObjLst = arrgs_TotalDataStatisticsObjLst0.filter(x => x.totalDataTypeId == strTypeId && x.dataUser == strUserId);
                            if (arrgs_TotalDataStatisticsObjLst.length > 0) {
                                strhtml += '<div><span class="color2">' + UpdUserName + '</span></div>';
                                strhtml += '<div><span class="color3">' + TypeName + '</span></div></br>';
                                strhtml += '<span class="color4">数量：&nbsp;&nbsp;</span><span class="abstract-text">' + arrgs_TotalDataStatisticsObjLst.length + '</span></br>';
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
                                    strhtml += '<span class="color6">时间&nbsp;&nbsp;当前周' + strWeek + '';
                                    strhtml += '&nbsp;&nbsp;周时间范围' + strWeekRange + '</span></br></br>';
                                    //strhtml += '</br><div style="border-bottom: 1px solid #eee;"></div></br>';
                                }
                                strhtml += '';
                            }
                        }
                    }
                    if (UpdUserName != "") {
                        //  if (arrgs_TotalDataStatisticsObjLst.length > 0) {
                        //服务器展示
                        var strAddressAndPort = `${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrIPAddressAndPort}/${clsSysPara4WebApi2_js_1.clsSysPara4WebApi2.CurrPrx_Local}/`;
                        //本地展示；
                        //   var strAddressAndPort = `${clsSysPara4WebApi2.CurrIPAddressAndPort_LocalPic}/${clsSysPara4WebApi2.CurrPrx_Local}/`;
                        var strAddressAndPortfull = strAddressAndPort + "UploadFiles/UserCanvasPic/" + strid_CurrEducls + "/" + strUserId + ".png";
                        strhtml += '<br/>&nbsp;&nbsp;&nbsp;<img src="' + strAddressAndPortfull + '" alt="" id="txtImgPath' + strUserId + '"/>';
                        //    }
                    }
                }
                strhtml += '</div>';
                //拼接；
                $("#ExportDetail").html(strhtml);
                (0, clsgs_TotalDataStatisticsWApi_js_1.gs_TotalDataStatistics_ReFreshCache)(strid_CurrEducls);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定论文视图对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        //-------------------------------关于图表函数绑定
        //绑定所有学生数据统计
        async BindGv_TotalDataNum() {
            var strWhereCond = this.CombineCondition1();
            var arrvgs_TotalDataStatisticsObjLst1 = [];
            //var arrvgs_TotalDataStatisticsObjLst2: Array<clsvgs_TotalDataStatisticsEN> = [];
            var arrvgs_TotalDataStatisticsObjLst3 = [];
            //临时
            var arrvgs_TotalDataStatisticsObjLst4 = [];
            try {
                //用户
                const responseText1 = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst1 = jsonData;
                    console.log("3-1");
                });
                //用户、周
                const responseText3 = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst3 = jsonData;
                    console.log("3-3");
                });
                //教学班
                //var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
                //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                //const responseText5 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
                //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText5;
                //if (objgs_TeachingDateEN != null) {
                //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                //    //计算出相差天数
                //    var days = Math.floor(duration / (24 * 3600 * 1000));
                //    //天数除以7得到周；
                //    var WeekNum = Math.ceil(days / 7);
                var WeekNum = await this.GetTeachingDateWeek();
                if (WeekNum != 0) {
                    var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                    /*********************************周列表*********************************/
                    var strWeek = "[";
                    for (var j = 1; j <= WeekNum; j++) {
                        //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        //var ChildarrvSysCommentObjLst = arrvgs_TotalDataStatisticsObjLst2.find(x => x.week == i);
                        //if (ChildarrvSysCommentObjLst == null) {
                        strWeek += '"第' + j + '周",';
                        //}
                        //else {
                        //    strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                        //}
                    }
                    strWeek = strWeek.substr(0, strWeek.length - 1);
                    strWeek += "]";
                    var strLabelsJson = eval(strWeek);
                    //定义一个标识符Number 用于展示多个Canvas；
                    var Number = 0;
                    if (arrvgs_TotalDataStatisticsObjLst1.length > 0) {
                        /******************************************************************/
                        //var spanUserName1 = '<span style="font-weight: 500;"><i class="fa fa-square" style="color:'
                        //var spanUserName2 = ';font-size: 20px; padding-right: 5px; vertical-align: middle; margin-top: -3px;"></i>'
                        //var spanUserName3 = '</span>'
                        //var strHtml = "";
                        //循环总数据 先得到先得到每个人的数据；
                        // arrvgs_TotalDataStatisticsObjLst1 = arrvgs_TotalDataStatisticsObjLst1.filter(x => x.dataUser == "0310276"); //用于测试；
                        for (var k = 0; k < arrvgs_TotalDataStatisticsObjLst1.length; k++) {
                            var strDataUserId = arrvgs_TotalDataStatisticsObjLst1[k].dataUser;
                            var strId_CurrEducls = arrvgs_TotalDataStatisticsObjLst1[k].id_CurrEduCls;
                            var arrvgs_TotalDataStatisticsObjLst2 = arrvgs_TotalDataStatisticsObjLst1.filter(x => x.dataUser == strDataUserId);
                            if (strDataUserId != "") {
                                //存放隐藏参数；
                                var strNum = "[";
                                for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst2.length; i++) {
                                    //获取色码
                                    var strcolor = this.getRandomColor();
                                    var objUser = arrUsers.find(x => x.userId == arrvgs_TotalDataStatisticsObjLst2[i].dataUser);
                                    if (objUser != null) {
                                        //strHtml += spanUserName1 + strcolor + spanUserName2 + objUser.userName + spanUserName3;
                                        //strNum += "{ label: \"" + objUser.userName + "\",fillColor: \"rgba(220,220,220, 0.01)\",strokeColor: \"" + strcolor + "\",pointColor: \"" + strcolor + "\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"" + strcolor + "\",data: [";
                                        strNum += "{ label: \"" + objUser.userName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                                        arrvgs_TotalDataStatisticsObjLst4 = arrvgs_TotalDataStatisticsObjLst3.filter(x => x.dataUser == arrvgs_TotalDataStatisticsObjLst2[i].dataUser);
                                        //for (var j = 0; j < arrvgs_TotalDataStatisticsObjLst2.length; j++) {
                                        for (var j = 1; j <= WeekNum; j++) {
                                            if (arrvgs_TotalDataStatisticsObjLst4.length > 0) {
                                                //var objWeek = arrvgs_TotalDataStatisticsObjLst4.find(x => x.week == arrvgs_TotalDataStatisticsObjLst2[j].week);
                                                var objWeek = arrvgs_TotalDataStatisticsObjLst4.find(x => x.week == j);
                                                if (objWeek != null) {
                                                    strNum += objWeek.memo + ',';
                                                }
                                                else {
                                                    strNum += '0,';
                                                }
                                            }
                                            else {
                                                strNum += '0,';
                                            }
                                        }
                                        strNum = strNum.substr(0, strNum.length - 1);
                                        strNum += "]},";
                                    }
                                    //else {
                                    //    strNum += "],";
                                    //}
                                }
                                if (strNum.length > 1) {
                                    //只有大于1数组才表示有数据；才需要截取；和调用；
                                    strNum = strNum.substr(0, strNum.length - 1);
                                    strNum += "]";
                                    var strDatasetsJson = eval(strNum);
                                    Number++; //用来区分多个Canvas ，用户ID 作为属性 用于图片存放名称；
                                    Canvas3(strLabelsJson, strDatasetsJson, Number, strDataUserId);
                                }
                                //   btnExportWord_Click();
                            }
                            strNum = "";
                        }
                        //如果循环完毕，那么再次调用教学班所有数据；
                        if (k == arrvgs_TotalDataStatisticsObjLst1.length) {
                            //存放隐藏参数；
                            var strNum = "[";
                            for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst1.length; i++) {
                                //获取色码
                                var strcolor = this.getRandomColor();
                                var objUser = arrUsers.find(x => x.userId == arrvgs_TotalDataStatisticsObjLst1[i].dataUser);
                                if (objUser != null) {
                                    //strHtml += spanUserName1 + strcolor + spanUserName2 + objUser.userName + spanUserName3;
                                    //strNum += "{ label: \"" + objUser.userName + "\",fillColor: \"rgba(220,220,220, 0.01)\",strokeColor: \"" + strcolor + "\",pointColor: \"" + strcolor + "\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"" + strcolor + "\",data: [";
                                    strNum += "{ label: \"" + objUser.userName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                                    arrvgs_TotalDataStatisticsObjLst4 = arrvgs_TotalDataStatisticsObjLst3.filter(x => x.dataUser == arrvgs_TotalDataStatisticsObjLst1[i].dataUser);
                                    //for (var j = 0; j < arrvgs_TotalDataStatisticsObjLst2.length; j++) {
                                    for (var j = 1; j <= WeekNum; j++) {
                                        if (arrvgs_TotalDataStatisticsObjLst4.length > 0) {
                                            //var objWeek = arrvgs_TotalDataStatisticsObjLst4.find(x => x.week == arrvgs_TotalDataStatisticsObjLst2[j].week);
                                            var objWeek = arrvgs_TotalDataStatisticsObjLst4.find(x => x.week == j);
                                            if (objWeek != null) {
                                                strNum += objWeek.memo + ',';
                                            }
                                            else {
                                                strNum += '0,';
                                            }
                                        }
                                        else {
                                            strNum += '0,';
                                        }
                                    }
                                    strNum = strNum.substr(0, strNum.length - 1);
                                    strNum += "]},";
                                }
                            }
                            strNum = strNum.substr(0, strNum.length - 1);
                            strNum += "]";
                            var strDatasetsJson = eval(strNum);
                            var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
                            Number = 0; //这里等于0 说明代表是整个教学班的Canvas图；
                            Canvas3(strLabelsJson, strDatasetsJson, Number, strId_CurrEduCls);
                            // btnExportWord_Click();
                            strNum = "";
                        }
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        alert(strMsg);
                    }
                }
                else {
                    var strMsg = `当前教学班没有设置时间范围`;
                    alert(strMsg);
                }
                //$("#divUserLst").html(strHtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        CombineCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
            if (strId_CurrEduCls == "") {
                strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
                $("#hidId_CurrEduClspara").val(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
            }
            else {
                strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
            }
            //通过教学班得到教学班时间范围；、
            //if (this.EndDate_q == "") {
            //    if ($("#hidQueryStata").val() == "2" || $("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "4") {
            //        if ($("#hidStartDate").val() != "" && $("#hiEndDate").val() != "") {
            //            var startDate = $("#hidStartDate").val();
            //            var endDate = $("#hiEndDate").val();
            //            strWhereCond += " And dataAddDate >= '" + startDate + "' And dataAddDate <= '" + endDate + "'";
            //        }
            //    }
            //}
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //if (this.StartDate_q != "") {
                //    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;
                //}
                //if (this.EndDate_q != "") {
                //    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                //}
                //if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                //    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                //}
                ////管理员
                ////if ($("#hidQueryStata").val() == "1") {
                //if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                //    if (this.UserId_q != "" && this.UserId_q != "0") {
                //        strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.UserId_q}'`;
                //    }
                //    if (this.TopicId_q != "0" && this.TopicId_q != "") {
                //        strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                //    }
                //    if (this.isRecommend == true) {
                //        strWhereCond += ` And isRecommend=1`;
                //    }
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //获取不同色码
        getRandomColor() {
            return '#' + ('00000' + (Math.random() * 0x1000000 << 0).toString(16)).substr(-6);
        }
        //获取教学班的时间得到周数
        async GetTeachingDateWeek() {
            //教学班
            var strid_CurrEduCls = "";
            var strId_CurrEduCls = $("#hidId_CurrEduClspara").val();
            if (strId_CurrEduCls == "") {
                strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                //$("#hidId_CurrEduClspara").val(clsPublocalStorage.Getid_CurrEduCls());
            }
            else {
                strid_CurrEduCls = strId_CurrEduCls;
            }
            // var strid_CurrEduCls = clsPublocalStorage.Getid_CurrEduCls();
            var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
            //const responseText5 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText5;
            var arrgs_TeachingDateObjLst = [];
            const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetObjLst_Cache)(strId_CurrEduCls).then((jsonData) => {
                //const responseText1 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_TeachingDateObjLst = jsonData;
                console.log("获取教学班日期成功");
            });
            var objgs_TeachingDateEN = arrgs_TeachingDateObjLst.find(x => x.id_CurrEduCls == strid_CurrEduCls);
            if (objgs_TeachingDateEN != null) {
                var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                //计算出相差天数
                var days = Math.floor(duration / (24 * 3600 * 1000));
                //天数除以7得到周；
                var WeekNum = Math.ceil(days / 7);
                return WeekNum;
            }
            else {
                var strMsg = `当前教学班没有设置时间范围`;
                alert(strMsg);
                return 0;
            }
        }
    }
    exports.SysScoreSummaryNewTotal = SysScoreSummaryNewTotal;
});
