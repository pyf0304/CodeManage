/**
* 类名:clsPageDispModeWApi
* 表名:PageDispMode(01120908)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:55
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:菜单管理(PrjMenu)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/PrjMenu/clsPageDispModeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PageDispMode_GetObjFromJsonObj = exports.PageDispMode_CopyObjTo = exports.PageDispMode_GetUniCondStr4Update_PageDispModeName = exports.PageDispMode_GetUniCondStr_PageDispModeName = exports.PageDispMode_GetCombineCondition = exports.PageDispMode_GetObjByJSONStr = exports.PageDispMode_GetObjLstByJSONObjLst = exports.PageDispMode_GetObjLstByJSONStr = exports.PageDispMode_GetJSONStrByObj = exports.PageDispMode_CheckProperty4Update = exports.PageDispMode_CheckPropertyNew = exports.PageDispMode__Cache = exports.PageDispMode_ReFreshThisCache = exports.PageDispMode_ReFreshCache = exports.PageDispMode_GetWebApiUrl = exports.PageDispMode_GetMaxStrIdByPrefix = exports.PageDispMode_GetMaxStrIdAsync = exports.PageDispMode_GetRecCountByCond_Cache = exports.PageDispMode_GetRecCountByCondAsync = exports.PageDispMode_IsExistAsync = exports.PageDispMode_IsExist_Cache = exports.PageDispMode_IsExist = exports.PageDispMode_IsExistRecordAsync = exports.PageDispMode_IsExistRecord_Cache = exports.PageDispMode_UpdateWithConditionAsync = exports.PageDispMode_UpdateRecordAsync = exports.PageDispMode_AddNewRecordWithReturnKey = exports.PageDispMode_AddNewRecordWithReturnKeyAsync = exports.PageDispMode_AddNewRecordWithMaxIdAsync = exports.PageDispMode_AddNewRecordAsync = exports.PageDispMode_DelPageDispModesByCondAsync = exports.PageDispMode_DelPageDispModesAsync = exports.PageDispMode_DelRecordAsync = exports.PageDispMode_GetObjLstByPagerAsync = exports.PageDispMode_GetObjLstByPager_Cache = exports.PageDispMode_GetObjLstByRange = exports.PageDispMode_GetObjLstByRangeAsync = exports.PageDispMode_GetTopObjLstAsync = exports.PageDispMode_GetObjLstByPageDispModeIdLst_Cache = exports.PageDispMode_GetObjLstByPageDispModeIdLstAsync = exports.PageDispMode_GetSubObjLst_Cache = exports.PageDispMode_GetObjLst_PureCache = exports.PageDispMode_GetObjLst_Cache = exports.PageDispMode_GetObjLst_sessionStorage_PureCache = exports.PageDispMode_GetObjLst_sessionStorage = exports.PageDispMode_GetObjLstAsync = exports.PageDispMode_GetObjLst_localStorage_PureCache = exports.PageDispMode_GetObjLst_localStorage = exports.PageDispMode_GetObjLst_ClientCache = exports.PageDispMode_GetFirstObjAsync = exports.PageDispMode_GetFirstID = exports.PageDispMode_GetFirstIDAsync = exports.PageDispMode_funcKey = exports.PageDispMode_FilterFunByKey = exports.PageDispMode_SortFunByKey = exports.PageDispMode_SortFun_Defa_2Fld = exports.PageDispMode_SortFun_Defa = exports.PageDispMode_func = exports.PageDispMode_GetNameByPageDispModeId_Cache = exports.PageDispMode_UpdateObjInLst_Cache = exports.PageDispMode_GetObjByPageDispModeId_localStorage = exports.PageDispMode_GetObjByPageDispModeId_Cache = exports.PageDispMode_GetObjByPageDispModeIdAsync = exports.pageDispMode_ConstructorName = exports.pageDispMode_Controller = void 0;
    /**
     * 页面显示模式(PageDispMode)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPageDispModeEN_js_1 = require("../../L0_Entity/PrjMenu/clsPageDispModeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.pageDispMode_Controller = "PageDispModeApi";
    exports.pageDispMode_ConstructorName = "pageDispMode";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPageDispModeId:关键字
    * @returns 对象
    **/
    async function PageDispMode_GetObjByPageDispModeIdAsync(strPageDispModeId) {
        const strThisFuncName = "GetObjByPageDispModeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPageDispModeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPageDispModeId]不能为空！(In clsPageDispModeWApi.GetObjByPageDispModeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPageDispModeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！(clsPageDispModeWApi.GetObjByPageDispModeIdAsync)", strPageDispModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPageDispModeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strPageDispModeId": strPageDispModeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objPageDispMode = PageDispMode_GetObjFromJsonObj(returnObj);
                return objPageDispMode;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetObjByPageDispModeIdAsync = PageDispMode_GetObjByPageDispModeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPageDispModeId:所给的关键字
     * @returns 对象
    */
    async function PageDispMode_GetObjByPageDispModeId_Cache(strPageDispModeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPageDispModeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPageDispModeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPageDispModeId]不能为空！(In clsPageDispModeWApi.GetObjByPageDispModeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPageDispModeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！(clsPageDispModeWApi.GetObjByPageDispModeId_Cache)", strPageDispModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        try {
            const arrPageDispMode_Sel = arrPageDispModeObjLst_Cache.filter(x => x.pageDispModeId == strPageDispModeId);
            let objPageDispMode;
            if (arrPageDispMode_Sel.length > 0) {
                objPageDispMode = arrPageDispMode_Sel[0];
                return objPageDispMode;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objPageDispMode_Const = await PageDispMode_GetObjByPageDispModeIdAsync(strPageDispModeId);
                    if (objPageDispMode_Const != null) {
                        PageDispMode_ReFreshThisCache();
                        return objPageDispMode_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPageDispModeId, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PageDispMode_GetObjByPageDispModeId_Cache = PageDispMode_GetObjByPageDispModeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPageDispModeId:所给的关键字
     * @returns 对象
    */
    async function PageDispMode_GetObjByPageDispModeId_localStorage(strPageDispModeId) {
        const strThisFuncName = "GetObjByPageDispModeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPageDispModeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPageDispModeId]不能为空！(In clsPageDispModeWApi.GetObjByPageDispModeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPageDispModeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！(clsPageDispModeWApi.GetObjByPageDispModeId_localStorage)", strPageDispModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName, strPageDispModeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPageDispMode_Cache = JSON.parse(strTempObj);
            return objPageDispMode_Cache;
        }
        try {
            const objPageDispMode = await PageDispMode_GetObjByPageDispModeIdAsync(strPageDispModeId);
            if (objPageDispMode != null) {
                localStorage.setItem(strKey, JSON.stringify(objPageDispMode));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPageDispMode;
            }
            return objPageDispMode;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPageDispModeId, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PageDispMode_GetObjByPageDispModeId_localStorage = PageDispMode_GetObjByPageDispModeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPageDispMode:所给的对象
     * @returns 对象
    */
    async function PageDispMode_UpdateObjInLst_Cache(objPageDispMode) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
            const obj = arrPageDispModeObjLst_Cache.find(x => x.pageDispModeName == objPageDispMode.pageDispModeName);
            if (obj != null) {
                objPageDispMode.pageDispModeId = obj.pageDispModeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPageDispMode);
            }
            else {
                arrPageDispModeObjLst_Cache.push(objPageDispMode);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PageDispMode_UpdateObjInLst_Cache = PageDispMode_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strPageDispModeId:所给的关键字
     * @returns 对象
    */
    async function PageDispMode_GetNameByPageDispModeId_Cache(strPageDispModeId) {
        const strThisFuncName = "GetNameByPageDispModeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPageDispModeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPageDispModeId]不能为空！(In clsPageDispModeWApi.GetNameByPageDispModeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPageDispModeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPageDispModeId]的长度:[{0}]不正确！(clsPageDispModeWApi.GetNameByPageDispModeId_Cache)", strPageDispModeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        if (arrPageDispModeObjLst_Cache == null)
            return "";
        try {
            const arrPageDispMode_Sel = arrPageDispModeObjLst_Cache.filter(x => x.pageDispModeId == strPageDispModeId);
            let objPageDispMode;
            if (arrPageDispMode_Sel.length > 0) {
                objPageDispMode = arrPageDispMode_Sel[0];
                return objPageDispMode.pageDispModeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPageDispModeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.PageDispMode_GetNameByPageDispModeId_Cache = PageDispMode_GetNameByPageDispModeId_Cache;
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
    async function PageDispMode_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPageDispModeEN_js_1.clsPageDispModeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsPageDispModeEN_js_1.clsPageDispModeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPageDispModeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objPageDispMode = await PageDispMode_GetObjByPageDispModeId_Cache(strPageDispModeId);
        if (objPageDispMode == null)
            return "";
        if (objPageDispMode.GetFldValue(strOutFldName) == null)
            return "";
        return objPageDispMode.GetFldValue(strOutFldName).toString();
    }
    exports.PageDispMode_func = PageDispMode_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PageDispMode_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.pageDispModeId.localeCompare(b.pageDispModeId);
    }
    exports.PageDispMode_SortFun_Defa = PageDispMode_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PageDispMode_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.pageDispModeName == b.pageDispModeName)
            return a.pageDispModeENName.localeCompare(b.pageDispModeENName);
        else
            return a.pageDispModeName.localeCompare(b.pageDispModeName);
    }
    exports.PageDispMode_SortFun_Defa_2Fld = PageDispMode_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PageDispMode_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId:
                    return (a, b) => {
                        return a.pageDispModeId.localeCompare(b.pageDispModeId);
                    };
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName:
                    return (a, b) => {
                        return a.pageDispModeName.localeCompare(b.pageDispModeName);
                    };
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeENName:
                    return (a, b) => {
                        return a.pageDispModeENName.localeCompare(b.pageDispModeENName);
                    };
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PageDispMode]中不存在！(in ${exports.pageDispMode_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId:
                    return (a, b) => {
                        return b.pageDispModeId.localeCompare(a.pageDispModeId);
                    };
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName:
                    return (a, b) => {
                        return b.pageDispModeName.localeCompare(a.pageDispModeName);
                    };
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeENName:
                    return (a, b) => {
                        return b.pageDispModeENName.localeCompare(a.pageDispModeENName);
                    };
                case clsPageDispModeEN_js_1.clsPageDispModeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PageDispMode]中不存在！(in ${exports.pageDispMode_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PageDispMode_SortFunByKey = PageDispMode_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PageDispMode_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId:
                return (obj) => {
                    return obj.pageDispModeId === value;
                };
            case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName:
                return (obj) => {
                    return obj.pageDispModeName === value;
                };
            case clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeENName:
                return (obj) => {
                    return obj.pageDispModeENName === value;
                };
            case clsPageDispModeEN_js_1.clsPageDispModeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PageDispMode]中不存在！(in ${exports.pageDispMode_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PageDispMode_FilterFunByKey = PageDispMode_FilterFunByKey;
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
    async function PageDispMode_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrPageDispMode = await PageDispMode_GetObjLst_Cache();
        if (arrPageDispMode == null)
            return [];
        let arrPageDispMode_Sel = arrPageDispMode;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrPageDispMode_Sel.length == 0)
            return [];
        return arrPageDispMode_Sel.map(x => x.pageDispModeId);
    }
    exports.PageDispMode_funcKey = PageDispMode_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PageDispMode_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetFirstIDAsync = PageDispMode_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PageDispMode_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetFirstID = PageDispMode_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PageDispMode_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const objPageDispMode = PageDispMode_GetObjFromJsonObj(returnObj);
                return objPageDispMode;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetFirstObjAsync = PageDispMode_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPageDispModeEN_js_1.clsPageDispModeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPageDispModeEN_js_1.clsPageDispModeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPageDispModeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrPageDispModeObjLst_T = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeExObjLst_Cache);
            return arrPageDispModeObjLst_T;
        }
        try {
            const arrPageDispModeExObjLst = await PageDispMode_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPageDispModeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPageDispModeExObjLst.length);
            console.log(strInfo);
            return arrPageDispModeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PageDispMode_GetObjLst_ClientCache = PageDispMode_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPageDispModeEN_js_1.clsPageDispModeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPageDispModeEN_js_1.clsPageDispModeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPageDispModeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPageDispModeObjLst_T = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeExObjLst_Cache);
            return arrPageDispModeObjLst_T;
        }
        try {
            const arrPageDispModeExObjLst = await PageDispMode_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPageDispModeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPageDispModeExObjLst.length);
            console.log(strInfo);
            return arrPageDispModeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PageDispMode_GetObjLst_localStorage = PageDispMode_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPageDispModeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPageDispModeObjLst_Cache;
        }
        else
            return null;
    }
    exports.PageDispMode_GetObjLst_localStorage_PureCache = PageDispMode_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PageDispMode_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pageDispMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetObjLstAsync = PageDispMode_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPageDispModeEN_js_1.clsPageDispModeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPageDispModeEN_js_1.clsPageDispModeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPageDispModeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPageDispModeObjLst_T = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeExObjLst_Cache);
            return arrPageDispModeObjLst_T;
        }
        try {
            const arrPageDispModeExObjLst = await PageDispMode_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPageDispModeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPageDispModeExObjLst.length);
            console.log(strInfo);
            return arrPageDispModeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PageDispMode_GetObjLst_sessionStorage = PageDispMode_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPageDispModeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPageDispModeObjLst_Cache;
        }
        else
            return null;
    }
    exports.PageDispMode_GetObjLst_sessionStorage_PureCache = PageDispMode_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrPageDispModeObjLst_Cache;
        switch (clsPageDispModeEN_js_1.clsPageDispModeEN.CacheModeId) {
            case "04": //sessionStorage
                arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_ClientCache();
                break;
            default:
                arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_ClientCache();
                break;
        }
        const arrPageDispModeObjLst = PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeObjLst_Cache);
        return arrPageDispModeObjLst_Cache;
    }
    exports.PageDispMode_GetObjLst_Cache = PageDispMode_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PageDispMode_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPageDispModeObjLst_Cache;
        switch (clsPageDispModeEN_js_1.clsPageDispModeEN.CacheModeId) {
            case "04": //sessionStorage
                arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrPageDispModeObjLst_Cache = null;
                break;
            default:
                arrPageDispModeObjLst_Cache = null;
                break;
        }
        return arrPageDispModeObjLst_Cache;
    }
    exports.PageDispMode_GetObjLst_PureCache = PageDispMode_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPageDispModeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PageDispMode_GetSubObjLst_Cache(objPageDispMode_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        let arrPageDispMode_Sel = arrPageDispModeObjLst_Cache;
        if (objPageDispMode_Cond.sf_FldComparisonOp == null || objPageDispMode_Cond.sf_FldComparisonOp == "")
            return arrPageDispMode_Sel;
        const dicFldComparisonOp = JSON.parse(objPageDispMode_Cond.sf_FldComparisonOp);
        //console.log("clsPageDispModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPageDispMode_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPageDispMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPageDispMode_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPageDispMode_Cond), exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PageDispMode_GetSubObjLst_Cache = PageDispMode_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPageDispModeId:关键字列表
    * @returns 对象列表
    **/
    async function PageDispMode_GetObjLstByPageDispModeIdLstAsync(arrPageDispModeId) {
        const strThisFuncName = "GetObjLstByPageDispModeIdLstAsync";
        const strAction = "GetObjLstByPageDispModeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPageDispModeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pageDispMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetObjLstByPageDispModeIdLstAsync = PageDispMode_GetObjLstByPageDispModeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPageDispModeIdLst:关键字列表
     * @returns 对象列表
    */
    async function PageDispMode_GetObjLstByPageDispModeIdLst_Cache(arrPageDispModeIdLst) {
        const strThisFuncName = "GetObjLstByPageDispModeIdLst_Cache";
        try {
            const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
            const arrPageDispMode_Sel = arrPageDispModeObjLst_Cache.filter(x => arrPageDispModeIdLst.indexOf(x.pageDispModeId) > -1);
            return arrPageDispMode_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPageDispModeIdLst.join(","), exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.PageDispMode_GetObjLstByPageDispModeIdLst_Cache = PageDispMode_GetObjLstByPageDispModeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PageDispMode_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pageDispMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetTopObjLstAsync = PageDispMode_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PageDispMode_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pageDispMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetObjLstByRangeAsync = PageDispMode_GetObjLstByRangeAsync;
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
    async function PageDispMode_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetObjLstByRange = PageDispMode_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PageDispMode_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        if (arrPageDispModeObjLst_Cache.length == 0)
            return arrPageDispModeObjLst_Cache;
        let arrPageDispMode_Sel = arrPageDispModeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPageDispMode_Cond = new clsPageDispModeEN_js_1.clsPageDispModeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPageDispMode_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPageDispModeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPageDispMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPageDispMode_Sel.length == 0)
                return arrPageDispMode_Sel;
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
                arrPageDispMode_Sel = arrPageDispMode_Sel.sort(PageDispMode_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPageDispMode_Sel = arrPageDispMode_Sel.sort(objPagerPara.sortFun);
            }
            arrPageDispMode_Sel = arrPageDispMode_Sel.slice(intStart, intEnd);
            return arrPageDispMode_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PageDispMode_GetObjLstByPager_Cache = PageDispMode_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PageDispMode_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.pageDispMode_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PageDispMode_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetObjLstByPagerAsync = PageDispMode_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strPageDispModeId:关键字
    * @returns 获取删除的结果
    **/
    async function PageDispMode_DelRecordAsync(strPageDispModeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strPageDispModeId);
        try {
            const response = await axios_1.default.delete(strUrl);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_DelRecordAsync = PageDispMode_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPageDispModeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PageDispMode_DelPageDispModesAsync(arrPageDispModeId) {
        const strThisFuncName = "DelPageDispModesAsync";
        const strAction = "DelPageDispModes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPageDispModeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_DelPageDispModesAsync = PageDispMode_DelPageDispModesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PageDispMode_DelPageDispModesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPageDispModesByCondAsync";
        const strAction = "DelPageDispModesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_DelPageDispModesByCondAsync = PageDispMode_DelPageDispModesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPageDispModeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PageDispMode_AddNewRecordAsync(objPageDispModeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPageDispModeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPageDispModeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_AddNewRecordAsync = PageDispMode_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objPageDispModeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PageDispMode_AddNewRecordWithMaxIdAsync(objPageDispModeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPageDispModeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_AddNewRecordWithMaxIdAsync = PageDispMode_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPageDispModeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PageDispMode_AddNewRecordWithReturnKeyAsync(objPageDispModeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPageDispModeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_AddNewRecordWithReturnKeyAsync = PageDispMode_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPageDispModeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PageDispMode_AddNewRecordWithReturnKey(objPageDispModeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPageDispModeEN.pageDispModeId === null || objPageDispModeEN.pageDispModeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPageDispModeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_AddNewRecordWithReturnKey = PageDispMode_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPageDispModeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PageDispMode_UpdateRecordAsync(objPageDispModeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPageDispModeEN.sf_UpdFldSetStr === undefined || objPageDispModeEN.sf_UpdFldSetStr === null || objPageDispModeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPageDispModeEN.pageDispModeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPageDispModeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_UpdateRecordAsync = PageDispMode_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPageDispModeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PageDispMode_UpdateWithConditionAsync(objPageDispModeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPageDispModeEN.sf_UpdFldSetStr === undefined || objPageDispModeEN.sf_UpdFldSetStr === null || objPageDispModeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPageDispModeEN.pageDispModeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        objPageDispModeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPageDispModeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_UpdateWithConditionAsync = PageDispMode_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPageDispModeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PageDispMode_IsExistRecord_Cache(objPageDispMode_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        if (arrPageDispModeObjLst_Cache == null)
            return false;
        let arrPageDispMode_Sel = arrPageDispModeObjLst_Cache;
        if (objPageDispMode_Cond.sf_FldComparisonOp == null || objPageDispMode_Cond.sf_FldComparisonOp == "")
            return arrPageDispMode_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPageDispMode_Cond.sf_FldComparisonOp);
        //console.log("clsPageDispModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPageDispMode_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPageDispMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPageDispMode_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPageDispMode_Cond), exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PageDispMode_IsExistRecord_Cache = PageDispMode_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PageDispMode_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_IsExistRecordAsync = PageDispMode_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPageDispModeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PageDispMode_IsExist(strPageDispModeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PageDispModeId": strPageDispModeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_IsExist = PageDispMode_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPageDispModeId:所给的关键字
     * @returns 对象
    */
    async function PageDispMode_IsExist_Cache(strPageDispModeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        if (arrPageDispModeObjLst_Cache == null)
            return false;
        try {
            const arrPageDispMode_Sel = arrPageDispModeObjLst_Cache.filter(x => x.pageDispModeId == strPageDispModeId);
            if (arrPageDispMode_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPageDispModeId, exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PageDispMode_IsExist_Cache = PageDispMode_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPageDispModeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PageDispMode_IsExistAsync(strPageDispModeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPageDispModeId": strPageDispModeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_IsExistAsync = PageDispMode_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PageDispMode_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetRecCountByCondAsync = PageDispMode_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPageDispMode_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PageDispMode_GetRecCountByCond_Cache(objPageDispMode_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPageDispModeObjLst_Cache = await PageDispMode_GetObjLst_Cache();
        if (arrPageDispModeObjLst_Cache == null)
            return 0;
        let arrPageDispMode_Sel = arrPageDispModeObjLst_Cache;
        if (objPageDispMode_Cond.sf_FldComparisonOp == null || objPageDispMode_Cond.sf_FldComparisonOp == "")
            return arrPageDispMode_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPageDispMode_Cond.sf_FldComparisonOp);
        //console.log("clsPageDispModeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPageDispMode_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPageDispMode_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPageDispMode_Sel = arrPageDispMode_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPageDispMode_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPageDispMode_Cond), exports.pageDispMode_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PageDispMode_GetRecCountByCond_Cache = PageDispMode_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function PageDispMode_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetMaxStrIdAsync = PageDispMode_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function PageDispMode_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.pageDispMode_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.pageDispMode_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PageDispMode_GetMaxStrIdByPrefix = PageDispMode_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PageDispMode_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.PageDispMode_GetWebApiUrl = PageDispMode_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PageDispMode_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
        switch (clsPageDispModeEN_js_1.clsPageDispModeEN.CacheModeId) {
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
    }
    exports.PageDispMode_ReFreshCache = PageDispMode_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PageDispMode_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsPageDispModeEN_js_1.clsPageDispModeEN._CurrTabName;
            switch (clsPageDispModeEN_js_1.clsPageDispModeEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.PageDispMode_ReFreshThisCache = PageDispMode_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function PageDispMode__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await PageDispMode_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId, clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName, "页面显示模式");
    }
    exports.PageDispMode__Cache = PageDispMode__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PageDispMode_CheckPropertyNew(pobjPageDispModeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeName) === true) {
            throw new Error("(errid:Watl000058)字段[页面显示模式名称]不能为空(In 页面显示模式)!(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeENName) === true) {
            throw new Error("(errid:Watl000058)字段[页面显示模式英文名]不能为空(In 页面显示模式)!(clsPageDispModeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeId) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.pageDispModeId) > 2) {
            throw new Error("(errid:Watl000059)字段[页面显示模式Id(pageDispModeId)]的长度不能超过2(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeId)(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeName) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.pageDispModeName) > 50) {
            throw new Error("(errid:Watl000059)字段[页面显示模式名称(pageDispModeName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeName)(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeENName) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.pageDispModeENName) > 50) {
            throw new Error("(errid:Watl000059)字段[页面显示模式英文名(pageDispModeENName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeENName)(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.memo)(clsPageDispModeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeId) == false && undefined !== pobjPageDispModeEN.pageDispModeId && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.pageDispModeId) === false) {
            throw new Error("(errid:Watl000060)字段[页面显示模式Id(pageDispModeId)]的值:[$(pobjPageDispModeEN.pageDispModeId)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeName) == false && undefined !== pobjPageDispModeEN.pageDispModeName && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.pageDispModeName) === false) {
            throw new Error("(errid:Watl000060)字段[页面显示模式名称(pageDispModeName)]的值:[$(pobjPageDispModeEN.pageDispModeName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeENName) == false && undefined !== pobjPageDispModeEN.pageDispModeENName && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.pageDispModeENName) === false) {
            throw new Error("(errid:Watl000060)字段[页面显示模式英文名(pageDispModeENName)]的值:[$(pobjPageDispModeEN.pageDispModeENName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.memo) == false && undefined !== pobjPageDispModeEN.memo && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPageDispModeEN.memo)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPageDispModeEN.SetIsCheckProperty(true);
    }
    exports.PageDispMode_CheckPropertyNew = PageDispMode_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PageDispMode_CheckProperty4Update(pobjPageDispModeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeId) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.pageDispModeId) > 2) {
            throw new Error("(errid:Watl000062)字段[页面显示模式Id(pageDispModeId)]的长度不能超过2(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeId)(clsPageDispModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeName) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.pageDispModeName) > 50) {
            throw new Error("(errid:Watl000062)字段[页面显示模式名称(pageDispModeName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeName)(clsPageDispModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeENName) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.pageDispModeENName) > 50) {
            throw new Error("(errid:Watl000062)字段[页面显示模式英文名(pageDispModeENName)]的长度不能超过50(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.pageDispModeENName)(clsPageDispModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPageDispModeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 页面显示模式(PageDispMode))!值:$(pobjPageDispModeEN.memo)(clsPageDispModeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeId) == false && undefined !== pobjPageDispModeEN.pageDispModeId && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.pageDispModeId) === false) {
            throw new Error("(errid:Watl000063)字段[页面显示模式Id(pageDispModeId)]的值:[$(pobjPageDispModeEN.pageDispModeId)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeName) == false && undefined !== pobjPageDispModeEN.pageDispModeName && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.pageDispModeName) === false) {
            throw new Error("(errid:Watl000063)字段[页面显示模式名称(pageDispModeName)]的值:[$(pobjPageDispModeEN.pageDispModeName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeENName) == false && undefined !== pobjPageDispModeEN.pageDispModeENName && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.pageDispModeENName) === false) {
            throw new Error("(errid:Watl000063)字段[页面显示模式英文名(pageDispModeENName)]的值:[$(pobjPageDispModeEN.pageDispModeENName)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.memo) == false && undefined !== pobjPageDispModeEN.memo && clsString_js_1.tzDataType.isString(pobjPageDispModeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPageDispModeEN.memo)], 非法，应该为字符型(In 页面显示模式(PageDispMode))!(clsPageDispModeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPageDispModeEN.pageDispModeId) === true) {
            throw new Error("(errid:Watl000064)字段[页面显示模式Id]不能为空(In 页面显示模式)!(clsPageDispModeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjPageDispModeEN.SetIsCheckProperty(true);
    }
    exports.PageDispMode_CheckProperty4Update = PageDispMode_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PageDispMode_GetJSONStrByObj(pobjPageDispModeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPageDispModeEN.sf_UpdFldSetStr = pobjPageDispModeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPageDispModeEN);
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
    exports.PageDispMode_GetJSONStrByObj = PageDispMode_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PageDispMode_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPageDispModeObjLst = new Array();
        if (strJSON === "") {
            return arrPageDispModeObjLst;
        }
        try {
            arrPageDispModeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPageDispModeObjLst;
        }
        return arrPageDispModeObjLst;
    }
    exports.PageDispMode_GetObjLstByJSONStr = PageDispMode_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPageDispModeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PageDispMode_GetObjLstByJSONObjLst(arrPageDispModeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPageDispModeObjLst = new Array();
        for (const objInFor of arrPageDispModeObjLstS) {
            const obj1 = PageDispMode_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPageDispModeObjLst.push(obj1);
        }
        return arrPageDispModeObjLst;
    }
    exports.PageDispMode_GetObjLstByJSONObjLst = PageDispMode_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PageDispMode_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPageDispModeEN = new clsPageDispModeEN_js_1.clsPageDispModeEN();
        if (strJSON === "") {
            return pobjPageDispModeEN;
        }
        try {
            pobjPageDispModeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPageDispModeEN;
        }
        return pobjPageDispModeEN;
    }
    exports.PageDispMode_GetObjByJSONStr = PageDispMode_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PageDispMode_GetCombineCondition(objPageDispMode_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId) == true) {
            const strComparisonOp_PageDispModeId = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeId, objPageDispMode_Cond.pageDispModeId, strComparisonOp_PageDispModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName) == true) {
            const strComparisonOp_PageDispModeName = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeName, objPageDispMode_Cond.pageDispModeName, strComparisonOp_PageDispModeName);
        }
        if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeENName) == true) {
            const strComparisonOp_PageDispModeENName = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPageDispModeEN_js_1.clsPageDispModeEN.con_PageDispModeENName, objPageDispMode_Cond.pageDispModeENName, strComparisonOp_PageDispModeENName);
        }
        if (Object.prototype.hasOwnProperty.call(objPageDispMode_Cond.dicFldComparisonOp, clsPageDispModeEN_js_1.clsPageDispModeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPageDispMode_Cond.dicFldComparisonOp[clsPageDispModeEN_js_1.clsPageDispModeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPageDispModeEN_js_1.clsPageDispModeEN.con_Memo, objPageDispMode_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.PageDispMode_GetCombineCondition = PageDispMode_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PageDispMode(页面显示模式),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPageDispModeName: 页面显示模式名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PageDispMode_GetUniCondStr_PageDispModeName(objPageDispModeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PageDispModeName = '{0}'", objPageDispModeEN.pageDispModeName);
        return strWhereCond;
    }
    exports.PageDispMode_GetUniCondStr_PageDispModeName = PageDispMode_GetUniCondStr_PageDispModeName;
    /**
    *获取唯一性条件串(Uniqueness)--PageDispMode(页面显示模式),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPageDispModeName: 页面显示模式名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PageDispMode_GetUniCondStr4Update_PageDispModeName(objPageDispModeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PageDispModeId <> '{0}'", objPageDispModeEN.pageDispModeId);
        strWhereCond += (0, clsString_js_2.Format)(" and PageDispModeName = '{0}'", objPageDispModeEN.pageDispModeName);
        return strWhereCond;
    }
    exports.PageDispMode_GetUniCondStr4Update_PageDispModeName = PageDispMode_GetUniCondStr4Update_PageDispModeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPageDispModeENS:源对象
     * @param objPageDispModeENT:目标对象
    */
    function PageDispMode_CopyObjTo(objPageDispModeENS, objPageDispModeENT) {
        objPageDispModeENT.pageDispModeId = objPageDispModeENS.pageDispModeId; //页面显示模式Id
        objPageDispModeENT.pageDispModeName = objPageDispModeENS.pageDispModeName; //页面显示模式名称
        objPageDispModeENT.pageDispModeENName = objPageDispModeENS.pageDispModeENName; //页面显示模式英文名
        objPageDispModeENT.memo = objPageDispModeENS.memo; //备注
        objPageDispModeENT.sf_UpdFldSetStr = objPageDispModeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PageDispMode_CopyObjTo = PageDispMode_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPageDispModeENS:源对象
     * @param objPageDispModeENT:目标对象
    */
    function PageDispMode_GetObjFromJsonObj(objPageDispModeENS) {
        const objPageDispModeENT = new clsPageDispModeEN_js_1.clsPageDispModeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPageDispModeENT, objPageDispModeENS);
        return objPageDispModeENT;
    }
    exports.PageDispMode_GetObjFromJsonObj = PageDispMode_GetObjFromJsonObj;
});
