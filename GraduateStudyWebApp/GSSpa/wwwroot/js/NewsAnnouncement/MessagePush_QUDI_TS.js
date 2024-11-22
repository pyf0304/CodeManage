(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/NewsAnnouncement/clsMessagePushEN.js", "../TS/L0_Entity/NewsAnnouncement/clsvMessagePushEN.js", "../TS/L3_ForWApi/NewsAnnouncement/clsMessagePushWApi.js", "../TS/L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPager.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.MessagePush_QUDI_TS = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:MessagePush_QUDI_TS
    表名:MessagePush(00420700)
    生成代码版本:2019.10.18.1
    生成日期:2019/10/21 17:14:28
    生成者:
    工程名称:教育高地
    工程ID:0042
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:新闻公告
    模块英文名:NewsAnnouncement
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsMessagePushEN_js_1 = require("../TS/L0_Entity/NewsAnnouncement/clsMessagePushEN.js");
    const clsvMessagePushEN_js_1 = require("../TS/L0_Entity/NewsAnnouncement/clsvMessagePushEN.js");
    const clsMessagePushWApi_js_1 = require("../TS/L3_ForWApi/NewsAnnouncement/clsMessagePushWApi.js");
    const clsvMessagePushWApi_js_1 = require("../TS/L3_ForWApi/NewsAnnouncement/clsvMessagePushWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    /* MessagePush_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class MessagePush_QUDI_TS extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        AddNewRecord() {
            this.SetKeyReadOnly(false);
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucMessagePushB1.messagePushId = clsMessagePushBL.GetMaxStrId_S();
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objMessagePushEN = new clsMessagePushEN_js_1.clsMessagePushEN();
            this.PutDataToMessagePushClass(objMessagePushEN);
            try {
                const responseText = await (0, clsMessagePushWApi_js_1.MessagePush_IsExistAsync)(objMessagePushEN.messagePushId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objMessagePushEN.messagePushId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsMessagePushWApi_js_1.MessagePush_AddNewRecordAsync)(objMessagePushEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    var strInfo = `添加记录成功!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vMessagePush() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevMessagePushCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvMessagePushObjLst = [];
            try {
                const responseRecCount = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvMessagePushBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvMessagePushObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvMessagePushObjLst.length == 0) {
                var strMsg = `根据条件获取的对象列表数为空！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vMessagePush(strListDiv, arrvMessagePushObjLst);
                console.log("完成BindGv_vMessagePush!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vMessagePush对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrMessagePushObjLst">需要绑定的对象列表</param>
       */
        BindTab_vMessagePush(divContainer, arrvMessagePushObjLst) {
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
                    FldName: "messagePushId",
                    ColHeader: "消息Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    ColHeader: "备注",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    ColHeader: "修改",
                    Text: "修改", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnUpdateRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    ColHeader: "删除",
                    Text: "删除", TdClass: "text-left", SortBy: "",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvMessagePushObjLst, arrDataColumn, "messagePushId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                const responseText = await this.AddNewRecord();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 删除记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
       */
        async btnDelRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                const responseText = await this.DelMultiRecord(arrKeyIds);
                const responseText2 = await this.BindGv_vMessagePush();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
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
                const responseText2 = await this.BindGv_vMessagePush();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
            this.OpType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                this.DetailRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvMessagePushObjLst = jsonData;
                    this.BindTab_vMessagePush(this.mstrListDiv, arrvMessagePushObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnOKUpd_Click() {
            var strCommandText = this.btnOKUpd;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vMessagePush();
                            }
                        });
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vMessagePush();
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnOKUpd_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的记录对象的列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevMessagePushCondition();
            try {
                const responseRecCount = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvMessagePushBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvMessagePushObjLst = jsonData;
                    this.BindTab_vMessagePush(this.mstrListDiv, arrvMessagePushObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        在数据表里选择记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
       */
        async btnSelectRecordInTab_Click(strKeyId) {
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                this.SelectRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            this.UpdateRecord(strKeyId);
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.messagePushId = "";
            this.messagePushNumber = "";
            this.messageTitle = "";
            this.messageContent = "";
            this.receivePeople = "";
            this.messageTypeId = "";
            this.isAllpush = false;
            this.isReceive = false;
            this.clientVersionTypeId = "";
            this.updDate = "";
            this.memo = "";
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevMessagePushCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.MessageTitle_q != "") {
                    strWhereCond += ` And ${clsvMessagePushEN_js_1.clsvMessagePushEN.con_MessageTitle} like '% ${this.MessageTitle_q}%'`;
                }
                if (this.ReceivePeople_q != "") {
                    strWhereCond += ` And ${clsvMessagePushEN_js_1.clsvMessagePushEN.con_ReceivePeople} like '% ${this.ReceivePeople_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineMessagePushCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        DelMultiRecord(arrMessagePushId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsMessagePushWApi_js_1.MessagePush_DelMessagePushsAsync)(arrMessagePushId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
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
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        DelRecord(strMessagePushId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsMessagePushWApi_js_1.MessagePush_DelRecordAsync)(strMessagePushId).then((jsonData) => {
                        var returnInt = jsonData;
                        if (returnInt > 0) {
                            var strInfo = `删除记录成功,共删除${returnInt}条记录!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `删除记录不成功!`;
                            //显示信息框
                            alert(strInfo);
                        }
                        console.log("完成DelRecord!");
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
        /*
        演示Session 操作
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Demo_Session)
        */
        async Demo_Session() {
            try {
                //设置Session
                var strUserId = "TestUserId";
                await this.SetSessionAsync("userId", strUserId);
                //获取Session
                var strUserId_Value1 = await this.GetSessionAsync("userId");
                console.log('strUserId_Value1:' + strUserId_Value1);
                //获取Session方法2：直接读取页面中的hidUserId
                var strUserId_Value2 = this.hidUserId;
                console.log('strUserId_Value2:' + strUserId_Value2);
            }
            catch (e) {
                var strMsg = `演示Session不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        DetailRecord(strMessagePushId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsMessagePushWApi_js_1.MessagePush_GetObjByMessagePushIdAsync)(strMessagePushId).then((jsonData) => {
                        var objMessagePushEN = jsonData;
                        this.GetDataFromMessagePushClass(objMessagePushEN);
                        console.log("完成DetailRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjMessagePushEN">表实体类对象</param>
       */
        GetDataFromMessagePushClass(pobjMessagePushEN) {
            this.messagePushId = pobjMessagePushEN.messagePushId; // 消息Id
            this.messagePushNumber = pobjMessagePushEN.messagePushNumber; // 消息编号
            this.messageTitle = pobjMessagePushEN.messageTitle; // 消息标题
            this.messageContent = pobjMessagePushEN.messageContent; // 消息内容
            this.receivePeople = pobjMessagePushEN.receivePeople; // 接收人员
            this.messageTypeId = pobjMessagePushEN.messageTypeId; // 消息类型Id
            this.isAllpush = pobjMessagePushEN.isAllpush; // 是否全体推送
            this.isReceive = pobjMessagePushEN.isReceive; // 是否接收
            this.clientVersionTypeId = pobjMessagePushEN.clientVersionTypeId; // 客户端版本类型Id
            this.updDate = pobjMessagePushEN.updDate; // 修改日期
            this.memo = pobjMessagePushEN.memo; // 备注
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjMessagePushEN">表实体类对象</param>
        <returns>列表的第一个关键字值</returns>
       */
        GetFirstKey() {
            if (clsCommonFunc4Web2_js_1.arrSelectedKeys.length == 1) {
                return clsCommonFunc4Web2_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommonFunc4Web2_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        // /* 获取当前表关键字值的最大值,再加1,避免重复
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
        //*/
        // public async GetMaxStrId(strKeyCtrlName) {
        //     this.DivName = "divGetMaxStrId";
        //     try {
        //         const responseText = await MessagePush_GetMaxStrIdAsync();
        //         var returnString: string = responseText.toString();
        //         if (returnString == "") {
        //             var strInfo: string = `获取表MessagePush的最大关键字为空，不成功，请检查!`;
        //             $('#lblResult35').val(strInfo);
        //             //显示信息框
        //             alert(strInfo);
        //             $(strKeyCtrlName).val(returnString);
        //         }
        //         else {
        //             var strInfo: string = `获取表MessagePush的最大关键字为：${returnString}!`;
        //             $('#lblResult35').val(strInfo);
        //             //显示信息框
        //             alert(strInfo);
        //             $(strKeyCtrlName).val(returnString);
        //         }
        //     }
        //     catch (e) {
        //         console.error('catch(e)=');
        //         console.error(e);
        //         var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
        //         alert(strMsg);
        //     }
        // }
        /*
        获取Session 关键字的值
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetSessionAsync)
        <param name = "Key">关键字</param>
         <return>值</return>
        */
        GetSessionAsync(Key) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_GetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                        resolve(data);
                    },
                    error: (e) => {
                        var strErrMsg = decodeURIComponent(e.responseText);
                        reject(e);
                    }
                });
            });
        }
        /* 函数功能:在数据 列表中跳转到某一页
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
         <param name = "intPageIndex">页序号</param>
       */
        async IndexPage(intPageIndex) {
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.PageCount;
            }
            console.log("跳转到" + intPageIndex + "页");
            this.setCurrPageIndex(intPageIndex, this.divName4Pager);
            this.BindGv_vMessagePush();
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //1、为下拉框设置数据源,绑定列表数据
                this.hidSortvMessagePushBy = "messagePushId Asc";
                var strWhereCond = this.CombinevMessagePushCondition();
                const responseText = await (0, clsvMessagePushWApi_js_1.vMessagePush_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vMessagePush();
            }
            catch (e) {
                var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjMessagePushEN">数据传输的目的类对象</param>
       */
        PutDataToMessagePushClass(pobjMessagePushEN) {
            pobjMessagePushEN.messagePushId = this.messagePushId; // 消息Id
            pobjMessagePushEN.messagePushNumber = this.messagePushNumber; // 消息编号
            pobjMessagePushEN.messageTitle = this.messageTitle; // 消息标题
            pobjMessagePushEN.messageContent = this.messageContent; // 消息内容
            pobjMessagePushEN.receivePeople = this.receivePeople; // 接收人员
            pobjMessagePushEN.messageTypeId = this.messageTypeId; // 消息类型Id
            pobjMessagePushEN.isAllpush = this.isAllpush; // 是否全体推送
            pobjMessagePushEN.isReceive = this.isReceive; // 是否接收
            pobjMessagePushEN.clientVersionTypeId = this.clientVersionTypeId; // 客户端版本类型Id
            pobjMessagePushEN.updDate = this.updDate; // 修改日期
            pobjMessagePushEN.memo = this.memo; // 备注
        }
        /* 根据条件获取相应的记录对象的列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_QueryLst)
       */
        QueryvMessagePushLst(strListDiv) {
            var strWhereCond = this.CombinevMessagePushCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            return new Promise((resolve, reject) => {
                try {
                    var objPagerPara = {
                        pageIndex: intCurrPageIndex,
                        pageSize: this.pageSize,
                        whereCond: strWhereCond,
                        orderBy: this.hidSortvMessagePushBy,
                        sortFun: (x, y) => { return 0; }
                    };
                    const responseText = (0, clsvMessagePushWApi_js_1.vMessagePush_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                        var arrvMessagePushObjLst = jsonData;
                        this.BindTab_vMessagePush(strListDiv, arrvMessagePushObjLst);
                        console.log("完成QueryvMessagePushLst!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `根据条件获取相应的记录对象的列表不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strMessagePushId) {
            try {
                const responseText = await (0, clsMessagePushWApi_js_1.MessagePush_GetObjByMessagePushIdAsync)(strMessagePushId);
                var objMessagePushEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vMessagePush");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtMessagePushId').prop['ReadOnly'] = bolReadonly;
        }
        /*
        设置Session
          (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetSessionAsync)
        <param name = "Key">关键字</param>
        <param name = "Value">值</param>
        */
        SetSessionAsync(Key, Value) {
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl_Session_SetString,
                    cache: false,
                    async: false,
                    type: 'get',
                    dataType: "json",
                    data: {
                        Key: Key,
                        Value: Value
                    },
                    success: function (data) {
                        var strKey = data.key;
                        var strValue = data.value;
                        console.log('strKey, strValue=' + strKey + strValue);
                    }
                });
            });
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strMessagePushId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strMessagePushId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objMessagePushEN = new clsMessagePushEN_js_1.clsMessagePushEN();
            try {
                const responseText = await (0, clsMessagePushWApi_js_1.MessagePush_IsExistAsync)(strMessagePushId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strMessagePushId}] 的记录不存在!`;
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                }
            }
            catch (e) {
                var strMsg = `检查相应关键字的记录存在不成功, ${e}.`;
                alert(strMsg);
            }
            try {
                const responseText = await (0, clsMessagePushWApi_js_1.MessagePush_GetObjByMessagePushIdAsync)(strMessagePushId);
                objMessagePushEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromMessagePushClass(objMessagePushEN);
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objMessagePush">需要显示的对象</param>
       */
        ShowMessagePushObj(divContainer, objMessagePush) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objMessagePush);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objMessagePush[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvMessagePushBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvMessagePushBy.indexOf("Asc") >= 0) {
                    this.hidSortvMessagePushBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvMessagePushBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvMessagePushBy = `${strSortByFld} Asc`;
            }
            const responseText2 = await this.BindGv_vMessagePush();
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        UpdateRecord(strMessagePushId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strMessagePushId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsMessagePushWApi_js_1.MessagePush_GetObjByMessagePushIdAsync)(strMessagePushId).then((jsonData) => {
                        var objMessagePushEN = jsonData;
                        this.GetDataFromMessagePushClass(objMessagePushEN);
                        console.log("完成UpdateRecord!");
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error(e);
                    var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                    alert(strMsg);
                }
            });
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objMessagePushEN = new clsMessagePushEN_js_1.clsMessagePushEN();
            objMessagePushEN.messagePushId = this.KeyId;
            this.PutDataToMessagePushClass(objMessagePushEN);
            objMessagePushEN.sf_UpdFldSetStr = objMessagePushEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objMessagePushEN.messagePushId == "" || objMessagePushEN.messagePushId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsMessagePushWApi_js_1.MessagePush_UpdateRecordAsync)(objMessagePushEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `修改记录成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult44').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                            console.log("完成UpdateRecordSave");
                        }
                        resolve(jsonData);
                    });
                }
                catch (e) {
                    console.error('catch(e)=');
                    console.error(e);
                    var strMsg = `修改记录不成功,${e}.`;
                    alert(strMsg);
                    return false;
                }
            });
        }
        /*
        * 设置取消按钮的标题
       */
        set btnCancel(value) {
            $("#btnCancel").html(value);
        }
        /*
        * 设置确定按钮的标题
       */
        set btnOKUpd(value) {
            $("#btnOKUpd").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnOKUpd() {
            return $("#btnOKUpd").html();
        }
        /*
        * 客户端版本类型Id
       */
        set clientVersionTypeId(value) {
            $("#txtClientVersionTypeId").val(value);
        }
        /*
        * 客户端版本类型Id
       */
        get clientVersionTypeId() {
            return $("#txtClientVersionTypeId").val();
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
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvMessagePushBy(value) {
            $("#hidSortvMessagePushBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvMessagePushBy() {
            return $("#hidSortvMessagePushBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 是否全体推送
       */
        set isAllpush(value) {
            $("#chkIsAllpush").val(value);
        }
        /*
        * 是否全体推送
       */
        get isAllpush() {
            return $("#chkIsAllpush").prop("checked");
        }
        /*
        * 是否接收
       */
        set isReceive(value) {
            $("#chkIsReceive").val(value);
        }
        /*
        * 是否接收
       */
        get isReceive() {
            return $("#chkIsReceive").prop("checked");
        }
        /*
        * 设置关键字的值
       */
        set KeyId(value) {
            $("#hidKeyId").val(value);
        }
        /*
        * 设置关键字的值
       */
        get KeyId() {
            return $("#hidKeyId").val();
        }
        /*
        * 备注
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 消息内容
       */
        set messageContent(value) {
            $("#txtmessageContent").val(value);
        }
        /*
        * 消息内容
       */
        get messageContent() {
            return $("#txtmessageContent").val();
        }
        /*
        * 消息Id
       */
        set messagePushId(value) {
            $("#txtMessagePushId").val(value);
        }
        /*
        * 消息Id
       */
        get messagePushId() {
            return $("#txtMessagePushId").val();
        }
        /*
        * 消息编号
       */
        set messagePushNumber(value) {
            $("#txtMessagePushNumber").val(value);
        }
        /*
        * 消息编号
       */
        get messagePushNumber() {
            return $("#txtMessagePushNumber").val();
        }
        /*
        * 消息标题
       */
        set messageTitle(value) {
            $("#txtMessageTitle").val(value);
        }
        /*
        * 消息标题
       */
        get messageTitle() {
            return $("#txtMessageTitle").val();
        }
        /*
        * 消息标题
       */
        get MessageTitle_q() {
            return $("#txtMessageTitle_q").val();
        }
        /*
        * 消息类型Id
       */
        set messageTypeId(value) {
            $("#txtMessageTypeId").val(value);
        }
        /*
        * 消息类型Id
       */
        get messageTypeId() {
            return $("#txtMessageTypeId").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 接收人员
       */
        set receivePeople(value) {
            $("#txtReceivePeople").val(value);
        }
        /*
        * 接收人员
       */
        get receivePeople() {
            return $("#txtReceivePeople").val();
        }
        /*
        * 接收人员
       */
        get ReceivePeople_q() {
            return $("#txtReceivePeople_q").val();
        }
        /*
        * 修改日期
       */
        set updDate(value) {
            $("#txtUpdDate").val(value);
        }
        /*
        * 修改日期
       */
        get updDate() {
            return $("#txtUpdDate").val();
        }
    }
    exports.MessagePush_QUDI_TS = MessagePush_QUDI_TS;
});
