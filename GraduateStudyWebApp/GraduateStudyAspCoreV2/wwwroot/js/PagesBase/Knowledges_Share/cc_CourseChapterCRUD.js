(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/PubFun/clsOrderByData.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js", "../../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterENEx.js", "../../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseChapterExWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseChapterExWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseChapterCRUD = void 0;
    /**
    * 类名:cc_CourseChapterCRUD(界面:cc_CourseChapterCRUD)
    * 表名:cc_CourseChapter(01120060)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/14 00:05:36
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:游戏化教育平台(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:知识点相关(Knowledges)
    * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clscc_CourseWApi_js_1 = require("../../TS/L3_ForWApi/CourseLearning_Share/clscc_CourseWApi.js");
    const clscc_CourseChapterWApi_js_1 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_2 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_3 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_4 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsOrderByData_js_1 = require("../../TS/PubFun/clsOrderByData.js");
    const clscc_CourseChapterWApi_js_5 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clscc_CourseChapterWApi_js_6 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsCommFunc4Ctrl_js_2 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clscc_CourseChapterWApi_js_7 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_8 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_9 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_10 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_11 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterEN_js_1 = require("../../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterEN.js");
    const clscc_CourseChapterENEx_js_1 = require("../../TS/L0_Entity/Knowledges_Share/clscc_CourseChapterENEx.js");
    const clscc_CourseChapterExWApi_js_1 = require("../../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseChapterExWApi.js");
    const clscc_CourseChapterWApi_js_12 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_13 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_14 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterExWApi_js_2 = require("../../TS/L3_ForWApiEx/Knowledges_Share/clscc_CourseChapterExWApi.js");
    const clscc_CourseChapterWApi_js_15 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_16 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_17 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clscc_CourseChapterWApi_js_18 = require("../../TS/L3_ForWApi/Knowledges_Share/clscc_CourseChapterWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_3 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** cc_CourseChapterCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class cc_CourseChapterCRUD {
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
            cc_CourseChapterCRUD.objPage_CRUD = this;
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
                await (0, clscc_CourseWApi_js_1.cc_Course_BindDdl_CourseIdInDiv_Cache)(this.divName4Function, "ddlCourseId_OrderNum"); //
                cc_CourseChapterCRUD.sortcc_CourseChapterBy = "courseChapterName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
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
                await (0, clscc_CourseWApi_js_1.cc_Course_BindDdl_CourseIdInDiv_Cache)(this.divName4Function, "ddlCourseId_OrderNum"); //
                this.SetEventFunc();
                cc_CourseChapterCRUD.sortcc_CourseChapterBy = "courseChapterName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
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
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrcc_CourseChapterObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrcc_CourseChapterObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrcc_CourseChapterObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("课程章节({0})导出.xlsx", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
        **/
        async ExportExcel_cc_CourseChapter() {
            const strThisFuncName = this.ExportExcel_cc_CourseChapter.name;
            if (cc_CourseChapterCRUD.sortcc_CourseChapterBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortcc_CourseChapterBy)为空，请检查！(In BindGv_cc_CourseChapter_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinecc_CourseChapterCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrcc_CourseChapterObjLst = [];
            try {
                this.recCount = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_GetRecCountByCondAsync)(strWhereCond);
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
                arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_2.cc_CourseChapter_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrcc_CourseChapterObjLst.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在ExportExcel过程中，根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "courseChapterId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "课程章节ID",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "courseChapterName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "课程章节名称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "chapterName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "章名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 6,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "sectionName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "节名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "chapterName_Sim",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "章名简称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "sectionName_Sim",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "节名简称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "chapterContent",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "章节内容",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isOpenToAllStu",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "全校师生",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isOpenToSchool",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "全校师生公开",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isOpenToSocial",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "社会公众",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 15,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isMustMenu",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否必建栏目",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "themeName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "主题名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 17,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isFile",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "项目或文件夹",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 18,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isUse",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否使用",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 19,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "viewCount",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "浏览量",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 20,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "courseChapterReferred",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "节简称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 21,
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
                        orderNum: 22,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "createDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "建立日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 23,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "editPeople",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "修改人",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 24,
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
                        orderNum: 25,
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
                        orderNum: 26,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrcc_CourseChapterObjLst = arrcc_CourseChapterObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrcc_CourseChapterObjLst, arrDataColumn);
                //console.log("完成BindGv_cc_CourseChapter!");
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
        async ExportExcel_cc_CourseChapter_Cache() {
            const strThisFuncName = this.ExportExcel_cc_CourseChapter_Cache.name;
            if (cc_CourseChapterCRUD.sortcc_CourseChapterBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortcc_CourseChapterBy)为空，请检查！(In BindGv_cc_CourseChapter_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objcc_CourseChapter_Cond = await this.Combinecc_CourseChapterConditionObj4ExportExcel();
            objcc_CourseChapter_Cond.SetCondFldValue(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseId, cc_CourseChapterCRUD.CourseId_Cache, "=");
            const strWhereCond = JSON.stringify(objcc_CourseChapter_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrcc_CourseChapterObjLst = [];
            try {
                this.recCount = await (0, clscc_CourseChapterWApi_js_3.cc_CourseChapter_GetRecCountByCond_Cache)(objcc_CourseChapter_Cond, cc_CourseChapterCRUD.CourseId_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objcc_CourseChapter_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objcc_CourseChapter_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_4.cc_CourseChapter_GetSubObjLst_Cache)(objcc_CourseChapter_Cond, cc_CourseChapterCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrcc_CourseChapterObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, cc_CourseChapterCRUD.CourseId_Cache);
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
                        fldName: "courseChapterId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "课程章节ID",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "courseChapterName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "课程章节名称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "chapterName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "章名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 6,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "sectionName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "节名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "chapterName_Sim",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "章名简称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "sectionName_Sim",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "节名简称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "chapterContent",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "章节内容",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isOpenToAllStu",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "全校师生",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isOpenToSchool",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "全校师生公开",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isOpenToSocial",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "社会公众",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 15,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isMustMenu",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否必建栏目",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "themeName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "主题名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 17,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isFile",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "项目或文件夹",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 18,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isUse",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否使用",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 19,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "viewCount",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "浏览量",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 20,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "courseChapterReferred",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "节简称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 21,
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
                        orderNum: 22,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "createDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "建立日期",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 23,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "editPeople",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "修改人",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 24,
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
                        orderNum: 25,
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
                        orderNum: 26,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrcc_CourseChapterObjLst = arrcc_CourseChapterObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrcc_CourseChapterObjLst, arrDataColumn);
                //console.log("完成BindGv_cc_CourseChapter!");
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
            const strCourseId = this.CourseId_OrderNum;
            const strOrderNum = this.CourseId_OrderNum;
            const intOrderNum = Number(strOrderNum);
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                const jsonObject = {
                    "courseid": strCourseId,
                    "ordernum": intOrderNum,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseChapterWApi_js_5.cc_CourseChapter_ReOrderAsync)(objOrderByData);
                //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("重序出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
        }
        /**
        * 置底
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoBottum_Click)
        **/
        async btnGoBottum_Click() {
            const strThisFuncName = this.btnGoBottum_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strCourseId = this.CourseId_OrderNum;
            const strOrderNum = this.CourseId_OrderNum;
            const intOrderNum = Number(strOrderNum);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert("请选择需要置底的记录！");
                return "";
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "courseid": strCourseId,
                    "ordernum": intOrderNum,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseChapterWApi_js_6.cc_CourseChapter_GoBottomAsync)(objOrderByData);
                //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("置底出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_2.SetCheckedItem4KeyId)(strListDiv, e));
        }
        /**
        * 移动记录序号时的预检查函数
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_PreCheck4Order)
        **/
        PreCheck4Order() {
            const strThisFuncName = this.PreCheck4Order.name;
            const strCourseId = this.CourseId_OrderNum;
            if (strCourseId == "") {
                const strMsg = (0, clsString_js_1.Format)("请输入CourseId!");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return false;
            }
            const strOrderNum = this.CourseId_OrderNum;
            if (strOrderNum == "") {
                const strMsg = (0, clsString_js_1.Format)("请输入OrderNum!");
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
            const strCourseId = this.CourseId_OrderNum;
            const strOrderNum = this.CourseId_OrderNum;
            const intOrderNum = Number(strOrderNum);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert(`请选择需要下移的记录!`);
                return;
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "courseid": strCourseId,
                    "ordernum": intOrderNum,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseChapterWApi_js_7.cc_CourseChapter_DownMoveAsync)(objOrderByData);
                //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("下移记录出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_2.SetCheckedItem4KeyId)(strListDiv, e));
        }
        /**
        * 上移
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnUpMove_Click)
        **/
        async btnUpMove_Click() {
            const strThisFuncName = this.btnUpMove_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strCourseId = this.CourseId_OrderNum;
            const strOrderNum = this.CourseId_OrderNum;
            const intOrderNum = Number(strOrderNum);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert(`请选择需要上移的记录!`);
                return;
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "courseid": strCourseId,
                    "ordernum": intOrderNum,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseChapterWApi_js_8.cc_CourseChapter_UpMoveAsync)(objOrderByData);
                //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("上移记录出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_2.SetCheckedItem4KeyId)(strListDiv, e));
        }
        /** 置顶
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_btnGoTop_Click)
        **/
        async btnGoTop_Click() {
            const strThisFuncName = this.btnGoTop_Click.name;
            if (this.PreCheck4Order() == false)
                return;
            const strCourseId = this.CourseId_OrderNum;
            const strOrderNum = this.CourseId_OrderNum;
            const intOrderNum = Number(strOrderNum);
            const arrKeyIds = (0, clsCommFunc4Ctrl_js_1.GetCheckedKeyIdsInDiv)(this.divName4List);
            if (arrKeyIds.length == 0) {
                alert("请选择需要置顶的记录！");
                return "";
            }
            try {
                const objOrderByData = new clsOrderByData_js_1.clsOrderByData();
                objOrderByData.KeyIdLst = arrKeyIds;
                const jsonObject = {
                    "courseid": strCourseId,
                    "ordernum": intOrderNum,
                };
                const jsonStr = JSON.stringify(jsonObject);
                objOrderByData.ClassificationFieldValueLst = jsonStr;
                const responseRederBy = await (0, clscc_CourseChapterWApi_js_9.cc_CourseChapter_GoTopAsync)(objOrderByData);
                //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("置顶出错。错误:{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
            const strListDiv = this.divName4DataList;
            arrKeyIds.forEach((e) => (0, clsCommFunc4Ctrl_js_2.SetCheckedItem4KeyId)(strListDiv, e));
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
                await this.BindGv_cc_CourseChapter4Func();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "strCourseChapterId": 表关键字
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
                await this.BindGv_cc_CourseChapter4Func();
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
        async btnSelectRecordInTab_Click(strCourseChapterId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(strCourseChapterId) == true) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(strCourseChapterId);
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
        async DelRecord(strCourseChapterId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clscc_CourseChapterWApi_js_10.cc_CourseChapter_DelRecordAsync)(strCourseChapterId);
                if (returnInt > 0) {
                    //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
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
        async SelectRecord(strCourseChapterId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objcc_CourseChapterEN = await (0, clscc_CourseChapterWApi_js_11.cc_CourseChapter_GetObjByCourseChapterIdAsync)(strCourseChapterId);
                //console.log("完成SelectRecord!", objcc_CourseChapterEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_cc_CourseChapter");
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
                await this.BindGv_cc_CourseChapter4Func();
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
            const responseBindGv = await this.ExportExcel_cc_CourseChapter_Cache();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async Combinecc_CourseChapterCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.courseChapterName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, this.courseChapterName_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(Combinecc_CourseChapterCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async Combinecc_CourseChapterConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objcc_CourseChapter_Cond = new clscc_CourseChapterEN_js_1.clscc_CourseChapterEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.courseChapterName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, this.courseChapterName_q);
                    objcc_CourseChapter_Cond.SetCondFldValue(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, this.courseChapterName_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(Combinecc_CourseChapterConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objcc_CourseChapter_Cond.whereCond = strWhereCond;
            return objcc_CourseChapter_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async Combinecc_CourseChapterConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objcc_CourseChapter_Cond = new clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.courseChapterName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, this.courseChapterName_q);
                    objcc_CourseChapter_Cond.SetCondFldValue(clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName, this.courseChapterName_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinecc_CourseChapterConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objcc_CourseChapter_Cond.whereCond = strWhereCond;
            return objcc_CourseChapter_Cond;
        }
        /** 显示cc_CourseChapter对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrcc_CourseChapterObjLst:需要绑定的对象列表
        **/
        async BindTab_cc_CourseChapter(divContainer, arrcc_CourseChapterObjLst) {
            const strThisFuncName = this.BindTab_cc_CourseChapter.name;
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
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "课程章节名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "章名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_CourseName,
                    sortBy: "courseName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "课程名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "节名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "章名简称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "节名简称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "节简称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrcc_CourseChapterObjLst, arrDataColumn, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 显示cc_CourseChapter对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
        * @param divContainer:显示容器
        * @param arrcc_CourseChapterExObjLst:需要绑定的对象列表
        **/
        async BindTab_cc_CourseChapter4Func(divContainer, arrcc_CourseChapterExObjLst) {
            const strThisFuncName = this.BindTab_cc_CourseChapter4Func.name;
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
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "课程章节名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "章名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterENEx_js_1.clscc_CourseChapterENEx.con_CourseName,
                    sortBy: "courseName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "课程名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "节名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_ChapterName_Sim,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "章名简称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_SectionName_Sim,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "节名简称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterReferred,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "节简称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_EditPeople,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate,
                    sortBy: clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            try {
                await this.ExtendFldFuncMap(arrcc_CourseChapterExObjLst, arrDataColumn);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("扩展字段值的映射出错,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrcc_CourseChapterExObjLst, arrDataColumn, clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.con_CourseChapterId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrcc_CourseChapterExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrcc_CourseChapterExObjLst, arrDataColumn) {
            const arrFldName = clscc_CourseChapterEN_js_1.clscc_CourseChapterEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrcc_CourseChapterExObjLst) {
                    await (0, clscc_CourseChapterExWApi_js_1.cc_CourseChapterEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_cc_CourseChapter4Func();
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
        async BindGv_cc_CourseChapter() {
            const strThisFuncName = this.BindGv_cc_CourseChapter.name;
            if (cc_CourseChapterCRUD.sortcc_CourseChapterBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortcc_CourseChapterBy)为空，请检查！(In BindGv_cc_CourseChapter)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinecc_CourseChapterCondition();
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrcc_CourseChapterObjLst = [];
            try {
                this.recCount = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_GetRecCountByCondAsync)(strWhereCond);
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
                    orderBy: cc_CourseChapterCRUD.sortcc_CourseChapterBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_12.cc_CourseChapter_GetObjLstByPagerAsync)(objPagerPara);
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
            if (arrcc_CourseChapterObjLst.length == 0) {
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
                await this.BindTab_cc_CourseChapter(strListDiv, arrcc_CourseChapterObjLst);
                //console.log("完成BindGv_cc_CourseChapter!");
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
        async BindGv_cc_CourseChapter_Cache() {
            const strThisFuncName = this.BindGv_cc_CourseChapter_Cache.name;
            if (cc_CourseChapterCRUD.sortcc_CourseChapterBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortcc_CourseChapterBy)为空，请检查！(In BindGv_cc_CourseChapter_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objcc_CourseChapter_Cond = await this.Combinecc_CourseChapterConditionObj();
            const strWhereCond = JSON.stringify(objcc_CourseChapter_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrcc_CourseChapterObjLst = [];
            try {
                this.recCount = await (0, clscc_CourseChapterWApi_js_3.cc_CourseChapter_GetRecCountByCond_Cache)(objcc_CourseChapter_Cond, cc_CourseChapterCRUD.CourseId_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objcc_CourseChapter_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objcc_CourseChapter_Cond.whereCond);
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
                    orderBy: cc_CourseChapterCRUD.sortcc_CourseChapterBy,
                    sortFun: clscc_CourseChapterWApi_js_13.cc_CourseChapter_SortFun_Defa
                };
                arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_14.cc_CourseChapter_GetObjLstByPager_Cache)(objPagerPara, cc_CourseChapterCRUD.CourseId_Cache);
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
            if (arrcc_CourseChapterObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, cc_CourseChapterCRUD.CourseId_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_cc_CourseChapter(strListDiv, arrcc_CourseChapterObjLst);
                //console.log("完成BindGv_cc_CourseChapter_Cache!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func_NoCache)
        **/
        async BindGv_cc_CourseChapter4Func() {
            const strThisFuncName = this.BindGv_cc_CourseChapter4Func.name;
            if (cc_CourseChapterCRUD.sortcc_CourseChapterBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortcc_CourseChapterBy)为空，请检查！(In BindGv_cc_CourseChapter_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinecc_CourseChapterCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrcc_CourseChapterExObjLst = [];
            try {
                this.recCount = await (0, clscc_CourseChapterWApi_js_1.cc_CourseChapter_GetRecCountByCondAsync)(strWhereCond);
                const objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: cc_CourseChapterCRUD.sortcc_CourseChapterBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                arrcc_CourseChapterExObjLst = await (0, clscc_CourseChapterExWApi_js_2.cc_CourseChapterEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrcc_CourseChapterExObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clscc_CourseChapterEN_js_1.clscc_CourseChapterEN._CurrTabName, cc_CourseChapterCRUD.CourseId_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_cc_CourseChapter4Func(strListDiv, arrcc_CourseChapterExObjLst);
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
            if (a.memo == b.memo)
                return a.memo.localeCompare(b.memo);
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, cc_CourseChapterCRUD.ascOrDesc4SortFun, cc_CourseChapterCRUD.sortcc_CourseChapterBy, strSortExpress);
            cc_CourseChapterCRUD.sortcc_CourseChapterBy = sortBy;
            cc_CourseChapterCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            cc_CourseChapterCRUD.sortFun_Static = sortFun;
            await this.BindGv_cc_CourseChapter4Func();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrCourseChapterId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrcc_CourseChapterObjLst = await (0, clscc_CourseChapterWApi_js_15.cc_CourseChapter_GetObjLstByCourseChapterIdLstAsync)(arrCourseChapterId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrcc_CourseChapterObjLst) {
                    const strMaxStrId = await (0, clscc_CourseChapterWApi_js_16.cc_CourseChapter_GetMaxStrIdAsync)();
                    //console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.courseChapterId = strMaxStrId;
                    const returnBool = await (0, clscc_CourseChapterWApi_js_17.cc_CourseChapter_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
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
        async DelMultiRecord(arrCourseChapterId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clscc_CourseChapterWApi_js_18.cc_CourseChapter_Delcc_CourseChaptersAsync)(arrCourseChapterId);
                if (returnInt > 0) {
                    //cc_CourseChapter_ReFreshCache(cc_CourseChapterCRUD.CourseId_Cache);
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
        * @param objcc_CourseChapter:需要显示的对象
        **/
        Showcc_CourseChapterObj(divContainer, objcc_CourseChapter) {
            const strThisFuncName = this.Showcc_CourseChapterObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseChapter);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objcc_CourseChapter.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjcc_CourseChapterEN:表实体类对象
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
        * 课程章节名称 (Used In CombineCondition())
        **/
        get courseChapterName_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetInputValueInDiv)(this.divName4Query, "txtCourseChapterName_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 课程章节名称 (Used In CombineCondition())
        **/
        set courseChapterName_q(value) {
            (0, clsCommFunc4Ctrl_js_3.SetInputValueByIdInDiv)(this.divName4Query, "txtCourseChapterName_q", value);
        }
        /**
        * CourseId (Used In btnReOrder_Click())
        **/
        get CourseId_OrderNum() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetSelectValueInDiv)(this.divName4Function, "ddlCourseId_OrderNum");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * CourseId (Used In btnReOrder_Click())
        **/
        set CourseId_OrderNum(value) {
            (0, clsCommFunc4Ctrl_js_3.SetSelectValueByIdInDiv)(this.divName4Function, "ddlCourseId_OrderNum", value);
        }
        /**
        * 设置界面标题-相当使用ViewState功能
        **/
        set ViewTitle(value) {
            (0, clsCommFunc4Ctrl_js_3.SetLabelHtmlByIdInDiv)(this.divName4Layout, "lblViewTitle", value);
        }
        /**
        * 设置界面标题
        **/
        get ViewTitle() {
            const strValue = (0, clsCommFunc4Ctrl_js_3.GetLabelHtmlInDiv)(this.divName4Layout, "lblViewTitle");
            return strValue;
        }
    }
    exports.cc_CourseChapterCRUD = cc_CourseChapterCRUD;
    cc_CourseChapterCRUD.ascOrDesc4SortFun = "Asc";
    cc_CourseChapterCRUD.sortcc_CourseChapterBy = "";
    cc_CourseChapterCRUD.CourseId_Cache = ""; //缓存分类字段
    cc_CourseChapterCRUD.CourseId_Static = "99999999"; //功能区下拉框条件变量1
});
