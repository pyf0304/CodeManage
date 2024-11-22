(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsENEx.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsAcademicJournalsExWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsAcademicJournalsExWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsAcademicJournalsExWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.AcademicJournalsCRUD = void 0;
    /**
    * 类名:AcademicJournalsCRUD(界面:AcademicJournalsCRUD)
    * 表名:AcademicJournals(01120929)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:39:19
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
    const clsAcademicJournalsENEx_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsENEx.js");
    const clsAcademicJournalsWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsAcademicJournalsExWApi.js");
    const clsJournalSubjectCategoryWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectCategoryWApi.js");
    const clsJournalSubjectWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsJournalSubjectWApi.js");
    const clsAcademicJournalsWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsEN_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsAcademicJournalsEN.js");
    const clsAcademicJournalsExWApi_js_2 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsAcademicJournalsExWApi.js");
    const clsAcademicJournalsWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsExWApi_js_3 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsAcademicJournalsExWApi.js");
    const clsAcademicJournalsWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_9 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_10 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsAcademicJournalsWApi_js_11 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsAcademicJournalsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** AcademicJournalsCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class AcademicJournalsCRUD {
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
            AcademicJournalsCRUD.objPage_CRUD = this;
            this.objPager = new clsPager_js_1.clsPager(this);
        }
        /**
        * 每页记录数，在扩展类可以修改
        **/
        get pageSize() {
            return 5;
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
                AcademicJournalsCRUD.sortAcademicJournalsBy = "journalId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_AcademicJournals4Func();
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
            const responseBindGv = await this.BindGv_AcademicJournals4Func();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrAcademicJournalsObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrAcademicJournalsObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrAcademicJournalsObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("学术期刊({0})导出.xlsx", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData4Func)
        **/
        CombineData4Func(arrAcademicJournalsExObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData4Func.name;
            const intRowNum = arrAcademicJournalsExObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j]);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrAcademicJournalsExObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("学术期刊({0})导出.xlsx", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel4Func)
        **/
        async ExportExcel_AcademicJournals4Func() {
            const strThisFuncName = this.ExportExcel_AcademicJournals4Func.name;
            if (AcademicJournalsCRUD.sortAcademicJournalsBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortAcademicJournalsBy)为空，请检查！(In BindGv_AcademicJournals_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objAcademicJournals_Cond = await this.CombineAcademicJournalsConditionObj4ExportExcel();
            let arrAcademicJournalsObjLst = [];
            let arrAcademicJournalsExObjLst = [];
            try {
                this.recCount = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetRecCountByCond_Cache)(objAcademicJournals_Cond);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objAcademicJournals_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objAcademicJournals_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_2.AcademicJournals_GetSubObjLst_Cache)(objAcademicJournals_Cond);
                arrAcademicJournalsExObjLst = arrAcademicJournalsObjLst.map(clsAcademicJournalsExWApi_js_1.AcademicJournalsEx_CopyToEx);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("导出Excel时获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrAcademicJournalsObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
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
                        fldName: "journalSubjectCategoryId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学科门类",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "journalSubjectId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学科代码",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "journalSubjectId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学科",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "journalId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "期刊Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "journalName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "期刊名称",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 6,
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
                        orderNum: 7,
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
                        orderNum: 8,
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
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                try {
                    await this.ExtendFldFuncMap(arrAcademicJournalsExObjLst, arrDataColumn);
                }
                catch (e) {
                    const strMsg = (0, clsString_js_1.Format)("扩展字段值的映射出错,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                arrAcademicJournalsObjLst = arrAcademicJournalsObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrAcademicJournalsObjLst, arrDataColumn);
                //console.log("完成BindGv_AcademicJournals!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[JournalSubjectCategoryId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_JournalSubjectCategoryIdInDiv() {
            await (0, clsJournalSubjectCategoryWApi_js_1.JournalSubjectCategory_BindDdl_JournalSubjectCategoryIdInDiv_Cache)(this.divName4Query, "ddlJournalSubjectCategoryId_q"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[JournalSubjectId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_JournalSubjectIdInDiv() {
            await (0, clsJournalSubjectWApi_js_1.JournalSubject_BindDdl_JournalSubjectIdInDiv_Cache)(this.divName4Query, "ddlJournalSubjectId_q"); //
        }
        /** 函数功能:为查询区绑定下拉框
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
        **/
        async BindDdl4QueryRegion() {
            const strThisFuncName = this.BindDdl4QueryRegion.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_JournalSubjectCategoryIdInDiv(); //查询区域
            await this.SetDdl_JournalSubjectIdInDiv(); //查询区域
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
                await this.BindGv_AcademicJournals4Func();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "strJournalId": 表关键字
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
                await this.BindGv_AcademicJournals4Func();
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
        async btnSelectRecordInTab_Click(strJournalId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(strJournalId) == true) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(strJournalId);
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
        async DelRecord(strJournalId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsAcademicJournalsWApi_js_3.AcademicJournals_DelRecordAsync)(strJournalId);
                if (returnInt > 0) {
                    (0, clsAcademicJournalsWApi_js_4.AcademicJournals_ReFreshCache)();
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
        async SelectRecord(strJournalId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objAcademicJournalsEN = await (0, clsAcademicJournalsWApi_js_5.AcademicJournals_GetObjByJournalIdAsync)(strJournalId);
                //console.log("完成SelectRecord!", objAcademicJournalsEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_AcademicJournals");
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
                await this.BindGv_AcademicJournals4Func();
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
            const responseBindGv = await this.ExportExcel_AcademicJournals4Func();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async CombineAcademicJournalsCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.journalId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.journalId_q);
                }
                if (this.journalName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.journalName_q);
                }
                if (this.journalSubjectCategoryId_q != "" && this.journalSubjectCategoryId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.journalSubjectCategoryId_q);
                }
                if (this.journalSubjectId_q != "" && this.journalSubjectId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.journalSubjectId_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(CombineAcademicJournalsCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async CombineAcademicJournalsConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objAcademicJournals_Cond = new clsAcademicJournalsEN_js_1.clsAcademicJournalsEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.journalId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.journalId_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.journalId_q, "like");
                }
                if (this.journalName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.journalName_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.journalName_q, "like");
                }
                if (this.journalSubjectCategoryId_q != "" && this.journalSubjectCategoryId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.journalSubjectCategoryId_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.journalSubjectCategoryId_q, "=");
                }
                if (this.journalSubjectId_q != "" && this.journalSubjectId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.journalSubjectId_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.journalSubjectId_q, "=");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(CombineAcademicJournalsConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objAcademicJournals_Cond.whereCond = strWhereCond;
            return objAcademicJournals_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async CombineAcademicJournalsConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objAcademicJournals_Cond = new clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.journalId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.journalId_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this.journalId_q, "like");
                }
                if (this.journalName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.journalName_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName, this.journalName_q, "like");
                }
                if (this.journalSubjectCategoryId_q != "" && this.journalSubjectCategoryId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.journalSubjectCategoryId_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectCategoryId, this.journalSubjectCategoryId_q, "=");
                }
                if (this.journalSubjectId_q != "" && this.journalSubjectId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.journalSubjectId_q);
                    objAcademicJournals_Cond.SetCondFldValue(clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalSubjectId, this.journalSubjectId_q, "=");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineAcademicJournalsConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objAcademicJournals_Cond.whereCond = strWhereCond;
            return objAcademicJournals_Cond;
        }
        /** 显示AcademicJournals对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrAcademicJournalsObjLst:需要绑定的对象列表
        **/
        async BindTab_AcademicJournals(divContainer, arrAcademicJournalsObjLst) {
            const strThisFuncName = this.BindTab_AcademicJournals.name;
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
                    fldName: clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCategoryName,
                    sortBy: "journalSubjectCategoryName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学科门类",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCode,
                    sortBy: "journalSubjectCode",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学科代码",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectName,
                    sortBy: "journalSubjectName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学科",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "期刊Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "期刊名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdDate,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdUser,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_Memo,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_Memo,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "备注",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrAcademicJournalsObjLst, arrDataColumn, clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 显示AcademicJournals对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
        * @param divContainer:显示容器
        * @param arrAcademicJournalsExObjLst:需要绑定的对象列表
        **/
        async BindTab_AcademicJournals4Func(divContainer, arrAcademicJournalsExObjLst) {
            const strThisFuncName = this.BindTab_AcademicJournals4Func.name;
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
                    fldName: clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCategoryName,
                    sortBy: "journalSubjectCategoryName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学科门类",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectCode,
                    sortBy: "journalSubjectCode",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学科代码",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsENEx_js_1.clsAcademicJournalsENEx.con_JournalSubjectName,
                    sortBy: "journalSubjectName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学科",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "期刊Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "期刊名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdDate,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdUser,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_Memo,
                    sortBy: clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_Memo,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "备注",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            try {
                await this.ExtendFldFuncMap(arrAcademicJournalsExObjLst, arrDataColumn);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("扩展字段值的映射出错,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrAcademicJournalsExObjLst, arrDataColumn, clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.con_JournalId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrAcademicJournalsExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrAcademicJournalsExObjLst, arrDataColumn) {
            const arrFldName = clsAcademicJournalsEN_js_1.clsAcademicJournalsEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrAcademicJournalsExObjLst) {
                    await (0, clsAcademicJournalsExWApi_js_2.AcademicJournalsEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_AcademicJournals4Func();
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
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv_Cache)
        **/
        async BindGv_AcademicJournals_Cache() {
            const strThisFuncName = this.BindGv_AcademicJournals_Cache.name;
            if (AcademicJournalsCRUD.sortAcademicJournalsBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortAcademicJournalsBy)为空，请检查！(In BindGv_AcademicJournals_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objAcademicJournals_Cond = await this.CombineAcademicJournalsConditionObj();
            const strWhereCond = JSON.stringify(objAcademicJournals_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrAcademicJournalsObjLst = [];
            try {
                this.recCount = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetRecCountByCond_Cache)(objAcademicJournals_Cond);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objAcademicJournals_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objAcademicJournals_Cond.whereCond);
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
                    orderBy: AcademicJournalsCRUD.sortAcademicJournalsBy,
                    sortFun: clsAcademicJournalsWApi_js_6.AcademicJournals_SortFun_Defa
                };
                arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_7.AcademicJournals_GetObjLstByPager_Cache)(objPagerPara);
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
            if (arrAcademicJournalsObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_AcademicJournals(strListDiv, arrAcademicJournalsObjLst);
                //console.log("完成BindGv_AcademicJournals_Cache!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindGv4Func)
        **/
        async BindGv_AcademicJournals4Func() {
            const strThisFuncName = this.BindGv_AcademicJournals4Func.name;
            if (AcademicJournalsCRUD.sortAcademicJournalsBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortAcademicJournalsBy)为空，请检查！(In BindGv_AcademicJournals_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objAcademicJournals_Cond = await this.CombineAcademicJournalsConditionObj();
            const strWhereCond = JSON.stringify(objAcademicJournals_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrAcademicJournalsExObjLst = [];
            try {
                this.recCount = await (0, clsAcademicJournalsWApi_js_1.AcademicJournals_GetRecCountByCond_Cache)(objAcademicJournals_Cond);
                let strSortFun = (x, y) => { return 0; };
                if (AcademicJournalsCRUD.sortFun_Static != undefined) {
                    strSortFun = AcademicJournalsCRUD.sortFun_Static(AcademicJournalsCRUD.ascOrDesc4SortFun);
                }
                const objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: AcademicJournalsCRUD.sortAcademicJournalsBy,
                    sortFun: strSortFun
                };
                arrAcademicJournalsExObjLst = await (0, clsAcademicJournalsExWApi_js_3.AcademicJournalsEx_GetObjExLstByPager_Cache)(objPagerPara);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrAcademicJournalsExObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}", clsAcademicJournalsEN_js_1.clsAcademicJournalsEN._CurrTabName);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_AcademicJournals4Func(strListDiv, arrAcademicJournalsExObjLst);
                //console.log("完成BindGv_AcademicJournals4Func!");
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, AcademicJournalsCRUD.ascOrDesc4SortFun, AcademicJournalsCRUD.sortAcademicJournalsBy, strSortExpress);
            AcademicJournalsCRUD.sortAcademicJournalsBy = sortBy;
            AcademicJournalsCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            AcademicJournalsCRUD.sortFun_Static = sortFun;
            await this.BindGv_AcademicJournals4Func();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrJournalId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrAcademicJournalsObjLst = await (0, clsAcademicJournalsWApi_js_8.AcademicJournals_GetObjLstByJournalIdLstAsync)(arrJournalId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrAcademicJournalsObjLst) {
                    const strMaxStrId = await (0, clsAcademicJournalsWApi_js_9.AcademicJournals_GetMaxStrIdAsync)();
                    //console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.journalId = strMaxStrId;
                    const returnBool = await (0, clsAcademicJournalsWApi_js_10.AcademicJournals_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        (0, clsAcademicJournalsWApi_js_4.AcademicJournals_ReFreshCache)();
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
        async DelMultiRecord(arrJournalId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsAcademicJournalsWApi_js_11.AcademicJournals_DelAcademicJournalssAsync)(arrJournalId);
                if (returnInt > 0) {
                    (0, clsAcademicJournalsWApi_js_4.AcademicJournals_ReFreshCache)();
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
        * @param objAcademicJournals:需要显示的对象
        **/
        ShowAcademicJournalsObj(divContainer, objAcademicJournals) {
            const strThisFuncName = this.ShowAcademicJournalsObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objAcademicJournals);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objAcademicJournals.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjAcademicJournalsEN:表实体类对象
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
        * 期刊Id (Used In CombineCondition())
        **/
        get journalId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtJournalId_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 期刊Id (Used In CombineCondition())
        **/
        set journalId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtJournalId_q", value);
        }
        /**
        * 期刊名称 (Used In CombineCondition())
        **/
        get journalName_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtJournalName_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 期刊名称 (Used In CombineCondition())
        **/
        set journalName_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtJournalName_q", value);
        }
        /**
        * 期刊学科门类Id (Used In CombineCondition())
        **/
        get journalSubjectCategoryId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlJournalSubjectCategoryId_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 期刊学科门类Id (Used In CombineCondition())
        **/
        set journalSubjectCategoryId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Query, "ddlJournalSubjectCategoryId_q", value);
        }
        /**
        * 期刊学科Id (Used In CombineCondition())
        **/
        get journalSubjectId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlJournalSubjectId_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 期刊学科Id (Used In CombineCondition())
        **/
        set journalSubjectId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Query, "ddlJournalSubjectId_q", value);
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
    exports.AcademicJournalsCRUD = AcademicJournalsCRUD;
    AcademicJournalsCRUD.ascOrDesc4SortFun = "Asc";
    AcademicJournalsCRUD.sortAcademicJournalsBy = "";
});
