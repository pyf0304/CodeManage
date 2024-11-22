/**
* 类名:clsqa_AnswerWApi
* 表名:qa_Answer(01120641)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:52:46
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsqa_AnswerEN.js", "../../L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_Answer_GetObjFromJsonObj = exports.qa_Answer_CopyObjTo = exports.qa_Answer_GetUniCondStr4Update_AnswerId = exports.qa_Answer_GetUniCondStr_AnswerId = exports.qa_Answer_GetCombineCondition = exports.qa_Answer_GetObjByJSONStr = exports.qa_Answer_GetObjLstByJSONObjLst = exports.qa_Answer_GetObjLstByJSONStr = exports.qa_Answer_GetJSONStrByObj = exports.qa_Answer_CheckProperty4Update = exports.qa_Answer_CheckPropertyNew = exports.qa_Answer_ReFreshThisCache = exports.qa_Answer_ReFreshCache = exports.qa_Answer_GetWebApiUrl = exports.qa_Answer_GetMaxStrIdByPrefix = exports.qa_Answer_GetMaxStrIdAsync = exports.qa_Answer_GetRecCountByCond_Cache = exports.qa_Answer_GetRecCountByCondAsync = exports.qa_Answer_IsExistAsync = exports.qa_Answer_IsExist_Cache = exports.qa_Answer_IsExist = exports.qa_Answer_IsExistRecordAsync = exports.qa_Answer_IsExistRecord_Cache = exports.qa_Answer_UpdateWithConditionAsync = exports.qa_Answer_UpdateRecordAsync = exports.qa_Answer_AddNewRecordWithReturnKey = exports.qa_Answer_AddNewRecordWithReturnKeyAsync = exports.qa_Answer_AddNewRecordWithMaxIdAsync = exports.qa_Answer_AddNewRecordAsync = exports.qa_Answer_Delqa_AnswersByCondAsync = exports.qa_Answer_Delqa_AnswersAsync = exports.qa_Answer_DelRecordAsync = exports.qa_Answer_GetObjLstByPagerAsync = exports.qa_Answer_GetObjLstByPager_Cache = exports.qa_Answer_GetObjLstByRange = exports.qa_Answer_GetObjLstByRangeAsync = exports.qa_Answer_GetTopObjLstAsync = exports.qa_Answer_GetObjLstByAnswerIdLst_Cache = exports.qa_Answer_GetObjLstByAnswerIdLstAsync = exports.qa_Answer_GetSubObjLst_Cache = exports.qa_Answer_GetObjLst_PureCache = exports.qa_Answer_GetObjLst_Cache = exports.qa_Answer_GetObjLst_sessionStorage_PureCache = exports.qa_Answer_GetObjLst_sessionStorage = exports.qa_Answer_GetObjLstAsync = exports.qa_Answer_GetObjLst_localStorage_PureCache = exports.qa_Answer_GetObjLst_localStorage = exports.qa_Answer_GetObjLst_ClientCache = exports.qa_Answer_GetFirstObjAsync = exports.qa_Answer_GetFirstID = exports.qa_Answer_GetFirstIDAsync = exports.qa_Answer_funcKey = exports.qa_Answer_FilterFunByKey = exports.qa_Answer_SortFunByKey = exports.qa_Answer_SortFun_Defa_2Fld = exports.qa_Answer_SortFun_Defa = exports.qa_Answer_func = exports.qa_Answer_UpdateObjInLst_Cache = exports.qa_Answer_GetObjByAnswerId_localStorage = exports.qa_Answer_GetObjByAnswerId_Cache = exports.qa_Answer_GetObjByAnswerIdAsync = exports.qa_Answer_ConstructorName = exports.qa_Answer_Controller = void 0;
    /**
     * 答疑回答(qa_Answer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsqa_AnswerEN_js_1 = require("../../L0_Entity/InteractManage/clsqa_AnswerEN.js");
    const clsvqa_AnswerWApi_js_1 = require("../../L3_ForWApi/InteractManage/clsvqa_AnswerWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.qa_Answer_Controller = "qa_AnswerApi";
    exports.qa_Answer_ConstructorName = "qa_Answer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strAnswerId:关键字
    * @returns 对象
    **/
    async function qa_Answer_GetObjByAnswerIdAsync(strAnswerId) {
        const strThisFuncName = "GetObjByAnswerIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strAnswerId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strAnswerId]不能为空！(In clsqa_AnswerWApi.GetObjByAnswerIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！(clsqa_AnswerWApi.GetObjByAnswerIdAsync)", strAnswerId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByAnswerId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strAnswerId": strAnswerId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objqa_Answer = qa_Answer_GetObjFromJsonObj(returnObj);
                return objqa_Answer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetObjByAnswerIdAsync = qa_Answer_GetObjByAnswerIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strAnswerId:所给的关键字
     * @returns 对象
    */
    async function qa_Answer_GetObjByAnswerId_Cache(strAnswerId, strTopicId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByAnswerId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strAnswerId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strAnswerId]不能为空！(In clsqa_AnswerWApi.GetObjByAnswerId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！(clsqa_AnswerWApi.GetObjByAnswerId_Cache)", strAnswerId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
        try {
            const arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache.filter(x => x.answerId == strAnswerId);
            let objqa_Answer;
            if (arrqa_Answer_Sel.length > 0) {
                objqa_Answer = arrqa_Answer_Sel[0];
                return objqa_Answer;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objqa_Answer_Const = await qa_Answer_GetObjByAnswerIdAsync(strAnswerId);
                    if (objqa_Answer_Const != null) {
                        qa_Answer_ReFreshThisCache(strTopicId);
                        return objqa_Answer_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerId, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.qa_Answer_GetObjByAnswerId_Cache = qa_Answer_GetObjByAnswerId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strAnswerId:所给的关键字
     * @returns 对象
    */
    async function qa_Answer_GetObjByAnswerId_localStorage(strAnswerId) {
        const strThisFuncName = "GetObjByAnswerId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strAnswerId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strAnswerId]不能为空！(In clsqa_AnswerWApi.GetObjByAnswerId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！(clsqa_AnswerWApi.GetObjByAnswerId_localStorage)", strAnswerId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strAnswerId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objqa_Answer_Cache = JSON.parse(strTempObj);
            return objqa_Answer_Cache;
        }
        try {
            const objqa_Answer = await qa_Answer_GetObjByAnswerIdAsync(strAnswerId);
            if (objqa_Answer != null) {
                localStorage.setItem(strKey, JSON.stringify(objqa_Answer));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objqa_Answer;
            }
            return objqa_Answer;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerId, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.qa_Answer_GetObjByAnswerId_localStorage = qa_Answer_GetObjByAnswerId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objqa_Answer:所给的对象
     * @returns 对象
    */
    async function qa_Answer_UpdateObjInLst_Cache(objqa_Answer, strTopicId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
            const obj = arrqa_AnswerObjLst_Cache.find(x => x.answerId == objqa_Answer.answerId);
            if (obj != null) {
                objqa_Answer.answerId = obj.answerId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objqa_Answer);
            }
            else {
                arrqa_AnswerObjLst_Cache.push(objqa_Answer);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.qa_Answer_UpdateObjInLst_Cache = qa_Answer_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strTopicId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function qa_Answer_func(strInFldName, strOutFldName, strInValue, strTopicId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicId_C]不能为空！(In clsqa_AnswerWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsqa_AnswerWApi.func)", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsqa_AnswerEN_js_1.clsqa_AnswerEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsqa_AnswerEN_js_1.clsqa_AnswerEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strAnswerId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objqa_Answer = await qa_Answer_GetObjByAnswerId_Cache(strAnswerId, strTopicId_C);
        if (objqa_Answer == null)
            return "";
        if (objqa_Answer.GetFldValue(strOutFldName) == null)
            return "";
        return objqa_Answer.GetFldValue(strOutFldName).toString();
    }
    exports.qa_Answer_func = qa_Answer_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_Answer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.answerId.localeCompare(b.answerId);
    }
    exports.qa_Answer_SortFun_Defa = qa_Answer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_Answer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionsId == b.questionsId)
            return a.answerContent.localeCompare(b.answerContent);
        else
            return a.questionsId.localeCompare(b.questionsId);
    }
    exports.qa_Answer_SortFun_Defa_2Fld = qa_Answer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_Answer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId:
                    return (a, b) => {
                        return a.answerId.localeCompare(b.answerId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_QuestionsId:
                    return (a, b) => {
                        return a.questionsId.localeCompare(b.questionsId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerContent:
                    return (a, b) => {
                        if (a.answerContent == null)
                            return -1;
                        if (b.answerContent == null)
                            return 1;
                        return a.answerContent.localeCompare(b.answerContent);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ScoreType:
                    return (a, b) => {
                        if (a.scoreType == null)
                            return -1;
                        if (b.scoreType == null)
                            return 1;
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRight:
                    return (a, b) => {
                        if (a.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ParentId:
                    return (a, b) => {
                        if (a.parentId == null)
                            return -1;
                        if (b.parentId == null)
                            return 1;
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRecommend:
                    return (a, b) => {
                        if (a.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (a.answerTypeId == null)
                            return -1;
                        if (b.answerTypeId == null)
                            return 1;
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[qa_Answer]中不存在！(in ${exports.qa_Answer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId:
                    return (a, b) => {
                        return b.answerId.localeCompare(a.answerId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_QuestionsId:
                    return (a, b) => {
                        return b.questionsId.localeCompare(a.questionsId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerContent:
                    return (a, b) => {
                        if (b.answerContent == null)
                            return -1;
                        if (a.answerContent == null)
                            return 1;
                        return b.answerContent.localeCompare(a.answerContent);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ScoreType:
                    return (a, b) => {
                        if (b.scoreType == null)
                            return -1;
                        if (a.scoreType == null)
                            return 1;
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRight:
                    return (a, b) => {
                        if (b.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ParentId:
                    return (a, b) => {
                        if (b.parentId == null)
                            return -1;
                        if (a.parentId == null)
                            return 1;
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRecommend:
                    return (a, b) => {
                        if (b.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (b.answerTypeId == null)
                            return -1;
                        if (a.answerTypeId == null)
                            return 1;
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[qa_Answer]中不存在！(in ${exports.qa_Answer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.qa_Answer_SortFunByKey = qa_Answer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function qa_Answer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId:
                return (obj) => {
                    return obj.answerId === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_QuestionsId:
                return (obj) => {
                    return obj.questionsId === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerContent:
                return (obj) => {
                    return obj.answerContent === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRight:
                return (obj) => {
                    return obj.isRight === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRecommend:
                return (obj) => {
                    return obj.isRecommend === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[qa_Answer]中不存在！(in ${exports.qa_Answer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.qa_Answer_FilterFunByKey = qa_Answer_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strTopicId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function qa_Answer_funcKey(strInFldName, strInValue, strComparisonOp, strTopicId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicId_C]不能为空！(In clsqa_AnswerWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！(clsqa_AnswerWApi.funcKey)", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrqa_Answer = await qa_Answer_GetObjLst_Cache(strTopicId_C);
        if (arrqa_Answer == null)
            return [];
        let arrqa_Answer_Sel = arrqa_Answer;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrqa_Answer_Sel.length == 0)
            return [];
        return arrqa_Answer_Sel.map(x => x.answerId);
    }
    exports.qa_Answer_funcKey = qa_Answer_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function qa_Answer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetFirstIDAsync = qa_Answer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function qa_Answer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetFirstID = qa_Answer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function qa_Answer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const objqa_Answer = qa_Answer_GetObjFromJsonObj(returnObj);
                return objqa_Answer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetFirstObjAsync = qa_Answer_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_ClientCache(strTopicId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.WhereFormat, strTopicId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("TopicId='{0}'", strTopicId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrqa_AnswerExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrqa_AnswerObjLst_T = qa_Answer_GetObjLstByJSONObjLst(arrqa_AnswerExObjLst_Cache);
            return arrqa_AnswerObjLst_T;
        }
        try {
            const arrqa_AnswerExObjLst = await qa_Answer_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrqa_AnswerExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerExObjLst.length);
            console.log(strInfo);
            return arrqa_AnswerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_Answer_GetObjLst_ClientCache = qa_Answer_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_localStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.WhereFormat, strTopicId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("TopicId='{0}'", strTopicId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrqa_AnswerExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrqa_AnswerObjLst_T = qa_Answer_GetObjLstByJSONObjLst(arrqa_AnswerExObjLst_Cache);
            return arrqa_AnswerObjLst_T;
        }
        try {
            const arrqa_AnswerExObjLst = await qa_Answer_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrqa_AnswerExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerExObjLst.length);
            console.log(strInfo);
            return arrqa_AnswerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_Answer_GetObjLst_localStorage = qa_Answer_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_localStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrqa_AnswerObjLst_Cache = JSON.parse(strTempObjLst);
            return arrqa_AnswerObjLst_Cache;
        }
        else
            return null;
    }
    exports.qa_Answer_GetObjLst_localStorage_PureCache = qa_Answer_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function qa_Answer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetObjLstAsync = qa_Answer_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_sessionStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.WhereFormat, strTopicId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("TopicId='{0}'", strTopicId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrqa_AnswerExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrqa_AnswerObjLst_T = qa_Answer_GetObjLstByJSONObjLst(arrqa_AnswerExObjLst_Cache);
            return arrqa_AnswerObjLst_T;
        }
        try {
            const arrqa_AnswerExObjLst = await qa_Answer_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrqa_AnswerExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerExObjLst.length);
            console.log(strInfo);
            return arrqa_AnswerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_Answer_GetObjLst_sessionStorage = qa_Answer_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_sessionStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrqa_AnswerObjLst_Cache = JSON.parse(strTempObjLst);
            return arrqa_AnswerObjLst_Cache;
        }
        else
            return null;
    }
    exports.qa_Answer_GetObjLst_sessionStorage_PureCache = qa_Answer_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_Cache(strTopicId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[TopicId]不能为空！(in clsqa_AnswerWApi.qa_Answer_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(in clsqa_AnswerWApi.qa_Answer_GetObjLst_Cache() )", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrqa_AnswerObjLst_Cache;
        switch (clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheModeId) {
            case "04": //sessionStorage
                arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_sessionStorage(strTopicId);
                break;
            case "03": //localStorage
                arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_localStorage(strTopicId);
                break;
            case "02": //ClientCache
                arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_ClientCache(strTopicId);
                break;
            default:
                arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_ClientCache(strTopicId);
                break;
        }
        const arrqa_AnswerObjLst = qa_Answer_GetObjLstByJSONObjLst(arrqa_AnswerObjLst_Cache);
        return arrqa_AnswerObjLst_Cache;
    }
    exports.qa_Answer_GetObjLst_Cache = qa_Answer_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_Answer_GetObjLst_PureCache(strTopicId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrqa_AnswerObjLst_Cache;
        switch (clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheModeId) {
            case "04": //sessionStorage
                arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_sessionStorage_PureCache(strTopicId);
                break;
            case "03": //localStorage
                arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_localStorage_PureCache(strTopicId);
                break;
            case "02": //ClientCache
                arrqa_AnswerObjLst_Cache = null;
                break;
            default:
                arrqa_AnswerObjLst_Cache = null;
                break;
        }
        return arrqa_AnswerObjLst_Cache;
    }
    exports.qa_Answer_GetObjLst_PureCache = qa_Answer_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrAnswerId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function qa_Answer_GetSubObjLst_Cache(objqa_Answer_Cond, strTopicId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
        let arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache;
        if (objqa_Answer_Cond.sf_FldComparisonOp == null || objqa_Answer_Cond.sf_FldComparisonOp == "")
            return arrqa_Answer_Sel;
        const dicFldComparisonOp = JSON.parse(objqa_Answer_Cond.sf_FldComparisonOp);
        //console.log("clsqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_Answer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objqa_Answer_Cond), exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_Answer_GetSubObjLst_Cache = qa_Answer_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrAnswerId:关键字列表
    * @returns 对象列表
    **/
    async function qa_Answer_GetObjLstByAnswerIdLstAsync(arrAnswerId) {
        const strThisFuncName = "GetObjLstByAnswerIdLstAsync";
        const strAction = "GetObjLstByAnswerIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetObjLstByAnswerIdLstAsync = qa_Answer_GetObjLstByAnswerIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrAnswerIdLst:关键字列表
     * @returns 对象列表
    */
    async function qa_Answer_GetObjLstByAnswerIdLst_Cache(arrAnswerIdLst, strTopicId) {
        const strThisFuncName = "GetObjLstByAnswerIdLst_Cache";
        try {
            const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
            const arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache.filter(x => arrAnswerIdLst.indexOf(x.answerId) > -1);
            return arrqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerIdLst.join(","), exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.qa_Answer_GetObjLstByAnswerIdLst_Cache = qa_Answer_GetObjLstByAnswerIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function qa_Answer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetTopObjLstAsync = qa_Answer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function qa_Answer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetObjLstByRangeAsync = qa_Answer_GetObjLstByRangeAsync;
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
    async function qa_Answer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetObjLstByRange = qa_Answer_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function qa_Answer_GetObjLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
        if (arrqa_AnswerObjLst_Cache.length == 0)
            return arrqa_AnswerObjLst_Cache;
        let arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objqa_Answer_Cond = new clsqa_AnswerEN_js_1.clsqa_AnswerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_Answer_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsqa_AnswerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_Answer_Sel.length == 0)
                return arrqa_Answer_Sel;
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
                arrqa_Answer_Sel = arrqa_Answer_Sel.sort(qa_Answer_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrqa_Answer_Sel = arrqa_Answer_Sel.sort(objPagerPara.sortFun);
            }
            arrqa_Answer_Sel = arrqa_Answer_Sel.slice(intStart, intEnd);
            return arrqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_Answer_GetObjLstByPager_Cache = qa_Answer_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function qa_Answer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetObjLstByPagerAsync = qa_Answer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strAnswerId:关键字
    * @returns 获取删除的结果
    **/
    async function qa_Answer_DelRecordAsync(strAnswerId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strAnswerId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_DelRecordAsync = qa_Answer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrAnswerId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function qa_Answer_Delqa_AnswersAsync(arrAnswerId) {
        const strThisFuncName = "Delqa_AnswersAsync";
        const strAction = "Delqa_Answers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_Delqa_AnswersAsync = qa_Answer_Delqa_AnswersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function qa_Answer_Delqa_AnswersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delqa_AnswersByCondAsync";
        const strAction = "Delqa_AnswersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_Delqa_AnswersByCondAsync = qa_Answer_Delqa_AnswersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objqa_AnswerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function qa_Answer_AddNewRecordAsync(objqa_AnswerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objqa_AnswerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_AddNewRecordAsync = qa_Answer_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objqa_AnswerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function qa_Answer_AddNewRecordWithMaxIdAsync(objqa_AnswerEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_AddNewRecordWithMaxIdAsync = qa_Answer_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objqa_AnswerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function qa_Answer_AddNewRecordWithReturnKeyAsync(objqa_AnswerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_AddNewRecordWithReturnKeyAsync = qa_Answer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objqa_AnswerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function qa_Answer_AddNewRecordWithReturnKey(objqa_AnswerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objqa_AnswerEN.answerId === null || objqa_AnswerEN.answerId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_AddNewRecordWithReturnKey = qa_Answer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objqa_AnswerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function qa_Answer_UpdateRecordAsync(objqa_AnswerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objqa_AnswerEN.sf_UpdFldSetStr === undefined || objqa_AnswerEN.sf_UpdFldSetStr === null || objqa_AnswerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_AnswerEN.answerId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_UpdateRecordAsync = qa_Answer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objqa_AnswerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function qa_Answer_UpdateWithConditionAsync(objqa_AnswerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objqa_AnswerEN.sf_UpdFldSetStr === undefined || objqa_AnswerEN.sf_UpdFldSetStr === null || objqa_AnswerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_AnswerEN.answerId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        objqa_AnswerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_UpdateWithConditionAsync = qa_Answer_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrAnswerId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function qa_Answer_IsExistRecord_Cache(objqa_Answer_Cond, strTopicId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
        if (arrqa_AnswerObjLst_Cache == null)
            return false;
        let arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache;
        if (objqa_Answer_Cond.sf_FldComparisonOp == null || objqa_Answer_Cond.sf_FldComparisonOp == "")
            return arrqa_Answer_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objqa_Answer_Cond.sf_FldComparisonOp);
        //console.log("clsqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_Answer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_Answer_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objqa_Answer_Cond), exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.qa_Answer_IsExistRecord_Cache = qa_Answer_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function qa_Answer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_IsExistRecordAsync = qa_Answer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strAnswerId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function qa_Answer_IsExist(strAnswerId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "AnswerId": strAnswerId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_IsExist = qa_Answer_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strAnswerId:所给的关键字
     * @returns 对象
    */
    async function qa_Answer_IsExist_Cache(strAnswerId, strTopicId) {
        const strThisFuncName = "IsExist_Cache";
        const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
        if (arrqa_AnswerObjLst_Cache == null)
            return false;
        try {
            const arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache.filter(x => x.answerId == strAnswerId);
            if (arrqa_Answer_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strAnswerId, exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.qa_Answer_IsExist_Cache = qa_Answer_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strAnswerId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function qa_Answer_IsExistAsync(strAnswerId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strAnswerId": strAnswerId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_IsExistAsync = qa_Answer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function qa_Answer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetRecCountByCondAsync = qa_Answer_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objqa_Answer_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function qa_Answer_GetRecCountByCond_Cache(objqa_Answer_Cond, strTopicId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrqa_AnswerObjLst_Cache = await qa_Answer_GetObjLst_Cache(strTopicId);
        if (arrqa_AnswerObjLst_Cache == null)
            return 0;
        let arrqa_Answer_Sel = arrqa_AnswerObjLst_Cache;
        if (objqa_Answer_Cond.sf_FldComparisonOp == null || objqa_Answer_Cond.sf_FldComparisonOp == "")
            return arrqa_Answer_Sel.length;
        const dicFldComparisonOp = JSON.parse(objqa_Answer_Cond.sf_FldComparisonOp);
        //console.log("clsqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_Answer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_Answer_Sel = arrqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrqa_Answer_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objqa_Answer_Cond), exports.qa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.qa_Answer_GetRecCountByCond_Cache = qa_Answer_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function qa_Answer_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetMaxStrIdAsync = qa_Answer_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function qa_Answer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_Answer_GetMaxStrIdByPrefix = qa_Answer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function qa_Answer_GetWebApiUrl(strController, strAction) {
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
    exports.qa_Answer_GetWebApiUrl = qa_Answer_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function qa_Answer_ReFreshCache(strTopicId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicId]不能为空！(In clsqa_AnswerWApi.clsqa_AnswerWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！(clsqa_AnswerWApi.clsqa_AnswerWApi.ReFreshCache)", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
        switch (clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheModeId) {
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
        (0, clsvqa_AnswerWApi_js_1.vqa_Answer_ReFreshThisCache)(strTopicId);
    }
    exports.qa_Answer_ReFreshCache = qa_Answer_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function qa_Answer_ReFreshThisCache(strTopicId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN._CurrTabName, strTopicId);
            switch (clsqa_AnswerEN_js_1.clsqa_AnswerEN.CacheModeId) {
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
    exports.qa_Answer_ReFreshThisCache = qa_Answer_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function qa_Answer_CheckPropertyNew(pobjqa_AnswerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.questionsId) === true) {
            throw new Error("(errid:Watl000058)字段[提问Id]不能为空(In 答疑回答)!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.answerId) > 10) {
            throw new Error("(errid:Watl000059)字段[回答Id(answerId)]的长度不能超过10(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.answerId)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.questionsId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.questionsId) > 8) {
            throw new Error("(errid:Watl000059)字段[提问Id(questionsId)]的长度不能超过8(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.questionsId)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.scoreType) > 1) {
            throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.scoreType)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.parentId) > 10) {
            throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.parentId)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.topicId)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.answerTypeId)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.createDate)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.id_CurrEduCls)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.updUser)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.updDate)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.memo)(clsqa_AnswerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerId) == false && undefined !== pobjqa_AnswerEN.answerId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.answerId) === false) {
            throw new Error("(errid:Watl000060)字段[回答Id(answerId)]的值:[$(pobjqa_AnswerEN.answerId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.questionsId) == false && undefined !== pobjqa_AnswerEN.questionsId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.questionsId) === false) {
            throw new Error("(errid:Watl000060)字段[提问Id(questionsId)]的值:[$(pobjqa_AnswerEN.questionsId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerContent) == false && undefined !== pobjqa_AnswerEN.answerContent && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.answerContent) === false) {
            throw new Error("(errid:Watl000060)字段[答案内容(answerContent)]的值:[$(pobjqa_AnswerEN.answerContent)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.score && undefined !== pobjqa_AnswerEN.score && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjqa_AnswerEN.score)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.scoreType) == false && undefined !== pobjqa_AnswerEN.scoreType && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.scoreType) === false) {
            throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjqa_AnswerEN.scoreType)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.isRight && undefined !== pobjqa_AnswerEN.isRight && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerEN.isRight) === false) {
            throw new Error("(errid:Watl000060)字段[是否正确(isRight)]的值:[$(pobjqa_AnswerEN.isRight)], 非法，应该为布尔型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.parentId) == false && undefined !== pobjqa_AnswerEN.parentId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjqa_AnswerEN.parentId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.voteCount && undefined !== pobjqa_AnswerEN.voteCount && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.voteCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjqa_AnswerEN.voteCount)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.isRecommend && undefined !== pobjqa_AnswerEN.isRecommend && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerEN.isRecommend) === false) {
            throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjqa_AnswerEN.isRecommend)], 非法，应该为布尔型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.topicId) == false && undefined !== pobjqa_AnswerEN.topicId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjqa_AnswerEN.topicId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerTypeId) == false && undefined !== pobjqa_AnswerEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[答案类型ID(answerTypeId)]的值:[$(pobjqa_AnswerEN.answerTypeId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.isSubmit && undefined !== pobjqa_AnswerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjqa_AnswerEN.isSubmit)], 非法，应该为布尔型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.appraiseCount && undefined !== pobjqa_AnswerEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjqa_AnswerEN.appraiseCount)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.stuScore && undefined !== pobjqa_AnswerEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjqa_AnswerEN.stuScore)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerEN.teaScore && undefined !== pobjqa_AnswerEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjqa_AnswerEN.teaScore)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.createDate) == false && undefined !== pobjqa_AnswerEN.createDate && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjqa_AnswerEN.createDate)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.id_CurrEduCls) == false && undefined !== pobjqa_AnswerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjqa_AnswerEN.id_CurrEduCls)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updUser) == false && undefined !== pobjqa_AnswerEN.updUser && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjqa_AnswerEN.updUser)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updDate) == false && undefined !== pobjqa_AnswerEN.updDate && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjqa_AnswerEN.updDate)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.memo) == false && undefined !== pobjqa_AnswerEN.memo && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjqa_AnswerEN.memo)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjqa_AnswerEN.SetIsCheckProperty(true);
    }
    exports.qa_Answer_CheckPropertyNew = qa_Answer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function qa_Answer_CheckProperty4Update(pobjqa_AnswerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.answerId) > 10) {
            throw new Error("(errid:Watl000062)字段[回答Id(answerId)]的长度不能超过10(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.answerId)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.questionsId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.questionsId) > 8) {
            throw new Error("(errid:Watl000062)字段[提问Id(questionsId)]的长度不能超过8(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.questionsId)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.scoreType) > 1) {
            throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.scoreType)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.parentId) > 10) {
            throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.parentId)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.topicId)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.answerTypeId)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.createDate)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.id_CurrEduCls)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.updUser)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.updDate)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 答疑回答(qa_Answer))!值:$(pobjqa_AnswerEN.memo)(clsqa_AnswerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerId) == false && undefined !== pobjqa_AnswerEN.answerId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.answerId) === false) {
            throw new Error("(errid:Watl000063)字段[回答Id(answerId)]的值:[$(pobjqa_AnswerEN.answerId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.questionsId) == false && undefined !== pobjqa_AnswerEN.questionsId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.questionsId) === false) {
            throw new Error("(errid:Watl000063)字段[提问Id(questionsId)]的值:[$(pobjqa_AnswerEN.questionsId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerContent) == false && undefined !== pobjqa_AnswerEN.answerContent && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.answerContent) === false) {
            throw new Error("(errid:Watl000063)字段[答案内容(answerContent)]的值:[$(pobjqa_AnswerEN.answerContent)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.score && undefined !== pobjqa_AnswerEN.score && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjqa_AnswerEN.score)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.scoreType) == false && undefined !== pobjqa_AnswerEN.scoreType && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.scoreType) === false) {
            throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjqa_AnswerEN.scoreType)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.isRight && undefined !== pobjqa_AnswerEN.isRight && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerEN.isRight) === false) {
            throw new Error("(errid:Watl000063)字段[是否正确(isRight)]的值:[$(pobjqa_AnswerEN.isRight)], 非法，应该为布尔型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.parentId) == false && undefined !== pobjqa_AnswerEN.parentId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjqa_AnswerEN.parentId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.voteCount && undefined !== pobjqa_AnswerEN.voteCount && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.voteCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjqa_AnswerEN.voteCount)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.isRecommend && undefined !== pobjqa_AnswerEN.isRecommend && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerEN.isRecommend) === false) {
            throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjqa_AnswerEN.isRecommend)], 非法，应该为布尔型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.topicId) == false && undefined !== pobjqa_AnswerEN.topicId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjqa_AnswerEN.topicId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerTypeId) == false && undefined !== pobjqa_AnswerEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[答案类型ID(answerTypeId)]的值:[$(pobjqa_AnswerEN.answerTypeId)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.isSubmit && undefined !== pobjqa_AnswerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjqa_AnswerEN.isSubmit)], 非法，应该为布尔型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.appraiseCount && undefined !== pobjqa_AnswerEN.appraiseCount && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjqa_AnswerEN.appraiseCount)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.stuScore && undefined !== pobjqa_AnswerEN.stuScore && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjqa_AnswerEN.stuScore)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerEN.teaScore && undefined !== pobjqa_AnswerEN.teaScore && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjqa_AnswerEN.teaScore)], 非法，应该为数值型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.createDate) == false && undefined !== pobjqa_AnswerEN.createDate && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjqa_AnswerEN.createDate)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.id_CurrEduCls) == false && undefined !== pobjqa_AnswerEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjqa_AnswerEN.id_CurrEduCls)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updUser) == false && undefined !== pobjqa_AnswerEN.updUser && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjqa_AnswerEN.updUser)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.updDate) == false && undefined !== pobjqa_AnswerEN.updDate && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjqa_AnswerEN.updDate)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.memo) == false && undefined !== pobjqa_AnswerEN.memo && clsString_js_1.tzDataType.isString(pobjqa_AnswerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjqa_AnswerEN.memo)], 非法，应该为字符型(In 答疑回答(qa_Answer))!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerEN.answerId) === true) {
            throw new Error("(errid:Watl000064)字段[回答Id]不能为空(In 答疑回答)!(clsqa_AnswerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjqa_AnswerEN.SetIsCheckProperty(true);
    }
    exports.qa_Answer_CheckProperty4Update = qa_Answer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function qa_Answer_GetJSONStrByObj(pobjqa_AnswerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjqa_AnswerEN.sf_UpdFldSetStr = pobjqa_AnswerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjqa_AnswerEN);
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
    exports.qa_Answer_GetJSONStrByObj = qa_Answer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function qa_Answer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrqa_AnswerObjLst = new Array();
        if (strJSON === "") {
            return arrqa_AnswerObjLst;
        }
        try {
            arrqa_AnswerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrqa_AnswerObjLst;
        }
        return arrqa_AnswerObjLst;
    }
    exports.qa_Answer_GetObjLstByJSONStr = qa_Answer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrqa_AnswerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function qa_Answer_GetObjLstByJSONObjLst(arrqa_AnswerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrqa_AnswerObjLst = new Array();
        for (const objInFor of arrqa_AnswerObjLstS) {
            const obj1 = qa_Answer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrqa_AnswerObjLst.push(obj1);
        }
        return arrqa_AnswerObjLst;
    }
    exports.qa_Answer_GetObjLstByJSONObjLst = qa_Answer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function qa_Answer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjqa_AnswerEN = new clsqa_AnswerEN_js_1.clsqa_AnswerEN();
        if (strJSON === "") {
            return pobjqa_AnswerEN;
        }
        try {
            pobjqa_AnswerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjqa_AnswerEN;
        }
        return pobjqa_AnswerEN;
    }
    exports.qa_Answer_GetObjByJSONStr = qa_Answer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function qa_Answer_GetCombineCondition(objqa_Answer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId) == true) {
            const strComparisonOp_AnswerId = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerId, objqa_Answer_Cond.answerId, strComparisonOp_AnswerId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_QuestionsId) == true) {
            const strComparisonOp_QuestionsId = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_QuestionsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_QuestionsId, objqa_Answer_Cond.questionsId, strComparisonOp_QuestionsId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Score) == true) {
            const strComparisonOp_Score = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Score, objqa_Answer_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ScoreType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ScoreType, objqa_Answer_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRight) == true) {
            if (objqa_Answer_Cond.isRight == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRight);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRight);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ParentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_ParentId, objqa_Answer_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_VoteCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_VoteCount, objqa_Answer_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRecommend) == true) {
            if (objqa_Answer_Cond.isRecommend == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRecommend);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsRecommend);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TopicId, objqa_Answer_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AnswerTypeId, objqa_Answer_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsSubmit) == true) {
            if (objqa_Answer_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_AppraiseCount, objqa_Answer_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_StuScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_StuScore, objqa_Answer_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TeaScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_TeaScore, objqa_Answer_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_CreateDate, objqa_Answer_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_id_CurrEduCls, objqa_Answer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdUser, objqa_Answer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_UpdDate, objqa_Answer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_Answer_Cond.dicFldComparisonOp, clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objqa_Answer_Cond.dicFldComparisonOp[clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerEN_js_1.clsqa_AnswerEN.con_Memo, objqa_Answer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.qa_Answer_GetCombineCondition = qa_Answer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--qa_Answer(答疑回答),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strAnswerId: 回答Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function qa_Answer_GetUniCondStr_AnswerId(objqa_AnswerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerId = '{0}'", objqa_AnswerEN.answerId);
        return strWhereCond;
    }
    exports.qa_Answer_GetUniCondStr_AnswerId = qa_Answer_GetUniCondStr_AnswerId;
    /**
    *获取唯一性条件串(Uniqueness)--qa_Answer(答疑回答),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strAnswerId: 回答Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function qa_Answer_GetUniCondStr4Update_AnswerId(objqa_AnswerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerId <> '{0}'", objqa_AnswerEN.answerId);
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerId = '{0}'", objqa_AnswerEN.answerId);
        return strWhereCond;
    }
    exports.qa_Answer_GetUniCondStr4Update_AnswerId = qa_Answer_GetUniCondStr4Update_AnswerId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objqa_AnswerENS:源对象
     * @param objqa_AnswerENT:目标对象
    */
    function qa_Answer_CopyObjTo(objqa_AnswerENS, objqa_AnswerENT) {
        objqa_AnswerENT.answerId = objqa_AnswerENS.answerId; //回答Id
        objqa_AnswerENT.questionsId = objqa_AnswerENS.questionsId; //提问Id
        objqa_AnswerENT.answerContent = objqa_AnswerENS.answerContent; //答案内容
        objqa_AnswerENT.score = objqa_AnswerENS.score; //评分
        objqa_AnswerENT.scoreType = objqa_AnswerENS.scoreType; //评分类型
        objqa_AnswerENT.isRight = objqa_AnswerENS.isRight; //是否正确
        objqa_AnswerENT.parentId = objqa_AnswerENS.parentId; //父节点Id
        objqa_AnswerENT.voteCount = objqa_AnswerENS.voteCount; //点赞计数
        objqa_AnswerENT.isRecommend = objqa_AnswerENS.isRecommend; //是否推荐
        objqa_AnswerENT.topicId = objqa_AnswerENS.topicId; //主题Id
        objqa_AnswerENT.answerTypeId = objqa_AnswerENS.answerTypeId; //答案类型ID
        objqa_AnswerENT.isSubmit = objqa_AnswerENS.isSubmit; //是否提交
        objqa_AnswerENT.appraiseCount = objqa_AnswerENS.appraiseCount; //评论数
        objqa_AnswerENT.stuScore = objqa_AnswerENS.stuScore; //学生平均分
        objqa_AnswerENT.teaScore = objqa_AnswerENS.teaScore; //教师评分
        objqa_AnswerENT.createDate = objqa_AnswerENS.createDate; //建立日期
        objqa_AnswerENT.id_CurrEduCls = objqa_AnswerENS.id_CurrEduCls; //教学班流水号
        objqa_AnswerENT.updUser = objqa_AnswerENS.updUser; //修改人
        objqa_AnswerENT.updDate = objqa_AnswerENS.updDate; //修改日期
        objqa_AnswerENT.memo = objqa_AnswerENS.memo; //备注
        objqa_AnswerENT.sf_UpdFldSetStr = objqa_AnswerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.qa_Answer_CopyObjTo = qa_Answer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objqa_AnswerENS:源对象
     * @param objqa_AnswerENT:目标对象
    */
    function qa_Answer_GetObjFromJsonObj(objqa_AnswerENS) {
        const objqa_AnswerENT = new clsqa_AnswerEN_js_1.clsqa_AnswerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_AnswerENT, objqa_AnswerENS);
        return objqa_AnswerENT;
    }
    exports.qa_Answer_GetObjFromJsonObj = qa_Answer_GetObjFromJsonObj;
});
