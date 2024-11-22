///// <reference path="../../scripts/typings/jquery/jquery.d.ts" />
///// <reference path="../../scripts/typings/q/q.d.ts" />
///// <reference path="../../scripts/typings/handlebars/handlebars.d.ts" />
//import * as $ from "jquery";
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../TS/L3_ForWApiEx/SystemSet_Share/clsCacheUseStateExWApi.js", "../TS/PubFun/clsCommFunc4Ctrl.js", "../TS/PubFun/clsString.js", "../PagesBase/SystemSet_Share/CacheUseStateCRUD.js", "./CacheUseState_EditEx.js", "../TS/PubFun/clsPublocalStorage.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseStateCRUDEx = void 0;
    const clsCacheUseStateExWApi_js_1 = require("../TS/L3_ForWApiEx/SystemSet_Share/clsCacheUseStateExWApi.js");
    const clsCommFunc4Ctrl_js_1 = require("../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../TS/PubFun/clsString.js");
    const CacheUseStateCRUD_js_1 = require("../PagesBase/SystemSet_Share/CacheUseStateCRUD.js");
    const CacheUseState_EditEx_js_1 = require("./CacheUseState_EditEx.js");
    const clsPublocalStorage_js_1 = require("../TS/PubFun/clsPublocalStorage.js");
    /** CacheUseStateCRUDEx 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScriptCSEx_TS4TypeScript:GeneCode)
    */
    class CacheUseStateCRUDEx extends CacheUseStateCRUD_js_1.CacheUseStateCRUD {
        //public static mstrListDiv=  "divDataLst";
        //public static mstrSortvCacheUseStateBy=  "mId";
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
            const objPage = new CacheUseStateCRUDEx();
            const objPage_Edit = new CacheUseState_EditEx_js_1.CacheUseState_EditEx(objPage);
            let strMsg = "";
            switch (strCommandName) {
                case "GetCacheUseState": //查询记录
                    objPage.GetCacheUseState();
                    break;
                case "ClearLocalStorage": //查询记录
                    objPage.ClearLocalStorage();
                    break;
                case "ClearSessionStorage": //查询记录
                    objPage.ClearSessionStorage();
                    break;
                case "Query": //查询记录
                    objPage.btnQuery_Click();
                    break;
                case "AddNewRecordWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "CreateWithMaxId": //添加记录使用最大关键字
                    //objPage_Edit.btnAddNewRecordWithMaxId_Click();
                    break;
                case "AddNewRecord": //添加记录
                case "Create": //添加记录
                    objPage_Edit.btnAddNewRecord_Click();
                    break;
                case "UpdateRecord": //修改记录
                case "Update": //修改记录
                    strKeyId = (0, clsCommFunc4Ctrl_js_1.GetFirstCheckedKeyIdInDiv)(objPage.divName4List);
                    if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                        strMsg = "请选择需要修改的记录！";
                        console.error(strMsg);
                        alert(strMsg);
                        return;
                    }
                    objPage_Edit.btnUpdateRecord_Click(strKeyId);
                    break;
                case "CopyRecord": //复制记录
                case "Clone": //复制记录
                    //objPage.btnCopyRecord_Click();
                    break;
                case "DelRecord": //删除记录
                case "Delete": //删除记录
                    objPage.btnDelRecord_Click();
                    break;
                case "DelRecordBySign": //按标志删除记录
                case "DeleteBySign": //按标志删除记录
                    //objPage.btnDelRecordBySign_Click();
                    break;
                case "UnDelRecordBySign": //按标志恢复删除记录
                case "UnDeleteBySign": //按标志恢复删除记录
                    //objPage.btnUnDelRecordBySign_Click();
                    break;
                case "GoTop": //置顶记录
                    //objPage.btnGoTop_Click();
                    break;
                case "GoBottum": //移底记录
                    //objPage.btnGoBottum_Click();
                    break;
                case "UpMove": //上移记录
                    //objPage.btnUpMove_Click();
                    break;
                case "DownMove": //下移记录
                    //objPage.btnDownMove_Click();
                    break;
                case "ReOrder": //重序记录
                    //objPage.btnReOrder_Click();
                    break;
                default:
                    strMsg = '命令:' + strCommandName + "在函数(CacheUseStateCRUDEx.btn_Click)中没有被处理！";
                    alert(strMsg);
                    break;
                case "ExportExcel": //导出Excel
                    alert("导出Excel功能还没有开通！");
                    break;
            }
        }
        BindGv(strType, strPara) {
            alert('该类没有绑定该函数：[this.BindGv_vCacheUseState]！');
            //this.BindGv_vCacheUseState();
        }
        BindGv_Cache(strType, strPara) {
            let strMsg = "";
            switch (strType) {
                case "vCacheUseState":
                    this.BindGv_CacheUseState4Func();
                    break;
                default:
                    strMsg = (0, clsString_js_1.Format)("类型(strType):{0}在BindGv_Cache函数的switch中没有被处理！", strType);
                    console.error(strMsg);
                    alert(strMsg);
                    break;
            }
        }
        /** 函数功能:页面导入,当页面开始运行时所发生的事件
     (AutoGCLib.WA_ViewScriptCS_TS4TypeScript:Gen_WApi_Ts_Page_Load_Cache)
    */
        async Page_Load_Cache() {
            const strThisFuncName = this.Page_Load_Cache.name;
            // 在此处放置用户代码以初始化页面
            try {
                CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Cache = clsPublocalStorage_js_1.clsPublocalStorage.userId;
                // 为查询区绑定下拉框
                const gvBindDdl = await this.BindDdl4QueryRegion();
                if (this.bolIsInitShow == false) //
                 {
                    this.objPager.InitShow(this.divName4Pager);
                    this.bolIsInitShow = true; //
                }
                CacheUseStateCRUD_js_1.CacheUseStateCRUD.sortCacheUseStateBy = "mId Asc";
                //2、显示无条件的表内容在GridView中
                const gvResult = await this.BindGv_CacheUseState4Func();
                const gvResult2 = await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_Subtotals)(clsPublocalStorage_js_1.clsPublocalStorage.userId);
            }
            catch (e) {
                const strMsg = `页面启动不成功,${e}.(in ${this.constructor.name}.${strThisFuncName})`;
                alert(strMsg);
            }
        }
        async GetCacheUseState() {
            const con1 = await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_GetCacheUseState)(CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static);
            const gvResult = await this.BindGv_CacheUseState4Func();
            const gvResult2 = await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_Subtotals)(CacheUseStateCRUD_js_1.CacheUseStateCRUD.UserId_Static);
        }
        ClearLocalStorage() {
            const con1 = (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_ClearLocalStorage)();
        }
        ClearSessionStorage() {
            const con1 = (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_ClearSessionStorage)();
        }
    }
    exports.CacheUseStateCRUDEx = CacheUseStateCRUDEx;
});
