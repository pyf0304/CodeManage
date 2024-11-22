/**
* 类名:clsSubViewpointTypeWApi
* 表名:SubViewpointType(01120533)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:55:22
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/ParameterTable/clsSubViewpointTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SubViewpointType_GetObjFromJsonObj = exports.SubViewpointType_CopyObjTo = exports.SubViewpointType_GetUniCondStr4Update_SubViewpointTypeName = exports.SubViewpointType_GetUniCondStr_SubViewpointTypeName = exports.SubViewpointType_GetCombineCondition = exports.SubViewpointType_GetObjByJSONStr = exports.SubViewpointType_GetObjLstByJSONObjLst = exports.SubViewpointType_GetObjLstByJSONStr = exports.SubViewpointType_GetJSONStrByObj = exports.SubViewpointType_CheckProperty4Update = exports.SubViewpointType_CheckPropertyNew = exports.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache = exports.SubViewpointType_ReFreshThisCache = exports.SubViewpointType_ReFreshCache = exports.SubViewpointType_GetWebApiUrl = exports.SubViewpointType_GetMaxStrIdByPrefix = exports.SubViewpointType_GetMaxStrIdAsync = exports.SubViewpointType_GetRecCountByCond_Cache = exports.SubViewpointType_GetRecCountByCondAsync = exports.SubViewpointType_IsExistAsync = exports.SubViewpointType_IsExist_Cache = exports.SubViewpointType_IsExist = exports.SubViewpointType_IsExistRecordAsync = exports.SubViewpointType_IsExistRecord_Cache = exports.SubViewpointType_UpdateWithConditionAsync = exports.SubViewpointType_UpdateRecordAsync = exports.SubViewpointType_AddNewRecordWithReturnKey = exports.SubViewpointType_AddNewRecordWithReturnKeyAsync = exports.SubViewpointType_ReOrderAsync = exports.SubViewpointType_GoBottomAsync = exports.SubViewpointType_DownMoveAsync = exports.SubViewpointType_UpMoveAsync = exports.SubViewpointType_GoTopAsync = exports.SubViewpointType_AddNewRecordWithMaxIdAsync = exports.SubViewpointType_AddNewRecordAsync = exports.SubViewpointType_DelSubViewpointTypesByCondAsync = exports.SubViewpointType_DelSubViewpointTypesAsync = exports.SubViewpointType_DelRecordAsync = exports.SubViewpointType_GetObjLstByPagerAsync = exports.SubViewpointType_GetObjLstByPager_Cache = exports.SubViewpointType_GetObjLstByRange = exports.SubViewpointType_GetObjLstByRangeAsync = exports.SubViewpointType_GetTopObjLstAsync = exports.SubViewpointType_GetObjLstBySubViewpointTypeIdLst_Cache = exports.SubViewpointType_GetObjLstBySubViewpointTypeIdLstAsync = exports.SubViewpointType_GetSubObjLst_Cache = exports.SubViewpointType_GetObjLst_PureCache = exports.SubViewpointType_GetObjLst_Cache = exports.SubViewpointType_GetObjLst_sessionStorage_PureCache = exports.SubViewpointType_GetObjLst_sessionStorage = exports.SubViewpointType_GetObjLstAsync = exports.SubViewpointType_GetObjLst_localStorage_PureCache = exports.SubViewpointType_GetObjLst_localStorage = exports.SubViewpointType_GetObjLst_ClientCache = exports.SubViewpointType_GetFirstObjAsync = exports.SubViewpointType_GetFirstID = exports.SubViewpointType_GetFirstIDAsync = exports.SubViewpointType_funcKey = exports.SubViewpointType_FilterFunByKey = exports.SubViewpointType_SortFunByKey = exports.SubViewpointType_SortFun_Defa_2Fld = exports.SubViewpointType_SortFun_Defa = exports.SubViewpointType_func = exports.SubViewpointType_GetNameBySubViewpointTypeId_Cache = exports.SubViewpointType_UpdateObjInLst_Cache = exports.SubViewpointType_GetObjBySubViewpointTypeId_localStorage = exports.SubViewpointType_GetObjBySubViewpointTypeId_Cache = exports.SubViewpointType_GetObjBySubViewpointTypeIdAsync = exports.subViewpointType_ConstructorName = exports.subViewpointType_Controller = void 0;
    /**
     * 子观点类型表(SubViewpointType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSubViewpointTypeEN_js_1 = require("../../L0_Entity/ParameterTable/clsSubViewpointTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.subViewpointType_Controller = "SubViewpointTypeApi";
    exports.subViewpointType_ConstructorName = "subViewpointType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSubViewpointTypeId:关键字
    * @returns 对象
    **/
    async function SubViewpointType_GetObjBySubViewpointTypeIdAsync(strSubViewpointTypeId) {
        const strThisFuncName = "GetObjBySubViewpointTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSubViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSubViewpointTypeId]不能为空！(In clsSubViewpointTypeWApi.GetObjBySubViewpointTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointTypeId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSubViewpointTypeId]的长度:[{0}]不正确！(clsSubViewpointTypeWApi.GetObjBySubViewpointTypeIdAsync)", strSubViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySubViewpointTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSubViewpointTypeId": strSubViewpointTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSubViewpointType = SubViewpointType_GetObjFromJsonObj(returnObj);
                return objSubViewpointType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetObjBySubViewpointTypeIdAsync = SubViewpointType_GetObjBySubViewpointTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSubViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function SubViewpointType_GetObjBySubViewpointTypeId_Cache(strSubViewpointTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySubViewpointTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSubViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSubViewpointTypeId]不能为空！(In clsSubViewpointTypeWApi.GetObjBySubViewpointTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointTypeId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSubViewpointTypeId]的长度:[{0}]不正确！(clsSubViewpointTypeWApi.GetObjBySubViewpointTypeId_Cache)", strSubViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        try {
            const arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache.filter(x => x.subViewpointTypeId == strSubViewpointTypeId);
            let objSubViewpointType;
            if (arrSubViewpointType_Sel.length > 0) {
                objSubViewpointType = arrSubViewpointType_Sel[0];
                return objSubViewpointType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objSubViewpointType_Const = await SubViewpointType_GetObjBySubViewpointTypeIdAsync(strSubViewpointTypeId);
                    if (objSubViewpointType_Const != null) {
                        SubViewpointType_ReFreshThisCache();
                        return objSubViewpointType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointTypeId, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SubViewpointType_GetObjBySubViewpointTypeId_Cache = SubViewpointType_GetObjBySubViewpointTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSubViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function SubViewpointType_GetObjBySubViewpointTypeId_localStorage(strSubViewpointTypeId) {
        const strThisFuncName = "GetObjBySubViewpointTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSubViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSubViewpointTypeId]不能为空！(In clsSubViewpointTypeWApi.GetObjBySubViewpointTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointTypeId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSubViewpointTypeId]的长度:[{0}]不正确！(clsSubViewpointTypeWApi.GetObjBySubViewpointTypeId_localStorage)", strSubViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName, strSubViewpointTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSubViewpointType_Cache = JSON.parse(strTempObj);
            return objSubViewpointType_Cache;
        }
        try {
            const objSubViewpointType = await SubViewpointType_GetObjBySubViewpointTypeIdAsync(strSubViewpointTypeId);
            if (objSubViewpointType != null) {
                localStorage.setItem(strKey, JSON.stringify(objSubViewpointType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSubViewpointType;
            }
            return objSubViewpointType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointTypeId, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SubViewpointType_GetObjBySubViewpointTypeId_localStorage = SubViewpointType_GetObjBySubViewpointTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSubViewpointType:所给的对象
     * @returns 对象
    */
    async function SubViewpointType_UpdateObjInLst_Cache(objSubViewpointType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
            const obj = arrSubViewpointTypeObjLst_Cache.find(x => x.subViewpointTypeName == objSubViewpointType.subViewpointTypeName);
            if (obj != null) {
                objSubViewpointType.subViewpointTypeId = obj.subViewpointTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSubViewpointType);
            }
            else {
                arrSubViewpointTypeObjLst_Cache.push(objSubViewpointType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SubViewpointType_UpdateObjInLst_Cache = SubViewpointType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strSubViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function SubViewpointType_GetNameBySubViewpointTypeId_Cache(strSubViewpointTypeId) {
        const strThisFuncName = "GetNameBySubViewpointTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strSubViewpointTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strSubViewpointTypeId]不能为空！(In clsSubViewpointTypeWApi.GetNameBySubViewpointTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointTypeId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strSubViewpointTypeId]的长度:[{0}]不正确！(clsSubViewpointTypeWApi.GetNameBySubViewpointTypeId_Cache)", strSubViewpointTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        if (arrSubViewpointTypeObjLst_Cache == null)
            return "";
        try {
            const arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache.filter(x => x.subViewpointTypeId == strSubViewpointTypeId);
            let objSubViewpointType;
            if (arrSubViewpointType_Sel.length > 0) {
                objSubViewpointType = arrSubViewpointType_Sel[0];
                return objSubViewpointType.subViewpointTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSubViewpointTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.SubViewpointType_GetNameBySubViewpointTypeId_Cache = SubViewpointType_GetNameBySubViewpointTypeId_Cache;
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
    async function SubViewpointType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSubViewpointTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSubViewpointType = await SubViewpointType_GetObjBySubViewpointTypeId_Cache(strSubViewpointTypeId);
        if (objSubViewpointType == null)
            return "";
        if (objSubViewpointType.GetFldValue(strOutFldName) == null)
            return "";
        return objSubViewpointType.GetFldValue(strOutFldName).toString();
    }
    exports.SubViewpointType_func = SubViewpointType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SubViewpointType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.subViewpointTypeId.localeCompare(b.subViewpointTypeId);
    }
    exports.SubViewpointType_SortFun_Defa = SubViewpointType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SubViewpointType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.subViewpointTypeName == b.subViewpointTypeName)
            return a.subViewpointTypeENName.localeCompare(b.subViewpointTypeENName);
        else
            return a.subViewpointTypeName.localeCompare(b.subViewpointTypeName);
    }
    exports.SubViewpointType_SortFun_Defa_2Fld = SubViewpointType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SubViewpointType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId:
                    return (a, b) => {
                        return a.subViewpointTypeId.localeCompare(b.subViewpointTypeId);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName:
                    return (a, b) => {
                        if (a.subViewpointTypeName == null)
                            return -1;
                        if (b.subViewpointTypeName == null)
                            return 1;
                        return a.subViewpointTypeName.localeCompare(b.subViewpointTypeName);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeENName:
                    return (a, b) => {
                        if (a.subViewpointTypeENName == null)
                            return -1;
                        if (b.subViewpointTypeENName == null)
                            return 1;
                        return a.subViewpointTypeENName.localeCompare(b.subViewpointTypeENName);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_DefaTitle:
                    return (a, b) => {
                        if (a.defaTitle == null)
                            return -1;
                        if (b.defaTitle == null)
                            return 1;
                        return a.defaTitle.localeCompare(b.defaTitle);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SubViewpointType]中不存在！(in ${exports.subViewpointType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId:
                    return (a, b) => {
                        return b.subViewpointTypeId.localeCompare(a.subViewpointTypeId);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName:
                    return (a, b) => {
                        if (b.subViewpointTypeName == null)
                            return -1;
                        if (a.subViewpointTypeName == null)
                            return 1;
                        return b.subViewpointTypeName.localeCompare(a.subViewpointTypeName);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeENName:
                    return (a, b) => {
                        if (b.subViewpointTypeENName == null)
                            return -1;
                        if (a.subViewpointTypeENName == null)
                            return 1;
                        return b.subViewpointTypeENName.localeCompare(a.subViewpointTypeENName);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_DefaTitle:
                    return (a, b) => {
                        if (b.defaTitle == null)
                            return -1;
                        if (a.defaTitle == null)
                            return 1;
                        return b.defaTitle.localeCompare(a.defaTitle);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SubViewpointType]中不存在！(in ${exports.subViewpointType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SubViewpointType_SortFunByKey = SubViewpointType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SubViewpointType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId:
                return (obj) => {
                    return obj.subViewpointTypeId === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName:
                return (obj) => {
                    return obj.subViewpointTypeName === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeENName:
                return (obj) => {
                    return obj.subViewpointTypeENName === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_DefaTitle:
                return (obj) => {
                    return obj.defaTitle === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SubViewpointType]中不存在！(in ${exports.subViewpointType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SubViewpointType_FilterFunByKey = SubViewpointType_FilterFunByKey;
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
    async function SubViewpointType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrSubViewpointType = await SubViewpointType_GetObjLst_Cache();
        if (arrSubViewpointType == null)
            return [];
        let arrSubViewpointType_Sel = arrSubViewpointType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrSubViewpointType_Sel.length == 0)
            return [];
        return arrSubViewpointType_Sel.map(x => x.subViewpointTypeId);
    }
    exports.SubViewpointType_funcKey = SubViewpointType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SubViewpointType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetFirstIDAsync = SubViewpointType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SubViewpointType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetFirstID = SubViewpointType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SubViewpointType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const objSubViewpointType = SubViewpointType_GetObjFromJsonObj(returnObj);
                return objSubViewpointType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetFirstObjAsync = SubViewpointType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSubViewpointTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrSubViewpointTypeObjLst_T = SubViewpointType_GetObjLstByJSONObjLst(arrSubViewpointTypeExObjLst_Cache);
            return arrSubViewpointTypeObjLst_T;
        }
        try {
            const arrSubViewpointTypeExObjLst = await SubViewpointType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrSubViewpointTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSubViewpointTypeExObjLst.length);
            console.log(strInfo);
            return arrSubViewpointTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SubViewpointType_GetObjLst_ClientCache = SubViewpointType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSubViewpointTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSubViewpointTypeObjLst_T = SubViewpointType_GetObjLstByJSONObjLst(arrSubViewpointTypeExObjLst_Cache);
            return arrSubViewpointTypeObjLst_T;
        }
        try {
            const arrSubViewpointTypeExObjLst = await SubViewpointType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSubViewpointTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSubViewpointTypeExObjLst.length);
            console.log(strInfo);
            return arrSubViewpointTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SubViewpointType_GetObjLst_localStorage = SubViewpointType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSubViewpointTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSubViewpointTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.SubViewpointType_GetObjLst_localStorage_PureCache = SubViewpointType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SubViewpointType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.subViewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SubViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetObjLstAsync = SubViewpointType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSubViewpointTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSubViewpointTypeObjLst_T = SubViewpointType_GetObjLstByJSONObjLst(arrSubViewpointTypeExObjLst_Cache);
            return arrSubViewpointTypeObjLst_T;
        }
        try {
            const arrSubViewpointTypeExObjLst = await SubViewpointType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSubViewpointTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSubViewpointTypeExObjLst.length);
            console.log(strInfo);
            return arrSubViewpointTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SubViewpointType_GetObjLst_sessionStorage = SubViewpointType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSubViewpointTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSubViewpointTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.SubViewpointType_GetObjLst_sessionStorage_PureCache = SubViewpointType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrSubViewpointTypeObjLst_Cache;
        switch (clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_ClientCache();
                break;
            default:
                arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_ClientCache();
                break;
        }
        const arrSubViewpointTypeObjLst = SubViewpointType_GetObjLstByJSONObjLst(arrSubViewpointTypeObjLst_Cache);
        return arrSubViewpointTypeObjLst_Cache;
    }
    exports.SubViewpointType_GetObjLst_Cache = SubViewpointType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SubViewpointType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSubViewpointTypeObjLst_Cache;
        switch (clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrSubViewpointTypeObjLst_Cache = null;
                break;
            default:
                arrSubViewpointTypeObjLst_Cache = null;
                break;
        }
        return arrSubViewpointTypeObjLst_Cache;
    }
    exports.SubViewpointType_GetObjLst_PureCache = SubViewpointType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSubViewpointTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SubViewpointType_GetSubObjLst_Cache(objSubViewpointType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        let arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache;
        if (objSubViewpointType_Cond.sf_FldComparisonOp == null || objSubViewpointType_Cond.sf_FldComparisonOp == "")
            return arrSubViewpointType_Sel;
        const dicFldComparisonOp = JSON.parse(objSubViewpointType_Cond.sf_FldComparisonOp);
        //console.log("clsSubViewpointTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSubViewpointType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSubViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSubViewpointType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSubViewpointType_Cond), exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SubViewpointType_GetSubObjLst_Cache = SubViewpointType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSubViewpointTypeId:关键字列表
    * @returns 对象列表
    **/
    async function SubViewpointType_GetObjLstBySubViewpointTypeIdLstAsync(arrSubViewpointTypeId) {
        const strThisFuncName = "GetObjLstBySubViewpointTypeIdLstAsync";
        const strAction = "GetObjLstBySubViewpointTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubViewpointTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.subViewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SubViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetObjLstBySubViewpointTypeIdLstAsync = SubViewpointType_GetObjLstBySubViewpointTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSubViewpointTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function SubViewpointType_GetObjLstBySubViewpointTypeIdLst_Cache(arrSubViewpointTypeIdLst) {
        const strThisFuncName = "GetObjLstBySubViewpointTypeIdLst_Cache";
        try {
            const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
            const arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache.filter(x => arrSubViewpointTypeIdLst.indexOf(x.subViewpointTypeId) > -1);
            return arrSubViewpointType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSubViewpointTypeIdLst.join(","), exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.SubViewpointType_GetObjLstBySubViewpointTypeIdLst_Cache = SubViewpointType_GetObjLstBySubViewpointTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SubViewpointType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.subViewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SubViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetTopObjLstAsync = SubViewpointType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SubViewpointType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.subViewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SubViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetObjLstByRangeAsync = SubViewpointType_GetObjLstByRangeAsync;
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
    async function SubViewpointType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetObjLstByRange = SubViewpointType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SubViewpointType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        if (arrSubViewpointTypeObjLst_Cache.length == 0)
            return arrSubViewpointTypeObjLst_Cache;
        let arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSubViewpointType_Cond = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSubViewpointType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSubViewpointTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSubViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSubViewpointType_Sel.length == 0)
                return arrSubViewpointType_Sel;
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
                arrSubViewpointType_Sel = arrSubViewpointType_Sel.sort(SubViewpointType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSubViewpointType_Sel = arrSubViewpointType_Sel.sort(objPagerPara.sortFun);
            }
            arrSubViewpointType_Sel = arrSubViewpointType_Sel.slice(intStart, intEnd);
            return arrSubViewpointType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SubViewpointType_GetObjLstByPager_Cache = SubViewpointType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SubViewpointType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.subViewpointType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SubViewpointType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetObjLstByPagerAsync = SubViewpointType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSubViewpointTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function SubViewpointType_DelRecordAsync(strSubViewpointTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strSubViewpointTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_DelRecordAsync = SubViewpointType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSubViewpointTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SubViewpointType_DelSubViewpointTypesAsync(arrSubViewpointTypeId) {
        const strThisFuncName = "DelSubViewpointTypesAsync";
        const strAction = "DelSubViewpointTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubViewpointTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_DelSubViewpointTypesAsync = SubViewpointType_DelSubViewpointTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SubViewpointType_DelSubViewpointTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSubViewpointTypesByCondAsync";
        const strAction = "DelSubViewpointTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_DelSubViewpointTypesByCondAsync = SubViewpointType_DelSubViewpointTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_AddNewRecordAsync(objSubViewpointTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSubViewpointTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSubViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_AddNewRecordAsync = SubViewpointType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_AddNewRecordWithMaxIdAsync(objSubViewpointTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSubViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_AddNewRecordWithMaxIdAsync = SubViewpointType_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GoTopAsync = SubViewpointType_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSubViewpointTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_UpMoveAsync = SubViewpointType_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSubViewpointTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_DownMoveAsync = SubViewpointType_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objSubViewpointTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GoBottomAsync = SubViewpointType_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SubViewpointType_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objSubViewpointTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_ReOrderAsync = SubViewpointType_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSubViewpointTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SubViewpointType_AddNewRecordWithReturnKeyAsync(objSubViewpointTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSubViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_AddNewRecordWithReturnKeyAsync = SubViewpointType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSubViewpointTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SubViewpointType_AddNewRecordWithReturnKey(objSubViewpointTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSubViewpointTypeEN.subViewpointTypeId === null || objSubViewpointTypeEN.subViewpointTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSubViewpointTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_AddNewRecordWithReturnKey = SubViewpointType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSubViewpointTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SubViewpointType_UpdateRecordAsync(objSubViewpointTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSubViewpointTypeEN.sf_UpdFldSetStr === undefined || objSubViewpointTypeEN.sf_UpdFldSetStr === null || objSubViewpointTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSubViewpointTypeEN.subViewpointTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSubViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_UpdateRecordAsync = SubViewpointType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSubViewpointTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SubViewpointType_UpdateWithConditionAsync(objSubViewpointTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSubViewpointTypeEN.sf_UpdFldSetStr === undefined || objSubViewpointTypeEN.sf_UpdFldSetStr === null || objSubViewpointTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSubViewpointTypeEN.subViewpointTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        objSubViewpointTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSubViewpointTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_UpdateWithConditionAsync = SubViewpointType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSubViewpointTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SubViewpointType_IsExistRecord_Cache(objSubViewpointType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        if (arrSubViewpointTypeObjLst_Cache == null)
            return false;
        let arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache;
        if (objSubViewpointType_Cond.sf_FldComparisonOp == null || objSubViewpointType_Cond.sf_FldComparisonOp == "")
            return arrSubViewpointType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSubViewpointType_Cond.sf_FldComparisonOp);
        //console.log("clsSubViewpointTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSubViewpointType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSubViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSubViewpointType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSubViewpointType_Cond), exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SubViewpointType_IsExistRecord_Cache = SubViewpointType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SubViewpointType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_IsExistRecordAsync = SubViewpointType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSubViewpointTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SubViewpointType_IsExist(strSubViewpointTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SubViewpointTypeId": strSubViewpointTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_IsExist = SubViewpointType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSubViewpointTypeId:所给的关键字
     * @returns 对象
    */
    async function SubViewpointType_IsExist_Cache(strSubViewpointTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        if (arrSubViewpointTypeObjLst_Cache == null)
            return false;
        try {
            const arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache.filter(x => x.subViewpointTypeId == strSubViewpointTypeId);
            if (arrSubViewpointType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSubViewpointTypeId, exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SubViewpointType_IsExist_Cache = SubViewpointType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSubViewpointTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SubViewpointType_IsExistAsync(strSubViewpointTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSubViewpointTypeId": strSubViewpointTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_IsExistAsync = SubViewpointType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SubViewpointType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetRecCountByCondAsync = SubViewpointType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSubViewpointType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SubViewpointType_GetRecCountByCond_Cache(objSubViewpointType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSubViewpointTypeObjLst_Cache = await SubViewpointType_GetObjLst_Cache();
        if (arrSubViewpointTypeObjLst_Cache == null)
            return 0;
        let arrSubViewpointType_Sel = arrSubViewpointTypeObjLst_Cache;
        if (objSubViewpointType_Cond.sf_FldComparisonOp == null || objSubViewpointType_Cond.sf_FldComparisonOp == "")
            return arrSubViewpointType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSubViewpointType_Cond.sf_FldComparisonOp);
        //console.log("clsSubViewpointTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSubViewpointType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSubViewpointType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSubViewpointType_Sel = arrSubViewpointType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSubViewpointType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSubViewpointType_Cond), exports.subViewpointType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SubViewpointType_GetRecCountByCond_Cache = SubViewpointType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function SubViewpointType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetMaxStrIdAsync = SubViewpointType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function SubViewpointType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.subViewpointType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.subViewpointType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SubViewpointType_GetMaxStrIdByPrefix = SubViewpointType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SubViewpointType_GetWebApiUrl(strController, strAction) {
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
    exports.SubViewpointType_GetWebApiUrl = SubViewpointType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SubViewpointType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
        switch (clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheModeId) {
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
    exports.SubViewpointType_ReFreshCache = SubViewpointType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SubViewpointType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN._CurrTabName;
            switch (clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.CacheModeId) {
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
    exports.SubViewpointType_ReFreshThisCache = SubViewpointType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_SubViewpointTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_SubViewpointTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_SubViewpointTypeIdInDiv_Cache");
        const arrObjLst_Sel = await SubViewpointType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName, "子观点类型表");
    }
    exports.SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache = SubViewpointType_BindDdl_SubViewpointTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SubViewpointType_CheckPropertyNew(pobjSubViewpointTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.subViewpointTypeId) > 8) {
            throw new Error("(errid:Watl000059)字段[类型Id(subViewpointTypeId)]的长度不能超过8(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.subViewpointTypeId)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.subViewpointTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[类型名称(subViewpointTypeName)]的长度不能超过50(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.subViewpointTypeName)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.subViewpointTypeENName) > 100) {
            throw new Error("(errid:Watl000059)字段[类型英文名(subViewpointTypeENName)]的长度不能超过100(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.subViewpointTypeENName)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.defaTitle) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.defaTitle) > 20) {
            throw new Error("(errid:Watl000059)字段[默认标题(defaTitle)]的长度不能超过20(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.defaTitle)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.updDate)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.updUserId)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.memo)(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeId) == false && undefined !== pobjSubViewpointTypeEN.subViewpointTypeId && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.subViewpointTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[类型Id(subViewpointTypeId)]的值:[$(pobjSubViewpointTypeEN.subViewpointTypeId)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeName) == false && undefined !== pobjSubViewpointTypeEN.subViewpointTypeName && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.subViewpointTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[类型名称(subViewpointTypeName)]的值:[$(pobjSubViewpointTypeEN.subViewpointTypeName)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeENName) == false && undefined !== pobjSubViewpointTypeEN.subViewpointTypeENName && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.subViewpointTypeENName) === false) {
            throw new Error("(errid:Watl000060)字段[类型英文名(subViewpointTypeENName)]的值:[$(pobjSubViewpointTypeEN.subViewpointTypeENName)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.defaTitle) == false && undefined !== pobjSubViewpointTypeEN.defaTitle && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.defaTitle) === false) {
            throw new Error("(errid:Watl000060)字段[默认标题(defaTitle)]的值:[$(pobjSubViewpointTypeEN.defaTitle)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if (null != pobjSubViewpointTypeEN.orderNum && undefined !== pobjSubViewpointTypeEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjSubViewpointTypeEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjSubViewpointTypeEN.orderNum)], 非法，应该为数值型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updDate) == false && undefined !== pobjSubViewpointTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSubViewpointTypeEN.updDate)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updUserId) == false && undefined !== pobjSubViewpointTypeEN.updUserId && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjSubViewpointTypeEN.updUserId)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.memo) == false && undefined !== pobjSubViewpointTypeEN.memo && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSubViewpointTypeEN.memo)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSubViewpointTypeEN.SetIsCheckProperty(true);
    }
    exports.SubViewpointType_CheckPropertyNew = SubViewpointType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SubViewpointType_CheckProperty4Update(pobjSubViewpointTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.subViewpointTypeId) > 8) {
            throw new Error("(errid:Watl000062)字段[类型Id(subViewpointTypeId)]的长度不能超过8(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.subViewpointTypeId)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.subViewpointTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[类型名称(subViewpointTypeName)]的长度不能超过50(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.subViewpointTypeName)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.subViewpointTypeENName) > 100) {
            throw new Error("(errid:Watl000062)字段[类型英文名(subViewpointTypeENName)]的长度不能超过100(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.subViewpointTypeENName)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.defaTitle) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.defaTitle) > 20) {
            throw new Error("(errid:Watl000062)字段[默认标题(defaTitle)]的长度不能超过20(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.defaTitle)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.updDate)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updUserId) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.updUserId)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSubViewpointTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 子观点类型表(SubViewpointType))!值:$(pobjSubViewpointTypeEN.memo)(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeId) == false && undefined !== pobjSubViewpointTypeEN.subViewpointTypeId && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.subViewpointTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[类型Id(subViewpointTypeId)]的值:[$(pobjSubViewpointTypeEN.subViewpointTypeId)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeName) == false && undefined !== pobjSubViewpointTypeEN.subViewpointTypeName && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.subViewpointTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[类型名称(subViewpointTypeName)]的值:[$(pobjSubViewpointTypeEN.subViewpointTypeName)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeENName) == false && undefined !== pobjSubViewpointTypeEN.subViewpointTypeENName && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.subViewpointTypeENName) === false) {
            throw new Error("(errid:Watl000063)字段[类型英文名(subViewpointTypeENName)]的值:[$(pobjSubViewpointTypeEN.subViewpointTypeENName)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.defaTitle) == false && undefined !== pobjSubViewpointTypeEN.defaTitle && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.defaTitle) === false) {
            throw new Error("(errid:Watl000063)字段[默认标题(defaTitle)]的值:[$(pobjSubViewpointTypeEN.defaTitle)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if (null != pobjSubViewpointTypeEN.orderNum && undefined !== pobjSubViewpointTypeEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjSubViewpointTypeEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjSubViewpointTypeEN.orderNum)], 非法，应该为数值型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updDate) == false && undefined !== pobjSubViewpointTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSubViewpointTypeEN.updDate)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.updUserId) == false && undefined !== pobjSubViewpointTypeEN.updUserId && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjSubViewpointTypeEN.updUserId)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.memo) == false && undefined !== pobjSubViewpointTypeEN.memo && clsString_js_1.tzDataType.isString(pobjSubViewpointTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSubViewpointTypeEN.memo)], 非法，应该为字符型(In 子观点类型表(SubViewpointType))!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSubViewpointTypeEN.subViewpointTypeId) === true
            || pobjSubViewpointTypeEN.subViewpointTypeId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[类型Id]不能为空(In 子观点类型表)!(clsSubViewpointTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSubViewpointTypeEN.SetIsCheckProperty(true);
    }
    exports.SubViewpointType_CheckProperty4Update = SubViewpointType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SubViewpointType_GetJSONStrByObj(pobjSubViewpointTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSubViewpointTypeEN.sf_UpdFldSetStr = pobjSubViewpointTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSubViewpointTypeEN);
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
    exports.SubViewpointType_GetJSONStrByObj = SubViewpointType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SubViewpointType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSubViewpointTypeObjLst = new Array();
        if (strJSON === "") {
            return arrSubViewpointTypeObjLst;
        }
        try {
            arrSubViewpointTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSubViewpointTypeObjLst;
        }
        return arrSubViewpointTypeObjLst;
    }
    exports.SubViewpointType_GetObjLstByJSONStr = SubViewpointType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSubViewpointTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SubViewpointType_GetObjLstByJSONObjLst(arrSubViewpointTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSubViewpointTypeObjLst = new Array();
        for (const objInFor of arrSubViewpointTypeObjLstS) {
            const obj1 = SubViewpointType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSubViewpointTypeObjLst.push(obj1);
        }
        return arrSubViewpointTypeObjLst;
    }
    exports.SubViewpointType_GetObjLstByJSONObjLst = SubViewpointType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SubViewpointType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSubViewpointTypeEN = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN();
        if (strJSON === "") {
            return pobjSubViewpointTypeEN;
        }
        try {
            pobjSubViewpointTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSubViewpointTypeEN;
        }
        return pobjSubViewpointTypeEN;
    }
    exports.SubViewpointType_GetObjByJSONStr = SubViewpointType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SubViewpointType_GetCombineCondition(objSubViewpointType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId) == true) {
            const strComparisonOp_SubViewpointTypeId = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeId, objSubViewpointType_Cond.subViewpointTypeId, strComparisonOp_SubViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName) == true) {
            const strComparisonOp_SubViewpointTypeName = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeName, objSubViewpointType_Cond.subViewpointTypeName, strComparisonOp_SubViewpointTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeENName) == true) {
            const strComparisonOp_SubViewpointTypeENName = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_SubViewpointTypeENName, objSubViewpointType_Cond.subViewpointTypeENName, strComparisonOp_SubViewpointTypeENName);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_DefaTitle) == true) {
            const strComparisonOp_DefaTitle = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_DefaTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_DefaTitle, objSubViewpointType_Cond.defaTitle, strComparisonOp_DefaTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_OrderNum, objSubViewpointType_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdDate, objSubViewpointType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_UpdUserId, objSubViewpointType_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objSubViewpointType_Cond.dicFldComparisonOp, clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSubViewpointType_Cond.dicFldComparisonOp[clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN.con_Memo, objSubViewpointType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.SubViewpointType_GetCombineCondition = SubViewpointType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SubViewpointType(子观点类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSubViewpointTypeName: 类型名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SubViewpointType_GetUniCondStr_SubViewpointTypeName(objSubViewpointTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.subViewpointTypeName);
        return strWhereCond;
    }
    exports.SubViewpointType_GetUniCondStr_SubViewpointTypeName = SubViewpointType_GetUniCondStr_SubViewpointTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--SubViewpointType(子观点类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSubViewpointTypeName: 类型名称(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SubViewpointType_GetUniCondStr4Update_SubViewpointTypeName(objSubViewpointTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and SubViewpointTypeId <> '{0}'", objSubViewpointTypeEN.subViewpointTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and SubViewpointTypeName = '{0}'", objSubViewpointTypeEN.subViewpointTypeName);
        return strWhereCond;
    }
    exports.SubViewpointType_GetUniCondStr4Update_SubViewpointTypeName = SubViewpointType_GetUniCondStr4Update_SubViewpointTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSubViewpointTypeENS:源对象
     * @param objSubViewpointTypeENT:目标对象
    */
    function SubViewpointType_CopyObjTo(objSubViewpointTypeENS, objSubViewpointTypeENT) {
        objSubViewpointTypeENT.subViewpointTypeId = objSubViewpointTypeENS.subViewpointTypeId; //类型Id
        objSubViewpointTypeENT.subViewpointTypeName = objSubViewpointTypeENS.subViewpointTypeName; //类型名称
        objSubViewpointTypeENT.subViewpointTypeENName = objSubViewpointTypeENS.subViewpointTypeENName; //类型英文名
        objSubViewpointTypeENT.defaTitle = objSubViewpointTypeENS.defaTitle; //默认标题
        objSubViewpointTypeENT.orderNum = objSubViewpointTypeENS.orderNum; //序号
        objSubViewpointTypeENT.updDate = objSubViewpointTypeENS.updDate; //修改日期
        objSubViewpointTypeENT.updUserId = objSubViewpointTypeENS.updUserId; //修改用户Id
        objSubViewpointTypeENT.memo = objSubViewpointTypeENS.memo; //备注
        objSubViewpointTypeENT.sf_UpdFldSetStr = objSubViewpointTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SubViewpointType_CopyObjTo = SubViewpointType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSubViewpointTypeENS:源对象
     * @param objSubViewpointTypeENT:目标对象
    */
    function SubViewpointType_GetObjFromJsonObj(objSubViewpointTypeENS) {
        const objSubViewpointTypeENT = new clsSubViewpointTypeEN_js_1.clsSubViewpointTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSubViewpointTypeENT, objSubViewpointTypeENS);
        return objSubViewpointTypeENT;
    }
    exports.SubViewpointType_GetObjFromJsonObj = SubViewpointType_GetObjFromJsonObj;
});
