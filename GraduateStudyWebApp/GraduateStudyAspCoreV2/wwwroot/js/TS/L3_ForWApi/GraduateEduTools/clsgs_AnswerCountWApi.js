/**
* 类名:clsgs_AnswerCountWApi
* 表名:gs_AnswerCount(01120767)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:39
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_AnswerCount_GetObjFromJsonObj = exports.gs_AnswerCount_CopyObjTo = exports.gs_AnswerCount_GetUniCondStr4Update_AnswerCountId = exports.gs_AnswerCount_GetUniCondStr_AnswerCountId = exports.gs_AnswerCount_GetCombineCondition = exports.gs_AnswerCount_GetObjByJSONStr = exports.gs_AnswerCount_GetObjLstByJSONObjLst = exports.gs_AnswerCount_GetObjLstByJSONStr = exports.gs_AnswerCount_GetJSONStrByObj = exports.gs_AnswerCount_CheckProperty4Update = exports.gs_AnswerCount_CheckPropertyNew = exports.gs_AnswerCount_ReFreshThisCache = exports.gs_AnswerCount_ReFreshCache = exports.gs_AnswerCount_GetWebApiUrl = exports.gs_AnswerCount_GetMaxStrIdByPrefix = exports.gs_AnswerCount_GetMaxStrIdAsync = exports.gs_AnswerCount_GetRecCountByCond_Cache = exports.gs_AnswerCount_GetRecCountByCondAsync = exports.gs_AnswerCount_IsExistAsync = exports.gs_AnswerCount_IsExist_Cache = exports.gs_AnswerCount_IsExist = exports.gs_AnswerCount_IsExistRecordAsync = exports.gs_AnswerCount_IsExistRecord_Cache = exports.gs_AnswerCount_UpdateWithConditionAsync = exports.gs_AnswerCount_UpdateRecordAsync = exports.gs_AnswerCount_AddNewRecordWithReturnKey = exports.gs_AnswerCount_AddNewRecordWithReturnKeyAsync = exports.gs_AnswerCount_AddNewRecordWithMaxIdAsync = exports.gs_AnswerCount_AddNewRecordAsync = exports.gs_AnswerCount_Delgs_AnswerCountsByCondAsync = exports.gs_AnswerCount_Delgs_AnswerCountsAsync = exports.gs_AnswerCount_DelRecordAsync = exports.gs_AnswerCount_GetObjLstByPagerAsync = exports.gs_AnswerCount_GetObjLstByPager_Cache = exports.gs_AnswerCount_GetObjLstByRange = exports.gs_AnswerCount_GetObjLstByRangeAsync = exports.gs_AnswerCount_GetTopObjLstAsync = exports.gs_AnswerCount_GetObjLstByAnswerCountIdLst_Cache = exports.gs_AnswerCount_GetObjLstByAnswerCountIdLstAsync = exports.gs_AnswerCount_GetSubObjLst_Cache = exports.gs_AnswerCount_GetObjLst_PureCache = exports.gs_AnswerCount_GetObjLst_Cache = exports.gs_AnswerCount_GetObjLst_sessionStorage_PureCache = exports.gs_AnswerCount_GetObjLst_sessionStorage = exports.gs_AnswerCount_GetObjLstAsync = exports.gs_AnswerCount_GetObjLst_localStorage_PureCache = exports.gs_AnswerCount_GetObjLst_localStorage = exports.gs_AnswerCount_GetObjLst_ClientCache = exports.gs_AnswerCount_GetFirstObjAsync = exports.gs_AnswerCount_GetFirstID = exports.gs_AnswerCount_GetFirstIDAsync = exports.gs_AnswerCount_funcKey = exports.gs_AnswerCount_FilterFunByKey = exports.gs_AnswerCount_SortFunByKey = exports.gs_AnswerCount_SortFun_Defa_2Fld = exports.gs_AnswerCount_SortFun_Defa = exports.gs_AnswerCount_func = exports.gs_AnswerCount_UpdateObjInLst_Cache = exports.gs_AnswerCount_GetObjByAnswerCountId_localStorage = exports.gs_AnswerCount_GetObjByAnswerCountId_Cache = exports.gs_AnswerCount_GetObjByAnswerCountIdAsync = exports.gs_AnswerCount_ConstructorName = exports.gs_AnswerCount_Controller = void 0;
    /**
     * 问题讨论回答统计(gs_AnswerCount)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_AnswerCountEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsgs_AnswerCountEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.gs_AnswerCount_Controller = "gs_AnswerCountApi";
    exports.gs_AnswerCount_ConstructorName = "gs_AnswerCount";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strAnswerCountId:关键字
    * @returns 对象
    **/
    async function gs_AnswerCount_GetObjByAnswerCountIdAsync(strAnswerCountId) {
        const strThisFuncName = "GetObjByAnswerCountIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strAnswerCountId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strAnswerCountId]不能为空！(In clsgs_AnswerCountWApi.GetObjByAnswerCountIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerCountId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strAnswerCountId]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.GetObjByAnswerCountIdAsync)", strAnswerCountId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByAnswerCountId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strAnswerCountId": strAnswerCountId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objgs_AnswerCount = gs_AnswerCount_GetObjFromJsonObj(returnObj);
                return objgs_AnswerCount;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetObjByAnswerCountIdAsync = gs_AnswerCount_GetObjByAnswerCountIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strAnswerCountId:所给的关键字
     * @returns 对象
    */
    async function gs_AnswerCount_GetObjByAnswerCountId_Cache(strAnswerCountId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByAnswerCountId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strAnswerCountId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strAnswerCountId]不能为空！(In clsgs_AnswerCountWApi.GetObjByAnswerCountId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerCountId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strAnswerCountId]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.GetObjByAnswerCountId_Cache)", strAnswerCountId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache.filter(x => x.answerCountId == strAnswerCountId);
            let objgs_AnswerCount;
            if (arrgs_AnswerCount_Sel.length > 0) {
                objgs_AnswerCount = arrgs_AnswerCount_Sel[0];
                return objgs_AnswerCount;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objgs_AnswerCount_Const = await gs_AnswerCount_GetObjByAnswerCountIdAsync(strAnswerCountId);
                    if (objgs_AnswerCount_Const != null) {
                        gs_AnswerCount_ReFreshThisCache(strid_CurrEduCls);
                        return objgs_AnswerCount_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerCountId, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_AnswerCount_GetObjByAnswerCountId_Cache = gs_AnswerCount_GetObjByAnswerCountId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strAnswerCountId:所给的关键字
     * @returns 对象
    */
    async function gs_AnswerCount_GetObjByAnswerCountId_localStorage(strAnswerCountId) {
        const strThisFuncName = "GetObjByAnswerCountId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strAnswerCountId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strAnswerCountId]不能为空！(In clsgs_AnswerCountWApi.GetObjByAnswerCountId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerCountId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strAnswerCountId]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.GetObjByAnswerCountId_localStorage)", strAnswerCountId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strAnswerCountId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_AnswerCount_Cache = JSON.parse(strTempObj);
            return objgs_AnswerCount_Cache;
        }
        try {
            const objgs_AnswerCount = await gs_AnswerCount_GetObjByAnswerCountIdAsync(strAnswerCountId);
            if (objgs_AnswerCount != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_AnswerCount));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_AnswerCount;
            }
            return objgs_AnswerCount;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerCountId, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_AnswerCount_GetObjByAnswerCountId_localStorage = gs_AnswerCount_GetObjByAnswerCountId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_AnswerCount:所给的对象
     * @returns 对象
    */
    async function gs_AnswerCount_UpdateObjInLst_Cache(objgs_AnswerCount, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrgs_AnswerCountObjLst_Cache.find(x => x.answerCountId == objgs_AnswerCount.answerCountId);
            if (obj != null) {
                objgs_AnswerCount.answerCountId = obj.answerCountId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_AnswerCount);
            }
            else {
                arrgs_AnswerCountObjLst_Cache.push(objgs_AnswerCount);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_AnswerCount_UpdateObjInLst_Cache = gs_AnswerCount_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function gs_AnswerCount_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_AnswerCountWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strAnswerCountId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_AnswerCount = await gs_AnswerCount_GetObjByAnswerCountId_Cache(strAnswerCountId, strid_CurrEduCls_C);
        if (objgs_AnswerCount == null)
            return "";
        if (objgs_AnswerCount.GetFldValue(strOutFldName) == null)
            return "";
        return objgs_AnswerCount.GetFldValue(strOutFldName).toString();
    }
    exports.gs_AnswerCount_func = gs_AnswerCount_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_AnswerCount_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.answerCountId.localeCompare(b.answerCountId);
    }
    exports.gs_AnswerCount_SortFun_Defa = gs_AnswerCount_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_AnswerCount_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.memo == b.memo)
            return a.dataUser.localeCompare(b.dataUser);
        else
            return a.memo.localeCompare(b.memo);
    }
    exports.gs_AnswerCount_SortFun_Defa_2Fld = gs_AnswerCount_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_AnswerCount_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId:
                    return (a, b) => {
                        return a.answerCountId.localeCompare(b.answerCountId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataUser:
                    return (a, b) => {
                        if (a.dataUser == null)
                            return -1;
                        if (b.dataUser == null)
                            return 1;
                        return a.dataUser.localeCompare(b.dataUser);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate:
                    return (a, b) => {
                        if (a.dataAddDate == null)
                            return -1;
                        if (b.dataAddDate == null)
                            return 1;
                        return a.dataAddDate.localeCompare(b.dataAddDate);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Month:
                    return (a, b) => {
                        return a.month - b.month;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Week:
                    return (a, b) => {
                        return a.week - b.week;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_WeekTimeRange:
                    return (a, b) => {
                        if (a.weekTimeRange == null)
                            return -1;
                        if (b.weekTimeRange == null)
                            return 1;
                        return a.weekTimeRange.localeCompare(b.weekTimeRange);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_IsRecommend:
                    return (a, b) => {
                        if (a.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerId:
                    return (a, b) => {
                        if (a.answerId == null)
                            return -1;
                        if (b.answerId == null)
                            return 1;
                        return a.answerId.localeCompare(b.answerId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (a.answerTypeId == null)
                            return -1;
                        if (b.answerTypeId == null)
                            return 1;
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_QuestionsId:
                    return (a, b) => {
                        if (a.questionsId == null)
                            return -1;
                        if (b.questionsId == null)
                            return 1;
                        return a.questionsId.localeCompare(b.questionsId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerContent:
                    return (a, b) => {
                        if (a.answerContent == null)
                            return -1;
                        if (b.answerContent == null)
                            return 1;
                        return a.answerContent.localeCompare(b.answerContent);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_ScoreType:
                    return (a, b) => {
                        if (a.scoreType == null)
                            return -1;
                        if (b.scoreType == null)
                            return 1;
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_AnswerCount]中不存在！(in ${exports.gs_AnswerCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId:
                    return (a, b) => {
                        return b.answerCountId.localeCompare(a.answerCountId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataUser:
                    return (a, b) => {
                        if (b.dataUser == null)
                            return -1;
                        if (a.dataUser == null)
                            return 1;
                        return b.dataUser.localeCompare(a.dataUser);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate:
                    return (a, b) => {
                        if (b.dataAddDate == null)
                            return -1;
                        if (a.dataAddDate == null)
                            return 1;
                        return b.dataAddDate.localeCompare(a.dataAddDate);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Month:
                    return (a, b) => {
                        return b.month - a.month;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Week:
                    return (a, b) => {
                        return b.week - a.week;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_WeekTimeRange:
                    return (a, b) => {
                        if (b.weekTimeRange == null)
                            return -1;
                        if (a.weekTimeRange == null)
                            return 1;
                        return b.weekTimeRange.localeCompare(a.weekTimeRange);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_IsRecommend:
                    return (a, b) => {
                        if (b.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerId:
                    return (a, b) => {
                        if (b.answerId == null)
                            return -1;
                        if (a.answerId == null)
                            return 1;
                        return b.answerId.localeCompare(a.answerId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (b.answerTypeId == null)
                            return -1;
                        if (a.answerTypeId == null)
                            return 1;
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_QuestionsId:
                    return (a, b) => {
                        if (b.questionsId == null)
                            return -1;
                        if (a.questionsId == null)
                            return 1;
                        return b.questionsId.localeCompare(a.questionsId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerContent:
                    return (a, b) => {
                        if (b.answerContent == null)
                            return -1;
                        if (a.answerContent == null)
                            return 1;
                        return b.answerContent.localeCompare(a.answerContent);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_ScoreType:
                    return (a, b) => {
                        if (b.scoreType == null)
                            return -1;
                        if (a.scoreType == null)
                            return 1;
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_AnswerCount]中不存在！(in ${exports.gs_AnswerCount_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_AnswerCount_SortFunByKey = gs_AnswerCount_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_AnswerCount_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId:
                return (obj) => {
                    return obj.answerCountId === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataUser:
                return (obj) => {
                    return obj.dataUser === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate:
                return (obj) => {
                    return obj.dataAddDate === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Week:
                return (obj) => {
                    return obj.week === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_WeekTimeRange:
                return (obj) => {
                    return obj.weekTimeRange === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_IsRecommend:
                return (obj) => {
                    return obj.isRecommend === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerId:
                return (obj) => {
                    return obj.answerId === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_QuestionsId:
                return (obj) => {
                    return obj.questionsId === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerContent:
                return (obj) => {
                    return obj.answerContent === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_AnswerCount]中不存在！(in ${exports.gs_AnswerCount_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_AnswerCount_FilterFunByKey = gs_AnswerCount_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function gs_AnswerCount_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsgs_AnswerCountWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrgs_AnswerCount = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrgs_AnswerCount == null)
            return [];
        let arrgs_AnswerCount_Sel = arrgs_AnswerCount;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrgs_AnswerCount_Sel.length == 0)
            return [];
        return arrgs_AnswerCount_Sel.map(x => x.answerCountId);
    }
    exports.gs_AnswerCount_funcKey = gs_AnswerCount_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_AnswerCount_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetFirstIDAsync = gs_AnswerCount_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_AnswerCount_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetFirstID = gs_AnswerCount_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_AnswerCount_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const objgs_AnswerCount = gs_AnswerCount_GetObjFromJsonObj(returnObj);
                return objgs_AnswerCount;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetFirstObjAsync = gs_AnswerCount_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_AnswerCountExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrgs_AnswerCountObjLst_T = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountExObjLst_Cache);
            return arrgs_AnswerCountObjLst_T;
        }
        try {
            const arrgs_AnswerCountExObjLst = await gs_AnswerCount_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrgs_AnswerCountExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_AnswerCountExObjLst.length);
            console.log(strInfo);
            return arrgs_AnswerCountExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_AnswerCount_GetObjLst_ClientCache = gs_AnswerCount_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_AnswerCountExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_AnswerCountObjLst_T = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountExObjLst_Cache);
            return arrgs_AnswerCountObjLst_T;
        }
        try {
            const arrgs_AnswerCountExObjLst = await gs_AnswerCount_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_AnswerCountExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_AnswerCountExObjLst.length);
            console.log(strInfo);
            return arrgs_AnswerCountExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_AnswerCount_GetObjLst_localStorage = gs_AnswerCount_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_AnswerCountObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_AnswerCountObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_AnswerCount_GetObjLst_localStorage_PureCache = gs_AnswerCount_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_AnswerCount_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetObjLstAsync = gs_AnswerCount_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_AnswerCountExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_AnswerCountObjLst_T = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountExObjLst_Cache);
            return arrgs_AnswerCountObjLst_T;
        }
        try {
            const arrgs_AnswerCountExObjLst = await gs_AnswerCount_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_AnswerCountExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_AnswerCountExObjLst.length);
            console.log(strInfo);
            return arrgs_AnswerCountExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_AnswerCount_GetObjLst_sessionStorage = gs_AnswerCount_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_AnswerCountObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_AnswerCountObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_AnswerCount_GetObjLst_sessionStorage_PureCache = gs_AnswerCount_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsgs_AnswerCountWApi.gs_AnswerCount_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsgs_AnswerCountWApi.gs_AnswerCount_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_AnswerCountObjLst_Cache;
        switch (clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrgs_AnswerCountObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountObjLst_Cache);
        return arrgs_AnswerCountObjLst_Cache;
    }
    exports.gs_AnswerCount_GetObjLst_Cache = gs_AnswerCount_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_AnswerCount_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_AnswerCountObjLst_Cache;
        switch (clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrgs_AnswerCountObjLst_Cache = null;
                break;
            default:
                arrgs_AnswerCountObjLst_Cache = null;
                break;
        }
        return arrgs_AnswerCountObjLst_Cache;
    }
    exports.gs_AnswerCount_GetObjLst_PureCache = gs_AnswerCount_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrAnswerCountId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_AnswerCount_GetSubObjLst_Cache(objgs_AnswerCount_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
        let arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache;
        if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "")
            return arrgs_AnswerCount_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
        //console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_AnswerCount_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_AnswerCount_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_AnswerCount_Cond), exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_AnswerCount_GetSubObjLst_Cache = gs_AnswerCount_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrAnswerCountId:关键字列表
    * @returns 对象列表
    **/
    async function gs_AnswerCount_GetObjLstByAnswerCountIdLstAsync(arrAnswerCountId) {
        const strThisFuncName = "GetObjLstByAnswerCountIdLstAsync";
        const strAction = "GetObjLstByAnswerCountIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerCountId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetObjLstByAnswerCountIdLstAsync = gs_AnswerCount_GetObjLstByAnswerCountIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrAnswerCountIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_AnswerCount_GetObjLstByAnswerCountIdLst_Cache(arrAnswerCountIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByAnswerCountIdLst_Cache";
        try {
            const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
            const arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache.filter(x => arrAnswerCountIdLst.indexOf(x.answerCountId) > -1);
            return arrgs_AnswerCount_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerCountIdLst.join(","), exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.gs_AnswerCount_GetObjLstByAnswerCountIdLst_Cache = gs_AnswerCount_GetObjLstByAnswerCountIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_AnswerCount_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetTopObjLstAsync = gs_AnswerCount_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_AnswerCount_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetObjLstByRangeAsync = gs_AnswerCount_GetObjLstByRangeAsync;
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
    async function gs_AnswerCount_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetObjLstByRange = gs_AnswerCount_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_AnswerCount_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_AnswerCountObjLst_Cache.length == 0)
            return arrgs_AnswerCountObjLst_Cache;
        let arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_AnswerCount_Cond = new clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_AnswerCount_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_AnswerCountWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_AnswerCount_Sel.length == 0)
                return arrgs_AnswerCount_Sel;
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
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(gs_AnswerCount_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.slice(intStart, intEnd);
            return arrgs_AnswerCount_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_AnswerCount_GetObjLstByPager_Cache = gs_AnswerCount_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_AnswerCount_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_AnswerCount_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetObjLstByPagerAsync = gs_AnswerCount_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strAnswerCountId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_AnswerCount_DelRecordAsync(strAnswerCountId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strAnswerCountId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_DelRecordAsync = gs_AnswerCount_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrAnswerCountId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_AnswerCount_Delgs_AnswerCountsAsync(arrAnswerCountId) {
        const strThisFuncName = "Delgs_AnswerCountsAsync";
        const strAction = "Delgs_AnswerCounts";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerCountId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_Delgs_AnswerCountsAsync = gs_AnswerCount_Delgs_AnswerCountsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_AnswerCount_Delgs_AnswerCountsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_AnswerCountsByCondAsync";
        const strAction = "Delgs_AnswerCountsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_Delgs_AnswerCountsByCondAsync = gs_AnswerCount_Delgs_AnswerCountsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_AnswerCountEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_AnswerCount_AddNewRecordAsync(objgs_AnswerCountEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_AnswerCountEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_AnswerCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_AddNewRecordAsync = gs_AnswerCount_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_AnswerCountEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_AnswerCount_AddNewRecordWithMaxIdAsync(objgs_AnswerCountEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_AnswerCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_AddNewRecordWithMaxIdAsync = gs_AnswerCount_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_AnswerCountEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_AnswerCount_AddNewRecordWithReturnKeyAsync(objgs_AnswerCountEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_AnswerCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_AddNewRecordWithReturnKeyAsync = gs_AnswerCount_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_AnswerCountEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_AnswerCount_AddNewRecordWithReturnKey(objgs_AnswerCountEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_AnswerCountEN.answerCountId === null || objgs_AnswerCountEN.answerCountId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_AnswerCountEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_AddNewRecordWithReturnKey = gs_AnswerCount_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_AnswerCountEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_AnswerCount_UpdateRecordAsync(objgs_AnswerCountEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_AnswerCountEN.sf_UpdFldSetStr === undefined || objgs_AnswerCountEN.sf_UpdFldSetStr === null || objgs_AnswerCountEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_AnswerCountEN.answerCountId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_AnswerCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_UpdateRecordAsync = gs_AnswerCount_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_AnswerCountEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_AnswerCount_UpdateWithConditionAsync(objgs_AnswerCountEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_AnswerCountEN.sf_UpdFldSetStr === undefined || objgs_AnswerCountEN.sf_UpdFldSetStr === null || objgs_AnswerCountEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_AnswerCountEN.answerCountId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        objgs_AnswerCountEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_AnswerCountEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_UpdateWithConditionAsync = gs_AnswerCount_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrAnswerCountId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_AnswerCount_IsExistRecord_Cache(objgs_AnswerCount_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_AnswerCountObjLst_Cache == null)
            return false;
        let arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache;
        if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "")
            return arrgs_AnswerCount_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
        //console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_AnswerCount_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_AnswerCount_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_AnswerCount_Cond), exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_AnswerCount_IsExistRecord_Cache = gs_AnswerCount_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_AnswerCount_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_IsExistRecordAsync = gs_AnswerCount_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strAnswerCountId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_AnswerCount_IsExist(strAnswerCountId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "AnswerCountId": strAnswerCountId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_IsExist = gs_AnswerCount_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strAnswerCountId:所给的关键字
     * @returns 对象
    */
    async function gs_AnswerCount_IsExist_Cache(strAnswerCountId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_AnswerCountObjLst_Cache == null)
            return false;
        try {
            const arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache.filter(x => x.answerCountId == strAnswerCountId);
            if (arrgs_AnswerCount_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strAnswerCountId, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_AnswerCount_IsExist_Cache = gs_AnswerCount_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strAnswerCountId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_AnswerCount_IsExistAsync(strAnswerCountId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strAnswerCountId": strAnswerCountId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_IsExistAsync = gs_AnswerCount_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_AnswerCount_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetRecCountByCondAsync = gs_AnswerCount_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_AnswerCount_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_AnswerCount_GetRecCountByCond_Cache(objgs_AnswerCount_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_AnswerCountObjLst_Cache = await gs_AnswerCount_GetObjLst_Cache(strid_CurrEduCls);
        if (arrgs_AnswerCountObjLst_Cache == null)
            return 0;
        let arrgs_AnswerCount_Sel = arrgs_AnswerCountObjLst_Cache;
        if (objgs_AnswerCount_Cond.sf_FldComparisonOp == null || objgs_AnswerCount_Cond.sf_FldComparisonOp == "")
            return arrgs_AnswerCount_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_AnswerCount_Cond.sf_FldComparisonOp);
        //console.log("clsgs_AnswerCountWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_AnswerCount_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_AnswerCount_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_AnswerCount_Sel = arrgs_AnswerCount_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_AnswerCount_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_AnswerCount_Cond), exports.gs_AnswerCount_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_AnswerCount_GetRecCountByCond_Cache = gs_AnswerCount_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_AnswerCount_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetMaxStrIdAsync = gs_AnswerCount_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_AnswerCount_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_AnswerCount_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_AnswerCount_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_AnswerCount_GetMaxStrIdByPrefix = gs_AnswerCount_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_AnswerCount_GetWebApiUrl(strController, strAction) {
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
    exports.gs_AnswerCount_GetWebApiUrl = gs_AnswerCount_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_AnswerCount_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsgs_AnswerCountWApi.clsgs_AnswerCountWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsgs_AnswerCountWApi.clsgs_AnswerCountWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
        switch (clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheModeId) {
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
    exports.gs_AnswerCount_ReFreshCache = gs_AnswerCount_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_AnswerCount_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN._CurrTabName, strid_CurrEduCls);
            switch (clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.CacheModeId) {
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
    exports.gs_AnswerCount_ReFreshThisCache = gs_AnswerCount_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_AnswerCount_CheckPropertyNew(pobjgs_AnswerCountEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.memo)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerCountId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.answerCountId) > 10) {
            throw new Error("(errid:Watl000059)字段[AnswerCountId(answerCountId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerCountId)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.dataUser) > 20) {
            throw new Error("(errid:Watl000059)字段[数据用户(dataUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataUser)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataAddDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.dataAddDate) > 20) {
            throw new Error("(errid:Watl000059)字段[数据添加日期(dataAddDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataAddDate)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.weekTimeRange) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.weekTimeRange) > 100) {
            throw new Error("(errid:Watl000059)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.weekTimeRange)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.answerId) > 10) {
            throw new Error("(errid:Watl000059)字段[回答Id(answerId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerId)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerTypeId)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.questionsId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.questionsId) > 8) {
            throw new Error("(errid:Watl000059)字段[提问Id(questionsId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.questionsId)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.topicId)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.paperId)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.id_CurrEduCls)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.scoreType) > 1) {
            throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.scoreType)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updUser)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updDate)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.userName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.userName) > 30) {
            throw new Error("(errid:Watl000059)字段[用户名(userName)]的长度不能超过30(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.userName)(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.memo) == false && undefined !== pobjgs_AnswerCountEN.memo && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_AnswerCountEN.memo)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerCountId) == false && undefined !== pobjgs_AnswerCountEN.answerCountId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerCountId) === false) {
            throw new Error("(errid:Watl000060)字段[AnswerCountId(answerCountId)]的值:[$(pobjgs_AnswerCountEN.answerCountId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataUser) == false && undefined !== pobjgs_AnswerCountEN.dataUser && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.dataUser) === false) {
            throw new Error("(errid:Watl000060)字段[数据用户(dataUser)]的值:[$(pobjgs_AnswerCountEN.dataUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataAddDate) == false && undefined !== pobjgs_AnswerCountEN.dataAddDate && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.dataAddDate) === false) {
            throw new Error("(errid:Watl000060)字段[数据添加日期(dataAddDate)]的值:[$(pobjgs_AnswerCountEN.dataAddDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if (null != pobjgs_AnswerCountEN.month && undefined !== pobjgs_AnswerCountEN.month && clsString_js_1.tzDataType.isNumber(pobjgs_AnswerCountEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjgs_AnswerCountEN.month)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if (null != pobjgs_AnswerCountEN.week && undefined !== pobjgs_AnswerCountEN.week && clsString_js_1.tzDataType.isNumber(pobjgs_AnswerCountEN.week) === false) {
            throw new Error("(errid:Watl000060)字段[周(week)]的值:[$(pobjgs_AnswerCountEN.week)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.weekTimeRange) == false && undefined !== pobjgs_AnswerCountEN.weekTimeRange && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.weekTimeRange) === false) {
            throw new Error("(errid:Watl000060)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjgs_AnswerCountEN.weekTimeRange)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if (null != pobjgs_AnswerCountEN.isRecommend && undefined !== pobjgs_AnswerCountEN.isRecommend && clsString_js_1.tzDataType.isBoolean(pobjgs_AnswerCountEN.isRecommend) === false) {
            throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjgs_AnswerCountEN.isRecommend)], 非法，应该为布尔型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerId) == false && undefined !== pobjgs_AnswerCountEN.answerId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerId) === false) {
            throw new Error("(errid:Watl000060)字段[回答Id(answerId)]的值:[$(pobjgs_AnswerCountEN.answerId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerTypeId) == false && undefined !== pobjgs_AnswerCountEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[答案类型ID(answerTypeId)]的值:[$(pobjgs_AnswerCountEN.answerTypeId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.questionsId) == false && undefined !== pobjgs_AnswerCountEN.questionsId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.questionsId) === false) {
            throw new Error("(errid:Watl000060)字段[提问Id(questionsId)]的值:[$(pobjgs_AnswerCountEN.questionsId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.topicId) == false && undefined !== pobjgs_AnswerCountEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjgs_AnswerCountEN.topicId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.paperId) == false && undefined !== pobjgs_AnswerCountEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_AnswerCountEN.paperId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.id_CurrEduCls) == false && undefined !== pobjgs_AnswerCountEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_AnswerCountEN.id_CurrEduCls)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerContent) == false && undefined !== pobjgs_AnswerCountEN.answerContent && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerContent) === false) {
            throw new Error("(errid:Watl000060)字段[答案内容(answerContent)]的值:[$(pobjgs_AnswerCountEN.answerContent)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if (null != pobjgs_AnswerCountEN.score && undefined !== pobjgs_AnswerCountEN.score && clsString_js_1.tzDataType.isNumber(pobjgs_AnswerCountEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_AnswerCountEN.score)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.scoreType) == false && undefined !== pobjgs_AnswerCountEN.scoreType && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.scoreType) === false) {
            throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjgs_AnswerCountEN.scoreType)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updUser) == false && undefined !== pobjgs_AnswerCountEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_AnswerCountEN.updUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updDate) == false && undefined !== pobjgs_AnswerCountEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_AnswerCountEN.updDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.userName) == false && undefined !== pobjgs_AnswerCountEN.userName && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.userName) === false) {
            throw new Error("(errid:Watl000060)字段[用户名(userName)]的值:[$(pobjgs_AnswerCountEN.userName)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_AnswerCountEN.SetIsCheckProperty(true);
    }
    exports.gs_AnswerCount_CheckPropertyNew = gs_AnswerCount_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_AnswerCount_CheckProperty4Update(pobjgs_AnswerCountEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.memo)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerCountId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.answerCountId) > 10) {
            throw new Error("(errid:Watl000062)字段[AnswerCountId(answerCountId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerCountId)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.dataUser) > 20) {
            throw new Error("(errid:Watl000062)字段[数据用户(dataUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataUser)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataAddDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.dataAddDate) > 20) {
            throw new Error("(errid:Watl000062)字段[数据添加日期(dataAddDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.dataAddDate)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.weekTimeRange) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.weekTimeRange) > 100) {
            throw new Error("(errid:Watl000062)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.weekTimeRange)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.answerId) > 10) {
            throw new Error("(errid:Watl000062)字段[回答Id(answerId)]的长度不能超过10(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerId)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.answerTypeId)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.questionsId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.questionsId) > 8) {
            throw new Error("(errid:Watl000062)字段[提问Id(questionsId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.questionsId)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.topicId)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.paperId)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.id_CurrEduCls)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.scoreType) > 1) {
            throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.scoreType)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updUser)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.updDate)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.userName) == false && (0, clsString_js_2.GetStrLen)(pobjgs_AnswerCountEN.userName) > 30) {
            throw new Error("(errid:Watl000062)字段[用户名(userName)]的长度不能超过30(In 问题讨论回答统计(gs_AnswerCount))!值:$(pobjgs_AnswerCountEN.userName)(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.memo) == false && undefined !== pobjgs_AnswerCountEN.memo && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_AnswerCountEN.memo)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerCountId) == false && undefined !== pobjgs_AnswerCountEN.answerCountId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerCountId) === false) {
            throw new Error("(errid:Watl000063)字段[AnswerCountId(answerCountId)]的值:[$(pobjgs_AnswerCountEN.answerCountId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataUser) == false && undefined !== pobjgs_AnswerCountEN.dataUser && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.dataUser) === false) {
            throw new Error("(errid:Watl000063)字段[数据用户(dataUser)]的值:[$(pobjgs_AnswerCountEN.dataUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.dataAddDate) == false && undefined !== pobjgs_AnswerCountEN.dataAddDate && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.dataAddDate) === false) {
            throw new Error("(errid:Watl000063)字段[数据添加日期(dataAddDate)]的值:[$(pobjgs_AnswerCountEN.dataAddDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if (null != pobjgs_AnswerCountEN.month && undefined !== pobjgs_AnswerCountEN.month && clsString_js_1.tzDataType.isNumber(pobjgs_AnswerCountEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjgs_AnswerCountEN.month)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if (null != pobjgs_AnswerCountEN.week && undefined !== pobjgs_AnswerCountEN.week && clsString_js_1.tzDataType.isNumber(pobjgs_AnswerCountEN.week) === false) {
            throw new Error("(errid:Watl000063)字段[周(week)]的值:[$(pobjgs_AnswerCountEN.week)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.weekTimeRange) == false && undefined !== pobjgs_AnswerCountEN.weekTimeRange && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.weekTimeRange) === false) {
            throw new Error("(errid:Watl000063)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjgs_AnswerCountEN.weekTimeRange)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if (null != pobjgs_AnswerCountEN.isRecommend && undefined !== pobjgs_AnswerCountEN.isRecommend && clsString_js_1.tzDataType.isBoolean(pobjgs_AnswerCountEN.isRecommend) === false) {
            throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjgs_AnswerCountEN.isRecommend)], 非法，应该为布尔型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerId) == false && undefined !== pobjgs_AnswerCountEN.answerId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerId) === false) {
            throw new Error("(errid:Watl000063)字段[回答Id(answerId)]的值:[$(pobjgs_AnswerCountEN.answerId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerTypeId) == false && undefined !== pobjgs_AnswerCountEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[答案类型ID(answerTypeId)]的值:[$(pobjgs_AnswerCountEN.answerTypeId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.questionsId) == false && undefined !== pobjgs_AnswerCountEN.questionsId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.questionsId) === false) {
            throw new Error("(errid:Watl000063)字段[提问Id(questionsId)]的值:[$(pobjgs_AnswerCountEN.questionsId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.topicId) == false && undefined !== pobjgs_AnswerCountEN.topicId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjgs_AnswerCountEN.topicId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.paperId) == false && undefined !== pobjgs_AnswerCountEN.paperId && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_AnswerCountEN.paperId)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.id_CurrEduCls) == false && undefined !== pobjgs_AnswerCountEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_AnswerCountEN.id_CurrEduCls)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerContent) == false && undefined !== pobjgs_AnswerCountEN.answerContent && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.answerContent) === false) {
            throw new Error("(errid:Watl000063)字段[答案内容(answerContent)]的值:[$(pobjgs_AnswerCountEN.answerContent)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if (null != pobjgs_AnswerCountEN.score && undefined !== pobjgs_AnswerCountEN.score && clsString_js_1.tzDataType.isNumber(pobjgs_AnswerCountEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_AnswerCountEN.score)], 非法，应该为数值型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.scoreType) == false && undefined !== pobjgs_AnswerCountEN.scoreType && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.scoreType) === false) {
            throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjgs_AnswerCountEN.scoreType)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updUser) == false && undefined !== pobjgs_AnswerCountEN.updUser && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_AnswerCountEN.updUser)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.updDate) == false && undefined !== pobjgs_AnswerCountEN.updDate && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_AnswerCountEN.updDate)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.userName) == false && undefined !== pobjgs_AnswerCountEN.userName && clsString_js_1.tzDataType.isString(pobjgs_AnswerCountEN.userName) === false) {
            throw new Error("(errid:Watl000063)字段[用户名(userName)]的值:[$(pobjgs_AnswerCountEN.userName)], 非法，应该为字符型(In 问题讨论回答统计(gs_AnswerCount))!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjgs_AnswerCountEN.answerCountId) === true) {
            throw new Error("(errid:Watl000064)字段[AnswerCountId]不能为空(In 问题讨论回答统计)!(clsgs_AnswerCountBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_AnswerCountEN.SetIsCheckProperty(true);
    }
    exports.gs_AnswerCount_CheckProperty4Update = gs_AnswerCount_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_AnswerCount_GetJSONStrByObj(pobjgs_AnswerCountEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_AnswerCountEN.sf_UpdFldSetStr = pobjgs_AnswerCountEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_AnswerCountEN);
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
    exports.gs_AnswerCount_GetJSONStrByObj = gs_AnswerCount_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_AnswerCount_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_AnswerCountObjLst = new Array();
        if (strJSON === "") {
            return arrgs_AnswerCountObjLst;
        }
        try {
            arrgs_AnswerCountObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_AnswerCountObjLst;
        }
        return arrgs_AnswerCountObjLst;
    }
    exports.gs_AnswerCount_GetObjLstByJSONStr = gs_AnswerCount_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_AnswerCountObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_AnswerCount_GetObjLstByJSONObjLst(arrgs_AnswerCountObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_AnswerCountObjLst = new Array();
        for (const objInFor of arrgs_AnswerCountObjLstS) {
            const obj1 = gs_AnswerCount_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_AnswerCountObjLst.push(obj1);
        }
        return arrgs_AnswerCountObjLst;
    }
    exports.gs_AnswerCount_GetObjLstByJSONObjLst = gs_AnswerCount_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_AnswerCount_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_AnswerCountEN = new clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN();
        if (strJSON === "") {
            return pobjgs_AnswerCountEN;
        }
        try {
            pobjgs_AnswerCountEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_AnswerCountEN;
        }
        return pobjgs_AnswerCountEN;
    }
    exports.gs_AnswerCount_GetObjByJSONStr = gs_AnswerCount_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_AnswerCount_GetCombineCondition(objgs_AnswerCount_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Memo, objgs_AnswerCount_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId) == true) {
            const strComparisonOp_AnswerCountId = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerCountId, objgs_AnswerCount_Cond.answerCountId, strComparisonOp_AnswerCountId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataUser) == true) {
            const strComparisonOp_DataUser = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataUser, objgs_AnswerCount_Cond.dataUser, strComparisonOp_DataUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate) == true) {
            const strComparisonOp_DataAddDate = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_DataAddDate, objgs_AnswerCount_Cond.dataAddDate, strComparisonOp_DataAddDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Month) == true) {
            const strComparisonOp_Month = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Month];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Month, objgs_AnswerCount_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Week) == true) {
            const strComparisonOp_Week = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Week];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Week, objgs_AnswerCount_Cond.week, strComparisonOp_Week);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_WeekTimeRange) == true) {
            const strComparisonOp_WeekTimeRange = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_WeekTimeRange];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_WeekTimeRange, objgs_AnswerCount_Cond.weekTimeRange, strComparisonOp_WeekTimeRange);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_IsRecommend) == true) {
            if (objgs_AnswerCount_Cond.isRecommend == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_IsRecommend);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_IsRecommend);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerId) == true) {
            const strComparisonOp_AnswerId = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerId, objgs_AnswerCount_Cond.answerId, strComparisonOp_AnswerId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_AnswerTypeId, objgs_AnswerCount_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_QuestionsId) == true) {
            const strComparisonOp_QuestionsId = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_QuestionsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_QuestionsId, objgs_AnswerCount_Cond.questionsId, strComparisonOp_QuestionsId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_TopicId, objgs_AnswerCount_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_PaperId, objgs_AnswerCount_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_id_CurrEduCls, objgs_AnswerCount_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Score) == true) {
            const strComparisonOp_Score = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_Score, objgs_AnswerCount_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_ScoreType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_ScoreType, objgs_AnswerCount_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdUser, objgs_AnswerCount_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UpdDate, objgs_AnswerCount_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_AnswerCount_Cond.dicFldComparisonOp, clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UserName) == true) {
            const strComparisonOp_UserName = objgs_AnswerCount_Cond.dicFldComparisonOp[clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UserName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN.con_UserName, objgs_AnswerCount_Cond.userName, strComparisonOp_UserName);
        }
        return strWhereCond;
    }
    exports.gs_AnswerCount_GetCombineCondition = gs_AnswerCount_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_AnswerCount(问题讨论回答统计),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strAnswerCountId: AnswerCountId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_AnswerCount_GetUniCondStr_AnswerCountId(objgs_AnswerCountEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.answerCountId);
        return strWhereCond;
    }
    exports.gs_AnswerCount_GetUniCondStr_AnswerCountId = gs_AnswerCount_GetUniCondStr_AnswerCountId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_AnswerCount(问题讨论回答统计),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strAnswerCountId: AnswerCountId(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_AnswerCount_GetUniCondStr4Update_AnswerCountId(objgs_AnswerCountEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerCountId <> '{0}'", objgs_AnswerCountEN.answerCountId);
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerCountId = '{0}'", objgs_AnswerCountEN.answerCountId);
        return strWhereCond;
    }
    exports.gs_AnswerCount_GetUniCondStr4Update_AnswerCountId = gs_AnswerCount_GetUniCondStr4Update_AnswerCountId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_AnswerCountENS:源对象
     * @param objgs_AnswerCountENT:目标对象
    */
    function gs_AnswerCount_CopyObjTo(objgs_AnswerCountENS, objgs_AnswerCountENT) {
        objgs_AnswerCountENT.memo = objgs_AnswerCountENS.memo; //备注
        objgs_AnswerCountENT.answerCountId = objgs_AnswerCountENS.answerCountId; //AnswerCountId
        objgs_AnswerCountENT.dataUser = objgs_AnswerCountENS.dataUser; //数据用户
        objgs_AnswerCountENT.dataAddDate = objgs_AnswerCountENS.dataAddDate; //数据添加日期
        objgs_AnswerCountENT.month = objgs_AnswerCountENS.month; //月
        objgs_AnswerCountENT.week = objgs_AnswerCountENS.week; //周
        objgs_AnswerCountENT.weekTimeRange = objgs_AnswerCountENS.weekTimeRange; //WeekTimeRange
        objgs_AnswerCountENT.isRecommend = objgs_AnswerCountENS.isRecommend; //是否推荐
        objgs_AnswerCountENT.answerId = objgs_AnswerCountENS.answerId; //回答Id
        objgs_AnswerCountENT.answerTypeId = objgs_AnswerCountENS.answerTypeId; //答案类型ID
        objgs_AnswerCountENT.questionsId = objgs_AnswerCountENS.questionsId; //提问Id
        objgs_AnswerCountENT.topicId = objgs_AnswerCountENS.topicId; //主题Id
        objgs_AnswerCountENT.paperId = objgs_AnswerCountENS.paperId; //论文Id
        objgs_AnswerCountENT.id_CurrEduCls = objgs_AnswerCountENS.id_CurrEduCls; //教学班流水号
        objgs_AnswerCountENT.answerContent = objgs_AnswerCountENS.answerContent; //答案内容
        objgs_AnswerCountENT.score = objgs_AnswerCountENS.score; //评分
        objgs_AnswerCountENT.scoreType = objgs_AnswerCountENS.scoreType; //评分类型
        objgs_AnswerCountENT.updUser = objgs_AnswerCountENS.updUser; //修改人
        objgs_AnswerCountENT.updDate = objgs_AnswerCountENS.updDate; //修改日期
        objgs_AnswerCountENT.userName = objgs_AnswerCountENS.userName; //用户名
        objgs_AnswerCountENT.sf_UpdFldSetStr = objgs_AnswerCountENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_AnswerCount_CopyObjTo = gs_AnswerCount_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_AnswerCountENS:源对象
     * @param objgs_AnswerCountENT:目标对象
    */
    function gs_AnswerCount_GetObjFromJsonObj(objgs_AnswerCountENS) {
        const objgs_AnswerCountENT = new clsgs_AnswerCountEN_js_1.clsgs_AnswerCountEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_AnswerCountENT, objgs_AnswerCountENS);
        return objgs_AnswerCountENT;
    }
    exports.gs_AnswerCount_GetObjFromJsonObj = gs_AnswerCount_GetObjFromJsonObj;
});
