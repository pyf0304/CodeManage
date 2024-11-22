/**
* 类名:clsSysOperationTypeWApi
* 表名:SysOperationType(01120652)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:23
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsSysOperationTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysOperationType_GetObjFromJsonObj = exports.SysOperationType_CopyObjTo = exports.SysOperationType_GetCombineCondition = exports.SysOperationType_GetObjByJSONStr = exports.SysOperationType_GetObjLstByJSONObjLst = exports.SysOperationType_GetObjLstByJSONStr = exports.SysOperationType_GetJSONStrByObj = exports.SysOperationType_CheckProperty4Update = exports.SysOperationType_CheckPropertyNew = exports.SysOperationType_BindDdl_OperationTypeIdInDiv_Cache = exports.SysOperationType_ReFreshThisCache = exports.SysOperationType_ReFreshCache = exports.SysOperationType_GetWebApiUrl = exports.SysOperationType_GetMaxStrIdByPrefix = exports.SysOperationType_GetRecCountByCond_Cache = exports.SysOperationType_GetRecCountByCondAsync = exports.SysOperationType_IsExistAsync = exports.SysOperationType_IsExist_Cache = exports.SysOperationType_IsExist = exports.SysOperationType_IsExistRecordAsync = exports.SysOperationType_IsExistRecord_Cache = exports.SysOperationType_UpdateWithConditionAsync = exports.SysOperationType_UpdateRecordAsync = exports.SysOperationType_AddNewRecordWithReturnKey = exports.SysOperationType_AddNewRecordWithReturnKeyAsync = exports.SysOperationType_AddNewRecordWithMaxIdAsync = exports.SysOperationType_AddNewRecordAsync = exports.SysOperationType_DelSysOperationTypesByCondAsync = exports.SysOperationType_DelSysOperationTypesAsync = exports.SysOperationType_DelRecordAsync = exports.SysOperationType_GetObjLstByPagerAsync = exports.SysOperationType_GetObjLstByPager_Cache = exports.SysOperationType_GetObjLstByRange = exports.SysOperationType_GetObjLstByRangeAsync = exports.SysOperationType_GetTopObjLstAsync = exports.SysOperationType_GetObjLstByOperationTypeIdLst_Cache = exports.SysOperationType_GetObjLstByOperationTypeIdLstAsync = exports.SysOperationType_GetSubObjLst_Cache = exports.SysOperationType_GetObjLst_PureCache = exports.SysOperationType_GetObjLst_Cache = exports.SysOperationType_GetObjLst_sessionStorage_PureCache = exports.SysOperationType_GetObjLst_sessionStorage = exports.SysOperationType_GetObjLstAsync = exports.SysOperationType_GetObjLst_localStorage_PureCache = exports.SysOperationType_GetObjLst_localStorage = exports.SysOperationType_GetObjLst_ClientCache = exports.SysOperationType_GetFirstObjAsync = exports.SysOperationType_GetFirstID = exports.SysOperationType_GetFirstIDAsync = exports.SysOperationType_FilterFunByKey = exports.SysOperationType_SortFunByKey = exports.SysOperationType_SortFun_Defa_2Fld = exports.SysOperationType_SortFun_Defa = exports.SysOperationType_func = exports.SysOperationType_GetNameByOperationTypeId_Cache = exports.SysOperationType_UpdateObjInLst_Cache = exports.SysOperationType_GetObjByOperationTypeId_localStorage = exports.SysOperationType_GetObjByOperationTypeId_Cache = exports.SysOperationType_GetObjByOperationTypeIdAsync = exports.sysOperationType_ConstructorName = exports.sysOperationType_Controller = void 0;
    /**
     * 操作类型表(SysOperationType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSysOperationTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsSysOperationTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysOperationType_Controller = "SysOperationTypeApi";
    exports.sysOperationType_ConstructorName = "sysOperationType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strOperationTypeId:关键字
    * @returns 对象
    **/
    async function SysOperationType_GetObjByOperationTypeIdAsync(strOperationTypeId) {
        const strThisFuncName = "GetObjByOperationTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strOperationTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strOperationTypeId]不能为空！(In GetObjByOperationTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strOperationTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strOperationTypeId]的长度:[{0}]不正确！", strOperationTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByOperationTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strOperationTypeId": strOperationTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysOperationType = SysOperationType_GetObjFromJsonObj(returnObj);
                return objSysOperationType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetObjByOperationTypeIdAsync = SysOperationType_GetObjByOperationTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function SysOperationType_GetObjByOperationTypeId_Cache(strOperationTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByOperationTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strOperationTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strOperationTypeId]不能为空！(In GetObjByOperationTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strOperationTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strOperationTypeId]的长度:[{0}]不正确！", strOperationTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        try {
            const arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache.filter(x => x.operationTypeId == strOperationTypeId);
            let objSysOperationType;
            if (arrSysOperationType_Sel.length > 0) {
                objSysOperationType = arrSysOperationType_Sel[0];
                return objSysOperationType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objSysOperationType = await SysOperationType_GetObjByOperationTypeIdAsync(strOperationTypeId);
                    if (objSysOperationType != null) {
                        SysOperationType_ReFreshThisCache();
                        return objSysOperationType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strOperationTypeId, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SysOperationType_GetObjByOperationTypeId_Cache = SysOperationType_GetObjByOperationTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function SysOperationType_GetObjByOperationTypeId_localStorage(strOperationTypeId) {
        const strThisFuncName = "GetObjByOperationTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strOperationTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strOperationTypeId]不能为空！(In GetObjByOperationTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strOperationTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strOperationTypeId]的长度:[{0}]不正确！", strOperationTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName, strOperationTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSysOperationType_Cache = JSON.parse(strTempObj);
            return objSysOperationType_Cache;
        }
        try {
            const objSysOperationType = await SysOperationType_GetObjByOperationTypeIdAsync(strOperationTypeId);
            if (objSysOperationType != null) {
                localStorage.setItem(strKey, JSON.stringify(objSysOperationType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSysOperationType;
            }
            return objSysOperationType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strOperationTypeId, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SysOperationType_GetObjByOperationTypeId_localStorage = SysOperationType_GetObjByOperationTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSysOperationType:所给的对象
     * @returns 对象
    */
    async function SysOperationType_UpdateObjInLst_Cache(objSysOperationType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
            const obj = arrSysOperationTypeObjLst_Cache.find(x => x.operationTypeId == objSysOperationType.operationTypeId);
            if (obj != null) {
                objSysOperationType.operationTypeId = obj.operationTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSysOperationType);
            }
            else {
                arrSysOperationTypeObjLst_Cache.push(objSysOperationType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SysOperationType_UpdateObjInLst_Cache = SysOperationType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function SysOperationType_GetNameByOperationTypeId_Cache(strOperationTypeId) {
        const strThisFuncName = "GetNameByOperationTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strOperationTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strOperationTypeId]不能为空！(In GetNameByOperationTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strOperationTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strOperationTypeId]的长度:[{0}]不正确！", strOperationTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        if (arrSysOperationTypeObjLst_Cache == null)
            return "";
        try {
            const arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache.filter(x => x.operationTypeId == strOperationTypeId);
            let objSysOperationType;
            if (arrSysOperationType_Sel.length > 0) {
                objSysOperationType = arrSysOperationType_Sel[0];
                return objSysOperationType.operationTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strOperationTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.SysOperationType_GetNameByOperationTypeId_Cache = SysOperationType_GetNameByOperationTypeId_Cache;
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
    async function SysOperationType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strOperationTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSysOperationType = await SysOperationType_GetObjByOperationTypeId_Cache(strOperationTypeId);
        if (objSysOperationType == null)
            return "";
        return objSysOperationType.GetFldValue(strOutFldName).toString();
    }
    exports.SysOperationType_func = SysOperationType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysOperationType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.operationTypeId.localeCompare(b.operationTypeId);
    }
    exports.SysOperationType_SortFun_Defa = SysOperationType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysOperationType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.memo == b.memo)
            return a.operationTypeName.localeCompare(b.operationTypeName);
        else
            return a.memo.localeCompare(b.memo);
    }
    exports.SysOperationType_SortFun_Defa_2Fld = SysOperationType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysOperationType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId:
                    return (a, b) => {
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName:
                    return (a, b) => {
                        return a.operationTypeName.localeCompare(b.operationTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysOperationType]中不存在！(in ${exports.sysOperationType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId:
                    return (a, b) => {
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName:
                    return (a, b) => {
                        return b.operationTypeName.localeCompare(a.operationTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysOperationType]中不存在！(in ${exports.sysOperationType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysOperationType_SortFunByKey = SysOperationType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysOperationType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName:
                return (obj) => {
                    return obj.operationTypeName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysOperationType]中不存在！(in ${exports.sysOperationType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysOperationType_FilterFunByKey = SysOperationType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysOperationType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetFirstIDAsync = SysOperationType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysOperationType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetFirstID = SysOperationType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysOperationType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysOperationType = SysOperationType_GetObjFromJsonObj(returnObj);
                return objSysOperationType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetFirstObjAsync = SysOperationType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
        clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSysOperationTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrSysOperationTypeObjLst_T = SysOperationType_GetObjLstByJSONObjLst(arrSysOperationTypeExObjLst_Cache);
            return arrSysOperationTypeObjLst_T;
        }
        try {
            const arrSysOperationTypeExObjLst = await SysOperationType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrSysOperationTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysOperationTypeExObjLst.length);
            console.log(strInfo);
            return arrSysOperationTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysOperationType_GetObjLst_ClientCache = SysOperationType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
        clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysOperationTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysOperationTypeObjLst_T = SysOperationType_GetObjLstByJSONObjLst(arrSysOperationTypeExObjLst_Cache);
            return arrSysOperationTypeObjLst_T;
        }
        try {
            const arrSysOperationTypeExObjLst = await SysOperationType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSysOperationTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysOperationTypeExObjLst.length);
            console.log(strInfo);
            return arrSysOperationTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysOperationType_GetObjLst_localStorage = SysOperationType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysOperationTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysOperationTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysOperationType_GetObjLst_localStorage_PureCache = SysOperationType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysOperationType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysOperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetObjLstAsync = SysOperationType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
        clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysOperationTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysOperationTypeObjLst_T = SysOperationType_GetObjLstByJSONObjLst(arrSysOperationTypeExObjLst_Cache);
            return arrSysOperationTypeObjLst_T;
        }
        try {
            const arrSysOperationTypeExObjLst = await SysOperationType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSysOperationTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysOperationTypeExObjLst.length);
            console.log(strInfo);
            return arrSysOperationTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysOperationType_GetObjLst_sessionStorage = SysOperationType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysOperationTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysOperationTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysOperationType_GetObjLst_sessionStorage_PureCache = SysOperationType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrSysOperationTypeObjLst_Cache;
        switch (clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_ClientCache();
                break;
            default:
                arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_ClientCache();
                break;
        }
        const arrSysOperationTypeObjLst = SysOperationType_GetObjLstByJSONObjLst(arrSysOperationTypeObjLst_Cache);
        return arrSysOperationTypeObjLst_Cache;
    }
    exports.SysOperationType_GetObjLst_Cache = SysOperationType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysOperationType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSysOperationTypeObjLst_Cache;
        switch (clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrSysOperationTypeObjLst_Cache = null;
                break;
            default:
                arrSysOperationTypeObjLst_Cache = null;
                break;
        }
        return arrSysOperationTypeObjLst_Cache;
    }
    exports.SysOperationType_GetObjLst_PureCache = SysOperationType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrOperationTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysOperationType_GetSubObjLst_Cache(objSysOperationType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        let arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache;
        if (objSysOperationType_Cond.sf_FldComparisonOp == null || objSysOperationType_Cond.sf_FldComparisonOp == "")
            return arrSysOperationType_Sel;
        const dicFldComparisonOp = JSON.parse(objSysOperationType_Cond.sf_FldComparisonOp);
        //console.log("clsSysOperationTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysOperationType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysOperationType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSysOperationType_Cond), exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysOperationType_GetSubObjLst_Cache = SysOperationType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrOperationTypeId:关键字列表
    * @returns 对象列表
    **/
    async function SysOperationType_GetObjLstByOperationTypeIdLstAsync(arrOperationTypeId) {
        const strThisFuncName = "GetObjLstByOperationTypeIdLstAsync";
        const strAction = "GetObjLstByOperationTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrOperationTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysOperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetObjLstByOperationTypeIdLstAsync = SysOperationType_GetObjLstByOperationTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrOperationTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function SysOperationType_GetObjLstByOperationTypeIdLst_Cache(arrOperationTypeIdLst) {
        const strThisFuncName = "GetObjLstByOperationTypeIdLst_Cache";
        try {
            const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
            const arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache.filter(x => arrOperationTypeIdLst.indexOf(x.operationTypeId) > -1);
            return arrSysOperationType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrOperationTypeIdLst.join(","), exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysOperationType_GetObjLstByOperationTypeIdLst_Cache = SysOperationType_GetObjLstByOperationTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysOperationType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysOperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetTopObjLstAsync = SysOperationType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysOperationType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysOperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetObjLstByRangeAsync = SysOperationType_GetObjLstByRangeAsync;
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
    async function SysOperationType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetObjLstByRange = SysOperationType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysOperationType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        if (arrSysOperationTypeObjLst_Cache.length == 0)
            return arrSysOperationTypeObjLst_Cache;
        let arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysOperationType_Cond = new clsSysOperationTypeEN_js_1.clsSysOperationTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysOperationType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysOperationTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysOperationType_Sel.length == 0)
                return arrSysOperationType_Sel;
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
                arrSysOperationType_Sel = arrSysOperationType_Sel.sort(SysOperationType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysOperationType_Sel = arrSysOperationType_Sel.sort(objPagerPara.sortFun);
            }
            arrSysOperationType_Sel = arrSysOperationType_Sel.slice(intStart, intEnd);
            return arrSysOperationType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysOperationType_GetObjLstByPager_Cache = SysOperationType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysOperationType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysOperationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysOperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetObjLstByPagerAsync = SysOperationType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strOperationTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function SysOperationType_DelRecordAsync(strOperationTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strOperationTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strOperationTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_DelRecordAsync = SysOperationType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrOperationTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysOperationType_DelSysOperationTypesAsync(arrOperationTypeId) {
        const strThisFuncName = "DelSysOperationTypesAsync";
        const strAction = "DelSysOperationTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrOperationTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_DelSysOperationTypesAsync = SysOperationType_DelSysOperationTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysOperationType_DelSysOperationTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysOperationTypesByCondAsync";
        const strAction = "DelSysOperationTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_DelSysOperationTypesByCondAsync = SysOperationType_DelSysOperationTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysOperationTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysOperationType_AddNewRecordAsync(objSysOperationTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objSysOperationTypeEN.operationTypeId === null || objSysOperationTypeEN.operationTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSysOperationTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_AddNewRecordAsync = SysOperationType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysOperationTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysOperationType_AddNewRecordWithMaxIdAsync(objSysOperationTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_AddNewRecordWithMaxIdAsync = SysOperationType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysOperationTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysOperationType_AddNewRecordWithReturnKeyAsync(objSysOperationTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_AddNewRecordWithReturnKeyAsync = SysOperationType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysOperationTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysOperationType_AddNewRecordWithReturnKey(objSysOperationTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysOperationTypeEN.operationTypeId === null || objSysOperationTypeEN.operationTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysOperationTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_AddNewRecordWithReturnKey = SysOperationType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysOperationTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysOperationType_UpdateRecordAsync(objSysOperationTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysOperationTypeEN.sf_UpdFldSetStr === undefined || objSysOperationTypeEN.sf_UpdFldSetStr === null || objSysOperationTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysOperationTypeEN.operationTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_UpdateRecordAsync = SysOperationType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysOperationTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysOperationType_UpdateWithConditionAsync(objSysOperationTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysOperationTypeEN.sf_UpdFldSetStr === undefined || objSysOperationTypeEN.sf_UpdFldSetStr === null || objSysOperationTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysOperationTypeEN.operationTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        objSysOperationTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_UpdateWithConditionAsync = SysOperationType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrOperationTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysOperationType_IsExistRecord_Cache(objSysOperationType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        if (arrSysOperationTypeObjLst_Cache == null)
            return false;
        let arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache;
        if (objSysOperationType_Cond.sf_FldComparisonOp == null || objSysOperationType_Cond.sf_FldComparisonOp == "")
            return arrSysOperationType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSysOperationType_Cond.sf_FldComparisonOp);
        //console.log("clsSysOperationTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysOperationType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysOperationType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSysOperationType_Cond), exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SysOperationType_IsExistRecord_Cache = SysOperationType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysOperationType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_IsExistRecordAsync = SysOperationType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strOperationTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysOperationType_IsExist(strOperationTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "OperationTypeId": strOperationTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_IsExist = SysOperationType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function SysOperationType_IsExist_Cache(strOperationTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        if (arrSysOperationTypeObjLst_Cache == null)
            return false;
        try {
            const arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache.filter(x => x.operationTypeId == strOperationTypeId);
            if (arrSysOperationType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strOperationTypeId, exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SysOperationType_IsExist_Cache = SysOperationType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strOperationTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysOperationType_IsExistAsync(strOperationTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strOperationTypeId": strOperationTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_IsExistAsync = SysOperationType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysOperationType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetRecCountByCondAsync = SysOperationType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSysOperationType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SysOperationType_GetRecCountByCond_Cache(objSysOperationType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSysOperationTypeObjLst_Cache = await SysOperationType_GetObjLst_Cache();
        if (arrSysOperationTypeObjLst_Cache == null)
            return 0;
        let arrSysOperationType_Sel = arrSysOperationTypeObjLst_Cache;
        if (objSysOperationType_Cond.sf_FldComparisonOp == null || objSysOperationType_Cond.sf_FldComparisonOp == "")
            return arrSysOperationType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSysOperationType_Cond.sf_FldComparisonOp);
        //console.log("clsSysOperationTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysOperationType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysOperationType_Sel = arrSysOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysOperationType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSysOperationType_Cond), exports.sysOperationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SysOperationType_GetRecCountByCond_Cache = SysOperationType_GetRecCountByCond_Cache;
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
    async function SysOperationType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysOperationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysOperationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysOperationType_GetMaxStrIdByPrefix = SysOperationType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysOperationType_GetWebApiUrl(strController, strAction) {
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
    exports.SysOperationType_GetWebApiUrl = SysOperationType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SysOperationType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
        switch (clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheModeId) {
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
    exports.SysOperationType_ReFreshCache = SysOperationType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SysOperationType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsSysOperationTypeEN_js_1.clsSysOperationTypeEN._CurrTabName;
            switch (clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.CacheModeId) {
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
    exports.SysOperationType_ReFreshThisCache = SysOperationType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function SysOperationType_BindDdl_OperationTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_OperationTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_OperationTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_OperationTypeIdInDiv_Cache");
        const arrObjLst_Sel = await SysOperationType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId, clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName, "操作类型表");
    }
    exports.SysOperationType_BindDdl_OperationTypeIdInDiv_Cache = SysOperationType_BindDdl_OperationTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysOperationType_CheckPropertyNew(pobjSysOperationTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjSysOperationTypeEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 操作类型表(SysOperationType))!值:$(pobjSysOperationTypeEN.operationTypeId)(clsSysOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysOperationTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 操作类型表(SysOperationType))!值:$(pobjSysOperationTypeEN.memo)(clsSysOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjSysOperationTypeEN.operationTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[操作类型名(operationTypeName)]的长度不能超过50(In 操作类型表(SysOperationType))!值:$(pobjSysOperationTypeEN.operationTypeName)(clsSysOperationTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeId) == false && undefined !== pobjSysOperationTypeEN.operationTypeId && jsString_js_1.tzDataType.isString(pobjSysOperationTypeEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysOperationTypeEN.operationTypeId)], 非法，应该为字符型(In 操作类型表(SysOperationType))!(clsSysOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.memo) == false && undefined !== pobjSysOperationTypeEN.memo && jsString_js_1.tzDataType.isString(pobjSysOperationTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysOperationTypeEN.memo)], 非法，应该为字符型(In 操作类型表(SysOperationType))!(clsSysOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeName) == false && undefined !== pobjSysOperationTypeEN.operationTypeName && jsString_js_1.tzDataType.isString(pobjSysOperationTypeEN.operationTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型名(operationTypeName)]的值:[$(pobjSysOperationTypeEN.operationTypeName)], 非法，应该为字符型(In 操作类型表(SysOperationType))!(clsSysOperationTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysOperationTypeEN.SetIsCheckProperty(true);
    }
    exports.SysOperationType_CheckPropertyNew = SysOperationType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysOperationType_CheckProperty4Update(pobjSysOperationTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjSysOperationTypeEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 操作类型表(SysOperationType))!值:$(pobjSysOperationTypeEN.operationTypeId)(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysOperationTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 操作类型表(SysOperationType))!值:$(pobjSysOperationTypeEN.memo)(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjSysOperationTypeEN.operationTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[操作类型名(operationTypeName)]的长度不能超过50(In 操作类型表(SysOperationType))!值:$(pobjSysOperationTypeEN.operationTypeName)(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeId) == false && undefined !== pobjSysOperationTypeEN.operationTypeId && jsString_js_1.tzDataType.isString(pobjSysOperationTypeEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjSysOperationTypeEN.operationTypeId)], 非法，应该为字符型(In 操作类型表(SysOperationType))!(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.memo) == false && undefined !== pobjSysOperationTypeEN.memo && jsString_js_1.tzDataType.isString(pobjSysOperationTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysOperationTypeEN.memo)], 非法，应该为字符型(In 操作类型表(SysOperationType))!(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeName) == false && undefined !== pobjSysOperationTypeEN.operationTypeName && jsString_js_1.tzDataType.isString(pobjSysOperationTypeEN.operationTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型名(operationTypeName)]的值:[$(pobjSysOperationTypeEN.operationTypeName)], 非法，应该为字符型(In 操作类型表(SysOperationType))!(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysOperationTypeEN.operationTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[操作类型ID]不能为空(In 操作类型表)!(clsSysOperationTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysOperationTypeEN.SetIsCheckProperty(true);
    }
    exports.SysOperationType_CheckProperty4Update = SysOperationType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysOperationType_GetJSONStrByObj(pobjSysOperationTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysOperationTypeEN.sf_UpdFldSetStr = pobjSysOperationTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysOperationTypeEN);
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
    exports.SysOperationType_GetJSONStrByObj = SysOperationType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysOperationType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysOperationTypeObjLst = new Array();
        if (strJSON === "") {
            return arrSysOperationTypeObjLst;
        }
        try {
            arrSysOperationTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysOperationTypeObjLst;
        }
        return arrSysOperationTypeObjLst;
    }
    exports.SysOperationType_GetObjLstByJSONStr = SysOperationType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysOperationTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysOperationType_GetObjLstByJSONObjLst(arrSysOperationTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysOperationTypeObjLst = new Array();
        for (const objInFor of arrSysOperationTypeObjLstS) {
            const obj1 = SysOperationType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysOperationTypeObjLst.push(obj1);
        }
        return arrSysOperationTypeObjLst;
    }
    exports.SysOperationType_GetObjLstByJSONObjLst = SysOperationType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysOperationType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysOperationTypeEN = new clsSysOperationTypeEN_js_1.clsSysOperationTypeEN();
        if (strJSON === "") {
            return pobjSysOperationTypeEN;
        }
        try {
            pobjSysOperationTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysOperationTypeEN;
        }
        return pobjSysOperationTypeEN;
    }
    exports.SysOperationType_GetObjByJSONStr = SysOperationType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysOperationType_GetCombineCondition(objSysOperationType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysOperationType_Cond.dicFldComparisonOp, clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objSysOperationType_Cond.dicFldComparisonOp[clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeId, objSysOperationType_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysOperationType_Cond.dicFldComparisonOp, clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysOperationType_Cond.dicFldComparisonOp[clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_Memo, objSysOperationType_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysOperationType_Cond.dicFldComparisonOp, clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName) == true) {
            const strComparisonOp_OperationTypeName = objSysOperationType_Cond.dicFldComparisonOp[clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysOperationTypeEN_js_1.clsSysOperationTypeEN.con_OperationTypeName, objSysOperationType_Cond.operationTypeName, strComparisonOp_OperationTypeName);
        }
        return strWhereCond;
    }
    exports.SysOperationType_GetCombineCondition = SysOperationType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysOperationTypeENS:源对象
     * @param objSysOperationTypeENT:目标对象
    */
    function SysOperationType_CopyObjTo(objSysOperationTypeENS, objSysOperationTypeENT) {
        objSysOperationTypeENT.operationTypeId = objSysOperationTypeENS.operationTypeId; //操作类型ID
        objSysOperationTypeENT.memo = objSysOperationTypeENS.memo; //备注
        objSysOperationTypeENT.operationTypeName = objSysOperationTypeENS.operationTypeName; //操作类型名
        objSysOperationTypeENT.sf_UpdFldSetStr = objSysOperationTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysOperationType_CopyObjTo = SysOperationType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysOperationTypeENS:源对象
     * @param objSysOperationTypeENT:目标对象
    */
    function SysOperationType_GetObjFromJsonObj(objSysOperationTypeENS) {
        const objSysOperationTypeENT = new clsSysOperationTypeEN_js_1.clsSysOperationTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysOperationTypeENT, objSysOperationTypeENS);
        return objSysOperationTypeENT;
    }
    exports.SysOperationType_GetObjFromJsonObj = SysOperationType_GetObjFromJsonObj;
});
