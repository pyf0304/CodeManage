(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js", "../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js", "../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js", "../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js", "../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsPublocalStorage.js", "../TS/PubFun/clsStackTrace.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperSubViewpoint_QUDI_TS = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:PaperSubViewpoint_QUDI_TS
    表名:PaperSubViewpoint(01120534)
    生成代码版本:2020.03.03.1
    生成日期:2020/03/12 02:22:23
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:tzar.tpddns.cn,19433EduHigh_Jsie
    PrjDataBaseId:0122
    模块中文名:研究生培养
    模块英文名:GraduateEduPaper
    框架-层名:WA_界面脚本后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsPaperSubViewpointEN.js");
    const clsSectionEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsSectionEN.js");
    const clsvPaperSubViewpointEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const clsExplainTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsExplainTypeEN.js");
    const clsSubViewpointTypeEN_js_1 = require("../TS/L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsPaperSubViewpointWApi.js");
    const clsSectionWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsSectionWApi.js");
    const clsvPaperSubViewpointWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvPaperSubViewpointWApi.js");
    const clsExplainTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsExplainTypeWApi.js");
    const clsSubViewpointTypeWApi_js_1 = require("../TS/L3_ForWApi/ParameterTable/clsSubViewpointTypeWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    /* PaperSubViewpoint_QUDI_TS 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class PaperSubViewpoint_QUDI_TS extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst";
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
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
        }
        /* 添加新记录，保存函数
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordSave)
       */
        async AddNewRecordSave() {
            this.DivName = "divAddNewRecordSave";
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            try {
                const responseText2 = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_AddNewRecordAsync)(objPaperSubViewpointEN);
                var returnBool = !!responseText2;
                if (returnBool == true) {
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
                return false;
            }
            return true; //一定要有一个返回值，否则会出错！
        }
        /* 为插入记录做准备工作
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_AddNewRecordWithMaxId)
       */
        AddNewRecordWithMaxId() {
            this.btnOKUpd = "确认添加";
            this.btnCancel = "取消添加";
            this.Clear();
            //wucPaperSubViewpointB1.subViewpointId = clsPaperSubViewpointBL.GetMaxStrId_S();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vPaperSubViewpoint() {
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.CombinevPaperSubViewpointCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperSubViewpointObjLst = [];
            try {
                const responseRecCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperSubViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvPaperSubViewpointObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvPaperSubViewpointObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vPaperSubViewpoint(strListDiv, arrvPaperSubViewpointObjLst);
                console.log("完成BindGv_vPaperSubViewpoint!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vPaperSubViewpoint_Cache() {
            var strListDiv = this.mstrListDiv;
            var objvPaperSubViewpoint_Cond = this.CombinevPaperSubViewpointConditionObj();
            var strWhereCond = JSON.stringify(objvPaperSubViewpoint_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvPaperSubViewpointObjLst = [];
            try {
                this.RecCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCond_Cache)(objvPaperSubViewpoint_Cond, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperSubViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvPaperSubViewpointObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstByPager_Cache)(objPagerPara, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
            }
            if (arrvPaperSubViewpointObjLst.length == 0) {
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=PaperSubViewpoint)`;
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vPaperSubViewpoint(strListDiv, arrvPaperSubViewpointObjLst);
                console.log("完成BindGv_vPaperSubViewpoint!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 显示vPaperSubViewpoint对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrPaperSubViewpointObjLst">需要绑定的对象列表</param>
       */
        BindTab_vPaperSubViewpoint(divContainer, arrvPaperSubViewpointObjLst) {
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
                    FldName: "paperRWId",
                    ColHeader: "论文读写Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "subViewpointTypeName",
                    ColHeader: "类型名称",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "rwTitle",
                    ColHeader: "读写标题",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "subViewpointContent",
                    ColHeader: "详情内容",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "explainTypeName",
                    ColHeader: "说明类型名",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "isPublic",
                    ColHeader: "是否公开",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "orderNum",
                    ColHeader: "序号",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    ColHeader: "修改用户Id",
                    Text: "", TdClass: "text-left", SortBy: "",
                    ColumnType: "Label",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    ColHeader: "修改日期",
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
                        btn1.className = "btn btn-outline-info btn-sm";
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
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btnDelRecordInTab_Click('${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvPaperSubViewpointObjLst, arrDataColumn, "subViewpointId");
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
                const responseBindGv = await this.BindGv_vPaperSubViewpoint();
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
                var lngKeyId = Number(strKeyId);
                //const responseText = await this.DelRecord(lngKeyId).then((jsonData) => {
                //    ;
                //});
                const responseBindGv = await this.BindGv_vPaperSubViewpoint();
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
                var lngKeyId = strKeyId;
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
        下移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        */
        async btnDownMove_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            var strPaperRWId = this.PaperRWId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert(`请选择需要下移的记录!`);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_DownMoveAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `下移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
       */
        async btnExportExcel_Click() {
            var strWhereCond = " 1=1 ";
            try {
                const responseText = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvPaperSubViewpointObjLst = jsonData;
                    this.BindTab_vPaperSubViewpoint(this.mstrListDiv, arrvPaperSubViewpointObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        置底
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
        */
        async btnGoBottum_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            var strPaperRWId = this.PaperRWId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要置底的记录！");
                return "";
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GoBottomAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `置底出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /* 置顶
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
        */
        async btnGoTop_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            var strPaperRWId = this.PaperRWId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要置顶的记录！");
                return "";
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GoTopAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `置顶出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            var strListDiv = this.mstrListDiv;
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
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
                        if (this.OpType == "AddWithMaxId") {
                            //const responseText3 = await this.AddNewRecordWithMaxIdSave().then((jsonData)=>{
                            //var returnBool2: boolean = jsonData;
                            //if (returnBool2 == true)
                            //{
                            //HideDialog();
                            //this.BindGv_vPaperSubViewpoint();
                            //}
                            //});
                        }
                        else {
                            const responseText2 = await this.AddNewRecordSave().then((jsonData) => {
                                var returnBool = jsonData;
                                if (returnBool == true) {
                                    HideDialog();
                                    this.BindGv_vPaperSubViewpoint();
                                }
                            });
                        }
                        break;
                    case "确认修改":
                        //这是一个单表的修改的代码,由于逻辑层太简单,
                        const responseText3 = await this.UpdateRecordSave().then((jsonData) => {
                            var returnBool = jsonData;
                            if (returnBool == true) {
                                HideDialog();
                                this.BindGv_vPaperSubViewpoint();
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
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click(strListDiv) {
            var strWhereCond = this.CombinevPaperSubViewpointCondition();
            try {
                const responseRecCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: 1,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvPaperSubViewpointBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    var arrvPaperSubViewpointObjLst = jsonData;
                    this.BindTab_vPaperSubViewpoint(this.mstrListDiv, arrvPaperSubViewpointObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `查询不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        重序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
        */
        async btnReOrder_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            var strPaperRWId = this.PaperRWId_OrderNum;
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_ReOrderAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
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
                var lngKeyId = strKeyId;
                this.SelectRecord(lngKeyId);
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
            var lngKeyId = strKeyId;
            this.UpdateRecord(lngKeyId);
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
            var lngKeyId = strKeyId;
            this.UpdateRecord(lngKeyId);
        }
        /*
        上移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        */
        async btnUpMove_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            var strPaperRWId = this.PaperRWId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert(`请选择需要上移的记录!`);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "subViewpointTypeId": strSubViewpointTypeId,
                    "paperRWId": strPaperRWId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpMoveAsync)(objOrderByData);
            }
            catch (e) {
                var strMsg = `上移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /// <summary>
        /// 清除用户自定义控件中，所有控件的值
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Clear)
        /// </summary>	
        Clear() {
            this.paperRWId = "";
            $('#ddlSectionId option[0]').attr("selected", true);
            $('#ddlSubViewpointTypeId option[0]').attr("selected", true);
            this.rwTitle = "";
            this.subViewpointContent = "";
            $('#ddlExplainTypeId option[0]').attr("selected", true);
            this.explainContent = "";
            this.isPublic = false;
            this.literatureSourcesId = "";
            this.pageNumber = 0;
            this.orderNum = 0;
            this.updUser = "";
            this.updDate = "";
            this.memo = "";
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevPaperSubViewpointCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperRWId_q != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId} like '% ${this.PaperRWId_q}%'`;
                }
                if (this.SectionId_q != "" && this.SectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
                }
                if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
                }
                if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0002)在组合查询条件(CombinePaperSubViewpointCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        CombinevPaperSubViewpointConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvPaperSubViewpoint_Cond = new clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.PaperRWId_q != "") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId} like '% ${this.PaperRWId_q}%'`;
                    objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId, this.PaperRWId_q, "like");
                }
                if (this.SectionId_q != "" && this.SectionId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId} = '${this.SectionId_q}'`;
                    objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId, this.SectionId_q, "=");
                }
                if (this.SubViewpointTypeId_q != "" && this.SubViewpointTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId} = '${this.SubViewpointTypeId_q}'`;
                    objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId, this.SubViewpointTypeId_q, "=");
                }
                if (this.ExplainTypeId_q != "" && this.ExplainTypeId_q != "0") {
                    strWhereCond += ` And ${clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId} = '${this.ExplainTypeId_q}'`;
                    objvPaperSubViewpoint_Cond.SetCondFldValue(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId, this.ExplainTypeId_q, "=");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0005)在组合查询条件对象(CombinePaperSubViewpointConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvPaperSubViewpoint_Cond;
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        DelMultiRecord(arrSubViewpointId) {
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_DelPaperSubViewpointsAsync)(arrSubViewpointId).then((jsonData) => {
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
        //public DelRecord(lngSubViewpointId: number): Promise<number> {
        //    return new Promise((resolve, reject) => {
        //        try {
        //            const responseText = PaperSubViewpoint_DelRecordAsync(lngSubViewpointId).then((jsonData) => {
        //                var returnInt: number = jsonData;
        //                if (returnInt > 0) {
        //                    var strInfo: string = `删除记录成功,共删除${returnInt}条记录!`;
        //                    //显示信息框
        //                    alert(strInfo);
        //                }
        //                else {
        //                    var strInfo: string = `删除记录不成功!`;
        //                    //显示信息框
        //                    alert(strInfo);
        //                }
        //                console.log("完成DelRecord!");
        //                resolve(jsonData);
        //            });
        //        }
        //        catch (e) {
        //            console.error('catch(e)=');
        //            console.error(e);
        //            var strMsg: string = `删除记录不成功. ${e}.`;
        //            alert(strMsg);
        //        }
        //    });
        //}
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
        DetailRecord(lngSubViewpointId) {
            this.btnOKUpd = "";
            this.btnCancel = "关闭";
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetObjBySubViewpointIdAsync)(lngSubViewpointId).then((jsonData) => {
                        var objPaperSubViewpointEN = jsonData;
                        this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
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
         <param name = "pobjPaperSubViewpointEN">表实体类对象</param>
       */
        GetDataFromPaperSubViewpointClass(pobjPaperSubViewpointEN) {
            this.paperRWId = pobjPaperSubViewpointEN.paperRWId; // 论文读写Id
            this.sectionId = pobjPaperSubViewpointEN.sectionId; // 节Id
            this.subViewpointTypeId = pobjPaperSubViewpointEN.subViewpointTypeId; // 类型Id
            this.rwTitle = pobjPaperSubViewpointEN.rwTitle; // 读写标题
            this.subViewpointContent = pobjPaperSubViewpointEN.subViewpointContent; // 详情内容
            this.explainTypeId = pobjPaperSubViewpointEN.explainTypeId; // 说明类型Id
            this.explainContent = pobjPaperSubViewpointEN.explainContent; // 说明内容
            this.isPublic = pobjPaperSubViewpointEN.isPublic; // 是否公开
            this.literatureSourcesId = pobjPaperSubViewpointEN.literatureSourcesId; // 文献来源
            this.pageNumber = pobjPaperSubViewpointEN.pageNumber; // 页码
            this.orderNum = pobjPaperSubViewpointEN.orderNum; // 序号
            this.updUser = pobjPaperSubViewpointEN.updUser; // 修改用户Id
            this.updDate = pobjPaperSubViewpointEN.updDate; // 修改日期
            this.memo = pobjPaperSubViewpointEN.memo; // 备注
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjPaperSubViewpointEN">表实体类对象</param>
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
        /* 获取当前表关键字值的最大值,再加1,避免重复
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetMaxStrId)
       */
        async GetMaxStrId(strKeyCtrlName) {
            this.DivName = "divGetMaxStrId";
            try {
                const responseText = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetMaxStrIdAsync)();
                var returnString = responseText.toString();
                if (returnString == "") {
                    var strInfo = `获取表PaperSubViewpoint的最大关键字为空，不成功，请检查!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
                else {
                    var strInfo = `获取表PaperSubViewpoint的最大关键字为：${returnString}!`;
                    $('#lblResult40').val(strInfo);
                    //显示信息框
                    alert(strInfo);
                    $(strKeyCtrlName).val(returnString);
                }
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `获取表关键字的最大值不成功,${e}.`;
                alert(strMsg);
            }
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
            this.BindGv_vPaperSubViewpoint();
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                //建立缓存
                const arrSection_Cache = await (0, clsSectionWApi_js_1.Section_GetObjLstAsync)("1=1"); //查询区域
                const arrSubViewpointType_Cache = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstAsync)("1=1"); //查询区域
                const arrExplainType_Cache = await (0, clsExplainTypeWApi_js_1.ExplainType_GetObjLstAsync)("1=1"); //查询区域
                const arrvPaperSubViewpoint_Cache = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)("1=1");
                var objSection_Cond = new clsSectionEN_js_1.clsSectionEN(); //查询区域
                var objSubViewpointType_Cond = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN(); //查询区域
                var objExplainType_Cond = new clsExplainTypeEN_js_1.clsExplainTypeEN(); //查询区域
                var strPaperId_q = "";
                //const ddlSectionId_q = Section_BindDdl_SectionId_Cache("ddlSectionId_q", objSection_Cond, strPaperId_q);//查询区域
                await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4List, "ddlSubViewpointTypeId_q"); //查询区域
                await (0, clsExplainTypeWApi_js_1.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache)(this.divName4List, "ddlExplainTypeId_q"); //查询区域
                var strPaperId = "";
                //const ddlSectionId = Section_BindDdl_SectionId_Cache("ddlSectionId", objSection_Cond, strPaperId);//编辑区域
                await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4List, "ddlSubViewpointTypeId"); //编辑区域
                await (0, clsExplainTypeWApi_js_1.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache)(this.divName4List, "ddlExplainTypeId"); //编辑区域
                await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4List, "ddlSubViewpointTypeId_OrderNum"); //功能区域
                this.hidSortvPaperSubViewpointBy = "paperRWId Asc";
                var strWhereCond = this.CombinevPaperSubViewpointCondition();
                const responseText = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaperSubViewpoint();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                const arrSection_Cache = await (0, clsSectionWApi_js_1.Section_GetObjLstAsync)("1=1"); //查询区域
                const arrSubViewpointType_Cache = await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_GetObjLstAsync)("1=1"); //查询区域
                const arrExplainType_Cache = await (0, clsExplainTypeWApi_js_1.ExplainType_GetObjLstAsync)("1=1"); //查询区域
                const arrvPaperSubViewpoint_Cache = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetObjLstAsync)("1=1");
                var objSection_Cond = new clsSectionEN_js_1.clsSectionEN(); //查询区域
                var objSubViewpointType_Cond = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN(); //查询区域
                var objExplainType_Cond = new clsExplainTypeEN_js_1.clsExplainTypeEN(); //查询区域
                var strPaperId_q = "";
                //const ddlSectionId_q = Section_BindDdl_SectionId_Cache("ddlSectionId_q", objSection_Cond, strPaperId_q);//查询区域
                await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4List, "ddlSubViewpointTypeId_q"); //查询区域
                await (0, clsExplainTypeWApi_js_1.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache)(this.divName4List, "ddlExplainTypeId_q"); //查询区域
                var strPaperId = "";
                //const ddlSectionId = Section_BindDdl_SectionId_Cache("ddlSectionId", objSection_Cond, strPaperId);//编辑区域
                await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4List, "ddlSubViewpointTypeId"); //编辑区域
                await (0, clsExplainTypeWApi_js_1.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache)(this.divName4List, "ddlExplainTypeId"); //编辑区域
                await (0, clsSubViewpointTypeWApi_js_1.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache)(this.divName4List, "ddlSubViewpointTypeId_OrderNum"); //功能区域
                this.hidSortvPaperSubViewpointBy = "paperRWId Asc";
                var objvPaperSubViewpoint_Cond = this.CombinevPaperSubViewpointConditionObj();
                this.RecCount = await (0, clsvPaperSubViewpointWApi_js_1.vPaperSubViewpoint_GetRecCountByCond_Cache)(objvPaperSubViewpoint_Cond, clsPublocalStorage_js_1.clsPublocalStorage.Getid_CurrEduCls());
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vPaperSubViewpoint_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /*
        移动记录序号时的预检查函数
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
        */
        PreCheck4Order() {
            var strSubViewpointTypeId = this.SubViewpointTypeId_OrderNum;
            if (strSubViewpointTypeId == "") {
                var strMsg = `请输入subViewpointTypeId!`;
                alert(strMsg);
                return false;
            }
            var strPaperRWId = this.PaperRWId_OrderNum;
            if (strPaperRWId == "") {
                var strMsg = `请输入paperRWId!`;
                alert(strMsg);
                return false;
            }
            return true;
        }
        /* 函数功能:把界面上的属性数据传到类对象中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PutDataToClass)
         <param name = "pobjPaperSubViewpointEN">数据传输的目的类对象</param>
       */
        PutDataToPaperSubViewpointClass(pobjPaperSubViewpointEN) {
            pobjPaperSubViewpointEN.paperRWId = this.paperRWId; // 论文读写Id
            pobjPaperSubViewpointEN.sectionId = this.sectionId; // 节Id
            pobjPaperSubViewpointEN.subViewpointTypeId = this.subViewpointTypeId; // 类型Id
            pobjPaperSubViewpointEN.rwTitle = this.rwTitle; // 读写标题
            pobjPaperSubViewpointEN.subViewpointContent = this.subViewpointContent; // 详情内容
            pobjPaperSubViewpointEN.explainTypeId = this.explainTypeId; // 说明类型Id
            pobjPaperSubViewpointEN.explainContent = this.explainContent; // 说明内容
            pobjPaperSubViewpointEN.isPublic = this.isPublic; // 是否公开
            pobjPaperSubViewpointEN.literatureSourcesId = this.literatureSourcesId; // 文献来源
            pobjPaperSubViewpointEN.pageNumber = this.pageNumber; // 页码
            pobjPaperSubViewpointEN.orderNum = this.orderNum; // 序号
            pobjPaperSubViewpointEN.updUser = this.updUser; // 修改用户Id
            pobjPaperSubViewpointEN.updDate = this.updDate; // 修改日期
            pobjPaperSubViewpointEN.memo = this.memo; // 备注
        }
        /*
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(lngSubViewpointId) {
            try {
                const responseText = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetObjBySubViewpointIdAsync)(lngSubViewpointId);
                var objPaperSubViewpointEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vPaperSubViewpoint");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
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
        /* 函数功能:把以该关键字的记录内容显示在界面上,
              在这里是把值传到表控件中
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowData)
         <param name = "lngSubViewpointId">表记录的关键字,显示该表关键字的内容</param>
       */
        async ShowData(lngSubViewpointId) {
            //操作步骤:
            //1、检查关键字是否为空；
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            //3、用提供的关键字初始化一个类对象；
            //4、获取类对象的所有属性；
            //5、把该对象的所有属性显示在界面上,在这里显示在表控件中
            //2、检查该关键字的记录是否存在,如果不存在就返回不显示；
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            try {
                const responseText = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_IsExistAsync)(lngSubViewpointId);
                var returnBool = responseText;
                if (returnBool == false) {
                    var strInfo = `关键字:[${lngSubViewpointId}] 的记录不存在!`;
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
                const responseText = await (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetObjBySubViewpointIdAsync)(lngSubViewpointId);
                objPaperSubViewpointEN = responseText;
            }
            catch (e) {
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                alert(strMsg);
            }
            //3、用提供的关键字初始化一个类对象；
            this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
        }
        /* 显示{0}对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
         <param name = "divContainer">显示容器</param>
         <param name = "objPaperSubViewpoint">需要显示的对象</param>
       */
        ShowPaperSubViewpointObj(divContainer, objPaperSubViewpoint) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objPaperSubViewpoint);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objPaperSubViewpoint[strKey];
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
            if (this.hidSortvPaperSubViewpointBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvPaperSubViewpointBy.indexOf("Asc") >= 0) {
                    this.hidSortvPaperSubViewpointBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvPaperSubViewpointBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvPaperSubViewpointBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vPaperSubViewpoint();
        }
        /* 根据关键字获取相应的记录的对象
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_UpdateRecord)
         <param name = "sender">参数列表</param>
       */
        UpdateRecord(strSubViewpointId) {
            this.btnOKUpd = "确认修改";
            this.btnCancel = "取消修改";
            this.KeyId = strSubViewpointId;
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_GetObjBySubViewpointIdAsync)(strSubViewpointId).then((jsonData) => {
                        var objPaperSubViewpointEN = jsonData;
                        this.GetDataFromPaperSubViewpointClass(objPaperSubViewpointEN);
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
            var objPaperSubViewpointEN = new clsPaperSubViewpointEN_js_1.clsPaperSubViewpointEN();
            objPaperSubViewpointEN.subViewpointId = this.KeyId;
            this.PutDataToPaperSubViewpointClass(objPaperSubViewpointEN);
            objPaperSubViewpointEN.sf_UpdFldSetStr = objPaperSubViewpointEN.updFldString; //设置哪些字段被修改(脏字段)
            if (objPaperSubViewpointEN.subViewpointId == "" || objPaperSubViewpointEN.subViewpointId == undefined) {
                throw "关键字不能为空!";
            }
            return new Promise((resolve, reject) => {
                try {
                    const responseText = (0, clsPaperSubViewpointWApi_js_1.PaperSubViewpoint_UpdateRecordAsync)(objPaperSubViewpointEN).then((jsonData) => {
                        var returnBool = jsonData;
                        if (returnBool == true) {
                            var strInfo = `修改记录成功!`;
                            $('#lblResult51').val(strInfo);
                            //显示信息框
                            alert(strInfo);
                        }
                        else {
                            var strInfo = `修改记录不成功!`;
                            $('#lblResult51').val(strInfo);
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
        * 说明内容
       */
        set explainContent(value) {
            $("#txtExplainContent").val(value);
        }
        /*
        * 说明内容
       */
        get explainContent() {
            return $("#txtExplainContent").val();
        }
        /*
        * 说明类型Id
       */
        set explainTypeId(value) {
            $("#ddlExplainTypeId").val(value);
        }
        /*
        * 说明类型Id
       */
        get explainTypeId() {
            return $("#ddlExplainTypeId").val();
        }
        /*
        * 说明类型Id
       */
        get ExplainTypeId_q() {
            return $("#ddlExplainTypeId_q").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvPaperSubViewpointBy(value) {
            $("#hidSortvPaperSubViewpointBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvPaperSubViewpointBy() {
            return $("#hidSortvPaperSubViewpointBy").val();
        }
        /*
        * 用户Id
       */
        get hidUserId() {
            return $("#hidUserId").val();
        }
        /*
        * 是否公开
       */
        set isPublic(value) {
            $("#chkIsPublic").val(value);
        }
        /*
        * 是否公开
       */
        get isPublic() {
            return $("#chkIsPublic").prop("checked");
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
        * 文献来源
       */
        set literatureSourcesId(value) {
            $("#txtLiteratureSourcesId").val(value);
        }
        /*
        * 文献来源
       */
        get literatureSourcesId() {
            return $("#txtLiteratureSourcesId").val();
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
        * 序号
       */
        set orderNum(value) {
            $("#txtOrderNum").val(value);
        }
        /*
        * 序号
       */
        get orderNum() {
            return $("#txtOrderNum").val();
        }
        /*
        * 页码
       */
        set pageNumber(value) {
            $("#txtPageNumber").val(value);
        }
        /*
        * 页码
       */
        get pageNumber() {
            return $("#txtPageNumber").val();
        }
        /*
        * 论文读写Id
       */
        set paperRWId(value) {
            $("#txtPaperRWId").val(value);
        }
        /*
        * 论文读写Id
       */
        get paperRWId() {
            return $("#txtPaperRWId").val();
        }
        /*
        * paperRWId
       */
        get PaperRWId_OrderNum() {
            return $("#txtPaperRWId_OrderNum").val();
        }
        /*
        * 论文读写Id
       */
        get PaperRWId_q() {
            return $("#txtPaperRWId_q").val();
        }
        /*
        * 读写标题
       */
        set rwTitle(value) {
            $("#txtRWTitle").val(value);
        }
        /*
        * 读写标题
       */
        get rwTitle() {
            return $("#txtRWTitle").val();
        }
        /*
        * 节Id
       */
        set sectionId(value) {
            $("#ddlSectionId").val(value);
        }
        /*
        * 节Id
       */
        get sectionId() {
            return $("#ddlSectionId").val();
        }
        /*
        * 节Id
       */
        get SectionId_q() {
            return $("#ddlSectionId_q").val();
        }
        /*
        * 详情内容
       */
        set subViewpointContent(value) {
            $("#txtSubViewpointContent").val(value);
        }
        /*
        * 详情内容
       */
        get subViewpointContent() {
            return $("#txtSubViewpointContent").val();
        }
        /*
        * 类型Id
       */
        set subViewpointTypeId(value) {
            $("#ddlSubViewpointTypeId").val(value);
        }
        /*
        * 类型Id
       */
        get subViewpointTypeId() {
            return $("#ddlSubViewpointTypeId").val();
        }
        /*
        * subViewpointTypeId
       */
        get SubViewpointTypeId_OrderNum() {
            return $("#ddlSubViewpointTypeId_OrderNum").val();
        }
        /*
        * 类型Id
       */
        get SubViewpointTypeId_q() {
            return $("#ddlSubViewpointTypeId_q").val();
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
        /*
        * 修改用户Id
       */
        set updUser(value) {
            $("#txtUpdUser").val(value);
        }
        /*
        * 修改用户Id
       */
        get updUser() {
            return $("#txtUpdUser").val();
        }
        /*
       * 观点态度
      */
        set attitudesId(value) {
            $("#ddlAttitudesId").val(value);
        }
        /*
        * 观点态度Id
       */
        get attitudesId() {
            return $("#ddl").val();
        }
    }
    exports.PaperSubViewpoint_QUDI_TS = PaperSubViewpoint_QUDI_TS;
});
