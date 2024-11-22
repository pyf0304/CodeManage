(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js", "../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js", "../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js", "../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsOrderByData.js", "../TS/PubFun/clsStackTrace.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraphCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_PaperParagraphCRUD
    表名:gs_PaperParagraph(01120744)
    生成代码版本:2020.09.24.1
    生成日期:2020/09/27 16:02:34
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:101.251.68.133,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:研培论文
    模块英文名:GraduateEduPaper
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js");
    const clsvgs_PaperParagraphEN_js_1 = require("../TS/L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js");
    const clsgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperParagraphWApi.js");
    const clsvgs_PaperParagraphWApi_js_1 = require("../TS/L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsOrderByData_js_1 = require("../TS/PubFun/clsOrderByData.js");
    const clsStackTrace_js_1 = require("../TS/PubFun/clsStackTrace.js");
    /* gs_PaperParagraphCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class gs_PaperParagraphCRUD extends clsOperateList2_js_1.clsOperateList {
        constructor() {
            super(...arguments);
            this.mstrListDiv = "divDataLst"; //列表区数据列表层id
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
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
       */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvgs_PaperParagraphBy = "paragraphTypeName Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
       */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvgs_PaperParagraphBy = "paragraphTypeName Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
       */
        async btnQuery_Click() {
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
        }
        /*
        重序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
        */
        async btnReOrder_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSectionId = gs_PaperParagraphCRUD.SectionId_OrderNum;
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                var jsonObject = {
                    "sectionId": strSectionId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_ReOrderAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `重序出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        /*
        置底
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
        */
        async btnGoBottum_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSectionId = gs_PaperParagraphCRUD.SectionId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要置底的记录！");
                return "";
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "sectionId": strSectionId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GoBottomAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `置底出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /*
        移动记录序号时的预检查函数
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
        */
        PreCheck4Order() {
            var strSectionId = gs_PaperParagraphCRUD.SectionId_OrderNum;
            if (strSectionId == "") {
                var strMsg = `请输入sectionId!`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return false;
            }
            return true;
        }
        /*
        下移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        */
        async btnDownMove_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSectionId = gs_PaperParagraphCRUD.SectionId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert(`请选择需要下移的记录!`);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "sectionId": strSectionId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_DownMoveAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `下移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /*
        上移
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        */
        async btnUpMove_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSectionId = gs_PaperParagraphCRUD.SectionId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert(`请选择需要上移的记录!`);
                return;
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "sectionId": strSectionId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_UpMoveAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `上移记录出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /* 置顶
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
        */
        async btnGoTop_Click() {
            if (this.PreCheck4Order() == false)
                return;
            var strSectionId = gs_PaperParagraphCRUD.SectionId_OrderNum;
            var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
            if (arrKeyIds.length == 0) {
                alert("请选择需要置顶的记录！");
                return "";
            }
            try {
                var objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                var jsonObject = {
                    "sectionId": strSectionId,
                };
                var jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GoTopAsync)(objOrderByData);
                //gs_PaperParagraph_ReFreshCache();
            }
            catch (e) {
                var strMsg = `置顶出错。错误:${e}.(In ${clsStackTrace_js_1.clsStackTrace.GetCurrClassFunction()})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            var strListDiv = this.mstrListDiv;
            var strListDiv = this.mstrListDiv;
            arrKeyIds.forEach((e) => clsCommonFunc4Web2_js_1.clsCommonFunc4Web.SetCkechedItem4KeyId(strListDiv, e));
        }
        /*
         添加新记录
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
        */
        async btnCopyRecord_Click() {
            try {
                var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                if (arrKeyIds.length == 0) {
                    alert("请选择需要克隆的记录！");
                    return "";
                }
                const responseText = await this.CopyRecord(arrKeyIds);
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `复制记录不成功,${e}.`;
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
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
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
                this.SelectRecord(strKeyId);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `选择记录不成功. ${e}.`;
                alert(strMsg);
            }
        }
        /*
        根据关键字删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
       */
        async DelRecord(strParagraphId) {
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_DelRecordAsync)(strParagraphId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_PaperParagraph_ReFreshCache();
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
        根据关键字选择相应的记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
         <param name = "sender">参数列表</param>
       */
        async SelectRecord(strParagraphId) {
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetObjByParagraphIdAsync)(strParagraphId);
                var objgs_PaperParagraphEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_vgs_PaperParagraph");
            }
            catch (e) {
                console.error(e);
                var strMsg = `根据关键字获取相应的记录的对象不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
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
                const responseBindGv = await this.BindGv_vgs_PaperParagraph();
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
                const responseText = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetObjLstAsync)(strWhereCond).then((jsonData) => {
                    var arrvgs_PaperParagraphObjLst = jsonData;
                    this.BindTab_vgs_PaperParagraph(this.mstrListDiv, arrvgs_PaperParagraphObjLst);
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `导出Excel不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinevgs_PaperParagraphCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ParagraphContent_q != "") {
                    strWhereCond += ` And ${clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphContent} like '% ${this.ParagraphContent_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperParagraphCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinevgs_PaperParagraphConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objvgs_PaperParagraph_Cond = new clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.ParagraphContent_q != "") {
                    strWhereCond += ` And ${clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphContent} like '% ${this.ParagraphContent_q}%'`;
                    objvgs_PaperParagraph_Cond.SetCondFldValue(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphContent, this.ParagraphContent_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_PaperParagraphConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return objvgs_PaperParagraph_Cond;
        }
        /* 显示vgs_PaperParagraph对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrgs_PaperParagraphObjLst">需要绑定的对象列表</param>
       */
        BindTab_vgs_PaperParagraph(divContainer, arrvgs_PaperParagraphObjLst) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var arrDataColumn = [
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "CheckBox",
                    orderNum: 1,
                    FuncName: () => { }
                },
                {
                    FldName: "paragraphTypeName",
                    SortBy: "paragraphTypeName",
                    ColHeader: "段落类型",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "paragraphContent",
                    SortBy: "paragraphContent",
                    ColHeader: "段落内容",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "voteCount",
                    SortBy: "voteCount",
                    ColHeader: "点赞计数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "commentCount",
                    SortBy: "commentCount",
                    ColHeader: "评论数",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "versionCount",
                    SortBy: "versionCount",
                    ColHeader: "版本统计",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "createDate",
                    SortBy: "createDate",
                    ColHeader: "建立日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
                {
                    FldName: "createUser",
                    SortBy: "createUser",
                    ColHeader: "建立用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 8,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 9,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 10,
                    FuncName: () => { }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "修改",
                    Text: "修改",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('UpdateRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
                {
                    FldName: "",
                    SortBy: "",
                    ColHeader: "删除",
                    Text: "删除",
                    TdClass: "text-left",
                    ColumnType: "Button",
                    orderNum: 1,
                    FuncName: (strKeyId, strText) => {
                        var btn1 = document.createElement("button");
                        btn1.innerText = strText;
                        btn1.className = "btn btn-outline-info btn-sm";
                        btn1.setAttribute("onclick", `btn_Click('DelRecordInTab', '${strKeyId}');`);
                        return btn1;
                    }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV2(o, arrvgs_PaperParagraphObjLst, arrDataColumn, "paragraphId");
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
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_vgs_PaperParagraph() {
            if (this.hidSortvgs_PaperParagraphBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinevgs_PaperParagraphCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_PaperParagraphObjLst = [];
            try {
                const responseRecCount = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_PaperParagraphBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvgs_PaperParagraphObjLst = jsonData;
                });
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
            if (arrvgs_PaperParagraphObjLst.length == 0) {
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vgs_PaperParagraph(strListDiv, arrvgs_PaperParagraphObjLst);
                console.log("完成BindGv_vgs_PaperParagraph!");
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                //console.trace();
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                alert(strMsg);
            }
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
       */
        async BindGv_vgs_PaperParagraph_Cache() {
            if (this.hidSortvgs_PaperParagraphBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortvgs_PaperParagraphBy)为空，请检查！(In BindGv_vgs_PaperParagraph_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objvgs_PaperParagraph_Cond = this.Combinevgs_PaperParagraphConditionObj();
            var strWhereCond = JSON.stringify(objvgs_PaperParagraph_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrvgs_PaperParagraphObjLst = [];
            try {
                this.RecCount = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetRecCountByCond_Cache)(objvgs_PaperParagraph_Cond);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortvgs_PaperParagraphBy,
                    sortFun: (x, y) => { return 0; }
                };
                var arrvgs_PaperParagraphObjLst = await (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_GetObjLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                console.error('catch(e)=');
                console.error(e);
                var strMsg = `绑定GridView不成功,${e}.`;
                alert(strMsg);
                return;
            }
            if (arrvgs_PaperParagraphObjLst.length == 0) {
                var strKey = `${clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_vgs_PaperParagraph(strListDiv, arrvgs_PaperParagraphObjLst);
                console.log("完成BindGv_vgs_PaperParagraph!");
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
            if (this.hidSortvgs_PaperParagraphBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortvgs_PaperParagraphBy.indexOf("Asc") >= 0) {
                    this.hidSortvgs_PaperParagraphBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortvgs_PaperParagraphBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortvgs_PaperParagraphBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_vgs_PaperParagraph();
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrParagraphId) {
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetObjLstByParagraphIdLstAsync)(arrParagraphId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrgs_PaperParagraphObjLst = responseText;
                for (let objInFor of arrgs_PaperParagraphObjLst) {
                    const strMaxStrId = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_GetMaxStrIdAsync)();
                    console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.paragraphId = strMaxStrId;
                    const responseText2 = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        var strInfo = `克隆记录成功!`;
                        intCount++;
                    }
                    else {
                        var strInfo = `克隆记录不成功!`;
                        //显示信息框
                        alert(strInfo);
                    }
                }
                var strInfo = `共克隆了${intCount}条记录!`;
                alert(strInfo);
                console.log('完成！');
            }
            catch (e) {
                var strMsg = `复制记录不成功,${e}.`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /* 根据关键字列表删除记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
       */
        async DelMultiRecord(arrParagraphId) {
            try {
                const responseText = await (0, clsgs_PaperParagraphWApi_js_1.gs_PaperParagraph_Delgs_PaperParagraphsAsync)(arrParagraphId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_PaperParagraph_ReFreshCache();
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
         <param name = "objgs_PaperParagraph">需要显示的对象</param>
       */
        Showgs_PaperParagraphObj(divContainer, objgs_PaperParagraph) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objgs_PaperParagraph);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objgs_PaperParagraph[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjgs_PaperParagraphEN">表实体类对象</param>
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
        * 设置当前页序号
       */
        set CurrPageIndex(value) {
            $("#hidCurrPageIndex").val(value);
        }
        /*
        * 获取当前页序号(Used In BindGv_)
       */
        get CurrPageIndex() {
            return $("#hidCurrPageIndex").val();
        }
        /*
        * 设置排序字段-相当使用ViewState功能
       */
        set hidSortvgs_PaperParagraphBy(value) {
            $("#hidSortvgs_PaperParagraphBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortvgs_PaperParagraphBy() {
            return $("#hidSortvgs_PaperParagraphBy").val();
        }
        /*
        * 段落内容 (Used In CombineCondition())
       */
        get ParagraphContent_q() {
            return $("#txtParagraphContent_q").val();
        }
        /*
        * sectionId (Used In btnReOrder_Click())
       */
        static get SectionId_OrderNum() {
            return $("#txtSectionId_OrderNum").val();
        }
        /*
        * sectionId (Used In btnReOrder_Click())
       */
        static set SectionId_OrderNum(value) {
            $("#txtSectionId_OrderNum").val(value);
        }
    }
    exports.gs_PaperParagraphCRUD = gs_PaperParagraphCRUD;
});
