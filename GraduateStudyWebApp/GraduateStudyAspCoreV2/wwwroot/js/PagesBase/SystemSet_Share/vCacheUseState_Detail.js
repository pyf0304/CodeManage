(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "../../TS/L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js", "../../TS/PubFun/clsCommFunc4Web.js", "../../TS/L3_ForWApiEx/SystemSet_Share/clsCacheUseStateExWApi.js", "../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateENEx.js", "../../TS/PubFun/clsCommFunc4Ctrl.js", "../../TS/PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCacheUseState_Detail = void 0;
    /**
    * 类名:vCacheUseState_Detail(界面:CacheUseStateCRUD)
    * 表名:CacheUseState(00050566)
    * 版本:2022.12.12.1(服务器:WIN-SRV103-116)
    * 日期:2022/12/13 05:51:10
    * 生成者:
    工程名称:AGC(0005)
    CM工程:AgcSpa前端(变量首字母小写)-WebApi函数集
    * 相关数据库:103.116.76.183,9433AGC_CS12
    * PrjDataBaseId:0005
    * 模块中文名:系统设置(SystemSet)
    * 框架-层名:WA_详细信息后台_TS(TS)(WA_ViewScript_DetailCS_TS)
    * 编程语言:TypeScript
    **/
    //import $ from "jquery";
    const clsCacheUseStateWApi_js_1 = require("../../TS/L3_ForWApi/SystemSet_Share/clsCacheUseStateWApi.js");
    const clsCommFunc4Web_js_1 = require("../../TS/PubFun/clsCommFunc4Web.js");
    const clsCacheUseStateExWApi_js_1 = require("../../TS/L3_ForWApiEx/SystemSet_Share/clsCacheUseStateExWApi.js");
    const clsCacheUseStateENEx_js_1 = require("../../TS/L0_Entity/SystemSet_Share/clsCacheUseStateENEx.js");
    const clsCommFunc4Ctrl_js_1 = require("../../TS/PubFun/clsCommFunc4Ctrl.js");
    const clsString_js_1 = require("../../TS/PubFun/clsString.js");
    /* vCacheUseState_Detail 的摘要说明。其中Q代表查询,U代表修改
     (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:GeneCode)
   */
    class vCacheUseState_Detail {
        constructor(objShowList) {
            this.opType = "";
            this.keyId = "";
            this.mstrListDiv = "divDataLst";
            this.bolIsLoadDetailRegion = false; //记录是否导入编辑区的变量
            this.divName4Detail = "divDetail"; //编辑区的Id
            this.iShowList = objShowList;
        }
        /// <summary>
        /// 在当前界面中，导入编辑区域
        /// (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_AddDPV_Detail)
        /// </summary>
        /// <returns></returns>
        async AddDPV_Detail(divName4Detail) {
            const strThisFuncName = this.AddDPV_Detail.name;
            const strUrl = "./vCacheUseState_Detail/";
            console.log("divName4Detail:(In AddDPV_Detail)" + divName4Detail);
            return new Promise(function (resolve, reject) {
                $.ajax({
                    url: strUrl,
                    method: "GET",
                    dataType: "html",
                    data: {},
                    success: function (data) {
                        console.log("已经成功获取页面:" + strUrl + "  字节数: " + data.length.toString());
                        $('#' + divName4Detail).html(data);
                        resolve(true);
                        //setTimeout(() => { clsDetailObj.BindTab(); }, 100);
                        //clsDetailObj.BindTab();
                    },
                    error: (e) => {
                        console.error(e);
                        reject(e);
                    }
                });
            });
        }
        /**
         显示对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_ShowDialog)
        **/
        ShowDialog_CacheUseState(strOp) {
            const strThisFuncName = this.ShowDialog_CacheUseState.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_CacheUseState");
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "h4", "lblDialogTitle_CacheUseState");
            if (strOp === "Add" || strOp === "AddWithMaxId") {
                $('#lblDialogTitle_CacheUseState').html('添加记录');
                //vCacheUseState_DetailEx.GetMaxStrId('#txtmId');
            }
            else if (strOp === "Update") {
                $('#lblDialogTitle_CacheUseState').html('修改记录');
            }
            else if (strOp === "Detail") {
                $('#btnSubmit_CacheUseState').hide();
                $('#lblDialogTitle_CacheUseState').html('详细信息');
            }
            ShowDialog('#divDetailDialog_CacheUseState');
        }
        /**
         隐藏对话框
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_TS_HideDialog)
        **/
        HideDialog_CacheUseState() {
            const strThisFuncName = this.HideDialog_CacheUseState.name;
            (0, clsCommFunc4Ctrl_js_1.CheckControlExist)(this.divName4Detail, "div", "divDetailDialog_CacheUseState");
            HideDialog('#divDetailDialog_CacheUseState');
        }
        /*
        在数据表里详细信息记录
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecordInTab_Click)
       */
        async btnDetailRecordInTab_Click(strKeyId) {
            const strThisFuncName = this.btnDetailRecordInTab_Click.name;
            this.opType = "Detail";
            try {
                if (strKeyId == "") {
                    alert("请选择需要详细信息的记录！");
                    return "";
                }
                const lngKeyId = Number(strKeyId);
                this.DetailRecord4Func(lngKeyId);
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("详细信息记录不成功. {0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /*
        根据关键字详细信息记录
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_DetailRecord4Func)
         <param name = "sender">参数列表</param>
       */
        async DetailRecord4Func(lngmId) {
            const strThisFuncName = this.DetailRecord4Func.name;
            this.btnCancel_d_CacheUseState = "关闭";
            try {
                const objCacheUseStateEN = await (0, clsCacheUseStateWApi_js_1.CacheUseState_GetObjBymIdAsync)(lngmId);
                const objCacheUseStateENEx = new clsCacheUseStateENEx_js_1.clsCacheUseStateENEx();
                (0, clsCommFunc4Web_js_1.ObjectAssign)(objCacheUseStateENEx, objCacheUseStateEN);
                await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_FuncMapByFldName)(clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeId, objCacheUseStateENEx);
                await (0, clsCacheUseStateExWApi_js_1.CacheUseStateEx_FuncMapByFldName)(clsCacheUseStateENEx_js_1.clsCacheUseStateENEx.con_CacheModeId, objCacheUseStateENEx);
                this.ShowDetailDataFromCacheUseStateClass4Func(objCacheUseStateENEx);
                console.log("完成DetailRecord4Func!");
            }
            catch (e) {
                const strMsg = (0, clsString_js_1.Format)("显示详细信息4Func不成功,{0}.(in {1}.{2})", e, this.constructor.name, strThisFuncName);
                console.error(strMsg);
                alert(strMsg);
            }
        }
        /* 修改记录
        (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_btnDetailRecord_Click)
       */
        async btnDetailRecord_Click(strKeyId) {
            const strThisFuncName = this.btnDetailRecord_Click.name;
            this.opType = "Detail";
            if ((0, clsString_js_1.IsNullOrEmpty)(strKeyId) == true) {
                const strMsg = "需要显示详细信息记录的关键字为空，请检查！";
                console.error(strMsg);
                alert(strMsg);
            }
            if (this.bolIsLoadDetailRegion == false) //
             {
                const responseBool = await this.AddDPV_Detail(this.divName4Detail);
                // 为编辑区绑定下拉框
                //const conBindDdl = await this.BindDdl4DetailRegion();
                this.bolIsLoadDetailRegion = true; //
                const lngKeyId = Number(strKeyId);
                this.DetailRecord4Func(lngKeyId);
                this.ShowDialog_CacheUseState('Detail');
            }
            else {
                const lngKeyId = Number(strKeyId);
                this.DetailRecord4Func(lngKeyId);
                this.ShowDialog_CacheUseState('Detail');
            }
        }
        /* 函数功能:把类对象的属性内容显示到界面的详细信息区域中
         (AutoGCLib.WA_ViewScript_DetailCS_TS4TypeScript:Gen_WApi_Ts_ShowDetailDataFromClass4Func)
         <param name = "pobjCacheUseStateEN">表实体类对象</param>
       */
        ShowDetailDataFromCacheUseStateClass4Func(pobjCacheUseStateENEx) {
            const strThisFuncName = this.ShowDetailDataFromCacheUseStateClass4Func.name;
            this.userId_d = pobjCacheUseStateENEx.userId; // 用户Id
            this.cacheKey_d = pobjCacheUseStateENEx.cacheKey; // 缓存关键字
            this.cacheSize_d = pobjCacheUseStateENEx.cacheSize; // 缓存大小
            this.memo_d = pobjCacheUseStateENEx.memo; // 说明
            this.cacheModeName_d = pobjCacheUseStateENEx.cacheModeName; // 缓存方式
            this.cacheModeENName_d = pobjCacheUseStateENEx.cacheModeENName; // 缓存方式英文名
        }
        /**
        * 设置取消按钮的标题(Used In DetailRecord())
        **/
        set btnCancel_d_CacheUseState(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnCancel_d_CacheUseState", value);
        }
        /**
        * 设置确定按钮的标题(Used In DetailRecord())
        **/
        set btnSubmit_d_CacheUseState(value) {
            (0, clsCommFunc4Ctrl_js_1.SetButtonHtmlByIdInDiv)(this.divName4Detail, "btnSubmit_d_CacheUseState", value);
        }
        /**
        * 缓存关键字 (Used In ShowDetailDataFromClass4Func())
        **/
        set cacheKey_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblCacheKey_d", value);
        }
        /**
        * 缓存方式Id (Used In ShowDetailDataFromClass4Func())
        **/
        set cacheModeENName_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblCacheModeENName_d", value);
        }
        /**
        * 缓存方式Id (Used In ShowDetailDataFromClass4Func())
        **/
        set cacheModeName_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblCacheModeName_d", value);
        }
        /**
        * 缓存大小 (Used In ShowDetailDataFromClass4Func())
        **/
        set cacheSize_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblCacheSize_d", value.toString());
        }
        /**
        * 说明 (Used In ShowDetailDataFromClass4Func())
        **/
        set memo_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblMemo_d", value);
        }
        /**
        * 用户Id (Used In ShowDetailDataFromClass4Func())
        **/
        set userId_d(value) {
            (0, clsCommFunc4Ctrl_js_1.SetLabelHtmlByIdInDiv)(this.divName4Detail, "lblUserId_d", value);
        }
    }
    exports.vCacheUseState_Detail = vCacheUseState_Detail;
    vCacheUseState_Detail.UserId_Cache = ""; //缓存分类字段1
    vCacheUseState_Detail.UserId_Static = "0";
});
