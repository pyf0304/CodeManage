/**
* 类名:clsCacheUseStateWApi
* 表名:CacheUseState(01120689)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:45:56
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统设置(SystemSet)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/SystemSet/clsCacheUseStateEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheUseState_GetObjFromJsonObj = exports.CacheUseState_CopyObjTo = exports.CacheUseState_GetUniCondStr4Update_mId = exports.CacheUseState_GetUniCondStr_mId = exports.CacheUseState_GetCombineCondition = exports.CacheUseState_GetObjByJSONStr = exports.CacheUseState_GetObjLstByJSONObjLst = exports.CacheUseState_GetObjLstByJSONStr = exports.CacheUseState_GetJSONStrByObj = exports.CacheUseState_CheckProperty4Update = exports.CacheUseState_CheckPropertyNew = exports.CacheUseState__Cache = exports.CacheUseState_ReFreshThisCache = exports.CacheUseState_ReFreshCache = exports.CacheUseState_GetWebApiUrl = exports.CacheUseState_GetMaxStrIdByPrefix = exports.CacheUseState_GetRecCountByCond_Cache = exports.CacheUseState_GetRecCountByCondAsync = exports.CacheUseState_IsExistAsync = exports.CacheUseState_IsExist_Cache = exports.CacheUseState_IsExist = exports.CacheUseState_IsExistRecordAsync = exports.CacheUseState_IsExistRecord_Cache = exports.CacheUseState_UpdateWithConditionAsync = exports.CacheUseState_UpdateRecordAsync = exports.CacheUseState_AddNewRecordWithReturnKey = exports.CacheUseState_AddNewRecordWithReturnKeyAsync = exports.CacheUseState_AddNewRecordAsync = exports.CacheUseState_DelCacheUseStatesByCondAsync = exports.CacheUseState_DelCacheUseStatesAsync = exports.CacheUseState_DelRecordAsync = exports.CacheUseState_GetObjLstByPagerAsync = exports.CacheUseState_GetObjLstByPager_Cache = exports.CacheUseState_GetObjLstByRange = exports.CacheUseState_GetObjLstByRangeAsync = exports.CacheUseState_GetTopObjLstAsync = exports.CacheUseState_GetObjLstBymIdLst_Cache = exports.CacheUseState_GetObjLstBymIdLstAsync = exports.CacheUseState_GetSubObjLst_Cache = exports.CacheUseState_GetObjLst_PureCache = exports.CacheUseState_GetObjLst_Cache = exports.CacheUseState_GetObjLst_sessionStorage_PureCache = exports.CacheUseState_GetObjLst_sessionStorage = exports.CacheUseState_GetObjLstAsync = exports.CacheUseState_GetObjLst_localStorage_PureCache = exports.CacheUseState_GetObjLst_localStorage = exports.CacheUseState_GetObjLst_ClientCache = exports.CacheUseState_GetFirstObjAsync = exports.CacheUseState_GetFirstID = exports.CacheUseState_GetFirstIDAsync = exports.CacheUseState_FilterFunByKey = exports.CacheUseState_SortFunByKey = exports.CacheUseState_SortFun_Defa_2Fld = exports.CacheUseState_SortFun_Defa = exports.CacheUseState_func = exports.CacheUseState_GetNameBymId_Cache = exports.CacheUseState_UpdateObjInLst_Cache = exports.CacheUseState_GetObjBymId_localStorage = exports.CacheUseState_GetObjBymId_Cache = exports.CacheUseState_GetObjBymIdAsync = exports.cacheUseState_ConstructorName = exports.cacheUseState_Controller = void 0;
    /**
     * 缓存使用状态(CacheUseState)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCacheUseStateEN_js_1 = require("../../L0_Entity/SystemSet/clsCacheUseStateEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.cacheUseState_Controller = "CacheUseStateApi";
    exports.cacheUseState_ConstructorName = "cacheUseState";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function CacheUseState_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objCacheUseState = CacheUseState_GetObjFromJsonObj(returnObj);
                return objCacheUseState;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetObjBymIdAsync = CacheUseState_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function CacheUseState_GetObjBymId_Cache(lngmId, strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        try {
            const arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
            let objCacheUseState;
            if (arrCacheUseState_Sel.length > 0) {
                objCacheUseState = arrCacheUseState_Sel[0];
                return objCacheUseState;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objCacheUseState = await CacheUseState_GetObjBymIdAsync(lngmId);
                    if (objCacheUseState != null) {
                        CacheUseState_ReFreshThisCache(strUserId);
                        return objCacheUseState;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.CacheUseState_GetObjBymId_Cache = CacheUseState_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function CacheUseState_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objCacheUseState_Cache = JSON.parse(strTempObj);
            return objCacheUseState_Cache;
        }
        try {
            const objCacheUseState = await CacheUseState_GetObjBymIdAsync(lngmId);
            if (objCacheUseState != null) {
                localStorage.setItem(strKey, JSON.stringify(objCacheUseState));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objCacheUseState;
            }
            return objCacheUseState;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.CacheUseState_GetObjBymId_localStorage = CacheUseState_GetObjBymId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objCacheUseState:所给的对象
     * @returns 对象
    */
    async function CacheUseState_UpdateObjInLst_Cache(objCacheUseState, strUserId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
            const obj = arrCacheUseStateObjLst_Cache.find(x => x.mId == objCacheUseState.mId);
            if (obj != null) {
                objCacheUseState.mId = obj.mId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objCacheUseState);
            }
            else {
                arrCacheUseStateObjLst_Cache.push(objCacheUseState);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.CacheUseState_UpdateObjInLst_Cache = CacheUseState_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function CacheUseState_GetNameBymId_Cache(lngmId, strUserId) {
        const strThisFuncName = "GetNameBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetNameBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        if (arrCacheUseStateObjLst_Cache == null)
            return "";
        try {
            const arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
            let objCacheUseState;
            if (arrCacheUseState_Sel.length > 0) {
                objCacheUseState = arrCacheUseState_Sel[0];
                return objCacheUseState.userId;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, lngmId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.CacheUseState_GetNameBymId_Cache = CacheUseState_GetNameBymId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strUserId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function CacheUseState_func(strInFldName, strOutFldName, strInValue, strUserId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsCacheUseStateEN_js_1.clsCacheUseStateEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsCacheUseStateEN_js_1.clsCacheUseStateEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objCacheUseState = await CacheUseState_GetObjBymId_Cache(lngmId, strUserId_C);
        if (objCacheUseState == null)
            return "";
        return objCacheUseState.GetFldValue(strOutFldName).toString();
    }
    exports.CacheUseState_func = CacheUseState_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheUseState_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.CacheUseState_SortFun_Defa = CacheUseState_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheUseState_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userId == b.userId)
            return a.cacheModeId.localeCompare(b.cacheModeId);
        else
            return a.userId.localeCompare(b.userId);
    }
    exports.CacheUseState_SortFun_Defa_2Fld = CacheUseState_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheUseState_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId:
                    return (a, b) => {
                        return a.cacheModeId.localeCompare(b.cacheModeId);
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey:
                    return (a, b) => {
                        return a.cacheKey.localeCompare(b.cacheKey);
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize:
                    return (a, b) => {
                        return a.cacheSize - b.cacheSize;
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CacheUseState]中不存在！(in ${exports.cacheUseState_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId:
                    return (a, b) => {
                        return b.cacheModeId.localeCompare(a.cacheModeId);
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey:
                    return (a, b) => {
                        return b.cacheKey.localeCompare(a.cacheKey);
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize:
                    return (a, b) => {
                        return b.cacheSize - a.cacheSize;
                    };
                case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CacheUseState]中不存在！(in ${exports.cacheUseState_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.CacheUseState_SortFunByKey = CacheUseState_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CacheUseState_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId:
                return (obj) => {
                    return obj.cacheModeId === value;
                };
            case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey:
                return (obj) => {
                    return obj.cacheKey === value;
                };
            case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize:
                return (obj) => {
                    return obj.cacheSize === value;
                };
            case clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[CacheUseState]中不存在！(in ${exports.cacheUseState_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.CacheUseState_FilterFunByKey = CacheUseState_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function CacheUseState_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetFirstIDAsync = CacheUseState_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function CacheUseState_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetFirstID = CacheUseState_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function CacheUseState_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objCacheUseState = CacheUseState_GetObjFromJsonObj(returnObj);
                return objCacheUseState;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetFirstObjAsync = CacheUseState_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_ClientCache(strUserId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
        clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrCacheUseStateExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrCacheUseStateObjLst_T = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateExObjLst_Cache);
            return arrCacheUseStateObjLst_T;
        }
        try {
            const arrCacheUseStateExObjLst = await CacheUseState_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrCacheUseStateExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheUseStateExObjLst.length);
            console.log(strInfo);
            return arrCacheUseStateExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CacheUseState_GetObjLst_ClientCache = CacheUseState_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_localStorage(strUserId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
        clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCacheUseStateExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCacheUseStateObjLst_T = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateExObjLst_Cache);
            return arrCacheUseStateObjLst_T;
        }
        try {
            const arrCacheUseStateExObjLst = await CacheUseState_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrCacheUseStateExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheUseStateExObjLst.length);
            console.log(strInfo);
            return arrCacheUseStateExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CacheUseState_GetObjLst_localStorage = CacheUseState_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_localStorage_PureCache(strUserId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCacheUseStateObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCacheUseStateObjLst_Cache;
        }
        else
            return null;
    }
    exports.CacheUseState_GetObjLst_localStorage_PureCache = CacheUseState_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function CacheUseState_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetObjLstAsync = CacheUseState_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_sessionStorage(strUserId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
        clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCacheUseStateExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCacheUseStateObjLst_T = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateExObjLst_Cache);
            return arrCacheUseStateObjLst_T;
        }
        try {
            const arrCacheUseStateExObjLst = await CacheUseState_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrCacheUseStateExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheUseStateExObjLst.length);
            console.log(strInfo);
            return arrCacheUseStateExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CacheUseState_GetObjLst_sessionStorage = CacheUseState_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_sessionStorage_PureCache(strUserId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCacheUseStateObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCacheUseStateObjLst_Cache;
        }
        else
            return null;
    }
    exports.CacheUseState_GetObjLst_sessionStorage_PureCache = CacheUseState_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_Cache(strUserId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[UserId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        let arrCacheUseStateObjLst_Cache;
        switch (clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheModeId) {
            case "04": //sessionStorage
                arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_sessionStorage(strUserId);
                break;
            case "03": //localStorage
                arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_localStorage(strUserId);
                break;
            case "02": //ClientCache
                arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_ClientCache(strUserId);
                break;
            default:
                arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_ClientCache(strUserId);
                break;
        }
        const arrCacheUseStateObjLst = CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateObjLst_Cache);
        return arrCacheUseStateObjLst_Cache;
    }
    exports.CacheUseState_GetObjLst_Cache = CacheUseState_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheUseState_GetObjLst_PureCache(strUserId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrCacheUseStateObjLst_Cache;
        switch (clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheModeId) {
            case "04": //sessionStorage
                arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_sessionStorage_PureCache(strUserId);
                break;
            case "03": //localStorage
                arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_localStorage_PureCache(strUserId);
                break;
            case "02": //ClientCache
                arrCacheUseStateObjLst_Cache = null;
                break;
            default:
                arrCacheUseStateObjLst_Cache = null;
                break;
        }
        return arrCacheUseStateObjLst_Cache;
    }
    exports.CacheUseState_GetObjLst_PureCache = CacheUseState_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CacheUseState_GetSubObjLst_Cache(objCacheUseState_Cond, strUserId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        let arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache;
        if (objCacheUseState_Cond.sf_FldComparisonOp == null || objCacheUseState_Cond.sf_FldComparisonOp == "")
            return arrCacheUseState_Sel;
        const dicFldComparisonOp = JSON.parse(objCacheUseState_Cond.sf_FldComparisonOp);
        //console.log("clsCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheUseState_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheUseState_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCacheUseState_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objCacheUseState_Cond), exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheUseState_GetSubObjLst_Cache = CacheUseState_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function CacheUseState_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetObjLstBymIdLstAsync = CacheUseState_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function CacheUseState_GetObjLstBymIdLst_Cache(arrmIdLst, strUserId) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
            const arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrCacheUseState_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheUseState_GetObjLstBymIdLst_Cache = CacheUseState_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function CacheUseState_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetTopObjLstAsync = CacheUseState_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CacheUseState_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetObjLstByRangeAsync = CacheUseState_GetObjLstByRangeAsync;
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
    async function CacheUseState_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetObjLstByRange = CacheUseState_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CacheUseState_GetObjLstByPager_Cache(objPagerPara, strUserId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        if (arrCacheUseStateObjLst_Cache.length == 0)
            return arrCacheUseStateObjLst_Cache;
        let arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCacheUseState_Cond = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCacheUseState_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCacheUseStateWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheUseState_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCacheUseState_Sel.length == 0)
                return arrCacheUseState_Sel;
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
                arrCacheUseState_Sel = arrCacheUseState_Sel.sort(CacheUseState_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCacheUseState_Sel = arrCacheUseState_Sel.sort(objPagerPara.sortFun);
            }
            arrCacheUseState_Sel = arrCacheUseState_Sel.slice(intStart, intEnd);
            return arrCacheUseState_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheUseState_GetObjLstByPager_Cache = CacheUseState_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CacheUseState_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheUseState_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheUseState_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetObjLstByPagerAsync = CacheUseState_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngmId:关键字
    * @returns 获取删除的结果
    **/
    async function CacheUseState_DelRecordAsync(lngmId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngmId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngmId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_DelRecordAsync = CacheUseState_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrmId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function CacheUseState_DelCacheUseStatesAsync(arrmId) {
        const strThisFuncName = "DelCacheUseStatesAsync";
        const strAction = "DelCacheUseStates";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                return data.returnInt;
            }
            else {
                console.error(data.errorMsg);
                throw data.errorMsg;
            }
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_DelCacheUseStatesAsync = CacheUseState_DelCacheUseStatesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function CacheUseState_DelCacheUseStatesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelCacheUseStatesByCondAsync";
        const strAction = "DelCacheUseStatesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_DelCacheUseStatesByCondAsync = CacheUseState_DelCacheUseStatesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objCacheUseStateEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CacheUseState_AddNewRecordAsync(objCacheUseStateEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objCacheUseStateEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheUseStateEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_AddNewRecordAsync = CacheUseState_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objCacheUseStateEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function CacheUseState_AddNewRecordWithReturnKeyAsync(objCacheUseStateEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheUseStateEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_AddNewRecordWithReturnKeyAsync = CacheUseState_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objCacheUseStateEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function CacheUseState_AddNewRecordWithReturnKey(objCacheUseStateEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objCacheUseStateEN.mId === null || objCacheUseStateEN.mId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheUseStateEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_AddNewRecordWithReturnKey = CacheUseState_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objCacheUseStateEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function CacheUseState_UpdateRecordAsync(objCacheUseStateEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objCacheUseStateEN.sf_UpdFldSetStr === undefined || objCacheUseStateEN.sf_UpdFldSetStr === null || objCacheUseStateEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheUseStateEN.mId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheUseStateEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_UpdateRecordAsync = CacheUseState_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objCacheUseStateEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function CacheUseState_UpdateWithConditionAsync(objCacheUseStateEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objCacheUseStateEN.sf_UpdFldSetStr === undefined || objCacheUseStateEN.sf_UpdFldSetStr === null || objCacheUseStateEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheUseStateEN.mId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        objCacheUseStateEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objCacheUseStateEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_UpdateWithConditionAsync = CacheUseState_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CacheUseState_IsExistRecord_Cache(objCacheUseState_Cond, strUserId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        if (arrCacheUseStateObjLst_Cache == null)
            return false;
        let arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache;
        if (objCacheUseState_Cond.sf_FldComparisonOp == null || objCacheUseState_Cond.sf_FldComparisonOp == "")
            return arrCacheUseState_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objCacheUseState_Cond.sf_FldComparisonOp);
        //console.log("clsCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheUseState_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheUseState_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCacheUseState_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objCacheUseState_Cond), exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.CacheUseState_IsExistRecord_Cache = CacheUseState_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function CacheUseState_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_IsExistRecordAsync = CacheUseState_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function CacheUseState_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_IsExist = CacheUseState_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function CacheUseState_IsExist_Cache(lngmId, strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        if (arrCacheUseStateObjLst_Cache == null)
            return false;
        try {
            const arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrCacheUseState_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.CacheUseState_IsExist_Cache = CacheUseState_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function CacheUseState_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_IsExistAsync = CacheUseState_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function CacheUseState_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetRecCountByCondAsync = CacheUseState_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objCacheUseState_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function CacheUseState_GetRecCountByCond_Cache(objCacheUseState_Cond, strUserId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrCacheUseStateObjLst_Cache = await CacheUseState_GetObjLst_Cache(strUserId);
        if (arrCacheUseStateObjLst_Cache == null)
            return 0;
        let arrCacheUseState_Sel = arrCacheUseStateObjLst_Cache;
        if (objCacheUseState_Cond.sf_FldComparisonOp == null || objCacheUseState_Cond.sf_FldComparisonOp == "")
            return arrCacheUseState_Sel.length;
        const dicFldComparisonOp = JSON.parse(objCacheUseState_Cond.sf_FldComparisonOp);
        //console.log("clsCacheUseStateWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheUseState_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheUseState_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheUseState_Sel = arrCacheUseState_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCacheUseState_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objCacheUseState_Cond), exports.cacheUseState_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.CacheUseState_GetRecCountByCond_Cache = CacheUseState_GetRecCountByCond_Cache;
    /*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function CacheUseState_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheUseState_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPrefix": strPrefix }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheUseState_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheUseState_GetMaxStrIdByPrefix = CacheUseState_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function CacheUseState_GetWebApiUrl(strController, strAction) {
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
    exports.CacheUseState_GetWebApiUrl = CacheUseState_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function CacheUseState_ReFreshCache(strUserId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsCacheUseStateWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
        switch (clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheModeId) {
            case "04": //sessionStorage
                sessionStorage.removeItem(strKey);
                break;
            case "03": //localStorage
                localStorage.removeItem(strKey);
                break;
            case "02": //ClientCache
                CacheHelper_js_2.CacheHelper.Remove(strKey);
                break;
            default:
                CacheHelper_js_2.CacheHelper.Remove(strKey);
                break;
        }
    }
    exports.CacheUseState_ReFreshCache = CacheUseState_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function CacheUseState_ReFreshThisCache(strUserId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN._CurrTabName, strUserId);
            switch (clsCacheUseStateEN_js_1.clsCacheUseStateEN.CacheModeId) {
                case "04": //sessionStorage
                    sessionStorage.removeItem(strKey);
                    break;
                case "03": //localStorage
                    localStorage.removeItem(strKey);
                    break;
                case "02": //ClientCache
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
                    break;
                default:
                    CacheHelper_js_2.CacheHelper.Remove(strKey);
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
    exports.CacheUseState_ReFreshThisCache = CacheUseState_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function CacheUseState__Cache(strDivName, strDdlName, strUserId) {
        const strThisFuncName = "_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In )");
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await CacheUseState_GetObjLst_Cache(strUserId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, "缓存使用状态");
    }
    exports.CacheUseState__Cache = CacheUseState__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CacheUseState_CheckPropertyNew(pobjCacheUseStateEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.userId) === true) {
            throw new Error("(errid:Watl000058)字段[用户ID]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheModeId) === true) {
            throw new Error("(errid:Watl000058)字段[缓存方式Id]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheKey) === true) {
            throw new Error("(errid:Watl000058)字段[缓存关键字]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.userId)(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheModeId) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.cacheModeId) > 2) {
            throw new Error("(errid:Watl000059)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheModeId)(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheKey) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.cacheKey) > 50) {
            throw new Error("(errid:Watl000059)字段[缓存关键字(cacheKey)]的长度不能超过50(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheKey)(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.memo)(clsCacheUseStateBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjCacheUseStateEN.mId && undefined !== pobjCacheUseStateEN.mId && jsString_js_1.tzDataType.isNumber(pobjCacheUseStateEN.mId) === false) {
            throw new Error("(errid:Watl000060)字段[mId(mId)]的值:[$(pobjCacheUseStateEN.mId)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.userId) == false && undefined !== pobjCacheUseStateEN.userId && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjCacheUseStateEN.userId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheModeId) == false && undefined !== pobjCacheUseStateEN.cacheModeId && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.cacheModeId) === false) {
            throw new Error("(errid:Watl000060)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheUseStateEN.cacheModeId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheKey) == false && undefined !== pobjCacheUseStateEN.cacheKey && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.cacheKey) === false) {
            throw new Error("(errid:Watl000060)字段[缓存关键字(cacheKey)]的值:[$(pobjCacheUseStateEN.cacheKey)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if (null != pobjCacheUseStateEN.cacheSize && undefined !== pobjCacheUseStateEN.cacheSize && jsString_js_1.tzDataType.isNumber(pobjCacheUseStateEN.cacheSize) === false) {
            throw new Error("(errid:Watl000060)字段[缓存大小(cacheSize)]的值:[$(pobjCacheUseStateEN.cacheSize)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.memo) == false && undefined !== pobjCacheUseStateEN.memo && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCacheUseStateEN.memo)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjCacheUseStateEN.SetIsCheckProperty(true);
    }
    exports.CacheUseState_CheckPropertyNew = CacheUseState_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CacheUseState_CheckProperty4Update(pobjCacheUseStateEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.userId)(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheModeId) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.cacheModeId) > 2) {
            throw new Error("(errid:Watl000062)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheModeId)(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheKey) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.cacheKey) > 50) {
            throw new Error("(errid:Watl000062)字段[缓存关键字(cacheKey)]的长度不能超过50(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.cacheKey)(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjCacheUseStateEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 缓存使用状态(CacheUseState))!值:$(pobjCacheUseStateEN.memo)(clsCacheUseStateBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjCacheUseStateEN.mId && undefined !== pobjCacheUseStateEN.mId && jsString_js_1.tzDataType.isNumber(pobjCacheUseStateEN.mId) === false) {
            throw new Error("(errid:Watl000063)字段[mId(mId)]的值:[$(pobjCacheUseStateEN.mId)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.userId) == false && undefined !== pobjCacheUseStateEN.userId && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjCacheUseStateEN.userId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheModeId) == false && undefined !== pobjCacheUseStateEN.cacheModeId && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.cacheModeId) === false) {
            throw new Error("(errid:Watl000063)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheUseStateEN.cacheModeId)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.cacheKey) == false && undefined !== pobjCacheUseStateEN.cacheKey && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.cacheKey) === false) {
            throw new Error("(errid:Watl000063)字段[缓存关键字(cacheKey)]的值:[$(pobjCacheUseStateEN.cacheKey)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if (null != pobjCacheUseStateEN.cacheSize && undefined !== pobjCacheUseStateEN.cacheSize && jsString_js_1.tzDataType.isNumber(pobjCacheUseStateEN.cacheSize) === false) {
            throw new Error("(errid:Watl000063)字段[缓存大小(cacheSize)]的值:[$(pobjCacheUseStateEN.cacheSize)], 非法，应该为数值型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheUseStateEN.memo) == false && undefined !== pobjCacheUseStateEN.memo && jsString_js_1.tzDataType.isString(pobjCacheUseStateEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCacheUseStateEN.memo)], 非法，应该为字符型(In 缓存使用状态(CacheUseState))!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjCacheUseStateEN.mId
            || pobjCacheUseStateEN.mId != null && pobjCacheUseStateEN.mId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[mId]不能为空(In 缓存使用状态)!(clsCacheUseStateBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjCacheUseStateEN.SetIsCheckProperty(true);
    }
    exports.CacheUseState_CheckProperty4Update = CacheUseState_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CacheUseState_GetJSONStrByObj(pobjCacheUseStateEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjCacheUseStateEN.sf_UpdFldSetStr = pobjCacheUseStateEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjCacheUseStateEN);
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
    exports.CacheUseState_GetJSONStrByObj = CacheUseState_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function CacheUseState_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrCacheUseStateObjLst = new Array();
        if (strJSON === "") {
            return arrCacheUseStateObjLst;
        }
        try {
            arrCacheUseStateObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrCacheUseStateObjLst;
        }
        return arrCacheUseStateObjLst;
    }
    exports.CacheUseState_GetObjLstByJSONStr = CacheUseState_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrCacheUseStateObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function CacheUseState_GetObjLstByJSONObjLst(arrCacheUseStateObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrCacheUseStateObjLst = new Array();
        for (const objInFor of arrCacheUseStateObjLstS) {
            const obj1 = CacheUseState_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrCacheUseStateObjLst.push(obj1);
        }
        return arrCacheUseStateObjLst;
    }
    exports.CacheUseState_GetObjLstByJSONObjLst = CacheUseState_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CacheUseState_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjCacheUseStateEN = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
        if (strJSON === "") {
            return pobjCacheUseStateEN;
        }
        try {
            pobjCacheUseStateEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjCacheUseStateEN;
        }
        return pobjCacheUseStateEN;
    }
    exports.CacheUseState_GetObjByJSONStr = CacheUseState_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function CacheUseState_GetCombineCondition(objCacheUseState_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId) == true) {
            const strComparisonOp_mId = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_mId, objCacheUseState_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId) == true) {
            const strComparisonOp_UserId = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_UserId, objCacheUseState_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId) == true) {
            const strComparisonOp_CacheModeId = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheModeId, objCacheUseState_Cond.cacheModeId, strComparisonOp_CacheModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey) == true) {
            const strComparisonOp_CacheKey = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheKey, objCacheUseState_Cond.cacheKey, strComparisonOp_CacheKey);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize) == true) {
            const strComparisonOp_CacheSize = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_CacheSize, objCacheUseState_Cond.cacheSize, strComparisonOp_CacheSize);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheUseState_Cond.dicFldComparisonOp, clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo) == true) {
            const strComparisonOp_Memo = objCacheUseState_Cond.dicFldComparisonOp[clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheUseStateEN_js_1.clsCacheUseStateEN.con_Memo, objCacheUseState_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.CacheUseState_GetCombineCondition = CacheUseState_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--CacheUseState(缓存使用状态),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CacheUseState_GetUniCondStr_mId(objCacheUseStateEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objCacheUseStateEN.mId);
        return strWhereCond;
    }
    exports.CacheUseState_GetUniCondStr_mId = CacheUseState_GetUniCondStr_mId;
    /**
    *获取唯一性条件串(Uniqueness)--CacheUseState(缓存使用状态),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngmId: mId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CacheUseState_GetUniCondStr4Update_mId(objCacheUseStateEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and mId <> '{0}'", objCacheUseStateEN.mId);
        strWhereCond += (0, clsString_js_1.Format)(" and mId = '{0}'", objCacheUseStateEN.mId);
        return strWhereCond;
    }
    exports.CacheUseState_GetUniCondStr4Update_mId = CacheUseState_GetUniCondStr4Update_mId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objCacheUseStateENS:源对象
     * @param objCacheUseStateENT:目标对象
    */
    function CacheUseState_CopyObjTo(objCacheUseStateENS, objCacheUseStateENT) {
        objCacheUseStateENT.mId = objCacheUseStateENS.mId; //mId
        objCacheUseStateENT.userId = objCacheUseStateENS.userId; //用户ID
        objCacheUseStateENT.cacheModeId = objCacheUseStateENS.cacheModeId; //缓存方式Id
        objCacheUseStateENT.cacheKey = objCacheUseStateENS.cacheKey; //缓存关键字
        objCacheUseStateENT.cacheSize = objCacheUseStateENS.cacheSize; //缓存大小
        objCacheUseStateENT.memo = objCacheUseStateENS.memo; //备注
        objCacheUseStateENT.sf_UpdFldSetStr = objCacheUseStateENS.updFldString; //sf_UpdFldSetStr
    }
    exports.CacheUseState_CopyObjTo = CacheUseState_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objCacheUseStateENS:源对象
     * @param objCacheUseStateENT:目标对象
    */
    function CacheUseState_GetObjFromJsonObj(objCacheUseStateENS) {
        const objCacheUseStateENT = new clsCacheUseStateEN_js_1.clsCacheUseStateEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCacheUseStateENT, objCacheUseStateENS);
        return objCacheUseStateENT;
    }
    exports.CacheUseState_GetObjFromJsonObj = CacheUseState_GetObjFromJsonObj;
});
