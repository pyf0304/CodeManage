/**
* 类名:clscc_CourseTypeWApi
* 表名:cc_CourseType(01120057)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:45:59
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/CourseLearning/clscc_CourseTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.cc_CourseType_GetObjFromJsonObj = exports.cc_CourseType_CopyObjTo = exports.cc_CourseType_GetCombineCondition = exports.cc_CourseType_GetObjByJSONStr = exports.cc_CourseType_GetObjLstByJSONObjLst = exports.cc_CourseType_GetObjLstByJSONStr = exports.cc_CourseType_GetJSONStrByObj = exports.cc_CourseType_CheckProperty4Update = exports.cc_CourseType_CheckPropertyNew = exports.cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache = exports.cc_CourseType_ReFreshThisCache = exports.cc_CourseType_ReFreshCache = exports.cc_CourseType_GetWebApiUrl = exports.cc_CourseType_GetMaxStrIdByPrefix = exports.cc_CourseType_GetRecCountByCond_Cache = exports.cc_CourseType_GetRecCountByCondAsync = exports.cc_CourseType_IsExistAsync = exports.cc_CourseType_IsExist_Cache = exports.cc_CourseType_IsExist = exports.cc_CourseType_IsExistRecordAsync = exports.cc_CourseType_IsExistRecord_Cache = exports.cc_CourseType_UpdateWithConditionAsync = exports.cc_CourseType_UpdateRecordAsync = exports.cc_CourseType_AddNewRecordWithReturnKey = exports.cc_CourseType_AddNewRecordWithReturnKeyAsync = exports.cc_CourseType_AddNewRecordWithMaxIdAsync = exports.cc_CourseType_AddNewRecordAsync = exports.cc_CourseType_Delcc_CourseTypesByCondAsync = exports.cc_CourseType_Delcc_CourseTypesAsync = exports.cc_CourseType_DelRecordAsync = exports.cc_CourseType_GetObjLstByPagerAsync = exports.cc_CourseType_GetObjLstByPager_Cache = exports.cc_CourseType_GetObjLstByRange = exports.cc_CourseType_GetObjLstByRangeAsync = exports.cc_CourseType_GetTopObjLstAsync = exports.cc_CourseType_GetObjLstByCourseTypeIDLst_Cache = exports.cc_CourseType_GetObjLstByCourseTypeIDLstAsync = exports.cc_CourseType_GetSubObjLst_Cache = exports.cc_CourseType_GetObjLst_PureCache = exports.cc_CourseType_GetObjLst_Cache = exports.cc_CourseType_GetObjLst_sessionStorage_PureCache = exports.cc_CourseType_GetObjLst_sessionStorage = exports.cc_CourseType_GetObjLstAsync = exports.cc_CourseType_GetObjLst_localStorage_PureCache = exports.cc_CourseType_GetObjLst_localStorage = exports.cc_CourseType_GetObjLst_ClientCache = exports.cc_CourseType_GetFirstObjAsync = exports.cc_CourseType_GetFirstID = exports.cc_CourseType_GetFirstIDAsync = exports.cc_CourseType_FilterFunByKey = exports.cc_CourseType_SortFunByKey = exports.cc_CourseType_SortFun_Defa_2Fld = exports.cc_CourseType_SortFun_Defa = exports.cc_CourseType_func = exports.cc_CourseType_GetNameByCourseTypeID_Cache = exports.cc_CourseType_UpdateObjInLst_Cache = exports.cc_CourseType_GetObjByCourseTypeID_localStorage = exports.cc_CourseType_GetObjByCourseTypeID_Cache = exports.cc_CourseType_GetObjByCourseTypeIDAsync = exports.cc_CourseType_ConstructorName = exports.cc_CourseType_Controller = void 0;
    /**
     * 课程类型(cc_CourseType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clscc_CourseTypeEN_js_1 = require("../../L0_Entity/CourseLearning/clscc_CourseTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.cc_CourseType_Controller = "cc_CourseTypeApi";
    exports.cc_CourseType_ConstructorName = "cc_CourseType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseTypeID:关键字
    * @returns 对象
    **/
    async function cc_CourseType_GetObjByCourseTypeIDAsync(strCourseTypeID) {
        const strThisFuncName = "GetObjByCourseTypeIDAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseTypeID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseTypeID]不能为空！(In GetObjByCourseTypeIDAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseTypeID.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseTypeID]的长度:[{0}]不正确！", strCourseTypeID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseTypeID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseTypeID": strCourseTypeID,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objcc_CourseType = cc_CourseType_GetObjFromJsonObj(returnObj);
                return objcc_CourseType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetObjByCourseTypeIDAsync = cc_CourseType_GetObjByCourseTypeIDAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseTypeID:所给的关键字
     * @returns 对象
    */
    async function cc_CourseType_GetObjByCourseTypeID_Cache(strCourseTypeID, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseTypeID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseTypeID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseTypeID]不能为空！(In GetObjByCourseTypeID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseTypeID.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseTypeID]的长度:[{0}]不正确！", strCourseTypeID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        try {
            const arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache.filter(x => x.courseTypeID == strCourseTypeID);
            let objcc_CourseType;
            if (arrcc_CourseType_Sel.length > 0) {
                objcc_CourseType = arrcc_CourseType_Sel[0];
                return objcc_CourseType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objcc_CourseType = await cc_CourseType_GetObjByCourseTypeIDAsync(strCourseTypeID);
                    if (objcc_CourseType != null) {
                        cc_CourseType_ReFreshThisCache();
                        return objcc_CourseType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseTypeID, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.cc_CourseType_GetObjByCourseTypeID_Cache = cc_CourseType_GetObjByCourseTypeID_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseTypeID:所给的关键字
     * @returns 对象
    */
    async function cc_CourseType_GetObjByCourseTypeID_localStorage(strCourseTypeID) {
        const strThisFuncName = "GetObjByCourseTypeID_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseTypeID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseTypeID]不能为空！(In GetObjByCourseTypeID_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseTypeID.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseTypeID]的长度:[{0}]不正确！", strCourseTypeID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName, strCourseTypeID);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objcc_CourseType_Cache = JSON.parse(strTempObj);
            return objcc_CourseType_Cache;
        }
        try {
            const objcc_CourseType = await cc_CourseType_GetObjByCourseTypeIDAsync(strCourseTypeID);
            if (objcc_CourseType != null) {
                localStorage.setItem(strKey, JSON.stringify(objcc_CourseType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objcc_CourseType;
            }
            return objcc_CourseType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseTypeID, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.cc_CourseType_GetObjByCourseTypeID_localStorage = cc_CourseType_GetObjByCourseTypeID_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objcc_CourseType:所给的对象
     * @returns 对象
    */
    async function cc_CourseType_UpdateObjInLst_Cache(objcc_CourseType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
            const obj = arrcc_CourseTypeObjLst_Cache.find(x => x.courseTypeID == objcc_CourseType.courseTypeID);
            if (obj != null) {
                objcc_CourseType.courseTypeID = obj.courseTypeID;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objcc_CourseType);
            }
            else {
                arrcc_CourseTypeObjLst_Cache.push(objcc_CourseType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.cc_CourseType_UpdateObjInLst_Cache = cc_CourseType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strCourseTypeID:所给的关键字
     * @returns 对象
    */
    async function cc_CourseType_GetNameByCourseTypeID_Cache(strCourseTypeID) {
        const strThisFuncName = "GetNameByCourseTypeID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseTypeID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseTypeID]不能为空！(In GetNameByCourseTypeID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseTypeID.length != 4) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseTypeID]的长度:[{0}]不正确！", strCourseTypeID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        if (arrcc_CourseTypeObjLst_Cache == null)
            return "";
        try {
            const arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache.filter(x => x.courseTypeID == strCourseTypeID);
            let objcc_CourseType;
            if (arrcc_CourseType_Sel.length > 0) {
                objcc_CourseType = arrcc_CourseType_Sel[0];
                return objcc_CourseType.courseTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseTypeID);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.cc_CourseType_GetNameByCourseTypeID_Cache = cc_CourseType_GetNameByCourseTypeID_Cache;
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
    async function cc_CourseType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseTypeID = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objcc_CourseType = await cc_CourseType_GetObjByCourseTypeID_Cache(strCourseTypeID);
        if (objcc_CourseType == null)
            return "";
        return objcc_CourseType.GetFldValue(strOutFldName).toString();
    }
    exports.cc_CourseType_func = cc_CourseType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseTypeID.localeCompare(b.courseTypeID);
    }
    exports.cc_CourseType_SortFun_Defa = cc_CourseType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseTypeName == b.courseTypeName)
            return a.id_School.localeCompare(b.id_School);
        else
            return a.courseTypeName.localeCompare(b.courseTypeName);
    }
    exports.cc_CourseType_SortFun_Defa_2Fld = cc_CourseType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function cc_CourseType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID:
                    return (a, b) => {
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName:
                    return (a, b) => {
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_id_School:
                    return (a, b) => {
                        return a.id_School.localeCompare(b.id_School);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_IsUse:
                    return (a, b) => {
                        if (a.isUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_CourseType]中不存在！(in ${exports.cc_CourseType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID:
                    return (a, b) => {
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName:
                    return (a, b) => {
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_id_School:
                    return (a, b) => {
                        return b.id_School.localeCompare(a.id_School);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_IsUse:
                    return (a, b) => {
                        if (b.isUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdUserId:
                    return (a, b) => {
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[cc_CourseType]中不存在！(in ${exports.cc_CourseType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.cc_CourseType_SortFunByKey = cc_CourseType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function cc_CourseType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_id_School:
                return (obj) => {
                    return obj.id_School === value;
                };
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_IsUse:
                return (obj) => {
                    return obj.isUse === value;
                };
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[cc_CourseType]中不存在！(in ${exports.cc_CourseType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.cc_CourseType_FilterFunByKey = cc_CourseType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_CourseType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetFirstIDAsync = cc_CourseType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function cc_CourseType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetFirstID = cc_CourseType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function cc_CourseType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objcc_CourseType = cc_CourseType_GetObjFromJsonObj(returnObj);
                return objcc_CourseType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetFirstObjAsync = cc_CourseType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
        clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrcc_CourseTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrcc_CourseTypeObjLst_T = cc_CourseType_GetObjLstByJSONObjLst(arrcc_CourseTypeExObjLst_Cache);
            return arrcc_CourseTypeObjLst_T;
        }
        try {
            const arrcc_CourseTypeExObjLst = await cc_CourseType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrcc_CourseTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseTypeExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseType_GetObjLst_ClientCache = cc_CourseType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
        clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseTypeObjLst_T = cc_CourseType_GetObjLstByJSONObjLst(arrcc_CourseTypeExObjLst_Cache);
            return arrcc_CourseTypeObjLst_T;
        }
        try {
            const arrcc_CourseTypeExObjLst = await cc_CourseType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrcc_CourseTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseTypeExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseType_GetObjLst_localStorage = cc_CourseType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrcc_CourseTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_CourseType_GetObjLst_localStorage_PureCache = cc_CourseType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function cc_CourseType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetObjLstAsync = cc_CourseType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
        clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrcc_CourseTypeObjLst_T = cc_CourseType_GetObjLstByJSONObjLst(arrcc_CourseTypeExObjLst_Cache);
            return arrcc_CourseTypeObjLst_T;
        }
        try {
            const arrcc_CourseTypeExObjLst = await cc_CourseType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrcc_CourseTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrcc_CourseTypeExObjLst.length);
            console.log(strInfo);
            return arrcc_CourseTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.cc_CourseType_GetObjLst_sessionStorage = cc_CourseType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrcc_CourseTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrcc_CourseTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.cc_CourseType_GetObjLst_sessionStorage_PureCache = cc_CourseType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrcc_CourseTypeObjLst_Cache;
        switch (clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_ClientCache();
                break;
            default:
                arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_ClientCache();
                break;
        }
        const arrcc_CourseTypeObjLst = cc_CourseType_GetObjLstByJSONObjLst(arrcc_CourseTypeObjLst_Cache);
        return arrcc_CourseTypeObjLst_Cache;
    }
    exports.cc_CourseType_GetObjLst_Cache = cc_CourseType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function cc_CourseType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrcc_CourseTypeObjLst_Cache;
        switch (clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrcc_CourseTypeObjLst_Cache = null;
                break;
            default:
                arrcc_CourseTypeObjLst_Cache = null;
                break;
        }
        return arrcc_CourseTypeObjLst_Cache;
    }
    exports.cc_CourseType_GetObjLst_PureCache = cc_CourseType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseTypeID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_CourseType_GetSubObjLst_Cache(objcc_CourseType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        let arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache;
        if (objcc_CourseType_Cond.sf_FldComparisonOp == null || objcc_CourseType_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseType_Sel;
        const dicFldComparisonOp = JSON.parse(objcc_CourseType_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_CourseType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objcc_CourseType_Cond), exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseType_GetSubObjLst_Cache = cc_CourseType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseTypeID:关键字列表
    * @returns 对象列表
    **/
    async function cc_CourseType_GetObjLstByCourseTypeIDLstAsync(arrCourseTypeID) {
        const strThisFuncName = "GetObjLstByCourseTypeIDLstAsync";
        const strAction = "GetObjLstByCourseTypeIDLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseTypeID);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetObjLstByCourseTypeIDLstAsync = cc_CourseType_GetObjLstByCourseTypeIDLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseTypeIDLst:关键字列表
     * @returns 对象列表
    */
    async function cc_CourseType_GetObjLstByCourseTypeIDLst_Cache(arrCourseTypeIDLst) {
        const strThisFuncName = "GetObjLstByCourseTypeIDLst_Cache";
        try {
            const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
            const arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache.filter(x => arrCourseTypeIDLst.indexOf(x.courseTypeID) > -1);
            return arrcc_CourseType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseTypeIDLst.join(","), exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseType_GetObjLstByCourseTypeIDLst_Cache = cc_CourseType_GetObjLstByCourseTypeIDLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function cc_CourseType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetTopObjLstAsync = cc_CourseType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_CourseType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetObjLstByRangeAsync = cc_CourseType_GetObjLstByRangeAsync;
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
    async function cc_CourseType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetObjLstByRange = cc_CourseType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function cc_CourseType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        if (arrcc_CourseTypeObjLst_Cache.length == 0)
            return arrcc_CourseTypeObjLst_Cache;
        let arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objcc_CourseType_Cond = new clscc_CourseTypeEN_js_1.clscc_CourseTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clscc_CourseTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseType_Sel.length == 0)
                return arrcc_CourseType_Sel;
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
                arrcc_CourseType_Sel = arrcc_CourseType_Sel.sort(cc_CourseType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrcc_CourseType_Sel = arrcc_CourseType_Sel.sort(objPagerPara.sortFun);
            }
            arrcc_CourseType_Sel = arrcc_CourseType_Sel.slice(intStart, intEnd);
            return arrcc_CourseType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.cc_CourseType_GetObjLstByPager_Cache = cc_CourseType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function cc_CourseType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.cc_CourseType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = cc_CourseType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetObjLstByPagerAsync = cc_CourseType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCourseTypeID:关键字
    * @returns 获取删除的结果
    **/
    async function cc_CourseType_DelRecordAsync(strCourseTypeID) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strCourseTypeID);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strCourseTypeID, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_DelRecordAsync = cc_CourseType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCourseTypeID:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function cc_CourseType_Delcc_CourseTypesAsync(arrCourseTypeID) {
        const strThisFuncName = "Delcc_CourseTypesAsync";
        const strAction = "Delcc_CourseTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseTypeID);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_Delcc_CourseTypesAsync = cc_CourseType_Delcc_CourseTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function cc_CourseType_Delcc_CourseTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delcc_CourseTypesByCondAsync";
        const strAction = "Delcc_CourseTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_Delcc_CourseTypesByCondAsync = cc_CourseType_Delcc_CourseTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objcc_CourseTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseType_AddNewRecordAsync(objcc_CourseTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objcc_CourseTypeEN.courseTypeID === null || objcc_CourseTypeEN.courseTypeID === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objcc_CourseTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_AddNewRecordAsync = cc_CourseType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objcc_CourseTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function cc_CourseType_AddNewRecordWithMaxIdAsync(objcc_CourseTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_AddNewRecordWithMaxIdAsync = cc_CourseType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objcc_CourseTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function cc_CourseType_AddNewRecordWithReturnKeyAsync(objcc_CourseTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_AddNewRecordWithReturnKeyAsync = cc_CourseType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objcc_CourseTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function cc_CourseType_AddNewRecordWithReturnKey(objcc_CourseTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objcc_CourseTypeEN.courseTypeID === null || objcc_CourseTypeEN.courseTypeID === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_AddNewRecordWithReturnKey = cc_CourseType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objcc_CourseTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function cc_CourseType_UpdateRecordAsync(objcc_CourseTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objcc_CourseTypeEN.sf_UpdFldSetStr === undefined || objcc_CourseTypeEN.sf_UpdFldSetStr === null || objcc_CourseTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseTypeEN.courseTypeID);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_UpdateRecordAsync = cc_CourseType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objcc_CourseTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function cc_CourseType_UpdateWithConditionAsync(objcc_CourseTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objcc_CourseTypeEN.sf_UpdFldSetStr === undefined || objcc_CourseTypeEN.sf_UpdFldSetStr === null || objcc_CourseTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objcc_CourseTypeEN.courseTypeID);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        objcc_CourseTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objcc_CourseTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_UpdateWithConditionAsync = cc_CourseType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseTypeID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function cc_CourseType_IsExistRecord_Cache(objcc_CourseType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        if (arrcc_CourseTypeObjLst_Cache == null)
            return false;
        let arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache;
        if (objcc_CourseType_Cond.sf_FldComparisonOp == null || objcc_CourseType_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objcc_CourseType_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrcc_CourseType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objcc_CourseType_Cond), exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.cc_CourseType_IsExistRecord_Cache = cc_CourseType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function cc_CourseType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_IsExistRecordAsync = cc_CourseType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseTypeID:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function cc_CourseType_IsExist(strCourseTypeID, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseTypeID": strCourseTypeID,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_IsExist = cc_CourseType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseTypeID:所给的关键字
     * @returns 对象
    */
    async function cc_CourseType_IsExist_Cache(strCourseTypeID) {
        const strThisFuncName = "IsExist_Cache";
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        if (arrcc_CourseTypeObjLst_Cache == null)
            return false;
        try {
            const arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache.filter(x => x.courseTypeID == strCourseTypeID);
            if (arrcc_CourseType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseTypeID, exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.cc_CourseType_IsExist_Cache = cc_CourseType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseTypeID:关键字
    * @returns 是否存在?存在返回True
    **/
    async function cc_CourseType_IsExistAsync(strCourseTypeID) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseTypeID": strCourseTypeID }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_IsExistAsync = cc_CourseType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function cc_CourseType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetRecCountByCondAsync = cc_CourseType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objcc_CourseType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function cc_CourseType_GetRecCountByCond_Cache(objcc_CourseType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrcc_CourseTypeObjLst_Cache = await cc_CourseType_GetObjLst_Cache();
        if (arrcc_CourseTypeObjLst_Cache == null)
            return 0;
        let arrcc_CourseType_Sel = arrcc_CourseTypeObjLst_Cache;
        if (objcc_CourseType_Cond.sf_FldComparisonOp == null || objcc_CourseType_Cond.sf_FldComparisonOp == "")
            return arrcc_CourseType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objcc_CourseType_Cond.sf_FldComparisonOp);
        //console.log("clscc_CourseTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objcc_CourseType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objcc_CourseType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrcc_CourseType_Sel = arrcc_CourseType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrcc_CourseType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objcc_CourseType_Cond), exports.cc_CourseType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.cc_CourseType_GetRecCountByCond_Cache = cc_CourseType_GetRecCountByCond_Cache;
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
    async function cc_CourseType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.cc_CourseType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.cc_CourseType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.cc_CourseType_GetMaxStrIdByPrefix = cc_CourseType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function cc_CourseType_GetWebApiUrl(strController, strAction) {
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
    exports.cc_CourseType_GetWebApiUrl = cc_CourseType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function cc_CourseType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
        switch (clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheModeId) {
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
    exports.cc_CourseType_ReFreshCache = cc_CourseType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function cc_CourseType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clscc_CourseTypeEN_js_1.clscc_CourseTypeEN._CurrTabName;
            switch (clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.CacheModeId) {
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
    exports.cc_CourseType_ReFreshThisCache = cc_CourseType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_CourseTypeIDInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_CourseTypeIDInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CourseTypeIDInDiv_Cache");
        const arrObjLst_Sel = await cc_CourseType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName, "课程类型");
    }
    exports.cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache = cc_CourseType_BindDdl_CourseTypeIDInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_CourseType_CheckPropertyNew(pobjcc_CourseTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[课程类型名称]不能为空(In 课程类型)!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeID) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.courseTypeID) > 4) {
            throw new Error("(errid:Watl000059)字段[课程类型ID(courseTypeID)]的长度不能超过4(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.courseTypeID)(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.courseTypeName) > 30) {
            throw new Error("(errid:Watl000059)字段[课程类型名称(courseTypeName)]的长度不能超过30(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.courseTypeName)(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.id_School) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.id_School) > 4) {
            throw new Error("(errid:Watl000059)字段[学校流水号(id_School)]的长度不能超过4(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.id_School)(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.updDate)(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000059)字段[修改用户Id(updUserId)]的长度不能超过20(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.updUserId)(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.memo)(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeID) == false && undefined !== pobjcc_CourseTypeEN.courseTypeID && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.courseTypeID) === false) {
            throw new Error("(errid:Watl000060)字段[课程类型ID(courseTypeID)]的值:[$(pobjcc_CourseTypeEN.courseTypeID)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeName) == false && undefined !== pobjcc_CourseTypeEN.courseTypeName && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.courseTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[课程类型名称(courseTypeName)]的值:[$(pobjcc_CourseTypeEN.courseTypeName)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.id_School) == false && undefined !== pobjcc_CourseTypeEN.id_School && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.id_School) === false) {
            throw new Error("(errid:Watl000060)字段[学校流水号(id_School)]的值:[$(pobjcc_CourseTypeEN.id_School)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if (null != pobjcc_CourseTypeEN.isUse && undefined !== pobjcc_CourseTypeEN.isUse && jsString_js_1.tzDataType.isBoolean(pobjcc_CourseTypeEN.isUse) === false) {
            throw new Error("(errid:Watl000060)字段[是否使用(isUse)]的值:[$(pobjcc_CourseTypeEN.isUse)], 非法，应该为布尔型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updDate) == false && undefined !== pobjcc_CourseTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjcc_CourseTypeEN.updDate)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updUserId) == false && undefined !== pobjcc_CourseTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000060)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseTypeEN.updUserId)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.memo) == false && undefined !== pobjcc_CourseTypeEN.memo && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjcc_CourseTypeEN.memo)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjcc_CourseTypeEN.SetIsCheckProperty(true);
    }
    exports.cc_CourseType_CheckPropertyNew = cc_CourseType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function cc_CourseType_CheckProperty4Update(pobjcc_CourseTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeID) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.courseTypeID) > 4) {
            throw new Error("(errid:Watl000062)字段[课程类型ID(courseTypeID)]的长度不能超过4(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.courseTypeID)(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.courseTypeName) > 30) {
            throw new Error("(errid:Watl000062)字段[课程类型名称(courseTypeName)]的长度不能超过30(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.courseTypeName)(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.id_School) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.id_School) > 4) {
            throw new Error("(errid:Watl000062)字段[学校流水号(id_School)]的长度不能超过4(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.id_School)(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.updDate)(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updUserId) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.updUserId) > 20) {
            throw new Error("(errid:Watl000062)字段[修改用户Id(updUserId)]的长度不能超过20(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.updUserId)(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjcc_CourseTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 课程类型(cc_CourseType))!值:$(pobjcc_CourseTypeEN.memo)(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeID) == false && undefined !== pobjcc_CourseTypeEN.courseTypeID && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.courseTypeID) === false) {
            throw new Error("(errid:Watl000063)字段[课程类型ID(courseTypeID)]的值:[$(pobjcc_CourseTypeEN.courseTypeID)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeName) == false && undefined !== pobjcc_CourseTypeEN.courseTypeName && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.courseTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[课程类型名称(courseTypeName)]的值:[$(pobjcc_CourseTypeEN.courseTypeName)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.id_School) == false && undefined !== pobjcc_CourseTypeEN.id_School && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.id_School) === false) {
            throw new Error("(errid:Watl000063)字段[学校流水号(id_School)]的值:[$(pobjcc_CourseTypeEN.id_School)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if (null != pobjcc_CourseTypeEN.isUse && undefined !== pobjcc_CourseTypeEN.isUse && jsString_js_1.tzDataType.isBoolean(pobjcc_CourseTypeEN.isUse) === false) {
            throw new Error("(errid:Watl000063)字段[是否使用(isUse)]的值:[$(pobjcc_CourseTypeEN.isUse)], 非法，应该为布尔型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updDate) == false && undefined !== pobjcc_CourseTypeEN.updDate && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjcc_CourseTypeEN.updDate)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.updUserId) == false && undefined !== pobjcc_CourseTypeEN.updUserId && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.updUserId) === false) {
            throw new Error("(errid:Watl000063)字段[修改用户Id(updUserId)]的值:[$(pobjcc_CourseTypeEN.updUserId)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.memo) == false && undefined !== pobjcc_CourseTypeEN.memo && jsString_js_1.tzDataType.isString(pobjcc_CourseTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjcc_CourseTypeEN.memo)], 非法，应该为字符型(In 课程类型(cc_CourseType))!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjcc_CourseTypeEN.courseTypeID) === true
            || pobjcc_CourseTypeEN.courseTypeID.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[课程类型ID]不能为空(In 课程类型)!(clscc_CourseTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjcc_CourseTypeEN.SetIsCheckProperty(true);
    }
    exports.cc_CourseType_CheckProperty4Update = cc_CourseType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_CourseType_GetJSONStrByObj(pobjcc_CourseTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjcc_CourseTypeEN.sf_UpdFldSetStr = pobjcc_CourseTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjcc_CourseTypeEN);
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
    exports.cc_CourseType_GetJSONStrByObj = cc_CourseType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function cc_CourseType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrcc_CourseTypeObjLst = new Array();
        if (strJSON === "") {
            return arrcc_CourseTypeObjLst;
        }
        try {
            arrcc_CourseTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrcc_CourseTypeObjLst;
        }
        return arrcc_CourseTypeObjLst;
    }
    exports.cc_CourseType_GetObjLstByJSONStr = cc_CourseType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrcc_CourseTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function cc_CourseType_GetObjLstByJSONObjLst(arrcc_CourseTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrcc_CourseTypeObjLst = new Array();
        for (const objInFor of arrcc_CourseTypeObjLstS) {
            const obj1 = cc_CourseType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrcc_CourseTypeObjLst.push(obj1);
        }
        return arrcc_CourseTypeObjLst;
    }
    exports.cc_CourseType_GetObjLstByJSONObjLst = cc_CourseType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function cc_CourseType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjcc_CourseTypeEN = new clscc_CourseTypeEN_js_1.clscc_CourseTypeEN();
        if (strJSON === "") {
            return pobjcc_CourseTypeEN;
        }
        try {
            pobjcc_CourseTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjcc_CourseTypeEN;
        }
        return pobjcc_CourseTypeEN;
    }
    exports.cc_CourseType_GetObjByJSONStr = cc_CourseType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function cc_CourseType_GetCombineCondition(objcc_CourseType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objcc_CourseType_Cond.dicFldComparisonOp[clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeID, objcc_CourseType_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objcc_CourseType_Cond.dicFldComparisonOp[clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_CourseTypeName, objcc_CourseType_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_id_School) == true) {
            const strComparisonOp_id_School = objcc_CourseType_Cond.dicFldComparisonOp[clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_id_School];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_id_School, objcc_CourseType_Cond.id_School, strComparisonOp_id_School);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_IsUse) == true) {
            if (objcc_CourseType_Cond.isUse == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_IsUse);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_IsUse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objcc_CourseType_Cond.dicFldComparisonOp[clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdDate, objcc_CourseType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objcc_CourseType_Cond.dicFldComparisonOp[clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_UpdUserId, objcc_CourseType_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objcc_CourseType_Cond.dicFldComparisonOp, clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objcc_CourseType_Cond.dicFldComparisonOp[clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clscc_CourseTypeEN_js_1.clscc_CourseTypeEN.con_Memo, objcc_CourseType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.cc_CourseType_GetCombineCondition = cc_CourseType_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objcc_CourseTypeENS:源对象
     * @param objcc_CourseTypeENT:目标对象
    */
    function cc_CourseType_CopyObjTo(objcc_CourseTypeENS, objcc_CourseTypeENT) {
        objcc_CourseTypeENT.courseTypeID = objcc_CourseTypeENS.courseTypeID; //课程类型ID
        objcc_CourseTypeENT.courseTypeName = objcc_CourseTypeENS.courseTypeName; //课程类型名称
        objcc_CourseTypeENT.id_School = objcc_CourseTypeENS.id_School; //学校流水号
        objcc_CourseTypeENT.isUse = objcc_CourseTypeENS.isUse; //是否使用
        objcc_CourseTypeENT.updDate = objcc_CourseTypeENS.updDate; //修改日期
        objcc_CourseTypeENT.updUserId = objcc_CourseTypeENS.updUserId; //修改用户Id
        objcc_CourseTypeENT.memo = objcc_CourseTypeENS.memo; //备注
        objcc_CourseTypeENT.sf_UpdFldSetStr = objcc_CourseTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.cc_CourseType_CopyObjTo = cc_CourseType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objcc_CourseTypeENS:源对象
     * @param objcc_CourseTypeENT:目标对象
    */
    function cc_CourseType_GetObjFromJsonObj(objcc_CourseTypeENS) {
        const objcc_CourseTypeENT = new clscc_CourseTypeEN_js_1.clscc_CourseTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objcc_CourseTypeENT, objcc_CourseTypeENS);
        return objcc_CourseTypeENT;
    }
    exports.cc_CourseType_GetObjFromJsonObj = cc_CourseType_GetObjFromJsonObj;
});
