/**
* 类名:clsXzMajorTypeWApi
* 表名:XzMajorType(01120068)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 02:43:30
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:课程学习(CourseLearning)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/CourseLearning_Share/clsXzMajorTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.XzMajorType_GetObjFromJsonObj = exports.XzMajorType_CopyObjTo = exports.XzMajorType_GetCombineCondition = exports.XzMajorType_GetObjByJSONStr = exports.XzMajorType_GetObjLstByJSONObjLst = exports.XzMajorType_GetObjLstByJSONStr = exports.XzMajorType_GetJSONStrByObj = exports.XzMajorType_CheckProperty4Update = exports.XzMajorType_CheckPropertyNew = exports.XzMajorType__Cache = exports.XzMajorType_ReFreshThisCache = exports.XzMajorType_ReFreshCache = exports.XzMajorType_GetWebApiUrl = exports.XzMajorType_GetMaxStrIdByPrefix = exports.XzMajorType_GetRecCountByCond_Cache = exports.XzMajorType_GetRecCountByCondAsync = exports.XzMajorType_IsExistAsync = exports.XzMajorType_IsExist_Cache = exports.XzMajorType_IsExist = exports.XzMajorType_IsExistRecordAsync = exports.XzMajorType_IsExistRecord_Cache = exports.XzMajorType_UpdateWithConditionAsync = exports.XzMajorType_UpdateRecordAsync = exports.XzMajorType_AddNewRecordWithReturnKey = exports.XzMajorType_AddNewRecordWithReturnKeyAsync = exports.XzMajorType_AddNewRecordWithMaxIdAsync = exports.XzMajorType_AddNewRecordAsync = exports.XzMajorType_DelXzMajorTypesByCondAsync = exports.XzMajorType_DelXzMajorTypesAsync = exports.XzMajorType_DelRecordAsync = exports.XzMajorType_GetObjLstByPagerAsync = exports.XzMajorType_GetObjLstByPager_Cache = exports.XzMajorType_GetObjLstByRange = exports.XzMajorType_GetObjLstByRangeAsync = exports.XzMajorType_GetTopObjLstAsync = exports.XzMajorType_GetObjLstByid_MajorTypeLst_Cache = exports.XzMajorType_GetObjLstByid_MajorTypeLstAsync = exports.XzMajorType_GetSubObjLst_Cache = exports.XzMajorType_GetObjLst_PureCache = exports.XzMajorType_GetObjLst_Cache = exports.XzMajorType_GetObjLst_sessionStorage_PureCache = exports.XzMajorType_GetObjLst_sessionStorage = exports.XzMajorType_GetObjLstAsync = exports.XzMajorType_GetObjLst_localStorage_PureCache = exports.XzMajorType_GetObjLst_localStorage = exports.XzMajorType_GetObjLst_ClientCache = exports.XzMajorType_GetFirstObjAsync = exports.XzMajorType_GetFirstID = exports.XzMajorType_GetFirstIDAsync = exports.XzMajorType_funcKey = exports.XzMajorType_FilterFunByKey = exports.XzMajorType_SortFunByKey = exports.XzMajorType_SortFun_Defa_2Fld = exports.XzMajorType_SortFun_Defa = exports.XzMajorType_func = exports.XzMajorType_GetNameByid_MajorType_Cache = exports.XzMajorType_UpdateObjInLst_Cache = exports.XzMajorType_GetObjByid_MajorType_localStorage = exports.XzMajorType_GetObjByid_MajorType_Cache = exports.XzMajorType_GetObjByid_MajorTypeAsync = exports.xzMajorType_ConstructorName = exports.xzMajorType_Controller = void 0;
    /**
     * 专业类型(XzMajorType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsXzMajorTypeEN_js_1 = require("../../L0_Entity/CourseLearning_Share/clsXzMajorTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.xzMajorType_Controller = "XzMajorTypeApi";
    exports.xzMajorType_ConstructorName = "xzMajorType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_MajorType:关键字
    * @returns 对象
    **/
    async function XzMajorType_GetObjByid_MajorTypeAsync(strid_MajorType) {
        const strThisFuncName = "GetObjByid_MajorTypeAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_MajorType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_MajorType]不能为空！(In clsXzMajorTypeWApi.GetObjByid_MajorTypeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_MajorType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_MajorType]的长度:[{0}]不正确！(clsXzMajorTypeWApi.GetObjByid_MajorTypeAsync)", strid_MajorType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_MajorType";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_MajorType": strid_MajorType,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objXzMajorType = XzMajorType_GetObjFromJsonObj(returnObj);
                return objXzMajorType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetObjByid_MajorTypeAsync = XzMajorType_GetObjByid_MajorTypeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_MajorType:所给的关键字
     * @returns 对象
    */
    async function XzMajorType_GetObjByid_MajorType_Cache(strid_MajorType, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_MajorType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_MajorType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_MajorType]不能为空！(In clsXzMajorTypeWApi.GetObjByid_MajorType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_MajorType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_MajorType]的长度:[{0}]不正确！(clsXzMajorTypeWApi.GetObjByid_MajorType_Cache)", strid_MajorType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        try {
            const arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache.filter(x => x.id_MajorType == strid_MajorType);
            let objXzMajorType;
            if (arrXzMajorType_Sel.length > 0) {
                objXzMajorType = arrXzMajorType_Sel[0];
                return objXzMajorType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objXzMajorType_Const = await XzMajorType_GetObjByid_MajorTypeAsync(strid_MajorType);
                    if (objXzMajorType_Const != null) {
                        XzMajorType_ReFreshThisCache();
                        return objXzMajorType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_MajorType, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.XzMajorType_GetObjByid_MajorType_Cache = XzMajorType_GetObjByid_MajorType_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_MajorType:所给的关键字
     * @returns 对象
    */
    async function XzMajorType_GetObjByid_MajorType_localStorage(strid_MajorType) {
        const strThisFuncName = "GetObjByid_MajorType_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_MajorType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_MajorType]不能为空！(In clsXzMajorTypeWApi.GetObjByid_MajorType_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_MajorType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_MajorType]的长度:[{0}]不正确！(clsXzMajorTypeWApi.GetObjByid_MajorType_localStorage)", strid_MajorType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName, strid_MajorType);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objXzMajorType_Cache = JSON.parse(strTempObj);
            return objXzMajorType_Cache;
        }
        try {
            const objXzMajorType = await XzMajorType_GetObjByid_MajorTypeAsync(strid_MajorType);
            if (objXzMajorType != null) {
                localStorage.setItem(strKey, JSON.stringify(objXzMajorType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objXzMajorType;
            }
            return objXzMajorType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_MajorType, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.XzMajorType_GetObjByid_MajorType_localStorage = XzMajorType_GetObjByid_MajorType_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objXzMajorType:所给的对象
     * @returns 对象
    */
    async function XzMajorType_UpdateObjInLst_Cache(objXzMajorType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
            const obj = arrXzMajorTypeObjLst_Cache.find(x => x.id_MajorType == objXzMajorType.id_MajorType);
            if (obj != null) {
                objXzMajorType.id_MajorType = obj.id_MajorType;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objXzMajorType);
            }
            else {
                arrXzMajorTypeObjLst_Cache.push(objXzMajorType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.XzMajorType_UpdateObjInLst_Cache = XzMajorType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_MajorType:所给的关键字
     * @returns 对象
    */
    async function XzMajorType_GetNameByid_MajorType_Cache(strid_MajorType) {
        const strThisFuncName = "GetNameByid_MajorType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_MajorType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_MajorType]不能为空！(In clsXzMajorTypeWApi.GetNameByid_MajorType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_MajorType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_MajorType]的长度:[{0}]不正确！(clsXzMajorTypeWApi.GetNameByid_MajorType_Cache)", strid_MajorType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        if (arrXzMajorTypeObjLst_Cache == null)
            return "";
        try {
            const arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache.filter(x => x.id_MajorType == strid_MajorType);
            let objXzMajorType;
            if (arrXzMajorType_Sel.length > 0) {
                objXzMajorType = arrXzMajorType_Sel[0];
                return objXzMajorType.majorTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_MajorType);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.XzMajorType_GetNameByid_MajorType_Cache = XzMajorType_GetNameByid_MajorType_Cache;
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
    async function XzMajorType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_MajorType = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objXzMajorType = await XzMajorType_GetObjByid_MajorType_Cache(strid_MajorType);
        if (objXzMajorType == null)
            return "";
        if (objXzMajorType.GetFldValue(strOutFldName) == null)
            return "";
        return objXzMajorType.GetFldValue(strOutFldName).toString();
    }
    exports.XzMajorType_func = XzMajorType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_MajorType.localeCompare(b.id_MajorType);
    }
    exports.XzMajorType_SortFun_Defa = XzMajorType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.majorTypeID == b.majorTypeID)
            return a.majorTypeName.localeCompare(b.majorTypeName);
        else
            return a.majorTypeID.localeCompare(b.majorTypeID);
    }
    exports.XzMajorType_SortFun_Defa_2Fld = XzMajorType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function XzMajorType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType:
                    return (a, b) => {
                        return a.id_MajorType.localeCompare(b.id_MajorType);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeID:
                    return (a, b) => {
                        return a.majorTypeID.localeCompare(b.majorTypeID);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName:
                    return (a, b) => {
                        return a.majorTypeName.localeCompare(b.majorTypeName);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajorType]中不存在！(in ${exports.xzMajorType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType:
                    return (a, b) => {
                        return b.id_MajorType.localeCompare(a.id_MajorType);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeID:
                    return (a, b) => {
                        return b.majorTypeID.localeCompare(a.majorTypeID);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName:
                    return (a, b) => {
                        return b.majorTypeName.localeCompare(a.majorTypeName);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[XzMajorType]中不存在！(in ${exports.xzMajorType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.XzMajorType_SortFunByKey = XzMajorType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function XzMajorType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType:
                return (obj) => {
                    return obj.id_MajorType === value;
                };
            case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeID:
                return (obj) => {
                    return obj.majorTypeID === value;
                };
            case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName:
                return (obj) => {
                    return obj.majorTypeName === value;
                };
            case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[XzMajorType]中不存在！(in ${exports.xzMajorType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.XzMajorType_FilterFunByKey = XzMajorType_FilterFunByKey;
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
    async function XzMajorType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrXzMajorType = await XzMajorType_GetObjLst_Cache();
        if (arrXzMajorType == null)
            return [];
        let arrXzMajorType_Sel = arrXzMajorType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrXzMajorType_Sel.length == 0)
            return [];
        return arrXzMajorType_Sel.map(x => x.id_MajorType);
    }
    exports.XzMajorType_funcKey = XzMajorType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajorType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetFirstIDAsync = XzMajorType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function XzMajorType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetFirstID = XzMajorType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function XzMajorType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const objXzMajorType = XzMajorType_GetObjFromJsonObj(returnObj);
                return objXzMajorType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetFirstObjAsync = XzMajorType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrXzMajorTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrXzMajorTypeObjLst_T = XzMajorType_GetObjLstByJSONObjLst(arrXzMajorTypeExObjLst_Cache);
            return arrXzMajorTypeObjLst_T;
        }
        try {
            const arrXzMajorTypeExObjLst = await XzMajorType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrXzMajorTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorTypeExObjLst.length);
            console.log(strInfo);
            return arrXzMajorTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorType_GetObjLst_ClientCache = XzMajorType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorTypeObjLst_T = XzMajorType_GetObjLstByJSONObjLst(arrXzMajorTypeExObjLst_Cache);
            return arrXzMajorTypeObjLst_T;
        }
        try {
            const arrXzMajorTypeExObjLst = await XzMajorType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrXzMajorTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorTypeExObjLst.length);
            console.log(strInfo);
            return arrXzMajorTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorType_GetObjLst_localStorage = XzMajorType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrXzMajorTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajorType_GetObjLst_localStorage_PureCache = XzMajorType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function XzMajorType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetObjLstAsync = XzMajorType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrXzMajorTypeObjLst_T = XzMajorType_GetObjLstByJSONObjLst(arrXzMajorTypeExObjLst_Cache);
            return arrXzMajorTypeObjLst_T;
        }
        try {
            const arrXzMajorTypeExObjLst = await XzMajorType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrXzMajorTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrXzMajorTypeExObjLst.length);
            console.log(strInfo);
            return arrXzMajorTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.XzMajorType_GetObjLst_sessionStorage = XzMajorType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrXzMajorTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrXzMajorTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.XzMajorType_GetObjLst_sessionStorage_PureCache = XzMajorType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrXzMajorTypeObjLst_Cache;
        switch (clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_ClientCache();
                break;
            default:
                arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_ClientCache();
                break;
        }
        const arrXzMajorTypeObjLst = XzMajorType_GetObjLstByJSONObjLst(arrXzMajorTypeObjLst_Cache);
        return arrXzMajorTypeObjLst_Cache;
    }
    exports.XzMajorType_GetObjLst_Cache = XzMajorType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function XzMajorType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrXzMajorTypeObjLst_Cache;
        switch (clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrXzMajorTypeObjLst_Cache = null;
                break;
            default:
                arrXzMajorTypeObjLst_Cache = null;
                break;
        }
        return arrXzMajorTypeObjLst_Cache;
    }
    exports.XzMajorType_GetObjLst_PureCache = XzMajorType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_MajorType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajorType_GetSubObjLst_Cache(objXzMajorType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        let arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache;
        if (objXzMajorType_Cond.sf_FldComparisonOp == null || objXzMajorType_Cond.sf_FldComparisonOp == "")
            return arrXzMajorType_Sel;
        const dicFldComparisonOp = JSON.parse(objXzMajorType_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajorType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objXzMajorType_Cond), exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorType_GetSubObjLst_Cache = XzMajorType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_MajorType:关键字列表
    * @returns 对象列表
    **/
    async function XzMajorType_GetObjLstByid_MajorTypeLstAsync(arrid_MajorType) {
        const strThisFuncName = "GetObjLstByid_MajorTypeLstAsync";
        const strAction = "GetObjLstByid_MajorTypeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_MajorType);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetObjLstByid_MajorTypeLstAsync = XzMajorType_GetObjLstByid_MajorTypeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_MajorTypeLst:关键字列表
     * @returns 对象列表
    */
    async function XzMajorType_GetObjLstByid_MajorTypeLst_Cache(arrid_MajorTypeLst) {
        const strThisFuncName = "GetObjLstByid_MajorTypeLst_Cache";
        try {
            const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
            const arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache.filter(x => arrid_MajorTypeLst.indexOf(x.id_MajorType) > -1);
            return arrXzMajorType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_MajorTypeLst.join(","), exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.XzMajorType_GetObjLstByid_MajorTypeLst_Cache = XzMajorType_GetObjLstByid_MajorTypeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function XzMajorType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetTopObjLstAsync = XzMajorType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajorType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetObjLstByRangeAsync = XzMajorType_GetObjLstByRangeAsync;
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
    async function XzMajorType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetObjLstByRange = XzMajorType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function XzMajorType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        if (arrXzMajorTypeObjLst_Cache.length == 0)
            return arrXzMajorTypeObjLst_Cache;
        let arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objXzMajorType_Cond = new clsXzMajorTypeEN_js_1.clsXzMajorTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsXzMajorTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorType_Sel.length == 0)
                return arrXzMajorType_Sel;
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
                arrXzMajorType_Sel = arrXzMajorType_Sel.sort(XzMajorType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrXzMajorType_Sel = arrXzMajorType_Sel.sort(objPagerPara.sortFun);
            }
            arrXzMajorType_Sel = arrXzMajorType_Sel.slice(intStart, intEnd);
            return arrXzMajorType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.XzMajorType_GetObjLstByPager_Cache = XzMajorType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function XzMajorType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.xzMajorType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = XzMajorType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetObjLstByPagerAsync = XzMajorType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_MajorType:关键字
    * @returns 获取删除的结果
    **/
    async function XzMajorType_DelRecordAsync(strid_MajorType) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_MajorType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_DelRecordAsync = XzMajorType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_MajorType:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function XzMajorType_DelXzMajorTypesAsync(arrid_MajorType) {
        const strThisFuncName = "DelXzMajorTypesAsync";
        const strAction = "DelXzMajorTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_MajorType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_DelXzMajorTypesAsync = XzMajorType_DelXzMajorTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function XzMajorType_DelXzMajorTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelXzMajorTypesByCondAsync";
        const strAction = "DelXzMajorTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_DelXzMajorTypesByCondAsync = XzMajorType_DelXzMajorTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objXzMajorTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajorType_AddNewRecordAsync(objXzMajorTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objXzMajorTypeEN.id_MajorType === null || objXzMajorTypeEN.id_MajorType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objXzMajorTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_AddNewRecordAsync = XzMajorType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objXzMajorTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function XzMajorType_AddNewRecordWithMaxIdAsync(objXzMajorTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_AddNewRecordWithMaxIdAsync = XzMajorType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objXzMajorTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function XzMajorType_AddNewRecordWithReturnKeyAsync(objXzMajorTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_AddNewRecordWithReturnKeyAsync = XzMajorType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objXzMajorTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function XzMajorType_AddNewRecordWithReturnKey(objXzMajorTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objXzMajorTypeEN.id_MajorType === null || objXzMajorTypeEN.id_MajorType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_AddNewRecordWithReturnKey = XzMajorType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objXzMajorTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function XzMajorType_UpdateRecordAsync(objXzMajorTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objXzMajorTypeEN.sf_UpdFldSetStr === undefined || objXzMajorTypeEN.sf_UpdFldSetStr === null || objXzMajorTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorTypeEN.id_MajorType);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_UpdateRecordAsync = XzMajorType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objXzMajorTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function XzMajorType_UpdateWithConditionAsync(objXzMajorTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objXzMajorTypeEN.sf_UpdFldSetStr === undefined || objXzMajorTypeEN.sf_UpdFldSetStr === null || objXzMajorTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objXzMajorTypeEN.id_MajorType);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        objXzMajorTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objXzMajorTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_UpdateWithConditionAsync = XzMajorType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_MajorType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function XzMajorType_IsExistRecord_Cache(objXzMajorType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        if (arrXzMajorTypeObjLst_Cache == null)
            return false;
        let arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache;
        if (objXzMajorType_Cond.sf_FldComparisonOp == null || objXzMajorType_Cond.sf_FldComparisonOp == "")
            return arrXzMajorType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objXzMajorType_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrXzMajorType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objXzMajorType_Cond), exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.XzMajorType_IsExistRecord_Cache = XzMajorType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function XzMajorType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_IsExistRecordAsync = XzMajorType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_MajorType:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function XzMajorType_IsExist(strid_MajorType, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_MajorType": strid_MajorType,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_IsExist = XzMajorType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_MajorType:所给的关键字
     * @returns 对象
    */
    async function XzMajorType_IsExist_Cache(strid_MajorType) {
        const strThisFuncName = "IsExist_Cache";
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        if (arrXzMajorTypeObjLst_Cache == null)
            return false;
        try {
            const arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache.filter(x => x.id_MajorType == strid_MajorType);
            if (arrXzMajorType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_MajorType, exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.XzMajorType_IsExist_Cache = XzMajorType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_MajorType:关键字
    * @returns 是否存在?存在返回True
    **/
    async function XzMajorType_IsExistAsync(strid_MajorType) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_MajorType": strid_MajorType }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_IsExistAsync = XzMajorType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function XzMajorType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetRecCountByCondAsync = XzMajorType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objXzMajorType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function XzMajorType_GetRecCountByCond_Cache(objXzMajorType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrXzMajorTypeObjLst_Cache = await XzMajorType_GetObjLst_Cache();
        if (arrXzMajorTypeObjLst_Cache == null)
            return 0;
        let arrXzMajorType_Sel = arrXzMajorTypeObjLst_Cache;
        if (objXzMajorType_Cond.sf_FldComparisonOp == null || objXzMajorType_Cond.sf_FldComparisonOp == "")
            return arrXzMajorType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objXzMajorType_Cond.sf_FldComparisonOp);
        //console.log("clsXzMajorTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objXzMajorType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objXzMajorType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrXzMajorType_Sel = arrXzMajorType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrXzMajorType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objXzMajorType_Cond), exports.xzMajorType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.XzMajorType_GetRecCountByCond_Cache = XzMajorType_GetRecCountByCond_Cache;
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
    async function XzMajorType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.xzMajorType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.xzMajorType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.XzMajorType_GetMaxStrIdByPrefix = XzMajorType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function XzMajorType_GetWebApiUrl(strController, strAction) {
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
    exports.XzMajorType_GetWebApiUrl = XzMajorType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function XzMajorType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
        switch (clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheModeId) {
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
    exports.XzMajorType_ReFreshCache = XzMajorType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function XzMajorType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsXzMajorTypeEN_js_1.clsXzMajorTypeEN._CurrTabName;
            switch (clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.CacheModeId) {
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
    exports.XzMajorType_ReFreshThisCache = XzMajorType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function XzMajorType__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await XzMajorType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName, "专业类型");
    }
    exports.XzMajorType__Cache = XzMajorType__Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajorType_CheckPropertyNew(pobjXzMajorTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeID) === true) {
            throw new Error("(errid:Watl000058)字段[专业类型代号]不能为空(In 专业类型)!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[专业类型名称]不能为空(In 专业类型)!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.id_MajorType) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.id_MajorType) > 4) {
            throw new Error("(errid:Watl000059)字段[专业类型(文理工)流水号(id_MajorType)]的长度不能超过4(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.id_MajorType)(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.majorTypeID) > 2) {
            throw new Error("(errid:Watl000059)字段[专业类型代号(majorTypeID)]的长度不能超过2(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.majorTypeID)(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.majorTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[专业类型名称(majorTypeName)]的长度不能超过50(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.majorTypeName)(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.modifyUserID)(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.modifyDate)(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.memo)(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.id_MajorType) == false && undefined !== pobjXzMajorTypeEN.id_MajorType && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.id_MajorType) === false) {
            throw new Error("(errid:Watl000060)字段[专业类型(文理工)流水号(id_MajorType)]的值:[$(pobjXzMajorTypeEN.id_MajorType)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeID) == false && undefined !== pobjXzMajorTypeEN.majorTypeID && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.majorTypeID) === false) {
            throw new Error("(errid:Watl000060)字段[专业类型代号(majorTypeID)]的值:[$(pobjXzMajorTypeEN.majorTypeID)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeName) == false && undefined !== pobjXzMajorTypeEN.majorTypeName && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.majorTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[专业类型名称(majorTypeName)]的值:[$(pobjXzMajorTypeEN.majorTypeName)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyUserID) == false && undefined !== pobjXzMajorTypeEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjXzMajorTypeEN.modifyUserID)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyDate) == false && undefined !== pobjXzMajorTypeEN.modifyDate && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjXzMajorTypeEN.modifyDate)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.memo) == false && undefined !== pobjXzMajorTypeEN.memo && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjXzMajorTypeEN.memo)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjXzMajorTypeEN.SetIsCheckProperty(true);
    }
    exports.XzMajorType_CheckPropertyNew = XzMajorType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function XzMajorType_CheckProperty4Update(pobjXzMajorTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.id_MajorType) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.id_MajorType) > 4) {
            throw new Error("(errid:Watl000062)字段[专业类型(文理工)流水号(id_MajorType)]的长度不能超过4(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.id_MajorType)(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.majorTypeID) > 2) {
            throw new Error("(errid:Watl000062)字段[专业类型代号(majorTypeID)]的长度不能超过2(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.majorTypeID)(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.majorTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[专业类型名称(majorTypeName)]的长度不能超过50(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.majorTypeName)(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.modifyUserID)(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.modifyDate)(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjXzMajorTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 专业类型(XzMajorType))!值:$(pobjXzMajorTypeEN.memo)(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.id_MajorType) == false && undefined !== pobjXzMajorTypeEN.id_MajorType && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.id_MajorType) === false) {
            throw new Error("(errid:Watl000063)字段[专业类型(文理工)流水号(id_MajorType)]的值:[$(pobjXzMajorTypeEN.id_MajorType)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeID) == false && undefined !== pobjXzMajorTypeEN.majorTypeID && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.majorTypeID) === false) {
            throw new Error("(errid:Watl000063)字段[专业类型代号(majorTypeID)]的值:[$(pobjXzMajorTypeEN.majorTypeID)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.majorTypeName) == false && undefined !== pobjXzMajorTypeEN.majorTypeName && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.majorTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[专业类型名称(majorTypeName)]的值:[$(pobjXzMajorTypeEN.majorTypeName)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyUserID) == false && undefined !== pobjXzMajorTypeEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjXzMajorTypeEN.modifyUserID)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.modifyDate) == false && undefined !== pobjXzMajorTypeEN.modifyDate && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjXzMajorTypeEN.modifyDate)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.memo) == false && undefined !== pobjXzMajorTypeEN.memo && clsString_js_1.tzDataType.isString(pobjXzMajorTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjXzMajorTypeEN.memo)], 非法，应该为字符型(In 专业类型(XzMajorType))!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjXzMajorTypeEN.id_MajorType) === true
            || pobjXzMajorTypeEN.id_MajorType.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[专业类型(文理工)流水号]不能为空(In 专业类型)!(clsXzMajorTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjXzMajorTypeEN.SetIsCheckProperty(true);
    }
    exports.XzMajorType_CheckProperty4Update = XzMajorType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajorType_GetJSONStrByObj(pobjXzMajorTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjXzMajorTypeEN.sf_UpdFldSetStr = pobjXzMajorTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjXzMajorTypeEN);
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
    exports.XzMajorType_GetJSONStrByObj = XzMajorType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function XzMajorType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrXzMajorTypeObjLst = new Array();
        if (strJSON === "") {
            return arrXzMajorTypeObjLst;
        }
        try {
            arrXzMajorTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrXzMajorTypeObjLst;
        }
        return arrXzMajorTypeObjLst;
    }
    exports.XzMajorType_GetObjLstByJSONStr = XzMajorType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrXzMajorTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function XzMajorType_GetObjLstByJSONObjLst(arrXzMajorTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrXzMajorTypeObjLst = new Array();
        for (const objInFor of arrXzMajorTypeObjLstS) {
            const obj1 = XzMajorType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrXzMajorTypeObjLst.push(obj1);
        }
        return arrXzMajorTypeObjLst;
    }
    exports.XzMajorType_GetObjLstByJSONObjLst = XzMajorType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function XzMajorType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjXzMajorTypeEN = new clsXzMajorTypeEN_js_1.clsXzMajorTypeEN();
        if (strJSON === "") {
            return pobjXzMajorTypeEN;
        }
        try {
            pobjXzMajorTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjXzMajorTypeEN;
        }
        return pobjXzMajorTypeEN;
    }
    exports.XzMajorType_GetObjByJSONStr = XzMajorType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function XzMajorType_GetCombineCondition(objXzMajorType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objXzMajorType_Cond.dicFldComparisonOp, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType) == true) {
            const strComparisonOp_id_MajorType = objXzMajorType_Cond.dicFldComparisonOp[clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_id_MajorType, objXzMajorType_Cond.id_MajorType, strComparisonOp_id_MajorType);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorType_Cond.dicFldComparisonOp, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeID) == true) {
            const strComparisonOp_MajorTypeID = objXzMajorType_Cond.dicFldComparisonOp[clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeID, objXzMajorType_Cond.majorTypeID, strComparisonOp_MajorTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorType_Cond.dicFldComparisonOp, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName) == true) {
            const strComparisonOp_MajorTypeName = objXzMajorType_Cond.dicFldComparisonOp[clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_MajorTypeName, objXzMajorType_Cond.majorTypeName, strComparisonOp_MajorTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorType_Cond.dicFldComparisonOp, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objXzMajorType_Cond.dicFldComparisonOp[clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyUserID, objXzMajorType_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorType_Cond.dicFldComparisonOp, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objXzMajorType_Cond.dicFldComparisonOp[clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_ModifyDate, objXzMajorType_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objXzMajorType_Cond.dicFldComparisonOp, clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objXzMajorType_Cond.dicFldComparisonOp[clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsXzMajorTypeEN_js_1.clsXzMajorTypeEN.con_Memo, objXzMajorType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.XzMajorType_GetCombineCondition = XzMajorType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objXzMajorTypeENS:源对象
     * @param objXzMajorTypeENT:目标对象
    */
    function XzMajorType_CopyObjTo(objXzMajorTypeENS, objXzMajorTypeENT) {
        objXzMajorTypeENT.id_MajorType = objXzMajorTypeENS.id_MajorType; //专业类型(文理工)流水号
        objXzMajorTypeENT.majorTypeID = objXzMajorTypeENS.majorTypeID; //专业类型代号
        objXzMajorTypeENT.majorTypeName = objXzMajorTypeENS.majorTypeName; //专业类型名称
        objXzMajorTypeENT.modifyUserID = objXzMajorTypeENS.modifyUserID; //修改人
        objXzMajorTypeENT.modifyDate = objXzMajorTypeENS.modifyDate; //修改日期
        objXzMajorTypeENT.memo = objXzMajorTypeENS.memo; //备注
        objXzMajorTypeENT.sf_UpdFldSetStr = objXzMajorTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.XzMajorType_CopyObjTo = XzMajorType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objXzMajorTypeENS:源对象
     * @param objXzMajorTypeENT:目标对象
    */
    function XzMajorType_GetObjFromJsonObj(objXzMajorTypeENS) {
        const objXzMajorTypeENT = new clsXzMajorTypeEN_js_1.clsXzMajorTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objXzMajorTypeENT, objXzMajorTypeENS);
        return objXzMajorTypeENT;
    }
    exports.XzMajorType_GetObjFromJsonObj = XzMajorType_GetObjFromJsonObj;
});
