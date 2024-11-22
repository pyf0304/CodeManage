/**
* 类名:clsvqa_QuestionsWApi
* 表名:vqa_Questions(01120636)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:31
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/InteractManage/clsvqa_QuestionsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vqa_Questions_GetObjFromJsonObj = exports.vqa_Questions_CopyObjTo = exports.vqa_Questions_GetUniCondStr4Update_QuestionsId = exports.vqa_Questions_GetUniCondStr_QuestionsId = exports.vqa_Questions_GetCombineCondition = exports.vqa_Questions_GetObjByJSONStr = exports.vqa_Questions_GetObjLstByJSONObjLst = exports.vqa_Questions_GetObjLstByJSONStr = exports.vqa_Questions_GetJSONStrByObj = exports.vqa_Questions_ReFreshThisCache = exports.vqa_Questions_GetWebApiUrl = exports.vqa_Questions_GetRecCountByCond_Cache = exports.vqa_Questions_GetRecCountByCondAsync = exports.vqa_Questions_IsExistAsync = exports.vqa_Questions_IsExist_Cache = exports.vqa_Questions_IsExist = exports.vqa_Questions_IsExistRecordAsync = exports.vqa_Questions_IsExistRecord_Cache = exports.vqa_Questions_GetObjLstByPagerAsync = exports.vqa_Questions_GetObjLstByPager_Cache = exports.vqa_Questions_GetObjLstByRange = exports.vqa_Questions_GetObjLstByRangeAsync = exports.vqa_Questions_GetTopObjLstAsync = exports.vqa_Questions_GetObjLstByQuestionsIdLst_Cache = exports.vqa_Questions_GetObjLstByQuestionsIdLstAsync = exports.vqa_Questions_GetSubObjLst_Cache = exports.vqa_Questions_GetObjLst_PureCache = exports.vqa_Questions_GetObjLst_Cache = exports.vqa_Questions_GetObjLst_sessionStorage_PureCache = exports.vqa_Questions_GetObjLst_sessionStorage = exports.vqa_Questions_GetObjLstAsync = exports.vqa_Questions_GetObjLst_localStorage_PureCache = exports.vqa_Questions_GetObjLst_localStorage = exports.vqa_Questions_GetObjLst_ClientCache = exports.vqa_Questions_GetFirstObjAsync = exports.vqa_Questions_GetFirstID = exports.vqa_Questions_GetFirstIDAsync = exports.vqa_Questions_FilterFunByKey = exports.vqa_Questions_SortFunByKey = exports.vqa_Questions_SortFun_Defa_2Fld = exports.vqa_Questions_SortFun_Defa = exports.vqa_Questions_func = exports.vqa_Questions_GetObjByQuestionsId_localStorage = exports.vqa_Questions_GetObjByQuestionsId_Cache = exports.vqa_Questions_GetObjByQuestionsIdAsync = exports.vqa_Questions_ConstructorName = exports.vqa_Questions_Controller = void 0;
    /**
     * v答疑提问(vqa_Questions)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvqa_QuestionsEN_js_1 = require("../../L0_Entity/InteractManage/clsvqa_QuestionsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vqa_Questions_Controller = "vqa_QuestionsApi";
    exports.vqa_Questions_ConstructorName = "vqa_Questions";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strQuestionsId:关键字
    * @returns 对象
    **/
    async function vqa_Questions_GetObjByQuestionsIdAsync(strQuestionsId) {
        const strThisFuncName = "GetObjByQuestionsIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionsId]不能为空！(In GetObjByQuestionsIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionsId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionsId]的长度:[{0}]不正确！", strQuestionsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByQuestionsId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strQuestionsId": strQuestionsId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvqa_Questions = vqa_Questions_GetObjFromJsonObj(returnObj);
                return objvqa_Questions;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetObjByQuestionsIdAsync = vqa_Questions_GetObjByQuestionsIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strQuestionsId:所给的关键字
     * @returns 对象
    */
    async function vqa_Questions_GetObjByQuestionsId_Cache(strQuestionsId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByQuestionsId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionsId]不能为空！(In GetObjByQuestionsId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionsId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionsId]的长度:[{0}]不正确！", strQuestionsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
        try {
            const arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache.filter(x => x.questionsId == strQuestionsId);
            let objvqa_Questions;
            if (arrvqa_Questions_Sel.length > 0) {
                objvqa_Questions = arrvqa_Questions_Sel[0];
                return objvqa_Questions;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvqa_Questions = await vqa_Questions_GetObjByQuestionsIdAsync(strQuestionsId);
                    if (objvqa_Questions != null) {
                        vqa_Questions_ReFreshThisCache();
                        return objvqa_Questions;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionsId, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vqa_Questions_GetObjByQuestionsId_Cache = vqa_Questions_GetObjByQuestionsId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strQuestionsId:所给的关键字
     * @returns 对象
    */
    async function vqa_Questions_GetObjByQuestionsId_localStorage(strQuestionsId) {
        const strThisFuncName = "GetObjByQuestionsId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionsId]不能为空！(In GetObjByQuestionsId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionsId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionsId]的长度:[{0}]不正确！", strQuestionsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName, strQuestionsId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvqa_Questions_Cache = JSON.parse(strTempObj);
            return objvqa_Questions_Cache;
        }
        try {
            const objvqa_Questions = await vqa_Questions_GetObjByQuestionsIdAsync(strQuestionsId);
            if (objvqa_Questions != null) {
                localStorage.setItem(strKey, JSON.stringify(objvqa_Questions));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvqa_Questions;
            }
            return objvqa_Questions;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionsId, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vqa_Questions_GetObjByQuestionsId_localStorage = vqa_Questions_GetObjByQuestionsId_localStorage;
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
    async function vqa_Questions_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strQuestionsId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvqa_Questions = await vqa_Questions_GetObjByQuestionsId_Cache(strQuestionsId);
        if (objvqa_Questions == null)
            return "";
        return objvqa_Questions.GetFldValue(strOutFldName).toString();
    }
    exports.vqa_Questions_func = vqa_Questions_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Questions_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.questionsId.localeCompare(b.questionsId);
    }
    exports.vqa_Questions_SortFun_Defa = vqa_Questions_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Questions_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.qa_PaperId.localeCompare(b.qa_PaperId);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.vqa_Questions_SortFun_Defa_2Fld = vqa_Questions_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vqa_Questions_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId:
                    return (a, b) => {
                        return a.questionsId.localeCompare(b.questionsId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_qa_PaperId:
                    return (a, b) => {
                        return a.qa_PaperId.localeCompare(b.qa_PaperId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent:
                    return (a, b) => {
                        return a.questionsContent.localeCompare(b.questionsContent);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsDelete:
                    return (a, b) => {
                        if (a.isDelete == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsEnd:
                    return (a, b) => {
                        if (a.isEnd == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_AnswerCount:
                    return (a, b) => {
                        return a.answerCount - b.answerCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle:
                    return (a, b) => {
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivLet:
                    return (a, b) => {
                        return a.pdfDivLet.localeCompare(b.pdfDivLet);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivTop:
                    return (a, b) => {
                        return a.pdfDivTop.localeCompare(b.pdfDivTop);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNumIn:
                    return (a, b) => {
                        return a.pdfPageNumIn.localeCompare(b.pdfPageNumIn);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageTop:
                    return (a, b) => {
                        return a.pdfPageTop - b.pdfPageTop;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfZoom:
                    return (a, b) => {
                        return a.pdfZoom.localeCompare(b.pdfZoom);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeId:
                    return (a, b) => {
                        return a.questionsTypeId.localeCompare(b.questionsTypeId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeName:
                    return (a, b) => {
                        return a.questionsTypeName.localeCompare(b.questionsTypeName);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_DiscussCount:
                    return (a, b) => {
                        return a.discussCount - b.discussCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_GroupDiscussCount:
                    return (a, b) => {
                        return a.groupDiscussCount - b.groupDiscussCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_RecommendAnswerCount:
                    return (a, b) => {
                        return a.recommendAnswerCount - b.recommendAnswerCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Questions]中不存在！(in ${exports.vqa_Questions_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId:
                    return (a, b) => {
                        return b.questionsId.localeCompare(a.questionsId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_qa_PaperId:
                    return (a, b) => {
                        return b.qa_PaperId.localeCompare(a.qa_PaperId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent:
                    return (a, b) => {
                        return b.questionsContent.localeCompare(a.questionsContent);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsDelete:
                    return (a, b) => {
                        if (b.isDelete == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsEnd:
                    return (a, b) => {
                        if (b.isEnd == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_AnswerCount:
                    return (a, b) => {
                        return b.answerCount - a.answerCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle:
                    return (a, b) => {
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivLet:
                    return (a, b) => {
                        return b.pdfDivLet.localeCompare(a.pdfDivLet);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivTop:
                    return (a, b) => {
                        return b.pdfDivTop.localeCompare(a.pdfDivTop);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNumIn:
                    return (a, b) => {
                        return b.pdfPageNumIn.localeCompare(a.pdfPageNumIn);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageTop:
                    return (a, b) => {
                        return b.pdfPageTop - a.pdfPageTop;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfZoom:
                    return (a, b) => {
                        return b.pdfZoom.localeCompare(a.pdfZoom);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeId:
                    return (a, b) => {
                        return b.questionsTypeId.localeCompare(a.questionsTypeId);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeName:
                    return (a, b) => {
                        return b.questionsTypeName.localeCompare(a.questionsTypeName);
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_DiscussCount:
                    return (a, b) => {
                        return b.discussCount - a.discussCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_GroupDiscussCount:
                    return (a, b) => {
                        return b.groupDiscussCount - a.groupDiscussCount;
                    };
                case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_RecommendAnswerCount:
                    return (a, b) => {
                        return b.recommendAnswerCount - a.recommendAnswerCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vqa_Questions]中不存在！(in ${exports.vqa_Questions_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vqa_Questions_SortFunByKey = vqa_Questions_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vqa_Questions_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId:
                return (obj) => {
                    return obj.questionsId === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_qa_PaperId:
                return (obj) => {
                    return obj.qa_PaperId === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent:
                return (obj) => {
                    return obj.questionsContent === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsDelete:
                return (obj) => {
                    return obj.isDelete === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsEnd:
                return (obj) => {
                    return obj.isEnd === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_AnswerCount:
                return (obj) => {
                    return obj.answerCount === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivLet:
                return (obj) => {
                    return obj.pdfDivLet === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivTop:
                return (obj) => {
                    return obj.pdfDivTop === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNumIn:
                return (obj) => {
                    return obj.pdfPageNumIn === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageTop:
                return (obj) => {
                    return obj.pdfPageTop === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfZoom:
                return (obj) => {
                    return obj.pdfZoom === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeId:
                return (obj) => {
                    return obj.questionsTypeId === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeName:
                return (obj) => {
                    return obj.questionsTypeName === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_DiscussCount:
                return (obj) => {
                    return obj.discussCount === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_GroupDiscussCount:
                return (obj) => {
                    return obj.groupDiscussCount === value;
                };
            case clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_RecommendAnswerCount:
                return (obj) => {
                    return obj.recommendAnswerCount === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vqa_Questions]中不存在！(in ${exports.vqa_Questions_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vqa_Questions_FilterFunByKey = vqa_Questions_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vqa_Questions_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetFirstIDAsync = vqa_Questions_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vqa_Questions_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetFirstID = vqa_Questions_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vqa_Questions_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvqa_Questions = vqa_Questions_GetObjFromJsonObj(returnObj);
                return objvqa_Questions;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetFirstObjAsync = vqa_Questions_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName;
        clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvqa_QuestionsExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvqa_QuestionsObjLst_T = vqa_Questions_GetObjLstByJSONObjLst(arrvqa_QuestionsExObjLst_Cache);
            return arrvqa_QuestionsObjLst_T;
        }
        try {
            const arrvqa_QuestionsExObjLst = await vqa_Questions_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvqa_QuestionsExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_QuestionsExObjLst.length);
            console.log(strInfo);
            return arrvqa_QuestionsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Questions_GetObjLst_ClientCache = vqa_Questions_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName;
        clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvqa_QuestionsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvqa_QuestionsObjLst_T = vqa_Questions_GetObjLstByJSONObjLst(arrvqa_QuestionsExObjLst_Cache);
            return arrvqa_QuestionsObjLst_T;
        }
        try {
            const arrvqa_QuestionsExObjLst = await vqa_Questions_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvqa_QuestionsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_QuestionsExObjLst.length);
            console.log(strInfo);
            return arrvqa_QuestionsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Questions_GetObjLst_localStorage = vqa_Questions_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvqa_QuestionsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvqa_QuestionsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vqa_Questions_GetObjLst_localStorage_PureCache = vqa_Questions_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vqa_Questions_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Questions_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetObjLstAsync = vqa_Questions_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName;
        clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvqa_QuestionsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvqa_QuestionsObjLst_T = vqa_Questions_GetObjLstByJSONObjLst(arrvqa_QuestionsExObjLst_Cache);
            return arrvqa_QuestionsObjLst_T;
        }
        try {
            const arrvqa_QuestionsExObjLst = await vqa_Questions_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvqa_QuestionsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvqa_QuestionsExObjLst.length);
            console.log(strInfo);
            return arrvqa_QuestionsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vqa_Questions_GetObjLst_sessionStorage = vqa_Questions_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvqa_QuestionsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvqa_QuestionsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vqa_Questions_GetObjLst_sessionStorage_PureCache = vqa_Questions_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvqa_QuestionsObjLst_Cache;
        switch (clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_ClientCache();
                break;
            default:
                arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_ClientCache();
                break;
        }
        const arrvqa_QuestionsObjLst = vqa_Questions_GetObjLstByJSONObjLst(arrvqa_QuestionsObjLst_Cache);
        return arrvqa_QuestionsObjLst_Cache;
    }
    exports.vqa_Questions_GetObjLst_Cache = vqa_Questions_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vqa_Questions_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvqa_QuestionsObjLst_Cache;
        switch (clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvqa_QuestionsObjLst_Cache = null;
                break;
            default:
                arrvqa_QuestionsObjLst_Cache = null;
                break;
        }
        return arrvqa_QuestionsObjLst_Cache;
    }
    exports.vqa_Questions_GetObjLst_PureCache = vqa_Questions_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrQuestionsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vqa_Questions_GetSubObjLst_Cache(objvqa_Questions_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
        let arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache;
        if (objvqa_Questions_Cond.sf_FldComparisonOp == null || objvqa_Questions_Cond.sf_FldComparisonOp == "")
            return arrvqa_Questions_Sel;
        const dicFldComparisonOp = JSON.parse(objvqa_Questions_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_QuestionsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Questions_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Questions_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvqa_Questions_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvqa_Questions_Cond), exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Questions_GetSubObjLst_Cache = vqa_Questions_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrQuestionsId:关键字列表
    * @returns 对象列表
    **/
    async function vqa_Questions_GetObjLstByQuestionsIdLstAsync(arrQuestionsId) {
        const strThisFuncName = "GetObjLstByQuestionsIdLstAsync";
        const strAction = "GetObjLstByQuestionsIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionsId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Questions_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetObjLstByQuestionsIdLstAsync = vqa_Questions_GetObjLstByQuestionsIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrQuestionsIdLst:关键字列表
     * @returns 对象列表
    */
    async function vqa_Questions_GetObjLstByQuestionsIdLst_Cache(arrQuestionsIdLst) {
        const strThisFuncName = "GetObjLstByQuestionsIdLst_Cache";
        try {
            const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
            const arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache.filter(x => arrQuestionsIdLst.indexOf(x.questionsId) > -1);
            return arrvqa_Questions_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrQuestionsIdLst.join(","), exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Questions_GetObjLstByQuestionsIdLst_Cache = vqa_Questions_GetObjLstByQuestionsIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vqa_Questions_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Questions_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetTopObjLstAsync = vqa_Questions_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Questions_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Questions_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetObjLstByRangeAsync = vqa_Questions_GetObjLstByRangeAsync;
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
    async function vqa_Questions_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetObjLstByRange = vqa_Questions_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vqa_Questions_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
        if (arrvqa_QuestionsObjLst_Cache.length == 0)
            return arrvqa_QuestionsObjLst_Cache;
        let arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvqa_Questions_Cond = new clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_Questions_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvqa_QuestionsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Questions_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Questions_Sel.length == 0)
                return arrvqa_Questions_Sel;
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
                arrvqa_Questions_Sel = arrvqa_Questions_Sel.sort(vqa_Questions_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvqa_Questions_Sel = arrvqa_Questions_Sel.sort(objPagerPara.sortFun);
            }
            arrvqa_Questions_Sel = arrvqa_Questions_Sel.slice(intStart, intEnd);
            return arrvqa_Questions_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vqa_Questions_GetObjLstByPager_Cache = vqa_Questions_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vqa_Questions_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vqa_Questions_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vqa_Questions_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetObjLstByPagerAsync = vqa_Questions_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrQuestionsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vqa_Questions_IsExistRecord_Cache(objvqa_Questions_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
        if (arrvqa_QuestionsObjLst_Cache == null)
            return false;
        let arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache;
        if (objvqa_Questions_Cond.sf_FldComparisonOp == null || objvqa_Questions_Cond.sf_FldComparisonOp == "")
            return arrvqa_Questions_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvqa_Questions_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_QuestionsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Questions_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Questions_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvqa_Questions_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvqa_Questions_Cond), exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vqa_Questions_IsExistRecord_Cache = vqa_Questions_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vqa_Questions_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_IsExistRecordAsync = vqa_Questions_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strQuestionsId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vqa_Questions_IsExist(strQuestionsId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "QuestionsId": strQuestionsId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_IsExist = vqa_Questions_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strQuestionsId:所给的关键字
     * @returns 对象
    */
    async function vqa_Questions_IsExist_Cache(strQuestionsId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
        if (arrvqa_QuestionsObjLst_Cache == null)
            return false;
        try {
            const arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache.filter(x => x.questionsId == strQuestionsId);
            if (arrvqa_Questions_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strQuestionsId, exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vqa_Questions_IsExist_Cache = vqa_Questions_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strQuestionsId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vqa_Questions_IsExistAsync(strQuestionsId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strQuestionsId": strQuestionsId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_IsExistAsync = vqa_Questions_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vqa_Questions_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vqa_Questions_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vqa_Questions_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vqa_Questions_GetRecCountByCondAsync = vqa_Questions_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvqa_Questions_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vqa_Questions_GetRecCountByCond_Cache(objvqa_Questions_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvqa_QuestionsObjLst_Cache = await vqa_Questions_GetObjLst_Cache();
        if (arrvqa_QuestionsObjLst_Cache == null)
            return 0;
        let arrvqa_Questions_Sel = arrvqa_QuestionsObjLst_Cache;
        if (objvqa_Questions_Cond.sf_FldComparisonOp == null || objvqa_Questions_Cond.sf_FldComparisonOp == "")
            return arrvqa_Questions_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvqa_Questions_Cond.sf_FldComparisonOp);
        //console.log("clsvqa_QuestionsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvqa_Questions_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvqa_Questions_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvqa_Questions_Sel = arrvqa_Questions_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvqa_Questions_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvqa_Questions_Cond), exports.vqa_Questions_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vqa_Questions_GetRecCountByCond_Cache = vqa_Questions_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vqa_Questions_GetWebApiUrl(strController, strAction) {
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
    exports.vqa_Questions_GetWebApiUrl = vqa_Questions_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vqa_Questions_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN._CurrTabName;
            switch (clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.CacheModeId) {
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
    exports.vqa_Questions_ReFreshThisCache = vqa_Questions_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Questions_GetJSONStrByObj(pobjvqa_QuestionsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvqa_QuestionsEN);
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
    exports.vqa_Questions_GetJSONStrByObj = vqa_Questions_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vqa_Questions_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvqa_QuestionsObjLst = new Array();
        if (strJSON === "") {
            return arrvqa_QuestionsObjLst;
        }
        try {
            arrvqa_QuestionsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvqa_QuestionsObjLst;
        }
        return arrvqa_QuestionsObjLst;
    }
    exports.vqa_Questions_GetObjLstByJSONStr = vqa_Questions_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvqa_QuestionsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vqa_Questions_GetObjLstByJSONObjLst(arrvqa_QuestionsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvqa_QuestionsObjLst = new Array();
        for (const objInFor of arrvqa_QuestionsObjLstS) {
            const obj1 = vqa_Questions_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvqa_QuestionsObjLst.push(obj1);
        }
        return arrvqa_QuestionsObjLst;
    }
    exports.vqa_Questions_GetObjLstByJSONObjLst = vqa_Questions_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vqa_Questions_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvqa_QuestionsEN = new clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN();
        if (strJSON === "") {
            return pobjvqa_QuestionsEN;
        }
        try {
            pobjvqa_QuestionsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvqa_QuestionsEN;
        }
        return pobjvqa_QuestionsEN;
    }
    exports.vqa_Questions_GetObjByJSONStr = vqa_Questions_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vqa_Questions_GetCombineCondition(objvqa_Questions_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId) == true) {
            const strComparisonOp_QuestionsId = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsId, objvqa_Questions_Cond.questionsId, strComparisonOp_QuestionsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperId, objvqa_Questions_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsSubmit) == true) {
            if (objvqa_Questions_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_qa_PaperId) == true) {
            const strComparisonOp_qa_PaperId = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_qa_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_qa_PaperId, objvqa_Questions_Cond.qa_PaperId, strComparisonOp_qa_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent) == true) {
            const strComparisonOp_QuestionsContent = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsContent, objvqa_Questions_Cond.questionsContent, strComparisonOp_QuestionsContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfContent, objvqa_Questions_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNum, objvqa_Questions_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsDelete) == true) {
            if (objvqa_Questions_Cond.isDelete == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsDelete);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsDelete);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsPublic) == true) {
            if (objvqa_Questions_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsEnd) == true) {
            if (objvqa_Questions_Cond.isEnd == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsEnd);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_IsEnd);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_VoteCount, objvqa_Questions_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_AnswerCount) == true) {
            const strComparisonOp_AnswerCount = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_AnswerCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_AnswerCount, objvqa_Questions_Cond.answerCount, strComparisonOp_AnswerCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_OrderNum, objvqa_Questions_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdUser, objvqa_Questions_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UpdDate, objvqa_Questions_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_Memo, objvqa_Questions_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserName, objvqa_Questions_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_id_CurrEduCls, objvqa_Questions_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PaperTitle, objvqa_Questions_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivLet) == true) {
            const strComparisonOp_PdfDivLet = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivLet];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivLet, objvqa_Questions_Cond.pdfDivLet, strComparisonOp_PdfDivLet);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivTop) == true) {
            const strComparisonOp_PdfDivTop = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivTop];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfDivTop, objvqa_Questions_Cond.pdfDivTop, strComparisonOp_PdfDivTop);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNumIn) == true) {
            const strComparisonOp_PdfPageNumIn = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNumIn];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageNumIn, objvqa_Questions_Cond.pdfPageNumIn, strComparisonOp_PdfPageNumIn);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageTop) == true) {
            const strComparisonOp_PdfPageTop = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageTop];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfPageTop, objvqa_Questions_Cond.pdfPageTop, strComparisonOp_PdfPageTop);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfZoom) == true) {
            const strComparisonOp_PdfZoom = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfZoom];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_PdfZoom, objvqa_Questions_Cond.pdfZoom, strComparisonOp_PdfZoom);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_UserId, objvqa_Questions_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeId) == true) {
            const strComparisonOp_QuestionsTypeId = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeId, objvqa_Questions_Cond.questionsTypeId, strComparisonOp_QuestionsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeName) == true) {
            const strComparisonOp_QuestionsTypeName = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_QuestionsTypeName, objvqa_Questions_Cond.questionsTypeName, strComparisonOp_QuestionsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_DiscussCount) == true) {
            const strComparisonOp_DiscussCount = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_DiscussCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_DiscussCount, objvqa_Questions_Cond.discussCount, strComparisonOp_DiscussCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_GroupDiscussCount) == true) {
            const strComparisonOp_GroupDiscussCount = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_GroupDiscussCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_GroupDiscussCount, objvqa_Questions_Cond.groupDiscussCount, strComparisonOp_GroupDiscussCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvqa_Questions_Cond.dicFldComparisonOp, clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_RecommendAnswerCount) == true) {
            const strComparisonOp_RecommendAnswerCount = objvqa_Questions_Cond.dicFldComparisonOp[clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_RecommendAnswerCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN.con_RecommendAnswerCount, objvqa_Questions_Cond.recommendAnswerCount, strComparisonOp_RecommendAnswerCount);
        }
        return strWhereCond;
    }
    exports.vqa_Questions_GetCombineCondition = vqa_Questions_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vqa_Questions(v答疑提问),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strQuestionsId: 提问Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vqa_Questions_GetUniCondStr_QuestionsId(objvqa_QuestionsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and QuestionsId = '{0}'", objvqa_QuestionsEN.questionsId);
        return strWhereCond;
    }
    exports.vqa_Questions_GetUniCondStr_QuestionsId = vqa_Questions_GetUniCondStr_QuestionsId;
    /**
    *获取唯一性条件串(Uniqueness)--vqa_Questions(v答疑提问),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strQuestionsId: 提问Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vqa_Questions_GetUniCondStr4Update_QuestionsId(objvqa_QuestionsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and QuestionsId <> '{0}'", objvqa_QuestionsEN.questionsId);
        strWhereCond += (0, clsString_js_1.Format)(" and QuestionsId = '{0}'", objvqa_QuestionsEN.questionsId);
        return strWhereCond;
    }
    exports.vqa_Questions_GetUniCondStr4Update_QuestionsId = vqa_Questions_GetUniCondStr4Update_QuestionsId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvqa_QuestionsENS:源对象
     * @param objvqa_QuestionsENT:目标对象
    */
    function vqa_Questions_CopyObjTo(objvqa_QuestionsENS, objvqa_QuestionsENT) {
        objvqa_QuestionsENT.questionsId = objvqa_QuestionsENS.questionsId; //提问Id
        objvqa_QuestionsENT.paperId = objvqa_QuestionsENS.paperId; //论文Id
        objvqa_QuestionsENT.isSubmit = objvqa_QuestionsENS.isSubmit; //是否提交
        objvqa_QuestionsENT.qa_PaperId = objvqa_QuestionsENS.qa_PaperId; //论文答疑Id
        objvqa_QuestionsENT.questionsContent = objvqa_QuestionsENS.questionsContent; //提问内容
        objvqa_QuestionsENT.pdfContent = objvqa_QuestionsENS.pdfContent; //Pdf内容
        objvqa_QuestionsENT.pdfPageNum = objvqa_QuestionsENS.pdfPageNum; //Pdf页码
        objvqa_QuestionsENT.isDelete = objvqa_QuestionsENS.isDelete; //是否删除
        objvqa_QuestionsENT.isPublic = objvqa_QuestionsENS.isPublic; //是否公开
        objvqa_QuestionsENT.isEnd = objvqa_QuestionsENS.isEnd; //是否结束
        objvqa_QuestionsENT.voteCount = objvqa_QuestionsENS.voteCount; //点赞计数
        objvqa_QuestionsENT.answerCount = objvqa_QuestionsENS.answerCount; //回答计数
        objvqa_QuestionsENT.orderNum = objvqa_QuestionsENS.orderNum; //序号
        objvqa_QuestionsENT.updUser = objvqa_QuestionsENS.updUser; //修改人
        objvqa_QuestionsENT.updDate = objvqa_QuestionsENS.updDate; //修改日期
        objvqa_QuestionsENT.memo = objvqa_QuestionsENS.memo; //备注
        objvqa_QuestionsENT.userName = objvqa_QuestionsENS.userName; //用户名
        objvqa_QuestionsENT.id_CurrEduCls = objvqa_QuestionsENS.id_CurrEduCls; //教学班流水号
        objvqa_QuestionsENT.paperTitle = objvqa_QuestionsENS.paperTitle; //论文标题
        objvqa_QuestionsENT.pdfDivLet = objvqa_QuestionsENS.pdfDivLet; //PdfDivLet
        objvqa_QuestionsENT.pdfDivTop = objvqa_QuestionsENS.pdfDivTop; //PdfDivTop
        objvqa_QuestionsENT.pdfPageNumIn = objvqa_QuestionsENS.pdfPageNumIn; //PdfPageNumIn
        objvqa_QuestionsENT.pdfPageTop = objvqa_QuestionsENS.pdfPageTop; //pdf页面顶部位置
        objvqa_QuestionsENT.pdfZoom = objvqa_QuestionsENS.pdfZoom; //PdfZoom
        objvqa_QuestionsENT.userId = objvqa_QuestionsENS.userId; //用户ID
        objvqa_QuestionsENT.questionsTypeId = objvqa_QuestionsENS.questionsTypeId; //问题类型Id
        objvqa_QuestionsENT.questionsTypeName = objvqa_QuestionsENS.questionsTypeName; //问题类型名称
        objvqa_QuestionsENT.discussCount = objvqa_QuestionsENS.discussCount; //DiscussCount
        objvqa_QuestionsENT.groupDiscussCount = objvqa_QuestionsENS.groupDiscussCount; //GroupDiscussCount
        objvqa_QuestionsENT.recommendAnswerCount = objvqa_QuestionsENS.recommendAnswerCount; //RecommendAnswerCount
    }
    exports.vqa_Questions_CopyObjTo = vqa_Questions_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvqa_QuestionsENS:源对象
     * @param objvqa_QuestionsENT:目标对象
    */
    function vqa_Questions_GetObjFromJsonObj(objvqa_QuestionsENS) {
        const objvqa_QuestionsENT = new clsvqa_QuestionsEN_js_1.clsvqa_QuestionsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvqa_QuestionsENT, objvqa_QuestionsENS);
        return objvqa_QuestionsENT;
    }
    exports.vqa_Questions_GetObjFromJsonObj = vqa_Questions_GetObjFromJsonObj;
});
