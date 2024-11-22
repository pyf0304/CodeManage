/**
* 类名:clsgs_TotalDataTypeWApi
* 表名:gs_TotalDataType(01120685)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:53
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsgs_TotalDataTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_TotalDataType_GetObjFromJsonObj = exports.gs_TotalDataType_CopyObjTo = exports.gs_TotalDataType_GetCombineCondition = exports.gs_TotalDataType_GetObjByJSONStr = exports.gs_TotalDataType_GetObjLstByJSONObjLst = exports.gs_TotalDataType_GetObjLstByJSONStr = exports.gs_TotalDataType_GetJSONStrByObj = exports.gs_TotalDataType_CheckProperty4Update = exports.gs_TotalDataType_CheckPropertyNew = exports.gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache = exports.gs_TotalDataType_ReFreshThisCache = exports.gs_TotalDataType_ReFreshCache = exports.gs_TotalDataType_GetWebApiUrl = exports.gs_TotalDataType_GetMaxStrIdByPrefix = exports.gs_TotalDataType_GetRecCountByCond_Cache = exports.gs_TotalDataType_GetRecCountByCondAsync = exports.gs_TotalDataType_IsExistAsync = exports.gs_TotalDataType_IsExist_Cache = exports.gs_TotalDataType_IsExist = exports.gs_TotalDataType_IsExistRecordAsync = exports.gs_TotalDataType_IsExistRecord_Cache = exports.gs_TotalDataType_UpdateWithConditionAsync = exports.gs_TotalDataType_UpdateRecordAsync = exports.gs_TotalDataType_AddNewRecordWithReturnKey = exports.gs_TotalDataType_AddNewRecordWithReturnKeyAsync = exports.gs_TotalDataType_AddNewRecordWithMaxIdAsync = exports.gs_TotalDataType_AddNewRecordAsync = exports.gs_TotalDataType_Delgs_TotalDataTypesByCondAsync = exports.gs_TotalDataType_Delgs_TotalDataTypesAsync = exports.gs_TotalDataType_DelRecordAsync = exports.gs_TotalDataType_GetObjLstByPagerAsync = exports.gs_TotalDataType_GetObjLstByPager_Cache = exports.gs_TotalDataType_GetObjLstByRange = exports.gs_TotalDataType_GetObjLstByRangeAsync = exports.gs_TotalDataType_GetTopObjLstAsync = exports.gs_TotalDataType_GetObjLstByTotalDataTypeIdLst_Cache = exports.gs_TotalDataType_GetObjLstByTotalDataTypeIdLstAsync = exports.gs_TotalDataType_GetSubObjLst_Cache = exports.gs_TotalDataType_GetObjLst_PureCache = exports.gs_TotalDataType_GetObjLst_Cache = exports.gs_TotalDataType_GetObjLst_sessionStorage_PureCache = exports.gs_TotalDataType_GetObjLst_sessionStorage = exports.gs_TotalDataType_GetObjLstAsync = exports.gs_TotalDataType_GetObjLst_localStorage_PureCache = exports.gs_TotalDataType_GetObjLst_localStorage = exports.gs_TotalDataType_GetObjLst_ClientCache = exports.gs_TotalDataType_GetFirstObjAsync = exports.gs_TotalDataType_GetFirstID = exports.gs_TotalDataType_GetFirstIDAsync = exports.gs_TotalDataType_funcKey = exports.gs_TotalDataType_FilterFunByKey = exports.gs_TotalDataType_SortFunByKey = exports.gs_TotalDataType_SortFun_Defa_2Fld = exports.gs_TotalDataType_SortFun_Defa = exports.gs_TotalDataType_func = exports.gs_TotalDataType_GetNameByTotalDataTypeId_Cache = exports.gs_TotalDataType_UpdateObjInLst_Cache = exports.gs_TotalDataType_GetObjByTotalDataTypeId_localStorage = exports.gs_TotalDataType_GetObjByTotalDataTypeId_Cache = exports.gs_TotalDataType_GetObjByTotalDataTypeIdAsync = exports.gs_TotalDataType_ConstructorName = exports.gs_TotalDataType_Controller = void 0;
    /**
     * 总数据类型表(gs_TotalDataType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_TotalDataTypeEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_TotalDataTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_TotalDataType_Controller = "gs_TotalDataTypeApi";
    exports.gs_TotalDataType_ConstructorName = "gs_TotalDataType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTotalDataTypeId:关键字
    * @returns 对象
    **/
    async function gs_TotalDataType_GetObjByTotalDataTypeIdAsync(strTotalDataTypeId) {
        const strThisFuncName = "GetObjByTotalDataTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTotalDataTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTotalDataTypeId]不能为空！(In clsgs_TotalDataTypeWApi.GetObjByTotalDataTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTotalDataTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTotalDataTypeId]的长度:[{0}]不正确！(clsgs_TotalDataTypeWApi.GetObjByTotalDataTypeIdAsync)", strTotalDataTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTotalDataTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTotalDataTypeId": strTotalDataTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_TotalDataType = gs_TotalDataType_GetObjFromJsonObj(returnObj);
                return objgs_TotalDataType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetObjByTotalDataTypeIdAsync = gs_TotalDataType_GetObjByTotalDataTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTotalDataTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataType_GetObjByTotalDataTypeId_Cache(strTotalDataTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTotalDataTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTotalDataTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTotalDataTypeId]不能为空！(In clsgs_TotalDataTypeWApi.GetObjByTotalDataTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTotalDataTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTotalDataTypeId]的长度:[{0}]不正确！(clsgs_TotalDataTypeWApi.GetObjByTotalDataTypeId_Cache)", strTotalDataTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        try {
            const arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache.filter(x => x.totalDataTypeId == strTotalDataTypeId);
            let objgs_TotalDataType;
            if (arrgs_TotalDataType_Sel.length > 0) {
                objgs_TotalDataType = arrgs_TotalDataType_Sel[0];
                return objgs_TotalDataType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_TotalDataType_Const = await gs_TotalDataType_GetObjByTotalDataTypeIdAsync(strTotalDataTypeId);
                    if (objgs_TotalDataType_Const != null) {
                        gs_TotalDataType_ReFreshThisCache();
                        return objgs_TotalDataType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTotalDataTypeId, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_TotalDataType_GetObjByTotalDataTypeId_Cache = gs_TotalDataType_GetObjByTotalDataTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTotalDataTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataType_GetObjByTotalDataTypeId_localStorage(strTotalDataTypeId) {
        const strThisFuncName = "GetObjByTotalDataTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTotalDataTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTotalDataTypeId]不能为空！(In clsgs_TotalDataTypeWApi.GetObjByTotalDataTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTotalDataTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTotalDataTypeId]的长度:[{0}]不正确！(clsgs_TotalDataTypeWApi.GetObjByTotalDataTypeId_localStorage)", strTotalDataTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName, strTotalDataTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_TotalDataType_Cache = JSON.parse(strTempObj);
            return objgs_TotalDataType_Cache;
        }
        try {
            const objgs_TotalDataType = await gs_TotalDataType_GetObjByTotalDataTypeIdAsync(strTotalDataTypeId);
            if (objgs_TotalDataType != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_TotalDataType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_TotalDataType;
            }
            return objgs_TotalDataType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTotalDataTypeId, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_TotalDataType_GetObjByTotalDataTypeId_localStorage = gs_TotalDataType_GetObjByTotalDataTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_TotalDataType:所给的对象
     * @returns 对象
    */
    async function gs_TotalDataType_UpdateObjInLst_Cache(objgs_TotalDataType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
            const obj = arrgs_TotalDataTypeObjLst_Cache.find(x => x.totalDataTypeId == objgs_TotalDataType.totalDataTypeId);
            if (obj != null) {
                objgs_TotalDataType.totalDataTypeId = obj.totalDataTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_TotalDataType);
            }
            else {
                arrgs_TotalDataTypeObjLst_Cache.push(objgs_TotalDataType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_TotalDataType_UpdateObjInLst_Cache = gs_TotalDataType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strTotalDataTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataType_GetNameByTotalDataTypeId_Cache(strTotalDataTypeId) {
        const strThisFuncName = "GetNameByTotalDataTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTotalDataTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTotalDataTypeId]不能为空！(In clsgs_TotalDataTypeWApi.GetNameByTotalDataTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTotalDataTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTotalDataTypeId]的长度:[{0}]不正确！(clsgs_TotalDataTypeWApi.GetNameByTotalDataTypeId_Cache)", strTotalDataTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        if (arrgs_TotalDataTypeObjLst_Cache == null)
            return "";
        try {
            const arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache.filter(x => x.totalDataTypeId == strTotalDataTypeId);
            let objgs_TotalDataType;
            if (arrgs_TotalDataType_Sel.length > 0) {
                objgs_TotalDataType = arrgs_TotalDataType_Sel[0];
                return objgs_TotalDataType.totalDataTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strTotalDataTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.gs_TotalDataType_GetNameByTotalDataTypeId_Cache = gs_TotalDataType_GetNameByTotalDataTypeId_Cache;
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
    async function gs_TotalDataType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTotalDataTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_TotalDataType = await gs_TotalDataType_GetObjByTotalDataTypeId_Cache(strTotalDataTypeId);
        if (objgs_TotalDataType == null)
            return "";
        if (objgs_TotalDataType.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_TotalDataType.GetFldValue(strOutFldName).toString();
    }
    exports.gs_TotalDataType_func = gs_TotalDataType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.totalDataTypeId.localeCompare(b.totalDataTypeId);
    }
    exports.gs_TotalDataType_SortFun_Defa = gs_TotalDataType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.totalDataTypeName == b.totalDataTypeName)
            return a.dataTable.localeCompare(b.dataTable);
        else
            return a.totalDataTypeName.localeCompare(b.totalDataTypeName);
    }
    exports.gs_TotalDataType_SortFun_Defa_2Fld = gs_TotalDataType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_TotalDataType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId:
                    return (a, b) => {
                        return a.totalDataTypeId.localeCompare(b.totalDataTypeId);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName:
                    return (a, b) => {
                        if (a.totalDataTypeName == null)
                            return -1;
                        if (b.totalDataTypeName == null)
                            return 1;
                        return a.totalDataTypeName.localeCompare(b.totalDataTypeName);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTable:
                    return (a, b) => {
                        if (a.dataTable == null)
                            return -1;
                        if (b.dataTable == null)
                            return 1;
                        return a.dataTable.localeCompare(b.dataTable);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTableId:
                    return (a, b) => {
                        if (a.dataTableId == null)
                            return -1;
                        if (b.dataTableId == null)
                            return 1;
                        return a.dataTableId.localeCompare(b.dataTableId);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_OnlyId:
                    return (a, b) => {
                        if (a.onlyId == null)
                            return -1;
                        if (b.onlyId == null)
                            return 1;
                        return a.onlyId.localeCompare(b.onlyId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataType]中不存在！(in ${exports.gs_TotalDataType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId:
                    return (a, b) => {
                        return b.totalDataTypeId.localeCompare(a.totalDataTypeId);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName:
                    return (a, b) => {
                        if (b.totalDataTypeName == null)
                            return -1;
                        if (a.totalDataTypeName == null)
                            return 1;
                        return b.totalDataTypeName.localeCompare(a.totalDataTypeName);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTable:
                    return (a, b) => {
                        if (b.dataTable == null)
                            return -1;
                        if (a.dataTable == null)
                            return 1;
                        return b.dataTable.localeCompare(a.dataTable);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTableId:
                    return (a, b) => {
                        if (b.dataTableId == null)
                            return -1;
                        if (a.dataTableId == null)
                            return 1;
                        return b.dataTableId.localeCompare(a.dataTableId);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_OnlyId:
                    return (a, b) => {
                        if (b.onlyId == null)
                            return -1;
                        if (a.onlyId == null)
                            return 1;
                        return b.onlyId.localeCompare(a.onlyId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataType]中不存在！(in ${exports.gs_TotalDataType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_TotalDataType_SortFunByKey = gs_TotalDataType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_TotalDataType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId:
                return (obj) => {
                    return obj.totalDataTypeId === value;
                };
            case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName:
                return (obj) => {
                    return obj.totalDataTypeName === value;
                };
            case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTable:
                return (obj) => {
                    return obj.dataTable === value;
                };
            case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTableId:
                return (obj) => {
                    return obj.dataTableId === value;
                };
            case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_OnlyId:
                return (obj) => {
                    return obj.onlyId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_TotalDataType]中不存在！(in ${exports.gs_TotalDataType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_TotalDataType_FilterFunByKey = gs_TotalDataType_FilterFunByKey;
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
    async function gs_TotalDataType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_TotalDataType = await gs_TotalDataType_GetObjLst_Cache();
        if (arrgs_TotalDataType == null)
            return [];
        let arrgs_TotalDataType_Sel = arrgs_TotalDataType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_TotalDataType_Sel.length == 0)
            return [];
        return arrgs_TotalDataType_Sel.map(x => x.totalDataTypeId);
    }
    exports.gs_TotalDataType_funcKey = gs_TotalDataType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TotalDataType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetFirstIDAsync = gs_TotalDataType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_TotalDataType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetFirstID = gs_TotalDataType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_TotalDataType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const objgs_TotalDataType = gs_TotalDataType_GetObjFromJsonObj(returnObj);
                return objgs_TotalDataType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetFirstObjAsync = gs_TotalDataType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_TotalDataTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_TotalDataTypeObjLst_T = gs_TotalDataType_GetObjLstByJSONObjLst(arrgs_TotalDataTypeExObjLst_Cache);
            return arrgs_TotalDataTypeObjLst_T;
        }
        try {
            const arrgs_TotalDataTypeExObjLst = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_TotalDataTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_TotalDataTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TotalDataType_GetObjLst_ClientCache = gs_TotalDataType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TotalDataTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TotalDataTypeObjLst_T = gs_TotalDataType_GetObjLstByJSONObjLst(arrgs_TotalDataTypeExObjLst_Cache);
            return arrgs_TotalDataTypeObjLst_T;
        }
        try {
            const arrgs_TotalDataTypeExObjLst = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_TotalDataTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TotalDataType_GetObjLst_localStorage = gs_TotalDataType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_TotalDataTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TotalDataTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TotalDataType_GetObjLst_localStorage_PureCache = gs_TotalDataType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_TotalDataType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetObjLstAsync = gs_TotalDataType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TotalDataTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_TotalDataTypeObjLst_T = gs_TotalDataType_GetObjLstByJSONObjLst(arrgs_TotalDataTypeExObjLst_Cache);
            return arrgs_TotalDataTypeObjLst_T;
        }
        try {
            const arrgs_TotalDataTypeExObjLst = await gs_TotalDataType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_TotalDataTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_TotalDataTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_TotalDataTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_TotalDataType_GetObjLst_sessionStorage = gs_TotalDataType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_TotalDataTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_TotalDataTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_TotalDataType_GetObjLst_sessionStorage_PureCache = gs_TotalDataType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_TotalDataTypeObjLst_Cache;
        switch (clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_ClientCache();
                break;
            default:
                arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_ClientCache();
                break;
        }
        const arrgs_TotalDataTypeObjLst = gs_TotalDataType_GetObjLstByJSONObjLst(arrgs_TotalDataTypeObjLst_Cache);
        return arrgs_TotalDataTypeObjLst_Cache;
    }
    exports.gs_TotalDataType_GetObjLst_Cache = gs_TotalDataType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_TotalDataType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_TotalDataTypeObjLst_Cache;
        switch (clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_TotalDataTypeObjLst_Cache = null;
                break;
            default:
                arrgs_TotalDataTypeObjLst_Cache = null;
                break;
        }
        return arrgs_TotalDataTypeObjLst_Cache;
    }
    exports.gs_TotalDataType_GetObjLst_PureCache = gs_TotalDataType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTotalDataTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TotalDataType_GetSubObjLst_Cache(objgs_TotalDataType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        let arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache;
        if (objgs_TotalDataType_Cond.sf_FldComparisonOp == null || objgs_TotalDataType_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataType_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_TotalDataType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TotalDataType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TotalDataType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_TotalDataType_Cond), exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataType_GetSubObjLst_Cache = gs_TotalDataType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTotalDataTypeId:关键字列表
    * @returns 对象列表
    **/
    async function gs_TotalDataType_GetObjLstByTotalDataTypeIdLstAsync(arrTotalDataTypeId) {
        const strThisFuncName = "GetObjLstByTotalDataTypeIdLstAsync";
        const strAction = "GetObjLstByTotalDataTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTotalDataTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetObjLstByTotalDataTypeIdLstAsync = gs_TotalDataType_GetObjLstByTotalDataTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTotalDataTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_TotalDataType_GetObjLstByTotalDataTypeIdLst_Cache(arrTotalDataTypeIdLst) {
        const strThisFuncName = "GetObjLstByTotalDataTypeIdLst_Cache";
        try {
            const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
            const arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache.filter(x => arrTotalDataTypeIdLst.indexOf(x.totalDataTypeId) > -1);
            return arrgs_TotalDataType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTotalDataTypeIdLst.join(","), exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_TotalDataType_GetObjLstByTotalDataTypeIdLst_Cache = gs_TotalDataType_GetObjLstByTotalDataTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_TotalDataType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetTopObjLstAsync = gs_TotalDataType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TotalDataType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetObjLstByRangeAsync = gs_TotalDataType_GetObjLstByRangeAsync;
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
    async function gs_TotalDataType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetObjLstByRange = gs_TotalDataType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_TotalDataType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        if (arrgs_TotalDataTypeObjLst_Cache.length == 0)
            return arrgs_TotalDataTypeObjLst_Cache;
        let arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_TotalDataType_Cond = new clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TotalDataType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_TotalDataTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TotalDataType_Sel.length == 0)
                return arrgs_TotalDataType_Sel;
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
                arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.sort(gs_TotalDataType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.slice(intStart, intEnd);
            return arrgs_TotalDataType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_TotalDataType_GetObjLstByPager_Cache = gs_TotalDataType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_TotalDataType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_TotalDataType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetObjLstByPagerAsync = gs_TotalDataType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTotalDataTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_TotalDataType_DelRecordAsync(strTotalDataTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strTotalDataTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_DelRecordAsync = gs_TotalDataType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTotalDataTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_TotalDataType_Delgs_TotalDataTypesAsync(arrTotalDataTypeId) {
        const strThisFuncName = "Delgs_TotalDataTypesAsync";
        const strAction = "Delgs_TotalDataTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTotalDataTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_Delgs_TotalDataTypesAsync = gs_TotalDataType_Delgs_TotalDataTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_TotalDataType_Delgs_TotalDataTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_TotalDataTypesByCondAsync";
        const strAction = "Delgs_TotalDataTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_Delgs_TotalDataTypesByCondAsync = gs_TotalDataType_Delgs_TotalDataTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_TotalDataTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TotalDataType_AddNewRecordAsync(objgs_TotalDataTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objgs_TotalDataTypeEN.totalDataTypeId === null || objgs_TotalDataTypeEN.totalDataTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_TotalDataTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_AddNewRecordAsync = gs_TotalDataType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_TotalDataTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_TotalDataType_AddNewRecordWithMaxIdAsync(objgs_TotalDataTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_AddNewRecordWithMaxIdAsync = gs_TotalDataType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_TotalDataTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_TotalDataType_AddNewRecordWithReturnKeyAsync(objgs_TotalDataTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_AddNewRecordWithReturnKeyAsync = gs_TotalDataType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_TotalDataTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_TotalDataType_AddNewRecordWithReturnKey(objgs_TotalDataTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_TotalDataTypeEN.totalDataTypeId === null || objgs_TotalDataTypeEN.totalDataTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_AddNewRecordWithReturnKey = gs_TotalDataType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_TotalDataTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_TotalDataType_UpdateRecordAsync(objgs_TotalDataTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_TotalDataTypeEN.sf_UpdFldSetStr === undefined || objgs_TotalDataTypeEN.sf_UpdFldSetStr === null || objgs_TotalDataTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataTypeEN.totalDataTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_UpdateRecordAsync = gs_TotalDataType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_TotalDataTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_TotalDataType_UpdateWithConditionAsync(objgs_TotalDataTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_TotalDataTypeEN.sf_UpdFldSetStr === undefined || objgs_TotalDataTypeEN.sf_UpdFldSetStr === null || objgs_TotalDataTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_TotalDataTypeEN.totalDataTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        objgs_TotalDataTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_TotalDataTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_UpdateWithConditionAsync = gs_TotalDataType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTotalDataTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_TotalDataType_IsExistRecord_Cache(objgs_TotalDataType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        if (arrgs_TotalDataTypeObjLst_Cache == null)
            return false;
        let arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache;
        if (objgs_TotalDataType_Cond.sf_FldComparisonOp == null || objgs_TotalDataType_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_TotalDataType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TotalDataType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_TotalDataType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_TotalDataType_Cond), exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_TotalDataType_IsExistRecord_Cache = gs_TotalDataType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_TotalDataType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_IsExistRecordAsync = gs_TotalDataType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTotalDataTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_TotalDataType_IsExist(strTotalDataTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TotalDataTypeId": strTotalDataTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_IsExist = gs_TotalDataType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTotalDataTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_TotalDataType_IsExist_Cache(strTotalDataTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        if (arrgs_TotalDataTypeObjLst_Cache == null)
            return false;
        try {
            const arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache.filter(x => x.totalDataTypeId == strTotalDataTypeId);
            if (arrgs_TotalDataType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTotalDataTypeId, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_TotalDataType_IsExist_Cache = gs_TotalDataType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTotalDataTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_TotalDataType_IsExistAsync(strTotalDataTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTotalDataTypeId": strTotalDataTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_IsExistAsync = gs_TotalDataType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_TotalDataType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetRecCountByCondAsync = gs_TotalDataType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_TotalDataType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_TotalDataType_GetRecCountByCond_Cache(objgs_TotalDataType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_TotalDataTypeObjLst_Cache = await gs_TotalDataType_GetObjLst_Cache();
        if (arrgs_TotalDataTypeObjLst_Cache == null)
            return 0;
        let arrgs_TotalDataType_Sel = arrgs_TotalDataTypeObjLst_Cache;
        if (objgs_TotalDataType_Cond.sf_FldComparisonOp == null || objgs_TotalDataType_Cond.sf_FldComparisonOp == "")
            return arrgs_TotalDataType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_TotalDataType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_TotalDataTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_TotalDataType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_TotalDataType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_TotalDataType_Sel = arrgs_TotalDataType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_TotalDataType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_TotalDataType_Cond), exports.gs_TotalDataType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_TotalDataType_GetRecCountByCond_Cache = gs_TotalDataType_GetRecCountByCond_Cache;
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
    async function gs_TotalDataType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_TotalDataType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_TotalDataType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_TotalDataType_GetMaxStrIdByPrefix = gs_TotalDataType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_TotalDataType_GetWebApiUrl(strController, strAction) {
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
    exports.gs_TotalDataType_GetWebApiUrl = gs_TotalDataType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_TotalDataType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
        switch (clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheModeId) {
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
    exports.gs_TotalDataType_ReFreshCache = gs_TotalDataType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_TotalDataType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN._CurrTabName;
            switch (clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.CacheModeId) {
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
    exports.gs_TotalDataType_ReFreshThisCache = gs_TotalDataType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_TotalDataTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_TotalDataTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_TotalDataTypeIdInDiv_Cache");
        const arrObjLst_Sel = await gs_TotalDataType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName, "总数据类型表");
    }
    exports.gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache = gs_TotalDataType_BindDdl_TotalDataTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TotalDataType_CheckPropertyNew(pobjgs_TotalDataTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.totalDataTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[总数据类型Id(totalDataTypeId)]的长度不能超过2(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.totalDataTypeId)(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.totalDataTypeName) > 500) {
            throw new Error("(errid:Watl000059)字段[总数据类型名称(totalDataTypeName)]的长度不能超过500(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.totalDataTypeName)(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTable) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.dataTable) > 100) {
            throw new Error("(errid:Watl000059)字段[数据表(dataTable)]的长度不能超过100(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.dataTable)(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTableId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.dataTableId) > 50) {
            throw new Error("(errid:Watl000059)字段[数据表Id(dataTableId)]的长度不能超过50(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.dataTableId)(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.memo)(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.onlyId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.onlyId) > 20) {
            throw new Error("(errid:Watl000059)字段[OnlyId(onlyId)]的长度不能超过20(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.onlyId)(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeId) == false && undefined !== pobjgs_TotalDataTypeEN.totalDataTypeId && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.totalDataTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[总数据类型Id(totalDataTypeId)]的值:[$(pobjgs_TotalDataTypeEN.totalDataTypeId)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeName) == false && undefined !== pobjgs_TotalDataTypeEN.totalDataTypeName && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.totalDataTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[总数据类型名称(totalDataTypeName)]的值:[$(pobjgs_TotalDataTypeEN.totalDataTypeName)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTable) == false && undefined !== pobjgs_TotalDataTypeEN.dataTable && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.dataTable) === false) {
            throw new Error("(errid:Watl000060)字段[数据表(dataTable)]的值:[$(pobjgs_TotalDataTypeEN.dataTable)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTableId) == false && undefined !== pobjgs_TotalDataTypeEN.dataTableId && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.dataTableId) === false) {
            throw new Error("(errid:Watl000060)字段[数据表Id(dataTableId)]的值:[$(pobjgs_TotalDataTypeEN.dataTableId)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.memo) == false && undefined !== pobjgs_TotalDataTypeEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_TotalDataTypeEN.memo)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.onlyId) == false && undefined !== pobjgs_TotalDataTypeEN.onlyId && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.onlyId) === false) {
            throw new Error("(errid:Watl000060)字段[OnlyId(onlyId)]的值:[$(pobjgs_TotalDataTypeEN.onlyId)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_TotalDataTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_TotalDataType_CheckPropertyNew = gs_TotalDataType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_TotalDataType_CheckProperty4Update(pobjgs_TotalDataTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.totalDataTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[总数据类型Id(totalDataTypeId)]的长度不能超过2(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.totalDataTypeId)(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.totalDataTypeName) > 500) {
            throw new Error("(errid:Watl000062)字段[总数据类型名称(totalDataTypeName)]的长度不能超过500(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.totalDataTypeName)(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTable) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.dataTable) > 100) {
            throw new Error("(errid:Watl000062)字段[数据表(dataTable)]的长度不能超过100(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.dataTable)(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTableId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.dataTableId) > 50) {
            throw new Error("(errid:Watl000062)字段[数据表Id(dataTableId)]的长度不能超过50(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.dataTableId)(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.memo)(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.onlyId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_TotalDataTypeEN.onlyId) > 20) {
            throw new Error("(errid:Watl000062)字段[OnlyId(onlyId)]的长度不能超过20(In 总数据类型表(gs_TotalDataType))!值:$(pobjgs_TotalDataTypeEN.onlyId)(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeId) == false && undefined !== pobjgs_TotalDataTypeEN.totalDataTypeId && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.totalDataTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[总数据类型Id(totalDataTypeId)]的值:[$(pobjgs_TotalDataTypeEN.totalDataTypeId)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeName) == false && undefined !== pobjgs_TotalDataTypeEN.totalDataTypeName && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.totalDataTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[总数据类型名称(totalDataTypeName)]的值:[$(pobjgs_TotalDataTypeEN.totalDataTypeName)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTable) == false && undefined !== pobjgs_TotalDataTypeEN.dataTable && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.dataTable) === false) {
            throw new Error("(errid:Watl000063)字段[数据表(dataTable)]的值:[$(pobjgs_TotalDataTypeEN.dataTable)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.dataTableId) == false && undefined !== pobjgs_TotalDataTypeEN.dataTableId && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.dataTableId) === false) {
            throw new Error("(errid:Watl000063)字段[数据表Id(dataTableId)]的值:[$(pobjgs_TotalDataTypeEN.dataTableId)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.memo) == false && undefined !== pobjgs_TotalDataTypeEN.memo && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_TotalDataTypeEN.memo)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.onlyId) == false && undefined !== pobjgs_TotalDataTypeEN.onlyId && clsString_js_1.tzDataType.isString(pobjgs_TotalDataTypeEN.onlyId) === false) {
            throw new Error("(errid:Watl000063)字段[OnlyId(onlyId)]的值:[$(pobjgs_TotalDataTypeEN.onlyId)], 非法，应该为字符型(In 总数据类型表(gs_TotalDataType))!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_TotalDataTypeEN.totalDataTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[总数据类型Id]不能为空(In 总数据类型表)!(clsgs_TotalDataTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_TotalDataTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_TotalDataType_CheckProperty4Update = gs_TotalDataType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TotalDataType_GetJSONStrByObj(pobjgs_TotalDataTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_TotalDataTypeEN.sf_UpdFldSetStr = pobjgs_TotalDataTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_TotalDataTypeEN);
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
    exports.gs_TotalDataType_GetJSONStrByObj = gs_TotalDataType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_TotalDataType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_TotalDataTypeObjLst = new Array();
        if (strJSON === "") {
            return arrgs_TotalDataTypeObjLst;
        }
        try {
            arrgs_TotalDataTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_TotalDataTypeObjLst;
        }
        return arrgs_TotalDataTypeObjLst;
    }
    exports.gs_TotalDataType_GetObjLstByJSONStr = gs_TotalDataType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_TotalDataTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_TotalDataType_GetObjLstByJSONObjLst(arrgs_TotalDataTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_TotalDataTypeObjLst = new Array();
        for (const objInFor of arrgs_TotalDataTypeObjLstS) {
            const obj1 = gs_TotalDataType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_TotalDataTypeObjLst.push(obj1);
        }
        return arrgs_TotalDataTypeObjLst;
    }
    exports.gs_TotalDataType_GetObjLstByJSONObjLst = gs_TotalDataType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_TotalDataType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_TotalDataTypeEN = new clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN();
        if (strJSON === "") {
            return pobjgs_TotalDataTypeEN;
        }
        try {
            pobjgs_TotalDataTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_TotalDataTypeEN;
        }
        return pobjgs_TotalDataTypeEN;
    }
    exports.gs_TotalDataType_GetObjByJSONStr = gs_TotalDataType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_TotalDataType_GetCombineCondition(objgs_TotalDataType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataType_Cond.dicFldComparisonOp, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId) == true) {
            const strComparisonOp_TotalDataTypeId = objgs_TotalDataType_Cond.dicFldComparisonOp[clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeId, objgs_TotalDataType_Cond.totalDataTypeId, strComparisonOp_TotalDataTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataType_Cond.dicFldComparisonOp, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName) == true) {
            const strComparisonOp_TotalDataTypeName = objgs_TotalDataType_Cond.dicFldComparisonOp[clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_TotalDataTypeName, objgs_TotalDataType_Cond.totalDataTypeName, strComparisonOp_TotalDataTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataType_Cond.dicFldComparisonOp, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTable) == true) {
            const strComparisonOp_DataTable = objgs_TotalDataType_Cond.dicFldComparisonOp[clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTable];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTable, objgs_TotalDataType_Cond.dataTable, strComparisonOp_DataTable);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataType_Cond.dicFldComparisonOp, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTableId) == true) {
            const strComparisonOp_DataTableId = objgs_TotalDataType_Cond.dicFldComparisonOp[clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTableId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_DataTableId, objgs_TotalDataType_Cond.dataTableId, strComparisonOp_DataTableId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataType_Cond.dicFldComparisonOp, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_TotalDataType_Cond.dicFldComparisonOp[clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_Memo, objgs_TotalDataType_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_TotalDataType_Cond.dicFldComparisonOp, clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_OnlyId) == true) {
            const strComparisonOp_OnlyId = objgs_TotalDataType_Cond.dicFldComparisonOp[clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_OnlyId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN.con_OnlyId, objgs_TotalDataType_Cond.onlyId, strComparisonOp_OnlyId);
        }
        return strWhereCond;
    }
    exports.gs_TotalDataType_GetCombineCondition = gs_TotalDataType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_TotalDataTypeENS:源对象
     * @param objgs_TotalDataTypeENT:目标对象
    */
    function gs_TotalDataType_CopyObjTo(objgs_TotalDataTypeENS, objgs_TotalDataTypeENT) {
        objgs_TotalDataTypeENT.totalDataTypeId = objgs_TotalDataTypeENS.totalDataTypeId; //总数据类型Id
        objgs_TotalDataTypeENT.totalDataTypeName = objgs_TotalDataTypeENS.totalDataTypeName; //总数据类型名称
        objgs_TotalDataTypeENT.dataTable = objgs_TotalDataTypeENS.dataTable; //数据表
        objgs_TotalDataTypeENT.dataTableId = objgs_TotalDataTypeENS.dataTableId; //数据表Id
        objgs_TotalDataTypeENT.memo = objgs_TotalDataTypeENS.memo; //备注
        objgs_TotalDataTypeENT.onlyId = objgs_TotalDataTypeENS.onlyId; //OnlyId
        objgs_TotalDataTypeENT.sf_UpdFldSetStr = objgs_TotalDataTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_TotalDataType_CopyObjTo = gs_TotalDataType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_TotalDataTypeENS:源对象
     * @param objgs_TotalDataTypeENT:目标对象
    */
    function gs_TotalDataType_GetObjFromJsonObj(objgs_TotalDataTypeENS) {
        const objgs_TotalDataTypeENT = new clsgs_TotalDataTypeEN_js_1.clsgs_TotalDataTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_TotalDataTypeENT, objgs_TotalDataTypeENS);
        return objgs_TotalDataTypeENT;
    }
    exports.gs_TotalDataType_GetObjFromJsonObj = gs_TotalDataType_GetObjFromJsonObj;
});
