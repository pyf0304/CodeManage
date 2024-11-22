(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/CourseLearning/clscc_CourseEN.js", "../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js", "../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphEN.js", "../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphENEx.js", "../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js", "../TS/L3_ForWApi/CourseLearning/clscc_CourseWApi.js", "../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js", "../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesGraphWApi.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsOperateList2.js", "../TS/PubFun/clsString2.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesGraphCRUD = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:gs_KnowledgesGraphCRUD
    表名:gs_KnowledgesGraph(01120873)
    生成代码版本:2021.01.27.2
    生成日期:2021/01/27 23:33:06
    生成者:
    工程名称:问卷调查
    工程ID:0112
    相关数据库:103.116.76.183,9433EduHigh_Jsie
    PrjDataBaseId:0170
    模块中文名:知识点相关
    模块英文名:Knowledges
    框架-层名:WA_界面后台_TS(WA_ViewScriptCS_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clscc_CourseEN_js_1 = require("../TS/L0_Entity/CourseLearning/clscc_CourseEN.js");
    const clsCurrEduClsEN_js_1 = require("../TS/L0_Entity/DailyRunning/clsCurrEduClsEN.js");
    const clsgs_KnowledgesGraphEN_js_1 = require("../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphEN.js");
    const clsgs_KnowledgesGraphENEx_js_1 = require("../TS/L0_Entity/Knowledges/clsgs_KnowledgesGraphENEx.js");
    const clscc_CourseTypeWApi_js_1 = require("../TS/L3_ForWApi/CourseLearning/clscc_CourseTypeWApi.js");
    const clscc_CourseWApi_js_1 = require("../TS/L3_ForWApi/CourseLearning/clscc_CourseWApi.js");
    const clsCurrEduClsWApi_js_1 = require("../TS/L3_ForWApi/DailyRunning/clsCurrEduClsWApi.js");
    const clsgs_KnowledgesGraphWApi_js_1 = require("../TS/L3_ForWApi/Knowledges/clsgs_KnowledgesGraphWApi.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsOperateList2_js_1 = require("../TS/PubFun/clsOperateList2.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    /* gs_KnowledgesGraphCRUD 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    */
    class gs_KnowledgesGraphCRUD extends clsOperateList2_js_1.clsOperateList {
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
                this.hidSortgs_KnowledgesGraphBy = "knowledgeGraphName Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
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
                this.hidSortgs_KnowledgesGraphBy = "knowledgeGraphName Asc";
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
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
            this.CurrPageIndex = 1;
            const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
        }
        /* 合并数据
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
       */
        CombineData(arrgs_KnowledgesGraphObjLst, arrDataColumn) {
            var intRowNum = arrgs_KnowledgesGraphObjLst.length;
            var intColNum = arrDataColumn.length;
            var arrData = new Array();
            var arrHead = new Array();
            for (var j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].ColHeader);
            }
            arrData.push(arrHead);
            for (var i = 0; i < intRowNum; i++) {
                var arrRow = new Array();
                var objEN = arrgs_KnowledgesGraphObjLst[i];
                for (var j = 0; j < intColNum; j++) {
                    arrRow.push(objEN[arrDataColumn[j].FldName]); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            console.log("arrData", arrData);
            var strFileName = clsString2_js_1.clsString.Format("知识点逻辑图({0})导出.xlsx", clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /* 根据条件获取相应的对象列表
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
    */
        async ExportExcel_gs_KnowledgesGraph_Cache() {
            if (this.hidSortgs_KnowledgesGraphBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortgs_KnowledgesGraphBy)为空，请检查！(In BindGv_gs_KnowledgesGraph_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objgs_KnowledgesGraph_Cond = this.Combinegs_KnowledgesGraphConditionObj4ExportExcel();
            objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId, gs_KnowledgesGraphCRUD.strCourseId_Cache, "=");
            var strWhereCond = JSON.stringify(objgs_KnowledgesGraph_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrgs_KnowledgesGraphObjLst = [];
            try {
                this.RecCount = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetRecCountByCond_Cache)(objgs_KnowledgesGraph_Cond, gs_KnowledgesGraphCRUD.strCourseId_Cache);
                if (this.RecCount == 0) {
                    var lblMsg = document.createElement("span");
                    lblMsg.innerHTML = clsString2_js_1.clsString.Format("根据条件:[{0}]获取的对象列表数为0！", objgs_KnowledgesGraph_Cond.whereCond);
                    var divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    var strMsg = `在绑定Gv_Cache过程中，根据条件:[${objgs_KnowledgesGraph_Cond.whereCond}]获取的对象列表数为0！`;
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                var arrgs_KnowledgesGraphObjLst = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetSubObjLst_Cache)(objgs_KnowledgesGraph_Cond, gs_KnowledgesGraphCRUD.strCourseId_Cache);
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrgs_KnowledgesGraphObjLst.length == 0) {
                var strKey = `${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN._CurrTabName}_${gs_KnowledgesGraphCRUD.strCourseId_Cache}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                var arrDataColumn = [
                    {
                        FldName: "knowledgeGraphId",
                        SortBy: "",
                        ColHeader: "知识点图Id",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 2,
                        FuncName: () => { }
                    },
                    {
                        FldName: "knowledgeGraphName",
                        SortBy: "",
                        ColHeader: "知识点图名",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 3,
                        FuncName: () => { }
                    },
                    {
                        FldName: "id_CurrEduCls",
                        SortBy: "",
                        ColHeader: "当前教学班流水号",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 4,
                        FuncName: () => { }
                    },
                    {
                        FldName: "createUser",
                        SortBy: "",
                        ColHeader: "建立用户",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 6,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updDate",
                        SortBy: "",
                        ColHeader: "修改日期",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 7,
                        FuncName: () => { }
                    },
                    {
                        FldName: "updUser",
                        SortBy: "",
                        ColHeader: "修改人",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 8,
                        FuncName: () => { }
                    },
                    {
                        FldName: "memo",
                        SortBy: "",
                        ColHeader: "备注",
                        Text: "",
                        TdClass: "text-left",
                        ColumnType: "Label",
                        orderNum: 9,
                        FuncName: () => { }
                    },
                ];
                arrgs_KnowledgesGraphObjLst = arrgs_KnowledgesGraphObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrgs_KnowledgesGraphObjLst, arrDataColumn);
                console.log("完成BindGv_gs_KnowledgesGraph!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[id_CurrEduCls]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
        /// </summary>
        async SetDdl_id_CurrEduCls() {
            var objCurrEduCls_Cond = new clsCurrEduClsEN_js_1.clsCurrEduClsEN(); //查询区域
            const ddlid_CurrEduCls_q = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4List, "ddlid_CurrEduCls_q"); //查询区域
        }
        /// <summary>
        /// 设置绑定下拉框，针对字段:[courseId]
        /// (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion)
        /// </summary>
        async SetDdl_CourseId() {
            var objcc_Course_Cond = new clscc_CourseEN_js_1.clscc_CourseEN(); //查询区域
            const ddlCourseId_q = await (0, clscc_CourseTypeWApi_js_1.cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache)(this.divName4List, "ddlCourseId_q"); //查询区域
        }
        /* 函数功能:为查询区绑定下拉框
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
       */
        async BindDdl4QueryRegion() {
            // 在此处放置用户代码以初始化页面
            //const ddlid_CurrEduCls_q = await this.SetDdl_id_CurrEduCls();//查询区域
            const ddlCourseId_q = await this.SetDdl_CourseId(); //查询区域
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
                const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
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
                const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
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
        async DelRecord(strKnowledgeGraphId) {
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_DelRecordAsync)(strKnowledgeGraphId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_KnowledgesGraph_ReFreshCache();
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
        async SelectRecord(strKnowledgeGraphId) {
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetObjByKnowledgeGraphIdAsync)(strKnowledgeGraphId);
                var objgs_KnowledgesGraphEN = responseText;
                console.log("完成SelectRecord!");
                clsCommonFunc4Web2_js_1.clsCommonFunc4Web.Redirect("/Index/Main_gs_KnowledgesGraph");
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
                const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
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
            const responseBindGv = await this.ExportExcel_gs_KnowledgesGraph_Cache();
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinegs_KnowledgesGraphCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                }
                if (this.CourseId_q != "" && this.CourseId_q != "0") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId} = '${this.CourseId_q}'`;
                }
                if (this.KnowledgeGraphName_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_KnowledgeGraphName} like '% ${this.KnowledgeGraphName_q}%'`;
                }
                if (this.CreateUser_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CreateUser} like '% ${this.CreateUser_q}%'`;
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0009)在组合查询条件(Combinegs_KnowledgesGraphCondition)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            return strWhereCond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinegs_KnowledgesGraphConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objgs_KnowledgesGraph_Cond = new clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
                }
                if (this.CourseId_q != "" && this.CourseId_q != "0") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId} = '${this.CourseId_q}'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId, this.CourseId_q, "=");
                }
                if (this.KnowledgeGraphName_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_KnowledgeGraphName} like '% ${this.KnowledgeGraphName_q}%'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_KnowledgeGraphName, this.KnowledgeGraphName_q, "like");
                }
                if (this.CreateUser_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CreateUser} like '% ${this.CreateUser_q}%'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CreateUser, this.CreateUser_q, "like");
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_UpdDate, this.UpdDate_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0010)在组合查询条件对象(Combinegs_KnowledgesGraphConditionObj)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objgs_KnowledgesGraph_Cond.whereCond = strWhereCond;
            return objgs_KnowledgesGraph_Cond;
        }
        /* 把所有的查询控件内容组合成一个条件串
        (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
         <returns>条件串(strWhereCond)</returns>
       */
        Combinegs_KnowledgesGraphConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && userName = '张三'
            var strWhereCond = " 1 = 1 ";
            var objgs_KnowledgesGraph_Cond = new clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_id_CurrEduCls} = '${this.id_CurrEduCls_q}'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
                }
                if (this.CourseId_q != "" && this.CourseId_q != "0") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId} = '${this.CourseId_q}'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId, this.CourseId_q, "=");
                }
                if (this.KnowledgeGraphName_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_KnowledgeGraphName} like '% ${this.KnowledgeGraphName_q}%'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_KnowledgeGraphName, this.KnowledgeGraphName_q, "like");
                }
                if (this.CreateUser_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CreateUser} like '% ${this.CreateUser_q}%'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CreateUser, this.CreateUser_q, "like");
                }
                if (this.UpdDate_q != "") {
                    strWhereCond += ` And ${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_UpdDate} like '% ${this.UpdDate_q}%'`;
                    objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_UpdDate, this.UpdDate_q, "like");
                }
            }
            catch (objException) {
                var strMsg = `(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_KnowledgesGraphConditionObj4ExportExcel)时出错!请联系管理员!${objException}`;
                throw strMsg;
            }
            objgs_KnowledgesGraph_Cond.whereCond = strWhereCond;
            return objgs_KnowledgesGraph_Cond;
        }
        /* 显示gs_KnowledgesGraph对象的所有属性值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
         <param name = "divContainer">显示容器</param>
         <param name = "arrgs_KnowledgesGraphObjLst">需要绑定的对象列表</param>
       */
        BindTab_gs_KnowledgesGraph(divContainer, arrgs_KnowledgesGraphObjLst) {
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
                    FldName: "knowledgeGraphName",
                    SortBy: "knowledgeGraphName",
                    ColHeader: "知识点图名",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "createUser",
                    SortBy: "createUser",
                    ColHeader: "建立用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "id_CurrEduCls",
                    SortBy: "id_CurrEduCls",
                    ColHeader: "当前教学班流水号",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "courseId",
                    SortBy: "courseId",
                    ColHeader: "课程Id",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV3(o, arrgs_KnowledgesGraphObjLst, arrDataColumn, "knowledgeGraphId", this);
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
            const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
        }
        /* 根据条件获取相应的对象列表
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
       */
        async BindGv_gs_KnowledgesGraph() {
            if (this.hidSortgs_KnowledgesGraphBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortgs_KnowledgesGraphBy)为空，请检查！(In BindGv_gs_KnowledgesGraph)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var strWhereCond = this.Combinegs_KnowledgesGraphCondition();
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrgs_KnowledgesGraphObjLst = [];
            try {
                const responseRecCount = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetRecCountByCondAsync)(strWhereCond).then((jsonData) => {
                    this.RecCount = jsonData;
                });
                //if (this.RecCount == 0) {
                //    var lblMsg: HTMLSpanElement = <HTMLSpanElement>document.createElement("span");
                //    lblMsg.innerHTML = clsString.Format("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                //    var divDataLst: HTMLDivElement = <HTMLDivElement>document.getElementById("divDataLst");
                //    if (divDataLst != null) {
                //        divDataLst.innerText = "";
                //        divDataLst.appendChild(lblMsg);
                //    }
                //    var strMsg: string = `在绑定Gv过程中，根据条件:[${strWhereCond}]获取的对象列表数为0！`;
                //    console.error("Error: ", strMsg);
                //    //console.trace();
                //    alert(strMsg);
                //    return;
                //}
                var intPageCount = this.objPager.GetPageCount(this.RecCount, this.pageSize);
                if (intCurrPageIndex == 0) {
                    if (intPageCount > 1)
                        intCurrPageIndex = intPageCount;
                    else
                        intCurrPageIndex = 1;
                    this.CurrPageIndex = intCurrPageIndex;
                }
                else if (intCurrPageIndex > intPageCount) {
                    intCurrPageIndex = intPageCount;
                    if (intCurrPageIndex == 0)
                        intCurrPageIndex = 1;
                    this.CurrPageIndex = intCurrPageIndex;
                }
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortgs_KnowledgesGraphBy,
                    sortFun: (x, y) => { return 0; }
                };
                const responseObjLst = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrgs_KnowledgesGraphObjLst = jsonData;
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
            var divPager = document.getElementById("divPager");
            if (this.RecCount <= this.pageSize) {
                if (divPager != null) {
                    divPager.style.display = "none";
                }
            }
            else {
                if (divPager != null) {
                    divPager.style.display = "block";
                }
            }
            if (arrgs_KnowledgesGraphObjLst.length == 0) {
                var lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                var divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                var strMsg = `在绑定Gv_Cache过程中，根据条件获取的对象列表数为0！`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_gs_KnowledgesGraph(strListDiv, arrgs_KnowledgesGraphObjLst);
                console.log("完成BindGv_gs_KnowledgesGraph!");
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
       (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
     */
        async BindGv_gs_KnowledgesGraph4Func() {
            if (this.hidSortgs_KnowledgesGraphBy == null) {
                var strMsg = `在显示列表时，排序字段(hidSortgs_KnowledgesGraphBy)为空，请检查！(In BindGv_gs_KnowledgesGraph_Cache)`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            var strListDiv = this.mstrListDiv;
            var objgs_KnowledgesGraph_Cond = this.Combinegs_KnowledgesGraphConditionObj();
            objgs_KnowledgesGraph_Cond.SetCondFldValue(clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN.con_CourseId, gs_KnowledgesGraphCRUD.strCourseId_Cache, "=");
            var strWhereCond = JSON.stringify(objgs_KnowledgesGraph_Cond);
            var intCurrPageIndex = this.getCurrPageIndex(this.divName4Pager); //获取当前页
            var arrgs_KnowledgesGraphObjLst = [];
            var arrgs_KnowledgesGraphExObjLst = [];
            try {
                this.RecCount = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetRecCountByCond_Cache)(objgs_KnowledgesGraph_Cond, gs_KnowledgesGraphCRUD.strCourseId_Cache);
                var objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: this.hidSortgs_KnowledgesGraphBy,
                    sortFun: (x, y) => { return 0; }
                };
                arrgs_KnowledgesGraphObjLst = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetObjLstByPager_Cache)(objPagerPara, gs_KnowledgesGraphCRUD.strCourseId_Cache);
                arrgs_KnowledgesGraphExObjLst = arrgs_KnowledgesGraphObjLst.map(this.CopyToEx);
                for (var objInFor of arrgs_KnowledgesGraphExObjLst) {
                    const conFuncMap = await this.FuncMap(objInFor);
                }
            }
            catch (e) {
                var strMsg = `绑定GridView不成功,${e}.`;
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrgs_KnowledgesGraphObjLst.length == 0) {
                var strKey = `${clsgs_KnowledgesGraphEN_js_1.clsgs_KnowledgesGraphEN._CurrTabName}_${gs_KnowledgesGraphCRUD.strCourseId_Cache}`;
                var strMsg = `在BindGv_Cache过程中，根据条件对象获取的对象列表数为0！(Key=${strKey})`;
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                this.BindTab_gs_KnowledgesGraph4Func(strListDiv, arrgs_KnowledgesGraphExObjLst);
                console.log("完成BindGv_gs_KnowledgesGraph4Func!");
            }
            catch (e) {
                var strMsg = `绑定对象列表不成功.Error Massage:${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 显示gs_KnowledgesGraph对象的所有属性值
      (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
      <param name = "divContainer">显示容器</param>
      <param name = "arrgs_KnowledgesGraphExObjLst">需要绑定的对象列表</param>
    */
        BindTab_gs_KnowledgesGraph4Func(divContainer, arrgs_KnowledgesGraphExObjLst) {
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
                    FldName: "knowledgeGraphName",
                    SortBy: "knowledgeGraphName",
                    ColHeader: "知识点图名",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 2,
                    FuncName: () => { }
                },
                {
                    FldName: "courseName",
                    SortBy: "courseName",
                    ColHeader: "课程",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 3,
                    FuncName: () => { }
                },
                {
                    FldName: "eduClassName",
                    SortBy: "eduClassName",
                    ColHeader: "当前教学班",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 4,
                    FuncName: () => { }
                },
                {
                    FldName: "createUser",
                    SortBy: "createUser",
                    ColHeader: "建立用户",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 5,
                    FuncName: () => { }
                },
                {
                    FldName: "updDate",
                    SortBy: "updDate",
                    ColHeader: "修改日期",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 6,
                    FuncName: () => { }
                },
                {
                    FldName: "updUser",
                    SortBy: "updUser",
                    ColHeader: "修改人",
                    Text: "",
                    TdClass: "text-left",
                    ColumnType: "Label",
                    orderNum: 7,
                    FuncName: () => { }
                },
            ];
            clsCommonFunc4Web2_js_1.clsCommonFunc4Web.BindTabV4(o, arrgs_KnowledgesGraphExObjLst, arrDataColumn, "knowledgeGraphId", this);
            this.objPager.RecCount = this.RecCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /// <summary>
        /// 把同一个类的对象,复制到另一个对象
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyToEx)
        /// </summary>
        /// <param name = "objgs_KnowledgesGraphENS">源对象</param>
        /// <returns>目标对象=>clsgs_KnowledgesGraphEN:objgs_KnowledgesGraphENT</returns>
        CopyToEx(objgs_KnowledgesGraphENS) {
            var objgs_KnowledgesGraphENT = new clsgs_KnowledgesGraphENEx_js_1.clsgs_KnowledgesGraphENEx();
            try {
                (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_CopyObjTo)(objgs_KnowledgesGraphENS, objgs_KnowledgesGraphENT);
                return objgs_KnowledgesGraphENT;
            }
            catch (e) {
                var strMsg = clsString2_js_1.clsString.Format("(errid:WiTsCs0011)Copy表对象数据出错,${e}.");
                console.error(strMsg);
                alert(strMsg);
                return objgs_KnowledgesGraphENT;
            }
        }
        /// <summary>
        /// 把一个扩展类的部分属性进行函数转换
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap)
        /// </summary>
        /// <param name = "objgs_KnowledgesGraphS">源对象</param>
        async FuncMap(objgs_KnowledgesGraph) {
            try {
                {
                    var CurrEduCls_id_CurrEduCls = objgs_KnowledgesGraph.id_CurrEduCls;
                    var CurrEduCls_EduClassName = await (0, clsCurrEduClsWApi_js_1.CurrEduCls_func)(clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_id_CurrEduCls, clsCurrEduClsEN_js_1.clsCurrEduClsEN.con_EduClsName, CurrEduCls_id_CurrEduCls);
                    objgs_KnowledgesGraph.eduClassName = CurrEduCls_EduClassName;
                }
                ;
                {
                    var cc_Course_CourseId = objgs_KnowledgesGraph.courseId;
                    var cc_Course_CourseName = await (0, clscc_CourseWApi_js_1.cc_Course_func)(clscc_CourseEN_js_1.clscc_CourseEN.con_CourseId, clscc_CourseEN_js_1.clscc_CourseEN.con_CourseName, cc_Course_CourseId);
                    objgs_KnowledgesGraph.courseName = cc_Course_CourseName;
                }
                ;
            }
            catch (e) {
                var strMsg = `(errid:WiTsCs0012)函数映射表对象数据出错,${e}.`;
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /// <summary>
        /// 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时，需用该类的扩展类的同名函数
        /// 作者:lyl
        /// 日期:
        /// (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortFunExportExcel)
        /// </summary>
        /// <param name = "a">比较的第1个对象</param>
        /// <param name = "b">比较的第1个对象</param>
        /// <returns>返回两个对象比较的结果</returns>
        SortFun_ExportExcel(a, b) {
            if (a.knowledgeGraphId == b.knowledgeGraphId)
                return a.knowledgeGraphName.localeCompare(b.knowledgeGraphName);
            else
                return a.knowledgeGraphId.localeCompare(b.knowledgeGraphId);
        }
        /* 函数功能:从界面列表中根据某一个字段排序
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
         <param name = "objAnchorElement">带有排序字段的Anchors</param>
       */
        async SortBy(objAnchorElement) {
            console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
            //event = window.event || event;
            var thisEventObj = objAnchorElement;
            var strFldName = thisEventObj.getAttribute("FldName");
            if (clsString2_js_1.clsString.IsNullOrEmpty(strFldName) == true)
                return;
            var strSortByFld = strFldName;
            if (this.hidSortgs_KnowledgesGraphBy.indexOf(strSortByFld) >= 0) {
                if (this.hidSortgs_KnowledgesGraphBy.indexOf("Asc") >= 0) {
                    this.hidSortgs_KnowledgesGraphBy = `${strSortByFld} Desc`;
                }
                else {
                    this.hidSortgs_KnowledgesGraphBy = `${strSortByFld} Asc`;
                }
            }
            else {
                this.hidSortgs_KnowledgesGraphBy = `${strSortByFld} Asc`;
            }
            const responseBindGv = await this.BindGv_gs_KnowledgesGraph();
        }
        /* 复制记录
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
       */
        async CopyRecord(arrKnowledgeGraphId) {
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetObjLstByKnowledgeGraphIdLstAsync)(arrKnowledgeGraphId);
                console.log('responseText=');
                console.log(responseText);
                var intCount = 0;
                var arrgs_KnowledgesGraphObjLst = responseText;
                for (let objInFor of arrgs_KnowledgesGraphObjLst) {
                    const strMaxStrId = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_GetMaxStrIdAsync)();
                    console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.knowledgeGraphId = strMaxStrId;
                    const responseText2 = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_AddNewRecordAsync)(objInFor);
                    console.log('responseText2=');
                    console.log(responseText2);
                    var returnBool = !!responseText2;
                    if (returnBool == true) {
                        //gs_KnowledgesGraph_ReFreshCache();
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
        async DelMultiRecord(arrKnowledgeGraphId) {
            try {
                const responseText = await (0, clsgs_KnowledgesGraphWApi_js_1.gs_KnowledgesGraph_Delgs_KnowledgesGraphsAsync)(arrKnowledgeGraphId);
                var returnInt = responseText;
                if (returnInt > 0) {
                    //gs_KnowledgesGraph_ReFreshCache();
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
         <param name = "objgs_KnowledgesGraph">需要显示的对象</param>
       */
        Showgs_KnowledgesGraphObj(divContainer, objgs_KnowledgesGraph) {
            var o = document.getElementById(divContainer);
            if (o == null) {
                alert(`${divContainer}不存在！`);
                return;
            }
            var sstrKeys = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetObjKeys(objgs_KnowledgesGraph);
            var ul = document.createElement("ul");
            for (let strKey of sstrKeys) {
                var strValue = objgs_KnowledgesGraph[strKey];
                var li = document.createElement("li");
                li.innerHTML = `${strKey}:${strValue}`;
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /* 函数功能:从界面列表中获取第一个关键字的值
         (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
         <param name = "pobjgs_KnowledgesGraphEN">表实体类对象</param>
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
        * 课程Id (Used In CombineCondition())
       */
        get CourseId_q() {
            if ($("#ddlCourseId_q").val() == "0")
                return "";
            return $("#ddlCourseId_q").val();
        }
        /*
        * 课程Id (Used In CombineCondition())
       */
        set CourseId_q(value) {
            $("#ddlCourseId_q").val(value);
        }
        /*
        * 建立用户 (Used In CombineCondition())
       */
        get CreateUser_q() {
            return $("#txtCreateUser_q").val();
        }
        /*
        * 建立用户 (Used In CombineCondition())
       */
        set CreateUser_q(value) {
            $("#txtCreateUser_q").val(value);
        }
        /*
        * 获取当前页序号(Used In BindGv_Cache)
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
        set hidSortgs_KnowledgesGraphBy(value) {
            $("#hidSortgs_KnowledgesGraphBy").val(value);
        }
        /*
        * 设置排序字段
       */
        get hidSortgs_KnowledgesGraphBy() {
            return $("#hidSortgs_KnowledgesGraphBy").val();
        }
        /*
        * 当前教学班流水号 (Used In CombineCondition())
       */
        get id_CurrEduCls_q() {
            if ($("#ddlid_CurrEduCls_q").val() == "0")
                return "";
            return $("#ddlid_CurrEduCls_q").val();
        }
        /*
        * 当前教学班流水号 (Used In CombineCondition())
       */
        set id_CurrEduCls_q(value) {
            $("#ddlid_CurrEduCls_q").val(value);
        }
        /*
        * 知识点图名 (Used In CombineCondition())
       */
        get KnowledgeGraphName_q() {
            return $("#txtKnowledgeGraphName_q").val();
        }
        /*
        * 知识点图名 (Used In CombineCondition())
       */
        set KnowledgeGraphName_q(value) {
            $("#txtKnowledgeGraphName_q").val(value);
        }
        /*
        * 修改日期 (Used In CombineCondition())
       */
        get UpdDate_q() {
            return $("#txtUpdDate_q").val();
        }
        /*
        * 修改日期 (Used In CombineCondition())
       */
        set UpdDate_q(value) {
            $("#txtUpdDate_q").val(value);
        }
    }
    exports.gs_KnowledgesGraphCRUD = gs_KnowledgesGraphCRUD;
    gs_KnowledgesGraphCRUD.strCourseId_Cache = "99999991"; //缓存分类字段
});
