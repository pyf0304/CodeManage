(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js", "../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js", "../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js", "../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js", "../TS/PubFun/clsPager.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TeachingDate_Edit = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_TeachingDate_Edit
    表名:gs_TeachingDate(01120684)
    生成代码版本:2020.07.25.1
    生成日期:2020/07/27 14:20:25
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
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
    const clsgs_TeachingDateEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsgs_TeachingDateEN.js");
    const clsvgs_TeachingDateEN_js_1 = require("../TS/L0_Entity/GraduateEduTools/clsvgs_TeachingDateEN.js");
    const clsgs_TeachingDateWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduTools/clsgs_TeachingDateWApi.js");
    const clsgs_TotalDataStatisticsExWApi_js_1 = require("../TS/L3_ForWApiEx/GraduateEduTools/clsgs_TotalDataStatisticsExWApi.js");
    const clsPager_js_1 = require("../TS/PubFun/clsPager.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* gs_TeachingDate_Edit 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    */
    class gs_TeachingDate_Edit {
        constructor(objShowList) {
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.objPager = new clsPager_js_1.clsPager();
            this.RecCount = 0;
            this.iShowList = objShowList;
            gs_TeachingDate_Edit.objPage_Edit = this;
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
            var strUrl = "../GraduateEduTools/gs_TeachingDate_Edit/";
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
                    ShowDialog_gs_TeachingDate('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog_gs_TeachingDate('Add');
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
                    ShowDialog_gs_TeachingDate('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog_gs_TeachingDate('Add');
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
                ShowDialog_gs_TeachingDate('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog_gs_TeachingDate('Update');
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
                ShowDialog_gs_TeachingDate('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                const update = await this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog_gs_TeachingDate('Update');
                var lngKeyId = Number(strKeyId);
                const update = await this.UpdateRecord(lngKeyId);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_gs_TeachingDate;
            //判断如果教学班文本框没有数据，那么就取标题栏下拉框的缓存数据
            if ($("#txtid_CurrEduCls").val() == "") {
                var strId_CurrEduCls = clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls();
            }
            else {
                var strId_CurrEduCls = $("#txtid_CurrEduCls").val();
            }
            try {
                //判断session是否失效
                if (clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId() != "") {
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
                                //HideDialog_gs_TeachingDate();
                                //this.iShowList.BindGv_Cache(clsvgs_TeachingDateEN._CurrTabName);
                                //}
                                //});
                            }
                            else {
                                const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                    var returnBool = jsonData;
                                    if (returnBool == true) {
                                        HideDialog_gs_TeachingDate();
                                        this.iShowList.BindGv(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, "");
                                        //数据同步；
                                        const responseText4 = (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strId_CurrEduCls, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                                        var returnBool3 = !!responseText4;
                                        if (returnBool3 == true) {
                                            console.log("同步成功");
                                        }
                                        else {
                                            console.log("同步失败");
                                        }
                                    }
                                });
                            }
                            break;
                        case "确认修改":
                            //这是一个单表的修改的代码,由于逻辑层太简单,
                            const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                                strInfo += "(In gs_TeachingDate_Edit.btnSubmit_Click)";
                                $('#lblResult51').val(strInfo);
                                //显示信息框
                                console.log(strInfo);
                                alert(strInfo);
                                if (returnBool == true) {
                                    HideDialog_gs_TeachingDate();
                                    this.iShowList.BindGv(clsvgs_TeachingDateEN_js_1.clsvgs_TeachingDateEN._CurrTabName, "");
                                    //数据同步；
                                    const responseText4 = (0, clsgs_TotalDataStatisticsExWApi_js_1.gs_TotalDataStatisticsEx_GetTotalStatisticsByTableAsync)(strId_CurrEduCls, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                                    var returnBool3 = !!responseText4;
                                    if (returnBool3 == true) {
                                        console.log("同步成功");
                                    }
                                    else {
                                        console.log("同步失败");
                                    }
                                }
                            });
                            break;
                        default:
                            var strMsg = `strCommandText:${strCommandText}在switch中没有处理！(In btnSubmit_Click())`;
                            alert(strMsg);
                            break;
                    }
                }
                else {
                    alert("登录超时，请重新登录");
                    window.top.location.href = "../Web/Login";
                }
                $("#divLoading").hide();
                //去掉提交按钮不可用状态
                $('#btnOKUpd').attr("disabled", false);
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
            this.btnSubmit_gs_TeachingDate = "确认添加";
            this.btnCancel_gs_TeachingDate = "取消添加";
            this.Clear();
            //wucgs_TeachingDateB1.mId = clsgs_TeachingDateBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnSubmit_gs_TeachingDate = "确认添加";
            this.btnCancel_gs_TeachingDate = "取消添加";
            this.Clear();
            //wucgs_TeachingDateB1.mId = clsgs_TeachingDateBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjgs_TeachingDateEN">数据传输的目的类对象</param>
       */
        PutDataTogs_TeachingDateClass(pobjgs_TeachingDateEN) {
            pobjgs_TeachingDateEN.id_CurrEduCls = this.id_CurrEduCls; // 当前教学班流水号
            pobjgs_TeachingDateEN.startDate = this.startDate; // 开始日期
            pobjgs_TeachingDateEN.endDate = this.endDate; // 截止日期
            pobjgs_TeachingDateEN.updDate = this.updDate; // 修改日期
            pobjgs_TeachingDateEN.updUser = this.updUser; // 修改人
            pobjgs_TeachingDateEN.memo = this.memo; // 备注
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objgs_TeachingDateEN = new clsgs_TeachingDateEN_js_1.clsgs_TeachingDateEN();
            this.PutDataTogs_TeachingDateClass(objgs_TeachingDateEN);
            try {
                const responseText2 = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_AddNewRecordAsync)(objgs_TeachingDateEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    //gs_TeachingDate_ReFreshCache(gs_TeachingDate_Edit.strid_CurrEduCls_Cache);
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
         <param name = "lngmId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(lngmId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objgs_TeachingDateEN = new clsgs_TeachingDateEN_js_1.clsgs_TeachingDateEN();
            try {
                const responseText = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_IsExistAsync)(lngmId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${lngmId}] 的记录不存在!`;
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
                const responseText = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetObjBymIdAsync)(lngmId);
                objgs_TeachingDateEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromgs_TeachingDateClass(objgs_TeachingDateEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjgs_TeachingDateEN">表实体类对象</param>
       */
        GetDataFromgs_TeachingDateClass(pobjgs_TeachingDateEN) {
            this.id_CurrEduCls = pobjgs_TeachingDateEN.id_CurrEduCls; // 当前教学班流水号
            this.startDate = pobjgs_TeachingDateEN.startDate; // 开始日期
            this.endDate = pobjgs_TeachingDateEN.endDate; // 截止日期
            this.updDate = pobjgs_TeachingDateEN.updDate; // 修改日期
            this.updUser = pobjgs_TeachingDateEN.updUser; // 修改人
            this.memo = pobjgs_TeachingDateEN.memo; // 备注
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(lngmId) {
            this.btnSubmit_gs_TeachingDate = "确认修改";
            this.btnCancel_gs_TeachingDate = "取消修改";
            this.KeyId = lngmId.toString();
            try {
                const responseText = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_GetObjBymIdAsync)(lngmId);
                var objgs_TeachingDateEN = responseText;
                const conGetDataFromClass = await this.GetDataFromgs_TeachingDateClass(objgs_TeachingDateEN);
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
            var objgs_TeachingDateEN = new clsgs_TeachingDateEN_js_1.clsgs_TeachingDateEN();
            objgs_TeachingDateEN.mId = Number(this.KeyId);
            this.PutDataTogs_TeachingDateClass(objgs_TeachingDateEN);
            objgs_TeachingDateEN.sf_UpdFldSetStr = objgs_TeachingDateEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objgs_TeachingDateEN.mId == 0 || objgs_TeachingDateEN.mId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsgs_TeachingDateWApi_js_1.gs_TeachingDate_UpdateRecordAsync)(objgs_TeachingDateEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    //gs_TeachingDate_ReFreshCache(gs_TeachingDate_Edit.strid_CurrEduCls_Cache);
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
        set btnCancel_gs_TeachingDate(value) {
            $("#btnCancel_gs_TeachingDate").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_gs_TeachingDate() {
            return $("#btnSubmit_gs_TeachingDate").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_gs_TeachingDate(value) {
            $("#btnSubmit_gs_TeachingDate").html(value);
        }
        /*
        * 添加、修改用的层名
       */
        set DivName(value) {
            $("#hidDivName").val(value);
        }
        /*
        * 截止日期 (Used In Clear())
       */
        set endDate(value) {
            $("#txtEndDate").val(value);
        }
        /*
        * 截止日期 (Used In PutDataToClass())
       */
        get endDate() {
            return $("#txtEndDate").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvgs_TeachingDateBy(value) {
            $("#hidSortvgs_TeachingDateBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_TeachingDateBy() {
            return $("#hidSortvgs_TeachingDateBy").val();
        }
        /*
        * 当前教学班流水号 (Used In Clear())
       */
        set id_CurrEduCls(value) {
            $("#txtid_CurrEduCls").val(value);
        }
        /*
        * 当前教学班流水号 (Used In PutDataToClass())
       */
        get id_CurrEduCls() {
            return $("#txtid_CurrEduCls").val();
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
        * 开始日期 (Used In Clear())
       */
        set startDate(value) {
            $("#txtStartDate").val(value);
        }
        /*
        * 开始日期 (Used In PutDataToClass())
       */
        get startDate() {
            return $("#txtStartDate").val();
        }
        /*
        * 修改日期 (Used In Clear())
       */
        set updDate(value) {
            $("#txtUpdDate").val(value);
        }
        /*
        * 修改日期 (Used In PutDataToClass())
       */
        get updDate() {
            return $("#txtUpdDate").val();
        }
        /*
        * 修改人 (Used In Clear())
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改人 (Used In PutDataToClass())
       */
        get updUser() {
            return $("#txtUpdUser").val();
        }
    }
    exports.gs_TeachingDate_Edit = gs_TeachingDate_Edit;
    gs_TeachingDate_Edit.strid_CurrEduCls_Cache = "99999991";
});
