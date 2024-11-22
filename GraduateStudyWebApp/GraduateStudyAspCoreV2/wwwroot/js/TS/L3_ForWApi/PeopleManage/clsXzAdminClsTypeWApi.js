/**
* 类名:clsXzAdminClsTypeWApi
* 表名:XzAdminClsType(01120195)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:40
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:人员管理(PeopleManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/PeopleManage/clsXzAdminClsTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzAdminClsType_GetObjFromJsonObj = exports.XzAdminClsType_CopyObjTo = exports.XzAdminClsType_GetCombineCondition = exports.XzAdminClsType_GetObjByJSONStr = exports.XzAdminClsType_GetObjLstByJSONObjLst = exports.XzAdminClsType_GetObjLstByJSONStr = exports.XzAdminClsType_GetJSONStrByObj = exports.XzAdminClsType_CheckProperty4Update = exports.XzAdminClsType_CheckPropertyNew = exports.XzAdminClsType__Cache = exports.XzAdminClsType_ReFreshThisCache = exports.XzAdminClsType_ReFreshCache = exports.XzAdminClsType_GetWebApiUrl = exports.XzAdminClsType_GetMaxStrIdByPrefix = exports.XzAdminClsType_GetRecCountByCond_Cache = exports.XzAdminClsType_GetRecCountByCondAsync = exports.XzAdminClsType_IsExistAsync = exports.XzAdminClsType_IsExist_Cache = exports.XzAdminClsType_IsExist = exports.XzAdminClsType_IsExistRecordAsync = exports.XzAdminClsType_IsExistRecord_Cache = exports.XzAdminClsType_UpdateWithConditionAsync = exports.XzAdminClsType_UpdateRecordAsync = exports.XzAdminClsType_AddNewRecordWithReturnKey = exports.XzAdminClsType_AddNewRecordWithReturnKeyAsync = exports.XzAdminClsType_AddNewRecordWithMaxIdAsync = exports.XzAdminClsType_AddNewRecordAsync = exports.XzAdminClsType_DelXzAdminClsTypesByCondAsync = exports.XzAdminClsType_DelXzAdminClsTypesAsync = exports.XzAdminClsType_DelRecordAsync = exports.XzAdminClsType_GetObjLstByPagerAsync = exports.XzAdminClsType_GetObjLstByPager_Cache = exports.XzAdminClsType_GetObjLstByRange = exports.XzAdminClsType_GetObjLstByRangeAsync = exports.XzAdminClsType_GetTopObjLstAsync = exports.XzAdminClsType_GetObjLstByid_AdminClsTypeLst_Cache = exports.XzAdminClsType_GetObjLstByid_AdminClsTypeLstAsync = exports.XzAdminClsType_GetSubObjLst_Cache = exports.XzAdminClsType_GetObjLst_PureCache = exports.XzAdminClsType_GetObjLst_Cache = exports.XzAdminClsType_GetObjLst_sessionStorage_PureCache = exports.XzAdminClsType_GetObjLst_sessionStorage = exports.XzAdminClsType_GetObjLstAsync = exports.XzAdminClsType_GetObjLst_localStorage_PureCache = exports.XzAdminClsType_GetObjLst_localStorage = exports.XzAdminClsType_GetObjLst_ClientCache = exports.XzAdminClsType_GetFirstObjAsync = exports.XzAdminClsType_GetFirstID = exports.XzAdminClsType_GetFirstIDAsync = exports.XzAdminClsType_funcKey = exports.XzAdminClsType_FilterFunByKey = exports.XzAdminClsType_SortFunByKey = exports.XzAdminClsType_SortFun_Defa_2Fld = exports.XzAdminClsType_SortFun_Defa = exports.XzAdminClsType_func = exports.XzAdminClsType_GetNameByid_AdminClsType_Cache = exports.XzAdminClsType_UpdateObjInLst_Cache = exports.XzAdminClsType_GetObjByid_AdminClsType_localStorage = exports.XzAdminClsType_GetObjByid_AdminClsType_Cache = exports.XzAdminClsType_GetObjByid_AdminClsTypeAsync = exports.xzAdminClsType_ConstructorName = exports.xzAdminClsType_Controller = void 0;
    /**
     * 行政班类型(XzAdminClsType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzAdminClsTypeEN_js_1 = require("../../L0_Entity/PeopleManage/clsXzAdminClsTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.xzAdminClsType_Controller = "XzAdminClsTypeApi";
    exports.xzAdminClsType_ConstructorName = "xzAdminClsType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_AdminClsType:关键字
    * @returns 对象
    **/
    async function XzAdminClsType_GetObjByid_AdminClsTypeAsync(strid_AdminClsType) {
        const strThisFuncName = "GetObjByid_AdminClsTypeAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminClsType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminClsType]不能为空！(In clsXzAdminClsTypeWApi.GetObjByid_AdminClsTypeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminClsType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminClsType]的长度:[{0}]不正确！(clsXzAdminClsTypeWApi.GetObjByid_AdminClsTypeAsync)", strid_AdminClsType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_AdminClsType";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_AdminClsType": strid_AdminClsType,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objXzAdminClsType = XzAdminClsType_GetObjFromJsonObj(returnObj);
                return objXzAdminClsType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetObjByid_AdminClsTypeAsync = XzAdminClsType_GetObjByid_AdminClsTypeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_AdminClsType:所给的关键字
     * @returns 对象
    */
    async function XzAdminClsType_GetObjByid_AdminClsType_Cache(strid_AdminClsType, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_AdminClsType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminClsType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminClsType]不能为空！(In clsXzAdminClsTypeWApi.GetObjByid_AdminClsType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminClsType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminClsType]的长度:[{0}]不正确！(clsXzAdminClsTypeWApi.GetObjByid_AdminClsType_Cache)", strid_AdminClsType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        try {
            const arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache.filter(x => x.id_AdminClsType == strid_AdminClsType);
            let objXzAdminClsType;
            if (arrXzAdminClsType_Sel.length > 0) {
                objXzAdminClsType = arrXzAdminClsType_Sel[0];
                return objXzAdminClsType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objXzAdminClsType_Const = await XzAdminClsType_GetObjByid_AdminClsTypeAsync(strid_AdminClsType);
                    if (objXzAdminClsType_Const != null) {
                        XzAdminClsType_ReFreshThisCache();
                        return objXzAdminClsType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_AdminClsType, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzAdminClsType_GetObjByid_AdminClsType_Cache = XzAdminClsType_GetObjByid_AdminClsType_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_AdminClsType:所给的关键字
     * @returns 对象
    */
    async function XzAdminClsType_GetObjByid_AdminClsType_localStorage(strid_AdminClsType) {
        const strThisFuncName = "GetObjByid_AdminClsType_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminClsType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminClsType]不能为空！(In clsXzAdminClsTypeWApi.GetObjByid_AdminClsType_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminClsType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminClsType]的长度:[{0}]不正确！(clsXzAdminClsTypeWApi.GetObjByid_AdminClsType_localStorage)", strid_AdminClsType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName, strid_AdminClsType);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzAdminClsType_Cache = JSON.parse(strTempObj);
            return objXzAdminClsType_Cache;
        }
        try {
            const objXzAdminClsType = await XzAdminClsType_GetObjByid_AdminClsTypeAsync(strid_AdminClsType);
            if (objXzAdminClsType != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzAdminClsType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzAdminClsType;
            }
            return objXzAdminClsType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_AdminClsType, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzAdminClsType_GetObjByid_AdminClsType_localStorage = XzAdminClsType_GetObjByid_AdminClsType_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzAdminClsType:所给的对象
     * @returns 对象
    */
    async function XzAdminClsType_UpdateObjInLst_Cache(objXzAdminClsType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
            const obj = arrXzAdminClsTypeObjLst_Cache.find(x => x.id_AdminClsType == objXzAdminClsType.id_AdminClsType);
            if (obj != null) {
                objXzAdminClsType.id_AdminClsType = obj.id_AdminClsType;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzAdminClsType);
            }
            else {
                arrXzAdminClsTypeObjLst_Cache.push(objXzAdminClsType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzAdminClsType_UpdateObjInLst_Cache = XzAdminClsType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_AdminClsType:所给的关键字
     * @returns 对象
    */
    async function XzAdminClsType_GetNameByid_AdminClsType_Cache(strid_AdminClsType) {
        const strThisFuncName = "GetNameByid_AdminClsType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_AdminClsType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_AdminClsType]不能为空！(In clsXzAdminClsTypeWApi.GetNameByid_AdminClsType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_AdminClsType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_AdminClsType]的长度:[{0}]不正确！(clsXzAdminClsTypeWApi.GetNameByid_AdminClsType_Cache)", strid_AdminClsType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        if (arrXzAdminClsTypeObjLst_Cache == null)
            return "";
        try {
            const arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache.filter(x => x.id_AdminClsType == strid_AdminClsType);
            let objXzAdminClsType;
            if (arrXzAdminClsType_Sel.length > 0) {
                objXzAdminClsType = arrXzAdminClsType_Sel[0];
                return objXzAdminClsType.adminClsTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_AdminClsType);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzAdminClsType_GetNameByid_AdminClsType_Cache = XzAdminClsType_GetNameByid_AdminClsType_Cache;
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
    async function XzAdminClsType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_AdminClsType = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzAdminClsType = await XzAdminClsType_GetObjByid_AdminClsType_Cache(strid_AdminClsType);
        if (objXzAdminClsType == null)
            return "";
        if (objXzAdminClsType.GetFldValue(strOutFldName) == null)
            return "";
        return objXzAdminClsType.GetFldValue(strOutFldName).toString();
    }
    exports.XzAdminClsType_func = XzAdminClsType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzAdminClsType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_AdminClsType.localeCompare(b.id_AdminClsType);
    }
    exports.XzAdminClsType_SortFun_Defa = XzAdminClsType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzAdminClsType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.adminClsTypeId == b.adminClsTypeId)
            return a.adminClsTypeName.localeCompare(b.adminClsTypeName);
        else
            return a.adminClsTypeId.localeCompare(b.adminClsTypeId);
    }
    exports.XzAdminClsType_SortFun_Defa_2Fld = XzAdminClsType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzAdminClsType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType:
                    return (a, b) => {
                        return a.id_AdminClsType.localeCompare(b.id_AdminClsType);
                    };
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeId:
                    return (a, b) => {
                        return a.adminClsTypeId.localeCompare(b.adminClsTypeId);
                    };
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName:
                    return (a, b) => {
                        return a.adminClsTypeName.localeCompare(b.adminClsTypeName);
                    };
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzAdminClsType]中不存在！(in ${exports.xzAdminClsType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType:
                    return (a, b) => {
                        return b.id_AdminClsType.localeCompare(a.id_AdminClsType);
                    };
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeId:
                    return (a, b) => {
                        return b.adminClsTypeId.localeCompare(a.adminClsTypeId);
                    };
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName:
                    return (a, b) => {
                        return b.adminClsTypeName.localeCompare(a.adminClsTypeName);
                    };
                case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzAdminClsType]中不存在！(in ${exports.xzAdminClsType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzAdminClsType_SortFunByKey = XzAdminClsType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzAdminClsType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType:
                return (obj) => {
                    return obj.id_AdminClsType === value;
                };
            case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeId:
                return (obj) => {
                    return obj.adminClsTypeId === value;
                };
            case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName:
                return (obj) => {
                    return obj.adminClsTypeName === value;
                };
            case clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzAdminClsType]中不存在！(in ${exports.xzAdminClsType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzAdminClsType_FilterFunByKey = XzAdminClsType_FilterFunByKey;
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
    async function XzAdminClsType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrXzAdminClsType = await XzAdminClsType_GetObjLst_Cache();
        if (arrXzAdminClsType == null)
            return [];
        let arrXzAdminClsType_Sel = arrXzAdminClsType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrXzAdminClsType_Sel.length == 0)
            return [];
        return arrXzAdminClsType_Sel.map(x => x.id_AdminClsType);
    }
    exports.XzAdminClsType_funcKey = XzAdminClsType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzAdminClsType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetFirstIDAsync = XzAdminClsType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzAdminClsType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetFirstID = XzAdminClsType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzAdminClsType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const objXzAdminClsType = XzAdminClsType_GetObjFromJsonObj(returnObj);
                return objXzAdminClsType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetFirstObjAsync = XzAdminClsType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzAdminClsTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrXzAdminClsTypeObjLst_T = XzAdminClsType_GetObjLstByJSONObjLst(arrXzAdminClsTypeExObjLst_Cache);
            return arrXzAdminClsTypeObjLst_T;
        }
        try {
            const arrXzAdminClsTypeExObjLst = await XzAdminClsType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrXzAdminClsTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsTypeExObjLst.length);
            console.log(strInfo);
            return arrXzAdminClsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzAdminClsType_GetObjLst_ClientCache = XzAdminClsType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzAdminClsTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzAdminClsTypeObjLst_T = XzAdminClsType_GetObjLstByJSONObjLst(arrXzAdminClsTypeExObjLst_Cache);
            return arrXzAdminClsTypeObjLst_T;
        }
        try {
            const arrXzAdminClsTypeExObjLst = await XzAdminClsType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzAdminClsTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsTypeExObjLst.length);
            console.log(strInfo);
            return arrXzAdminClsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzAdminClsType_GetObjLst_localStorage = XzAdminClsType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzAdminClsTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzAdminClsTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzAdminClsType_GetObjLst_localStorage_PureCache = XzAdminClsType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzAdminClsType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetObjLstAsync = XzAdminClsType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzAdminClsTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzAdminClsTypeObjLst_T = XzAdminClsType_GetObjLstByJSONObjLst(arrXzAdminClsTypeExObjLst_Cache);
            return arrXzAdminClsTypeObjLst_T;
        }
        try {
            const arrXzAdminClsTypeExObjLst = await XzAdminClsType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzAdminClsTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzAdminClsTypeExObjLst.length);
            console.log(strInfo);
            return arrXzAdminClsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzAdminClsType_GetObjLst_sessionStorage = XzAdminClsType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzAdminClsTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzAdminClsTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzAdminClsType_GetObjLst_sessionStorage_PureCache = XzAdminClsType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzAdminClsTypeObjLst_Cache;
        switch (clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_ClientCache();
                break;
            default:
                arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_ClientCache();
                break;
        }
        const arrXzAdminClsTypeObjLst = XzAdminClsType_GetObjLstByJSONObjLst(arrXzAdminClsTypeObjLst_Cache);
        return arrXzAdminClsTypeObjLst_Cache;
    }
    exports.XzAdminClsType_GetObjLst_Cache = XzAdminClsType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzAdminClsType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzAdminClsTypeObjLst_Cache;
        switch (clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzAdminClsTypeObjLst_Cache = null;
                break;
            default:
                arrXzAdminClsTypeObjLst_Cache = null;
                break;
        }
        return arrXzAdminClsTypeObjLst_Cache;
    }
    exports.XzAdminClsType_GetObjLst_PureCache = XzAdminClsType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_AdminClsType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzAdminClsType_GetSubObjLst_Cache(objXzAdminClsType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        let arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache;
        if (objXzAdminClsType_Cond.sf_FldComparisonOp == null || objXzAdminClsType_Cond.sf_FldComparisonOp == "")
            return arrXzAdminClsType_Sel;
        const dicFldComparisonOp = JSON.parse(objXzAdminClsType_Cond.sf_FldComparisonOp);
        //console.log("clsXzAdminClsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzAdminClsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzAdminClsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzAdminClsType_Cond), exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzAdminClsType_GetSubObjLst_Cache = XzAdminClsType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_AdminClsType:关键字列表
    * @returns 对象列表
    **/
    async function XzAdminClsType_GetObjLstByid_AdminClsTypeLstAsync(arrid_AdminClsType) {
        const strThisFuncName = "GetObjLstByid_AdminClsTypeLstAsync";
        const strAction = "GetObjLstByid_AdminClsTypeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_AdminClsType);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetObjLstByid_AdminClsTypeLstAsync = XzAdminClsType_GetObjLstByid_AdminClsTypeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_AdminClsTypeLst:关键字列表
     * @returns 对象列表
    */
    async function XzAdminClsType_GetObjLstByid_AdminClsTypeLst_Cache(arrid_AdminClsTypeLst) {
        const strThisFuncName = "GetObjLstByid_AdminClsTypeLst_Cache";
        try {
            const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
            const arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache.filter(x => arrid_AdminClsTypeLst.indexOf(x.id_AdminClsType) > -1);
            return arrXzAdminClsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_AdminClsTypeLst.join(","), exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.XzAdminClsType_GetObjLstByid_AdminClsTypeLst_Cache = XzAdminClsType_GetObjLstByid_AdminClsTypeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzAdminClsType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetTopObjLstAsync = XzAdminClsType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzAdminClsType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetObjLstByRangeAsync = XzAdminClsType_GetObjLstByRangeAsync;
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
    async function XzAdminClsType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetObjLstByRange = XzAdminClsType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzAdminClsType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        if (arrXzAdminClsTypeObjLst_Cache.length == 0)
            return arrXzAdminClsTypeObjLst_Cache;
        let arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzAdminClsType_Cond = new clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzAdminClsType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzAdminClsTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzAdminClsType_Sel.length == 0)
                return arrXzAdminClsType_Sel;
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
                arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.sort(XzAdminClsType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.sort(objPagerPara.sortFun);
            }
            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.slice(intStart, intEnd);
            return arrXzAdminClsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzAdminClsType_GetObjLstByPager_Cache = XzAdminClsType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzAdminClsType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzAdminClsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzAdminClsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetObjLstByPagerAsync = XzAdminClsType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_AdminClsType:关键字
    * @returns 获取删除的结果
    **/
    async function XzAdminClsType_DelRecordAsync(strid_AdminClsType) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_AdminClsType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_DelRecordAsync = XzAdminClsType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_AdminClsType:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzAdminClsType_DelXzAdminClsTypesAsync(arrid_AdminClsType) {
        const strThisFuncName = "DelXzAdminClsTypesAsync";
        const strAction = "DelXzAdminClsTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_AdminClsType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_DelXzAdminClsTypesAsync = XzAdminClsType_DelXzAdminClsTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzAdminClsType_DelXzAdminClsTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzAdminClsTypesByCondAsync";
        const strAction = "DelXzAdminClsTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_DelXzAdminClsTypesByCondAsync = XzAdminClsType_DelXzAdminClsTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzAdminClsTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzAdminClsType_AddNewRecordAsync(objXzAdminClsTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objXzAdminClsTypeEN.id_AdminClsType === null || objXzAdminClsTypeEN.id_AdminClsType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objXzAdminClsTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_AddNewRecordAsync = XzAdminClsType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzAdminClsTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzAdminClsType_AddNewRecordWithMaxIdAsync(objXzAdminClsTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_AddNewRecordWithMaxIdAsync = XzAdminClsType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzAdminClsTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzAdminClsType_AddNewRecordWithReturnKeyAsync(objXzAdminClsTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_AddNewRecordWithReturnKeyAsync = XzAdminClsType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzAdminClsTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzAdminClsType_AddNewRecordWithReturnKey(objXzAdminClsTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzAdminClsTypeEN.id_AdminClsType === null || objXzAdminClsTypeEN.id_AdminClsType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_AddNewRecordWithReturnKey = XzAdminClsType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzAdminClsTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzAdminClsType_UpdateRecordAsync(objXzAdminClsTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzAdminClsTypeEN.sf_UpdFldSetStr === undefined || objXzAdminClsTypeEN.sf_UpdFldSetStr === null || objXzAdminClsTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzAdminClsTypeEN.id_AdminClsType);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_UpdateRecordAsync = XzAdminClsType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzAdminClsTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzAdminClsType_UpdateWithConditionAsync(objXzAdminClsTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzAdminClsTypeEN.sf_UpdFldSetStr === undefined || objXzAdminClsTypeEN.sf_UpdFldSetStr === null || objXzAdminClsTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzAdminClsTypeEN.id_AdminClsType);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        objXzAdminClsTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzAdminClsTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_UpdateWithConditionAsync = XzAdminClsType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_AdminClsType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzAdminClsType_IsExistRecord_Cache(objXzAdminClsType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        if (arrXzAdminClsTypeObjLst_Cache == null)
            return false;
        let arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache;
        if (objXzAdminClsType_Cond.sf_FldComparisonOp == null || objXzAdminClsType_Cond.sf_FldComparisonOp == "")
            return arrXzAdminClsType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzAdminClsType_Cond.sf_FldComparisonOp);
        //console.log("clsXzAdminClsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzAdminClsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzAdminClsType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzAdminClsType_Cond), exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzAdminClsType_IsExistRecord_Cache = XzAdminClsType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzAdminClsType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_IsExistRecordAsync = XzAdminClsType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_AdminClsType:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzAdminClsType_IsExist(strid_AdminClsType, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_AdminClsType": strid_AdminClsType,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_IsExist = XzAdminClsType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_AdminClsType:所给的关键字
     * @returns 对象
    */
    async function XzAdminClsType_IsExist_Cache(strid_AdminClsType) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        if (arrXzAdminClsTypeObjLst_Cache == null)
            return false;
        try {
            const arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache.filter(x => x.id_AdminClsType == strid_AdminClsType);
            if (arrXzAdminClsType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_AdminClsType, exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzAdminClsType_IsExist_Cache = XzAdminClsType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_AdminClsType:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzAdminClsType_IsExistAsync(strid_AdminClsType) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_AdminClsType": strid_AdminClsType }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_IsExistAsync = XzAdminClsType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzAdminClsType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetRecCountByCondAsync = XzAdminClsType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzAdminClsType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzAdminClsType_GetRecCountByCond_Cache(objXzAdminClsType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzAdminClsTypeObjLst_Cache = await XzAdminClsType_GetObjLst_Cache();
        if (arrXzAdminClsTypeObjLst_Cache == null)
            return 0;
        let arrXzAdminClsType_Sel = arrXzAdminClsTypeObjLst_Cache;
        if (objXzAdminClsType_Cond.sf_FldComparisonOp == null || objXzAdminClsType_Cond.sf_FldComparisonOp == "")
            return arrXzAdminClsType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzAdminClsType_Cond.sf_FldComparisonOp);
        //console.log("clsXzAdminClsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzAdminClsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzAdminClsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzAdminClsType_Sel = arrXzAdminClsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzAdminClsType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzAdminClsType_Cond), exports.xzAdminClsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzAdminClsType_GetRecCountByCond_Cache = XzAdminClsType_GetRecCountByCond_Cache;
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
    async function XzAdminClsType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzAdminClsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzAdminClsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzAdminClsType_GetMaxStrIdByPrefix = XzAdminClsType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzAdminClsType_GetWebApiUrl(strController, strAction) {
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
    exports.XzAdminClsType_GetWebApiUrl = XzAdminClsType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzAdminClsType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
        switch (clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheModeId) {
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
    exports.XzAdminClsType_ReFreshCache = XzAdminClsType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzAdminClsType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN._CurrTabName;
            switch (clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.CacheModeId) {
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
    exports.XzAdminClsType_ReFreshThisCache = XzAdminClsType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzAdminClsType__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await XzAdminClsType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName, "行政班类型");
    }
    exports.XzAdminClsType__Cache = XzAdminClsType__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzAdminClsType_CheckPropertyNew(pobjXzAdminClsTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[行政班级类型ID]不能为空(In 行政班类型)!(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[行政班级类型名称]不能为空(In 行政班类型)!(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.id_AdminClsType) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.id_AdminClsType) > 4) {
            throw new Error("(errid:Watl000059)字段[行政班级类型流水号(id_AdminClsType)]的长度不能超过4(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.id_AdminClsType)(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.adminClsTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[行政班级类型ID(adminClsTypeId)]的长度不能超过4(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.adminClsTypeId)(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.adminClsTypeName) > 30) {
            throw new Error("(errid:Watl000059)字段[行政班级类型名称(adminClsTypeName)]的长度不能超过30(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.adminClsTypeName)(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.memo)(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.id_AdminClsType) == false && undefined !== pobjXzAdminClsTypeEN.id_AdminClsType && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.id_AdminClsType) === false) {
            throw new Error("(errid:Watl000060)字段[行政班级类型流水号(id_AdminClsType)]的值:[$(pobjXzAdminClsTypeEN.id_AdminClsType)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeId) == false && undefined !== pobjXzAdminClsTypeEN.adminClsTypeId && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.adminClsTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[行政班级类型ID(adminClsTypeId)]的值:[$(pobjXzAdminClsTypeEN.adminClsTypeId)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeName) == false && undefined !== pobjXzAdminClsTypeEN.adminClsTypeName && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.adminClsTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[行政班级类型名称(adminClsTypeName)]的值:[$(pobjXzAdminClsTypeEN.adminClsTypeName)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.memo) == false && undefined !== pobjXzAdminClsTypeEN.memo && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzAdminClsTypeEN.memo)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzAdminClsTypeEN.SetIsCheckProperty(true);
    }
    exports.XzAdminClsType_CheckPropertyNew = XzAdminClsType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzAdminClsType_CheckProperty4Update(pobjXzAdminClsTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.id_AdminClsType) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.id_AdminClsType) > 4) {
            throw new Error("(errid:Watl000062)字段[行政班级类型流水号(id_AdminClsType)]的长度不能超过4(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.id_AdminClsType)(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.adminClsTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[行政班级类型ID(adminClsTypeId)]的长度不能超过4(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.adminClsTypeId)(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.adminClsTypeName) > 30) {
            throw new Error("(errid:Watl000062)字段[行政班级类型名称(adminClsTypeName)]的长度不能超过30(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.adminClsTypeName)(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzAdminClsTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 行政班类型(XzAdminClsType))!值:$(pobjXzAdminClsTypeEN.memo)(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.id_AdminClsType) == false && undefined !== pobjXzAdminClsTypeEN.id_AdminClsType && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.id_AdminClsType) === false) {
            throw new Error("(errid:Watl000063)字段[行政班级类型流水号(id_AdminClsType)]的值:[$(pobjXzAdminClsTypeEN.id_AdminClsType)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeId) == false && undefined !== pobjXzAdminClsTypeEN.adminClsTypeId && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.adminClsTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[行政班级类型ID(adminClsTypeId)]的值:[$(pobjXzAdminClsTypeEN.adminClsTypeId)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.adminClsTypeName) == false && undefined !== pobjXzAdminClsTypeEN.adminClsTypeName && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.adminClsTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[行政班级类型名称(adminClsTypeName)]的值:[$(pobjXzAdminClsTypeEN.adminClsTypeName)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.memo) == false && undefined !== pobjXzAdminClsTypeEN.memo && clsString_js_1.tzDataType.isString(pobjXzAdminClsTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzAdminClsTypeEN.memo)], 非法，应该为字符型(In 行政班类型(XzAdminClsType))!(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzAdminClsTypeEN.id_AdminClsType) === true
            || pobjXzAdminClsTypeEN.id_AdminClsType.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[行政班级类型流水号]不能为空(In 行政班类型)!(clsXzAdminClsTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzAdminClsTypeEN.SetIsCheckProperty(true);
    }
    exports.XzAdminClsType_CheckProperty4Update = XzAdminClsType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzAdminClsType_GetJSONStrByObj(pobjXzAdminClsTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzAdminClsTypeEN.sf_UpdFldSetStr = pobjXzAdminClsTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzAdminClsTypeEN);
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
    exports.XzAdminClsType_GetJSONStrByObj = XzAdminClsType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzAdminClsType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzAdminClsTypeObjLst = new Array();
        if (strJSON === "") {
            return arrXzAdminClsTypeObjLst;
        }
        try {
            arrXzAdminClsTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzAdminClsTypeObjLst;
        }
        return arrXzAdminClsTypeObjLst;
    }
    exports.XzAdminClsType_GetObjLstByJSONStr = XzAdminClsType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzAdminClsTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzAdminClsType_GetObjLstByJSONObjLst(arrXzAdminClsTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzAdminClsTypeObjLst = new Array();
        for (const objInFor of arrXzAdminClsTypeObjLstS) {
            const obj1 = XzAdminClsType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzAdminClsTypeObjLst.push(obj1);
        }
        return arrXzAdminClsTypeObjLst;
    }
    exports.XzAdminClsType_GetObjLstByJSONObjLst = XzAdminClsType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzAdminClsType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzAdminClsTypeEN = new clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN();
        if (strJSON === "") {
            return pobjXzAdminClsTypeEN;
        }
        try {
            pobjXzAdminClsTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzAdminClsTypeEN;
        }
        return pobjXzAdminClsTypeEN;
    }
    exports.XzAdminClsType_GetObjByJSONStr = XzAdminClsType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzAdminClsType_GetCombineCondition(objXzAdminClsType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzAdminClsType_Cond.dicFldComparisonOp, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType) == true) {
            const strComparisonOp_id_AdminClsType = objXzAdminClsType_Cond.dicFldComparisonOp[clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_id_AdminClsType, objXzAdminClsType_Cond.id_AdminClsType, strComparisonOp_id_AdminClsType);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminClsType_Cond.dicFldComparisonOp, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeId) == true) {
            const strComparisonOp_AdminClsTypeId = objXzAdminClsType_Cond.dicFldComparisonOp[clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeId, objXzAdminClsType_Cond.adminClsTypeId, strComparisonOp_AdminClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminClsType_Cond.dicFldComparisonOp, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName) == true) {
            const strComparisonOp_AdminClsTypeName = objXzAdminClsType_Cond.dicFldComparisonOp[clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_AdminClsTypeName, objXzAdminClsType_Cond.adminClsTypeName, strComparisonOp_AdminClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzAdminClsType_Cond.dicFldComparisonOp, clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzAdminClsType_Cond.dicFldComparisonOp[clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN.con_Memo, objXzAdminClsType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzAdminClsType_GetCombineCondition = XzAdminClsType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzAdminClsTypeENS:源对象
     * @param objXzAdminClsTypeENT:目标对象
    */
    function XzAdminClsType_CopyObjTo(objXzAdminClsTypeENS, objXzAdminClsTypeENT) {
        objXzAdminClsTypeENT.id_AdminClsType = objXzAdminClsTypeENS.id_AdminClsType; //行政班级类型流水号
        objXzAdminClsTypeENT.adminClsTypeId = objXzAdminClsTypeENS.adminClsTypeId; //行政班级类型ID
        objXzAdminClsTypeENT.adminClsTypeName = objXzAdminClsTypeENS.adminClsTypeName; //行政班级类型名称
        objXzAdminClsTypeENT.memo = objXzAdminClsTypeENS.memo; //备注
        objXzAdminClsTypeENT.sf_UpdFldSetStr = objXzAdminClsTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzAdminClsType_CopyObjTo = XzAdminClsType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzAdminClsTypeENS:源对象
     * @param objXzAdminClsTypeENT:目标对象
    */
    function XzAdminClsType_GetObjFromJsonObj(objXzAdminClsTypeENS) {
        const objXzAdminClsTypeENT = new clsXzAdminClsTypeEN_js_1.clsXzAdminClsTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzAdminClsTypeENT, objXzAdminClsTypeENS);
        return objXzAdminClsTypeENT;
    }
    exports.XzAdminClsType_GetObjFromJsonObj = XzAdminClsType_GetObjFromJsonObj;
});
