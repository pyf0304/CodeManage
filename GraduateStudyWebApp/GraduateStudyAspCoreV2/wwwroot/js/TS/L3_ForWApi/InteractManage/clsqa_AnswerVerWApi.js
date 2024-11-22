/**
* 类名:clsqa_AnswerVerWApi
* 表名:qa_AnswerVer(01120756)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:12
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsqa_AnswerVerEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.qa_AnswerVer_GetObjFromJsonObj = exports.qa_AnswerVer_CopyObjTo = exports.qa_AnswerVer_GetUniCondStr4Update_AnswerVId = exports.qa_AnswerVer_GetUniCondStr_AnswerVId = exports.qa_AnswerVer_GetCombineCondition = exports.qa_AnswerVer_GetObjByJSONStr = exports.qa_AnswerVer_GetObjLstByJSONObjLst = exports.qa_AnswerVer_GetObjLstByJSONStr = exports.qa_AnswerVer_GetJSONStrByObj = exports.qa_AnswerVer_CheckProperty4Update = exports.qa_AnswerVer_CheckPropertyNew = exports.qa_AnswerVer_ReFreshThisCache = exports.qa_AnswerVer_ReFreshCache = exports.qa_AnswerVer_GetWebApiUrl = exports.qa_AnswerVer_GetMaxStrIdByPrefix = exports.qa_AnswerVer_GetRecCountByCond_Cache = exports.qa_AnswerVer_GetRecCountByCondAsync = exports.qa_AnswerVer_IsExistAsync = exports.qa_AnswerVer_IsExist_Cache = exports.qa_AnswerVer_IsExist = exports.qa_AnswerVer_IsExistRecordAsync = exports.qa_AnswerVer_IsExistRecord_Cache = exports.qa_AnswerVer_UpdateWithConditionAsync = exports.qa_AnswerVer_UpdateRecordAsync = exports.qa_AnswerVer_AddNewRecordWithReturnKey = exports.qa_AnswerVer_AddNewRecordWithReturnKeyAsync = exports.qa_AnswerVer_AddNewRecordAsync = exports.qa_AnswerVer_Delqa_AnswerVersByCondAsync = exports.qa_AnswerVer_Delqa_AnswerVersAsync = exports.qa_AnswerVer_DelRecordAsync = exports.qa_AnswerVer_GetObjLstByPagerAsync = exports.qa_AnswerVer_GetObjLstByPager_Cache = exports.qa_AnswerVer_GetObjLstByRange = exports.qa_AnswerVer_GetObjLstByRangeAsync = exports.qa_AnswerVer_GetTopObjLstAsync = exports.qa_AnswerVer_GetObjLstByAnswerVIdLst_Cache = exports.qa_AnswerVer_GetObjLstByAnswerVIdLstAsync = exports.qa_AnswerVer_GetSubObjLst_Cache = exports.qa_AnswerVer_GetObjLst_PureCache = exports.qa_AnswerVer_GetObjLst_Cache = exports.qa_AnswerVer_GetObjLst_sessionStorage_PureCache = exports.qa_AnswerVer_GetObjLst_sessionStorage = exports.qa_AnswerVer_GetObjLstAsync = exports.qa_AnswerVer_GetObjLst_localStorage_PureCache = exports.qa_AnswerVer_GetObjLst_localStorage = exports.qa_AnswerVer_GetObjLst_ClientCache = exports.qa_AnswerVer_GetFirstObjAsync = exports.qa_AnswerVer_GetFirstID = exports.qa_AnswerVer_GetFirstIDAsync = exports.qa_AnswerVer_funcKey = exports.qa_AnswerVer_FilterFunByKey = exports.qa_AnswerVer_SortFunByKey = exports.qa_AnswerVer_SortFun_Defa_2Fld = exports.qa_AnswerVer_SortFun_Defa = exports.qa_AnswerVer_func = exports.qa_AnswerVer_UpdateObjInLst_Cache = exports.qa_AnswerVer_GetObjByAnswerVId_localStorage = exports.qa_AnswerVer_GetObjByAnswerVId_Cache = exports.qa_AnswerVer_GetObjByAnswerVIdAsync = exports.qa_AnswerVer_ConstructorName = exports.qa_AnswerVer_Controller = void 0;
    /**
     * 答疑回答历史V(qa_AnswerVer)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsqa_AnswerVerEN_js_1 = require("../../L0_Entity/InteractManage/clsqa_AnswerVerEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.qa_AnswerVer_Controller = "qa_AnswerVerApi";
    exports.qa_AnswerVer_ConstructorName = "qa_AnswerVer";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngAnswerVId:关键字
    * @returns 对象
    **/
    async function qa_AnswerVer_GetObjByAnswerVIdAsync(lngAnswerVId) {
        const strThisFuncName = "GetObjByAnswerVIdAsync";
        if (lngAnswerVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngAnswerVId]不能为空！(In clsqa_AnswerVerWApi.GetObjByAnswerVIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByAnswerVId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngAnswerVId": lngAnswerVId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objqa_AnswerVer = qa_AnswerVer_GetObjFromJsonObj(returnObj);
                return objqa_AnswerVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetObjByAnswerVIdAsync = qa_AnswerVer_GetObjByAnswerVIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngAnswerVId:所给的关键字
     * @returns 对象
    */
    async function qa_AnswerVer_GetObjByAnswerVId_Cache(lngAnswerVId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByAnswerVId_Cache";
        if (lngAnswerVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngAnswerVId]不能为空！(In clsqa_AnswerVerWApi.GetObjByAnswerVId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
        try {
            const arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache.filter(x => x.answerVId == lngAnswerVId);
            let objqa_AnswerVer;
            if (arrqa_AnswerVer_Sel.length > 0) {
                objqa_AnswerVer = arrqa_AnswerVer_Sel[0];
                return objqa_AnswerVer;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objqa_AnswerVer_Const = await qa_AnswerVer_GetObjByAnswerVIdAsync(lngAnswerVId);
                    if (objqa_AnswerVer_Const != null) {
                        qa_AnswerVer_ReFreshThisCache();
                        return objqa_AnswerVer_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngAnswerVId, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.qa_AnswerVer_GetObjByAnswerVId_Cache = qa_AnswerVer_GetObjByAnswerVId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngAnswerVId:所给的关键字
     * @returns 对象
    */
    async function qa_AnswerVer_GetObjByAnswerVId_localStorage(lngAnswerVId) {
        const strThisFuncName = "GetObjByAnswerVId_localStorage";
        if (lngAnswerVId == 0) {
            const strMsg = (0, clsString_js_2.Format)("参数:[lngAnswerVId]不能为空！(In clsqa_AnswerVerWApi.GetObjByAnswerVId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName, lngAnswerVId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objqa_AnswerVer_Cache = JSON.parse(strTempObj);
            return objqa_AnswerVer_Cache;
        }
        try {
            const objqa_AnswerVer = await qa_AnswerVer_GetObjByAnswerVIdAsync(lngAnswerVId);
            if (objqa_AnswerVer != null) {
                localStorage.setItem(strKey, JSON.stringify(objqa_AnswerVer));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objqa_AnswerVer;
            }
            return objqa_AnswerVer;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngAnswerVId, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.qa_AnswerVer_GetObjByAnswerVId_localStorage = qa_AnswerVer_GetObjByAnswerVId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objqa_AnswerVer:所给的对象
     * @returns 对象
    */
    async function qa_AnswerVer_UpdateObjInLst_Cache(objqa_AnswerVer) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
            const obj = arrqa_AnswerVerObjLst_Cache.find(x => x.answerVId == objqa_AnswerVer.answerVId);
            if (obj != null) {
                objqa_AnswerVer.answerVId = obj.answerVId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objqa_AnswerVer);
            }
            else {
                arrqa_AnswerVerObjLst_Cache.push(objqa_AnswerVer);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.qa_AnswerVer_UpdateObjInLst_Cache = qa_AnswerVer_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
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
    async function qa_AnswerVer_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngAnswerVId = Number(strInValue);
        if (lngAnswerVId == 0) {
            return "";
        }
        const objqa_AnswerVer = await qa_AnswerVer_GetObjByAnswerVId_Cache(lngAnswerVId);
        if (objqa_AnswerVer == null)
            return "";
        if (objqa_AnswerVer.GetFldValue(strOutFldName) == null)
            return "";
        return objqa_AnswerVer.GetFldValue(strOutFldName).toString();
    }
    exports.qa_AnswerVer_func = qa_AnswerVer_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_AnswerVer_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.answerVId - b.answerVId;
    }
    exports.qa_AnswerVer_SortFun_Defa = qa_AnswerVer_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_AnswerVer_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.answerId == b.answerId)
            return a.questionsId.localeCompare(b.questionsId);
        else
            return a.answerId.localeCompare(b.answerId);
    }
    exports.qa_AnswerVer_SortFun_Defa_2Fld = qa_AnswerVer_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function qa_AnswerVer_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId:
                    return (a, b) => {
                        return a.answerVId - b.answerVId;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerId:
                    return (a, b) => {
                        return a.answerId.localeCompare(b.answerId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_QuestionsId:
                    return (a, b) => {
                        return a.questionsId.localeCompare(b.questionsId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerContent:
                    return (a, b) => {
                        if (a.answerContent == null)
                            return -1;
                        if (b.answerContent == null)
                            return 1;
                        return a.answerContent.localeCompare(b.answerContent);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ScoreType:
                    return (a, b) => {
                        if (a.scoreType == null)
                            return -1;
                        if (b.scoreType == null)
                            return 1;
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRight:
                    return (a, b) => {
                        if (a.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ParentId:
                    return (a, b) => {
                        if (a.parentId == null)
                            return -1;
                        if (b.parentId == null)
                            return 1;
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRecommend:
                    return (a, b) => {
                        if (a.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (a.answerTypeId == null)
                            return -1;
                        if (b.answerTypeId == null)
                            return 1;
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[qa_AnswerVer]中不存在！(in ${exports.qa_AnswerVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId:
                    return (a, b) => {
                        return b.answerVId - a.answerVId;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerId:
                    return (a, b) => {
                        return b.answerId.localeCompare(a.answerId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_QuestionsId:
                    return (a, b) => {
                        return b.questionsId.localeCompare(a.questionsId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerContent:
                    return (a, b) => {
                        if (b.answerContent == null)
                            return -1;
                        if (a.answerContent == null)
                            return 1;
                        return b.answerContent.localeCompare(a.answerContent);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ScoreType:
                    return (a, b) => {
                        if (b.scoreType == null)
                            return -1;
                        if (a.scoreType == null)
                            return 1;
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRight:
                    return (a, b) => {
                        if (b.isRight == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ParentId:
                    return (a, b) => {
                        if (b.parentId == null)
                            return -1;
                        if (a.parentId == null)
                            return 1;
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRecommend:
                    return (a, b) => {
                        if (b.isRecommend == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (b.answerTypeId == null)
                            return -1;
                        if (a.answerTypeId == null)
                            return 1;
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[qa_AnswerVer]中不存在！(in ${exports.qa_AnswerVer_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.qa_AnswerVer_SortFunByKey = qa_AnswerVer_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function qa_AnswerVer_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId:
                return (obj) => {
                    return obj.answerVId === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerId:
                return (obj) => {
                    return obj.answerId === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_QuestionsId:
                return (obj) => {
                    return obj.questionsId === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerContent:
                return (obj) => {
                    return obj.answerContent === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRight:
                return (obj) => {
                    return obj.isRight === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRecommend:
                return (obj) => {
                    return obj.isRecommend === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[qa_AnswerVer]中不存在！(in ${exports.qa_AnswerVer_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.qa_AnswerVer_FilterFunByKey = qa_AnswerVer_FilterFunByKey;
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
    async function qa_AnswerVer_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrqa_AnswerVer = await qa_AnswerVer_GetObjLst_Cache();
        if (arrqa_AnswerVer == null)
            return [];
        let arrqa_AnswerVer_Sel = arrqa_AnswerVer;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrqa_AnswerVer_Sel.length == 0)
            return [];
        return arrqa_AnswerVer_Sel.map(x => x.answerVId);
    }
    exports.qa_AnswerVer_funcKey = qa_AnswerVer_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function qa_AnswerVer_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetFirstIDAsync = qa_AnswerVer_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function qa_AnswerVer_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetFirstID = qa_AnswerVer_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function qa_AnswerVer_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const objqa_AnswerVer = qa_AnswerVer_GetObjFromJsonObj(returnObj);
                return objqa_AnswerVer;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetFirstObjAsync = qa_AnswerVer_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrqa_AnswerVerExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrqa_AnswerVerObjLst_T = qa_AnswerVer_GetObjLstByJSONObjLst(arrqa_AnswerVerExObjLst_Cache);
            return arrqa_AnswerVerObjLst_T;
        }
        try {
            const arrqa_AnswerVerExObjLst = await qa_AnswerVer_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrqa_AnswerVerExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerVerExObjLst.length);
            console.log(strInfo);
            return arrqa_AnswerVerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_AnswerVer_GetObjLst_ClientCache = qa_AnswerVer_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrqa_AnswerVerExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrqa_AnswerVerObjLst_T = qa_AnswerVer_GetObjLstByJSONObjLst(arrqa_AnswerVerExObjLst_Cache);
            return arrqa_AnswerVerObjLst_T;
        }
        try {
            const arrqa_AnswerVerExObjLst = await qa_AnswerVer_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrqa_AnswerVerExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerVerExObjLst.length);
            console.log(strInfo);
            return arrqa_AnswerVerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_AnswerVer_GetObjLst_localStorage = qa_AnswerVer_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrqa_AnswerVerObjLst_Cache = JSON.parse(strTempObjLst);
            return arrqa_AnswerVerObjLst_Cache;
        }
        else
            return null;
    }
    exports.qa_AnswerVer_GetObjLst_localStorage_PureCache = qa_AnswerVer_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function qa_AnswerVer_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_AnswerVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetObjLstAsync = qa_AnswerVer_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
        if ((0, clsString_js_2.IsNullOrEmpty)(clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrqa_AnswerVerExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrqa_AnswerVerObjLst_T = qa_AnswerVer_GetObjLstByJSONObjLst(arrqa_AnswerVerExObjLst_Cache);
            return arrqa_AnswerVerObjLst_T;
        }
        try {
            const arrqa_AnswerVerExObjLst = await qa_AnswerVer_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrqa_AnswerVerExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrqa_AnswerVerExObjLst.length);
            console.log(strInfo);
            return arrqa_AnswerVerExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.qa_AnswerVer_GetObjLst_sessionStorage = qa_AnswerVer_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrqa_AnswerVerObjLst_Cache = JSON.parse(strTempObjLst);
            return arrqa_AnswerVerObjLst_Cache;
        }
        else
            return null;
    }
    exports.qa_AnswerVer_GetObjLst_sessionStorage_PureCache = qa_AnswerVer_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrqa_AnswerVerObjLst_Cache;
        switch (clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheModeId) {
            case "04": //sessionStorage
                arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_ClientCache();
                break;
            default:
                arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_ClientCache();
                break;
        }
        const arrqa_AnswerVerObjLst = qa_AnswerVer_GetObjLstByJSONObjLst(arrqa_AnswerVerObjLst_Cache);
        return arrqa_AnswerVerObjLst_Cache;
    }
    exports.qa_AnswerVer_GetObjLst_Cache = qa_AnswerVer_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function qa_AnswerVer_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrqa_AnswerVerObjLst_Cache;
        switch (clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheModeId) {
            case "04": //sessionStorage
                arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrqa_AnswerVerObjLst_Cache = null;
                break;
            default:
                arrqa_AnswerVerObjLst_Cache = null;
                break;
        }
        return arrqa_AnswerVerObjLst_Cache;
    }
    exports.qa_AnswerVer_GetObjLst_PureCache = qa_AnswerVer_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngAnswerVId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function qa_AnswerVer_GetSubObjLst_Cache(objqa_AnswerVer_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
        let arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache;
        if (objqa_AnswerVer_Cond.sf_FldComparisonOp == null || objqa_AnswerVer_Cond.sf_FldComparisonOp == "")
            return arrqa_AnswerVer_Sel;
        const dicFldComparisonOp = JSON.parse(objqa_AnswerVer_Cond.sf_FldComparisonOp);
        //console.log("clsqa_AnswerVerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_AnswerVer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_AnswerVer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrqa_AnswerVer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objqa_AnswerVer_Cond), exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_AnswerVer_GetSubObjLst_Cache = qa_AnswerVer_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrAnswerVId:关键字列表
    * @returns 对象列表
    **/
    async function qa_AnswerVer_GetObjLstByAnswerVIdLstAsync(arrAnswerVId) {
        const strThisFuncName = "GetObjLstByAnswerVIdLstAsync";
        const strAction = "GetObjLstByAnswerVIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerVId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_AnswerVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetObjLstByAnswerVIdLstAsync = qa_AnswerVer_GetObjLstByAnswerVIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngAnswerVIdLst:关键字列表
     * @returns 对象列表
    */
    async function qa_AnswerVer_GetObjLstByAnswerVIdLst_Cache(arrAnswerVIdLst) {
        const strThisFuncName = "GetObjLstByAnswerVIdLst_Cache";
        try {
            const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
            const arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache.filter(x => arrAnswerVIdLst.indexOf(x.answerVId) > -1);
            return arrqa_AnswerVer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrAnswerVIdLst.join(","), exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.qa_AnswerVer_GetObjLstByAnswerVIdLst_Cache = qa_AnswerVer_GetObjLstByAnswerVIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function qa_AnswerVer_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_AnswerVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetTopObjLstAsync = qa_AnswerVer_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function qa_AnswerVer_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_AnswerVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetObjLstByRangeAsync = qa_AnswerVer_GetObjLstByRangeAsync;
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
    async function qa_AnswerVer_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetObjLstByRange = qa_AnswerVer_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function qa_AnswerVer_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
        if (arrqa_AnswerVerObjLst_Cache.length == 0)
            return arrqa_AnswerVerObjLst_Cache;
        let arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objqa_AnswerVer_Cond = new clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_AnswerVer_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsqa_AnswerVerWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_AnswerVer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_AnswerVer_Sel.length == 0)
                return arrqa_AnswerVer_Sel;
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
                arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.sort(qa_AnswerVer_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.sort(objPagerPara.sortFun);
            }
            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.slice(intStart, intEnd);
            return arrqa_AnswerVer_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.qa_AnswerVer_GetObjLstByPager_Cache = qa_AnswerVer_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function qa_AnswerVer_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = qa_AnswerVer_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetObjLstByPagerAsync = qa_AnswerVer_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngAnswerVId:关键字
    * @returns 获取删除的结果
    **/
    async function qa_AnswerVer_DelRecordAsync(lngAnswerVId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, lngAnswerVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_DelRecordAsync = qa_AnswerVer_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrAnswerVId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function qa_AnswerVer_Delqa_AnswerVersAsync(arrAnswerVId) {
        const strThisFuncName = "Delqa_AnswerVersAsync";
        const strAction = "Delqa_AnswerVers";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrAnswerVId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_Delqa_AnswerVersAsync = qa_AnswerVer_Delqa_AnswerVersAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function qa_AnswerVer_Delqa_AnswerVersByCondAsync(strWhereCond) {
        const strThisFuncName = "Delqa_AnswerVersByCondAsync";
        const strAction = "Delqa_AnswerVersByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_Delqa_AnswerVersByCondAsync = qa_AnswerVer_Delqa_AnswerVersByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objqa_AnswerVerEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function qa_AnswerVer_AddNewRecordAsync(objqa_AnswerVerEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objqa_AnswerVerEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_AddNewRecordAsync = qa_AnswerVer_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objqa_AnswerVerEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function qa_AnswerVer_AddNewRecordWithReturnKeyAsync(objqa_AnswerVerEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_AddNewRecordWithReturnKeyAsync = qa_AnswerVer_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objqa_AnswerVerEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function qa_AnswerVer_AddNewRecordWithReturnKey(objqa_AnswerVerEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objqa_AnswerVerEN.answerVId === null || objqa_AnswerVerEN.answerVId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerVerEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_AddNewRecordWithReturnKey = qa_AnswerVer_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objqa_AnswerVerEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function qa_AnswerVer_UpdateRecordAsync(objqa_AnswerVerEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objqa_AnswerVerEN.sf_UpdFldSetStr === undefined || objqa_AnswerVerEN.sf_UpdFldSetStr === null || objqa_AnswerVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_AnswerVerEN.answerVId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_UpdateRecordAsync = qa_AnswerVer_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objqa_AnswerVerEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function qa_AnswerVer_UpdateWithConditionAsync(objqa_AnswerVerEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objqa_AnswerVerEN.sf_UpdFldSetStr === undefined || objqa_AnswerVerEN.sf_UpdFldSetStr === null || objqa_AnswerVerEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objqa_AnswerVerEN.answerVId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        objqa_AnswerVerEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objqa_AnswerVerEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_UpdateWithConditionAsync = qa_AnswerVer_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngAnswerVId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function qa_AnswerVer_IsExistRecord_Cache(objqa_AnswerVer_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
        if (arrqa_AnswerVerObjLst_Cache == null)
            return false;
        let arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache;
        if (objqa_AnswerVer_Cond.sf_FldComparisonOp == null || objqa_AnswerVer_Cond.sf_FldComparisonOp == "")
            return arrqa_AnswerVer_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objqa_AnswerVer_Cond.sf_FldComparisonOp);
        //console.log("clsqa_AnswerVerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_AnswerVer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_AnswerVer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrqa_AnswerVer_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objqa_AnswerVer_Cond), exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.qa_AnswerVer_IsExistRecord_Cache = qa_AnswerVer_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function qa_AnswerVer_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_IsExistRecordAsync = qa_AnswerVer_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngAnswerVId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function qa_AnswerVer_IsExist(lngAnswerVId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "AnswerVId": lngAnswerVId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_IsExist = qa_AnswerVer_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngAnswerVId:所给的关键字
     * @returns 对象
    */
    async function qa_AnswerVer_IsExist_Cache(lngAnswerVId) {
        const strThisFuncName = "IsExist_Cache";
        const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
        if (arrqa_AnswerVerObjLst_Cache == null)
            return false;
        try {
            const arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache.filter(x => x.answerVId == lngAnswerVId);
            if (arrqa_AnswerVer_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngAnswerVId, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.qa_AnswerVer_IsExist_Cache = qa_AnswerVer_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngAnswerVId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function qa_AnswerVer_IsExistAsync(lngAnswerVId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngAnswerVId": lngAnswerVId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_IsExistAsync = qa_AnswerVer_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function qa_AnswerVer_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetRecCountByCondAsync = qa_AnswerVer_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objqa_AnswerVer_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function qa_AnswerVer_GetRecCountByCond_Cache(objqa_AnswerVer_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrqa_AnswerVerObjLst_Cache = await qa_AnswerVer_GetObjLst_Cache();
        if (arrqa_AnswerVerObjLst_Cache == null)
            return 0;
        let arrqa_AnswerVer_Sel = arrqa_AnswerVerObjLst_Cache;
        if (objqa_AnswerVer_Cond.sf_FldComparisonOp == null || objqa_AnswerVer_Cond.sf_FldComparisonOp == "")
            return arrqa_AnswerVer_Sel.length;
        const dicFldComparisonOp = JSON.parse(objqa_AnswerVer_Cond.sf_FldComparisonOp);
        //console.log("clsqa_AnswerVerWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objqa_AnswerVer_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objqa_AnswerVer_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrqa_AnswerVer_Sel = arrqa_AnswerVer_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrqa_AnswerVer_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objqa_AnswerVer_Cond), exports.qa_AnswerVer_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.qa_AnswerVer_GetRecCountByCond_Cache = qa_AnswerVer_GetRecCountByCond_Cache;
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
    async function qa_AnswerVer_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.qa_AnswerVer_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.qa_AnswerVer_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.qa_AnswerVer_GetMaxStrIdByPrefix = qa_AnswerVer_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function qa_AnswerVer_GetWebApiUrl(strController, strAction) {
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
    exports.qa_AnswerVer_GetWebApiUrl = qa_AnswerVer_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function qa_AnswerVer_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
        switch (clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheModeId) {
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
    exports.qa_AnswerVer_ReFreshCache = qa_AnswerVer_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function qa_AnswerVer_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN._CurrTabName;
            switch (clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.CacheModeId) {
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
    exports.qa_AnswerVer_ReFreshThisCache = qa_AnswerVer_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function qa_AnswerVer_CheckPropertyNew(pobjqa_AnswerVerEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerId) === true) {
            throw new Error("(errid:Watl000058)字段[回答Id]不能为空(In 答疑回答历史V)!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.questionsId) === true) {
            throw new Error("(errid:Watl000058)字段[提问Id]不能为空(In 答疑回答历史V)!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.answerId) > 10) {
            throw new Error("(errid:Watl000059)字段[回答Id(answerId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.answerId)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.questionsId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.questionsId) > 8) {
            throw new Error("(errid:Watl000059)字段[提问Id(questionsId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.questionsId)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.scoreType) > 1) {
            throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.scoreType)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.parentId) > 10) {
            throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.parentId)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.topicId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.topicId)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.answerTypeId)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.updUser)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.updDate)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.memo)(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjqa_AnswerVerEN.answerVId && undefined !== pobjqa_AnswerVerEN.answerVId && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerVerEN.answerVId) === false) {
            throw new Error("(errid:Watl000060)字段[问答历史主键(answerVId)]的值:[$(pobjqa_AnswerVerEN.answerVId)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerId) == false && undefined !== pobjqa_AnswerVerEN.answerId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.answerId) === false) {
            throw new Error("(errid:Watl000060)字段[回答Id(answerId)]的值:[$(pobjqa_AnswerVerEN.answerId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.questionsId) == false && undefined !== pobjqa_AnswerVerEN.questionsId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.questionsId) === false) {
            throw new Error("(errid:Watl000060)字段[提问Id(questionsId)]的值:[$(pobjqa_AnswerVerEN.questionsId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerContent) == false && undefined !== pobjqa_AnswerVerEN.answerContent && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.answerContent) === false) {
            throw new Error("(errid:Watl000060)字段[答案内容(answerContent)]的值:[$(pobjqa_AnswerVerEN.answerContent)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerVerEN.score && undefined !== pobjqa_AnswerVerEN.score && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerVerEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjqa_AnswerVerEN.score)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.scoreType) == false && undefined !== pobjqa_AnswerVerEN.scoreType && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.scoreType) === false) {
            throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjqa_AnswerVerEN.scoreType)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerVerEN.isRight && undefined !== pobjqa_AnswerVerEN.isRight && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerVerEN.isRight) === false) {
            throw new Error("(errid:Watl000060)字段[是否正确(isRight)]的值:[$(pobjqa_AnswerVerEN.isRight)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.parentId) == false && undefined !== pobjqa_AnswerVerEN.parentId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjqa_AnswerVerEN.parentId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerVerEN.voteCount && undefined !== pobjqa_AnswerVerEN.voteCount && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerVerEN.voteCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjqa_AnswerVerEN.voteCount)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerVerEN.isRecommend && undefined !== pobjqa_AnswerVerEN.isRecommend && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerVerEN.isRecommend) === false) {
            throw new Error("(errid:Watl000060)字段[是否推荐(isRecommend)]的值:[$(pobjqa_AnswerVerEN.isRecommend)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.topicId) == false && undefined !== pobjqa_AnswerVerEN.topicId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.topicId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicId)]的值:[$(pobjqa_AnswerVerEN.topicId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerTypeId) == false && undefined !== pobjqa_AnswerVerEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[答案类型ID(answerTypeId)]的值:[$(pobjqa_AnswerVerEN.answerTypeId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if (null != pobjqa_AnswerVerEN.isSubmit && undefined !== pobjqa_AnswerVerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerVerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjqa_AnswerVerEN.isSubmit)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updUser) == false && undefined !== pobjqa_AnswerVerEN.updUser && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjqa_AnswerVerEN.updUser)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updDate) == false && undefined !== pobjqa_AnswerVerEN.updDate && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjqa_AnswerVerEN.updDate)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.memo) == false && undefined !== pobjqa_AnswerVerEN.memo && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjqa_AnswerVerEN.memo)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjqa_AnswerVerEN.SetIsCheckProperty(true);
    }
    exports.qa_AnswerVer_CheckPropertyNew = qa_AnswerVer_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function qa_AnswerVer_CheckProperty4Update(pobjqa_AnswerVerEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.answerId) > 10) {
            throw new Error("(errid:Watl000062)字段[回答Id(answerId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.answerId)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.questionsId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.questionsId) > 8) {
            throw new Error("(errid:Watl000062)字段[提问Id(questionsId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.questionsId)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.scoreType) > 1) {
            throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.scoreType)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.parentId) > 10) {
            throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.parentId)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.topicId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.topicId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicId)]的长度不能超过8(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.topicId)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.answerTypeId)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.updUser)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.updDate)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjqa_AnswerVerEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 答疑回答历史V(qa_AnswerVer))!值:$(pobjqa_AnswerVerEN.memo)(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjqa_AnswerVerEN.answerVId && undefined !== pobjqa_AnswerVerEN.answerVId && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerVerEN.answerVId) === false) {
            throw new Error("(errid:Watl000063)字段[问答历史主键(answerVId)]的值:[$(pobjqa_AnswerVerEN.answerVId)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerId) == false && undefined !== pobjqa_AnswerVerEN.answerId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.answerId) === false) {
            throw new Error("(errid:Watl000063)字段[回答Id(answerId)]的值:[$(pobjqa_AnswerVerEN.answerId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.questionsId) == false && undefined !== pobjqa_AnswerVerEN.questionsId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.questionsId) === false) {
            throw new Error("(errid:Watl000063)字段[提问Id(questionsId)]的值:[$(pobjqa_AnswerVerEN.questionsId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerContent) == false && undefined !== pobjqa_AnswerVerEN.answerContent && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.answerContent) === false) {
            throw new Error("(errid:Watl000063)字段[答案内容(answerContent)]的值:[$(pobjqa_AnswerVerEN.answerContent)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerVerEN.score && undefined !== pobjqa_AnswerVerEN.score && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerVerEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjqa_AnswerVerEN.score)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.scoreType) == false && undefined !== pobjqa_AnswerVerEN.scoreType && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.scoreType) === false) {
            throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjqa_AnswerVerEN.scoreType)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerVerEN.isRight && undefined !== pobjqa_AnswerVerEN.isRight && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerVerEN.isRight) === false) {
            throw new Error("(errid:Watl000063)字段[是否正确(isRight)]的值:[$(pobjqa_AnswerVerEN.isRight)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.parentId) == false && undefined !== pobjqa_AnswerVerEN.parentId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjqa_AnswerVerEN.parentId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerVerEN.voteCount && undefined !== pobjqa_AnswerVerEN.voteCount && clsString_js_1.tzDataType.isNumber(pobjqa_AnswerVerEN.voteCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjqa_AnswerVerEN.voteCount)], 非法，应该为数值型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerVerEN.isRecommend && undefined !== pobjqa_AnswerVerEN.isRecommend && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerVerEN.isRecommend) === false) {
            throw new Error("(errid:Watl000063)字段[是否推荐(isRecommend)]的值:[$(pobjqa_AnswerVerEN.isRecommend)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.topicId) == false && undefined !== pobjqa_AnswerVerEN.topicId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.topicId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicId)]的值:[$(pobjqa_AnswerVerEN.topicId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.answerTypeId) == false && undefined !== pobjqa_AnswerVerEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[答案类型ID(answerTypeId)]的值:[$(pobjqa_AnswerVerEN.answerTypeId)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if (null != pobjqa_AnswerVerEN.isSubmit && undefined !== pobjqa_AnswerVerEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjqa_AnswerVerEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjqa_AnswerVerEN.isSubmit)], 非法，应该为布尔型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updUser) == false && undefined !== pobjqa_AnswerVerEN.updUser && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjqa_AnswerVerEN.updUser)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.updDate) == false && undefined !== pobjqa_AnswerVerEN.updDate && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjqa_AnswerVerEN.updDate)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjqa_AnswerVerEN.memo) == false && undefined !== pobjqa_AnswerVerEN.memo && clsString_js_1.tzDataType.isString(pobjqa_AnswerVerEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjqa_AnswerVerEN.memo)], 非法，应该为字符型(In 答疑回答历史V(qa_AnswerVer))!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjqa_AnswerVerEN.answerVId
            || pobjqa_AnswerVerEN.answerVId != null && pobjqa_AnswerVerEN.answerVId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[问答历史主键]不能为空(In 答疑回答历史V)!(clsqa_AnswerVerBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjqa_AnswerVerEN.SetIsCheckProperty(true);
    }
    exports.qa_AnswerVer_CheckProperty4Update = qa_AnswerVer_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function qa_AnswerVer_GetJSONStrByObj(pobjqa_AnswerVerEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjqa_AnswerVerEN.sf_UpdFldSetStr = pobjqa_AnswerVerEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjqa_AnswerVerEN);
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
    exports.qa_AnswerVer_GetJSONStrByObj = qa_AnswerVer_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function qa_AnswerVer_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrqa_AnswerVerObjLst = new Array();
        if (strJSON === "") {
            return arrqa_AnswerVerObjLst;
        }
        try {
            arrqa_AnswerVerObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrqa_AnswerVerObjLst;
        }
        return arrqa_AnswerVerObjLst;
    }
    exports.qa_AnswerVer_GetObjLstByJSONStr = qa_AnswerVer_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrqa_AnswerVerObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function qa_AnswerVer_GetObjLstByJSONObjLst(arrqa_AnswerVerObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrqa_AnswerVerObjLst = new Array();
        for (const objInFor of arrqa_AnswerVerObjLstS) {
            const obj1 = qa_AnswerVer_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrqa_AnswerVerObjLst.push(obj1);
        }
        return arrqa_AnswerVerObjLst;
    }
    exports.qa_AnswerVer_GetObjLstByJSONObjLst = qa_AnswerVer_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function qa_AnswerVer_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjqa_AnswerVerEN = new clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN();
        if (strJSON === "") {
            return pobjqa_AnswerVerEN;
        }
        try {
            pobjqa_AnswerVerEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjqa_AnswerVerEN;
        }
        return pobjqa_AnswerVerEN;
    }
    exports.qa_AnswerVer_GetObjByJSONStr = qa_AnswerVer_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function qa_AnswerVer_GetCombineCondition(objqa_AnswerVer_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId) == true) {
            const strComparisonOp_AnswerVId = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerVId, objqa_AnswerVer_Cond.answerVId, strComparisonOp_AnswerVId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerId) == true) {
            const strComparisonOp_AnswerId = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerId, objqa_AnswerVer_Cond.answerId, strComparisonOp_AnswerId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_QuestionsId) == true) {
            const strComparisonOp_QuestionsId = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_QuestionsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_QuestionsId, objqa_AnswerVer_Cond.questionsId, strComparisonOp_QuestionsId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Score) == true) {
            const strComparisonOp_Score = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Score, objqa_AnswerVer_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ScoreType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ScoreType, objqa_AnswerVer_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRight) == true) {
            if (objqa_AnswerVer_Cond.isRight == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRight);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRight);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ParentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_ParentId, objqa_AnswerVer_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_VoteCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_VoteCount, objqa_AnswerVer_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRecommend) == true) {
            if (objqa_AnswerVer_Cond.isRecommend == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRecommend);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsRecommend);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_TopicId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_TopicId, objqa_AnswerVer_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_AnswerTypeId, objqa_AnswerVer_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsSubmit) == true) {
            if (objqa_AnswerVer_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdUser, objqa_AnswerVer_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_UpdDate, objqa_AnswerVer_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objqa_AnswerVer_Cond.dicFldComparisonOp, clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Memo) == true) {
            const strComparisonOp_Memo = objqa_AnswerVer_Cond.dicFldComparisonOp[clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN.con_Memo, objqa_AnswerVer_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.qa_AnswerVer_GetCombineCondition = qa_AnswerVer_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--qa_AnswerVer(答疑回答历史V),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param lngAnswerVId: 问答历史主键(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function qa_AnswerVer_GetUniCondStr_AnswerVId(objqa_AnswerVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerVId = '{0}'", objqa_AnswerVerEN.answerVId);
        return strWhereCond;
    }
    exports.qa_AnswerVer_GetUniCondStr_AnswerVId = qa_AnswerVer_GetUniCondStr_AnswerVId;
    /**
    *获取唯一性条件串(Uniqueness)--qa_AnswerVer(答疑回答历史V),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param lngAnswerVId: 问答历史主键(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function qa_AnswerVer_GetUniCondStr4Update_AnswerVId(objqa_AnswerVerEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerVId <> '{0}'", objqa_AnswerVerEN.answerVId);
        strWhereCond += (0, clsString_js_2.Format)(" and AnswerVId = '{0}'", objqa_AnswerVerEN.answerVId);
        return strWhereCond;
    }
    exports.qa_AnswerVer_GetUniCondStr4Update_AnswerVId = qa_AnswerVer_GetUniCondStr4Update_AnswerVId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objqa_AnswerVerENS:源对象
     * @param objqa_AnswerVerENT:目标对象
    */
    function qa_AnswerVer_CopyObjTo(objqa_AnswerVerENS, objqa_AnswerVerENT) {
        objqa_AnswerVerENT.answerVId = objqa_AnswerVerENS.answerVId; //问答历史主键
        objqa_AnswerVerENT.answerId = objqa_AnswerVerENS.answerId; //回答Id
        objqa_AnswerVerENT.questionsId = objqa_AnswerVerENS.questionsId; //提问Id
        objqa_AnswerVerENT.answerContent = objqa_AnswerVerENS.answerContent; //答案内容
        objqa_AnswerVerENT.score = objqa_AnswerVerENS.score; //评分
        objqa_AnswerVerENT.scoreType = objqa_AnswerVerENS.scoreType; //评分类型
        objqa_AnswerVerENT.isRight = objqa_AnswerVerENS.isRight; //是否正确
        objqa_AnswerVerENT.parentId = objqa_AnswerVerENS.parentId; //父节点Id
        objqa_AnswerVerENT.voteCount = objqa_AnswerVerENS.voteCount; //点赞计数
        objqa_AnswerVerENT.isRecommend = objqa_AnswerVerENS.isRecommend; //是否推荐
        objqa_AnswerVerENT.topicId = objqa_AnswerVerENS.topicId; //主题Id
        objqa_AnswerVerENT.answerTypeId = objqa_AnswerVerENS.answerTypeId; //答案类型ID
        objqa_AnswerVerENT.isSubmit = objqa_AnswerVerENS.isSubmit; //是否提交
        objqa_AnswerVerENT.updUser = objqa_AnswerVerENS.updUser; //修改人
        objqa_AnswerVerENT.updDate = objqa_AnswerVerENS.updDate; //修改日期
        objqa_AnswerVerENT.memo = objqa_AnswerVerENS.memo; //备注
        objqa_AnswerVerENT.sf_UpdFldSetStr = objqa_AnswerVerENS.updFldString; //sf_UpdFldSetStr
    }
    exports.qa_AnswerVer_CopyObjTo = qa_AnswerVer_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objqa_AnswerVerENS:源对象
     * @param objqa_AnswerVerENT:目标对象
    */
    function qa_AnswerVer_GetObjFromJsonObj(objqa_AnswerVerENS) {
        const objqa_AnswerVerENT = new clsqa_AnswerVerEN_js_1.clsqa_AnswerVerEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objqa_AnswerVerENT, objqa_AnswerVerENS);
        return objqa_AnswerVerENT;
    }
    exports.qa_AnswerVer_GetObjFromJsonObj = qa_AnswerVer_GetObjFromJsonObj;
});