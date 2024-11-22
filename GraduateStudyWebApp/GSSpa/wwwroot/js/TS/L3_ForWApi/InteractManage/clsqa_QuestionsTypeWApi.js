/**
* 类名:clsqa_QuestionsTypeWApi
* 表名:qa_QuestionsType(01120752)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:12
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:互动管理(InteractManage)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsqa_QuestionsTypeEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_QuestionsType_GetObjFromJsonObj = exports.qa_QuestionsType_CopyObjTo = exports.qa_QuestionsType_GetUniCondStr4Update_QuestionsTypeId = exports.qa_QuestionsType_GetUniCondStr_QuestionsTypeId = exports.qa_QuestionsType_GetCombineCondition = exports.qa_QuestionsType_GetObjByJSONStr = exports.qa_QuestionsType_GetObjLstByJSONObjLst = exports.qa_QuestionsType_GetObjLstByJSONStr = exports.qa_QuestionsType_GetJSONStrByObj = exports.qa_QuestionsType_CheckProperty4Update = exports.qa_QuestionsType_CheckPropertyNew = exports.qa_QuestionsType_ReFreshThisCache = exports.qa_QuestionsType_ReFreshCache = exports.qa_QuestionsType_GetWebApiUrl = exports.qa_QuestionsType_GetMaxStrIdByPrefix = exports.qa_QuestionsType_GetRecCountByCond_Cache = exports.qa_QuestionsType_GetRecCountByCondAsync = exports.qa_QuestionsType_IsExistAsync = exports.qa_QuestionsType_IsExist_Cache = exports.qa_QuestionsType_IsExist = exports.qa_QuestionsType_IsExistRecordAsync = exports.qa_QuestionsType_IsExistRecord_Cache = exports.qa_QuestionsType_UpdateWithConditionAsync = exports.qa_QuestionsType_UpdateRecordAsync = exports.qa_QuestionsType_AddNewRecordWithReturnKey = exports.qa_QuestionsType_AddNewRecordWithReturnKeyAsync = exports.qa_QuestionsType_AddNewRecordWithMaxIdAsync = exports.qa_QuestionsType_AddNewRecordAsync = exports.qa_QuestionsType_Delqa_QuestionsTypesByCondAsync = exports.qa_QuestionsType_Delqa_QuestionsTypesAsync = exports.qa_QuestionsType_DelRecordAsync = exports.qa_QuestionsType_GetObjLstByPagerAsync = exports.qa_QuestionsType_GetObjLstByPager_Cache = exports.qa_QuestionsType_GetObjLstByRange = exports.qa_QuestionsType_GetObjLstByRangeAsync = exports.qa_QuestionsType_GetTopObjLstAsync = exports.qa_QuestionsType_GetObjLstByQuestionsTypeIdLst_Cache = exports.qa_QuestionsType_GetObjLstByQuestionsTypeIdLstAsync = exports.qa_QuestionsType_GetSubObjLst_Cache = exports.qa_QuestionsType_GetObjLst_PureCache = exports.qa_QuestionsType_GetObjLst_Cache = exports.qa_QuestionsType_GetObjLst_sessionStorage_PureCache = exports.qa_QuestionsType_GetObjLst_sessionStorage = exports.qa_QuestionsType_GetObjLstAsync = exports.qa_QuestionsType_GetObjLst_localStorage_PureCache = exports.qa_QuestionsType_GetObjLst_localStorage = exports.qa_QuestionsType_GetObjLst_ClientCache = exports.qa_QuestionsType_GetFirstObjAsync = exports.qa_QuestionsType_GetFirstID = exports.qa_QuestionsType_GetFirstIDAsync = exports.qa_QuestionsType_FilterFunByKey = exports.qa_QuestionsType_SortFunByKey = exports.qa_QuestionsType_SortFun_Defa_2Fld = exports.qa_QuestionsType_SortFun_Defa = exports.qa_QuestionsType_func = exports.qa_QuestionsType_UpdateObjInLst_Cache = exports.qa_QuestionsType_GetObjByQuestionsTypeId_localStorage = exports.qa_QuestionsType_GetObjByQuestionsTypeId_Cache = exports.qa_QuestionsType_GetObjByQuestionsTypeIdAsync = exports.qa_QuestionsType_ConstructorName = exports.qa_QuestionsType_Controller = void 0;
    /**
     * 问题类型表(qa_QuestionsType)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsqa_QuestionsTypeEN_js_1 = require("../../L0_Entity/InteractManage/clsqa_QuestionsTypeEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.qa_QuestionsType_Controller = "qa_QuestionsTypeApi";
    exports.qa_QuestionsType_ConstructorName = "qa_QuestionsType";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strQuestionsTypeId:关键字
    * @returns 对象
    **/
    async function qa_QuestionsType_GetObjByQuestionsTypeIdAsync(strQuestionsTypeId) {
        const strThisFuncName = "GetObjByQuestionsTypeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionsTypeId]不能为空！(In GetObjByQuestionsTypeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionsTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionsTypeId]的长度:[{0}]不正确！", strQuestionsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByQuestionsTypeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strQuestionsTypeId": strQuestionsTypeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objqa_QuestionsType = qa_QuestionsType_GetObjFromJsonObj(returnObj);
                return objqa_QuestionsType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetObjByQuestionsTypeIdAsync = qa_QuestionsType_GetObjByQuestionsTypeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strQuestionsTypeId:所给的关键字
     * @returns 对象
    */
    async function qa_QuestionsType_GetObjByQuestionsTypeId_Cache(strQuestionsTypeId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByQuestionsTypeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionsTypeId]不能为空！(In GetObjByQuestionsTypeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionsTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionsTypeId]的长度:[{0}]不正确！", strQuestionsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
        try {
            const arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache.filter(x => x.questionsTypeId == strQuestionsTypeId);
            let objqa_QuestionsType;
            if (arrqa_QuestionsType_Sel.length > 0) {
                objqa_QuestionsType = arrqa_QuestionsType_Sel[0];
                return objqa_QuestionsType;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objqa_QuestionsType = await qa_QuestionsType_GetObjByQuestionsTypeIdAsync(strQuestionsTypeId);
                    if (objqa_QuestionsType != null) {
                        qa_QuestionsType_ReFreshThisCache();
                        return objqa_QuestionsType;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionsTypeId, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.qa_QuestionsType_GetObjByQuestionsTypeId_Cache = qa_QuestionsType_GetObjByQuestionsTypeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strQuestionsTypeId:所给的关键字
     * @returns 对象
    */
    async function qa_QuestionsType_GetObjByQuestionsTypeId_localStorage(strQuestionsTypeId) {
        const strThisFuncName = "GetObjByQuestionsTypeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionsTypeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionsTypeId]不能为空！(In GetObjByQuestionsTypeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionsTypeId.length != 2) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionsTypeId]的长度:[{0}]不正确！", strQuestionsTypeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName, strQuestionsTypeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objqa_QuestionsType_Cache = JSON.parse(strTempObj);
            return objqa_QuestionsType_Cache;
        }
        try {
            const objqa_QuestionsType = await qa_QuestionsType_GetObjByQuestionsTypeIdAsync(strQuestionsTypeId);
            if (objqa_QuestionsType != null) {
                localStorage.setItem(strKey, JSON.stringify(objqa_QuestionsType));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objqa_QuestionsType;
            }
            return objqa_QuestionsType;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionsTypeId, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.qa_QuestionsType_GetObjByQuestionsTypeId_localStorage = qa_QuestionsType_GetObjByQuestionsTypeId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objqa_QuestionsType:所给的对象
     * @returns 对象
    */
    async function qa_QuestionsType_UpdateObjInLst_Cache(objqa_QuestionsType) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
            const obj = arrqa_QuestionsTypeObjLst_Cache.find(x => x.questionsTypeId == objqa_QuestionsType.questionsTypeId);
            if (obj != null) {
                objqa_QuestionsType.questionsTypeId = obj.questionsTypeId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objqa_QuestionsType);
            }
            else {
                arrqa_QuestionsTypeObjLst_Cache.push(objqa_QuestionsType);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.qa_QuestionsType_UpdateObjInLst_Cache = qa_QuestionsType_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function qa_QuestionsType_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strQuestionsTypeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objqa_QuestionsType = await qa_QuestionsType_GetObjByQuestionsTypeId_Cache(strQuestionsTypeId);
        if (objqa_QuestionsType == null)
            return "";
        return objqa_QuestionsType.GetFldValue(strOutFldName).toString();
    }
    exports.qa_QuestionsType_func = qa_QuestionsType_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_QuestionsType_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.questionsTypeId.localeCompare(b.questionsTypeId);
    }
    exports.qa_QuestionsType_SortFun_Defa = qa_QuestionsType_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_QuestionsType_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionsTypeName == b.questionsTypeName)
            return a.memo.localeCompare(b.memo);
        else
            return a.questionsTypeName.localeCompare(b.questionsTypeName);
    }
    exports.qa_QuestionsType_SortFun_Defa_2Fld = qa_QuestionsType_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_QuestionsType_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId:
                    return (a, b) => {
                        return a.questionsTypeId.localeCompare(b.questionsTypeId);
                    };
                case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeName:
                    return (a, b) => {
                        return a.questionsTypeName.localeCompare(b.questionsTypeName);
                    };
                case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[qa_QuestionsType]中不存在！(in ${exports.qa_QuestionsType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId:
                    return (a, b) => {
                        return b.questionsTypeId.localeCompare(a.questionsTypeId);
                    };
                case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeName:
                    return (a, b) => {
                        return b.questionsTypeName.localeCompare(a.questionsTypeName);
                    };
                case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[qa_QuestionsType]中不存在！(in ${exports.qa_QuestionsType_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.qa_QuestionsType_SortFunByKey = qa_QuestionsType_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function qa_QuestionsType_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId:
                return (obj) => {
                    return obj.questionsTypeId === value;
                };
            case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeName:
                return (obj) => {
                    return obj.questionsTypeName === value;
                };
            case clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[qa_QuestionsType]中不存在！(in ${exports.qa_QuestionsType_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.qa_QuestionsType_FilterFunByKey = qa_QuestionsType_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function qa_QuestionsType_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetFirstIDAsync = qa_QuestionsType_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function qa_QuestionsType_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetFirstID = qa_QuestionsType_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function qa_QuestionsType_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objqa_QuestionsType = qa_QuestionsType_GetObjFromJsonObj(returnObj);
                return objqa_QuestionsType;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetFirstObjAsync = qa_QuestionsType_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
        clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrqa_QuestionsTypeExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrqa_QuestionsTypeObjLst_T = qa_QuestionsType_GetObjLstByJSONObjLst(arrqa_QuestionsTypeExObjLst_Cache);
            return arrqa_QuestionsTypeObjLst_T;
        }
        try {
            const arrqa_QuestionsTypeExObjLst = await qa_QuestionsType_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrqa_QuestionsTypeExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_QuestionsTypeExObjLst.length);
            console.log(strInfo);
            return arrqa_QuestionsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_QuestionsType_GetObjLst_ClientCache = qa_QuestionsType_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
        clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrqa_QuestionsTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrqa_QuestionsTypeObjLst_T = qa_QuestionsType_GetObjLstByJSONObjLst(arrqa_QuestionsTypeExObjLst_Cache);
            return arrqa_QuestionsTypeObjLst_T;
        }
        try {
            const arrqa_QuestionsTypeExObjLst = await qa_QuestionsType_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrqa_QuestionsTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_QuestionsTypeExObjLst.length);
            console.log(strInfo);
            return arrqa_QuestionsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_QuestionsType_GetObjLst_localStorage = qa_QuestionsType_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrqa_QuestionsTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrqa_QuestionsTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.qa_QuestionsType_GetObjLst_localStorage_PureCache = qa_QuestionsType_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function qa_QuestionsType_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_QuestionsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetObjLstAsync = qa_QuestionsType_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
        clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrqa_QuestionsTypeExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrqa_QuestionsTypeObjLst_T = qa_QuestionsType_GetObjLstByJSONObjLst(arrqa_QuestionsTypeExObjLst_Cache);
            return arrqa_QuestionsTypeObjLst_T;
        }
        try {
            const arrqa_QuestionsTypeExObjLst = await qa_QuestionsType_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrqa_QuestionsTypeExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_QuestionsTypeExObjLst.length);
            console.log(strInfo);
            return arrqa_QuestionsTypeExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_QuestionsType_GetObjLst_sessionStorage = qa_QuestionsType_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrqa_QuestionsTypeObjLst_Cache = JSON.parse(strTempObjLst);
            return arrqa_QuestionsTypeObjLst_Cache;
        }
        else
            return null;
    }
    exports.qa_QuestionsType_GetObjLst_sessionStorage_PureCache = qa_QuestionsType_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrqa_QuestionsTypeObjLst_Cache;
        switch (clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_ClientCache();
                break;
            default:
                arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_ClientCache();
                break;
        }
        const arrqa_QuestionsTypeObjLst = qa_QuestionsType_GetObjLstByJSONObjLst(arrqa_QuestionsTypeObjLst_Cache);
        return arrqa_QuestionsTypeObjLst_Cache;
    }
    exports.qa_QuestionsType_GetObjLst_Cache = qa_QuestionsType_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_QuestionsType_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrqa_QuestionsTypeObjLst_Cache;
        switch (clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheModeId) {
            case "04": //sessionStorage
                arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrqa_QuestionsTypeObjLst_Cache = null;
                break;
            default:
                arrqa_QuestionsTypeObjLst_Cache = null;
                break;
        }
        return arrqa_QuestionsTypeObjLst_Cache;
    }
    exports.qa_QuestionsType_GetObjLst_PureCache = qa_QuestionsType_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrQuestionsTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function qa_QuestionsType_GetSubObjLst_Cache(objqa_QuestionsType_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
        let arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache;
        if (objqa_QuestionsType_Cond.sf_FldComparisonOp == null || objqa_QuestionsType_Cond.sf_FldComparisonOp == "")
            return arrqa_QuestionsType_Sel;
        const dicFldComparisonOp = JSON.parse(objqa_QuestionsType_Cond.sf_FldComparisonOp);
        //console.log("clsqa_QuestionsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_QuestionsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_QuestionsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrqa_QuestionsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objqa_QuestionsType_Cond), exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_QuestionsType_GetSubObjLst_Cache = qa_QuestionsType_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrQuestionsTypeId:关键字列表
    * @returns 对象列表
    **/
    async function qa_QuestionsType_GetObjLstByQuestionsTypeIdLstAsync(arrQuestionsTypeId) {
        const strThisFuncName = "GetObjLstByQuestionsTypeIdLstAsync";
        const strAction = "GetObjLstByQuestionsTypeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionsTypeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_QuestionsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetObjLstByQuestionsTypeIdLstAsync = qa_QuestionsType_GetObjLstByQuestionsTypeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrQuestionsTypeIdLst:关键字列表
     * @returns 对象列表
    */
    async function qa_QuestionsType_GetObjLstByQuestionsTypeIdLst_Cache(arrQuestionsTypeIdLst) {
        const strThisFuncName = "GetObjLstByQuestionsTypeIdLst_Cache";
        try {
            const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
            const arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache.filter(x => arrQuestionsTypeIdLst.indexOf(x.questionsTypeId) > -1);
            return arrqa_QuestionsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrQuestionsTypeIdLst.join(","), exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_QuestionsType_GetObjLstByQuestionsTypeIdLst_Cache = qa_QuestionsType_GetObjLstByQuestionsTypeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function qa_QuestionsType_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_QuestionsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetTopObjLstAsync = qa_QuestionsType_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function qa_QuestionsType_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_QuestionsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetObjLstByRangeAsync = qa_QuestionsType_GetObjLstByRangeAsync;
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
    async function qa_QuestionsType_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetObjLstByRange = qa_QuestionsType_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function qa_QuestionsType_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
        if (arrqa_QuestionsTypeObjLst_Cache.length == 0)
            return arrqa_QuestionsTypeObjLst_Cache;
        let arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objqa_QuestionsType_Cond = new clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_QuestionsType_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsqa_QuestionsTypeWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_QuestionsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_QuestionsType_Sel.length == 0)
                return arrqa_QuestionsType_Sel;
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
                arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.sort(qa_QuestionsType_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.sort(objPagerPara.sortFun);
            }
            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.slice(intStart, intEnd);
            return arrqa_QuestionsType_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_QuestionsType_GetObjLstByPager_Cache = qa_QuestionsType_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function qa_QuestionsType_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_QuestionsType_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetObjLstByPagerAsync = qa_QuestionsType_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strQuestionsTypeId:关键字
    * @returns 获取删除的结果
    **/
    async function qa_QuestionsType_DelRecordAsync(strQuestionsTypeId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strQuestionsTypeId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strQuestionsTypeId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_DelRecordAsync = qa_QuestionsType_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrQuestionsTypeId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function qa_QuestionsType_Delqa_QuestionsTypesAsync(arrQuestionsTypeId) {
        const strThisFuncName = "Delqa_QuestionsTypesAsync";
        const strAction = "Delqa_QuestionsTypes";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionsTypeId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_Delqa_QuestionsTypesAsync = qa_QuestionsType_Delqa_QuestionsTypesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function qa_QuestionsType_Delqa_QuestionsTypesByCondAsync(strWhereCond) {
        const strThisFuncName = "Delqa_QuestionsTypesByCondAsync";
        const strAction = "Delqa_QuestionsTypesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_Delqa_QuestionsTypesByCondAsync = qa_QuestionsType_Delqa_QuestionsTypesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objqa_QuestionsTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function qa_QuestionsType_AddNewRecordAsync(objqa_QuestionsTypeEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objqa_QuestionsTypeEN.questionsTypeId === null || objqa_QuestionsTypeEN.questionsTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objqa_QuestionsTypeEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_QuestionsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_AddNewRecordAsync = qa_QuestionsType_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objqa_QuestionsTypeEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function qa_QuestionsType_AddNewRecordWithMaxIdAsync(objqa_QuestionsTypeEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_QuestionsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_AddNewRecordWithMaxIdAsync = qa_QuestionsType_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objqa_QuestionsTypeEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function qa_QuestionsType_AddNewRecordWithReturnKeyAsync(objqa_QuestionsTypeEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_QuestionsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_AddNewRecordWithReturnKeyAsync = qa_QuestionsType_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objqa_QuestionsTypeEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function qa_QuestionsType_AddNewRecordWithReturnKey(objqa_QuestionsTypeEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objqa_QuestionsTypeEN.questionsTypeId === null || objqa_QuestionsTypeEN.questionsTypeId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_QuestionsTypeEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_AddNewRecordWithReturnKey = qa_QuestionsType_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objqa_QuestionsTypeEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function qa_QuestionsType_UpdateRecordAsync(objqa_QuestionsTypeEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objqa_QuestionsTypeEN.sf_UpdFldSetStr === undefined || objqa_QuestionsTypeEN.sf_UpdFldSetStr === null || objqa_QuestionsTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_QuestionsTypeEN.questionsTypeId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_QuestionsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_UpdateRecordAsync = qa_QuestionsType_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objqa_QuestionsTypeEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function qa_QuestionsType_UpdateWithConditionAsync(objqa_QuestionsTypeEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objqa_QuestionsTypeEN.sf_UpdFldSetStr === undefined || objqa_QuestionsTypeEN.sf_UpdFldSetStr === null || objqa_QuestionsTypeEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_QuestionsTypeEN.questionsTypeId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        objqa_QuestionsTypeEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objqa_QuestionsTypeEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_UpdateWithConditionAsync = qa_QuestionsType_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrQuestionsTypeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function qa_QuestionsType_IsExistRecord_Cache(objqa_QuestionsType_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
        if (arrqa_QuestionsTypeObjLst_Cache == null)
            return false;
        let arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache;
        if (objqa_QuestionsType_Cond.sf_FldComparisonOp == null || objqa_QuestionsType_Cond.sf_FldComparisonOp == "")
            return arrqa_QuestionsType_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objqa_QuestionsType_Cond.sf_FldComparisonOp);
        //console.log("clsqa_QuestionsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_QuestionsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_QuestionsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_QuestionsType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objqa_QuestionsType_Cond), exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.qa_QuestionsType_IsExistRecord_Cache = qa_QuestionsType_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function qa_QuestionsType_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_IsExistRecordAsync = qa_QuestionsType_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strQuestionsTypeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function qa_QuestionsType_IsExist(strQuestionsTypeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "QuestionsTypeId": strQuestionsTypeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_IsExist = qa_QuestionsType_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strQuestionsTypeId:所给的关键字
     * @returns 对象
    */
    async function qa_QuestionsType_IsExist_Cache(strQuestionsTypeId) {
        const strThisFuncName = "IsExist_Cache";
        const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
        if (arrqa_QuestionsTypeObjLst_Cache == null)
            return false;
        try {
            const arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache.filter(x => x.questionsTypeId == strQuestionsTypeId);
            if (arrqa_QuestionsType_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strQuestionsTypeId, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.qa_QuestionsType_IsExist_Cache = qa_QuestionsType_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strQuestionsTypeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function qa_QuestionsType_IsExistAsync(strQuestionsTypeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strQuestionsTypeId": strQuestionsTypeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_IsExistAsync = qa_QuestionsType_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function qa_QuestionsType_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetRecCountByCondAsync = qa_QuestionsType_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objqa_QuestionsType_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function qa_QuestionsType_GetRecCountByCond_Cache(objqa_QuestionsType_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrqa_QuestionsTypeObjLst_Cache = await qa_QuestionsType_GetObjLst_Cache();
        if (arrqa_QuestionsTypeObjLst_Cache == null)
            return 0;
        let arrqa_QuestionsType_Sel = arrqa_QuestionsTypeObjLst_Cache;
        if (objqa_QuestionsType_Cond.sf_FldComparisonOp == null || objqa_QuestionsType_Cond.sf_FldComparisonOp == "")
            return arrqa_QuestionsType_Sel.length;
        const dicFldComparisonOp = JSON.parse(objqa_QuestionsType_Cond.sf_FldComparisonOp);
        //console.log("clsqa_QuestionsTypeWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_QuestionsType_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_QuestionsType_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_QuestionsType_Sel = arrqa_QuestionsType_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrqa_QuestionsType_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objqa_QuestionsType_Cond), exports.qa_QuestionsType_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.qa_QuestionsType_GetRecCountByCond_Cache = qa_QuestionsType_GetRecCountByCond_Cache;
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
    async function qa_QuestionsType_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_QuestionsType_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_QuestionsType_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_QuestionsType_GetMaxStrIdByPrefix = qa_QuestionsType_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function qa_QuestionsType_GetWebApiUrl(strController, strAction) {
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
    exports.qa_QuestionsType_GetWebApiUrl = qa_QuestionsType_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function qa_QuestionsType_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
        switch (clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheModeId) {
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
    exports.qa_QuestionsType_ReFreshCache = qa_QuestionsType_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function qa_QuestionsType_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN._CurrTabName;
            switch (clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.CacheModeId) {
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
    exports.qa_QuestionsType_ReFreshThisCache = qa_QuestionsType_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function qa_QuestionsType_CheckPropertyNew(pobjqa_QuestionsTypeEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjqa_QuestionsTypeEN.questionsTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[问题类型Id(questionsTypeId)]的长度不能超过2(In 问题类型表(qa_QuestionsType))!值:$(pobjqa_QuestionsTypeEN.questionsTypeId)(clsqa_QuestionsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjqa_QuestionsTypeEN.questionsTypeName) > 50) {
            throw new Error("(errid:Watl000059)字段[问题类型名称(questionsTypeName)]的长度不能超过50(In 问题类型表(qa_QuestionsType))!值:$(pobjqa_QuestionsTypeEN.questionsTypeName)(clsqa_QuestionsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjqa_QuestionsTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 问题类型表(qa_QuestionsType))!值:$(pobjqa_QuestionsTypeEN.memo)(clsqa_QuestionsTypeBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeId) == false && undefined !== pobjqa_QuestionsTypeEN.questionsTypeId && jsString_js_1.tzDataType.isString(pobjqa_QuestionsTypeEN.questionsTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[问题类型Id(questionsTypeId)]的值:[$(pobjqa_QuestionsTypeEN.questionsTypeId)], 非法，应该为字符型(In 问题类型表(qa_QuestionsType))!(clsqa_QuestionsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeName) == false && undefined !== pobjqa_QuestionsTypeEN.questionsTypeName && jsString_js_1.tzDataType.isString(pobjqa_QuestionsTypeEN.questionsTypeName) === false) {
            throw new Error("(errid:Watl000060)字段[问题类型名称(questionsTypeName)]的值:[$(pobjqa_QuestionsTypeEN.questionsTypeName)], 非法，应该为字符型(In 问题类型表(qa_QuestionsType))!(clsqa_QuestionsTypeBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.memo) == false && undefined !== pobjqa_QuestionsTypeEN.memo && jsString_js_1.tzDataType.isString(pobjqa_QuestionsTypeEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjqa_QuestionsTypeEN.memo)], 非法，应该为字符型(In 问题类型表(qa_QuestionsType))!(clsqa_QuestionsTypeBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjqa_QuestionsTypeEN.SetIsCheckProperty(true);
    }
    exports.qa_QuestionsType_CheckPropertyNew = qa_QuestionsType_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function qa_QuestionsType_CheckProperty4Update(pobjqa_QuestionsTypeEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjqa_QuestionsTypeEN.questionsTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[问题类型Id(questionsTypeId)]的长度不能超过2(In 问题类型表(qa_QuestionsType))!值:$(pobjqa_QuestionsTypeEN.questionsTypeId)(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeName) == false && (0, clsString_js_1.GetStrLen)(pobjqa_QuestionsTypeEN.questionsTypeName) > 50) {
            throw new Error("(errid:Watl000062)字段[问题类型名称(questionsTypeName)]的长度不能超过50(In 问题类型表(qa_QuestionsType))!值:$(pobjqa_QuestionsTypeEN.questionsTypeName)(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjqa_QuestionsTypeEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 问题类型表(qa_QuestionsType))!值:$(pobjqa_QuestionsTypeEN.memo)(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeId) == false && undefined !== pobjqa_QuestionsTypeEN.questionsTypeId && jsString_js_1.tzDataType.isString(pobjqa_QuestionsTypeEN.questionsTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[问题类型Id(questionsTypeId)]的值:[$(pobjqa_QuestionsTypeEN.questionsTypeId)], 非法，应该为字符型(In 问题类型表(qa_QuestionsType))!(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeName) == false && undefined !== pobjqa_QuestionsTypeEN.questionsTypeName && jsString_js_1.tzDataType.isString(pobjqa_QuestionsTypeEN.questionsTypeName) === false) {
            throw new Error("(errid:Watl000063)字段[问题类型名称(questionsTypeName)]的值:[$(pobjqa_QuestionsTypeEN.questionsTypeName)], 非法，应该为字符型(In 问题类型表(qa_QuestionsType))!(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.memo) == false && undefined !== pobjqa_QuestionsTypeEN.memo && jsString_js_1.tzDataType.isString(pobjqa_QuestionsTypeEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjqa_QuestionsTypeEN.memo)], 非法，应该为字符型(In 问题类型表(qa_QuestionsType))!(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjqa_QuestionsTypeEN.questionsTypeId) === true) {
            throw new Error("(errid:Watl000064)字段[问题类型Id]不能为空(In 问题类型表)!(clsqa_QuestionsTypeBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjqa_QuestionsTypeEN.SetIsCheckProperty(true);
    }
    exports.qa_QuestionsType_CheckProperty4Update = qa_QuestionsType_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function qa_QuestionsType_GetJSONStrByObj(pobjqa_QuestionsTypeEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjqa_QuestionsTypeEN.sf_UpdFldSetStr = pobjqa_QuestionsTypeEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjqa_QuestionsTypeEN);
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
    exports.qa_QuestionsType_GetJSONStrByObj = qa_QuestionsType_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function qa_QuestionsType_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrqa_QuestionsTypeObjLst = new Array();
        if (strJSON === "") {
            return arrqa_QuestionsTypeObjLst;
        }
        try {
            arrqa_QuestionsTypeObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrqa_QuestionsTypeObjLst;
        }
        return arrqa_QuestionsTypeObjLst;
    }
    exports.qa_QuestionsType_GetObjLstByJSONStr = qa_QuestionsType_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrqa_QuestionsTypeObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function qa_QuestionsType_GetObjLstByJSONObjLst(arrqa_QuestionsTypeObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrqa_QuestionsTypeObjLst = new Array();
        for (const objInFor of arrqa_QuestionsTypeObjLstS) {
            const obj1 = qa_QuestionsType_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrqa_QuestionsTypeObjLst.push(obj1);
        }
        return arrqa_QuestionsTypeObjLst;
    }
    exports.qa_QuestionsType_GetObjLstByJSONObjLst = qa_QuestionsType_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function qa_QuestionsType_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjqa_QuestionsTypeEN = new clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN();
        if (strJSON === "") {
            return pobjqa_QuestionsTypeEN;
        }
        try {
            pobjqa_QuestionsTypeEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjqa_QuestionsTypeEN;
        }
        return pobjqa_QuestionsTypeEN;
    }
    exports.qa_QuestionsType_GetObjByJSONStr = qa_QuestionsType_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function qa_QuestionsType_GetCombineCondition(objqa_QuestionsType_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objqa_QuestionsType_Cond.dicFldComparisonOp, clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId) == true) {
            const strComparisonOp_QuestionsTypeId = objqa_QuestionsType_Cond.dicFldComparisonOp[clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeId, objqa_QuestionsType_Cond.questionsTypeId, strComparisonOp_QuestionsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_QuestionsType_Cond.dicFldComparisonOp, clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeName) == true) {
            const strComparisonOp_QuestionsTypeName = objqa_QuestionsType_Cond.dicFldComparisonOp[clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_QuestionsTypeName, objqa_QuestionsType_Cond.questionsTypeName, strComparisonOp_QuestionsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_QuestionsType_Cond.dicFldComparisonOp, clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_Memo) == true) {
            const strComparisonOp_Memo = objqa_QuestionsType_Cond.dicFldComparisonOp[clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN.con_Memo, objqa_QuestionsType_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.qa_QuestionsType_GetCombineCondition = qa_QuestionsType_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--qa_QuestionsType(问题类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strQuestionsTypeId: 问题类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function qa_QuestionsType_GetUniCondStr_QuestionsTypeId(objqa_QuestionsTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and QuestionsTypeId = '{0}'", objqa_QuestionsTypeEN.questionsTypeId);
        return strWhereCond;
    }
    exports.qa_QuestionsType_GetUniCondStr_QuestionsTypeId = qa_QuestionsType_GetUniCondStr_QuestionsTypeId;
    /**
    *获取唯一性条件串(Uniqueness)--qa_QuestionsType(问题类型表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strQuestionsTypeId: 问题类型Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function qa_QuestionsType_GetUniCondStr4Update_QuestionsTypeId(objqa_QuestionsTypeEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and QuestionsTypeId <> '{0}'", objqa_QuestionsTypeEN.questionsTypeId);
        strWhereCond += (0, clsString_js_1.Format)(" and QuestionsTypeId = '{0}'", objqa_QuestionsTypeEN.questionsTypeId);
        return strWhereCond;
    }
    exports.qa_QuestionsType_GetUniCondStr4Update_QuestionsTypeId = qa_QuestionsType_GetUniCondStr4Update_QuestionsTypeId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objqa_QuestionsTypeENS:源对象
     * @param objqa_QuestionsTypeENT:目标对象
    */
    function qa_QuestionsType_CopyObjTo(objqa_QuestionsTypeENS, objqa_QuestionsTypeENT) {
        objqa_QuestionsTypeENT.questionsTypeId = objqa_QuestionsTypeENS.questionsTypeId; //问题类型Id
        objqa_QuestionsTypeENT.questionsTypeName = objqa_QuestionsTypeENS.questionsTypeName; //问题类型名称
        objqa_QuestionsTypeENT.memo = objqa_QuestionsTypeENS.memo; //备注
        objqa_QuestionsTypeENT.sf_UpdFldSetStr = objqa_QuestionsTypeENS.updFldString; //sf_UpdFldSetStr
    }
    exports.qa_QuestionsType_CopyObjTo = qa_QuestionsType_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objqa_QuestionsTypeENS:源对象
     * @param objqa_QuestionsTypeENT:目标对象
    */
    function qa_QuestionsType_GetObjFromJsonObj(objqa_QuestionsTypeENS) {
        const objqa_QuestionsTypeENT = new clsqa_QuestionsTypeEN_js_1.clsqa_QuestionsTypeEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_QuestionsTypeENT, objqa_QuestionsTypeENS);
        return objqa_QuestionsTypeENT;
    }
    exports.qa_QuestionsType_GetObjFromJsonObj = qa_QuestionsType_GetObjFromJsonObj;
});
