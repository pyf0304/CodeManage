(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsDropDownList.js", "../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js", "../TS/L0_Entity/UserManage/clsvUsersSimEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js", "../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js", "./gs_TeachingDate_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TotalDataStatisticsTest = void 0;
    const clsDropDownList_js_1 = require("../TS/FunClass/clsDropDownList.js");
    const clsvgs_TotalDataStatisticsEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvgs_TotalDataStatisticsEN.js");
    const clsvUsersSimEN_js_1 = require("../TS/L0_Entity/UserManage/clsvUsersSimEN.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsgs_TotalDataTypeWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TotalDataTypeWApi.js");
    const clsvgs_TotalDataStatisticsWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsvgs_TotalDataStatisticsWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage/clsvUsersSimWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsvgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsvgs_TotalDataStatisticsExWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const gs_TeachingDate_EditEx_js_1 = require("./gs_TeachingDate_EditEx.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class TotalDataStatisticsTest {
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
            this.bindAllData();
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
                if (clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() != "") {
                    //$("#hidUserId").val(clsPubSessionStorage.GetSession_UserId());
                    //$("#hidRoleId").val(clsPubSessionStorage.GetSession_RoleId());
                    //1、从教学班表内获取当前教学班学生
                    const ddl_UserId_q = await clsDropDownList_js_1.clsDropDownList.BindDdl_CurrEduClsStuUser("ddlUserId_q");
                    //const ddl_UserId_q = await this.BindDdl_UserName("ddlUserId_q");
                    const ddl_TotalDataTypeId_q = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache)("", "ddlTotalDataTypeId_q");
                    $("#hidId_CurrEduCls").val(clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                    //const gvResult = await this.BindGv_vTotalDataStatistics();
                    //tbody();
                    //$(this).val($(this).find("option:first-child").val()).trigger('change')
                    //$("#sex").find("option[value='男']").attr("selected", true);
                    //$("select").find("option:first").prop("selected", true);
                    //$('selector').find('option:eq(1)').attr('selected', 'selected');
                    if (this.UserId_q != "" && this.UserId_q != "0") {
                        // const gvResult1 = await this.BindGv_UserNum();
                    }
                    else {
                        //默认显示第3个；参数可以变换；
                        $('#ddlUserId_q').prop('selectedIndex', 2);
                    }
                    //const gvResult2 = await this.BindGv_TeaClassNum();
                    //const gvResult3 = await this.BindGv_TotalDataNum();
                    //const gvResult = await this.BindGv_TotalDataNum();
                    //获取教学班时间范围
                    const gvResult = await this.GetEduDataRandge();
                    //默认显示数据
                    const gvResult1 = await this.bindAllData();
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
            var strWhereCond = " id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            var objDdl = document.getElementById(ddlUserId_q);
            if (objDdl == null) {
                var strMsg = `下拉框：${ddlUserId_q} 不存在！`;
                alert(strMsg);
                throw (strMsg);
            }
            try {
                var arrObjLst_Sel = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUserNumObjLstAsync)(strWhereCond);
                //arrvclsvTopicObjectiveEN = arrvObjList.filter(x => x.objectiveType == "02");//客观数据；
                var arrUserId_Set = new Set(arrObjLst_Sel.map(x => x.updUser));
                console.log(arrUserId_Set);
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
                var arrUsersList_Sel = arrUsers.filter(x => arrUserId_Set.has(x.userId));
                console.log(arrUsersList_Sel);
                arrUsersList_Sel = arrUsersList_Sel.sort(x => x[clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName]);
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId_q, arrUsersList_Sel, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserId, clsvUsersSimEN_js_1.clsvUsersSimEN.con_UserName, "教学班用户");
                //arrObjLst_Sel = arrObjLst_Sel.sort(x => x[clsvgs_TotalDataStatisticsEN.con_UpdUser]);
                //clsCommonFunc4Web.BindDdl_ObjLst(ddlUserId_q, arrObjLst_Sel, clsvCurrEduClsStuEN.con_StuID, clsvCurrEduClsStuEN.con_StuName, "教学班学生");
                console.log("完成BindDdl_vCurrEduClsStuId!");
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //获取教学班时间范围
        async GetEduDataRandge() {
            var strWhereCond = " 1 = 1 and id_CurrEduCls=" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            //通过教学班得到教学班时间范围；、
            const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhereCond);
            var objgs_TeachingDateEN = responseText1;
            if (objgs_TeachingDateEN != null) {
                $("#hidStartDate").val(objgs_TeachingDateEN.startDate);
                $("#hiEndDate").val(objgs_TeachingDateEN.endDate);
            }
        }
        //设置教学班范围时间；
        async btnSetUpDateRecord_Click() {
            var objPage = new TotalDataStatisticsTest();
            var objPage_Edit = new gs_TeachingDate_EditEx_js_1.gs_TeachingDate_EditEx(objPage);
            var strKeyId = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
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
        async Bind_AllData() {
            const gvResult3 = await this.BindGv_TotalDataNum();
            const gvResult_3 = await this.BindGv_TotalDataNumTable();
            const gvResult1 = await this.BindGv_UserNum();
            const gvResult_1 = await this.BindGv_UserNumTable();
            const gvResult2 = await this.BindGv_TeaClassNum();
            const gvResult_2 = await this.BindGv_UserNumTable();
            const gvResult4 = await this.BindGv_AVGTeaScore();
            const gvResult_4 = await this.BindGv_TeaClassAverageTab();
        }
        async bindAllData() {
            if ($("#hidQueryStata").val() == "1") {
                if (this.UserId_q != "" && this.UserId_q != "0") {
                }
                else {
                    $('select').prop('selectedIndex', 1);
                }
                const gvResult = await this.BindGv_UserNum();
                const gvResult1 = await this.BindGv_UserNumTable();
            }
            else if ($("#hidQueryStata").val() == "2") {
                const gvResult = await this.BindGv_TeaClassNum();
                const gvResult1 = await this.BindGv_UserNumTable();
            }
            else if ($("#hidQueryStata").val() == "3") {
                const gvResult = await this.BindGv_TotalDataNum();
                const gvResult1 = await this.BindGv_TotalDataNumTable();
            }
            else {
                const gvResult = await this.BindGv_AVGTeaScore();
                const gvResult1 = await this.BindGv_TeaClassAverageTab();
            }
        }
        /* 查询
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async btnQuery_Click() {
            try {
                if ($("#hidQueryStata").val() == "1") {
                    if (this.UserId_q != "" && this.UserId_q != "0") {
                        const gvResult = await this.BindGv_UserNum();
                        const gvResult1 = await this.BindGv_UserNumTable();
                    }
                    else {
                        Alert2("请先选择用户并查询！");
                    }
                }
                else if ($("#hidQueryStata").val() == "2") {
                    const gvResult = await this.BindGv_TeaClassNum();
                    const gvResult1 = await this.BindGv_UserNumTable();
                }
                else if ($("#hidQueryStata").val() == "3") {
                    const gvResult = await this.BindGv_TotalDataNum();
                    const gvResult1 = await this.BindGv_TotalDataNumTable();
                }
                else {
                    const gvResult = await this.BindGv_AVGTeaScore();
                    const gvResult1 = await this.BindGv_TeaClassAverageTab();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //同步总数据统计
        async btnSynTotalDataStatistics_Click() {
            $("#divLoading").show();
            var strUserId = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
            var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            try {
                const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_IsExistRecordAsync)("id_CurrEduCls =" + strid_CurrEduCls);
                var returnBool1 = !!responseText1;
                if (returnBool1 == true) {
                    const responseText2 = await (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strid_CurrEduCls, strUserId);
                    var returnBool2 = !!responseText2;
                    if (returnBool2 == true) {
                        var strInfo = `同步数据成功!`;
                        //$('#lblResult46').val(strInfo);
                        //显示信息框
                        //Alert1(strInfo);
                        alert(strInfo);
                        $("#divLoading").hide();
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
        /* 用户统计
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async liUserNum_Click() {
            try {
                if (this.UserId_q != "" && this.UserId_q != "0") {
                    const gvResult1 = await this.BindGv_UserNum();
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
            var strWhereCond = this.CombineCondition1();
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
                //获取统计类型数据；
                const responseText2 = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLstAsync)("1=1").then((jsonData) => {
                    gs_TotalDataTypeObjLst = jsonData;
                    console.log("获取统计类型数据成功");
                });
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
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async liTeaClassNum_Click() {
            try {
                const gvResult = await this.BindGv_TeaClassNum();
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
                const gvResult = await this.BindGv_AVGTeaScore();
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
            var strWhereCond = this.CombineCondition1();
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
                //获取统计类型数据；
                const responseText2 = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLstAsync)("1=1").then((jsonData) => {
                    gs_TotalDataTypeObjLst = jsonData;
                    console.log("获取统计类型数据成功");
                });
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
                const gvResult = await this.BindGv_TotalDataNum();
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
            var strWhereCond = this.CombineCondition1();
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
                //获取统计类型数据；
                const responseText2 = await (0, clsgs_TotalDataTypeWApi_js_1.gs_TotalDataType_GetObjLstAsync)("1=1").then((jsonData) => {
                    gs_TotalDataTypeObjLst = jsonData;
                    console.log("获取统计类型数据成功");
                });
                var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
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
        CombineCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls() + "'";
            //通过教学班得到教学班时间范围；、
            if ($("#hidStartDate").val() != "" && $("#hiEndDate").val() != "") {
                var startDate = $("#hidStartDate").val();
                var endDate = $("#hiEndDate").val();
                strWhereCond += " And dataAddDate > '" + startDate + "' And dataAddDate < '" + endDate + "'";
            }
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (this.TotalDataTypeId_q != "0" && this.TotalDataTypeId_q != "") {
                    strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_TotalDataTypeId} = '${this.TotalDataTypeId_q}'`;
                }
                //管理员
                if ($("#hidQueryStata").val() == "1") {
                    if (this.UserId_q != "" && this.UserId_q != "0") {
                        strWhereCond += ` And ${clsvgs_TotalDataStatisticsEN_js_1.clsvgs_TotalDataStatisticsEN.con_DataUser} = '${this.UserId_q}'`;
                    }
                }
                //if ($("#hidRoleId").val() == "00620001") { }
                //教师
                //else if ($("#hidRoleId").val() == "00620002") {
                //    $("#td_UserId").hide();
                //    strWhereCond += " and dataUser='" + $("#hidUserId").val() + "'";
                //}
                ////学生
                //else {
                //    $("#td_UserId").hide();
                //    strWhereCond += " and dataUser='" + $("#hidUserId").val() + "'";
                //}
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //绑定学生数据统计
        async BindGv_UserNum() {
            var strWhereCond = this.CombineCondition1();
            var arrvgs_TotalDataStatisticsObjLst = [];
            // var ChildarrvSysCommentObjLst: Array<clsvgs_TotalDataStatisticsEN> = [];
            var arrgs_TeachingDateENObjLst;
            try {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("1-0");
                });
                //教学班
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhereEduCls);
                var objgs_TeachingDateEN = responseText1;
                if (objgs_TeachingDateEN != null) {
                    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                    //计算出相差天数
                    var days = Math.floor(duration / (24 * 3600 * 1000));
                    //天数除以7得到周；
                    var WeekNum = Math.ceil(days / 7);
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
        async BindGv_AVGTeaScore() {
            var strWhereCond = this.CombineCondition1();
            var arrvgs_TotalDataStatisticsObjLst = [];
            try {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekAVGTeaScoreObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("1-0");
                });
                //教学班
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhereEduCls);
                var objgs_TeachingDateEN = responseText1;
                if (objgs_TeachingDateEN != null) {
                    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                    //计算出相差天数
                    var days = Math.floor(duration / (24 * 3600 * 1000));
                    //天数除以7得到周；
                    var WeekNum = Math.ceil(days / 7);
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
                        Canvas4(strLabelsJson, strDatasetsJson, strColorJson);
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
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //绑定教学班统计
        async BindGv_TeaClassNum() {
            var strWhereCond = this.CombineCondition1();
            var arrvgs_TotalDataStatisticsObjLst = [];
            try {
                const responseText = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst = jsonData;
                    console.log("1-0");
                });
                //教学班
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                const responseText1 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhereEduCls);
                var objgs_TeachingDateEN = responseText1;
                if (objgs_TeachingDateEN != null) {
                    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                    //计算出相差天数
                    var days = Math.floor(duration / (24 * 3600 * 1000));
                    //天数除以7得到周；
                    var WeekNum = Math.ceil(days / 7);
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
                        Canvas2(strLabelsJson, strDatasetsJson, strColorJson);
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
        //    var strWhereCond = this.CombineCondition1();
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
                //周
                //const responseText2 = await vgs_TotalDataStatisticsEx_GetWeekNumObjLstAsync(strWhereCond).then((jsonData) => {
                //    arrvgs_TotalDataStatisticsObjLst2 = <Array<clsvgs_TotalDataStatisticsEN>>jsonData;
                //    console.log("3-2");
                //});
                //用户、周
                const responseText3 = await (0, clsvgs_TotalDataStatisticsExWApi_js_1.vgs_TotalDataStatisticsEx_GetUser_WeekNumObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrvgs_TotalDataStatisticsObjLst3 = jsonData;
                    console.log("3-3");
                });
                //教学班
                var strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
                var strWhereEduCls = " 1 = 1 And id_CurrEduCls = '" + strid_CurrEduCls + "'";
                const responseText5 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetFirstObjAsync)(strWhereEduCls);
                var objgs_TeachingDateEN = responseText5;
                if (objgs_TeachingDateEN != null) {
                    var eventStartTime = new Date(objgs_TeachingDateEN.startDate);
                    var eventEndTime = new Date(objgs_TeachingDateEN.endDate);
                    var duration = eventEndTime.valueOf() - eventStartTime.valueOf();
                    //计算出相差天数
                    var days = Math.floor(duration / (24 * 3600 * 1000));
                    //天数除以7得到周；
                    var WeekNum = Math.ceil(days / 7);
                    var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)();
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
                        Canvas3(strLabelsJson, strDatasetsJson);
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
        get UserId_q() {
            return $("#ddlUserId_q").val();
        }
        /*
        * 用户
       */
        set UserId_q(value) {
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
    }
    exports.TotalDataStatisticsTest = TotalDataStatisticsTest;
});
