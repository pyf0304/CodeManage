/**
* 类名:clsSysSecurityLevelWApi
* 表名:SysSecurityLevel(01120651)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:22
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培参数(ParameterTable)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsSysSecurityLevelEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSecurityLevel_GetObjFromJsonObj = exports.SysSecurityLevel_CopyObjTo = exports.SysSecurityLevel_GetUniCondStr4Update_LevelId = exports.SysSecurityLevel_GetUniCondStr_LevelId = exports.SysSecurityLevel_GetCombineCondition = exports.SysSecurityLevel_GetObjByJSONStr = exports.SysSecurityLevel_GetObjLstByJSONObjLst = exports.SysSecurityLevel_GetObjLstByJSONStr = exports.SysSecurityLevel_GetJSONStrByObj = exports.SysSecurityLevel_CheckProperty4Update = exports.SysSecurityLevel_CheckPropertyNew = exports.SysSecurityLevel_BindDdl_LevelIdInDiv_Cache = exports.SysSecurityLevel_ReFreshThisCache = exports.SysSecurityLevel_ReFreshCache = exports.SysSecurityLevel_GetWebApiUrl = exports.SysSecurityLevel_GetMaxStrIdByPrefix = exports.SysSecurityLevel_GetMaxStrIdAsync = exports.SysSecurityLevel_GetRecCountByCond_Cache = exports.SysSecurityLevel_GetRecCountByCondAsync = exports.SysSecurityLevel_IsExistAsync = exports.SysSecurityLevel_IsExist_Cache = exports.SysSecurityLevel_IsExist = exports.SysSecurityLevel_IsExistRecordAsync = exports.SysSecurityLevel_IsExistRecord_Cache = exports.SysSecurityLevel_UpdateWithConditionAsync = exports.SysSecurityLevel_UpdateRecordAsync = exports.SysSecurityLevel_AddNewRecordWithReturnKey = exports.SysSecurityLevel_AddNewRecordWithReturnKeyAsync = exports.SysSecurityLevel_AddNewRecordWithMaxIdAsync = exports.SysSecurityLevel_AddNewRecordAsync = exports.SysSecurityLevel_DelSysSecurityLevelsByCondAsync = exports.SysSecurityLevel_DelSysSecurityLevelsAsync = exports.SysSecurityLevel_DelRecordAsync = exports.SysSecurityLevel_GetObjLstByPagerAsync = exports.SysSecurityLevel_GetObjLstByPager_Cache = exports.SysSecurityLevel_GetObjLstByRange = exports.SysSecurityLevel_GetObjLstByRangeAsync = exports.SysSecurityLevel_GetTopObjLstAsync = exports.SysSecurityLevel_GetObjLstByLevelIdLst_Cache = exports.SysSecurityLevel_GetObjLstByLevelIdLstAsync = exports.SysSecurityLevel_GetSubObjLst_Cache = exports.SysSecurityLevel_GetObjLst_PureCache = exports.SysSecurityLevel_GetObjLst_Cache = exports.SysSecurityLevel_GetObjLst_sessionStorage_PureCache = exports.SysSecurityLevel_GetObjLst_sessionStorage = exports.SysSecurityLevel_GetObjLstAsync = exports.SysSecurityLevel_GetObjLst_localStorage_PureCache = exports.SysSecurityLevel_GetObjLst_localStorage = exports.SysSecurityLevel_GetObjLst_ClientCache = exports.SysSecurityLevel_GetFirstObjAsync = exports.SysSecurityLevel_GetFirstID = exports.SysSecurityLevel_GetFirstIDAsync = exports.SysSecurityLevel_FilterFunByKey = exports.SysSecurityLevel_SortFunByKey = exports.SysSecurityLevel_SortFun_Defa_2Fld = exports.SysSecurityLevel_SortFun_Defa = exports.SysSecurityLevel_func = exports.SysSecurityLevel_GetNameByLevelId_Cache = exports.SysSecurityLevel_UpdateObjInLst_Cache = exports.SysSecurityLevel_GetObjByLevelId_localStorage = exports.SysSecurityLevel_GetObjByLevelId_Cache = exports.SysSecurityLevel_GetObjByLevelIdAsync = exports.sysSecurityLevel_ConstructorName = exports.sysSecurityLevel_Controller = void 0;
    /**
     * 保密级别表(SysSecurityLevel)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSysSecurityLevelEN_js_1 = require("../../L0_Entity/ParameterTable/clsSysSecurityLevelEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysSecurityLevel_Controller = "SysSecurityLevelApi";
    exports.sysSecurityLevel_ConstructorName = "sysSecurityLevel";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strLevelId:关键字
    * @returns 对象
    **/
    async function SysSecurityLevel_GetObjByLevelIdAsync(strLevelId) {
        const strThisFuncName = "GetObjByLevelIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLevelId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLevelId]不能为空！(In GetObjByLevelIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLevelId]的长度:[{0}]不正确！", strLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByLevelId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strLevelId": strLevelId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysSecurityLevel = SysSecurityLevel_GetObjFromJsonObj(returnObj);
                return objSysSecurityLevel;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetObjByLevelIdAsync = SysSecurityLevel_GetObjByLevelIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strLevelId:所给的关键字
     * @returns 对象
    */
    async function SysSecurityLevel_GetObjByLevelId_Cache(strLevelId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByLevelId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLevelId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLevelId]不能为空！(In GetObjByLevelId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLevelId]的长度:[{0}]不正确！", strLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        try {
            const arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache.filter(x => x.levelId == strLevelId);
            let objSysSecurityLevel;
            if (arrSysSecurityLevel_Sel.length > 0) {
                objSysSecurityLevel = arrSysSecurityLevel_Sel[0];
                return objSysSecurityLevel;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objSysSecurityLevel = await SysSecurityLevel_GetObjByLevelIdAsync(strLevelId);
                    if (objSysSecurityLevel != null) {
                        SysSecurityLevel_ReFreshThisCache();
                        return objSysSecurityLevel;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLevelId, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SysSecurityLevel_GetObjByLevelId_Cache = SysSecurityLevel_GetObjByLevelId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strLevelId:所给的关键字
     * @returns 对象
    */
    async function SysSecurityLevel_GetObjByLevelId_localStorage(strLevelId) {
        const strThisFuncName = "GetObjByLevelId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLevelId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLevelId]不能为空！(In GetObjByLevelId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLevelId]的长度:[{0}]不正确！", strLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName, strLevelId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSysSecurityLevel_Cache = JSON.parse(strTempObj);
            return objSysSecurityLevel_Cache;
        }
        try {
            const objSysSecurityLevel = await SysSecurityLevel_GetObjByLevelIdAsync(strLevelId);
            if (objSysSecurityLevel != null) {
                localStorage.setItem(strKey, JSON.stringify(objSysSecurityLevel));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSysSecurityLevel;
            }
            return objSysSecurityLevel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLevelId, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SysSecurityLevel_GetObjByLevelId_localStorage = SysSecurityLevel_GetObjByLevelId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSysSecurityLevel:所给的对象
     * @returns 对象
    */
    async function SysSecurityLevel_UpdateObjInLst_Cache(objSysSecurityLevel) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
            const obj = arrSysSecurityLevelObjLst_Cache.find(x => x.levelId == objSysSecurityLevel.levelId);
            if (obj != null) {
                objSysSecurityLevel.levelId = obj.levelId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSysSecurityLevel);
            }
            else {
                arrSysSecurityLevelObjLst_Cache.push(objSysSecurityLevel);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SysSecurityLevel_UpdateObjInLst_Cache = SysSecurityLevel_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strLevelId:所给的关键字
     * @returns 对象
    */
    async function SysSecurityLevel_GetNameByLevelId_Cache(strLevelId) {
        const strThisFuncName = "GetNameByLevelId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLevelId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLevelId]不能为空！(In GetNameByLevelId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLevelId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLevelId]的长度:[{0}]不正确！", strLevelId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        if (arrSysSecurityLevelObjLst_Cache == null)
            return "";
        try {
            const arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache.filter(x => x.levelId == strLevelId);
            let objSysSecurityLevel;
            if (arrSysSecurityLevel_Sel.length > 0) {
                objSysSecurityLevel = arrSysSecurityLevel_Sel[0];
                return objSysSecurityLevel.levelName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strLevelId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.SysSecurityLevel_GetNameByLevelId_Cache = SysSecurityLevel_GetNameByLevelId_Cache;
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
    async function SysSecurityLevel_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strLevelId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSysSecurityLevel = await SysSecurityLevel_GetObjByLevelId_Cache(strLevelId);
        if (objSysSecurityLevel == null)
            return "";
        return objSysSecurityLevel.GetFldValue(strOutFldName).toString();
    }
    exports.SysSecurityLevel_func = SysSecurityLevel_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSecurityLevel_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.levelId.localeCompare(b.levelId);
    }
    exports.SysSecurityLevel_SortFun_Defa = SysSecurityLevel_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSecurityLevel_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.levelName == b.levelName)
            return a.memo.localeCompare(b.memo);
        else
            return a.levelName.localeCompare(b.levelName);
    }
    exports.SysSecurityLevel_SortFun_Defa_2Fld = SysSecurityLevel_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSecurityLevel_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId:
                    return (a, b) => {
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName:
                    return (a, b) => {
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSecurityLevel]中不存在！(in ${exports.sysSecurityLevel_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId:
                    return (a, b) => {
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName:
                    return (a, b) => {
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSecurityLevel]中不存在！(in ${exports.sysSecurityLevel_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysSecurityLevel_SortFunByKey = SysSecurityLevel_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSecurityLevel_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysSecurityLevel]中不存在！(in ${exports.sysSecurityLevel_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysSecurityLevel_FilterFunByKey = SysSecurityLevel_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSecurityLevel_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetFirstIDAsync = SysSecurityLevel_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysSecurityLevel_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetFirstID = SysSecurityLevel_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysSecurityLevel_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysSecurityLevel = SysSecurityLevel_GetObjFromJsonObj(returnObj);
                return objSysSecurityLevel;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetFirstObjAsync = SysSecurityLevel_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
        clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSysSecurityLevelExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrSysSecurityLevelObjLst_T = SysSecurityLevel_GetObjLstByJSONObjLst(arrSysSecurityLevelExObjLst_Cache);
            return arrSysSecurityLevelObjLst_T;
        }
        try {
            const arrSysSecurityLevelExObjLst = await SysSecurityLevel_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrSysSecurityLevelExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSecurityLevelExObjLst.length);
            console.log(strInfo);
            return arrSysSecurityLevelExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSecurityLevel_GetObjLst_ClientCache = SysSecurityLevel_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
        clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysSecurityLevelExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysSecurityLevelObjLst_T = SysSecurityLevel_GetObjLstByJSONObjLst(arrSysSecurityLevelExObjLst_Cache);
            return arrSysSecurityLevelObjLst_T;
        }
        try {
            const arrSysSecurityLevelExObjLst = await SysSecurityLevel_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSysSecurityLevelExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSecurityLevelExObjLst.length);
            console.log(strInfo);
            return arrSysSecurityLevelExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSecurityLevel_GetObjLst_localStorage = SysSecurityLevel_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysSecurityLevelObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysSecurityLevelObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysSecurityLevel_GetObjLst_localStorage_PureCache = SysSecurityLevel_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysSecurityLevel_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSecurityLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetObjLstAsync = SysSecurityLevel_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
        clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysSecurityLevelExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysSecurityLevelObjLst_T = SysSecurityLevel_GetObjLstByJSONObjLst(arrSysSecurityLevelExObjLst_Cache);
            return arrSysSecurityLevelObjLst_T;
        }
        try {
            const arrSysSecurityLevelExObjLst = await SysSecurityLevel_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSysSecurityLevelExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSecurityLevelExObjLst.length);
            console.log(strInfo);
            return arrSysSecurityLevelExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSecurityLevel_GetObjLst_sessionStorage = SysSecurityLevel_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysSecurityLevelObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysSecurityLevelObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysSecurityLevel_GetObjLst_sessionStorage_PureCache = SysSecurityLevel_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrSysSecurityLevelObjLst_Cache;
        switch (clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_ClientCache();
                break;
            default:
                arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_ClientCache();
                break;
        }
        const arrSysSecurityLevelObjLst = SysSecurityLevel_GetObjLstByJSONObjLst(arrSysSecurityLevelObjLst_Cache);
        return arrSysSecurityLevelObjLst_Cache;
    }
    exports.SysSecurityLevel_GetObjLst_Cache = SysSecurityLevel_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSecurityLevel_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSysSecurityLevelObjLst_Cache;
        switch (clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrSysSecurityLevelObjLst_Cache = null;
                break;
            default:
                arrSysSecurityLevelObjLst_Cache = null;
                break;
        }
        return arrSysSecurityLevelObjLst_Cache;
    }
    exports.SysSecurityLevel_GetObjLst_PureCache = SysSecurityLevel_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrLevelId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysSecurityLevel_GetSubObjLst_Cache(objSysSecurityLevel_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        let arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache;
        if (objSysSecurityLevel_Cond.sf_FldComparisonOp == null || objSysSecurityLevel_Cond.sf_FldComparisonOp == "")
            return arrSysSecurityLevel_Sel;
        const dicFldComparisonOp = JSON.parse(objSysSecurityLevel_Cond.sf_FldComparisonOp);
        //console.log("clsSysSecurityLevelWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSecurityLevel_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSecurityLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysSecurityLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSysSecurityLevel_Cond), exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSecurityLevel_GetSubObjLst_Cache = SysSecurityLevel_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrLevelId:关键字列表
    * @returns 对象列表
    **/
    async function SysSecurityLevel_GetObjLstByLevelIdLstAsync(arrLevelId) {
        const strThisFuncName = "GetObjLstByLevelIdLstAsync";
        const strAction = "GetObjLstByLevelIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLevelId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSecurityLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetObjLstByLevelIdLstAsync = SysSecurityLevel_GetObjLstByLevelIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrLevelIdLst:关键字列表
     * @returns 对象列表
    */
    async function SysSecurityLevel_GetObjLstByLevelIdLst_Cache(arrLevelIdLst) {
        const strThisFuncName = "GetObjLstByLevelIdLst_Cache";
        try {
            const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
            const arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache.filter(x => arrLevelIdLst.indexOf(x.levelId) > -1);
            return arrSysSecurityLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrLevelIdLst.join(","), exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSecurityLevel_GetObjLstByLevelIdLst_Cache = SysSecurityLevel_GetObjLstByLevelIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysSecurityLevel_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSecurityLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetTopObjLstAsync = SysSecurityLevel_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSecurityLevel_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSecurityLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetObjLstByRangeAsync = SysSecurityLevel_GetObjLstByRangeAsync;
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
    async function SysSecurityLevel_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetObjLstByRange = SysSecurityLevel_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysSecurityLevel_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        if (arrSysSecurityLevelObjLst_Cache.length == 0)
            return arrSysSecurityLevelObjLst_Cache;
        let arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysSecurityLevel_Cond = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSecurityLevel_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysSecurityLevelWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSecurityLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSecurityLevel_Sel.length == 0)
                return arrSysSecurityLevel_Sel;
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
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.sort(SysSecurityLevel_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.sort(objPagerPara.sortFun);
            }
            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.slice(intStart, intEnd);
            return arrSysSecurityLevel_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSecurityLevel_GetObjLstByPager_Cache = SysSecurityLevel_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSecurityLevel_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSecurityLevel_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetObjLstByPagerAsync = SysSecurityLevel_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strLevelId:关键字
    * @returns 获取删除的结果
    **/
    async function SysSecurityLevel_DelRecordAsync(strLevelId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strLevelId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strLevelId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_DelRecordAsync = SysSecurityLevel_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrLevelId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysSecurityLevel_DelSysSecurityLevelsAsync(arrLevelId) {
        const strThisFuncName = "DelSysSecurityLevelsAsync";
        const strAction = "DelSysSecurityLevels";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLevelId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_DelSysSecurityLevelsAsync = SysSecurityLevel_DelSysSecurityLevelsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysSecurityLevel_DelSysSecurityLevelsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysSecurityLevelsByCondAsync";
        const strAction = "DelSysSecurityLevelsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_DelSysSecurityLevelsByCondAsync = SysSecurityLevel_DelSysSecurityLevelsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysSecurityLevelEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSecurityLevel_AddNewRecordAsync(objSysSecurityLevelEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysSecurityLevelEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSecurityLevelEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_AddNewRecordAsync = SysSecurityLevel_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysSecurityLevelEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSecurityLevel_AddNewRecordWithMaxIdAsync(objSysSecurityLevelEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSecurityLevelEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_AddNewRecordWithMaxIdAsync = SysSecurityLevel_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysSecurityLevelEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysSecurityLevel_AddNewRecordWithReturnKeyAsync(objSysSecurityLevelEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSecurityLevelEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_AddNewRecordWithReturnKeyAsync = SysSecurityLevel_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysSecurityLevelEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysSecurityLevel_AddNewRecordWithReturnKey(objSysSecurityLevelEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysSecurityLevelEN.levelId === null || objSysSecurityLevelEN.levelId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSecurityLevelEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_AddNewRecordWithReturnKey = SysSecurityLevel_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysSecurityLevelEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysSecurityLevel_UpdateRecordAsync(objSysSecurityLevelEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysSecurityLevelEN.sf_UpdFldSetStr === undefined || objSysSecurityLevelEN.sf_UpdFldSetStr === null || objSysSecurityLevelEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSecurityLevelEN.levelId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSecurityLevelEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_UpdateRecordAsync = SysSecurityLevel_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysSecurityLevelEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSecurityLevel_UpdateWithConditionAsync(objSysSecurityLevelEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysSecurityLevelEN.sf_UpdFldSetStr === undefined || objSysSecurityLevelEN.sf_UpdFldSetStr === null || objSysSecurityLevelEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSecurityLevelEN.levelId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        objSysSecurityLevelEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysSecurityLevelEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_UpdateWithConditionAsync = SysSecurityLevel_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrLevelId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysSecurityLevel_IsExistRecord_Cache(objSysSecurityLevel_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        if (arrSysSecurityLevelObjLst_Cache == null)
            return false;
        let arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache;
        if (objSysSecurityLevel_Cond.sf_FldComparisonOp == null || objSysSecurityLevel_Cond.sf_FldComparisonOp == "")
            return arrSysSecurityLevel_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSysSecurityLevel_Cond.sf_FldComparisonOp);
        //console.log("clsSysSecurityLevelWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSecurityLevel_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSecurityLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSecurityLevel_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSysSecurityLevel_Cond), exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SysSecurityLevel_IsExistRecord_Cache = SysSecurityLevel_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysSecurityLevel_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_IsExistRecordAsync = SysSecurityLevel_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strLevelId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysSecurityLevel_IsExist(strLevelId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "LevelId": strLevelId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_IsExist = SysSecurityLevel_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strLevelId:所给的关键字
     * @returns 对象
    */
    async function SysSecurityLevel_IsExist_Cache(strLevelId) {
        const strThisFuncName = "IsExist_Cache";
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        if (arrSysSecurityLevelObjLst_Cache == null)
            return false;
        try {
            const arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache.filter(x => x.levelId == strLevelId);
            if (arrSysSecurityLevel_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strLevelId, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SysSecurityLevel_IsExist_Cache = SysSecurityLevel_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strLevelId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysSecurityLevel_IsExistAsync(strLevelId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strLevelId": strLevelId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_IsExistAsync = SysSecurityLevel_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysSecurityLevel_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetRecCountByCondAsync = SysSecurityLevel_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSysSecurityLevel_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SysSecurityLevel_GetRecCountByCond_Cache(objSysSecurityLevel_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSysSecurityLevelObjLst_Cache = await SysSecurityLevel_GetObjLst_Cache();
        if (arrSysSecurityLevelObjLst_Cache == null)
            return 0;
        let arrSysSecurityLevel_Sel = arrSysSecurityLevelObjLst_Cache;
        if (objSysSecurityLevel_Cond.sf_FldComparisonOp == null || objSysSecurityLevel_Cond.sf_FldComparisonOp == "")
            return arrSysSecurityLevel_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSysSecurityLevel_Cond.sf_FldComparisonOp);
        //console.log("clsSysSecurityLevelWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSecurityLevel_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSecurityLevel_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSecurityLevel_Sel = arrSysSecurityLevel_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysSecurityLevel_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSysSecurityLevel_Cond), exports.sysSecurityLevel_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SysSecurityLevel_GetRecCountByCond_Cache = SysSecurityLevel_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function SysSecurityLevel_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetMaxStrIdAsync = SysSecurityLevel_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function SysSecurityLevel_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSecurityLevel_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSecurityLevel_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSecurityLevel_GetMaxStrIdByPrefix = SysSecurityLevel_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysSecurityLevel_GetWebApiUrl(strController, strAction) {
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
    exports.SysSecurityLevel_GetWebApiUrl = SysSecurityLevel_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SysSecurityLevel_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
        switch (clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheModeId) {
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
    exports.SysSecurityLevel_ReFreshCache = SysSecurityLevel_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SysSecurityLevel_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN._CurrTabName;
            switch (clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.CacheModeId) {
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
    exports.SysSecurityLevel_ReFreshThisCache = SysSecurityLevel_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function SysSecurityLevel_BindDdl_LevelIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_LevelIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_LevelIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_LevelIdInDiv_Cache");
        const arrObjLst_Sel = await SysSecurityLevel_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId, clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName, "保密级别表");
    }
    exports.SysSecurityLevel_BindDdl_LevelIdInDiv_Cache = SysSecurityLevel_BindDdl_LevelIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSecurityLevel_CheckPropertyNew(pobjSysSecurityLevelEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSecurityLevelEN.levelId) > 2) {
            throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 保密级别表(SysSecurityLevel))!值:$(pobjSysSecurityLevelEN.levelId)(clsSysSecurityLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelName) == false && (0, clsString_js_1.GetStrLen)(pobjSysSecurityLevelEN.levelName) > 50) {
            throw new Error("(errid:Watl000059)字段[级别名称(levelName)]的长度不能超过50(In 保密级别表(SysSecurityLevel))!值:$(pobjSysSecurityLevelEN.levelName)(clsSysSecurityLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysSecurityLevelEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 保密级别表(SysSecurityLevel))!值:$(pobjSysSecurityLevelEN.memo)(clsSysSecurityLevelBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelId) == false && undefined !== pobjSysSecurityLevelEN.levelId && jsString_js_1.tzDataType.isString(pobjSysSecurityLevelEN.levelId) === false) {
            throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSecurityLevelEN.levelId)], 非法，应该为字符型(In 保密级别表(SysSecurityLevel))!(clsSysSecurityLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelName) == false && undefined !== pobjSysSecurityLevelEN.levelName && jsString_js_1.tzDataType.isString(pobjSysSecurityLevelEN.levelName) === false) {
            throw new Error("(errid:Watl000060)字段[级别名称(levelName)]的值:[$(pobjSysSecurityLevelEN.levelName)], 非法，应该为字符型(In 保密级别表(SysSecurityLevel))!(clsSysSecurityLevelBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.memo) == false && undefined !== pobjSysSecurityLevelEN.memo && jsString_js_1.tzDataType.isString(pobjSysSecurityLevelEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSecurityLevelEN.memo)], 非法，应该为字符型(In 保密级别表(SysSecurityLevel))!(clsSysSecurityLevelBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysSecurityLevelEN.SetIsCheckProperty(true);
    }
    exports.SysSecurityLevel_CheckPropertyNew = SysSecurityLevel_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSecurityLevel_CheckProperty4Update(pobjSysSecurityLevelEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSecurityLevelEN.levelId) > 2) {
            throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 保密级别表(SysSecurityLevel))!值:$(pobjSysSecurityLevelEN.levelId)(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelName) == false && (0, clsString_js_1.GetStrLen)(pobjSysSecurityLevelEN.levelName) > 50) {
            throw new Error("(errid:Watl000062)字段[级别名称(levelName)]的长度不能超过50(In 保密级别表(SysSecurityLevel))!值:$(pobjSysSecurityLevelEN.levelName)(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysSecurityLevelEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 保密级别表(SysSecurityLevel))!值:$(pobjSysSecurityLevelEN.memo)(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelId) == false && undefined !== pobjSysSecurityLevelEN.levelId && jsString_js_1.tzDataType.isString(pobjSysSecurityLevelEN.levelId) === false) {
            throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSecurityLevelEN.levelId)], 非法，应该为字符型(In 保密级别表(SysSecurityLevel))!(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelName) == false && undefined !== pobjSysSecurityLevelEN.levelName && jsString_js_1.tzDataType.isString(pobjSysSecurityLevelEN.levelName) === false) {
            throw new Error("(errid:Watl000063)字段[级别名称(levelName)]的值:[$(pobjSysSecurityLevelEN.levelName)], 非法，应该为字符型(In 保密级别表(SysSecurityLevel))!(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.memo) == false && undefined !== pobjSysSecurityLevelEN.memo && jsString_js_1.tzDataType.isString(pobjSysSecurityLevelEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSecurityLevelEN.memo)], 非法，应该为字符型(In 保密级别表(SysSecurityLevel))!(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSecurityLevelEN.levelId) === true
            || pobjSysSecurityLevelEN.levelId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[级别Id]不能为空(In 保密级别表)!(clsSysSecurityLevelBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysSecurityLevelEN.SetIsCheckProperty(true);
    }
    exports.SysSecurityLevel_CheckProperty4Update = SysSecurityLevel_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSecurityLevel_GetJSONStrByObj(pobjSysSecurityLevelEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysSecurityLevelEN.sf_UpdFldSetStr = pobjSysSecurityLevelEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysSecurityLevelEN);
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
    exports.SysSecurityLevel_GetJSONStrByObj = SysSecurityLevel_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysSecurityLevel_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysSecurityLevelObjLst = new Array();
        if (strJSON === "") {
            return arrSysSecurityLevelObjLst;
        }
        try {
            arrSysSecurityLevelObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysSecurityLevelObjLst;
        }
        return arrSysSecurityLevelObjLst;
    }
    exports.SysSecurityLevel_GetObjLstByJSONStr = SysSecurityLevel_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysSecurityLevelObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysSecurityLevel_GetObjLstByJSONObjLst(arrSysSecurityLevelObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysSecurityLevelObjLst = new Array();
        for (const objInFor of arrSysSecurityLevelObjLstS) {
            const obj1 = SysSecurityLevel_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysSecurityLevelObjLst.push(obj1);
        }
        return arrSysSecurityLevelObjLst;
    }
    exports.SysSecurityLevel_GetObjLstByJSONObjLst = SysSecurityLevel_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSecurityLevel_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysSecurityLevelEN = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN();
        if (strJSON === "") {
            return pobjSysSecurityLevelEN;
        }
        try {
            pobjSysSecurityLevelEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysSecurityLevelEN;
        }
        return pobjSysSecurityLevelEN;
    }
    exports.SysSecurityLevel_GetObjByJSONStr = SysSecurityLevel_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysSecurityLevel_GetCombineCondition(objSysSecurityLevel_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysSecurityLevel_Cond.dicFldComparisonOp, clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objSysSecurityLevel_Cond.dicFldComparisonOp[clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelId, objSysSecurityLevel_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSecurityLevel_Cond.dicFldComparisonOp, clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objSysSecurityLevel_Cond.dicFldComparisonOp[clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_LevelName, objSysSecurityLevel_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSecurityLevel_Cond.dicFldComparisonOp, clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysSecurityLevel_Cond.dicFldComparisonOp[clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN.con_Memo, objSysSecurityLevel_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.SysSecurityLevel_GetCombineCondition = SysSecurityLevel_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysSecurityLevel(保密级别表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strLevelId: 级别Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSecurityLevel_GetUniCondStr_LevelId(objSysSecurityLevelEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and LevelId = '{0}'", objSysSecurityLevelEN.levelId);
        return strWhereCond;
    }
    exports.SysSecurityLevel_GetUniCondStr_LevelId = SysSecurityLevel_GetUniCondStr_LevelId;
    /**
    *获取唯一性条件串(Uniqueness)--SysSecurityLevel(保密级别表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strLevelId: 级别Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSecurityLevel_GetUniCondStr4Update_LevelId(objSysSecurityLevelEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and LevelId <> '{0}'", objSysSecurityLevelEN.levelId);
        strWhereCond += (0, clsString_js_1.Format)(" and LevelId = '{0}'", objSysSecurityLevelEN.levelId);
        return strWhereCond;
    }
    exports.SysSecurityLevel_GetUniCondStr4Update_LevelId = SysSecurityLevel_GetUniCondStr4Update_LevelId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysSecurityLevelENS:源对象
     * @param objSysSecurityLevelENT:目标对象
    */
    function SysSecurityLevel_CopyObjTo(objSysSecurityLevelENS, objSysSecurityLevelENT) {
        objSysSecurityLevelENT.levelId = objSysSecurityLevelENS.levelId; //级别Id
        objSysSecurityLevelENT.levelName = objSysSecurityLevelENS.levelName; //级别名称
        objSysSecurityLevelENT.memo = objSysSecurityLevelENS.memo; //备注
        objSysSecurityLevelENT.sf_UpdFldSetStr = objSysSecurityLevelENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysSecurityLevel_CopyObjTo = SysSecurityLevel_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysSecurityLevelENS:源对象
     * @param objSysSecurityLevelENT:目标对象
    */
    function SysSecurityLevel_GetObjFromJsonObj(objSysSecurityLevelENS) {
        const objSysSecurityLevelENT = new clsSysSecurityLevelEN_js_1.clsSysSecurityLevelEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSecurityLevelENT, objSysSecurityLevelENS);
        return objSysSecurityLevelENT;
    }
    exports.SysSecurityLevel_GetObjFromJsonObj = SysSecurityLevel_GetObjFromJsonObj;
});
