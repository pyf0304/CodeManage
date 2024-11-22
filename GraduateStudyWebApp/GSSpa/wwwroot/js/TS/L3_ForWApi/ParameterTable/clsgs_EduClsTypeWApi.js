/**
* 类名:clsgs_EduClsTypeWApi
* 表名:gs_EduClsType(01120723)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:28
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsgs_EduClsTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_EduClsType_GetObjFromJsonObj = exports.gs_EduClsType_CopyObjTo = exports.gs_EduClsType_GetUniCondStr4Update_EduClsTypeName = exports.gs_EduClsType_GetUniCondStr_EduClsTypeName = exports.gs_EduClsType_GetCombineCondition = exports.gs_EduClsType_GetObjByJSONStr = exports.gs_EduClsType_GetObjLstByJSONObjLst = exports.gs_EduClsType_GetObjLstByJSONStr = exports.gs_EduClsType_GetJSONStrByObj = exports.gs_EduClsType_CheckProperty4Update = exports.gs_EduClsType_CheckPropertyNew = exports.gs_EduClsType__Cache = exports.gs_EduClsType_ReFreshThisCache = exports.gs_EduClsType_ReFreshCache = exports.gs_EduClsType_GetWebApiUrl = exports.gs_EduClsType_GetMaxStrIdByPrefix = exports.gs_EduClsType_GetMaxStrIdAsync = exports.gs_EduClsType_GetRecCountByCond_Cache = exports.gs_EduClsType_GetRecCountByCondAsync = exports.gs_EduClsType_IsExistAsync = exports.gs_EduClsType_IsExist_Cache = exports.gs_EduClsType_IsExist = exports.gs_EduClsType_IsExistRecordAsync = exports.gs_EduClsType_IsExistRecord_Cache = exports.gs_EduClsType_UpdateWithConditionAsync = exports.gs_EduClsType_UpdateRecordAsync = exports.gs_EduClsType_AddNewRecordWithReturnKey = exports.gs_EduClsType_AddNewRecordWithReturnKeyAsync = exports.gs_EduClsType_AddNewRecordWithMaxIdAsync = exports.gs_EduClsType_AddNewRecordAsync = exports.gs_EduClsType_Delgs_EduClsTypesByCondAsync = exports.gs_EduClsType_Delgs_EduClsTypesAsync = exports.gs_EduClsType_DelRecordAsync = exports.gs_EduClsType_GetObjLstByPagerAsync = exports.gs_EduClsType_GetObjLstByPager_Cache = exports.gs_EduClsType_GetObjLstByRange = exports.gs_EduClsType_GetObjLstByRangeAsync = exports.gs_EduClsType_GetTopObjLstAsync = exports.gs_EduClsType_GetObjLstByEduClsTypeIdLst_Cache = exports.gs_EduClsType_GetObjLstByEduClsTypeIdLstAsync = exports.gs_EduClsType_GetSubObjLst_Cache = exports.gs_EduClsType_GetObjLst_PureCache = exports.gs_EduClsType_GetObjLst_Cache = exports.gs_EduClsType_GetObjLst_sessionStorage_PureCache = exports.gs_EduClsType_GetObjLst_sessionStorage = exports.gs_EduClsType_GetObjLstAsync = exports.gs_EduClsType_GetObjLst_localStorage_PureCache = exports.gs_EduClsType_GetObjLst_localStorage = exports.gs_EduClsType_GetObjLst_ClientCache = exports.gs_EduClsType_GetFirstObjAsync = exports.gs_EduClsType_GetFirstID = exports.gs_EduClsType_GetFirstIDAsync = exports.gs_EduClsType_FilterFunByKey = exports.gs_EduClsType_SortFunByKey = exports.gs_EduClsType_SortFun_Defa_2Fld = exports.gs_EduClsType_SortFun_Defa = exports.gs_EduClsType_func = exports.gs_EduClsType_GetNameByEduClsTypeId_Cache = exports.gs_EduClsType_UpdateObjInLst_Cache = exports.gs_EduClsType_GetObjByEduClsTypeId_localStorage = exports.gs_EduClsType_GetObjByEduClsTypeId_Cache = exports.gs_EduClsType_GetObjByEduClsTypeIdAsync = exports.gs_EduClsType_ConstructorName = exports.gs_EduClsType_Controller = void 0;
    /**
     * 教学班类型(gs_EduClsType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_EduClsTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_EduClsTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_EduClsType_Controller = "gs_EduClsTypeApi";
    exports.gs_EduClsType_ConstructorName = "gs_EduClsType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strEduClsTypeId:关键字
    * @returns 对象
    **/
    async function gs_EduClsType_GetObjByEduClsTypeIdAsync(strEduClsTypeId) {
        const strThisFuncName = "GetObjByEduClsTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In GetObjByEduClsTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByEduClsTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strEduClsTypeId": strEduClsTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_EduClsType = gs_EduClsType_GetObjFromJsonObj(returnObj);
                return objgs_EduClsType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetObjByEduClsTypeIdAsync = gs_EduClsType_GetObjByEduClsTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strEduClsTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_EduClsType_GetObjByEduClsTypeId_Cache(strEduClsTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByEduClsTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In GetObjByEduClsTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        try {
            const arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache.filter(x => x.eduClsTypeId == strEduClsTypeId);
            let objgs_EduClsType;
            if (arrgs_EduClsType_Sel.length > 0) {
                objgs_EduClsType = arrgs_EduClsType_Sel[0];
                return objgs_EduClsType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_EduClsType = await gs_EduClsType_GetObjByEduClsTypeIdAsync(strEduClsTypeId);
                    if (objgs_EduClsType != null) {
                        gs_EduClsType_ReFreshThisCache();
                        return objgs_EduClsType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strEduClsTypeId, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_EduClsType_GetObjByEduClsTypeId_Cache = gs_EduClsType_GetObjByEduClsTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strEduClsTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_EduClsType_GetObjByEduClsTypeId_localStorage(strEduClsTypeId) {
        const strThisFuncName = "GetObjByEduClsTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In GetObjByEduClsTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName, strEduClsTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_EduClsType_Cache = JSON.parse(strTempObj);
            return objgs_EduClsType_Cache;
        }
        try {
            const objgs_EduClsType = await gs_EduClsType_GetObjByEduClsTypeIdAsync(strEduClsTypeId);
            if (objgs_EduClsType != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_EduClsType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_EduClsType;
            }
            return objgs_EduClsType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strEduClsTypeId, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_EduClsType_GetObjByEduClsTypeId_localStorage = gs_EduClsType_GetObjByEduClsTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_EduClsType:所给的对象
     * @returns 对象
    */
    async function gs_EduClsType_UpdateObjInLst_Cache(objgs_EduClsType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
            const obj = arrgs_EduClsTypeObjLst_Cache.find(x => x.eduClsTypeName == objgs_EduClsType.eduClsTypeName);
            if (obj != null) {
                objgs_EduClsType.eduClsTypeId = obj.eduClsTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_EduClsType);
            }
            else {
                arrgs_EduClsTypeObjLst_Cache.push(objgs_EduClsType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_EduClsType_UpdateObjInLst_Cache = gs_EduClsType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strEduClsTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_EduClsType_GetNameByEduClsTypeId_Cache(strEduClsTypeId) {
        const strThisFuncName = "GetNameByEduClsTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strEduClsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strEduClsTypeId]不能为空！(In GetNameByEduClsTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strEduClsTypeId.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strEduClsTypeId]的长度:[{0}]不正确！", strEduClsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        if (arrgs_EduClsTypeObjLst_Cache == null)
            return "";
        try {
            const arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache.filter(x => x.eduClsTypeId == strEduClsTypeId);
            let objgs_EduClsType;
            if (arrgs_EduClsType_Sel.length > 0) {
                objgs_EduClsType = arrgs_EduClsType_Sel[0];
                return objgs_EduClsType.eduClsTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strEduClsTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.gs_EduClsType_GetNameByEduClsTypeId_Cache = gs_EduClsType_GetNameByEduClsTypeId_Cache;
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
    async function gs_EduClsType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strEduClsTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_EduClsType = await gs_EduClsType_GetObjByEduClsTypeId_Cache(strEduClsTypeId);
        if (objgs_EduClsType == null)
            return "";
        return objgs_EduClsType.GetFldValue(strOutFldName).toString();
    }
    exports.gs_EduClsType_func = gs_EduClsType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_EduClsType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
    }
    exports.gs_EduClsType_SortFun_Defa = gs_EduClsType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_EduClsType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.eduClsTypeName == b.eduClsTypeName)
            return a.memo.localeCompare(b.memo);
        else
            return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
    }
    exports.gs_EduClsType_SortFun_Defa_2Fld = gs_EduClsType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_EduClsType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId:
                    return (a, b) => {
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName:
                    return (a, b) => {
                        return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
                    };
                case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_EduClsType]中不存在！(in ${exports.gs_EduClsType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId:
                    return (a, b) => {
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName:
                    return (a, b) => {
                        return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
                    };
                case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_EduClsType]中不存在！(in ${exports.gs_EduClsType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_EduClsType_SortFunByKey = gs_EduClsType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_EduClsType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName:
                return (obj) => {
                    return obj.eduClsTypeName === value;
                };
            case clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_EduClsType]中不存在！(in ${exports.gs_EduClsType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_EduClsType_FilterFunByKey = gs_EduClsType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_EduClsType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetFirstIDAsync = gs_EduClsType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_EduClsType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetFirstID = gs_EduClsType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_EduClsType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_EduClsType = gs_EduClsType_GetObjFromJsonObj(returnObj);
                return objgs_EduClsType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetFirstObjAsync = gs_EduClsType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
        clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_EduClsTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_EduClsTypeObjLst_T = gs_EduClsType_GetObjLstByJSONObjLst(arrgs_EduClsTypeExObjLst_Cache);
            return arrgs_EduClsTypeObjLst_T;
        }
        try {
            const arrgs_EduClsTypeExObjLst = await gs_EduClsType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_EduClsTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_EduClsTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_EduClsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_EduClsType_GetObjLst_ClientCache = gs_EduClsType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
        clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_EduClsTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_EduClsTypeObjLst_T = gs_EduClsType_GetObjLstByJSONObjLst(arrgs_EduClsTypeExObjLst_Cache);
            return arrgs_EduClsTypeObjLst_T;
        }
        try {
            const arrgs_EduClsTypeExObjLst = await gs_EduClsType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_EduClsTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_EduClsTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_EduClsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_EduClsType_GetObjLst_localStorage = gs_EduClsType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_EduClsTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_EduClsTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_EduClsType_GetObjLst_localStorage_PureCache = gs_EduClsType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_EduClsType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_EduClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetObjLstAsync = gs_EduClsType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
        clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_EduClsTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_EduClsTypeObjLst_T = gs_EduClsType_GetObjLstByJSONObjLst(arrgs_EduClsTypeExObjLst_Cache);
            return arrgs_EduClsTypeObjLst_T;
        }
        try {
            const arrgs_EduClsTypeExObjLst = await gs_EduClsType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_EduClsTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_EduClsTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_EduClsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_EduClsType_GetObjLst_sessionStorage = gs_EduClsType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_EduClsTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_EduClsTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_EduClsType_GetObjLst_sessionStorage_PureCache = gs_EduClsType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_EduClsTypeObjLst_Cache;
        switch (clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_ClientCache();
                break;
            default:
                arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_ClientCache();
                break;
        }
        const arrgs_EduClsTypeObjLst = gs_EduClsType_GetObjLstByJSONObjLst(arrgs_EduClsTypeObjLst_Cache);
        return arrgs_EduClsTypeObjLst_Cache;
    }
    exports.gs_EduClsType_GetObjLst_Cache = gs_EduClsType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_EduClsType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_EduClsTypeObjLst_Cache;
        switch (clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_EduClsTypeObjLst_Cache = null;
                break;
            default:
                arrgs_EduClsTypeObjLst_Cache = null;
                break;
        }
        return arrgs_EduClsTypeObjLst_Cache;
    }
    exports.gs_EduClsType_GetObjLst_PureCache = gs_EduClsType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrEduClsTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_EduClsType_GetSubObjLst_Cache(objgs_EduClsType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        let arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache;
        if (objgs_EduClsType_Cond.sf_FldComparisonOp == null || objgs_EduClsType_Cond.sf_FldComparisonOp == "")
            return arrgs_EduClsType_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_EduClsType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_EduClsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_EduClsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_EduClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_EduClsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_EduClsType_Cond), exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_EduClsType_GetSubObjLst_Cache = gs_EduClsType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrEduClsTypeId:关键字列表
    * @returns 对象列表
    **/
    async function gs_EduClsType_GetObjLstByEduClsTypeIdLstAsync(arrEduClsTypeId) {
        const strThisFuncName = "GetObjLstByEduClsTypeIdLstAsync";
        const strAction = "GetObjLstByEduClsTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrEduClsTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_EduClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetObjLstByEduClsTypeIdLstAsync = gs_EduClsType_GetObjLstByEduClsTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrEduClsTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_EduClsType_GetObjLstByEduClsTypeIdLst_Cache(arrEduClsTypeIdLst) {
        const strThisFuncName = "GetObjLstByEduClsTypeIdLst_Cache";
        try {
            const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
            const arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache.filter(x => arrEduClsTypeIdLst.indexOf(x.eduClsTypeId) > -1);
            return arrgs_EduClsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrEduClsTypeIdLst.join(","), exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_EduClsType_GetObjLstByEduClsTypeIdLst_Cache = gs_EduClsType_GetObjLstByEduClsTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_EduClsType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_EduClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetTopObjLstAsync = gs_EduClsType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_EduClsType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_EduClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetObjLstByRangeAsync = gs_EduClsType_GetObjLstByRangeAsync;
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
    async function gs_EduClsType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetObjLstByRange = gs_EduClsType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_EduClsType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        if (arrgs_EduClsTypeObjLst_Cache.length == 0)
            return arrgs_EduClsTypeObjLst_Cache;
        let arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_EduClsType_Cond = new clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_EduClsType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_EduClsTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_EduClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_EduClsType_Sel.length == 0)
                return arrgs_EduClsType_Sel;
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
                arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.sort(gs_EduClsType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.slice(intStart, intEnd);
            return arrgs_EduClsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_EduClsType_GetObjLstByPager_Cache = gs_EduClsType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_EduClsType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_EduClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_EduClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetObjLstByPagerAsync = gs_EduClsType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strEduClsTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_EduClsType_DelRecordAsync(strEduClsTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strEduClsTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strEduClsTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_DelRecordAsync = gs_EduClsType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrEduClsTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_EduClsType_Delgs_EduClsTypesAsync(arrEduClsTypeId) {
        const strThisFuncName = "Delgs_EduClsTypesAsync";
        const strAction = "Delgs_EduClsTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrEduClsTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_Delgs_EduClsTypesAsync = gs_EduClsType_Delgs_EduClsTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_EduClsType_Delgs_EduClsTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_EduClsTypesByCondAsync";
        const strAction = "Delgs_EduClsTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_Delgs_EduClsTypesByCondAsync = gs_EduClsType_Delgs_EduClsTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_EduClsTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_EduClsType_AddNewRecordAsync(objgs_EduClsTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_EduClsTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_EduClsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_AddNewRecordAsync = gs_EduClsType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_EduClsTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_EduClsType_AddNewRecordWithMaxIdAsync(objgs_EduClsTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_EduClsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_AddNewRecordWithMaxIdAsync = gs_EduClsType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_EduClsTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_EduClsType_AddNewRecordWithReturnKeyAsync(objgs_EduClsTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_EduClsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_AddNewRecordWithReturnKeyAsync = gs_EduClsType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_EduClsTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_EduClsType_AddNewRecordWithReturnKey(objgs_EduClsTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_EduClsTypeEN.eduClsTypeId === null || objgs_EduClsTypeEN.eduClsTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_EduClsTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_AddNewRecordWithReturnKey = gs_EduClsType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_EduClsTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_EduClsType_UpdateRecordAsync(objgs_EduClsTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_EduClsTypeEN.sf_UpdFldSetStr === undefined || objgs_EduClsTypeEN.sf_UpdFldSetStr === null || objgs_EduClsTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_EduClsTypeEN.eduClsTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_EduClsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_UpdateRecordAsync = gs_EduClsType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_EduClsTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_EduClsType_UpdateWithConditionAsync(objgs_EduClsTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_EduClsTypeEN.sf_UpdFldSetStr === undefined || objgs_EduClsTypeEN.sf_UpdFldSetStr === null || objgs_EduClsTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_EduClsTypeEN.eduClsTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        objgs_EduClsTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_EduClsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_UpdateWithConditionAsync = gs_EduClsType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrEduClsTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_EduClsType_IsExistRecord_Cache(objgs_EduClsType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        if (arrgs_EduClsTypeObjLst_Cache == null)
            return false;
        let arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache;
        if (objgs_EduClsType_Cond.sf_FldComparisonOp == null || objgs_EduClsType_Cond.sf_FldComparisonOp == "")
            return arrgs_EduClsType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_EduClsType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_EduClsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_EduClsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_EduClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_EduClsType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_EduClsType_Cond), exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_EduClsType_IsExistRecord_Cache = gs_EduClsType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_EduClsType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_IsExistRecordAsync = gs_EduClsType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strEduClsTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_EduClsType_IsExist(strEduClsTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "EduClsTypeId": strEduClsTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_IsExist = gs_EduClsType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strEduClsTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_EduClsType_IsExist_Cache(strEduClsTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        if (arrgs_EduClsTypeObjLst_Cache == null)
            return false;
        try {
            const arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache.filter(x => x.eduClsTypeId == strEduClsTypeId);
            if (arrgs_EduClsType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strEduClsTypeId, exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_EduClsType_IsExist_Cache = gs_EduClsType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strEduClsTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_EduClsType_IsExistAsync(strEduClsTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strEduClsTypeId": strEduClsTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_IsExistAsync = gs_EduClsType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_EduClsType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetRecCountByCondAsync = gs_EduClsType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_EduClsType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_EduClsType_GetRecCountByCond_Cache(objgs_EduClsType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_EduClsTypeObjLst_Cache = await gs_EduClsType_GetObjLst_Cache();
        if (arrgs_EduClsTypeObjLst_Cache == null)
            return 0;
        let arrgs_EduClsType_Sel = arrgs_EduClsTypeObjLst_Cache;
        if (objgs_EduClsType_Cond.sf_FldComparisonOp == null || objgs_EduClsType_Cond.sf_FldComparisonOp == "")
            return arrgs_EduClsType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_EduClsType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_EduClsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_EduClsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_EduClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_EduClsType_Sel = arrgs_EduClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_EduClsType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_EduClsType_Cond), exports.gs_EduClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_EduClsType_GetRecCountByCond_Cache = gs_EduClsType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_EduClsType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetMaxStrIdAsync = gs_EduClsType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_EduClsType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_EduClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_EduClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_EduClsType_GetMaxStrIdByPrefix = gs_EduClsType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_EduClsType_GetWebApiUrl(strController, strAction) {
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
    exports.gs_EduClsType_GetWebApiUrl = gs_EduClsType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_EduClsType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
        switch (clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheModeId) {
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
    exports.gs_EduClsType_ReFreshCache = gs_EduClsType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_EduClsType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN._CurrTabName;
            switch (clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.CacheModeId) {
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
    exports.gs_EduClsType_ReFreshThisCache = gs_EduClsType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function gs_EduClsType__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await gs_EduClsType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId, clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName, "教学班类型");
    }
    exports.gs_EduClsType__Cache = gs_EduClsType__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_EduClsType_CheckPropertyNew(pobjgs_EduClsTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_EduClsTypeEN.eduClsTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[教学班类型Id(eduClsTypeId)]的长度不能超过4(In 教学班类型(gs_EduClsType))!值:$(pobjgs_EduClsTypeEN.eduClsTypeId)(clsgs_EduClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_EduClsTypeEN.eduClsTypeName) > 100) {
            throw new Error("(errid:Watl000059)字段[教学班类型名称(eduClsTypeName)]的长度不能超过100(In 教学班类型(gs_EduClsType))!值:$(pobjgs_EduClsTypeEN.eduClsTypeName)(clsgs_EduClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_EduClsTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教学班类型(gs_EduClsType))!值:$(pobjgs_EduClsTypeEN.memo)(clsgs_EduClsTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeId) == false && undefined !== pobjgs_EduClsTypeEN.eduClsTypeId && jsString_js_1.tzDataType.isString(pobjgs_EduClsTypeEN.eduClsTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[教学班类型Id(eduClsTypeId)]的值:[$(pobjgs_EduClsTypeEN.eduClsTypeId)], 非法，应该为字符型(In 教学班类型(gs_EduClsType))!(clsgs_EduClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeName) == false && undefined !== pobjgs_EduClsTypeEN.eduClsTypeName && jsString_js_1.tzDataType.isString(pobjgs_EduClsTypeEN.eduClsTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[教学班类型名称(eduClsTypeName)]的值:[$(pobjgs_EduClsTypeEN.eduClsTypeName)], 非法，应该为字符型(In 教学班类型(gs_EduClsType))!(clsgs_EduClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.memo) == false && undefined !== pobjgs_EduClsTypeEN.memo && jsString_js_1.tzDataType.isString(pobjgs_EduClsTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_EduClsTypeEN.memo)], 非法，应该为字符型(In 教学班类型(gs_EduClsType))!(clsgs_EduClsTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_EduClsTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_EduClsType_CheckPropertyNew = gs_EduClsType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_EduClsType_CheckProperty4Update(pobjgs_EduClsTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_EduClsTypeEN.eduClsTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[教学班类型Id(eduClsTypeId)]的长度不能超过4(In 教学班类型(gs_EduClsType))!值:$(pobjgs_EduClsTypeEN.eduClsTypeId)(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_EduClsTypeEN.eduClsTypeName) > 100) {
            throw new Error("(errid:Watl000062)字段[教学班类型名称(eduClsTypeName)]的长度不能超过100(In 教学班类型(gs_EduClsType))!值:$(pobjgs_EduClsTypeEN.eduClsTypeName)(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_EduClsTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教学班类型(gs_EduClsType))!值:$(pobjgs_EduClsTypeEN.memo)(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeId) == false && undefined !== pobjgs_EduClsTypeEN.eduClsTypeId && jsString_js_1.tzDataType.isString(pobjgs_EduClsTypeEN.eduClsTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[教学班类型Id(eduClsTypeId)]的值:[$(pobjgs_EduClsTypeEN.eduClsTypeId)], 非法，应该为字符型(In 教学班类型(gs_EduClsType))!(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeName) == false && undefined !== pobjgs_EduClsTypeEN.eduClsTypeName && jsString_js_1.tzDataType.isString(pobjgs_EduClsTypeEN.eduClsTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[教学班类型名称(eduClsTypeName)]的值:[$(pobjgs_EduClsTypeEN.eduClsTypeName)], 非法，应该为字符型(In 教学班类型(gs_EduClsType))!(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.memo) == false && undefined !== pobjgs_EduClsTypeEN.memo && jsString_js_1.tzDataType.isString(pobjgs_EduClsTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_EduClsTypeEN.memo)], 非法，应该为字符型(In 教学班类型(gs_EduClsType))!(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_EduClsTypeEN.eduClsTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[教学班类型Id]不能为空(In 教学班类型)!(clsgs_EduClsTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_EduClsTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_EduClsType_CheckProperty4Update = gs_EduClsType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_EduClsType_GetJSONStrByObj(pobjgs_EduClsTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_EduClsTypeEN.sf_UpdFldSetStr = pobjgs_EduClsTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_EduClsTypeEN);
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
    exports.gs_EduClsType_GetJSONStrByObj = gs_EduClsType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_EduClsType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_EduClsTypeObjLst = new Array();
        if (strJSON === "") {
            return arrgs_EduClsTypeObjLst;
        }
        try {
            arrgs_EduClsTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_EduClsTypeObjLst;
        }
        return arrgs_EduClsTypeObjLst;
    }
    exports.gs_EduClsType_GetObjLstByJSONStr = gs_EduClsType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_EduClsTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_EduClsType_GetObjLstByJSONObjLst(arrgs_EduClsTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_EduClsTypeObjLst = new Array();
        for (const objInFor of arrgs_EduClsTypeObjLstS) {
            const obj1 = gs_EduClsType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_EduClsTypeObjLst.push(obj1);
        }
        return arrgs_EduClsTypeObjLst;
    }
    exports.gs_EduClsType_GetObjLstByJSONObjLst = gs_EduClsType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_EduClsType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_EduClsTypeEN = new clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN();
        if (strJSON === "") {
            return pobjgs_EduClsTypeEN;
        }
        try {
            pobjgs_EduClsTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_EduClsTypeEN;
        }
        return pobjgs_EduClsTypeEN;
    }
    exports.gs_EduClsType_GetObjByJSONStr = gs_EduClsType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_EduClsType_GetCombineCondition(objgs_EduClsType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_EduClsType_Cond.dicFldComparisonOp, clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objgs_EduClsType_Cond.dicFldComparisonOp[clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeId, objgs_EduClsType_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_EduClsType_Cond.dicFldComparisonOp, clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName) == true) {
            const strComparisonOp_EduClsTypeName = objgs_EduClsType_Cond.dicFldComparisonOp[clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_EduClsTypeName, objgs_EduClsType_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_EduClsType_Cond.dicFldComparisonOp, clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_EduClsType_Cond.dicFldComparisonOp[clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN.con_Memo, objgs_EduClsType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_EduClsType_GetCombineCondition = gs_EduClsType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_EduClsType(教学班类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strEduClsTypeName: 教学班类型名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_EduClsType_GetUniCondStr_EduClsTypeName(objgs_EduClsTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and EduClsTypeName = '{0}'", objgs_EduClsTypeEN.eduClsTypeName);
        return strWhereCond;
    }
    exports.gs_EduClsType_GetUniCondStr_EduClsTypeName = gs_EduClsType_GetUniCondStr_EduClsTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--gs_EduClsType(教学班类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strEduClsTypeName: 教学班类型名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_EduClsType_GetUniCondStr4Update_EduClsTypeName(objgs_EduClsTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and EduClsTypeId <> '{0}'", objgs_EduClsTypeEN.eduClsTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and EduClsTypeName = '{0}'", objgs_EduClsTypeEN.eduClsTypeName);
        return strWhereCond;
    }
    exports.gs_EduClsType_GetUniCondStr4Update_EduClsTypeName = gs_EduClsType_GetUniCondStr4Update_EduClsTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_EduClsTypeENS:源对象
     * @param objgs_EduClsTypeENT:目标对象
    */
    function gs_EduClsType_CopyObjTo(objgs_EduClsTypeENS, objgs_EduClsTypeENT) {
        objgs_EduClsTypeENT.eduClsTypeId = objgs_EduClsTypeENS.eduClsTypeId; //教学班类型Id
        objgs_EduClsTypeENT.eduClsTypeName = objgs_EduClsTypeENS.eduClsTypeName; //教学班类型名称
        objgs_EduClsTypeENT.memo = objgs_EduClsTypeENS.memo; //备注
        objgs_EduClsTypeENT.sf_UpdFldSetStr = objgs_EduClsTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_EduClsType_CopyObjTo = gs_EduClsType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_EduClsTypeENS:源对象
     * @param objgs_EduClsTypeENT:目标对象
    */
    function gs_EduClsType_GetObjFromJsonObj(objgs_EduClsTypeENS) {
        const objgs_EduClsTypeENT = new clsgs_EduClsTypeEN_js_1.clsgs_EduClsTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_EduClsTypeENT, objgs_EduClsTypeENS);
        return objgs_EduClsTypeENT;
    }
    exports.gs_EduClsType_GetObjFromJsonObj = gs_EduClsType_GetObjFromJsonObj;
});
