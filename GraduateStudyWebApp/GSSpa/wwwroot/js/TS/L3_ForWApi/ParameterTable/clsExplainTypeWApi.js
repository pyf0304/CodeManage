/**
* 类名:clsExplainTypeWApi
* 表名:ExplainType(01120548)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:26
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsExplainTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ExplainType_GetObjFromJsonObj = exports.ExplainType_CopyObjTo = exports.ExplainType_GetCombineCondition = exports.ExplainType_GetObjByJSONStr = exports.ExplainType_GetObjLstByJSONObjLst = exports.ExplainType_GetObjLstByJSONStr = exports.ExplainType_GetJSONStrByObj = exports.ExplainType_CheckProperty4Update = exports.ExplainType_CheckPropertyNew = exports.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache = exports.ExplainType_ReFreshThisCache = exports.ExplainType_ReFreshCache = exports.ExplainType_GetWebApiUrl = exports.ExplainType_GetMaxStrIdByPrefix = exports.ExplainType_GetRecCountByCond_Cache = exports.ExplainType_GetRecCountByCondAsync = exports.ExplainType_IsExistAsync = exports.ExplainType_IsExist_Cache = exports.ExplainType_IsExist = exports.ExplainType_IsExistRecordAsync = exports.ExplainType_IsExistRecord_Cache = exports.ExplainType_UpdateWithConditionAsync = exports.ExplainType_UpdateRecordAsync = exports.ExplainType_AddNewRecordWithReturnKey = exports.ExplainType_AddNewRecordWithReturnKeyAsync = exports.ExplainType_AddNewRecordWithMaxIdAsync = exports.ExplainType_AddNewRecordAsync = exports.ExplainType_DelExplainTypesByCondAsync = exports.ExplainType_DelExplainTypesAsync = exports.ExplainType_DelRecordAsync = exports.ExplainType_GetObjLstByPagerAsync = exports.ExplainType_GetObjLstByPager_Cache = exports.ExplainType_GetObjLstByRange = exports.ExplainType_GetObjLstByRangeAsync = exports.ExplainType_GetTopObjLstAsync = exports.ExplainType_GetObjLstByExplainTypeIdLst_Cache = exports.ExplainType_GetObjLstByExplainTypeIdLstAsync = exports.ExplainType_GetSubObjLst_Cache = exports.ExplainType_GetObjLst_PureCache = exports.ExplainType_GetObjLst_Cache = exports.ExplainType_GetObjLst_sessionStorage_PureCache = exports.ExplainType_GetObjLst_sessionStorage = exports.ExplainType_GetObjLstAsync = exports.ExplainType_GetObjLst_localStorage_PureCache = exports.ExplainType_GetObjLst_localStorage = exports.ExplainType_GetObjLst_ClientCache = exports.ExplainType_GetFirstObjAsync = exports.ExplainType_GetFirstID = exports.ExplainType_GetFirstIDAsync = exports.ExplainType_FilterFunByKey = exports.ExplainType_SortFunByKey = exports.ExplainType_SortFun_Defa_2Fld = exports.ExplainType_SortFun_Defa = exports.ExplainType_func = exports.ExplainType_GetNameByExplainTypeId_Cache = exports.ExplainType_UpdateObjInLst_Cache = exports.ExplainType_GetObjByExplainTypeId_localStorage = exports.ExplainType_GetObjByExplainTypeId_Cache = exports.ExplainType_GetObjByExplainTypeIdAsync = exports.explainType_ConstructorName = exports.explainType_Controller = void 0;
    /**
     * 说明类型(ExplainType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsExplainTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsExplainTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.explainType_Controller = "ExplainTypeApi";
    exports.explainType_ConstructorName = "explainType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strExplainTypeId:关键字
    * @returns 对象
    **/
    async function ExplainType_GetObjByExplainTypeIdAsync(strExplainTypeId) {
        const strThisFuncName = "GetObjByExplainTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strExplainTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strExplainTypeId]不能为空！(In GetObjByExplainTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strExplainTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByExplainTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strExplainTypeId": strExplainTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objExplainType = ExplainType_GetObjFromJsonObj(returnObj);
                return objExplainType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetObjByExplainTypeIdAsync = ExplainType_GetObjByExplainTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strExplainTypeId:所给的关键字
     * @returns 对象
    */
    async function ExplainType_GetObjByExplainTypeId_Cache(strExplainTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByExplainTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strExplainTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strExplainTypeId]不能为空！(In GetObjByExplainTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strExplainTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        try {
            const arrExplainType_Sel = arrExplainTypeObjLst_Cache.filter(x => x.explainTypeId == strExplainTypeId);
            let objExplainType;
            if (arrExplainType_Sel.length > 0) {
                objExplainType = arrExplainType_Sel[0];
                return objExplainType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objExplainType = await ExplainType_GetObjByExplainTypeIdAsync(strExplainTypeId);
                    if (objExplainType != null) {
                        ExplainType_ReFreshThisCache();
                        return objExplainType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strExplainTypeId, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ExplainType_GetObjByExplainTypeId_Cache = ExplainType_GetObjByExplainTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strExplainTypeId:所给的关键字
     * @returns 对象
    */
    async function ExplainType_GetObjByExplainTypeId_localStorage(strExplainTypeId) {
        const strThisFuncName = "GetObjByExplainTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strExplainTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strExplainTypeId]不能为空！(In GetObjByExplainTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strExplainTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName, strExplainTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objExplainType_Cache = JSON.parse(strTempObj);
            return objExplainType_Cache;
        }
        try {
            const objExplainType = await ExplainType_GetObjByExplainTypeIdAsync(strExplainTypeId);
            if (objExplainType != null) {
                localStorage.setItem(strKey, JSON.stringify(objExplainType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objExplainType;
            }
            return objExplainType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strExplainTypeId, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ExplainType_GetObjByExplainTypeId_localStorage = ExplainType_GetObjByExplainTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objExplainType:所给的对象
     * @returns 对象
    */
    async function ExplainType_UpdateObjInLst_Cache(objExplainType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
            const obj = arrExplainTypeObjLst_Cache.find(x => x.explainTypeId == objExplainType.explainTypeId);
            if (obj != null) {
                objExplainType.explainTypeId = obj.explainTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objExplainType);
            }
            else {
                arrExplainTypeObjLst_Cache.push(objExplainType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ExplainType_UpdateObjInLst_Cache = ExplainType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strExplainTypeId:所给的关键字
     * @returns 对象
    */
    async function ExplainType_GetNameByExplainTypeId_Cache(strExplainTypeId) {
        const strThisFuncName = "GetNameByExplainTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strExplainTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strExplainTypeId]不能为空！(In GetNameByExplainTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strExplainTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strExplainTypeId]的长度:[{0}]不正确！", strExplainTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        if (arrExplainTypeObjLst_Cache == null)
            return "";
        try {
            const arrExplainType_Sel = arrExplainTypeObjLst_Cache.filter(x => x.explainTypeId == strExplainTypeId);
            let objExplainType;
            if (arrExplainType_Sel.length > 0) {
                objExplainType = arrExplainType_Sel[0];
                return objExplainType.explainTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strExplainTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.ExplainType_GetNameByExplainTypeId_Cache = ExplainType_GetNameByExplainTypeId_Cache;
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
    async function ExplainType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsExplainTypeEN_js_1.clsExplainTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsExplainTypeEN_js_1.clsExplainTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strExplainTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objExplainType = await ExplainType_GetObjByExplainTypeId_Cache(strExplainTypeId);
        if (objExplainType == null)
            return "";
        return objExplainType.GetFldValue(strOutFldName).toString();
    }
    exports.ExplainType_func = ExplainType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ExplainType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.explainTypeId.localeCompare(b.explainTypeId);
    }
    exports.ExplainType_SortFun_Defa = ExplainType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ExplainType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.explainTypeName == b.explainTypeName)
            return a.updDate.localeCompare(b.updDate);
        else
            return a.explainTypeName.localeCompare(b.explainTypeName);
    }
    exports.ExplainType_SortFun_Defa_2Fld = ExplainType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ExplainType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId:
                    return (a, b) => {
                        return a.explainTypeId.localeCompare(b.explainTypeId);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName:
                    return (a, b) => {
                        return a.explainTypeName.localeCompare(b.explainTypeName);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ExplainType]中不存在！(in ${exports.explainType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId:
                    return (a, b) => {
                        return b.explainTypeId.localeCompare(a.explainTypeId);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName:
                    return (a, b) => {
                        return b.explainTypeName.localeCompare(a.explainTypeName);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsExplainTypeEN_js_1.clsExplainTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ExplainType]中不存在！(in ${exports.explainType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ExplainType_SortFunByKey = ExplainType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ExplainType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId:
                return (obj) => {
                    return obj.explainTypeId === value;
                };
            case clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName:
                return (obj) => {
                    return obj.explainTypeName === value;
                };
            case clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsExplainTypeEN_js_1.clsExplainTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ExplainType]中不存在！(in ${exports.explainType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ExplainType_FilterFunByKey = ExplainType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ExplainType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetFirstIDAsync = ExplainType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ExplainType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetFirstID = ExplainType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ExplainType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objExplainType = ExplainType_GetObjFromJsonObj(returnObj);
                return objExplainType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetFirstObjAsync = ExplainType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
        clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrExplainTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrExplainTypeObjLst_T = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeExObjLst_Cache);
            return arrExplainTypeObjLst_T;
        }
        try {
            const arrExplainTypeExObjLst = await ExplainType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrExplainTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrExplainTypeExObjLst.length);
            console.log(strInfo);
            return arrExplainTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ExplainType_GetObjLst_ClientCache = ExplainType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
        clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrExplainTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrExplainTypeObjLst_T = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeExObjLst_Cache);
            return arrExplainTypeObjLst_T;
        }
        try {
            const arrExplainTypeExObjLst = await ExplainType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrExplainTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrExplainTypeExObjLst.length);
            console.log(strInfo);
            return arrExplainTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ExplainType_GetObjLst_localStorage = ExplainType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrExplainTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrExplainTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ExplainType_GetObjLst_localStorage_PureCache = ExplainType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ExplainType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetObjLstAsync = ExplainType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
        clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsExplainTypeEN_js_1.clsExplainTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrExplainTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrExplainTypeObjLst_T = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeExObjLst_Cache);
            return arrExplainTypeObjLst_T;
        }
        try {
            const arrExplainTypeExObjLst = await ExplainType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrExplainTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrExplainTypeExObjLst.length);
            console.log(strInfo);
            return arrExplainTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ExplainType_GetObjLst_sessionStorage = ExplainType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrExplainTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrExplainTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ExplainType_GetObjLst_sessionStorage_PureCache = ExplainType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrExplainTypeObjLst_Cache;
        switch (clsExplainTypeEN_js_1.clsExplainTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_ClientCache();
                break;
            default:
                arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_ClientCache();
                break;
        }
        const arrExplainTypeObjLst = ExplainType_GetObjLstByJSONObjLst(arrExplainTypeObjLst_Cache);
        return arrExplainTypeObjLst_Cache;
    }
    exports.ExplainType_GetObjLst_Cache = ExplainType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ExplainType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrExplainTypeObjLst_Cache;
        switch (clsExplainTypeEN_js_1.clsExplainTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrExplainTypeObjLst_Cache = null;
                break;
            default:
                arrExplainTypeObjLst_Cache = null;
                break;
        }
        return arrExplainTypeObjLst_Cache;
    }
    exports.ExplainType_GetObjLst_PureCache = ExplainType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrExplainTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ExplainType_GetSubObjLst_Cache(objExplainType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        let arrExplainType_Sel = arrExplainTypeObjLst_Cache;
        if (objExplainType_Cond.sf_FldComparisonOp == null || objExplainType_Cond.sf_FldComparisonOp == "")
            return arrExplainType_Sel;
        const dicFldComparisonOp = JSON.parse(objExplainType_Cond.sf_FldComparisonOp);
        //console.log("clsExplainTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objExplainType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objExplainType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrExplainType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objExplainType_Cond), exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ExplainType_GetSubObjLst_Cache = ExplainType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrExplainTypeId:关键字列表
    * @returns 对象列表
    **/
    async function ExplainType_GetObjLstByExplainTypeIdLstAsync(arrExplainTypeId) {
        const strThisFuncName = "GetObjLstByExplainTypeIdLstAsync";
        const strAction = "GetObjLstByExplainTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrExplainTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetObjLstByExplainTypeIdLstAsync = ExplainType_GetObjLstByExplainTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrExplainTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function ExplainType_GetObjLstByExplainTypeIdLst_Cache(arrExplainTypeIdLst) {
        const strThisFuncName = "GetObjLstByExplainTypeIdLst_Cache";
        try {
            const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
            const arrExplainType_Sel = arrExplainTypeObjLst_Cache.filter(x => arrExplainTypeIdLst.indexOf(x.explainTypeId) > -1);
            return arrExplainType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrExplainTypeIdLst.join(","), exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ExplainType_GetObjLstByExplainTypeIdLst_Cache = ExplainType_GetObjLstByExplainTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ExplainType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetTopObjLstAsync = ExplainType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ExplainType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetObjLstByRangeAsync = ExplainType_GetObjLstByRangeAsync;
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
    async function ExplainType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetObjLstByRange = ExplainType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ExplainType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        if (arrExplainTypeObjLst_Cache.length == 0)
            return arrExplainTypeObjLst_Cache;
        let arrExplainType_Sel = arrExplainTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objExplainType_Cond = new clsExplainTypeEN_js_1.clsExplainTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objExplainType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsExplainTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objExplainType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrExplainType_Sel.length == 0)
                return arrExplainType_Sel;
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
                arrExplainType_Sel = arrExplainType_Sel.sort(ExplainType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrExplainType_Sel = arrExplainType_Sel.sort(objPagerPara.sortFun);
            }
            arrExplainType_Sel = arrExplainType_Sel.slice(intStart, intEnd);
            return arrExplainType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ExplainType_GetObjLstByPager_Cache = ExplainType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ExplainType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.explainType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ExplainType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetObjLstByPagerAsync = ExplainType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strExplainTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function ExplainType_DelRecordAsync(strExplainTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strExplainTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strExplainTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_DelRecordAsync = ExplainType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrExplainTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ExplainType_DelExplainTypesAsync(arrExplainTypeId) {
        const strThisFuncName = "DelExplainTypesAsync";
        const strAction = "DelExplainTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrExplainTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_DelExplainTypesAsync = ExplainType_DelExplainTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ExplainType_DelExplainTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelExplainTypesByCondAsync";
        const strAction = "DelExplainTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_DelExplainTypesByCondAsync = ExplainType_DelExplainTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objExplainTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ExplainType_AddNewRecordAsync(objExplainTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objExplainTypeEN.explainTypeId === null || objExplainTypeEN.explainTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objExplainTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objExplainTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_AddNewRecordAsync = ExplainType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objExplainTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ExplainType_AddNewRecordWithMaxIdAsync(objExplainTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objExplainTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_AddNewRecordWithMaxIdAsync = ExplainType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objExplainTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ExplainType_AddNewRecordWithReturnKeyAsync(objExplainTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objExplainTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_AddNewRecordWithReturnKeyAsync = ExplainType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objExplainTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ExplainType_AddNewRecordWithReturnKey(objExplainTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objExplainTypeEN.explainTypeId === null || objExplainTypeEN.explainTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objExplainTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_AddNewRecordWithReturnKey = ExplainType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objExplainTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ExplainType_UpdateRecordAsync(objExplainTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objExplainTypeEN.sf_UpdFldSetStr === undefined || objExplainTypeEN.sf_UpdFldSetStr === null || objExplainTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objExplainTypeEN.explainTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objExplainTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_UpdateRecordAsync = ExplainType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objExplainTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ExplainType_UpdateWithConditionAsync(objExplainTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objExplainTypeEN.sf_UpdFldSetStr === undefined || objExplainTypeEN.sf_UpdFldSetStr === null || objExplainTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objExplainTypeEN.explainTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        objExplainTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objExplainTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_UpdateWithConditionAsync = ExplainType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrExplainTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ExplainType_IsExistRecord_Cache(objExplainType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        if (arrExplainTypeObjLst_Cache == null)
            return false;
        let arrExplainType_Sel = arrExplainTypeObjLst_Cache;
        if (objExplainType_Cond.sf_FldComparisonOp == null || objExplainType_Cond.sf_FldComparisonOp == "")
            return arrExplainType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objExplainType_Cond.sf_FldComparisonOp);
        //console.log("clsExplainTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objExplainType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objExplainType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrExplainType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objExplainType_Cond), exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ExplainType_IsExistRecord_Cache = ExplainType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ExplainType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_IsExistRecordAsync = ExplainType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strExplainTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ExplainType_IsExist(strExplainTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ExplainTypeId": strExplainTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_IsExist = ExplainType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strExplainTypeId:所给的关键字
     * @returns 对象
    */
    async function ExplainType_IsExist_Cache(strExplainTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        if (arrExplainTypeObjLst_Cache == null)
            return false;
        try {
            const arrExplainType_Sel = arrExplainTypeObjLst_Cache.filter(x => x.explainTypeId == strExplainTypeId);
            if (arrExplainType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strExplainTypeId, exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ExplainType_IsExist_Cache = ExplainType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strExplainTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ExplainType_IsExistAsync(strExplainTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strExplainTypeId": strExplainTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_IsExistAsync = ExplainType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ExplainType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetRecCountByCondAsync = ExplainType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objExplainType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ExplainType_GetRecCountByCond_Cache(objExplainType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrExplainTypeObjLst_Cache = await ExplainType_GetObjLst_Cache();
        if (arrExplainTypeObjLst_Cache == null)
            return 0;
        let arrExplainType_Sel = arrExplainTypeObjLst_Cache;
        if (objExplainType_Cond.sf_FldComparisonOp == null || objExplainType_Cond.sf_FldComparisonOp == "")
            return arrExplainType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objExplainType_Cond.sf_FldComparisonOp);
        //console.log("clsExplainTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objExplainType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objExplainType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrExplainType_Sel = arrExplainType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrExplainType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objExplainType_Cond), exports.explainType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ExplainType_GetRecCountByCond_Cache = ExplainType_GetRecCountByCond_Cache;
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
    async function ExplainType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.explainType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.explainType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ExplainType_GetMaxStrIdByPrefix = ExplainType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ExplainType_GetWebApiUrl(strController, strAction) {
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
    exports.ExplainType_GetWebApiUrl = ExplainType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ExplainType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
        switch (clsExplainTypeEN_js_1.clsExplainTypeEN.CacheModeId) {
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
    exports.ExplainType_ReFreshCache = ExplainType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ExplainType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsExplainTypeEN_js_1.clsExplainTypeEN._CurrTabName;
            switch (clsExplainTypeEN_js_1.clsExplainTypeEN.CacheModeId) {
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
    exports.ExplainType_ReFreshThisCache = ExplainType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function ExplainType_BindDdl_ExplainTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_ExplainTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_ExplainTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_ExplainTypeIdInDiv_Cache");
        const arrObjLst_Sel = await ExplainType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName, "说明类型");
    }
    exports.ExplainType_BindDdl_ExplainTypeIdInDiv_Cache = ExplainType_BindDdl_ExplainTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ExplainType_CheckPropertyNew(pobjExplainTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.explainTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeId)(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.explainTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[说明类型名(explainTypeName)]的长度不能超过50(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeName)(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updDate)(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updUserId)(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.memo)(clsExplainTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeId) == false && undefined !== pobjExplainTypeEN.explainTypeId && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.explainTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[说明类型Id(explainTypeId)]的值:[$(pobjExplainTypeEN.explainTypeId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeName) == false && undefined !== pobjExplainTypeEN.explainTypeName && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.explainTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[说明类型名(explainTypeName)]的值:[$(pobjExplainTypeEN.explainTypeName)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updDate) == false && undefined !== pobjExplainTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjExplainTypeEN.updDate)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updUserId) == false && undefined !== pobjExplainTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjExplainTypeEN.updUserId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.memo) == false && undefined !== pobjExplainTypeEN.memo && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjExplainTypeEN.memo)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjExplainTypeEN.SetIsCheckProperty(true);
    }
    exports.ExplainType_CheckPropertyNew = ExplainType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ExplainType_CheckProperty4Update(pobjExplainTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.explainTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[说明类型Id(explainTypeId)]的长度不能超过2(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeId)(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.explainTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[说明类型名(explainTypeName)]的长度不能超过50(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.explainTypeName)(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updDate)(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.updUserId)(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjExplainTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 说明类型(ExplainType))!值:$(pobjExplainTypeEN.memo)(clsExplainTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeId) == false && undefined !== pobjExplainTypeEN.explainTypeId && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.explainTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[说明类型Id(explainTypeId)]的值:[$(pobjExplainTypeEN.explainTypeId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeName) == false && undefined !== pobjExplainTypeEN.explainTypeName && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.explainTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[说明类型名(explainTypeName)]的值:[$(pobjExplainTypeEN.explainTypeName)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updDate) == false && undefined !== pobjExplainTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjExplainTypeEN.updDate)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.updUserId) == false && undefined !== pobjExplainTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjExplainTypeEN.updUserId)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.memo) == false && undefined !== pobjExplainTypeEN.memo && jsString_js_1.tzDataType.isString(pobjExplainTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjExplainTypeEN.memo)], 非法，应该为字符型(In 说明类型(ExplainType))!(clsExplainTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjExplainTypeEN.explainTypeId) === true
            || pobjExplainTypeEN.explainTypeId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[说明类型Id]不能为空(In 说明类型)!(clsExplainTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjExplainTypeEN.SetIsCheckProperty(true);
    }
    exports.ExplainType_CheckProperty4Update = ExplainType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ExplainType_GetJSONStrByObj(pobjExplainTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjExplainTypeEN.sf_UpdFldSetStr = pobjExplainTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjExplainTypeEN);
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
    exports.ExplainType_GetJSONStrByObj = ExplainType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ExplainType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrExplainTypeObjLst = new Array();
        if (strJSON === "") {
            return arrExplainTypeObjLst;
        }
        try {
            arrExplainTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrExplainTypeObjLst;
        }
        return arrExplainTypeObjLst;
    }
    exports.ExplainType_GetObjLstByJSONStr = ExplainType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrExplainTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ExplainType_GetObjLstByJSONObjLst(arrExplainTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrExplainTypeObjLst = new Array();
        for (const objInFor of arrExplainTypeObjLstS) {
            const obj1 = ExplainType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrExplainTypeObjLst.push(obj1);
        }
        return arrExplainTypeObjLst;
    }
    exports.ExplainType_GetObjLstByJSONObjLst = ExplainType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ExplainType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjExplainTypeEN = new clsExplainTypeEN_js_1.clsExplainTypeEN();
        if (strJSON === "") {
            return pobjExplainTypeEN;
        }
        try {
            pobjExplainTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjExplainTypeEN;
        }
        return pobjExplainTypeEN;
    }
    exports.ExplainType_GetObjByJSONStr = ExplainType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ExplainType_GetCombineCondition(objExplainType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId) == true) {
            const strComparisonOp_ExplainTypeId = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeId, objExplainType_Cond.explainTypeId, strComparisonOp_ExplainTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName) == true) {
            const strComparisonOp_ExplainTypeName = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsExplainTypeEN_js_1.clsExplainTypeEN.con_ExplainTypeName, objExplainType_Cond.explainTypeName, strComparisonOp_ExplainTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdDate, objExplainType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsExplainTypeEN_js_1.clsExplainTypeEN.con_UpdUserId, objExplainType_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objExplainType_Cond.dicFldComparisonOp, clsExplainTypeEN_js_1.clsExplainTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objExplainType_Cond.dicFldComparisonOp[clsExplainTypeEN_js_1.clsExplainTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsExplainTypeEN_js_1.clsExplainTypeEN.con_Memo, objExplainType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ExplainType_GetCombineCondition = ExplainType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objExplainTypeENS:源对象
     * @param objExplainTypeENT:目标对象
    */
    function ExplainType_CopyObjTo(objExplainTypeENS, objExplainTypeENT) {
        objExplainTypeENT.explainTypeId = objExplainTypeENS.explainTypeId; //说明类型Id
        objExplainTypeENT.explainTypeName = objExplainTypeENS.explainTypeName; //说明类型名
        objExplainTypeENT.updDate = objExplainTypeENS.updDate; //修改日期
        objExplainTypeENT.updUserId = objExplainTypeENS.updUserId; //修改用户Id
        objExplainTypeENT.memo = objExplainTypeENS.memo; //备注
        objExplainTypeENT.sf_UpdFldSetStr = objExplainTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ExplainType_CopyObjTo = ExplainType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objExplainTypeENS:源对象
     * @param objExplainTypeENT:目标对象
    */
    function ExplainType_GetObjFromJsonObj(objExplainTypeENS) {
        const objExplainTypeENT = new clsExplainTypeEN_js_1.clsExplainTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objExplainTypeENT, objExplainTypeENS);
        return objExplainTypeENT;
    }
    exports.ExplainType_GetObjFromJsonObj = ExplainType_GetObjFromJsonObj;
});
