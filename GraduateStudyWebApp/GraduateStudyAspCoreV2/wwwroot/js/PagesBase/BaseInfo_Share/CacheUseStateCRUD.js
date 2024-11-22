(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L0_Entity/SystemSet_Share/clsCacheModeEN.js", "../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateEN.js", "../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateENEx.js", "../../TS/L3_ForWApi/SystemSet_Share/clsCacheModeWApi.js", "../../TS/L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js", "../../TS/L3_ForWApiEx/SystemSet_Share/clsCacheUseStateExWApi.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/PubFun/clsOperateList.js", "../../TS/PubFun/clsPager.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseStateCRUD = void 0;
    /**
    * 类名:CacheUseStateCRUD(界面:CacheUseStateCRUD)
    * 表名:CacheUseState(00050566)
    * 版本:2022.12.12.1(服务器:WIN-SRV103-116)
    * 日期:2022/12/13 05:51:10
    * 生成者:
    工程名称:AGC(0005)
    CM工程:AgcSpa前端(变量首字母小写)-WebApi函数集
    * 相关数据库:103.116.76.183,9433AGC_CS12
    * PrjDataBaseId:0005
    * 模块中文名:系统设置(SystemSet)
    * 框架-层名:WA_界面后台_TS(TS)(WA_ViewScriptCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsCacheModeEN_js_1 = require("../../TS/L0_Entity/SystemSet_Share/clsCacheModeEN.js");
    const clsCacheUseStateEN_js_1 = require("../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateEN.js");
    const clsCacheUseStateENEx_js_1 = require("../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateENEx.js");
    const clsCacheModeWApi_js_1 = require("../../TS/L3_ForWApi/SystemSet_Share/clsCacheModeWApi.js");
    const clsCacheUseStateWApi_js_1 = require("../../TS/L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js");
    const clsCacheUseStateExWApi_js_1 = require("../../TS/L3_ForWApiEx/SystemSet_Share/clsCacheUseStateExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsOperateList_js_1 = require("../../TS/PubFun/clsOperateList.js");
    const clsPager_js_1 = require("../../TS/PubFun/clsPager.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /** CacheUseStateCRUD 的摘要说明。其中Q代表查询,U代表修改
    * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:GeneCode)
    **/
    class CacheUseStateCRUD {
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
            CacheUseStateCRUD.objPage_CRUD = this;
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
                CacheUseStateCRUD.sortCacheUseStateBy = "mId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const responseBindGv = await this.BindGv_CacheUseState4Func();
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
            const responseBindGv = await this.BindGv_CacheUseState4Func();
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData)
        **/
        CombineData(arrCacheUseStateObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData.name;
            const intRowNum = arrCacheUseStateObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j].colHeader);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrCacheUseStateObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("缓存使用状态({0})导出.xlsx", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 合并数据
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineData4Func)
        **/
        CombineData4Func(arrCacheUseStateExObjLst, arrDataColumn) {
            const strThisFuncName = this.CombineData4Func.name;
            const intRowNum = arrCacheUseStateExObjLst.length;
            const intColNum = arrDataColumn.length;
            const arrData = new Array();
            const arrHead = new Array();
            for (let j = 0; j < intColNum; j++) {
                arrHead.push(arrDataColumn[j]);
            }
            arrData.push(arrHead);
            for (let i = 0; i < intRowNum; i++) {
                const arrRow = new Array();
                const objEN = arrCacheUseStateExObjLst[i];
                for (let j = 0; j < intColNum; j++) {
                    arrRow.push(objEN.GetFldValue(arrDataColumn[j].fldName)); //i + "" + j;
                }
                arrData.push(arrRow);
            }
            //console.log("arrData", arrData);
            const strFileName = (0, clsString_js_1.Format)("缓存使用状态({0})导出.xlsx", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName);
            exportSpecialExcel_pyf(arrData, strFileName);
        }
        /** 根据条件获取相应的对象列表
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExportExcel4Func)
        **/
        async ExportExcel_CacheUseState4Func() {
            const strThisFuncName = this.ExportExcel_CacheUseState4Func.name;
            if (CacheUseStateCRUD.sortCacheUseStateBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortCacheUseStateBy)为空，请检查！(In BindGv_CacheUseState_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objCacheUseState_Cond = this.CombineCacheUseStateConditionObj4ExportExcel();
            objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Cache, "=");
            let arrCacheUseStateObjLst = [];
            const arrCacheUseStateExObjLst = [];
            try {
                this.recCount = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetRecCountByCond_Cache)(objCacheUseState_Cond, CacheUseStateCRUD.UserId_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objCacheUseState_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objCacheUseState_Cond.whereCond);
                    console.error("Error: ", strMsg);
                    //console.trace();
                    alert(strMsg);
                    return;
                }
                arrCacheUseStateObjLst = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetSubObjLst_Cache)(objCacheUseState_Cond, CacheUseStateCRUD.UserId_Cache);
                for (const objInFor of arrCacheUseStateObjLst) {
                    const objEx = new clsCacheUseStateENEx_js_1.clsCacheUseStateENEx();
                    (0, clsCommFunc4Web_js_1.ObjectAssign)(objEx, objInFor);
                    arrCacheUseStateExObjLst.push(objEx);
                }
                for (const objInFor of arrCacheUseStateExObjLst) {
                    const conFuncMap = await this.FuncMap4ExcelExport(objInFor);
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("导出Excel时获取数据不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrCacheUseStateObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, CacheUseStateCRUD.UserId_Cache);
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
                        fldName: "mId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "mId",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 2,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "cacheModeId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "缓存方式名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 3,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "cacheModeId",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "缓存方式英文名",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 4,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "cacheKey",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "缓存关键字",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 5,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                    {
                        fldName: "cacheSize",
                        sortBy: "",
                        sortFun: clsCommFunc4Web_js_1.SortFun,
                        getDataSource: "",
                        colHeader: "缓存大小",
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
                        colHeader: "说明",
                        text: "",
                        tdClass: "text-left",
                        columnType: "Label",
                        orderNum: 7,
                        funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                    },
                ];
                arrCacheUseStateObjLst = arrCacheUseStateObjLst.sort(this.SortFun_ExportExcel);
                this.CombineData(arrCacheUseStateObjLst, arrDataColumn);
                //console.log("完成BindGv_CacheUseState!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 设置绑定下拉框，针对字段:[CacheModeId]
        * (AGC.PureClassEx.clsASPDropDownListBLEx_Static:GC_SetBindDdl_TS4QryRegion4TabFeature1B)
        **/
        async SetDdl_CacheModeIdInDiv() {
            await (0, clsCacheModeWApi_js_1.CacheMode_BindDdl_CacheModeIdByInUseInDiv_Cache)(this.divName4Query, "ddlCacheModeId_q", true); //
        }
        /** 函数功能:为查询区绑定下拉框
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindDdl4QueryRegion)
        **/
        async BindDdl4QueryRegion() {
            const strThisFuncName = this.BindDdl4QueryRegion.name;
            // 在此处放置用户代码以初始化页面
            await this.SetDdl_CacheModeIdInDiv(); //查询区域
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
                await this.BindGv_CacheUseState4Func();
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("复制记录不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 在数据表里删除记录
        * "lngmId": 表关键字
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
                await this.BindGv_CacheUseState4Func();
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
        async btnSelectRecordInTab_Click(lngmId) {
            const strThisFuncName = this.btnSelectRecordInTab_Click.name;
            try {
                if (lngmId == 0) {
                    const strMsg = "请选择相关记录，请检查！";
                    console.error(strMsg);
                    alert(strMsg);
                    return;
                }
                if ((0, clsCommFunc4Web_js_1.confirm_del)(0) == false) {
                    return;
                }
                this.SelectRecord(lngmId);
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
        async DelRecord(lngmId) {
            const strThisFuncName = this.DelRecord.name;
            try {
                const returnInt = await (0, clsCacheUseStateWApi_js_1.CacheUseState_DelRecordAsync)(lngmId);
                if (returnInt > 0) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(CacheUseStateCRUD.UserId_Cache);
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
        async SelectRecord(lngmId) {
            const strThisFuncName = this.SelectRecord.name;
            try {
                const objCacheUseStateEN = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                //console.log("完成SelectRecord!", objCacheUseStateEN);
                (0, clsCommFunc4Web_js_1.Redirect)("/Index/Main_CacheUseState");
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
                await this.BindGv_CacheUseState4Func();
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
            const responseBindGv = await this.ExportExcel_CacheUseState4Func();
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineCondition)
        * @returns 条件串(strWhereCond)
        **/
        CombineCacheUseStateCondition() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            strWhereCond += (0, clsString_js_1.Format)(" and UserId ='{0}'", CacheUseStateCRUD.UserId_Static);
            try {
                if (this.cacheModeId_q != "" && this.cacheModeId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId, this.cacheModeId_q);
                }
                if (this.cacheKey_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey, this.cacheKey_q);
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0009)在组合查询条件(CombineCacheUseStateCondition)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            return strWhereCond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj)
        * @returns 条件串(strWhereCond)
        **/
        async CombineCacheUseStateConditionObj() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objCacheUseState_Cond = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Static, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.cacheModeId_q != "" && this.cacheModeId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId, this.cacheModeId_q);
                    objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId, this.cacheModeId_q, "=");
                }
                if (this.cacheKey_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey, this.cacheKey_q);
                    objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey, this.cacheKey_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0010)在组合查询条件对象(CombineCacheUseStateConditionObj)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objCacheUseState_Cond.whereCond = strWhereCond;
            return objCacheUseState_Cond;
        }
        /** 把所有的查询控件内容组合成一个条件串
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CombineConditionObj4ExportExcel)
        * @returns 条件串(strWhereCond)
        **/
        CombineCacheUseStateConditionObj4ExportExcel() {
            //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
            //例如 1 = 1 && UserName = '张三'
            let strWhereCond = " 1 = 1 ";
            const objCacheUseState_Cond = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
            objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Static, "=");
            //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
            try {
                if (this.cacheModeId_q != "" && this.cacheModeId_q != "0") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} = '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId, this.cacheModeId_q);
                    objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId, this.cacheModeId_q, "=");
                }
                if (this.cacheKey_q != "") {
                    strWhereCond += (0, clsString_js_1.Format)(" And {0} like '% {1}%'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey, this.cacheKey_q);
                    objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey, this.cacheKey_q, "like");
                }
            }
            catch (objException) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0013)在组合导出Excel条件对象(CombineCacheUseStateConditionObj4ExportExcel)时出错!请联系管理员!{0}", objException);
                throw strMsg;
            }
            objCacheUseState_Cond.whereCond = strWhereCond;
            return objCacheUseState_Cond;
        }
        /** 显示CacheUseState对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab)
        * @param divContainer:显示容器
        * @param arrCacheUseStateObjLst:需要绑定的对象列表
        **/
        async BindTab_CacheUseState(divContainer, arrCacheUseStateObjLst) {
            const strThisFuncName = this.BindTab_CacheUseState.name;
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
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "mId",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "用户Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName,
                    sortBy: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存方式名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName,
                    sortBy: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存方式英文名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存关键字",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存大小",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UseDate,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UseDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "使用日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "说明",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrCacheUseStateObjLst, arrDataColumn, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 显示CacheUseState对象的所有属性值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_BindTab4Func)
        * @param divContainer:显示容器
        * @param arrCacheUseStateExObjLst:需要绑定的对象列表
        **/
        async BindTab_CacheUseState4Func(divContainer, arrCacheUseStateExObjLst) {
            const strThisFuncName = this.BindTab_CacheUseState4Func.name;
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
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "mId",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 2,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "用户Id",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 3,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName,
                    sortBy: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存方式名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 4,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName,
                    sortBy: clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeENName,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存方式英文名",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 5,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存关键字",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 7,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "缓存大小",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 8,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UseDate,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UseDate,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "使用日期",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 9,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
                {
                    fldName: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo,
                    sortBy: clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo,
                    sortFun: clsCommFunc4Web_js_1.SortFun,
                    getDataSource: "",
                    colHeader: "说明",
                    text: "",
                    tdClass: "text-left",
                    columnType: "Label",
                    orderNum: 10,
                    funcName: (strKey, strText) => { console.log(strKey, strText); return new HTMLElement(); }
                },
            ];
            try {
                await this.ExtendFldFuncMap(arrCacheUseStateExObjLst, arrDataColumn);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("扩展字段值的映射出错,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            await (0, clsCommFunc4Web_js_1.BindTab)(o, arrCacheUseStateExObjLst, arrDataColumn, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId, this);
            this.objPager.recCount = this.recCount;
            this.objPager.pageSize = this.pageSize;
            this.objPager.ShowPagerV2(this, this.divName4Pager);
        }
        /** 扩展字段值的函数映射
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_ExtendFldFuncMap)
        * @param arrCacheUseStateExObjLst:需要映射的对象列表
        * @param arrDataColumn:用于绑定表的数据列信息
        **/
        async ExtendFldFuncMap(arrCacheUseStateExObjLst, arrDataColumn) {
            const arrFldName = clsCacheUseStateEN_js_1.clsCacheUseStateEN.AttributeName;
            for (const objDataColumn of arrDataColumn) {
                if ((0, clsString_js_1.IsNullOrEmpty)(objDataColumn.fldName) == true)
                    continue;
                if (arrFldName.indexOf(objDataColumn.fldName) > -1)
                    continue;
                for (const objInFor of arrCacheUseStateExObjLst) {
                    await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_FuncMapByFldName)(objDataColumn.fldName, objInFor);
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
            const responseBindGv = await this.BindGv_CacheUseState4Func();
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
        async BindGv_CacheUseState_Cache() {
            const strThisFuncName = this.BindGv_CacheUseState_Cache.name;
            if (CacheUseStateCRUD.sortCacheUseStateBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortCacheUseStateBy)为空，请检查！(In BindGv_CacheUseState_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objCacheUseState_Cond = await this.CombineCacheUseStateConditionObj();
            objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Cache, "=");
            const strWhereCond = JSON.stringify(objCacheUseState_Cond);
            let intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrCacheUseStateObjLst = [];
            try {
                this.recCount = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetRecCountByCond_Cache)(objCacheUseState_Cond, CacheUseStateCRUD.UserId_Cache);
                if (this.recCount == 0) {
                    const lblMsg = document.createElement("span");
                    lblMsg.innerHTML = (0, clsString_js_1.Format)("根据条件:[{0}]获取的对象列表数为0！", objCacheUseState_Cond.whereCond);
                    const divDataLst = document.getElementById("divDataLst");
                    if (divDataLst != null) {
                        divDataLst.innerText = "";
                        divDataLst.appendChild(lblMsg);
                    }
                    const strMsg = (0, clsString_js_1.Format)("在绑定Gv_Cache过程中，根据条件:[{0}]获取的对象列表数为0！", objCacheUseState_Cond.whereCond);
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
                    orderBy: CacheUseStateCRUD.sortCacheUseStateBy,
                    sortFun: clsCacheUseStateWApi_js_1.CacheUseState_SortFun_Defa
                };
                arrCacheUseStateObjLst = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjLstByPager_Cache)(objPagerPara, CacheUseStateCRUD.UserId_Cache);
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
            if (arrCacheUseStateObjLst.length == 0) {
                const lblMsg = document.createElement("span");
                lblMsg.innerHTML = "根据条件获取的对象列表数为0！";
                const divDataLst = document.getElementById("divDataLst");
                if (divDataLst != null) {
                    divDataLst.innerText = "";
                    divDataLst.appendChild(lblMsg);
                }
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, CacheUseStateCRUD.UserId_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_CacheUseState(strListDiv, arrCacheUseStateObjLst);
                //console.log("完成BindGv_CacheUseState_Cache!");
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
        async BindGv_CacheUseState4Func() {
            const strThisFuncName = this.BindGv_CacheUseState4Func.name;
            if (CacheUseStateCRUD.sortCacheUseStateBy == null) {
                const strMsg = (0, clsString_js_1.Format)("在显示列表时，排序字段(sortCacheUseStateBy)为空，请检查！(In BindGv_CacheUseState_Cache)");
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            const strListDiv = this.divName4DataList;
            const objCacheUseState_Cond = await this.CombineCacheUseStateConditionObj();
            objCacheUseState_Cond.SetCondFldValue(clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, CacheUseStateCRUD.UserId_Cache, "=");
            const strWhereCond = JSON.stringify(objCacheUseState_Cond);
            const intCurrPageIndex = (0, clsOperateList_js_1.GetCurrPageIndex)(this.objPager.currPageIndex); //获取当前页
            let arrCacheUseStateExObjLst = [];
            try {
                this.recCount = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetRecCountByCond_Cache)(objCacheUseState_Cond, CacheUseStateCRUD.UserId_Cache);
                let strSortFun = (x, y) => { return 0; };
                if (CacheUseStateCRUD.sortFun_Static != undefined) {
                    strSortFun = CacheUseStateCRUD.sortFun_Static(CacheUseStateCRUD.ascOrDesc4SortFun);
                }
                const objPagerPara = {
                    pageIndex: intCurrPageIndex,
                    pageSize: this.pageSize,
                    whereCond: strWhereCond,
                    orderBy: CacheUseStateCRUD.sortCacheUseStateBy,
                    sortFun: strSortFun
                };
                arrCacheUseStateExObjLst = await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_GetObjExLstByPager_Cache)(objPagerPara, CacheUseStateCRUD.UserId_Cache);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定GridView不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
                return;
            }
            if (arrCacheUseStateExObjLst.length == 0) {
                const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, CacheUseStateCRUD.UserId_Cache);
                const strMsg = (0, clsString_js_1.Format)("根据条件获取的记录数为0！(Key={0})", strKey);
                console.error("Error: ", strMsg);
                //console.trace();
                (0, clsOperateList_js_1.ShowEmptyRecNumInfo)(strListDiv, strMsg);
                this.objPager.Hide(this.divName4Pager);
                return;
            }
            try {
                await this.BindTab_CacheUseState4Func(strListDiv, arrCacheUseStateExObjLst);
                //console.log("完成BindGv_CacheUseState4Func!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("绑定对象列表不成功, {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /**
        * 把一个扩展类的部分属性进行函数转换
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_FuncMap4ExcelExport)
        * @param objCacheUseStateS:源对象
        **/
        async FuncMap4ExcelExport(objCacheUseState) {
            const strThisFuncName = this.FuncMap4ExcelExport.name;
            try {
                {
                    const CacheMode_CacheModeId = objCacheUseState.cacheModeId;
                    const CacheMode_CacheModeName = await (0, clsCacheModeWApi_js_1.CacheMode_func)(clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName, CacheMode_CacheModeId.toString());
                    objCacheUseState.cacheModeName = CacheMode_CacheModeName;
                }
                {
                    const CacheMode_CacheModeId = objCacheUseState.cacheModeId;
                    const CacheMode_CacheModeENName = await (0, clsCacheModeWApi_js_1.CacheMode_func)(clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName, CacheMode_CacheModeId.toString());
                    objCacheUseState.cacheModeENName = CacheMode_CacheModeENName;
                }
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("(errid:WiTsCs0014)函数映射4ExcelExport表对象数据出错,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
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
            if (a.mId == b.mId)
                return a.mId - b.mId;
            else
                return a.userId.localeCompare(b.userId);
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
            const { sortFun, ascOrDesc4SortFun, sortBy } = (0, clsOperateList_js_1.GetSortBy)(objAnchorElement, CacheUseStateCRUD.ascOrDesc4SortFun, CacheUseStateCRUD.sortCacheUseStateBy, strSortExpress);
            CacheUseStateCRUD.sortCacheUseStateBy = sortBy;
            CacheUseStateCRUD.ascOrDesc4SortFun = ascOrDesc4SortFun;
            CacheUseStateCRUD.sortFun_Static = sortFun;
            await this.BindGv_CacheUseState4Func();
        }
        /** 复制记录
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_CopyRecord)
        **/
        async CopyRecord(arrmId) {
            const strThisFuncName = this.CopyRecord.name;
            try {
                const arrCacheUseStateObjLst = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjLstBymIdLstAsync)(arrmId);
                //console.log('responseText=');
                //console.log(responseText);
                let intCount = 0;
                for (const objInFor of arrCacheUseStateObjLst) {
                    const returnBool = await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objInFor);
                    //console.log('returnBool=');
                    //console.log(returnBool);
                    if (returnBool == true) {
                        (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(CacheUseStateCRUD.UserId_Cache);
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
        async DelMultiRecord(arrmId) {
            const strThisFuncName = this.DelMultiRecord.name;
            try {
                const returnInt = await (0, clsCacheUseStateWApi_js_1.CacheUseState_DelCacheUseStatesAsync)(arrmId);
                if (returnInt > 0) {
                    (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(CacheUseStateCRUD.UserId_Cache);
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
        * @param objCacheUseState:需要显示的对象
        **/
        ShowCacheUseStateObj(divContainer, objCacheUseState) {
            const strThisFuncName = this.ShowCacheUseStateObj.name;
            const o = document.getElementById(divContainer);
            if (o == null) {
                alert((0, clsString_js_1.Format)("{}不存在！", divContainer));
                return;
            }
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheUseState);
            const ul = document.createElement("ul");
            for (const strKey of sstrKeys) {
                const strValue = objCacheUseState.GetFldValue(strKey);
                const li = document.createElement("li");
                li.innerHTML = (0, clsString_js_1.Format)("{0}:{1}", strKey, strValue);
                ul.appendChild(li);
            }
            o.appendChild(ul);
        }
        /** 函数功能:从界面列表中获取第一个关键字的值
        * (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_GetFirstKey)
        * @param pobjCacheUseStateEN:表实体类对象
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
        * 缓存关键字 (Used In CombineCondition())
        **/
        get cacheKey_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetInputValueInDiv)(this.divName4Query, "txtCacheKey_q");
            if (strValue == undefined)
                return "";
            else
                return strValue.toString();
        }
        /**
        * 缓存关键字 (Used In CombineCondition())
        **/
        set cacheKey_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetInputValueByIdInDiv)(this.divName4Query, "txtCacheKey_q", value);
        }
        /**
        * 缓存方式Id (Used In CombineCondition())
        **/
        get cacheModeId_q() {
            const strValue = (0, clsCommFunc4Ctrl_js_1.GetSelectValueInDiv)(this.divName4Query, "ddlCacheModeId_q");
            if (strValue == undefined)
                return "";
            else if (strValue == "0")
                return "";
            else
                return strValue;
        }
        /**
        * 缓存方式Id (Used In CombineCondition())
        **/
        set cacheModeId_q(value) {
            (0, clsCommFunc4Ctrl_js_1.SetSelectValueByIdInDiv)(this.divName4Query, "ddlCacheModeId_q", value);
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
    exports.CacheUseStateCRUD = CacheUseStateCRUD;
    CacheUseStateCRUD.ascOrDesc4SortFun = "Asc";
    CacheUseStateCRUD.sortCacheUseStateBy = "";
    CacheUseStateCRUD.UserId_Cache = ""; //缓存分类字段
    CacheUseStateCRUD.UserId_Static = ""; //查询区条件变量
    CacheUseStateCRUD.Bool_True = ""; //查询区下拉框条件变量1
});
