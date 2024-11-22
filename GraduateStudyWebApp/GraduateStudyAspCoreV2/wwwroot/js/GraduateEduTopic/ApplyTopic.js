(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTools/sys_RequestPushCRUD.js", "../TS/FunClass_Share/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js", "../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js", "../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvResearchTopicWApi.js", "../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsOperateList.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js", "../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ApplyTopic = void 0;
    const sys_RequestPushCRUD_js_1 = require("../PagesBase/GraduateEduTools/sys_RequestPushCRUD.js");
    const clsPubFun4Web_js_1 = require("../TS/FunClass_Share/clsPubFun4Web.js");
    const clsPaperReadWriteEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clssys_RequestPushEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js");
    const clsRTUserRelaEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsRTUserRelaEN.js");
    const clsvResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvResearchTopicEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clssys_RequestPushWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clsResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsResearchTopicWApi.js");
    const clsRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsRTUserRelaWApi.js");
    const clsvResearchTopicWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvResearchTopicWApi.js");
    const clsgs_ColorWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsgs_ColorWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsOperateList_js_1 = require("../TS/PubFun/clsOperateList.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    /* PaperSubViewpoint_QUDI_TSEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class ApplyTopic extends sys_RequestPushCRUD_js_1.sys_RequestPushCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvPaperSubViewpointBy: string = "subViewpointId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 50;
        }
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //1、为下拉框设置数据源,绑定列表数据
                if (clsPublocalStorage_js_1.clsPublocalStorage.userId != "") {
                    this.hidSortBy = "updDate Desc";
                    //绑定主题
                    const gvResult1 = await this.BindGv_Topic();
                    const gvResult2 = await this.Bind_RequestPushCount();
                    //请求
                    ApplyTopic.requestStata = "1";
                    const gvResult3 = await this.BindGv_sys_RequestPush();
                    //通知
                    ApplyTopic.requestStata = "2";
                    const gvResult4 = await this.BindGv_sys_RequestPush();
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
        /* 查询
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
    */
        async btnQuery_Click() {
            try {
                const gvResult = await this.BindGv_Topic();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*历史请求*/
        async history_Request_Click() {
            try {
                //请求
                ApplyTopic.requestStata = "3";
                const gvResult3 = await this.BindGv_sys_RequestPush();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*历史通知*/
        async history_Notice_Click() {
            try {
                //历史通知
                ApplyTopic.requestStata = "4";
                const gvResult3 = await this.BindGv_sys_RequestPush();
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
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            strWhereCond += " and id_CurrEduCls='" + clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls + "'";
            try {
                if (this.topicName_q != "") {
                    strWhereCond += ` And ${clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_TopicName} like '% ${this.topicName_q}%'`;
                }
                if (this.TopicProposePeople_q != "") {
                    strWhereCond += ` And ${clsvResearchTopicEN_js_1.clsvResearchTopicEN.con_UserName} like '% ${this.TopicProposePeople_q}%'`;
                }
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                if (clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls == "00000050") {
                    strWhereCond += " and updUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
                }
                else {
                    strWhereCond += " and topicId not in(select topicId from RTUserRela where UserID='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "')";
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        CombineCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //var strPaperTypeId = $("#hidPaperTypeId").val();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.StartDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} > '${this.StartDate_q}'`;
                }
                if (this.EndDate_q != "") {
                    strWhereCond += ` And ${clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate} < '${this.EndDate_q}'`;
                }
                strWhereCond += " And updUser = '" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "'";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //主题讨论评论
        async BindGv_Topic() {
            const strCourseId = clsPublocalStorage_js_1.clsPublocalStorage.courseId;
            var strWhereCond = await this.CombineCondition1();
            var arrvResearchTopicObjLst = [];
            var intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            try {
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrvResearchTopicObjLst = await (0, clsvResearchTopicWApi_js_1.vResearchTopic_GetObjLstByPagerAsync)(objPagerPara);
                if (arrvResearchTopicObjLst.length == 0) {
                    const strid_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls;
                    const objCurrEduCls = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_GetObjByid_CurrEduCls_Cache)(strid_CurrEduCls, strCourseId);
                    const strMsg = (0, clsString_js_1.Format)("没有可申请的研究主题。当前教学班:[{0}].", objCurrEduCls === null || objCurrEduCls === void 0 ? void 0 : objCurrEduCls.eduClsName);
                    alert(strMsg);
                    return;
                }
                var arrTopicId = "";
                for (var i = 0; i < arrvResearchTopicObjLst.length; i++) {
                    arrTopicId += arrvResearchTopicObjLst[i].topicId + ",";
                }
                arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);
                //主题用户关系
                var strWhereCond2 = "topicId in(" + arrTopicId + ")";
                //var strWhereCond3 = "UserID ='" + clsPublocalStorage.userId + "'";
                var arrRTUserRelaObjLst = [];
                var arrRTUserRelaObjLst2 = [];
                arrRTUserRelaObjLst = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetObjLstAsync)(strWhereCond2);
                var strhtml = "";
                var cateid = 0;
                //$('#tbList tr').remove();
                for (var i = 0; i < arrvResearchTopicObjLst.length; i++) {
                    var strTopicName = arrvResearchTopicObjLst[i].topicName;
                    //var strAppraiseScore: number = arrvResearchTopicObjLst[i].AppraiseScore;
                    var strTopicContent = arrvResearchTopicObjLst[i].topicContent;
                    if (strTopicContent.length > 15) {
                        strTopicContent = strTopicContent.substr(0, 15) + "...";
                    }
                    var html_TopicContent = '<a style="color:#436EEE;" title="' + arrvResearchTopicObjLst[i].topicContent + '">' + strTopicContent + '</a>';
                    var strUserName = arrvResearchTopicObjLst[i].updUser + "(" + arrvResearchTopicObjLst[i].userName + ")";
                    arrRTUserRelaObjLst2 = arrRTUserRelaObjLst.filter(x => x.topicId == arrvResearchTopicObjLst[i].topicId);
                    var strUserNum = arrRTUserRelaObjLst2.length;
                    var streduClsName = clsPublocalStorage_js_1.clsPublocalStorage.eduClsName;
                    var html_ApplyTopic = '<button title="申请加入" class="layui-btn layui-btn-warm layui-btn-xs" onclick=btnApplyTopic_Click("' + arrvResearchTopicObjLst[i].topicId + '","' + arrvResearchTopicObjLst[i].updUser + '");><i class="layui-icon">&#xe654;</i>申请加入</button>';
                    strhtml += '<tr><td>' + strTopicName + '</td><td>' + html_TopicContent + '</td><td>' + strUserName + '</td><td>' + strUserNum + '</td><td>' + streduClsName + '</td><td>' + html_ApplyTopic + '</td></tr>';
                }
                //拼接；
                //$("#tbList").append(strhtml);
                $("#tbApplyTopicList").html(strhtml);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //申请加入主题
        async btnApplyTopic_Click(topicId, updUser) {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            var objsys_RequestPushEN = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            //this.PutDataTosys_RequestPushClass(objsys_RequestPushEN);
            objsys_RequestPushEN.SetTableKey(topicId);
            objsys_RequestPushEN.SetRequesTypeId("02");
            //objsys_RequestPushEN.SetParentId($("#hidParentId").val();
            //objsys_RequestPushEN.SetPubParentId($("#hidPubParentId").val();
            objsys_RequestPushEN.SetReceiveUser(updUser); //接收用户
            objsys_RequestPushEN.SetRequestUser(strUserId); //请求用户
            objsys_RequestPushEN.SetIsReply(false); //请求用户
            objsys_RequestPushEN.SetRequestStata("请求中"); //请求用户
            objsys_RequestPushEN.SetRequestDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); //请求日期
            objsys_RequestPushEN.Setid_CurrEduCls(clsPublocalStorage_js_1.clsPublocalStorage.id_CurrEduCls);
            try {
                const responseText2 = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_AddNewRecordAsync)(objsys_RequestPushEN);
                //const responseText2 = await sys_RequestPush_AddNewRecordWithMaxIdAsync(objsys_RequestPushEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `申请成功,请等待主题负责人通过申请才可加入!`;
                    ////$('#lblResult40').val(strInfo);
                    ////显示信息框
                    //alert(strInfo);
                    Alert1(strInfo);
                    ApplyTopic.requestStata = "1";
                    const gvResult3 = await this.BindGv_sys_RequestPush();
                    //CloseWindow();
                }
                else {
                    var strInfo = `申请失败!`;
                    //$('#lblResult40').val(strInfo);
                    //显示信息框
                    Alert1(strInfo);
                }
                //$("#J_PostBtn").attr("disabled", false);
                //$("#btnOKUpdAppraise").attr("disabled", false);
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                //$("#J_PostBtn").attr("disabled", false);
                //$("#btnOKUpdAppraise").attr("disabled", false);
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加评论不成功,${e}.`;
                alert(strMsg);
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /****************************************************答疑邀请相关 Start***************************************************/
        //请求
        Combinesys_RequestPushCondition1() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //strWhereCond += " and id_CurrEduCls=" + clsPublocalStorage.id_CurrEduCls;
                strWhereCond += " and requesTypeId='02' and requestUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' ";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //接收
        Combinesys_RequestPushCondition2() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                //strWhereCond += " and id_CurrEduCls=" + clsPublocalStorage.id_CurrEduCls;
                strWhereCond += " and requesTypeId='02' and receiveUser='" + clsPublocalStorage_js_1.clsPublocalStorage.userId + "' ";
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(Combineqa_PaperCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        //申请请求接收推送统计
        async Bind_RequestPushCount() {
            try {
                var strWhereCond1 = this.Combinesys_RequestPushCondition1();
                strWhereCond1 += " and isReply=0";
                var strWhereCond2 = this.Combinesys_RequestPushCondition2();
                strWhereCond2 += " and isReply=0";
                var int_requestCount = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetRecCountByCondAsync)(strWhereCond1);
                var int_noticeCount = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetRecCountByCondAsync)(strWhereCond2);
                $("#requestCount").html(int_requestCount);
                $("#noticeCount").html(int_noticeCount);
                var int_RequestPushCount = int_requestCount + int_noticeCount;
                $("#RequestPushCount").html(int_RequestPushCount);
                $("#hidRequestPushCount").val(int_RequestPushCount);
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        //请求列表
        async BindGv_sys_RequestPush() {
            //    public async BindGv_sys_RequestPush(requestStata: string) {
            var strWhereCond = "";
            switch (ApplyTopic.requestStata) {
                case "1":
                    strWhereCond += this.Combinesys_RequestPushCondition1();
                    strWhereCond += " and isReply=0";
                    break;
                case "2":
                    strWhereCond += this.Combinesys_RequestPushCondition2();
                    strWhereCond += " and isReply=0";
                    break;
                case "3":
                    strWhereCond += this.Combinesys_RequestPushCondition1();
                    strWhereCond += " and isReply=1";
                    break;
                case "4":
                    strWhereCond += this.Combinesys_RequestPushCondition2();
                    strWhereCond += " and isReply=1";
                    break;
            }
            //if (requestStata == "1") {
            //    strWhereCond += this.Combinesys_RequestPushCondition1();
            //    strWhereCond += " and isReply=0";
            //} else {
            //    strWhereCond += this.Combinesys_RequestPushCondition2();
            //    strWhereCond += " and isReply=0";
            //}
            //strWhereCond += " order by requestDate Asc";
            //var intCurrPageIndex = GetCurrPageIndex(this.objPager.currPageIndex);//获取当前页
            var arrsys_RequestPushObjLst = [];
            var arrResearchTopicObjLst = [];
            var arrUsers = [];
            try {
                const responseObjLst = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    arrsys_RequestPushObjLst = jsonData;
                });
                if (arrsys_RequestPushObjLst.length > 0) {
                    //通过主题id获取到对应的主题对象
                    var arrTopicId = "";
                    for (var i = 0; i < arrsys_RequestPushObjLst.length; i++) {
                        arrTopicId += arrsys_RequestPushObjLst[i].tableKey + ",";
                    }
                    arrTopicId = arrTopicId.substr(0, arrTopicId.length - 1);
                    var strWhereCond2 = "topicId in(" + arrTopicId + ")";
                    //声明主题变量
                    const responseObjLst2 = await (0, clsResearchTopicWApi_js_1.ResearchTopic_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                        arrResearchTopicObjLst = jsonData;
                    });
                }
                //获取用户缓存数据
                arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定推送数据不成功,${e}.`;
                alert(strMsg);
            }
            try {
                var strhtml = "";
                if (ApplyTopic.requestStata == "1") {
                    //请求
                    strhtml += '<div class="info" id="infoRequest">';
                }
                else {
                    //通知
                    strhtml += '<div class="info" id="infonotice">';
                }
                strhtml += '<ul class="artlist">';
                var k = 0;
                for (var i = 0; i < arrsys_RequestPushObjLst.length; i++) {
                    k++;
                    var objUser = arrUsers.find(x => x.userId == arrsys_RequestPushObjLst[i].requestUser);
                    if (objUser != null) {
                        strhtml += '<li id="li' + arrsys_RequestPushObjLst[i].requestId + '">';
                        strhtml += '<div style="text-align:left; float:left; width:65%;">';
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">' + k + '、</span>';
                        var objResearchTopic = arrResearchTopicObjLst.find(x => x.topicId == arrsys_RequestPushObjLst[i].tableKey);
                        if (objResearchTopic != null) {
                            if (ApplyTopic.requestStata == "1") {
                                //请求
                                strhtml += '<span class="title btn-1"><a href="#"  class="abstract-text">' + objUser.userName + '申请参加"' + objResearchTopic.topicName + '"主题！</a></span>';
                            }
                            else {
                                //通知
                                strhtml += '<span class="title btn-1"><a href="#"  class="abstract-text">' + objUser.userName + '申请参加"' + objResearchTopic.topicName + '"主题，您是否同意？</a></span>';
                            }
                        }
                        //}
                        strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;<span class="badge badge-pill badge-success" title="' + arrsys_RequestPushObjLst[i].requestStata + '">' + arrsys_RequestPushObjLst[i].requestStata + '</span>';
                        if (ApplyTopic.requestStata == "2") {
                            //同意
                            strhtml += '&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<button title="同意" class="layui-btn layui-btn layui-btn-xs" onclick=btn_OK_Click(' + arrsys_RequestPushObjLst[i].requestId + ',"' + arrsys_RequestPushObjLst[i].tableKey + '","' + arrsys_RequestPushObjLst[i].requestUser + '")><i class="layui-icon">&#xe605;</i></button>';
                            //拒绝
                            strhtml += '&nbsp;<button title="拒绝" class="layui-btn-danger layui-btn layui-btn-xs" onclick=btn_NO_Click(' + arrsys_RequestPushObjLst[i].requestId + ') href="javascript:;"><i class="layui-icon">&#x1006;</i></button>';
                        }
                        strhtml += '</div>';
                        //strhtml += '</li>';
                        //strhtml += '<li style="text-align:right;>';
                        strhtml += '<div style="text-align:right; float:right; width:34%;">';
                        strhtml += '<span class="rowtit color5"></span>' + objUser.userName + '<span class="rowtit color5">&nbsp;/&nbsp;</span>' + arrsys_RequestPushObjLst[i].requestDate;
                        //}
                        strhtml += '</div>';
                        strhtml += '</li>';
                    }
                }
                strhtml += '</ul>';
                strhtml += '</div>';
                //if (requestStata == "1") {
                //    //请求
                //    $("#Request").html(strhtml);
                //    console.log("完成BindGv_request!");
                //} else {
                //    //通知
                //    $("#Notice").html(strhtml);
                //    console.log("完成BindGv_notice!");
                //}
                switch (ApplyTopic.requestStata) {
                    case "1":
                        //请求
                        $("#Request").html(strhtml);
                        console.log("完成BindGv_request!");
                        break;
                    case "2":
                        //通知
                        $("#Notice").html(strhtml);
                        console.log("完成BindGv_notice!");
                        break;
                    case "3":
                        //历史请求
                        $("#history_Request").html(strhtml);
                        console.log("完成BindGv_history_Request!");
                        break;
                    case "4":
                        //历史通知
                        $("#history_Notice").html(strhtml);
                        console.log("完成BindGv_history_Notice!");
                        break;
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定推送列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 同意
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
     */
        async btn_OK_Click(requestId, strTopicId, strRequestUser) {
            const strThisFuncName = this.btn_OK_Click.name;
            var objsys_RequestPushEN = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            objsys_RequestPushEN.SetRequestId(requestId);
            objsys_RequestPushEN.SetIsReply(true);
            objsys_RequestPushEN.SetReplyDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
            objsys_RequestPushEN.SetRequestStata("同意");
            objsys_RequestPushEN.sf_UpdFldSetStr = objsys_RequestPushEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objsys_RequestPushEN.requestId == 0 || objsys_RequestPushEN.requestId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_UpdateRecordAsync)(objsys_RequestPushEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //Alert1("当前申请已同意！");
                    ////通知
                    //const gvResult4 = await this.BindGv_sys_RequestPush("2");
                    console.log("完成请求推送的修改!");
                    //增加主题用户关系
                    const responseText2 = await this.AddNewTopicAndRecordSaveUserRela(strTopicId, strRequestUser);
                    var returnBool2 = !!responseText2;
                    if (returnBool2 == true) {
                        Alert1("当前申请已同意！");
                        //通知
                        ApplyTopic.requestStata = "2";
                        const gvResult4 = await this.BindGv_sys_RequestPush();
                    }
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
        /* 添加主题同时把用户作为组长存放到主题用户关系表*/
        async AddNewTopicAndRecordSaveUserRela(strTopicId, strRequestUser) {
            var objRTUserRelaEN = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
            objRTUserRelaEN.SetTopicId(strTopicId);
            objRTUserRelaEN.SetUserId(strRequestUser);
            objRTUserRelaEN.SetTopicUserRoleId("0003"); //主题成员
            objRTUserRelaEN.SetOrderNum(30);
            objRTUserRelaEN.SetUpdDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate()); // 修改日期
            objRTUserRelaEN.SetUpdUser(clsPublocalStorage_js_1.clsPublocalStorage.userId); // 修改用户
            try {
                // 同一主题 同一用户 只能添加一次；
                var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strRequestUser + "'";
                const responseText = await (0, clsRTUserRelaWApi_js_1.RTUserRela_IsExistRecordAsync)(strWhere);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `同一主题不能重复添加同一个用户！`;
                    //alert(strMsg);
                    Alert2(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsRTUserRelaWApi_js_1.RTUserRela_AddNewRecordAsync)(objRTUserRelaEN);
                var returnBool = !!responseText2;
                //if (returnBool == true) {
                //    console.log("完成主题用户关系!");
                //}
                if (returnBool == true) {
                    console.log("完成主题用户关系!");
                    const responseText3 = await this.btnReOrder_Click(strTopicId);
                    //获取缓存色码表；
                    var arrGs_ColorObjLst = [];
                    //获取色码数据
                    const responseObjLst3 = await (0, clsgs_ColorWApi_js_1.gs_Color_GetObjLst_Cache)().then((jsonData) => {
                        arrGs_ColorObjLst = jsonData;
                    });
                    //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
                    var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strRequestUser + "'";
                    //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
                    const responseText = await (0, clsRTUserRelaWApi_js_1.RTUserRela_GetFirstObjAsync)(strWhereUserRela).then((jsonData) => {
                        var objRTUserRelaEN = jsonData;
                        if (objRTUserRelaEN != null) {
                            //得到用户排序号
                            var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
                            if (Objgs_Color != null) {
                                //得到色码
                                var objUpdateRTUserRelaEN = new clsRTUserRelaEN_js_1.clsRTUserRelaEN();
                                objUpdateRTUserRelaEN.SetmId(objRTUserRelaEN.mId);
                                objUpdateRTUserRelaEN.SetColorId(Objgs_Color.colorId);
                                objUpdateRTUserRelaEN.sf_UpdFldSetStr = objUpdateRTUserRelaEN.updFldString; //设置哪些字段被修改(脏字段)
                                const responseText = (0, clsRTUserRelaWApi_js_1.RTUserRela_UpdateRecordAsync)(objUpdateRTUserRelaEN).then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        return true;
                                    }
                                    else {
                                        var strInfo = `修改用户色码不成功!`;
                                        alert(strInfo);
                                        console.log("修改用户色码不成功");
                                        return false;
                                    }
                                });
                            }
                        }
                    });
                }
                else {
                    var strInfo = `添加主题用户关系不成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseText2; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加记录不成功,${e}.`;
                alert(strMsg);
            }
            //return true;//一定要有一个返回值，否则会出错！
        }
        async btnReOrder_Click(strTopicId) {
            //var strTopicId = clsPrivateSessionStorage.topicId;
            // if (this.PreCheck4Order() == false) return;
            //var strSectionId: string = gs_PaperParagraphCRUD.SectionId_OrderNum;
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "topicId": strTopicId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsRTUserRelaWApi_js_1.RTUserRela_ReOrderAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
        }
        /* 添加主题同时把用户作为组长存放到主题用户关系表*/
        //public async AddNewTopicAndRecordSaveUserRela() {
        //    var strTopicId = clsPrivateSessionStorage.topicId;
        //    var strUserId = clsPublocalStorage.userId;
        //    var objRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        //    this.PutDataToRTUserRelaClassWhere(objRTUserRelaEN, strTopicId);
        //    //获取缓存色码表；
        //    var arrGs_ColorObjLst: Array<clsgs_ColorEN> = [];
        //    try {
        //        // 同一主题 同一用户 只能添加一次；
        //        var strWhere = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
        //        const responseText = await RTUserRela_IsExistRecordAsync(strWhere);
        //        var bolIsExist: boolean = responseText;
        //        if (bolIsExist == true) {
        //            var strMsg: string = `同一主题不能重复添加同一个用户！`;
        //            alert(strMsg);
        //            return responseText;//一定要有一个返回值，否则会出错！
        //        }
        //        const responseText2 = await RTUserRela_AddNewRecordAsync(objRTUserRelaEN);
        //        var returnBool: boolean = !!responseText2;
        //        if (returnBool == true) {
        //            var strInfo: string = `添加成功!`;
        //            $('#lblResult40').val(strInfo);
        //            //隐藏用户框
        //            HideDialogFour();
        //            //显示信息框
        //            alert(strInfo);
        //            const responseText3 = await this.btnReOrder_Click();
        //            //获取色码数据
        //            const responseObjLst3 = await gs_Color_GetObjLst_Cache().then((jsonData) => {
        //                arrGs_ColorObjLst = <Array<clsgs_ColorEN>>jsonData;
        //            });
        //            //添加完成后把根据用户排序号得到色码表 样式把样式更新到主题用户关系表；
        //            var strWhereUserRela = " 1 = 1 And topicId = '" + strTopicId + "' And userId = '" + strUserId + "'";
        //            //const responseText = await RTUserRela_GetFirstObjAsync(strWhere);
        //            const responseText = await RTUserRela_GetFirstObjAsync(strWhereUserRela).then((jsonData) => {
        //                var objRTUserRelaEN: clsRTUserRelaEN = <clsRTUserRelaEN>jsonData;
        //                if (objRTUserRelaEN != null) {
        //                    //得到用户排序号
        //                    var Objgs_Color = arrGs_ColorObjLst.find(x => x.userNo == objRTUserRelaEN.orderNum);
        //                    if (Objgs_Color != null) {
        //                        //得到色码
        //                        var objUpdateRTUserRelaEN: clsRTUserRelaEN = new clsRTUserRelaEN();
        //                        objUpdateRTUserRelaEN.SetmId(objRTUserRelaEN.mId;
        //                        objUpdateRTUserRelaEN.SetUserBgColor(Objgs_Color.colorCode;
        //                        objUpdateRTUserRelaEN.sf_UpdFldSetStr = objUpdateRTUserRelaEN.updFldString;//设置哪些字段被修改(脏字段)
        //                        const responseText = RTUserRela_UpdateRecordAsync(objUpdateRTUserRelaEN).then((jsonData) => {
        //                            var returnBool: boolean = jsonData;
        //                            if (returnBool == true) {
        //                                return true;
        //                            }
        //                            else {
        //                                var strInfo: string = `修改用户色码不成功!`;
        //                                alert(strInfo);
        //                                console.log("修改用户色码不成功");
        //                                return false;
        //                            }
        //                        });
        //                    }
        //                }
        //            })
        //            this.BindGv_vRTUserRela();
        //            ////主题Id
        //            //window.location.href = "../GraduateEdu/WApiRTUserRela_QUDI_TS?TopicRelaId='01'";
        //        }
        //        else {
        //            var strInfo: string = `添加不成功!`;
        //            $('#lblResult40').val(strInfo);
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
        //    }
        //    return true;//一定要有一个返回值，否则会出错！
        //}
        /* 拒绝
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
    */
        async btn_NO_Click(requestId) {
            const strThisFuncName = this.btn_NO_Click.name;
            var objsys_RequestPushEN = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            objsys_RequestPushEN.SetRequestId(requestId);
            objsys_RequestPushEN.SetIsReply(true);
            objsys_RequestPushEN.SetReplyDate(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate());
            objsys_RequestPushEN.SetRequestStata("拒绝");
            objsys_RequestPushEN.sf_UpdFldSetStr = objsys_RequestPushEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objsys_RequestPushEN.requestId == 0 || objsys_RequestPushEN.requestId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_UpdateRecordAsync)(objsys_RequestPushEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    Alert1("当前申请已拒绝！");
                    console.log("当前申请已拒绝!");
                }
                return returnBool;
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `拒绝不成功,${e}.`;
                alert(strMsg);
                return false;
            }
        }
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
        set hidSortBy(value) {
            $("#hidSortBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortBy() {
            return $("#hidSortBy").val();
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
        * 栏目主题
       */
        get topicName_q() {
            return $("#txtTopicName_q").val();
        }
        /*
        * 主题提出人
       */
        get TopicProposePeople_q() {
            return $("#txtTopicProposePeople_q").val();
        }
    }
    exports.ApplyTopic = ApplyTopic;
    ApplyTopic.requestStata = "";
});
