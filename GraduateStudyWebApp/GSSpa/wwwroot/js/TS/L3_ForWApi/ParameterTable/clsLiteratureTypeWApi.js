/**
* 类名:clsLiteratureTypeWApi
* 表名:LiteratureType(01120557)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsLiteratureTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.LiteratureType_GetObjFromJsonObj = exports.LiteratureType_CopyObjTo = exports.LiteratureType_GetCombineCondition = exports.LiteratureType_GetObjByJSONStr = exports.LiteratureType_GetObjLstByJSONObjLst = exports.LiteratureType_GetObjLstByJSONStr = exports.LiteratureType_GetJSONStrByObj = exports.LiteratureType_CheckProperty4Update = exports.LiteratureType_CheckPropertyNew = exports.LiteratureType__Cache = exports.LiteratureType_ReFreshThisCache = exports.LiteratureType_ReFreshCache = exports.LiteratureType_GetWebApiUrl = exports.LiteratureType_GetMaxStrIdByPrefix = exports.LiteratureType_GetRecCountByCond_Cache = exports.LiteratureType_GetRecCountByCondAsync = exports.LiteratureType_IsExistAsync = exports.LiteratureType_IsExist_Cache = exports.LiteratureType_IsExist = exports.LiteratureType_IsExistRecordAsync = exports.LiteratureType_IsExistRecord_Cache = exports.LiteratureType_UpdateWithConditionAsync = exports.LiteratureType_UpdateRecordAsync = exports.LiteratureType_AddNewRecordWithReturnKey = exports.LiteratureType_AddNewRecordWithReturnKeyAsync = exports.LiteratureType_AddNewRecordWithMaxIdAsync = exports.LiteratureType_AddNewRecordAsync = exports.LiteratureType_DelLiteratureTypesByCondAsync = exports.LiteratureType_DelLiteratureTypesAsync = exports.LiteratureType_DelRecordAsync = exports.LiteratureType_GetObjLstByPagerAsync = exports.LiteratureType_GetObjLstByPager_Cache = exports.LiteratureType_GetObjLstByRange = exports.LiteratureType_GetObjLstByRangeAsync = exports.LiteratureType_GetTopObjLstAsync = exports.LiteratureType_GetObjLstByLiteratureTypeIdLst_Cache = exports.LiteratureType_GetObjLstByLiteratureTypeIdLstAsync = exports.LiteratureType_GetSubObjLst_Cache = exports.LiteratureType_GetObjLst_PureCache = exports.LiteratureType_GetObjLst_Cache = exports.LiteratureType_GetObjLst_sessionStorage_PureCache = exports.LiteratureType_GetObjLst_sessionStorage = exports.LiteratureType_GetObjLstAsync = exports.LiteratureType_GetObjLst_localStorage_PureCache = exports.LiteratureType_GetObjLst_localStorage = exports.LiteratureType_GetObjLst_ClientCache = exports.LiteratureType_GetFirstObjAsync = exports.LiteratureType_GetFirstID = exports.LiteratureType_GetFirstIDAsync = exports.LiteratureType_FilterFunByKey = exports.LiteratureType_SortFunByKey = exports.LiteratureType_SortFun_Defa_2Fld = exports.LiteratureType_SortFun_Defa = exports.LiteratureType_func = exports.LiteratureType_GetNameByLiteratureTypeId_Cache = exports.LiteratureType_UpdateObjInLst_Cache = exports.LiteratureType_GetObjByLiteratureTypeId_localStorage = exports.LiteratureType_GetObjByLiteratureTypeId_Cache = exports.LiteratureType_GetObjByLiteratureTypeIdAsync = exports.literatureType_ConstructorName = exports.literatureType_Controller = void 0;
    /**
     * 文献类型(LiteratureType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsLiteratureTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsLiteratureTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.literatureType_Controller = "LiteratureTypeApi";
    exports.literatureType_ConstructorName = "literatureType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strLiteratureTypeId:关键字
    * @returns 对象
    **/
    async function LiteratureType_GetObjByLiteratureTypeIdAsync(strLiteratureTypeId) {
        const strThisFuncName = "GetObjByLiteratureTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLiteratureTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLiteratureTypeId]不能为空！(In GetObjByLiteratureTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLiteratureTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByLiteratureTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strLiteratureTypeId": strLiteratureTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objLiteratureType = LiteratureType_GetObjFromJsonObj(returnObj);
                return objLiteratureType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetObjByLiteratureTypeIdAsync = LiteratureType_GetObjByLiteratureTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strLiteratureTypeId:所给的关键字
     * @returns 对象
    */
    async function LiteratureType_GetObjByLiteratureTypeId_Cache(strLiteratureTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByLiteratureTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLiteratureTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLiteratureTypeId]不能为空！(In GetObjByLiteratureTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLiteratureTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        try {
            const arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache.filter(x => x.literatureTypeId == strLiteratureTypeId);
            let objLiteratureType;
            if (arrLiteratureType_Sel.length > 0) {
                objLiteratureType = arrLiteratureType_Sel[0];
                return objLiteratureType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objLiteratureType = await LiteratureType_GetObjByLiteratureTypeIdAsync(strLiteratureTypeId);
                    if (objLiteratureType != null) {
                        LiteratureType_ReFreshThisCache();
                        return objLiteratureType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLiteratureTypeId, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.LiteratureType_GetObjByLiteratureTypeId_Cache = LiteratureType_GetObjByLiteratureTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strLiteratureTypeId:所给的关键字
     * @returns 对象
    */
    async function LiteratureType_GetObjByLiteratureTypeId_localStorage(strLiteratureTypeId) {
        const strThisFuncName = "GetObjByLiteratureTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLiteratureTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLiteratureTypeId]不能为空！(In GetObjByLiteratureTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLiteratureTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName, strLiteratureTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objLiteratureType_Cache = JSON.parse(strTempObj);
            return objLiteratureType_Cache;
        }
        try {
            const objLiteratureType = await LiteratureType_GetObjByLiteratureTypeIdAsync(strLiteratureTypeId);
            if (objLiteratureType != null) {
                localStorage.setItem(strKey, JSON.stringify(objLiteratureType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objLiteratureType;
            }
            return objLiteratureType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strLiteratureTypeId, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.LiteratureType_GetObjByLiteratureTypeId_localStorage = LiteratureType_GetObjByLiteratureTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objLiteratureType:所给的对象
     * @returns 对象
    */
    async function LiteratureType_UpdateObjInLst_Cache(objLiteratureType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
            const obj = arrLiteratureTypeObjLst_Cache.find(x => x.literatureTypeId == objLiteratureType.literatureTypeId);
            if (obj != null) {
                objLiteratureType.literatureTypeId = obj.literatureTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objLiteratureType);
            }
            else {
                arrLiteratureTypeObjLst_Cache.push(objLiteratureType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.LiteratureType_UpdateObjInLst_Cache = LiteratureType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strLiteratureTypeId:所给的关键字
     * @returns 对象
    */
    async function LiteratureType_GetNameByLiteratureTypeId_Cache(strLiteratureTypeId) {
        const strThisFuncName = "GetNameByLiteratureTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strLiteratureTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strLiteratureTypeId]不能为空！(In GetNameByLiteratureTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strLiteratureTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strLiteratureTypeId]的长度:[{0}]不正确！", strLiteratureTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        if (arrLiteratureTypeObjLst_Cache == null)
            return "";
        try {
            const arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache.filter(x => x.literatureTypeId == strLiteratureTypeId);
            let objLiteratureType;
            if (arrLiteratureType_Sel.length > 0) {
                objLiteratureType = arrLiteratureType_Sel[0];
                return objLiteratureType.literatureTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strLiteratureTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.LiteratureType_GetNameByLiteratureTypeId_Cache = LiteratureType_GetNameByLiteratureTypeId_Cache;
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
    async function LiteratureType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strLiteratureTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objLiteratureType = await LiteratureType_GetObjByLiteratureTypeId_Cache(strLiteratureTypeId);
        if (objLiteratureType == null)
            return "";
        return objLiteratureType.GetFldValue(strOutFldName).toString();
    }
    exports.LiteratureType_func = LiteratureType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function LiteratureType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.literatureTypeId.localeCompare(b.literatureTypeId);
    }
    exports.LiteratureType_SortFun_Defa = LiteratureType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function LiteratureType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.literatureTypeName == b.literatureTypeName)
            return a.updUserId.localeCompare(b.updUserId);
        else
            return a.literatureTypeName.localeCompare(b.literatureTypeName);
    }
    exports.LiteratureType_SortFun_Defa_2Fld = LiteratureType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function LiteratureType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName:
                    return (a, b) => {
                        return a.literatureTypeName.localeCompare(b.literatureTypeName);
                    };
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[LiteratureType]中不存在！(in ${exports.literatureType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId:
                    return (a, b) => {
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName:
                    return (a, b) => {
                        return b.literatureTypeName.localeCompare(a.literatureTypeName);
                    };
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[LiteratureType]中不存在！(in ${exports.literatureType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.LiteratureType_SortFunByKey = LiteratureType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function LiteratureType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName:
                return (obj) => {
                    return obj.literatureTypeName === value;
                };
            case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[LiteratureType]中不存在！(in ${exports.literatureType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.LiteratureType_FilterFunByKey = LiteratureType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function LiteratureType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetFirstIDAsync = LiteratureType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function LiteratureType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetFirstID = LiteratureType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function LiteratureType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objLiteratureType = LiteratureType_GetObjFromJsonObj(returnObj);
                return objLiteratureType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetFirstObjAsync = LiteratureType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
        clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrLiteratureTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrLiteratureTypeObjLst_T = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeExObjLst_Cache);
            return arrLiteratureTypeObjLst_T;
        }
        try {
            const arrLiteratureTypeExObjLst = await LiteratureType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrLiteratureTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLiteratureTypeExObjLst.length);
            console.log(strInfo);
            return arrLiteratureTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.LiteratureType_GetObjLst_ClientCache = LiteratureType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
        clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrLiteratureTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrLiteratureTypeObjLst_T = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeExObjLst_Cache);
            return arrLiteratureTypeObjLst_T;
        }
        try {
            const arrLiteratureTypeExObjLst = await LiteratureType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrLiteratureTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLiteratureTypeExObjLst.length);
            console.log(strInfo);
            return arrLiteratureTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.LiteratureType_GetObjLst_localStorage = LiteratureType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrLiteratureTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrLiteratureTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.LiteratureType_GetObjLst_localStorage_PureCache = LiteratureType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function LiteratureType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetObjLstAsync = LiteratureType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
        clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrLiteratureTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrLiteratureTypeObjLst_T = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeExObjLst_Cache);
            return arrLiteratureTypeObjLst_T;
        }
        try {
            const arrLiteratureTypeExObjLst = await LiteratureType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrLiteratureTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrLiteratureTypeExObjLst.length);
            console.log(strInfo);
            return arrLiteratureTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.LiteratureType_GetObjLst_sessionStorage = LiteratureType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrLiteratureTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrLiteratureTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.LiteratureType_GetObjLst_sessionStorage_PureCache = LiteratureType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrLiteratureTypeObjLst_Cache;
        switch (clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_ClientCache();
                break;
            default:
                arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_ClientCache();
                break;
        }
        const arrLiteratureTypeObjLst = LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeObjLst_Cache);
        return arrLiteratureTypeObjLst_Cache;
    }
    exports.LiteratureType_GetObjLst_Cache = LiteratureType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function LiteratureType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrLiteratureTypeObjLst_Cache;
        switch (clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrLiteratureTypeObjLst_Cache = null;
                break;
            default:
                arrLiteratureTypeObjLst_Cache = null;
                break;
        }
        return arrLiteratureTypeObjLst_Cache;
    }
    exports.LiteratureType_GetObjLst_PureCache = LiteratureType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrLiteratureTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function LiteratureType_GetSubObjLst_Cache(objLiteratureType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        let arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache;
        if (objLiteratureType_Cond.sf_FldComparisonOp == null || objLiteratureType_Cond.sf_FldComparisonOp == "")
            return arrLiteratureType_Sel;
        const dicFldComparisonOp = JSON.parse(objLiteratureType_Cond.sf_FldComparisonOp);
        //console.log("clsLiteratureTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objLiteratureType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLiteratureType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrLiteratureType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objLiteratureType_Cond), exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.LiteratureType_GetSubObjLst_Cache = LiteratureType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrLiteratureTypeId:关键字列表
    * @returns 对象列表
    **/
    async function LiteratureType_GetObjLstByLiteratureTypeIdLstAsync(arrLiteratureTypeId) {
        const strThisFuncName = "GetObjLstByLiteratureTypeIdLstAsync";
        const strAction = "GetObjLstByLiteratureTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLiteratureTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetObjLstByLiteratureTypeIdLstAsync = LiteratureType_GetObjLstByLiteratureTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrLiteratureTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function LiteratureType_GetObjLstByLiteratureTypeIdLst_Cache(arrLiteratureTypeIdLst) {
        const strThisFuncName = "GetObjLstByLiteratureTypeIdLst_Cache";
        try {
            const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
            const arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache.filter(x => arrLiteratureTypeIdLst.indexOf(x.literatureTypeId) > -1);
            return arrLiteratureType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrLiteratureTypeIdLst.join(","), exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.LiteratureType_GetObjLstByLiteratureTypeIdLst_Cache = LiteratureType_GetObjLstByLiteratureTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function LiteratureType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetTopObjLstAsync = LiteratureType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function LiteratureType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetObjLstByRangeAsync = LiteratureType_GetObjLstByRangeAsync;
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
    async function LiteratureType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetObjLstByRange = LiteratureType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function LiteratureType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        if (arrLiteratureTypeObjLst_Cache.length == 0)
            return arrLiteratureTypeObjLst_Cache;
        let arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objLiteratureType_Cond = new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objLiteratureType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsLiteratureTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLiteratureType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrLiteratureType_Sel.length == 0)
                return arrLiteratureType_Sel;
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
                arrLiteratureType_Sel = arrLiteratureType_Sel.sort(LiteratureType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrLiteratureType_Sel = arrLiteratureType_Sel.sort(objPagerPara.sortFun);
            }
            arrLiteratureType_Sel = arrLiteratureType_Sel.slice(intStart, intEnd);
            return arrLiteratureType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.LiteratureType_GetObjLstByPager_Cache = LiteratureType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function LiteratureType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.literatureType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = LiteratureType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetObjLstByPagerAsync = LiteratureType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strLiteratureTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function LiteratureType_DelRecordAsync(strLiteratureTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strLiteratureTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strLiteratureTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_DelRecordAsync = LiteratureType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrLiteratureTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function LiteratureType_DelLiteratureTypesAsync(arrLiteratureTypeId) {
        const strThisFuncName = "DelLiteratureTypesAsync";
        const strAction = "DelLiteratureTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrLiteratureTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_DelLiteratureTypesAsync = LiteratureType_DelLiteratureTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function LiteratureType_DelLiteratureTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelLiteratureTypesByCondAsync";
        const strAction = "DelLiteratureTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_DelLiteratureTypesByCondAsync = LiteratureType_DelLiteratureTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objLiteratureTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function LiteratureType_AddNewRecordAsync(objLiteratureTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objLiteratureTypeEN.literatureTypeId === null || objLiteratureTypeEN.literatureTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objLiteratureTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLiteratureTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_AddNewRecordAsync = LiteratureType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objLiteratureTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function LiteratureType_AddNewRecordWithMaxIdAsync(objLiteratureTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLiteratureTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_AddNewRecordWithMaxIdAsync = LiteratureType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objLiteratureTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function LiteratureType_AddNewRecordWithReturnKeyAsync(objLiteratureTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLiteratureTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_AddNewRecordWithReturnKeyAsync = LiteratureType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objLiteratureTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function LiteratureType_AddNewRecordWithReturnKey(objLiteratureTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objLiteratureTypeEN.literatureTypeId === null || objLiteratureTypeEN.literatureTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLiteratureTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_AddNewRecordWithReturnKey = LiteratureType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objLiteratureTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function LiteratureType_UpdateRecordAsync(objLiteratureTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objLiteratureTypeEN.sf_UpdFldSetStr === undefined || objLiteratureTypeEN.sf_UpdFldSetStr === null || objLiteratureTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLiteratureTypeEN.literatureTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objLiteratureTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_UpdateRecordAsync = LiteratureType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objLiteratureTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function LiteratureType_UpdateWithConditionAsync(objLiteratureTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objLiteratureTypeEN.sf_UpdFldSetStr === undefined || objLiteratureTypeEN.sf_UpdFldSetStr === null || objLiteratureTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objLiteratureTypeEN.literatureTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        objLiteratureTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objLiteratureTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_UpdateWithConditionAsync = LiteratureType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrLiteratureTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function LiteratureType_IsExistRecord_Cache(objLiteratureType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        if (arrLiteratureTypeObjLst_Cache == null)
            return false;
        let arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache;
        if (objLiteratureType_Cond.sf_FldComparisonOp == null || objLiteratureType_Cond.sf_FldComparisonOp == "")
            return arrLiteratureType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objLiteratureType_Cond.sf_FldComparisonOp);
        //console.log("clsLiteratureTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objLiteratureType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLiteratureType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrLiteratureType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objLiteratureType_Cond), exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.LiteratureType_IsExistRecord_Cache = LiteratureType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function LiteratureType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_IsExistRecordAsync = LiteratureType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strLiteratureTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function LiteratureType_IsExist(strLiteratureTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "LiteratureTypeId": strLiteratureTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_IsExist = LiteratureType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strLiteratureTypeId:所给的关键字
     * @returns 对象
    */
    async function LiteratureType_IsExist_Cache(strLiteratureTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        if (arrLiteratureTypeObjLst_Cache == null)
            return false;
        try {
            const arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache.filter(x => x.literatureTypeId == strLiteratureTypeId);
            if (arrLiteratureType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strLiteratureTypeId, exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.LiteratureType_IsExist_Cache = LiteratureType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strLiteratureTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function LiteratureType_IsExistAsync(strLiteratureTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strLiteratureTypeId": strLiteratureTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_IsExistAsync = LiteratureType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function LiteratureType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetRecCountByCondAsync = LiteratureType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objLiteratureType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function LiteratureType_GetRecCountByCond_Cache(objLiteratureType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrLiteratureTypeObjLst_Cache = await LiteratureType_GetObjLst_Cache();
        if (arrLiteratureTypeObjLst_Cache == null)
            return 0;
        let arrLiteratureType_Sel = arrLiteratureTypeObjLst_Cache;
        if (objLiteratureType_Cond.sf_FldComparisonOp == null || objLiteratureType_Cond.sf_FldComparisonOp == "")
            return arrLiteratureType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objLiteratureType_Cond.sf_FldComparisonOp);
        //console.log("clsLiteratureTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objLiteratureType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objLiteratureType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrLiteratureType_Sel = arrLiteratureType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrLiteratureType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objLiteratureType_Cond), exports.literatureType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.LiteratureType_GetRecCountByCond_Cache = LiteratureType_GetRecCountByCond_Cache;
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
    async function LiteratureType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.literatureType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.literatureType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.LiteratureType_GetMaxStrIdByPrefix = LiteratureType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function LiteratureType_GetWebApiUrl(strController, strAction) {
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
    exports.LiteratureType_GetWebApiUrl = LiteratureType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function LiteratureType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
        switch (clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheModeId) {
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
    exports.LiteratureType_ReFreshCache = LiteratureType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function LiteratureType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsLiteratureTypeEN_js_1.clsLiteratureTypeEN._CurrTabName;
            switch (clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.CacheModeId) {
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
    exports.LiteratureType_ReFreshThisCache = LiteratureType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function LiteratureType__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await LiteratureType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, "文献类型");
    }
    exports.LiteratureType__Cache = LiteratureType__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function LiteratureType_CheckPropertyNew(pobjLiteratureTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.literatureTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeId)(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.literatureTypeName) > 100) {
            throw new Error("(errid:Watl000059)字段[作文类型名(literatureTypeName)]的长度不能超过100(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeName)(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updUserId)(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updDate)(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeId) == false && undefined !== pobjLiteratureTypeEN.literatureTypeId && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.literatureTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[作文类型Id(literatureTypeId)]的值:[$(pobjLiteratureTypeEN.literatureTypeId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeName) == false && undefined !== pobjLiteratureTypeEN.literatureTypeName && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.literatureTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[作文类型名(literatureTypeName)]的值:[$(pobjLiteratureTypeEN.literatureTypeName)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updUserId) == false && undefined !== pobjLiteratureTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjLiteratureTypeEN.updUserId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updDate) == false && undefined !== pobjLiteratureTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjLiteratureTypeEN.updDate)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjLiteratureTypeEN.SetIsCheckProperty(true);
    }
    exports.LiteratureType_CheckPropertyNew = LiteratureType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function LiteratureType_CheckProperty4Update(pobjLiteratureTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.literatureTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[作文类型Id(literatureTypeId)]的长度不能超过2(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeId)(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.literatureTypeName) > 100) {
            throw new Error("(errid:Watl000062)字段[作文类型名(literatureTypeName)]的长度不能超过100(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.literatureTypeName)(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updUserId)(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjLiteratureTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 文献类型(LiteratureType))!值:$(pobjLiteratureTypeEN.updDate)(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeId) == false && undefined !== pobjLiteratureTypeEN.literatureTypeId && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.literatureTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[作文类型Id(literatureTypeId)]的值:[$(pobjLiteratureTypeEN.literatureTypeId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeName) == false && undefined !== pobjLiteratureTypeEN.literatureTypeName && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.literatureTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[作文类型名(literatureTypeName)]的值:[$(pobjLiteratureTypeEN.literatureTypeName)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updUserId) == false && undefined !== pobjLiteratureTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjLiteratureTypeEN.updUserId)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.updDate) == false && undefined !== pobjLiteratureTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjLiteratureTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjLiteratureTypeEN.updDate)], 非法，应该为字符型(In 文献类型(LiteratureType))!(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjLiteratureTypeEN.literatureTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[作文类型Id]不能为空(In 文献类型)!(clsLiteratureTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjLiteratureTypeEN.SetIsCheckProperty(true);
    }
    exports.LiteratureType_CheckProperty4Update = LiteratureType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function LiteratureType_GetJSONStrByObj(pobjLiteratureTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjLiteratureTypeEN.sf_UpdFldSetStr = pobjLiteratureTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjLiteratureTypeEN);
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
    exports.LiteratureType_GetJSONStrByObj = LiteratureType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function LiteratureType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrLiteratureTypeObjLst = new Array();
        if (strJSON === "") {
            return arrLiteratureTypeObjLst;
        }
        try {
            arrLiteratureTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrLiteratureTypeObjLst;
        }
        return arrLiteratureTypeObjLst;
    }
    exports.LiteratureType_GetObjLstByJSONStr = LiteratureType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrLiteratureTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function LiteratureType_GetObjLstByJSONObjLst(arrLiteratureTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrLiteratureTypeObjLst = new Array();
        for (const objInFor of arrLiteratureTypeObjLstS) {
            const obj1 = LiteratureType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrLiteratureTypeObjLst.push(obj1);
        }
        return arrLiteratureTypeObjLst;
    }
    exports.LiteratureType_GetObjLstByJSONObjLst = LiteratureType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function LiteratureType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjLiteratureTypeEN = new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN();
        if (strJSON === "") {
            return pobjLiteratureTypeEN;
        }
        try {
            pobjLiteratureTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjLiteratureTypeEN;
        }
        return pobjLiteratureTypeEN;
    }
    exports.LiteratureType_GetObjByJSONStr = LiteratureType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function LiteratureType_GetCombineCondition(objLiteratureType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeId, objLiteratureType_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName) == true) {
            const strComparisonOp_LiteratureTypeName = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_LiteratureTypeName, objLiteratureType_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdUserId, objLiteratureType_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objLiteratureType_Cond.dicFldComparisonOp, clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objLiteratureType_Cond.dicFldComparisonOp[clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsLiteratureTypeEN_js_1.clsLiteratureTypeEN.con_UpdDate, objLiteratureType_Cond.updDate, strComparisonOp_UpdDate);
        }
        return strWhereCond;
    }
    exports.LiteratureType_GetCombineCondition = LiteratureType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objLiteratureTypeENS:源对象
     * @param objLiteratureTypeENT:目标对象
    */
    function LiteratureType_CopyObjTo(objLiteratureTypeENS, objLiteratureTypeENT) {
        objLiteratureTypeENT.literatureTypeId = objLiteratureTypeENS.literatureTypeId; //作文类型Id
        objLiteratureTypeENT.literatureTypeName = objLiteratureTypeENS.literatureTypeName; //作文类型名
        objLiteratureTypeENT.updUserId = objLiteratureTypeENS.updUserId; //修改用户Id
        objLiteratureTypeENT.updDate = objLiteratureTypeENS.updDate; //修改日期
        objLiteratureTypeENT.sf_UpdFldSetStr = objLiteratureTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.LiteratureType_CopyObjTo = LiteratureType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objLiteratureTypeENS:源对象
     * @param objLiteratureTypeENT:目标对象
    */
    function LiteratureType_GetObjFromJsonObj(objLiteratureTypeENS) {
        const objLiteratureTypeENT = new clsLiteratureTypeEN_js_1.clsLiteratureTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objLiteratureTypeENT, objLiteratureTypeENS);
        return objLiteratureTypeENT;
    }
    exports.LiteratureType_GetObjFromJsonObj = LiteratureType_GetObjFromJsonObj;
});
