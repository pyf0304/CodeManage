/**
* 类名:clsViewpointTypeWApi
* 表名:ViewpointType(01120544)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:45
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsViewpointTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.ViewpointType_GetObjFromJsonObj = exports.ViewpointType_CopyObjTo = exports.ViewpointType_GetUniCondStr4Update_ViewpointTypeName = exports.ViewpointType_GetUniCondStr_ViewpointTypeName = exports.ViewpointType_GetCombineCondition = exports.ViewpointType_GetObjByJSONStr = exports.ViewpointType_GetObjLstByJSONObjLst = exports.ViewpointType_GetObjLstByJSONStr = exports.ViewpointType_GetJSONStrByObj = exports.ViewpointType_CheckProperty4Update = exports.ViewpointType_CheckPropertyNew = exports.ViewpointType_BindDdl_ViewpointTypeIdInDiv_Cache = exports.ViewpointType_ReFreshThisCache = exports.ViewpointType_ReFreshCache = exports.ViewpointType_GetWebApiUrl = exports.ViewpointType_GetMaxStrIdByPrefix = exports.ViewpointType_GetMaxStrIdAsync = exports.ViewpointType_GetRecCountByCond_Cache = exports.ViewpointType_GetRecCountByCondAsync = exports.ViewpointType_IsExistAsync = exports.ViewpointType_IsExist_Cache = exports.ViewpointType_IsExist = exports.ViewpointType_IsExistRecordAsync = exports.ViewpointType_IsExistRecord_Cache = exports.ViewpointType_UpdateWithConditionAsync = exports.ViewpointType_UpdateRecordAsync = exports.ViewpointType_AddNewRecordWithReturnKey = exports.ViewpointType_AddNewRecordWithReturnKeyAsync = exports.ViewpointType_AddNewRecordWithMaxIdAsync = exports.ViewpointType_AddNewRecordAsync = exports.ViewpointType_DelViewpointTypesByCondAsync = exports.ViewpointType_DelViewpointTypesAsync = exports.ViewpointType_DelRecordAsync = exports.ViewpointType_GetObjLstByPagerAsync = exports.ViewpointType_GetObjLstByPager_Cache = exports.ViewpointType_GetObjLstByRange = exports.ViewpointType_GetObjLstByRangeAsync = exports.ViewpointType_GetTopObjLstAsync = exports.ViewpointType_GetObjLstByViewpointTypeIdLst_Cache = exports.ViewpointType_GetObjLstByViewpointTypeIdLstAsync = exports.ViewpointType_GetSubObjLst_Cache = exports.ViewpointType_GetObjLst_PureCache = exports.ViewpointType_GetObjLst_Cache = exports.ViewpointType_GetObjLst_sessionStorage_PureCache = exports.ViewpointType_GetObjLst_sessionStorage = exports.ViewpointType_GetObjLstAsync = exports.ViewpointType_GetObjLst_localStorage_PureCache = exports.ViewpointType_GetObjLst_localStorage = exports.ViewpointType_GetObjLst_ClientCache = exports.ViewpointType_GetFirstObjAsync = exports.ViewpointType_GetFirstID = exports.ViewpointType_GetFirstIDAsync = exports.ViewpointType_funcKey = exports.ViewpointType_FilterFunByKey = exports.ViewpointType_SortFunByKey = exports.ViewpointType_SortFun_Defa_2Fld = exports.ViewpointType_SortFun_Defa = exports.ViewpointType_func = exports.ViewpointType_GetNameByViewpointTypeId_Cache = exports.ViewpointType_UpdateObjInLst_Cache = exports.ViewpointType_GetObjByViewpointTypeId_localStorage = exports.ViewpointType_GetObjByViewpointTypeId_Cache = exports.ViewpointType_GetObjByViewpointTypeIdAsync = exports.viewpointType_ConstructorName = exports.viewpointType_Controller = void 0;
    /**
     * 观点类型(ViewpointType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsViewpointTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsViewpointTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.viewpointType_Controller = "ViewpointTypeApi";
    exports.viewpointType_ConstructorName = "viewpointType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strViewpointTypeId:关键字
    * @returns 对象
    **/
    async function ViewpointType_GetObjByViewpointTypeIdAsync(strViewpointTypeId) {
        const strThisFuncName = "GetObjByViewpointTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strViewpointTypeId]不能为空！(In clsViewpointTypeWApi.GetObjByViewpointTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strViewpointTypeId]的长度:[{0}]不正确！(clsViewpointTypeWApi.GetObjByViewpointTypeIdAsync)", strViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByViewpointTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strViewpointTypeId": strViewpointTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objViewpointType = ViewpointType_GetObjFromJsonObj(returnObj);
                return objViewpointType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetObjByViewpointTypeIdAsync = ViewpointType_GetObjByViewpointTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function ViewpointType_GetObjByViewpointTypeId_Cache(strViewpointTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByViewpointTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strViewpointTypeId]不能为空！(In clsViewpointTypeWApi.GetObjByViewpointTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strViewpointTypeId]的长度:[{0}]不正确！(clsViewpointTypeWApi.GetObjByViewpointTypeId_Cache)", strViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        try {
            const arrViewpointType_Sel = arrViewpointTypeObjLst_Cache.filter(x => x.viewpointTypeId == strViewpointTypeId);
            let objViewpointType;
            if (arrViewpointType_Sel.length > 0) {
                objViewpointType = arrViewpointType_Sel[0];
                return objViewpointType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objViewpointType_Const = await ViewpointType_GetObjByViewpointTypeIdAsync(strViewpointTypeId);
                    if (objViewpointType_Const != null) {
                        ViewpointType_ReFreshThisCache();
                        return objViewpointType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strViewpointTypeId, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.ViewpointType_GetObjByViewpointTypeId_Cache = ViewpointType_GetObjByViewpointTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function ViewpointType_GetObjByViewpointTypeId_localStorage(strViewpointTypeId) {
        const strThisFuncName = "GetObjByViewpointTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strViewpointTypeId]不能为空！(In clsViewpointTypeWApi.GetObjByViewpointTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strViewpointTypeId]的长度:[{0}]不正确！(clsViewpointTypeWApi.GetObjByViewpointTypeId_localStorage)", strViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName, strViewpointTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objViewpointType_Cache = JSON.parse(strTempObj);
            return objViewpointType_Cache;
        }
        try {
            const objViewpointType = await ViewpointType_GetObjByViewpointTypeIdAsync(strViewpointTypeId);
            if (objViewpointType != null) {
                localStorage.setItem(strKey, JSON.stringify(objViewpointType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objViewpointType;
            }
            return objViewpointType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strViewpointTypeId, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.ViewpointType_GetObjByViewpointTypeId_localStorage = ViewpointType_GetObjByViewpointTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objViewpointType:所给的对象
     * @returns 对象
    */
    async function ViewpointType_UpdateObjInLst_Cache(objViewpointType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
            const obj = arrViewpointTypeObjLst_Cache.find(x => x.viewpointTypeName == objViewpointType.viewpointTypeName);
            if (obj != null) {
                objViewpointType.viewpointTypeId = obj.viewpointTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objViewpointType);
            }
            else {
                arrViewpointTypeObjLst_Cache.push(objViewpointType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.ViewpointType_UpdateObjInLst_Cache = ViewpointType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function ViewpointType_GetNameByViewpointTypeId_Cache(strViewpointTypeId) {
        const strThisFuncName = "GetNameByViewpointTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strViewpointTypeId]不能为空！(In clsViewpointTypeWApi.GetNameByViewpointTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strViewpointTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strViewpointTypeId]的长度:[{0}]不正确！(clsViewpointTypeWApi.GetNameByViewpointTypeId_Cache)", strViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        if (arrViewpointTypeObjLst_Cache == null)
            return "";
        try {
            const arrViewpointType_Sel = arrViewpointTypeObjLst_Cache.filter(x => x.viewpointTypeId == strViewpointTypeId);
            let objViewpointType;
            if (arrViewpointType_Sel.length > 0) {
                objViewpointType = arrViewpointType_Sel[0];
                return objViewpointType.viewpointTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strViewpointTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.ViewpointType_GetNameByViewpointTypeId_Cache = ViewpointType_GetNameByViewpointTypeId_Cache;
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
    async function ViewpointType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsViewpointTypeEN_js_1.clsViewpointTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsViewpointTypeEN_js_1.clsViewpointTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strViewpointTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objViewpointType = await ViewpointType_GetObjByViewpointTypeId_Cache(strViewpointTypeId);
        if (objViewpointType == null)
            return "";
        if (objViewpointType.GetFldValue(strOutFldName) == null)
            return "";
        return objViewpointType.GetFldValue(strOutFldName).toString();
    }
    exports.ViewpointType_func = ViewpointType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
    }
    exports.ViewpointType_SortFun_Defa = ViewpointType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.viewpointTypeName == b.viewpointTypeName)
            return a.memo.localeCompare(b.memo);
        else
            return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
    }
    exports.ViewpointType_SortFun_Defa_2Fld = ViewpointType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function ViewpointType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return a.viewpointTypeId.localeCompare(b.viewpointTypeId);
                    };
                case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName:
                    return (a, b) => {
                        if (a.viewpointTypeName == null)
                            return -1;
                        if (b.viewpointTypeName == null)
                            return 1;
                        return a.viewpointTypeName.localeCompare(b.viewpointTypeName);
                    };
                case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointType]中不存在！(in ${exports.viewpointType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId:
                    return (a, b) => {
                        return b.viewpointTypeId.localeCompare(a.viewpointTypeId);
                    };
                case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName:
                    return (a, b) => {
                        if (b.viewpointTypeName == null)
                            return -1;
                        if (a.viewpointTypeName == null)
                            return 1;
                        return b.viewpointTypeName.localeCompare(a.viewpointTypeName);
                    };
                case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[ViewpointType]中不存在！(in ${exports.viewpointType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.ViewpointType_SortFunByKey = ViewpointType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function ViewpointType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId:
                return (obj) => {
                    return obj.viewpointTypeId === value;
                };
            case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName:
                return (obj) => {
                    return obj.viewpointTypeName === value;
                };
            case clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[ViewpointType]中不存在！(in ${exports.viewpointType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.ViewpointType_FilterFunByKey = ViewpointType_FilterFunByKey;
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
    async function ViewpointType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrViewpointType = await ViewpointType_GetObjLst_Cache();
        if (arrViewpointType == null)
            return [];
        let arrViewpointType_Sel = arrViewpointType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrViewpointType_Sel.length == 0)
            return [];
        return arrViewpointType_Sel.map(x => x.viewpointTypeId);
    }
    exports.ViewpointType_funcKey = ViewpointType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetFirstIDAsync = ViewpointType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function ViewpointType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetFirstID = ViewpointType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function ViewpointType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const objViewpointType = ViewpointType_GetObjFromJsonObj(returnObj);
                return objViewpointType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetFirstObjAsync = ViewpointType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrViewpointTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrViewpointTypeObjLst_T = ViewpointType_GetObjLstByJSONObjLst(arrViewpointTypeExObjLst_Cache);
            return arrViewpointTypeObjLst_T;
        }
        try {
            const arrViewpointTypeExObjLst = await ViewpointType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrViewpointTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointTypeExObjLst.length);
            console.log(strInfo);
            return arrViewpointTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointType_GetObjLst_ClientCache = ViewpointType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointTypeObjLst_T = ViewpointType_GetObjLstByJSONObjLst(arrViewpointTypeExObjLst_Cache);
            return arrViewpointTypeObjLst_T;
        }
        try {
            const arrViewpointTypeExObjLst = await ViewpointType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrViewpointTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointTypeExObjLst.length);
            console.log(strInfo);
            return arrViewpointTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointType_GetObjLst_localStorage = ViewpointType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrViewpointTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointType_GetObjLst_localStorage_PureCache = ViewpointType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function ViewpointType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetObjLstAsync = ViewpointType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrViewpointTypeObjLst_T = ViewpointType_GetObjLstByJSONObjLst(arrViewpointTypeExObjLst_Cache);
            return arrViewpointTypeObjLst_T;
        }
        try {
            const arrViewpointTypeExObjLst = await ViewpointType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrViewpointTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrViewpointTypeExObjLst.length);
            console.log(strInfo);
            return arrViewpointTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.ViewpointType_GetObjLst_sessionStorage = ViewpointType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrViewpointTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrViewpointTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.ViewpointType_GetObjLst_sessionStorage_PureCache = ViewpointType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrViewpointTypeObjLst_Cache;
        switch (clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_ClientCache();
                break;
            default:
                arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_ClientCache();
                break;
        }
        const arrViewpointTypeObjLst = ViewpointType_GetObjLstByJSONObjLst(arrViewpointTypeObjLst_Cache);
        return arrViewpointTypeObjLst_Cache;
    }
    exports.ViewpointType_GetObjLst_Cache = ViewpointType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function ViewpointType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrViewpointTypeObjLst_Cache;
        switch (clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrViewpointTypeObjLst_Cache = null;
                break;
            default:
                arrViewpointTypeObjLst_Cache = null;
                break;
        }
        return arrViewpointTypeObjLst_Cache;
    }
    exports.ViewpointType_GetObjLst_PureCache = ViewpointType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrViewpointTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointType_GetSubObjLst_Cache(objViewpointType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        let arrViewpointType_Sel = arrViewpointTypeObjLst_Cache;
        if (objViewpointType_Cond.sf_FldComparisonOp == null || objViewpointType_Cond.sf_FldComparisonOp == "")
            return arrViewpointType_Sel;
        const dicFldComparisonOp = JSON.parse(objViewpointType_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objViewpointType_Cond), exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointType_GetSubObjLst_Cache = ViewpointType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrViewpointTypeId:关键字列表
    * @returns 对象列表
    **/
    async function ViewpointType_GetObjLstByViewpointTypeIdLstAsync(arrViewpointTypeId) {
        const strThisFuncName = "GetObjLstByViewpointTypeIdLstAsync";
        const strAction = "GetObjLstByViewpointTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetObjLstByViewpointTypeIdLstAsync = ViewpointType_GetObjLstByViewpointTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrViewpointTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function ViewpointType_GetObjLstByViewpointTypeIdLst_Cache(arrViewpointTypeIdLst) {
        const strThisFuncName = "GetObjLstByViewpointTypeIdLst_Cache";
        try {
            const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
            const arrViewpointType_Sel = arrViewpointTypeObjLst_Cache.filter(x => arrViewpointTypeIdLst.indexOf(x.viewpointTypeId) > -1);
            return arrViewpointType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrViewpointTypeIdLst.join(","), exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.ViewpointType_GetObjLstByViewpointTypeIdLst_Cache = ViewpointType_GetObjLstByViewpointTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function ViewpointType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetTopObjLstAsync = ViewpointType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetObjLstByRangeAsync = ViewpointType_GetObjLstByRangeAsync;
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
    async function ViewpointType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetObjLstByRange = ViewpointType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function ViewpointType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        if (arrViewpointTypeObjLst_Cache.length == 0)
            return arrViewpointTypeObjLst_Cache;
        let arrViewpointType_Sel = arrViewpointTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objViewpointType_Cond = new clsViewpointTypeEN_js_1.clsViewpointTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsViewpointTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointType_Sel.length == 0)
                return arrViewpointType_Sel;
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
                arrViewpointType_Sel = arrViewpointType_Sel.sort(ViewpointType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrViewpointType_Sel = arrViewpointType_Sel.sort(objPagerPara.sortFun);
            }
            arrViewpointType_Sel = arrViewpointType_Sel.slice(intStart, intEnd);
            return arrViewpointType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.ViewpointType_GetObjLstByPager_Cache = ViewpointType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function ViewpointType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.viewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = ViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetObjLstByPagerAsync = ViewpointType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strViewpointTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function ViewpointType_DelRecordAsync(strViewpointTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strViewpointTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_DelRecordAsync = ViewpointType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrViewpointTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function ViewpointType_DelViewpointTypesAsync(arrViewpointTypeId) {
        const strThisFuncName = "DelViewpointTypesAsync";
        const strAction = "DelViewpointTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrViewpointTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_DelViewpointTypesAsync = ViewpointType_DelViewpointTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function ViewpointType_DelViewpointTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelViewpointTypesByCondAsync";
        const strAction = "DelViewpointTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_DelViewpointTypesByCondAsync = ViewpointType_DelViewpointTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointType_AddNewRecordAsync(objViewpointTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objViewpointTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_AddNewRecordAsync = ViewpointType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function ViewpointType_AddNewRecordWithMaxIdAsync(objViewpointTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_AddNewRecordWithMaxIdAsync = ViewpointType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objViewpointTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function ViewpointType_AddNewRecordWithReturnKeyAsync(objViewpointTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_AddNewRecordWithReturnKeyAsync = ViewpointType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objViewpointTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function ViewpointType_AddNewRecordWithReturnKey(objViewpointTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objViewpointTypeEN.viewpointTypeId === null || objViewpointTypeEN.viewpointTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_AddNewRecordWithReturnKey = ViewpointType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objViewpointTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function ViewpointType_UpdateRecordAsync(objViewpointTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objViewpointTypeEN.sf_UpdFldSetStr === undefined || objViewpointTypeEN.sf_UpdFldSetStr === null || objViewpointTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointTypeEN.viewpointTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_UpdateRecordAsync = ViewpointType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objViewpointTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function ViewpointType_UpdateWithConditionAsync(objViewpointTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objViewpointTypeEN.sf_UpdFldSetStr === undefined || objViewpointTypeEN.sf_UpdFldSetStr === null || objViewpointTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objViewpointTypeEN.viewpointTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        objViewpointTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_UpdateWithConditionAsync = ViewpointType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrViewpointTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function ViewpointType_IsExistRecord_Cache(objViewpointType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        if (arrViewpointTypeObjLst_Cache == null)
            return false;
        let arrViewpointType_Sel = arrViewpointTypeObjLst_Cache;
        if (objViewpointType_Cond.sf_FldComparisonOp == null || objViewpointType_Cond.sf_FldComparisonOp == "")
            return arrViewpointType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objViewpointType_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrViewpointType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objViewpointType_Cond), exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.ViewpointType_IsExistRecord_Cache = ViewpointType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function ViewpointType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_IsExistRecordAsync = ViewpointType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strViewpointTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function ViewpointType_IsExist(strViewpointTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ViewpointTypeId": strViewpointTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_IsExist = ViewpointType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function ViewpointType_IsExist_Cache(strViewpointTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        if (arrViewpointTypeObjLst_Cache == null)
            return false;
        try {
            const arrViewpointType_Sel = arrViewpointTypeObjLst_Cache.filter(x => x.viewpointTypeId == strViewpointTypeId);
            if (arrViewpointType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strViewpointTypeId, exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.ViewpointType_IsExist_Cache = ViewpointType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strViewpointTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function ViewpointType_IsExistAsync(strViewpointTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strViewpointTypeId": strViewpointTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_IsExistAsync = ViewpointType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function ViewpointType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetRecCountByCondAsync = ViewpointType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objViewpointType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function ViewpointType_GetRecCountByCond_Cache(objViewpointType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrViewpointTypeObjLst_Cache = await ViewpointType_GetObjLst_Cache();
        if (arrViewpointTypeObjLst_Cache == null)
            return 0;
        let arrViewpointType_Sel = arrViewpointTypeObjLst_Cache;
        if (objViewpointType_Cond.sf_FldComparisonOp == null || objViewpointType_Cond.sf_FldComparisonOp == "")
            return arrViewpointType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objViewpointType_Cond.sf_FldComparisonOp);
        //console.log("clsViewpointTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objViewpointType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrViewpointType_Sel = arrViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrViewpointType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objViewpointType_Cond), exports.viewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.ViewpointType_GetRecCountByCond_Cache = ViewpointType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function ViewpointType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetMaxStrIdAsync = ViewpointType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function ViewpointType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.viewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.viewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.ViewpointType_GetMaxStrIdByPrefix = ViewpointType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function ViewpointType_GetWebApiUrl(strController, strAction) {
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
    exports.ViewpointType_GetWebApiUrl = ViewpointType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function ViewpointType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
        switch (clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheModeId) {
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
    exports.ViewpointType_ReFreshCache = ViewpointType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function ViewpointType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsViewpointTypeEN_js_1.clsViewpointTypeEN._CurrTabName;
            switch (clsViewpointTypeEN_js_1.clsViewpointTypeEN.CacheModeId) {
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
    exports.ViewpointType_ReFreshThisCache = ViewpointType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function ViewpointType_BindDdl_ViewpointTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_ViewpointTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_ViewpointTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_ViewpointTypeIdInDiv_Cache");
        const arrObjLst_Sel = await ViewpointType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName, "观点类型");
    }
    exports.ViewpointType_BindDdl_ViewpointTypeIdInDiv_Cache = ViewpointType_BindDdl_ViewpointTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointType_CheckPropertyNew(pobjViewpointTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointTypeEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点类型(ViewpointType))!值:$(pobjViewpointTypeEN.viewpointTypeId)(clsViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointTypeEN.viewpointTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[观点类型名(viewpointTypeName)]的长度不能超过50(In 观点类型(ViewpointType))!值:$(pobjViewpointTypeEN.viewpointTypeName)(clsViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 观点类型(ViewpointType))!值:$(pobjViewpointTypeEN.memo)(clsViewpointTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeId) == false && undefined !== pobjViewpointTypeEN.viewpointTypeId && clsString_js_1.tzDataType.isString(pobjViewpointTypeEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointTypeEN.viewpointTypeId)], 非法，应该为字符型(In 观点类型(ViewpointType))!(clsViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeName) == false && undefined !== pobjViewpointTypeEN.viewpointTypeName && clsString_js_1.tzDataType.isString(pobjViewpointTypeEN.viewpointTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[观点类型名(viewpointTypeName)]的值:[$(pobjViewpointTypeEN.viewpointTypeName)], 非法，应该为字符型(In 观点类型(ViewpointType))!(clsViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.memo) == false && undefined !== pobjViewpointTypeEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjViewpointTypeEN.memo)], 非法，应该为字符型(In 观点类型(ViewpointType))!(clsViewpointTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjViewpointTypeEN.SetIsCheckProperty(true);
    }
    exports.ViewpointType_CheckPropertyNew = ViewpointType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function ViewpointType_CheckProperty4Update(pobjViewpointTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointTypeEN.viewpointTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[观点类型Id(viewpointTypeId)]的长度不能超过4(In 观点类型(ViewpointType))!值:$(pobjViewpointTypeEN.viewpointTypeId)(clsViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointTypeEN.viewpointTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[观点类型名(viewpointTypeName)]的长度不能超过50(In 观点类型(ViewpointType))!值:$(pobjViewpointTypeEN.viewpointTypeName)(clsViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjViewpointTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 观点类型(ViewpointType))!值:$(pobjViewpointTypeEN.memo)(clsViewpointTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeId) == false && undefined !== pobjViewpointTypeEN.viewpointTypeId && clsString_js_1.tzDataType.isString(pobjViewpointTypeEN.viewpointTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[观点类型Id(viewpointTypeId)]的值:[$(pobjViewpointTypeEN.viewpointTypeId)], 非法，应该为字符型(In 观点类型(ViewpointType))!(clsViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeName) == false && undefined !== pobjViewpointTypeEN.viewpointTypeName && clsString_js_1.tzDataType.isString(pobjViewpointTypeEN.viewpointTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[观点类型名(viewpointTypeName)]的值:[$(pobjViewpointTypeEN.viewpointTypeName)], 非法，应该为字符型(In 观点类型(ViewpointType))!(clsViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.memo) == false && undefined !== pobjViewpointTypeEN.memo && clsString_js_1.tzDataType.isString(pobjViewpointTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjViewpointTypeEN.memo)], 非法，应该为字符型(In 观点类型(ViewpointType))!(clsViewpointTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjViewpointTypeEN.viewpointTypeId) === true
            || pobjViewpointTypeEN.viewpointTypeId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[观点类型Id]不能为空(In 观点类型)!(clsViewpointTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjViewpointTypeEN.SetIsCheckProperty(true);
    }
    exports.ViewpointType_CheckProperty4Update = ViewpointType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointType_GetJSONStrByObj(pobjViewpointTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjViewpointTypeEN.sf_UpdFldSetStr = pobjViewpointTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjViewpointTypeEN);
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
    exports.ViewpointType_GetJSONStrByObj = ViewpointType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function ViewpointType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrViewpointTypeObjLst = new Array();
        if (strJSON === "") {
            return arrViewpointTypeObjLst;
        }
        try {
            arrViewpointTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrViewpointTypeObjLst;
        }
        return arrViewpointTypeObjLst;
    }
    exports.ViewpointType_GetObjLstByJSONStr = ViewpointType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrViewpointTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function ViewpointType_GetObjLstByJSONObjLst(arrViewpointTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrViewpointTypeObjLst = new Array();
        for (const objInFor of arrViewpointTypeObjLstS) {
            const obj1 = ViewpointType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrViewpointTypeObjLst.push(obj1);
        }
        return arrViewpointTypeObjLst;
    }
    exports.ViewpointType_GetObjLstByJSONObjLst = ViewpointType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function ViewpointType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjViewpointTypeEN = new clsViewpointTypeEN_js_1.clsViewpointTypeEN();
        if (strJSON === "") {
            return pobjViewpointTypeEN;
        }
        try {
            pobjViewpointTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjViewpointTypeEN;
        }
        return pobjViewpointTypeEN;
    }
    exports.ViewpointType_GetObjByJSONStr = ViewpointType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function ViewpointType_GetCombineCondition(objViewpointType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objViewpointType_Cond.dicFldComparisonOp, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId) == true) {
            const strComparisonOp_ViewpointTypeId = objViewpointType_Cond.dicFldComparisonOp[clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeId, objViewpointType_Cond.viewpointTypeId, strComparisonOp_ViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointType_Cond.dicFldComparisonOp, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName) == true) {
            const strComparisonOp_ViewpointTypeName = objViewpointType_Cond.dicFldComparisonOp[clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_ViewpointTypeName, objViewpointType_Cond.viewpointTypeName, strComparisonOp_ViewpointTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objViewpointType_Cond.dicFldComparisonOp, clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objViewpointType_Cond.dicFldComparisonOp[clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsViewpointTypeEN_js_1.clsViewpointTypeEN.con_Memo, objViewpointType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.ViewpointType_GetCombineCondition = ViewpointType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointType(观点类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strViewpointTypeName: 观点类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointType_GetUniCondStr_ViewpointTypeName(objViewpointTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointTypeName = '{0}'", objViewpointTypeEN.viewpointTypeName);
        return strWhereCond;
    }
    exports.ViewpointType_GetUniCondStr_ViewpointTypeName = ViewpointType_GetUniCondStr_ViewpointTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--ViewpointType(观点类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strViewpointTypeName: 观点类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function ViewpointType_GetUniCondStr4Update_ViewpointTypeName(objViewpointTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointTypeId <> '{0}'", objViewpointTypeEN.viewpointTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and ViewpointTypeName = '{0}'", objViewpointTypeEN.viewpointTypeName);
        return strWhereCond;
    }
    exports.ViewpointType_GetUniCondStr4Update_ViewpointTypeName = ViewpointType_GetUniCondStr4Update_ViewpointTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objViewpointTypeENS:源对象
     * @param objViewpointTypeENT:目标对象
    */
    function ViewpointType_CopyObjTo(objViewpointTypeENS, objViewpointTypeENT) {
        objViewpointTypeENT.viewpointTypeId = objViewpointTypeENS.viewpointTypeId; //观点类型Id
        objViewpointTypeENT.viewpointTypeName = objViewpointTypeENS.viewpointTypeName; //观点类型名
        objViewpointTypeENT.memo = objViewpointTypeENS.memo; //备注
        objViewpointTypeENT.sf_UpdFldSetStr = objViewpointTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.ViewpointType_CopyObjTo = ViewpointType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objViewpointTypeENS:源对象
     * @param objViewpointTypeENT:目标对象
    */
    function ViewpointType_GetObjFromJsonObj(objViewpointTypeENS) {
        const objViewpointTypeENT = new clsViewpointTypeEN_js_1.clsViewpointTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objViewpointTypeENT, objViewpointTypeENS);
        return objViewpointTypeENT;
    }
    exports.ViewpointType_GetObjFromJsonObj = ViewpointType_GetObjFromJsonObj;
});
