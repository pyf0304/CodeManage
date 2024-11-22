/**
* 类名:clsKnowledgeTypeWApi
* 表名:KnowledgeType(01120890)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:13:00
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.KnowledgeType_GetObjFromJsonObj = exports.KnowledgeType_CopyObjTo = exports.KnowledgeType_GetUniCondStr4Update_KnowledgeTypeName = exports.KnowledgeType_GetUniCondStr_KnowledgeTypeName = exports.KnowledgeType_GetCombineCondition = exports.KnowledgeType_GetObjByJSONStr = exports.KnowledgeType_GetObjLstByJSONObjLst = exports.KnowledgeType_GetObjLstByJSONStr = exports.KnowledgeType_GetJSONStrByObj = exports.KnowledgeType_CheckProperty4Update = exports.KnowledgeType_CheckPropertyNew = exports.KnowledgeType_BindDdl_KnowledgeTypeIdInDiv_Cache = exports.KnowledgeType_ReFreshThisCache = exports.KnowledgeType_ReFreshCache = exports.KnowledgeType_GetWebApiUrl = exports.KnowledgeType_GetMaxStrIdByPrefix = exports.KnowledgeType_GetMaxStrIdAsync = exports.KnowledgeType_GetRecCountByCond_Cache = exports.KnowledgeType_GetRecCountByCondAsync = exports.KnowledgeType_IsExistAsync = exports.KnowledgeType_IsExist_Cache = exports.KnowledgeType_IsExist = exports.KnowledgeType_IsExistRecordAsync = exports.KnowledgeType_IsExistRecord_Cache = exports.KnowledgeType_UpdateWithConditionAsync = exports.KnowledgeType_UpdateRecordAsync = exports.KnowledgeType_AddNewRecordWithReturnKey = exports.KnowledgeType_AddNewRecordWithReturnKeyAsync = exports.KnowledgeType_AddNewRecordWithMaxIdAsync = exports.KnowledgeType_AddNewRecordAsync = exports.KnowledgeType_DelKnowledgeTypesByCondAsync = exports.KnowledgeType_DelKnowledgeTypesAsync = exports.KnowledgeType_DelRecordAsync = exports.KnowledgeType_GetObjLstByPagerAsync = exports.KnowledgeType_GetObjLstByPager_Cache = exports.KnowledgeType_GetObjLstByRange = exports.KnowledgeType_GetObjLstByRangeAsync = exports.KnowledgeType_GetTopObjLstAsync = exports.KnowledgeType_GetObjLstByKnowledgeTypeIdLst_Cache = exports.KnowledgeType_GetObjLstByKnowledgeTypeIdLstAsync = exports.KnowledgeType_GetSubObjLst_Cache = exports.KnowledgeType_GetObjLst_PureCache = exports.KnowledgeType_GetObjLst_Cache = exports.KnowledgeType_GetObjLst_sessionStorage_PureCache = exports.KnowledgeType_GetObjLst_sessionStorage = exports.KnowledgeType_GetObjLstAsync = exports.KnowledgeType_GetObjLst_localStorage_PureCache = exports.KnowledgeType_GetObjLst_localStorage = exports.KnowledgeType_GetObjLst_ClientCache = exports.KnowledgeType_GetFirstObjAsync = exports.KnowledgeType_GetFirstID = exports.KnowledgeType_GetFirstIDAsync = exports.KnowledgeType_funcKey = exports.KnowledgeType_FilterFunByKey = exports.KnowledgeType_SortFunByKey = exports.KnowledgeType_SortFun_Defa_2Fld = exports.KnowledgeType_SortFun_Defa = exports.KnowledgeType_func = exports.KnowledgeType_GetNameByKnowledgeTypeId_Cache = exports.KnowledgeType_UpdateObjInLst_Cache = exports.KnowledgeType_GetObjByKnowledgeTypeId_localStorage = exports.KnowledgeType_GetObjByKnowledgeTypeId_Cache = exports.KnowledgeType_GetObjByKnowledgeTypeIdAsync = exports.knowledgeType_ConstructorName = exports.knowledgeType_Controller = void 0;
    /**
     * 知识点类型(KnowledgeType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsKnowledgeTypeEN_js_1 = require("../../L0_Entity/Knowledges_Share/clsKnowledgeTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.knowledgeType_Controller = "KnowledgeTypeApi";
    exports.knowledgeType_ConstructorName = "knowledgeType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strKnowledgeTypeId:关键字
    * @returns 对象
    **/
    async function KnowledgeType_GetObjByKnowledgeTypeIdAsync(strKnowledgeTypeId) {
        const strThisFuncName = "GetObjByKnowledgeTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strKnowledgeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strKnowledgeTypeId]不能为空！(In clsKnowledgeTypeWApi.GetObjByKnowledgeTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strKnowledgeTypeId]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.GetObjByKnowledgeTypeIdAsync)", strKnowledgeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByKnowledgeTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strKnowledgeTypeId": strKnowledgeTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objKnowledgeType = KnowledgeType_GetObjFromJsonObj(returnObj);
                return objKnowledgeType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetObjByKnowledgeTypeIdAsync = KnowledgeType_GetObjByKnowledgeTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strKnowledgeTypeId:所给的关键字
     * @returns 对象
    */
    async function KnowledgeType_GetObjByKnowledgeTypeId_Cache(strKnowledgeTypeId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByKnowledgeTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strKnowledgeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strKnowledgeTypeId]不能为空！(In clsKnowledgeTypeWApi.GetObjByKnowledgeTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strKnowledgeTypeId]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.GetObjByKnowledgeTypeId_Cache)", strKnowledgeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        try {
            const arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache.filter(x => x.knowledgeTypeId == strKnowledgeTypeId);
            let objKnowledgeType;
            if (arrKnowledgeType_Sel.length > 0) {
                objKnowledgeType = arrKnowledgeType_Sel[0];
                return objKnowledgeType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objKnowledgeType_Const = await KnowledgeType_GetObjByKnowledgeTypeIdAsync(strKnowledgeTypeId);
                    if (objKnowledgeType_Const != null) {
                        KnowledgeType_ReFreshThisCache(strCourseId);
                        return objKnowledgeType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strKnowledgeTypeId, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.KnowledgeType_GetObjByKnowledgeTypeId_Cache = KnowledgeType_GetObjByKnowledgeTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strKnowledgeTypeId:所给的关键字
     * @returns 对象
    */
    async function KnowledgeType_GetObjByKnowledgeTypeId_localStorage(strKnowledgeTypeId) {
        const strThisFuncName = "GetObjByKnowledgeTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strKnowledgeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strKnowledgeTypeId]不能为空！(In clsKnowledgeTypeWApi.GetObjByKnowledgeTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strKnowledgeTypeId]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.GetObjByKnowledgeTypeId_localStorage)", strKnowledgeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strKnowledgeTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objKnowledgeType_Cache = JSON.parse(strTempObj);
            return objKnowledgeType_Cache;
        }
        try {
            const objKnowledgeType = await KnowledgeType_GetObjByKnowledgeTypeIdAsync(strKnowledgeTypeId);
            if (objKnowledgeType != null) {
                localStorage.setItem(strKey, JSON.stringify(objKnowledgeType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objKnowledgeType;
            }
            return objKnowledgeType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strKnowledgeTypeId, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.KnowledgeType_GetObjByKnowledgeTypeId_localStorage = KnowledgeType_GetObjByKnowledgeTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objKnowledgeType:所给的对象
     * @returns 对象
    */
    async function KnowledgeType_UpdateObjInLst_Cache(objKnowledgeType, strCourseId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
            const obj = arrKnowledgeTypeObjLst_Cache.find(x => x.knowledgeTypeName == objKnowledgeType.knowledgeTypeName);
            if (obj != null) {
                objKnowledgeType.knowledgeTypeId = obj.knowledgeTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objKnowledgeType);
            }
            else {
                arrKnowledgeTypeObjLst_Cache.push(objKnowledgeType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.KnowledgeType_UpdateObjInLst_Cache = KnowledgeType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strKnowledgeTypeId:所给的关键字
     * @returns 对象
    */
    async function KnowledgeType_GetNameByKnowledgeTypeId_Cache(strKnowledgeTypeId, strCourseId) {
        const strThisFuncName = "GetNameByKnowledgeTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strKnowledgeTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strKnowledgeTypeId]不能为空！(In clsKnowledgeTypeWApi.GetNameByKnowledgeTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strKnowledgeTypeId.length != 4) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strKnowledgeTypeId]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.GetNameByKnowledgeTypeId_Cache)", strKnowledgeTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        if (arrKnowledgeTypeObjLst_Cache == null)
            return "";
        try {
            const arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache.filter(x => x.knowledgeTypeId == strKnowledgeTypeId);
            let objKnowledgeType;
            if (arrKnowledgeType_Sel.length > 0) {
                objKnowledgeType = arrKnowledgeType_Sel[0];
                return objKnowledgeType.knowledgeTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strKnowledgeTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.KnowledgeType_GetNameByKnowledgeTypeId_Cache = KnowledgeType_GetNameByKnowledgeTypeId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function KnowledgeType_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clsKnowledgeTypeWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strKnowledgeTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objKnowledgeType = await KnowledgeType_GetObjByKnowledgeTypeId_Cache(strKnowledgeTypeId, strCourseId_C);
        if (objKnowledgeType == null)
            return "";
        if (objKnowledgeType.GetFldValue(strOutFldName) == null)
            return "";
        return objKnowledgeType.GetFldValue(strOutFldName).toString();
    }
    exports.KnowledgeType_func = KnowledgeType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function KnowledgeType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.knowledgeTypeId.localeCompare(b.knowledgeTypeId);
    }
    exports.KnowledgeType_SortFun_Defa = KnowledgeType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function KnowledgeType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.knowledgeTypeName == b.knowledgeTypeName)
            return a.courseId.localeCompare(b.courseId);
        else
            return a.knowledgeTypeName.localeCompare(b.knowledgeTypeName);
    }
    exports.KnowledgeType_SortFun_Defa_2Fld = KnowledgeType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function KnowledgeType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId:
                    return (a, b) => {
                        return a.knowledgeTypeId.localeCompare(b.knowledgeTypeId);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName:
                    return (a, b) => {
                        return a.knowledgeTypeName.localeCompare(b.knowledgeTypeName);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[KnowledgeType]中不存在！(in ${exports.knowledgeType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId:
                    return (a, b) => {
                        return b.knowledgeTypeId.localeCompare(a.knowledgeTypeId);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName:
                    return (a, b) => {
                        return b.knowledgeTypeName.localeCompare(a.knowledgeTypeName);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[KnowledgeType]中不存在！(in ${exports.knowledgeType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.KnowledgeType_SortFunByKey = KnowledgeType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function KnowledgeType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId:
                return (obj) => {
                    return obj.knowledgeTypeId === value;
                };
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName:
                return (obj) => {
                    return obj.knowledgeTypeName === value;
                };
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[KnowledgeType]中不存在！(in ${exports.knowledgeType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.KnowledgeType_FilterFunByKey = KnowledgeType_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function KnowledgeType_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clsKnowledgeTypeWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrKnowledgeType = await KnowledgeType_GetObjLst_Cache(strCourseId_C);
        if (arrKnowledgeType == null)
            return [];
        let arrKnowledgeType_Sel = arrKnowledgeType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrKnowledgeType_Sel.length == 0)
            return [];
        return arrKnowledgeType_Sel.map(x => x.knowledgeTypeId);
    }
    exports.KnowledgeType_funcKey = KnowledgeType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function KnowledgeType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetFirstIDAsync = KnowledgeType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function KnowledgeType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetFirstID = KnowledgeType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function KnowledgeType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const objKnowledgeType = KnowledgeType_GetObjFromJsonObj(returnObj);
                return objKnowledgeType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetFirstObjAsync = KnowledgeType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrKnowledgeTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrKnowledgeTypeObjLst_T = KnowledgeType_GetObjLstByJSONObjLst(arrKnowledgeTypeExObjLst_Cache);
            return arrKnowledgeTypeObjLst_T;
        }
        try {
            const arrKnowledgeTypeExObjLst = await KnowledgeType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrKnowledgeTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrKnowledgeTypeExObjLst.length);
            console.log(strInfo);
            return arrKnowledgeTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.KnowledgeType_GetObjLst_ClientCache = KnowledgeType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrKnowledgeTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrKnowledgeTypeObjLst_T = KnowledgeType_GetObjLstByJSONObjLst(arrKnowledgeTypeExObjLst_Cache);
            return arrKnowledgeTypeObjLst_T;
        }
        try {
            const arrKnowledgeTypeExObjLst = await KnowledgeType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrKnowledgeTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrKnowledgeTypeExObjLst.length);
            console.log(strInfo);
            return arrKnowledgeTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.KnowledgeType_GetObjLst_localStorage = KnowledgeType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrKnowledgeTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrKnowledgeTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.KnowledgeType_GetObjLst_localStorage_PureCache = KnowledgeType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function KnowledgeType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.knowledgeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = KnowledgeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetObjLstAsync = KnowledgeType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrKnowledgeTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrKnowledgeTypeObjLst_T = KnowledgeType_GetObjLstByJSONObjLst(arrKnowledgeTypeExObjLst_Cache);
            return arrKnowledgeTypeObjLst_T;
        }
        try {
            const arrKnowledgeTypeExObjLst = await KnowledgeType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrKnowledgeTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrKnowledgeTypeExObjLst.length);
            console.log(strInfo);
            return arrKnowledgeTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.KnowledgeType_GetObjLst_sessionStorage = KnowledgeType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrKnowledgeTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrKnowledgeTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.KnowledgeType_GetObjLst_sessionStorage_PureCache = KnowledgeType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[CourseId]不能为空！(in clsKnowledgeTypeWApi.KnowledgeType_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsKnowledgeTypeWApi.KnowledgeType_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrKnowledgeTypeObjLst_Cache;
        switch (clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrKnowledgeTypeObjLst = KnowledgeType_GetObjLstByJSONObjLst(arrKnowledgeTypeObjLst_Cache);
        return arrKnowledgeTypeObjLst_Cache;
    }
    exports.KnowledgeType_GetObjLst_Cache = KnowledgeType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function KnowledgeType_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrKnowledgeTypeObjLst_Cache;
        switch (clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrKnowledgeTypeObjLst_Cache = null;
                break;
            default:
                arrKnowledgeTypeObjLst_Cache = null;
                break;
        }
        return arrKnowledgeTypeObjLst_Cache;
    }
    exports.KnowledgeType_GetObjLst_PureCache = KnowledgeType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrKnowledgeTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function KnowledgeType_GetSubObjLst_Cache(objKnowledgeType_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        let arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache;
        if (objKnowledgeType_Cond.sf_FldComparisonOp == null || objKnowledgeType_Cond.sf_FldComparisonOp == "")
            return arrKnowledgeType_Sel;
        const dicFldComparisonOp = JSON.parse(objKnowledgeType_Cond.sf_FldComparisonOp);
        //console.log("clsKnowledgeTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objKnowledgeType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objKnowledgeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrKnowledgeType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objKnowledgeType_Cond), exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.KnowledgeType_GetSubObjLst_Cache = KnowledgeType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrKnowledgeTypeId:关键字列表
    * @returns 对象列表
    **/
    async function KnowledgeType_GetObjLstByKnowledgeTypeIdLstAsync(arrKnowledgeTypeId) {
        const strThisFuncName = "GetObjLstByKnowledgeTypeIdLstAsync";
        const strAction = "GetObjLstByKnowledgeTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrKnowledgeTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.knowledgeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = KnowledgeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetObjLstByKnowledgeTypeIdLstAsync = KnowledgeType_GetObjLstByKnowledgeTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrKnowledgeTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function KnowledgeType_GetObjLstByKnowledgeTypeIdLst_Cache(arrKnowledgeTypeIdLst, strCourseId) {
        const strThisFuncName = "GetObjLstByKnowledgeTypeIdLst_Cache";
        try {
            const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
            const arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache.filter(x => arrKnowledgeTypeIdLst.indexOf(x.knowledgeTypeId) > -1);
            return arrKnowledgeType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrKnowledgeTypeIdLst.join(","), exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.KnowledgeType_GetObjLstByKnowledgeTypeIdLst_Cache = KnowledgeType_GetObjLstByKnowledgeTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function KnowledgeType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.knowledgeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = KnowledgeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetTopObjLstAsync = KnowledgeType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function KnowledgeType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.knowledgeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = KnowledgeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetObjLstByRangeAsync = KnowledgeType_GetObjLstByRangeAsync;
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
    async function KnowledgeType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetObjLstByRange = KnowledgeType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function KnowledgeType_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        if (arrKnowledgeTypeObjLst_Cache.length == 0)
            return arrKnowledgeTypeObjLst_Cache;
        let arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objKnowledgeType_Cond = new clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objKnowledgeType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsKnowledgeTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objKnowledgeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrKnowledgeType_Sel.length == 0)
                return arrKnowledgeType_Sel;
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
                arrKnowledgeType_Sel = arrKnowledgeType_Sel.sort(KnowledgeType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrKnowledgeType_Sel = arrKnowledgeType_Sel.sort(objPagerPara.sortFun);
            }
            arrKnowledgeType_Sel = arrKnowledgeType_Sel.slice(intStart, intEnd);
            return arrKnowledgeType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.KnowledgeType_GetObjLstByPager_Cache = KnowledgeType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function KnowledgeType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.knowledgeType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = KnowledgeType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetObjLstByPagerAsync = KnowledgeType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strKnowledgeTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function KnowledgeType_DelRecordAsync(strKnowledgeTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strKnowledgeTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_DelRecordAsync = KnowledgeType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrKnowledgeTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function KnowledgeType_DelKnowledgeTypesAsync(arrKnowledgeTypeId) {
        const strThisFuncName = "DelKnowledgeTypesAsync";
        const strAction = "DelKnowledgeTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrKnowledgeTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_DelKnowledgeTypesAsync = KnowledgeType_DelKnowledgeTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function KnowledgeType_DelKnowledgeTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelKnowledgeTypesByCondAsync";
        const strAction = "DelKnowledgeTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_DelKnowledgeTypesByCondAsync = KnowledgeType_DelKnowledgeTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objKnowledgeTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function KnowledgeType_AddNewRecordAsync(objKnowledgeTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objKnowledgeTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objKnowledgeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_AddNewRecordAsync = KnowledgeType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objKnowledgeTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function KnowledgeType_AddNewRecordWithMaxIdAsync(objKnowledgeTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objKnowledgeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_AddNewRecordWithMaxIdAsync = KnowledgeType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objKnowledgeTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function KnowledgeType_AddNewRecordWithReturnKeyAsync(objKnowledgeTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objKnowledgeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_AddNewRecordWithReturnKeyAsync = KnowledgeType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objKnowledgeTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function KnowledgeType_AddNewRecordWithReturnKey(objKnowledgeTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objKnowledgeTypeEN.knowledgeTypeId === null || objKnowledgeTypeEN.knowledgeTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objKnowledgeTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_AddNewRecordWithReturnKey = KnowledgeType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objKnowledgeTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function KnowledgeType_UpdateRecordAsync(objKnowledgeTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objKnowledgeTypeEN.sf_UpdFldSetStr === undefined || objKnowledgeTypeEN.sf_UpdFldSetStr === null || objKnowledgeTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objKnowledgeTypeEN.knowledgeTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objKnowledgeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_UpdateRecordAsync = KnowledgeType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objKnowledgeTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function KnowledgeType_UpdateWithConditionAsync(objKnowledgeTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objKnowledgeTypeEN.sf_UpdFldSetStr === undefined || objKnowledgeTypeEN.sf_UpdFldSetStr === null || objKnowledgeTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objKnowledgeTypeEN.knowledgeTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        objKnowledgeTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objKnowledgeTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_UpdateWithConditionAsync = KnowledgeType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrKnowledgeTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function KnowledgeType_IsExistRecord_Cache(objKnowledgeType_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        if (arrKnowledgeTypeObjLst_Cache == null)
            return false;
        let arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache;
        if (objKnowledgeType_Cond.sf_FldComparisonOp == null || objKnowledgeType_Cond.sf_FldComparisonOp == "")
            return arrKnowledgeType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objKnowledgeType_Cond.sf_FldComparisonOp);
        //console.log("clsKnowledgeTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objKnowledgeType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objKnowledgeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrKnowledgeType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objKnowledgeType_Cond), exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.KnowledgeType_IsExistRecord_Cache = KnowledgeType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function KnowledgeType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_IsExistRecordAsync = KnowledgeType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strKnowledgeTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function KnowledgeType_IsExist(strKnowledgeTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "KnowledgeTypeId": strKnowledgeTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_IsExist = KnowledgeType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strKnowledgeTypeId:所给的关键字
     * @returns 对象
    */
    async function KnowledgeType_IsExist_Cache(strKnowledgeTypeId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        if (arrKnowledgeTypeObjLst_Cache == null)
            return false;
        try {
            const arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache.filter(x => x.knowledgeTypeId == strKnowledgeTypeId);
            if (arrKnowledgeType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strKnowledgeTypeId, exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.KnowledgeType_IsExist_Cache = KnowledgeType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strKnowledgeTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function KnowledgeType_IsExistAsync(strKnowledgeTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strKnowledgeTypeId": strKnowledgeTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_IsExistAsync = KnowledgeType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function KnowledgeType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetRecCountByCondAsync = KnowledgeType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objKnowledgeType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function KnowledgeType_GetRecCountByCond_Cache(objKnowledgeType_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrKnowledgeTypeObjLst_Cache = await KnowledgeType_GetObjLst_Cache(strCourseId);
        if (arrKnowledgeTypeObjLst_Cache == null)
            return 0;
        let arrKnowledgeType_Sel = arrKnowledgeTypeObjLst_Cache;
        if (objKnowledgeType_Cond.sf_FldComparisonOp == null || objKnowledgeType_Cond.sf_FldComparisonOp == "")
            return arrKnowledgeType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objKnowledgeType_Cond.sf_FldComparisonOp);
        //console.log("clsKnowledgeTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objKnowledgeType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objKnowledgeType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrKnowledgeType_Sel = arrKnowledgeType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrKnowledgeType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objKnowledgeType_Cond), exports.knowledgeType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.KnowledgeType_GetRecCountByCond_Cache = KnowledgeType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function KnowledgeType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetMaxStrIdAsync = KnowledgeType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function KnowledgeType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.knowledgeType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.knowledgeType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.KnowledgeType_GetMaxStrIdByPrefix = KnowledgeType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function KnowledgeType_GetWebApiUrl(strController, strAction) {
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
    exports.KnowledgeType_GetWebApiUrl = KnowledgeType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function KnowledgeType_ReFreshCache(strCourseId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clsKnowledgeTypeWApi.clsKnowledgeTypeWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.clsKnowledgeTypeWApi.ReFreshCache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
        switch (clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheModeId) {
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
    exports.KnowledgeType_ReFreshCache = KnowledgeType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function KnowledgeType_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN._CurrTabName, strCourseId);
            switch (clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.CacheModeId) {
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
    exports.KnowledgeType_ReFreshThisCache = KnowledgeType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function KnowledgeType_BindDdl_KnowledgeTypeIdInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_KnowledgeTypeIdInDiv_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clsKnowledgeTypeWApi.BindDdl_KnowledgeTypeIdInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsKnowledgeTypeWApi.BindDdl_KnowledgeTypeIdInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_KnowledgeTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_KnowledgeTypeIdInDiv_Cache");
        const arrObjLst_Sel = await KnowledgeType_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, "知识点类型");
    }
    exports.KnowledgeType_BindDdl_KnowledgeTypeIdInDiv_Cache = KnowledgeType_BindDdl_KnowledgeTypeIdInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function KnowledgeType_CheckPropertyNew(pobjKnowledgeTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[知识点类型名]不能为空(In 知识点类型)!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) === true
            || pobjKnowledgeTypeEN.courseId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[课程Id]不能为空(In 知识点类型)!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.knowledgeTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[知识点类型Id(knowledgeTypeId)]的长度不能超过4(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.knowledgeTypeId)(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.knowledgeTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[知识点类型名(knowledgeTypeName)]的长度不能超过50(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.knowledgeTypeName)(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.courseId)(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.updDate)(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.updUser)(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.memo)(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeId) == false && undefined !== pobjKnowledgeTypeEN.knowledgeTypeId && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.knowledgeTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[知识点类型Id(knowledgeTypeId)]的值:[$(pobjKnowledgeTypeEN.knowledgeTypeId)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeName) == false && undefined !== pobjKnowledgeTypeEN.knowledgeTypeName && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.knowledgeTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[知识点类型名(knowledgeTypeName)]的值:[$(pobjKnowledgeTypeEN.knowledgeTypeName)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) == false && undefined !== pobjKnowledgeTypeEN.courseId && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjKnowledgeTypeEN.courseId)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if (null != pobjKnowledgeTypeEN.orderNum && undefined !== pobjKnowledgeTypeEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjKnowledgeTypeEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjKnowledgeTypeEN.orderNum)], 非法，应该为数值型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updDate) == false && undefined !== pobjKnowledgeTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjKnowledgeTypeEN.updDate)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updUser) == false && undefined !== pobjKnowledgeTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjKnowledgeTypeEN.updUser)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.memo) == false && undefined !== pobjKnowledgeTypeEN.memo && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjKnowledgeTypeEN.memo)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.courseId) != 8) {
            throw ("(errid:Watl000061)字段[课程Id]作为外键字段,长度应该为8(In 知识点类型)!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjKnowledgeTypeEN.SetIsCheckProperty(true);
    }
    exports.KnowledgeType_CheckPropertyNew = KnowledgeType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function KnowledgeType_CheckProperty4Update(pobjKnowledgeTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.knowledgeTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[知识点类型Id(knowledgeTypeId)]的长度不能超过4(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.knowledgeTypeId)(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.knowledgeTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[知识点类型名(knowledgeTypeName)]的长度不能超过50(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.knowledgeTypeName)(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.courseId)(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.updDate)(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.updUser)(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 知识点类型(KnowledgeType))!值:$(pobjKnowledgeTypeEN.memo)(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeId) == false && undefined !== pobjKnowledgeTypeEN.knowledgeTypeId && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.knowledgeTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[知识点类型Id(knowledgeTypeId)]的值:[$(pobjKnowledgeTypeEN.knowledgeTypeId)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeName) == false && undefined !== pobjKnowledgeTypeEN.knowledgeTypeName && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.knowledgeTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[知识点类型名(knowledgeTypeName)]的值:[$(pobjKnowledgeTypeEN.knowledgeTypeName)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) == false && undefined !== pobjKnowledgeTypeEN.courseId && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjKnowledgeTypeEN.courseId)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if (null != pobjKnowledgeTypeEN.orderNum && undefined !== pobjKnowledgeTypeEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjKnowledgeTypeEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjKnowledgeTypeEN.orderNum)], 非法，应该为数值型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updDate) == false && undefined !== pobjKnowledgeTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjKnowledgeTypeEN.updDate)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.updUser) == false && undefined !== pobjKnowledgeTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjKnowledgeTypeEN.updUser)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.memo) == false && undefined !== pobjKnowledgeTypeEN.memo && clsString_js_1.tzDataType.isString(pobjKnowledgeTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjKnowledgeTypeEN.memo)], 非法，应该为字符型(In 知识点类型(KnowledgeType))!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.knowledgeTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[知识点类型Id]不能为空(In 知识点类型)!(clsKnowledgeTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjKnowledgeTypeEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjKnowledgeTypeEN.courseId) != 8) {
            throw ("(errid:Watl000065)字段[课程Id]作为外键字段,长度应该为8(In 知识点类型)!(clsKnowledgeTypeBL:CheckPropertyNew)");
        }
        pobjKnowledgeTypeEN.SetIsCheckProperty(true);
    }
    exports.KnowledgeType_CheckProperty4Update = KnowledgeType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function KnowledgeType_GetJSONStrByObj(pobjKnowledgeTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjKnowledgeTypeEN.sf_UpdFldSetStr = pobjKnowledgeTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjKnowledgeTypeEN);
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
    exports.KnowledgeType_GetJSONStrByObj = KnowledgeType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function KnowledgeType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrKnowledgeTypeObjLst = new Array();
        if (strJSON === "") {
            return arrKnowledgeTypeObjLst;
        }
        try {
            arrKnowledgeTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrKnowledgeTypeObjLst;
        }
        return arrKnowledgeTypeObjLst;
    }
    exports.KnowledgeType_GetObjLstByJSONStr = KnowledgeType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrKnowledgeTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function KnowledgeType_GetObjLstByJSONObjLst(arrKnowledgeTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrKnowledgeTypeObjLst = new Array();
        for (const objInFor of arrKnowledgeTypeObjLstS) {
            const obj1 = KnowledgeType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrKnowledgeTypeObjLst.push(obj1);
        }
        return arrKnowledgeTypeObjLst;
    }
    exports.KnowledgeType_GetObjLstByJSONObjLst = KnowledgeType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function KnowledgeType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjKnowledgeTypeEN = new clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN();
        if (strJSON === "") {
            return pobjKnowledgeTypeEN;
        }
        try {
            pobjKnowledgeTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjKnowledgeTypeEN;
        }
        return pobjKnowledgeTypeEN;
    }
    exports.KnowledgeType_GetObjByJSONStr = KnowledgeType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function KnowledgeType_GetCombineCondition(objKnowledgeType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId) == true) {
            const strComparisonOp_KnowledgeTypeId = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeId, objKnowledgeType_Cond.knowledgeTypeId, strComparisonOp_KnowledgeTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName) == true) {
            const strComparisonOp_KnowledgeTypeName = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_KnowledgeTypeName, objKnowledgeType_Cond.knowledgeTypeName, strComparisonOp_KnowledgeTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_CourseId, objKnowledgeType_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_OrderNum, objKnowledgeType_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdDate, objKnowledgeType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_UpdUser, objKnowledgeType_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objKnowledgeType_Cond.dicFldComparisonOp, clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objKnowledgeType_Cond.dicFldComparisonOp[clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN.con_Memo, objKnowledgeType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.KnowledgeType_GetCombineCondition = KnowledgeType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--KnowledgeType(知识点类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strKnowledgeTypeName: 知识点类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function KnowledgeType_GetUniCondStr_KnowledgeTypeName(objKnowledgeTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.knowledgeTypeName);
        return strWhereCond;
    }
    exports.KnowledgeType_GetUniCondStr_KnowledgeTypeName = KnowledgeType_GetUniCondStr_KnowledgeTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--KnowledgeType(知识点类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strKnowledgeTypeName: 知识点类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function KnowledgeType_GetUniCondStr4Update_KnowledgeTypeName(objKnowledgeTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and KnowledgeTypeId <> '{0}'", objKnowledgeTypeEN.knowledgeTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and KnowledgeTypeName = '{0}'", objKnowledgeTypeEN.knowledgeTypeName);
        return strWhereCond;
    }
    exports.KnowledgeType_GetUniCondStr4Update_KnowledgeTypeName = KnowledgeType_GetUniCondStr4Update_KnowledgeTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objKnowledgeTypeENS:源对象
     * @param objKnowledgeTypeENT:目标对象
    */
    function KnowledgeType_CopyObjTo(objKnowledgeTypeENS, objKnowledgeTypeENT) {
        objKnowledgeTypeENT.knowledgeTypeId = objKnowledgeTypeENS.knowledgeTypeId; //知识点类型Id
        objKnowledgeTypeENT.knowledgeTypeName = objKnowledgeTypeENS.knowledgeTypeName; //知识点类型名
        objKnowledgeTypeENT.courseId = objKnowledgeTypeENS.courseId; //课程Id
        objKnowledgeTypeENT.orderNum = objKnowledgeTypeENS.orderNum; //序号
        objKnowledgeTypeENT.updDate = objKnowledgeTypeENS.updDate; //修改日期
        objKnowledgeTypeENT.updUser = objKnowledgeTypeENS.updUser; //修改人
        objKnowledgeTypeENT.memo = objKnowledgeTypeENS.memo; //备注
        objKnowledgeTypeENT.sf_UpdFldSetStr = objKnowledgeTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.KnowledgeType_CopyObjTo = KnowledgeType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objKnowledgeTypeENS:源对象
     * @param objKnowledgeTypeENT:目标对象
    */
    function KnowledgeType_GetObjFromJsonObj(objKnowledgeTypeENS) {
        const objKnowledgeTypeENT = new clsKnowledgeTypeEN_js_1.clsKnowledgeTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objKnowledgeTypeENT, objKnowledgeTypeENS);
        return objKnowledgeTypeENT;
    }
    exports.KnowledgeType_GetObjFromJsonObj = KnowledgeType_GetObjFromJsonObj;
});
