(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../PagesBase/GraduateEduTopic/gs_MeetingMinutesCRUD.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesVerWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesWApi.js", "../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js", "../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js", "../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_MeetingMinutesExWApi.js", "../TS/PubConfig/clsPrivateSessionStorage.js", "../TS/PubConfig/clsSysPara4WebApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsCommFunc4Web.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsString.js", "./gs_MeetingMinutes_EditEx.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_MeetingMinutesCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_MeetingMinutesCRUDEx
    表名:gs_MeetingMinutes(01120770)
    生成代码版本:2020.11.22.1
    生成日期:2020/11/25 22:07:12
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
    const gs_MeetingMinutesCRUD_js_1 = require("../PagesBase/GraduateEduTopic/gs_MeetingMinutesCRUD.js");
    const clsgs_MeetingMinutesEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js");
    const clsgs_MeetingMinutesVerWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesVerWApi.js");
    const clsgs_MeetingMinutesWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesWApi.js");
    const clsvRTUserRelaWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsvRTUserRelaWApi.js");
    const clsvUsersSimWApi_js_1 = require("../TS/L3_ForWApi/UserManage_Share/clsvUsersSimWApi.js");
    const clsgs_MeetingMinutesExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTopic/clsgs_MeetingMinutesExWApi.js");
    const clsPrivateSessionStorage_js_1 = require("../TS/PubConfig/clsPrivateSessionStorage.js");
    const clsSysPara4WebApi_js_1 = require("../TS/PubConfig/clsSysPara4WebApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../TS/PubFun/clsCommFunc4Web.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const gs_MeetingMinutes_EditEx_js_1 = require("./gs_MeetingMinutes_EditEx.js");
    /* gs_MeetingMinutesCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class gs_MeetingMinutesCRUDEx extends gs_MeetingMinutesCRUD_js_1.gs_MeetingMinutesCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvgs_MeetingMinutesBy: string = "meetingId";
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
                case "vgs_MeetingMinutes":
                    alert('该类没有绑定该函数：[this.BindGv_vgs_MeetingMinutes_Cache]！');
                    //this.BindGv_vgs_MeetingMinutes_Cache();
                    break;
            }
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new gs_MeetingMinutesCRUDEx();
            var objPage_Edit = new gs_MeetingMinutes_EditEx_js_1.gs_MeetingMinutes_EditEx(objPage);
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
                    var strMsg = '命令:' + strCommandName + "在函数(gs_MeetingMinutesCRUDExEx.btn_Click)中没有被处理！";
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
                //if (this.bolIsInitShow == false)  //
                //{
                //    this.objPager.InitShow(this.divName4Pager);
                //    this.bolIsInitShow = true;  //
                //}
                const responseBindGv1 = await this.Bind_MeetingMinutesTree();
                const responseBindGv2 = await this.Bind_MeetingMinutesList();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        //会议纪要树绑定
        async Bind_MeetingMinutesTree() {
            var strWhereCond = " topicId='" + clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId + "'";
            //声明主题变量
            var arrgs_MeetingYearNumObjLst = [];
            var arrgs_MeetingMonthNumObjLst1 = [];
            var arrgs_MeetingMonthNumObjLst2 = [];
            const responseObjLst1 = await (0, clsgs_MeetingMinutesExWApi_js_1.gs_MeetingMinutesEx_GetMeetingYearNumObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_MeetingYearNumObjLst = jsonData;
            });
            const responseObjLst2 = await (0, clsgs_MeetingMinutesExWApi_js_1.gs_MeetingMinutesEx_GetMeetingMonthNumObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_MeetingMonthNumObjLst1 = jsonData;
            });
            var strhtml = "";
            for (var i = 0; i < arrgs_MeetingYearNumObjLst.length; i++) {
                var strYear = arrgs_MeetingYearNumObjLst[i].year;
                strhtml += '<li class="li">';
                strhtml += '<a href="#" id="' + strYear + '" class="main" title="' + strYear + '" onclick=main_Click("' + strYear + '")>' + strYear + '年</a>';
                strhtml += '<ul class="submenu" id="ul' + strYear + '">';
                arrgs_MeetingMonthNumObjLst2 = arrgs_MeetingMonthNumObjLst1.filter(x => x.year == strYear);
                //循环数据
                for (var j = 0; j < arrgs_MeetingMonthNumObjLst2.length; j++) {
                    var strMonth = arrgs_MeetingMonthNumObjLst2[j].month;
                    strhtml += '<li id="' + strYear + strMonth + '" onclick=btnSelectMeetingMonth("' + strYear + '","' + strMonth + '")>';
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
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="badge badge-primary" title="会议纪要' + arrgs_MeetingMonthNumObjLst2[j].memo + '条">' + arrgs_MeetingMonthNumObjLst2[j].memo + '</span>';
                    strhtml += '</div>';
                    strhtml += '</li>';
                }
                strhtml += '</ul>';
                strhtml += '</li>';
            }
            $("#MeetingMinutesTreeBind").html(strhtml);
        }
        //会议纪要列表绑定
        async Bind_MeetingMinutesList() {
            var strUserId = clsPublocalStorage_js_1.clsPublocalStorage.userId;
            var strRoleId = clsPublocalStorage_js_1.clsPublocalStorage.roleId;
            var strTopicId = clsPrivateSessionStorage_js_1.clsPrivateSessionStorage.topicId;
            var strWhereCond = " topicId='" + strTopicId + "' and year='" + $("#hidYear").val() + "' and month='" + $("#hidMonth").val() + "'";
            //声明主题变量
            var arrgs_MeetingDateNumObjLst = [];
            var arrgs_MeetingMinutesObjLst1 = [];
            var arrgs_MeetingMinutesObjLst2 = [];
            var arrRTUserRelaObjLst = [];
            const responseObjLst1 = await (0, clsgs_MeetingMinutesExWApi_js_1.gs_MeetingMinutesEx_GetMeetingDateNumObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_MeetingDateNumObjLst = jsonData;
            });
            const responseObjLst2 = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                arrgs_MeetingMinutesObjLst1 = jsonData;
            });
            var strWhereCond2 = "topicId ='" + strTopicId + "'";
            const responseObjLst3 = await (0, clsvRTUserRelaWApi_js_1.vRTUserRela_GetObjLstAsync)(strWhereCond2).then((jsonData) => {
                arrRTUserRelaObjLst = jsonData;
            });
            //获取用户缓存数据
            var arrUsers = await (0, clsvUsersSimWApi_js_1.vUsersSim_GetObjLst_Cache)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.cmPrjId);
            //var strBr = '<br/>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;';
            var strhtml = "";
            //循环数据源 
            strhtml += '<div><th colspan="2">';
            for (var y = 0; y < arrRTUserRelaObjLst.length; y++) {
                var strUserName = arrRTUserRelaObjLst[y].userName;
                var strColorCode = arrRTUserRelaObjLst[y].colorCode;
                //得到显示用户的色码块
                strhtml += '<label style="background: ' + strColorCode + '">&nbsp;&nbsp;&nbsp;&nbsp;</label>&nbsp;&nbsp;<span>' + strUserName + '</span>&nbsp;&nbsp;&nbsp;';
            }
            strhtml += '</th></div>';
            for (var i = 0; i < arrgs_MeetingDateNumObjLst.length; i++) {
                var strMeetingDate = arrgs_MeetingDateNumObjLst[i].meetingDate;
                strhtml += '<li class="layui-timeline-item">';
                strhtml += '<i class="layui-icon layui-timeline-axis"></i>';
                strhtml += '<div class="layui-timeline-content layui-text">';
                strhtml += '<h3 class="layui-timeline-title">' + strMeetingDate + '</h3>';
                arrgs_MeetingMinutesObjLst2 = arrgs_MeetingMinutesObjLst1.filter(x => x.meetingDate == strMeetingDate);
                for (var j = 0; j < arrgs_MeetingMinutesObjLst2.length; j++) {
                    var strKeyId = arrgs_MeetingMinutesObjLst2[j].meetingId;
                    var strMeetingContent = arrgs_MeetingMinutesObjLst2[j].meetingContent;
                    ////处理换行
                    //strMeetingContent = strMeetingContent.replace(/\r\n/g, strBr);
                    //strMeetingContent = strMeetingContent.replace(/\n/g, strBr);
                    var strUpdUser = arrgs_MeetingMinutesObjLst2[j].updUser;
                    var isSubmit = arrgs_MeetingMinutesObjLst2[j].isSubmit;
                    var versionCount = arrgs_MeetingMinutesObjLst2[j].versionCount;
                    var strParticipants = arrgs_MeetingMinutesObjLst2[j].participants;
                    strhtml += '<div>' + strMeetingContent + '</div>';
                    strhtml += '<div style="width:100%;height:40px;">';
                    strhtml += '<div style="float:left;">';
                    var objUser = arrUsers.find(x => x.userId == strUpdUser);
                    if (objUser != null) {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[编辑用户]：</span>' + objUser.userName;
                    }
                    strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color1">[参与者]：</span>' + strParticipants;
                    strhtml += '</div>';
                    strhtml += '<div style="float:right;">';
                    if (isSubmit == false) {
                        strhtml += '&nbsp;<span class="rowtit color2">未提交</span>&nbsp;&nbsp;';
                        if (strRoleId != "00620003") {
                            //删除
                            strhtml += '<button title="提交会议纪要" class="layui-btn layui-btn-danger layui-btn-xs" onclick=Update_MeetingIsSubmit_Click("' + strKeyId + '",1) href="javascript:;"><i class="layui-icon">&#x1005;</i>提交</button>';
                            //删除
                            strhtml += '<button title="删除会议纪要" class="layui-btn layui-btn-danger layui-btn-xs" onclick=btnDelgs_MeetingMinutes_Click("' + strKeyId + '") href="javascript:;"><i class="layui-icon">&#xe640;</i></button>';
                        }
                        //编辑
                        strhtml += '<button title="编辑会议纪要" class="layui-btn layui-btn layui-btn-xs" onclick=btnUpdategs_MeetingMinutes_Click("' + strKeyId + '")><i class="layui-icon">&#xe642;</i></button>';
                    }
                    else {
                        strhtml += '&nbsp;&nbsp;&nbsp;<span class="rowtit color3">[已提交]：</span>';
                        if (strRoleId == "00620001") {
                            //删除
                            strhtml += '<button title="撤销提交" class="layui-btn layui-btn-danger layui-btn-xs" onclick=Update_MeetingIsSubmit_Click("' + strKeyId + '",0) href="javascript:;"><i class="layui-icon">&#xe9aa;</i>撤销提交</button>';
                        }
                    }
                    strhtml += "&nbsp;&nbsp;<button class=\"layui-btn layui-btn-warm layui-btn-xs btnRight\" onclick=\"xadmin.open('会议纪要历史版本', '../GraduateEduEx/HistoricalVersion?Key=" + strKeyId + "&Type=13')\"> <i class=\"layui-icon\" >&#xe642;</i>历史版本<span class=\"layui-badge\">" + versionCount + "</span></button >";
                    //判断角色
                    //不等于学生，其他角色都可以添加问题
                    strhtml += '</div>';
                    strhtml += '</div>';
                    strhtml += '<div style="border-bottom: 1px solid #eee;"></div>';
                }
                strhtml += '</div>';
                strhtml += '</li>';
            }
            $("#MeetingMinutesList").html(strhtml);
        }
        //会议纪要提交
        async Update_MeetingIsSubmit_Click(strKeyId, stata) {
            const strThisFuncName = this.Update_MeetingIsSubmit_Click.name;
            var objgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
            objgs_MeetingMinutesEN.SetMeetingId(strKeyId);
            if (stata == 0) {
                objgs_MeetingMinutesEN.SetIsSubmit(false);
            }
            else {
                objgs_MeetingMinutesEN.SetIsSubmit(true);
            }
            objgs_MeetingMinutesEN.sf_UpdFldSetStr = objgs_MeetingMinutesEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_MeetingMinutesEN.meetingId == "" || objgs_MeetingMinutesEN.meetingId == undefined) {
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_UpdateRecordAsync)(objgs_MeetingMinutesEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    if (stata == 0) {
                        layui_Alert(1, "提交撤销成功！");
                    }
                    else {
                        layui_Alert(1, "会议提交成功！");
                    }
                    const responseBindGv = await this.Bind_MeetingMinutesList();
                    //gs_MeetingMinutes_ReFreshCache();
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
                const responseText1 = await this.VDelRecord(strKeyId);
                const responseText2 = await this.DelRecord(strKeyId);
                const responseBindGv = await this.Bind_MeetingMinutesList();
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
        async DelRecord(strMeetingId) {
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_DelRecordAsync)(strMeetingId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_MeetingMinutes_ReFreshCache();
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
        //历史版本删除
        VDelRecord(arrMeetingId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsgs_MeetingMinutesVerWApi_js_1.gs_MeetingMinutesVer_Delgs_MeetingMinutesVersByCondAsync)("meetingId='" + arrMeetingId + "'").then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除历史版本成功!`;
                            ////显示信息框
                            //alert(strInfo);
                            console.log(strInfo);
                        }
                        else {
                            var strInfo = `历史版本删除记录不成功!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        console.log("完成DelMultiRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `删除记录不成功. ${e}.`;
                    alert(strMsg);
                }
            });
        }
    }
    exports.gs_MeetingMinutesCRUDEx = gs_MeetingMinutesCRUDEx;
});
