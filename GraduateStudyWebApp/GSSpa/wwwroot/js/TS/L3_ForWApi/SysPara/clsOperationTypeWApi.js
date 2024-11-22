/**
* 类名:clsOperationTypeWApi
* 表名:OperationType(01120538)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:45:54
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统参数(SysPara)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/SysPara/clsOperationTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.OperationType_GetObjFromJsonObj = exports.OperationType_CopyObjTo = exports.OperationType_GetUniCondStr4Update_OperationTypeId = exports.OperationType_GetUniCondStr_OperationTypeId = exports.OperationType_GetCombineCondition = exports.OperationType_GetObjByJSONStr = exports.OperationType_GetObjLstByJSONObjLst = exports.OperationType_GetObjLstByJSONStr = exports.OperationType_GetJSONStrByObj = exports.OperationType_CheckProperty4Update = exports.OperationType_CheckPropertyNew = exports.OperationType__Cache = exports.OperationType_ReFreshThisCache = exports.OperationType_ReFreshCache = exports.OperationType_GetWebApiUrl = exports.OperationType_GetMaxStrIdByPrefix = exports.OperationType_GetMaxStrIdAsync = exports.OperationType_GetRecCountByCond_Cache = exports.OperationType_GetRecCountByCondAsync = exports.OperationType_IsExistAsync = exports.OperationType_IsExist_Cache = exports.OperationType_IsExist = exports.OperationType_IsExistRecordAsync = exports.OperationType_IsExistRecord_Cache = exports.OperationType_UpdateWithConditionAsync = exports.OperationType_UpdateRecordAsync = exports.OperationType_AddNewRecordWithReturnKey = exports.OperationType_AddNewRecordWithReturnKeyAsync = exports.OperationType_AddNewRecordWithMaxIdAsync = exports.OperationType_AddNewRecordAsync = exports.OperationType_DelOperationTypesByCondAsync = exports.OperationType_DelOperationTypesAsync = exports.OperationType_DelRecordAsync = exports.OperationType_GetObjLstByPagerAsync = exports.OperationType_GetObjLstByPager_Cache = exports.OperationType_GetObjLstByRange = exports.OperationType_GetObjLstByRangeAsync = exports.OperationType_GetTopObjLstAsync = exports.OperationType_GetObjLstByOperationTypeIdLst_Cache = exports.OperationType_GetObjLstByOperationTypeIdLstAsync = exports.OperationType_GetSubObjLst_Cache = exports.OperationType_GetObjLst_PureCache = exports.OperationType_GetObjLst_Cache = exports.OperationType_GetObjLst_sessionStorage_PureCache = exports.OperationType_GetObjLst_sessionStorage = exports.OperationType_GetObjLstAsync = exports.OperationType_GetObjLst_localStorage_PureCache = exports.OperationType_GetObjLst_localStorage = exports.OperationType_GetObjLst_ClientCache = exports.OperationType_GetFirstObjAsync = exports.OperationType_GetFirstID = exports.OperationType_GetFirstIDAsync = exports.OperationType_FilterFunByKey = exports.OperationType_SortFunByKey = exports.OperationType_SortFun_Defa_2Fld = exports.OperationType_SortFun_Defa = exports.OperationType_func = exports.OperationType_GetNameByOperationTypeId_Cache = exports.OperationType_UpdateObjInLst_Cache = exports.OperationType_GetObjByOperationTypeId_localStorage = exports.OperationType_GetObjByOperationTypeId_Cache = exports.OperationType_GetObjByOperationTypeIdAsync = exports.operationType_ConstructorName = exports.operationType_Controller = void 0;
    /**
     * 操作类型(OperationType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsOperationTypeEN_js_1 = require("../../L0_Entity/SysPara/clsOperationTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.operationType_Controller = "OperationTypeApi";
    exports.operationType_ConstructorName = "operationType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strOperationTypeId:关键字
    * @returns 对象
    **/
    async function OperationType_GetObjByOperationTypeIdAsync(strOperationTypeId) {
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
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objOperationType = OperationType_GetObjFromJsonObj(returnObj);
                return objOperationType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetObjByOperationTypeIdAsync = OperationType_GetObjByOperationTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function OperationType_GetObjByOperationTypeId_Cache(strOperationTypeId, bolTryAsyncOnce = true) {
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
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        try {
            const arrOperationType_Sel = arrOperationTypeObjLst_Cache.filter(x => x.operationTypeId == strOperationTypeId);
            let objOperationType;
            if (arrOperationType_Sel.length > 0) {
                objOperationType = arrOperationType_Sel[0];
                return objOperationType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objOperationType = await OperationType_GetObjByOperationTypeIdAsync(strOperationTypeId);
                    if (objOperationType != null) {
                        OperationType_ReFreshThisCache();
                        return objOperationType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strOperationTypeId, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.OperationType_GetObjByOperationTypeId_Cache = OperationType_GetObjByOperationTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function OperationType_GetObjByOperationTypeId_localStorage(strOperationTypeId) {
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
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName, strOperationTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objOperationType_Cache = JSON.parse(strTempObj);
            return objOperationType_Cache;
        }
        try {
            const objOperationType = await OperationType_GetObjByOperationTypeIdAsync(strOperationTypeId);
            if (objOperationType != null) {
                localStorage.setItem(strKey, JSON.stringify(objOperationType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objOperationType;
            }
            return objOperationType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strOperationTypeId, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.OperationType_GetObjByOperationTypeId_localStorage = OperationType_GetObjByOperationTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objOperationType:所给的对象
     * @returns 对象
    */
    async function OperationType_UpdateObjInLst_Cache(objOperationType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
            const obj = arrOperationTypeObjLst_Cache.find(x => x.operationTypeId == objOperationType.operationTypeId);
            if (obj != null) {
                objOperationType.operationTypeId = obj.operationTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objOperationType);
            }
            else {
                arrOperationTypeObjLst_Cache.push(objOperationType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.OperationType_UpdateObjInLst_Cache = OperationType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function OperationType_GetNameByOperationTypeId_Cache(strOperationTypeId) {
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
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        if (arrOperationTypeObjLst_Cache == null)
            return "";
        try {
            const arrOperationType_Sel = arrOperationTypeObjLst_Cache.filter(x => x.operationTypeId == strOperationTypeId);
            let objOperationType;
            if (arrOperationType_Sel.length > 0) {
                objOperationType = arrOperationType_Sel[0];
                return objOperationType.operationTypeName;
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
    exports.OperationType_GetNameByOperationTypeId_Cache = OperationType_GetNameByOperationTypeId_Cache;
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
    async function OperationType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsOperationTypeEN_js_1.clsOperationTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsOperationTypeEN_js_1.clsOperationTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strOperationTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objOperationType = await OperationType_GetObjByOperationTypeId_Cache(strOperationTypeId);
        if (objOperationType == null)
            return "";
        return objOperationType.GetFldValue(strOutFldName).toString();
    }
    exports.OperationType_func = OperationType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function OperationType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.operationTypeId.localeCompare(b.operationTypeId);
    }
    exports.OperationType_SortFun_Defa = OperationType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function OperationType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.operationTypeName == b.operationTypeName)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.operationTypeName.localeCompare(b.operationTypeName);
    }
    exports.OperationType_SortFun_Defa_2Fld = OperationType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function OperationType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId:
                    return (a, b) => {
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName:
                    return (a, b) => {
                        return a.operationTypeName.localeCompare(b.operationTypeName);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[OperationType]中不存在！(in ${exports.operationType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId:
                    return (a, b) => {
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName:
                    return (a, b) => {
                        return b.operationTypeName.localeCompare(a.operationTypeName);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsOperationTypeEN_js_1.clsOperationTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[OperationType]中不存在！(in ${exports.operationType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.OperationType_SortFunByKey = OperationType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function OperationType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName:
                return (obj) => {
                    return obj.operationTypeName === value;
                };
            case clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsOperationTypeEN_js_1.clsOperationTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[OperationType]中不存在！(in ${exports.operationType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.OperationType_FilterFunByKey = OperationType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function OperationType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetFirstIDAsync = OperationType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function OperationType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetFirstID = OperationType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function OperationType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objOperationType = OperationType_GetObjFromJsonObj(returnObj);
                return objOperationType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetFirstObjAsync = OperationType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
        clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrOperationTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrOperationTypeObjLst_T = OperationType_GetObjLstByJSONObjLst(arrOperationTypeExObjLst_Cache);
            return arrOperationTypeObjLst_T;
        }
        try {
            const arrOperationTypeExObjLst = await OperationType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrOperationTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrOperationTypeExObjLst.length);
            console.log(strInfo);
            return arrOperationTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.OperationType_GetObjLst_ClientCache = OperationType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
        clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrOperationTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrOperationTypeObjLst_T = OperationType_GetObjLstByJSONObjLst(arrOperationTypeExObjLst_Cache);
            return arrOperationTypeObjLst_T;
        }
        try {
            const arrOperationTypeExObjLst = await OperationType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrOperationTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrOperationTypeExObjLst.length);
            console.log(strInfo);
            return arrOperationTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.OperationType_GetObjLst_localStorage = OperationType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrOperationTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrOperationTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.OperationType_GetObjLst_localStorage_PureCache = OperationType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function OperationType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = OperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetObjLstAsync = OperationType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
        clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsOperationTypeEN_js_1.clsOperationTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrOperationTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrOperationTypeObjLst_T = OperationType_GetObjLstByJSONObjLst(arrOperationTypeExObjLst_Cache);
            return arrOperationTypeObjLst_T;
        }
        try {
            const arrOperationTypeExObjLst = await OperationType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrOperationTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrOperationTypeExObjLst.length);
            console.log(strInfo);
            return arrOperationTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.OperationType_GetObjLst_sessionStorage = OperationType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrOperationTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrOperationTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.OperationType_GetObjLst_sessionStorage_PureCache = OperationType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrOperationTypeObjLst_Cache;
        switch (clsOperationTypeEN_js_1.clsOperationTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_ClientCache();
                break;
            default:
                arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_ClientCache();
                break;
        }
        const arrOperationTypeObjLst = OperationType_GetObjLstByJSONObjLst(arrOperationTypeObjLst_Cache);
        return arrOperationTypeObjLst_Cache;
    }
    exports.OperationType_GetObjLst_Cache = OperationType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function OperationType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrOperationTypeObjLst_Cache;
        switch (clsOperationTypeEN_js_1.clsOperationTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrOperationTypeObjLst_Cache = null;
                break;
            default:
                arrOperationTypeObjLst_Cache = null;
                break;
        }
        return arrOperationTypeObjLst_Cache;
    }
    exports.OperationType_GetObjLst_PureCache = OperationType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrOperationTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function OperationType_GetSubObjLst_Cache(objOperationType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        let arrOperationType_Sel = arrOperationTypeObjLst_Cache;
        if (objOperationType_Cond.sf_FldComparisonOp == null || objOperationType_Cond.sf_FldComparisonOp == "")
            return arrOperationType_Sel;
        const dicFldComparisonOp = JSON.parse(objOperationType_Cond.sf_FldComparisonOp);
        //console.log("clsOperationTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objOperationType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrOperationType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objOperationType_Cond), exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.OperationType_GetSubObjLst_Cache = OperationType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrOperationTypeId:关键字列表
    * @returns 对象列表
    **/
    async function OperationType_GetObjLstByOperationTypeIdLstAsync(arrOperationTypeId) {
        const strThisFuncName = "GetObjLstByOperationTypeIdLstAsync";
        const strAction = "GetObjLstByOperationTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrOperationTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = OperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetObjLstByOperationTypeIdLstAsync = OperationType_GetObjLstByOperationTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrOperationTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function OperationType_GetObjLstByOperationTypeIdLst_Cache(arrOperationTypeIdLst) {
        const strThisFuncName = "GetObjLstByOperationTypeIdLst_Cache";
        try {
            const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
            const arrOperationType_Sel = arrOperationTypeObjLst_Cache.filter(x => arrOperationTypeIdLst.indexOf(x.operationTypeId) > -1);
            return arrOperationType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrOperationTypeIdLst.join(","), exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.OperationType_GetObjLstByOperationTypeIdLst_Cache = OperationType_GetObjLstByOperationTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function OperationType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = OperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetTopObjLstAsync = OperationType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function OperationType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = OperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetObjLstByRangeAsync = OperationType_GetObjLstByRangeAsync;
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
    async function OperationType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetObjLstByRange = OperationType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function OperationType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        if (arrOperationTypeObjLst_Cache.length == 0)
            return arrOperationTypeObjLst_Cache;
        let arrOperationType_Sel = arrOperationTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objOperationType_Cond = new clsOperationTypeEN_js_1.clsOperationTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objOperationType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsOperationTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrOperationType_Sel.length == 0)
                return arrOperationType_Sel;
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
                arrOperationType_Sel = arrOperationType_Sel.sort(OperationType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrOperationType_Sel = arrOperationType_Sel.sort(objPagerPara.sortFun);
            }
            arrOperationType_Sel = arrOperationType_Sel.slice(intStart, intEnd);
            return arrOperationType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.OperationType_GetObjLstByPager_Cache = OperationType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function OperationType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.operationType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = OperationType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetObjLstByPagerAsync = OperationType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strOperationTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function OperationType_DelRecordAsync(strOperationTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_DelRecordAsync = OperationType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrOperationTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function OperationType_DelOperationTypesAsync(arrOperationTypeId) {
        const strThisFuncName = "DelOperationTypesAsync";
        const strAction = "DelOperationTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_DelOperationTypesAsync = OperationType_DelOperationTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function OperationType_DelOperationTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelOperationTypesByCondAsync";
        const strAction = "DelOperationTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_DelOperationTypesByCondAsync = OperationType_DelOperationTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objOperationTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function OperationType_AddNewRecordAsync(objOperationTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objOperationTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_AddNewRecordAsync = OperationType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objOperationTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function OperationType_AddNewRecordWithMaxIdAsync(objOperationTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_AddNewRecordWithMaxIdAsync = OperationType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objOperationTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function OperationType_AddNewRecordWithReturnKeyAsync(objOperationTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_AddNewRecordWithReturnKeyAsync = OperationType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objOperationTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function OperationType_AddNewRecordWithReturnKey(objOperationTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objOperationTypeEN.operationTypeId === null || objOperationTypeEN.operationTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOperationTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_AddNewRecordWithReturnKey = OperationType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objOperationTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function OperationType_UpdateRecordAsync(objOperationTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objOperationTypeEN.sf_UpdFldSetStr === undefined || objOperationTypeEN.sf_UpdFldSetStr === null || objOperationTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objOperationTypeEN.operationTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_UpdateRecordAsync = OperationType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objOperationTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function OperationType_UpdateWithConditionAsync(objOperationTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objOperationTypeEN.sf_UpdFldSetStr === undefined || objOperationTypeEN.sf_UpdFldSetStr === null || objOperationTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objOperationTypeEN.operationTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
        objOperationTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objOperationTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_UpdateWithConditionAsync = OperationType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrOperationTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function OperationType_IsExistRecord_Cache(objOperationType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        if (arrOperationTypeObjLst_Cache == null)
            return false;
        let arrOperationType_Sel = arrOperationTypeObjLst_Cache;
        if (objOperationType_Cond.sf_FldComparisonOp == null || objOperationType_Cond.sf_FldComparisonOp == "")
            return arrOperationType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objOperationType_Cond.sf_FldComparisonOp);
        //console.log("clsOperationTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objOperationType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrOperationType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objOperationType_Cond), exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.OperationType_IsExistRecord_Cache = OperationType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function OperationType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_IsExistRecordAsync = OperationType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strOperationTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function OperationType_IsExist(strOperationTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_IsExist = OperationType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strOperationTypeId:所给的关键字
     * @returns 对象
    */
    async function OperationType_IsExist_Cache(strOperationTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        if (arrOperationTypeObjLst_Cache == null)
            return false;
        try {
            const arrOperationType_Sel = arrOperationTypeObjLst_Cache.filter(x => x.operationTypeId == strOperationTypeId);
            if (arrOperationType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strOperationTypeId, exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.OperationType_IsExist_Cache = OperationType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strOperationTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function OperationType_IsExistAsync(strOperationTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_IsExistAsync = OperationType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function OperationType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetRecCountByCondAsync = OperationType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objOperationType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function OperationType_GetRecCountByCond_Cache(objOperationType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrOperationTypeObjLst_Cache = await OperationType_GetObjLst_Cache();
        if (arrOperationTypeObjLst_Cache == null)
            return 0;
        let arrOperationType_Sel = arrOperationTypeObjLst_Cache;
        if (objOperationType_Cond.sf_FldComparisonOp == null || objOperationType_Cond.sf_FldComparisonOp == "")
            return arrOperationType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objOperationType_Cond.sf_FldComparisonOp);
        //console.log("clsOperationTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objOperationType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objOperationType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrOperationType_Sel = arrOperationType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrOperationType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objOperationType_Cond), exports.operationType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.OperationType_GetRecCountByCond_Cache = OperationType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function OperationType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetMaxStrIdAsync = OperationType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function OperationType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.operationType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.operationType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.OperationType_GetMaxStrIdByPrefix = OperationType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function OperationType_GetWebApiUrl(strController, strAction) {
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
    exports.OperationType_GetWebApiUrl = OperationType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function OperationType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
        switch (clsOperationTypeEN_js_1.clsOperationTypeEN.CacheModeId) {
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
    exports.OperationType_ReFreshCache = OperationType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function OperationType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsOperationTypeEN_js_1.clsOperationTypeEN._CurrTabName;
            switch (clsOperationTypeEN_js_1.clsOperationTypeEN.CacheModeId) {
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
    exports.OperationType_ReFreshThisCache = OperationType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function OperationType__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await OperationType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId, clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName, "操作类型");
    }
    exports.OperationType__Cache = OperationType__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function OperationType_CheckPropertyNew(pobjOperationTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[操作类型名]不能为空(In 操作类型)!(clsOperationTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.operationTypeId)(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.operationTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[操作类型名(operationTypeName)]的长度不能超过50(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.operationTypeName)(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.updDate)(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.updUserId)(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.memo)(clsOperationTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeId) == false && undefined !== pobjOperationTypeEN.operationTypeId && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjOperationTypeEN.operationTypeId)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeName) == false && undefined !== pobjOperationTypeEN.operationTypeName && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.operationTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型名(operationTypeName)]的值:[$(pobjOperationTypeEN.operationTypeName)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updDate) == false && undefined !== pobjOperationTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjOperationTypeEN.updDate)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updUserId) == false && undefined !== pobjOperationTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjOperationTypeEN.updUserId)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.memo) == false && undefined !== pobjOperationTypeEN.memo && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjOperationTypeEN.memo)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjOperationTypeEN.SetIsCheckProperty(true);
    }
    exports.OperationType_CheckPropertyNew = OperationType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function OperationType_CheckProperty4Update(pobjOperationTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.operationTypeId)(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.operationTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[操作类型名(operationTypeName)]的长度不能超过50(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.operationTypeName)(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.updDate)(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.updUserId)(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjOperationTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 操作类型(OperationType))!值:$(pobjOperationTypeEN.memo)(clsOperationTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeId) == false && undefined !== pobjOperationTypeEN.operationTypeId && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjOperationTypeEN.operationTypeId)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeName) == false && undefined !== pobjOperationTypeEN.operationTypeName && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.operationTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型名(operationTypeName)]的值:[$(pobjOperationTypeEN.operationTypeName)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updDate) == false && undefined !== pobjOperationTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjOperationTypeEN.updDate)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.updUserId) == false && undefined !== pobjOperationTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjOperationTypeEN.updUserId)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.memo) == false && undefined !== pobjOperationTypeEN.memo && jsString_js_1.tzDataType.isString(pobjOperationTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjOperationTypeEN.memo)], 非法，应该为字符型(In 操作类型(OperationType))!(clsOperationTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjOperationTypeEN.operationTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[操作类型ID]不能为空(In 操作类型)!(clsOperationTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjOperationTypeEN.SetIsCheckProperty(true);
    }
    exports.OperationType_CheckProperty4Update = OperationType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function OperationType_GetJSONStrByObj(pobjOperationTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjOperationTypeEN.sf_UpdFldSetStr = pobjOperationTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjOperationTypeEN);
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
    exports.OperationType_GetJSONStrByObj = OperationType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function OperationType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrOperationTypeObjLst = new Array();
        if (strJSON === "") {
            return arrOperationTypeObjLst;
        }
        try {
            arrOperationTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrOperationTypeObjLst;
        }
        return arrOperationTypeObjLst;
    }
    exports.OperationType_GetObjLstByJSONStr = OperationType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrOperationTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function OperationType_GetObjLstByJSONObjLst(arrOperationTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrOperationTypeObjLst = new Array();
        for (const objInFor of arrOperationTypeObjLstS) {
            const obj1 = OperationType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrOperationTypeObjLst.push(obj1);
        }
        return arrOperationTypeObjLst;
    }
    exports.OperationType_GetObjLstByJSONObjLst = OperationType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function OperationType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjOperationTypeEN = new clsOperationTypeEN_js_1.clsOperationTypeEN();
        if (strJSON === "") {
            return pobjOperationTypeEN;
        }
        try {
            pobjOperationTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjOperationTypeEN;
        }
        return pobjOperationTypeEN;
    }
    exports.OperationType_GetObjByJSONStr = OperationType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function OperationType_GetCombineCondition(objOperationType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objOperationType_Cond.dicFldComparisonOp, clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objOperationType_Cond.dicFldComparisonOp[clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeId, objOperationType_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objOperationType_Cond.dicFldComparisonOp, clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName) == true) {
            const strComparisonOp_OperationTypeName = objOperationType_Cond.dicFldComparisonOp[clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsOperationTypeEN_js_1.clsOperationTypeEN.con_OperationTypeName, objOperationType_Cond.operationTypeName, strComparisonOp_OperationTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objOperationType_Cond.dicFldComparisonOp, clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objOperationType_Cond.dicFldComparisonOp[clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdDate, objOperationType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objOperationType_Cond.dicFldComparisonOp, clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objOperationType_Cond.dicFldComparisonOp[clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsOperationTypeEN_js_1.clsOperationTypeEN.con_UpdUserId, objOperationType_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objOperationType_Cond.dicFldComparisonOp, clsOperationTypeEN_js_1.clsOperationTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objOperationType_Cond.dicFldComparisonOp[clsOperationTypeEN_js_1.clsOperationTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsOperationTypeEN_js_1.clsOperationTypeEN.con_Memo, objOperationType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.OperationType_GetCombineCondition = OperationType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--OperationType(操作类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strOperationTypeId: 操作类型ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function OperationType_GetUniCondStr_OperationTypeId(objOperationTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and OperationTypeId = '{0}'", objOperationTypeEN.operationTypeId);
        return strWhereCond;
    }
    exports.OperationType_GetUniCondStr_OperationTypeId = OperationType_GetUniCondStr_OperationTypeId;
    /**
    *获取唯一性条件串(Uniqueness)--OperationType(操作类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strOperationTypeId: 操作类型ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function OperationType_GetUniCondStr4Update_OperationTypeId(objOperationTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and OperationTypeId <> '{0}'", objOperationTypeEN.operationTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and OperationTypeId = '{0}'", objOperationTypeEN.operationTypeId);
        return strWhereCond;
    }
    exports.OperationType_GetUniCondStr4Update_OperationTypeId = OperationType_GetUniCondStr4Update_OperationTypeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objOperationTypeENS:源对象
     * @param objOperationTypeENT:目标对象
    */
    function OperationType_CopyObjTo(objOperationTypeENS, objOperationTypeENT) {
        objOperationTypeENT.operationTypeId = objOperationTypeENS.operationTypeId; //操作类型ID
        objOperationTypeENT.operationTypeName = objOperationTypeENS.operationTypeName; //操作类型名
        objOperationTypeENT.updDate = objOperationTypeENS.updDate; //修改日期
        objOperationTypeENT.updUserId = objOperationTypeENS.updUserId; //修改用户Id
        objOperationTypeENT.memo = objOperationTypeENS.memo; //备注
        objOperationTypeENT.sf_UpdFldSetStr = objOperationTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.OperationType_CopyObjTo = OperationType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objOperationTypeENS:源对象
     * @param objOperationTypeENT:目标对象
    */
    function OperationType_GetObjFromJsonObj(objOperationTypeENS) {
        const objOperationTypeENT = new clsOperationTypeEN_js_1.clsOperationTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objOperationTypeENT, objOperationTypeENS);
        return objOperationTypeENT;
    }
    exports.OperationType_GetObjFromJsonObj = OperationType_GetObjFromJsonObj;
});
