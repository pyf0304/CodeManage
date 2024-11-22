(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/UserManage/clsQxDepartmentInfoWApi.js", "../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js", "../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js", "../../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L0_Entity/BaseInfo/clsQxUsersEN.js", "../../TS/L0_Entity/BaseInfo/clsQxUsersENEx.js", "../../TS/L3_ForWApiEx/BaseInfo/clsQxUsersExWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js", "../../TS/PubFun/clsOperateList.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QxUsersCRUD = void 0;
    /**
    * 类名:QxUsersCRUD(界面:QxUsersCRUD)
    * 表名:QxUsers(01120258)
    * 版本:2023.03.10.1(服务器:WIN-SRV103-116)
    * 日期:2023/03/13 00:59:04
    * 生成者:
    工程名称:问卷调查(0112)
    CM工程:研究生论文学习(变量首字母小写)-全部函数集
    * 相关数据库:103.116.76.183,9433EduHigh_Jsie
    * PrjDataBaseId:0170
    * 模块中文名:基本信息维护(BaseInfo)
    * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsQxUsersWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_2 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_3 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_4 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxDepartmentInfoWApi_js_1 = require("../../TS/L3_ForWApi/UserManage/clsQxDepartmentInfoWApi.js");
    const clsXzClgWApi_js_1 = require("../../TS/L3_ForWApi/BaseInfo_Share/clsXzClgWApi.js");
    const clsXzGradeBaseWApi_js_1 = require("../../TS/L3_ForWApi/SysPara/clsXzGradeBaseWApi.js");
    const clsUserIdentityWApi_js_1 = require("../../TS/L3_ForWApi/UserManage_Share/clsUserIdentityWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsQxUsersWApi_js_5 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_6 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersEN_js_1 = require("../../TS/L0_Entity/BaseInfo/clsQxUsersEN.js");
    const clsQxUsersENEx_js_1 = require("../../TS/L0_Entity/BaseInfo/clsQxUsersENEx.js");
    const clsQxUsersExWApi_js_1 = require("../../TS/L3_ForWApiEx/BaseInfo/clsQxUsersExWApi.js");
    const clsQxUsersWApi_js_7 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_8 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_9 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_10 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_11 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsQxUsersWApi_js_12 = require("../../TS/L3_ForWApi/BaseInfo/clsQxUsersWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCommFunc4Ctrl_js_2 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    /** QxUsersCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class QxUsersCRUD {
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
            QxUsersCRUD.objPage_CRUD = this;
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
                QxUsersCRUD.sortQxUsersBy = "userId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_QxUsers();
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
                QxUsersCRUD.sortQxUsersBy = "userId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_QxUsers();
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
            const responseBindGv = await this.BindGv_QxUsers();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrQxUsersObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrQxUsersObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrQxUsersObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("Qx用户({0})导出.xlsx", clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel)
        **/
        async ExportExcel_QxUsers() {
            const strThisFuncName = this.ExportExcel_QxUsers.name;
            if (QxUsersCRUD.sortQxUsersBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortQxUsersBy)为空，请检查！(In BindGv_QxUsers_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.CombineQxUsersCondition();
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrQxUsersObjLst = [];
            try {
                this.recCount = await (0, clsQxUsersWApi_js_1.QxUsers_GetRecCountByCondAsync)(strWhereCond);
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
                arrQxUsersObjLst = await (0, clsQxUsersWApi_js_2.QxUsers_GetObjLstAsync)(strWhereCond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrQxUsersObjLst.length == 0) {
                const strMsg = (0, clsString_js_1.Format)("在ExportExcel过程中，根据条件获取的记录数为0！");
                console.error("Error: ", strMsg);
                //console.trace();
                alert(strMsg);
                return;
            }
            try {
                const arrDataColumn = [
                    {
                        fldName: "userId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "用户ID",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "userName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "用户名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_XzCollege",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学院流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_GradeBase",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "年级流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "card_State",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "Card_State",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isLeaved",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "IsLeaved",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "cardNo",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "卡号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "beginYearMonth",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "开始年月",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 11,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "endYearMonth",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "结束年月",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 12,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "optUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "OptUser",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "optDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "OptDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
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
                        orderNum: 15,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "password",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "Password",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isGpUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否Gp用户",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 17,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "schoolID1",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学校编号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 18,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "avatarsPicture",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "AvatarsPicture",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 19,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "email",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "电子邮箱",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 20,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "phoneNumber",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "PhoneNumber",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 21,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "effectiveDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "EffectiveDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 22,
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
                        orderNum: 23,
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
                        orderNum: 24,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "effitiveBeginDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "EffitiveBeginDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 25,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "effitiveEndDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "EffitiveEndDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 26,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_College",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学院流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 27,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isArchive",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "IsArchive",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 30,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrQxUsersObjLst = arrQxUsersObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrQxUsersObjLst, arrDataColumn);
                //console.log("完成BindGv_QxUsers!");
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
        async ExportExcel_QxUsers_Cache() {
            const strThisFuncName = this.ExportExcel_QxUsers_Cache.name;
            if (QxUsersCRUD.sortQxUsersBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortQxUsersBy)为空，请检查！(In BindGv_QxUsers_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objQxUsers_Cond = await this.CombineQxUsersConditionObj4ExportExcel();
            const strWhereCond = JSON.stringify(objQxUsers_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrQxUsersObjLst = [];
            try {
                this.recCount = await (0, clsQxUsersWApi_js_3.QxUsers_GetRecCountByCond_Cache)(objQxUsers_Cond);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objQxUsers_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objQxUsers_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrQxUsersObjLst = await (0, clsQxUsersWApi_js_4.QxUsers_GetSubObjLst_Cache)(objQxUsers_Cond);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrQxUsersObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}", clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName);
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
                        fldName: "userId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "用户ID",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "userName",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "用户名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_XzCollege",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学院流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_GradeBase",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "年级流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "card_State",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "Card_State",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 8,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isLeaved",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "IsLeaved",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 9,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "cardNo",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "卡号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 10,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "beginYearMonth",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "开始年月",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 11,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "endYearMonth",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "结束年月",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 12,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "optUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "OptUser",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 13,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "optDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "OptDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 14,
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
                        orderNum: 15,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "password",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "Password",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 16,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isGpUser",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "是否Gp用户",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 17,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "schoolID1",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学校编号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 18,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "avatarsPicture",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "AvatarsPicture",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 19,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "email",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "电子邮箱",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 20,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "phoneNumber",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "PhoneNumber",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 21,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "effectiveDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "EffectiveDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 22,
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
                        orderNum: 23,
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
                        orderNum: 24,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "effitiveBeginDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "EffitiveBeginDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 25,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "effitiveEndDate",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "EffitiveEndDate",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 26,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "id_College",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "学院流水号",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 27,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "isArchive",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "IsArchive",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 30,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrQxUsersObjLst = arrQxUsersObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrQxUsersObjLst, arrDataColumn);
                //console.log("完成BindGv_QxUsers!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[DepartmentId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_DepartmentIdInDiv() {
            await (0, clsQxDepartmentInfoWApi_js_1.QxDepartmentInfo_BindDdl_DepartmentIdInDiv_Cache)(this.divName4Query, "ddlDepartmentId_q"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_XzCollege]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_id_XzCollegeInDiv() {
            await (0, clsXzClgWApi_js_1.XzClg_BindDdl_id_XzCollegeInDiv_Cache)(this.divName4Query, "ddlid_XzCollege_q"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[id_GradeBase]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_id_GradeBaseInDiv() {
            await (0, clsXzGradeBaseWApi_js_1.XzGradeBase_BindDdl_id_GradeBaseInDiv_Cache)(this.divName4Query, "ddlid_GradeBase_q"); //
        }
        /**
        * 设置绑定下拉框，针对字段:[IdentityID]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_IdentityIDInDiv() {
            await (0, clsUserIdentityWApi_js_1.UserIdentity_BindDdl_IdentityIDInDiv_Cache)(this.divName4Query, "ddlIdentityID_q"); //
        }
        /** 函数功能:为查询区绑定下拉框
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
        **/
        async BindDdl4QueryRegion() {
            const strThisFuncName = this.BindDdl4QueryRegion.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_DepartmentIdInDiv(); //查询区域
            await this.SetDdl_id_XzCollegeInDiv(); //查询区域
            await this.SetDdl_id_GradeBaseInDiv(); //查询区域
            await this.SetDdl_IdentityIDInDiv(); //查询区域
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
                await this.BindGv_QxUsers();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "strUserId": 表关键字
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
                await this.BindGv_QxUsers();
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
        async btnSelectRecordInTab_Click(strUserId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(strUserId);
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
        async DelRecord(strUserId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsQxUsersWApi_js_5.QxUsers_DelRecordAsync)(strUserId);
                if (returnInt > 0) {
                    //QxUsers_ReFreshCache();
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
        async SelectRecord(strUserId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objQxUsersEN = await (0, clsQxUsersWApi_js_6.QxUsers_GetObjByUserIdAsync)(strUserId);
                //console.log("完成SelectRecord!", objQxUsersEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_QxUsers");
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
                await this.BindGv_QxUsers();
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
            const responseBindGv = await this.ExportExcel_QxUsers_Cache();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        async CombineQxUsersCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.userId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, this.userId_q);
                }
                if (this.userName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserName, this.userName_q);
                }
                if (this.departmentId_q != "" && this.departmentId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId, this.departmentId_q);
                }
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege, this.id_XzCollege_q);
                }
                if (this.id_GradeBase_q != "" && this.id_GradeBase_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase, this.id_GradeBase_q);
                }
                if (this.identityID_q != "" && this.identityID_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID, this.identityID_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(CombineQxUsersCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async CombineQxUsersConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objQxUsers_Cond = new clsQxUsersEN_js_1.clsQxUsersEN();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.userId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, this.userId_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, this.userId_q, "like");
                }
                if (this.userName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserName, this.userName_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_UserName, this.userName_q, "like");
                }
                if (this.departmentId_q != "" && this.departmentId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId, this.departmentId_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId, this.departmentId_q, "=");
                }
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege, this.id_XzCollege_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege, this.id_XzCollege_q, "=");
                }
                if (this.id_GradeBase_q != "" && this.id_GradeBase_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase, this.id_GradeBase_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase, this.id_GradeBase_q, "=");
                }
                if (this.identityID_q != "" && this.identityID_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID, this.identityID_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID, this.identityID_q, "=");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(CombineQxUsersConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objQxUsers_Cond.whereCond = strWhereCond;
            return objQxUsers_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        async CombineQxUsersConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objQxUsers_Cond = new clsQxUsersENEx_js_1.clsQxUsersENEx();
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.userId_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, this.userId_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, this.userId_q, "like");
                }
                if (this.userName_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsQxUsersEN_js_1.clsQxUsersEN.con_UserName, this.userName_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_UserName, this.userName_q, "like");
                }
                if (this.departmentId_q != "" && this.departmentId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId, this.departmentId_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_DepartmentId, this.departmentId_q, "=");
                }
                if (this.id_XzCollege_q != "" && this.id_XzCollege_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege, this.id_XzCollege_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_id_XzCollege, this.id_XzCollege_q, "=");
                }
                if (this.id_GradeBase_q != "" && this.id_GradeBase_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase, this.id_GradeBase_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_id_GradeBase, this.id_GradeBase_q, "=");
                }
                if (this.identityID_q != "" && this.identityID_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID, this.identityID_q);
                    objQxUsers_Cond.SetCondFldValue(clsQxUsersEN_js_1.clsQxUsersEN.con_IdentityID, this.identityID_q, "=");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineQxUsersConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objQxUsers_Cond.whereCond = strWhereCond;
            return objQxUsers_Cond;
        }
        /** 显示QxUsers对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrQxUsersObjLst:需要绑定的对象列表
        **/
        async BindTab_QxUsers(divContainer, arrQxUsersObjLst) {
            const strThisFuncName = this.BindTab_QxUsers.name;
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
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_UserId,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_UserId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "用户ID",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_UserName,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_UserName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "用户名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_Card_State,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "Card_State",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_CardNo,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "卡号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_EndYearMonth,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "结束年月",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 12,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_OptUser,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "OptUser",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 13,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_OptDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "OptDate",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 14,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_AvatarsPicture,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "AvatarsPicture",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 19,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_Email,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_Email,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "电子邮箱",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 20,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_PhoneNumber,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "PhoneNumber",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 21,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_EffectiveDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "EffectiveDate",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 22,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_UpdDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "修改日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 23,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_UpdUser,
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
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveBeginDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "EffitiveBeginDate",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 25,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_EffitiveEndDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "EffitiveEndDate",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 26,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_id_College,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_id_College,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "学院流水号",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 27,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive,
                    sortBy: clsQxUsersEN_js_1.clsQxUsersEN.con_IsArchive,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "IsArchive",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 30,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrQxUsersObjLst, arrDataColumn, clsQxUsersEN_js_1.clsQxUsersEN.con_UserId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrQxUsersExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrQxUsersExObjLst, arrDataColumn) {
            const arrFldName = clsQxUsersEN_js_1.clsQxUsersEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrQxUsersExObjLst) {
                    await (0, clsQxUsersExWApi_js_1.QxUsersEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_QxUsers();
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
        async BindGv_QxUsers() {
            const strThisFuncName = this.BindGv_QxUsers.name;
            if (QxUsersCRUD.sortQxUsersBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortQxUsersBy)为空，请检查！(In BindGv_QxUsers)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const strWhereCond = await this.CombineQxUsersCondition();
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrQxUsersObjLst = [];
            try {
                this.recCount = await (0, clsQxUsersWApi_js_1.QxUsers_GetRecCountByCondAsync)(strWhereCond);
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
                    orderBy: QxUsersCRUD.sortQxUsersBy,
                    sortFun: (x, y) => { console.log(x, y); return 0; }
                };
                arrQxUsersObjLst = await (0, clsQxUsersWApi_js_7.QxUsers_GetObjLstByPagerAsync)(objPagerPara);
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
            if (arrQxUsersObjLst.length == 0) {
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
                await this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
                //console.log("完成BindGv_QxUsers!");
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
        async BindGv_QxUsers_Cache() {
            const strThisFuncName = this.BindGv_QxUsers_Cache.name;
            if (QxUsersCRUD.sortQxUsersBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortQxUsersBy)为空，请检查！(In BindGv_QxUsers_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objQxUsers_Cond = await this.CombineQxUsersConditionObj();
            const strWhereCond = JSON.stringify(objQxUsers_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrQxUsersObjLst = [];
            try {
                this.recCount = await (0, clsQxUsersWApi_js_3.QxUsers_GetRecCountByCond_Cache)(objQxUsers_Cond);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objQxUsers_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objQxUsers_Cond.whereCond);
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
                    orderBy: QxUsersCRUD.sortQxUsersBy,
                    sortFun: clsQxUsersWApi_js_8.QxUsers_SortFun_Defa
                };
                arrQxUsersObjLst = await (0, clsQxUsersWApi_js_9.QxUsers_GetObjLstByPager_Cache)(objPagerPara);
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
            if (arrQxUsersObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}", clsQxUsersEN_js_1.clsQxUsersEN._CurrTabName);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_QxUsers(strListDiv, arrQxUsersObjLst);
                //console.log("完成BindGv_QxUsers_Cache!");
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, QxUsersCRUD.ascOrDesc4SortFun, QxUsersCRUD.sortQxUsersBy, strSortExpress);
            QxUsersCRUD.sortQxUsersBy = sortBy;
            QxUsersCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            QxUsersCRUD.sortFun_Static = sortFun;
            await this.BindGv_QxUsers();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrUserId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrQxUsersObjLst = await (0, clsQxUsersWApi_js_10.QxUsers_GetObjLstByUserIdLstAsync)(arrUserId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrQxUsersObjLst) {
                    const returnBool = await (0, clsQxUsersWApi_js_11.QxUsers_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        //QxUsers_ReFreshCache();
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
        async DelMultiRecord(arrUserId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsQxUsersWApi_js_12.QxUsers_DelQxUserssAsync)(arrUserId);
                if (returnInt > 0) {
                    //QxUsers_ReFreshCache();
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
        * @param objQxUsers:需要显示的对象
        **/
        ShowQxUsersObj(divContainer, objQxUsers) {
            const strThisFuncName = this.ShowQxUsersObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQxUsers);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objQxUsers.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjQxUsersEN:表实体类对象
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
        * 部门Id (Used In CombineCondition())
        **/
        get departmentId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetSelectValueInDiv)(this.divName4Query, "ddlDepartmentId_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 部门Id (Used In CombineCondition())
        **/
        set departmentId_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetSelectValueByIdInDiv)(this.divName4Query, "ddlDepartmentId_q", value);
        }
        /**
        * 年级流水号 (Used In CombineCondition())
        **/
        get id_GradeBase_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetSelectValueInDiv)(this.divName4Query, "ddlid_GradeBase_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 年级流水号 (Used In CombineCondition())
        **/
        set id_GradeBase_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetSelectValueByIdInDiv)(this.divName4Query, "ddlid_GradeBase_q", value);
        }
        /**
        * 学院流水号 (Used In CombineCondition())
        **/
        get id_XzCollege_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetSelectValueInDiv)(this.divName4Query, "ddlid_XzCollege_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 学院流水号 (Used In CombineCondition())
        **/
        set id_XzCollege_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetSelectValueByIdInDiv)(this.divName4Query, "ddlid_XzCollege_q", value);
        }
        /**
        * 身份编号 (Used In CombineCondition())
        **/
        get identityID_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetSelectValueInDiv)(this.divName4Query, "ddlIdentityID_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 身份编号 (Used In CombineCondition())
        **/
        set identityID_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetSelectValueByIdInDiv)(this.divName4Query, "ddlIdentityID_q", value);
        }
        /**
        * 用户ID (Used In CombineCondition())
        **/
        get userId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetInputValueInDiv)(this.divName4Query, "txtUserId_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户ID (Used In CombineCondition())
        **/
        set userId_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetInputValueByIdInDiv)(this.divName4Query, "txtUserId_q", value);
        }
        /**
        * 用户名 (Used In CombineCondition())
        **/
        get userName_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_2.GetInputValueInDiv)(this.divName4Query, "txtUserName_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 用户名 (Used In CombineCondition())
        **/
        set userName_q(value) {
            (0, clsCommFunc4Ctrl_js_2.SetInputValueByIdInDiv)(this.divName4Query, "txtUserName_q", value);
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
    exports.QxUsersCRUD = QxUsersCRUD;
    QxUsersCRUD.ascOrDesc4SortFun = "Asc";
    QxUsersCRUD.sortQxUsersBy = "";
});
