(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js", "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupENEx.js", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperGroupExWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsOrderByData.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperGroupCRUD = void 0;
    /**
    * 类名:gs_PaperGroupCRUD(界面:gs_PaperGroupCRUD)
    * 表名:gs_PaperGroup(01120749)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:39:23
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:研培论文(GraduateEduPaper)
    * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsgs_PaperGroupWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_9 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_10 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_11 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupEN_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupEN.js");
    const clsgs_PaperGroupENEx_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperGroupENEx.js");
    const clsgs_PaperGroupExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperGroupExWApi.js");
    const clsgs_PaperGroupWApi_js_12 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_13 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_14 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_15 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_16 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_17 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsgs_PaperGroupWApi_js_18 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperGroupWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsOrderByData_js_1 = require("../../TS/PubFun/clsOrderByData.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** gs_PaperGroupCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class gs_PaperGroupCRUD {
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
            gs_PaperGroupCRUD.objPage_CRUD = this;
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
                gs_PaperGroupCRUD.sortgs_PaperGroupBy = "paperGroupId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_gs_PaperGroup();
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
                gs_PaperGroupCRUD.sortgs_PaperGroupBy = "paperGroupId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_gs_PaperGroup();
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
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrgs_PaperGroupObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrgs_PaperGroupObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrgs_PaperGroupObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("论文分组({0})导出.xlsx", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
        **/
        async ExportExcel_gs_PaperGroup() {
            const strThisFuncName = this.ExportExcel_gs_PaperGroup.name;
            if (gs_PaperGroupCRUD.sortgs_PaperGroupBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinegs_PaperGroupCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrgs_PaperGroupObjLst = [];
            try {
                this.recCount = await (0, clsgs_PaperGroupWApi_js_1.gs_PaperGroup_GetRecCountByCondAsync)(strWhereCond);
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
                arrgs_PaperGroupObjLst = await (0, clsgs_PaperGroupWApi_js_2.gs_PaperGroup_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrgs_PaperGroupObjLst.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在ExportExcel过程中，根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "paperGroupId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "组Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "paperGroupName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "组名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
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
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "orderNum",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "序号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
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
                        orderNum: 6,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "meno",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "备注",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrgs_PaperGroupObjLst = arrgs_PaperGroupObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrgs_PaperGroupObjLst, arrDataColumn);
                //console.log("完成BindGv_gs_PaperGroup!");
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
        async ExportExcel_gs_PaperGroup_Cache() {
            const strThisFuncName = this.ExportExcel_gs_PaperGroup_Cache.name;
            if (gs_PaperGroupCRUD.sortgs_PaperGroupBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objgs_PaperGroup_Cond = await this.Combinegs_PaperGroupConditionObj4ExportExcel();
            objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, gs_PaperGroupCRUD.UpdUser_Cache, "=");
            const strWhereCond = JSON.stringify(objgs_PaperGroup_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrgs_PaperGroupObjLst = [];
            try {
                this.recCount = await (0, clsgs_PaperGroupWApi_js_3.gs_PaperGroup_GetRecCountByCond_Cache)(objgs_PaperGroup_Cond, gs_PaperGroupCRUD.UpdUser_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrgs_PaperGroupObjLst = await (0, clsgs_PaperGroupWApi_js_4.gs_PaperGroup_GetSubObjLst_Cache)(objgs_PaperGroup_Cond, gs_PaperGroupCRUD.UpdUser_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrgs_PaperGroupObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName, gs_PaperGroupCRUD.UpdUser_Cache);
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
                        fldName: "paperGroupId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "组Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "paperGroupName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "组名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
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
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "orderNum",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "序号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
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
                        orderNum: 6,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "meno",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "备注",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrgs_PaperGroupObjLst = arrgs_PaperGroupObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrgs_PaperGroupObjLst, arrDataColumn);
                //console.log("完成BindGv_gs_PaperGroup!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 函数功能:为查询区绑定下拉框
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
        **/
        async BindDdl4QueryRegion() {
            const strThisFuncName = this.BindDdl4QueryRegion.name;
            // 在此处放置用户代码以初始化页面
        }
        /**
        * 重序
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnReOrder_Click)
        **/
        async btnReOrder_Click() {
            const strThisFuncName = this.btnReOrder_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strUpdUser = gs_PaperGroupCRUD.UpdUser_OrderNum;
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                const jsonObject = {
                    "upduser": strUpdUser,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperGroupWApi_js_5.gs_PaperGroup_ReOrderAsync)(objOrderByData);
                //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("重序出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_gs_PaperGroup();
        }
        /**
        * 置底
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
        **/
        async btnGoBottum_Click() {
            const strThisFuncName = this.btnGoBottum_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strUpdUser = gs_PaperGroupCRUD.UpdUser_OrderNum;
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert("请选择需要置底的记录！");
                return "";
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "upduser": strUpdUser,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperGroupWApi_js_6.gs_PaperGroup_GoBottomAsync)(objOrderByData);
                //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("置底出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_gs_PaperGroup();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_1.SetCheckedItem4KeyId)(strListDiv, e));
        }
        /**
        * 移动记录序号时的预检查函数
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
        **/
        PreCheck4Order() {
            const strThisFuncName = this.PreCheck4Order.name;
            const strUpdUser = gs_PaperGroupCRUD.UpdUser_OrderNum;
            if (strUpdUser == "") {
                const strMsg = (0, clsString_js_1.Format)("请输入UpdUser!");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return false;
            }
            return true;
        }
        /**
        * 下移
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnDownMove_Click)
        **/
        async btnDownMove_Click() {
            const strThisFuncName = this.btnDownMove_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strUpdUser = gs_PaperGroupCRUD.UpdUser_OrderNum;
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert(`请选择需要下移的记录!`);
                return;
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "upduser": strUpdUser,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperGroupWApi_js_7.gs_PaperGroup_DownMoveAsync)(objOrderByData);
                //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("下移记录出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_gs_PaperGroup();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_1.SetCheckedItem4KeyId)(strListDiv, e));
        }
        /**
        * 上移
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        **/
        async btnUpMove_Click() {
            const strThisFuncName = this.btnUpMove_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strUpdUser = gs_PaperGroupCRUD.UpdUser_OrderNum;
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert(`请选择需要上移的记录!`);
                return;
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "upduser": strUpdUser,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperGroupWApi_js_8.gs_PaperGroup_UpMoveAsync)(objOrderByData);
                //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("上移记录出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_gs_PaperGroup();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_1.SetCheckedItem4KeyId)(strListDiv, e));
        }
        /** 置顶
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
        **/
        async btnGoTop_Click() {
            const strThisFuncName = this.btnGoTop_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strUpdUser = gs_PaperGroupCRUD.UpdUser_OrderNum;
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert("请选择需要置顶的记录！");
                return "";
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "upduser": strUpdUser,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clsgs_PaperGroupWApi_js_9.gs_PaperGroup_GoTopAsync)(objOrderByData);
                //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("置顶出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_gs_PaperGroup();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_1.SetCheckedItem4KeyId)(strListDiv, e));
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
                await this.BindGv_gs_PaperGroup();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "strPaperGroupId": 表关键字
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
                await this.BindGv_gs_PaperGroup();
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
        async btnSelectRecordInTab_Click(strPaperGroupId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(strPaperGroupId) == true) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(strPaperGroupId);
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
        async DelRecord(strPaperGroupId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsgs_PaperGroupWApi_js_10.gs_PaperGroup_DelRecordAsync)(strPaperGroupId);
                if (returnInt > 0) {
                    //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
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
        async SelectRecord(strPaperGroupId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objgs_PaperGroupEN = await (0, clsgs_PaperGroupWApi_js_11.gs_PaperGroup_GetObjByPaperGroupIdAsync)(strPaperGroupId);
                //console.log("完成SelectRecord!", objgs_PaperGroupEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_gs_PaperGroup");
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
                await this.BindGv_gs_PaperGroup();
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
            const responseBindGv = await this.ExportExcel_gs_PaperGroup_Cache();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async Combinegs_PaperGroupCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperGroupName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, this.paperGroupName_q);
                }
                if (this.updUser_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, this.updUser_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperGroupCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async Combinegs_PaperGroupConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objgs_PaperGroup_Cond = new clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperGroupName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, this.paperGroupName_q);
                    objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, this.paperGroupName_q, "like");
                }
                if (this.updUser_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, this.updUser_q);
                    objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, this.updUser_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_PaperGroupConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objgs_PaperGroup_Cond.whereCond = strWhereCond;
            return objgs_PaperGroup_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async Combinegs_PaperGroupConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objgs_PaperGroup_Cond = new clsgs_PaperGroupENEx_js_1.clsgs_PaperGroupENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperGroupName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, this.paperGroupName_q);
                    objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName, this.paperGroupName_q, "like");
                }
                if (this.updUser_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, this.updUser_q);
                    objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, this.updUser_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_PaperGroupConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objgs_PaperGroup_Cond.whereCond = strWhereCond;
            return objgs_PaperGroup_Cond;
        }
        /** 显示gs_PaperGroup对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrgs_PaperGroupObjLst:需要绑定的对象列表
        **/
        async BindTab_gs_PaperGroup(divContainer, arrgs_PaperGroupObjLst) {
            const strThisFuncName = this.BindTab_gs_PaperGroup.name;
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
                    fldName: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_OrderNum,
                    sortBy: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_OrderNum,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "序号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId,
                    sortBy: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "组Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName,
                    sortBy: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "组名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser,
                    sortBy: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdDate,
                    sortBy: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_Meno,
                    sortBy: clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_Meno,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "备注",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrgs_PaperGroupObjLst, arrDataColumn, clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_PaperGroupId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrgs_PaperGroupExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrgs_PaperGroupExObjLst, arrDataColumn) {
            const arrFldName = clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrgs_PaperGroupExObjLst) {
                    await (0, clsgs_PaperGroupExWApi_js_1.gs_PaperGroupEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_gs_PaperGroup();
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
        async BindGv_gs_PaperGroup() {
            const strThisFuncName = this.BindGv_gs_PaperGroup.name;
            if (gs_PaperGroupCRUD.sortgs_PaperGroupBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinegs_PaperGroupCondition();
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrgs_PaperGroupObjLst = [];
            try {
                this.recCount = await (0, clsgs_PaperGroupWApi_js_1.gs_PaperGroup_GetRecCountByCondAsync)(strWhereCond);
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
                    orderBy: gs_PaperGroupCRUD.sortgs_PaperGroupBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                const responseObjLst = await (0, clsgs_PaperGroupWApi_js_12.gs_PaperGroup_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrgs_PaperGroupObjLst = jsonData;
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
            if (arrgs_PaperGroupObjLst.length == 0) {
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
                await this.BindTab_gs_PaperGroup(strListDiv, arrgs_PaperGroupObjLst);
                //console.log("完成BindGv_gs_PaperGroup!");
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
        async BindGv_gs_PaperGroup_Cache() {
            const strThisFuncName = this.BindGv_gs_PaperGroup_Cache.name;
            if (gs_PaperGroupCRUD.sortgs_PaperGroupBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortgs_PaperGroupBy)为空，请检查！(In BindGv_gs_PaperGroup_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objgs_PaperGroup_Cond = await this.Combinegs_PaperGroupConditionObj();
            objgs_PaperGroup_Cond.SetCondFldValue(clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN.con_UpdUser, gs_PaperGroupCRUD.UpdUser_Cache, "=");
            const strWhereCond = JSON.stringify(objgs_PaperGroup_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrgs_PaperGroupObjLst = [];
            try {
                this.recCount = await (0, clsgs_PaperGroupWApi_js_3.gs_PaperGroup_GetRecCountByCond_Cache)(objgs_PaperGroup_Cond, gs_PaperGroupCRUD.UpdUser_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objgs_PaperGroup_Cond.whereCond);
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
                    orderBy: gs_PaperGroupCRUD.sortgs_PaperGroupBy,
                    sortFun: clsgs_PaperGroupWApi_js_13.gs_PaperGroup_SortFun_Defa
                };
                arrgs_PaperGroupObjLst = await (0, clsgs_PaperGroupWApi_js_14.gs_PaperGroup_GetObjLstByPager_Cache)(objPagerPara, gs_PaperGroupCRUD.UpdUser_Cache);
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
            if (arrgs_PaperGroupObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperGroupEN_js_1.clsgs_PaperGroupEN._CurrTabName, gs_PaperGroupCRUD.UpdUser_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_gs_PaperGroup(strListDiv, arrgs_PaperGroupObjLst);
                //console.log("完成BindGv_gs_PaperGroup_Cache!");
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, gs_PaperGroupCRUD.ascOrDesc4SortFun, gs_PaperGroupCRUD.sortgs_PaperGroupBy, strSortExpress);
            gs_PaperGroupCRUD.sortgs_PaperGroupBy = sortBy;
            gs_PaperGroupCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            gs_PaperGroupCRUD.sortFun_Static = sortFun;
            await this.BindGv_gs_PaperGroup();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrPaperGroupId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrgs_PaperGroupObjLst = await (0, clsgs_PaperGroupWApi_js_15.gs_PaperGroup_GetObjLstByPaperGroupIdLstAsync)(arrPaperGroupId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrgs_PaperGroupObjLst) {
                    const strMaxStrId = await (0, clsgs_PaperGroupWApi_js_16.gs_PaperGroup_GetMaxStrIdAsync)();
                    //console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.paperGroupId = strMaxStrId;
                    const returnBool = await (0, clsgs_PaperGroupWApi_js_17.gs_PaperGroup_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
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
        async DelMultiRecord(arrPaperGroupId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsgs_PaperGroupWApi_js_18.gs_PaperGroup_Delgs_PaperGroupsAsync)(arrPaperGroupId);
                if (returnInt > 0) {
                    //gs_PaperGroup_ReFreshCache(gs_PaperGroupCRUD.UpdUser_Cache);
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
        * @param objgs_PaperGroup:需要显示的对象
        **/
        Showgs_PaperGroupObj(divContainer, objgs_PaperGroup) {
            const strThisFuncName = this.Showgs_PaperGroupObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperGroup);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objgs_PaperGroup.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjgs_PaperGroupEN:表实体类对象
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
        * 组名 (Used In CombineCondition())
        **/
        get paperGroupName_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtPaperGroupName_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 组名 (Used In CombineCondition())
        **/
        set paperGroupName_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtPaperGroupName_q", value);
        }
        /**
        * UpdUser (Used In btnReOrder_Click())
        **/
        static get UpdUser_OrderNum() {
            return $("#txtUpdUser_OrderNum").val();
        }
        /**
        * UpdUser (Used In btnReOrder_Click())
        **/
        static set UpdUser_OrderNum(value) {
            $("#txtUpdUser_OrderNum").val(value);
        }
        /**
        * 修改人 (Used In CombineCondition())
        **/
        get updUser_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtUpdUser_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 修改人 (Used In CombineCondition())
        **/
        set updUser_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtUpdUser_q", value);
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
    exports.gs_PaperGroupCRUD = gs_PaperGroupCRUD;
    gs_PaperGroupCRUD.ascOrDesc4SortFun = "Asc";
    gs_PaperGroupCRUD.sortgs_PaperGroupBy = "";
    gs_PaperGroupCRUD.UpdUser_Cache = ""; //缓存分类字段
});
