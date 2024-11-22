/**
* 类名:clsgs_KnowledgesGraphTypeWApi
* 表名:gs_KnowledgesGraphType(01120888)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:03
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges/clsgs_KnowledgesGraphTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_KnowledgesGraphType_GetObjFromJsonObj = exports.gs_KnowledgesGraphType_CopyObjTo = exports.gs_KnowledgesGraphType_GetUniCondStr4Update_GraphTypeId = exports.gs_KnowledgesGraphType_GetUniCondStr_GraphTypeId = exports.gs_KnowledgesGraphType_GetCombineCondition = exports.gs_KnowledgesGraphType_GetObjByJSONStr = exports.gs_KnowledgesGraphType_GetObjLstByJSONObjLst = exports.gs_KnowledgesGraphType_GetObjLstByJSONStr = exports.gs_KnowledgesGraphType_GetJSONStrByObj = exports.gs_KnowledgesGraphType_CheckProperty4Update = exports.gs_KnowledgesGraphType_CheckPropertyNew = exports.gs_KnowledgesGraphType_ReFreshThisCache = exports.gs_KnowledgesGraphType_ReFreshCache = exports.gs_KnowledgesGraphType_GetWebApiUrl = exports.gs_KnowledgesGraphType_GetMaxStrIdByPrefix = exports.gs_KnowledgesGraphType_GetMaxStrIdAsync = exports.gs_KnowledgesGraphType_GetRecCountByCond_Cache = exports.gs_KnowledgesGraphType_GetRecCountByCondAsync = exports.gs_KnowledgesGraphType_IsExistAsync = exports.gs_KnowledgesGraphType_IsExist_Cache = exports.gs_KnowledgesGraphType_IsExist = exports.gs_KnowledgesGraphType_IsExistRecordAsync = exports.gs_KnowledgesGraphType_IsExistRecord_Cache = exports.gs_KnowledgesGraphType_UpdateWithConditionAsync = exports.gs_KnowledgesGraphType_UpdateRecordAsync = exports.gs_KnowledgesGraphType_AddNewRecordWithReturnKey = exports.gs_KnowledgesGraphType_AddNewRecordWithReturnKeyAsync = exports.gs_KnowledgesGraphType_AddNewRecordWithMaxIdAsync = exports.gs_KnowledgesGraphType_AddNewRecordAsync = exports.gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesByCondAsync = exports.gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesAsync = exports.gs_KnowledgesGraphType_DelRecordAsync = exports.gs_KnowledgesGraphType_GetObjLstByPagerAsync = exports.gs_KnowledgesGraphType_GetObjLstByPager_Cache = exports.gs_KnowledgesGraphType_GetObjLstByRange = exports.gs_KnowledgesGraphType_GetObjLstByRangeAsync = exports.gs_KnowledgesGraphType_GetTopObjLstAsync = exports.gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLst_Cache = exports.gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLstAsync = exports.gs_KnowledgesGraphType_GetSubObjLst_Cache = exports.gs_KnowledgesGraphType_GetObjLst_PureCache = exports.gs_KnowledgesGraphType_GetObjLst_Cache = exports.gs_KnowledgesGraphType_GetObjLst_sessionStorage_PureCache = exports.gs_KnowledgesGraphType_GetObjLst_sessionStorage = exports.gs_KnowledgesGraphType_GetObjLstAsync = exports.gs_KnowledgesGraphType_GetObjLst_localStorage_PureCache = exports.gs_KnowledgesGraphType_GetObjLst_localStorage = exports.gs_KnowledgesGraphType_GetObjLst_ClientCache = exports.gs_KnowledgesGraphType_GetFirstObjAsync = exports.gs_KnowledgesGraphType_GetFirstID = exports.gs_KnowledgesGraphType_GetFirstIDAsync = exports.gs_KnowledgesGraphType_FilterFunByKey = exports.gs_KnowledgesGraphType_SortFunByKey = exports.gs_KnowledgesGraphType_SortFun_Defa_2Fld = exports.gs_KnowledgesGraphType_SortFun_Defa = exports.gs_KnowledgesGraphType_func = exports.gs_KnowledgesGraphType_UpdateObjInLst_Cache = exports.gs_KnowledgesGraphType_GetObjByGraphTypeId_localStorage = exports.gs_KnowledgesGraphType_GetObjByGraphTypeId_Cache = exports.gs_KnowledgesGraphType_GetObjByGraphTypeIdAsync = exports.gs_KnowledgesGraphType_ConstructorName = exports.gs_KnowledgesGraphType_Controller = void 0;
    /**
     * 知识点图谱类型(gs_KnowledgesGraphType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_KnowledgesGraphTypeEN_js_1 = require("../../L0_Entity/Knowledges/clsgs_KnowledgesGraphTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_KnowledgesGraphType_Controller = "gs_KnowledgesGraphTypeApi";
    exports.gs_KnowledgesGraphType_ConstructorName = "gs_KnowledgesGraphType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strGraphTypeId:关键字
    * @returns 对象
    **/
    async function gs_KnowledgesGraphType_GetObjByGraphTypeIdAsync(strGraphTypeId) {
        const strThisFuncName = "GetObjByGraphTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strGraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strGraphTypeId]不能为空！(In GetObjByGraphTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strGraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strGraphTypeId]的长度:[{0}]不正确！", strGraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByGraphTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strGraphTypeId": strGraphTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_KnowledgesGraphType = gs_KnowledgesGraphType_GetObjFromJsonObj(returnObj);
                return objgs_KnowledgesGraphType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetObjByGraphTypeIdAsync = gs_KnowledgesGraphType_GetObjByGraphTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strGraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_KnowledgesGraphType_GetObjByGraphTypeId_Cache(strGraphTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByGraphTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strGraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strGraphTypeId]不能为空！(In GetObjByGraphTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strGraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strGraphTypeId]的长度:[{0}]不正确！", strGraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
        try {
            const arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache.filter(x => x.graphTypeId == strGraphTypeId);
            let objgs_KnowledgesGraphType;
            if (arrgs_KnowledgesGraphType_Sel.length > 0) {
                objgs_KnowledgesGraphType = arrgs_KnowledgesGraphType_Sel[0];
                return objgs_KnowledgesGraphType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_KnowledgesGraphType = await gs_KnowledgesGraphType_GetObjByGraphTypeIdAsync(strGraphTypeId);
                    if (objgs_KnowledgesGraphType != null) {
                        gs_KnowledgesGraphType_ReFreshThisCache();
                        return objgs_KnowledgesGraphType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strGraphTypeId, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_KnowledgesGraphType_GetObjByGraphTypeId_Cache = gs_KnowledgesGraphType_GetObjByGraphTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strGraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_KnowledgesGraphType_GetObjByGraphTypeId_localStorage(strGraphTypeId) {
        const strThisFuncName = "GetObjByGraphTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strGraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strGraphTypeId]不能为空！(In GetObjByGraphTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strGraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strGraphTypeId]的长度:[{0}]不正确！", strGraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName, strGraphTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_KnowledgesGraphType_Cache = JSON.parse(strTempObj);
            return objgs_KnowledgesGraphType_Cache;
        }
        try {
            const objgs_KnowledgesGraphType = await gs_KnowledgesGraphType_GetObjByGraphTypeIdAsync(strGraphTypeId);
            if (objgs_KnowledgesGraphType != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_KnowledgesGraphType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_KnowledgesGraphType;
            }
            return objgs_KnowledgesGraphType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strGraphTypeId, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_KnowledgesGraphType_GetObjByGraphTypeId_localStorage = gs_KnowledgesGraphType_GetObjByGraphTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_KnowledgesGraphType:所给的对象
     * @returns 对象
    */
    async function gs_KnowledgesGraphType_UpdateObjInLst_Cache(objgs_KnowledgesGraphType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
            const obj = arrgs_KnowledgesGraphTypeObjLst_Cache.find(x => x.graphTypeId == objgs_KnowledgesGraphType.graphTypeId);
            if (obj != null) {
                objgs_KnowledgesGraphType.graphTypeId = obj.graphTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_KnowledgesGraphType);
            }
            else {
                arrgs_KnowledgesGraphTypeObjLst_Cache.push(objgs_KnowledgesGraphType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_KnowledgesGraphType_UpdateObjInLst_Cache = gs_KnowledgesGraphType_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function gs_KnowledgesGraphType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strGraphTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_KnowledgesGraphType = await gs_KnowledgesGraphType_GetObjByGraphTypeId_Cache(strGraphTypeId);
        if (objgs_KnowledgesGraphType == null)
            return "";
        return objgs_KnowledgesGraphType.GetFldValue(strOutFldName).toString();
    }
    exports.gs_KnowledgesGraphType_func = gs_KnowledgesGraphType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesGraphType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.graphTypeId.localeCompare(b.graphTypeId);
    }
    exports.gs_KnowledgesGraphType_SortFun_Defa = gs_KnowledgesGraphType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesGraphType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.graphTypeName == b.graphTypeName)
            return a.memo.localeCompare(b.memo);
        else
            return a.graphTypeName.localeCompare(b.graphTypeName);
    }
    exports.gs_KnowledgesGraphType_SortFun_Defa_2Fld = gs_KnowledgesGraphType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_KnowledgesGraphType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId:
                    return (a, b) => {
                        return a.graphTypeId.localeCompare(b.graphTypeId);
                    };
                case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeName:
                    return (a, b) => {
                        return a.graphTypeName.localeCompare(b.graphTypeName);
                    };
                case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesGraphType]中不存在！(in ${exports.gs_KnowledgesGraphType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId:
                    return (a, b) => {
                        return b.graphTypeId.localeCompare(a.graphTypeId);
                    };
                case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeName:
                    return (a, b) => {
                        return b.graphTypeName.localeCompare(a.graphTypeName);
                    };
                case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesGraphType]中不存在！(in ${exports.gs_KnowledgesGraphType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_KnowledgesGraphType_SortFunByKey = gs_KnowledgesGraphType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_KnowledgesGraphType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId:
                return (obj) => {
                    return obj.graphTypeId === value;
                };
            case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeName:
                return (obj) => {
                    return obj.graphTypeName === value;
                };
            case clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_KnowledgesGraphType]中不存在！(in ${exports.gs_KnowledgesGraphType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_KnowledgesGraphType_FilterFunByKey = gs_KnowledgesGraphType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_KnowledgesGraphType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetFirstIDAsync = gs_KnowledgesGraphType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_KnowledgesGraphType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetFirstID = gs_KnowledgesGraphType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_KnowledgesGraphType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_KnowledgesGraphType = gs_KnowledgesGraphType_GetObjFromJsonObj(returnObj);
                return objgs_KnowledgesGraphType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetFirstObjAsync = gs_KnowledgesGraphType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
        clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_KnowledgesGraphTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_KnowledgesGraphTypeObjLst_T = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphTypeExObjLst_Cache);
            return arrgs_KnowledgesGraphTypeObjLst_T;
        }
        try {
            const arrgs_KnowledgesGraphTypeExObjLst = await gs_KnowledgesGraphType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_KnowledgesGraphTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesGraphTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_KnowledgesGraphTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLst_ClientCache = gs_KnowledgesGraphType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
        clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_KnowledgesGraphTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_KnowledgesGraphTypeObjLst_T = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphTypeExObjLst_Cache);
            return arrgs_KnowledgesGraphTypeObjLst_T;
        }
        try {
            const arrgs_KnowledgesGraphTypeExObjLst = await gs_KnowledgesGraphType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_KnowledgesGraphTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesGraphTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_KnowledgesGraphTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLst_localStorage = gs_KnowledgesGraphType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_KnowledgesGraphTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_KnowledgesGraphTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_KnowledgesGraphType_GetObjLst_localStorage_PureCache = gs_KnowledgesGraphType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLstAsync = gs_KnowledgesGraphType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
        clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_KnowledgesGraphTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_KnowledgesGraphTypeObjLst_T = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphTypeExObjLst_Cache);
            return arrgs_KnowledgesGraphTypeObjLst_T;
        }
        try {
            const arrgs_KnowledgesGraphTypeExObjLst = await gs_KnowledgesGraphType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_KnowledgesGraphTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_KnowledgesGraphTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_KnowledgesGraphTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLst_sessionStorage = gs_KnowledgesGraphType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_KnowledgesGraphTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_KnowledgesGraphTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_KnowledgesGraphType_GetObjLst_sessionStorage_PureCache = gs_KnowledgesGraphType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_KnowledgesGraphTypeObjLst_Cache;
        switch (clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_ClientCache();
                break;
            default:
                arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_ClientCache();
                break;
        }
        const arrgs_KnowledgesGraphTypeObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphTypeObjLst_Cache);
        return arrgs_KnowledgesGraphTypeObjLst_Cache;
    }
    exports.gs_KnowledgesGraphType_GetObjLst_Cache = gs_KnowledgesGraphType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_KnowledgesGraphTypeObjLst_Cache;
        switch (clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_KnowledgesGraphTypeObjLst_Cache = null;
                break;
            default:
                arrgs_KnowledgesGraphTypeObjLst_Cache = null;
                break;
        }
        return arrgs_KnowledgesGraphTypeObjLst_Cache;
    }
    exports.gs_KnowledgesGraphType_GetObjLst_PureCache = gs_KnowledgesGraphType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrGraphTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_KnowledgesGraphType_GetSubObjLst_Cache(objgs_KnowledgesGraphType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
        let arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache;
        if (objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp == null || objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp == "")
            return arrgs_KnowledgesGraphType_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_KnowledgesGraphTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_KnowledgesGraphType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesGraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_KnowledgesGraphType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_KnowledgesGraphType_Cond), exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesGraphType_GetSubObjLst_Cache = gs_KnowledgesGraphType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrGraphTypeId:关键字列表
    * @returns 对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLstAsync(arrGraphTypeId) {
        const strThisFuncName = "GetObjLstByGraphTypeIdLstAsync";
        const strAction = "GetObjLstByGraphTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrGraphTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLstAsync = gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrGraphTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLst_Cache(arrGraphTypeIdLst) {
        const strThisFuncName = "GetObjLstByGraphTypeIdLst_Cache";
        try {
            const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
            const arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache.filter(x => arrGraphTypeIdLst.indexOf(x.graphTypeId) > -1);
            return arrgs_KnowledgesGraphType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrGraphTypeIdLst.join(","), exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLst_Cache = gs_KnowledgesGraphType_GetObjLstByGraphTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_KnowledgesGraphType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetTopObjLstAsync = gs_KnowledgesGraphType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLstByRangeAsync = gs_KnowledgesGraphType_GetObjLstByRangeAsync;
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
    async function gs_KnowledgesGraphType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLstByRange = gs_KnowledgesGraphType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_KnowledgesGraphType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
        if (arrgs_KnowledgesGraphTypeObjLst_Cache.length == 0)
            return arrgs_KnowledgesGraphTypeObjLst_Cache;
        let arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_KnowledgesGraphType_Cond = new clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_KnowledgesGraphType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_KnowledgesGraphTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesGraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_KnowledgesGraphType_Sel.length == 0)
                return arrgs_KnowledgesGraphType_Sel;
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
                arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.sort(gs_KnowledgesGraphType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.slice(intStart, intEnd);
            return arrgs_KnowledgesGraphType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_KnowledgesGraphType_GetObjLstByPager_Cache = gs_KnowledgesGraphType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_KnowledgesGraphType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetObjLstByPagerAsync = gs_KnowledgesGraphType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strGraphTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_KnowledgesGraphType_DelRecordAsync(strGraphTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strGraphTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strGraphTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_DelRecordAsync = gs_KnowledgesGraphType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrGraphTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesAsync(arrGraphTypeId) {
        const strThisFuncName = "Delgs_KnowledgesGraphTypesAsync";
        const strAction = "Delgs_KnowledgesGraphTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrGraphTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesAsync = gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_KnowledgesGraphTypesByCondAsync";
        const strAction = "Delgs_KnowledgesGraphTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesByCondAsync = gs_KnowledgesGraphType_Delgs_KnowledgesGraphTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_KnowledgesGraphTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_KnowledgesGraphType_AddNewRecordAsync(objgs_KnowledgesGraphTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_KnowledgesGraphTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesGraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_AddNewRecordAsync = gs_KnowledgesGraphType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_KnowledgesGraphTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_KnowledgesGraphType_AddNewRecordWithMaxIdAsync(objgs_KnowledgesGraphTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesGraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_AddNewRecordWithMaxIdAsync = gs_KnowledgesGraphType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_KnowledgesGraphTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_KnowledgesGraphType_AddNewRecordWithReturnKeyAsync(objgs_KnowledgesGraphTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesGraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_AddNewRecordWithReturnKeyAsync = gs_KnowledgesGraphType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_KnowledgesGraphTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_KnowledgesGraphType_AddNewRecordWithReturnKey(objgs_KnowledgesGraphTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_KnowledgesGraphTypeEN.graphTypeId === null || objgs_KnowledgesGraphTypeEN.graphTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesGraphTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_AddNewRecordWithReturnKey = gs_KnowledgesGraphType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_KnowledgesGraphTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_KnowledgesGraphType_UpdateRecordAsync(objgs_KnowledgesGraphTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr === undefined || objgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr === null || objgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_KnowledgesGraphTypeEN.graphTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesGraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_UpdateRecordAsync = gs_KnowledgesGraphType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_KnowledgesGraphTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_KnowledgesGraphType_UpdateWithConditionAsync(objgs_KnowledgesGraphTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr === undefined || objgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr === null || objgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_KnowledgesGraphTypeEN.graphTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        objgs_KnowledgesGraphTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_KnowledgesGraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_UpdateWithConditionAsync = gs_KnowledgesGraphType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrGraphTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_KnowledgesGraphType_IsExistRecord_Cache(objgs_KnowledgesGraphType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
        if (arrgs_KnowledgesGraphTypeObjLst_Cache == null)
            return false;
        let arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache;
        if (objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp == null || objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp == "")
            return arrgs_KnowledgesGraphType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_KnowledgesGraphTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_KnowledgesGraphType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesGraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_KnowledgesGraphType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_KnowledgesGraphType_Cond), exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_KnowledgesGraphType_IsExistRecord_Cache = gs_KnowledgesGraphType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_KnowledgesGraphType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_IsExistRecordAsync = gs_KnowledgesGraphType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strGraphTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_KnowledgesGraphType_IsExist(strGraphTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "GraphTypeId": strGraphTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_IsExist = gs_KnowledgesGraphType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strGraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_KnowledgesGraphType_IsExist_Cache(strGraphTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
        if (arrgs_KnowledgesGraphTypeObjLst_Cache == null)
            return false;
        try {
            const arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache.filter(x => x.graphTypeId == strGraphTypeId);
            if (arrgs_KnowledgesGraphType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strGraphTypeId, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_KnowledgesGraphType_IsExist_Cache = gs_KnowledgesGraphType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strGraphTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_KnowledgesGraphType_IsExistAsync(strGraphTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strGraphTypeId": strGraphTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_IsExistAsync = gs_KnowledgesGraphType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_KnowledgesGraphType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetRecCountByCondAsync = gs_KnowledgesGraphType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_KnowledgesGraphType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_KnowledgesGraphType_GetRecCountByCond_Cache(objgs_KnowledgesGraphType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_KnowledgesGraphTypeObjLst_Cache = await gs_KnowledgesGraphType_GetObjLst_Cache();
        if (arrgs_KnowledgesGraphTypeObjLst_Cache == null)
            return 0;
        let arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphTypeObjLst_Cache;
        if (objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp == null || objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp == "")
            return arrgs_KnowledgesGraphType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_KnowledgesGraphType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_KnowledgesGraphTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_KnowledgesGraphType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_KnowledgesGraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_KnowledgesGraphType_Sel = arrgs_KnowledgesGraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_KnowledgesGraphType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_KnowledgesGraphType_Cond), exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_KnowledgesGraphType_GetRecCountByCond_Cache = gs_KnowledgesGraphType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_KnowledgesGraphType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetMaxStrIdAsync = gs_KnowledgesGraphType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_KnowledgesGraphType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_KnowledgesGraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_KnowledgesGraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_KnowledgesGraphType_GetMaxStrIdByPrefix = gs_KnowledgesGraphType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_KnowledgesGraphType_GetWebApiUrl(strController, strAction) {
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
    exports.gs_KnowledgesGraphType_GetWebApiUrl = gs_KnowledgesGraphType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_KnowledgesGraphType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
        switch (clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheModeId) {
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
    exports.gs_KnowledgesGraphType_ReFreshCache = gs_KnowledgesGraphType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_KnowledgesGraphType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN._CurrTabName;
            switch (clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.CacheModeId) {
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
    exports.gs_KnowledgesGraphType_ReFreshThisCache = gs_KnowledgesGraphType_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_KnowledgesGraphType_CheckPropertyNew(pobjgs_KnowledgesGraphTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[图谱类型Id(graphTypeId)]的长度不能超过2(In 知识点图谱类型(gs_KnowledgesGraphType))!值:$(pobjgs_KnowledgesGraphTypeEN.graphTypeId)(clsgs_KnowledgesGraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesGraphTypeEN.graphTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[图谱类型名称(graphTypeName)]的长度不能超过50(In 知识点图谱类型(gs_KnowledgesGraphType))!值:$(pobjgs_KnowledgesGraphTypeEN.graphTypeName)(clsgs_KnowledgesGraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesGraphTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点图谱类型(gs_KnowledgesGraphType))!值:$(pobjgs_KnowledgesGraphTypeEN.memo)(clsgs_KnowledgesGraphTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) == false && undefined !== pobjgs_KnowledgesGraphTypeEN.graphTypeId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesGraphTypeEN.graphTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[图谱类型Id(graphTypeId)]的值:[$(pobjgs_KnowledgesGraphTypeEN.graphTypeId)], 非法，应该为字符型(In 知识点图谱类型(gs_KnowledgesGraphType))!(clsgs_KnowledgesGraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeName) == false && undefined !== pobjgs_KnowledgesGraphTypeEN.graphTypeName && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesGraphTypeEN.graphTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[图谱类型名称(graphTypeName)]的值:[$(pobjgs_KnowledgesGraphTypeEN.graphTypeName)], 非法，应该为字符型(In 知识点图谱类型(gs_KnowledgesGraphType))!(clsgs_KnowledgesGraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.memo) == false && undefined !== pobjgs_KnowledgesGraphTypeEN.memo && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesGraphTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_KnowledgesGraphTypeEN.memo)], 非法，应该为字符型(In 知识点图谱类型(gs_KnowledgesGraphType))!(clsgs_KnowledgesGraphTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_KnowledgesGraphTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_KnowledgesGraphType_CheckPropertyNew = gs_KnowledgesGraphType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_KnowledgesGraphType_CheckProperty4Update(pobjgs_KnowledgesGraphTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[图谱类型Id(graphTypeId)]的长度不能超过2(In 知识点图谱类型(gs_KnowledgesGraphType))!值:$(pobjgs_KnowledgesGraphTypeEN.graphTypeId)(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesGraphTypeEN.graphTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[图谱类型名称(graphTypeName)]的长度不能超过50(In 知识点图谱类型(gs_KnowledgesGraphType))!值:$(pobjgs_KnowledgesGraphTypeEN.graphTypeName)(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_KnowledgesGraphTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点图谱类型(gs_KnowledgesGraphType))!值:$(pobjgs_KnowledgesGraphTypeEN.memo)(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) == false && undefined !== pobjgs_KnowledgesGraphTypeEN.graphTypeId && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesGraphTypeEN.graphTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[图谱类型Id(graphTypeId)]的值:[$(pobjgs_KnowledgesGraphTypeEN.graphTypeId)], 非法，应该为字符型(In 知识点图谱类型(gs_KnowledgesGraphType))!(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeName) == false && undefined !== pobjgs_KnowledgesGraphTypeEN.graphTypeName && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesGraphTypeEN.graphTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[图谱类型名称(graphTypeName)]的值:[$(pobjgs_KnowledgesGraphTypeEN.graphTypeName)], 非法，应该为字符型(In 知识点图谱类型(gs_KnowledgesGraphType))!(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.memo) == false && undefined !== pobjgs_KnowledgesGraphTypeEN.memo && jsString_js_1.tzDataType.isString(pobjgs_KnowledgesGraphTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_KnowledgesGraphTypeEN.memo)], 非法，应该为字符型(In 知识点图谱类型(gs_KnowledgesGraphType))!(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_KnowledgesGraphTypeEN.graphTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[图谱类型Id]不能为空(In 知识点图谱类型)!(clsgs_KnowledgesGraphTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_KnowledgesGraphTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_KnowledgesGraphType_CheckProperty4Update = gs_KnowledgesGraphType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_KnowledgesGraphType_GetJSONStrByObj(pobjgs_KnowledgesGraphTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_KnowledgesGraphTypeEN.sf_UpdFldSetStr = pobjgs_KnowledgesGraphTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_KnowledgesGraphTypeEN);
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
    exports.gs_KnowledgesGraphType_GetJSONStrByObj = gs_KnowledgesGraphType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_KnowledgesGraphType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_KnowledgesGraphTypeObjLst = new Array();
        if (strJSON === "") {
            return arrgs_KnowledgesGraphTypeObjLst;
        }
        try {
            arrgs_KnowledgesGraphTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_KnowledgesGraphTypeObjLst;
        }
        return arrgs_KnowledgesGraphTypeObjLst;
    }
    exports.gs_KnowledgesGraphType_GetObjLstByJSONStr = gs_KnowledgesGraphType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_KnowledgesGraphTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_KnowledgesGraphType_GetObjLstByJSONObjLst(arrgs_KnowledgesGraphTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_KnowledgesGraphTypeObjLst = new Array();
        for (const objInFor of arrgs_KnowledgesGraphTypeObjLstS) {
            const obj1 = gs_KnowledgesGraphType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_KnowledgesGraphTypeObjLst.push(obj1);
        }
        return arrgs_KnowledgesGraphTypeObjLst;
    }
    exports.gs_KnowledgesGraphType_GetObjLstByJSONObjLst = gs_KnowledgesGraphType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_KnowledgesGraphType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_KnowledgesGraphTypeEN = new clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN();
        if (strJSON === "") {
            return pobjgs_KnowledgesGraphTypeEN;
        }
        try {
            pobjgs_KnowledgesGraphTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_KnowledgesGraphTypeEN;
        }
        return pobjgs_KnowledgesGraphTypeEN;
    }
    exports.gs_KnowledgesGraphType_GetObjByJSONStr = gs_KnowledgesGraphType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_KnowledgesGraphType_GetCombineCondition(objgs_KnowledgesGraphType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraphType_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId) == true) {
            const strComparisonOp_GraphTypeId = objgs_KnowledgesGraphType_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeId, objgs_KnowledgesGraphType_Cond.graphTypeId, strComparisonOp_GraphTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraphType_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeName) == true) {
            const strComparisonOp_GraphTypeName = objgs_KnowledgesGraphType_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_GraphTypeName, objgs_KnowledgesGraphType_Cond.graphTypeName, strComparisonOp_GraphTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_KnowledgesGraphType_Cond.dicFldComparisonOp, clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_KnowledgesGraphType_Cond.dicFldComparisonOp[clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN.con_Memo, objgs_KnowledgesGraphType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_KnowledgesGraphType_GetCombineCondition = gs_KnowledgesGraphType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_KnowledgesGraphType(知识点图谱类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strGraphTypeId: 图谱类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_KnowledgesGraphType_GetUniCondStr_GraphTypeId(objgs_KnowledgesGraphTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and GraphTypeId = '{0}'", objgs_KnowledgesGraphTypeEN.graphTypeId);
        return strWhereCond;
    }
    exports.gs_KnowledgesGraphType_GetUniCondStr_GraphTypeId = gs_KnowledgesGraphType_GetUniCondStr_GraphTypeId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_KnowledgesGraphType(知识点图谱类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strGraphTypeId: 图谱类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_KnowledgesGraphType_GetUniCondStr4Update_GraphTypeId(objgs_KnowledgesGraphTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and GraphTypeId <> '{0}'", objgs_KnowledgesGraphTypeEN.graphTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and GraphTypeId = '{0}'", objgs_KnowledgesGraphTypeEN.graphTypeId);
        return strWhereCond;
    }
    exports.gs_KnowledgesGraphType_GetUniCondStr4Update_GraphTypeId = gs_KnowledgesGraphType_GetUniCondStr4Update_GraphTypeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_KnowledgesGraphTypeENS:源对象
     * @param objgs_KnowledgesGraphTypeENT:目标对象
    */
    function gs_KnowledgesGraphType_CopyObjTo(objgs_KnowledgesGraphTypeENS, objgs_KnowledgesGraphTypeENT) {
        objgs_KnowledgesGraphTypeENT.graphTypeId = objgs_KnowledgesGraphTypeENS.graphTypeId; //图谱类型Id
        objgs_KnowledgesGraphTypeENT.graphTypeName = objgs_KnowledgesGraphTypeENS.graphTypeName; //图谱类型名称
        objgs_KnowledgesGraphTypeENT.memo = objgs_KnowledgesGraphTypeENS.memo; //备注
        objgs_KnowledgesGraphTypeENT.sf_UpdFldSetStr = objgs_KnowledgesGraphTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_KnowledgesGraphType_CopyObjTo = gs_KnowledgesGraphType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_KnowledgesGraphTypeENS:源对象
     * @param objgs_KnowledgesGraphTypeENT:目标对象
    */
    function gs_KnowledgesGraphType_GetObjFromJsonObj(objgs_KnowledgesGraphTypeENS) {
        const objgs_KnowledgesGraphTypeENT = new clsgs_KnowledgesGraphTypeEN_js_1.clsgs_KnowledgesGraphTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_KnowledgesGraphTypeENT, objgs_KnowledgesGraphTypeENS);
        return objgs_KnowledgesGraphTypeENT;
    }
    exports.gs_KnowledgesGraphType_GetObjFromJsonObj = gs_KnowledgesGraphType_GetObjFromJsonObj;
});
