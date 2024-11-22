(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L0_Entity/SystemSet/clsCacheModeEN.js", "../TS/L0_Entity/SystemSet/clsCacheUseStateEN.js", "../TS/L3_ForWApi/SystemSet/clsCacheModeWApi.js", "../TS/L3_ForWApi/SystemSet/clsCacheUseStateWApi.js", "../TS/L3_ForWApi/SystemSet/clsvCacheUseStateWApi.js", "../TS/PubFun/CacheHelper.js", "../TS/PubFun/clsCommonFunc4Web2.js", "../TS/PubFun/clsPubSessionStorage.js", "../TS/PubFun/clsString2.js", "./CacheUseStateCRUD.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseStateCRUDEx = void 0;
    /*-- -- -- -- -- -- -- -- -- -- --
    类名:CacheUseStateCRUDEx
    表名:CacheUseState(00050566)
    生成代码版本:2020.06.17.1
    生成日期:2020/06/20 16:13:38
    生成者:
    工程名称:AGC
    工程ID:0005
    相关数据库:tzar.tpddns.cn,19433AGC_CS12
    PrjDataBaseId:0213
    模块中文名:系统设置
    模块英文名:SystemSet
    框架-层名:WA_界面后台Ex_TS(WA_ViewScriptCSEx_TS)
    编程语言:TypeScript
    == == == == == == == == == == == ==
    */
    ///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
    ///// <reference path="../../scripts/typings/q/q.d.ts" />
    ///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
    //import * as $ from "jquery";
    //import * as QQ from "q";
    const clsCacheModeEN_js_1 = require("../TS/L0_Entity/SystemSet/clsCacheModeEN.js");
    const clsCacheUseStateEN_js_1 = require("../TS/L0_Entity/SystemSet/clsCacheUseStateEN.js");
    const clsCacheModeWApi_js_1 = require("../TS/L3_ForWApi/SystemSet/clsCacheModeWApi.js");
    const clsCacheUseStateWApi_js_1 = require("../TS/L3_ForWApi/SystemSet/clsCacheUseStateWApi.js");
    const clsvCacheUseStateWApi_js_1 = require("../TS/L3_ForWApi/SystemSet/clsvCacheUseStateWApi.js");
    const CacheHelper_js_1 = require("../TS/PubFun/CacheHelper.js");
    const clsCommonFunc4Web2_js_1 = require("../TS/PubFun/clsCommonFunc4Web2.js");
    const clsPubSessionStorage_js_1 = require("../TS/PubFun/clsPubSessionStorage.js");
    const clsString2_js_1 = require("../TS/PubFun/clsString2.js");
    const CacheUseStateCRUD_js_1 = require("./CacheUseStateCRUD.js");
    /* CacheUseStateCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CacheUseStateCRUDEx extends CacheUseStateCRUD_js_1.CacheUseStateCRUD {
        //public static mstrListDiv: string = "divDataLst";
        //public static mstrSortvCacheUseStateBy: string = "mId";
        /*
        * 每页记录数，在扩展类可以修改
       */
        get pageSize() {
            return 10;
        }
        /*
         按钮单击,用于调用Js函数中btn_Click
        (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:Gen_WApi_TS_btn_Click)
        */
        static btn_Click(strCommandName, strKeyId) {
            var objPage = new CacheUseStateCRUDEx();
            switch (strCommandName) {
                case "GetCacheUseState": //查询记录
                    objPage.GetCacheUseState();
                    break;
                case "ClearLocalStorage": //查询记录
                    objPage.ClearLocalStorage();
                    break;
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    var strKeyId = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetFirstCheckedKeyId(objPage.divName4List);
                    if (strKeyId == "") {
                        alert("请选择需要修改的记录！");
                        return;
                    }
                    objPage.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要复制的记录！");
                        return;
                    }
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要删除的记录！");
                        return;
                    }
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要按标志删除的记录！");
                        return;
                    }
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要恢复删除的记录！");
                        return;
                    }
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要置顶的记录！");
                        return;
                    }
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要移底的记录！");
                        return;
                    }
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要上移的记录！");
                        return;
                    }
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    var arrKeyIds = clsCommonFunc4Web2_js_1.clsCommonFunc4Web.GetCheckedKeyIds();
                    if (arrKeyIds.length == 0) {
                        alert("请选择需要下移的记录！");
                        return;
                    }
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    var strMsg = '命令:' + strCommandName + "在函数(CacheUseStateCRUDExEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load)
    */
        async Page_Load() {
            // 在此处放置用户代码以初始化页面
            try {
                CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCacheUseStateBy = "mId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCacheUseState_Cache();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        /* 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
    */
        async Page_Load_Cache() {
            // 在此处放置用户代码以初始化页面
            try {
                CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static = clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId();
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                this.hidSortvCacheUseStateBy = "mId Asc";
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_vCacheUseState_Cache();
                const gvResult2 = await this.Subtotals();
            }
            catch (e) {
                var strMsg = `页面启动不成功,${e}.`;
                alert(strMsg);
            }
        }
        getBytes(str) {
            var len = str.length;
            var bytes = len;
            for (var i = 0; i < len; i++) {
                if (str.charCodeAt(i) > 255)
                    bytes++;
            }
            return bytes;
        }
        async GetCacheUseState() {
            var strKey;
            var myCache;
            var strCacheKeyLst = "";
            var strCondition = clsString2_js_1.clsString.Format("{0}='{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static);
            const conDelete = await (0, clsCacheUseStateWApi_js_1.CacheUseState_DelCacheUseStatesByCondAsync)(strCondition);
            for (var i = 0; i < localStorage.length; i++) {
                strKey = localStorage.key(i);
                if (strKey == null)
                    continue;
                if (clsString2_js_1.clsString.IsNullOrEmpty(strKey) == true)
                    continue;
                strCacheKeyLst += clsString2_js_1.clsString.Format("{0},", strKey);
                //拿到所有含u-的key
                var objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
                objCacheUseState.cacheKey = strKey;
                objCacheUseState.userId = CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static;
                objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.localStorage_03;
                myCache = localStorage.getItem(strKey);
                if (myCache == null) {
                    objCacheUseState.cacheSize = 0;
                }
                else {
                    objCacheUseState.cacheSize = this.getBytes(myCache);
                }
                const conAdd = await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseState);
            }
            for (var i = 0; i < sessionStorage.length; i++) {
                strKey = sessionStorage.key(i);
                if (strKey == null)
                    continue;
                if (clsString2_js_1.clsString.IsNullOrEmpty(strKey) == true)
                    continue;
                strCacheKeyLst += clsString2_js_1.clsString.Format("{0},", strKey);
                //拿到所有含u-的key
                var objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
                objCacheUseState.cacheKey = strKey;
                objCacheUseState.userId = CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static;
                objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.sessionStorage_04;
                myCache = sessionStorage.getItem(strKey);
                if (myCache == null) {
                    objCacheUseState.cacheSize = 0;
                }
                else {
                    objCacheUseState.cacheSize = this.getBytes(myCache);
                }
                const conAdd = await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseState);
            }
            for (var i = 0; i < CacheHelper_js_1.CacheHelper.CacheLength(); i++) {
                strKey = CacheHelper_js_1.CacheHelper.Key(i);
                if (strKey == null)
                    continue;
                if (clsString2_js_1.clsString.IsNullOrEmpty(strKey) == true)
                    continue;
                strCacheKeyLst += clsString2_js_1.clsString.Format("{0},", strKey);
                //拿到所有含u-的key
                var objCacheUseState = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
                objCacheUseState.cacheKey = strKey;
                objCacheUseState.userId = CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static;
                objCacheUseState.cacheModeId = clsCacheModeEN_js_1.enumCacheMode.ClientCache_02;
                myCache = CacheHelper_js_1.CacheHelper.Get(strKey);
                if (myCache == null) {
                    objCacheUseState.cacheSize = 0;
                }
                else {
                    objCacheUseState.cacheSize = this.getBytes(myCache);
                }
                const conAdd = await (0, clsCacheUseStateWApi_js_1.CacheUseState_AddNewRecordAsync)(objCacheUseState);
            }
            (0, clsCacheUseStateWApi_js_1.CacheUseState_ReFreshCache)(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
            const gvResult = await this.BindGv_vCacheUseState_Cache();
            const gvResult2 = await this.Subtotals();
            alert(strCacheKeyLst);
            console.log('strCacheKeyLst:', strCacheKeyLst);
        }
        async Subtotals() {
            var arrvCacheUseStateObjLst = await (0, clsvCacheUseStateWApi_js_1.vCacheUseState_GetObjLst_Cache)(clsPubSessionStorage_js_1.clsPubSessionStorage.GetSession_UserId());
            var arrCacheMode = await (0, clsCacheModeWApi_js_1.CacheMode_GetObjLst_Cache)();
            arrCacheMode.forEach(x => {
                var arr_Sel = arrvCacheUseStateObjLst.filter(y => y.cacheModeId == x.cacheModeId);
                var intTotals = 0;
                if (arr_Sel.length > 0) {
                    var data = arr_Sel.map(z => z.cacheSize);
                    data.forEach(d => intTotals += d);
                    //                arr_Sel.reduce((intTotals, item) => intTotals + item.cacheSize, 0);
                    intTotals = intTotals / 1024;
                    if (x.cacheModeId == clsCacheModeEN_js_1.enumCacheMode.localStorage_03 || x.cacheModeId == clsCacheModeEN_js_1.enumCacheMode.sessionStorage_04) {
                        var fltPercent = (intTotals * 100) / (1024 * 5);
                        x.memo = clsString2_js_1.clsString.Format("{0}KB, 占 {1} %", intTotals.toFixed(2), fltPercent.toFixed(2));
                    }
                    else {
                        x.memo = clsString2_js_1.clsString.Format("{0}KB", intTotals.toFixed(2));
                    }
                }
                if (intTotals > 0) {
                    switch (x.cacheModeId) {
                        case clsCacheModeEN_js_1.enumCacheMode.ClientCache_02:
                            var txtClientCache = document.getElementById('txtClientCache');
                            if (txtClientCache != null) {
                                txtClientCache.value = x.memo;
                            }
                            break;
                        case clsCacheModeEN_js_1.enumCacheMode.localStorage_03:
                            var txtlocalStorage = document.getElementById('txtlocalStorage');
                            if (txtlocalStorage != null) {
                                txtlocalStorage.value = x.memo;
                            }
                            break;
                        case clsCacheModeEN_js_1.enumCacheMode.sessionStorage_04:
                            var txtsessionStorage = document.getElementById('txtsessionStorage');
                            if (txtsessionStorage != null) {
                                txtsessionStorage.value = x.memo;
                            }
                            break;
                    }
                }
            });
        }
        ClearLocalStorage() {
            var arrCacheKeyLst = new Array();
            for (var i = 0; i < localStorage.length; i++) {
                var strKey = localStorage.key(i);
                if (strKey != null) {
                    arrCacheKeyLst.push(strKey);
                }
                //拿到所有含u-的key
            }
            //        alert(strCacheKeyLst);
            arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
        }
    }
    exports.CacheUseStateCRUDEx = CacheUseStateCRUDEx;
});
