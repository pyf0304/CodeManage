/**
* 类名:clsRsStuTypeWApi
* 表名:RsStuType(01120162)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:50:35
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:成长档案(EPortfolio)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/EPortfolio/clsRsStuTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.RsStuType_GetObjFromJsonObj = exports.RsStuType_CopyObjTo = exports.RsStuType_GetCombineCondition = exports.RsStuType_GetObjByJSONStr = exports.RsStuType_GetObjLstByJSONObjLst = exports.RsStuType_GetObjLstByJSONStr = exports.RsStuType_GetJSONStrByObj = exports.RsStuType_CheckProperty4Update = exports.RsStuType_CheckPropertyNew = exports.RsStuType_BindDdl_id_StuTypeInDiv_Cache = exports.RsStuType_ReFreshThisCache = exports.RsStuType_ReFreshCache = exports.RsStuType_GetWebApiUrl = exports.RsStuType_GetMaxStrIdByPrefix = exports.RsStuType_GetRecCountByCond_Cache = exports.RsStuType_GetRecCountByCondAsync = exports.RsStuType_IsExistAsync = exports.RsStuType_IsExist_Cache = exports.RsStuType_IsExist = exports.RsStuType_IsExistRecordAsync = exports.RsStuType_IsExistRecord_Cache = exports.RsStuType_UpdateWithConditionAsync = exports.RsStuType_UpdateRecordAsync = exports.RsStuType_AddNewRecordWithReturnKey = exports.RsStuType_AddNewRecordWithReturnKeyAsync = exports.RsStuType_AddNewRecordWithMaxIdAsync = exports.RsStuType_AddNewRecordAsync = exports.RsStuType_DelRsStuTypesByCondAsync = exports.RsStuType_DelRsStuTypesAsync = exports.RsStuType_DelRecordAsync = exports.RsStuType_GetObjLstByPagerAsync = exports.RsStuType_GetObjLstByPager_Cache = exports.RsStuType_GetObjLstByRange = exports.RsStuType_GetObjLstByRangeAsync = exports.RsStuType_GetTopObjLstAsync = exports.RsStuType_GetObjLstByid_StuTypeLst_Cache = exports.RsStuType_GetObjLstByid_StuTypeLstAsync = exports.RsStuType_GetSubObjLst_Cache = exports.RsStuType_GetObjLst_PureCache = exports.RsStuType_GetObjLst_Cache = exports.RsStuType_GetObjLst_sessionStorage_PureCache = exports.RsStuType_GetObjLst_sessionStorage = exports.RsStuType_GetObjLstAsync = exports.RsStuType_GetObjLst_localStorage_PureCache = exports.RsStuType_GetObjLst_localStorage = exports.RsStuType_GetObjLst_ClientCache = exports.RsStuType_GetFirstObjAsync = exports.RsStuType_GetFirstID = exports.RsStuType_GetFirstIDAsync = exports.RsStuType_funcKey = exports.RsStuType_FilterFunByKey = exports.RsStuType_SortFunByKey = exports.RsStuType_SortFun_Defa_2Fld = exports.RsStuType_SortFun_Defa = exports.RsStuType_func = exports.RsStuType_GetNameByid_StuType_Cache = exports.RsStuType_UpdateObjInLst_Cache = exports.RsStuType_GetObjByid_StuType_localStorage = exports.RsStuType_GetObjByid_StuType_Cache = exports.RsStuType_GetObjByid_StuTypeAsync = exports.rsStuType_ConstructorName = exports.rsStuType_Controller = void 0;
    /**
     * 学生类别(RsStuType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsRsStuTypeEN_js_1 = require("../../L0_Entity/EPortfolio/clsRsStuTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.rsStuType_Controller = "RsStuTypeApi";
    exports.rsStuType_ConstructorName = "rsStuType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_StuType:关键字
    * @returns 对象
    **/
    async function RsStuType_GetObjByid_StuTypeAsync(strid_StuType) {
        const strThisFuncName = "GetObjByid_StuTypeAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_StuType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetObjByid_StuTypeAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StuType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetObjByid_StuTypeAsync)", strid_StuType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_StuType";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_StuType": strid_StuType,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objRsStuType = RsStuType_GetObjFromJsonObj(returnObj);
                return objRsStuType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetObjByid_StuTypeAsync = RsStuType_GetObjByid_StuTypeAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_StuType:所给的关键字
     * @returns 对象
    */
    async function RsStuType_GetObjByid_StuType_Cache(strid_StuType, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_StuType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_StuType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetObjByid_StuType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StuType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetObjByid_StuType_Cache)", strid_StuType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        try {
            const arrRsStuType_Sel = arrRsStuTypeObjLst_Cache.filter(x => x.id_StuType == strid_StuType);
            let objRsStuType;
            if (arrRsStuType_Sel.length > 0) {
                objRsStuType = arrRsStuType_Sel[0];
                return objRsStuType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objRsStuType_Const = await RsStuType_GetObjByid_StuTypeAsync(strid_StuType);
                    if (objRsStuType_Const != null) {
                        RsStuType_ReFreshThisCache();
                        return objRsStuType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StuType, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.RsStuType_GetObjByid_StuType_Cache = RsStuType_GetObjByid_StuType_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_StuType:所给的关键字
     * @returns 对象
    */
    async function RsStuType_GetObjByid_StuType_localStorage(strid_StuType) {
        const strThisFuncName = "GetObjByid_StuType_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_StuType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetObjByid_StuType_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StuType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetObjByid_StuType_localStorage)", strid_StuType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName, strid_StuType);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objRsStuType_Cache = JSON.parse(strTempObj);
            return objRsStuType_Cache;
        }
        try {
            const objRsStuType = await RsStuType_GetObjByid_StuTypeAsync(strid_StuType);
            if (objRsStuType != null) {
                localStorage.setItem(strKey, JSON.stringify(objRsStuType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objRsStuType;
            }
            return objRsStuType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_StuType, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.RsStuType_GetObjByid_StuType_localStorage = RsStuType_GetObjByid_StuType_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objRsStuType:所给的对象
     * @returns 对象
    */
    async function RsStuType_UpdateObjInLst_Cache(objRsStuType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
            const obj = arrRsStuTypeObjLst_Cache.find(x => x.id_StuType == objRsStuType.id_StuType);
            if (obj != null) {
                objRsStuType.id_StuType = obj.id_StuType;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objRsStuType);
            }
            else {
                arrRsStuTypeObjLst_Cache.push(objRsStuType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.RsStuType_UpdateObjInLst_Cache = RsStuType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_StuType:所给的关键字
     * @returns 对象
    */
    async function RsStuType_GetNameByid_StuType_Cache(strid_StuType) {
        const strThisFuncName = "GetNameByid_StuType_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_StuType) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_StuType]不能为空！(In clsRsStuTypeWApi.GetNameByid_StuType_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_StuType.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_StuType]的长度:[{0}]不正确！(clsRsStuTypeWApi.GetNameByid_StuType_Cache)", strid_StuType.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        if (arrRsStuTypeObjLst_Cache == null)
            return "";
        try {
            const arrRsStuType_Sel = arrRsStuTypeObjLst_Cache.filter(x => x.id_StuType == strid_StuType);
            let objRsStuType;
            if (arrRsStuType_Sel.length > 0) {
                objRsStuType = arrRsStuType_Sel[0];
                return objRsStuType.stuTypeDesc;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_StuType);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.RsStuType_GetNameByid_StuType_Cache = RsStuType_GetNameByid_StuType_Cache;
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
    async function RsStuType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsRsStuTypeEN_js_1.clsRsStuTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsRsStuTypeEN_js_1.clsRsStuTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_StuType = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objRsStuType = await RsStuType_GetObjByid_StuType_Cache(strid_StuType);
        if (objRsStuType == null)
            return "";
        if (objRsStuType.GetFldValue(strOutFldName) == null)
            return "";
        return objRsStuType.GetFldValue(strOutFldName).toString();
    }
    exports.RsStuType_func = RsStuType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RsStuType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_StuType.localeCompare(b.id_StuType);
    }
    exports.RsStuType_SortFun_Defa = RsStuType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RsStuType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.stuTypeID == b.stuTypeID)
            return a.stuTypeDesc.localeCompare(b.stuTypeDesc);
        else
            return a.stuTypeID.localeCompare(b.stuTypeID);
    }
    exports.RsStuType_SortFun_Defa_2Fld = RsStuType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function RsStuType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType:
                    return (a, b) => {
                        return a.id_StuType.localeCompare(b.id_StuType);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeID:
                    return (a, b) => {
                        return a.stuTypeID.localeCompare(b.stuTypeID);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc:
                    return (a, b) => {
                        return a.stuTypeDesc.localeCompare(b.stuTypeDesc);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_SpecUniLenDesc:
                    return (a, b) => {
                        if (a.specUniLenDesc == null)
                            return -1;
                        if (b.specUniLenDesc == null)
                            return 1;
                        return a.specUniLenDesc.localeCompare(b.specUniLenDesc);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RsStuType]中不存在！(in ${exports.rsStuType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType:
                    return (a, b) => {
                        return b.id_StuType.localeCompare(a.id_StuType);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeID:
                    return (a, b) => {
                        return b.stuTypeID.localeCompare(a.stuTypeID);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc:
                    return (a, b) => {
                        return b.stuTypeDesc.localeCompare(a.stuTypeDesc);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_SpecUniLenDesc:
                    return (a, b) => {
                        if (b.specUniLenDesc == null)
                            return -1;
                        if (a.specUniLenDesc == null)
                            return 1;
                        return b.specUniLenDesc.localeCompare(a.specUniLenDesc);
                    };
                case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[RsStuType]中不存在！(in ${exports.rsStuType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.RsStuType_SortFunByKey = RsStuType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function RsStuType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType:
                return (obj) => {
                    return obj.id_StuType === value;
                };
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeID:
                return (obj) => {
                    return obj.stuTypeID === value;
                };
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc:
                return (obj) => {
                    return obj.stuTypeDesc === value;
                };
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_SpecUniLenDesc:
                return (obj) => {
                    return obj.specUniLenDesc === value;
                };
            case clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[RsStuType]中不存在！(in ${exports.rsStuType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.RsStuType_FilterFunByKey = RsStuType_FilterFunByKey;
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
    async function RsStuType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrRsStuType = await RsStuType_GetObjLst_Cache();
        if (arrRsStuType == null)
            return [];
        let arrRsStuType_Sel = arrRsStuType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrRsStuType_Sel.length == 0)
            return [];
        return arrRsStuType_Sel.map(x => x.id_StuType);
    }
    exports.RsStuType_funcKey = RsStuType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function RsStuType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetFirstIDAsync = RsStuType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function RsStuType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetFirstID = RsStuType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function RsStuType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const objRsStuType = RsStuType_GetObjFromJsonObj(returnObj);
                return objRsStuType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetFirstObjAsync = RsStuType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrRsStuTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrRsStuTypeObjLst_T = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeExObjLst_Cache);
            return arrRsStuTypeObjLst_T;
        }
        try {
            const arrRsStuTypeExObjLst = await RsStuType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrRsStuTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRsStuTypeExObjLst.length);
            console.log(strInfo);
            return arrRsStuTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RsStuType_GetObjLst_ClientCache = RsStuType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRsStuTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRsStuTypeObjLst_T = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeExObjLst_Cache);
            return arrRsStuTypeObjLst_T;
        }
        try {
            const arrRsStuTypeExObjLst = await RsStuType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrRsStuTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRsStuTypeExObjLst.length);
            console.log(strInfo);
            return arrRsStuTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RsStuType_GetObjLst_localStorage = RsStuType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrRsStuTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRsStuTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.RsStuType_GetObjLst_localStorage_PureCache = RsStuType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function RsStuType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rsStuType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetObjLstAsync = RsStuType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRsStuTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrRsStuTypeObjLst_T = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeExObjLst_Cache);
            return arrRsStuTypeObjLst_T;
        }
        try {
            const arrRsStuTypeExObjLst = await RsStuType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrRsStuTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrRsStuTypeExObjLst.length);
            console.log(strInfo);
            return arrRsStuTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.RsStuType_GetObjLst_sessionStorage = RsStuType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrRsStuTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrRsStuTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.RsStuType_GetObjLst_sessionStorage_PureCache = RsStuType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrRsStuTypeObjLst_Cache;
        switch (clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_ClientCache();
                break;
            default:
                arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_ClientCache();
                break;
        }
        const arrRsStuTypeObjLst = RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeObjLst_Cache);
        return arrRsStuTypeObjLst_Cache;
    }
    exports.RsStuType_GetObjLst_Cache = RsStuType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function RsStuType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrRsStuTypeObjLst_Cache;
        switch (clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrRsStuTypeObjLst_Cache = null;
                break;
            default:
                arrRsStuTypeObjLst_Cache = null;
                break;
        }
        return arrRsStuTypeObjLst_Cache;
    }
    exports.RsStuType_GetObjLst_PureCache = RsStuType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_StuType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RsStuType_GetSubObjLst_Cache(objRsStuType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        let arrRsStuType_Sel = arrRsStuTypeObjLst_Cache;
        if (objRsStuType_Cond.sf_FldComparisonOp == null || objRsStuType_Cond.sf_FldComparisonOp == "")
            return arrRsStuType_Sel;
        const dicFldComparisonOp = JSON.parse(objRsStuType_Cond.sf_FldComparisonOp);
        //console.log("clsRsStuTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRsStuType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRsStuType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRsStuType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objRsStuType_Cond), exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RsStuType_GetSubObjLst_Cache = RsStuType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_StuType:关键字列表
    * @returns 对象列表
    **/
    async function RsStuType_GetObjLstByid_StuTypeLstAsync(arrid_StuType) {
        const strThisFuncName = "GetObjLstByid_StuTypeLstAsync";
        const strAction = "GetObjLstByid_StuTypeLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_StuType);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rsStuType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetObjLstByid_StuTypeLstAsync = RsStuType_GetObjLstByid_StuTypeLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_StuTypeLst:关键字列表
     * @returns 对象列表
    */
    async function RsStuType_GetObjLstByid_StuTypeLst_Cache(arrid_StuTypeLst) {
        const strThisFuncName = "GetObjLstByid_StuTypeLst_Cache";
        try {
            const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
            const arrRsStuType_Sel = arrRsStuTypeObjLst_Cache.filter(x => arrid_StuTypeLst.indexOf(x.id_StuType) > -1);
            return arrRsStuType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_StuTypeLst.join(","), exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.RsStuType_GetObjLstByid_StuTypeLst_Cache = RsStuType_GetObjLstByid_StuTypeLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function RsStuType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rsStuType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetTopObjLstAsync = RsStuType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RsStuType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rsStuType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetObjLstByRangeAsync = RsStuType_GetObjLstByRangeAsync;
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
    async function RsStuType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetObjLstByRange = RsStuType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function RsStuType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        if (arrRsStuTypeObjLst_Cache.length == 0)
            return arrRsStuTypeObjLst_Cache;
        let arrRsStuType_Sel = arrRsStuTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objRsStuType_Cond = new clsRsStuTypeEN_js_1.clsRsStuTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRsStuType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsRsStuTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRsStuType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRsStuType_Sel.length == 0)
                return arrRsStuType_Sel;
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
                arrRsStuType_Sel = arrRsStuType_Sel.sort(RsStuType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrRsStuType_Sel = arrRsStuType_Sel.sort(objPagerPara.sortFun);
            }
            arrRsStuType_Sel = arrRsStuType_Sel.slice(intStart, intEnd);
            return arrRsStuType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.RsStuType_GetObjLstByPager_Cache = RsStuType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function RsStuType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.rsStuType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = RsStuType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetObjLstByPagerAsync = RsStuType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_StuType:关键字
    * @returns 获取删除的结果
    **/
    async function RsStuType_DelRecordAsync(strid_StuType) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strid_StuType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_DelRecordAsync = RsStuType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_StuType:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function RsStuType_DelRsStuTypesAsync(arrid_StuType) {
        const strThisFuncName = "DelRsStuTypesAsync";
        const strAction = "DelRsStuTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_StuType);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_DelRsStuTypesAsync = RsStuType_DelRsStuTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function RsStuType_DelRsStuTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelRsStuTypesByCondAsync";
        const strAction = "DelRsStuTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_DelRsStuTypesByCondAsync = RsStuType_DelRsStuTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objRsStuTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RsStuType_AddNewRecordAsync(objRsStuTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objRsStuTypeEN.id_StuType === null || objRsStuTypeEN.id_StuType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objRsStuTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRsStuTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_AddNewRecordAsync = RsStuType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objRsStuTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function RsStuType_AddNewRecordWithMaxIdAsync(objRsStuTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRsStuTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_AddNewRecordWithMaxIdAsync = RsStuType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objRsStuTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function RsStuType_AddNewRecordWithReturnKeyAsync(objRsStuTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRsStuTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_AddNewRecordWithReturnKeyAsync = RsStuType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objRsStuTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function RsStuType_AddNewRecordWithReturnKey(objRsStuTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objRsStuTypeEN.id_StuType === null || objRsStuTypeEN.id_StuType === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRsStuTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_AddNewRecordWithReturnKey = RsStuType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objRsStuTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function RsStuType_UpdateRecordAsync(objRsStuTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objRsStuTypeEN.sf_UpdFldSetStr === undefined || objRsStuTypeEN.sf_UpdFldSetStr === null || objRsStuTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRsStuTypeEN.id_StuType);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRsStuTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_UpdateRecordAsync = RsStuType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objRsStuTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function RsStuType_UpdateWithConditionAsync(objRsStuTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objRsStuTypeEN.sf_UpdFldSetStr === undefined || objRsStuTypeEN.sf_UpdFldSetStr === null || objRsStuTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objRsStuTypeEN.id_StuType);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        objRsStuTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objRsStuTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_UpdateWithConditionAsync = RsStuType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_StuType_Cond:条件对象
     * @returns 对象列表子集
    */
    async function RsStuType_IsExistRecord_Cache(objRsStuType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        if (arrRsStuTypeObjLst_Cache == null)
            return false;
        let arrRsStuType_Sel = arrRsStuTypeObjLst_Cache;
        if (objRsStuType_Cond.sf_FldComparisonOp == null || objRsStuType_Cond.sf_FldComparisonOp == "")
            return arrRsStuType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objRsStuType_Cond.sf_FldComparisonOp);
        //console.log("clsRsStuTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRsStuType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRsStuType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrRsStuType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objRsStuType_Cond), exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.RsStuType_IsExistRecord_Cache = RsStuType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function RsStuType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_IsExistRecordAsync = RsStuType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_StuType:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function RsStuType_IsExist(strid_StuType, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_StuType": strid_StuType,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_IsExist = RsStuType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_StuType:所给的关键字
     * @returns 对象
    */
    async function RsStuType_IsExist_Cache(strid_StuType) {
        const strThisFuncName = "IsExist_Cache";
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        if (arrRsStuTypeObjLst_Cache == null)
            return false;
        try {
            const arrRsStuType_Sel = arrRsStuTypeObjLst_Cache.filter(x => x.id_StuType == strid_StuType);
            if (arrRsStuType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_StuType, exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.RsStuType_IsExist_Cache = RsStuType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_StuType:关键字
    * @returns 是否存在?存在返回True
    **/
    async function RsStuType_IsExistAsync(strid_StuType) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_StuType": strid_StuType }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_IsExistAsync = RsStuType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function RsStuType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetRecCountByCondAsync = RsStuType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objRsStuType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function RsStuType_GetRecCountByCond_Cache(objRsStuType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrRsStuTypeObjLst_Cache = await RsStuType_GetObjLst_Cache();
        if (arrRsStuTypeObjLst_Cache == null)
            return 0;
        let arrRsStuType_Sel = arrRsStuTypeObjLst_Cache;
        if (objRsStuType_Cond.sf_FldComparisonOp == null || objRsStuType_Cond.sf_FldComparisonOp == "")
            return arrRsStuType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objRsStuType_Cond.sf_FldComparisonOp);
        //console.log("clsRsStuTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objRsStuType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objRsStuType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrRsStuType_Sel = arrRsStuType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrRsStuType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objRsStuType_Cond), exports.rsStuType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.RsStuType_GetRecCountByCond_Cache = RsStuType_GetRecCountByCond_Cache;
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
    async function RsStuType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.rsStuType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.rsStuType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.RsStuType_GetMaxStrIdByPrefix = RsStuType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function RsStuType_GetWebApiUrl(strController, strAction) {
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
    exports.RsStuType_GetWebApiUrl = RsStuType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function RsStuType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
        switch (clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheModeId) {
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
    exports.RsStuType_ReFreshCache = RsStuType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function RsStuType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsRsStuTypeEN_js_1.clsRsStuTypeEN._CurrTabName;
            switch (clsRsStuTypeEN_js_1.clsRsStuTypeEN.CacheModeId) {
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
    exports.RsStuType_ReFreshThisCache = RsStuType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function RsStuType_BindDdl_id_StuTypeInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_StuTypeInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_id_StuTypeInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_StuTypeInDiv_Cache");
        const arrObjLst_Sel = await RsStuType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc, "学生类别");
    }
    exports.RsStuType_BindDdl_id_StuTypeInDiv_Cache = RsStuType_BindDdl_id_StuTypeInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RsStuType_CheckPropertyNew(pobjRsStuTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeID) === true) {
            throw new Error("(errid:Watl000058)字段[学生类别ID]不能为空(In 学生类别)!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeDesc) === true) {
            throw new Error("(errid:Watl000058)字段[学生类别名称]不能为空(In 学生类别)!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.id_StuType) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.id_StuType) > 4) {
            throw new Error("(errid:Watl000059)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.id_StuType)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.stuTypeID) > 4) {
            throw new Error("(errid:Watl000059)字段[学生类别ID(stuTypeID)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeID)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeDesc) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.stuTypeDesc) > 50) {
            throw new Error("(errid:Watl000059)字段[学生类别名称(stuTypeDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeDesc)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyDate)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyUserID)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.specUniLenDesc) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.specUniLenDesc) > 50) {
            throw new Error("(errid:Watl000059)字段[SpecUniLenDesc(specUniLenDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.specUniLenDesc)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.memo)(clsRsStuTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.id_StuType) == false && undefined !== pobjRsStuTypeEN.id_StuType && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.id_StuType) === false) {
            throw new Error("(errid:Watl000060)字段[学生类别流水号(id_StuType)]的值:[$(pobjRsStuTypeEN.id_StuType)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeID) == false && undefined !== pobjRsStuTypeEN.stuTypeID && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.stuTypeID) === false) {
            throw new Error("(errid:Watl000060)字段[学生类别ID(stuTypeID)]的值:[$(pobjRsStuTypeEN.stuTypeID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeDesc) == false && undefined !== pobjRsStuTypeEN.stuTypeDesc && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.stuTypeDesc) === false) {
            throw new Error("(errid:Watl000060)字段[学生类别名称(stuTypeDesc)]的值:[$(pobjRsStuTypeEN.stuTypeDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyDate) == false && undefined !== pobjRsStuTypeEN.modifyDate && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjRsStuTypeEN.modifyDate)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyUserID) == false && undefined !== pobjRsStuTypeEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjRsStuTypeEN.modifyUserID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.specUniLenDesc) == false && undefined !== pobjRsStuTypeEN.specUniLenDesc && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.specUniLenDesc) === false) {
            throw new Error("(errid:Watl000060)字段[SpecUniLenDesc(specUniLenDesc)]的值:[$(pobjRsStuTypeEN.specUniLenDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.memo) == false && undefined !== pobjRsStuTypeEN.memo && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjRsStuTypeEN.memo)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjRsStuTypeEN.SetIsCheckProperty(true);
    }
    exports.RsStuType_CheckPropertyNew = RsStuType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function RsStuType_CheckProperty4Update(pobjRsStuTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.id_StuType) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.id_StuType) > 4) {
            throw new Error("(errid:Watl000062)字段[学生类别流水号(id_StuType)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.id_StuType)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeID) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.stuTypeID) > 4) {
            throw new Error("(errid:Watl000062)字段[学生类别ID(stuTypeID)]的长度不能超过4(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeID)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeDesc) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.stuTypeDesc) > 50) {
            throw new Error("(errid:Watl000062)字段[学生类别名称(stuTypeDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.stuTypeDesc)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyDate) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyDate)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyUserID) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.modifyUserID)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.specUniLenDesc) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.specUniLenDesc) > 50) {
            throw new Error("(errid:Watl000062)字段[SpecUniLenDesc(specUniLenDesc)]的长度不能超过50(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.specUniLenDesc)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjRsStuTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 学生类别(RsStuType))!值:$(pobjRsStuTypeEN.memo)(clsRsStuTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.id_StuType) == false && undefined !== pobjRsStuTypeEN.id_StuType && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.id_StuType) === false) {
            throw new Error("(errid:Watl000063)字段[学生类别流水号(id_StuType)]的值:[$(pobjRsStuTypeEN.id_StuType)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeID) == false && undefined !== pobjRsStuTypeEN.stuTypeID && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.stuTypeID) === false) {
            throw new Error("(errid:Watl000063)字段[学生类别ID(stuTypeID)]的值:[$(pobjRsStuTypeEN.stuTypeID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.stuTypeDesc) == false && undefined !== pobjRsStuTypeEN.stuTypeDesc && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.stuTypeDesc) === false) {
            throw new Error("(errid:Watl000063)字段[学生类别名称(stuTypeDesc)]的值:[$(pobjRsStuTypeEN.stuTypeDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyDate) == false && undefined !== pobjRsStuTypeEN.modifyDate && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjRsStuTypeEN.modifyDate)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.modifyUserID) == false && undefined !== pobjRsStuTypeEN.modifyUserID && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjRsStuTypeEN.modifyUserID)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.specUniLenDesc) == false && undefined !== pobjRsStuTypeEN.specUniLenDesc && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.specUniLenDesc) === false) {
            throw new Error("(errid:Watl000063)字段[SpecUniLenDesc(specUniLenDesc)]的值:[$(pobjRsStuTypeEN.specUniLenDesc)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.memo) == false && undefined !== pobjRsStuTypeEN.memo && clsString_js_1.tzDataType.isString(pobjRsStuTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjRsStuTypeEN.memo)], 非法，应该为字符型(In 学生类别(RsStuType))!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjRsStuTypeEN.id_StuType) === true
            || pobjRsStuTypeEN.id_StuType.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[学生类别流水号]不能为空(In 学生类别)!(clsRsStuTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjRsStuTypeEN.SetIsCheckProperty(true);
    }
    exports.RsStuType_CheckProperty4Update = RsStuType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RsStuType_GetJSONStrByObj(pobjRsStuTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjRsStuTypeEN.sf_UpdFldSetStr = pobjRsStuTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjRsStuTypeEN);
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
    exports.RsStuType_GetJSONStrByObj = RsStuType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function RsStuType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrRsStuTypeObjLst = new Array();
        if (strJSON === "") {
            return arrRsStuTypeObjLst;
        }
        try {
            arrRsStuTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrRsStuTypeObjLst;
        }
        return arrRsStuTypeObjLst;
    }
    exports.RsStuType_GetObjLstByJSONStr = RsStuType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrRsStuTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function RsStuType_GetObjLstByJSONObjLst(arrRsStuTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrRsStuTypeObjLst = new Array();
        for (const objInFor of arrRsStuTypeObjLstS) {
            const obj1 = RsStuType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrRsStuTypeObjLst.push(obj1);
        }
        return arrRsStuTypeObjLst;
    }
    exports.RsStuType_GetObjLstByJSONObjLst = RsStuType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function RsStuType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjRsStuTypeEN = new clsRsStuTypeEN_js_1.clsRsStuTypeEN();
        if (strJSON === "") {
            return pobjRsStuTypeEN;
        }
        try {
            pobjRsStuTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjRsStuTypeEN;
        }
        return pobjRsStuTypeEN;
    }
    exports.RsStuType_GetObjByJSONStr = RsStuType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function RsStuType_GetCombineCondition(objRsStuType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType) == true) {
            const strComparisonOp_id_StuType = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_id_StuType, objRsStuType_Cond.id_StuType, strComparisonOp_id_StuType);
        }
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeID) == true) {
            const strComparisonOp_StuTypeID = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeID, objRsStuType_Cond.stuTypeID, strComparisonOp_StuTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc) == true) {
            const strComparisonOp_StuTypeDesc = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_StuTypeDesc, objRsStuType_Cond.stuTypeDesc, strComparisonOp_StuTypeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyDate, objRsStuType_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_ModifyUserID, objRsStuType_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_SpecUniLenDesc) == true) {
            const strComparisonOp_SpecUniLenDesc = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_SpecUniLenDesc];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_SpecUniLenDesc, objRsStuType_Cond.specUniLenDesc, strComparisonOp_SpecUniLenDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objRsStuType_Cond.dicFldComparisonOp, clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objRsStuType_Cond.dicFldComparisonOp[clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsRsStuTypeEN_js_1.clsRsStuTypeEN.con_Memo, objRsStuType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.RsStuType_GetCombineCondition = RsStuType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objRsStuTypeENS:源对象
     * @param objRsStuTypeENT:目标对象
    */
    function RsStuType_CopyObjTo(objRsStuTypeENS, objRsStuTypeENT) {
        objRsStuTypeENT.id_StuType = objRsStuTypeENS.id_StuType; //学生类别流水号
        objRsStuTypeENT.stuTypeID = objRsStuTypeENS.stuTypeID; //学生类别ID
        objRsStuTypeENT.stuTypeDesc = objRsStuTypeENS.stuTypeDesc; //学生类别名称
        objRsStuTypeENT.modifyDate = objRsStuTypeENS.modifyDate; //修改日期
        objRsStuTypeENT.modifyUserID = objRsStuTypeENS.modifyUserID; //修改人
        objRsStuTypeENT.specUniLenDesc = objRsStuTypeENS.specUniLenDesc; //SpecUniLenDesc
        objRsStuTypeENT.memo = objRsStuTypeENS.memo; //备注
        objRsStuTypeENT.sf_UpdFldSetStr = objRsStuTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.RsStuType_CopyObjTo = RsStuType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objRsStuTypeENS:源对象
     * @param objRsStuTypeENT:目标对象
    */
    function RsStuType_GetObjFromJsonObj(objRsStuTypeENS) {
        const objRsStuTypeENT = new clsRsStuTypeEN_js_1.clsRsStuTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objRsStuTypeENT, objRsStuTypeENS);
        return objRsStuTypeENT;
    }
    exports.RsStuType_GetObjFromJsonObj = RsStuType_GetObjFromJsonObj;
});
