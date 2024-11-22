/**
* 类名:clssys_RequestTypeWApi
* 表名:sys_RequestType(01120727)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:48:37
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clssys_RequestTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.sys_RequestType_GetObjFromJsonObj = exports.sys_RequestType_CopyObjTo = exports.sys_RequestType_GetUniCondStr4Update_RequestTableId_RequestTypeId = exports.sys_RequestType_GetUniCondStr_RequestTableId_RequestTypeId = exports.sys_RequestType_GetCombineCondition = exports.sys_RequestType_GetObjByJSONStr = exports.sys_RequestType_GetObjLstByJSONObjLst = exports.sys_RequestType_GetObjLstByJSONStr = exports.sys_RequestType_GetJSONStrByObj = exports.sys_RequestType_CheckProperty4Update = exports.sys_RequestType_CheckPropertyNew = exports.sys_RequestType_ReFreshThisCache = exports.sys_RequestType_ReFreshCache = exports.sys_RequestType_GetWebApiUrl = exports.sys_RequestType_GetMaxStrIdByPrefix = exports.sys_RequestType_GetMaxStrIdAsync = exports.sys_RequestType_GetRecCountByCond_Cache = exports.sys_RequestType_GetRecCountByCondAsync = exports.sys_RequestType_IsExistAsync = exports.sys_RequestType_IsExist_Cache = exports.sys_RequestType_IsExist = exports.sys_RequestType_IsExistRecordAsync = exports.sys_RequestType_IsExistRecord_Cache = exports.sys_RequestType_UpdateWithConditionAsync = exports.sys_RequestType_UpdateRecordAsync = exports.sys_RequestType_AddNewRecordWithReturnKey = exports.sys_RequestType_AddNewRecordWithReturnKeyAsync = exports.sys_RequestType_AddNewRecordWithMaxIdAsync = exports.sys_RequestType_AddNewRecordAsync = exports.sys_RequestType_Delsys_RequestTypesByCondAsync = exports.sys_RequestType_Delsys_RequestTypesAsync = exports.sys_RequestType_DelRecordAsync = exports.sys_RequestType_GetObjLstByPagerAsync = exports.sys_RequestType_GetObjLstByPager_Cache = exports.sys_RequestType_GetObjLstByRange = exports.sys_RequestType_GetObjLstByRangeAsync = exports.sys_RequestType_GetTopObjLstAsync = exports.sys_RequestType_GetObjLstByRequestTypeIdLst_Cache = exports.sys_RequestType_GetObjLstByRequestTypeIdLstAsync = exports.sys_RequestType_GetSubObjLst_Cache = exports.sys_RequestType_GetObjLst_PureCache = exports.sys_RequestType_GetObjLst_Cache = exports.sys_RequestType_GetObjLst_sessionStorage_PureCache = exports.sys_RequestType_GetObjLst_sessionStorage = exports.sys_RequestType_GetObjLstAsync = exports.sys_RequestType_GetObjLst_localStorage_PureCache = exports.sys_RequestType_GetObjLst_localStorage = exports.sys_RequestType_GetObjLst_ClientCache = exports.sys_RequestType_GetFirstObjAsync = exports.sys_RequestType_GetFirstID = exports.sys_RequestType_GetFirstIDAsync = exports.sys_RequestType_funcKey = exports.sys_RequestType_FilterFunByKey = exports.sys_RequestType_SortFunByKey = exports.sys_RequestType_SortFun_Defa_2Fld = exports.sys_RequestType_SortFun_Defa = exports.sys_RequestType_func = exports.sys_RequestType_UpdateObjInLst_Cache = exports.sys_RequestType_GetObjByRequestTypeId_localStorage = exports.sys_RequestType_GetObjByRequestTypeId_Cache = exports.sys_RequestType_GetObjByRequestTypeIdAsync = exports.sys_RequestType_ConstructorName = exports.sys_RequestType_Controller = void 0;
    /**
     * 请求类型表(sys_RequestType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clssys_RequestTypeEN_js_1 = require("../../L0_Entity/GraduateEduTools/clssys_RequestTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sys_RequestType_Controller = "sys_RequestTypeApi";
    exports.sys_RequestType_ConstructorName = "sys_RequestType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strRequestTypeId:关键字
    * @returns 对象
    **/
    async function sys_RequestType_GetObjByRequestTypeIdAsync(strRequestTypeId) {
        const strThisFuncName = "GetObjByRequestTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRequestTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRequestTypeId]不能为空！(In clssys_RequestTypeWApi.GetObjByRequestTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRequestTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRequestTypeId]的长度:[{0}]不正确！(clssys_RequestTypeWApi.GetObjByRequestTypeIdAsync)", strRequestTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByRequestTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strRequestTypeId": strRequestTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objsys_RequestType = sys_RequestType_GetObjFromJsonObj(returnObj);
                return objsys_RequestType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetObjByRequestTypeIdAsync = sys_RequestType_GetObjByRequestTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strRequestTypeId:所给的关键字
     * @returns 对象
    */
    async function sys_RequestType_GetObjByRequestTypeId_Cache(strRequestTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByRequestTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRequestTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRequestTypeId]不能为空！(In clssys_RequestTypeWApi.GetObjByRequestTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRequestTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRequestTypeId]的长度:[{0}]不正确！(clssys_RequestTypeWApi.GetObjByRequestTypeId_Cache)", strRequestTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
        try {
            const arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache.filter(x => x.requestTypeId == strRequestTypeId);
            let objsys_RequestType;
            if (arrsys_RequestType_Sel.length > 0) {
                objsys_RequestType = arrsys_RequestType_Sel[0];
                return objsys_RequestType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objsys_RequestType_Const = await sys_RequestType_GetObjByRequestTypeIdAsync(strRequestTypeId);
                    if (objsys_RequestType_Const != null) {
                        sys_RequestType_ReFreshThisCache();
                        return objsys_RequestType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strRequestTypeId, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.sys_RequestType_GetObjByRequestTypeId_Cache = sys_RequestType_GetObjByRequestTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strRequestTypeId:所给的关键字
     * @returns 对象
    */
    async function sys_RequestType_GetObjByRequestTypeId_localStorage(strRequestTypeId) {
        const strThisFuncName = "GetObjByRequestTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRequestTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRequestTypeId]不能为空！(In clssys_RequestTypeWApi.GetObjByRequestTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRequestTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRequestTypeId]的长度:[{0}]不正确！(clssys_RequestTypeWApi.GetObjByRequestTypeId_localStorage)", strRequestTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName, strRequestTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objsys_RequestType_Cache = JSON.parse(strTempObj);
            return objsys_RequestType_Cache;
        }
        try {
            const objsys_RequestType = await sys_RequestType_GetObjByRequestTypeIdAsync(strRequestTypeId);
            if (objsys_RequestType != null) {
                localStorage.setItem(strKey, JSON.stringify(objsys_RequestType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objsys_RequestType;
            }
            return objsys_RequestType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strRequestTypeId, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.sys_RequestType_GetObjByRequestTypeId_localStorage = sys_RequestType_GetObjByRequestTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objsys_RequestType:所给的对象
     * @returns 对象
    */
    async function sys_RequestType_UpdateObjInLst_Cache(objsys_RequestType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
            const obj = arrsys_RequestTypeObjLst_Cache.find(x => x.requestTableId == objsys_RequestType.requestTableId && x.requestTypeId == objsys_RequestType.requestTypeId);
            if (obj != null) {
                objsys_RequestType.requestTypeId = obj.requestTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objsys_RequestType);
            }
            else {
                arrsys_RequestTypeObjLst_Cache.push(objsys_RequestType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.sys_RequestType_UpdateObjInLst_Cache = sys_RequestType_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function sys_RequestType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strRequestTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objsys_RequestType = await sys_RequestType_GetObjByRequestTypeId_Cache(strRequestTypeId);
        if (objsys_RequestType == null)
            return "";
        if (objsys_RequestType.GetFldValue(strOutFldName) == null)
            return "";
        return objsys_RequestType.GetFldValue(strOutFldName).toString();
    }
    exports.sys_RequestType_func = sys_RequestType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function sys_RequestType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.requestTypeId.localeCompare(b.requestTypeId);
    }
    exports.sys_RequestType_SortFun_Defa = sys_RequestType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function sys_RequestType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.requestTypeName == b.requestTypeName)
            return a.requestTable.localeCompare(b.requestTable);
        else
            return a.requestTypeName.localeCompare(b.requestTypeName);
    }
    exports.sys_RequestType_SortFun_Defa_2Fld = sys_RequestType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function sys_RequestType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId:
                    return (a, b) => {
                        return a.requestTypeId.localeCompare(b.requestTypeId);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeName:
                    return (a, b) => {
                        if (a.requestTypeName == null)
                            return -1;
                        if (b.requestTypeName == null)
                            return 1;
                        return a.requestTypeName.localeCompare(b.requestTypeName);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTable:
                    return (a, b) => {
                        if (a.requestTable == null)
                            return -1;
                        if (b.requestTable == null)
                            return 1;
                        return a.requestTable.localeCompare(b.requestTable);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTableId:
                    return (a, b) => {
                        if (a.requestTableId == null)
                            return -1;
                        if (b.requestTableId == null)
                            return 1;
                        return a.requestTableId.localeCompare(b.requestTableId);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[sys_RequestType]中不存在！(in ${exports.sys_RequestType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId:
                    return (a, b) => {
                        return b.requestTypeId.localeCompare(a.requestTypeId);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeName:
                    return (a, b) => {
                        if (b.requestTypeName == null)
                            return -1;
                        if (a.requestTypeName == null)
                            return 1;
                        return b.requestTypeName.localeCompare(a.requestTypeName);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTable:
                    return (a, b) => {
                        if (b.requestTable == null)
                            return -1;
                        if (a.requestTable == null)
                            return 1;
                        return b.requestTable.localeCompare(a.requestTable);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTableId:
                    return (a, b) => {
                        if (b.requestTableId == null)
                            return -1;
                        if (a.requestTableId == null)
                            return 1;
                        return b.requestTableId.localeCompare(a.requestTableId);
                    };
                case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[sys_RequestType]中不存在！(in ${exports.sys_RequestType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.sys_RequestType_SortFunByKey = sys_RequestType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function sys_RequestType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId:
                return (obj) => {
                    return obj.requestTypeId === value;
                };
            case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeName:
                return (obj) => {
                    return obj.requestTypeName === value;
                };
            case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTable:
                return (obj) => {
                    return obj.requestTable === value;
                };
            case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTableId:
                return (obj) => {
                    return obj.requestTableId === value;
                };
            case clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[sys_RequestType]中不存在！(in ${exports.sys_RequestType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.sys_RequestType_FilterFunByKey = sys_RequestType_FilterFunByKey;
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
    async function sys_RequestType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrsys_RequestType = await sys_RequestType_GetObjLst_Cache();
        if (arrsys_RequestType == null)
            return [];
        let arrsys_RequestType_Sel = arrsys_RequestType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrsys_RequestType_Sel.length == 0)
            return [];
        return arrsys_RequestType_Sel.map(x => x.requestTypeId);
    }
    exports.sys_RequestType_funcKey = sys_RequestType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function sys_RequestType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetFirstIDAsync = sys_RequestType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function sys_RequestType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetFirstID = sys_RequestType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function sys_RequestType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const objsys_RequestType = sys_RequestType_GetObjFromJsonObj(returnObj);
                return objsys_RequestType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetFirstObjAsync = sys_RequestType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrsys_RequestTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrsys_RequestTypeObjLst_T = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeExObjLst_Cache);
            return arrsys_RequestTypeObjLst_T;
        }
        try {
            const arrsys_RequestTypeExObjLst = await sys_RequestType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrsys_RequestTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestTypeExObjLst.length);
            console.log(strInfo);
            return arrsys_RequestTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.sys_RequestType_GetObjLst_ClientCache = sys_RequestType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrsys_RequestTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrsys_RequestTypeObjLst_T = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeExObjLst_Cache);
            return arrsys_RequestTypeObjLst_T;
        }
        try {
            const arrsys_RequestTypeExObjLst = await sys_RequestType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrsys_RequestTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestTypeExObjLst.length);
            console.log(strInfo);
            return arrsys_RequestTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.sys_RequestType_GetObjLst_localStorage = sys_RequestType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrsys_RequestTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrsys_RequestTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.sys_RequestType_GetObjLst_localStorage_PureCache = sys_RequestType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function sys_RequestType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sys_RequestType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetObjLstAsync = sys_RequestType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrsys_RequestTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrsys_RequestTypeObjLst_T = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeExObjLst_Cache);
            return arrsys_RequestTypeObjLst_T;
        }
        try {
            const arrsys_RequestTypeExObjLst = await sys_RequestType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrsys_RequestTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrsys_RequestTypeExObjLst.length);
            console.log(strInfo);
            return arrsys_RequestTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.sys_RequestType_GetObjLst_sessionStorage = sys_RequestType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrsys_RequestTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrsys_RequestTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.sys_RequestType_GetObjLst_sessionStorage_PureCache = sys_RequestType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrsys_RequestTypeObjLst_Cache;
        switch (clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_ClientCache();
                break;
            default:
                arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_ClientCache();
                break;
        }
        const arrsys_RequestTypeObjLst = sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeObjLst_Cache);
        return arrsys_RequestTypeObjLst_Cache;
    }
    exports.sys_RequestType_GetObjLst_Cache = sys_RequestType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function sys_RequestType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrsys_RequestTypeObjLst_Cache;
        switch (clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrsys_RequestTypeObjLst_Cache = null;
                break;
            default:
                arrsys_RequestTypeObjLst_Cache = null;
                break;
        }
        return arrsys_RequestTypeObjLst_Cache;
    }
    exports.sys_RequestType_GetObjLst_PureCache = sys_RequestType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrRequestTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function sys_RequestType_GetSubObjLst_Cache(objsys_RequestType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
        let arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache;
        if (objsys_RequestType_Cond.sf_FldComparisonOp == null || objsys_RequestType_Cond.sf_FldComparisonOp == "")
            return arrsys_RequestType_Sel;
        const dicFldComparisonOp = JSON.parse(objsys_RequestType_Cond.sf_FldComparisonOp);
        //console.log("clssys_RequestTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objsys_RequestType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrsys_RequestType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objsys_RequestType_Cond), exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.sys_RequestType_GetSubObjLst_Cache = sys_RequestType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrRequestTypeId:关键字列表
    * @returns 对象列表
    **/
    async function sys_RequestType_GetObjLstByRequestTypeIdLstAsync(arrRequestTypeId) {
        const strThisFuncName = "GetObjLstByRequestTypeIdLstAsync";
        const strAction = "GetObjLstByRequestTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrRequestTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sys_RequestType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetObjLstByRequestTypeIdLstAsync = sys_RequestType_GetObjLstByRequestTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrRequestTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function sys_RequestType_GetObjLstByRequestTypeIdLst_Cache(arrRequestTypeIdLst) {
        const strThisFuncName = "GetObjLstByRequestTypeIdLst_Cache";
        try {
            const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
            const arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache.filter(x => arrRequestTypeIdLst.indexOf(x.requestTypeId) > -1);
            return arrsys_RequestType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrRequestTypeIdLst.join(","), exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.sys_RequestType_GetObjLstByRequestTypeIdLst_Cache = sys_RequestType_GetObjLstByRequestTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function sys_RequestType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sys_RequestType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetTopObjLstAsync = sys_RequestType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function sys_RequestType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sys_RequestType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetObjLstByRangeAsync = sys_RequestType_GetObjLstByRangeAsync;
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
    async function sys_RequestType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetObjLstByRange = sys_RequestType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function sys_RequestType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
        if (arrsys_RequestTypeObjLst_Cache.length == 0)
            return arrsys_RequestTypeObjLst_Cache;
        let arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objsys_RequestType_Cond = new clssys_RequestTypeEN_js_1.clssys_RequestTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objsys_RequestType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clssys_RequestTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrsys_RequestType_Sel.length == 0)
                return arrsys_RequestType_Sel;
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
                arrsys_RequestType_Sel = arrsys_RequestType_Sel.sort(sys_RequestType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrsys_RequestType_Sel = arrsys_RequestType_Sel.sort(objPagerPara.sortFun);
            }
            arrsys_RequestType_Sel = arrsys_RequestType_Sel.slice(intStart, intEnd);
            return arrsys_RequestType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.sys_RequestType_GetObjLstByPager_Cache = sys_RequestType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function sys_RequestType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sys_RequestType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = sys_RequestType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetObjLstByPagerAsync = sys_RequestType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strRequestTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function sys_RequestType_DelRecordAsync(strRequestTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strRequestTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_DelRecordAsync = sys_RequestType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrRequestTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function sys_RequestType_Delsys_RequestTypesAsync(arrRequestTypeId) {
        const strThisFuncName = "Delsys_RequestTypesAsync";
        const strAction = "Delsys_RequestTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrRequestTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_Delsys_RequestTypesAsync = sys_RequestType_Delsys_RequestTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function sys_RequestType_Delsys_RequestTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delsys_RequestTypesByCondAsync";
        const strAction = "Delsys_RequestTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_Delsys_RequestTypesByCondAsync = sys_RequestType_Delsys_RequestTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objsys_RequestTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function sys_RequestType_AddNewRecordAsync(objsys_RequestTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objsys_RequestTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objsys_RequestTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_AddNewRecordAsync = sys_RequestType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objsys_RequestTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function sys_RequestType_AddNewRecordWithMaxIdAsync(objsys_RequestTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objsys_RequestTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_AddNewRecordWithMaxIdAsync = sys_RequestType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objsys_RequestTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function sys_RequestType_AddNewRecordWithReturnKeyAsync(objsys_RequestTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objsys_RequestTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_AddNewRecordWithReturnKeyAsync = sys_RequestType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objsys_RequestTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function sys_RequestType_AddNewRecordWithReturnKey(objsys_RequestTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objsys_RequestTypeEN.requestTypeId === null || objsys_RequestTypeEN.requestTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objsys_RequestTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_AddNewRecordWithReturnKey = sys_RequestType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objsys_RequestTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function sys_RequestType_UpdateRecordAsync(objsys_RequestTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objsys_RequestTypeEN.sf_UpdFldSetStr === undefined || objsys_RequestTypeEN.sf_UpdFldSetStr === null || objsys_RequestTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objsys_RequestTypeEN.requestTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objsys_RequestTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_UpdateRecordAsync = sys_RequestType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objsys_RequestTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function sys_RequestType_UpdateWithConditionAsync(objsys_RequestTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objsys_RequestTypeEN.sf_UpdFldSetStr === undefined || objsys_RequestTypeEN.sf_UpdFldSetStr === null || objsys_RequestTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objsys_RequestTypeEN.requestTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        objsys_RequestTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objsys_RequestTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_UpdateWithConditionAsync = sys_RequestType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrRequestTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function sys_RequestType_IsExistRecord_Cache(objsys_RequestType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
        if (arrsys_RequestTypeObjLst_Cache == null)
            return false;
        let arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache;
        if (objsys_RequestType_Cond.sf_FldComparisonOp == null || objsys_RequestType_Cond.sf_FldComparisonOp == "")
            return arrsys_RequestType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objsys_RequestType_Cond.sf_FldComparisonOp);
        //console.log("clssys_RequestTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objsys_RequestType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrsys_RequestType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objsys_RequestType_Cond), exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.sys_RequestType_IsExistRecord_Cache = sys_RequestType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function sys_RequestType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_IsExistRecordAsync = sys_RequestType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strRequestTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function sys_RequestType_IsExist(strRequestTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "RequestTypeId": strRequestTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_IsExist = sys_RequestType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strRequestTypeId:所给的关键字
     * @returns 对象
    */
    async function sys_RequestType_IsExist_Cache(strRequestTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
        if (arrsys_RequestTypeObjLst_Cache == null)
            return false;
        try {
            const arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache.filter(x => x.requestTypeId == strRequestTypeId);
            if (arrsys_RequestType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strRequestTypeId, exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.sys_RequestType_IsExist_Cache = sys_RequestType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strRequestTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function sys_RequestType_IsExistAsync(strRequestTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strRequestTypeId": strRequestTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_IsExistAsync = sys_RequestType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function sys_RequestType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetRecCountByCondAsync = sys_RequestType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objsys_RequestType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function sys_RequestType_GetRecCountByCond_Cache(objsys_RequestType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrsys_RequestTypeObjLst_Cache = await sys_RequestType_GetObjLst_Cache();
        if (arrsys_RequestTypeObjLst_Cache == null)
            return 0;
        let arrsys_RequestType_Sel = arrsys_RequestTypeObjLst_Cache;
        if (objsys_RequestType_Cond.sf_FldComparisonOp == null || objsys_RequestType_Cond.sf_FldComparisonOp == "")
            return arrsys_RequestType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objsys_RequestType_Cond.sf_FldComparisonOp);
        //console.log("clssys_RequestTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objsys_RequestType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objsys_RequestType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrsys_RequestType_Sel = arrsys_RequestType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrsys_RequestType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objsys_RequestType_Cond), exports.sys_RequestType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.sys_RequestType_GetRecCountByCond_Cache = sys_RequestType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function sys_RequestType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetMaxStrIdAsync = sys_RequestType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function sys_RequestType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sys_RequestType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sys_RequestType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.sys_RequestType_GetMaxStrIdByPrefix = sys_RequestType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function sys_RequestType_GetWebApiUrl(strController, strAction) {
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
    exports.sys_RequestType_GetWebApiUrl = sys_RequestType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function sys_RequestType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
        switch (clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheModeId) {
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
    exports.sys_RequestType_ReFreshCache = sys_RequestType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function sys_RequestType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clssys_RequestTypeEN_js_1.clssys_RequestTypeEN._CurrTabName;
            switch (clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.CacheModeId) {
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
    exports.sys_RequestType_ReFreshThisCache = sys_RequestType_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function sys_RequestType_CheckPropertyNew(pobjsys_RequestTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[RequestTypeId(requestTypeId)]的长度不能超过2(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeId)(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[RequestTypeName(requestTypeName)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeName)(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTable) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTable) > 50) {
            throw new Error("(errid:Watl000059)字段[RequestTable(requestTable)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTable)(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTableId) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTableId) > 50) {
            throw new Error("(errid:Watl000059)字段[RequestTableId(requestTableId)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTableId)(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.memo)(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeId) == false && undefined !== pobjsys_RequestTypeEN.requestTypeId && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[RequestTypeId(requestTypeId)]的值:[$(pobjsys_RequestTypeEN.requestTypeId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeName) == false && undefined !== pobjsys_RequestTypeEN.requestTypeName && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[RequestTypeName(requestTypeName)]的值:[$(pobjsys_RequestTypeEN.requestTypeName)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTable) == false && undefined !== pobjsys_RequestTypeEN.requestTable && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTable) === false) {
            throw new Error("(errid:Watl000060)字段[RequestTable(requestTable)]的值:[$(pobjsys_RequestTypeEN.requestTable)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTableId) == false && undefined !== pobjsys_RequestTypeEN.requestTableId && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTableId) === false) {
            throw new Error("(errid:Watl000060)字段[RequestTableId(requestTableId)]的值:[$(pobjsys_RequestTypeEN.requestTableId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.memo) == false && undefined !== pobjsys_RequestTypeEN.memo && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjsys_RequestTypeEN.memo)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjsys_RequestTypeEN.SetIsCheckProperty(true);
    }
    exports.sys_RequestType_CheckPropertyNew = sys_RequestType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function sys_RequestType_CheckProperty4Update(pobjsys_RequestTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[RequestTypeId(requestTypeId)]的长度不能超过2(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeId)(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[RequestTypeName(requestTypeName)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTypeName)(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTable) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTable) > 50) {
            throw new Error("(errid:Watl000062)字段[RequestTable(requestTable)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTable)(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTableId) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.requestTableId) > 50) {
            throw new Error("(errid:Watl000062)字段[RequestTableId(requestTableId)]的长度不能超过50(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.requestTableId)(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjsys_RequestTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 请求类型表(sys_RequestType))!值:$(pobjsys_RequestTypeEN.memo)(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeId) == false && undefined !== pobjsys_RequestTypeEN.requestTypeId && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[RequestTypeId(requestTypeId)]的值:[$(pobjsys_RequestTypeEN.requestTypeId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeName) == false && undefined !== pobjsys_RequestTypeEN.requestTypeName && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[RequestTypeName(requestTypeName)]的值:[$(pobjsys_RequestTypeEN.requestTypeName)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTable) == false && undefined !== pobjsys_RequestTypeEN.requestTable && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTable) === false) {
            throw new Error("(errid:Watl000063)字段[RequestTable(requestTable)]的值:[$(pobjsys_RequestTypeEN.requestTable)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTableId) == false && undefined !== pobjsys_RequestTypeEN.requestTableId && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.requestTableId) === false) {
            throw new Error("(errid:Watl000063)字段[RequestTableId(requestTableId)]的值:[$(pobjsys_RequestTypeEN.requestTableId)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.memo) == false && undefined !== pobjsys_RequestTypeEN.memo && clsString_js_1.tzDataType.isString(pobjsys_RequestTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjsys_RequestTypeEN.memo)], 非法，应该为字符型(In 请求类型表(sys_RequestType))!(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjsys_RequestTypeEN.requestTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[RequestTypeId]不能为空(In 请求类型表)!(clssys_RequestTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjsys_RequestTypeEN.SetIsCheckProperty(true);
    }
    exports.sys_RequestType_CheckProperty4Update = sys_RequestType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function sys_RequestType_GetJSONStrByObj(pobjsys_RequestTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjsys_RequestTypeEN.sf_UpdFldSetStr = pobjsys_RequestTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjsys_RequestTypeEN);
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
    exports.sys_RequestType_GetJSONStrByObj = sys_RequestType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function sys_RequestType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrsys_RequestTypeObjLst = new Array();
        if (strJSON === "") {
            return arrsys_RequestTypeObjLst;
        }
        try {
            arrsys_RequestTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrsys_RequestTypeObjLst;
        }
        return arrsys_RequestTypeObjLst;
    }
    exports.sys_RequestType_GetObjLstByJSONStr = sys_RequestType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrsys_RequestTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function sys_RequestType_GetObjLstByJSONObjLst(arrsys_RequestTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrsys_RequestTypeObjLst = new Array();
        for (const objInFor of arrsys_RequestTypeObjLstS) {
            const obj1 = sys_RequestType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrsys_RequestTypeObjLst.push(obj1);
        }
        return arrsys_RequestTypeObjLst;
    }
    exports.sys_RequestType_GetObjLstByJSONObjLst = sys_RequestType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function sys_RequestType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjsys_RequestTypeEN = new clssys_RequestTypeEN_js_1.clssys_RequestTypeEN();
        if (strJSON === "") {
            return pobjsys_RequestTypeEN;
        }
        try {
            pobjsys_RequestTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjsys_RequestTypeEN;
        }
        return pobjsys_RequestTypeEN;
    }
    exports.sys_RequestType_GetObjByJSONStr = sys_RequestType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function sys_RequestType_GetCombineCondition(objsys_RequestType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId) == true) {
            const strComparisonOp_RequestTypeId = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeId, objsys_RequestType_Cond.requestTypeId, strComparisonOp_RequestTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeName) == true) {
            const strComparisonOp_RequestTypeName = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTypeName, objsys_RequestType_Cond.requestTypeName, strComparisonOp_RequestTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTable) == true) {
            const strComparisonOp_RequestTable = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTable];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTable, objsys_RequestType_Cond.requestTable, strComparisonOp_RequestTable);
        }
        if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTableId) == true) {
            const strComparisonOp_RequestTableId = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTableId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_RequestTableId, objsys_RequestType_Cond.requestTableId, strComparisonOp_RequestTableId);
        }
        if (Object.prototype.hasOwnProperty.call(objsys_RequestType_Cond.dicFldComparisonOp, clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objsys_RequestType_Cond.dicFldComparisonOp[clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clssys_RequestTypeEN_js_1.clssys_RequestTypeEN.con_Memo, objsys_RequestType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.sys_RequestType_GetCombineCondition = sys_RequestType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--sys_RequestType(请求类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strRequestTableId: RequestTableId(要求唯一的字段)
    * @param strRequestTypeId: RequestTypeId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function sys_RequestType_GetUniCondStr_RequestTableId_RequestTypeId(objsys_RequestTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and RequestTableId = '{0}'", objsys_RequestTypeEN.requestTableId);
        strWhereCond += (0, clsString_js_2.Format)(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.requestTypeId);
        return strWhereCond;
    }
    exports.sys_RequestType_GetUniCondStr_RequestTableId_RequestTypeId = sys_RequestType_GetUniCondStr_RequestTableId_RequestTypeId;
    /**
    *获取唯一性条件串(Uniqueness)--sys_RequestType(请求类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strRequestTableId: RequestTableId(要求唯一的字段)
    * @param strRequestTypeId: RequestTypeId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function sys_RequestType_GetUniCondStr4Update_RequestTableId_RequestTypeId(objsys_RequestTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and RequestTypeId <> '{0}'", objsys_RequestTypeEN.requestTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and RequestTableId = '{0}'", objsys_RequestTypeEN.requestTableId);
        strWhereCond += (0, clsString_js_2.Format)(" and RequestTypeId = '{0}'", objsys_RequestTypeEN.requestTypeId);
        return strWhereCond;
    }
    exports.sys_RequestType_GetUniCondStr4Update_RequestTableId_RequestTypeId = sys_RequestType_GetUniCondStr4Update_RequestTableId_RequestTypeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objsys_RequestTypeENS:源对象
     * @param objsys_RequestTypeENT:目标对象
    */
    function sys_RequestType_CopyObjTo(objsys_RequestTypeENS, objsys_RequestTypeENT) {
        objsys_RequestTypeENT.requestTypeId = objsys_RequestTypeENS.requestTypeId; //RequestTypeId
        objsys_RequestTypeENT.requestTypeName = objsys_RequestTypeENS.requestTypeName; //RequestTypeName
        objsys_RequestTypeENT.requestTable = objsys_RequestTypeENS.requestTable; //RequestTable
        objsys_RequestTypeENT.requestTableId = objsys_RequestTypeENS.requestTableId; //RequestTableId
        objsys_RequestTypeENT.memo = objsys_RequestTypeENS.memo; //备注
        objsys_RequestTypeENT.sf_UpdFldSetStr = objsys_RequestTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.sys_RequestType_CopyObjTo = sys_RequestType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objsys_RequestTypeENS:源对象
     * @param objsys_RequestTypeENT:目标对象
    */
    function sys_RequestType_GetObjFromJsonObj(objsys_RequestTypeENS) {
        const objsys_RequestTypeENT = new clssys_RequestTypeEN_js_1.clssys_RequestTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objsys_RequestTypeENT, objsys_RequestTypeENS);
        return objsys_RequestTypeENT;
    }
    exports.sys_RequestType_GetObjFromJsonObj = sys_RequestType_GetObjFromJsonObj;
});
