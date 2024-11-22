(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js", "../../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanENEx.js", "../../TS/L3_ForWApiEx/GraduateEduTopic/clsvgs_ResearchPlanExWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js", "../../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ResearchPlanCRUD = void 0;
    /**
    * 类名:gs_ResearchPlanCRUD(界面:gs_ResearchPlanCRUD)
    * 表名:gs_ResearchPlan(01120663)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:40:56
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培主题(GraduateEduTopic)
    * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsvgs_ResearchPlanWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsgs_TopicTaskStatusWApi_js_1 = require("../../TS/L3_ForWApi/ParameterTable/clsgs_TopicTaskStatusWApi.js");
    const clsgs_ResearchPlanWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsgs_ResearchPlanWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanEN_js_1 = require("../../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanEN.js");
    const clsvgs_ResearchPlanENEx_js_1 = require("../../TS/L0_Entity/GraduateEduTopic/clsvgs_ResearchPlanENEx.js");
    const clsvgs_ResearchPlanExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduTopic/clsvgs_ResearchPlanExWApi.js");
    const clsvgs_ResearchPlanWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsvgs_ResearchPlanWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsvgs_ResearchPlanWApi.js");
    const clsgs_ResearchPlanWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsgs_ResearchPlanWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsgs_ResearchPlanWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsgs_ResearchPlanWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduTopic/clsgs_ResearchPlanWApi.js");
    const clsgs_ResearchPlanEN_js_1 = require("../../TS/L0_Entity/GraduateEduTopic/clsgs_ResearchPlanEN.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** gs_ResearchPlanCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class gs_ResearchPlanCRUD {
        constructor() {
            //专门用于数据列表的界面变量，用于分页功能等
            this.currPageIndex = 0;
            this.divName4List = "divList"; //列表区的层Id
            this.divName4DataList = "divDataLst"; //列表中数据区的层Id
            this.divName4Pager = "divPager"; //列表中的分页区的层Id
            this.bolIsInitShow = false; //记录是否导入分页区的变量
            this.bolIsTableSm = true; //是否窄行的小表，即表中加样式： table-sm
            this.divName4Query = "divQuery"; //查询区的层Id
            this.divName4Function = "divFunction"; //功能区的层Id
            this.divName4Layout = "divLayout"; //界面布局的层Id
            this.recCount = 0;
            gs_ResearchPlanCRUD.objPage_CRUD = this;
            this.objPager = new clsPager_js_1.clsPager(this);
        }
        /**
        * 每页记录数，在扩展类可以修改
        **/
        get pageSize() {
            return 5;
        }
        /** 函数功能:页面导入,当页面开始运行时所发生的事件
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
        **/
        async Page_Load() {
            const strThisFuncName = this.Page_Load.name;
            // 在此处放置用户代码以初始化页面
            try {
                this.SetEventFunc();
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy = "topicName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /** 函数功能:设置事件函数
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetEventFunc)
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
        /** 函数功能:页面导入,当页面开始运行时所发生的事件
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
        **/
        async Page_Load_Cache() {
            const strThisFuncName = this.Page_Load_Cache.name;
            // 在此处放置用户代码以初始化页面
            try {
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.SetEventFunc();
                gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy = "topicName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("页面启动不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnQuery_Click)
        **/
        async btnQuery_Click() {
            const strThisFuncName = this.btnQuery_Click.name;
            this.SetCurrPageIndex(1);
            const responseBindGv = await this.BindGv_vgs_ResearchPlan();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrvgs_ResearchPlanObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrvgs_ResearchPlanObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrvgs_ResearchPlanObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("主题研究计划({0})导出.xlsx", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
        **/
        async ExportExcel_vgs_ResearchPlan() {
            const strThisFuncName = this.ExportExcel_vgs_ResearchPlan.name;
            if (gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortvgs_ResearchPlanBy)为空，请检查！(In BindGv_vgs_ResearchPlan_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinevgs_ResearchPlanCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrvgs_ResearchPlanObjLst = [];
            try {
                this.recCount = await (0, clsvgs_ResearchPlanWApi_js_1.vgs_ResearchPlan_GetRecCountByCondAsync)(strWhereCond);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定ExportExcel过程中，根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrvgs_ResearchPlanObjLst = await (0, clsvgs_ResearchPlanWApi_js_2.vgs_ResearchPlan_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrvgs_ResearchPlanObjLst.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在ExportExcel过程中，根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "planId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "计划Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "topicName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "栏目主题",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_CurrEduCls",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "当前教学班流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "statusName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "状态名称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "planContent",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "计划内容",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "responsibleUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "负责人/小组",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "startDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "开始日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "endDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "截止日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 11,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "actualFinishingDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "实际完成日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 12,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "acceptanceUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "验收用户",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isSubmit",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否提交",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "updUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "修改人",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 15,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "updDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "修改日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "memo",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "备注",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 17,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrvgs_ResearchPlanObjLst = arrvgs_ResearchPlanObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrvgs_ResearchPlanObjLst, arrDataColumn);
                //console.log("完成BindGv_vgs_ResearchPlan!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel_Cache)
        **/
        async ExportExcel_vgs_ResearchPlan_Cache() {
            const strThisFuncName = this.ExportExcel_vgs_ResearchPlan_Cache.name;
            if (gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortvgs_ResearchPlanBy)为空，请检查！(In BindGv_vgs_ResearchPlan_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objvgs_ResearchPlan_Cond = await this.Combinevgs_ResearchPlanConditionObj4ExportExcel();
            objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls, gs_ResearchPlanCRUD.id_CurrEduCls_Cache, "=");
            const strWhereCond = JSON.stringify(objvgs_ResearchPlan_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrvgs_ResearchPlanObjLst = [];
            try {
                this.recCount = await (0, clsvgs_ResearchPlanWApi_js_3.vgs_ResearchPlan_GetRecCountByCond_Cache)(objvgs_ResearchPlan_Cond, gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objvgs_ResearchPlan_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvgs_ResearchPlan_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrvgs_ResearchPlanObjLst = await (0, clsvgs_ResearchPlanWApi_js_4.vgs_ResearchPlan_GetSubObjLst_Cache)(objvgs_ResearchPlan_Cond, gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrvgs_ResearchPlanObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "planId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "计划Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "topicName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "栏目主题",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_CurrEduCls",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "当前教学班流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "statusName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "状态名称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "planContent",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "计划内容",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "responsibleUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "负责人/小组",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "startDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "开始日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "endDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "截止日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 11,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "actualFinishingDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "实际完成日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 12,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "acceptanceUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "验收用户",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isSubmit",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否提交",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "updUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "修改人",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 15,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "updDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "修改日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "memo",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "备注",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 17,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrvgs_ResearchPlanObjLst = arrvgs_ResearchPlanObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrvgs_ResearchPlanObjLst, arrDataColumn);
                //console.log("完成BindGv_vgs_ResearchPlan!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[StatusId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_StatusIdInDiv() {
            await (0, clsgs_TopicTaskStatusWApi_js_1.gs_TopicTaskStatus_BindDdl_StatusIdInDiv_Cache)(this.divName4Query, "ddlStatusId_q"); //
        }
        /** 函数功能:为查询区绑定下拉框
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
        **/
        async BindDdl4QueryRegion() {
            const strThisFuncName = this.BindDdl4QueryRegion.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_StatusIdInDiv(); //查询区域
        }
        /**
        * 添加新记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnCopyRecord_Click)
        **/
        async btnCopyRecord_Click() {
            const strThisFuncName = this.btnCopyRecord_Click.name;
            try {
                const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
                if (arrKeyIds.length == 0) {
                    alert("请选择需要克隆的记录！");
                    return "";
                }
                await this.CopyRecord(arrKeyIds);
                await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "strPlanId": 表关键字
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecordInTab_Click)
        **/
        async btnDelRecordInTab_Click(strKeyId) {
            const strThisFuncName = this.btnDelRecordInTab_Click.name;
            try {
                if (strKeyId == "") {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                const responseText = await this.DelRecord(strKeyId);
                await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里选择记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnSelectRecordInTab_Click)
        **/
        async btnSelectRecordInTab_Click(strPlanId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(strPlanId) == true) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(strPlanId);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("选择记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 根据关键字删除记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelRecord)
        **/
        async DelRecord(strPlanId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsgs_ResearchPlanWApi_js_1.gs_ResearchPlan_DelRecordAsync)(strPlanId);
                if (returnInt > 0) {
                    //gs_ResearchPlan_ReFreshCache(gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                    const strInfo = (0, clsString_js_1.Format)("删除记录成功,共删除{0}条记录!", returnInt);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    const strInfo = (0, clsString_js_1.Format)("删除记录不成功!");
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelRecord!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 根据关键字选择相应的记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SelectRecord)
        * @param sender:参数列表
        **/
        async SelectRecord(strPlanId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objgs_ResearchPlanEN = await (0, clsgs_ResearchPlanWApi_js_2.gs_ResearchPlan_GetObjByPlanIdAsync)(strPlanId);
                //console.log("完成SelectRecord!", objgs_ResearchPlanEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_vgs_ResearchPlan");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("根据关键字获取相应的记录的对象不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /** 删除记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDelRecord_Click)
        **/
        async btnDelRecord_Click() {
            const strThisFuncName = this.btnDelRecord_Click.name;
            try {
                const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
                if (arrKeyIds.length == 0) {
                    alert("请选择需要删除的记录！");
                    return "";
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(arrKeyIds.length) == false) {
                    return;
                }
                await this.DelMultiRecord(arrKeyIds);
                await this.BindGv_vgs_ResearchPlan();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnExportExcel_Click)
        **/
        async btnExportExcel_Click() {
            const strThisFuncName = this.btnExportExcel_Click.name;
            const responseBindGv = await this.ExportExcel_vgs_ResearchPlan_Cache();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async Combinevgs_ResearchPlanCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.topicName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, this.topicName_q);
                }
                if (this.statusId_q != "" && this.statusId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, this.statusId_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(Combinegs_ResearchPlanCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async Combinevgs_ResearchPlanConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objvgs_ResearchPlan_Cond = new clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.topicName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, this.topicName_q);
                    objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, this.topicName_q, "like");
                }
                if (this.statusId_q != "" && this.statusId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, this.statusId_q);
                    objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, this.statusId_q, "=");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_ResearchPlanConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objvgs_ResearchPlan_Cond.whereCond = strWhereCond;
            return objvgs_ResearchPlan_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async Combinevgs_ResearchPlanConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objvgs_ResearchPlan_Cond = new clsvgs_ResearchPlanENEx_js_1.clsvgs_ResearchPlanENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.topicName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, this.topicName_q);
                    objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName, this.topicName_q, "like");
                }
                if (this.statusId_q != "" && this.statusId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, this.statusId_q);
                    objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusId, this.statusId_q, "=");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_ResearchPlanConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objvgs_ResearchPlan_Cond.whereCond = strWhereCond;
            return objvgs_ResearchPlan_Cond;
        }
        /** 显示vgs_ResearchPlan对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrgs_ResearchPlanObjLst:需要绑定的对象列表
        **/
        async BindTab_vgs_ResearchPlan(divContainer, arrvgs_ResearchPlanObjLst) {
            const strThisFuncName = this.BindTab_vgs_ResearchPlan.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{0}不存在！", divContainer));
                return;
            }
            const arrDataColumn = [
                {
                    fldName: "",
                    sortBy: "",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "",
                    text: "",
                    tdClass: "text-left",
                    columnType: "CheckBox",
                    orderNum: 1,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_TopicName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "栏目主题",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StatusName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "状态名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanContent,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "计划内容",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ResponsibleUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "负责人/小组",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_StartDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "开始日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_EndDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "截止日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_ActualFinishingDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "实际完成日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_AcceptanceUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "验收用户",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_IsSubmit,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "是否提交",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 11,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate,
                    sortBy: clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 12,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab_V)(o, arrvgs_ResearchPlanObjLst, arrDataColumn, clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_PlanId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrvgs_ResearchPlanExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrvgs_ResearchPlanExObjLst, arrDataColumn) {
            const arrFldName = clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrvgs_ResearchPlanExObjLst) {
                    await (0, clsvgs_ResearchPlanExWApi_js_1.vgs_ResearchPlanEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
                }
            }
        }
        /** 函数功能:在数据列表中跳转到前一页
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PrevPage)
        **/
        async PrevPage() {
            const strThisFuncName = this.PrevPage.name;
            const intCurrPageIndex = this.objPager.currPageIndex;
            const intPageIndex = Number(intCurrPageIndex) - 1;
            //console.log("跳转到" + intPageIndex + "页");
            this.IndexPage(intPageIndex);
        }
        /** 函数功能:在数据 列表中跳转到某一页
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_IndexPage)
        * @param intPageIndex:页序号
        **/
        async IndexPage(intPageIndex) {
            const strThisFuncName = this.IndexPage.name;
            if (intPageIndex == 0) {
                intPageIndex = this.objPager.pageCount;
            }
            //console.log("跳转到" + intPageIndex + "页");
            this.SetCurrPageIndex(intPageIndex);
            const responseBindGv = await this.BindGv_vgs_ResearchPlan();
        }
        /** 函数功能:在数据列表中跳转到下一页
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_NextPage)
        **/
        async NextPage() {
            const strThisFuncName = this.NextPage.name;
            const intCurrPageIndex = this.objPager.currPageIndex;
            const intPageIndex = Number(intCurrPageIndex) + 1;
            //console.log("跳转到" + intPageIndex + "页");
            this.IndexPage(intPageIndex);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv)
        **/
        async BindGv_vgs_ResearchPlan() {
            const strThisFuncName = this.BindGv_vgs_ResearchPlan.name;
            if (gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortvgs_ResearchPlanBy)为空，请检查！(In BindGv_vgs_ResearchPlan)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinevgs_ResearchPlanCondition();
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrvgs_ResearchPlanObjLst = [];
            try {
                this.recCount = await (0, clsvgs_ResearchPlanWApi_js_1.vgs_ResearchPlan_GetRecCountByCondAsync)(strWhereCond);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv过程中，根据条件:[{0}]获取的对象列表数为0！", strWhereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);
                if (intCurrPageIndex == 0) {
                    if (intPageCount > 1)
                        intCurrPageIndex = intPageCount;
                    else
                        intCurrPageIndex = 1;
                    this.SetCurrPageIndex(intCurrPageIndex);
                }
                else if (intCurrPageIndex > intPageCount) {
                    intCurrPageIndex = intPageCount;
                    this.SetCurrPageIndex(intCurrPageIndex);
                }
                const objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                const responseObjLst = await (0, clsvgs_ResearchPlanWApi_js_5.vgs_ResearchPlan_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrvgs_ResearchPlanObjLst = jsonData;
                });
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
            const divPager = document.getElementById("divPager");
            if (this.recCount <= this.pageSize) {
                if (divPager != null) {
                    divPager.style.display = "none";
                }
            }
            else {
                if (divPager != null) {
                    divPager.style.display = "block";
                }
            }
            if (arrvgs_ResearchPlanObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_vgs_ResearchPlan(strListDiv, arrvgs_ResearchPlanObjLst);
                //console.log("完成BindGv_vgs_ResearchPlan!");
            }
            catch (e) {
                //console.trace();
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
        **/
        async BindGv_vgs_ResearchPlan_Cache() {
            const strThisFuncName = this.BindGv_vgs_ResearchPlan_Cache.name;
            if (gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortvgs_ResearchPlanBy)为空，请检查！(In BindGv_vgs_ResearchPlan_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objvgs_ResearchPlan_Cond = await this.Combinevgs_ResearchPlanConditionObj();
            objvgs_ResearchPlan_Cond.SetCondFldValue(clsvgs_ResearchPlanEN_js_1.clsvgs_ResearchPlanEN.con_id_CurrEduCls, gs_ResearchPlanCRUD.id_CurrEduCls_Cache, "=");
            const strWhereCond = JSON.stringify(objvgs_ResearchPlan_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrvgs_ResearchPlanObjLst = [];
            try {
                this.recCount = await (0, clsvgs_ResearchPlanWApi_js_3.vgs_ResearchPlan_GetRecCountByCond_Cache)(objvgs_ResearchPlan_Cond, gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objvgs_ResearchPlan_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objvgs_ResearchPlan_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                const intPageCount = this.objPager.GetPageCount(this.recCount, this.pageSize);
                if (intCurrPageIndex == 0) {
                    if (intPageCount > 1)
                        intCurrPageIndex = intPageCount;
                    else
                        intCurrPageIndex = 1;
                    this.SetCurrPageIndex(intCurrPageIndex);
                }
                else if (intCurrPageIndex > intPageCount) {
                    intCurrPageIndex = intPageCount;
                    this.SetCurrPageIndex(intCurrPageIndex);
                }
                const objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy,
                    sortFun: clsvgs_ResearchPlanWApi_js_6.vgs_ResearchPlan_SortFun_Defa
                };
                arrvgs_ResearchPlanObjLst = await (0, clsvgs_ResearchPlanWApi_js_7.vgs_ResearchPlan_GetObjLstByPager_Cache)(objPagerPara, gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const divPager = document.getElementById("divPager");
            if (this.recCount <= this.pageSize) {
                if (divPager != null) {
                    divPager.style.display = "none";
                }
            }
            else {
                if (divPager != null) {
                    divPager.style.display = "block";
                }
            }
            if (arrvgs_ResearchPlanObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_ResearchPlanEN_js_1.clsgs_ResearchPlanEN._CurrTabName, gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_vgs_ResearchPlan(strListDiv, arrvgs_ResearchPlanObjLst);
                //console.log("完成BindGv_vgs_ResearchPlan_Cache!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 排序函数。根据表对象中随机两个字段的值进行比较,正常使用时，需用该类的扩展类的同名函数
        * 作者:pyf
        * 日期:
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortFunExportExcel)
        * @param a:比较的第1个对象
        * @param b:比较的第1个对象
        * @returns 返回两个对象比较的结果
        **/
        SortFun_ExportExcel(a, b) {
            const strThisFuncName = this.SortFun_ExportExcel.name;
            if (a.updUser == b.updUser)
                return a.updUser.localeCompare(b.updUser);
            else
                return a.updDate.localeCompare(b.updDate);
        }
        /** 函数功能:从界面列表中根据某一个字段排序
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SortBy)
        * @param objAnchorElement:带有排序字段的Anchors
        **/
        async SortBy(objAnchorElement) {
            const strThisFuncName = this.SortBy.name;
            console.log("objAnchorElement(In SetAllCkechedKeysV2):", objAnchorElement);
            let strSortExpress = "";
            //event = window.event || event;
            if (typeof (objAnchorElement) != "function") {
                const thisEventObj = objAnchorElement;
                strSortExpress = thisEventObj.getAttribute("FldName");
            }
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, gs_ResearchPlanCRUD.ascOrDesc4SortFun, gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy, strSortExpress);
            gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy = sortBy;
            gs_ResearchPlanCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            gs_ResearchPlanCRUD.sortFun_Static = sortFun;
            await this.BindGv_vgs_ResearchPlan();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrPlanId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrgs_ResearchPlanObjLst = await (0, clsgs_ResearchPlanWApi_js_3.gs_ResearchPlan_GetObjLstByPlanIdLstAsync)(arrPlanId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrgs_ResearchPlanObjLst) {
                    const strMaxStrId = await (0, clsgs_ResearchPlanWApi_js_4.gs_ResearchPlan_GetMaxStrIdAsync)();
                    //console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.planId = strMaxStrId;
                    const returnBool = await (0, clsgs_ResearchPlanWApi_js_5.gs_ResearchPlan_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        //gs_ResearchPlan_ReFreshCache(gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                        const strInfo = (0, clsString_js_1.Format)("克隆记录成功!");
                        intCount++;
                    }
                    else {
                        const strInfo = (0, clsString_js_1.Format)("克隆记录不成功!");
                        //显示信息框
                        alert(strInfo);
                    }
                }
                const strInfo = (0, clsString_js_1.Format)("共克隆了{0}条记录!", intCount);
                alert(strInfo);
                //console.log('完成！');
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
            }
        }
        /** 根据关键字列表删除记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_DelMultiRecord)
        **/
        async DelMultiRecord(arrPlanId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsgs_ResearchPlanWApi_js_6.gs_ResearchPlan_Delgs_ResearchPlansAsync)(arrPlanId);
                if (returnInt > 0) {
                    //gs_ResearchPlan_ReFreshCache(gs_ResearchPlanCRUD.id_CurrEduCls_Cache);
                    const strInfo = (0, clsString_js_1.Format)("删除记录成功,共删除{0}条记录!", returnInt);
                    //显示信息框
                    alert(strInfo);
                }
                else {
                    const strInfo = (0, clsString_js_1.Format)("删除记录不成功!");
                    //显示信息框
                    alert(strInfo);
                }
                console.log("完成DelMultiRecord!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("删除记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 显示{0}对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ShowTabObj)
        * @param divContainer:显示容器
        * @param objgs_ResearchPlan:需要显示的对象
        **/
        Showgs_ResearchPlanObj(divContainer, objgs_ResearchPlan) {
            const strThisFuncName = this.Showgs_ResearchPlanObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ResearchPlan);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objgs_ResearchPlan.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjgs_ResearchPlanEN:表实体类对象
        * @returns 列表的第一个关键字值
        **/
        GetFirstKey() {
            const strThisFuncName = this.GetFirstKey.name;
            if (clsCommFunc4Web_js_1.arrSelectedKeys.length == 1) {
                return clsCommFunc4Web_js_1.arrSelectedKeys[0];
            }
            else {
                alert(`请选择一个关键字！目前选择了:${clsCommFunc4Web_js_1.arrSelectedKeys.length}个关键字。`);
                return "";
            }
        }
        /** 函数功能:设置当前页序号
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_SetCurrPageIndex)
        * @param value:页序号
        * @param strDivName4Pager:当前分页所在的层(div)
        **/
        SetCurrPageIndex(value) {
            this.objPager.currPageIndex = value;
        }
        /** 函数功能:预留函数，在某一个层(div)里绑定数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindInDiv)
        **/
        async BindInDiv(divName4Bind) {
        }
        /**
        * 状态Id (Used In CombineCondition())
        **/
        get statusId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlStatusId_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 状态Id (Used In CombineCondition())
        **/
        set statusId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Query, "ddlStatusId_q", value);
        }
        /**
        * 栏目主题 (Used In CombineCondition())
        **/
        get topicName_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtTopicName_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 栏目主题 (Used In CombineCondition())
        **/
        set topicName_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtTopicName_q", value);
        }
        /**
        * 设置界面标题-相当使用ViewState功能
        **/
        set ViewTitle(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Layout, "lblViewTitle", value);
        }
        /**
        * 设置界面标题
        **/
        get ViewTitle() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetLabelHtmlInDiv)(this.divName4Query, "lblViewTitle");
            return strValue;
        }
    }
    exports.gs_ResearchPlanCRUD = gs_ResearchPlanCRUD;
    gs_ResearchPlanCRUD.ascOrDesc4SortFun = "Asc";
    gs_ResearchPlanCRUD.sortvgs_ResearchPlanBy = "";
    gs_ResearchPlanCRUD.id_CurrEduCls_Cache = ""; //缓存分类字段
});
