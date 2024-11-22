(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTools/gs_TotalDataStatisticsCRUD.js", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js", "../TS/L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js", "../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js", "../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_AnswerCountExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "./gs_TeachingDate_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TotalDataStatisticsEx = void 0;
    const gs_TotalDataStatisticsCRUD_js_1 = require("../PagesBase/GraduateEduTools/gs_TotalDataStatisticsCRUD.js");
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsvCurrEduClsStuEN_js_1 = require("../TS/L0_Entity/DailyRunning_Share/clsvCurrEduClsStuEN.js");
    const clsgs_AnswerCountEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js");
    const clsSysCommentEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const clsvgs_TotalDataStatisticsEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage_Share/clsvUsersSimEN.js");
    const clsvCurrEduClsStuWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsvCurrEduClsStuWApi.js");
    const clsgs_AnswerCountWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_AnswerCountWApi.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsgs_TotalDataTypeWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js");
    const clsSysCommentWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsSysCommentWApi.js");
    const clsvgs_TotalDataStatisticsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysCommentExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEdu/clsSysCommentExWApi.js");
    const clsgs_AnswerCountExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_AnswerCountExWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsvgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const gs_TeachingDate_EditEx_js_1 = require("./gs_TeachingDate_EditEx.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class TotalDataStatisticsEx extends gs_TotalDataStatisticsCRUD_js_1.gs_TotalDataStatisticsCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        BindGv(strType, strPara) {
            //this.BindGv_vgs_TeachingDate();
            var strid_CurrEdu = "";
            var strPageStata = "";
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls != "") {
                    //1、从教学班表内获取当前教学班学生
                    await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsStuUser("ddlUserId_q");
                    //const ddl_UserId_q = await this.BindDdl_UserName("ddlUserId_q");
                    await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache)(this.divName4Query, "ddlTotalDataTypeId_q");
                    await clsDropDownList_js_1.clsDropDownList.BindDdl_TopicId("ddlTopicId_q");
                    //默认显示第3个；参数可以变换；
                    //if (this.userId_q != "" && this.userId_q != "0") {
                    //    // const gvResult1 = await this.BindGv_UserNum();
                    //}
                    //else {
                    //    //默认显示第3个；参数可以变换；
                    //    $('#ddlUserId_q').prop('selectedIndex', 2);
                    //}
                    //获取教学班时间范围
                    const gvResult = await this.GetEduDataRandge();
                    var strid_CurrEdu = "";
                    var strPageStata = "";
                    //默认显示数据,因为是本界面调用，所以参数赋 空值；
                    const gvResult1 = await this.Bind_AllData();
                    //const gvResult1 = await this.Bind_AllData()
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
        //教学班学生关系
        async BindDdl_UserName(ddlUserId_q) {
            //var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var objDdl = document.getElementById(ddlUserId_q);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlUserId_q} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetObjLst_Cache)(strid_CurrEduCls);
                //var arrObjLst_Sel: Array<clsvgs_TotalDataStatisticsEN> = await vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync(strWhereCond);
                //arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02");//客观数据；
                var arrUserId_Set = new Set(arrObjLst_Sel.map(x => x.updUser));
                console.log(arrUserId_Set);
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var arrUsersList_Sel = arrUsers.filter(x => arrUserId_Set.has(x.userId));
                console.log(arrUsersList_Sel);
                arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName]);
                (0, clsCommFunc4Web_js_1.BindDdl_ObjLst_V)(ddlUserId_q, arrUsersList_Sel, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, "教学班用户");
                //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvgs_TotalDataStatisticsEN.con_UpdUser]);
                //BindDdl_ObjLst(ddlUserId_q, arrObjLst_Sel, clsvCurrEduClsStuEN.con_StuID, clsvCurrEduClsStuEN.con_StuName, "教学班学生");
                console.log("完成BindDdl_vCurrEduClsStuId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //获取教学班时间范围
        async GetEduDataRandge() {
            // var strWhereCond: string = " 1 = 1 and id_CurrEduCls=" + clsPublocalStorage.id_CurrEduCls;
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            var arrgs_TeachingDateObjLst = [];
            const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetObjLst_Cache)(strid_CurrEduCls).then((jsonData) => {
                //const responseText1 = await vCurrEduClsStu_GetObjLstAsync(strWhereCond).then((jsonData) => {
                arrgs_TeachingDateObjLst = jsonData;
                console.log("获取教学班日期成功");
            });
            //通过教学班得到教学班时间范围；、
            // const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereCond);
            var objgs_TeachingDateEN = arrgs_TeachingDateObjLst.find(x => x.id_CurrEduCls == strid_CurrEduCls);
            //    var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
            if (objgs_TeachingDateEN != null) {
                $("#hidStartDate").val(objgs_TeachingDateEN.startDate);
                $("#hiEndDate").val(objgs_TeachingDateEN.endDate);
                this.StartDate_q = objgs_TeachingDateEN.startDate;
                this.EndDate_q = objgs_TeachingDateEN.endDate;
            }
        }
        //设置教学班范围时间；
        async btnSetUpDateRecord_Click() {
            var objPage = new TotalDataStatisticsEx();
            var objPage_Edit = new gs_TeachingDate_EditEx_js_1.gs_TeachingDate_EditEx(objPage);
            var strKeyId = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            //判断教学班数据是否已经被设置
            var strWhere = " 1 = 1 And id_CurrEduCls = '" + strKeyId + "'";
            const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhere);
            var objgs_TeachingDateEN = responseText1;
            if (objgs_TeachingDateEN != null) {
                //赋值，弹出框
                //存放教学班日期范围表主键
                $("#hidgs_DateId").val(objgs_TeachingDateEN.mId);
                objPage_Edit.btnUpdateRecordInTab_Click(objgs_TeachingDateEN.mId.toString());
            }
            else {
                //添加 需要清空下隐藏数据
                $("#hidgs_DateId").val("");
                objPage_Edit.btnAddNewRecord_Click();
            }
        }
        //一个是教学班，一个是判断调用函数的类型参数；
        async Bind_AllData() {
            ////如果传入的教学班为空，那么则可以判断不是其他界面调用此函数；
            // var hQstata: string = "";
            // //如果等于空，则是 本界面调用，那么类型参数按照本界面执行，否则按照传入的参数调用执行；
            // if (strId_CurrEduCls != "") {
            //     hQstata = strPageStata;
            // }
            // else {
            //     hQstata = $("#hidQueryStata").val();
            // }
            var hQstata = $("#hidQueryStata").val();
            //赋值等于空，则是本界面调用，否则按照传入的参数调用执行
            var strId_CurrEduCls = "";
            var Number = "";
            var strUserIdorCurrEduClsId = "";
            switch (hQstata) {
                case "1":
                    if (this.userId_q != "" && this.userId_q != "0") {
                    }
                    else {
                        $('select').prop('selectedIndex', 1);
                    }
                    const gvResult1 = await this.BindGv_UserNum(strId_CurrEduCls);
                    const gvResult_1 = await this.BindGv_UserNumTable();
                    break;
                case "2":
                    const gvResult2 = await this.BindGv_TeaClassNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                    const gvResult_2 = await this.BindGv_UserNumTable();
                    break;
                case "3":
                    const gvResult3 = await this.BindGv_TotalDataNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                    const gvResult_3 = await this.BindGv_TotalDataNumTable();
                    break;
                case "4":
                    const gvResult4 = await this.BindGv_AVGTeaScore(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                    const gvResult_4 = await this.BindGv_TeaClassAverageTab();
                    break;
                case "5":
                    const gvResult5 = await this.BindChart_TeaClassComment(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                    break;
                case "6":
                    const gvResult6 = await this.BindChart_UserCommentNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                    break;
                case "7":
                    const gvResult7 = await this.BindChart_UserDiscussNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                    const gvResult_7 = await this.BindGv_UserDiscussNumTable();
                    break;
            }
            //if (hQstata == "1") {
            //    if (this.userId_q != "" && this.userId_q != "0") {
            //    }
            //    else {
            //        $('select').prop('selectedIndex', 1);
            //    }
            //    const gvResult = await this.BindGv_UserNum();
            //    const gvResult1 = await this.BindGv_UserNumTable();
            //} else if (hQstata == "2") {
            //    const gvResult = await this.BindGv_TeaClassNum();
            //    const gvResult1 = await this.BindGv_UserNumTable();
            //} else if (hQstata == "3") {
            //    const gvResult = await this.BindGv_TotalDataNum();
            //    const gvResult1 = await this.BindGv_TotalDataNumTable();
            //}
            //else if (hQstata == "4") {
            //    const gvResult = await this.BindGv_AVGTeaScore();
            //    const gvResult1 = await this.BindGv_TeaClassAverageTab();
            //}
            //else if (hQstata == "5") {
            //    const gvResult = await this.BindChart_TeaClassComment();
            //}
            //else if (hQstata == "6") {
            //    const gvResult = await this.BindChart_UserCommentNum();
            //}
        }
        //同步总数据统计
        async btnSynTotalDataStatistics_Click() {
            $("#divLoading").show();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            try {
                const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_IsExistRecordAsync)("id_CurrEduCls =" + strid_CurrEduCls);
                var returnBool1 = !!responseText1;
                if (returnBool1 == true) {
                    const responseText2 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strid_CurrEduCls, strUserId);
                    var returnBool2 = !!responseText2;
                    if (returnBool2 == true) {
                        const responseText3 = await (0, clsSysCommentExWApi_js_1.SysCommentEx_UpdateCommentWeekAsync)(strid_CurrEduCls, strUserId);
                        var returnBool3 = !!responseText2;
                        if (returnBool3 == true) {
                            var strInfo = `同步数据成功!`;
                            //$('#lblResult46').val(strInfo);
                            //显示信息框
                            //Alert1(strInfo);
                            alert(strInfo);
                            $("#divLoading").hide();
                        }
                        else {
                            var strInfo = `同步数据成功,但同步评论出错!`;
                            //$('#lblResult46').val(strInfo);
                            //显示信息框
                            //Alert1(strInfo);
                            alert(strInfo);
                            $("#divLoading").hide();
                        }
                    }
                    else {
                        var strInfo = `同步数据不成功!`;
                        //$('#lblResult46').val(strInfo);
                        //显示信息框
                        //Alert1(strInfo);
                        alert(strInfo);
                        $("#divLoading").hide();
                    }
                    return responseText2; //一定要有一个返回值，否则会出错！
                }
                else {
                    $("#divLoading").hide();
                    var strInfo = `当前教学班还没有添加教学班时间，请到教学班维护界面添加教学班时间!`;
                    alert(strInfo);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `统计核算异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }
        //同步总数据统计
        async btnSynAnswerCount_Click() {
            $("#divLoading").show();
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            try {
                const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_IsExistRecordAsync)("id_CurrEduCls =" + strid_CurrEduCls);
                var returnBool1 = !!responseText1;
                if (returnBool1 == true) {
                    const responseText2 = await (0, clsgs_AnswerCountExWApi_js_1.gs_AnswerCountEx_GetAnswerCountByTableAsync)(strid_CurrEduCls, strUserId);
                    var returnBool2 = !!responseText2;
                    if (returnBool2 == true) {
                        var strInfo = `同步数据成功!`;
                        alert(strInfo);
                        $("#divLoading").hide();
                    }
                    else {
                        var strInfo = `同步数据不成功!`;
                        alert(strInfo);
                        $("#divLoading").hide();
                    }
                    return responseText2; //一定要有一个返回值，否则会出错！
                }
                else {
                    $("#divLoading").hide();
                    var strInfo = `当前教学班还没有添加教学班时间，请到教学班维护界面添加教学班时间!`;
                    alert(strInfo);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `统计核算异常,${e}.`;
                alert(strMsg);
                $("#divLoading").hide();
            }
        }
        /* 用户统计
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_liUserNum_Click)
    */
        async liUserNum_Click() {
            try {
                var strid_CurrEdu = "";
                if (this.userId_q != "" && this.userId_q != "0") {
                    const gvResult1 = await this.BindGv_UserNum(strid_CurrEdu);
                    const gvResult2 = await this.BindGv_UserNumTable();
                }
                else {
                    Alert2("请先选择用户并查询！");
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //用户统计列表
        async BindGv_UserNumTable() {
            var strid_CurrEdu = "";
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            //周合集、观点合集
            var arrvgs_TotalDataStatisticsObjLst = [];
            //所有观点详细
            var arrvgs_TotalDetailObjLst = [];
            //某一类型观点详细
            var ChildarrvSysCommentObjLst = [];
            //获取统计类型数据；
            var gs_TotalDataTypeObjLst = [];
            try {
                //获取周和观点数据
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("获取周和观点数据成功");
                });
                //获取观点详细数据；
                const responseText1 = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDetailObjLst = jsonData;
                    console.log("获取详细数据成功");
                });
                ////获取统计类型数据；
                //const responseText2 = await gs_TotalDataType_GetObjLstAsync("1=1").then((jsonData) => {
                //    gs_TotalDataTypeObjLst = <Array<clsgs_TotalDataTypeEN>>jsonData;
                //    console.log("获取统计类型数据成功");
                //});
                gs_TotalDataTypeObjLst = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLst_Cache)();
                // arrObjLst_Sel = arrObjLst_Sel.filter(x => x.totalDataTypeId != "02");
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                if ($("#hidQueryStata").val() == "1") {
                    $('#tbListUserNum tr').remove();
                }
                else {
                    $('#tbListTeaClassNum tr').remove();
                }
                if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                    //得到数据源循环数据
                    for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                        cateid++;
                        // intJ++;
                        var fid = 0;
                        //周；
                        var strWeek = arrvgs_TotalDataStatisticsObjLst[i].week;
                        //周日期范围
                        var strWeekTimeFrame = arrvgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                        //记录数
                        var strNum = arrvgs_TotalDataStatisticsObjLst[i].memo;
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        ChildarrvSysCommentObjLst = arrvgs_TotalDetailObjLst.filter(x => x.week == strWeek);
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                        //周
                        strhtml += '<td>' + strWeek + '</td>';
                        //周日期范围
                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                        strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strNum + '</td>';
                        //结束
                        strhtml += '</tr>';
                        //父节点转化
                        cateid_ = cateid;
                        //子数据
                        if (ChildarrvSysCommentObjLst.length > 0) {
                            //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                            // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                            //循环统计类型；
                            for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                                var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                                var DetailTypeObjLst = ChildarrvSysCommentObjLst.filter(x => x.totalDataTypeId == strTypeId);
                                //如果大于0 ，说明有此类型数据，需要输出；
                                if (DetailTypeObjLst.length > 0) {
                                    for (var j = 0; j < DetailTypeObjLst.length; j++) {
                                        cateid++;
                                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                                        //周
                                        strhtml += '<td>' + strWeek + '</td>';
                                        //周日期范围
                                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                                        strhtml += '<td>' + DetailTypeObjLst[j].totalDataTypeName + '[' + DetailTypeObjLst.length + ']</td>';
                                        strhtml += '</tr>';
                                        //因为统计一个类型数据量，所以直接break；
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                //拼接；
                if ($("#hidQueryStata").val() == "1") {
                    $("#tbListUserNum").html(strhtml);
                }
                else {
                    $("#tbListTeaClassNum").html(strhtml);
                }
                tbody();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取用户统计数据不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 教学班统计
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_liTeaClassNum_Click)
    */
        async liTeaClassNum_Click() {
            try {
                var strid_CurrEdu = ""; //其他界面调用共参；
                var Number = "";
                var strUserIdorCurrEduClsId = "";
                const gvResult = await this.BindGv_TeaClassNum(strid_CurrEdu, Number, strUserIdorCurrEduClsId);
                const gvResult1 = await this.BindGv_UserNumTable();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //教学班平均分
        async TeaClassAverage_Click() {
            try {
                var strId_CurrEduCls = "";
                var Number = "";
                var strUserIdorCurrEduClsId = "";
                const gvResult = await this.BindGv_AVGTeaScore(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                const gvResult1 = await this.BindGv_TeaClassAverageTab();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        // //教学班平均分 列表
        async BindGv_TeaClassAverageTab() {
            var strid_CurrEdu = "";
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            var arrvgs_TotalDataStatisticsObjLst = [];
            //所有观点详细
            var arrvgs_TotalDetailObjLst = [];
            //某一类型观点详细
            var ChildarrvSysCommentObjLst = [];
            //获取统计类型数据；
            var gs_TotalDataTypeObjLst = [];
            try {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("获取统计平均分成功！");
                });
                //获取观点详细数据；
                const responseText1 = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDetailObjLst = jsonData;
                    console.log("获取详细数据成功");
                });
                ////获取统计类型数据；
                //const responseText2 = await gs_TotalDataType_GetObjLstAsync("1=1").then((jsonData) => {
                //    gs_TotalDataTypeObjLst = <Array<clsgs_TotalDataTypeEN>>jsonData;
                //    console.log("获取统计类型数据成功");
                //});
                gs_TotalDataTypeObjLst = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLst_Cache)();
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                $('#tbListClassAverage tr').remove();
                //得到统计平均分 分类数据
                if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                    //得到数据源循环数据
                    for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                        cateid++;
                        // intJ++;
                        var fid = 0;
                        //周；
                        var strWeek = arrvgs_TotalDataStatisticsObjLst[i].week;
                        //平均分
                        var strScore = arrvgs_TotalDataStatisticsObjLst[i].memo;
                        //周日期范围
                        var strWeekTimeFrame = arrvgs_TotalDataStatisticsObjLst[i].weekTimeRange;
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                        //周
                        strhtml += '<td>' + strWeek + '</td>';
                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                        strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strScore + '</td>';
                        //结束
                        strhtml += '</tr>';
                        //父节点转化
                        cateid_ = cateid;
                        //如果平均分大于0 则查询子数据
                        if (strScore != "0") {
                            //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                            ChildarrvSysCommentObjLst = arrvgs_TotalDetailObjLst.filter(x => x.week == strWeek);
                            //子数据
                            if (ChildarrvSysCommentObjLst.length > 0) {
                                //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                                // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                                //循环统计类型；
                                for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                                    var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                                    var strTypeName = gs_TotalDataTypeObjLst[k].totalDataTypeName;
                                    var DetailTypeObjLst = ChildarrvSysCommentObjLst.filter(x => x.totalDataTypeId == strTypeId);
                                    //如果大于0 ，说明有此类型数据，需要输出；
                                    if (DetailTypeObjLst.length > 0) {
                                        //对象列表某一列求和
                                        //var ScoreSum = DetailTypeObjLst.reduce((p, e) => p + e.teaScore, 0);
                                        //获取只打分的观点数
                                        var DetailNumObjLst = DetailTypeObjLst.filter(x => x.teaScore != 0);
                                        //for (var j = 0; j < DetailTypeObjLst.length; j++) {
                                        cateid++;
                                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                                        //周
                                        strhtml += '<td>' + strWeek + '</td>';
                                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                                        strhtml += '<td>' + strTypeName + '[' + DetailNumObjLst.length + '/' + DetailTypeObjLst.length + ']</td>';
                                        strhtml += '</tr>';
                                        //因为只需要一个统计类型；
                                        //    break;
                                        //}
                                    }
                                }
                            }
                        }
                    }
                }
                $("#tbListClassAverage").html(strhtml);
                $("#Canvas2").removeClass("");
                tbody();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 总数统计
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async liTotalDataNum_Click() {
            try {
                var strId_CurrEduCls = "";
                var Number = "";
                var strUserIdorCurrEduClsId = "";
                const gvResult = await this.BindGv_TotalDataNum(strId_CurrEduCls, Number, strUserIdorCurrEduClsId);
                const gvResult1 = await this.BindGv_TotalDataNumTable();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //所有学生教学班周统计；
        async BindGv_TotalDataNumTable() {
            var strid_CurrEdu = "";
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            var arrvgs_TotalDataStatisticsObjLst3 = [];
            //所有观点详细
            var arrvgs_TotalDetailObjLst = [];
            //临时
            var arrvgs_TotalDataStatisticsObjLst4 = [];
            //获取统计类型数据；
            var gs_TotalDataTypeObjLst = [];
            try {
                //获取观点详细数据；
                const responseText1 = await (0, clsvgs_TotalDataStatisticsWApi_js_1.vgs_TotalDataStatistics_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDetailObjLst = jsonData;
                    console.log("获取详细数据成功");
                });
                //用户、周
                const responseText3 = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst3 = jsonData;
                    console.log("3-3");
                });
                ////获取统计类型数据；
                //const responseText2 = await gs_TotalDataType_GetObjLstAsync("1=1").then((jsonData) => {
                //    gs_TotalDataTypeObjLst = <Array<clsgs_TotalDataTypeEN>>jsonData;
                //    console.log("获取统计类型数据成功");
                //});
                gs_TotalDataTypeObjLst = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLst_Cache)();
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                $('#tbListTotalDataNum tr').remove();
                //首先得到用户 周 观点统计
                if (arrvgs_TotalDataStatisticsObjLst3.length > 0) {
                    //得到数据源循环数据
                    for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst3.length; i++) {
                        cateid++;
                        // intJ++;
                        var fid = 0;
                        //用户
                        var strUserId = arrvgs_TotalDataStatisticsObjLst3[i].dataUser;
                        //周；
                        var strWeek = arrvgs_TotalDataStatisticsObjLst3[i].week;
                        //记录数
                        var strNum = arrvgs_TotalDataStatisticsObjLst3[i].memo;
                        //用户名
                        var objUser = arrUsers.find(x => x.userId == strUserId);
                        //周日期范围
                        var strWeekTimeFrame = arrvgs_TotalDataStatisticsObjLst3[i].weekTimeRange;
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                        //周
                        strhtml += '<td>' + strWeek + '</td>';
                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                        if (objUser != null) {
                            //用户
                            strhtml += '<td>' + objUser.userName + '</td>';
                        }
                        else {
                            //用户
                            strhtml += '<td></td>';
                        }
                        strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strNum + '</td>';
                        //结束
                        strhtml += '</tr>';
                        //父节点转化
                        cateid_ = cateid;
                        //先过滤当前循环用户的数据，再过滤当前数据周的数据 然后数据输出；
                        arrvgs_TotalDataStatisticsObjLst4 = arrvgs_TotalDetailObjLst.filter(x => x.dataUser == strUserId && x.week == strWeek);
                        //子数据
                        if (arrvgs_TotalDataStatisticsObjLst4.length > 0) {
                            //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                            // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                            //循环统计类型；
                            for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                                var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                                var DetailTypeObjLst = arrvgs_TotalDataStatisticsObjLst4.filter(x => x.totalDataTypeId == strTypeId);
                                //如果大于0 ，说明有此类型数据，需要输出；
                                if (DetailTypeObjLst.length > 0) {
                                    for (var j = 0; j < DetailTypeObjLst.length; j++) {
                                        cateid++;
                                        strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                                        //周
                                        strhtml += '<td>' + strWeek + '</td>';
                                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                                        //用户
                                        if (objUser != null) {
                                            //用户
                                            strhtml += '<td>' + objUser.userName + '</td>';
                                        }
                                        else {
                                            //用户
                                            strhtml += '<td></td>';
                                        }
                                        strhtml += '<td>' + DetailTypeObjLst[j].totalDataTypeName + '[' + DetailTypeObjLst.length + ']</td>';
                                        strhtml += '</tr>';
                                        //因为统计一个类型数据量，所以直接break；
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                $("#tbListTotalDataNum").html(strhtml);
                tbody();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        CombineCondition1(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1";
            // var  strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
                try {
                    if (this.StartDate_q != "") {
                        strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;
                    }
                    if (this.EndDate_q != "") {
                        strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                    }
                    if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                        strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                    }
                    //管理员
                    //if ($("#hidQueryStata").val() == "1") {
                    if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                        if (this.userId_q != "" && this.userId_q != "0") {
                            strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                        }
                        if (this.TopicId_q != "0" && this.TopicId_q != "") {
                            strWhereCond += ` And ${clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                        }
                        if (this.isRecommend == true) {
                            strWhereCond += ` And isRecommend=1`;
                        }
                    }
                    //if ($("#hidRoleId").val() == "00620001") { }
                    //教师
                    //else if ($("#hidRoleId").val() == "00620002") {
                    //    $("#td_UserId").hide();
                    //    strWhereCond += " and dataUser='" + clsPublocalStorage.userId + "'";
                    //}
                    ////学生
                    //else {
                    //    $("#td_UserId").hide();
                    //    strWhereCond += " and dataUser='" + clsPublocalStorage.userId + "'";
                    //}
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            //例如 1 = 1 && userName = '张三'
            strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
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
            return strWhereCond;
        }
        CombineConditionObj1(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            var objvgs_TotalDataStatistics_Cond = new clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN();
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                try {
                    if (this.StartDate_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;
                        objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.StartDate_q, ">=");
                    }
                    if (this.EndDate_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                        objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                        objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    //管理员
                    //if ($("#hidQueryStata").val() == "1") {
                    if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                        if (this.userId_q != "" && this.userId_q != "0") {
                            // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                            objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                        }
                        if (this.TopicId_q != "0" && this.TopicId_q != "") {
                            //  strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                            objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataAddDate, this.EndDate_q, "<=");
                        }
                    }
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            objvgs_TotalDataStatistics_Cond.SetCondFldValue(clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            return objvgs_TotalDataStatistics_Cond;
        }
        CombineCondition2(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                try {
                    if (this.userId_q != "" && this.userId_q != "0") {
                        strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID} = '${this.userId_q}'`;
                    }
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
            strWhereCond += ' order by stuName Asc';
            return strWhereCond;
        }
        CombineConditionObj2(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvCurrEduClsStu_Cond = new clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN();
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                try {
                    if (this.userId_q != "" && this.userId_q != "0") {
                        strWhereCond += ` And ${clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID} = '${this.userId_q}'`;
                        objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID, this.userId_q, "=");
                    }
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            objvCurrEduClsStu_Cond.SetCondFldValue(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            //  strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
            //strWhereCond += ' order by stuName Asc';
            return objvCurrEduClsStu_Cond;
        }
        CombineCondition3(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1";
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                //var strPaperTypeId = $("#hidPaperTypeId").val();
                //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
                try {
                    if (this.StartDate_q != "") {
                        strWhereCond += ` And ${clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate} >= '${this.StartDate_q}'`;
                    }
                    if (this.EndDate_q != "") {
                        strWhereCond += ` And ${clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate} <= '${this.EndDate_q}'`;
                    }
                    if (this.userId_q != "" && this.userId_q != "0") {
                        strWhereCond += ` And ${clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser} = '${this.userId_q}'`;
                    }
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            strWhereCond += " and id_CurrEduCls='" + strId_CurrEduCls + "'";
            return strWhereCond;
        }
        CombineConditionObj3(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            var objSysComment_Cond = new clsSysCommentEN_js_1.clsSysCommentEN();
            objSysComment_Cond.SetCondFldValue(clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            //例如 1 = 1 && userName = '张三'
            //  var strWhereCond: string = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "'";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    //    strWhereCond += ` And ${clsSysCommentEN.con_UpdDate} >= '${this.StartDate_q}'`;
                    objSysComment_Cond.SetCondFldValue(clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate, this.StartDate_q, ">=");
                }
                if (this.EndDate_q != "") {
                    //    strWhereCond += ` And ${clsSysCommentEN.con_UpdDate} <= '${this.EndDate_q}'`;
                    objSysComment_Cond.SetCondFldValue(clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate, this.EndDate_q, "<=");
                }
                if (this.userId_q != "" && this.userId_q != "0") {
                    //   strWhereCond += ` And ${clsSysCommentEN.con_UpdUser} = '${this.userId_q}'`;
                    objSysComment_Cond.SetCondFldValue(clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser, this.userId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objSysComment_Cond;
        }
        //绑定学生数据统计
        async BindGv_UserNum(strid_CurrEdu) {
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            var arrvgs_TotalDataStatisticsObjLst = [];
            // var ChildarrvSysCommentObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
            var arrgs_TeachingDateENObjLst;
            try {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("1-0");
                });
                //教学班
                //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
                //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
                //if (objgs_TeachingDateEN != null) {
                //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                //    //计算出相差天数
                //    var days = Math.floor(duration / (24 * 3600 * 1000));
                //    //天数除以7得到周；
                //    var WeekNum = Math.ceil(days / 7);
                var strId_CurrEduCls = "";
                if (strid_CurrEdu == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                }
                else {
                    strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
                }
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                        var strWeek = "[";
                        var strNum = "[";
                        //for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                        //    strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
                        //    strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
                        //}
                        for (var i = 1; i <= WeekNum; i++) {
                            //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                            //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                            var ChildarrvSysCommentObjLst = arrvgs_TotalDataStatisticsObjLst.find(x => x.week == i);
                            if (ChildarrvSysCommentObjLst == null) {
                                strWeek += '"第' + i + '周",';
                                strNum += "0" + ',';
                            }
                            else {
                                strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                                strNum += ChildarrvSysCommentObjLst.memo + ',';
                            }
                        }
                        strWeek = strWeek.substr(0, strWeek.length - 1);
                        strNum = strNum.substr(0, strNum.length - 1);
                        strWeek += "]";
                        strNum += "]";
                        var strLabelsJson = eval(strWeek);
                        var strDatasetsJson = eval(strNum);
                        Canvas1(strLabelsJson, strDatasetsJson);
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        alert(strMsg);
                    }
                }
                else {
                    var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                    alert(strMsg);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //获取教学班周教师打分平均分
        async BindGv_AVGTeaScore(strid_CurrEdu, Number, strUserIdorCurrEduClsId) {
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            var arrvgs_TotalDataStatisticsObjLst = [];
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            //var objvgs_TotalDataStatistics_Cond = this.CombineConditionObj1(strId_CurrEduCls);
            //var strWhereCond = JSON.stringify(objvgs_TotalDataStatistics_Sim);
            try {
                //const responseText = await vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("1-0");
                });
                //教学班
                //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
                //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
                //if (objgs_TeachingDateEN != null) {
                //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                //    //计算出相差天数
                //    var days = Math.floor(duration / (24 * 3600 * 1000));
                //    //天数除以7得到周；
                //    var WeekNum = Math.ceil(days / 7);
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                        //var strcolor = this.getRandomColor();
                        var strWeek = "[";
                        var strNum = "[";
                        var strColor = "[";
                        for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                            strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
                            strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
                            strColor += '"' + this.getRandomColor() + '",';
                        }
                        strWeek = strWeek.substr(0, strWeek.length - 1);
                        strNum = strNum.substr(0, strNum.length - 1);
                        strColor = strColor.substr(0, strColor.length - 1);
                        strWeek += "]";
                        strNum += "]";
                        strColor += "]";
                        var strLabelsJson = eval(strWeek);
                        var strDatasetsJson = eval(strNum);
                        var strColorJson = eval(strColor);
                        Canvas4(strLabelsJson, strDatasetsJson, strColorJson, Number, strUserIdorCurrEduClsId);
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        alert(strMsg);
                    }
                }
                else {
                    var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                    alert(strMsg);
                }
                //}
                //else {
                //    var strMsg: string = `当前教学班没有设置时间范围`;
                //console.error(strMsg);
                //    alert(strMsg);
                //}
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定教学班统计
        async BindGv_TeaClassNum(strid_CurrEdu, Number, strUserIdorCurrEduClsId) {
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            //var objvgs_TotalDataStatistics_Cond = this.CombineConditionObj1(strId_CurrEduCls);
            //var strWhereCond = JSON.stringify(objvgs_TotalDataStatistics_Sim);
            var arrvgs_TotalDataStatisticsObjLst = [];
            try {
                //const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("1-0");
                });
                ////教学班
                //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
                //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
                //if (objgs_TeachingDateEN != null) {
                //    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                //    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                //    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                //    //计算出相差天数
                //    var days = Math.floor(duration / (24 * 3600 * 1000));
                //    //天数除以7得到周；
                //    var WeekNum = Math.ceil(days / 7);
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    if (arrvgs_TotalDataStatisticsObjLst.length > 0) {
                        //var strcolor = this.getRandomColor();
                        var strWeek = "[";
                        var strNum = "[";
                        var strColor = "[";
                        //for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
                        //    strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
                        //    strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
                        //    strColor += '"' + this.getRandomColor() + '",';
                        //}
                        for (var i = 1; i <= WeekNum; i++) {
                            //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                            //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                            var ChildarrvSysCommentObjLst = arrvgs_TotalDataStatisticsObjLst.find(x => x.week == i);
                            if (ChildarrvSysCommentObjLst == null) {
                                strWeek += '"第' + i + '周",';
                                strNum += "0" + ',';
                                strColor += '"' + this.getRandomColor() + '",';
                            }
                            else {
                                strWeek += '"第' + ChildarrvSysCommentObjLst.week + '周",';
                                strNum += ChildarrvSysCommentObjLst.memo + ',';
                                strColor += '"' + this.getRandomColor() + '",';
                            }
                        }
                        strWeek = strWeek.substr(0, strWeek.length - 1);
                        strNum = strNum.substr(0, strNum.length - 1);
                        strColor = strColor.substr(0, strColor.length - 1);
                        strWeek += "]";
                        strNum += "]";
                        strColor += "]";
                        var strLabelsJson = eval(strWeek);
                        var strDatasetsJson = eval(strNum);
                        var strColorJson = eval(strColor);
                        Canvas2(strLabelsJson, strDatasetsJson, strColorJson, Number, strUserIdorCurrEduClsId);
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        console.error(strMsg);
                        alert(strMsg);
                    }
                }
                else {
                    var strMsg = `当前教学班没有设置时间范围`;
                    console.error(strMsg);
                    alert(strMsg);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        ////得到教学班平均分统计
        //public async  TeaClassAverage() {
        //    var strWhereCond = await this.CombineCondition1();
        //    var arrvgs_TotalDataStatisticsObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
        //    try {
        //        const responseText = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
        //            arrvgs_TotalDataStatisticsObjLst = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
        //            console.log("1-0");
        //        });
        //        //var strcolor = this.getRandomColor();
        //        var strWeek: string = "[";
        //        var strNum: string = "[";
        //        var strColor: string = "[";
        //        for (var i = 0; i < arrvgs_TotalDataStatisticsObjLst.length; i++) {
        //            strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst[i].week + '周",';
        //            strNum += arrvgs_TotalDataStatisticsObjLst[i].memo + ',';
        //            strColor += '"' + this.getRandomColor() + '",';
        //        }
        //        strWeek = strWeek.substr(0, strWeek.length - 1);
        //        strNum = strNum.substr(0, strNum.length - 1);
        //        strColor = strColor.substr(0, strColor.length - 1);
        //        strWeek += "]";
        //        strNum += "]";
        //        strColor += "]";
        //        var strLabelsJson = eval(strWeek);
        //        var strDatasetsJson = eval(strNum);
        //        var strColorJson = eval(strColor);
        //        Canvas2(strLabelsJson, strDatasetsJson, strColorJson);
        //    }
        //    catch (e) {
        //        console.error('catch(e)=');
        //        console.error(e);
        //        var strMsg: string = `根据条件获取相应的记录对象的列表不成功,${e}.`;
        //        alert(strMsg);
        //    }
        //}
        //绑定所有学生数据统计
        async BindGv_TotalDataNum(strid_CurrEdu, Number, strUserIdorCurrEduClsId) {
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            var arrvgs_TotalDataStatisticsObjLst1 = [];
            //var arrvgs_TotalDataStatisticsObjLst2: Array<clsvgs_TotalDataStatisticsEN> = [];
            var arrvgs_TotalDataStatisticsObjLst3 = [];
            //临时
            var arrvgs_TotalDataStatisticsObjLst4 = [];
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            //var objvgs_TotalDataStatistics_Cond = this.CombineConditionObj1(strId_CurrEduCls);
            //var strWhere_Cond = JSON.stringify(objvgs_TotalDataStatistics_Sim);
            try {
                //用户
                //const responseText1 = await vgs_TotalDataStatisticsEx_GetUserNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
                const responseText1 = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst1 = jsonData;
                    console.log("3-1");
                });
                //周
                //const responseText2 = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrvgs_TotalDataStatisticsObjLst2 = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                //    console.log("3-2");
                //});
                //用户、周
                // const responseText3 = await vgs_TotalDataStatisticsEx_GetUser_WeekNumSubObjLst_Cache(objvgs_TotalDataStatistics_Cond, strId_CurrEduCls).then((jsonData) => {
                const responseText3 = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst3 = jsonData;
                    console.log("3-3");
                });
                //教学班
                //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
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
                var strId_CurrEduCls = "";
                if (strid_CurrEdu == "") {
                    strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                }
                else {
                    strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
                }
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                    /*********************************周列表*********************************/
                    var strWeek = "[";
                    //for (var j = 0; j < arrvgs_TotalDataStatisticsObjLst2.length; j++) {
                    //    strWeek += '"第' + arrvgs_TotalDataStatisticsObjLst2[j].week + '周",';
                    //}
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
                    if (arrvgs_TotalDataStatisticsObjLst1.length > 0) {
                        /******************************************************************/
                        //var spanUserName1 = '<span style="font-weight: 500;"><i class="fa fa-square" style="color:'
                        //var spanUserName2 = ';font-size: 20px; padding-right: 5px; vertical-align: middle; margin-top: -3px;"></i>'
                        //var spanUserName3 = '</span>'
                        //var strHtml = "";
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
                        Canvas3(strLabelsJson, strDatasetsJson, Number, strUserIdorCurrEduClsId);
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        console.error(strMsg);
                        alert(strMsg);
                    }
                }
                else {
                    var strMsg = `当前教学班没有设置时间范围`;
                    console.error(strMsg);
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
        //绑定教学班周评论统计
        async BindChart_TeaClassComment(strid_CurrEdu, Number, strUserIdorCurrEduClsId) {
            //var strWhereCond = await this.CombineCondition3();
            var objclsSysComment_Cond = this.CombineConditionObj3(strid_CurrEdu);
            var strWhereCond = JSON.stringify(objclsSysComment_Cond);
            var arrSysCommentObjLst0 = [];
            var arrSysCommentObjLst = [];
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            try {
                const responseText = await (0, clsSysCommentWApi_js_1.SysComment_GetSubObjLst_Cache)(objclsSysComment_Cond, strId_CurrEduCls).then((jsonData) => {
                    //const responseText = await SysComment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrSysCommentObjLst0 = jsonData;
                    console.log("5-0");
                });
                //教学班
                //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                //var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                //const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
                //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText1;
                //if (objgs_TeachingDateEN != null) {
                //var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                //var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                //var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                ////计算出相差天数
                //var days = Math.floor(duration / (24 * 3600 * 1000));
                ////天数除以7得到周；
                //var WeekNum = Math.ceil(days / 7);
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    if (arrSysCommentObjLst0.length > 0) {
                        var strWeek = "[";
                        var strNum = "[";
                        var strColor = "[";
                        for (var i = 1; i <= WeekNum; i++) {
                            //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                            //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                            arrSysCommentObjLst = arrSysCommentObjLst0.filter(x => x.week == i);
                            strWeek += '"第' + i + '周",';
                            strNum += arrSysCommentObjLst.length + ',';
                            strColor += '"' + this.getRandomColor() + '",';
                        }
                        strWeek = strWeek.substr(0, strWeek.length - 1);
                        strNum = strNum.substr(0, strNum.length - 1);
                        strColor = strColor.substr(0, strColor.length - 1);
                        strWeek += "]";
                        strNum += "]";
                        strColor += "]";
                        var strLabelsJson = eval(strWeek);
                        var strDatasetsJson = eval(strNum);
                        var strColorJson = eval(strColor);
                        Canvas5(strLabelsJson, strDatasetsJson, strColorJson, Number, strUserIdorCurrEduClsId);
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        alert(strMsg);
                    }
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定当前教学班用户周期评论数据
        async BindChart_UserCommentNum(strid_CurrEdu, Number, strUserIdorCurrEduClsId) {
            //var strWhereCond = await this.CombineCondition3(strid_CurrEdu);
            var objclsSysComment_Cond = this.CombineConditionObj3(strid_CurrEdu);
            var strWhereCond = JSON.stringify(objclsSysComment_Cond);
            // var strWhereCond2 = this.CombineCondition2(strid_CurrEdu);
            var objclsvCurrEduClsStu_Cond = this.CombineConditionObj2(strid_CurrEdu);
            var strWhereCond = JSON.stringify(objclsvCurrEduClsStu_Cond);
            var arrSysCommentObjLst0 = [];
            var arrSysCommentObjLst1 = [];
            var arrSysCommentObjLst2 = [];
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            try {
                //var strWhereCond2 = " id_CurrEduCls='" + clsPublocalStorage.id_CurrEduCls + "' order by stuName Asc";
                var arrCurrEduClsUserObjLst = await (0, clsvCurrEduClsStuWApi_js_1.vCurrEduClsStu_GetSubObjLst_Cache)(objclsvCurrEduClsStu_Cond, strId_CurrEduCls);
                //var arrCurrEduClsUserObjLst: Array<clsvCurrEduClsStuEN> = await vCurrEduClsStu_GetObjLstAsync(strWhereCond2);
                console.log("6-1");
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                console.log("6-2");
                const responseText = await (0, clsSysCommentWApi_js_1.SysComment_GetSubObjLst_Cache)(objclsSysComment_Cond, strId_CurrEduCls).then((jsonData) => {
                    //const responseText = await SysComment_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrSysCommentObjLst0 = jsonData;
                    console.log("6-3");
                });
                //var strId_CurrEduCls: string = "";
                //if (strid_CurrEdu == "") {
                //    strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
                //}
                //else {
                //    strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
                //}
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    /*********************************周列表*********************************/
                    var strWeek = "[";
                    for (var j = 1; j <= WeekNum; j++) {
                        strWeek += '"第' + j + '周",';
                    }
                    strWeek = strWeek.substr(0, strWeek.length - 1);
                    strWeek += "]";
                    var strLabelsJson = eval(strWeek);
                    /************************************用户和评论数******************************/
                    var strNum = "[";
                    for (var i = 0; i < arrCurrEduClsUserObjLst.length; i++) {
                        //获取色码
                        var strcolor = this.getRandomColor();
                        strNum += "{ label: \"" + arrCurrEduClsUserObjLst[i].stuName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                        arrSysCommentObjLst1 = arrSysCommentObjLst0.filter(x => x.updUser == arrCurrEduClsUserObjLst[i].stuID);
                        for (var j = 1; j <= WeekNum; j++) {
                            arrSysCommentObjLst2 = arrSysCommentObjLst1.filter(x => x.week == j);
                            strNum += arrSysCommentObjLst2.length + ',';
                        }
                        strNum = strNum.substr(0, strNum.length - 1);
                        strNum += "]},";
                    }
                    strNum = strNum.substr(0, strNum.length - 1);
                    strNum += "]";
                    var strDatasetsJson = eval(strNum);
                    Canvas6(strLabelsJson, strDatasetsJson, Number, strUserIdorCurrEduClsId);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        CombineConditionObjgs_AnswerCount(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            var objgs_AnswerCount_Cond = new clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN();
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                try {
                    if (this.StartDate_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.StartDate_q, ">=");
                    }
                    if (this.EndDate_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    //管理员
                    //if ($("#hidQueryStata").val() == "1") {
                    if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                        if (this.userId_q != "" && this.userId_q != "0") {
                            // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                            objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                        }
                        if (this.TopicId_q != "0" && this.TopicId_q != "") {
                            //  strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                            objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                        }
                    }
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            return objgs_AnswerCount_Cond;
        }
        CombineConditiongs_AnswerCountObj1(strid_CurrEdu) {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            var objgs_AnswerCount_Cond = new clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN();
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                try {
                    if (this.StartDate_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} >= '${this.StartDate_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.StartDate_q, ">=");
                    }
                    if (this.EndDate_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataAddDate} <= '${this.EndDate_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                        // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                        objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                    }
                    //管理员
                    //if ($("#hidQueryStata").val() == "1") {
                    if ($("#hidQueryStata").val() == "3" || $("#hidQueryStata").val() == "7") {
                        if (this.userId_q != "" && this.userId_q != "0") {
                            // strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.userId_q}'`;
                            objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                        }
                        if (this.TopicId_q != "0" && this.TopicId_q != "") {
                            //  strWhereCond += ` And ${clsgs_AnswerCountEN.con_TopicId} = '${this.TopicId_q}'`;
                            objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, this.EndDate_q, "<=");
                        }
                    }
                }
                catch (objException) {
                    var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                    throw strMsg;
                }
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            objgs_AnswerCount_Cond.SetCondFldValue(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls, strId_CurrEduCls, "=");
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            return objgs_AnswerCount_Cond;
        }
        //绑定当前教学班用户讨论回答统计数据
        async BindChart_UserDiscussNum(strid_CurrEdu, Number, strUserIdorCurrEduClsId) {
            var strWhereCond = await this.CombineCondition1(strid_CurrEdu);
            //var strWhereCond = await this.CombineConditionObj1(strid_CurrEdu);
            var strId_CurrEduCls = "";
            if (strid_CurrEdu == "") {
                strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strId_CurrEduCls = strid_CurrEdu; //传递过来教学班参数；
            }
            //var objgs_AnswerCount1_Cond = this.CombineConditiongs_AnswerCountObj1(strId_CurrEduCls);
            //var strWhere_Cond = JSON.stringify(objgs_AnswerCount_Sim);
            var objgs_AnswerCount_Cond = this.CombineConditionObjgs_AnswerCount(strid_CurrEdu);
            var strWhereCond1 = JSON.stringify(objgs_AnswerCount_Cond);
            var arrgs_AnswerCountUserNum = [];
            //var arrgs_AnswerCountObjLst2: Array<clsgs_AnswerCountEN> = [];
            var arrgs_AnswerCountObjLst1 = [];
            //临时
            var arrgs_AnswerCountObjLst2 = [];
            var arrgs_AnswerCountObjLst3 = [];
            //var strId_CurrEduCls: string = "";
            //if (strid_CurrEdu == "") {
            //    strId_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //}
            //else {
            //    strId_CurrEduCls = strid_CurrEdu;//传递过来教学班参数；
            //}
            try {
                //用户
                //const responseText1 = await gs_AnswerCountEx_GetSubObjLst_Cache(objgs_AnswerCount1_Cond, strId_CurrEduCls).then((jsonData) => {
                const responseText1 = await (0, clsgs_AnswerCountExWApi_js_1.gs_AnswerCountEx_GetAnswerCountNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_AnswerCountUserNum = jsonData;
                    console.log("3-1");
                });
                //用户、周
                const responseText3 = await (0, clsgs_AnswerCountWApi_js_1.gs_AnswerCount_GetSubObjLst_Cache)(objgs_AnswerCount_Cond, strId_CurrEduCls).then((jsonData) => {
                    //const responseText3 = await gs_AnswerCount_GetObjLstAsync(strWhereCond).then((jsonData) => {
                    arrgs_AnswerCountObjLst1 = jsonData;
                    console.log("3-3");
                });
                //教学班
                var WeekNum = await this.GetTeachingDateWeek(strId_CurrEduCls);
                if (WeekNum != 0) {
                    var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
                    /*********************************周列表*********************************/
                    var strWeek = "[";
                    //for (var j = 0; j < arrgs_AnswerCountObjLst2.length; j++) {
                    //    strWeek += '"第' + arrgs_AnswerCountObjLst2[j].week + '周",';
                    //}
                    for (var j = 1; j <= WeekNum; j++) {
                        //判断是否存在对等的周数据 ，存在则从列表中取，否则为0；
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        //var ChildarrvSysCommentObjLst = arrgs_AnswerCountObjLst2.find(x => x.week == i);
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
                    if (arrgs_AnswerCountUserNum.length > 0) {
                        /******************************************************************/
                        //var spanUserName1 = '<span style="font-weight: 500;"><i class="fa fa-square" style="color:'
                        //var spanUserName2 = ';font-size: 20px; padding-right: 5px; vertical-align: middle; margin-top: -3px;"></i>'
                        //var spanUserName3 = '</span>'
                        //var strHtml = "";
                        var strNum = "[";
                        for (var i = 0; i < arrgs_AnswerCountUserNum.length; i++) {
                            //获取色码
                            var strcolor = this.getRandomColor();
                            //var objUser = arrUsers.find(x => x.userId == arrgs_AnswerCountUserNum[i].dataUser);
                            //if (objUser != null) {
                            //strHtml += spanUserName1 + strcolor + spanUserName2 + objUser.userName + spanUserName3;
                            //strNum += "{ label: \"" + objUser.userName + "\",fillColor: \"rgba(220,220,220, 0.01)\",strokeColor: \"" + strcolor + "\",pointColor: \"" + strcolor + "\",pointStrokeColor: \"#fff\",pointHighlightFill: \"#fff\",pointHighlightStroke: \"" + strcolor + "\",data: [";
                            strNum += "{ label: \"" + arrgs_AnswerCountUserNum[i].userName + "\",backgroundColor: \"" + strcolor + "\",borderColor: \"" + strcolor + "\",fill: false,data: [";
                            arrgs_AnswerCountObjLst2 = arrgs_AnswerCountObjLst1.filter(x => x.dataUser == arrgs_AnswerCountUserNum[i].dataUser);
                            //for (var j = 0; j < arrgs_AnswerCountObjLst2.length; j++) {
                            for (var j = 1; j <= WeekNum; j++) {
                                if (arrgs_AnswerCountObjLst2.length > 0) {
                                    arrgs_AnswerCountObjLst3 = arrgs_AnswerCountObjLst2.filter(x => x.week == j);
                                    if (arrgs_AnswerCountObjLst3.length > 0) {
                                        strNum += arrgs_AnswerCountObjLst3.length + ',';
                                    }
                                    else {
                                        strNum += '0,';
                                    }
                                    //var objWeek = arrgs_AnswerCountObjLst4.find(x => x.week == arrgs_AnswerCountObjLst2[j].week);
                                    //var objWeek = arrgs_AnswerCountObjLst4.find(x => x.week == j);
                                    //if (objWeek != null) {
                                    //    strNum += objWeek.memo + ',';
                                    //}
                                    //else {
                                    //    strNum += '0,';
                                    //}
                                }
                                else {
                                    strNum += '0,';
                                }
                            }
                            strNum = strNum.substr(0, strNum.length - 1);
                            strNum += "]},";
                            //}
                        }
                        strNum = strNum.substr(0, strNum.length - 1);
                        strNum += "]";
                        var strDatasetsJson = eval(strNum);
                        Canvas7(strLabelsJson, strDatasetsJson, Number, strUserIdorCurrEduClsId);
                    }
                    else {
                        var strMsg = `当前无数据,请选择其他条件或切换教学班`;
                        console.error(strMsg);
                        alert(strMsg);
                    }
                }
                else {
                    var strMsg = `当前教学班没有设置时间范围`;
                    console.error(strMsg);
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
        //用户统计列表
        async BindGv_UserDiscussNumTable() {
            var strId_CurrEduCls = "";
            var strWhereCond = await this.CombineCondition1(strId_CurrEduCls);
            var arrgs_AnswerCountUserNum = [];
            var arrgs_WeekAnswerCountUserNum = [];
            var arrgs_AnswerCountObjLst1 = [];
            //临时
            var arrgs_AnswerCountObjLst2 = [];
            var arrgs_AnswerCountObjLst3 = [];
            try {
                //用户
                //const responseText1 = await gs_AnswerCountEx_GetAnswerCountNumObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrgs_AnswerCountUserNum = <Array<clsgs_AnswerCountEN>>jsonData;
                //    console.log("7-1");
                //});
                //周
                const responseText2 = await (0, clsgs_AnswerCountExWApi_js_1.gs_AnswerCountEx_GetWeekAnswerCountNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrgs_WeekAnswerCountUserNum = jsonData;
                    console.log("7-1");
                });
                //用户、周
                //const responseText3 = await gs_AnswerCount_GetObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrgs_AnswerCountObjLst1 = <Array<clsgs_AnswerCountEN>>jsonData;
                //    console.log("7-3");
                //});
                var strhtml = "";
                var cateid = 0;
                var cateid_ = 0;
                if ($("#hidQueryStata").val() == "1") {
                    $('#tbListUserNum tr').remove();
                }
                else {
                    $('#tbListTeaClassNum tr').remove();
                }
                if (arrgs_WeekAnswerCountUserNum.length > 0) {
                    //得到数据源循环数据
                    for (var i = 0; i < arrgs_WeekAnswerCountUserNum.length; i++) {
                        cateid++;
                        // intJ++;
                        var fid = 0;
                        //周；
                        var strWeek = arrgs_WeekAnswerCountUserNum[i].week;
                        //周日期范围
                        var strWeekTimeFrame = arrgs_WeekAnswerCountUserNum[i].weekTimeRange;
                        //记录数
                        var strNum = arrgs_WeekAnswerCountUserNum[i].memo;
                        //从详细数据中过滤 通过当前周作为条件；把数据存放到某一个类型观点详细；
                        //ChildarrvSysCommentObjLst = arrvgs_TotalDetailObjLst.filter(x => x.week == strWeek);
                        strhtml += '<tr cate-id="' + cateid + '" fid="' + fid + '">';
                        //周
                        strhtml += '<td>' + strWeek + '</td>';
                        //周日期范围
                        strhtml += '<td>' + strWeekTimeFrame + '</td>';
                        strhtml += '<td><i class="layui-icon x-show" status="true"></i>' + strNum + '</td>';
                        //结束
                        strhtml += '</tr>';
                        ////父节点转化
                        //cateid_ = cateid;
                        ////子数据
                        //if (ChildarrvSysCommentObjLst.length > 0) {
                        //    //因为有10个数据类型；需要分别判断读取，如果有数据则执行输出，没有则跳过；
                        //    // 01	论文02	论文读写03	论文子观点04	个人观05	专家观点06	主题概念 07	客观事实08	客观数据09	技能10	社会关系
                        //    //循环统计类型；
                        //    for (var k = 0; k < gs_TotalDataTypeObjLst.length; k++) {
                        //        var strTypeId = gs_TotalDataTypeObjLst[k].totalDataTypeId;
                        //        var DetailTypeObjLst = ChildarrvSysCommentObjLst.filter(x => x.totalDataTypeId == strTypeId);
                        //        //如果大于0 ，说明有此类型数据，需要输出；
                        //        if (DetailTypeObjLst.length > 0) {
                        //            for (var j = 0; j < DetailTypeObjLst.length; j++) {
                        //                cateid++;
                        //                strhtml += '<tr cate-id="' + cateid + '" fid="' + cateid_ + '" style="display:none;">';
                        //                //周
                        //                strhtml += '<td>' + strWeek + '</td>';
                        //                //周日期范围
                        //                strhtml += '<td>' + strWeekTimeFrame + '</td>';
                        //                strhtml += '<td>' + DetailTypeObjLst[j].totalDataTypeName + '[' + DetailTypeObjLst.length + ']</td>';
                        //                strhtml += '</tr>';
                        //                //因为统计一个类型数据量，所以直接break；
                        //                break;
                        //            }
                        //        }
                        //    }
                        //}
                    }
                }
                $("#tbListUserDiscussNum").html(strhtml);
                //tbody();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取用户统计数据不成功,${e}.`;
                alert(strMsg);
            }
        }
        //获取教学班的时间得到周数
        async GetTeachingDateWeek(strId_CurrEduCls) {
            var strid_CurrEduCls = "";
            if (strId_CurrEduCls == "") {
                strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
            }
            else {
                strid_CurrEduCls = strId_CurrEduCls;
            }
            //教学班
            //var strid_CurrEduCls = clsPublocalStorage.id_CurrEduCls;
            //    var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
            const arrgs_TeachingDateObjLst = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetObjLst_Cache)(strid_CurrEduCls);
            if (arrgs_TeachingDateObjLst.length > 0) {
                console.log("获取教学班日期成功");
            }
            //通过教学班得到教学班时间范围；、
            // const responseText1 = await gs_TeachingDate_GetFirstObjAsync(strWhereCond);
            var objgs_TeachingDateEN = arrgs_TeachingDateObjLst.find(x => x.id_CurrEduCls == strid_CurrEduCls);
            //const responseText5 = await gs_TeachingDate_GetFirstObjAsync(strWhereEduCls);
            //var objgs_TeachingDateEN: clsgs_TeachingDateEN = <clsgs_TeachingDateEN>responseText5;
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
        //获取不同色码
        getRandomColor() {
            return '#' + ('00000' + (Math.random() * 0x1000000 << 0).toString(16)).substr(-6);
        }
        /*
       * 起始时间
      */
        get StartDate_q() {
            return $("#txtStartDate_q").val();
        }
        /*
        * 起始时间
       */
        set StartDate_q(value) {
            $("#txtStartDate_q").val(value);
        }
        /*
       * 结束时间
      */
        get EndDate_q() {
            return $("#txtEndDate_q").val();
        }
        /*
        * 结束时间
       */
        set EndDate_q(value) {
            $("#txtEndDate_q").val(value);
        }
        /*
       * 用户
      */
        get userId_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 用户
       */
        set userId_q(value) {
            $("#ddlUserId_q").val(value);
        }
        /*
      * 数据类型
     */
        get TotalDataTypeId_q() {
            return $("#ddlTotalDataTypeId_q").val();
        }
        /*
        * 数据类型
       */
        set TotalDataTypeId_q(value) {
            $("#ddlTotalDataTypeId_q").val(value);
        }
        /*
        * 是否推荐
       */
        set isRecommend(value) {
            $("#chkIsRecommend").val(value);
        }
        /*
        * 是否推荐
       */
        get isRecommend() {
            return $("#chkIsRecommend").prop("checked");
        }
        /*
     * 主题
    */
        get TopicId_q() {
            return $("#ddlTopicId_q").val();
        }
        /*
        * 主题
       */
        set TopicId_q(value) {
            $("#ddlTopicId_q").val(value);
        }
    }
    exports.TotalDataStatisticsEx = TotalDataStatisticsEx;
});
