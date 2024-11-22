/**
* 类名:clsvqa_AnswerWApi
* 表名:vqa_Answer(01120635)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:30
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsvqa_AnswerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vqa_Answer_GetObjFromJsonObj = exports.vqa_Answer_CopyObjTo = exports.vqa_Answer_GetCombineCondition = exports.vqa_Answer_GetObjByJSONStr = exports.vqa_Answer_GetObjLstByJSONObjLst = exports.vqa_Answer_GetObjLstByJSONStr = exports.vqa_Answer_GetJSONStrByObj = exports.vqa_Answer_ReFreshThisCache = exports.vqa_Answer_GetWebApiUrl = exports.vqa_Answer_GetRecCountByCond_Cache = exports.vqa_Answer_GetRecCountByCondAsync = exports.vqa_Answer_IsExistAsync = exports.vqa_Answer_IsExist_Cache = exports.vqa_Answer_IsExist = exports.vqa_Answer_IsExistRecordAsync = exports.vqa_Answer_IsExistRecord_Cache = exports.vqa_Answer_GetObjLstByPagerAsync = exports.vqa_Answer_GetObjLstByPager_Cache = exports.vqa_Answer_GetObjLstByRange = exports.vqa_Answer_GetObjLstByRangeAsync = exports.vqa_Answer_GetTopObjLstAsync = exports.vqa_Answer_GetObjLstByAnswerIdLst_Cache = exports.vqa_Answer_GetObjLstByAnswerIdLstAsync = exports.vqa_Answer_GetSubObjLst_Cache = exports.vqa_Answer_GetObjLst_PureCache = exports.vqa_Answer_GetObjLst_Cache = exports.vqa_Answer_GetObjLst_sessionStorage_PureCache = exports.vqa_Answer_GetObjLst_sessionStorage = exports.vqa_Answer_GetObjLstAsync = exports.vqa_Answer_GetObjLst_localStorage_PureCache = exports.vqa_Answer_GetObjLst_localStorage = exports.vqa_Answer_GetObjLst_ClientCache = exports.vqa_Answer_GetFirstObjAsync = exports.vqa_Answer_GetFirstID = exports.vqa_Answer_GetFirstIDAsync = exports.vqa_Answer_FilterFunByKey = exports.vqa_Answer_SortFunByKey = exports.vqa_Answer_SortFun_Defa_2Fld = exports.vqa_Answer_SortFun_Defa = exports.vqa_Answer_func = exports.vqa_Answer_GetObjByAnswerId_localStorage = exports.vqa_Answer_GetObjByAnswerId_Cache = exports.vqa_Answer_GetObjByAnswerIdAsync = exports.vqa_Answer_ConstructorName = exports.vqa_Answer_Controller = void 0;
    /**
     * v答疑回答(vqa_Answer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvqa_AnswerEN_js_1 = require("../../L0_Entity/InteractManage/clsvqa_AnswerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vqa_Answer_Controller = "vqa_AnswerApi";
    exports.vqa_Answer_ConstructorName = "vqa_Answer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strAnswerId:关键字
    * @returns 对象
    **/
    async function vqa_Answer_GetObjByAnswerIdAsync(strAnswerId) {
        const strThisFuncName = "GetObjByAnswerIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strAnswerId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strAnswerId]不能为空！(In GetObjByAnswerIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！", strAnswerId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByAnswerId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvqa_Answer = vqa_Answer_GetObjFromJsonObj(returnObj);
                return objvqa_Answer;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetObjByAnswerIdAsync = vqa_Answer_GetObjByAnswerIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strAnswerId:所给的关键字
     * @returns 对象
    */
    async function vqa_Answer_GetObjByAnswerId_Cache(strAnswerId, strTopicId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByAnswerId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strAnswerId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strAnswerId]不能为空！(In GetObjByAnswerId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！", strAnswerId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
        try {
            const arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache.filter(x => x.answerId == strAnswerId);
            let objvqa_Answer;
            if (arrvqa_Answer_Sel.length > 0) {
                objvqa_Answer = arrvqa_Answer_Sel[0];
                return objvqa_Answer;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvqa_Answer = await vqa_Answer_GetObjByAnswerIdAsync(strAnswerId);
                    if (objvqa_Answer != null) {
                        vqa_Answer_ReFreshThisCache(strTopicId);
                        return objvqa_Answer;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerId, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vqa_Answer_GetObjByAnswerId_Cache = vqa_Answer_GetObjByAnswerId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strAnswerId:所给的关键字
     * @returns 对象
    */
    async function vqa_Answer_GetObjByAnswerId_localStorage(strAnswerId) {
        const strThisFuncName = "GetObjByAnswerId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strAnswerId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strAnswerId]不能为空！(In GetObjByAnswerId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strAnswerId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strAnswerId]的长度:[{0}]不正确！", strAnswerId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strAnswerId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvqa_Answer_Cache = JSON.parse(strTempObj);
            return objvqa_Answer_Cache;
        }
        try {
            const objvqa_Answer = await vqa_Answer_GetObjByAnswerIdAsync(strAnswerId);
            if (objvqa_Answer != null) {
                localStorage.setItem(strKey, JSON.stringify(objvqa_Answer));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvqa_Answer;
            }
            return objvqa_Answer;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strAnswerId, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vqa_Answer_GetObjByAnswerId_localStorage = vqa_Answer_GetObjByAnswerId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strTopicId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vqa_Answer_func(strInFldName, strOutFldName, strInValue, strTopicId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId_C]的长度:[{0}]不正确！", strTopicId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strAnswerId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvqa_Answer = await vqa_Answer_GetObjByAnswerId_Cache(strAnswerId, strTopicId_C);
        if (objvqa_Answer == null)
            return "";
        return objvqa_Answer.GetFldValue(strOutFldName).toString();
    }
    exports.vqa_Answer_func = vqa_Answer_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Answer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.answerId.localeCompare(b.answerId);
    }
    exports.vqa_Answer_SortFun_Defa = vqa_Answer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Answer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionsId == b.questionsId)
            return a.answerContent.localeCompare(b.answerContent);
        else
            return a.questionsId.localeCompare(b.questionsId);
    }
    exports.vqa_Answer_SortFun_Defa_2Fld = vqa_Answer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Answer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId:
                    return (a, b) => {
                        return a.answerId.localeCompare(b.answerId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsId:
                    return (a, b) => {
                        return a.questionsId.localeCompare(b.questionsId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerContent:
                    return (a, b) => {
                        return a.answerContent.localeCompare(b.answerContent);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ScoreType:
                    return (a, b) => {
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRight:
                    return (a, b) => {
                        if (a.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_qa_PaperId:
                    return (a, b) => {
                        return a.qa_PaperId.localeCompare(b.qa_PaperId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent:
                    return (a, b) => {
                        return a.questionsContent.localeCompare(b.questionsContent);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeId:
                    return (a, b) => {
                        return a.questionsTypeId.localeCompare(b.questionsTypeId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeName:
                    return (a, b) => {
                        return a.questionsTypeName.localeCompare(b.questionsTypeName);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRecommend:
                    return (a, b) => {
                        if (a.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TopicId:
                    return (a, b) => {
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerTypeId:
                    return (a, b) => {
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerCount:
                    return (a, b) => {
                        return a.answerCount - b.answerCount;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName:
                    return (a, b) => {
                        return a.questUserName.localeCompare(b.questUserName);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Answer]中不存在！(in ${exports.vqa_Answer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId:
                    return (a, b) => {
                        return b.answerId.localeCompare(a.answerId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsId:
                    return (a, b) => {
                        return b.questionsId.localeCompare(a.questionsId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerContent:
                    return (a, b) => {
                        return b.answerContent.localeCompare(a.answerContent);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ScoreType:
                    return (a, b) => {
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRight:
                    return (a, b) => {
                        if (b.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_qa_PaperId:
                    return (a, b) => {
                        return b.qa_PaperId.localeCompare(a.qa_PaperId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent:
                    return (a, b) => {
                        return b.questionsContent.localeCompare(a.questionsContent);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeId:
                    return (a, b) => {
                        return b.questionsTypeId.localeCompare(a.questionsTypeId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeName:
                    return (a, b) => {
                        return b.questionsTypeName.localeCompare(a.questionsTypeName);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRecommend:
                    return (a, b) => {
                        if (b.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TopicId:
                    return (a, b) => {
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerTypeId:
                    return (a, b) => {
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerCount:
                    return (a, b) => {
                        return b.answerCount - a.answerCount;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName:
                    return (a, b) => {
                        return b.questUserName.localeCompare(a.questUserName);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Answer]中不存在！(in ${exports.vqa_Answer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vqa_Answer_SortFunByKey = vqa_Answer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vqa_Answer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId:
                return (obj) => {
                    return obj.answerId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsId:
                return (obj) => {
                    return obj.questionsId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerContent:
                return (obj) => {
                    return obj.answerContent === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRight:
                return (obj) => {
                    return obj.isRight === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_qa_PaperId:
                return (obj) => {
                    return obj.qa_PaperId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent:
                return (obj) => {
                    return obj.questionsContent === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeId:
                return (obj) => {
                    return obj.questionsTypeId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeName:
                return (obj) => {
                    return obj.questionsTypeName === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRecommend:
                return (obj) => {
                    return obj.isRecommend === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerCount:
                return (obj) => {
                    return obj.answerCount === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName:
                return (obj) => {
                    return obj.questUserName === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vqa_Answer]中不存在！(in ${exports.vqa_Answer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vqa_Answer_FilterFunByKey = vqa_Answer_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vqa_Answer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetFirstIDAsync = vqa_Answer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vqa_Answer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetFirstID = vqa_Answer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vqa_Answer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvqa_Answer = vqa_Answer_GetObjFromJsonObj(returnObj);
                return objvqa_Answer;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetFirstObjAsync = vqa_Answer_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_ClientCache(strTopicId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strTopicId);
        clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvqa_AnswerExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvqa_AnswerObjLst_T = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerExObjLst_Cache);
            return arrvqa_AnswerObjLst_T;
        }
        try {
            const arrvqa_AnswerExObjLst = await vqa_Answer_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvqa_AnswerExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_AnswerExObjLst.length);
            console.log(strInfo);
            return arrvqa_AnswerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Answer_GetObjLst_ClientCache = vqa_Answer_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_localStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strTopicId);
        clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvqa_AnswerExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvqa_AnswerObjLst_T = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerExObjLst_Cache);
            return arrvqa_AnswerObjLst_T;
        }
        try {
            const arrvqa_AnswerExObjLst = await vqa_Answer_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvqa_AnswerExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_AnswerExObjLst.length);
            console.log(strInfo);
            return arrvqa_AnswerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Answer_GetObjLst_localStorage = vqa_Answer_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_localStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvqa_AnswerObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvqa_AnswerObjLst_Cache;
        }
        else
            return null;
    }
    exports.vqa_Answer_GetObjLst_localStorage_PureCache = vqa_Answer_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vqa_Answer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetObjLstAsync = vqa_Answer_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_sessionStorage(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strTopicId);
        clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvqa_AnswerExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvqa_AnswerObjLst_T = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerExObjLst_Cache);
            return arrvqa_AnswerObjLst_T;
        }
        try {
            const arrvqa_AnswerExObjLst = await vqa_Answer_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvqa_AnswerExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_AnswerExObjLst.length);
            console.log(strInfo);
            return arrvqa_AnswerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Answer_GetObjLst_sessionStorage = vqa_Answer_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_sessionStorage_PureCache(strTopicId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("TopicId='{0}'", strTopicId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strTopicId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvqa_AnswerObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvqa_AnswerObjLst_Cache;
        }
        else
            return null;
    }
    exports.vqa_Answer_GetObjLst_sessionStorage_PureCache = vqa_Answer_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_Cache(strTopicId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[TopicId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicId]的长度:[{0}]不正确！", strTopicId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvqa_AnswerObjLst_Cache;
        switch (clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheModeId) {
            case "04": //sessionStorage
                arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_sessionStorage(strTopicId);
                break;
            case "03": //localStorage
                arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_localStorage(strTopicId);
                break;
            case "02": //ClientCache
                arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_ClientCache(strTopicId);
                break;
            default:
                arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_ClientCache(strTopicId);
                break;
        }
        const arrvqa_AnswerObjLst = vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerObjLst_Cache);
        return arrvqa_AnswerObjLst_Cache;
    }
    exports.vqa_Answer_GetObjLst_Cache = vqa_Answer_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Answer_GetObjLst_PureCache(strTopicId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvqa_AnswerObjLst_Cache;
        switch (clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheModeId) {
            case "04": //sessionStorage
                arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_sessionStorage_PureCache(strTopicId);
                break;
            case "03": //localStorage
                arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_localStorage_PureCache(strTopicId);
                break;
            case "02": //ClientCache
                arrvqa_AnswerObjLst_Cache = null;
                break;
            default:
                arrvqa_AnswerObjLst_Cache = null;
                break;
        }
        return arrvqa_AnswerObjLst_Cache;
    }
    exports.vqa_Answer_GetObjLst_PureCache = vqa_Answer_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrAnswerId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vqa_Answer_GetSubObjLst_Cache(objvqa_Answer_Cond, strTopicId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
        let arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache;
        if (objvqa_Answer_Cond.sf_FldComparisonOp == null || objvqa_Answer_Cond.sf_FldComparisonOp == "")
            return arrvqa_Answer_Sel;
        const dicFldComparisonOp = JSON.parse(objvqa_Answer_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Answer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvqa_Answer_Cond), exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Answer_GetSubObjLst_Cache = vqa_Answer_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrAnswerId:关键字列表
    * @returns 对象列表
    **/
    async function vqa_Answer_GetObjLstByAnswerIdLstAsync(arrAnswerId) {
        const strThisFuncName = "GetObjLstByAnswerIdLstAsync";
        const strAction = "GetObjLstByAnswerIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetObjLstByAnswerIdLstAsync = vqa_Answer_GetObjLstByAnswerIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrAnswerIdLst:关键字列表
     * @returns 对象列表
    */
    async function vqa_Answer_GetObjLstByAnswerIdLst_Cache(arrAnswerIdLst, strTopicId) {
        const strThisFuncName = "GetObjLstByAnswerIdLst_Cache";
        try {
            const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
            const arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache.filter(x => arrAnswerIdLst.indexOf(x.answerId) > -1);
            return arrvqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerIdLst.join(","), exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Answer_GetObjLstByAnswerIdLst_Cache = vqa_Answer_GetObjLstByAnswerIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vqa_Answer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetTopObjLstAsync = vqa_Answer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Answer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetObjLstByRangeAsync = vqa_Answer_GetObjLstByRangeAsync;
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
    async function vqa_Answer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetObjLstByRange = vqa_Answer_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vqa_Answer_GetObjLstByPager_Cache(objPagerPara, strTopicId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
        if (arrvqa_AnswerObjLst_Cache.length == 0)
            return arrvqa_AnswerObjLst_Cache;
        let arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvqa_Answer_Cond = new clsvqa_AnswerEN_js_1.clsvqa_AnswerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_Answer_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvqa_AnswerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Answer_Sel.length == 0)
                return arrvqa_Answer_Sel;
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
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(vqa_Answer_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.sort(objPagerPara.sortFun);
            }
            arrvqa_Answer_Sel = arrvqa_Answer_Sel.slice(intStart, intEnd);
            return arrvqa_Answer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Answer_GetObjLstByPager_Cache = vqa_Answer_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Answer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Answer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Answer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetObjLstByPagerAsync = vqa_Answer_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrAnswerId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vqa_Answer_IsExistRecord_Cache(objvqa_Answer_Cond, strTopicId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
        if (arrvqa_AnswerObjLst_Cache == null)
            return false;
        let arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache;
        if (objvqa_Answer_Cond.sf_FldComparisonOp == null || objvqa_Answer_Cond.sf_FldComparisonOp == "")
            return arrvqa_Answer_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvqa_Answer_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Answer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Answer_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvqa_Answer_Cond), exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vqa_Answer_IsExistRecord_Cache = vqa_Answer_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vqa_Answer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_IsExistRecordAsync = vqa_Answer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strAnswerId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vqa_Answer_IsExist(strAnswerId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_IsExist = vqa_Answer_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strAnswerId:所给的关键字
     * @returns 对象
    */
    async function vqa_Answer_IsExist_Cache(strAnswerId, strTopicId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
        if (arrvqa_AnswerObjLst_Cache == null)
            return false;
        try {
            const arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache.filter(x => x.answerId == strAnswerId);
            if (arrvqa_Answer_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strAnswerId, exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vqa_Answer_IsExist_Cache = vqa_Answer_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strAnswerId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vqa_Answer_IsExistAsync(strAnswerId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_IsExistAsync = vqa_Answer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vqa_Answer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Answer_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Answer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Answer_GetRecCountByCondAsync = vqa_Answer_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvqa_Answer_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vqa_Answer_GetRecCountByCond_Cache(objvqa_Answer_Cond, strTopicId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvqa_AnswerObjLst_Cache = await vqa_Answer_GetObjLst_Cache(strTopicId);
        if (arrvqa_AnswerObjLst_Cache == null)
            return 0;
        let arrvqa_Answer_Sel = arrvqa_AnswerObjLst_Cache;
        if (objvqa_Answer_Cond.sf_FldComparisonOp == null || objvqa_Answer_Cond.sf_FldComparisonOp == "")
            return arrvqa_Answer_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvqa_Answer_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_AnswerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Answer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Answer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Answer_Sel = arrvqa_Answer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvqa_Answer_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvqa_Answer_Cond), exports.vqa_Answer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vqa_Answer_GetRecCountByCond_Cache = vqa_Answer_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vqa_Answer_GetWebApiUrl(strController, strAction) {
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
    exports.vqa_Answer_GetWebApiUrl = vqa_Answer_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vqa_Answer_ReFreshThisCache(strTopicId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN._CurrTabName, strTopicId);
            switch (clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.CacheModeId) {
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
    exports.vqa_Answer_ReFreshThisCache = vqa_Answer_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Answer_GetJSONStrByObj(pobjvqa_AnswerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvqa_AnswerEN);
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
    exports.vqa_Answer_GetJSONStrByObj = vqa_Answer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vqa_Answer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvqa_AnswerObjLst = new Array();
        if (strJSON === "") {
            return arrvqa_AnswerObjLst;
        }
        try {
            arrvqa_AnswerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvqa_AnswerObjLst;
        }
        return arrvqa_AnswerObjLst;
    }
    exports.vqa_Answer_GetObjLstByJSONStr = vqa_Answer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvqa_AnswerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vqa_Answer_GetObjLstByJSONObjLst(arrvqa_AnswerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvqa_AnswerObjLst = new Array();
        for (const objInFor of arrvqa_AnswerObjLstS) {
            const obj1 = vqa_Answer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvqa_AnswerObjLst.push(obj1);
        }
        return arrvqa_AnswerObjLst;
    }
    exports.vqa_Answer_GetObjLstByJSONObjLst = vqa_Answer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Answer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvqa_AnswerEN = new clsvqa_AnswerEN_js_1.clsvqa_AnswerEN();
        if (strJSON === "") {
            return pobjvqa_AnswerEN;
        }
        try {
            pobjvqa_AnswerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvqa_AnswerEN;
        }
        return pobjvqa_AnswerEN;
    }
    exports.vqa_Answer_GetObjByJSONStr = vqa_Answer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vqa_Answer_GetCombineCondition(objvqa_Answer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId) == true) {
            const strComparisonOp_AnswerId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerId, objvqa_Answer_Cond.answerId, strComparisonOp_AnswerId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsId) == true) {
            const strComparisonOp_QuestionsId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsId, objvqa_Answer_Cond.questionsId, strComparisonOp_QuestionsId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_score) == true) {
            const strComparisonOp_score = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_score, objvqa_Answer_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ScoreType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ScoreType, objvqa_Answer_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRight) == true) {
            if (objvqa_Answer_Cond.isRight == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRight);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRight);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_ParentId, objvqa_Answer_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_VoteCount, objvqa_Answer_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdUser, objvqa_Answer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserName, objvqa_Answer_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UpdDate, objvqa_Answer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_Memo, objvqa_Answer_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_qa_PaperId) == true) {
            const strComparisonOp_qa_PaperId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_qa_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_qa_PaperId, objvqa_Answer_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent) == true) {
            const strComparisonOp_QuestionsContent = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsContent, objvqa_Answer_Cond.questionsContent, strComparisonOp_QuestionsContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperId, objvqa_Answer_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeId) == true) {
            const strComparisonOp_QuestionsTypeId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeId, objvqa_Answer_Cond.questionsTypeId, strComparisonOp_QuestionsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeName) == true) {
            const strComparisonOp_QuestionsTypeName = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestionsTypeName, objvqa_Answer_Cond.questionsTypeName, strComparisonOp_QuestionsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRecommend) == true) {
            if (objvqa_Answer_Cond.isRecommend == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRecommend);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsRecommend);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TopicId, objvqa_Answer_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerTypeId, objvqa_Answer_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsSubmit) == true) {
            if (objvqa_Answer_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerCount) == true) {
            const strComparisonOp_AnswerCount = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AnswerCount, objvqa_Answer_Cond.answerCount, strComparisonOp_AnswerCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_PaperTitle, objvqa_Answer_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName) == true) {
            const strComparisonOp_QuestUserName = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_QuestUserName, objvqa_Answer_Cond.questUserName, strComparisonOp_QuestUserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_AppraiseCount, objvqa_Answer_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_StuScore, objvqa_Answer_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_TeaScore, objvqa_Answer_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_UserId, objvqa_Answer_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Answer_Cond.dicFldComparisonOp, clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvqa_Answer_Cond.dicFldComparisonOp[clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_AnswerEN_js_1.clsvqa_AnswerEN.con_id_CurrEduCls, objvqa_Answer_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.vqa_Answer_GetCombineCondition = vqa_Answer_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvqa_AnswerENS:源对象
     * @param objvqa_AnswerENT:目标对象
    */
    function vqa_Answer_CopyObjTo(objvqa_AnswerENS, objvqa_AnswerENT) {
        objvqa_AnswerENT.answerId = objvqa_AnswerENS.answerId; //回答Id
        objvqa_AnswerENT.questionsId = objvqa_AnswerENS.questionsId; //提问Id
        objvqa_AnswerENT.answerContent = objvqa_AnswerENS.answerContent; //答案内容
        objvqa_AnswerENT.score = objvqa_AnswerENS.score; //评分
        objvqa_AnswerENT.scoreType = objvqa_AnswerENS.scoreType; //评分类型
        objvqa_AnswerENT.isRight = objvqa_AnswerENS.isRight; //是否正确
        objvqa_AnswerENT.parentId = objvqa_AnswerENS.parentId; //父节点Id
        objvqa_AnswerENT.voteCount = objvqa_AnswerENS.voteCount; //点赞计数
        objvqa_AnswerENT.updUser = objvqa_AnswerENS.updUser; //修改人
        objvqa_AnswerENT.userName = objvqa_AnswerENS.userName; //用户名
        objvqa_AnswerENT.updDate = objvqa_AnswerENS.updDate; //修改日期
        objvqa_AnswerENT.memo = objvqa_AnswerENS.memo; //备注
        objvqa_AnswerENT.qa_PaperId = objvqa_AnswerENS.qa_PaperId; //论文答疑Id
        objvqa_AnswerENT.questionsContent = objvqa_AnswerENS.questionsContent; //提问内容
        objvqa_AnswerENT.paperId = objvqa_AnswerENS.paperId; //论文Id
        objvqa_AnswerENT.questionsTypeId = objvqa_AnswerENS.questionsTypeId; //问题类型Id
        objvqa_AnswerENT.questionsTypeName = objvqa_AnswerENS.questionsTypeName; //问题类型名称
        objvqa_AnswerENT.isRecommend = objvqa_AnswerENS.isRecommend; //是否推荐
        objvqa_AnswerENT.topicId = objvqa_AnswerENS.topicId; //主题Id
        objvqa_AnswerENT.answerTypeId = objvqa_AnswerENS.answerTypeId; //答案类型ID
        objvqa_AnswerENT.isSubmit = objvqa_AnswerENS.isSubmit; //是否提交
        objvqa_AnswerENT.answerCount = objvqa_AnswerENS.answerCount; //回答计数
        objvqa_AnswerENT.paperTitle = objvqa_AnswerENS.paperTitle; //论文标题
        objvqa_AnswerENT.questUserName = objvqa_AnswerENS.questUserName; //QuestUserName
        objvqa_AnswerENT.appraiseCount = objvqa_AnswerENS.appraiseCount; //评论数
        objvqa_AnswerENT.stuScore = objvqa_AnswerENS.stuScore; //学生平均分
        objvqa_AnswerENT.teaScore = objvqa_AnswerENS.teaScore; //教师评分
        objvqa_AnswerENT.userId = objvqa_AnswerENS.userId; //用户ID
        objvqa_AnswerENT.id_CurrEduCls = objvqa_AnswerENS.id_CurrEduCls; //教学班流水号
    }
    exports.vqa_Answer_CopyObjTo = vqa_Answer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvqa_AnswerENS:源对象
     * @param objvqa_AnswerENT:目标对象
    */
    function vqa_Answer_GetObjFromJsonObj(objvqa_AnswerENS) {
        const objvqa_AnswerENT = new clsvqa_AnswerEN_js_1.clsvqa_AnswerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_AnswerENT, objvqa_AnswerENS);
        return objvqa_AnswerENT;
    }
    exports.vqa_Answer_GetObjFromJsonObj = vqa_Answer_GetObjFromJsonObj;
});
