(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/SystemSet/clsCacheUseStateEN.js", "../TS/L0_Entity/SystemSet/clsvCacheUseStateEN.js", "../TS/L3_ForWApi/SystemSet/clsCacheModeWApi.js", "../TS/L3_ForWApi/SystemSet/clsCacheUseStateWApi.js", "../TS/L3_ForWApi/SystemSet/clsvCacheUseStateWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsPubSessionStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseStateCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:CacheUseStateCRUD
    表名:CacheUseState(00050566)
    生成代码版本:2020.06.27.2
    生成日期:2020/07/03 04:23:25
    生成者:
    工程名称:AGC
    工程ID:0005
    相关数据库:tzar.tpddns.cn,19433AGC_CS12
    PrjDataBaseId:0213
    模块中文名:系统设置
    模块英文名:SystemSet
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsCacheUseStateEN_js_1 = require("../TS/L0_Entity/SystemSet/clsCacheUseStateEN.js");
    const clsvCacheUseStateEN_js_1 = require("../TS/L0_Entity/SystemSet/clsvCacheUseStateEN.js");
    const clsCacheModeWApi_js_1 = require("../TS/L3_ForWApi/SystemSet/clsCacheModeWApi.js");
    const clsCacheUseStateWApi_js_1 = require("../TS/L3_ForWApi/SystemSet/clsCacheUseStateWApi.js");
    const clsvCacheUseStateWApi_js_1 = require("../TS/L3_ForWApi/SystemSet/clsvCacheUseStateWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    /* CacheUseStateCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class CacheUseStateCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadEditRegion = false; //记录是否导入编辑区的变量
            this.bolIsLoadDetailRegion = false; //记录是否导入详细信息区的变量
            this.divName4Edit = "divEdit"; //编辑区的Id
            this.divName4Detail = "divDetail"; //详细信息区的Id
            this.RecCount = 0;
        }
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 5;
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Edit)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Edit(divName4Edit) {
            var strUrl = "./CacheUseState_Edit/";
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
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Detail(divName4Detail) {
            var strUrl = "./vCacheUseState_Detail/";
            console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Detail).html(data);
                        resolve(true);
                        //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
                        //clsDetailObj.BindTab();
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
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCacheUseStateBy = "mId Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCacheUseState_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            var objvCacheUseState_Cond = this.CombinevCacheUseStateConditionObj();
            var strWhereCond = JSON.stringify(objvCacheUseState_Cond);
            try {
                this.RecCount = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetRecCountByCond_Cache)(objvCacheUseState_Cond, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCacheUseStateBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetObjLstByPager_Cache)(objPagerPara, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId()).then((jsonData) => {
                    var arrvCacheUseStateObjLst = jsonData;
                    this.BindTab_vCacheUseState(this.mstrListDiv, arrvCacheUseStateObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecord_Click)
       */
        async btnAddNewRecord_Click() {
            this.OpType = "Add";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog_CacheUseState('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecord();
                }
                else {
                    ShowDialog_CacheUseState('Add');
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
        /* 添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnAddNewRecordWithMaxId_Click)
       */
        async btnAddNewRecordWithMaxId_Click() {
            this.OpType = "AddWithMaxId";
            try {
                if (this.bolIsLoadEditRegion == false) //
                 {
                    const responseBool = await this.AddDPV_Edit(this.divName4Edit);
                    // 为编辑区绑定下拉框
                    const conBindDdl = await this.BindDdl4EditRegion();
                    ShowDialog_CacheUseState('Add');
                    this.bolIsLoadEditRegion = true; //
                    const responseText = this.AddNewRecordWithMaxId();
                }
                else {
                    ShowDialog_CacheUseState('Add');
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
        /* 函数功能:为编辑区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4EditRegion)
       */
        async BindDdl4EditRegion() {
            // 在此处放置用户代码以初始化页面
            const ddlCacheModeId = await (0, clsCacheModeWApi_js_1.CacheMode_BindDdl_CacheModeIdInDiv_Cache)(this.divName4List, "ddlCacheModeId"); //编辑区域
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Js_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面        
            const ddlCacheModeId_q = await (0, clsCacheModeWApi_js_1.CacheMode_BindDdl_CacheModeIdInDiv_Cache)(this.divName4List, "ddlCacheModeId_q"); //查询区域
        }
        /* 在数据表里修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecordInTab_Click)
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
                ShowDialog_CacheUseState('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog_CacheUseState('Update');
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
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
                var lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                const responseBindGv = await this.BindGv_vCacheUseState_Cache();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
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
                var lngKeyId = Number(strKeyId);
                this.SelectRecord(lngKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
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
                var lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `详细信息记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(lngmId) {
            try {
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_DelRecordAsync)(lngmId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
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
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord)
         <param name = "sender">参数列表</param>
       */
        async DetailRecord(lngmId) {
            this.btnSubmit_d_vCacheUseState = "";
            this.btnCancel_d_vCacheUseState = "关闭";
            try {
                const responseText = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetObjBymIdAsync)(lngmId);
                var objvCacheUseStateEN = responseText;
                this.ShowDetailDataFromvCacheUseStateClass(objvCacheUseStateEN);
                console.log("完成DetailRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(lngmId) {
            try {
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                var objCacheUseStateEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vCacheUseState");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpdateRecord_Click)
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
                ShowDialog_CacheUseState('Update');
                this.bolIsLoadEditRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
            else {
                ShowDialog_CacheUseState('Update');
                var lngKeyId = Number(strKeyId);
                this.UpdateRecord(lngKeyId);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecord_Click)
       */
        async btnDetailRecord_Click(strKeyId) {
            this.OpType_d = "Detail";
            //var strKeyId = clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
            if (strKeyId == "") {
                alert("请选择需要修改的记录！");
                return;
            }
            if (this.bolIsLoadDetailRegion == false) //
             {
                const responseBool = await this.AddDPV_Detail(this.divName4Detail);
                // 为编辑区绑定下拉框
                //const conBindDdl = await this.BindDdl4DetailRegion();
                ShowDialog_CacheUseState('Detail');
                this.bolIsLoadDetailRegion = true; //
                var lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
            }
            else {
                ShowDialog_CacheUseState('Detail');
                var lngKeyId = Number(strKeyId);
                this.DetailRecord(lngKeyId);
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
                const responseBindGv = await this.BindGv_vCacheUseState_Cache();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvCacheUseStateObjLst = jsonData;
                    this.BindTab_vCacheUseState(this.mstrListDiv, arrvCacheUseStateObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:事件函数,当单击<确定修改>时发生的事件函数,
         具体功能为把界面内容同步数据库中,把界面内容保存到数据库中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnOKUpd_Click)
       */
        async btnSubmit_Click() {
            var strCommandText = this.btnSubmit_CacheUseState;
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
                            //var returnBool2: boolean = jsonData;
                            //if (returnBool2 == true)
                            //{
                            //HideDialog_CacheUseState();
                            //this.BindGv_vCacheUseState_Cache();
                            //}
                            //});
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog_CacheUseState();
                                    this.BindGv_vCacheUseState_Cache();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            var strInfo = returnBool ? "修改成功！" : "修改不成功！";
                            strInfo += "(In CacheUseStateCRUD.btnSubmit_Click)";
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            console.log(strInfo);
                            alert(strInfo);
                            if (returnBool == true) {
                                HideDialog_CacheUseState();
                                this.BindGv_vCacheUseState_Cache();
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
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevCacheUseStateCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            strWhereCond += `userId =${CacheUseStateCRUD.UserId_Static}`;
            try {
                if (this.CacheModeId_q != "" && this.CacheModeId_q != "0") {
                    strWhereCond += ` And ${clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_CacheModeId} = '${this.CacheModeId_q}'`;
                }
                if (this.CacheKey_q != "") {
                    strWhereCond += ` And ${clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_CacheKey} like '% ${this.CacheKey_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombineCacheUseStateCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevCacheUseStateConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvCacheUseState_Cond = new clsvCacheUseStateEN_js_1.clsvCacheUseStateEN();
            objvCacheUseState_Cond.SetCondFldValue(clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Static, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.CacheModeId_q != "" && this.CacheModeId_q != "0") {
                    strWhereCond += ` And ${clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_CacheModeId} = '${this.CacheModeId_q}'`;
                    objvCacheUseState_Cond.SetCondFldValue(clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_CacheModeId, this.CacheModeId_q, "=");
                }
                if (this.CacheKey_q != "") {
                    strWhereCond += ` And ${clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_CacheKey} like '% ${this.CacheKey_q}%'`;
                    objvCacheUseState_Cond.SetCondFldValue(clsvCacheUseStateEN_js_1.clsvCacheUseStateEN.con_CacheKey, this.CacheKey_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0008)在组合查询条件对象(CombineCacheUseStateConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvCacheUseState_Cond;
        }
        /* 显示vCacheUseState对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrCacheUseStateObjLst">需要绑定的对象列表</param>
       */
        BindTab_vCacheUseState(divContainer, arrvCacheUseStateObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "mId",
                    ColHeader: "mId",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheModeName",
                    ColHeader: "缓存方式名",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheModeENName",
                    ColHeader: "缓存方式英文名",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheKey",
                    ColHeader: "缓存关键字",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "cacheSize",
                    ColHeader: "缓存大小",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "memo",
                    ColHeader: "说明",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "userId",
                    ColHeader: "用户Id",
                    Text: "",
                    TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvCacheUseStateObjLst, arrDataColumn, "mId");
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
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
            this.BindGv_vCacheUseState_Cache();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vCacheUseState_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvCacheUseState_Cond = this.CombinevCacheUseStateConditionObj();
            var strWhereCond = JSON.stringify(objvCacheUseState_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvCacheUseStateObjLst = [];
            try {
                this.RecCount = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetRecCountByCond_Cache)(objvCacheUseState_Cond, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvCacheUseStateBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvCacheUseStateObjLst = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetObjLstByPager_Cache)(objPagerPara, clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrvCacheUseStateObjLst.length == 0) {
                var strKey = `${clsvCacheUseStateEN_js_1.clsvCacheUseStateEN._CurrTabName}_${clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId()}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vCacheUseState(strListDiv, arrvCacheUseStateObjLst);
                console.log("完成BindGv_vCacheUseState!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "strSortByFld">排序的字段</param>
       */
        async SortBy(strSortByFld) {
            if (this.hidSortvCacheUseStateBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvCacheUseStateBy.indexOf("Asc") >= 0) {
                    this.hidSortvCacheUseStateBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvCacheUseStateBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvCacheUseStateBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vCacheUseState_Cache();
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
        }
        // /* 获取当前表关键字值的最大值,再加1,避免重复
        //  (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
        //*/
        //public async GetMaxStrId(strKeyCtrlName) {
        //this.DivName = "divGetMaxStrId";
        //try
        //{
        //const responseText = await CacheUseState_GetMaxStrIdAsync();
        //var returnString: string = responseText.toString();
        //if (returnString == "")
        //{
        //var strInfo: string = `获取表CacheUseState的最大关键字为空，不成功，请检查!`;
        //$('#lblResult40').val(strInfo);
        ////显示信息框
        //alert(strInfo);
        // $(strKeyCtrlName).val(returnString);
        //}
        //else
        //{
        //var strInfo: string = `获取表CacheUseState的最大关键字为：${returnString}!`;
        //$('#lblResult40').val(strInfo);
        ////显示信息框
        //alert(strInfo);
        // $(strKeyCtrlName).val(returnString);
        //}
        //}
        //catch(e)
        //{
        //console.error('catch(e)=');
        //console.error(e);
        //var strMsg: string = `获取表关键字的最大值不成功,${e}.`;
        //alert(strMsg);
        //}
        //}
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecord)
       */
        async AddNewRecord() {
            this.btnSubmit_CacheUseState = "确认添加";
            this.btnCancel_CacheUseState = "取消添加";
            this.Clear();
            //wucCacheUseStateB1.mId = clsCacheUseStateBL.GetMaxStrId_S();
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnSubmit_CacheUseState = "确认添加";
            this.btnCancel_CacheUseState = "取消添加";
            this.Clear();
            //wucCacheUseStateB1.mId = clsCacheUseStateBL.GetMaxStrId_S();
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjCacheUseStateEN">数据传输的目的类对象</param>
       */
        PutDataToCacheUseStateClass(pobjCacheUseStateEN) {
            pobjCacheUseStateEN.cacheModeId = this.cacheModeId; // 缓存方式Id
            pobjCacheUseStateEN.cacheKey = this.cacheKey; // 缓存关键字
            pobjCacheUseStateEN.cacheSize = this.cacheSize; // 缓存大小
            pobjCacheUseStateEN.memo = this.memo; // 说明
            pobjCacheUseStateEN.userId = CacheUseStateCRUD.UserId_Static; // 用户Id
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            this.PutDataToCacheUseStateClass(objCacheUseStateEN);
            try {
                const responseText2 = await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseStateEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
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
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
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
            var objCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            try {
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_IsExistAsync)(lngmId);
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
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                objCacheUseStateEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromCacheUseStateClass(objCacheUseStateEN);
        }
        /* 函数功能:把类对象的属性内容显示到界面上
        注意:如果有两个下拉框,并且是一级、二级连带关系的,请先为一级下拉框赋值,然后再为二级下拉框赋值
         如果在设置数据库时,就应该一级字段在前,二级字段在后
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetDataFromClass)
         <param name = "pobjCacheUseStateEN">表实体类对象</param>
       */
        GetDataFromCacheUseStateClass(pobjCacheUseStateEN) {
            this.cacheModeId = pobjCacheUseStateEN.cacheModeId; // 缓存方式Id
            this.cacheKey = pobjCacheUseStateEN.cacheKey; // 缓存关键字
            this.cacheSize = pobjCacheUseStateEN.cacheSize; // 缓存大小
            this.memo = pobjCacheUseStateEN.memo; // 说明
            this.userId = pobjCacheUseStateEN.userId; // 用户Id
        }
        /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass)
         <param name = "pobjCacheUseStateEN">表实体类对象</param>
       */
        ShowDetailDataFromvCacheUseStateClass(pobjvCacheUseStateEN) {
            this.UserId_d = pobjvCacheUseStateEN.userId; // 用户Id
            this.CacheModeName_d = pobjvCacheUseStateEN.cacheModeName; // 缓存方式名
            this.CacheModeENName_d = pobjvCacheUseStateEN.cacheModeENName; // 缓存方式英文名
            this.CacheKey_d = pobjvCacheUseStateEN.cacheKey; // 缓存关键字
            this.CacheSize_d = pobjvCacheUseStateEN.cacheSize; // 缓存大小
            this.Memo_d = pobjvCacheUseStateEN.memo; // 说明
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        async UpdateRecord(lngmId) {
            this.btnSubmit_CacheUseState = "确认修改";
            this.btnCancel_CacheUseState = "取消修改";
            this.KeyId = lngmId.toString();
            try {
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                var objCacheUseStateEN = responseText;
                this.GetDataFromCacheUseStateClass(objCacheUseStateEN);
                console.log("完成UpdateRecord!");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 修改记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecordSave)
       */
        async UpdateRecordSave() {
            this.DivName = "divUpdateRecordSave";
            var objCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseStateEN.mId = Number(this.KeyId);
            this.PutDataToCacheUseStateClass(objCacheUseStateEN);
            objCacheUseStateEN.sf_UpdFldSetStr = objCacheUseStateEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objCacheUseStateEN.mId == 0 || objCacheUseStateEN.mId == undefined) {
                throw "关键字不能为空!";
            }
            try {
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_UpdateRecordAsync)(objCacheUseStateEN);
                var returnBool = !!responseText;
                if (returnBool == true) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
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
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrmId) {
            try {
                const responseText = await (0, clsCacheUseStateWApi_js_1.CacheUseState_DelCacheUseStatesAsync)(arrmId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
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
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `删除记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objCacheUseState">需要显示的对象</param>
       */
        ShowCacheUseStateObj(divContainer, objCacheUseState) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objCacheUseState);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objCacheUseState[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjCacheUseStateEN">表实体类对象</param>
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
                    error: function (result) {
                        console.log(result);
                        console.log(JSON.stringify(result));
                        if (result.statusText == "error") {
                            var strInfo = `网络错误！访问网络不成功！`;
                            reject(strInfo);
                        }
                        else {
                            reject(result.statusText);
                        }
                    }
                });
            });
        }
        /*
        * 设置取消按钮的标题(Used In AddNewRecord())
       */
        set btnCancel_CacheUseState(value) {
            $("#btnCancel_CacheUseState").html(value);
        }
        /*
        * 设置取消按钮的标题(Used In DetailRecord())
       */
        set btnCancel_d_vCacheUseState(value) {
            $("#btnCancel_d_vCacheUseState").html(value);
        }
        /*
        * 获取按钮的标题
       */
        get btnSubmit_CacheUseState() {
            return $("#btnSubmit_CacheUseState").html();
        }
        /*
        * 设置确定按钮的标题(Used In AddNewRecord())
       */
        set btnSubmit_CacheUseState(value) {
            $("#btnSubmit_CacheUseState").html(value);
        }
        /*
        * 设置确定按钮的标题(Used In DetailRecord())
       */
        set btnSubmit_d_vCacheUseState(value) {
            $("#btnSubmit_d_vCacheUseState").html(value);
        }
        /*
        * 缓存关键字 (Used In Clear())
       */
        set cacheKey(value) {
            $("#txtCacheKey").val(value);
        }
        /*
        * 缓存关键字 (Used In PutDataToClass())
       */
        get cacheKey() {
            return $("#txtCacheKey").val();
        }
        /*
        * 缓存关键字 (Used In ShowDetailDataFromClass())
       */
        set CacheKey_d(value) {
            $("#lblCacheKey_d").html(value);
        }
        /*
        * 缓存关键字 (Used In CombineCondition())
       */
        get CacheKey_q() {
            return $("#txtCacheKey_q").val();
        }
        /*
        * 缓存方式英文名 (Used In ShowDetailDataFromClass())
       */
        set CacheModeENName_d(value) {
            $("#lblCacheModeENName_d").html(value);
        }
        /*
        * 缓存方式Id (Used In Clear())
       */
        set cacheModeId(value) {
            $("#ddlCacheModeId").val(value);
        }
        /*
        * 缓存方式Id (Used In PutDataToClass())
       */
        get cacheModeId() {
            return $("#ddlCacheModeId").val();
        }
        /*
        * 缓存方式Id (Used In CombineCondition())
       */
        get CacheModeId_q() {
            return $("#ddlCacheModeId_q").val();
        }
        /*
        * 缓存方式名 (Used In ShowDetailDataFromClass())
       */
        set CacheModeName_d(value) {
            $("#lblCacheModeName_d").html(value);
        }
        /*
        * 缓存大小 (Used In Clear())
       */
        set cacheSize(value) {
            $("#txtCacheSize").val(value);
        }
        /*
        * 缓存大小 (Used In PutDataToClass())
       */
        get cacheSize() {
            return $("#txtCacheSize").val();
        }
        /*
        * 缓存大小 (Used In ShowDetailDataFromClass())
       */
        set CacheSize_d(value) {
            $("#lblCacheSize_d").html(value);
        }
        /*
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号(Used In BindGv_Cache)
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
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
        set hidSortvCacheUseStateBy(value) {
            $("#hidSortvCacheUseStateBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvCacheUseStateBy() {
            return $("#hidSortvCacheUseStateBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
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
        * 说明 (Used In Clear())
       */
        set memo(value) {
            $("#txtMemo").val(value);
        }
        /*
        * 说明 (Used In PutDataToClass())
       */
        get memo() {
            return $("#txtMemo").val();
        }
        /*
        * 说明 (Used In ShowDetailDataFromClass())
       */
        set Memo_d(value) {
            $("#lblMemo_d").html(value);
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
        * 设置操作类型：Add||Update||Detail
       */
        set OpType_d(value) {
            $("#hidOpType_d").val(value);
        }
        /*
        * 用户Id (Used In Clear())
       */
        set userId(value) {
            //界面变量(ViewVariable)
            var strKey = `varUserId`;
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                sessionStorage.removeItem(strKey);
            }
            sessionStorage.setItem(strKey, value.toString());
        }
        /*
        * 用户Id (Used In ShowDetailDataFromClass())
       */
        set UserId_d(value) {
            $("#lblUserId_d").html(value);
        }
        /*
        * 用户Id (Used In CombineCondition())
       */
        get UserId_q() {
            //界面变量(ViewVariable)
            var strKey = `varUserId_q`;
            if (sessionStorage.hasOwnProperty(strKey)) {
                //缓存存在，直接返回
                var strValue = sessionStorage.getItem(strKey);
                return strValue;
            }
            return "";
        }
    }
    exports.CacheUseStateCRUD = CacheUseStateCRUD;
    CacheUseStateCRUD.UserId_Static = "0";
});
