(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/FunClass/clsPubFun4Web.js", "../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js", "../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js", "../TS/L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js", "../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesWApi.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_MeetingMinutes_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_MeetingMinutes_Edit
    表名:gs_MeetingMinutes(01120770)
    生成代码版本:2020.11.22.1
    生成日期:2020/11/25 22:11:15
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培主题
    模块英文名:GraduateEduTopic
    框架-层名:WA_编辑区后台_TS(WA_ViewScript_EditCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPubFun4Web_js_1 = require("../TS/FunClass/clsPubFun4Web.js");
    const clsgs_MeetingMinutesEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsgs_MeetingMinutesEN.js");
    const clsResearchTopicEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsResearchTopicEN.js");
    const clsvgs_MeetingMinutesEN_js_1 = require("../TS/L0_Entity/GraduateEduTopic/clsvgs_MeetingMinutesEN.js");
    const clsgs_MeetingMinutesWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTopic/clsgs_MeetingMinutesWApi.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* gs_MeetingMinutes_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    */
    class gs_MeetingMinutes_Edit {
        constructor(objShowList) {
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divMeetingMinutesEdit"; //编辑区的Id
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
            this.iShowList = objShowList;
            gs_MeetingMinutes_Edit.objPage_Edit = this;
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
            var strUrl = "./gs_MeetingMinutes_Edit/";
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
                    ShowDialog_gs_MeetingMinutes('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog_gs_MeetingMinutes('Add');
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
            var strid_CurrEduCls = ""; //定义条件字段
            const ddlTopicId = await this.SetDdl_TopicId(strid_CurrEduCls); //编辑区域
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
                    ShowDialog_gs_MeetingMinutes('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog_gs_MeetingMinutes('Add');
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
        /// 设置绑定下拉框，针对字段:[topicId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS)
        /// </summary>
        async SetDdl_TopicId(strid_CurrEduCls) {
            var objResearchTopic_Cond = new clsResearchTopicEN_js_1.clsResearchTopicEN(); //编辑区域
            //定义条件字段
            //var strid_CurrEduCls = "";//定义条件字段
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
                ShowDialog_gs_MeetingMinutes('Update');
                this.bolIsLoadEditRegion = true; //
                this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog_gs_MeetingMinutes('Update');
                this.UpdateRecord(strKeyId);
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
                ShowDialog_gs_MeetingMinutes('Update');
                this.bolIsLoadEditRegion = true; //
                const update = await this.UpdateRecord(strKeyId);
            }
            else {
                ShowDialog_gs_MeetingMinutes('Update');
                const update = await this.UpdateRecord(strKeyId);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_MeetingMinutes;
            try {
                switch (strCommandText) {
                    case "添加":
                        const responseText1 = await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.OpType == "AddWithMaxId") {
                            const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData) => {
                                var returnKeyId = jsonData;
                                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                                    HideDialog_gs_MeetingMinutes();
                                    this.iShowList.BindGv(clsvgs_MeetingMinutesEN_js_1.clsvgs_MeetingMinutesEN._CurrTabName, "");
                                }
                            });
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_gs_MeetingMinutes();
                                    this.iShowList.BindGv(clsvgs_MeetingMinutesEN_js_1.clsvgs_MeetingMinutesEN._CurrTabName, "");
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In gs_MeetingMinutes_Edit.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_gs_MeetingMinutes();
                                this.iShowList.BindGv(clsvgs_MeetingMinutesEN_js_1.clsvgs_MeetingMinutesEN._CurrTabName, "");
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
        /// 在用户自定义控件中，设置关键字的值，是否只读
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetKeyReadOnly)
        /// </summary>
        /// <param name = "bolReadonly">是否只读</param>
        SetKeyReadOnly(bolReadonly) {
            $('#txtMeetingId').prop['ReadOnly'] = bolReadonly;
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.meetingId = "";
            $('#ddlTopicId option[0]').attr("selected", true);
            this.isSubmit = false;
            this.meetingContent = "";
            this.meetingDate = "";
            this.memo = "";
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_gs_MeetingMinutes = "确认添加";
            this.btnCancel_gs_MeetingMinutes = "取消添加";
            this.Clear();
            //wucgs_MeetingMinutesB1.meetingId = clsgs_MeetingMinutesBL.GetMaxStrId_S();
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_GetMaxStrIdAsync)();
                var returnString = responseText;
                if (returnString == "") {
                    var strInfo = `获取表gs_MeetingMinutes的最大关键字为空，不成功，请检查!`;
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    $('#txtMeetingId').val(returnString);
                    $('#txtMeetingDate').val(clsPubFun4Web_js_1.clsPubFun4Web.getNowDate_ymd());
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnSubmit_gs_MeetingMinutes = "确认添加";
            this.btnCancel_gs_MeetingMinutes = "取消添加";
            this.Clear();
            //wucgs_MeetingMinutesB1.meetingId = clsgs_MeetingMinutesBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_MeetingMinutesEN">数据传输的目的类对象</param>
       */
        PutDataTogs_MeetingMinutesClass(pobjgs_MeetingMinutesEN) {
            pobjgs_MeetingMinutesEN.meetingId = this.meetingId; // 会议Id
            pobjgs_MeetingMinutesEN.topicId = this.topicId; // 主题编号
            pobjgs_MeetingMinutesEN.isSubmit = this.isSubmit; // 是否提交
            pobjgs_MeetingMinutesEN.meetingContent = this.meetingContent; // 会议内容
            pobjgs_MeetingMinutesEN.meetingDate = this.meetingDate; // 会议日期
            pobjgs_MeetingMinutesEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
            this.PutDataTogs_MeetingMinutesClass(objgs_MeetingMinutesEN);
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_IsExistAsync)(objgs_MeetingMinutesEN.meetingId);
                var bolIsExist = responseText;
                if (bolIsExist == true) {
                    var strMsg = `添加记录时，关键字：${objgs_MeetingMinutesEN.meetingId}已经存在！`;
                    alert(strMsg);
                    return responseText; //一定要有一个返回值，否则会出错！
                }
                const responseText2 = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_AddNewRecordAsync)(objgs_MeetingMinutesEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //gs_MeetingMinutes_ReFreshCache();
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
        /* 添加新记录，由后台自动获取最大值的关键字。保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxIdSave)
       */
        async AddNewRecordWithMaxIdSave() {
            this.DivName = "divAddNewRecordWithMaxIdSave";
            var objgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
            this.PutDataTogs_MeetingMinutesClass(objgs_MeetingMinutesEN);
            try {
                const responseKeyId = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_AddNewRecordWithMaxIdAsync)(objgs_MeetingMinutesEN);
                var returnKeyId = responseKeyId;
                if (clsString2_js_1.clsString.IsNullOrEmpty(returnKeyId) == false) {
                    //gs_MeetingMinutes_ReFreshCache();
                    var strInfo = `添加记录成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    var strInfo = `添加记录不成功!`;
                    $('#lblResult47').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return responseKeyId; //一定要有一个返回值，否则会出错！
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
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "strMeetingId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(strMeetingId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_IsExistAsync)(strMeetingId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${strMeetingId}] 的记录不存在!`;
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
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_GetObjByMeetingIdAsync)(strMeetingId);
                objgs_MeetingMinutesEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_MeetingMinutesClass(objgs_MeetingMinutesEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_MeetingMinutesEN">表实体类对象</param>
       */
        GetDataFromgs_MeetingMinutesClass(pobjgs_MeetingMinutesEN) {
            this.meetingId = pobjgs_MeetingMinutesEN.meetingId; // 会议Id
            this.topicId = pobjgs_MeetingMinutesEN.topicId; // 主题编号
            this.isSubmit = pobjgs_MeetingMinutesEN.isSubmit; // 是否提交
            this.meetingContent = pobjgs_MeetingMinutesEN.meetingContent; // 会议内容
            this.meetingDate = pobjgs_MeetingMinutesEN.meetingDate; // 会议日期
            this.memo = pobjgs_MeetingMinutesEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(strMeetingId) {
            this.btnSubmit_gs_MeetingMinutes = "确认修改";
            this.btnCancel_gs_MeetingMinutes = "取消修改";
            this.KeyId = strMeetingId;
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_GetObjByMeetingIdAsync)(strMeetingId);
                var objgs_MeetingMinutesEN = responseText;
                const conGetDataFromClass = await this.GetDataFromgs_MeetingMinutesClass(objgs_MeetingMinutesEN);
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
            var objgs_MeetingMinutesEN = new clsgs_MeetingMinutesEN_js_1.clsgs_MeetingMinutesEN();
            objgs_MeetingMinutesEN.meetingId = this.KeyId;
            this.PutDataTogs_MeetingMinutesClass(objgs_MeetingMinutesEN);
            objgs_MeetingMinutesEN.sf_UpdFldSetStr = objgs_MeetingMinutesEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_MeetingMinutesEN.meetingId == "" || objgs_MeetingMinutesEN.meetingId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsgs_MeetingMinutesWApi_js_1.gs_MeetingMinutes_UpdateRecordAsync)(objgs_MeetingMinutesEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_MeetingMinutes_ReFreshCache();
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
        set btnCancel_gs_MeetingMinutes(value) {
            $("#btnCancel_gs_MeetingMinutes").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_gs_MeetingMinutes() {
            return $("#btnSubmit_gs_MeetingMinutes").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_gs_MeetingMinutes(value) {
            $("#btnSubmit_gs_MeetingMinutes").html(value);
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
        set hidSortvgs_MeetingMinutesBy(value) {
            $("#hidSortvgs_MeetingMinutesBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_MeetingMinutesBy() {
            return $("#hidSortvgs_MeetingMinutesBy").val();
        }
        /*
        * 是否提交 (Used In Clear())
       */
        set isSubmit(value) {
            $("#chkIsSubmit").attr("checked", value);
        }
        /*
        * 是否提交 (Used In PutDataToClass())
       */
        get isSubmit() {
            return $("#chkIsSubmit").prop("checked");
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
        * 会议内容 (Used In Clear())
       */
        set meetingContent(value) {
            $("#txtMeetingContent").val(value);
        }
        /*
        * 会议内容 (Used In PutDataToClass())
       */
        get meetingContent() {
            return $("#txtMeetingContent").val();
        }
        /*
        * 会议日期 (Used In Clear())
       */
        set meetingDate(value) {
            $("#txtMeetingDate").val(value);
        }
        /*
        * 会议日期 (Used In PutDataToClass())
       */
        get meetingDate() {
            return $("#txtMeetingDate").val();
        }
        /*
        * 会议Id (Used In Clear())
       */
        set meetingId(value) {
            $("#txtMeetingId").val(value);
        }
        /*
        * 会议Id (Used In PutDataToClass())
       */
        get meetingId() {
            return $("#txtMeetingId").val();
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
        * 主题编号 (Used In Clear())
       */
        set topicId(value) {
            $("#ddlTopicId").val(value);
        }
        /*
        * 主题编号 (Used In PutDataToClass())
       */
        get topicId() {
            return $("#ddlTopicId").val();
        }
    }
    exports.gs_MeetingMinutes_Edit = gs_MeetingMinutes_Edit;
});
