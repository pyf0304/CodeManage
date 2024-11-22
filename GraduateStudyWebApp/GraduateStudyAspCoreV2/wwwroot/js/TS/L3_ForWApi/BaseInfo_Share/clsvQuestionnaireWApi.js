/**
* 类名:clsvQuestionnaireWApi
* 表名:vQuestionnaire(01120019)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:31:39
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo_Share/clsvQuestionnaireEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vQuestionnaire_GetObjFromJsonObj = exports.vQuestionnaire_CopyObjTo = exports.vQuestionnaire_GetCombineCondition = exports.vQuestionnaire_GetObjByJSONStr = exports.vQuestionnaire_GetObjLstByJSONObjLst = exports.vQuestionnaire_GetObjLstByJSONStr = exports.vQuestionnaire_GetJSONStrByObj = exports.vQuestionnaire__Cache = exports.vQuestionnaire_ReFreshThisCache = exports.vQuestionnaire_GetWebApiUrl = exports.vQuestionnaire_GetRecCountByCond_Cache = exports.vQuestionnaire_GetRecCountByCondAsync = exports.vQuestionnaire_IsExistAsync = exports.vQuestionnaire_IsExist_Cache = exports.vQuestionnaire_IsExist = exports.vQuestionnaire_IsExistRecordAsync = exports.vQuestionnaire_IsExistRecord_Cache = exports.vQuestionnaire_GetObjLstByPagerAsync = exports.vQuestionnaire_GetObjLstByPager_Cache = exports.vQuestionnaire_GetObjLstByRange = exports.vQuestionnaire_GetObjLstByRangeAsync = exports.vQuestionnaire_GetTopObjLstAsync = exports.vQuestionnaire_GetObjLstByQuestionIDLst_Cache = exports.vQuestionnaire_GetObjLstByQuestionIDLstAsync = exports.vQuestionnaire_GetSubObjLst_Cache = exports.vQuestionnaire_GetObjLst_PureCache = exports.vQuestionnaire_GetObjLst_Cache = exports.vQuestionnaire_GetObjLst_sessionStorage_PureCache = exports.vQuestionnaire_GetObjLst_sessionStorage = exports.vQuestionnaire_GetObjLstAsync = exports.vQuestionnaire_GetObjLst_localStorage_PureCache = exports.vQuestionnaire_GetObjLst_localStorage = exports.vQuestionnaire_GetObjLst_ClientCache = exports.vQuestionnaire_GetFirstObjAsync = exports.vQuestionnaire_GetFirstID = exports.vQuestionnaire_GetFirstIDAsync = exports.vQuestionnaire_funcKey = exports.vQuestionnaire_FilterFunByKey = exports.vQuestionnaire_SortFunByKey = exports.vQuestionnaire_SortFun_Defa_2Fld = exports.vQuestionnaire_SortFun_Defa = exports.vQuestionnaire_func = exports.vQuestionnaire_GetNameByQuestionID_Cache = exports.vQuestionnaire_GetObjByQuestionID_localStorage = exports.vQuestionnaire_GetObjByQuestionID_Cache = exports.vQuestionnaire_GetObjByQuestionIDAsync = exports.vQuestionnaire_ConstructorName = exports.vQuestionnaire_Controller = void 0;
    /**
     * v题目(vQuestionnaire)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvQuestionnaireEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsvQuestionnaireEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vQuestionnaire_Controller = "vQuestionnaireApi";
    exports.vQuestionnaire_ConstructorName = "vQuestionnaire";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strQuestionID:关键字
    * @returns 对象
    **/
    async function vQuestionnaire_GetObjByQuestionIDAsync(strQuestionID) {
        const strThisFuncName = "GetObjByQuestionIDAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaireWApi.GetObjByQuestionIDAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaireWApi.GetObjByQuestionIDAsync)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByQuestionID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const objvQuestionnaire = vQuestionnaire_GetObjFromJsonObj(returnObj);
                return objvQuestionnaire;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetObjByQuestionIDAsync = vQuestionnaire_GetObjByQuestionIDAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_GetObjByQuestionID_Cache(strQuestionID, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByQuestionID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaireWApi.GetObjByQuestionID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaireWApi.GetObjByQuestionID_Cache)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        try {
            const arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache.filter(x => x.questionID == strQuestionID);
            let objvQuestionnaire;
            if (arrvQuestionnaire_Sel.length > 0) {
                objvQuestionnaire = arrvQuestionnaire_Sel[0];
                return objvQuestionnaire;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvQuestionnaire_Const = await vQuestionnaire_GetObjByQuestionIDAsync(strQuestionID);
                    if (objvQuestionnaire_Const != null) {
                        vQuestionnaire_ReFreshThisCache(strCourseId);
                        return objvQuestionnaire_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionID, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vQuestionnaire_GetObjByQuestionID_Cache = vQuestionnaire_GetObjByQuestionID_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_GetObjByQuestionID_localStorage(strQuestionID) {
        const strThisFuncName = "GetObjByQuestionID_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaireWApi.GetObjByQuestionID_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaireWApi.GetObjByQuestionID_localStorage)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strQuestionID);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvQuestionnaire_Cache = JSON.parse(strTempObj);
            return objvQuestionnaire_Cache;
        }
        try {
            const objvQuestionnaire = await vQuestionnaire_GetObjByQuestionIDAsync(strQuestionID);
            if (objvQuestionnaire != null) {
                localStorage.setItem(strKey, JSON.stringify(objvQuestionnaire));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvQuestionnaire;
            }
            return objvQuestionnaire;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionID, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vQuestionnaire_GetObjByQuestionID_localStorage = vQuestionnaire_GetObjByQuestionID_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_GetNameByQuestionID_Cache(strQuestionID, strCourseId) {
        const strThisFuncName = "GetNameByQuestionID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaireWApi.GetNameByQuestionID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaireWApi.GetNameByQuestionID_Cache)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaireObjLst_Cache == null)
            return "";
        try {
            const arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache.filter(x => x.questionID == strQuestionID);
            let objvQuestionnaire;
            if (arrvQuestionnaire_Sel.length > 0) {
                objvQuestionnaire = arrvQuestionnaire_Sel[0];
                return objvQuestionnaire.questionName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strQuestionID);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vQuestionnaire_GetNameByQuestionID_Cache = vQuestionnaire_GetNameByQuestionID_Cache;
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
    async function vQuestionnaire_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvQuestionnaireWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvQuestionnaireWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strQuestionID = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvQuestionnaire = await vQuestionnaire_GetObjByQuestionID_Cache(strQuestionID, strCourseId_C);
        if (objvQuestionnaire == null)
            return "";
        if (objvQuestionnaire.GetFldValue(strOutFldName) == null)
            return "";
        return objvQuestionnaire.GetFldValue(strOutFldName).toString();
    }
    exports.vQuestionnaire_func = vQuestionnaire_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQuestionnaire_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.questionID.localeCompare(b.questionID);
    }
    exports.vQuestionnaire_SortFun_Defa = vQuestionnaire_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQuestionnaire_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionIndex == b.questionIndex)
            return a.questionName.localeCompare(b.questionName);
        else
            return a.questionIndex - b.questionIndex;
    }
    exports.vQuestionnaire_SortFun_Defa_2Fld = vQuestionnaire_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQuestionnaire_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID:
                    return (a, b) => {
                        if (a.questionID == null)
                            return -1;
                        if (b.questionID == null)
                            return 1;
                        return a.questionID.localeCompare(b.questionID);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionIndex:
                    return (a, b) => {
                        return a.questionIndex - b.questionIndex;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName:
                    return (a, b) => {
                        if (a.questionName == null)
                            return -1;
                        if (b.questionName == null)
                            return 1;
                        return a.questionName.localeCompare(b.questionName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionContent:
                    return (a, b) => {
                        if (a.questionContent == null)
                            return -1;
                        if (b.questionContent == null)
                            return 1;
                        return a.questionContent.localeCompare(b.questionContent);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionMemo:
                    return (a, b) => {
                        if (a.questionMemo == null)
                            return -1;
                        if (b.questionMemo == null)
                            return 1;
                        return a.questionMemo.localeCompare(b.questionMemo);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionNo:
                    return (a, b) => {
                        if (a.questionNo == null)
                            return -1;
                        if (b.questionNo == null)
                            return 1;
                        return a.questionNo.localeCompare(b.questionNo);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentQuestionId:
                    return (a, b) => {
                        if (a.parentQuestionId == null)
                            return -1;
                        if (b.parentQuestionId == null)
                            return 1;
                        return a.parentQuestionId.localeCompare(b.parentQuestionId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamAnswer:
                    return (a, b) => {
                        if (a.examAnswer == null)
                            return -1;
                        if (b.examAnswer == null)
                            return 1;
                        return a.examAnswer.localeCompare(b.examAnswer);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LevelNo:
                    return (a, b) => {
                        return a.levelNo - b.levelNo;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterId:
                    return (a, b) => {
                        if (a.courseChapterId == null)
                            return -1;
                        if (b.courseChapterId == null)
                            return 1;
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterName:
                    return (a, b) => {
                        if (a.courseChapterName == null)
                            return -1;
                        if (b.courseChapterName == null)
                            return 1;
                        return a.courseChapterName.localeCompare(b.courseChapterName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterId:
                    return (a, b) => {
                        if (a.chapterId == null)
                            return -1;
                        if (b.chapterId == null)
                            return 1;
                        return a.chapterId.localeCompare(b.chapterId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName:
                    return (a, b) => {
                        if (a.chapterName == null)
                            return -1;
                        if (b.chapterName == null)
                            return 1;
                        return a.chapterName.localeCompare(b.chapterName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (a.chapterName_Sim == null)
                            return -1;
                        if (b.chapterName_Sim == null)
                            return 1;
                        return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (a.sectionName_Sim == null)
                            return -1;
                        if (b.sectionName_Sim == null)
                            return 1;
                        return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeID:
                    return (a, b) => {
                        if (a.parentNodeID == null)
                            return -1;
                        if (b.parentNodeID == null)
                            return 1;
                        return a.parentNodeID.localeCompare(b.parentNodeID);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterReferred:
                    return (a, b) => {
                        if (a.courseChapterReferred == null)
                            return -1;
                        if (b.courseChapterReferred == null)
                            return 1;
                        return a.courseChapterReferred.localeCompare(b.courseChapterReferred);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeName:
                    return (a, b) => {
                        if (a.parentNodeName == null)
                            return -1;
                        if (b.parentNodeName == null)
                            return 1;
                        return a.parentNodeName.localeCompare(b.parentNodeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeReferred:
                    return (a, b) => {
                        if (a.parentNodeReferred == null)
                            return -1;
                        if (b.parentNodeReferred == null)
                            return 1;
                        return a.parentNodeReferred.localeCompare(b.parentNodeReferred);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId:
                    return (a, b) => {
                        if (a.questionTypeId == null)
                            return -1;
                        if (b.questionTypeId == null)
                            return 1;
                        return a.questionTypeId.localeCompare(b.questionTypeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName:
                    return (a, b) => {
                        if (a.questionTypeName == null)
                            return -1;
                        if (b.questionTypeName == null)
                            return 1;
                        return a.questionTypeName.localeCompare(b.questionTypeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId4Course:
                    return (a, b) => {
                        return a.questionTypeId4Course.localeCompare(b.questionTypeId4Course);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName4Course:
                    return (a, b) => {
                        if (a.questionTypeName4Course == null)
                            return -1;
                        if (b.questionTypeName4Course == null)
                            return 1;
                        return a.questionTypeName4Course.localeCompare(b.questionTypeName4Course);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (a.answerTypeId == null)
                            return -1;
                        if (b.answerTypeId == null)
                            return 1;
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeName:
                    return (a, b) => {
                        if (a.answerTypeName == null)
                            return -1;
                        if (b.answerTypeName == null)
                            return 1;
                        return a.answerTypeName.localeCompare(b.answerTypeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_GridTitle:
                    return (a, b) => {
                        if (a.gridTitle == null)
                            return -1;
                        if (b.gridTitle == null)
                            return 1;
                        return a.gridTitle.localeCompare(b.gridTitle);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeId:
                    return (a, b) => {
                        if (a.answerModeId == null)
                            return -1;
                        if (b.answerModeId == null)
                            return 1;
                        return a.answerModeId.localeCompare(b.answerModeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeName:
                    return (a, b) => {
                        if (a.answerModeName == null)
                            return -1;
                        if (b.answerModeName == null)
                            return 1;
                        return a.answerModeName.localeCompare(b.answerModeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionScore:
                    return (a, b) => {
                        return a.questionScore - b.questionScore;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultValue:
                    return (a, b) => {
                        if (a.defaultValue == null)
                            return -1;
                        if (b.defaultValue == null)
                            return 1;
                        return a.defaultValue.localeCompare(b.defaultValue);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultSelectItem:
                    return (a, b) => {
                        if (a.defaultSelectItem == null)
                            return -1;
                        if (b.defaultSelectItem == null)
                            return 1;
                        return a.defaultSelectItem.localeCompare(b.defaultSelectItem);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCast:
                    return (a, b) => {
                        if (a.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerAttLimitSize:
                    return (a, b) => {
                        return a.answerAttLimitSize - b.answerAttLimitSize;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LimitedResourceType:
                    return (a, b) => {
                        if (a.limitedResourceType == null)
                            return -1;
                        if (b.limitedResourceType == null)
                            return 1;
                        return a.limitedResourceType.localeCompare(b.limitedResourceType);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCanInPaper:
                    return (a, b) => {
                        if (a.isCanInPaper == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeId:
                    return (a, b) => {
                        if (a.examGradeId == null)
                            return -1;
                        if (b.examGradeId == null)
                            return 1;
                        return a.examGradeId.localeCompare(b.examGradeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeName:
                    return (a, b) => {
                        if (a.examGradeName == null)
                            return -1;
                        if (b.examGradeName == null)
                            return 1;
                        return a.examGradeName.localeCompare(b.examGradeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_TextDirectId:
                    return (a, b) => {
                        if (a.textDirectId == null)
                            return -1;
                        if (b.textDirectId == null)
                            return 1;
                        return a.textDirectId.localeCompare(b.textDirectId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FirstIndent:
                    return (a, b) => {
                        if (a.firstIndent == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab:
                    return (a, b) => {
                        if (a.codeTab == null)
                            return -1;
                        if (b.codeTab == null)
                            return 1;
                        return a.codeTab.localeCompare(b.codeTab);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Code:
                    return (a, b) => {
                        if (a.codeTab_Code == null)
                            return -1;
                        if (b.codeTab_Code == null)
                            return 1;
                        return a.codeTab_Code.localeCompare(b.codeTab_Code);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Condition:
                    return (a, b) => {
                        if (a.codeTab_Condition == null)
                            return -1;
                        if (b.codeTab_Condition == null)
                            return 1;
                        return a.codeTab_Condition.localeCompare(b.codeTab_Condition);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Name:
                    return (a, b) => {
                        if (a.codeTab_Name == null)
                            return -1;
                        if (b.codeTab_Name == null)
                            return 1;
                        return a.codeTab_Name.localeCompare(b.codeTab_Name);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId_Chapter:
                    return (a, b) => {
                        if (a.courseId_Chapter == null)
                            return -1;
                        if (b.courseId_Chapter == null)
                            return 1;
                        return a.courseId_Chapter.localeCompare(b.courseId_Chapter);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_OptionNum:
                    return (a, b) => {
                        return a.optionNum - b.optionNum;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterOrderNum:
                    return (a, b) => {
                        return a.chapterOrderNum - b.chapterOrderNum;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName_Add:
                    return (a, b) => {
                        if (a.questionName_Add == null)
                            return -1;
                        if (b.questionName_Add == null)
                            return 1;
                        return a.questionName_Add.localeCompare(b.questionName_Add);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DifficultyLevelId:
                    return (a, b) => {
                        if (a.difficultyLevelId == null)
                            return -1;
                        if (b.difficultyLevelId == null)
                            return 1;
                        return a.difficultyLevelId.localeCompare(b.difficultyLevelId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextHeight:
                    return (a, b) => {
                        return a.fillInTextHeight - b.fillInTextHeight;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextWidth:
                    return (a, b) => {
                        return a.fillInTextWidth - b.fillInTextWidth;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsHaveAdditionalMemo:
                    return (a, b) => {
                        if (a.isHaveAdditionalMemo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsJs:
                    return (a, b) => {
                        if (a.isJs == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsMulti4FillInText:
                    return (a, b) => {
                        if (a.isMulti4FillInText == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_KnowledgeGraphId:
                    return (a, b) => {
                        if (a.knowledgeGraphId == null)
                            return -1;
                        if (b.knowledgeGraphId == null)
                            return 1;
                        return a.knowledgeGraphId.localeCompare(b.knowledgeGraphId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_MemoTextWidth:
                    return (a, b) => {
                        return a.memoTextWidth - b.memoTextWidth;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionCode:
                    return (a, b) => {
                        if (a.questionCode == null)
                            return -1;
                        if (b.questionCode == null)
                            return 1;
                        return a.questionCode.localeCompare(b.questionCode);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionTypeId:
                    return (a, b) => {
                        if (a.sectionTypeId == null)
                            return -1;
                        if (b.sectionTypeId == null)
                            return 1;
                        return a.sectionTypeId.localeCompare(b.sectionTypeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CheckBoxLimitCount:
                    return (a, b) => {
                        return a.checkBoxLimitCount - b.checkBoxLimitCount;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_RelaEvent:
                    return (a, b) => {
                        if (a.relaEvent == null)
                            return -1;
                        if (b.relaEvent == null)
                            return 1;
                        return a.relaEvent.localeCompare(b.relaEvent);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQuestionnaire]中不存在！(in ${exports.vQuestionnaire_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID:
                    return (a, b) => {
                        if (b.questionID == null)
                            return -1;
                        if (a.questionID == null)
                            return 1;
                        return b.questionID.localeCompare(a.questionID);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionIndex:
                    return (a, b) => {
                        return b.questionIndex - a.questionIndex;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName:
                    return (a, b) => {
                        if (b.questionName == null)
                            return -1;
                        if (a.questionName == null)
                            return 1;
                        return b.questionName.localeCompare(a.questionName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionContent:
                    return (a, b) => {
                        if (b.questionContent == null)
                            return -1;
                        if (a.questionContent == null)
                            return 1;
                        return b.questionContent.localeCompare(a.questionContent);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionMemo:
                    return (a, b) => {
                        if (b.questionMemo == null)
                            return -1;
                        if (a.questionMemo == null)
                            return 1;
                        return b.questionMemo.localeCompare(a.questionMemo);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionNo:
                    return (a, b) => {
                        if (b.questionNo == null)
                            return -1;
                        if (a.questionNo == null)
                            return 1;
                        return b.questionNo.localeCompare(a.questionNo);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentQuestionId:
                    return (a, b) => {
                        if (b.parentQuestionId == null)
                            return -1;
                        if (a.parentQuestionId == null)
                            return 1;
                        return b.parentQuestionId.localeCompare(a.parentQuestionId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamAnswer:
                    return (a, b) => {
                        if (b.examAnswer == null)
                            return -1;
                        if (a.examAnswer == null)
                            return 1;
                        return b.examAnswer.localeCompare(a.examAnswer);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LevelNo:
                    return (a, b) => {
                        return b.levelNo - a.levelNo;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterId:
                    return (a, b) => {
                        if (b.courseChapterId == null)
                            return -1;
                        if (a.courseChapterId == null)
                            return 1;
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterName:
                    return (a, b) => {
                        if (b.courseChapterName == null)
                            return -1;
                        if (a.courseChapterName == null)
                            return 1;
                        return b.courseChapterName.localeCompare(a.courseChapterName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterId:
                    return (a, b) => {
                        if (b.chapterId == null)
                            return -1;
                        if (a.chapterId == null)
                            return 1;
                        return b.chapterId.localeCompare(a.chapterId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName:
                    return (a, b) => {
                        if (b.chapterName == null)
                            return -1;
                        if (a.chapterName == null)
                            return 1;
                        return b.chapterName.localeCompare(a.chapterName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (b.chapterName_Sim == null)
                            return -1;
                        if (a.chapterName_Sim == null)
                            return 1;
                        return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (b.sectionName_Sim == null)
                            return -1;
                        if (a.sectionName_Sim == null)
                            return 1;
                        return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeID:
                    return (a, b) => {
                        if (b.parentNodeID == null)
                            return -1;
                        if (a.parentNodeID == null)
                            return 1;
                        return b.parentNodeID.localeCompare(a.parentNodeID);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterReferred:
                    return (a, b) => {
                        if (b.courseChapterReferred == null)
                            return -1;
                        if (a.courseChapterReferred == null)
                            return 1;
                        return b.courseChapterReferred.localeCompare(a.courseChapterReferred);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeName:
                    return (a, b) => {
                        if (b.parentNodeName == null)
                            return -1;
                        if (a.parentNodeName == null)
                            return 1;
                        return b.parentNodeName.localeCompare(a.parentNodeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeReferred:
                    return (a, b) => {
                        if (b.parentNodeReferred == null)
                            return -1;
                        if (a.parentNodeReferred == null)
                            return 1;
                        return b.parentNodeReferred.localeCompare(a.parentNodeReferred);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId:
                    return (a, b) => {
                        if (b.questionTypeId == null)
                            return -1;
                        if (a.questionTypeId == null)
                            return 1;
                        return b.questionTypeId.localeCompare(a.questionTypeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName:
                    return (a, b) => {
                        if (b.questionTypeName == null)
                            return -1;
                        if (a.questionTypeName == null)
                            return 1;
                        return b.questionTypeName.localeCompare(a.questionTypeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId4Course:
                    return (a, b) => {
                        return b.questionTypeId4Course.localeCompare(a.questionTypeId4Course);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName4Course:
                    return (a, b) => {
                        if (b.questionTypeName4Course == null)
                            return -1;
                        if (a.questionTypeName4Course == null)
                            return 1;
                        return b.questionTypeName4Course.localeCompare(a.questionTypeName4Course);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (b.answerTypeId == null)
                            return -1;
                        if (a.answerTypeId == null)
                            return 1;
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeName:
                    return (a, b) => {
                        if (b.answerTypeName == null)
                            return -1;
                        if (a.answerTypeName == null)
                            return 1;
                        return b.answerTypeName.localeCompare(a.answerTypeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_GridTitle:
                    return (a, b) => {
                        if (b.gridTitle == null)
                            return -1;
                        if (a.gridTitle == null)
                            return 1;
                        return b.gridTitle.localeCompare(a.gridTitle);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeId:
                    return (a, b) => {
                        if (b.answerModeId == null)
                            return -1;
                        if (a.answerModeId == null)
                            return 1;
                        return b.answerModeId.localeCompare(a.answerModeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeName:
                    return (a, b) => {
                        if (b.answerModeName == null)
                            return -1;
                        if (a.answerModeName == null)
                            return 1;
                        return b.answerModeName.localeCompare(a.answerModeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionScore:
                    return (a, b) => {
                        return b.questionScore - a.questionScore;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultValue:
                    return (a, b) => {
                        if (b.defaultValue == null)
                            return -1;
                        if (a.defaultValue == null)
                            return 1;
                        return b.defaultValue.localeCompare(a.defaultValue);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultSelectItem:
                    return (a, b) => {
                        if (b.defaultSelectItem == null)
                            return -1;
                        if (a.defaultSelectItem == null)
                            return 1;
                        return b.defaultSelectItem.localeCompare(a.defaultSelectItem);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCast:
                    return (a, b) => {
                        if (b.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerAttLimitSize:
                    return (a, b) => {
                        return b.answerAttLimitSize - a.answerAttLimitSize;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LimitedResourceType:
                    return (a, b) => {
                        if (b.limitedResourceType == null)
                            return -1;
                        if (a.limitedResourceType == null)
                            return 1;
                        return b.limitedResourceType.localeCompare(a.limitedResourceType);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCanInPaper:
                    return (a, b) => {
                        if (b.isCanInPaper == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeId:
                    return (a, b) => {
                        if (b.examGradeId == null)
                            return -1;
                        if (a.examGradeId == null)
                            return 1;
                        return b.examGradeId.localeCompare(a.examGradeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeName:
                    return (a, b) => {
                        if (b.examGradeName == null)
                            return -1;
                        if (a.examGradeName == null)
                            return 1;
                        return b.examGradeName.localeCompare(a.examGradeName);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_TextDirectId:
                    return (a, b) => {
                        if (b.textDirectId == null)
                            return -1;
                        if (a.textDirectId == null)
                            return 1;
                        return b.textDirectId.localeCompare(a.textDirectId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FirstIndent:
                    return (a, b) => {
                        if (b.firstIndent == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab:
                    return (a, b) => {
                        if (b.codeTab == null)
                            return -1;
                        if (a.codeTab == null)
                            return 1;
                        return b.codeTab.localeCompare(a.codeTab);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Code:
                    return (a, b) => {
                        if (b.codeTab_Code == null)
                            return -1;
                        if (a.codeTab_Code == null)
                            return 1;
                        return b.codeTab_Code.localeCompare(a.codeTab_Code);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Condition:
                    return (a, b) => {
                        if (b.codeTab_Condition == null)
                            return -1;
                        if (a.codeTab_Condition == null)
                            return 1;
                        return b.codeTab_Condition.localeCompare(a.codeTab_Condition);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Name:
                    return (a, b) => {
                        if (b.codeTab_Name == null)
                            return -1;
                        if (a.codeTab_Name == null)
                            return 1;
                        return b.codeTab_Name.localeCompare(a.codeTab_Name);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId_Chapter:
                    return (a, b) => {
                        if (b.courseId_Chapter == null)
                            return -1;
                        if (a.courseId_Chapter == null)
                            return 1;
                        return b.courseId_Chapter.localeCompare(a.courseId_Chapter);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_OptionNum:
                    return (a, b) => {
                        return b.optionNum - a.optionNum;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterOrderNum:
                    return (a, b) => {
                        return b.chapterOrderNum - a.chapterOrderNum;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName_Add:
                    return (a, b) => {
                        if (b.questionName_Add == null)
                            return -1;
                        if (a.questionName_Add == null)
                            return 1;
                        return b.questionName_Add.localeCompare(a.questionName_Add);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DifficultyLevelId:
                    return (a, b) => {
                        if (b.difficultyLevelId == null)
                            return -1;
                        if (a.difficultyLevelId == null)
                            return 1;
                        return b.difficultyLevelId.localeCompare(a.difficultyLevelId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextHeight:
                    return (a, b) => {
                        return b.fillInTextHeight - a.fillInTextHeight;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextWidth:
                    return (a, b) => {
                        return b.fillInTextWidth - a.fillInTextWidth;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsHaveAdditionalMemo:
                    return (a, b) => {
                        if (b.isHaveAdditionalMemo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsJs:
                    return (a, b) => {
                        if (b.isJs == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsMulti4FillInText:
                    return (a, b) => {
                        if (b.isMulti4FillInText == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_KnowledgeGraphId:
                    return (a, b) => {
                        if (b.knowledgeGraphId == null)
                            return -1;
                        if (a.knowledgeGraphId == null)
                            return 1;
                        return b.knowledgeGraphId.localeCompare(a.knowledgeGraphId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_MemoTextWidth:
                    return (a, b) => {
                        return b.memoTextWidth - a.memoTextWidth;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionCode:
                    return (a, b) => {
                        if (b.questionCode == null)
                            return -1;
                        if (a.questionCode == null)
                            return 1;
                        return b.questionCode.localeCompare(a.questionCode);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionTypeId:
                    return (a, b) => {
                        if (b.sectionTypeId == null)
                            return -1;
                        if (a.sectionTypeId == null)
                            return 1;
                        return b.sectionTypeId.localeCompare(a.sectionTypeId);
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CheckBoxLimitCount:
                    return (a, b) => {
                        return b.checkBoxLimitCount - a.checkBoxLimitCount;
                    };
                case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_RelaEvent:
                    return (a, b) => {
                        if (b.relaEvent == null)
                            return -1;
                        if (a.relaEvent == null)
                            return 1;
                        return b.relaEvent.localeCompare(a.relaEvent);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQuestionnaire]中不存在！(in ${exports.vQuestionnaire_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vQuestionnaire_SortFunByKey = vQuestionnaire_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vQuestionnaire_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID:
                return (obj) => {
                    return obj.questionID === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionIndex:
                return (obj) => {
                    return obj.questionIndex === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName:
                return (obj) => {
                    return obj.questionName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionContent:
                return (obj) => {
                    return obj.questionContent === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionMemo:
                return (obj) => {
                    return obj.questionMemo === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionNo:
                return (obj) => {
                    return obj.questionNo === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentQuestionId:
                return (obj) => {
                    return obj.parentQuestionId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamAnswer:
                return (obj) => {
                    return obj.examAnswer === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LevelNo:
                return (obj) => {
                    return obj.levelNo === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterName:
                return (obj) => {
                    return obj.courseChapterName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterId:
                return (obj) => {
                    return obj.chapterId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName:
                return (obj) => {
                    return obj.chapterName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName_Sim:
                return (obj) => {
                    return obj.chapterName_Sim === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName_Sim:
                return (obj) => {
                    return obj.sectionName_Sim === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeID:
                return (obj) => {
                    return obj.parentNodeID === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterReferred:
                return (obj) => {
                    return obj.courseChapterReferred === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeName:
                return (obj) => {
                    return obj.parentNodeName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeReferred:
                return (obj) => {
                    return obj.parentNodeReferred === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId:
                return (obj) => {
                    return obj.questionTypeId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName:
                return (obj) => {
                    return obj.questionTypeName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId4Course:
                return (obj) => {
                    return obj.questionTypeId4Course === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName4Course:
                return (obj) => {
                    return obj.questionTypeName4Course === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeName:
                return (obj) => {
                    return obj.answerTypeName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_GridTitle:
                return (obj) => {
                    return obj.gridTitle === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeId:
                return (obj) => {
                    return obj.answerModeId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeName:
                return (obj) => {
                    return obj.answerModeName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionScore:
                return (obj) => {
                    return obj.questionScore === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultValue:
                return (obj) => {
                    return obj.defaultValue === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultSelectItem:
                return (obj) => {
                    return obj.defaultSelectItem === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCast:
                return (obj) => {
                    return obj.isCast === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerAttLimitSize:
                return (obj) => {
                    return obj.answerAttLimitSize === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LimitedResourceType:
                return (obj) => {
                    return obj.limitedResourceType === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCanInPaper:
                return (obj) => {
                    return obj.isCanInPaper === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeId:
                return (obj) => {
                    return obj.examGradeId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeName:
                return (obj) => {
                    return obj.examGradeName === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_TextDirectId:
                return (obj) => {
                    return obj.textDirectId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FirstIndent:
                return (obj) => {
                    return obj.firstIndent === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab:
                return (obj) => {
                    return obj.codeTab === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Code:
                return (obj) => {
                    return obj.codeTab_Code === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Condition:
                return (obj) => {
                    return obj.codeTab_Condition === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Name:
                return (obj) => {
                    return obj.codeTab_Name === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId_Chapter:
                return (obj) => {
                    return obj.courseId_Chapter === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_OptionNum:
                return (obj) => {
                    return obj.optionNum === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterOrderNum:
                return (obj) => {
                    return obj.chapterOrderNum === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName_Add:
                return (obj) => {
                    return obj.questionName_Add === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DifficultyLevelId:
                return (obj) => {
                    return obj.difficultyLevelId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextHeight:
                return (obj) => {
                    return obj.fillInTextHeight === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextWidth:
                return (obj) => {
                    return obj.fillInTextWidth === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsHaveAdditionalMemo:
                return (obj) => {
                    return obj.isHaveAdditionalMemo === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsJs:
                return (obj) => {
                    return obj.isJs === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsMulti4FillInText:
                return (obj) => {
                    return obj.isMulti4FillInText === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_KnowledgeGraphId:
                return (obj) => {
                    return obj.knowledgeGraphId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_MemoTextWidth:
                return (obj) => {
                    return obj.memoTextWidth === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionCode:
                return (obj) => {
                    return obj.questionCode === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionTypeId:
                return (obj) => {
                    return obj.sectionTypeId === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CheckBoxLimitCount:
                return (obj) => {
                    return obj.checkBoxLimitCount === value;
                };
            case clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_RelaEvent:
                return (obj) => {
                    return obj.relaEvent === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vQuestionnaire]中不存在！(in ${exports.vQuestionnaire_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vQuestionnaire_FilterFunByKey = vQuestionnaire_FilterFunByKey;
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
    async function vQuestionnaire_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvQuestionnaireWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvQuestionnaireWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvQuestionnaire = await vQuestionnaire_GetObjLst_Cache(strCourseId_C);
        if (arrvQuestionnaire == null)
            return [];
        let arrvQuestionnaire_Sel = arrvQuestionnaire;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvQuestionnaire_Sel.length == 0)
            return [];
        return arrvQuestionnaire_Sel.map(x => x.questionID);
    }
    exports.vQuestionnaire_funcKey = vQuestionnaire_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vQuestionnaire_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetFirstIDAsync = vQuestionnaire_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vQuestionnaire_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetFirstID = vQuestionnaire_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vQuestionnaire_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const objvQuestionnaire = vQuestionnaire_GetObjFromJsonObj(returnObj);
                return objvQuestionnaire;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetFirstObjAsync = vQuestionnaire_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvQuestionnaireExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvQuestionnaireObjLst_T = vQuestionnaire_GetObjLstByJSONObjLst(arrvQuestionnaireExObjLst_Cache);
            return arrvQuestionnaireObjLst_T;
        }
        try {
            const arrvQuestionnaireExObjLst = await vQuestionnaire_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvQuestionnaireExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQuestionnaireExObjLst.length);
            console.log(strInfo);
            return arrvQuestionnaireExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQuestionnaire_GetObjLst_ClientCache = vQuestionnaire_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQuestionnaireExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQuestionnaireObjLst_T = vQuestionnaire_GetObjLstByJSONObjLst(arrvQuestionnaireExObjLst_Cache);
            return arrvQuestionnaireObjLst_T;
        }
        try {
            const arrvQuestionnaireExObjLst = await vQuestionnaire_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvQuestionnaireExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQuestionnaireExObjLst.length);
            console.log(strInfo);
            return arrvQuestionnaireExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQuestionnaire_GetObjLst_localStorage = vQuestionnaire_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQuestionnaireObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQuestionnaireObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQuestionnaire_GetObjLst_localStorage_PureCache = vQuestionnaire_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vQuestionnaire_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetObjLstAsync = vQuestionnaire_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQuestionnaireExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQuestionnaireObjLst_T = vQuestionnaire_GetObjLstByJSONObjLst(arrvQuestionnaireExObjLst_Cache);
            return arrvQuestionnaireObjLst_T;
        }
        try {
            const arrvQuestionnaireExObjLst = await vQuestionnaire_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvQuestionnaireExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQuestionnaireExObjLst.length);
            console.log(strInfo);
            return arrvQuestionnaireExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQuestionnaire_GetObjLst_sessionStorage = vQuestionnaire_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQuestionnaireObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQuestionnaireObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQuestionnaire_GetObjLst_sessionStorage_PureCache = vQuestionnaire_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[CourseId]不能为空！(in clsvQuestionnaireWApi.vQuestionnaire_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsvQuestionnaireWApi.vQuestionnaire_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvQuestionnaireObjLst_Cache;
        switch (clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrvQuestionnaireObjLst = vQuestionnaire_GetObjLstByJSONObjLst(arrvQuestionnaireObjLst_Cache);
        return arrvQuestionnaireObjLst_Cache;
    }
    exports.vQuestionnaire_GetObjLst_Cache = vQuestionnaire_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvQuestionnaireObjLst_Cache;
        switch (clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrvQuestionnaireObjLst_Cache = null;
                break;
            default:
                arrvQuestionnaireObjLst_Cache = null;
                break;
        }
        return arrvQuestionnaireObjLst_Cache;
    }
    exports.vQuestionnaire_GetObjLst_PureCache = vQuestionnaire_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrQuestionID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQuestionnaire_GetSubObjLst_Cache(objvQuestionnaire_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        let arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache;
        if (objvQuestionnaire_Cond.sf_FldComparisonOp == null || objvQuestionnaire_Cond.sf_FldComparisonOp == "")
            return arrvQuestionnaire_Sel;
        const dicFldComparisonOp = JSON.parse(objvQuestionnaire_Cond.sf_FldComparisonOp);
        //console.log("clsvQuestionnaireWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQuestionnaire_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvQuestionnaire_Cond), exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQuestionnaire_GetSubObjLst_Cache = vQuestionnaire_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrQuestionID:关键字列表
    * @returns 对象列表
    **/
    async function vQuestionnaire_GetObjLstByQuestionIDLstAsync(arrQuestionID) {
        const strThisFuncName = "GetObjLstByQuestionIDLstAsync";
        const strAction = "GetObjLstByQuestionIDLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionID);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetObjLstByQuestionIDLstAsync = vQuestionnaire_GetObjLstByQuestionIDLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrQuestionIDLst:关键字列表
     * @returns 对象列表
    */
    async function vQuestionnaire_GetObjLstByQuestionIDLst_Cache(arrQuestionIDLst, strCourseId) {
        const strThisFuncName = "GetObjLstByQuestionIDLst_Cache";
        try {
            const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
            const arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache.filter(x => arrQuestionIDLst.indexOf(x.questionID) > -1);
            return arrvQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrQuestionIDLst.join(","), exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vQuestionnaire_GetObjLstByQuestionIDLst_Cache = vQuestionnaire_GetObjLstByQuestionIDLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vQuestionnaire_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetTopObjLstAsync = vQuestionnaire_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQuestionnaire_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetObjLstByRangeAsync = vQuestionnaire_GetObjLstByRangeAsync;
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
    async function vQuestionnaire_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetObjLstByRange = vQuestionnaire_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vQuestionnaire_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaireObjLst_Cache.length == 0)
            return arrvQuestionnaireObjLst_Cache;
        let arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvQuestionnaire_Cond = new clsvQuestionnaireEN_js_1.clsvQuestionnaireEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQuestionnaire_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvQuestionnaireWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQuestionnaire_Sel.length == 0)
                return arrvQuestionnaire_Sel;
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
                arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.sort(vQuestionnaire_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.sort(objPagerPara.sortFun);
            }
            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.slice(intStart, intEnd);
            return arrvQuestionnaire_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQuestionnaire_GetObjLstByPager_Cache = vQuestionnaire_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQuestionnaire_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetObjLstByPagerAsync = vQuestionnaire_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrQuestionID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQuestionnaire_IsExistRecord_Cache(objvQuestionnaire_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaireObjLst_Cache == null)
            return false;
        let arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache;
        if (objvQuestionnaire_Cond.sf_FldComparisonOp == null || objvQuestionnaire_Cond.sf_FldComparisonOp == "")
            return arrvQuestionnaire_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvQuestionnaire_Cond.sf_FldComparisonOp);
        //console.log("clsvQuestionnaireWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQuestionnaire_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQuestionnaire_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvQuestionnaire_Cond), exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vQuestionnaire_IsExistRecord_Cache = vQuestionnaire_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vQuestionnaire_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_IsExistRecordAsync = vQuestionnaire_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strQuestionID:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vQuestionnaire_IsExist(strQuestionID, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_IsExist = vQuestionnaire_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_IsExist_Cache(strQuestionID, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaireObjLst_Cache == null)
            return false;
        try {
            const arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache.filter(x => x.questionID == strQuestionID);
            if (arrvQuestionnaire_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strQuestionID, exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vQuestionnaire_IsExist_Cache = vQuestionnaire_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strQuestionID:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vQuestionnaire_IsExistAsync(strQuestionID) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_IsExistAsync = vQuestionnaire_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vQuestionnaire_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_GetRecCountByCondAsync = vQuestionnaire_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvQuestionnaire_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vQuestionnaire_GetRecCountByCond_Cache(objvQuestionnaire_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvQuestionnaireObjLst_Cache = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaireObjLst_Cache == null)
            return 0;
        let arrvQuestionnaire_Sel = arrvQuestionnaireObjLst_Cache;
        if (objvQuestionnaire_Cond.sf_FldComparisonOp == null || objvQuestionnaire_Cond.sf_FldComparisonOp == "")
            return arrvQuestionnaire_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvQuestionnaire_Cond.sf_FldComparisonOp);
        //console.log("clsvQuestionnaireWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQuestionnaire_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sel = arrvQuestionnaire_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQuestionnaire_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvQuestionnaire_Cond), exports.vQuestionnaire_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vQuestionnaire_GetRecCountByCond_Cache = vQuestionnaire_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vQuestionnaire_GetWebApiUrl(strController, strAction) {
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
    exports.vQuestionnaire_GetWebApiUrl = vQuestionnaire_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vQuestionnaire_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN._CurrTabName, strCourseId);
            switch (clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_1.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.vQuestionnaire_ReFreshThisCache = vQuestionnaire_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vQuestionnaire__Cache(strDivName, strDdlName, strCourseId) {
        const strThisFuncName = "_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvQuestionnaireWApi.)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvQuestionnaireWApi.)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vQuestionnaire_GetObjLst_Cache(strCourseId);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName, "v题目");
    }
    exports.vQuestionnaire__Cache = vQuestionnaire__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQuestionnaire_GetJSONStrByObj(pobjvQuestionnaireEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvQuestionnaireEN);
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
    exports.vQuestionnaire_GetJSONStrByObj = vQuestionnaire_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vQuestionnaire_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvQuestionnaireObjLst = new Array();
        if (strJSON === "") {
            return arrvQuestionnaireObjLst;
        }
        try {
            arrvQuestionnaireObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvQuestionnaireObjLst;
        }
        return arrvQuestionnaireObjLst;
    }
    exports.vQuestionnaire_GetObjLstByJSONStr = vQuestionnaire_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvQuestionnaireObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vQuestionnaire_GetObjLstByJSONObjLst(arrvQuestionnaireObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvQuestionnaireObjLst = new Array();
        for (const objInFor of arrvQuestionnaireObjLstS) {
            const obj1 = vQuestionnaire_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvQuestionnaireObjLst.push(obj1);
        }
        return arrvQuestionnaireObjLst;
    }
    exports.vQuestionnaire_GetObjLstByJSONObjLst = vQuestionnaire_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQuestionnaire_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvQuestionnaireEN = new clsvQuestionnaireEN_js_1.clsvQuestionnaireEN();
        if (strJSON === "") {
            return pobjvQuestionnaireEN;
        }
        try {
            pobjvQuestionnaireEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvQuestionnaireEN;
        }
        return pobjvQuestionnaireEN;
    }
    exports.vQuestionnaire_GetObjByJSONStr = vQuestionnaire_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vQuestionnaire_GetCombineCondition(objvQuestionnaire_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID) == true) {
            const strComparisonOp_QuestionID = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionID, objvQuestionnaire_Cond.questionID, strComparisonOp_QuestionID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionIndex) == true) {
            const strComparisonOp_QuestionIndex = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionIndex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionIndex, objvQuestionnaire_Cond.questionIndex, strComparisonOp_QuestionIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName) == true) {
            const strComparisonOp_QuestionName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName, objvQuestionnaire_Cond.questionName, strComparisonOp_QuestionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionContent) == true) {
            const strComparisonOp_QuestionContent = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionContent, objvQuestionnaire_Cond.questionContent, strComparisonOp_QuestionContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionMemo) == true) {
            const strComparisonOp_QuestionMemo = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionMemo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionMemo, objvQuestionnaire_Cond.questionMemo, strComparisonOp_QuestionMemo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionNo) == true) {
            const strComparisonOp_QuestionNo = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionNo, objvQuestionnaire_Cond.questionNo, strComparisonOp_QuestionNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentQuestionId) == true) {
            const strComparisonOp_ParentQuestionId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentQuestionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentQuestionId, objvQuestionnaire_Cond.parentQuestionId, strComparisonOp_ParentQuestionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamAnswer) == true) {
            const strComparisonOp_ExamAnswer = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamAnswer];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamAnswer, objvQuestionnaire_Cond.examAnswer, strComparisonOp_ExamAnswer);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId, objvQuestionnaire_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseCode, objvQuestionnaire_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseName, objvQuestionnaire_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LevelNo) == true) {
            const strComparisonOp_LevelNo = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LevelNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LevelNo, objvQuestionnaire_Cond.levelNo, strComparisonOp_LevelNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterId, objvQuestionnaire_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterName) == true) {
            const strComparisonOp_CourseChapterName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterName, objvQuestionnaire_Cond.courseChapterName, strComparisonOp_CourseChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterId) == true) {
            const strComparisonOp_ChapterId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterId, objvQuestionnaire_Cond.chapterId, strComparisonOp_ChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionId, objvQuestionnaire_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName) == true) {
            const strComparisonOp_ChapterName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName, objvQuestionnaire_Cond.chapterName, strComparisonOp_ChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName, objvQuestionnaire_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName_Sim) == true) {
            const strComparisonOp_ChapterName_Sim = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterName_Sim, objvQuestionnaire_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName_Sim) == true) {
            const strComparisonOp_SectionName_Sim = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionName_Sim, objvQuestionnaire_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeID) == true) {
            const strComparisonOp_ParentNodeID = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeID, objvQuestionnaire_Cond.parentNodeID, strComparisonOp_ParentNodeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterReferred) == true) {
            const strComparisonOp_CourseChapterReferred = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterReferred];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseChapterReferred, objvQuestionnaire_Cond.courseChapterReferred, strComparisonOp_CourseChapterReferred);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeName) == true) {
            const strComparisonOp_ParentNodeName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeName, objvQuestionnaire_Cond.parentNodeName, strComparisonOp_ParentNodeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeReferred) == true) {
            const strComparisonOp_ParentNodeReferred = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeReferred];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ParentNodeReferred, objvQuestionnaire_Cond.parentNodeReferred, strComparisonOp_ParentNodeReferred);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId) == true) {
            const strComparisonOp_QuestionTypeId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId, objvQuestionnaire_Cond.questionTypeId, strComparisonOp_QuestionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName) == true) {
            const strComparisonOp_QuestionTypeName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName, objvQuestionnaire_Cond.questionTypeName, strComparisonOp_QuestionTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId4Course) == true) {
            const strComparisonOp_QuestionTypeId4Course = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId4Course];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeId4Course, objvQuestionnaire_Cond.questionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName4Course) == true) {
            const strComparisonOp_QuestionTypeName4Course = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName4Course];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionTypeName4Course, objvQuestionnaire_Cond.questionTypeName4Course, strComparisonOp_QuestionTypeName4Course);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeId, objvQuestionnaire_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeName) == true) {
            const strComparisonOp_AnswerTypeName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerTypeName, objvQuestionnaire_Cond.answerTypeName, strComparisonOp_AnswerTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_GridTitle) == true) {
            const strComparisonOp_GridTitle = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_GridTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_GridTitle, objvQuestionnaire_Cond.gridTitle, strComparisonOp_GridTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeId) == true) {
            const strComparisonOp_AnswerModeId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeId, objvQuestionnaire_Cond.answerModeId, strComparisonOp_AnswerModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeName) == true) {
            const strComparisonOp_AnswerModeName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerModeName, objvQuestionnaire_Cond.answerModeName, strComparisonOp_AnswerModeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionScore) == true) {
            const strComparisonOp_QuestionScore = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionScore, objvQuestionnaire_Cond.questionScore, strComparisonOp_QuestionScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultValue) == true) {
            const strComparisonOp_DefaultValue = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultValue];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultValue, objvQuestionnaire_Cond.defaultValue, strComparisonOp_DefaultValue);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultSelectItem) == true) {
            const strComparisonOp_DefaultSelectItem = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultSelectItem];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DefaultSelectItem, objvQuestionnaire_Cond.defaultSelectItem, strComparisonOp_DefaultSelectItem);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsShow) == true) {
            if (objvQuestionnaire_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsShow);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCast) == true) {
            if (objvQuestionnaire_Cond.isCast == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCast);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCast);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LikeCount, objvQuestionnaire_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerAttLimitSize) == true) {
            const strComparisonOp_AnswerAttLimitSize = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerAttLimitSize];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_AnswerAttLimitSize, objvQuestionnaire_Cond.answerAttLimitSize, strComparisonOp_AnswerAttLimitSize);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LimitedResourceType) == true) {
            const strComparisonOp_LimitedResourceType = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LimitedResourceType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_LimitedResourceType, objvQuestionnaire_Cond.limitedResourceType, strComparisonOp_LimitedResourceType);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsEffective) == true) {
            if (objvQuestionnaire_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCanInPaper) == true) {
            if (objvQuestionnaire_Cond.isCanInPaper == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCanInPaper);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsCanInPaper);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeId) == true) {
            const strComparisonOp_ExamGradeId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeId, objvQuestionnaire_Cond.examGradeId, strComparisonOp_ExamGradeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeName) == true) {
            const strComparisonOp_ExamGradeName = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ExamGradeName, objvQuestionnaire_Cond.examGradeName, strComparisonOp_ExamGradeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_TextDirectId) == true) {
            const strComparisonOp_TextDirectId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_TextDirectId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_TextDirectId, objvQuestionnaire_Cond.textDirectId, strComparisonOp_TextDirectId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdDate, objvQuestionnaire_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_UpdUser, objvQuestionnaire_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_Memo, objvQuestionnaire_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FirstIndent) == true) {
            if (objvQuestionnaire_Cond.firstIndent == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FirstIndent);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FirstIndent);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab) == true) {
            const strComparisonOp_CodeTab = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab, objvQuestionnaire_Cond.codeTab, strComparisonOp_CodeTab);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Code) == true) {
            const strComparisonOp_CodeTab_Code = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Code];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Code, objvQuestionnaire_Cond.codeTab_Code, strComparisonOp_CodeTab_Code);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Condition) == true) {
            const strComparisonOp_CodeTab_Condition = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Condition];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Condition, objvQuestionnaire_Cond.codeTab_Condition, strComparisonOp_CodeTab_Condition);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Name) == true) {
            const strComparisonOp_CodeTab_Name = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Name];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CodeTab_Name, objvQuestionnaire_Cond.codeTab_Name, strComparisonOp_CodeTab_Name);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId_Chapter) == true) {
            const strComparisonOp_CourseId_Chapter = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId_Chapter];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CourseId_Chapter, objvQuestionnaire_Cond.courseId_Chapter, strComparisonOp_CourseId_Chapter);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_OptionNum) == true) {
            const strComparisonOp_OptionNum = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_OptionNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_OptionNum, objvQuestionnaire_Cond.optionNum, strComparisonOp_OptionNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterOrderNum) == true) {
            const strComparisonOp_ChapterOrderNum = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterOrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_ChapterOrderNum, objvQuestionnaire_Cond.chapterOrderNum, strComparisonOp_ChapterOrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName_Add) == true) {
            const strComparisonOp_QuestionName_Add = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName_Add];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionName_Add, objvQuestionnaire_Cond.questionName_Add, strComparisonOp_QuestionName_Add);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DifficultyLevelId) == true) {
            const strComparisonOp_DifficultyLevelId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DifficultyLevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_DifficultyLevelId, objvQuestionnaire_Cond.difficultyLevelId, strComparisonOp_DifficultyLevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextHeight) == true) {
            const strComparisonOp_FillInTextHeight = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextHeight];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextHeight, objvQuestionnaire_Cond.fillInTextHeight, strComparisonOp_FillInTextHeight);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextWidth) == true) {
            const strComparisonOp_FillInTextWidth = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextWidth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_FillInTextWidth, objvQuestionnaire_Cond.fillInTextWidth, strComparisonOp_FillInTextWidth);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsHaveAdditionalMemo) == true) {
            if (objvQuestionnaire_Cond.isHaveAdditionalMemo == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsHaveAdditionalMemo);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsHaveAdditionalMemo);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsJs) == true) {
            if (objvQuestionnaire_Cond.isJs == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsJs);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsJs);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsMulti4FillInText) == true) {
            if (objvQuestionnaire_Cond.isMulti4FillInText == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsMulti4FillInText);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_IsMulti4FillInText);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_KnowledgeGraphId) == true) {
            const strComparisonOp_KnowledgeGraphId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_KnowledgeGraphId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_KnowledgeGraphId, objvQuestionnaire_Cond.knowledgeGraphId, strComparisonOp_KnowledgeGraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_MemoTextWidth) == true) {
            const strComparisonOp_MemoTextWidth = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_MemoTextWidth];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_MemoTextWidth, objvQuestionnaire_Cond.memoTextWidth, strComparisonOp_MemoTextWidth);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionCode) == true) {
            const strComparisonOp_QuestionCode = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_QuestionCode, objvQuestionnaire_Cond.questionCode, strComparisonOp_QuestionCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionTypeId) == true) {
            const strComparisonOp_SectionTypeId = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_SectionTypeId, objvQuestionnaire_Cond.sectionTypeId, strComparisonOp_SectionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CheckBoxLimitCount) == true) {
            const strComparisonOp_CheckBoxLimitCount = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CheckBoxLimitCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_CheckBoxLimitCount, objvQuestionnaire_Cond.checkBoxLimitCount, strComparisonOp_CheckBoxLimitCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Cond.dicFldComparisonOp, clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_RelaEvent) == true) {
            const strComparisonOp_RelaEvent = objvQuestionnaire_Cond.dicFldComparisonOp[clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_RelaEvent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaireEN_js_1.clsvQuestionnaireEN.con_RelaEvent, objvQuestionnaire_Cond.relaEvent, strComparisonOp_RelaEvent);
        }
        return strWhereCond;
    }
    exports.vQuestionnaire_GetCombineCondition = vQuestionnaire_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvQuestionnaireENS:源对象
     * @param objvQuestionnaireENT:目标对象
    */
    function vQuestionnaire_CopyObjTo(objvQuestionnaireENS, objvQuestionnaireENT) {
        objvQuestionnaireENT.questionID = objvQuestionnaireENS.questionID; //题目ID
        objvQuestionnaireENT.questionIndex = objvQuestionnaireENS.questionIndex; //题目序号
        objvQuestionnaireENT.questionName = objvQuestionnaireENS.questionName; //题目名称
        objvQuestionnaireENT.questionContent = objvQuestionnaireENS.questionContent; //题目内容
        objvQuestionnaireENT.questionMemo = objvQuestionnaireENS.questionMemo; //题目说明
        objvQuestionnaireENT.questionNo = objvQuestionnaireENS.questionNo; //题目编号
        objvQuestionnaireENT.parentQuestionId = objvQuestionnaireENS.parentQuestionId; //父题目Id
        objvQuestionnaireENT.examAnswer = objvQuestionnaireENS.examAnswer; //题目答案
        objvQuestionnaireENT.courseId = objvQuestionnaireENS.courseId; //课程Id
        objvQuestionnaireENT.courseCode = objvQuestionnaireENS.courseCode; //课程代码
        objvQuestionnaireENT.courseName = objvQuestionnaireENS.courseName; //课程名称
        objvQuestionnaireENT.levelNo = objvQuestionnaireENS.levelNo; //学习关号2
        objvQuestionnaireENT.courseChapterId = objvQuestionnaireENS.courseChapterId; //课程章节ID
        objvQuestionnaireENT.courseChapterName = objvQuestionnaireENS.courseChapterName; //课程章节名称
        objvQuestionnaireENT.chapterId = objvQuestionnaireENS.chapterId; //章Id
        objvQuestionnaireENT.sectionId = objvQuestionnaireENS.sectionId; //节Id
        objvQuestionnaireENT.chapterName = objvQuestionnaireENS.chapterName; //章名
        objvQuestionnaireENT.sectionName = objvQuestionnaireENS.sectionName; //节名
        objvQuestionnaireENT.chapterName_Sim = objvQuestionnaireENS.chapterName_Sim; //章名简称
        objvQuestionnaireENT.sectionName_Sim = objvQuestionnaireENS.sectionName_Sim; //节名简称
        objvQuestionnaireENT.parentNodeID = objvQuestionnaireENS.parentNodeID; //父节点编号
        objvQuestionnaireENT.courseChapterReferred = objvQuestionnaireENS.courseChapterReferred; //节简称
        objvQuestionnaireENT.parentNodeName = objvQuestionnaireENS.parentNodeName; //父节点名称
        objvQuestionnaireENT.parentNodeReferred = objvQuestionnaireENS.parentNodeReferred; //章简称
        objvQuestionnaireENT.questionTypeId = objvQuestionnaireENS.questionTypeId; //题目类型Id
        objvQuestionnaireENT.questionTypeName = objvQuestionnaireENS.questionTypeName; //题目类型名
        objvQuestionnaireENT.questionTypeId4Course = objvQuestionnaireENS.questionTypeId4Course; //题目类型Id4课程
        objvQuestionnaireENT.questionTypeName4Course = objvQuestionnaireENS.questionTypeName4Course; //题目类型名4课程
        objvQuestionnaireENT.answerTypeId = objvQuestionnaireENS.answerTypeId; //答案类型ID
        objvQuestionnaireENT.answerTypeName = objvQuestionnaireENS.answerTypeName; //答案类型名
        objvQuestionnaireENT.gridTitle = objvQuestionnaireENS.gridTitle; //表格标题
        objvQuestionnaireENT.answerModeId = objvQuestionnaireENS.answerModeId; //答案模式Id
        objvQuestionnaireENT.answerModeName = objvQuestionnaireENS.answerModeName; //答案模式名称
        objvQuestionnaireENT.questionScore = objvQuestionnaireENS.questionScore; //题目得分
        objvQuestionnaireENT.defaultValue = objvQuestionnaireENS.defaultValue; //缺省值
        objvQuestionnaireENT.defaultSelectItem = objvQuestionnaireENS.defaultSelectItem; //默认选项
        objvQuestionnaireENT.isShow = objvQuestionnaireENS.isShow; //是否启用
        objvQuestionnaireENT.isCast = objvQuestionnaireENS.isCast; //是否播放
        objvQuestionnaireENT.likeCount = objvQuestionnaireENS.likeCount; //资源喜欢数量
        objvQuestionnaireENT.answerAttLimitSize = objvQuestionnaireENS.answerAttLimitSize; //回答附件限制大小
        objvQuestionnaireENT.limitedResourceType = objvQuestionnaireENS.limitedResourceType; //限制资源类型
        objvQuestionnaireENT.isEffective = objvQuestionnaireENS.isEffective; //是否有效
        objvQuestionnaireENT.isCanInPaper = objvQuestionnaireENS.isCanInPaper; //是否可在Paper
        objvQuestionnaireENT.examGradeId = objvQuestionnaireENS.examGradeId; //题库等级ID
        objvQuestionnaireENT.examGradeName = objvQuestionnaireENS.examGradeName; //题库等级名
        objvQuestionnaireENT.textDirectId = objvQuestionnaireENS.textDirectId; //文本方向ID
        objvQuestionnaireENT.updDate = objvQuestionnaireENS.updDate; //修改日期
        objvQuestionnaireENT.updUser = objvQuestionnaireENS.updUser; //修改人
        objvQuestionnaireENT.memo = objvQuestionnaireENS.memo; //备注
        objvQuestionnaireENT.firstIndent = objvQuestionnaireENS.firstIndent; //首行缩进
        objvQuestionnaireENT.codeTab = objvQuestionnaireENS.codeTab; //代码表
        objvQuestionnaireENT.codeTab_Code = objvQuestionnaireENS.codeTab_Code; //CodeTab_Code
        objvQuestionnaireENT.codeTab_Condition = objvQuestionnaireENS.codeTab_Condition; //代码表_条件
        objvQuestionnaireENT.codeTab_Name = objvQuestionnaireENS.codeTab_Name; //CodeTab_Name
        objvQuestionnaireENT.courseId_Chapter = objvQuestionnaireENS.courseId_Chapter; //CourseId_Chapter
        objvQuestionnaireENT.optionNum = objvQuestionnaireENS.optionNum; //选项数
        objvQuestionnaireENT.chapterOrderNum = objvQuestionnaireENS.chapterOrderNum; //章排序号
        objvQuestionnaireENT.questionName_Add = objvQuestionnaireENS.questionName_Add; //题目补充
        objvQuestionnaireENT.difficultyLevelId = objvQuestionnaireENS.difficultyLevelId; //难度等级Id
        objvQuestionnaireENT.fillInTextHeight = objvQuestionnaireENS.fillInTextHeight; //填空框高度
        objvQuestionnaireENT.fillInTextWidth = objvQuestionnaireENS.fillInTextWidth; //填空框宽度
        objvQuestionnaireENT.isHaveAdditionalMemo = objvQuestionnaireENS.isHaveAdditionalMemo; //是否有附加说明
        objvQuestionnaireENT.isJs = objvQuestionnaireENS.isJs; //是否是JS
        objvQuestionnaireENT.isMulti4FillInText = objvQuestionnaireENS.isMulti4FillInText; //是否填空框多行
        objvQuestionnaireENT.knowledgeGraphId = objvQuestionnaireENS.knowledgeGraphId; //知识点图Id
        objvQuestionnaireENT.memoTextWidth = objvQuestionnaireENS.memoTextWidth; //备注框宽度
        objvQuestionnaireENT.questionCode = objvQuestionnaireENS.questionCode; //html代码
        objvQuestionnaireENT.sectionTypeId = objvQuestionnaireENS.sectionTypeId; //节点类型Id
        objvQuestionnaireENT.checkBoxLimitCount = objvQuestionnaireENS.checkBoxLimitCount; //复选框限制数
        objvQuestionnaireENT.relaEvent = objvQuestionnaireENS.relaEvent; //相关事件
    }
    exports.vQuestionnaire_CopyObjTo = vQuestionnaire_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvQuestionnaireENS:源对象
     * @param objvQuestionnaireENT:目标对象
    */
    function vQuestionnaire_GetObjFromJsonObj(objvQuestionnaireENS) {
        const objvQuestionnaireENT = new clsvQuestionnaireEN_js_1.clsvQuestionnaireEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQuestionnaireENT, objvQuestionnaireENS);
        return objvQuestionnaireENT;
    }
    exports.vQuestionnaire_GetObjFromJsonObj = vQuestionnaire_GetObjFromJsonObj;
});
