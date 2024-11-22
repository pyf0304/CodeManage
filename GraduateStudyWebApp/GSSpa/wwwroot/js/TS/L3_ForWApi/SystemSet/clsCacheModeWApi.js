/**
* 类名:clsCacheModeWApi
* 表名:CacheMode(01120688)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/SystemSet/clsCacheModeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.CacheMode_GetObjFromJsonObj = exports.CacheMode_CopyObjTo = exports.CacheMode_GetUniCondStr4Update_CacheModeId = exports.CacheMode_GetUniCondStr_CacheModeId = exports.CacheMode_GetCombineCondition = exports.CacheMode_GetObjByJSONStr = exports.CacheMode_GetObjLstByJSONObjLst = exports.CacheMode_GetObjLstByJSONStr = exports.CacheMode_GetJSONStrByObj = exports.CacheMode_CheckProperty4Update = exports.CacheMode_CheckPropertyNew = exports.CacheMode_BindDdl_CacheModeIdInDiv_Cache = exports.CacheMode_ReFreshThisCache = exports.CacheMode_ReFreshCache = exports.CacheMode_GetWebApiUrl = exports.CacheMode_GetMaxStrIdByPrefix = exports.CacheMode_GetMaxStrIdAsync = exports.CacheMode_GetRecCountByCond_Cache = exports.CacheMode_GetRecCountByCondAsync = exports.CacheMode_IsExistAsync = exports.CacheMode_IsExist_Cache = exports.CacheMode_IsExist = exports.CacheMode_IsExistRecordAsync = exports.CacheMode_IsExistRecord_Cache = exports.CacheMode_UpdateWithConditionAsync = exports.CacheMode_UpdateRecordAsync = exports.CacheMode_AddNewRecordWithReturnKey = exports.CacheMode_AddNewRecordWithReturnKeyAsync = exports.CacheMode_AddNewRecordWithMaxIdAsync = exports.CacheMode_AddNewRecordAsync = exports.CacheMode_DelCacheModesByCondAsync = exports.CacheMode_DelCacheModesAsync = exports.CacheMode_DelRecordAsync = exports.CacheMode_GetObjLstByPagerAsync = exports.CacheMode_GetObjLstByPager_Cache = exports.CacheMode_GetObjLstByRange = exports.CacheMode_GetObjLstByRangeAsync = exports.CacheMode_GetTopObjLstAsync = exports.CacheMode_GetObjLstByCacheModeIdLst_Cache = exports.CacheMode_GetObjLstByCacheModeIdLstAsync = exports.CacheMode_GetSubObjLst_Cache = exports.CacheMode_GetObjLst_PureCache = exports.CacheMode_GetObjLst_Cache = exports.CacheMode_GetObjLst_sessionStorage_PureCache = exports.CacheMode_GetObjLst_sessionStorage = exports.CacheMode_GetObjLstAsync = exports.CacheMode_GetObjLst_localStorage_PureCache = exports.CacheMode_GetObjLst_localStorage = exports.CacheMode_GetObjLst_ClientCache = exports.CacheMode_GetFirstObjAsync = exports.CacheMode_GetFirstID = exports.CacheMode_GetFirstIDAsync = exports.CacheMode_FilterFunByKey = exports.CacheMode_SortFunByKey = exports.CacheMode_SortFun_Defa_2Fld = exports.CacheMode_SortFun_Defa = exports.CacheMode_func = exports.CacheMode_GetNameByCacheModeId_Cache = exports.CacheMode_UpdateObjInLst_Cache = exports.CacheMode_GetObjByCacheModeId_localStorage = exports.CacheMode_GetObjByCacheModeId_Cache = exports.CacheMode_GetObjByCacheModeIdAsync = exports.cacheMode_ConstructorName = exports.cacheMode_Controller = void 0;
    /**
     * 缓存方式(CacheMode)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsCacheModeEN_js_1 = require("../../L0_Entity/SystemSet/clsCacheModeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.cacheMode_Controller = "CacheModeApi";
    exports.cacheMode_ConstructorName = "cacheMode";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCacheModeId:关键字
    * @returns 对象
    **/
    async function CacheMode_GetObjByCacheModeIdAsync(strCacheModeId) {
        const strThisFuncName = "GetObjByCacheModeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCacheModeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCacheModeId]不能为空！(In GetObjByCacheModeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCacheModeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCacheModeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCacheModeId": strCacheModeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objCacheMode = CacheMode_GetObjFromJsonObj(returnObj);
                return objCacheMode;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetObjByCacheModeIdAsync = CacheMode_GetObjByCacheModeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCacheModeId:所给的关键字
     * @returns 对象
    */
    async function CacheMode_GetObjByCacheModeId_Cache(strCacheModeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCacheModeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCacheModeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCacheModeId]不能为空！(In GetObjByCacheModeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCacheModeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        try {
            const arrCacheMode_Sel = arrCacheModeObjLst_Cache.filter(x => x.cacheModeId == strCacheModeId);
            let objCacheMode;
            if (arrCacheMode_Sel.length > 0) {
                objCacheMode = arrCacheMode_Sel[0];
                return objCacheMode;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objCacheMode = await CacheMode_GetObjByCacheModeIdAsync(strCacheModeId);
                    if (objCacheMode != null) {
                        CacheMode_ReFreshThisCache();
                        return objCacheMode;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCacheModeId, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.CacheMode_GetObjByCacheModeId_Cache = CacheMode_GetObjByCacheModeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCacheModeId:所给的关键字
     * @returns 对象
    */
    async function CacheMode_GetObjByCacheModeId_localStorage(strCacheModeId) {
        const strThisFuncName = "GetObjByCacheModeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCacheModeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCacheModeId]不能为空！(In GetObjByCacheModeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCacheModeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName, strCacheModeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objCacheMode_Cache = JSON.parse(strTempObj);
            return objCacheMode_Cache;
        }
        try {
            const objCacheMode = await CacheMode_GetObjByCacheModeIdAsync(strCacheModeId);
            if (objCacheMode != null) {
                localStorage.setItem(strKey, JSON.stringify(objCacheMode));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objCacheMode;
            }
            return objCacheMode;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCacheModeId, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.CacheMode_GetObjByCacheModeId_localStorage = CacheMode_GetObjByCacheModeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objCacheMode:所给的对象
     * @returns 对象
    */
    async function CacheMode_UpdateObjInLst_Cache(objCacheMode) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
            const obj = arrCacheModeObjLst_Cache.find(x => x.cacheModeId == objCacheMode.cacheModeId);
            if (obj != null) {
                objCacheMode.cacheModeId = obj.cacheModeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objCacheMode);
            }
            else {
                arrCacheModeObjLst_Cache.push(objCacheMode);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.CacheMode_UpdateObjInLst_Cache = CacheMode_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strCacheModeId:所给的关键字
     * @returns 对象
    */
    async function CacheMode_GetNameByCacheModeId_Cache(strCacheModeId) {
        const strThisFuncName = "GetNameByCacheModeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCacheModeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCacheModeId]不能为空！(In GetNameByCacheModeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCacheModeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCacheModeId]的长度:[{0}]不正确！", strCacheModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        if (arrCacheModeObjLst_Cache == null)
            return "";
        try {
            const arrCacheMode_Sel = arrCacheModeObjLst_Cache.filter(x => x.cacheModeId == strCacheModeId);
            let objCacheMode;
            if (arrCacheMode_Sel.length > 0) {
                objCacheMode = arrCacheMode_Sel[0];
                return objCacheMode.cacheModeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCacheModeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.CacheMode_GetNameByCacheModeId_Cache = CacheMode_GetNameByCacheModeId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function CacheMode_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsCacheModeEN_js_1.clsCacheModeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsCacheModeEN_js_1.clsCacheModeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCacheModeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objCacheMode = await CacheMode_GetObjByCacheModeId_Cache(strCacheModeId);
        if (objCacheMode == null)
            return "";
        return objCacheMode.GetFldValue(strOutFldName).toString();
    }
    exports.CacheMode_func = CacheMode_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheMode_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.cacheModeId.localeCompare(b.cacheModeId);
    }
    exports.CacheMode_SortFun_Defa = CacheMode_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheMode_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.cacheModeName == b.cacheModeName)
            return a.cacheModeENName.localeCompare(b.cacheModeENName);
        else
            return a.cacheModeName.localeCompare(b.cacheModeName);
    }
    exports.CacheMode_SortFun_Defa_2Fld = CacheMode_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function CacheMode_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId:
                    return (a, b) => {
                        return a.cacheModeId.localeCompare(b.cacheModeId);
                    };
                case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName:
                    return (a, b) => {
                        return a.cacheModeName.localeCompare(b.cacheModeName);
                    };
                case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName:
                    return (a, b) => {
                        return a.cacheModeENName.localeCompare(b.cacheModeENName);
                    };
                case clsCacheModeEN_js_1.clsCacheModeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CacheMode]中不存在！(in ${exports.cacheMode_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId:
                    return (a, b) => {
                        return b.cacheModeId.localeCompare(a.cacheModeId);
                    };
                case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName:
                    return (a, b) => {
                        return b.cacheModeName.localeCompare(a.cacheModeName);
                    };
                case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName:
                    return (a, b) => {
                        return b.cacheModeENName.localeCompare(a.cacheModeENName);
                    };
                case clsCacheModeEN_js_1.clsCacheModeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[CacheMode]中不存在！(in ${exports.cacheMode_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.CacheMode_SortFunByKey = CacheMode_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function CacheMode_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId:
                return (obj) => {
                    return obj.cacheModeId === value;
                };
            case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName:
                return (obj) => {
                    return obj.cacheModeName === value;
                };
            case clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName:
                return (obj) => {
                    return obj.cacheModeENName === value;
                };
            case clsCacheModeEN_js_1.clsCacheModeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[CacheMode]中不存在！(in ${exports.cacheMode_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.CacheMode_FilterFunByKey = CacheMode_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function CacheMode_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetFirstIDAsync = CacheMode_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function CacheMode_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetFirstID = CacheMode_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function CacheMode_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objCacheMode = CacheMode_GetObjFromJsonObj(returnObj);
                return objCacheMode;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetFirstObjAsync = CacheMode_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
        clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrCacheModeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrCacheModeObjLst_T = CacheMode_GetObjLstByJSONObjLst(arrCacheModeExObjLst_Cache);
            return arrCacheModeObjLst_T;
        }
        try {
            const arrCacheModeExObjLst = await CacheMode_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrCacheModeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheModeExObjLst.length);
            console.log(strInfo);
            return arrCacheModeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CacheMode_GetObjLst_ClientCache = CacheMode_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
        clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCacheModeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCacheModeObjLst_T = CacheMode_GetObjLstByJSONObjLst(arrCacheModeExObjLst_Cache);
            return arrCacheModeObjLst_T;
        }
        try {
            const arrCacheModeExObjLst = await CacheMode_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrCacheModeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheModeExObjLst.length);
            console.log(strInfo);
            return arrCacheModeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CacheMode_GetObjLst_localStorage = CacheMode_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrCacheModeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCacheModeObjLst_Cache;
        }
        else
            return null;
    }
    exports.CacheMode_GetObjLst_localStorage_PureCache = CacheMode_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function CacheMode_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetObjLstAsync = CacheMode_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
        clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsCacheModeEN_js_1.clsCacheModeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCacheModeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrCacheModeObjLst_T = CacheMode_GetObjLstByJSONObjLst(arrCacheModeExObjLst_Cache);
            return arrCacheModeObjLst_T;
        }
        try {
            const arrCacheModeExObjLst = await CacheMode_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrCacheModeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrCacheModeExObjLst.length);
            console.log(strInfo);
            return arrCacheModeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.CacheMode_GetObjLst_sessionStorage = CacheMode_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrCacheModeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrCacheModeObjLst_Cache;
        }
        else
            return null;
    }
    exports.CacheMode_GetObjLst_sessionStorage_PureCache = CacheMode_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrCacheModeObjLst_Cache;
        switch (clsCacheModeEN_js_1.clsCacheModeEN.CacheModeId) {
            case "04": //sessionStorage
                arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_ClientCache();
                break;
            default:
                arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_ClientCache();
                break;
        }
        const arrCacheModeObjLst = CacheMode_GetObjLstByJSONObjLst(arrCacheModeObjLst_Cache);
        return arrCacheModeObjLst_Cache;
    }
    exports.CacheMode_GetObjLst_Cache = CacheMode_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function CacheMode_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrCacheModeObjLst_Cache;
        switch (clsCacheModeEN_js_1.clsCacheModeEN.CacheModeId) {
            case "04": //sessionStorage
                arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrCacheModeObjLst_Cache = null;
                break;
            default:
                arrCacheModeObjLst_Cache = null;
                break;
        }
        return arrCacheModeObjLst_Cache;
    }
    exports.CacheMode_GetObjLst_PureCache = CacheMode_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCacheModeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CacheMode_GetSubObjLst_Cache(objCacheMode_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        let arrCacheMode_Sel = arrCacheModeObjLst_Cache;
        if (objCacheMode_Cond.sf_FldComparisonOp == null || objCacheMode_Cond.sf_FldComparisonOp == "")
            return arrCacheMode_Sel;
        const dicFldComparisonOp = JSON.parse(objCacheMode_Cond.sf_FldComparisonOp);
        //console.log("clsCacheModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheMode_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCacheMode_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objCacheMode_Cond), exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheMode_GetSubObjLst_Cache = CacheMode_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCacheModeId:关键字列表
    * @returns 对象列表
    **/
    async function CacheMode_GetObjLstByCacheModeIdLstAsync(arrCacheModeId) {
        const strThisFuncName = "GetObjLstByCacheModeIdLstAsync";
        const strAction = "GetObjLstByCacheModeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCacheModeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetObjLstByCacheModeIdLstAsync = CacheMode_GetObjLstByCacheModeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCacheModeIdLst:关键字列表
     * @returns 对象列表
    */
    async function CacheMode_GetObjLstByCacheModeIdLst_Cache(arrCacheModeIdLst) {
        const strThisFuncName = "GetObjLstByCacheModeIdLst_Cache";
        try {
            const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
            const arrCacheMode_Sel = arrCacheModeObjLst_Cache.filter(x => arrCacheModeIdLst.indexOf(x.cacheModeId) > -1);
            return arrCacheMode_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCacheModeIdLst.join(","), exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheMode_GetObjLstByCacheModeIdLst_Cache = CacheMode_GetObjLstByCacheModeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function CacheMode_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetTopObjLstAsync = CacheMode_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CacheMode_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetObjLstByRangeAsync = CacheMode_GetObjLstByRangeAsync;
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
    async function CacheMode_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetObjLstByRange = CacheMode_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function CacheMode_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        if (arrCacheModeObjLst_Cache.length == 0)
            return arrCacheModeObjLst_Cache;
        let arrCacheMode_Sel = arrCacheModeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objCacheMode_Cond = new clsCacheModeEN_js_1.clsCacheModeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCacheMode_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsCacheModeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCacheMode_Sel.length == 0)
                return arrCacheMode_Sel;
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
                arrCacheMode_Sel = arrCacheMode_Sel.sort(CacheMode_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrCacheMode_Sel = arrCacheMode_Sel.sort(objPagerPara.sortFun);
            }
            arrCacheMode_Sel = arrCacheMode_Sel.slice(intStart, intEnd);
            return arrCacheMode_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.CacheMode_GetObjLstByPager_Cache = CacheMode_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function CacheMode_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cacheMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = CacheMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetObjLstByPagerAsync = CacheMode_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCacheModeId:关键字
    * @returns 获取删除的结果
    **/
    async function CacheMode_DelRecordAsync(strCacheModeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strCacheModeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strCacheModeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_DelRecordAsync = CacheMode_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCacheModeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function CacheMode_DelCacheModesAsync(arrCacheModeId) {
        const strThisFuncName = "DelCacheModesAsync";
        const strAction = "DelCacheModes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCacheModeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_DelCacheModesAsync = CacheMode_DelCacheModesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function CacheMode_DelCacheModesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelCacheModesByCondAsync";
        const strAction = "DelCacheModesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_DelCacheModesByCondAsync = CacheMode_DelCacheModesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objCacheModeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CacheMode_AddNewRecordAsync(objCacheModeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objCacheModeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheModeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_AddNewRecordAsync = CacheMode_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objCacheModeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function CacheMode_AddNewRecordWithMaxIdAsync(objCacheModeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheModeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_AddNewRecordWithMaxIdAsync = CacheMode_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objCacheModeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function CacheMode_AddNewRecordWithReturnKeyAsync(objCacheModeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheModeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_AddNewRecordWithReturnKeyAsync = CacheMode_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objCacheModeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function CacheMode_AddNewRecordWithReturnKey(objCacheModeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objCacheModeEN.cacheModeId === null || objCacheModeEN.cacheModeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheModeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_AddNewRecordWithReturnKey = CacheMode_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objCacheModeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function CacheMode_UpdateRecordAsync(objCacheModeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objCacheModeEN.sf_UpdFldSetStr === undefined || objCacheModeEN.sf_UpdFldSetStr === null || objCacheModeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheModeEN.cacheModeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objCacheModeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_UpdateRecordAsync = CacheMode_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objCacheModeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function CacheMode_UpdateWithConditionAsync(objCacheModeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objCacheModeEN.sf_UpdFldSetStr === undefined || objCacheModeEN.sf_UpdFldSetStr === null || objCacheModeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objCacheModeEN.cacheModeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        objCacheModeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objCacheModeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_UpdateWithConditionAsync = CacheMode_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCacheModeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function CacheMode_IsExistRecord_Cache(objCacheMode_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        if (arrCacheModeObjLst_Cache == null)
            return false;
        let arrCacheMode_Sel = arrCacheModeObjLst_Cache;
        if (objCacheMode_Cond.sf_FldComparisonOp == null || objCacheMode_Cond.sf_FldComparisonOp == "")
            return arrCacheMode_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objCacheMode_Cond.sf_FldComparisonOp);
        //console.log("clsCacheModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheMode_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrCacheMode_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objCacheMode_Cond), exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.CacheMode_IsExistRecord_Cache = CacheMode_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function CacheMode_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_IsExistRecordAsync = CacheMode_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCacheModeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function CacheMode_IsExist(strCacheModeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CacheModeId": strCacheModeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_IsExist = CacheMode_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCacheModeId:所给的关键字
     * @returns 对象
    */
    async function CacheMode_IsExist_Cache(strCacheModeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        if (arrCacheModeObjLst_Cache == null)
            return false;
        try {
            const arrCacheMode_Sel = arrCacheModeObjLst_Cache.filter(x => x.cacheModeId == strCacheModeId);
            if (arrCacheMode_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCacheModeId, exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.CacheMode_IsExist_Cache = CacheMode_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCacheModeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function CacheMode_IsExistAsync(strCacheModeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCacheModeId": strCacheModeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_IsExistAsync = CacheMode_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function CacheMode_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetRecCountByCondAsync = CacheMode_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objCacheMode_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function CacheMode_GetRecCountByCond_Cache(objCacheMode_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrCacheModeObjLst_Cache = await CacheMode_GetObjLst_Cache();
        if (arrCacheModeObjLst_Cache == null)
            return 0;
        let arrCacheMode_Sel = arrCacheModeObjLst_Cache;
        if (objCacheMode_Cond.sf_FldComparisonOp == null || objCacheMode_Cond.sf_FldComparisonOp == "")
            return arrCacheMode_Sel.length;
        const dicFldComparisonOp = JSON.parse(objCacheMode_Cond.sf_FldComparisonOp);
        //console.log("clsCacheModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objCacheMode_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objCacheMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrCacheMode_Sel = arrCacheMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrCacheMode_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objCacheMode_Cond), exports.cacheMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.CacheMode_GetRecCountByCond_Cache = CacheMode_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function CacheMode_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetMaxStrIdAsync = CacheMode_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function CacheMode_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cacheMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cacheMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.CacheMode_GetMaxStrIdByPrefix = CacheMode_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function CacheMode_GetWebApiUrl(strController, strAction) {
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
    exports.CacheMode_GetWebApiUrl = CacheMode_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function CacheMode_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
        switch (clsCacheModeEN_js_1.clsCacheModeEN.CacheModeId) {
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
    exports.CacheMode_ReFreshCache = CacheMode_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function CacheMode_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsCacheModeEN_js_1.clsCacheModeEN._CurrTabName;
            switch (clsCacheModeEN_js_1.clsCacheModeEN.CacheModeId) {
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
    exports.CacheMode_ReFreshThisCache = CacheMode_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function CacheMode_BindDdl_CacheModeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_CacheModeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_CacheModeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CacheModeIdInDiv_Cache");
        const arrObjLst_Sel = await CacheMode_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName, "缓存方式");
    }
    exports.CacheMode_BindDdl_CacheModeIdInDiv_Cache = CacheMode_BindDdl_CacheModeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CacheMode_CheckPropertyNew(pobjCacheModeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeName) === true) {
            throw new Error("(errid:Watl000058)字段[缓存方式名]不能为空(In 缓存方式)!(clsCacheModeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeId) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.cacheModeId) > 2) {
            throw new Error("(errid:Watl000059)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeId)(clsCacheModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeName) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.cacheModeName) > 50) {
            throw new Error("(errid:Watl000059)字段[缓存方式名(cacheModeName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeName)(clsCacheModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeENName) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.cacheModeENName) > 50) {
            throw new Error("(errid:Watl000059)字段[缓存方式英文名(cacheModeENName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeENName)(clsCacheModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.memo)(clsCacheModeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeId) == false && undefined !== pobjCacheModeEN.cacheModeId && jsString_js_1.tzDataType.isString(pobjCacheModeEN.cacheModeId) === false) {
            throw new Error("(errid:Watl000060)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheModeEN.cacheModeId)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeName) == false && undefined !== pobjCacheModeEN.cacheModeName && jsString_js_1.tzDataType.isString(pobjCacheModeEN.cacheModeName) === false) {
            throw new Error("(errid:Watl000060)字段[缓存方式名(cacheModeName)]的值:[$(pobjCacheModeEN.cacheModeName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeENName) == false && undefined !== pobjCacheModeEN.cacheModeENName && jsString_js_1.tzDataType.isString(pobjCacheModeEN.cacheModeENName) === false) {
            throw new Error("(errid:Watl000060)字段[缓存方式英文名(cacheModeENName)]的值:[$(pobjCacheModeEN.cacheModeENName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.memo) == false && undefined !== pobjCacheModeEN.memo && jsString_js_1.tzDataType.isString(pobjCacheModeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjCacheModeEN.memo)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjCacheModeEN.SetIsCheckProperty(true);
    }
    exports.CacheMode_CheckPropertyNew = CacheMode_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function CacheMode_CheckProperty4Update(pobjCacheModeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeId) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.cacheModeId) > 2) {
            throw new Error("(errid:Watl000062)字段[缓存方式Id(cacheModeId)]的长度不能超过2(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeId)(clsCacheModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeName) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.cacheModeName) > 50) {
            throw new Error("(errid:Watl000062)字段[缓存方式名(cacheModeName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeName)(clsCacheModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeENName) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.cacheModeENName) > 50) {
            throw new Error("(errid:Watl000062)字段[缓存方式英文名(cacheModeENName)]的长度不能超过50(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.cacheModeENName)(clsCacheModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjCacheModeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 缓存方式(CacheMode))!值:$(pobjCacheModeEN.memo)(clsCacheModeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeId) == false && undefined !== pobjCacheModeEN.cacheModeId && jsString_js_1.tzDataType.isString(pobjCacheModeEN.cacheModeId) === false) {
            throw new Error("(errid:Watl000063)字段[缓存方式Id(cacheModeId)]的值:[$(pobjCacheModeEN.cacheModeId)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeName) == false && undefined !== pobjCacheModeEN.cacheModeName && jsString_js_1.tzDataType.isString(pobjCacheModeEN.cacheModeName) === false) {
            throw new Error("(errid:Watl000063)字段[缓存方式名(cacheModeName)]的值:[$(pobjCacheModeEN.cacheModeName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeENName) == false && undefined !== pobjCacheModeEN.cacheModeENName && jsString_js_1.tzDataType.isString(pobjCacheModeEN.cacheModeENName) === false) {
            throw new Error("(errid:Watl000063)字段[缓存方式英文名(cacheModeENName)]的值:[$(pobjCacheModeEN.cacheModeENName)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.memo) == false && undefined !== pobjCacheModeEN.memo && jsString_js_1.tzDataType.isString(pobjCacheModeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjCacheModeEN.memo)], 非法，应该为字符型(In 缓存方式(CacheMode))!(clsCacheModeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjCacheModeEN.cacheModeId) === true) {
            throw new Error("(errid:Watl000064)字段[缓存方式Id]不能为空(In 缓存方式)!(clsCacheModeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjCacheModeEN.SetIsCheckProperty(true);
    }
    exports.CacheMode_CheckProperty4Update = CacheMode_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CacheMode_GetJSONStrByObj(pobjCacheModeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjCacheModeEN.sf_UpdFldSetStr = pobjCacheModeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjCacheModeEN);
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
    exports.CacheMode_GetJSONStrByObj = CacheMode_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function CacheMode_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrCacheModeObjLst = new Array();
        if (strJSON === "") {
            return arrCacheModeObjLst;
        }
        try {
            arrCacheModeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrCacheModeObjLst;
        }
        return arrCacheModeObjLst;
    }
    exports.CacheMode_GetObjLstByJSONStr = CacheMode_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrCacheModeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function CacheMode_GetObjLstByJSONObjLst(arrCacheModeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrCacheModeObjLst = new Array();
        for (const objInFor of arrCacheModeObjLstS) {
            const obj1 = CacheMode_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrCacheModeObjLst.push(obj1);
        }
        return arrCacheModeObjLst;
    }
    exports.CacheMode_GetObjLstByJSONObjLst = CacheMode_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function CacheMode_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjCacheModeEN = new clsCacheModeEN_js_1.clsCacheModeEN();
        if (strJSON === "") {
            return pobjCacheModeEN;
        }
        try {
            pobjCacheModeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjCacheModeEN;
        }
        return pobjCacheModeEN;
    }
    exports.CacheMode_GetObjByJSONStr = CacheMode_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function CacheMode_GetCombineCondition(objCacheMode_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId) == true) {
            const strComparisonOp_CacheModeId = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeId, objCacheMode_Cond.cacheModeId, strComparisonOp_CacheModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName) == true) {
            const strComparisonOp_CacheModeName = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeName, objCacheMode_Cond.cacheModeName, strComparisonOp_CacheModeName);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName) == true) {
            const strComparisonOp_CacheModeENName = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheModeEN_js_1.clsCacheModeEN.con_CacheModeENName, objCacheMode_Cond.cacheModeENName, strComparisonOp_CacheModeENName);
        }
        if (Object.prototype.hasOwnProperty.call(objCacheMode_Cond.dicFldComparisonOp, clsCacheModeEN_js_1.clsCacheModeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objCacheMode_Cond.dicFldComparisonOp[clsCacheModeEN_js_1.clsCacheModeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsCacheModeEN_js_1.clsCacheModeEN.con_Memo, objCacheMode_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.CacheMode_GetCombineCondition = CacheMode_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--CacheMode(缓存方式),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strCacheModeId: 缓存方式Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CacheMode_GetUniCondStr_CacheModeId(objCacheModeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and CacheModeId = '{0}'", objCacheModeEN.cacheModeId);
        return strWhereCond;
    }
    exports.CacheMode_GetUniCondStr_CacheModeId = CacheMode_GetUniCondStr_CacheModeId;
    /**
    *获取唯一性条件串(Uniqueness)--CacheMode(缓存方式),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strCacheModeId: 缓存方式Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function CacheMode_GetUniCondStr4Update_CacheModeId(objCacheModeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and CacheModeId <> '{0}'", objCacheModeEN.cacheModeId);
        strWhereCond += (0, clsString_js_1.Format)(" and CacheModeId = '{0}'", objCacheModeEN.cacheModeId);
        return strWhereCond;
    }
    exports.CacheMode_GetUniCondStr4Update_CacheModeId = CacheMode_GetUniCondStr4Update_CacheModeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objCacheModeENS:源对象
     * @param objCacheModeENT:目标对象
    */
    function CacheMode_CopyObjTo(objCacheModeENS, objCacheModeENT) {
        objCacheModeENT.cacheModeId = objCacheModeENS.cacheModeId; //缓存方式Id
        objCacheModeENT.cacheModeName = objCacheModeENS.cacheModeName; //缓存方式名
        objCacheModeENT.cacheModeENName = objCacheModeENS.cacheModeENName; //缓存方式英文名
        objCacheModeENT.memo = objCacheModeENS.memo; //备注
        objCacheModeENT.sf_UpdFldSetStr = objCacheModeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.CacheMode_CopyObjTo = CacheMode_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objCacheModeENS:源对象
     * @param objCacheModeENT:目标对象
    */
    function CacheMode_GetObjFromJsonObj(objCacheModeENS) {
        const objCacheModeENT = new clsCacheModeEN_js_1.clsCacheModeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objCacheModeENT, objCacheModeENS);
        return objCacheModeENT;
    }
    exports.CacheMode_GetObjFromJsonObj = CacheMode_GetObjFromJsonObj;
});
