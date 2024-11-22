/**
* 类名:clsQuestionnaireWApi
* 表名:Questionnaire(01120001)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:31:33
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息(BaseInfo)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.Questionnaire_GetObjFromJsonObj = exports.Questionnaire_CopyObjTo = exports.Questionnaire_GetUniCondStr4Update_QuestionID = exports.Questionnaire_GetUniCondStr_QuestionID = exports.Questionnaire_GetCombineCondition = exports.Questionnaire_GetObjByJSONStr = exports.Questionnaire_GetObjLstByJSONObjLst = exports.Questionnaire_GetObjLstByJSONStr = exports.Questionnaire_GetJSONStrByObj = exports.Questionnaire_CheckProperty4Update = exports.Questionnaire_CheckPropertyNew = exports.Questionnaire_BindDdl_QuestionIDInDiv_Cache = exports.Questionnaire_ReFreshThisCache = exports.Questionnaire_ReFreshCache = exports.Questionnaire_GetWebApiUrl = exports.Questionnaire_GetMaxStrIdByPrefix = exports.Questionnaire_GetMaxStrIdAsync = exports.Questionnaire_GetRecCountByCond_Cache = exports.Questionnaire_GetRecCountByCondAsync = exports.Questionnaire_IsExistAsync = exports.Questionnaire_IsExist_Cache = exports.Questionnaire_IsExist = exports.Questionnaire_IsExistRecordAsync = exports.Questionnaire_IsExistRecord_Cache = exports.Questionnaire_UpdateWithConditionAsync = exports.Questionnaire_UpdateRecordAsync = exports.Questionnaire_AddNewRecordWithReturnKey = exports.Questionnaire_AddNewRecordWithReturnKeyAsync = exports.Questionnaire_ReOrderAsync = exports.Questionnaire_GoBottomAsync = exports.Questionnaire_DownMoveAsync = exports.Questionnaire_UpMoveAsync = exports.Questionnaire_GoTopAsync = exports.Questionnaire_AddNewRecordWithMaxIdAsync = exports.Questionnaire_AddNewRecordAsync = exports.Questionnaire_DelQuestionnairesByCondAsync = exports.Questionnaire_DelQuestionnairesAsync = exports.Questionnaire_DelRecordAsync = exports.Questionnaire_GetObjLstByPagerAsync = exports.Questionnaire_GetObjLstByPager_Cache = exports.Questionnaire_GetObjLstByRange = exports.Questionnaire_GetObjLstByRangeAsync = exports.Questionnaire_GetTopObjLstAsync = exports.Questionnaire_GetObjLstByQuestionIDLst_Cache = exports.Questionnaire_GetObjLstByQuestionIDLstAsync = exports.Questionnaire_GetSubObjLst_Cache = exports.Questionnaire_GetObjLst_PureCache = exports.Questionnaire_GetObjLst_Cache = exports.Questionnaire_GetObjLst_sessionStorage_PureCache = exports.Questionnaire_GetObjLst_sessionStorage = exports.Questionnaire_GetObjLstAsync = exports.Questionnaire_GetObjLst_localStorage_PureCache = exports.Questionnaire_GetObjLst_localStorage = exports.Questionnaire_GetObjLst_ClientCache = exports.Questionnaire_GetFirstObjAsync = exports.Questionnaire_GetFirstID = exports.Questionnaire_GetFirstIDAsync = exports.Questionnaire_funcKey = exports.Questionnaire_FilterFunByKey = exports.Questionnaire_SortFunByKey = exports.Questionnaire_SortFun_Defa_2Fld = exports.Questionnaire_SortFun_Defa = exports.Questionnaire_func = exports.Questionnaire_GetNameByQuestionID_Cache = exports.Questionnaire_UpdateObjInLst_Cache = exports.Questionnaire_GetObjByQuestionID_localStorage = exports.Questionnaire_GetObjByQuestionID_Cache = exports.Questionnaire_GetObjByQuestionIDAsync = exports.questionnaire_ConstructorName = exports.questionnaire_Controller = void 0;
    /**
     * 题目(Questionnaire)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsQuestionnaireEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsQuestionnaireEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.questionnaire_Controller = "QuestionnaireApi";
    exports.questionnaire_ConstructorName = "questionnaire";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strQuestionID:关键字
    * @returns 对象
    **/
    async function Questionnaire_GetObjByQuestionIDAsync(strQuestionID) {
        const strThisFuncName = "GetObjByQuestionIDAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionID]不能为空！(In clsQuestionnaireWApi.GetObjByQuestionIDAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsQuestionnaireWApi.GetObjByQuestionIDAsync)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByQuestionID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strQuestionID": strQuestionID,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objQuestionnaire = Questionnaire_GetObjFromJsonObj(returnObj);
                return objQuestionnaire;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetObjByQuestionIDAsync = Questionnaire_GetObjByQuestionIDAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function Questionnaire_GetObjByQuestionID_Cache(strQuestionID, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByQuestionID_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionID]不能为空！(In clsQuestionnaireWApi.GetObjByQuestionID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsQuestionnaireWApi.GetObjByQuestionID_Cache)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        try {
            const arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache.filter(x => x.questionID == strQuestionID);
            let objQuestionnaire;
            if (arrQuestionnaire_Sel.length > 0) {
                objQuestionnaire = arrQuestionnaire_Sel[0];
                return objQuestionnaire;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objQuestionnaire_Const = await Questionnaire_GetObjByQuestionIDAsync(strQuestionID);
                    if (objQuestionnaire_Const != null) {
                        Questionnaire_ReFreshThisCache(strCourseId);
                        return objQuestionnaire_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionID, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.Questionnaire_GetObjByQuestionID_Cache = Questionnaire_GetObjByQuestionID_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function Questionnaire_GetObjByQuestionID_localStorage(strQuestionID) {
        const strThisFuncName = "GetObjByQuestionID_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionID]不能为空！(In clsQuestionnaireWApi.GetObjByQuestionID_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsQuestionnaireWApi.GetObjByQuestionID_localStorage)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strQuestionID);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objQuestionnaire_Cache = JSON.parse(strTempObj);
            return objQuestionnaire_Cache;
        }
        try {
            const objQuestionnaire = await Questionnaire_GetObjByQuestionIDAsync(strQuestionID);
            if (objQuestionnaire != null) {
                localStorage.setItem(strKey, JSON.stringify(objQuestionnaire));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objQuestionnaire;
            }
            return objQuestionnaire;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionID, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.Questionnaire_GetObjByQuestionID_localStorage = Questionnaire_GetObjByQuestionID_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objQuestionnaire:所给的对象
     * @returns 对象
    */
    async function Questionnaire_UpdateObjInLst_Cache(objQuestionnaire, strCourseId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
            const obj = arrQuestionnaireObjLst_Cache.find(x => x.questionID == objQuestionnaire.questionID);
            if (obj != null) {
                objQuestionnaire.questionID = obj.questionID;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objQuestionnaire);
            }
            else {
                arrQuestionnaireObjLst_Cache.push(objQuestionnaire);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.Questionnaire_UpdateObjInLst_Cache = Questionnaire_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function Questionnaire_GetNameByQuestionID_Cache(strQuestionID, strCourseId) {
        const strThisFuncName = "GetNameByQuestionID_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strQuestionID]不能为空！(In clsQuestionnaireWApi.GetNameByQuestionID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsQuestionnaireWApi.GetNameByQuestionID_Cache)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        if (arrQuestionnaireObjLst_Cache == null)
            return "";
        try {
            const arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache.filter(x => x.questionID == strQuestionID);
            let objQuestionnaire;
            if (arrQuestionnaire_Sel.length > 0) {
                objQuestionnaire = arrQuestionnaire_Sel[0];
                return objQuestionnaire.questionName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strQuestionID);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.Questionnaire_GetNameByQuestionID_Cache = Questionnaire_GetNameByQuestionID_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function Questionnaire_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clsQuestionnaireWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsQuestionnaireWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsQuestionnaireEN_js_1.clsQuestionnaireEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsQuestionnaireEN_js_1.clsQuestionnaireEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strQuestionID = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objQuestionnaire = await Questionnaire_GetObjByQuestionID_Cache(strQuestionID, strCourseId_C);
        if (objQuestionnaire == null)
            return "";
        if (objQuestionnaire.GetFldValue(strOutFldName) == null)
            return "";
        return objQuestionnaire.GetFldValue(strOutFldName).toString();
    }
    exports.Questionnaire_func = Questionnaire_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Questionnaire_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.questionID.localeCompare(b.questionID);
    }
    exports.Questionnaire_SortFun_Defa = Questionnaire_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Questionnaire_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionIndex == b.questionIndex)
            return a.questionName.localeCompare(b.questionName);
        else
            return a.questionIndex - b.questionIndex;
    }
    exports.Questionnaire_SortFun_Defa_2Fld = Questionnaire_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function Questionnaire_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID:
                    return (a, b) => {
                        return a.questionID.localeCompare(b.questionID);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionIndex:
                    return (a, b) => {
                        return a.questionIndex - b.questionIndex;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName:
                    return (a, b) => {
                        return a.questionName.localeCompare(b.questionName);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionContent:
                    return (a, b) => {
                        if (a.questionContent == null)
                            return -1;
                        if (b.questionContent == null)
                            return 1;
                        return a.questionContent.localeCompare(b.questionContent);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionMemo:
                    return (a, b) => {
                        if (a.questionMemo == null)
                            return -1;
                        if (b.questionMemo == null)
                            return 1;
                        return a.questionMemo.localeCompare(b.questionMemo);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionNo:
                    return (a, b) => {
                        if (a.questionNo == null)
                            return -1;
                        if (b.questionNo == null)
                            return 1;
                        return a.questionNo.localeCompare(b.questionNo);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ParentQuestionId:
                    return (a, b) => {
                        if (a.parentQuestionId == null)
                            return -1;
                        if (b.parentQuestionId == null)
                            return 1;
                        return a.parentQuestionId.localeCompare(b.parentQuestionId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamAnswer:
                    return (a, b) => {
                        if (a.examAnswer == null)
                            return -1;
                        if (b.examAnswer == null)
                            return 1;
                        return a.examAnswer.localeCompare(b.examAnswer);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelNo:
                    return (a, b) => {
                        return a.levelNo - b.levelNo;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseChapterId:
                    return (a, b) => {
                        if (a.courseChapterId == null)
                            return -1;
                        if (b.courseChapterId == null)
                            return 1;
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId:
                    return (a, b) => {
                        if (a.questionTypeId == null)
                            return -1;
                        if (b.questionTypeId == null)
                            return 1;
                        return a.questionTypeId.localeCompare(b.questionTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId4Course:
                    return (a, b) => {
                        if (a.questionTypeId4Course == null)
                            return -1;
                        if (b.questionTypeId4Course == null)
                            return 1;
                        return a.questionTypeId4Course.localeCompare(b.questionTypeId4Course);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (a.answerTypeId == null)
                            return -1;
                        if (b.answerTypeId == null)
                            return 1;
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_GridTitle:
                    return (a, b) => {
                        if (a.gridTitle == null)
                            return -1;
                        if (b.gridTitle == null)
                            return 1;
                        return a.gridTitle.localeCompare(b.gridTitle);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerModeId:
                    return (a, b) => {
                        if (a.answerModeId == null)
                            return -1;
                        if (b.answerModeId == null)
                            return 1;
                        return a.answerModeId.localeCompare(b.answerModeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsHaveAdditionalMemo:
                    return (a, b) => {
                        if (a.isHaveAdditionalMemo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionScore:
                    return (a, b) => {
                        return a.questionScore - b.questionScore;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultValue:
                    return (a, b) => {
                        if (a.defaultValue == null)
                            return -1;
                        if (b.defaultValue == null)
                            return 1;
                        return a.defaultValue.localeCompare(b.defaultValue);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultSelectItem:
                    return (a, b) => {
                        if (a.defaultSelectItem == null)
                            return -1;
                        if (b.defaultSelectItem == null)
                            return 1;
                        return a.defaultSelectItem.localeCompare(b.defaultSelectItem);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCast:
                    return (a, b) => {
                        if (a.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerAttLimitSize:
                    return (a, b) => {
                        return a.answerAttLimitSize - b.answerAttLimitSize;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LimitedResourceType:
                    return (a, b) => {
                        if (a.limitedResourceType == null)
                            return -1;
                        if (b.limitedResourceType == null)
                            return 1;
                        return a.limitedResourceType.localeCompare(b.limitedResourceType);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCanInPaper:
                    return (a, b) => {
                        if (a.isCanInPaper == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamGradeId:
                    return (a, b) => {
                        if (a.examGradeId == null)
                            return -1;
                        if (b.examGradeId == null)
                            return 1;
                        return a.examGradeId.localeCompare(b.examGradeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_TextDirectId:
                    return (a, b) => {
                        if (a.textDirectId == null)
                            return -1;
                        if (b.textDirectId == null)
                            return 1;
                        return a.textDirectId.localeCompare(b.textDirectId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionCode:
                    return (a, b) => {
                        if (a.questionCode == null)
                            return -1;
                        if (b.questionCode == null)
                            return 1;
                        return a.questionCode.localeCompare(b.questionCode);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DifficultyLevelId:
                    return (a, b) => {
                        if (a.difficultyLevelId == null)
                            return -1;
                        if (b.difficultyLevelId == null)
                            return 1;
                        return a.difficultyLevelId.localeCompare(b.difficultyLevelId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_SectionTypeId:
                    return (a, b) => {
                        if (a.sectionTypeId == null)
                            return -1;
                        if (b.sectionTypeId == null)
                            return 1;
                        return a.sectionTypeId.localeCompare(b.sectionTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_KnowledgeGraphId:
                    return (a, b) => {
                        if (a.knowledgeGraphId == null)
                            return -1;
                        if (b.knowledgeGraphId == null)
                            return 1;
                        return a.knowledgeGraphId.localeCompare(b.knowledgeGraphId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FirstIndent:
                    return (a, b) => {
                        if (a.firstIndent == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName_Add:
                    return (a, b) => {
                        if (a.questionName_Add == null)
                            return -1;
                        if (b.questionName_Add == null)
                            return 1;
                        return a.questionName_Add.localeCompare(b.questionName_Add);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab:
                    return (a, b) => {
                        if (a.codeTab == null)
                            return -1;
                        if (b.codeTab == null)
                            return 1;
                        return a.codeTab.localeCompare(b.codeTab);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Code:
                    return (a, b) => {
                        if (a.codeTab_Code == null)
                            return -1;
                        if (b.codeTab_Code == null)
                            return 1;
                        return a.codeTab_Code.localeCompare(b.codeTab_Code);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Condition:
                    return (a, b) => {
                        if (a.codeTab_Condition == null)
                            return -1;
                        if (b.codeTab_Condition == null)
                            return 1;
                        return a.codeTab_Condition.localeCompare(b.codeTab_Condition);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Name:
                    return (a, b) => {
                        if (a.codeTab_Name == null)
                            return -1;
                        if (b.codeTab_Name == null)
                            return 1;
                        return a.codeTab_Name.localeCompare(b.codeTab_Name);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextHeight:
                    return (a, b) => {
                        return a.fillInTextHeight - b.fillInTextHeight;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextWidth:
                    return (a, b) => {
                        return a.fillInTextWidth - b.fillInTextWidth;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsMulti4FillInText:
                    return (a, b) => {
                        if (a.isMulti4FillInText == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CheckBoxLimitCount:
                    return (a, b) => {
                        return a.checkBoxLimitCount - b.checkBoxLimitCount;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsJs:
                    return (a, b) => {
                        if (a.isJs == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_MemoTextWidth:
                    return (a, b) => {
                        return a.memoTextWidth - b.memoTextWidth;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_RelaEvent:
                    return (a, b) => {
                        if (a.relaEvent == null)
                            return -1;
                        if (b.relaEvent == null)
                            return 1;
                        return a.relaEvent.localeCompare(b.relaEvent);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsTest:
                    return (a, b) => {
                        if (a.isTest == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelModeTypeId:
                    return (a, b) => {
                        return a.levelModeTypeId.localeCompare(b.levelModeTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsRandom:
                    return (a, b) => {
                        if (a.isRandom == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Questionnaire]中不存在！(in ${exports.questionnaire_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID:
                    return (a, b) => {
                        return b.questionID.localeCompare(a.questionID);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionIndex:
                    return (a, b) => {
                        return b.questionIndex - a.questionIndex;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName:
                    return (a, b) => {
                        return b.questionName.localeCompare(a.questionName);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionContent:
                    return (a, b) => {
                        if (b.questionContent == null)
                            return -1;
                        if (a.questionContent == null)
                            return 1;
                        return b.questionContent.localeCompare(a.questionContent);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionMemo:
                    return (a, b) => {
                        if (b.questionMemo == null)
                            return -1;
                        if (a.questionMemo == null)
                            return 1;
                        return b.questionMemo.localeCompare(a.questionMemo);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionNo:
                    return (a, b) => {
                        if (b.questionNo == null)
                            return -1;
                        if (a.questionNo == null)
                            return 1;
                        return b.questionNo.localeCompare(a.questionNo);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ParentQuestionId:
                    return (a, b) => {
                        if (b.parentQuestionId == null)
                            return -1;
                        if (a.parentQuestionId == null)
                            return 1;
                        return b.parentQuestionId.localeCompare(a.parentQuestionId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamAnswer:
                    return (a, b) => {
                        if (b.examAnswer == null)
                            return -1;
                        if (a.examAnswer == null)
                            return 1;
                        return b.examAnswer.localeCompare(a.examAnswer);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelNo:
                    return (a, b) => {
                        return b.levelNo - a.levelNo;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseChapterId:
                    return (a, b) => {
                        if (b.courseChapterId == null)
                            return -1;
                        if (a.courseChapterId == null)
                            return 1;
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId:
                    return (a, b) => {
                        if (b.questionTypeId == null)
                            return -1;
                        if (a.questionTypeId == null)
                            return 1;
                        return b.questionTypeId.localeCompare(a.questionTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId4Course:
                    return (a, b) => {
                        if (b.questionTypeId4Course == null)
                            return -1;
                        if (a.questionTypeId4Course == null)
                            return 1;
                        return b.questionTypeId4Course.localeCompare(a.questionTypeId4Course);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (b.answerTypeId == null)
                            return -1;
                        if (a.answerTypeId == null)
                            return 1;
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_GridTitle:
                    return (a, b) => {
                        if (b.gridTitle == null)
                            return -1;
                        if (a.gridTitle == null)
                            return 1;
                        return b.gridTitle.localeCompare(a.gridTitle);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerModeId:
                    return (a, b) => {
                        if (b.answerModeId == null)
                            return -1;
                        if (a.answerModeId == null)
                            return 1;
                        return b.answerModeId.localeCompare(a.answerModeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsHaveAdditionalMemo:
                    return (a, b) => {
                        if (b.isHaveAdditionalMemo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionScore:
                    return (a, b) => {
                        return b.questionScore - a.questionScore;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultValue:
                    return (a, b) => {
                        if (b.defaultValue == null)
                            return -1;
                        if (a.defaultValue == null)
                            return 1;
                        return b.defaultValue.localeCompare(a.defaultValue);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultSelectItem:
                    return (a, b) => {
                        if (b.defaultSelectItem == null)
                            return -1;
                        if (a.defaultSelectItem == null)
                            return 1;
                        return b.defaultSelectItem.localeCompare(a.defaultSelectItem);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCast:
                    return (a, b) => {
                        if (b.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerAttLimitSize:
                    return (a, b) => {
                        return b.answerAttLimitSize - a.answerAttLimitSize;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LimitedResourceType:
                    return (a, b) => {
                        if (b.limitedResourceType == null)
                            return -1;
                        if (a.limitedResourceType == null)
                            return 1;
                        return b.limitedResourceType.localeCompare(a.limitedResourceType);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCanInPaper:
                    return (a, b) => {
                        if (b.isCanInPaper == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamGradeId:
                    return (a, b) => {
                        if (b.examGradeId == null)
                            return -1;
                        if (a.examGradeId == null)
                            return 1;
                        return b.examGradeId.localeCompare(a.examGradeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_TextDirectId:
                    return (a, b) => {
                        if (b.textDirectId == null)
                            return -1;
                        if (a.textDirectId == null)
                            return 1;
                        return b.textDirectId.localeCompare(a.textDirectId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionCode:
                    return (a, b) => {
                        if (b.questionCode == null)
                            return -1;
                        if (a.questionCode == null)
                            return 1;
                        return b.questionCode.localeCompare(a.questionCode);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DifficultyLevelId:
                    return (a, b) => {
                        if (b.difficultyLevelId == null)
                            return -1;
                        if (a.difficultyLevelId == null)
                            return 1;
                        return b.difficultyLevelId.localeCompare(a.difficultyLevelId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_SectionTypeId:
                    return (a, b) => {
                        if (b.sectionTypeId == null)
                            return -1;
                        if (a.sectionTypeId == null)
                            return 1;
                        return b.sectionTypeId.localeCompare(a.sectionTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_KnowledgeGraphId:
                    return (a, b) => {
                        if (b.knowledgeGraphId == null)
                            return -1;
                        if (a.knowledgeGraphId == null)
                            return 1;
                        return b.knowledgeGraphId.localeCompare(a.knowledgeGraphId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FirstIndent:
                    return (a, b) => {
                        if (b.firstIndent == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName_Add:
                    return (a, b) => {
                        if (b.questionName_Add == null)
                            return -1;
                        if (a.questionName_Add == null)
                            return 1;
                        return b.questionName_Add.localeCompare(a.questionName_Add);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab:
                    return (a, b) => {
                        if (b.codeTab == null)
                            return -1;
                        if (a.codeTab == null)
                            return 1;
                        return b.codeTab.localeCompare(a.codeTab);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Code:
                    return (a, b) => {
                        if (b.codeTab_Code == null)
                            return -1;
                        if (a.codeTab_Code == null)
                            return 1;
                        return b.codeTab_Code.localeCompare(a.codeTab_Code);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Condition:
                    return (a, b) => {
                        if (b.codeTab_Condition == null)
                            return -1;
                        if (a.codeTab_Condition == null)
                            return 1;
                        return b.codeTab_Condition.localeCompare(a.codeTab_Condition);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Name:
                    return (a, b) => {
                        if (b.codeTab_Name == null)
                            return -1;
                        if (a.codeTab_Name == null)
                            return 1;
                        return b.codeTab_Name.localeCompare(a.codeTab_Name);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextHeight:
                    return (a, b) => {
                        return b.fillInTextHeight - a.fillInTextHeight;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextWidth:
                    return (a, b) => {
                        return b.fillInTextWidth - a.fillInTextWidth;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsMulti4FillInText:
                    return (a, b) => {
                        if (b.isMulti4FillInText == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CheckBoxLimitCount:
                    return (a, b) => {
                        return b.checkBoxLimitCount - a.checkBoxLimitCount;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsJs:
                    return (a, b) => {
                        if (b.isJs == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_MemoTextWidth:
                    return (a, b) => {
                        return b.memoTextWidth - a.memoTextWidth;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_RelaEvent:
                    return (a, b) => {
                        if (b.relaEvent == null)
                            return -1;
                        if (a.relaEvent == null)
                            return 1;
                        return b.relaEvent.localeCompare(a.relaEvent);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsTest:
                    return (a, b) => {
                        if (b.isTest == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelModeTypeId:
                    return (a, b) => {
                        return b.levelModeTypeId.localeCompare(a.levelModeTypeId);
                    };
                case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsRandom:
                    return (a, b) => {
                        if (b.isRandom == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[Questionnaire]中不存在！(in ${exports.questionnaire_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.Questionnaire_SortFunByKey = Questionnaire_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function Questionnaire_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID:
                return (obj) => {
                    return obj.questionID === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionIndex:
                return (obj) => {
                    return obj.questionIndex === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName:
                return (obj) => {
                    return obj.questionName === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionContent:
                return (obj) => {
                    return obj.questionContent === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionMemo:
                return (obj) => {
                    return obj.questionMemo === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionNo:
                return (obj) => {
                    return obj.questionNo === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ParentQuestionId:
                return (obj) => {
                    return obj.parentQuestionId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamAnswer:
                return (obj) => {
                    return obj.examAnswer === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelNo:
                return (obj) => {
                    return obj.levelNo === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId:
                return (obj) => {
                    return obj.questionTypeId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId4Course:
                return (obj) => {
                    return obj.questionTypeId4Course === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_GridTitle:
                return (obj) => {
                    return obj.gridTitle === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerModeId:
                return (obj) => {
                    return obj.answerModeId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsHaveAdditionalMemo:
                return (obj) => {
                    return obj.isHaveAdditionalMemo === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionScore:
                return (obj) => {
                    return obj.questionScore === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultValue:
                return (obj) => {
                    return obj.defaultValue === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultSelectItem:
                return (obj) => {
                    return obj.defaultSelectItem === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCast:
                return (obj) => {
                    return obj.isCast === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerAttLimitSize:
                return (obj) => {
                    return obj.answerAttLimitSize === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LimitedResourceType:
                return (obj) => {
                    return obj.limitedResourceType === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCanInPaper:
                return (obj) => {
                    return obj.isCanInPaper === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamGradeId:
                return (obj) => {
                    return obj.examGradeId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_TextDirectId:
                return (obj) => {
                    return obj.textDirectId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionCode:
                return (obj) => {
                    return obj.questionCode === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DifficultyLevelId:
                return (obj) => {
                    return obj.difficultyLevelId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_SectionTypeId:
                return (obj) => {
                    return obj.sectionTypeId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_KnowledgeGraphId:
                return (obj) => {
                    return obj.knowledgeGraphId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FirstIndent:
                return (obj) => {
                    return obj.firstIndent === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName_Add:
                return (obj) => {
                    return obj.questionName_Add === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab:
                return (obj) => {
                    return obj.codeTab === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Code:
                return (obj) => {
                    return obj.codeTab_Code === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Condition:
                return (obj) => {
                    return obj.codeTab_Condition === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Name:
                return (obj) => {
                    return obj.codeTab_Name === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextHeight:
                return (obj) => {
                    return obj.fillInTextHeight === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextWidth:
                return (obj) => {
                    return obj.fillInTextWidth === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsMulti4FillInText:
                return (obj) => {
                    return obj.isMulti4FillInText === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CheckBoxLimitCount:
                return (obj) => {
                    return obj.checkBoxLimitCount === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsJs:
                return (obj) => {
                    return obj.isJs === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_MemoTextWidth:
                return (obj) => {
                    return obj.memoTextWidth === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_RelaEvent:
                return (obj) => {
                    return obj.relaEvent === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsTest:
                return (obj) => {
                    return obj.isTest === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelModeTypeId:
                return (obj) => {
                    return obj.levelModeTypeId === value;
                };
            case clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsRandom:
                return (obj) => {
                    return obj.isRandom === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[Questionnaire]中不存在！(in ${exports.questionnaire_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.Questionnaire_FilterFunByKey = Questionnaire_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function Questionnaire_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId_C]不能为空！(In clsQuestionnaireWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsQuestionnaireWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrQuestionnaire = await Questionnaire_GetObjLst_Cache(strCourseId_C);
        if (arrQuestionnaire == null)
            return [];
        let arrQuestionnaire_Sel = arrQuestionnaire;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrQuestionnaire_Sel.length == 0)
            return [];
        return arrQuestionnaire_Sel.map(x => x.questionID);
    }
    exports.Questionnaire_funcKey = Questionnaire_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function Questionnaire_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetFirstIDAsync = Questionnaire_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function Questionnaire_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetFirstID = Questionnaire_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function Questionnaire_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const objQuestionnaire = Questionnaire_GetObjFromJsonObj(returnObj);
                return objQuestionnaire;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetFirstObjAsync = Questionnaire_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrQuestionnaireExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrQuestionnaireObjLst_T = Questionnaire_GetObjLstByJSONObjLst(arrQuestionnaireExObjLst_Cache);
            return arrQuestionnaireObjLst_T;
        }
        try {
            const arrQuestionnaireExObjLst = await Questionnaire_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrQuestionnaireExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQuestionnaireExObjLst.length);
            console.log(strInfo);
            return arrQuestionnaireExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Questionnaire_GetObjLst_ClientCache = Questionnaire_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQuestionnaireExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQuestionnaireObjLst_T = Questionnaire_GetObjLstByJSONObjLst(arrQuestionnaireExObjLst_Cache);
            return arrQuestionnaireObjLst_T;
        }
        try {
            const arrQuestionnaireExObjLst = await Questionnaire_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrQuestionnaireExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQuestionnaireExObjLst.length);
            console.log(strInfo);
            return arrQuestionnaireExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Questionnaire_GetObjLst_localStorage = Questionnaire_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrQuestionnaireObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQuestionnaireObjLst_Cache;
        }
        else
            return null;
    }
    exports.Questionnaire_GetObjLst_localStorage_PureCache = Questionnaire_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function Questionnaire_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Questionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetObjLstAsync = Questionnaire_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQuestionnaireExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrQuestionnaireObjLst_T = Questionnaire_GetObjLstByJSONObjLst(arrQuestionnaireExObjLst_Cache);
            return arrQuestionnaireObjLst_T;
        }
        try {
            const arrQuestionnaireExObjLst = await Questionnaire_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrQuestionnaireExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrQuestionnaireExObjLst.length);
            console.log(strInfo);
            return arrQuestionnaireExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.Questionnaire_GetObjLst_sessionStorage = Questionnaire_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrQuestionnaireObjLst_Cache = JSON.parse(strTempObjLst);
            return arrQuestionnaireObjLst_Cache;
        }
        else
            return null;
    }
    exports.Questionnaire_GetObjLst_sessionStorage_PureCache = Questionnaire_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[CourseId]不能为空！(in clsQuestionnaireWApi.Questionnaire_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsQuestionnaireWApi.Questionnaire_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrQuestionnaireObjLst_Cache;
        switch (clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheModeId) {
            case "04": //sessionStorage
                arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrQuestionnaireObjLst = Questionnaire_GetObjLstByJSONObjLst(arrQuestionnaireObjLst_Cache);
        return arrQuestionnaireObjLst_Cache;
    }
    exports.Questionnaire_GetObjLst_Cache = Questionnaire_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function Questionnaire_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrQuestionnaireObjLst_Cache;
        switch (clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheModeId) {
            case "04": //sessionStorage
                arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrQuestionnaireObjLst_Cache = null;
                break;
            default:
                arrQuestionnaireObjLst_Cache = null;
                break;
        }
        return arrQuestionnaireObjLst_Cache;
    }
    exports.Questionnaire_GetObjLst_PureCache = Questionnaire_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrQuestionID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Questionnaire_GetSubObjLst_Cache(objQuestionnaire_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        let arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache;
        if (objQuestionnaire_Cond.sf_FldComparisonOp == null || objQuestionnaire_Cond.sf_FldComparisonOp == "")
            return arrQuestionnaire_Sel;
        const dicFldComparisonOp = JSON.parse(objQuestionnaire_Cond.sf_FldComparisonOp);
        //console.log("clsQuestionnaireWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQuestionnaire_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objQuestionnaire_Cond), exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Questionnaire_GetSubObjLst_Cache = Questionnaire_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrQuestionID:关键字列表
    * @returns 对象列表
    **/
    async function Questionnaire_GetObjLstByQuestionIDLstAsync(arrQuestionID) {
        const strThisFuncName = "GetObjLstByQuestionIDLstAsync";
        const strAction = "GetObjLstByQuestionIDLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionID);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Questionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetObjLstByQuestionIDLstAsync = Questionnaire_GetObjLstByQuestionIDLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrQuestionIDLst:关键字列表
     * @returns 对象列表
    */
    async function Questionnaire_GetObjLstByQuestionIDLst_Cache(arrQuestionIDLst, strCourseId) {
        const strThisFuncName = "GetObjLstByQuestionIDLst_Cache";
        try {
            const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
            const arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache.filter(x => arrQuestionIDLst.indexOf(x.questionID) > -1);
            return arrQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrQuestionIDLst.join(","), exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.Questionnaire_GetObjLstByQuestionIDLst_Cache = Questionnaire_GetObjLstByQuestionIDLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function Questionnaire_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Questionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetTopObjLstAsync = Questionnaire_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Questionnaire_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Questionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetObjLstByRangeAsync = Questionnaire_GetObjLstByRangeAsync;
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
    async function Questionnaire_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetObjLstByRange = Questionnaire_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function Questionnaire_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        if (arrQuestionnaireObjLst_Cache.length == 0)
            return arrQuestionnaireObjLst_Cache;
        let arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objQuestionnaire_Cond = new clsQuestionnaireEN_js_1.clsQuestionnaireEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQuestionnaire_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsQuestionnaireWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQuestionnaire_Sel.length == 0)
                return arrQuestionnaire_Sel;
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
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.sort(Questionnaire_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.sort(objPagerPara.sortFun);
            }
            arrQuestionnaire_Sel = arrQuestionnaire_Sel.slice(intStart, intEnd);
            return arrQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.Questionnaire_GetObjLstByPager_Cache = Questionnaire_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function Questionnaire_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.questionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = Questionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetObjLstByPagerAsync = Questionnaire_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strQuestionID:关键字
    * @returns 获取删除的结果
    **/
    async function Questionnaire_DelRecordAsync(strQuestionID) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strQuestionID);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_DelRecordAsync = Questionnaire_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrQuestionID:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function Questionnaire_DelQuestionnairesAsync(arrQuestionID) {
        const strThisFuncName = "DelQuestionnairesAsync";
        const strAction = "DelQuestionnaires";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionID);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_DelQuestionnairesAsync = Questionnaire_DelQuestionnairesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function Questionnaire_DelQuestionnairesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelQuestionnairesByCondAsync";
        const strAction = "DelQuestionnairesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_DelQuestionnairesByCondAsync = Questionnaire_DelQuestionnairesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_AddNewRecordAsync(objQuestionnaireEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objQuestionnaireEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionnaireEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_AddNewRecordAsync = Questionnaire_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_AddNewRecordWithMaxIdAsync(objQuestionnaireEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionnaireEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_AddNewRecordWithMaxIdAsync = Questionnaire_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GoTopAsync = Questionnaire_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objQuestionnaireEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_UpMoveAsync = Questionnaire_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objQuestionnaireEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_DownMoveAsync = Questionnaire_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objQuestionnaireEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GoBottomAsync = Questionnaire_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function Questionnaire_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objQuestionnaireEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_ReOrderAsync = Questionnaire_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objQuestionnaireEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function Questionnaire_AddNewRecordWithReturnKeyAsync(objQuestionnaireEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionnaireEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_AddNewRecordWithReturnKeyAsync = Questionnaire_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objQuestionnaireEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function Questionnaire_AddNewRecordWithReturnKey(objQuestionnaireEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objQuestionnaireEN.questionID === null || objQuestionnaireEN.questionID === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionnaireEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_AddNewRecordWithReturnKey = Questionnaire_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objQuestionnaireEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function Questionnaire_UpdateRecordAsync(objQuestionnaireEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objQuestionnaireEN.sf_UpdFldSetStr === undefined || objQuestionnaireEN.sf_UpdFldSetStr === null || objQuestionnaireEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQuestionnaireEN.questionID);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objQuestionnaireEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_UpdateRecordAsync = Questionnaire_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objQuestionnaireEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function Questionnaire_UpdateWithConditionAsync(objQuestionnaireEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objQuestionnaireEN.sf_UpdFldSetStr === undefined || objQuestionnaireEN.sf_UpdFldSetStr === null || objQuestionnaireEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objQuestionnaireEN.questionID);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        objQuestionnaireEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objQuestionnaireEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_UpdateWithConditionAsync = Questionnaire_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrQuestionID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function Questionnaire_IsExistRecord_Cache(objQuestionnaire_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        if (arrQuestionnaireObjLst_Cache == null)
            return false;
        let arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache;
        if (objQuestionnaire_Cond.sf_FldComparisonOp == null || objQuestionnaire_Cond.sf_FldComparisonOp == "")
            return arrQuestionnaire_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objQuestionnaire_Cond.sf_FldComparisonOp);
        //console.log("clsQuestionnaireWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQuestionnaire_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrQuestionnaire_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objQuestionnaire_Cond), exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.Questionnaire_IsExistRecord_Cache = Questionnaire_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function Questionnaire_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_IsExistRecordAsync = Questionnaire_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strQuestionID:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function Questionnaire_IsExist(strQuestionID, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "QuestionID": strQuestionID,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_IsExist = Questionnaire_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function Questionnaire_IsExist_Cache(strQuestionID, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        if (arrQuestionnaireObjLst_Cache == null)
            return false;
        try {
            const arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache.filter(x => x.questionID == strQuestionID);
            if (arrQuestionnaire_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strQuestionID, exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.Questionnaire_IsExist_Cache = Questionnaire_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strQuestionID:关键字
    * @returns 是否存在?存在返回True
    **/
    async function Questionnaire_IsExistAsync(strQuestionID) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strQuestionID": strQuestionID }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_IsExistAsync = Questionnaire_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function Questionnaire_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetRecCountByCondAsync = Questionnaire_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objQuestionnaire_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function Questionnaire_GetRecCountByCond_Cache(objQuestionnaire_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrQuestionnaireObjLst_Cache = await Questionnaire_GetObjLst_Cache(strCourseId);
        if (arrQuestionnaireObjLst_Cache == null)
            return 0;
        let arrQuestionnaire_Sel = arrQuestionnaireObjLst_Cache;
        if (objQuestionnaire_Cond.sf_FldComparisonOp == null || objQuestionnaire_Cond.sf_FldComparisonOp == "")
            return arrQuestionnaire_Sel.length;
        const dicFldComparisonOp = JSON.parse(objQuestionnaire_Cond.sf_FldComparisonOp);
        //console.log("clsQuestionnaireWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objQuestionnaire_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrQuestionnaire_Sel = arrQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrQuestionnaire_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objQuestionnaire_Cond), exports.questionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.Questionnaire_GetRecCountByCond_Cache = Questionnaire_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function Questionnaire_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetMaxStrIdAsync = Questionnaire_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function Questionnaire_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.questionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.questionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.Questionnaire_GetMaxStrIdByPrefix = Questionnaire_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function Questionnaire_GetWebApiUrl(strController, strAction) {
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
    exports.Questionnaire_GetWebApiUrl = Questionnaire_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function Questionnaire_ReFreshCache(strCourseId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clsQuestionnaireWApi.clsQuestionnaireWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsQuestionnaireWApi.clsQuestionnaireWApi.ReFreshCache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
        switch (clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheModeId) {
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
    exports.Questionnaire_ReFreshCache = Questionnaire_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function Questionnaire_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN._CurrTabName, strCourseId);
            switch (clsQuestionnaireEN_js_1.clsQuestionnaireEN.CacheModeId) {
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
    exports.Questionnaire_ReFreshThisCache = Questionnaire_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
     * @param strCourseId:课程Id
    */
    async function Questionnaire_BindDdl_QuestionIDInDiv_Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "BindDdl_QuestionIDInDiv_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCourseId]不能为空！(In clsQuestionnaireWApi.BindDdl_QuestionIDInDiv)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsQuestionnaireWApi.BindDdl_QuestionIDInDiv)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_2.Format)("下拉框：{0} 不存在！(In BindDdl_QuestionIDInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_QuestionIDInDiv_Cache");
        let arrObjLst_Sel = await Questionnaire_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName, "题目");
    }
    exports.Questionnaire_BindDdl_QuestionIDInDiv_Cache = Questionnaire_BindDdl_QuestionIDInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Questionnaire_CheckPropertyNew(pobjQuestionnaireEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName) === true) {
            throw new Error("(errid:Watl000058)字段[题目名称]不能为空(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseId) === true
            || pobjQuestionnaireEN.courseId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[课程Id]不能为空(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updDate) === true) {
            throw new Error("(errid:Watl000058)字段[修改日期]不能为空(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.levelModeTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[模式Id]不能为空(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionID) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionID) > 8) {
            throw new Error("(errid:Watl000059)字段[题目ID(questionID)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionID)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionName) > 500) {
            throw new Error("(errid:Watl000059)字段[题目名称(questionName)]的长度不能超过500(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionName)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionContent) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionContent) > 4000) {
            throw new Error("(errid:Watl000059)字段[题目内容(questionContent)]的长度不能超过4000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionContent)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionMemo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionMemo) > 1000) {
            throw new Error("(errid:Watl000059)字段[题目说明(questionMemo)]的长度不能超过1000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionMemo)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionNo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionNo) > 10) {
            throw new Error("(errid:Watl000059)字段[题目编号(questionNo)]的长度不能超过10(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionNo)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.parentQuestionId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.parentQuestionId) > 8) {
            throw new Error("(errid:Watl000059)字段[父题目Id(parentQuestionId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.parentQuestionId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examAnswer) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.examAnswer) > 8000) {
            throw new Error("(errid:Watl000059)字段[题目答案(examAnswer)]的长度不能超过8000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.examAnswer)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.courseId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程Id(courseId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.courseId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseChapterId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.courseChapterId) > 8) {
            throw new Error("(errid:Watl000059)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.courseChapterId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[题目类型Id(questionTypeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionTypeId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId4Course) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionTypeId4Course) > 8) {
            throw new Error("(errid:Watl000059)字段[题目类型Id4课程(questionTypeId4Course)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionTypeId4Course)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.answerTypeId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.gridTitle) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.gridTitle) > 30) {
            throw new Error("(errid:Watl000059)字段[表格标题(gridTitle)]的长度不能超过30(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.gridTitle)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerModeId) > 4) {
            throw new Error("(errid:Watl000059)字段[答案模式Id(answerModeId)]的长度不能超过4(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.answerModeId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultValue) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.defaultValue) > 50) {
            throw new Error("(errid:Watl000059)字段[缺省值(defaultValue)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.defaultValue)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultSelectItem) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.defaultSelectItem) > 20) {
            throw new Error("(errid:Watl000059)字段[默认选项(defaultSelectItem)]的长度不能超过20(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.defaultSelectItem)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.limitedResourceType) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.limitedResourceType) > 100) {
            throw new Error("(errid:Watl000059)字段[限制资源类型(limitedResourceType)]的长度不能超过100(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.limitedResourceType)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examGradeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.examGradeId) > 2) {
            throw new Error("(errid:Watl000059)字段[题库等级ID(examGradeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.examGradeId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.textDirectId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.textDirectId) > 4) {
            throw new Error("(errid:Watl000059)字段[文本方向ID(textDirectId)]的长度不能超过4(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.textDirectId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.updDate)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.updUser)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.memo)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionCode) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionCode) > 8000) {
            throw new Error("(errid:Watl000059)字段[html代码(questionCode)]的长度不能超过8000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionCode)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.difficultyLevelId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.difficultyLevelId) > 2) {
            throw new Error("(errid:Watl000059)字段[难度等级Id(difficultyLevelId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.difficultyLevelId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.sectionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.sectionTypeId) > 8) {
            throw new Error("(errid:Watl000059)字段[节点类型Id(sectionTypeId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.sectionTypeId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.knowledgeGraphId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.knowledgeGraphId) > 10) {
            throw new Error("(errid:Watl000059)字段[知识点图Id(knowledgeGraphId)]的长度不能超过10(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.knowledgeGraphId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName_Add) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionName_Add) > 500) {
            throw new Error("(errid:Watl000059)字段[题目补充(questionName_Add)]的长度不能超过500(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionName_Add)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab) > 50) {
            throw new Error("(errid:Watl000059)字段[代码表(codeTab)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Code) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab_Code) > 50) {
            throw new Error("(errid:Watl000059)字段[CodeTab_Code(codeTab_Code)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab_Code)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Condition) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab_Condition) > 200) {
            throw new Error("(errid:Watl000059)字段[代码表_条件(codeTab_Condition)]的长度不能超过200(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab_Condition)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Name) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab_Name) > 50) {
            throw new Error("(errid:Watl000059)字段[CodeTab_Name(codeTab_Name)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab_Name)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.relaEvent) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.relaEvent) > 4000) {
            throw new Error("(errid:Watl000059)字段[相关事件(relaEvent)]的长度不能超过4000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.relaEvent)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.levelModeTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.levelModeTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[模式Id(levelModeTypeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.levelModeTypeId)(clsQuestionnaireBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionID) == false && undefined !== pobjQuestionnaireEN.questionID && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionID) === false) {
            throw new Error("(errid:Watl000060)字段[题目ID(questionID)]的值:[$(pobjQuestionnaireEN.questionID)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.questionIndex && undefined !== pobjQuestionnaireEN.questionIndex && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.questionIndex) === false) {
            throw new Error("(errid:Watl000060)字段[题目序号(questionIndex)]的值:[$(pobjQuestionnaireEN.questionIndex)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName) == false && undefined !== pobjQuestionnaireEN.questionName && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionName) === false) {
            throw new Error("(errid:Watl000060)字段[题目名称(questionName)]的值:[$(pobjQuestionnaireEN.questionName)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionContent) == false && undefined !== pobjQuestionnaireEN.questionContent && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionContent) === false) {
            throw new Error("(errid:Watl000060)字段[题目内容(questionContent)]的值:[$(pobjQuestionnaireEN.questionContent)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionMemo) == false && undefined !== pobjQuestionnaireEN.questionMemo && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionMemo) === false) {
            throw new Error("(errid:Watl000060)字段[题目说明(questionMemo)]的值:[$(pobjQuestionnaireEN.questionMemo)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionNo) == false && undefined !== pobjQuestionnaireEN.questionNo && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionNo) === false) {
            throw new Error("(errid:Watl000060)字段[题目编号(questionNo)]的值:[$(pobjQuestionnaireEN.questionNo)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.parentQuestionId) == false && undefined !== pobjQuestionnaireEN.parentQuestionId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.parentQuestionId) === false) {
            throw new Error("(errid:Watl000060)字段[父题目Id(parentQuestionId)]的值:[$(pobjQuestionnaireEN.parentQuestionId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examAnswer) == false && undefined !== pobjQuestionnaireEN.examAnswer && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.examAnswer) === false) {
            throw new Error("(errid:Watl000060)字段[题目答案(examAnswer)]的值:[$(pobjQuestionnaireEN.examAnswer)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseId) == false && undefined !== pobjQuestionnaireEN.courseId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.courseId) === false) {
            throw new Error("(errid:Watl000060)字段[课程Id(courseId)]的值:[$(pobjQuestionnaireEN.courseId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.levelNo && undefined !== pobjQuestionnaireEN.levelNo && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.levelNo) === false) {
            throw new Error("(errid:Watl000060)字段[学习关号2(levelNo)]的值:[$(pobjQuestionnaireEN.levelNo)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseChapterId) == false && undefined !== pobjQuestionnaireEN.courseChapterId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.courseChapterId) === false) {
            throw new Error("(errid:Watl000060)字段[课程章节ID(courseChapterId)]的值:[$(pobjQuestionnaireEN.courseChapterId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId) == false && undefined !== pobjQuestionnaireEN.questionTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[题目类型Id(questionTypeId)]的值:[$(pobjQuestionnaireEN.questionTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId4Course) == false && undefined !== pobjQuestionnaireEN.questionTypeId4Course && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionTypeId4Course) === false) {
            throw new Error("(errid:Watl000060)字段[题目类型Id4课程(questionTypeId4Course)]的值:[$(pobjQuestionnaireEN.questionTypeId4Course)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerTypeId) == false && undefined !== pobjQuestionnaireEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[答案类型ID(answerTypeId)]的值:[$(pobjQuestionnaireEN.answerTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.gridTitle) == false && undefined !== pobjQuestionnaireEN.gridTitle && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.gridTitle) === false) {
            throw new Error("(errid:Watl000060)字段[表格标题(gridTitle)]的值:[$(pobjQuestionnaireEN.gridTitle)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerModeId) == false && undefined !== pobjQuestionnaireEN.answerModeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.answerModeId) === false) {
            throw new Error("(errid:Watl000060)字段[答案模式Id(answerModeId)]的值:[$(pobjQuestionnaireEN.answerModeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isHaveAdditionalMemo && undefined !== pobjQuestionnaireEN.isHaveAdditionalMemo && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isHaveAdditionalMemo) === false) {
            throw new Error("(errid:Watl000060)字段[是否有附加说明(isHaveAdditionalMemo)]的值:[$(pobjQuestionnaireEN.isHaveAdditionalMemo)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.questionScore && undefined !== pobjQuestionnaireEN.questionScore && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.questionScore) === false) {
            throw new Error("(errid:Watl000060)字段[题目得分(questionScore)]的值:[$(pobjQuestionnaireEN.questionScore)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultValue) == false && undefined !== pobjQuestionnaireEN.defaultValue && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.defaultValue) === false) {
            throw new Error("(errid:Watl000060)字段[缺省值(defaultValue)]的值:[$(pobjQuestionnaireEN.defaultValue)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultSelectItem) == false && undefined !== pobjQuestionnaireEN.defaultSelectItem && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.defaultSelectItem) === false) {
            throw new Error("(errid:Watl000060)字段[默认选项(defaultSelectItem)]的值:[$(pobjQuestionnaireEN.defaultSelectItem)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isShow && undefined !== pobjQuestionnaireEN.isShow && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isShow) === false) {
            throw new Error("(errid:Watl000060)字段[是否启用(isShow)]的值:[$(pobjQuestionnaireEN.isShow)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isCast && undefined !== pobjQuestionnaireEN.isCast && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isCast) === false) {
            throw new Error("(errid:Watl000060)字段[是否播放(isCast)]的值:[$(pobjQuestionnaireEN.isCast)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.likeCount && undefined !== pobjQuestionnaireEN.likeCount && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.likeCount) === false) {
            throw new Error("(errid:Watl000060)字段[资源喜欢数量(likeCount)]的值:[$(pobjQuestionnaireEN.likeCount)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.answerAttLimitSize && undefined !== pobjQuestionnaireEN.answerAttLimitSize && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.answerAttLimitSize) === false) {
            throw new Error("(errid:Watl000060)字段[回答附件限制大小(answerAttLimitSize)]的值:[$(pobjQuestionnaireEN.answerAttLimitSize)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.limitedResourceType) == false && undefined !== pobjQuestionnaireEN.limitedResourceType && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.limitedResourceType) === false) {
            throw new Error("(errid:Watl000060)字段[限制资源类型(limitedResourceType)]的值:[$(pobjQuestionnaireEN.limitedResourceType)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isEffective && undefined !== pobjQuestionnaireEN.isEffective && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isEffective) === false) {
            throw new Error("(errid:Watl000060)字段[是否有效(isEffective)]的值:[$(pobjQuestionnaireEN.isEffective)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isCanInPaper && undefined !== pobjQuestionnaireEN.isCanInPaper && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isCanInPaper) === false) {
            throw new Error("(errid:Watl000060)字段[是否可在Paper(isCanInPaper)]的值:[$(pobjQuestionnaireEN.isCanInPaper)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examGradeId) == false && undefined !== pobjQuestionnaireEN.examGradeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.examGradeId) === false) {
            throw new Error("(errid:Watl000060)字段[题库等级ID(examGradeId)]的值:[$(pobjQuestionnaireEN.examGradeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.textDirectId) == false && undefined !== pobjQuestionnaireEN.textDirectId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.textDirectId) === false) {
            throw new Error("(errid:Watl000060)字段[文本方向ID(textDirectId)]的值:[$(pobjQuestionnaireEN.textDirectId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updDate) == false && undefined !== pobjQuestionnaireEN.updDate && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjQuestionnaireEN.updDate)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updUser) == false && undefined !== pobjQuestionnaireEN.updUser && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjQuestionnaireEN.updUser)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.memo) == false && undefined !== pobjQuestionnaireEN.memo && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjQuestionnaireEN.memo)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionCode) == false && undefined !== pobjQuestionnaireEN.questionCode && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionCode) === false) {
            throw new Error("(errid:Watl000060)字段[html代码(questionCode)]的值:[$(pobjQuestionnaireEN.questionCode)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.difficultyLevelId) == false && undefined !== pobjQuestionnaireEN.difficultyLevelId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.difficultyLevelId) === false) {
            throw new Error("(errid:Watl000060)字段[难度等级Id(difficultyLevelId)]的值:[$(pobjQuestionnaireEN.difficultyLevelId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.sectionTypeId) == false && undefined !== pobjQuestionnaireEN.sectionTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.sectionTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[节点类型Id(sectionTypeId)]的值:[$(pobjQuestionnaireEN.sectionTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.knowledgeGraphId) == false && undefined !== pobjQuestionnaireEN.knowledgeGraphId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.knowledgeGraphId) === false) {
            throw new Error("(errid:Watl000060)字段[知识点图Id(knowledgeGraphId)]的值:[$(pobjQuestionnaireEN.knowledgeGraphId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.firstIndent && undefined !== pobjQuestionnaireEN.firstIndent && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.firstIndent) === false) {
            throw new Error("(errid:Watl000060)字段[首行缩进(firstIndent)]的值:[$(pobjQuestionnaireEN.firstIndent)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName_Add) == false && undefined !== pobjQuestionnaireEN.questionName_Add && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionName_Add) === false) {
            throw new Error("(errid:Watl000060)字段[题目补充(questionName_Add)]的值:[$(pobjQuestionnaireEN.questionName_Add)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab) == false && undefined !== pobjQuestionnaireEN.codeTab && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab) === false) {
            throw new Error("(errid:Watl000060)字段[代码表(codeTab)]的值:[$(pobjQuestionnaireEN.codeTab)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Code) == false && undefined !== pobjQuestionnaireEN.codeTab_Code && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab_Code) === false) {
            throw new Error("(errid:Watl000060)字段[CodeTab_Code(codeTab_Code)]的值:[$(pobjQuestionnaireEN.codeTab_Code)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Condition) == false && undefined !== pobjQuestionnaireEN.codeTab_Condition && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab_Condition) === false) {
            throw new Error("(errid:Watl000060)字段[代码表_条件(codeTab_Condition)]的值:[$(pobjQuestionnaireEN.codeTab_Condition)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Name) == false && undefined !== pobjQuestionnaireEN.codeTab_Name && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab_Name) === false) {
            throw new Error("(errid:Watl000060)字段[CodeTab_Name(codeTab_Name)]的值:[$(pobjQuestionnaireEN.codeTab_Name)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.fillInTextHeight && undefined !== pobjQuestionnaireEN.fillInTextHeight && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.fillInTextHeight) === false) {
            throw new Error("(errid:Watl000060)字段[填空框高度(fillInTextHeight)]的值:[$(pobjQuestionnaireEN.fillInTextHeight)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.fillInTextWidth && undefined !== pobjQuestionnaireEN.fillInTextWidth && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.fillInTextWidth) === false) {
            throw new Error("(errid:Watl000060)字段[填空框宽度(fillInTextWidth)]的值:[$(pobjQuestionnaireEN.fillInTextWidth)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isMulti4FillInText && undefined !== pobjQuestionnaireEN.isMulti4FillInText && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isMulti4FillInText) === false) {
            throw new Error("(errid:Watl000060)字段[是否填空框多行(isMulti4FillInText)]的值:[$(pobjQuestionnaireEN.isMulti4FillInText)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.checkBoxLimitCount && undefined !== pobjQuestionnaireEN.checkBoxLimitCount && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.checkBoxLimitCount) === false) {
            throw new Error("(errid:Watl000060)字段[复选框限制数(checkBoxLimitCount)]的值:[$(pobjQuestionnaireEN.checkBoxLimitCount)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isJs && undefined !== pobjQuestionnaireEN.isJs && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isJs) === false) {
            throw new Error("(errid:Watl000060)字段[是否是JS(isJs)]的值:[$(pobjQuestionnaireEN.isJs)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.memoTextWidth && undefined !== pobjQuestionnaireEN.memoTextWidth && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.memoTextWidth) === false) {
            throw new Error("(errid:Watl000060)字段[备注框宽度(memoTextWidth)]的值:[$(pobjQuestionnaireEN.memoTextWidth)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.relaEvent) == false && undefined !== pobjQuestionnaireEN.relaEvent && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.relaEvent) === false) {
            throw new Error("(errid:Watl000060)字段[相关事件(relaEvent)]的值:[$(pobjQuestionnaireEN.relaEvent)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isTest && undefined !== pobjQuestionnaireEN.isTest && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isTest) === false) {
            throw new Error("(errid:Watl000060)字段[是否测试(isTest)]的值:[$(pobjQuestionnaireEN.isTest)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.levelModeTypeId) == false && undefined !== pobjQuestionnaireEN.levelModeTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.levelModeTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[模式Id(levelModeTypeId)]的值:[$(pobjQuestionnaireEN.levelModeTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if (null != pobjQuestionnaireEN.isRandom && undefined !== pobjQuestionnaireEN.isRandom && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isRandom) === false) {
            throw new Error("(errid:Watl000060)字段[是否随机(isRandom)]的值:[$(pobjQuestionnaireEN.isRandom)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionTypeId) != 2) {
            throw ("(errid:Watl000061)字段[题目类型Id]作为外键字段,长度应该为2(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerTypeId) != 2) {
            throw ("(errid:Watl000061)字段[答案类型ID]作为外键字段,长度应该为2(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerModeId) != 4) {
            throw ("(errid:Watl000061)字段[答案模式Id]作为外键字段,长度应该为4(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjQuestionnaireEN.SetIsCheckProperty(true);
    }
    exports.Questionnaire_CheckPropertyNew = Questionnaire_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function Questionnaire_CheckProperty4Update(pobjQuestionnaireEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionID) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionID) > 8) {
            throw new Error("(errid:Watl000062)字段[题目ID(questionID)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionID)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionName) > 500) {
            throw new Error("(errid:Watl000062)字段[题目名称(questionName)]的长度不能超过500(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionName)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionContent) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionContent) > 4000) {
            throw new Error("(errid:Watl000062)字段[题目内容(questionContent)]的长度不能超过4000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionContent)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionMemo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionMemo) > 1000) {
            throw new Error("(errid:Watl000062)字段[题目说明(questionMemo)]的长度不能超过1000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionMemo)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionNo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionNo) > 10) {
            throw new Error("(errid:Watl000062)字段[题目编号(questionNo)]的长度不能超过10(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionNo)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.parentQuestionId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.parentQuestionId) > 8) {
            throw new Error("(errid:Watl000062)字段[父题目Id(parentQuestionId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.parentQuestionId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examAnswer) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.examAnswer) > 8000) {
            throw new Error("(errid:Watl000062)字段[题目答案(examAnswer)]的长度不能超过8000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.examAnswer)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.courseId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程Id(courseId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.courseId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseChapterId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.courseChapterId) > 8) {
            throw new Error("(errid:Watl000062)字段[课程章节ID(courseChapterId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.courseChapterId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[题目类型Id(questionTypeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionTypeId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId4Course) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionTypeId4Course) > 8) {
            throw new Error("(errid:Watl000062)字段[题目类型Id4课程(questionTypeId4Course)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionTypeId4Course)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[答案类型ID(answerTypeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.answerTypeId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.gridTitle) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.gridTitle) > 30) {
            throw new Error("(errid:Watl000062)字段[表格标题(gridTitle)]的长度不能超过30(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.gridTitle)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerModeId) > 4) {
            throw new Error("(errid:Watl000062)字段[答案模式Id(answerModeId)]的长度不能超过4(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.answerModeId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultValue) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.defaultValue) > 50) {
            throw new Error("(errid:Watl000062)字段[缺省值(defaultValue)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.defaultValue)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultSelectItem) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.defaultSelectItem) > 20) {
            throw new Error("(errid:Watl000062)字段[默认选项(defaultSelectItem)]的长度不能超过20(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.defaultSelectItem)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.limitedResourceType) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.limitedResourceType) > 100) {
            throw new Error("(errid:Watl000062)字段[限制资源类型(limitedResourceType)]的长度不能超过100(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.limitedResourceType)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examGradeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.examGradeId) > 2) {
            throw new Error("(errid:Watl000062)字段[题库等级ID(examGradeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.examGradeId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.textDirectId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.textDirectId) > 4) {
            throw new Error("(errid:Watl000062)字段[文本方向ID(textDirectId)]的长度不能超过4(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.textDirectId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.updDate)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.updUser)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.memo)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionCode) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionCode) > 8000) {
            throw new Error("(errid:Watl000062)字段[html代码(questionCode)]的长度不能超过8000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionCode)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.difficultyLevelId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.difficultyLevelId) > 2) {
            throw new Error("(errid:Watl000062)字段[难度等级Id(difficultyLevelId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.difficultyLevelId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.sectionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.sectionTypeId) > 8) {
            throw new Error("(errid:Watl000062)字段[节点类型Id(sectionTypeId)]的长度不能超过8(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.sectionTypeId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.knowledgeGraphId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.knowledgeGraphId) > 10) {
            throw new Error("(errid:Watl000062)字段[知识点图Id(knowledgeGraphId)]的长度不能超过10(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.knowledgeGraphId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName_Add) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionName_Add) > 500) {
            throw new Error("(errid:Watl000062)字段[题目补充(questionName_Add)]的长度不能超过500(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.questionName_Add)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab) > 50) {
            throw new Error("(errid:Watl000062)字段[代码表(codeTab)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Code) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab_Code) > 50) {
            throw new Error("(errid:Watl000062)字段[CodeTab_Code(codeTab_Code)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab_Code)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Condition) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab_Condition) > 200) {
            throw new Error("(errid:Watl000062)字段[代码表_条件(codeTab_Condition)]的长度不能超过200(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab_Condition)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Name) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.codeTab_Name) > 50) {
            throw new Error("(errid:Watl000062)字段[CodeTab_Name(codeTab_Name)]的长度不能超过50(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.codeTab_Name)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.relaEvent) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.relaEvent) > 4000) {
            throw new Error("(errid:Watl000062)字段[相关事件(relaEvent)]的长度不能超过4000(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.relaEvent)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.levelModeTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.levelModeTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[模式Id(levelModeTypeId)]的长度不能超过2(In 题目(Questionnaire))!值:$(pobjQuestionnaireEN.levelModeTypeId)(clsQuestionnaireBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionID) == false && undefined !== pobjQuestionnaireEN.questionID && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionID) === false) {
            throw new Error("(errid:Watl000063)字段[题目ID(questionID)]的值:[$(pobjQuestionnaireEN.questionID)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.questionIndex && undefined !== pobjQuestionnaireEN.questionIndex && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.questionIndex) === false) {
            throw new Error("(errid:Watl000063)字段[题目序号(questionIndex)]的值:[$(pobjQuestionnaireEN.questionIndex)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName) == false && undefined !== pobjQuestionnaireEN.questionName && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionName) === false) {
            throw new Error("(errid:Watl000063)字段[题目名称(questionName)]的值:[$(pobjQuestionnaireEN.questionName)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionContent) == false && undefined !== pobjQuestionnaireEN.questionContent && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionContent) === false) {
            throw new Error("(errid:Watl000063)字段[题目内容(questionContent)]的值:[$(pobjQuestionnaireEN.questionContent)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionMemo) == false && undefined !== pobjQuestionnaireEN.questionMemo && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionMemo) === false) {
            throw new Error("(errid:Watl000063)字段[题目说明(questionMemo)]的值:[$(pobjQuestionnaireEN.questionMemo)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionNo) == false && undefined !== pobjQuestionnaireEN.questionNo && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionNo) === false) {
            throw new Error("(errid:Watl000063)字段[题目编号(questionNo)]的值:[$(pobjQuestionnaireEN.questionNo)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.parentQuestionId) == false && undefined !== pobjQuestionnaireEN.parentQuestionId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.parentQuestionId) === false) {
            throw new Error("(errid:Watl000063)字段[父题目Id(parentQuestionId)]的值:[$(pobjQuestionnaireEN.parentQuestionId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examAnswer) == false && undefined !== pobjQuestionnaireEN.examAnswer && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.examAnswer) === false) {
            throw new Error("(errid:Watl000063)字段[题目答案(examAnswer)]的值:[$(pobjQuestionnaireEN.examAnswer)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseId) == false && undefined !== pobjQuestionnaireEN.courseId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.courseId) === false) {
            throw new Error("(errid:Watl000063)字段[课程Id(courseId)]的值:[$(pobjQuestionnaireEN.courseId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.levelNo && undefined !== pobjQuestionnaireEN.levelNo && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.levelNo) === false) {
            throw new Error("(errid:Watl000063)字段[学习关号2(levelNo)]的值:[$(pobjQuestionnaireEN.levelNo)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.courseChapterId) == false && undefined !== pobjQuestionnaireEN.courseChapterId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.courseChapterId) === false) {
            throw new Error("(errid:Watl000063)字段[课程章节ID(courseChapterId)]的值:[$(pobjQuestionnaireEN.courseChapterId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId) == false && undefined !== pobjQuestionnaireEN.questionTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[题目类型Id(questionTypeId)]的值:[$(pobjQuestionnaireEN.questionTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId4Course) == false && undefined !== pobjQuestionnaireEN.questionTypeId4Course && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionTypeId4Course) === false) {
            throw new Error("(errid:Watl000063)字段[题目类型Id4课程(questionTypeId4Course)]的值:[$(pobjQuestionnaireEN.questionTypeId4Course)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerTypeId) == false && undefined !== pobjQuestionnaireEN.answerTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.answerTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[答案类型ID(answerTypeId)]的值:[$(pobjQuestionnaireEN.answerTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.gridTitle) == false && undefined !== pobjQuestionnaireEN.gridTitle && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.gridTitle) === false) {
            throw new Error("(errid:Watl000063)字段[表格标题(gridTitle)]的值:[$(pobjQuestionnaireEN.gridTitle)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerModeId) == false && undefined !== pobjQuestionnaireEN.answerModeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.answerModeId) === false) {
            throw new Error("(errid:Watl000063)字段[答案模式Id(answerModeId)]的值:[$(pobjQuestionnaireEN.answerModeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isHaveAdditionalMemo && undefined !== pobjQuestionnaireEN.isHaveAdditionalMemo && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isHaveAdditionalMemo) === false) {
            throw new Error("(errid:Watl000063)字段[是否有附加说明(isHaveAdditionalMemo)]的值:[$(pobjQuestionnaireEN.isHaveAdditionalMemo)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.questionScore && undefined !== pobjQuestionnaireEN.questionScore && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.questionScore) === false) {
            throw new Error("(errid:Watl000063)字段[题目得分(questionScore)]的值:[$(pobjQuestionnaireEN.questionScore)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultValue) == false && undefined !== pobjQuestionnaireEN.defaultValue && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.defaultValue) === false) {
            throw new Error("(errid:Watl000063)字段[缺省值(defaultValue)]的值:[$(pobjQuestionnaireEN.defaultValue)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.defaultSelectItem) == false && undefined !== pobjQuestionnaireEN.defaultSelectItem && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.defaultSelectItem) === false) {
            throw new Error("(errid:Watl000063)字段[默认选项(defaultSelectItem)]的值:[$(pobjQuestionnaireEN.defaultSelectItem)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isShow && undefined !== pobjQuestionnaireEN.isShow && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isShow) === false) {
            throw new Error("(errid:Watl000063)字段[是否启用(isShow)]的值:[$(pobjQuestionnaireEN.isShow)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isCast && undefined !== pobjQuestionnaireEN.isCast && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isCast) === false) {
            throw new Error("(errid:Watl000063)字段[是否播放(isCast)]的值:[$(pobjQuestionnaireEN.isCast)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.likeCount && undefined !== pobjQuestionnaireEN.likeCount && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.likeCount) === false) {
            throw new Error("(errid:Watl000063)字段[资源喜欢数量(likeCount)]的值:[$(pobjQuestionnaireEN.likeCount)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.answerAttLimitSize && undefined !== pobjQuestionnaireEN.answerAttLimitSize && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.answerAttLimitSize) === false) {
            throw new Error("(errid:Watl000063)字段[回答附件限制大小(answerAttLimitSize)]的值:[$(pobjQuestionnaireEN.answerAttLimitSize)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.limitedResourceType) == false && undefined !== pobjQuestionnaireEN.limitedResourceType && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.limitedResourceType) === false) {
            throw new Error("(errid:Watl000063)字段[限制资源类型(limitedResourceType)]的值:[$(pobjQuestionnaireEN.limitedResourceType)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isEffective && undefined !== pobjQuestionnaireEN.isEffective && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isEffective) === false) {
            throw new Error("(errid:Watl000063)字段[是否有效(isEffective)]的值:[$(pobjQuestionnaireEN.isEffective)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isCanInPaper && undefined !== pobjQuestionnaireEN.isCanInPaper && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isCanInPaper) === false) {
            throw new Error("(errid:Watl000063)字段[是否可在Paper(isCanInPaper)]的值:[$(pobjQuestionnaireEN.isCanInPaper)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.examGradeId) == false && undefined !== pobjQuestionnaireEN.examGradeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.examGradeId) === false) {
            throw new Error("(errid:Watl000063)字段[题库等级ID(examGradeId)]的值:[$(pobjQuestionnaireEN.examGradeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.textDirectId) == false && undefined !== pobjQuestionnaireEN.textDirectId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.textDirectId) === false) {
            throw new Error("(errid:Watl000063)字段[文本方向ID(textDirectId)]的值:[$(pobjQuestionnaireEN.textDirectId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updDate) == false && undefined !== pobjQuestionnaireEN.updDate && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjQuestionnaireEN.updDate)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.updUser) == false && undefined !== pobjQuestionnaireEN.updUser && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjQuestionnaireEN.updUser)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.memo) == false && undefined !== pobjQuestionnaireEN.memo && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjQuestionnaireEN.memo)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionCode) == false && undefined !== pobjQuestionnaireEN.questionCode && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionCode) === false) {
            throw new Error("(errid:Watl000063)字段[html代码(questionCode)]的值:[$(pobjQuestionnaireEN.questionCode)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.difficultyLevelId) == false && undefined !== pobjQuestionnaireEN.difficultyLevelId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.difficultyLevelId) === false) {
            throw new Error("(errid:Watl000063)字段[难度等级Id(difficultyLevelId)]的值:[$(pobjQuestionnaireEN.difficultyLevelId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.sectionTypeId) == false && undefined !== pobjQuestionnaireEN.sectionTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.sectionTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[节点类型Id(sectionTypeId)]的值:[$(pobjQuestionnaireEN.sectionTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.knowledgeGraphId) == false && undefined !== pobjQuestionnaireEN.knowledgeGraphId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.knowledgeGraphId) === false) {
            throw new Error("(errid:Watl000063)字段[知识点图Id(knowledgeGraphId)]的值:[$(pobjQuestionnaireEN.knowledgeGraphId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.firstIndent && undefined !== pobjQuestionnaireEN.firstIndent && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.firstIndent) === false) {
            throw new Error("(errid:Watl000063)字段[首行缩进(firstIndent)]的值:[$(pobjQuestionnaireEN.firstIndent)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionName_Add) == false && undefined !== pobjQuestionnaireEN.questionName_Add && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.questionName_Add) === false) {
            throw new Error("(errid:Watl000063)字段[题目补充(questionName_Add)]的值:[$(pobjQuestionnaireEN.questionName_Add)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab) == false && undefined !== pobjQuestionnaireEN.codeTab && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab) === false) {
            throw new Error("(errid:Watl000063)字段[代码表(codeTab)]的值:[$(pobjQuestionnaireEN.codeTab)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Code) == false && undefined !== pobjQuestionnaireEN.codeTab_Code && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab_Code) === false) {
            throw new Error("(errid:Watl000063)字段[CodeTab_Code(codeTab_Code)]的值:[$(pobjQuestionnaireEN.codeTab_Code)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Condition) == false && undefined !== pobjQuestionnaireEN.codeTab_Condition && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab_Condition) === false) {
            throw new Error("(errid:Watl000063)字段[代码表_条件(codeTab_Condition)]的值:[$(pobjQuestionnaireEN.codeTab_Condition)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.codeTab_Name) == false && undefined !== pobjQuestionnaireEN.codeTab_Name && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.codeTab_Name) === false) {
            throw new Error("(errid:Watl000063)字段[CodeTab_Name(codeTab_Name)]的值:[$(pobjQuestionnaireEN.codeTab_Name)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.fillInTextHeight && undefined !== pobjQuestionnaireEN.fillInTextHeight && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.fillInTextHeight) === false) {
            throw new Error("(errid:Watl000063)字段[填空框高度(fillInTextHeight)]的值:[$(pobjQuestionnaireEN.fillInTextHeight)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.fillInTextWidth && undefined !== pobjQuestionnaireEN.fillInTextWidth && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.fillInTextWidth) === false) {
            throw new Error("(errid:Watl000063)字段[填空框宽度(fillInTextWidth)]的值:[$(pobjQuestionnaireEN.fillInTextWidth)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isMulti4FillInText && undefined !== pobjQuestionnaireEN.isMulti4FillInText && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isMulti4FillInText) === false) {
            throw new Error("(errid:Watl000063)字段[是否填空框多行(isMulti4FillInText)]的值:[$(pobjQuestionnaireEN.isMulti4FillInText)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.checkBoxLimitCount && undefined !== pobjQuestionnaireEN.checkBoxLimitCount && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.checkBoxLimitCount) === false) {
            throw new Error("(errid:Watl000063)字段[复选框限制数(checkBoxLimitCount)]的值:[$(pobjQuestionnaireEN.checkBoxLimitCount)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isJs && undefined !== pobjQuestionnaireEN.isJs && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isJs) === false) {
            throw new Error("(errid:Watl000063)字段[是否是JS(isJs)]的值:[$(pobjQuestionnaireEN.isJs)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.memoTextWidth && undefined !== pobjQuestionnaireEN.memoTextWidth && clsString_js_1.tzDataType.isNumber(pobjQuestionnaireEN.memoTextWidth) === false) {
            throw new Error("(errid:Watl000063)字段[备注框宽度(memoTextWidth)]的值:[$(pobjQuestionnaireEN.memoTextWidth)], 非法，应该为数值型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.relaEvent) == false && undefined !== pobjQuestionnaireEN.relaEvent && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.relaEvent) === false) {
            throw new Error("(errid:Watl000063)字段[相关事件(relaEvent)]的值:[$(pobjQuestionnaireEN.relaEvent)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isTest && undefined !== pobjQuestionnaireEN.isTest && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isTest) === false) {
            throw new Error("(errid:Watl000063)字段[是否测试(isTest)]的值:[$(pobjQuestionnaireEN.isTest)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.levelModeTypeId) == false && undefined !== pobjQuestionnaireEN.levelModeTypeId && clsString_js_1.tzDataType.isString(pobjQuestionnaireEN.levelModeTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[模式Id(levelModeTypeId)]的值:[$(pobjQuestionnaireEN.levelModeTypeId)], 非法，应该为字符型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        if (null != pobjQuestionnaireEN.isRandom && undefined !== pobjQuestionnaireEN.isRandom && clsString_js_1.tzDataType.isBoolean(pobjQuestionnaireEN.isRandom) === false) {
            throw new Error("(errid:Watl000063)字段[是否随机(isRandom)]的值:[$(pobjQuestionnaireEN.isRandom)], 非法，应该为布尔型(In 题目(Questionnaire))!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionID) === true
            || pobjQuestionnaireEN.questionID.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[题目ID]不能为空(In 题目)!(clsQuestionnaireBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.questionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.questionTypeId) != 2) {
            throw ("(errid:Watl000065)字段[题目类型Id]作为外键字段,长度应该为2(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerTypeId) != 2) {
            throw ("(errid:Watl000065)字段[答案类型ID]作为外键字段,长度应该为2(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjQuestionnaireEN.answerModeId) == false && (0, clsString_js_2.GetStrLen)(pobjQuestionnaireEN.answerModeId) != 4) {
            throw ("(errid:Watl000065)字段[答案模式Id]作为外键字段,长度应该为4(In 题目)!(clsQuestionnaireBL:CheckPropertyNew)");
        }
        pobjQuestionnaireEN.SetIsCheckProperty(true);
    }
    exports.Questionnaire_CheckProperty4Update = Questionnaire_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Questionnaire_GetJSONStrByObj(pobjQuestionnaireEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjQuestionnaireEN.sf_UpdFldSetStr = pobjQuestionnaireEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjQuestionnaireEN);
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
    exports.Questionnaire_GetJSONStrByObj = Questionnaire_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function Questionnaire_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrQuestionnaireObjLst = new Array();
        if (strJSON === "") {
            return arrQuestionnaireObjLst;
        }
        try {
            arrQuestionnaireObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrQuestionnaireObjLst;
        }
        return arrQuestionnaireObjLst;
    }
    exports.Questionnaire_GetObjLstByJSONStr = Questionnaire_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrQuestionnaireObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function Questionnaire_GetObjLstByJSONObjLst(arrQuestionnaireObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrQuestionnaireObjLst = new Array();
        for (const objInFor of arrQuestionnaireObjLstS) {
            const obj1 = Questionnaire_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrQuestionnaireObjLst.push(obj1);
        }
        return arrQuestionnaireObjLst;
    }
    exports.Questionnaire_GetObjLstByJSONObjLst = Questionnaire_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function Questionnaire_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjQuestionnaireEN = new clsQuestionnaireEN_js_1.clsQuestionnaireEN();
        if (strJSON === "") {
            return pobjQuestionnaireEN;
        }
        try {
            pobjQuestionnaireEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjQuestionnaireEN;
        }
        return pobjQuestionnaireEN;
    }
    exports.Questionnaire_GetObjByJSONStr = Questionnaire_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function Questionnaire_GetCombineCondition(objQuestionnaire_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID) == true) {
            const strComparisonOp_QuestionID = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionID, objQuestionnaire_Cond.questionID, strComparisonOp_QuestionID);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionIndex) == true) {
            const strComparisonOp_QuestionIndex = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionIndex];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionIndex, objQuestionnaire_Cond.questionIndex, strComparisonOp_QuestionIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName) == true) {
            const strComparisonOp_QuestionName = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName, objQuestionnaire_Cond.questionName, strComparisonOp_QuestionName);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionContent) == true) {
            const strComparisonOp_QuestionContent = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionContent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionContent, objQuestionnaire_Cond.questionContent, strComparisonOp_QuestionContent);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionMemo) == true) {
            const strComparisonOp_QuestionMemo = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionMemo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionMemo, objQuestionnaire_Cond.questionMemo, strComparisonOp_QuestionMemo);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionNo) == true) {
            const strComparisonOp_QuestionNo = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionNo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionNo, objQuestionnaire_Cond.questionNo, strComparisonOp_QuestionNo);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ParentQuestionId) == true) {
            const strComparisonOp_ParentQuestionId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ParentQuestionId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ParentQuestionId, objQuestionnaire_Cond.parentQuestionId, strComparisonOp_ParentQuestionId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamAnswer) == true) {
            const strComparisonOp_ExamAnswer = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamAnswer];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamAnswer, objQuestionnaire_Cond.examAnswer, strComparisonOp_ExamAnswer);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseId, objQuestionnaire_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelNo) == true) {
            const strComparisonOp_LevelNo = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelNo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelNo, objQuestionnaire_Cond.levelNo, strComparisonOp_LevelNo);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CourseChapterId, objQuestionnaire_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId) == true) {
            const strComparisonOp_QuestionTypeId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId, objQuestionnaire_Cond.questionTypeId, strComparisonOp_QuestionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId4Course) == true) {
            const strComparisonOp_QuestionTypeId4Course = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId4Course];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionTypeId4Course, objQuestionnaire_Cond.questionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerTypeId, objQuestionnaire_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_GridTitle) == true) {
            const strComparisonOp_GridTitle = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_GridTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_GridTitle, objQuestionnaire_Cond.gridTitle, strComparisonOp_GridTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerModeId) == true) {
            const strComparisonOp_AnswerModeId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerModeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerModeId, objQuestionnaire_Cond.answerModeId, strComparisonOp_AnswerModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsHaveAdditionalMemo) == true) {
            if (objQuestionnaire_Cond.isHaveAdditionalMemo == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsHaveAdditionalMemo);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsHaveAdditionalMemo);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionScore) == true) {
            const strComparisonOp_QuestionScore = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionScore];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionScore, objQuestionnaire_Cond.questionScore, strComparisonOp_QuestionScore);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultValue) == true) {
            const strComparisonOp_DefaultValue = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultValue];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultValue, objQuestionnaire_Cond.defaultValue, strComparisonOp_DefaultValue);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultSelectItem) == true) {
            const strComparisonOp_DefaultSelectItem = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultSelectItem];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DefaultSelectItem, objQuestionnaire_Cond.defaultSelectItem, strComparisonOp_DefaultSelectItem);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsShow) == true) {
            if (objQuestionnaire_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsShow);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCast) == true) {
            if (objQuestionnaire_Cond.isCast == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCast);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCast);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LikeCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LikeCount, objQuestionnaire_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerAttLimitSize) == true) {
            const strComparisonOp_AnswerAttLimitSize = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerAttLimitSize];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_AnswerAttLimitSize, objQuestionnaire_Cond.answerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LimitedResourceType) == true) {
            const strComparisonOp_LimitedResourceType = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LimitedResourceType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LimitedResourceType, objQuestionnaire_Cond.limitedResourceType, strComparisonOp_LimitedResourceType);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsEffective) == true) {
            if (objQuestionnaire_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCanInPaper) == true) {
            if (objQuestionnaire_Cond.isCanInPaper == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCanInPaper);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsCanInPaper);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamGradeId) == true) {
            const strComparisonOp_ExamGradeId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamGradeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_ExamGradeId, objQuestionnaire_Cond.examGradeId, strComparisonOp_ExamGradeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_TextDirectId) == true) {
            const strComparisonOp_TextDirectId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_TextDirectId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_TextDirectId, objQuestionnaire_Cond.textDirectId, strComparisonOp_TextDirectId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdDate, objQuestionnaire_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_UpdUser, objQuestionnaire_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_Memo) == true) {
            const strComparisonOp_Memo = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_Memo, objQuestionnaire_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionCode) == true) {
            const strComparisonOp_QuestionCode = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionCode];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionCode, objQuestionnaire_Cond.questionCode, strComparisonOp_QuestionCode);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DifficultyLevelId) == true) {
            const strComparisonOp_DifficultyLevelId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DifficultyLevelId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_DifficultyLevelId, objQuestionnaire_Cond.difficultyLevelId, strComparisonOp_DifficultyLevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_SectionTypeId) == true) {
            const strComparisonOp_SectionTypeId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_SectionTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_SectionTypeId, objQuestionnaire_Cond.sectionTypeId, strComparisonOp_SectionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_KnowledgeGraphId) == true) {
            const strComparisonOp_KnowledgeGraphId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_KnowledgeGraphId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_KnowledgeGraphId, objQuestionnaire_Cond.knowledgeGraphId, strComparisonOp_KnowledgeGraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FirstIndent) == true) {
            if (objQuestionnaire_Cond.firstIndent == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FirstIndent);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FirstIndent);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName_Add) == true) {
            const strComparisonOp_QuestionName_Add = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName_Add];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_QuestionName_Add, objQuestionnaire_Cond.questionName_Add, strComparisonOp_QuestionName_Add);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab) == true) {
            const strComparisonOp_CodeTab = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab, objQuestionnaire_Cond.codeTab, strComparisonOp_CodeTab);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Code) == true) {
            const strComparisonOp_CodeTab_Code = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Code];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Code, objQuestionnaire_Cond.codeTab_Code, strComparisonOp_CodeTab_Code);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Condition) == true) {
            const strComparisonOp_CodeTab_Condition = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Condition];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Condition, objQuestionnaire_Cond.codeTab_Condition, strComparisonOp_CodeTab_Condition);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Name) == true) {
            const strComparisonOp_CodeTab_Name = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Name];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CodeTab_Name, objQuestionnaire_Cond.codeTab_Name, strComparisonOp_CodeTab_Name);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextHeight) == true) {
            const strComparisonOp_FillInTextHeight = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextHeight];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextHeight, objQuestionnaire_Cond.fillInTextHeight, strComparisonOp_FillInTextHeight);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextWidth) == true) {
            const strComparisonOp_FillInTextWidth = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextWidth];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_FillInTextWidth, objQuestionnaire_Cond.fillInTextWidth, strComparisonOp_FillInTextWidth);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsMulti4FillInText) == true) {
            if (objQuestionnaire_Cond.isMulti4FillInText == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsMulti4FillInText);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsMulti4FillInText);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CheckBoxLimitCount) == true) {
            const strComparisonOp_CheckBoxLimitCount = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CheckBoxLimitCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_CheckBoxLimitCount, objQuestionnaire_Cond.checkBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsJs) == true) {
            if (objQuestionnaire_Cond.isJs == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsJs);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsJs);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_MemoTextWidth) == true) {
            const strComparisonOp_MemoTextWidth = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_MemoTextWidth];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_MemoTextWidth, objQuestionnaire_Cond.memoTextWidth, strComparisonOp_MemoTextWidth);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_RelaEvent) == true) {
            const strComparisonOp_RelaEvent = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_RelaEvent];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_RelaEvent, objQuestionnaire_Cond.relaEvent, strComparisonOp_RelaEvent);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsTest) == true) {
            if (objQuestionnaire_Cond.isTest == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsTest);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsTest);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelModeTypeId) == true) {
            const strComparisonOp_LevelModeTypeId = objQuestionnaire_Cond.dicFldComparisonOp[clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelModeTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_LevelModeTypeId, objQuestionnaire_Cond.levelModeTypeId, strComparisonOp_LevelModeTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objQuestionnaire_Cond.dicFldComparisonOp, clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsRandom) == true) {
            if (objQuestionnaire_Cond.isRandom == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsRandom);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsQuestionnaireEN_js_1.clsQuestionnaireEN.con_IsRandom);
            }
        }
        return strWhereCond;
    }
    exports.Questionnaire_GetCombineCondition = Questionnaire_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--Questionnaire(题目),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strQuestionID: 题目ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Questionnaire_GetUniCondStr_QuestionID(objQuestionnaireEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionID = '{0}'", objQuestionnaireEN.questionID);
        return strWhereCond;
    }
    exports.Questionnaire_GetUniCondStr_QuestionID = Questionnaire_GetUniCondStr_QuestionID;
    /**
    *获取唯一性条件串(Uniqueness)--Questionnaire(题目),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strQuestionID: 题目ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function Questionnaire_GetUniCondStr4Update_QuestionID(objQuestionnaireEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionID <> '{0}'", objQuestionnaireEN.questionID);
        strWhereCond += (0, clsString_js_2.Format)(" and QuestionID = '{0}'", objQuestionnaireEN.questionID);
        return strWhereCond;
    }
    exports.Questionnaire_GetUniCondStr4Update_QuestionID = Questionnaire_GetUniCondStr4Update_QuestionID;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objQuestionnaireENS:源对象
     * @param objQuestionnaireENT:目标对象
    */
    function Questionnaire_CopyObjTo(objQuestionnaireENS, objQuestionnaireENT) {
        objQuestionnaireENT.questionID = objQuestionnaireENS.questionID; //题目ID
        objQuestionnaireENT.questionIndex = objQuestionnaireENS.questionIndex; //题目序号
        objQuestionnaireENT.questionName = objQuestionnaireENS.questionName; //题目名称
        objQuestionnaireENT.questionContent = objQuestionnaireENS.questionContent; //题目内容
        objQuestionnaireENT.questionMemo = objQuestionnaireENS.questionMemo; //题目说明
        objQuestionnaireENT.questionNo = objQuestionnaireENS.questionNo; //题目编号
        objQuestionnaireENT.parentQuestionId = objQuestionnaireENS.parentQuestionId; //父题目Id
        objQuestionnaireENT.examAnswer = objQuestionnaireENS.examAnswer; //题目答案
        objQuestionnaireENT.courseId = objQuestionnaireENS.courseId; //课程Id
        objQuestionnaireENT.levelNo = objQuestionnaireENS.levelNo; //学习关号2
        objQuestionnaireENT.courseChapterId = objQuestionnaireENS.courseChapterId; //课程章节ID
        objQuestionnaireENT.questionTypeId = objQuestionnaireENS.questionTypeId; //题目类型Id
        objQuestionnaireENT.questionTypeId4Course = objQuestionnaireENS.questionTypeId4Course; //题目类型Id4课程
        objQuestionnaireENT.answerTypeId = objQuestionnaireENS.answerTypeId; //答案类型ID
        objQuestionnaireENT.gridTitle = objQuestionnaireENS.gridTitle; //表格标题
        objQuestionnaireENT.answerModeId = objQuestionnaireENS.answerModeId; //答案模式Id
        objQuestionnaireENT.isHaveAdditionalMemo = objQuestionnaireENS.isHaveAdditionalMemo; //是否有附加说明
        objQuestionnaireENT.questionScore = objQuestionnaireENS.questionScore; //题目得分
        objQuestionnaireENT.defaultValue = objQuestionnaireENS.defaultValue; //缺省值
        objQuestionnaireENT.defaultSelectItem = objQuestionnaireENS.defaultSelectItem; //默认选项
        objQuestionnaireENT.isShow = objQuestionnaireENS.isShow; //是否启用
        objQuestionnaireENT.isCast = objQuestionnaireENS.isCast; //是否播放
        objQuestionnaireENT.likeCount = objQuestionnaireENS.likeCount; //资源喜欢数量
        objQuestionnaireENT.answerAttLimitSize = objQuestionnaireENS.answerAttLimitSize; //回答附件限制大小
        objQuestionnaireENT.limitedResourceType = objQuestionnaireENS.limitedResourceType; //限制资源类型
        objQuestionnaireENT.isEffective = objQuestionnaireENS.isEffective; //是否有效
        objQuestionnaireENT.isCanInPaper = objQuestionnaireENS.isCanInPaper; //是否可在Paper
        objQuestionnaireENT.examGradeId = objQuestionnaireENS.examGradeId; //题库等级ID
        objQuestionnaireENT.textDirectId = objQuestionnaireENS.textDirectId; //文本方向ID
        objQuestionnaireENT.updDate = objQuestionnaireENS.updDate; //修改日期
        objQuestionnaireENT.updUser = objQuestionnaireENS.updUser; //修改人
        objQuestionnaireENT.memo = objQuestionnaireENS.memo; //备注
        objQuestionnaireENT.questionCode = objQuestionnaireENS.questionCode; //html代码
        objQuestionnaireENT.difficultyLevelId = objQuestionnaireENS.difficultyLevelId; //难度等级Id
        objQuestionnaireENT.sectionTypeId = objQuestionnaireENS.sectionTypeId; //节点类型Id
        objQuestionnaireENT.knowledgeGraphId = objQuestionnaireENS.knowledgeGraphId; //知识点图Id
        objQuestionnaireENT.firstIndent = objQuestionnaireENS.firstIndent; //首行缩进
        objQuestionnaireENT.questionName_Add = objQuestionnaireENS.questionName_Add; //题目补充
        objQuestionnaireENT.codeTab = objQuestionnaireENS.codeTab; //代码表
        objQuestionnaireENT.codeTab_Code = objQuestionnaireENS.codeTab_Code; //CodeTab_Code
        objQuestionnaireENT.codeTab_Condition = objQuestionnaireENS.codeTab_Condition; //代码表_条件
        objQuestionnaireENT.codeTab_Name = objQuestionnaireENS.codeTab_Name; //CodeTab_Name
        objQuestionnaireENT.fillInTextHeight = objQuestionnaireENS.fillInTextHeight; //填空框高度
        objQuestionnaireENT.fillInTextWidth = objQuestionnaireENS.fillInTextWidth; //填空框宽度
        objQuestionnaireENT.isMulti4FillInText = objQuestionnaireENS.isMulti4FillInText; //是否填空框多行
        objQuestionnaireENT.checkBoxLimitCount = objQuestionnaireENS.checkBoxLimitCount; //复选框限制数
        objQuestionnaireENT.isJs = objQuestionnaireENS.isJs; //是否是JS
        objQuestionnaireENT.memoTextWidth = objQuestionnaireENS.memoTextWidth; //备注框宽度
        objQuestionnaireENT.relaEvent = objQuestionnaireENS.relaEvent; //相关事件
        objQuestionnaireENT.isTest = objQuestionnaireENS.isTest; //是否测试
        objQuestionnaireENT.levelModeTypeId = objQuestionnaireENS.levelModeTypeId; //模式Id
        objQuestionnaireENT.isRandom = objQuestionnaireENS.isRandom; //是否随机
        objQuestionnaireENT.sf_UpdFldSetStr = objQuestionnaireENS.updFldString; //sf_UpdFldSetStr
    }
    exports.Questionnaire_CopyObjTo = Questionnaire_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objQuestionnaireENS:源对象
     * @param objQuestionnaireENT:目标对象
    */
    function Questionnaire_GetObjFromJsonObj(objQuestionnaireENS) {
        const objQuestionnaireENT = new clsQuestionnaireEN_js_1.clsQuestionnaireEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objQuestionnaireENT, objQuestionnaireENS);
        return objQuestionnaireENT;
    }
    exports.Questionnaire_GetObjFromJsonObj = Questionnaire_GetObjFromJsonObj;
});
