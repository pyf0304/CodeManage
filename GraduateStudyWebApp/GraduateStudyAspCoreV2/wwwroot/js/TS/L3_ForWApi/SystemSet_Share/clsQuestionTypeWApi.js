/**
* 类名:clsQuestionTypeWApi
* 表名:QuestionType(01120008)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:40:18
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:系统设置(SystemSet)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/SystemSet_Share/clsQuestionTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.QuestionType_GetObjFromJsonObj = exports.QuestionType_CopyObjTo = exports.QuestionType_GetUniCondStr4Update_QuestionTypeName = exports.QuestionType_GetUniCondStr_QuestionTypeName = exports.QuestionType_GetCombineCondition = exports.QuestionType_GetObjByJSONStr = exports.QuestionType_GetObjLstByJSONObjLst = exports.QuestionType_GetObjLstByJSONStr = exports.QuestionType_GetJSONStrByObj = exports.QuestionType_CheckProperty4Update = exports.QuestionType_CheckPropertyNew = exports.QuestionType_BindDdl_QuestionTypeIdInDiv_Cache = exports.QuestionType_ReFreshThisCache = exports.QuestionType_ReFreshCache = exports.QuestionType_GetWebApiUrl = exports.QuestionType_GetMaxStrIdByPrefix = exports.QuestionType_GetMaxStrIdAsync = exports.QuestionType_GetRecCountByCond_Cache = exports.QuestionType_GetRecCountByCondAsync = exports.QuestionType_IsExistAsync = exports.QuestionType_IsExist_Cache = exports.QuestionType_IsExist = exports.QuestionType_IsExistRecordAsync = exports.QuestionType_IsExistRecord_Cache = exports.QuestionType_UpdateWithConditionAsync = exports.QuestionType_UpdateRecordAsync = exports.QuestionType_AddNewRecordWithReturnKey = exports.QuestionType_AddNewRecordWithReturnKeyAsync = exports.QuestionType_AddNewRecordWithMaxIdAsync = exports.QuestionType_AddNewRecordAsync = exports.QuestionType_DelQuestionTypesByCondAsync = exports.QuestionType_DelQuestionTypesAsync = exports.QuestionType_DelRecordAsync = exports.QuestionType_GetObjLstByPagerAsync = exports.QuestionType_GetObjLstByPager_Cache = exports.QuestionType_GetObjLstByRange = exports.QuestionType_GetObjLstByRangeAsync = exports.QuestionType_GetTopObjLstAsync = exports.QuestionType_GetObjLstByQuestionTypeIdLst_Cache = exports.QuestionType_GetObjLstByQuestionTypeIdLstAsync = exports.QuestionType_GetSubObjLst_Cache = exports.QuestionType_GetObjLst_PureCache = exports.QuestionType_GetObjLst_Cache = exports.QuestionType_GetObjLst_sessionStorage_PureCache = exports.QuestionType_GetObjLst_sessionStorage = exports.QuestionType_GetObjLstAsync = exports.QuestionType_GetObjLst_localStorage_PureCache = exports.QuestionType_GetObjLst_localStorage = exports.QuestionType_GetObjLst_ClientCache = exports.QuestionType_GetFirstObjAsync = exports.QuestionType_GetFirstID = exports.QuestionType_GetFirstIDAsync = exports.QuestionType_funcKey = exports.QuestionType_FilterFunByKey = exports.QuestionType_SortFunByKey = exports.QuestionType_SortFun_Defa_2Fld = exports.QuestionType_SortFun_Defa = exports.QuestionType_func = exports.QuestionType_GetNameByQuestionTypeId_Cache = exports.QuestionType_UpdateObjInLst_Cache = exports.QuestionType_GetObjByQuestionTypeId_localStorage = exports.QuestionType_GetObjByQuestionTypeId_Cache = exports.QuestionType_GetObjByQuestionTypeIdAsync = exports.questionType_ConstructorName = exports.questionType_Controller = void 0;
    /**
     * 题目类型(QuestionType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsQuestionTypeEN_js_1 = require("../../L0_Entity/SystemSet_Share/clsQuestionTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.questionType_Controller = "QuestionTypeApi";
    exports.questionType_ConstructorName = "questionType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strQuestionTypeId:关键字
    * @returns 对象
    **/
    async function QuestionType_GetObjByQuestionTypeIdAsync(strQuestionTypeId) {
        const strThisFuncName = "GetObjByQuestionTypeIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionTypeId]不能为空！(In clsQuestionTypeWApi.GetObjByQuestionTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionTypeId]的长度:[{0}]不正确！(clsQuestionTypeWApi.GetObjByQuestionTypeIdAsync)", strQuestionTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByQuestionTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strQuestionTypeId": strQuestionTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objQuestionType = QuestionType_GetObjFromJsonObj(returnObj);
                return objQuestionType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetObjByQuestionTypeIdAsync = QuestionType_GetObjByQuestionTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strQuestionTypeId:所给的关键字
     * @returns 对象
    */
    async function QuestionType_GetObjByQuestionTypeId_Cache(strQuestionTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByQuestionTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionTypeId]不能为空！(In clsQuestionTypeWApi.GetObjByQuestionTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionTypeId]的长度:[{0}]不正确！(clsQuestionTypeWApi.GetObjByQuestionTypeId_Cache)", strQuestionTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        try {
            const arrQuestionType_Sel = arrQuestionTypeObjLst_Cache.filter(x => x.questionTypeId == strQuestionTypeId);
            let objQuestionType;
            if (arrQuestionType_Sel.length > 0) {
                objQuestionType = arrQuestionType_Sel[0];
                return objQuestionType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objQuestionType_Const = await QuestionType_GetObjByQuestionTypeIdAsync(strQuestionTypeId);
                    if (objQuestionType_Const != null) {
                        QuestionType_ReFreshThisCache();
                        return objQuestionType_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionTypeId, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.QuestionType_GetObjByQuestionTypeId_Cache = QuestionType_GetObjByQuestionTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strQuestionTypeId:所给的关键字
     * @returns 对象
    */
    async function QuestionType_GetObjByQuestionTypeId_localStorage(strQuestionTypeId) {
        const strThisFuncName = "GetObjByQuestionTypeId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionTypeId]不能为空！(In clsQuestionTypeWApi.GetObjByQuestionTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionTypeId]的长度:[{0}]不正确！(clsQuestionTypeWApi.GetObjByQuestionTypeId_localStorage)", strQuestionTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName, strQuestionTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objQuestionType_Cache = JSON.parse(strTempObj);
            return objQuestionType_Cache;
        }
        try {
            const objQuestionType = await QuestionType_GetObjByQuestionTypeIdAsync(strQuestionTypeId);
            if (objQuestionType != null) {
                localStorage.setItem(strKey, JSON.stringify(objQuestionType));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objQuestionType;
            }
            return objQuestionType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionTypeId, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.QuestionType_GetObjByQuestionTypeId_localStorage = QuestionType_GetObjByQuestionTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objQuestionType:所给的对象
     * @returns 对象
    */
    async function QuestionType_UpdateObjInLst_Cache(objQuestionType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
            const obj = arrQuestionTypeObjLst_Cache.find(x => x.questionTypeName == objQuestionType.questionTypeName);
            if (obj != null) {
                objQuestionType.questionTypeId = obj.questionTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objQuestionType);
            }
            else {
                arrQuestionTypeObjLst_Cache.push(objQuestionType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.QuestionType_UpdateObjInLst_Cache = QuestionType_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strQuestionTypeId:所给的关键字
     * @returns 对象
    */
    async function QuestionType_GetNameByQuestionTypeId_Cache(strQuestionTypeId) {
        const strThisFuncName = "GetNameByQuestionTypeId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionTypeId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionTypeId]不能为空！(In clsQuestionTypeWApi.GetNameByQuestionTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionTypeId.length != 2) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionTypeId]的长度:[{0}]不正确！(clsQuestionTypeWApi.GetNameByQuestionTypeId_Cache)", strQuestionTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        if (arrQuestionTypeObjLst_Cache == null)
            return "";
        try {
            const arrQuestionType_Sel = arrQuestionTypeObjLst_Cache.filter(x => x.questionTypeId == strQuestionTypeId);
            let objQuestionType;
            if (arrQuestionType_Sel.length > 0) {
                objQuestionType = arrQuestionType_Sel[0];
                return objQuestionType.questionTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strQuestionTypeId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.QuestionType_GetNameByQuestionTypeId_Cache = QuestionType_GetNameByQuestionTypeId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function QuestionType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsQuestionTypeEN_js_1.clsQuestionTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsQuestionTypeEN_js_1.clsQuestionTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strQuestionTypeId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objQuestionType = await QuestionType_GetObjByQuestionTypeId_Cache(strQuestionTypeId);
        if (objQuestionType == null)
            return "";
        if (objQuestionType.GetFldValue(strOutFldName) == null)
            return "";
        return objQuestionType.GetFldValue(strOutFldName).toString();
    }
    exports.QuestionType_func = QuestionType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QuestionType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.questionTypeId.localeCompare(b.questionTypeId);
    }
    exports.QuestionType_SortFun_Defa = QuestionType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QuestionType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionTypeName == b.questionTypeName)
            return a.questionTypeENName.localeCompare(b.questionTypeENName);
        else
            return a.questionTypeName.localeCompare(b.questionTypeName);
    }
    exports.QuestionType_SortFun_Defa_2Fld = QuestionType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function QuestionType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId:
                    return (a, b) => {
                        return a.questionTypeId.localeCompare(b.questionTypeId);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName:
                    return (a, b) => {
                        return a.questionTypeName.localeCompare(b.questionTypeName);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeENName:
                    return (a, b) => {
                        if (a.questionTypeENName == null)
                            return -1;
                        if (b.questionTypeENName == null)
                            return 1;
                        return a.questionTypeENName.localeCompare(b.questionTypeENName);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerModeId:
                    return (a, b) => {
                        if (a.defaAnswerModeId == null)
                            return -1;
                        if (b.defaAnswerModeId == null)
                            return 1;
                        return a.defaAnswerModeId.localeCompare(b.defaAnswerModeId);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerTypeId:
                    return (a, b) => {
                        if (a.defaAnswerTypeId == null)
                            return -1;
                        if (b.defaAnswerTypeId == null)
                            return 1;
                        return a.defaAnswerTypeId.localeCompare(b.defaAnswerTypeId);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_IsUse:
                    return (a, b) => {
                        if (a.isUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[QuestionType]中不存在！(in ${exports.questionType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId:
                    return (a, b) => {
                        return b.questionTypeId.localeCompare(a.questionTypeId);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName:
                    return (a, b) => {
                        return b.questionTypeName.localeCompare(a.questionTypeName);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeENName:
                    return (a, b) => {
                        if (b.questionTypeENName == null)
                            return -1;
                        if (a.questionTypeENName == null)
                            return 1;
                        return b.questionTypeENName.localeCompare(a.questionTypeENName);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerModeId:
                    return (a, b) => {
                        if (b.defaAnswerModeId == null)
                            return -1;
                        if (a.defaAnswerModeId == null)
                            return 1;
                        return b.defaAnswerModeId.localeCompare(a.defaAnswerModeId);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerTypeId:
                    return (a, b) => {
                        if (b.defaAnswerTypeId == null)
                            return -1;
                        if (a.defaAnswerTypeId == null)
                            return 1;
                        return b.defaAnswerTypeId.localeCompare(a.defaAnswerTypeId);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_IsUse:
                    return (a, b) => {
                        if (b.isUse == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[QuestionType]中不存在！(in ${exports.questionType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.QuestionType_SortFunByKey = QuestionType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function QuestionType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId:
                return (obj) => {
                    return obj.questionTypeId === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName:
                return (obj) => {
                    return obj.questionTypeName === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeENName:
                return (obj) => {
                    return obj.questionTypeENName === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerModeId:
                return (obj) => {
                    return obj.defaAnswerModeId === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerTypeId:
                return (obj) => {
                    return obj.defaAnswerTypeId === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_IsUse:
                return (obj) => {
                    return obj.isUse === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[QuestionType]中不存在！(in ${exports.questionType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.QuestionType_FilterFunByKey = QuestionType_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function QuestionType_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrQuestionType = await QuestionType_GetObjLst_Cache();
        if (arrQuestionType == null)
            return [];
        let arrQuestionType_Sel = arrQuestionType;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrQuestionType_Sel.length == 0)
            return [];
        return arrQuestionType_Sel.map(x => x.questionTypeId);
    }
    exports.QuestionType_funcKey = QuestionType_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function QuestionType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetFirstIDAsync = QuestionType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function QuestionType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetFirstID = QuestionType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function QuestionType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const objQuestionType = QuestionType_GetObjFromJsonObj(returnObj);
                return objQuestionType;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetFirstObjAsync = QuestionType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrQuestionTypeExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrQuestionTypeObjLst_T = QuestionType_GetObjLstByJSONObjLst(arrQuestionTypeExObjLst_Cache);
            return arrQuestionTypeObjLst_T;
        }
        try {
            const arrQuestionTypeExObjLst = await QuestionType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrQuestionTypeExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQuestionTypeExObjLst.length);
            console.log(strInfo);
            return arrQuestionTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionType_GetObjLst_ClientCache = QuestionType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQuestionTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQuestionTypeObjLst_T = QuestionType_GetObjLstByJSONObjLst(arrQuestionTypeExObjLst_Cache);
            return arrQuestionTypeObjLst_T;
        }
        try {
            const arrQuestionTypeExObjLst = await QuestionType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrQuestionTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQuestionTypeExObjLst.length);
            console.log(strInfo);
            return arrQuestionTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionType_GetObjLst_localStorage = QuestionType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQuestionTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQuestionTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.QuestionType_GetObjLst_localStorage_PureCache = QuestionType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function QuestionType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QuestionType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetObjLstAsync = QuestionType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQuestionTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQuestionTypeObjLst_T = QuestionType_GetObjLstByJSONObjLst(arrQuestionTypeExObjLst_Cache);
            return arrQuestionTypeObjLst_T;
        }
        try {
            const arrQuestionTypeExObjLst = await QuestionType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrQuestionTypeExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQuestionTypeExObjLst.length);
            console.log(strInfo);
            return arrQuestionTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.QuestionType_GetObjLst_sessionStorage = QuestionType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQuestionTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQuestionTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.QuestionType_GetObjLst_sessionStorage_PureCache = QuestionType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrQuestionTypeObjLst_Cache;
        switch (clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_ClientCache();
                break;
            default:
                arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_ClientCache();
                break;
        }
        const arrQuestionTypeObjLst = QuestionType_GetObjLstByJSONObjLst(arrQuestionTypeObjLst_Cache);
        return arrQuestionTypeObjLst_Cache;
    }
    exports.QuestionType_GetObjLst_Cache = QuestionType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function QuestionType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrQuestionTypeObjLst_Cache;
        switch (clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrQuestionTypeObjLst_Cache = null;
                break;
            default:
                arrQuestionTypeObjLst_Cache = null;
                break;
        }
        return arrQuestionTypeObjLst_Cache;
    }
    exports.QuestionType_GetObjLst_PureCache = QuestionType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrQuestionTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function QuestionType_GetSubObjLst_Cache(objQuestionType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        let arrQuestionType_Sel = arrQuestionTypeObjLst_Cache;
        if (objQuestionType_Cond.sf_FldComparisonOp == null || objQuestionType_Cond.sf_FldComparisonOp == "")
            return arrQuestionType_Sel;
        const dicFldComparisonOp = JSON.parse(objQuestionType_Cond.sf_FldComparisonOp);
        //console.log("clsQuestionTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQuestionType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQuestionType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objQuestionType_Cond), exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.QuestionType_GetSubObjLst_Cache = QuestionType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrQuestionTypeId:关键字列表
    * @returns 对象列表
    **/
    async function QuestionType_GetObjLstByQuestionTypeIdLstAsync(arrQuestionTypeId) {
        const strThisFuncName = "GetObjLstByQuestionTypeIdLstAsync";
        const strAction = "GetObjLstByQuestionTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QuestionType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetObjLstByQuestionTypeIdLstAsync = QuestionType_GetObjLstByQuestionTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrQuestionTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function QuestionType_GetObjLstByQuestionTypeIdLst_Cache(arrQuestionTypeIdLst) {
        const strThisFuncName = "GetObjLstByQuestionTypeIdLst_Cache";
        try {
            const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
            const arrQuestionType_Sel = arrQuestionTypeObjLst_Cache.filter(x => arrQuestionTypeIdLst.indexOf(x.questionTypeId) > -1);
            return arrQuestionType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrQuestionTypeIdLst.join(","), exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.QuestionType_GetObjLstByQuestionTypeIdLst_Cache = QuestionType_GetObjLstByQuestionTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function QuestionType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QuestionType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetTopObjLstAsync = QuestionType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function QuestionType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QuestionType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetObjLstByRangeAsync = QuestionType_GetObjLstByRangeAsync;
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
    async function QuestionType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetObjLstByRange = QuestionType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function QuestionType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        if (arrQuestionTypeObjLst_Cache.length == 0)
            return arrQuestionTypeObjLst_Cache;
        let arrQuestionType_Sel = arrQuestionTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objQuestionType_Cond = new clsQuestionTypeEN_js_1.clsQuestionTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQuestionType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsQuestionTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQuestionType_Sel.length == 0)
                return arrQuestionType_Sel;
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
                arrQuestionType_Sel = arrQuestionType_Sel.sort(QuestionType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrQuestionType_Sel = arrQuestionType_Sel.sort(objPagerPara.sortFun);
            }
            arrQuestionType_Sel = arrQuestionType_Sel.slice(intStart, intEnd);
            return arrQuestionType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.QuestionType_GetObjLstByPager_Cache = QuestionType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function QuestionType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = QuestionType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetObjLstByPagerAsync = QuestionType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strQuestionTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function QuestionType_DelRecordAsync(strQuestionTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strQuestionTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_DelRecordAsync = QuestionType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrQuestionTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function QuestionType_DelQuestionTypesAsync(arrQuestionTypeId) {
        const strThisFuncName = "DelQuestionTypesAsync";
        const strAction = "DelQuestionTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionTypeId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_DelQuestionTypesAsync = QuestionType_DelQuestionTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function QuestionType_DelQuestionTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelQuestionTypesByCondAsync";
        const strAction = "DelQuestionTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_DelQuestionTypesByCondAsync = QuestionType_DelQuestionTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objQuestionTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function QuestionType_AddNewRecordAsync(objQuestionTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objQuestionTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_AddNewRecordAsync = QuestionType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objQuestionTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function QuestionType_AddNewRecordWithMaxIdAsync(objQuestionTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_AddNewRecordWithMaxIdAsync = QuestionType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objQuestionTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function QuestionType_AddNewRecordWithReturnKeyAsync(objQuestionTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_AddNewRecordWithReturnKeyAsync = QuestionType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objQuestionTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function QuestionType_AddNewRecordWithReturnKey(objQuestionTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objQuestionTypeEN.questionTypeId === null || objQuestionTypeEN.questionTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_AddNewRecordWithReturnKey = QuestionType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objQuestionTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function QuestionType_UpdateRecordAsync(objQuestionTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objQuestionTypeEN.sf_UpdFldSetStr === undefined || objQuestionTypeEN.sf_UpdFldSetStr === null || objQuestionTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQuestionTypeEN.questionTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_UpdateRecordAsync = QuestionType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objQuestionTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function QuestionType_UpdateWithConditionAsync(objQuestionTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objQuestionTypeEN.sf_UpdFldSetStr === undefined || objQuestionTypeEN.sf_UpdFldSetStr === null || objQuestionTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQuestionTypeEN.questionTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        objQuestionTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objQuestionTypeEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_UpdateWithConditionAsync = QuestionType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrQuestionTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function QuestionType_IsExistRecord_Cache(objQuestionType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        if (arrQuestionTypeObjLst_Cache == null)
            return false;
        let arrQuestionType_Sel = arrQuestionTypeObjLst_Cache;
        if (objQuestionType_Cond.sf_FldComparisonOp == null || objQuestionType_Cond.sf_FldComparisonOp == "")
            return arrQuestionType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objQuestionType_Cond.sf_FldComparisonOp);
        //console.log("clsQuestionTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQuestionType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQuestionType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objQuestionType_Cond), exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.QuestionType_IsExistRecord_Cache = QuestionType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function QuestionType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_IsExistRecordAsync = QuestionType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strQuestionTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function QuestionType_IsExist(strQuestionTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "QuestionTypeId": strQuestionTypeId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_IsExist = QuestionType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strQuestionTypeId:所给的关键字
     * @returns 对象
    */
    async function QuestionType_IsExist_Cache(strQuestionTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        if (arrQuestionTypeObjLst_Cache == null)
            return false;
        try {
            const arrQuestionType_Sel = arrQuestionTypeObjLst_Cache.filter(x => x.questionTypeId == strQuestionTypeId);
            if (arrQuestionType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strQuestionTypeId, exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.QuestionType_IsExist_Cache = QuestionType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strQuestionTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function QuestionType_IsExistAsync(strQuestionTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strQuestionTypeId": strQuestionTypeId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_IsExistAsync = QuestionType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function QuestionType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetRecCountByCondAsync = QuestionType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objQuestionType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function QuestionType_GetRecCountByCond_Cache(objQuestionType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrQuestionTypeObjLst_Cache = await QuestionType_GetObjLst_Cache();
        if (arrQuestionTypeObjLst_Cache == null)
            return 0;
        let arrQuestionType_Sel = arrQuestionTypeObjLst_Cache;
        if (objQuestionType_Cond.sf_FldComparisonOp == null || objQuestionType_Cond.sf_FldComparisonOp == "")
            return arrQuestionType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objQuestionType_Cond.sf_FldComparisonOp);
        //console.log("clsQuestionTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQuestionType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionType_Sel = arrQuestionType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQuestionType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objQuestionType_Cond), exports.questionType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.QuestionType_GetRecCountByCond_Cache = QuestionType_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function QuestionType_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetMaxStrIdAsync = QuestionType_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function QuestionType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionType_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.QuestionType_GetMaxStrIdByPrefix = QuestionType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function QuestionType_GetWebApiUrl(strController, strAction) {
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
    exports.QuestionType_GetWebApiUrl = QuestionType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function QuestionType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
        switch (clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheModeId) {
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
    exports.QuestionType_ReFreshCache = QuestionType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function QuestionType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsQuestionTypeEN_js_1.clsQuestionTypeEN._CurrTabName;
            switch (clsQuestionTypeEN_js_1.clsQuestionTypeEN.CacheModeId) {
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
    exports.QuestionType_ReFreshThisCache = QuestionType_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function QuestionType_BindDdl_QuestionTypeIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_QuestionTypeIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_QuestionTypeIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_QuestionTypeIdInDiv_Cache");
        const arrObjLst_Sel = await QuestionType_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName, "题目类型");
    }
    exports.QuestionType_BindDdl_QuestionTypeIdInDiv_Cache = QuestionType_BindDdl_QuestionTypeIdInDiv_Cache;
    //(IsNeedGC == false)该表下拉框功能不需要生成;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function QuestionType_CheckPropertyNew(pobjQuestionTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeName) === true) {
            throw new Error("(errid:Watl000058)字段[题目类型名]不能为空(In 题目类型)!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 题目类型)!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.questionTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[题目类型Id(questionTypeId)]的长度不能超过2(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.questionTypeId)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.questionTypeName) > 20) {
            throw new Error("(errid:Watl000059)字段[题目类型名(questionTypeName)]的长度不能超过20(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.questionTypeName)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.questionTypeENName) > 50) {
            throw new Error("(errid:Watl000059)字段[题目类型英文名(questionTypeENName)]的长度不能超过50(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.questionTypeENName)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.defaAnswerModeId) > 4) {
            throw new Error("(errid:Watl000059)字段[默认答案模式Id(defaAnswerModeId)]的长度不能超过4(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.defaAnswerModeId)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.defaAnswerTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[默认答案类型Id(defaAnswerTypeId)]的长度不能超过2(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.defaAnswerTypeId)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.updDate)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.updUser)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.memo)(clsQuestionTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeId) == false && undefined !== pobjQuestionTypeEN.questionTypeId && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.questionTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[题目类型Id(questionTypeId)]的值:[$(pobjQuestionTypeEN.questionTypeId)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeName) == false && undefined !== pobjQuestionTypeEN.questionTypeName && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.questionTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[题目类型名(questionTypeName)]的值:[$(pobjQuestionTypeEN.questionTypeName)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeENName) == false && undefined !== pobjQuestionTypeEN.questionTypeENName && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.questionTypeENName) === false) {
            throw new Error("(errid:Watl000060)字段[题目类型英文名(questionTypeENName)]的值:[$(pobjQuestionTypeEN.questionTypeENName)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerModeId) == false && undefined !== pobjQuestionTypeEN.defaAnswerModeId && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.defaAnswerModeId) === false) {
            throw new Error("(errid:Watl000060)字段[默认答案模式Id(defaAnswerModeId)]的值:[$(pobjQuestionTypeEN.defaAnswerModeId)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerTypeId) == false && undefined !== pobjQuestionTypeEN.defaAnswerTypeId && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.defaAnswerTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[默认答案类型Id(defaAnswerTypeId)]的值:[$(pobjQuestionTypeEN.defaAnswerTypeId)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionTypeEN.orderNum && undefined !== pobjQuestionTypeEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjQuestionTypeEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjQuestionTypeEN.orderNum)], 非法，应该为数值型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionTypeEN.isUse && undefined !== pobjQuestionTypeEN.isUse && clsString_js_1.tzDataType.isBoolean(pobjQuestionTypeEN.isUse) === false) {
            throw new Error("(errid:Watl000060)字段[是否使用(isUse)]的值:[$(pobjQuestionTypeEN.isUse)], 非法，应该为布尔型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updDate) == false && undefined !== pobjQuestionTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjQuestionTypeEN.updDate)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updUser) == false && undefined !== pobjQuestionTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjQuestionTypeEN.updUser)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.memo) == false && undefined !== pobjQuestionTypeEN.memo && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjQuestionTypeEN.memo)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjQuestionTypeEN.SetIsCheckProperty(true);
    }
    exports.QuestionType_CheckPropertyNew = QuestionType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function QuestionType_CheckProperty4Update(pobjQuestionTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.questionTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[题目类型Id(questionTypeId)]的长度不能超过2(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.questionTypeId)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeName) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.questionTypeName) > 20) {
            throw new Error("(errid:Watl000062)字段[题目类型名(questionTypeName)]的长度不能超过20(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.questionTypeName)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeENName) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.questionTypeENName) > 50) {
            throw new Error("(errid:Watl000062)字段[题目类型英文名(questionTypeENName)]的长度不能超过50(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.questionTypeENName)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.defaAnswerModeId) > 4) {
            throw new Error("(errid:Watl000062)字段[默认答案模式Id(defaAnswerModeId)]的长度不能超过4(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.defaAnswerModeId)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.defaAnswerTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[默认答案类型Id(defaAnswerTypeId)]的长度不能超过2(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.defaAnswerTypeId)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.updDate)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.updUser)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 题目类型(QuestionType))!值:$(pobjQuestionTypeEN.memo)(clsQuestionTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeId) == false && undefined !== pobjQuestionTypeEN.questionTypeId && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.questionTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[题目类型Id(questionTypeId)]的值:[$(pobjQuestionTypeEN.questionTypeId)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeName) == false && undefined !== pobjQuestionTypeEN.questionTypeName && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.questionTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[题目类型名(questionTypeName)]的值:[$(pobjQuestionTypeEN.questionTypeName)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeENName) == false && undefined !== pobjQuestionTypeEN.questionTypeENName && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.questionTypeENName) === false) {
            throw new Error("(errid:Watl000063)字段[题目类型英文名(questionTypeENName)]的值:[$(pobjQuestionTypeEN.questionTypeENName)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerModeId) == false && undefined !== pobjQuestionTypeEN.defaAnswerModeId && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.defaAnswerModeId) === false) {
            throw new Error("(errid:Watl000063)字段[默认答案模式Id(defaAnswerModeId)]的值:[$(pobjQuestionTypeEN.defaAnswerModeId)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.defaAnswerTypeId) == false && undefined !== pobjQuestionTypeEN.defaAnswerTypeId && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.defaAnswerTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[默认答案类型Id(defaAnswerTypeId)]的值:[$(pobjQuestionTypeEN.defaAnswerTypeId)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionTypeEN.orderNum && undefined !== pobjQuestionTypeEN.orderNum && clsString_js_1.tzDataType.isNumber(pobjQuestionTypeEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjQuestionTypeEN.orderNum)], 非法，应该为数值型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionTypeEN.isUse && undefined !== pobjQuestionTypeEN.isUse && clsString_js_1.tzDataType.isBoolean(pobjQuestionTypeEN.isUse) === false) {
            throw new Error("(errid:Watl000063)字段[是否使用(isUse)]的值:[$(pobjQuestionTypeEN.isUse)], 非法，应该为布尔型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updDate) == false && undefined !== pobjQuestionTypeEN.updDate && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjQuestionTypeEN.updDate)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.updUser) == false && undefined !== pobjQuestionTypeEN.updUser && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjQuestionTypeEN.updUser)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.memo) == false && undefined !== pobjQuestionTypeEN.memo && clsString_js_1.tzDataType.isString(pobjQuestionTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjQuestionTypeEN.memo)], 非法，应该为字符型(In 题目类型(QuestionType))!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionTypeEN.questionTypeId) === true
            || pobjQuestionTypeEN.questionTypeId.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[题目类型Id]不能为空(In 题目类型)!(clsQuestionTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjQuestionTypeEN.SetIsCheckProperty(true);
    }
    exports.QuestionType_CheckProperty4Update = QuestionType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function QuestionType_GetJSONStrByObj(pobjQuestionTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjQuestionTypeEN.sf_UpdFldSetStr = pobjQuestionTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjQuestionTypeEN);
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
    exports.QuestionType_GetJSONStrByObj = QuestionType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function QuestionType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrQuestionTypeObjLst = new Array();
        if (strJSON === "") {
            return arrQuestionTypeObjLst;
        }
        try {
            arrQuestionTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrQuestionTypeObjLst;
        }
        return arrQuestionTypeObjLst;
    }
    exports.QuestionType_GetObjLstByJSONStr = QuestionType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrQuestionTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function QuestionType_GetObjLstByJSONObjLst(arrQuestionTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrQuestionTypeObjLst = new Array();
        for (const objInFor of arrQuestionTypeObjLstS) {
            const obj1 = QuestionType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrQuestionTypeObjLst.push(obj1);
        }
        return arrQuestionTypeObjLst;
    }
    exports.QuestionType_GetObjLstByJSONObjLst = QuestionType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function QuestionType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjQuestionTypeEN = new clsQuestionTypeEN_js_1.clsQuestionTypeEN();
        if (strJSON === "") {
            return pobjQuestionTypeEN;
        }
        try {
            pobjQuestionTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjQuestionTypeEN;
        }
        return pobjQuestionTypeEN;
    }
    exports.QuestionType_GetObjByJSONStr = QuestionType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function QuestionType_GetCombineCondition(objQuestionType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId) == true) {
            const strComparisonOp_QuestionTypeId = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeId, objQuestionType_Cond.questionTypeId, strComparisonOp_QuestionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName) == true) {
            const strComparisonOp_QuestionTypeName = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeName, objQuestionType_Cond.questionTypeName, strComparisonOp_QuestionTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeENName) == true) {
            const strComparisonOp_QuestionTypeENName = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeENName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_QuestionTypeENName, objQuestionType_Cond.questionTypeENName, strComparisonOp_QuestionTypeENName);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerModeId) == true) {
            const strComparisonOp_DefaAnswerModeId = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerModeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerModeId, objQuestionType_Cond.defaAnswerModeId, strComparisonOp_DefaAnswerModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerTypeId) == true) {
            const strComparisonOp_DefaAnswerTypeId = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_DefaAnswerTypeId, objQuestionType_Cond.defaAnswerTypeId, strComparisonOp_DefaAnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_OrderNum];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_OrderNum, objQuestionType_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_IsUse) == true) {
            if (objQuestionType_Cond.isUse == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_IsUse);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_IsUse);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdDate, objQuestionType_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_UpdUser, objQuestionType_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionType_Cond.dicFldComparisonOp, clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objQuestionType_Cond.dicFldComparisonOp[clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionTypeEN_js_1.clsQuestionTypeEN.con_Memo, objQuestionType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.QuestionType_GetCombineCondition = QuestionType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--QuestionType(题目类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strQuestionTypeName: 题目类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function QuestionType_GetUniCondStr_QuestionTypeName(objQuestionTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionTypeName = '{0}'", objQuestionTypeEN.questionTypeName);
        return strWhereCond;
    }
    exports.QuestionType_GetUniCondStr_QuestionTypeName = QuestionType_GetUniCondStr_QuestionTypeName;
    /**
    *获取唯一性条件串(Uniqueness)--QuestionType(题目类型),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strQuestionTypeName: 题目类型名(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function QuestionType_GetUniCondStr4Update_QuestionTypeName(objQuestionTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionTypeId <> '{0}'", objQuestionTypeEN.questionTypeId);
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionTypeName = '{0}'", objQuestionTypeEN.questionTypeName);
        return strWhereCond;
    }
    exports.QuestionType_GetUniCondStr4Update_QuestionTypeName = QuestionType_GetUniCondStr4Update_QuestionTypeName;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objQuestionTypeENS:源对象
     * @param objQuestionTypeENT:目标对象
    */
    function QuestionType_CopyObjTo(objQuestionTypeENS, objQuestionTypeENT) {
        objQuestionTypeENT.questionTypeId = objQuestionTypeENS.questionTypeId; //题目类型Id
        objQuestionTypeENT.questionTypeName = objQuestionTypeENS.questionTypeName; //题目类型名
        objQuestionTypeENT.questionTypeENName = objQuestionTypeENS.questionTypeENName; //题目类型英文名
        objQuestionTypeENT.defaAnswerModeId = objQuestionTypeENS.defaAnswerModeId; //默认答案模式Id
        objQuestionTypeENT.defaAnswerTypeId = objQuestionTypeENS.defaAnswerTypeId; //默认答案类型Id
        objQuestionTypeENT.orderNum = objQuestionTypeENS.orderNum; //序号
        objQuestionTypeENT.isUse = objQuestionTypeENS.isUse; //是否使用
        objQuestionTypeENT.updDate = objQuestionTypeENS.updDate; //修改日期
        objQuestionTypeENT.updUser = objQuestionTypeENS.updUser; //修改人
        objQuestionTypeENT.memo = objQuestionTypeENS.memo; //备注
        objQuestionTypeENT.sf_UpdFldSetStr = objQuestionTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.QuestionType_CopyObjTo = QuestionType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objQuestionTypeENS:源对象
     * @param objQuestionTypeENT:目标对象
    */
    function QuestionType_GetObjFromJsonObj(objQuestionTypeENS) {
        const objQuestionTypeENT = new clsQuestionTypeEN_js_1.clsQuestionTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQuestionTypeENT, objQuestionTypeENS);
        return objQuestionTypeENT;
    }
    exports.QuestionType_GetObjFromJsonObj = QuestionType_GetObjFromJsonObj;
});
