/**
* 类名:clsgs_RelaTypeWApi
* 表名:gs_RelaType(01120871)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 02:45:40
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges_Share/clsgs_RelaTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_RelaType_GetObjFromJsonObj = exports.gs_RelaType_CopyObjTo = exports.gs_RelaType_GetUniCondStr4Update_RelaTypeName = exports.gs_RelaType_GetUniCondStr_RelaTypeName = exports.gs_RelaType_GetCombineCondition = exports.gs_RelaType_GetObjByJSONStr = exports.gs_RelaType_GetObjLstByJSONObjLst = exports.gs_RelaType_GetObjLstByJSONStr = exports.gs_RelaType_GetJSONStrByObj = exports.gs_RelaType_CheckProperty4Update = exports.gs_RelaType_CheckPropertyNew = exports.gs_RelaType__Cache = exports.gs_RelaType_ReFreshThisCache = exports.gs_RelaType_ReFreshCache = exports.gs_RelaType_GetWebApiUrl = exports.gs_RelaType_GetMaxStrIdByPrefix = exports.gs_RelaType_GetMaxStrIdAsync = exports.gs_RelaType_GetRecCountByCond_Cache = exports.gs_RelaType_GetRecCountByCondAsync = exports.gs_RelaType_IsExistAsync = exports.gs_RelaType_IsExist_Cache = exports.gs_RelaType_IsExist = exports.gs_RelaType_IsExistRecordAsync = exports.gs_RelaType_IsExistRecord_Cache = exports.gs_RelaType_UpdateWithConditionAsync = exports.gs_RelaType_UpdateRecordAsync = exports.gs_RelaType_AddNewRecordWithReturnKey = exports.gs_RelaType_AddNewRecordWithReturnKeyAsync = exports.gs_RelaType_AddNewRecordWithMaxIdAsync = exports.gs_RelaType_AddNewRecordAsync = exports.gs_RelaType_Delgs_RelaTypesByCondAsync = exports.gs_RelaType_Delgs_RelaTypesAsync = exports.gs_RelaType_DelRecordAsync = exports.gs_RelaType_GetObjLstByPagerAsync = exports.gs_RelaType_GetObjLstByPager_Cache = exports.gs_RelaType_GetObjLstByRange = exports.gs_RelaType_GetObjLstByRangeAsync = exports.gs_RelaType_GetTopObjLstAsync = exports.gs_RelaType_GetObjLstByRelaTypeIdLst_Cache = exports.gs_RelaType_GetObjLstByRelaTypeIdLstAsync = exports.gs_RelaType_GetSubObjLst_Cache = exports.gs_RelaType_GetObjLst_PureCache = exports.gs_RelaType_GetObjLst_Cache = exports.gs_RelaType_GetObjLst_sessionStorage_PureCache = exports.gs_RelaType_GetObjLst_sessionStorage = exports.gs_RelaType_GetObjLstAsync = exports.gs_RelaType_GetObjLst_localStorage_PureCache = exports.gs_RelaType_GetObjLst_localStorage = exports.gs_RelaType_GetObjLst_ClientCache = exports.gs_RelaType_GetFirstObjAsync = exports.gs_RelaType_GetFirstID = exports.gs_RelaType_GetFirstIDAsync = exports.gs_RelaType_funcKey = exports.gs_RelaType_FilterFunByKey = exports.gs_RelaType_SortFunByKey = exports.gs_RelaType_SortFun_Defa_2Fld = exports.gs_RelaType_SortFun_Defa = exports.gs_RelaType_func = exports.gs_RelaType_GetNameByRelaTypeId_Cache = exports.gs_RelaType_UpdateObjInLst_Cache = exports.gs_RelaType_GetObjByRelaTypeId_localStorage = exports.gs_RelaType_GetObjByRelaTypeId_Cache = exports.gs_RelaType_GetObjByRelaTypeIdAsync = exports.gs_RelaType_ConstructorName = exports.gs_RelaType_Controller = void 0;
    /**
     * 知识点关系类型表(gs_RelaType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_RelaTypeEN_js_1 = require("../../L0_Entity/Knowledges_Share/clsgs_RelaTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_RelaType_Controller = "gs_RelaTypeApi";
    exports.gs_RelaType_ConstructorName = "gs_RelaType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strRelaTypeId:关键字
    * @returns 对象
    **/
    async function gs_RelaType_GetObjByRelaTypeIdAsync(strRelaTypeId) {
        const strThisFuncName = "GetObjByRelaTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRelaTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRelaTypeId]不能为空！(In clsgs_RelaTypeWApi.GetObjByRelaTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRelaTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRelaTypeId]的长度:[{0}]不正确！(clsgs_RelaTypeWApi.GetObjByRelaTypeIdAsync)", strRelaTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByRelaTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strRelaTypeId": strRelaTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_RelaType = gs_RelaType_GetObjFromJsonObj(returnObj);
                return objgs_RelaType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetObjByRelaTypeIdAsync = gs_RelaType_GetObjByRelaTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strRelaTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_RelaType_GetObjByRelaTypeId_Cache(strRelaTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByRelaTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRelaTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRelaTypeId]不能为空！(In clsgs_RelaTypeWApi.GetObjByRelaTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRelaTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRelaTypeId]的长度:[{0}]不正确！(clsgs_RelaTypeWApi.GetObjByRelaTypeId_Cache)", strRelaTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        try {
            const arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache.filter(x => x.relaTypeId == strRelaTypeId);
            let objgs_RelaType;
            if (arrgs_RelaType_Sel.length > 0) {
                objgs_RelaType = arrgs_RelaType_Sel[0];
                return objgs_RelaType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_RelaType_Const = await gs_RelaType_GetObjByRelaTypeIdAsync(strRelaTypeId);
                    if (objgs_RelaType_Const != null) {
                        gs_RelaType_ReFreshThisCache();
                        return objgs_RelaType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strRelaTypeId, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_RelaType_GetObjByRelaTypeId_Cache = gs_RelaType_GetObjByRelaTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strRelaTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_RelaType_GetObjByRelaTypeId_localStorage(strRelaTypeId) {
        const strThisFuncName = "GetObjByRelaTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRelaTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRelaTypeId]不能为空！(In clsgs_RelaTypeWApi.GetObjByRelaTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRelaTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRelaTypeId]的长度:[{0}]不正确！(clsgs_RelaTypeWApi.GetObjByRelaTypeId_localStorage)", strRelaTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName, strRelaTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_RelaType_Cache = JSON.parse(strTempObj);
            return objgs_RelaType_Cache;
        }
        try {
            const objgs_RelaType = await gs_RelaType_GetObjByRelaTypeIdAsync(strRelaTypeId);
            if (objgs_RelaType != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_RelaType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_RelaType;
            }
            return objgs_RelaType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strRelaTypeId, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_RelaType_GetObjByRelaTypeId_localStorage = gs_RelaType_GetObjByRelaTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_RelaType:所给的对象
     * @returns 对象
    */
    async function gs_RelaType_UpdateObjInLst_Cache(objgs_RelaType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
            const obj = arrgs_RelaTypeObjLst_Cache.find(x => x.relaTypeName == objgs_RelaType.relaTypeName);
            if (obj != null) {
                objgs_RelaType.relaTypeId = obj.relaTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_RelaType);
            }
            else {
                arrgs_RelaTypeObjLst_Cache.push(objgs_RelaType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_RelaType_UpdateObjInLst_Cache = gs_RelaType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strRelaTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_RelaType_GetNameByRelaTypeId_Cache(strRelaTypeId) {
        const strThisFuncName = "GetNameByRelaTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strRelaTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strRelaTypeId]不能为空！(In clsgs_RelaTypeWApi.GetNameByRelaTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strRelaTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strRelaTypeId]的长度:[{0}]不正确！(clsgs_RelaTypeWApi.GetNameByRelaTypeId_Cache)", strRelaTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        if (arrgs_RelaTypeObjLst_Cache == null)
            return "";
        try {
            const arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache.filter(x => x.relaTypeId == strRelaTypeId);
            let objgs_RelaType;
            if (arrgs_RelaType_Sel.length > 0) {
                objgs_RelaType = arrgs_RelaType_Sel[0];
                return objgs_RelaType.relaTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strRelaTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.gs_RelaType_GetNameByRelaTypeId_Cache = gs_RelaType_GetNameByRelaTypeId_Cache;
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
    async function gs_RelaType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strRelaTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_RelaType = await gs_RelaType_GetObjByRelaTypeId_Cache(strRelaTypeId);
        if (objgs_RelaType == null)
            return "";
        if (objgs_RelaType.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_RelaType.GetFldValue(strOutFldName).toString();
    }
    exports.gs_RelaType_func = gs_RelaType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_RelaType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.relaTypeId.localeCompare(b.relaTypeId);
    }
    exports.gs_RelaType_SortFun_Defa = gs_RelaType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_RelaType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.relaTypeName == b.relaTypeName)
            return a.relaTypeENName.localeCompare(b.relaTypeENName);
        else
            return a.relaTypeName.localeCompare(b.relaTypeName);
    }
    exports.gs_RelaType_SortFun_Defa_2Fld = gs_RelaType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_RelaType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId:
                    return (a, b) => {
                        return a.relaTypeId.localeCompare(b.relaTypeId);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName:
                    return (a, b) => {
                        return a.relaTypeName.localeCompare(b.relaTypeName);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeENName:
                    return (a, b) => {
                        return a.relaTypeENName.localeCompare(b.relaTypeENName);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_RelaType]中不存在！(in ${exports.gs_RelaType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId:
                    return (a, b) => {
                        return b.relaTypeId.localeCompare(a.relaTypeId);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName:
                    return (a, b) => {
                        return b.relaTypeName.localeCompare(a.relaTypeName);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeENName:
                    return (a, b) => {
                        return b.relaTypeENName.localeCompare(a.relaTypeENName);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_RelaType]中不存在！(in ${exports.gs_RelaType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_RelaType_SortFunByKey = gs_RelaType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_RelaType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId:
                return (obj) => {
                    return obj.relaTypeId === value;
                };
            case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName:
                return (obj) => {
                    return obj.relaTypeName === value;
                };
            case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeENName:
                return (obj) => {
                    return obj.relaTypeENName === value;
                };
            case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_RelaType]中不存在！(in ${exports.gs_RelaType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_RelaType_FilterFunByKey = gs_RelaType_FilterFunByKey;
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
    async function gs_RelaType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_RelaType = await gs_RelaType_GetObjLst_Cache();
        if (arrgs_RelaType == null)
            return [];
        let arrgs_RelaType_Sel = arrgs_RelaType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_RelaType_Sel.length == 0)
            return [];
        return arrgs_RelaType_Sel.map(x => x.relaTypeId);
    }
    exports.gs_RelaType_funcKey = gs_RelaType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_RelaType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetFirstIDAsync = gs_RelaType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_RelaType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetFirstID = gs_RelaType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_RelaType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const objgs_RelaType = gs_RelaType_GetObjFromJsonObj(returnObj);
                return objgs_RelaType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetFirstObjAsync = gs_RelaType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_RelaTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_RelaTypeObjLst_T = gs_RelaType_GetObjLstByJSONObjLst(arrgs_RelaTypeExObjLst_Cache);
            return arrgs_RelaTypeObjLst_T;
        }
        try {
            const arrgs_RelaTypeExObjLst = await gs_RelaType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_RelaTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RelaTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_RelaTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_RelaType_GetObjLst_ClientCache = gs_RelaType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_RelaTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_RelaTypeObjLst_T = gs_RelaType_GetObjLstByJSONObjLst(arrgs_RelaTypeExObjLst_Cache);
            return arrgs_RelaTypeObjLst_T;
        }
        try {
            const arrgs_RelaTypeExObjLst = await gs_RelaType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_RelaTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RelaTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_RelaTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_RelaType_GetObjLst_localStorage = gs_RelaType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_RelaTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_RelaTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_RelaType_GetObjLst_localStorage_PureCache = gs_RelaType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_RelaType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RelaType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RelaType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetObjLstAsync = gs_RelaType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_RelaTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_RelaTypeObjLst_T = gs_RelaType_GetObjLstByJSONObjLst(arrgs_RelaTypeExObjLst_Cache);
            return arrgs_RelaTypeObjLst_T;
        }
        try {
            const arrgs_RelaTypeExObjLst = await gs_RelaType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_RelaTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_RelaTypeExObjLst.length);
            console.log(strInfo);
            return arrgs_RelaTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_RelaType_GetObjLst_sessionStorage = gs_RelaType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_RelaTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_RelaTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_RelaType_GetObjLst_sessionStorage_PureCache = gs_RelaType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_RelaTypeObjLst_Cache;
        switch (clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_ClientCache();
                break;
            default:
                arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_ClientCache();
                break;
        }
        const arrgs_RelaTypeObjLst = gs_RelaType_GetObjLstByJSONObjLst(arrgs_RelaTypeObjLst_Cache);
        return arrgs_RelaTypeObjLst_Cache;
    }
    exports.gs_RelaType_GetObjLst_Cache = gs_RelaType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_RelaType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_RelaTypeObjLst_Cache;
        switch (clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_RelaTypeObjLst_Cache = null;
                break;
            default:
                arrgs_RelaTypeObjLst_Cache = null;
                break;
        }
        return arrgs_RelaTypeObjLst_Cache;
    }
    exports.gs_RelaType_GetObjLst_PureCache = gs_RelaType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrRelaTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_RelaType_GetSubObjLst_Cache(objgs_RelaType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        let arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache;
        if (objgs_RelaType_Cond.sf_FldComparisonOp == null || objgs_RelaType_Cond.sf_FldComparisonOp == "")
            return arrgs_RelaType_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_RelaType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_RelaTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_RelaType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RelaType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_RelaType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_RelaType_Cond), exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_RelaType_GetSubObjLst_Cache = gs_RelaType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrRelaTypeId:关键字列表
    * @returns 对象列表
    **/
    async function gs_RelaType_GetObjLstByRelaTypeIdLstAsync(arrRelaTypeId) {
        const strThisFuncName = "GetObjLstByRelaTypeIdLstAsync";
        const strAction = "GetObjLstByRelaTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrRelaTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RelaType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RelaType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetObjLstByRelaTypeIdLstAsync = gs_RelaType_GetObjLstByRelaTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrRelaTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_RelaType_GetObjLstByRelaTypeIdLst_Cache(arrRelaTypeIdLst) {
        const strThisFuncName = "GetObjLstByRelaTypeIdLst_Cache";
        try {
            const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
            const arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache.filter(x => arrRelaTypeIdLst.indexOf(x.relaTypeId) > -1);
            return arrgs_RelaType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrRelaTypeIdLst.join(","), exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_RelaType_GetObjLstByRelaTypeIdLst_Cache = gs_RelaType_GetObjLstByRelaTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_RelaType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RelaType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RelaType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetTopObjLstAsync = gs_RelaType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_RelaType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RelaType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RelaType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetObjLstByRangeAsync = gs_RelaType_GetObjLstByRangeAsync;
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
    async function gs_RelaType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetObjLstByRange = gs_RelaType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_RelaType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        if (arrgs_RelaTypeObjLst_Cache.length == 0)
            return arrgs_RelaTypeObjLst_Cache;
        let arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_RelaType_Cond = new clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_RelaType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_RelaTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RelaType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_RelaType_Sel.length == 0)
                return arrgs_RelaType_Sel;
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
                arrgs_RelaType_Sel = arrgs_RelaType_Sel.sort(gs_RelaType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_RelaType_Sel = arrgs_RelaType_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_RelaType_Sel = arrgs_RelaType_Sel.slice(intStart, intEnd);
            return arrgs_RelaType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_RelaType_GetObjLstByPager_Cache = gs_RelaType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_RelaType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_RelaType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_RelaType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetObjLstByPagerAsync = gs_RelaType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strRelaTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_RelaType_DelRecordAsync(strRelaTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strRelaTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_DelRecordAsync = gs_RelaType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrRelaTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_RelaType_Delgs_RelaTypesAsync(arrRelaTypeId) {
        const strThisFuncName = "Delgs_RelaTypesAsync";
        const strAction = "Delgs_RelaTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrRelaTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_Delgs_RelaTypesAsync = gs_RelaType_Delgs_RelaTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_RelaType_Delgs_RelaTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_RelaTypesByCondAsync";
        const strAction = "Delgs_RelaTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_Delgs_RelaTypesByCondAsync = gs_RelaType_Delgs_RelaTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_RelaTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_RelaType_AddNewRecordAsync(objgs_RelaTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_RelaTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RelaTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_AddNewRecordAsync = gs_RelaType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_RelaTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_RelaType_AddNewRecordWithMaxIdAsync(objgs_RelaTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RelaTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_AddNewRecordWithMaxIdAsync = gs_RelaType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_RelaTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_RelaType_AddNewRecordWithReturnKeyAsync(objgs_RelaTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RelaTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_AddNewRecordWithReturnKeyAsync = gs_RelaType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_RelaTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_RelaType_AddNewRecordWithReturnKey(objgs_RelaTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_RelaTypeEN.relaTypeId === null || objgs_RelaTypeEN.relaTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RelaTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_AddNewRecordWithReturnKey = gs_RelaType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_RelaTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_RelaType_UpdateRecordAsync(objgs_RelaTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_RelaTypeEN.sf_UpdFldSetStr === undefined || objgs_RelaTypeEN.sf_UpdFldSetStr === null || objgs_RelaTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_RelaTypeEN.relaTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_RelaTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_UpdateRecordAsync = gs_RelaType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_RelaTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_RelaType_UpdateWithConditionAsync(objgs_RelaTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_RelaTypeEN.sf_UpdFldSetStr === undefined || objgs_RelaTypeEN.sf_UpdFldSetStr === null || objgs_RelaTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_RelaTypeEN.relaTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        objgs_RelaTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_RelaTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_UpdateWithConditionAsync = gs_RelaType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrRelaTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_RelaType_IsExistRecord_Cache(objgs_RelaType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        if (arrgs_RelaTypeObjLst_Cache == null)
            return false;
        let arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache;
        if (objgs_RelaType_Cond.sf_FldComparisonOp == null || objgs_RelaType_Cond.sf_FldComparisonOp == "")
            return arrgs_RelaType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_RelaType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_RelaTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_RelaType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RelaType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_RelaType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_RelaType_Cond), exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_RelaType_IsExistRecord_Cache = gs_RelaType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_RelaType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_IsExistRecordAsync = gs_RelaType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strRelaTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_RelaType_IsExist(strRelaTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "RelaTypeId": strRelaTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_IsExist = gs_RelaType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strRelaTypeId:所给的关键字
     * @returns 对象
    */
    async function gs_RelaType_IsExist_Cache(strRelaTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        if (arrgs_RelaTypeObjLst_Cache == null)
            return false;
        try {
            const arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache.filter(x => x.relaTypeId == strRelaTypeId);
            if (arrgs_RelaType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strRelaTypeId, exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_RelaType_IsExist_Cache = gs_RelaType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strRelaTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_RelaType_IsExistAsync(strRelaTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strRelaTypeId": strRelaTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_IsExistAsync = gs_RelaType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_RelaType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetRecCountByCondAsync = gs_RelaType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_RelaType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_RelaType_GetRecCountByCond_Cache(objgs_RelaType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_RelaTypeObjLst_Cache = await gs_RelaType_GetObjLst_Cache();
        if (arrgs_RelaTypeObjLst_Cache == null)
            return 0;
        let arrgs_RelaType_Sel = arrgs_RelaTypeObjLst_Cache;
        if (objgs_RelaType_Cond.sf_FldComparisonOp == null || objgs_RelaType_Cond.sf_FldComparisonOp == "")
            return arrgs_RelaType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_RelaType_Cond.sf_FldComparisonOp);
        //console.log("clsgs_RelaTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_RelaType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_RelaType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_RelaType_Sel = arrgs_RelaType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_RelaType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_RelaType_Cond), exports.gs_RelaType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_RelaType_GetRecCountByCond_Cache = gs_RelaType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_RelaType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetMaxStrIdAsync = gs_RelaType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_RelaType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_RelaType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_RelaType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_RelaType_GetMaxStrIdByPrefix = gs_RelaType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_RelaType_GetWebApiUrl(strController, strAction) {
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
    exports.gs_RelaType_GetWebApiUrl = gs_RelaType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_RelaType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
        switch (clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheModeId) {
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
    exports.gs_RelaType_ReFreshCache = gs_RelaType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_RelaType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN._CurrTabName;
            switch (clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.CacheModeId) {
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
    exports.gs_RelaType_ReFreshThisCache = gs_RelaType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function gs_RelaType__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await gs_RelaType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName, "知识点关系类型表");
    }
    exports.gs_RelaType__Cache = gs_RelaType__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_RelaType_CheckPropertyNew(pobjgs_RelaTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[关系类型名]不能为空(In 知识点关系类型表)!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeENName) === true
            || pobjgs_RelaTypeEN.relaTypeENName.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[关系类型英文名]不能为空(In 知识点关系类型表)!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.relaTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[关系类型Id(relaTypeId)]的长度不能超过2(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.relaTypeId)(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.relaTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[关系类型名(relaTypeName)]的长度不能超过50(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.relaTypeName)(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.relaTypeENName) > 50) {
            throw new Error("(errid:Watl000059)字段[关系类型英文名(relaTypeENName)]的长度不能超过50(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.relaTypeENName)(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.updDate)(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.memo)(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.updUser)(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeId) == false && undefined !== pobjgs_RelaTypeEN.relaTypeId && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.relaTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[关系类型Id(relaTypeId)]的值:[$(pobjgs_RelaTypeEN.relaTypeId)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeName) == false && undefined !== pobjgs_RelaTypeEN.relaTypeName && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.relaTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[关系类型名(relaTypeName)]的值:[$(pobjgs_RelaTypeEN.relaTypeName)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeENName) == false && undefined !== pobjgs_RelaTypeEN.relaTypeENName && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.relaTypeENName) === false) {
            throw new Error("(errid:Watl000060)字段[关系类型英文名(relaTypeENName)]的值:[$(pobjgs_RelaTypeEN.relaTypeENName)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updDate) == false && undefined !== pobjgs_RelaTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_RelaTypeEN.updDate)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.memo) == false && undefined !== pobjgs_RelaTypeEN.memo && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_RelaTypeEN.memo)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updUser) == false && undefined !== pobjgs_RelaTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_RelaTypeEN.updUser)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_RelaTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_RelaType_CheckPropertyNew = gs_RelaType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_RelaType_CheckProperty4Update(pobjgs_RelaTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.relaTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[关系类型Id(relaTypeId)]的长度不能超过2(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.relaTypeId)(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.relaTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[关系类型名(relaTypeName)]的长度不能超过50(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.relaTypeName)(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.relaTypeENName) > 50) {
            throw new Error("(errid:Watl000062)字段[关系类型英文名(relaTypeENName)]的长度不能超过50(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.relaTypeENName)(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.updDate)(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.memo)(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_RelaTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识点关系类型表(gs_RelaType))!值:$(pobjgs_RelaTypeEN.updUser)(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeId) == false && undefined !== pobjgs_RelaTypeEN.relaTypeId && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.relaTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[关系类型Id(relaTypeId)]的值:[$(pobjgs_RelaTypeEN.relaTypeId)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeName) == false && undefined !== pobjgs_RelaTypeEN.relaTypeName && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.relaTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[关系类型名(relaTypeName)]的值:[$(pobjgs_RelaTypeEN.relaTypeName)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeENName) == false && undefined !== pobjgs_RelaTypeEN.relaTypeENName && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.relaTypeENName) === false) {
            throw new Error("(errid:Watl000063)字段[关系类型英文名(relaTypeENName)]的值:[$(pobjgs_RelaTypeEN.relaTypeENName)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updDate) == false && undefined !== pobjgs_RelaTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_RelaTypeEN.updDate)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.memo) == false && undefined !== pobjgs_RelaTypeEN.memo && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_RelaTypeEN.memo)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.updUser) == false && undefined !== pobjgs_RelaTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_RelaTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_RelaTypeEN.updUser)], 非法，应该为字符型(In 知识点关系类型表(gs_RelaType))!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_RelaTypeEN.relaTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[关系类型Id]不能为空(In 知识点关系类型表)!(clsgs_RelaTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_RelaTypeEN.SetIsCheckProperty(true);
    }
    exports.gs_RelaType_CheckProperty4Update = gs_RelaType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_RelaType_GetJSONStrByObj(pobjgs_RelaTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_RelaTypeEN.sf_UpdFldSetStr = pobjgs_RelaTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_RelaTypeEN);
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
    exports.gs_RelaType_GetJSONStrByObj = gs_RelaType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_RelaType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_RelaTypeObjLst = new Array();
        if (strJSON === "") {
            return arrgs_RelaTypeObjLst;
        }
        try {
            arrgs_RelaTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_RelaTypeObjLst;
        }
        return arrgs_RelaTypeObjLst;
    }
    exports.gs_RelaType_GetObjLstByJSONStr = gs_RelaType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_RelaTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_RelaType_GetObjLstByJSONObjLst(arrgs_RelaTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_RelaTypeObjLst = new Array();
        for (const objInFor of arrgs_RelaTypeObjLstS) {
            const obj1 = gs_RelaType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_RelaTypeObjLst.push(obj1);
        }
        return arrgs_RelaTypeObjLst;
    }
    exports.gs_RelaType_GetObjLstByJSONObjLst = gs_RelaType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_RelaType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_RelaTypeEN = new clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN();
        if (strJSON === "") {
            return pobjgs_RelaTypeEN;
        }
        try {
            pobjgs_RelaTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_RelaTypeEN;
        }
        return pobjgs_RelaTypeEN;
    }
    exports.gs_RelaType_GetObjByJSONStr = gs_RelaType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_RelaType_GetCombineCondition(objgs_RelaType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_RelaType_Cond.dicFldComparisonOp, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId) == true) {
            const strComparisonOp_RelaTypeId = objgs_RelaType_Cond.dicFldComparisonOp[clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeId, objgs_RelaType_Cond.relaTypeId, strComparisonOp_RelaTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RelaType_Cond.dicFldComparisonOp, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName) == true) {
            const strComparisonOp_RelaTypeName = objgs_RelaType_Cond.dicFldComparisonOp[clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeName, objgs_RelaType_Cond.relaTypeName, strComparisonOp_RelaTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RelaType_Cond.dicFldComparisonOp, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeENName) == true) {
            const strComparisonOp_RelaTypeENName = objgs_RelaType_Cond.dicFldComparisonOp[clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_RelaTypeENName, objgs_RelaType_Cond.relaTypeENName, strComparisonOp_RelaTypeENName);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RelaType_Cond.dicFldComparisonOp, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_RelaType_Cond.dicFldComparisonOp[clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdDate, objgs_RelaType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RelaType_Cond.dicFldComparisonOp, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_RelaType_Cond.dicFldComparisonOp[clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_Memo, objgs_RelaType_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_RelaType_Cond.dicFldComparisonOp, clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_RelaType_Cond.dicFldComparisonOp[clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN.con_UpdUser, objgs_RelaType_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.gs_RelaType_GetCombineCondition = gs_RelaType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_RelaType(知识点关系类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strRelaTypeName: 关系类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_RelaType_GetUniCondStr_RelaTypeName(objgs_RelaTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and RelaTypeName = '{0}'", objgs_RelaTypeEN.relaTypeName);
        return strWhereCond;
    }
    exports.gs_RelaType_GetUniCondStr_RelaTypeName = gs_RelaType_GetUniCondStr_RelaTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--gs_RelaType(知识点关系类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strRelaTypeName: 关系类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_RelaType_GetUniCondStr4Update_RelaTypeName(objgs_RelaTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and RelaTypeId <> '{0}'", objgs_RelaTypeEN.relaTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and RelaTypeName = '{0}'", objgs_RelaTypeEN.relaTypeName);
        return strWhereCond;
    }
    exports.gs_RelaType_GetUniCondStr4Update_RelaTypeName = gs_RelaType_GetUniCondStr4Update_RelaTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_RelaTypeENS:源对象
     * @param objgs_RelaTypeENT:目标对象
    */
    function gs_RelaType_CopyObjTo(objgs_RelaTypeENS, objgs_RelaTypeENT) {
        objgs_RelaTypeENT.relaTypeId = objgs_RelaTypeENS.relaTypeId; //关系类型Id
        objgs_RelaTypeENT.relaTypeName = objgs_RelaTypeENS.relaTypeName; //关系类型名
        objgs_RelaTypeENT.relaTypeENName = objgs_RelaTypeENS.relaTypeENName; //关系类型英文名
        objgs_RelaTypeENT.updDate = objgs_RelaTypeENS.updDate; //修改日期
        objgs_RelaTypeENT.memo = objgs_RelaTypeENS.memo; //备注
        objgs_RelaTypeENT.updUser = objgs_RelaTypeENS.updUser; //修改人
        objgs_RelaTypeENT.sf_UpdFldSetStr = objgs_RelaTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_RelaType_CopyObjTo = gs_RelaType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_RelaTypeENS:源对象
     * @param objgs_RelaTypeENT:目标对象
    */
    function gs_RelaType_GetObjFromJsonObj(objgs_RelaTypeENS) {
        const objgs_RelaTypeENT = new clsgs_RelaTypeEN_js_1.clsgs_RelaTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_RelaTypeENT, objgs_RelaTypeENS);
        return objgs_RelaTypeENT;
    }
    exports.gs_RelaType_GetObjFromJsonObj = gs_RelaType_GetObjFromJsonObj;
});
