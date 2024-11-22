(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js", "../../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeENEx.js", "../../TS/L3_ForWApiEx/Knowledges_Share/clsKnowledgeTypeExWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApiEx/Knowledges_Share/clsKnowledgeTypeExWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.KnowledgeTypeCRUD = void 0;
    /**
    * 类名:KnowledgeTypeCRUD(界面:KnowledgeTypeCRUD)
    * 表名:KnowledgeType(01120890)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:29:51
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:知识点相关(Knowledges)
    * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsKnowledgeTypeWApi_js_1 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_2 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_3 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_4 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsKnowledgeTypeWApi_js_5 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_6 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeEN_js_1 = require("../../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js");
    const clsKnowledgeTypeENEx_js_1 = require("../../TS/L0_Entity/Knowledges_Share/clsKnowledgeTypeENEx.js");
    const clsKnowledgeTypeExWApi_js_1 = require("../../TS/L3_ForWApiEx/Knowledges_Share/clsKnowledgeTypeExWApi.js");
    const clsKnowledgeTypeWApi_js_7 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_8 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_9 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeExWApi_js_2 = require("../../TS/L3_ForWApiEx/Knowledges_Share/clsKnowledgeTypeExWApi.js");
    const clsKnowledgeTypeWApi_js_10 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_11 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_12 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsKnowledgeTypeWApi_js_13 = require("../../TS/L3_ForWApi/Knowledges_Share/clsKnowledgeTypeWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_2 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** KnowledgeTypeCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class KnowledgeTypeCRUD {
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
            KnowledgeTypeCRUD.objPage_CRUD = this;
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
                KnowledgeTypeCRUD.sortKnowledgeTypeBy = "knowledgeTypeName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_KnowledgeType4Func();
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
                KnowledgeTypeCRUD.sortKnowledgeTypeBy = "knowledgeTypeName Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_KnowledgeType4Func();
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
            const responseBindGv = await this.BindGv_KnowledgeType4Func();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrKnowledgeTypeObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrKnowledgeTypeObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrKnowledgeTypeObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("知识点类型({0})导出.xlsx", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
        **/
        async ExportExcel_KnowledgeType() {
            const strThisFuncName = this.ExportExcel_KnowledgeType.name;
            if (KnowledgeTypeCRUD.sortKnowledgeTypeBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortKnowledgeTypeBy)为空，请检查！(In BindGv_KnowledgeType_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.CombineKnowledgeTypeCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrKnowledgeTypeObjLst = [];
            try {
                this.recCount = await (0, clsKnowledgeTypeWApi_js_1.KnowledgeType_GetRecCountByCondAsync)(strWhereCond);
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
                arrKnowledgeTypeObjLst = await (0, clsKnowledgeTypeWApi_js_2.KnowledgeType_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrKnowledgeTypeObjLst.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在ExportExcel过程中，根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "knowledgeTypeId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "知识点类型Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "knowledgeTypeName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "知识点类型名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
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
                        orderNum: 5,
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
                        orderNum: 6,
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
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrKnowledgeTypeObjLst = arrKnowledgeTypeObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrKnowledgeTypeObjLst, arrDataColumn);
                //console.log("完成BindGv_KnowledgeType!");
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
        async ExportExcel_KnowledgeType_Cache() {
            const strThisFuncName = this.ExportExcel_KnowledgeType_Cache.name;
            if (KnowledgeTypeCRUD.sortKnowledgeTypeBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortKnowledgeTypeBy)为空，请检查！(In BindGv_KnowledgeType_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objKnowledgeType_Cond = await this.CombineKnowledgeTypeConditionObj4ExportExcel();
            objKnowledgeType_Cond.SetCondFldValue(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId, KnowledgeTypeCRUD.CourseId_Cache, "=");
            const strWhereCond = JSON.stringify(objKnowledgeType_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrKnowledgeTypeObjLst = [];
            try {
                this.recCount = await (0, clsKnowledgeTypeWApi_js_3.KnowledgeType_GetRecCountByCond_Cache)(objKnowledgeType_Cond, KnowledgeTypeCRUD.CourseId_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objKnowledgeType_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objKnowledgeType_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrKnowledgeTypeObjLst = await (0, clsKnowledgeTypeWApi_js_4.KnowledgeType_GetSubObjLst_Cache)(objKnowledgeType_Cond, KnowledgeTypeCRUD.CourseId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrKnowledgeTypeObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, KnowledgeTypeCRUD.CourseId_Cache);
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
                        fldName: "knowledgeTypeId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "知识点类型Id",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "knowledgeTypeName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "知识点类型名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
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
                        orderNum: 5,
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
                        orderNum: 6,
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
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrKnowledgeTypeObjLst = arrKnowledgeTypeObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrKnowledgeTypeObjLst, arrDataColumn);
                //console.log("完成BindGv_KnowledgeType!");
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
                await this.BindGv_KnowledgeType4Func();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "strKnowledgeTypeId": 表关键字
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
                await this.BindGv_KnowledgeType4Func();
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
        async btnSelectRecordInTab_Click(strKnowledgeTypeId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(strKnowledgeTypeId) == true) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(strKnowledgeTypeId);
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
        async DelRecord(strKnowledgeTypeId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsKnowledgeTypeWApi_js_5.KnowledgeType_DelRecordAsync)(strKnowledgeTypeId);
                if (returnInt > 0) {
                    //KnowledgeType_ReFreshCache(KnowledgeTypeCRUD.CourseId_Cache);
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
        async SelectRecord(strKnowledgeTypeId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objKnowledgeTypeEN = await (0, clsKnowledgeTypeWApi_js_6.KnowledgeType_GetObjByKnowledgeTypeIdAsync)(strKnowledgeTypeId);
                //console.log("完成SelectRecord!", objKnowledgeTypeEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_KnowledgeType");
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
                await this.BindGv_KnowledgeType4Func();
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
            const responseBindGv = await this.ExportExcel_KnowledgeType_Cache();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async CombineKnowledgeTypeCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.knowledgeTypeName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, this.knowledgeTypeName_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(CombineKnowledgeTypeCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async CombineKnowledgeTypeConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objKnowledgeType_Cond = new clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.knowledgeTypeName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, this.knowledgeTypeName_q);
                    objKnowledgeType_Cond.SetCondFldValue(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, this.knowledgeTypeName_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(CombineKnowledgeTypeConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objKnowledgeType_Cond.whereCond = strWhereCond;
            return objKnowledgeType_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async CombineKnowledgeTypeConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objKnowledgeType_Cond = new clsKnowledgeTypeENEx_js_1.clsKnowledgeTypeENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.knowledgeTypeName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, this.knowledgeTypeName_q);
                    objKnowledgeType_Cond.SetCondFldValue(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, this.knowledgeTypeName_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineKnowledgeTypeConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objKnowledgeType_Cond.whereCond = strWhereCond;
            return objKnowledgeType_Cond;
        }
        /** 显示KnowledgeType对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrKnowledgeTypeObjLst:需要绑定的对象列表
        **/
        async BindTab_KnowledgeType(divContainer, arrKnowledgeTypeObjLst) {
            const strThisFuncName = this.BindTab_KnowledgeType.name;
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
                    fldName: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName,
                    sortBy: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "知识点类型名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsKnowledgeTypeENEx_js_1.clsKnowledgeTypeENEx.con_CourseName,
                    sortBy: "courseName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "课程名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate,
                    sortBy: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser,
                    sortBy: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrKnowledgeTypeObjLst, arrDataColumn, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 显示KnowledgeType对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
        * @param divContainer:显示容器
        * @param arrKnowledgeTypeExObjLst:需要绑定的对象列表
        **/
        async BindTab_KnowledgeType4Func(divContainer, arrKnowledgeTypeExObjLst) {
            const strThisFuncName = this.BindTab_KnowledgeType4Func.name;
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
                    fldName: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName,
                    sortBy: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "知识点类型名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsKnowledgeTypeENEx_js_1.clsKnowledgeTypeENEx.con_CourseName,
                    sortBy: "courseName",
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "课程名称",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate,
                    sortBy: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser,
                    sortBy: clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            try {
                await this.ExtendFldFuncMap(arrKnowledgeTypeExObjLst, arrDataColumn);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("扩展字段值的映射出错,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrKnowledgeTypeExObjLst, arrDataColumn, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrKnowledgeTypeExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrKnowledgeTypeExObjLst, arrDataColumn) {
            const arrFldName = clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrKnowledgeTypeExObjLst) {
                    await (0, clsKnowledgeTypeExWApi_js_1.KnowledgeTypeEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_KnowledgeType4Func();
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
        async BindGv_KnowledgeType() {
            const strThisFuncName = this.BindGv_KnowledgeType.name;
            if (KnowledgeTypeCRUD.sortKnowledgeTypeBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortKnowledgeTypeBy)为空，请检查！(In BindGv_KnowledgeType)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.CombineKnowledgeTypeCondition();
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrKnowledgeTypeObjLst = [];
            try {
                this.recCount = await (0, clsKnowledgeTypeWApi_js_1.KnowledgeType_GetRecCountByCondAsync)(strWhereCond);
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
                    orderBy: KnowledgeTypeCRUD.sortKnowledgeTypeBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                arrKnowledgeTypeObjLst = await (0, clsKnowledgeTypeWApi_js_7.KnowledgeType_GetObjLstByPagerAsync)(objPagerPara);
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
            if (arrKnowledgeTypeObjLst.length == 0) {
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
                await this.BindTab_KnowledgeType(strListDiv, arrKnowledgeTypeObjLst);
                //console.log("完成BindGv_KnowledgeType!");
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
        async BindGv_KnowledgeType_Cache() {
            const strThisFuncName = this.BindGv_KnowledgeType_Cache.name;
            if (KnowledgeTypeCRUD.sortKnowledgeTypeBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortKnowledgeTypeBy)为空，请检查！(In BindGv_KnowledgeType_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objKnowledgeType_Cond = await this.CombineKnowledgeTypeConditionObj();
            const strWhereCond = JSON.stringify(objKnowledgeType_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrKnowledgeTypeObjLst = [];
            try {
                this.recCount = await (0, clsKnowledgeTypeWApi_js_3.KnowledgeType_GetRecCountByCond_Cache)(objKnowledgeType_Cond, KnowledgeTypeCRUD.CourseId_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objKnowledgeType_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objKnowledgeType_Cond.whereCond);
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
                    orderBy: KnowledgeTypeCRUD.sortKnowledgeTypeBy,
                    sortFun: clsKnowledgeTypeWApi_js_8.KnowledgeType_SortFun_Defa
                };
                arrKnowledgeTypeObjLst = await (0, clsKnowledgeTypeWApi_js_9.KnowledgeType_GetObjLstByPager_Cache)(objPagerPara, KnowledgeTypeCRUD.CourseId_Cache);
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
            if (arrKnowledgeTypeObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, KnowledgeTypeCRUD.CourseId_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_KnowledgeType(strListDiv, arrKnowledgeTypeObjLst);
                //console.log("完成BindGv_KnowledgeType_Cache!");
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
        async BindGv_KnowledgeType4Func() {
            const strThisFuncName = this.BindGv_KnowledgeType4Func.name;
            if (KnowledgeTypeCRUD.sortKnowledgeTypeBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortKnowledgeTypeBy)为空，请检查！(In BindGv_KnowledgeType_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.CombineKnowledgeTypeCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrKnowledgeTypeExObjLst = [];
            try {
                this.recCount = await (0, clsKnowledgeTypeWApi_js_1.KnowledgeType_GetRecCountByCondAsync)(strWhereCond);
                const objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: KnowledgeTypeCRUD.sortKnowledgeTypeBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                arrKnowledgeTypeExObjLst = await (0, clsKnowledgeTypeExWApi_js_2.KnowledgeTypeEx_GetObjExLstByPagerAsync)(objPagerPara);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrKnowledgeTypeExObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, KnowledgeTypeCRUD.CourseId_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_KnowledgeType4Func(strListDiv, arrKnowledgeTypeExObjLst);
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, KnowledgeTypeCRUD.ascOrDesc4SortFun, KnowledgeTypeCRUD.sortKnowledgeTypeBy, strSortExpress);
            KnowledgeTypeCRUD.sortKnowledgeTypeBy = sortBy;
            KnowledgeTypeCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            KnowledgeTypeCRUD.sortFun_Static = sortFun;
            await this.BindGv_KnowledgeType4Func();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrKnowledgeTypeId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrKnowledgeTypeObjLst = await (0, clsKnowledgeTypeWApi_js_10.KnowledgeType_GetObjLstByKnowledgeTypeIdLstAsync)(arrKnowledgeTypeId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrKnowledgeTypeObjLst) {
                    const strMaxStrId = await (0, clsKnowledgeTypeWApi_js_11.KnowledgeType_GetMaxStrIdAsync)();
                    //console.log('strMaxStrId=' + strMaxStrId);
                    objInFor.knowledgeTypeId = strMaxStrId;
                    const returnBool = await (0, clsKnowledgeTypeWApi_js_12.KnowledgeType_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        //KnowledgeType_ReFreshCache(KnowledgeTypeCRUD.CourseId_Cache);
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
        async DelMultiRecord(arrKnowledgeTypeId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsKnowledgeTypeWApi_js_13.KnowledgeType_DelKnowledgeTypesAsync)(arrKnowledgeTypeId);
                if (returnInt > 0) {
                    //KnowledgeType_ReFreshCache(KnowledgeTypeCRUD.CourseId_Cache);
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
        * @param objKnowledgeType:需要显示的对象
        **/
        ShowKnowledgeTypeObj(divContainer, objKnowledgeType) {
            const strThisFuncName = this.ShowKnowledgeTypeObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objKnowledgeType);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objKnowledgeType.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjKnowledgeTypeEN:表实体类对象
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
        * 知识点类型名 (Used In CombineCondition())
        **/
        get knowledgeTypeName_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetInputValueInDiv)(this.divName4Query, "txtKnowledgeTypeName_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 知识点类型名 (Used In CombineCondition())
        **/
        set knowledgeTypeName_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetInputValueByIdInDiv)(this.divName4Query, "txtKnowledgeTypeName_q", value);
        }
        /**
        * 设置界面标题-相当使用ViewState功能
        **/
        set ViewTitle(value) {
            (0, clsCommFunc4Ctrl_js_2.SetLabelHtmlByIdInDiv)(this.divName4Layout, "lblViewTitle", value);
        }
        /**
        * 设置界面标题
        **/
        get ViewTitle() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetLabelHtmlInDiv)(this.divName4Layout, "lblViewTitle");
            return strValue;
        }
    }
    exports.KnowledgeTypeCRUD = KnowledgeTypeCRUD;
    KnowledgeTypeCRUD.ascOrDesc4SortFun = "Asc";
    KnowledgeTypeCRUD.sortKnowledgeTypeBy = "";
    KnowledgeTypeCRUD.CourseId_Cache = ""; //缓存分类字段
});
