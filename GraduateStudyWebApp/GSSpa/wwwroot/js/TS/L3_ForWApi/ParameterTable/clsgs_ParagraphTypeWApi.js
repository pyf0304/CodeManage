/**
* 类名:clsgs_ParagraphTypeWApi
* 表名:gs_ParagraphType(01120746)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 16:58:53
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsgs_ParagraphTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_ParagraphType_GetObjFromJsonObj = exports.gs_ParagraphType_CopyObjTo = exports.gs_ParagraphType_GetUniCondStr4Update_ParagraphTypeId = exports.gs_ParagraphType_GetUniCondStr_ParagraphTypeId = exports.gs_ParagraphType_GetCombineCondition = exports.gs_ParagraphType_GetObjByJSONStr = exports.gs_ParagraphType_GetObjLstByJSONObjLst = exports.gs_ParagraphType_GetObjLstByJSONStr = exports.gs_ParagraphType_GetJSONStrByObj = exports.gs_ParagraphType_CheckProperty4Update = exports.gs_ParagraphType_CheckPropertyNew = exports.gs_ParagraphType_BindDdl_ParagraphTypeIdInDiv_Cache = exports.gs_ParagraphType_ReFreshThisCache = exports.gs_ParagraphType_ReFreshCache = exports.gs_ParagraphType_GetWebApiUrl = exports.gs_ParagraphType_GetMaxStrIdByPrefix = exports.gs_ParagraphType_GetMaxStrIdAsync = exports.gs_ParagraphType_GetRecCountByCond_Cache = exports.gs_ParagraphType_GetRecCountByCondAsync = exports.gs_ParagraphType_IsExistAsync = exports.gs_ParagraphType_IsExist_Cache = exports.gs_ParagraphType_IsExist = exports.gs_ParagraphType_IsExistRecordAsync = exports.gs_ParagraphType_IsExistRecord_Cache = exports.gs_ParagraphType_UpdateWithConditionAsync = exports.gs_ParagraphType_UpdateRecordAsync = exports.gs_ParagraphType_AddNewRecordWithReturnKey = exports.gs_ParagraphType_AddNewRecordWithReturnKeyAsync = exports.gs_ParagraphType_AddNewRecordWithMaxIdAsync = exports.gs_ParagraphType_AddNewRecordAsync = exports.gs_ParagraphType_Delgs_ParagraphTypesByCondAsync = exports.gs_ParagraphType_Delgs_ParagraphTypesAsync = exports.gs_ParagraphType_DelRecordAsync = exports.gs_ParagraphType_GetObjLstByPagerAsync = exports.gs_ParagraphType_GetObjLstByPager_Cache = exports.gs_ParagraphType_GetObjLstByRange = exports.gs_ParagraphType_GetObjLstByRangeAsync = exports.gs_ParagraphType_GetTopObjLstAsync = exports.gs_ParagraphType_GetObjLstByParagraphTypeIdLst_Cache = exports.gs_ParagraphType_GetObjLstByParagraphTypeIdLstAsync = exports.gs_ParagraphType_GetSubObjLst_Cache = exports.gs_ParagraphType_GetObjLst_PureCache = exports.gs_ParagraphType_GetObjLst_Cache = exports.gs_ParagraphType_GetObjLst_sessionStorage_PureCache = exports.gs_ParagraphType_GetObjLst_sessionStorage = exports.gs_ParagraphType_GetObjLstAsync = exports.gs_ParagraphType_GetObjLst_localStorage_PureCache = exports.gs_ParagraphType_GetObjLst_localStorage = exports.gs_ParagraphType_GetObjLst_ClientCache = exports.gs_ParagraphType_GetFirstObjAsync = exports.gs_ParagraphType_GetFirstID = exports.gs_ParagraphType_GetFirstIDAsync = exports.gs_ParagraphType_FilterFunByKey = exports.gs_ParagraphType_SortFunByKey = exports.gs_ParagraphType_SortFun_Defa_2Fld = exports.gs_ParagraphType_SortFun_Defa = exports.gs_ParagraphType_func = exports.gs_ParagraphType_GetNameByParagraphTypeId_Cache = exports.gs_ParagraphType_UpdateObjInLst_Cache = exports.gs_ParagraphType_GetObjByParagraphTypeId_localStorage = exports.gs_ParagraphType_GetObjByParagraphTypeId_Cache = exports.gs_ParagraphType_GetObjByParagraphTypeIdAsync = exports.gs_ParagraphType_ConstructorName = exports.gs_ParagraphType_Controller = void 0;
    /**
     * 段落类型(gs_ParagraphType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_ParagraphTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsgs_ParagraphTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_ParagraphType_Controller = "gs_ParagraphTypeApi";
    exports.gs_ParagraphType_ConstructorName = "gs_ParagraphType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strParagraphTypeId:关键字
    * @returns 对象
    **/
    async function gs_ParagraphType_GetObjByParagraphTypeIdAsync(strParagraphTypeId) {
        const strThisFuncName = "GetObjByParagraphTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphTypeId]不能为空！(In GetObjByParagraphTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphTypeId]的长度:[{0}]不正确！", strParagraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByParagraphTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strParagraphTypeId": strParagraphTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ParagraphType = gs_ParagraphType_GetObjFromJsonObj(returnObj);
                return objgs_ParagraphType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetObjByParagraphTypeIdAsync = gs_ParagraphType_GetObjByParagraphTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strParagraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_ParagraphType_GetObjByParagraphTypeId_Cache(strParagraphTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByParagraphTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphTypeId]不能为空！(In GetObjByParagraphTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphTypeId]的长度:[{0}]不正确！", strParagraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        try {
            const arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache.filter(x => x.paragraphTypeId == strParagraphTypeId);
            let objgs_ParagraphType;
            if (arrgs_ParagraphType_Sel.length > 0) {
                objgs_ParagraphType = arrgs_ParagraphType_Sel[0];
                return objgs_ParagraphType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_ParagraphType = await gs_ParagraphType_GetObjByParagraphTypeIdAsync(strParagraphTypeId);
                    if (objgs_ParagraphType != null) {
                        gs_ParagraphType_ReFreshThisCache();
                        return objgs_ParagraphType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphTypeId, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_ParagraphType_GetObjByParagraphTypeId_Cache = gs_ParagraphType_GetObjByParagraphTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strParagraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_ParagraphType_GetObjByParagraphTypeId_localStorage(strParagraphTypeId) {
        const strThisFuncName = "GetObjByParagraphTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphTypeId]不能为空！(In GetObjByParagraphTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphTypeId]的长度:[{0}]不正确！", strParagraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName, strParagraphTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_ParagraphType_Cache = JSON.parse(strTempObj);
            return objgs_ParagraphType_Cache;
        }
        try {
            const objgs_ParagraphType = await gs_ParagraphType_GetObjByParagraphTypeIdAsync(strParagraphTypeId);
            if (objgs_ParagraphType != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_ParagraphType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_ParagraphType;
            }
            return objgs_ParagraphType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphTypeId, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_ParagraphType_GetObjByParagraphTypeId_localStorage = gs_ParagraphType_GetObjByParagraphTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_ParagraphType:所给的对象
     * @returns 对象
    */
    async function gs_ParagraphType_UpdateObjInLst_Cache(objgs_ParagraphType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
            const obj = arrgs_ParagraphTypeObjLst_Cache.find(x => x.paragraphTypeId == objgs_ParagraphType.paragraphTypeId);
            if (obj != null) {
                objgs_ParagraphType.paragraphTypeId = obj.paragraphTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_ParagraphType);
            }
            else {
                arrgs_ParagraphTypeObjLst_Cache.push(objgs_ParagraphType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_ParagraphType_UpdateObjInLst_Cache = gs_ParagraphType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strParagraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_ParagraphType_GetNameByParagraphTypeId_Cache(strParagraphTypeId) {
        const strThisFuncName = "GetNameByParagraphTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphTypeId]不能为空！(In GetNameByParagraphTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphTypeId]的长度:[{0}]不正确！", strParagraphTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        if (arrgs_ParagraphTypeObjLst_Cache == null)
            return "";
        try {
            const arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache.filter(x => x.paragraphTypeId == strParagraphTypeId);
            let objgs_ParagraphType;
            if (arrgs_ParagraphType_Sel.length > 0) {
                objgs_ParagraphType = arrgs_ParagraphType_Sel[0];
                return objgs_ParagraphType.paragraphTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strParagraphTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.gs_ParagraphType_GetNameByParagraphTypeId_Cache = gs_ParagraphType_GetNameByParagraphTypeId_Cache;
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
    async function gs_ParagraphType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strParagraphTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_ParagraphType = await gs_ParagraphType_GetObjByParagraphTypeId_Cache(strParagraphTypeId);
        if (objgs_ParagraphType == null)
            return "";
        return objgs_ParagraphType.GetFldValue(strOutFldName).toString();
    }
    exports.gs_ParagraphType_func = gs_ParagraphType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ParagraphType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
    }
    exports.gs_ParagraphType_SortFun_Defa = gs_ParagraphType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ParagraphType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paragraphTypeName == b.paragraphTypeName)
            return a.memo.localeCompare(b.memo);
        else
            return a.paragraphTypeName.localeCompare(b.paragraphTypeName);
    }
    exports.gs_ParagraphType_SortFun_Defa_2Fld = gs_ParagraphType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_ParagraphType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
                    };
                case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName:
                    return (a, b) => {
                        return a.paragraphTypeName.localeCompare(b.paragraphTypeName);
                    };
                case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ParagraphType]中不存在！(in ${exports.gs_ParagraphType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
                    };
                case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName:
                    return (a, b) => {
                        return b.paragraphTypeName.localeCompare(a.paragraphTypeName);
                    };
                case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_ParagraphType]中不存在！(in ${exports.gs_ParagraphType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_ParagraphType_SortFunByKey = gs_ParagraphType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_ParagraphType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId:
                return (obj) => {
                    return obj.paragraphTypeId === value;
                };
            case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName:
                return (obj) => {
                    return obj.paragraphTypeName === value;
                };
            case clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_ParagraphType]中不存在！(in ${exports.gs_ParagraphType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_ParagraphType_FilterFunByKey = gs_ParagraphType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ParagraphType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetFirstIDAsync = gs_ParagraphType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_ParagraphType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetFirstID = gs_ParagraphType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_ParagraphType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_ParagraphType = gs_ParagraphType_GetObjFromJsonObj(returnObj);
                return objgs_ParagraphType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetFirstObjAsync = gs_ParagraphType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
        clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_ParagraphTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_ParagraphTypeObjLst_T = gs_ParagraphType_GetObjLstByJSONObjLst(arrgs_ParagraphTypeExObjLst_Cache);
            return arrgs_ParagraphTypeObjLst_T;
        }
        try {
            const arrgs_ParagraphTypeExObjLst = await gs_ParagraphType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_ParagraphTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ParagraphTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_ParagraphTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ParagraphType_GetObjLst_ClientCache = gs_ParagraphType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
        clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ParagraphTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ParagraphTypeObjLst_T = gs_ParagraphType_GetObjLstByJSONObjLst(arrgs_ParagraphTypeExObjLst_Cache);
            return arrgs_ParagraphTypeObjLst_T;
        }
        try {
            const arrgs_ParagraphTypeExObjLst = await gs_ParagraphType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_ParagraphTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ParagraphTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_ParagraphTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ParagraphType_GetObjLst_localStorage = gs_ParagraphType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_ParagraphTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ParagraphTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_ParagraphType_GetObjLst_localStorage_PureCache = gs_ParagraphType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_ParagraphType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ParagraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetObjLstAsync = gs_ParagraphType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
        clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ParagraphTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_ParagraphTypeObjLst_T = gs_ParagraphType_GetObjLstByJSONObjLst(arrgs_ParagraphTypeExObjLst_Cache);
            return arrgs_ParagraphTypeObjLst_T;
        }
        try {
            const arrgs_ParagraphTypeExObjLst = await gs_ParagraphType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_ParagraphTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_ParagraphTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_ParagraphTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_ParagraphType_GetObjLst_sessionStorage = gs_ParagraphType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_ParagraphTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_ParagraphTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_ParagraphType_GetObjLst_sessionStorage_PureCache = gs_ParagraphType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_ParagraphTypeObjLst_Cache;
        switch (clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_ClientCache();
                break;
            default:
                arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_ClientCache();
                break;
        }
        const arrgs_ParagraphTypeObjLst = gs_ParagraphType_GetObjLstByJSONObjLst(arrgs_ParagraphTypeObjLst_Cache);
        return arrgs_ParagraphTypeObjLst_Cache;
    }
    exports.gs_ParagraphType_GetObjLst_Cache = gs_ParagraphType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_ParagraphType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_ParagraphTypeObjLst_Cache;
        switch (clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_ParagraphTypeObjLst_Cache = null;
                break;
            default:
                arrgs_ParagraphTypeObjLst_Cache = null;
                break;
        }
        return arrgs_ParagraphTypeObjLst_Cache;
    }
    exports.gs_ParagraphType_GetObjLst_PureCache = gs_ParagraphType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrParagraphTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_ParagraphType_GetSubObjLst_Cache(objgs_ParagraphType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        let arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache;
        if (objgs_ParagraphType_Cond.sf_FldComparisonOp == null || objgs_ParagraphType_Cond.sf_FldComparisonOp == "")
            return arrgs_ParagraphType_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_ParagraphType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ParagraphTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ParagraphType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ParagraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_ParagraphType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_ParagraphType_Cond), exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ParagraphType_GetSubObjLst_Cache = gs_ParagraphType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrParagraphTypeId:关键字列表
    * @returns 对象列表
    **/
    async function gs_ParagraphType_GetObjLstByParagraphTypeIdLstAsync(arrParagraphTypeId) {
        const strThisFuncName = "GetObjLstByParagraphTypeIdLstAsync";
        const strAction = "GetObjLstByParagraphTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ParagraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetObjLstByParagraphTypeIdLstAsync = gs_ParagraphType_GetObjLstByParagraphTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrParagraphTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_ParagraphType_GetObjLstByParagraphTypeIdLst_Cache(arrParagraphTypeIdLst) {
        const strThisFuncName = "GetObjLstByParagraphTypeIdLst_Cache";
        try {
            const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
            const arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache.filter(x => arrParagraphTypeIdLst.indexOf(x.paragraphTypeId) > -1);
            return arrgs_ParagraphType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrParagraphTypeIdLst.join(","), exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ParagraphType_GetObjLstByParagraphTypeIdLst_Cache = gs_ParagraphType_GetObjLstByParagraphTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_ParagraphType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ParagraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetTopObjLstAsync = gs_ParagraphType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ParagraphType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ParagraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetObjLstByRangeAsync = gs_ParagraphType_GetObjLstByRangeAsync;
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
    async function gs_ParagraphType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetObjLstByRange = gs_ParagraphType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_ParagraphType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        if (arrgs_ParagraphTypeObjLst_Cache.length == 0)
            return arrgs_ParagraphTypeObjLst_Cache;
        let arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_ParagraphType_Cond = new clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ParagraphType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_ParagraphTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ParagraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ParagraphType_Sel.length == 0)
                return arrgs_ParagraphType_Sel;
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
                arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.sort(gs_ParagraphType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.slice(intStart, intEnd);
            return arrgs_ParagraphType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_ParagraphType_GetObjLstByPager_Cache = gs_ParagraphType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_ParagraphType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_ParagraphType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetObjLstByPagerAsync = gs_ParagraphType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strParagraphTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_ParagraphType_DelRecordAsync(strParagraphTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strParagraphTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strParagraphTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_DelRecordAsync = gs_ParagraphType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrParagraphTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_ParagraphType_Delgs_ParagraphTypesAsync(arrParagraphTypeId) {
        const strThisFuncName = "Delgs_ParagraphTypesAsync";
        const strAction = "Delgs_ParagraphTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_Delgs_ParagraphTypesAsync = gs_ParagraphType_Delgs_ParagraphTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_ParagraphType_Delgs_ParagraphTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_ParagraphTypesByCondAsync";
        const strAction = "Delgs_ParagraphTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_Delgs_ParagraphTypesByCondAsync = gs_ParagraphType_Delgs_ParagraphTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_ParagraphTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ParagraphType_AddNewRecordAsync(objgs_ParagraphTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_ParagraphTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ParagraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_AddNewRecordAsync = gs_ParagraphType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_ParagraphTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_ParagraphType_AddNewRecordWithMaxIdAsync(objgs_ParagraphTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ParagraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_AddNewRecordWithMaxIdAsync = gs_ParagraphType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_ParagraphTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_ParagraphType_AddNewRecordWithReturnKeyAsync(objgs_ParagraphTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ParagraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_AddNewRecordWithReturnKeyAsync = gs_ParagraphType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_ParagraphTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_ParagraphType_AddNewRecordWithReturnKey(objgs_ParagraphTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_ParagraphTypeEN.paragraphTypeId === null || objgs_ParagraphTypeEN.paragraphTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ParagraphTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_AddNewRecordWithReturnKey = gs_ParagraphType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_ParagraphTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_ParagraphType_UpdateRecordAsync(objgs_ParagraphTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_ParagraphTypeEN.sf_UpdFldSetStr === undefined || objgs_ParagraphTypeEN.sf_UpdFldSetStr === null || objgs_ParagraphTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ParagraphTypeEN.paragraphTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_ParagraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_UpdateRecordAsync = gs_ParagraphType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_ParagraphTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_ParagraphType_UpdateWithConditionAsync(objgs_ParagraphTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_ParagraphTypeEN.sf_UpdFldSetStr === undefined || objgs_ParagraphTypeEN.sf_UpdFldSetStr === null || objgs_ParagraphTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_ParagraphTypeEN.paragraphTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        objgs_ParagraphTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_ParagraphTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_UpdateWithConditionAsync = gs_ParagraphType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrParagraphTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_ParagraphType_IsExistRecord_Cache(objgs_ParagraphType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        if (arrgs_ParagraphTypeObjLst_Cache == null)
            return false;
        let arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache;
        if (objgs_ParagraphType_Cond.sf_FldComparisonOp == null || objgs_ParagraphType_Cond.sf_FldComparisonOp == "")
            return arrgs_ParagraphType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_ParagraphType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ParagraphTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ParagraphType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ParagraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_ParagraphType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_ParagraphType_Cond), exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_ParagraphType_IsExistRecord_Cache = gs_ParagraphType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_ParagraphType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_IsExistRecordAsync = gs_ParagraphType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strParagraphTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_ParagraphType_IsExist(strParagraphTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ParagraphTypeId": strParagraphTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_IsExist = gs_ParagraphType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strParagraphTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_ParagraphType_IsExist_Cache(strParagraphTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        if (arrgs_ParagraphTypeObjLst_Cache == null)
            return false;
        try {
            const arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache.filter(x => x.paragraphTypeId == strParagraphTypeId);
            if (arrgs_ParagraphType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strParagraphTypeId, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_ParagraphType_IsExist_Cache = gs_ParagraphType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strParagraphTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_ParagraphType_IsExistAsync(strParagraphTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strParagraphTypeId": strParagraphTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_IsExistAsync = gs_ParagraphType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_ParagraphType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetRecCountByCondAsync = gs_ParagraphType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_ParagraphType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_ParagraphType_GetRecCountByCond_Cache(objgs_ParagraphType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_ParagraphTypeObjLst_Cache = await gs_ParagraphType_GetObjLst_Cache();
        if (arrgs_ParagraphTypeObjLst_Cache == null)
            return 0;
        let arrgs_ParagraphType_Sel = arrgs_ParagraphTypeObjLst_Cache;
        if (objgs_ParagraphType_Cond.sf_FldComparisonOp == null || objgs_ParagraphType_Cond.sf_FldComparisonOp == "")
            return arrgs_ParagraphType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_ParagraphType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_ParagraphTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_ParagraphType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_ParagraphType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_ParagraphType_Sel = arrgs_ParagraphType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_ParagraphType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_ParagraphType_Cond), exports.gs_ParagraphType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_ParagraphType_GetRecCountByCond_Cache = gs_ParagraphType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_ParagraphType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetMaxStrIdAsync = gs_ParagraphType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_ParagraphType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_ParagraphType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_ParagraphType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_ParagraphType_GetMaxStrIdByPrefix = gs_ParagraphType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_ParagraphType_GetWebApiUrl(strController, strAction) {
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
    exports.gs_ParagraphType_GetWebApiUrl = gs_ParagraphType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_ParagraphType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
        switch (clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheModeId) {
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
    exports.gs_ParagraphType_ReFreshCache = gs_ParagraphType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_ParagraphType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN._CurrTabName;
            switch (clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.CacheModeId) {
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
    exports.gs_ParagraphType_ReFreshThisCache = gs_ParagraphType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function gs_ParagraphType_BindDdl_ParagraphTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_ParagraphTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_ParagraphTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_ParagraphTypeIdInDiv_Cache");
        const arrObjLst_Sel = await gs_ParagraphType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId, clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName, "段落类型");
    }
    exports.gs_ParagraphType_BindDdl_ParagraphTypeIdInDiv_Cache = gs_ParagraphType_BindDdl_ParagraphTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ParagraphType_CheckPropertyNew(pobjgs_ParagraphTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ParagraphTypeEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 段落类型(gs_ParagraphType))!值:$(pobjgs_ParagraphTypeEN.paragraphTypeId)(clsgs_ParagraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ParagraphTypeEN.paragraphTypeName) > 100) {
            throw new Error("(errid:Watl000059)字段[段落类型(paragraphTypeName)]的长度不能超过100(In 段落类型(gs_ParagraphType))!值:$(pobjgs_ParagraphTypeEN.paragraphTypeName)(clsgs_ParagraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ParagraphTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 段落类型(gs_ParagraphType))!值:$(pobjgs_ParagraphTypeEN.memo)(clsgs_ParagraphTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeId) == false && undefined !== pobjgs_ParagraphTypeEN.paragraphTypeId && jsString_js_1.tzDataType.isString(pobjgs_ParagraphTypeEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_ParagraphTypeEN.paragraphTypeId)], 非法，应该为字符型(In 段落类型(gs_ParagraphType))!(clsgs_ParagraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeName) == false && undefined !== pobjgs_ParagraphTypeEN.paragraphTypeName && jsString_js_1.tzDataType.isString(pobjgs_ParagraphTypeEN.paragraphTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[段落类型(paragraphTypeName)]的值:[$(pobjgs_ParagraphTypeEN.paragraphTypeName)], 非法，应该为字符型(In 段落类型(gs_ParagraphType))!(clsgs_ParagraphTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.memo) == false && undefined !== pobjgs_ParagraphTypeEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ParagraphTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_ParagraphTypeEN.memo)], 非法，应该为字符型(In 段落类型(gs_ParagraphType))!(clsgs_ParagraphTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_ParagraphTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_ParagraphType_CheckPropertyNew = gs_ParagraphType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_ParagraphType_CheckProperty4Update(pobjgs_ParagraphTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ParagraphTypeEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 段落类型(gs_ParagraphType))!值:$(pobjgs_ParagraphTypeEN.paragraphTypeId)(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ParagraphTypeEN.paragraphTypeName) > 100) {
            throw new Error("(errid:Watl000062)字段[段落类型(paragraphTypeName)]的长度不能超过100(In 段落类型(gs_ParagraphType))!值:$(pobjgs_ParagraphTypeEN.paragraphTypeName)(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_ParagraphTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 段落类型(gs_ParagraphType))!值:$(pobjgs_ParagraphTypeEN.memo)(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeId) == false && undefined !== pobjgs_ParagraphTypeEN.paragraphTypeId && jsString_js_1.tzDataType.isString(pobjgs_ParagraphTypeEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_ParagraphTypeEN.paragraphTypeId)], 非法，应该为字符型(In 段落类型(gs_ParagraphType))!(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeName) == false && undefined !== pobjgs_ParagraphTypeEN.paragraphTypeName && jsString_js_1.tzDataType.isString(pobjgs_ParagraphTypeEN.paragraphTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[段落类型(paragraphTypeName)]的值:[$(pobjgs_ParagraphTypeEN.paragraphTypeName)], 非法，应该为字符型(In 段落类型(gs_ParagraphType))!(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.memo) == false && undefined !== pobjgs_ParagraphTypeEN.memo && jsString_js_1.tzDataType.isString(pobjgs_ParagraphTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_ParagraphTypeEN.memo)], 非法，应该为字符型(In 段落类型(gs_ParagraphType))!(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_ParagraphTypeEN.paragraphTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[段落类型Id]不能为空(In 段落类型)!(clsgs_ParagraphTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_ParagraphTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_ParagraphType_CheckProperty4Update = gs_ParagraphType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ParagraphType_GetJSONStrByObj(pobjgs_ParagraphTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_ParagraphTypeEN.sf_UpdFldSetStr = pobjgs_ParagraphTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_ParagraphTypeEN);
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
    exports.gs_ParagraphType_GetJSONStrByObj = gs_ParagraphType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_ParagraphType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_ParagraphTypeObjLst = new Array();
        if (strJSON === "") {
            return arrgs_ParagraphTypeObjLst;
        }
        try {
            arrgs_ParagraphTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_ParagraphTypeObjLst;
        }
        return arrgs_ParagraphTypeObjLst;
    }
    exports.gs_ParagraphType_GetObjLstByJSONStr = gs_ParagraphType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_ParagraphTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_ParagraphType_GetObjLstByJSONObjLst(arrgs_ParagraphTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_ParagraphTypeObjLst = new Array();
        for (const objInFor of arrgs_ParagraphTypeObjLstS) {
            const obj1 = gs_ParagraphType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_ParagraphTypeObjLst.push(obj1);
        }
        return arrgs_ParagraphTypeObjLst;
    }
    exports.gs_ParagraphType_GetObjLstByJSONObjLst = gs_ParagraphType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_ParagraphType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_ParagraphTypeEN = new clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN();
        if (strJSON === "") {
            return pobjgs_ParagraphTypeEN;
        }
        try {
            pobjgs_ParagraphTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_ParagraphTypeEN;
        }
        return pobjgs_ParagraphTypeEN;
    }
    exports.gs_ParagraphType_GetObjByJSONStr = gs_ParagraphType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_ParagraphType_GetCombineCondition(objgs_ParagraphType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_ParagraphType_Cond.dicFldComparisonOp, clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId) == true) {
            const strComparisonOp_ParagraphTypeId = objgs_ParagraphType_Cond.dicFldComparisonOp[clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeId, objgs_ParagraphType_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ParagraphType_Cond.dicFldComparisonOp, clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName) == true) {
            const strComparisonOp_ParagraphTypeName = objgs_ParagraphType_Cond.dicFldComparisonOp[clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_ParagraphTypeName, objgs_ParagraphType_Cond.paragraphTypeName, strComparisonOp_ParagraphTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_ParagraphType_Cond.dicFldComparisonOp, clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_ParagraphType_Cond.dicFldComparisonOp[clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN.con_Memo, objgs_ParagraphType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_ParagraphType_GetCombineCondition = gs_ParagraphType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ParagraphType(段落类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strParagraphTypeId: 段落类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ParagraphType_GetUniCondStr_ParagraphTypeId(objgs_ParagraphTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphTypeId = '{0}'", objgs_ParagraphTypeEN.paragraphTypeId);
        return strWhereCond;
    }
    exports.gs_ParagraphType_GetUniCondStr_ParagraphTypeId = gs_ParagraphType_GetUniCondStr_ParagraphTypeId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_ParagraphType(段落类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strParagraphTypeId: 段落类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_ParagraphType_GetUniCondStr4Update_ParagraphTypeId(objgs_ParagraphTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphTypeId <> '{0}'", objgs_ParagraphTypeEN.paragraphTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphTypeId = '{0}'", objgs_ParagraphTypeEN.paragraphTypeId);
        return strWhereCond;
    }
    exports.gs_ParagraphType_GetUniCondStr4Update_ParagraphTypeId = gs_ParagraphType_GetUniCondStr4Update_ParagraphTypeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_ParagraphTypeENS:源对象
     * @param objgs_ParagraphTypeENT:目标对象
    */
    function gs_ParagraphType_CopyObjTo(objgs_ParagraphTypeENS, objgs_ParagraphTypeENT) {
        objgs_ParagraphTypeENT.paragraphTypeId = objgs_ParagraphTypeENS.paragraphTypeId; //段落类型Id
        objgs_ParagraphTypeENT.paragraphTypeName = objgs_ParagraphTypeENS.paragraphTypeName; //段落类型
        objgs_ParagraphTypeENT.memo = objgs_ParagraphTypeENS.memo; //备注
        objgs_ParagraphTypeENT.sf_UpdFldSetStr = objgs_ParagraphTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_ParagraphType_CopyObjTo = gs_ParagraphType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_ParagraphTypeENS:源对象
     * @param objgs_ParagraphTypeENT:目标对象
    */
    function gs_ParagraphType_GetObjFromJsonObj(objgs_ParagraphTypeENS) {
        const objgs_ParagraphTypeENT = new clsgs_ParagraphTypeEN_js_1.clsgs_ParagraphTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_ParagraphTypeENT, objgs_ParagraphTypeENS);
        return objgs_ParagraphTypeENT;
    }
    exports.gs_ParagraphType_GetObjFromJsonObj = gs_ParagraphType_GetObjFromJsonObj;
});
