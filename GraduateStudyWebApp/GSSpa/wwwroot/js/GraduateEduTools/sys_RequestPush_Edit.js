(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js", "../TS/PubFun/clsPager.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.sys_RequestPush_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:sys_RequestPush_Edit
    表名:sys_RequestPush(01120726)
    生成代码版本:2020.09.01.1
    生成日期:2020/09/01 17:03:48
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培设置
    模块英文名:GraduateEduTools
    框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clssys_RequestPushEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clssys_RequestPushEN.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clssys_RequestPushWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clssys_RequestPushWApi.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    /* sys_RequestPush_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
   */
    class sys_RequestPush_Edit {
        constructor(objShowList) {
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
            this.iShowList = objShowList;
            sys_RequestPush_Edit.objPage_Edit = this;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./sys_RequestPush_Edit/";
            console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Edit).html(data);
                        resolve(true);
                        //setTimeout(() => { clsEditObj.BindTab(); }, 100);
                        //clsEditObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        ;
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:设置事件函数
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
       */
        async SetEventFunc() {
            // 在此处放置用户代码以初始化页面
            try {
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    this.SetEventFunc();
                    ShowDialog_sys_RequestPush('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog_sys_RequestPush('Add');
                    const responseText = await this.AddNewRecord();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            const ddlid_CurrEduCls = await this.SetDdl_id_CurrEduCls(); //编辑区域
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    this.SetEventFunc();
                    ShowDialog_sys_RequestPush('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog_sys_RequestPush('Add');
                    const responseText = this.AddNewRecordWithMaxId();
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `添加新记录初始化不成功,${e}.`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[id_CurrEduCls]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_id_CurrEduCls() {
            var objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN(); //编辑区域
            const ddlid_CurrEduCls = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4Edit, "ddlid_CurrEduCls"); //编辑区域
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
       */
        async btnUpdateRecordInTab_Click(strKeyId) {
            this.OpType = "Update";
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                this.SetEventFunc();
                ShowDialog_sys_RequestPush('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog_sys_RequestPush('Update');
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
       */
        async btnUpdateRecord_Click(strKeyId) {
            this.OpType = "Update";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadEditRegion == false) //
             {
                const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                // 为编辑区绑定下拉框
                const conBindDdl = await this.BindDdl4EditRegion();
                this.SetEventFunc();
                ShowDialog_sys_RequestPush('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                const update = await this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog_sys_RequestPush('Update');
                var lngKeyId = Number(strKeyId);
                const update = await this.UpdateRecord(lngKeyId);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_sys_RequestPush;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                            //var returnKeyId: string = <string>jsonData;
                            //if (clsString.IsNullOrEmpty(returnKeyId) == false)
                            //{
                            //HideDialog_sys_RequestPush();
                            //this.iShowList.BindGv_Cache(clssys_RequestPushEN._CurrTabName);
                            //}
                            //});
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_sys_RequestPush();
                                    this.iShowList.BindGv(clssys_RequestPushEN_js_1.clssys_RequestPushEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In sys_RequestPush_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_sys_RequestPush();
                                this.iShowList.BindGv(clssys_RequestPushEN_js_1.clssys_RequestPushEN._CurrTabName, "");
                            }
                        });
                        break;
                    default:
                        var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`;
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                var strMsg = `(errid: WiTsCs0033)在保存记录时(${strCommandText})时出错!请联系管理员!${e}`;
                alert(strMsg);
            }
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_sys_RequestPush = "确认添加";
            this.btnCancel_sys_RequestPush = "取消添加";
            this.Clear();
            //wucsys_RequestPushB1.requestId = clssys_RequestPushBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnSubmit_sys_RequestPush = "确认添加";
            this.btnCancel_sys_RequestPush = "取消添加";
            this.Clear();
            //wucsys_RequestPushB1.requestId = clssys_RequestPushBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjsys_RequestPushEN">数据传输的目的类对象</param>
       */
        PutDataTosys_RequestPushClass(pobjsys_RequestPushEN) {
            pobjsys_RequestPushEN.requesTypeId = this.requesTypeId; // 请求类型Id
            pobjsys_RequestPushEN.tableKey = this.tableKey; // 表主键
            pobjsys_RequestPushEN.receiveUser = this.receiveUser; // 接收用户
            pobjsys_RequestPushEN.isReply = this.isReply; // 是否回复
            pobjsys_RequestPushEN.replyDate = this.replyDate; // 回复日期
            pobjsys_RequestPushEN.requestUser = this.requestUser; // requestUser
            pobjsys_RequestPushEN.requestDate = this.requestDate; // requestDate
            pobjsys_RequestPushEN.requestStata = this.requestStata; // requestStata
            pobjsys_RequestPushEN.memo = this.memo; // 备注
            pobjsys_RequestPushEN.id_CurrEduCls = this.id_CurrEduCls; // 当前教学班流水号
            pobjsys_RequestPushEN.pushTypeId = this.pushTypeId; // 推送类型Id
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objsys_RequestPushEN = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            this.PutDataTosys_RequestPushClass(objsys_RequestPushEN);
            try {
                const responseText2 = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_AddNewRecordAsync)(objsys_RequestPushEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //sys_RequestPush_ReFreshCache();
                    var strInfo = `添加记录成功!`;
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult46').val(strInfo);
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
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "lngRequestId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(lngRequestId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objsys_RequestPushEN = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_IsExistAsync)(lngRequestId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${lngRequestId}] 的记录不存在!`;
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
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjByRequestIdAsync)(lngRequestId);
                objsys_RequestPushEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromsys_RequestPushClass(objsys_RequestPushEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjsys_RequestPushEN">表实体类对象</param>
       */
        GetDataFromsys_RequestPushClass(pobjsys_RequestPushEN) {
            this.requesTypeId = pobjsys_RequestPushEN.requesTypeId; // 请求类型Id
            this.tableKey = pobjsys_RequestPushEN.tableKey; // 表主键
            this.receiveUser = pobjsys_RequestPushEN.receiveUser; // 接收用户
            this.isReply = pobjsys_RequestPushEN.isReply; // 是否回复
            this.replyDate = pobjsys_RequestPushEN.replyDate; // 回复日期
            this.requestUser = pobjsys_RequestPushEN.requestUser; // requestUser
            this.requestDate = pobjsys_RequestPushEN.requestDate; // requestDate
            this.requestStata = pobjsys_RequestPushEN.requestStata; // requestStata
            this.memo = pobjsys_RequestPushEN.memo; // 备注
            this.id_CurrEduCls = pobjsys_RequestPushEN.id_CurrEduCls; // 当前教学班流水号
            this.pushTypeId = pobjsys_RequestPushEN.pushTypeId; // 推送类型Id
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(lngRequestId) {
            this.btnSubmit_sys_RequestPush = "确认修改";
            this.btnCancel_sys_RequestPush = "取消修改";
            this.KeyId = lngRequestId.toString();
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_GetObjByRequestIdAsync)(lngRequestId);
                var objsys_RequestPushEN = responseText;
                const conGetDataFromClass = await this.GetDataFromsys_RequestPushClass(objsys_RequestPushEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objsys_RequestPushEN = new clssys_RequestPushEN_js_1.clssys_RequestPushEN();
            objsys_RequestPushEN.requestId = Number(this.KeyId);
            this.PutDataTosys_RequestPushClass(objsys_RequestPushEN);
            objsys_RequestPushEN.sf_UpdFldSetStr = objsys_RequestPushEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objsys_RequestPushEN.requestId == 0 || objsys_RequestPushEN.requestId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clssys_RequestPushWApi_js_1.sys_RequestPush_UpdateRecordAsync)(objsys_RequestPushEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //sys_RequestPush_ReFreshCache();
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
        /*
        * 设置取消按钮的标题(Used In AddNewRecord())
       */
        set btnCancel_sys_RequestPush(value) {
            $("#btnCancel_sys_RequestPush").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_sys_RequestPush() {
            return $("#btnSubmit_sys_RequestPush").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_sys_RequestPush(value) {
            $("#btnSubmit_sys_RequestPush").html(value);
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
        set hidSortsys_RequestPushBy(value) {
            $("#hidSortsys_RequestPushBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortsys_RequestPushBy() {
            return $("#hidSortsys_RequestPushBy").val();
        }
        /*
        * 当前教学班流水号 (Used In Clear())
       */
        set id_CurrEduCls(value) {
            $("#ddlid_CurrEduCls").val(value);
        }
        /*
        * 当前教学班流水号 (Used In PutDataToClass())
       */
        get id_CurrEduCls() {
            return $("#ddlid_CurrEduCls").val();
        }
        /*
        * 是否回复 (Used In Clear())
       */
        set isReply(value) {
            $("#chkIsReply").attr("checked", value);
        }
        /*
        * 是否回复 (Used In PutDataToClass())
       */
        get isReply() {
            return $("#chkIsReply").prop("checked");
        }
        /*
        * 设置关键字的值(Used In UpdateRecord())
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
        * 备注 (Used In Clear())
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 备注 (Used In PutDataToClass())
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        set OpType(value) {
            $("#hidOpType").val(value);
        }
        /*
        * 设置操作类型：Add||Update||Detail
       */
        get OpType() {
            return $("#hidOpType").val();
        }
        /*
        * 推送类型Id (Used In Clear())
       */
        set pushTypeId(value) {
            $("#txtPushTypeId").val(value);
        }
        /*
        * 推送类型Id (Used In PutDataToClass())
       */
        get pushTypeId() {
            return $("#txtPushTypeId").val();
        }
        /*
        * 接收用户 (Used In Clear())
       */
        set receiveUser(value) {
            $("#txtReceiveUser").val(value);
        }
        /*
        * 接收用户 (Used In PutDataToClass())
       */
        get receiveUser() {
            return $("#txtReceiveUser").val();
        }
        /*
        * 回复日期 (Used In Clear())
       */
        set replyDate(value) {
            $("#txtReplyDate").val(value);
        }
        /*
        * 回复日期 (Used In PutDataToClass())
       */
        get replyDate() {
            return $("#txtReplyDate").val();
        }
        /*
        * requestDate (Used In Clear())
       */
        set requestDate(value) {
            $("#txtRequestDate").val(value);
        }
        /*
        * requestDate (Used In PutDataToClass())
       */
        get requestDate() {
            return $("#txtRequestDate").val();
        }
        /*
        * requestStata (Used In Clear())
       */
        set requestStata(value) {
            $("#txtRequestStata").val(value);
        }
        /*
        * requestStata (Used In PutDataToClass())
       */
        get requestStata() {
            return $("#txtRequestStata").val();
        }
        /*
        * requestUser (Used In Clear())
       */
        set requestUser(value) {
            $("#txtRequestUser").val(value);
        }
        /*
        * requestUser (Used In PutDataToClass())
       */
        get requestUser() {
            return $("#txtRequestUser").val();
        }
        /*
        * 请求类型Id (Used In Clear())
       */
        set requesTypeId(value) {
            $("#txtRequesTypeId").val(value);
        }
        /*
        * 请求类型Id (Used In PutDataToClass())
       */
        get requesTypeId() {
            return $("#txtRequesTypeId").val();
        }
        /*
        * 表主键 (Used In Clear())
       */
        set tableKey(value) {
            $("#txtTableKey").val(value);
        }
        /*
        * 表主键 (Used In PutDataToClass())
       */
        get tableKey() {
            return $("#txtTableKey").val();
        }
    }
    exports.sys_RequestPush_Edit = sys_RequestPush_Edit;
});
