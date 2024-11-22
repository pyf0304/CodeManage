(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js", "../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateEN.js", "../../TS/L3_ForWApi/SystemSet_Share/clsCacheModeWApi.js", "../../TS/L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseState_Edit = void 0;
    /**
    * 类名:CacheUseState_Edit(界面:CacheUseStateCRUD)
    * 表名:CacheUseState(00050566)
    * 版本:2022.12.12.1(服务器:WIN-SRV103-116)
    * 日期:2022/12/13 05:51:09
    * 生成者:
    工程名称:AGC(0005)
    CM工程:AgcSpa前端(变量首字母小写)-WebApi函数集
    * 相关数据库:103.116.76.183,9433AGC_CS12
    * PrjDataBaseId:0005
    * 模块中文名:系统设置(SystemSet)
    * 框架-层名:WA_编辑区后台_TS(TS)(WA_ViewScript_EditCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsPageDispModeEN_js_1 = require("../../TS/L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsCacheUseStateEN_js_1 = require("../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateEN.js");
    //import { clsCacheUseStateEN } from "../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateEN.js";
    const clsCacheModeWApi_js_1 = require("../../TS/L3_ForWApi/SystemSet_Share/clsCacheModeWApi.js");
    const clsCacheUseStateWApi_js_1 = require("../../TS/L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /** CacheUseState_Edit 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:GeneCode)
    **/
    class CacheUseState_Edit {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.iShowList = objShowList;
            CacheUseState_Edit.objPage_Edit = this;
            this.objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
        }
        /**
        * 在当前界面中，导入编辑区域
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        * @returns
        **/
        async AddDPV_Edit(divName4Edit) {
            const strThisFuncName = this.AddDPV_Edit.name;
            (0, clsCommFunc4Ctrl_js_1.CheckDivExist)(divName4Edit);
            const strUrl = "../SystemSet/CacheUseState_Edit";
            //console.log("divName4Edit:(In AddDPV_Edit)" + divName4Edit);
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
        /** 函数功能:页面导入,当页面开始运行时所发生的事件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
        **/
        async Page_Load() {
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:设置事件函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
        **/
        async SetEventFunc() {
            const strThisFuncName = this.SetEventFunc.name;
            // 在此处放置用户代码以初始化页面
            try {
                //没有定义相关事件
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("设置事件函数不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 显示对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
        **/
        ShowDialog_CacheUseState(strOp) {
            const strThisFuncName = this.ShowDialog_CacheUseState.name;
            //检查相关控件是否存在
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_CacheUseState");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "h4", "lblDialogTitle_CacheUseState");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_CacheUseState').html('添加记录');
                //CacheUseState_EditEx.GetMaxStrId('#txtmId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_CacheUseState').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_CacheUseState').hide();
                $('#lblDialogTitle_CacheUseState').html('详细信息');
            }
            ShowDialog('#divEditDialog_CacheUseState');
        }
        /**
        * 隐藏对话框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_CacheUseState() {
            const strThisFuncName = this.HideDialog_CacheUseState.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Edit, "div", "divEditDialog_CacheUseState");
            HideDialog('#divEditDialog_CacheUseState');
        }
        /** 添加新记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
        **/
        async btnAddNewRecord_Click() {
            const strThisFuncName = this.btnAddNewRecord_Click.name;
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Add";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_CacheUseState = "确认添加";
                    this.btnCancel_CacheUseState = "取消添加";
                    const responseText = this.AddNewRecord();
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Add');
                    }
                }
                else {
                    this.opType = "Add";
                    this.btnSubmit_CacheUseState = "确认添加";
                    this.btnCancel_CacheUseState = "取消添加";
                    const responseText = await this.AddNewRecord();
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Add');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 添加新记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
        **/
        async btnAddNewRecordWithMaxId_Click() {
            const strThisFuncName = this.btnAddNewRecordWithMaxId_Click.name;
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "AddWithMaxId";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_CacheUseState = "确认添加";
                    this.btnCancel_CacheUseState = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Add');
                    }
                }
                else {
                    this.opType = "AddWithMaxId";
                    this.btnSubmit_CacheUseState = "确认添加";
                    this.btnCancel_CacheUseState = "取消添加";
                    const responseText = this.AddNewRecordWithMaxId();
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Add');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加新记录初始化不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[CacheModeId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdlInDiv_TS4TabFeature)
        **/
        async SetDdl_CacheModeIdInDiv() {
            await (0, clsCacheModeWApi_js_1.CacheMode_BindDdl_CacheModeIdByInUseInDiv_Cache)(this.divName4Edit, "ddlCacheModeId", true); //
        }
        /** 函数功能:为编辑区绑定下拉框
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegionInDiv)
        **/
        async BindDdl4EditRegionInDiv() {
            const strThisFuncName = this.BindDdl4EditRegionInDiv.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_CacheModeIdInDiv(); //编辑区域
        }
        /** 在数据表里修改记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
        **/
        async btnUpdateRecordInTab_Click(strKeyId) {
            const strThisFuncName = this.btnUpdateRecordInTab_Click.name;
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Update";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_CacheUseState = "确认修改";
                    this.btnCancel_CacheUseState = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    this.UpdateRecord(lngKeyId);
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_CacheUseState = "确认修改";
                    this.btnCancel_CacheUseState = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    this.UpdateRecord(lngKeyId);
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Update');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 修改记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
        **/
        async btnUpdateRecord_Click(strKeyId) {
            const strThisFuncName = this.btnUpdateRecord_Click.name;
            if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                const strMsg = "修改记录的关键字为空，请检查！";
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    this.opType = "Update";
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegionInDiv();
                    this.SetEventFunc();
                    this.bolIsLoadEditRegion = true; //
                    this.btnSubmit_CacheUseState = "确认修改";
                    this.btnCancel_CacheUseState = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    const update = await this.UpdateRecord(lngKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Update');
                    }
                }
                else {
                    this.opType = "Update";
                    this.btnSubmit_CacheUseState = "确认修改";
                    this.btnCancel_CacheUseState = "取消修改";
                    const lngKeyId = Number(strKeyId);
                    const update = await this.UpdateRecord(lngKeyId);
                    if (update == false) {
                        const strMsg = (0, clsString_js_1.Format)("在修改记录时,显示记录数据不成功!");
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                        this.ShowDialog_CacheUseState('Update');
                    }
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0034)在修改记录时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
        * 具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
        **/
        async btnSubmit_Click() {
            const strThisFuncName = this.btnSubmit_Click.name;
            const strCommandText = this.btnSubmit_CacheUseState;
            try {
                let returnBool = false;
                const returnKeyId = 0;
                let strInfo = "";
                let strMsg = "";
                switch (strCommandText) {
                    case "添加":
                        this.btnSubmit_CacheUseState = "确认添加";
                        this.btnCancel_CacheUseState = "取消添加";
                        await this.AddNewRecord();
                        break;
                    case "确认添加":
                        //这是一个单表的插入的代码,由于逻辑层太简单,
                        //就把逻辑层合并到控制层,
                        if (this.opType == "AddWithMaxId") {
                            //const returnKeyId = await this.AddNewRecordWithMaxIdSave();
                            //if (IsNullOrEmpty(returnKeyId) == false)
                            //{
                            //HideDialog_CacheUseState();
                            //this.iShowList.BindGv_Cache(clsCacheUseStateEN._CurrTabName, "");
                            //}
                        }
                        else {
                            returnBool = await this.AddNewRecordSave();
                            if (returnBool == true) {
                                if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                    this.HideDialog_CacheUseState();
                                }
                                this.iShowList.BindGv_Cache(clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, returnBool.toString());
                            }
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        returnBool = await this.UpdateRecordSave();
                        strInfo = returnBool ? "修改成功！" : "修改不成功！";
                        strInfo += "(In CacheUseState_Edit.btnSubmit_Click)";
                        //显示信息框
                        //console.log(strInfo);
                        alert(strInfo);
                        if (returnBool == true) {
                            if (CacheUseState_Edit.strPageDispModeId == clsPageDispModeEN_js_1.enumPageDispMode.PopupBox_01) {
                                this.HideDialog_CacheUseState();
                            }
                            this.iShowList.BindGv_Cache(clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, returnBool.toString());
                        }
                        break;
                    default:
                        strMsg = (0, clsString_js_1.Format)("strCommandText:{0}在switch中没有处理！(In btnSubmit_Click())", strCommandText);
                        console.error(strMsg);
                        alert(strMsg);
                        break;
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid: WiTsCs0033)在保存记录时({3})时出错!请联系管理员!{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName, strCommandText);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
         * 清除用户自定义控件中，所有控件的值
         * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_Clear)
         **/
        Clear() {
            const strThisFuncName = this.Clear.name;
            $('#ddlCacheModeId option[0]').attr("selected", "true");
            this.cacheKey = "";
            this.cacheSize = 0;
            this.memo = "";
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
        **/
        async AddNewRecord() {
            const strThisFuncName = this.AddNewRecord.name;
            this.Clear();
            //wucCacheUseStateB1.mId = CacheUseState_GetMaxStrId_S();
        }
        /** 为插入记录做准备工作
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
        **/
        AddNewRecordWithMaxId() {
            const strThisFuncName = this.AddNewRecordWithMaxId.name;
            this.Clear();
            //wucCacheUseStateB1.mId = CacheUseState_GetMaxStrId_S();
        }
        /** 函数功能:把界面上的属性数据传到类对象中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
        * @param pobjCacheUseStateEN">数据传输的目的类对象</param>
        **/
        async PutDataToCacheUseStateClass(pobjCacheUseStateEN) {
            const strThisFuncName = this.PutDataToCacheUseStateClass.name;
            pobjCacheUseStateEN.SetCacheModeId(this.cacheModeId); // 缓存方式Id
            pobjCacheUseStateEN.SetCacheKey(this.cacheKey); // 缓存关键字
            pobjCacheUseStateEN.SetCacheSize(this.cacheSize); // 缓存大小
            pobjCacheUseStateEN.SetMemo(this.memo); // 说明
            pobjCacheUseStateEN.SetUserId(CacheUseState_Edit.UserId_Static); // 用户Id
        }
        /** 添加新记录，保存函数
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
        **/
        async AddNewRecordSave() {
            const strThisFuncName = this.AddNewRecordSave.name;
            const objCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            try {
                await this.PutDataToCacheUseStateClass(objCacheUseStateEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("从界面获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                (0, clsCacheUseStateWApi_js_1.CacheUseState_CheckPropertyNew)(objCacheUseStateEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_UserId_CacheModeId_CacheKey = await this.CheckUniCond4Add_UserId_CacheModeId_CacheKey(objCacheUseStateEN);
                if (bolIsExistCond_UserId_CacheModeId_CacheKey == false) {
                    return false;
                }
                let returnBool = false;
                returnBool = await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseStateEN);
                if (returnBool == true) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(CacheUseState_Edit.UserId_Cache);
                    const strInfo = (0, clsString_js_1.Format)("添加记录成功!");
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    const strInfo = (0, clsString_js_1.Format)("添加记录不成功!");
                    $('#lblResult46').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
                return returnBool; //一定要有一个返回值，否则会出错！
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("添加记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
        }
        /** 为添加记录检查唯一性条件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Add)
        **/
        async CheckUniCond4Add_UserId_CacheModeId_CacheKey(objCacheUseStateEN) {
            const strThisFuncName = this.CheckUniCond4Add_UserId_CacheModeId_CacheKey.name;
            const strUniquenessCondition = (0, clsCacheUseStateWApi_js_1.CacheUseState_GetUniCondStr_UserId_CacheModeId_CacheKey)(objCacheUseStateEN);
            const bolIsExistCondition = await (0, clsCacheUseStateWApi_js_1.CacheUseState_IsExistRecordAsync)(strUniquenessCondition);
            if (bolIsExistCondition == true) {
                const strMsg = (0, clsString_js_1.Format)("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /** 为修改记录检查唯一性条件
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_CheckUniCondition4Update)
        **/
        async CheckUniCond4Update_UserId_CacheModeId_CacheKey(objCacheUseStateEN) {
            const strThisFuncName = this.CheckUniCond4Update_UserId_CacheModeId_CacheKey.name;
            const strUniquenessCondition = (0, clsCacheUseStateWApi_js_1.CacheUseState_GetUniCondStr4Update_UserId_CacheModeId_CacheKey)(objCacheUseStateEN);
            const bolIsExistCondition = await (0, clsCacheUseStateWApi_js_1.CacheUseState_IsExistRecordAsync)(strUniquenessCondition);
            if (bolIsExistCondition == true) {
                const strMsg = (0, clsString_js_1.Format)("不能满足唯一性条件。满足条件：{0}的记录已经存在！", strUniquenessCondition);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
            return true;
        }
        /** 函数功能:把以该关键字的记录内容显示在界面上,
       * 在这里是把值传到表控件中
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
        * @param lngmId: 表记录的关键字,显示该表关键字的内容
        **/
        async ShowData(lngmId) {
            const strThisFuncName = this.ShowData.name;
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            let objCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            try {
                const returnBool = await (0, clsCacheUseStateWApi_js_1.CacheUseState_IsExistAsync)(lngmId);
                if (returnBool == false) {
                    const strInfo = (0, clsString_js_1.Format)("关键字:[{0}] 的记录不存在!", lngmId);
                    //$('#lblResult1').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查相应关键字的记录存在不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            try {
                const objCacheUseStateEN_Const = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                if (objCacheUseStateEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                objCacheUseStateEN = objCacheUseStateEN_Const;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromCacheUseStateClass(objCacheUseStateEN);
        }
        /** 函数功能:把类对象的属性内容显示到界面上
        * 注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
        * 如果在设置数据库时,就应该一级字段在前,二级字段在后
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
        * @param pobjCacheUseStateEN">表实体类对象</param>
        **/
        GetDataFromCacheUseStateClass(pobjCacheUseStateEN) {
            const strThisFuncName = this.GetDataFromCacheUseStateClass.name;
            this.cacheModeId = pobjCacheUseStateEN.cacheModeId; // 缓存方式Id
            this.cacheKey = pobjCacheUseStateEN.cacheKey; // 缓存关键字
            this.cacheSize = pobjCacheUseStateEN.cacheSize; // 缓存大小
            this.memo = pobjCacheUseStateEN.memo; // 说明
        }
        /** 根据关键字获取相应的记录的对象
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
        * @param sender">参数列表</param>
        **/
        async UpdateRecord(lngmId) {
            const strThisFuncName = this.UpdateRecord.name;
            this.keyId = lngmId.toString();
            try {
                const objCacheUseStateEN_Const = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                if (objCacheUseStateEN_Const == null) {
                    const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象为空.(in {0}.{1})", this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return false;
                }
                this.objCacheUseState = objCacheUseStateEN_Const;
                const conGetDataFromClass = await this.GetDataFromCacheUseStateClass(objCacheUseStateEN_Const);
                console.log("完成UpdateRecord!");
                return true;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
        /** 修改记录
        * (AutoGCLib.WA_ViewScript_EditCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
        **/
        async UpdateRecordSave() {
            const strThisFuncName = this.UpdateRecordSave.name;
            const objCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseStateEN.SetmId(Number(this.keyId));
            await this.PutDataToCacheUseStateClass(objCacheUseStateEN);
            objCacheUseStateEN.sf_UpdFldSetStr = objCacheUseStateEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objCacheUseStateEN.mId == 0 || objCacheUseStateEN.mId == undefined) {
                console.error("关键字不能为空!");
                throw (0, clsString_js_1.Format)("关键字不能为空!(in {0}.{1})", this.constructor.name, strThisFuncName);
            }
            try {
                (0, clsCacheUseStateWApi_js_1.CacheUseState_CheckProperty4Update)(objCacheUseStateEN);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("检查数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false; //一定要有一个返回值，否则会出错！
            }
            try {
                //检查唯一性条件
                const bolIsExistCond_UserId_CacheModeId_CacheKey = await this.CheckUniCond4Update_UserId_CacheModeId_CacheKey(objCacheUseStateEN);
                if (bolIsExistCond_UserId_CacheModeId_CacheKey == false) {
                    return false;
                }
                const returnBool = await (0, clsCacheUseStateWApi_js_1.CacheUseState_UpdateRecordAsync)(objCacheUseStateEN);
                if (returnBool == true) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(CacheUseState_Edit.UserId_Cache);
                }
                return returnBool;
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("修改记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return false;
            }
        }
        /**
        * 设置取消按钮的标题(Used In AddNewRecord())
        **/
        set btnCancel_CacheUseState(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnCancel_CacheUseState", value);
        }
        /**
        * 获取按钮的标题
        **/
        get btnSubmit_CacheUseState() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetButtonHtmlInDiv)(this.divName4Edit, "btnSubmit_CacheUseState");
            return strValue;
        }
        /**
        * 设置确定按钮的标题(Used In AddNewRecord())
        **/
        set btnSubmit_CacheUseState(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Edit, "btnSubmit_CacheUseState", value);
        }
        /**
        * 缓存关键字 (Used In Clear())
        **/
        set cacheKey(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCacheKey", value);
        }
        /**
        * 缓存关键字 (Used In PutDataToClass())
        **/
        get cacheKey() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCacheKey");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 缓存方式Id (Used In Clear())
        **/
        set cacheModeId(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Edit, "ddlCacheModeId", value);
        }
        /**
        * 缓存方式Id (Used In PutDataToClass())
        **/
        get cacheModeId() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Edit, "ddlCacheModeId");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 缓存大小 (Used In Clear())
        **/
        set cacheSize(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtCacheSize", value.toString());
        }
        /**
        * 缓存大小 (Used In PutDataToClass())
        **/
        get cacheSize() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtCacheSize");
            if (strValue == undefined)
                return 0;
            else if ((0, clsString_js_1.IsNullOrEmpty)(strValue) == true)
                return 0;
            else
                return Number(strValue);
        }
        /**
        * 说明 (Used In Clear())
        **/
        set memo(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Edit, "txtMemo", value);
        }
        /**
        * 说明 (Used In PutDataToClass())
        **/
        get memo() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Edit, "txtMemo");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
    }
    exports.CacheUseState_Edit = CacheUseState_Edit;
    CacheUseState_Edit.UserId_Cache = "";
    CacheUseState_Edit.UserId_Static = "";
    CacheUseState_Edit.strPageDispModeId = "01"; //PopupBox(弹出框)
});
