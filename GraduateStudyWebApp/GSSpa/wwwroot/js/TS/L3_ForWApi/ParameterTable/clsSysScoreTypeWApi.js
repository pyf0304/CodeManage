/**
* 类名:clsSysScoreTypeWApi
* 表名:SysScoreType(01120631)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 16:58:52
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsSysScoreTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysScoreType_GetObjFromJsonObj = exports.SysScoreType_CopyObjTo = exports.SysScoreType_GetCombineCondition = exports.SysScoreType_GetObjByJSONStr = exports.SysScoreType_GetObjLstByJSONObjLst = exports.SysScoreType_GetObjLstByJSONStr = exports.SysScoreType_GetJSONStrByObj = exports.SysScoreType_CheckProperty4Update = exports.SysScoreType_CheckPropertyNew = exports.SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache = exports.SysScoreType_ReFreshThisCache = exports.SysScoreType_ReFreshCache = exports.SysScoreType_GetWebApiUrl = exports.SysScoreType_GetMaxStrIdByPrefix = exports.SysScoreType_GetRecCountByCond_Cache = exports.SysScoreType_GetRecCountByCondAsync = exports.SysScoreType_IsExistAsync = exports.SysScoreType_IsExist_Cache = exports.SysScoreType_IsExist = exports.SysScoreType_IsExistRecordAsync = exports.SysScoreType_IsExistRecord_Cache = exports.SysScoreType_UpdateWithConditionAsync = exports.SysScoreType_UpdateRecordAsync = exports.SysScoreType_AddNewRecordWithReturnKey = exports.SysScoreType_AddNewRecordWithReturnKeyAsync = exports.SysScoreType_AddNewRecordWithMaxIdAsync = exports.SysScoreType_AddNewRecordAsync = exports.SysScoreType_DelSysScoreTypesByCondAsync = exports.SysScoreType_DelSysScoreTypesAsync = exports.SysScoreType_DelRecordAsync = exports.SysScoreType_GetObjLstByPagerAsync = exports.SysScoreType_GetObjLstByPager_Cache = exports.SysScoreType_GetObjLstByRange = exports.SysScoreType_GetObjLstByRangeAsync = exports.SysScoreType_GetTopObjLstAsync = exports.SysScoreType_GetObjLstByScoreTypeIdLst_Cache = exports.SysScoreType_GetObjLstByScoreTypeIdLstAsync = exports.SysScoreType_GetSubObjLst_Cache = exports.SysScoreType_GetObjLst_PureCache = exports.SysScoreType_GetObjLst_Cache = exports.SysScoreType_GetObjLst_sessionStorage_PureCache = exports.SysScoreType_GetObjLst_sessionStorage = exports.SysScoreType_GetObjLstAsync = exports.SysScoreType_GetObjLst_localStorage_PureCache = exports.SysScoreType_GetObjLst_localStorage = exports.SysScoreType_GetObjLst_ClientCache = exports.SysScoreType_GetFirstObjAsync = exports.SysScoreType_GetFirstID = exports.SysScoreType_GetFirstIDAsync = exports.SysScoreType_FilterFunByKey = exports.SysScoreType_SortFunByKey = exports.SysScoreType_SortFun_Defa_2Fld = exports.SysScoreType_SortFun_Defa = exports.SysScoreType_func = exports.SysScoreType_GetNameByScoreTypeId_Cache = exports.SysScoreType_UpdateObjInLst_Cache = exports.SysScoreType_GetObjByScoreTypeId_localStorage = exports.SysScoreType_GetObjByScoreTypeId_Cache = exports.SysScoreType_GetObjByScoreTypeIdAsync = exports.sysScoreType_ConstructorName = exports.sysScoreType_Controller = void 0;
    /**
     * 评分类型表(SysScoreType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSysScoreTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsSysScoreTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysScoreType_Controller = "SysScoreTypeApi";
    exports.sysScoreType_ConstructorName = "sysScoreType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strScoreTypeId:关键字
    * @returns 对象
    **/
    async function SysScoreType_GetObjByScoreTypeIdAsync(strScoreTypeId) {
        const strThisFuncName = "GetObjByScoreTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreTypeId]不能为空！(In GetObjByScoreTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！", strScoreTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByScoreTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strScoreTypeId": strScoreTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysScoreType = SysScoreType_GetObjFromJsonObj(returnObj);
                return objSysScoreType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetObjByScoreTypeIdAsync = SysScoreType_GetObjByScoreTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strScoreTypeId:所给的关键字
     * @returns 对象
    */
    async function SysScoreType_GetObjByScoreTypeId_Cache(strScoreTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByScoreTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreTypeId]不能为空！(In GetObjByScoreTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！", strScoreTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        try {
            const arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache.filter(x => x.scoreTypeId == strScoreTypeId);
            let objSysScoreType;
            if (arrSysScoreType_Sel.length > 0) {
                objSysScoreType = arrSysScoreType_Sel[0];
                return objSysScoreType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objSysScoreType = await SysScoreType_GetObjByScoreTypeIdAsync(strScoreTypeId);
                    if (objSysScoreType != null) {
                        SysScoreType_ReFreshThisCache();
                        return objSysScoreType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreTypeId, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SysScoreType_GetObjByScoreTypeId_Cache = SysScoreType_GetObjByScoreTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strScoreTypeId:所给的关键字
     * @returns 对象
    */
    async function SysScoreType_GetObjByScoreTypeId_localStorage(strScoreTypeId) {
        const strThisFuncName = "GetObjByScoreTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreTypeId]不能为空！(In GetObjByScoreTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！", strScoreTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName, strScoreTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSysScoreType_Cache = JSON.parse(strTempObj);
            return objSysScoreType_Cache;
        }
        try {
            const objSysScoreType = await SysScoreType_GetObjByScoreTypeIdAsync(strScoreTypeId);
            if (objSysScoreType != null) {
                localStorage.setItem(strKey, JSON.stringify(objSysScoreType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSysScoreType;
            }
            return objSysScoreType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strScoreTypeId, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SysScoreType_GetObjByScoreTypeId_localStorage = SysScoreType_GetObjByScoreTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSysScoreType:所给的对象
     * @returns 对象
    */
    async function SysScoreType_UpdateObjInLst_Cache(objSysScoreType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
            const obj = arrSysScoreTypeObjLst_Cache.find(x => x.scoreTypeId == objSysScoreType.scoreTypeId);
            if (obj != null) {
                objSysScoreType.scoreTypeId = obj.scoreTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSysScoreType);
            }
            else {
                arrSysScoreTypeObjLst_Cache.push(objSysScoreType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SysScoreType_UpdateObjInLst_Cache = SysScoreType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strScoreTypeId:所给的关键字
     * @returns 对象
    */
    async function SysScoreType_GetNameByScoreTypeId_Cache(strScoreTypeId) {
        const strThisFuncName = "GetNameByScoreTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strScoreTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strScoreTypeId]不能为空！(In GetNameByScoreTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strScoreTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strScoreTypeId]的长度:[{0}]不正确！", strScoreTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        if (arrSysScoreTypeObjLst_Cache == null)
            return "";
        try {
            const arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache.filter(x => x.scoreTypeId == strScoreTypeId);
            let objSysScoreType;
            if (arrSysScoreType_Sel.length > 0) {
                objSysScoreType = arrSysScoreType_Sel[0];
                return objSysScoreType.scoreTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strScoreTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.SysScoreType_GetNameByScoreTypeId_Cache = SysScoreType_GetNameByScoreTypeId_Cache;
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
    async function SysScoreType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strScoreTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSysScoreType = await SysScoreType_GetObjByScoreTypeId_Cache(strScoreTypeId);
        if (objSysScoreType == null)
            return "";
        return objSysScoreType.GetFldValue(strOutFldName).toString();
    }
    exports.SysScoreType_func = SysScoreType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysScoreType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.scoreTypeId.localeCompare(b.scoreTypeId);
    }
    exports.SysScoreType_SortFun_Defa = SysScoreType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysScoreType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.scoreTypeName == b.scoreTypeName)
            return a.onlyId.localeCompare(b.onlyId);
        else
            return a.scoreTypeName.localeCompare(b.scoreTypeName);
    }
    exports.SysScoreType_SortFun_Defa_2Fld = SysScoreType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysScoreType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId:
                    return (a, b) => {
                        return a.scoreTypeId.localeCompare(b.scoreTypeId);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName:
                    return (a, b) => {
                        return a.scoreTypeName.localeCompare(b.scoreTypeName);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_OnlyId:
                    return (a, b) => {
                        return a.onlyId.localeCompare(b.onlyId);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysScoreType]中不存在！(in ${exports.sysScoreType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId:
                    return (a, b) => {
                        return b.scoreTypeId.localeCompare(a.scoreTypeId);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName:
                    return (a, b) => {
                        return b.scoreTypeName.localeCompare(a.scoreTypeName);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_OnlyId:
                    return (a, b) => {
                        return b.onlyId.localeCompare(a.onlyId);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysScoreType]中不存在！(in ${exports.sysScoreType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysScoreType_SortFunByKey = SysScoreType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysScoreType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId:
                return (obj) => {
                    return obj.scoreTypeId === value;
                };
            case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName:
                return (obj) => {
                    return obj.scoreTypeName === value;
                };
            case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_OnlyId:
                return (obj) => {
                    return obj.onlyId === value;
                };
            case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysScoreType]中不存在！(in ${exports.sysScoreType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysScoreType_FilterFunByKey = SysScoreType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysScoreType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetFirstIDAsync = SysScoreType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysScoreType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetFirstID = SysScoreType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysScoreType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysScoreType = SysScoreType_GetObjFromJsonObj(returnObj);
                return objSysScoreType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetFirstObjAsync = SysScoreType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
        clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSysScoreTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrSysScoreTypeObjLst_T = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeExObjLst_Cache);
            return arrSysScoreTypeObjLst_T;
        }
        try {
            const arrSysScoreTypeExObjLst = await SysScoreType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrSysScoreTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreTypeExObjLst.length);
            console.log(strInfo);
            return arrSysScoreTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysScoreType_GetObjLst_ClientCache = SysScoreType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
        clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysScoreTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysScoreTypeObjLst_T = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeExObjLst_Cache);
            return arrSysScoreTypeObjLst_T;
        }
        try {
            const arrSysScoreTypeExObjLst = await SysScoreType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSysScoreTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreTypeExObjLst.length);
            console.log(strInfo);
            return arrSysScoreTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysScoreType_GetObjLst_localStorage = SysScoreType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysScoreTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysScoreTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysScoreType_GetObjLst_localStorage_PureCache = SysScoreType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysScoreType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetObjLstAsync = SysScoreType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
        clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysScoreTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysScoreTypeObjLst_T = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeExObjLst_Cache);
            return arrSysScoreTypeObjLst_T;
        }
        try {
            const arrSysScoreTypeExObjLst = await SysScoreType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSysScoreTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysScoreTypeExObjLst.length);
            console.log(strInfo);
            return arrSysScoreTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysScoreType_GetObjLst_sessionStorage = SysScoreType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysScoreTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysScoreTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysScoreType_GetObjLst_sessionStorage_PureCache = SysScoreType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrSysScoreTypeObjLst_Cache;
        switch (clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_ClientCache();
                break;
            default:
                arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_ClientCache();
                break;
        }
        const arrSysScoreTypeObjLst = SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeObjLst_Cache);
        return arrSysScoreTypeObjLst_Cache;
    }
    exports.SysScoreType_GetObjLst_Cache = SysScoreType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysScoreType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSysScoreTypeObjLst_Cache;
        switch (clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrSysScoreTypeObjLst_Cache = null;
                break;
            default:
                arrSysScoreTypeObjLst_Cache = null;
                break;
        }
        return arrSysScoreTypeObjLst_Cache;
    }
    exports.SysScoreType_GetObjLst_PureCache = SysScoreType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrScoreTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysScoreType_GetSubObjLst_Cache(objSysScoreType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        let arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache;
        if (objSysScoreType_Cond.sf_FldComparisonOp == null || objSysScoreType_Cond.sf_FldComparisonOp == "")
            return arrSysScoreType_Sel;
        const dicFldComparisonOp = JSON.parse(objSysScoreType_Cond.sf_FldComparisonOp);
        //console.log("clsSysScoreTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysScoreType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysScoreType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysScoreType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSysScoreType_Cond), exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysScoreType_GetSubObjLst_Cache = SysScoreType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrScoreTypeId:关键字列表
    * @returns 对象列表
    **/
    async function SysScoreType_GetObjLstByScoreTypeIdLstAsync(arrScoreTypeId) {
        const strThisFuncName = "GetObjLstByScoreTypeIdLstAsync";
        const strAction = "GetObjLstByScoreTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrScoreTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetObjLstByScoreTypeIdLstAsync = SysScoreType_GetObjLstByScoreTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrScoreTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function SysScoreType_GetObjLstByScoreTypeIdLst_Cache(arrScoreTypeIdLst) {
        const strThisFuncName = "GetObjLstByScoreTypeIdLst_Cache";
        try {
            const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
            const arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache.filter(x => arrScoreTypeIdLst.indexOf(x.scoreTypeId) > -1);
            return arrSysScoreType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrScoreTypeIdLst.join(","), exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysScoreType_GetObjLstByScoreTypeIdLst_Cache = SysScoreType_GetObjLstByScoreTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysScoreType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetTopObjLstAsync = SysScoreType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysScoreType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetObjLstByRangeAsync = SysScoreType_GetObjLstByRangeAsync;
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
    async function SysScoreType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetObjLstByRange = SysScoreType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysScoreType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        if (arrSysScoreTypeObjLst_Cache.length == 0)
            return arrSysScoreTypeObjLst_Cache;
        let arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysScoreType_Cond = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysScoreType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysScoreTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysScoreType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysScoreType_Sel.length == 0)
                return arrSysScoreType_Sel;
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
                arrSysScoreType_Sel = arrSysScoreType_Sel.sort(SysScoreType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysScoreType_Sel = arrSysScoreType_Sel.sort(objPagerPara.sortFun);
            }
            arrSysScoreType_Sel = arrSysScoreType_Sel.slice(intStart, intEnd);
            return arrSysScoreType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysScoreType_GetObjLstByPager_Cache = SysScoreType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysScoreType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysScoreType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysScoreType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetObjLstByPagerAsync = SysScoreType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strScoreTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function SysScoreType_DelRecordAsync(strScoreTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strScoreTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strScoreTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_DelRecordAsync = SysScoreType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrScoreTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysScoreType_DelSysScoreTypesAsync(arrScoreTypeId) {
        const strThisFuncName = "DelSysScoreTypesAsync";
        const strAction = "DelSysScoreTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrScoreTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_DelSysScoreTypesAsync = SysScoreType_DelSysScoreTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysScoreType_DelSysScoreTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysScoreTypesByCondAsync";
        const strAction = "DelSysScoreTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_DelSysScoreTypesByCondAsync = SysScoreType_DelSysScoreTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysScoreTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysScoreType_AddNewRecordAsync(objSysScoreTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objSysScoreTypeEN.scoreTypeId === null || objSysScoreTypeEN.scoreTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSysScoreTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_AddNewRecordAsync = SysScoreType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysScoreTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysScoreType_AddNewRecordWithMaxIdAsync(objSysScoreTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_AddNewRecordWithMaxIdAsync = SysScoreType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysScoreTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysScoreType_AddNewRecordWithReturnKeyAsync(objSysScoreTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_AddNewRecordWithReturnKeyAsync = SysScoreType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysScoreTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysScoreType_AddNewRecordWithReturnKey(objSysScoreTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysScoreTypeEN.scoreTypeId === null || objSysScoreTypeEN.scoreTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_AddNewRecordWithReturnKey = SysScoreType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysScoreTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysScoreType_UpdateRecordAsync(objSysScoreTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysScoreTypeEN.sf_UpdFldSetStr === undefined || objSysScoreTypeEN.sf_UpdFldSetStr === null || objSysScoreTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreTypeEN.scoreTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_UpdateRecordAsync = SysScoreType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysScoreTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysScoreType_UpdateWithConditionAsync(objSysScoreTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysScoreTypeEN.sf_UpdFldSetStr === undefined || objSysScoreTypeEN.sf_UpdFldSetStr === null || objSysScoreTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysScoreTypeEN.scoreTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        objSysScoreTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysScoreTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_UpdateWithConditionAsync = SysScoreType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrScoreTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysScoreType_IsExistRecord_Cache(objSysScoreType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        if (arrSysScoreTypeObjLst_Cache == null)
            return false;
        let arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache;
        if (objSysScoreType_Cond.sf_FldComparisonOp == null || objSysScoreType_Cond.sf_FldComparisonOp == "")
            return arrSysScoreType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSysScoreType_Cond.sf_FldComparisonOp);
        //console.log("clsSysScoreTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysScoreType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysScoreType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysScoreType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSysScoreType_Cond), exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SysScoreType_IsExistRecord_Cache = SysScoreType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysScoreType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_IsExistRecordAsync = SysScoreType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strScoreTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysScoreType_IsExist(strScoreTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ScoreTypeId": strScoreTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_IsExist = SysScoreType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strScoreTypeId:所给的关键字
     * @returns 对象
    */
    async function SysScoreType_IsExist_Cache(strScoreTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        if (arrSysScoreTypeObjLst_Cache == null)
            return false;
        try {
            const arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache.filter(x => x.scoreTypeId == strScoreTypeId);
            if (arrSysScoreType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strScoreTypeId, exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SysScoreType_IsExist_Cache = SysScoreType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strScoreTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysScoreType_IsExistAsync(strScoreTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strScoreTypeId": strScoreTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_IsExistAsync = SysScoreType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysScoreType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetRecCountByCondAsync = SysScoreType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSysScoreType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SysScoreType_GetRecCountByCond_Cache(objSysScoreType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSysScoreTypeObjLst_Cache = await SysScoreType_GetObjLst_Cache();
        if (arrSysScoreTypeObjLst_Cache == null)
            return 0;
        let arrSysScoreType_Sel = arrSysScoreTypeObjLst_Cache;
        if (objSysScoreType_Cond.sf_FldComparisonOp == null || objSysScoreType_Cond.sf_FldComparisonOp == "")
            return arrSysScoreType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSysScoreType_Cond.sf_FldComparisonOp);
        //console.log("clsSysScoreTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysScoreType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysScoreType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysScoreType_Sel = arrSysScoreType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysScoreType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSysScoreType_Cond), exports.sysScoreType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SysScoreType_GetRecCountByCond_Cache = SysScoreType_GetRecCountByCond_Cache;
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
    async function SysScoreType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysScoreType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysScoreType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysScoreType_GetMaxStrIdByPrefix = SysScoreType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysScoreType_GetWebApiUrl(strController, strAction) {
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
    exports.SysScoreType_GetWebApiUrl = SysScoreType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SysScoreType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
        switch (clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheModeId) {
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
    exports.SysScoreType_ReFreshCache = SysScoreType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SysScoreType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsSysScoreTypeEN_js_1.clsSysScoreTypeEN._CurrTabName;
            switch (clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.CacheModeId) {
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
    exports.SysScoreType_ReFreshThisCache = SysScoreType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_ScoreTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_ScoreTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_ScoreTypeIdInDiv_Cache");
        const arrObjLst_Sel = await SysScoreType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName, "评分类型表");
    }
    exports.SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache = SysScoreType_BindDdl_ScoreTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysScoreType_CheckPropertyNew(pobjSysScoreTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.scoreTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeId)(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.scoreTypeName) > 10) {
            throw new Error("(errid:Watl000059)字段[分数类型名称(scoreTypeName)]的长度不能超过10(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeName)(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.onlyId) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.onlyId) > 20) {
            throw new Error("(errid:Watl000059)字段[OnlyId(onlyId)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.onlyId)(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updUser)(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updDate)(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.memo)(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeId) == false && undefined !== pobjSysScoreTypeEN.scoreTypeId && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.scoreTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreTypeEN.scoreTypeId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeName) == false && undefined !== pobjSysScoreTypeEN.scoreTypeName && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.scoreTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[分数类型名称(scoreTypeName)]的值:[$(pobjSysScoreTypeEN.scoreTypeName)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.onlyId) == false && undefined !== pobjSysScoreTypeEN.onlyId && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.onlyId) === false) {
            throw new Error("(errid:Watl000060)字段[OnlyId(onlyId)]的值:[$(pobjSysScoreTypeEN.onlyId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updUser) == false && undefined !== pobjSysScoreTypeEN.updUser && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysScoreTypeEN.updUser)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updDate) == false && undefined !== pobjSysScoreTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysScoreTypeEN.updDate)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.memo) == false && undefined !== pobjSysScoreTypeEN.memo && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysScoreTypeEN.memo)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysScoreTypeEN.SetIsCheckProperty(true);
    }
    exports.SysScoreType_CheckPropertyNew = SysScoreType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysScoreType_CheckProperty4Update(pobjSysScoreTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.scoreTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[分数类型Id(scoreTypeId)]的长度不能超过4(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeId)(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.scoreTypeName) > 10) {
            throw new Error("(errid:Watl000062)字段[分数类型名称(scoreTypeName)]的长度不能超过10(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.scoreTypeName)(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.onlyId) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.onlyId) > 20) {
            throw new Error("(errid:Watl000062)字段[OnlyId(onlyId)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.onlyId)(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updUser)(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.updDate)(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysScoreTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 评分类型表(SysScoreType))!值:$(pobjSysScoreTypeEN.memo)(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeId) == false && undefined !== pobjSysScoreTypeEN.scoreTypeId && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.scoreTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[分数类型Id(scoreTypeId)]的值:[$(pobjSysScoreTypeEN.scoreTypeId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeName) == false && undefined !== pobjSysScoreTypeEN.scoreTypeName && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.scoreTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[分数类型名称(scoreTypeName)]的值:[$(pobjSysScoreTypeEN.scoreTypeName)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.onlyId) == false && undefined !== pobjSysScoreTypeEN.onlyId && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.onlyId) === false) {
            throw new Error("(errid:Watl000063)字段[OnlyId(onlyId)]的值:[$(pobjSysScoreTypeEN.onlyId)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updUser) == false && undefined !== pobjSysScoreTypeEN.updUser && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysScoreTypeEN.updUser)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.updDate) == false && undefined !== pobjSysScoreTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysScoreTypeEN.updDate)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.memo) == false && undefined !== pobjSysScoreTypeEN.memo && jsString_js_1.tzDataType.isString(pobjSysScoreTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysScoreTypeEN.memo)], 非法，应该为字符型(In 评分类型表(SysScoreType))!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysScoreTypeEN.scoreTypeId) === true
            || pobjSysScoreTypeEN.scoreTypeId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[分数类型Id]不能为空(In 评分类型表)!(clsSysScoreTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysScoreTypeEN.SetIsCheckProperty(true);
    }
    exports.SysScoreType_CheckProperty4Update = SysScoreType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysScoreType_GetJSONStrByObj(pobjSysScoreTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysScoreTypeEN.sf_UpdFldSetStr = pobjSysScoreTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysScoreTypeEN);
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
    exports.SysScoreType_GetJSONStrByObj = SysScoreType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysScoreType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysScoreTypeObjLst = new Array();
        if (strJSON === "") {
            return arrSysScoreTypeObjLst;
        }
        try {
            arrSysScoreTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysScoreTypeObjLst;
        }
        return arrSysScoreTypeObjLst;
    }
    exports.SysScoreType_GetObjLstByJSONStr = SysScoreType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysScoreTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysScoreType_GetObjLstByJSONObjLst(arrSysScoreTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysScoreTypeObjLst = new Array();
        for (const objInFor of arrSysScoreTypeObjLstS) {
            const obj1 = SysScoreType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysScoreTypeObjLst.push(obj1);
        }
        return arrSysScoreTypeObjLst;
    }
    exports.SysScoreType_GetObjLstByJSONObjLst = SysScoreType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysScoreType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysScoreTypeEN = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN();
        if (strJSON === "") {
            return pobjSysScoreTypeEN;
        }
        try {
            pobjSysScoreTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysScoreTypeEN;
        }
        return pobjSysScoreTypeEN;
    }
    exports.SysScoreType_GetObjByJSONStr = SysScoreType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysScoreType_GetCombineCondition(objSysScoreType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId) == true) {
            const strComparisonOp_ScoreTypeId = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeId, objSysScoreType_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName) == true) {
            const strComparisonOp_ScoreTypeName = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_ScoreTypeName, objSysScoreType_Cond.scoreTypeName, strComparisonOp_ScoreTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_OnlyId) == true) {
            const strComparisonOp_OnlyId = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_OnlyId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_OnlyId, objSysScoreType_Cond.onlyId, strComparisonOp_OnlyId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdUser, objSysScoreType_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_UpdDate, objSysScoreType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysScoreType_Cond.dicFldComparisonOp, clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysScoreType_Cond.dicFldComparisonOp[clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysScoreTypeEN_js_1.clsSysScoreTypeEN.con_Memo, objSysScoreType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.SysScoreType_GetCombineCondition = SysScoreType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysScoreTypeENS:源对象
     * @param objSysScoreTypeENT:目标对象
    */
    function SysScoreType_CopyObjTo(objSysScoreTypeENS, objSysScoreTypeENT) {
        objSysScoreTypeENT.scoreTypeId = objSysScoreTypeENS.scoreTypeId; //分数类型Id
        objSysScoreTypeENT.scoreTypeName = objSysScoreTypeENS.scoreTypeName; //分数类型名称
        objSysScoreTypeENT.onlyId = objSysScoreTypeENS.onlyId; //OnlyId
        objSysScoreTypeENT.updUser = objSysScoreTypeENS.updUser; //修改人
        objSysScoreTypeENT.updDate = objSysScoreTypeENS.updDate; //修改日期
        objSysScoreTypeENT.memo = objSysScoreTypeENS.memo; //备注
        objSysScoreTypeENT.sf_UpdFldSetStr = objSysScoreTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysScoreType_CopyObjTo = SysScoreType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysScoreTypeENS:源对象
     * @param objSysScoreTypeENT:目标对象
    */
    function SysScoreType_GetObjFromJsonObj(objSysScoreTypeENS) {
        const objSysScoreTypeENT = new clsSysScoreTypeEN_js_1.clsSysScoreTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysScoreTypeENT, objSysScoreTypeENS);
        return objSysScoreTypeENT;
    }
    exports.SysScoreType_GetObjFromJsonObj = SysScoreType_GetObjFromJsonObj;
});
