/**
* 类名:clsvViewpointAppraiseWApi
* 表名:vViewpointAppraise(01120610)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:59
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
* 框架-层名:WA_访问层(TS)(WA_Access)
* 编程语言:TypeScript
* 注意:1、需要数据底层(PubDataBase.dll)的版本:2019.03.07.01
  *      2、需要公共函数层(TzPubFunction.dll)的版本:2017.12.21.01
**/
var __importDefault = (this && this.__importDefault) || function (mod) {
    return (mod && mod.__esModule) ? mod : { "default": mod };
};
(function (factory) {
    if (typeof module === "object" && typeof module.exports === "object") {
        var v = factory(require, exports);
        if (v !== undefined) module.exports = v;
    }
    else if (typeof define === "function" && define.amd) {
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvViewpointAppraiseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vViewpointAppraise_GetObjFromJsonObj = exports.vViewpointAppraise_CopyObjTo = exports.vViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId = exports.vViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId = exports.vViewpointAppraise_GetCombineCondition = exports.vViewpointAppraise_GetObjByJSONStr = exports.vViewpointAppraise_GetObjLstByJSONObjLst = exports.vViewpointAppraise_GetObjLstByJSONStr = exports.vViewpointAppraise_GetJSONStrByObj = exports.vViewpointAppraise_ReFreshThisCache = exports.vViewpointAppraise_GetWebApiUrl = exports.vViewpointAppraise_GetRecCountByCond_Cache = exports.vViewpointAppraise_GetRecCountByCondAsync = exports.vViewpointAppraise_IsExistAsync = exports.vViewpointAppraise_IsExist_Cache = exports.vViewpointAppraise_IsExist = exports.vViewpointAppraise_IsExistRecordAsync = exports.vViewpointAppraise_IsExistRecord_Cache = exports.vViewpointAppraise_GetObjLstByPagerAsync = exports.vViewpointAppraise_GetObjLstByPager_Cache = exports.vViewpointAppraise_GetObjLstByRange = exports.vViewpointAppraise_GetObjLstByRangeAsync = exports.vViewpointAppraise_GetTopObjLstAsync = exports.vViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache = exports.vViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync = exports.vViewpointAppraise_GetSubObjLst_Cache = exports.vViewpointAppraise_GetObjLst_PureCache = exports.vViewpointAppraise_GetObjLst_Cache = exports.vViewpointAppraise_GetObjLst_sessionStorage_PureCache = exports.vViewpointAppraise_GetObjLst_sessionStorage = exports.vViewpointAppraise_GetObjLstAsync = exports.vViewpointAppraise_GetObjLst_localStorage_PureCache = exports.vViewpointAppraise_GetObjLst_localStorage = exports.vViewpointAppraise_GetObjLst_ClientCache = exports.vViewpointAppraise_GetFirstObjAsync = exports.vViewpointAppraise_GetFirstID = exports.vViewpointAppraise_GetFirstIDAsync = exports.vViewpointAppraise_funcKey = exports.vViewpointAppraise_FilterFunByKey = exports.vViewpointAppraise_SortFunByKey = exports.vViewpointAppraise_SortFun_Defa_2Fld = exports.vViewpointAppraise_SortFun_Defa = exports.vViewpointAppraise_func = exports.vViewpointAppraise_GetObjByViewpointAppraiseId_localStorage = exports.vViewpointAppraise_GetObjByViewpointAppraiseId_Cache = exports.vViewpointAppraise_GetObjByViewpointAppraiseIdAsync = exports.vViewpointAppraise_ConstructorName = exports.vViewpointAppraise_Controller = void 0;
    /**
     * vViewpointAppraise(vViewpointAppraise)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvViewpointAppraiseEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvViewpointAppraiseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vViewpointAppraise_Controller = "vViewpointAppraiseApi";
    exports.vViewpointAppraise_ConstructorName = "vViewpointAppraise";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngViewpointAppraiseId:关键字
    * @returns 对象
    **/
    async function vViewpointAppraise_GetObjByViewpointAppraiseIdAsync(lngViewpointAppraiseId) {
        const strThisFuncName = "GetObjByViewpointAppraiseIdAsync";
        if (lngViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAppraiseId]不能为空！(In clsvViewpointAppraiseWApi.GetObjByViewpointAppraiseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointAppraiseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngViewpointAppraiseId": lngViewpointAppraiseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvViewpointAppraise = vViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objvViewpointAppraise;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetObjByViewpointAppraiseIdAsync = vViewpointAppraise_GetObjByViewpointAppraiseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function vViewpointAppraise_GetObjByViewpointAppraiseId_Cache(lngViewpointAppraiseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByViewpointAppraiseId_Cache";
        if (lngViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAppraiseId]不能为空！(In clsvViewpointAppraiseWApi.GetObjByViewpointAppraiseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
        try {
            const arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache.filter(x => x.viewpointAppraiseId == lngViewpointAppraiseId);
            let objvViewpointAppraise;
            if (arrvViewpointAppraise_Sel.length > 0) {
                objvViewpointAppraise = arrvViewpointAppraise_Sel[0];
                return objvViewpointAppraise;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvViewpointAppraise_Const = await vViewpointAppraise_GetObjByViewpointAppraiseIdAsync(lngViewpointAppraiseId);
                    if (objvViewpointAppraise_Const != null) {
                        vViewpointAppraise_ReFreshThisCache();
                        return objvViewpointAppraise_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAppraiseId, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vViewpointAppraise_GetObjByViewpointAppraiseId_Cache = vViewpointAppraise_GetObjByViewpointAppraiseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function vViewpointAppraise_GetObjByViewpointAppraiseId_localStorage(lngViewpointAppraiseId) {
        const strThisFuncName = "GetObjByViewpointAppraiseId_localStorage";
        if (lngViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngViewpointAppraiseId]不能为空！(In clsvViewpointAppraiseWApi.GetObjByViewpointAppraiseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName, lngViewpointAppraiseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvViewpointAppraise_Cache = JSON.parse(strTempObj);
            return objvViewpointAppraise_Cache;
        }
        try {
            const objvViewpointAppraise = await vViewpointAppraise_GetObjByViewpointAppraiseIdAsync(lngViewpointAppraiseId);
            if (objvViewpointAppraise != null) {
                localStorage.setItem(strKey, JSON.stringify(objvViewpointAppraise));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvViewpointAppraise;
            }
            return objvViewpointAppraise;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngViewpointAppraiseId, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vViewpointAppraise_GetObjByViewpointAppraiseId_localStorage = vViewpointAppraise_GetObjByViewpointAppraiseId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vViewpointAppraise_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngViewpointAppraiseId = Number(strInValue);
        if (lngViewpointAppraiseId == 0) {
            return "";
        }
        const objvViewpointAppraise = await vViewpointAppraise_GetObjByViewpointAppraiseId_Cache(lngViewpointAppraiseId);
        if (objvViewpointAppraise == null)
            return "";
        if (objvViewpointAppraise.GetFldValue(strOutFldName) == null)
            return "";
        return objvViewpointAppraise.GetFldValue(strOutFldName).toString();
    }
    exports.vViewpointAppraise_func = vViewpointAppraise_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointAppraise_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointAppraiseId - b.viewpointAppraiseId;
    }
    exports.vViewpointAppraise_SortFun_Defa = vViewpointAppraise_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointAppraise_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userName == b.userName)
            return a.viewpointId.localeCompare(b.viewpointId);
        else
            return a.userName.localeCompare(b.userName);
    }
    exports.vViewpointAppraise_SortFun_Defa_2Fld = vViewpointAppraise_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vViewpointAppraise_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId:
                    return (a, b) => {
                        return a.viewpointAppraiseId - b.viewpointAppraiseId;
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointId:
                    return (a, b) => {
                        if (a.viewpointId == null)
                            return -1;
                        if (b.viewpointId == null)
                            return 1;
                        return a.viewpointId.localeCompare(b.viewpointId);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        if (a.appraiseContent == null)
                            return -1;
                        if (b.appraiseContent == null)
                            return 1;
                        return a.appraiseContent.localeCompare(b.appraiseContent);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointName:
                    return (a, b) => {
                        if (a.viewpointName == null)
                            return -1;
                        if (b.viewpointName == null)
                            return 1;
                        return a.viewpointName.localeCompare(b.viewpointName);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointContent:
                    return (a, b) => {
                        if (a.viewpointContent == null)
                            return -1;
                        if (b.viewpointContent == null)
                            return 1;
                        return a.viewpointContent.localeCompare(b.viewpointContent);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Reason:
                    return (a, b) => {
                        if (a.reason == null)
                            return -1;
                        if (b.reason == null)
                            return 1;
                        return a.reason.localeCompare(b.reason);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vViewpointAppraise]中不存在！(in ${exports.vViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId:
                    return (a, b) => {
                        return b.viewpointAppraiseId - a.viewpointAppraiseId;
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointId:
                    return (a, b) => {
                        if (b.viewpointId == null)
                            return -1;
                        if (a.viewpointId == null)
                            return 1;
                        return b.viewpointId.localeCompare(a.viewpointId);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        if (b.appraiseContent == null)
                            return -1;
                        if (a.appraiseContent == null)
                            return 1;
                        return b.appraiseContent.localeCompare(a.appraiseContent);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointName:
                    return (a, b) => {
                        if (b.viewpointName == null)
                            return -1;
                        if (a.viewpointName == null)
                            return 1;
                        return b.viewpointName.localeCompare(a.viewpointName);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointContent:
                    return (a, b) => {
                        if (b.viewpointContent == null)
                            return -1;
                        if (a.viewpointContent == null)
                            return 1;
                        return b.viewpointContent.localeCompare(a.viewpointContent);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Reason:
                    return (a, b) => {
                        if (b.reason == null)
                            return -1;
                        if (a.reason == null)
                            return 1;
                        return b.reason.localeCompare(a.reason);
                    };
                case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vViewpointAppraise]中不存在！(in ${exports.vViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vViewpointAppraise_SortFunByKey = vViewpointAppraise_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vViewpointAppraise_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId:
                return (obj) => {
                    return obj.viewpointAppraiseId === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointId:
                return (obj) => {
                    return obj.viewpointId === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_AppraiseContent:
                return (obj) => {
                    return obj.appraiseContent === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointName:
                return (obj) => {
                    return obj.viewpointName === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointContent:
                return (obj) => {
                    return obj.viewpointContent === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Reason:
                return (obj) => {
                    return obj.reason === value;
                };
            case clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vViewpointAppraise]中不存在！(in ${exports.vViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vViewpointAppraise_FilterFunByKey = vViewpointAppraise_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vViewpointAppraise_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvViewpointAppraise = await vViewpointAppraise_GetObjLst_Cache();
        if (arrvViewpointAppraise == null)
            return [];
        let arrvViewpointAppraise_Sel = arrvViewpointAppraise;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvViewpointAppraise_Sel.length == 0)
            return [];
        return arrvViewpointAppraise_Sel.map(x => x.viewpointAppraiseId);
    }
    exports.vViewpointAppraise_funcKey = vViewpointAppraise_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vViewpointAppraise_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnStr;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetFirstIDAsync = vViewpointAppraise_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vViewpointAppraise_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetFirstID = vViewpointAppraise_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vViewpointAppraise_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvViewpointAppraise = vViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objvViewpointAppraise;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetFirstObjAsync = vViewpointAppraise_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvViewpointAppraiseExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvViewpointAppraiseObjLst_T = vViewpointAppraise_GetObjLstByJSONObjLst(arrvViewpointAppraiseExObjLst_Cache);
            return arrvViewpointAppraiseObjLst_T;
        }
        try {
            const arrvViewpointAppraiseExObjLst = await vViewpointAppraise_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvViewpointAppraiseExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrvViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vViewpointAppraise_GetObjLst_ClientCache = vViewpointAppraise_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvViewpointAppraiseObjLst_T = vViewpointAppraise_GetObjLstByJSONObjLst(arrvViewpointAppraiseExObjLst_Cache);
            return arrvViewpointAppraiseObjLst_T;
        }
        try {
            const arrvViewpointAppraiseExObjLst = await vViewpointAppraise_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrvViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vViewpointAppraise_GetObjLst_localStorage = vViewpointAppraise_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.vViewpointAppraise_GetObjLst_localStorage_PureCache = vViewpointAppraise_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vViewpointAppraise_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetObjLstAsync = vViewpointAppraise_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvViewpointAppraiseObjLst_T = vViewpointAppraise_GetObjLstByJSONObjLst(arrvViewpointAppraiseExObjLst_Cache);
            return arrvViewpointAppraiseObjLst_T;
        }
        try {
            const arrvViewpointAppraiseExObjLst = await vViewpointAppraise_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrvViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vViewpointAppraise_GetObjLst_sessionStorage = vViewpointAppraise_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.vViewpointAppraise_GetObjLst_sessionStorage_PureCache = vViewpointAppraise_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvViewpointAppraiseObjLst_Cache;
        switch (clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_ClientCache();
                break;
            default:
                arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_ClientCache();
                break;
        }
        const arrvViewpointAppraiseObjLst = vViewpointAppraise_GetObjLstByJSONObjLst(arrvViewpointAppraiseObjLst_Cache);
        return arrvViewpointAppraiseObjLst_Cache;
    }
    exports.vViewpointAppraise_GetObjLst_Cache = vViewpointAppraise_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vViewpointAppraise_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvViewpointAppraiseObjLst_Cache;
        switch (clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvViewpointAppraiseObjLst_Cache = null;
                break;
            default:
                arrvViewpointAppraiseObjLst_Cache = null;
                break;
        }
        return arrvViewpointAppraiseObjLst_Cache;
    }
    exports.vViewpointAppraise_GetObjLst_PureCache = vViewpointAppraise_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vViewpointAppraise_GetSubObjLst_Cache(objvViewpointAppraise_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
        let arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache;
        if (objvViewpointAppraise_Cond.sf_FldComparisonOp == null || objvViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrvViewpointAppraise_Sel;
        const dicFldComparisonOp = JSON.parse(objvViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsvViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvViewpointAppraise_Cond), exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vViewpointAppraise_GetSubObjLst_Cache = vViewpointAppraise_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointAppraiseId:关键字列表
    * @returns 对象列表
    **/
    async function vViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync(arrViewpointAppraiseId) {
        const strThisFuncName = "GetObjLstByViewpointAppraiseIdLstAsync";
        const strAction = "GetObjLstByViewpointAppraiseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointAppraiseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync = vViewpointAppraise_GetObjLstByViewpointAppraiseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngViewpointAppraiseIdLst:关键字列表
     * @returns 对象列表
    */
    async function vViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache(arrViewpointAppraiseIdLst) {
        const strThisFuncName = "GetObjLstByViewpointAppraiseIdLst_Cache";
        try {
            const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
            const arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache.filter(x => arrViewpointAppraiseIdLst.indexOf(x.viewpointAppraiseId) > -1);
            return arrvViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointAppraiseIdLst.join(","), exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache = vViewpointAppraise_GetObjLstByViewpointAppraiseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vViewpointAppraise_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
                return (arrObjLst);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetTopObjLstAsync = vViewpointAppraise_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vViewpointAppraise_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetObjLstByRangeAsync = vViewpointAppraise_GetObjLstByRangeAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRange)
     * @param intMinNum:最小记录号
     * @param intMaxNum:最大记录号
     * @param strWhereCond:给定条件
     * @param strOrderBy:排序方式
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取的相应记录对象列表
    */
    async function vViewpointAppraise_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "intMinNum": intMinNum,
                    "intMaxNum": intMaxNum,
                    "strWhereCond": strWhereCond,
                    "strOrderBy": strOrderBy,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetObjLstByRange = vViewpointAppraise_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vViewpointAppraise_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
        if (arrvViewpointAppraiseObjLst_Cache.length == 0)
            return arrvViewpointAppraiseObjLst_Cache;
        let arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvViewpointAppraise_Cond = new clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvViewpointAppraise_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvViewpointAppraiseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvViewpointAppraise_Sel.length == 0)
                return arrvViewpointAppraise_Sel;
            let intStart = objPagerPara.pageSize * (objPagerPara.pageIndex - 1);
            if (intStart <= 0)
                intStart = 0;
            const intEnd = intStart + objPagerPara.pageSize;
            if (objPagerPara.orderBy != null && objPagerPara.orderBy.length > 0) {
                const sstrSplit = objPagerPara.orderBy.split(" ");
                let strSortType = "asc";
                const strSortFld = sstrSplit[0];
                if (sstrSplit.length > 1)
                    strSortType = sstrSplit[1];
                arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.sort(vViewpointAppraise_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.sort(objPagerPara.sortFun);
            }
            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.slice(intStart, intEnd);
            return arrvViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vViewpointAppraise_GetObjLstByPager_Cache = vViewpointAppraise_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vViewpointAppraise_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
                return arrObjLst;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetObjLstByPagerAsync = vViewpointAppraise_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vViewpointAppraise_IsExistRecord_Cache(objvViewpointAppraise_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
        if (arrvViewpointAppraiseObjLst_Cache == null)
            return false;
        let arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache;
        if (objvViewpointAppraise_Cond.sf_FldComparisonOp == null || objvViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrvViewpointAppraise_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsvViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvViewpointAppraise_Cond), exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vViewpointAppraise_IsExistRecord_Cache = vViewpointAppraise_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vViewpointAppraise_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnBool;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_IsExistRecordAsync = vViewpointAppraise_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngViewpointAppraiseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vViewpointAppraise_IsExist(lngViewpointAppraiseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointAppraiseId": lngViewpointAppraiseId,
                }
            });
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_IsExist = vViewpointAppraise_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function vViewpointAppraise_IsExist_Cache(lngViewpointAppraiseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
        if (arrvViewpointAppraiseObjLst_Cache == null)
            return false;
        try {
            const arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache.filter(x => x.viewpointAppraiseId == lngViewpointAppraiseId);
            if (arrvViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngViewpointAppraiseId, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vViewpointAppraise_IsExist_Cache = vViewpointAppraise_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngViewpointAppraiseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vViewpointAppraise_IsExistAsync(lngViewpointAppraiseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngViewpointAppraiseId": lngViewpointAppraiseId }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return (data.returnBool);
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_IsExistAsync = vViewpointAppraise_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vViewpointAppraise_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw (data.errorMsg);
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vViewpointAppraise_GetRecCountByCondAsync = vViewpointAppraise_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvViewpointAppraise_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vViewpointAppraise_GetRecCountByCond_Cache(objvViewpointAppraise_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvViewpointAppraiseObjLst_Cache = await vViewpointAppraise_GetObjLst_Cache();
        if (arrvViewpointAppraiseObjLst_Cache == null)
            return 0;
        let arrvViewpointAppraise_Sel = arrvViewpointAppraiseObjLst_Cache;
        if (objvViewpointAppraise_Cond.sf_FldComparisonOp == null || objvViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrvViewpointAppraise_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsvViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvViewpointAppraise_Sel = arrvViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvViewpointAppraise_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvViewpointAppraise_Cond), exports.vViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vViewpointAppraise_GetRecCountByCond_Cache = vViewpointAppraise_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vViewpointAppraise_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_1.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.vViewpointAppraise_GetWebApiUrl = vViewpointAppraise_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vViewpointAppraise_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN._CurrTabName;
            switch (clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_1.CacheHelper.Remove(strKey);
                    break;
            }
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vViewpointAppraise_ReFreshThisCache = vViewpointAppraise_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vViewpointAppraise_GetJSONStrByObj(pobjvViewpointAppraiseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvViewpointAppraiseEN);
        }
        catch (objException) {
            const strEx = (0, clsCommFunc4Web_js_1.GetExceptionStr)(objException);
            (0, clsCommFunc4Web_js_1.myShowErrorMsg)(strEx);
        }
        if (strJson == undefined)
            return "";
        else
            return strJson;
    }
    exports.vViewpointAppraise_GetJSONStrByObj = vViewpointAppraise_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vViewpointAppraise_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvViewpointAppraiseObjLst = new Array();
        if (strJSON === "") {
            return arrvViewpointAppraiseObjLst;
        }
        try {
            arrvViewpointAppraiseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvViewpointAppraiseObjLst;
        }
        return arrvViewpointAppraiseObjLst;
    }
    exports.vViewpointAppraise_GetObjLstByJSONStr = vViewpointAppraise_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvViewpointAppraiseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vViewpointAppraise_GetObjLstByJSONObjLst(arrvViewpointAppraiseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvViewpointAppraiseObjLst = new Array();
        for (const objInFor of arrvViewpointAppraiseObjLstS) {
            const obj1 = vViewpointAppraise_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvViewpointAppraiseObjLst.push(obj1);
        }
        return arrvViewpointAppraiseObjLst;
    }
    exports.vViewpointAppraise_GetObjLstByJSONObjLst = vViewpointAppraise_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vViewpointAppraise_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvViewpointAppraiseEN = new clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN();
        if (strJSON === "") {
            return pobjvViewpointAppraiseEN;
        }
        try {
            pobjvViewpointAppraiseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvViewpointAppraiseEN;
        }
        return pobjvViewpointAppraiseEN;
    }
    exports.vViewpointAppraise_GetObjByJSONStr = vViewpointAppraise_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vViewpointAppraise_GetCombineCondition(objvViewpointAppraise_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UserName, objvViewpointAppraise_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId) == true) {
            const strComparisonOp_ViewpointAppraiseId = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointAppraiseId, objvViewpointAppraise_Cond.viewpointAppraiseId, strComparisonOp_ViewpointAppraiseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointId) == true) {
            const strComparisonOp_ViewpointId = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointId, objvViewpointAppraise_Cond.viewpointId, strComparisonOp_ViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_AppraiseContent) == true) {
            const strComparisonOp_AppraiseContent = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_AppraiseContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_AppraiseContent, objvViewpointAppraise_Cond.appraiseContent, strComparisonOp_AppraiseContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdDate, objvViewpointAppraise_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_Memo, objvViewpointAppraise_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointName) == true) {
            const strComparisonOp_ViewpointName = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_ViewpointName, objvViewpointAppraise_Cond.viewpointName, strComparisonOp_ViewpointName);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvViewpointAppraise_Cond.dicFldComparisonOp, clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvViewpointAppraise_Cond.dicFldComparisonOp[clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN.con_UpdUser, objvViewpointAppraise_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.vViewpointAppraise_GetCombineCondition = vViewpointAppraise_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vViewpointAppraise(vViewpointAppraise),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngViewpointAppraiseId: 观点评论Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId(objvViewpointAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.viewpointAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.viewpointId);
        return strWhereCond;
    }
    exports.vViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId = vViewpointAppraise_GetUniCondStr_ViewpointAppraiseId_ViewpointId;
    /**
    *获取唯一性条件串(Uniqueness)--vViewpointAppraise(vViewpointAppraise),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngViewpointAppraiseId: 观点评论Id(要求唯一的字段)
    * @param strViewpointId: 观点Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId(objvViewpointAppraiseEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAppraiseId <> '{0}'", objvViewpointAppraiseEN.viewpointAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointAppraiseId = '{0}'", objvViewpointAppraiseEN.viewpointAppraiseId);
        strWhereCond += (0, clsString_js_1.Format)(" and ViewpointId = '{0}'", objvViewpointAppraiseEN.viewpointId);
        return strWhereCond;
    }
    exports.vViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId = vViewpointAppraise_GetUniCondStr4Update_ViewpointAppraiseId_ViewpointId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvViewpointAppraiseENS:源对象
     * @param objvViewpointAppraiseENT:目标对象
    */
    function vViewpointAppraise_CopyObjTo(objvViewpointAppraiseENS, objvViewpointAppraiseENT) {
        objvViewpointAppraiseENT.userName = objvViewpointAppraiseENS.userName; //用户名
        objvViewpointAppraiseENT.viewpointAppraiseId = objvViewpointAppraiseENS.viewpointAppraiseId; //观点评论Id
        objvViewpointAppraiseENT.viewpointId = objvViewpointAppraiseENS.viewpointId; //观点Id
        objvViewpointAppraiseENT.appraiseContent = objvViewpointAppraiseENS.appraiseContent; //评议内容
        objvViewpointAppraiseENT.updDate = objvViewpointAppraiseENS.updDate; //修改日期
        objvViewpointAppraiseENT.memo = objvViewpointAppraiseENS.memo; //备注
        objvViewpointAppraiseENT.viewpointName = objvViewpointAppraiseENS.viewpointName; //观点名称
        objvViewpointAppraiseENT.viewpointContent = objvViewpointAppraiseENS.viewpointContent; //观点内容
        objvViewpointAppraiseENT.reason = objvViewpointAppraiseENS.reason; //理由
        objvViewpointAppraiseENT.updUser = objvViewpointAppraiseENS.updUser; //修改人
    }
    exports.vViewpointAppraise_CopyObjTo = vViewpointAppraise_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvViewpointAppraiseENS:源对象
     * @param objvViewpointAppraiseENT:目标对象
    */
    function vViewpointAppraise_GetObjFromJsonObj(objvViewpointAppraiseENS) {
        const objvViewpointAppraiseENT = new clsvViewpointAppraiseEN_js_1.clsvViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvViewpointAppraiseENT, objvViewpointAppraiseENS);
        return objvViewpointAppraiseENT;
    }
    exports.vViewpointAppraise_GetObjFromJsonObj = vViewpointAppraise_GetObjFromJsonObj;
});