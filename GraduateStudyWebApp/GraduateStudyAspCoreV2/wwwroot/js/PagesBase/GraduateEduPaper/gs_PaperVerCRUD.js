(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js", "../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js", "../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerENEx.js", "../../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperVerExWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperVerCRUD = void 0;
    /**
    * 类名:gs_PaperVerCRUD(界面:gs_PaperVerCRUD)
    * 表名:gs_PaperVer(01120678)
    * 版本:2023.01.12.1(服务器:WIN-SRV103-116)
    * 日期:2023/01/12 16:38:16
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
    const clsgs_PaperVerWApi_js_1 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsgs_PaperVerWApi_js_2 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsvPaperSimProExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsvPaperSimProExWApi.js");
    const clsCurrEduClsWApi_js_1 = require("../../TS/L3_ForWApi/DailyRunning_Share/clsCurrEduClsWApi.js");
    const clsgs_PaperVerWApi_js_3 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsgs_PaperVerWApi_js_4 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsgs_PaperVerEN_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerEN.js");
    const clsgs_PaperVerENEx_js_1 = require("../../TS/L0_Entity/GraduateEduPaper/clsgs_PaperVerENEx.js");
    const clsgs_PaperVerExWApi_js_1 = require("../../TS/L3_ForWApiEx/GraduateEduPaper/clsgs_PaperVerExWApi.js");
    const clsgs_PaperVerWApi_js_5 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsgs_PaperVerWApi_js_6 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsgs_PaperVerWApi_js_7 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsgs_PaperVerWApi_js_8 = require("../../TS/L3_ForWApi/GraduateEduPaper/clsgs_PaperVerWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** gs_PaperVerCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class gs_PaperVerCRUD {
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
            gs_PaperVerCRUD.objPage_CRUD = this;
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
                gs_PaperVerCRUD.sortgs_PaperVerBy = "paperVId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_gs_PaperVer();
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
                gs_PaperVerCRUD.sortgs_PaperVerBy = "paperVId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_gs_PaperVer();
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
            const responseBindGv = await this.BindGv_gs_PaperVer();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrgs_PaperVerObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrgs_PaperVerObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrgs_PaperVerObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("论文历史版本表({0})导出.xlsx", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
        **/
        async ExportExcel_gs_PaperVer() {
            const strThisFuncName = this.ExportExcel_gs_PaperVer.name;
            if (gs_PaperVerCRUD.sortgs_PaperVerBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortgs_PaperVerBy)为空，请检查！(In BindGv_gs_PaperVer_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinegs_PaperVerCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrgs_PaperVerObjLst = [];
            try {
                this.recCount = await (0, clsgs_PaperVerWApi_js_1.gs_PaperVer_GetRecCountByCondAsync)(strWhereCond);
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
                arrgs_PaperVerObjLst = await (0, clsgs_PaperVerWApi_js_2.gs_PaperVer_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrgs_PaperVerObjLst.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在ExportExcel过程中，根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "paperTitle",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "论文标题",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "paperContent",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "主题内容",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "periodical",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "期刊",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "author",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "作者",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 6,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "researchQuestion",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "研究问题",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "keyword",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "关键字",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "literatureSources",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "文献来源",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "literatureLink",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "文献链接",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "uploadfileUrl",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "文件地址",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 11,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isQuotethesis",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否引用论文",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 12,
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
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isChecked",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否检查",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "checker",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "审核人",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
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
                        orderNum: 18,
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
                        orderNum: 19,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_CurrEduCls",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "教学班流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 20,
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
                        orderNum: 23,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrgs_PaperVerObjLst = arrgs_PaperVerObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrgs_PaperVerObjLst, arrDataColumn);
                //console.log("完成BindGv_gs_PaperVer!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[PaperId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_PaperIdInDiv(Id_CurrEduCls) {
            await (0, clsvPaperSimProExWApi_js_1.vPaperSimProEx_BindDdl_PaperIdByid_CurrEduClsInDiv_Cache)(this.divName4Query, "ddlPaperId_q", Id_CurrEduCls); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_CurrEduCls]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_id_CurrEduClsInDiv(courseId) {
            await (0, clsCurrEduClsWApi_js_1.CurrEduCls_BindDdl_id_CurrEduClsInDiv_Cache)(this.divName4Query, "ddlid_CurrEduCls_q", courseId); //
        }
        /** 函数功能:为查询区绑定下拉框
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
        **/
        async BindDdl4QueryRegion() {
            const strThisFuncName = this.BindDdl4QueryRegion.name;
            // 在此处放置用户代码以初始化页面
            const strid_CurrEduCls = gs_PaperVerCRUD.id_CurrEduCls_Static;
            const strCourseId = gs_PaperVerCRUD.CourseId_Static;
            await this.SetDdl_PaperIdInDiv(strid_CurrEduCls); //查询区域
            await this.SetDdl_id_CurrEduClsInDiv(strCourseId); //查询区域
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
                await this.BindGv_gs_PaperVer();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "lngPaperVId": 表关键字
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
                const lngKeyId = Number(strKeyId);
                const responseText = await this.DelRecord(lngKeyId);
                await this.BindGv_gs_PaperVer();
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
        async btnSelectRecordInTab_Click(lngPaperVId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if (lngPaperVId == 0) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(lngPaperVId);
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
        async DelRecord(lngPaperVId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsgs_PaperVerWApi_js_3.gs_PaperVer_DelRecordAsync)(lngPaperVId);
                if (returnInt > 0) {
                    //gs_PaperVer_ReFreshCache();
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
        async SelectRecord(lngPaperVId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objgs_PaperVerEN = await (0, clsgs_PaperVerWApi_js_4.gs_PaperVer_GetObjByPaperVIdAsync)(lngPaperVId);
                //console.log("完成SelectRecord!", objgs_PaperVerEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_gs_PaperVer");
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
                await this.BindGv_gs_PaperVer();
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
            const responseBindGv = await this.ExportExcel_gs_PaperVer();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async Combinegs_PaperVerCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperId_q != "" && this.paperId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId, this.paperId_q);
                }
                if (this.paperTitle_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q);
                }
                if (this.paperContent_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent, this.paperContent_q);
                }
                if (this.periodical_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical, this.periodical_q);
                }
                if (this.author_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author, this.author_q);
                }
                if (this.researchQuestion_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q);
                }
                if (this.keyword_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword, this.keyword_q);
                }
                if (this.literatureSources_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q);
                }
                if (this.literatureLink_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q);
                }
                if (this.uploadfileUrl_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q);
                }
                if (this.isQuotethesis_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
                }
                if (this.isSubmit_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
                }
                if (this.isChecked_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
                }
                if (this.quoteId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId, this.quoteId_q);
                }
                if (this.checker_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker, this.checker_q);
                }
                if (this.literatureTypeId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q);
                }
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
                }
                if (this.paperTypeId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q);
                }
                if (this.paperStatusId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(Combinegs_PaperVerCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async Combinegs_PaperVerConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objgs_PaperVer_Cond = new clsgs_PaperVerEN_js_1.clsgs_PaperVerEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperId_q != "" && this.paperId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId, this.paperId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId, this.paperId_q, "=");
                }
                if (this.paperTitle_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q, "like");
                }
                if (this.paperContent_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent, this.paperContent_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent, this.paperContent_q, "like");
                }
                if (this.periodical_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical, this.periodical_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical, this.periodical_q, "like");
                }
                if (this.author_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author, this.author_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author, this.author_q, "like");
                }
                if (this.researchQuestion_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q, "like");
                }
                if (this.keyword_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword, this.keyword_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword, this.keyword_q, "like");
                }
                if (this.literatureSources_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q, "like");
                }
                if (this.literatureLink_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q, "like");
                }
                if (this.uploadfileUrl_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q, "like");
                }
                if (this.isQuotethesis_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis, true, "=");
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis, false, "=");
                }
                if (this.isSubmit_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit, true, "=");
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit, false, "=");
                }
                if (this.isChecked_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked, true, "=");
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked, false, "=");
                }
                if (this.quoteId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId, this.quoteId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId, this.quoteId_q, "like");
                }
                if (this.checker_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker, this.checker_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker, this.checker_q, "like");
                }
                if (this.literatureTypeId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q, "like");
                }
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
                }
                if (this.paperTypeId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q, "like");
                }
                if (this.paperStatusId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(Combinegs_PaperVerConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objgs_PaperVer_Cond.whereCond = strWhereCond;
            return objgs_PaperVer_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async Combinegs_PaperVerConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objgs_PaperVer_Cond = new clsgs_PaperVerENEx_js_1.clsgs_PaperVerENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.paperId_q != "" && this.paperId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId, this.paperId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperId, this.paperId_q, "=");
                }
                if (this.paperTitle_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle, this.paperTitle_q, "like");
                }
                if (this.paperContent_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent, this.paperContent_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent, this.paperContent_q, "like");
                }
                if (this.periodical_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical, this.periodical_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical, this.periodical_q, "like");
                }
                if (this.author_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author, this.author_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author, this.author_q, "like");
                }
                if (this.researchQuestion_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion, this.researchQuestion_q, "like");
                }
                if (this.keyword_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword, this.keyword_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword, this.keyword_q, "like");
                }
                if (this.literatureSources_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources, this.literatureSources_q, "like");
                }
                if (this.literatureLink_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink, this.literatureLink_q, "like");
                }
                if (this.uploadfileUrl_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl, this.uploadfileUrl_q, "like");
                }
                if (this.isQuotethesis_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis, true, "=");
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis, false, "=");
                }
                if (this.isSubmit_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit, true, "=");
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit, false, "=");
                }
                if (this.isChecked_q == true) {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked, true, "=");
                }
                else {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked, false, "=");
                }
                if (this.quoteId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId, this.quoteId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_QuoteId, this.quoteId_q, "like");
                }
                if (this.checker_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker, this.checker_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker, this.checker_q, "like");
                }
                if (this.literatureTypeId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureTypeId, this.literatureTypeId_q, "like");
                }
                if (this.id_CurrEduCls_q != "" && this.id_CurrEduCls_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls, this.id_CurrEduCls_q, "=");
                }
                if (this.paperTypeId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTypeId, this.paperTypeId_q, "like");
                }
                if (this.paperStatusId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q);
                    objgs_PaperVer_Cond.SetCondFldValue(clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperStatusId, this.paperStatusId_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(Combinegs_PaperVerConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objgs_PaperVer_Cond.whereCond = strWhereCond;
            return objgs_PaperVer_Cond;
        }
        /** 显示gs_PaperVer对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrgs_PaperVerObjLst:需要绑定的对象列表
        **/
        async BindTab_gs_PaperVer(divContainer, arrgs_PaperVerObjLst) {
            const strThisFuncName = this.BindTab_gs_PaperVer.name;
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
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "PaperVId",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperTitle,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "论文标题",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperContent,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "主题内容",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Periodical,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "期刊",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 6,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Author,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "作者",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_ResearchQuestion,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "研究问题",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Keyword,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "关键字",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureSources,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "文献来源",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_LiteratureLink,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "文献链接",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 11,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UploadfileUrl,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "文件地址",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 12,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsQuotethesis,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "是否引用论文",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 13,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsSubmit,
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
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_IsChecked,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "是否检查",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 15,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Checker,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "审核人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 17,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改人",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 19,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 20,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_id_CurrEduCls,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "教学班流水号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 21,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo,
                    sortBy: clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_Memo,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "备注",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 24,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrgs_PaperVerObjLst, arrDataColumn, clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.con_PaperVId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrgs_PaperVerExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrgs_PaperVerExObjLst, arrDataColumn) {
            const arrFldName = clsgs_PaperVerEN_js_1.clsgs_PaperVerEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrgs_PaperVerExObjLst) {
                    await (0, clsgs_PaperVerExWApi_js_1.gs_PaperVerEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_gs_PaperVer();
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
        async BindGv_gs_PaperVer() {
            const strThisFuncName = this.BindGv_gs_PaperVer.name;
            if (gs_PaperVerCRUD.sortgs_PaperVerBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortgs_PaperVerBy)为空，请检查！(In BindGv_gs_PaperVer)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.Combinegs_PaperVerCondition();
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrgs_PaperVerObjLst = [];
            try {
                this.recCount = await (0, clsgs_PaperVerWApi_js_1.gs_PaperVer_GetRecCountByCondAsync)(strWhereCond);
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
                    orderBy: gs_PaperVerCRUD.sortgs_PaperVerBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                const responseObjLst = await (0, clsgs_PaperVerWApi_js_5.gs_PaperVer_GetObjLstByPagerAsync)(objPagerPara).then((jsonData) => {
                    arrgs_PaperVerObjLst = jsonData;
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
            if (arrgs_PaperVerObjLst.length == 0) {
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
                await this.BindTab_gs_PaperVer(strListDiv, arrgs_PaperVerObjLst);
                //console.log("完成BindGv_gs_PaperVer!");
            }
            catch (e) {
                //console.trace();
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, gs_PaperVerCRUD.ascOrDesc4SortFun, gs_PaperVerCRUD.sortgs_PaperVerBy, strSortExpress);
            gs_PaperVerCRUD.sortgs_PaperVerBy = sortBy;
            gs_PaperVerCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            gs_PaperVerCRUD.sortFun_Static = sortFun;
            await this.BindGv_gs_PaperVer();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrPaperVId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrgs_PaperVerObjLst = await (0, clsgs_PaperVerWApi_js_6.gs_PaperVer_GetObjLstByPaperVIdLstAsync)(arrPaperVId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrgs_PaperVerObjLst) {
                    const returnBool = await (0, clsgs_PaperVerWApi_js_7.gs_PaperVer_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        //gs_PaperVer_ReFreshCache();
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
        async DelMultiRecord(arrPaperVId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsgs_PaperVerWApi_js_8.gs_PaperVer_Delgs_PaperVersAsync)(arrPaperVId);
                if (returnInt > 0) {
                    //gs_PaperVer_ReFreshCache();
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
        * @param objgs_PaperVer:需要显示的对象
        **/
        Showgs_PaperVerObj(divContainer, objgs_PaperVer) {
            const strThisFuncName = this.Showgs_PaperVerObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperVer);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objgs_PaperVer.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjgs_PaperVerEN:表实体类对象
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
        * 作者 (Used In CombineCondition())
        **/
        get author_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtAuthor_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 作者 (Used In CombineCondition())
        **/
        set author_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtAuthor_q", value);
        }
        /**
        * 审核人 (Used In CombineCondition())
        **/
        get checker_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtChecker_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 审核人 (Used In CombineCondition())
        **/
        set checker_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtChecker_q", value);
        }
        /**
        * 教学班流水号 (Used In CombineCondition())
        **/
        get id_CurrEduCls_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlid_CurrEduCls_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 教学班流水号 (Used In CombineCondition())
        **/
        set id_CurrEduCls_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Query, "ddlid_CurrEduCls_q", value);
        }
        /**
        * 是否检查 (Used In CombineCondition())
        **/
        get isChecked_q() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Query, "chkIsChecked_q");
            return bolValue;
        }
        /**
        * 是否检查 (Used In CombineCondition())
        **/
        set isChecked_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Query, "chkIsChecked_q", value);
        }
        /**
        * 是否引用论文 (Used In CombineCondition())
        **/
        get isQuotethesis_q() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Query, "chkIsQuotethesis_q");
            return bolValue;
        }
        /**
        * 是否引用论文 (Used In CombineCondition())
        **/
        set isQuotethesis_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Query, "chkIsQuotethesis_q", value);
        }
        /**
        * 是否提交 (Used In CombineCondition())
        **/
        get isSubmit_q() {
            const bolValue = (0, clsCommFunc4Ctrl_js_1.GetCheckBoxValueInDiv)(this.divName4Query, "chkIsSubmit_q");
            return bolValue;
        }
        /**
        * 是否提交 (Used In CombineCondition())
        **/
        set isSubmit_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetCheckBoxValueByIdInDiv)(this.divName4Query, "chkIsSubmit_q", value);
        }
        /**
        * 关键字 (Used In CombineCondition())
        **/
        get keyword_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtKeyword_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 关键字 (Used In CombineCondition())
        **/
        set keyword_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtKeyword_q", value);
        }
        /**
        * 文献链接 (Used In CombineCondition())
        **/
        get literatureLink_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtLiteratureLink_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 文献链接 (Used In CombineCondition())
        **/
        set literatureLink_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtLiteratureLink_q", value);
        }
        /**
        * 文献来源 (Used In CombineCondition())
        **/
        get literatureSources_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtLiteratureSources_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 文献来源 (Used In CombineCondition())
        **/
        set literatureSources_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtLiteratureSources_q", value);
        }
        /**
        * 作文类型Id (Used In CombineCondition())
        **/
        get literatureTypeId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtLiteratureTypeId_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 作文类型Id (Used In CombineCondition())
        **/
        set literatureTypeId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtLiteratureTypeId_q", value);
        }
        /**
        * 主题内容 (Used In CombineCondition())
        **/
        get paperContent_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtPaperContent_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 主题内容 (Used In CombineCondition())
        **/
        set paperContent_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtPaperContent_q", value);
        }
        /**
        * 论文Id (Used In CombineCondition())
        **/
        get paperId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlPaperId_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 论文Id (Used In CombineCondition())
        **/
        set paperId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Query, "ddlPaperId_q", value);
        }
        /**
        * 论文状态Id (Used In CombineCondition())
        **/
        get paperStatusId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtPaperStatusId_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文状态Id (Used In CombineCondition())
        **/
        set paperStatusId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtPaperStatusId_q", value);
        }
        /**
        * 论文标题 (Used In CombineCondition())
        **/
        get paperTitle_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtPaperTitle_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文标题 (Used In CombineCondition())
        **/
        set paperTitle_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtPaperTitle_q", value);
        }
        /**
        * 论文类型Id (Used In CombineCondition())
        **/
        get paperTypeId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtPaperTypeId_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 论文类型Id (Used In CombineCondition())
        **/
        set paperTypeId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtPaperTypeId_q", value);
        }
        /**
        * 期刊 (Used In CombineCondition())
        **/
        get periodical_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtPeriodical_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 期刊 (Used In CombineCondition())
        **/
        set periodical_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtPeriodical_q", value);
        }
        /**
        * 引用Id (Used In CombineCondition())
        **/
        get quoteId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtQuoteId_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 引用Id (Used In CombineCondition())
        **/
        set quoteId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtQuoteId_q", value);
        }
        /**
        * 研究问题 (Used In CombineCondition())
        **/
        get researchQuestion_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtResearchQuestion_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 研究问题 (Used In CombineCondition())
        **/
        set researchQuestion_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtResearchQuestion_q", value);
        }
        /**
        * 文件地址 (Used In CombineCondition())
        **/
        get uploadfileUrl_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtUploadfileUrl_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 文件地址 (Used In CombineCondition())
        **/
        set uploadfileUrl_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtUploadfileUrl_q", value);
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
    exports.gs_PaperVerCRUD = gs_PaperVerCRUD;
    gs_PaperVerCRUD.ascOrDesc4SortFun = "Asc";
    gs_PaperVerCRUD.sortgs_PaperVerBy = "";
    gs_PaperVerCRUD.id_CurrEduCls_Static = ""; //查询区下拉框条件变量1
    gs_PaperVerCRUD.CourseId_Static = ""; //查询区下拉框条件变量1
});
