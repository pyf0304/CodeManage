/**
* 类名:clsvQuestionnaire_SimWApi
* 表名:vQuestionnaire_Sim(01120949)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 18:31:53
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../PubFun/CacheHelper.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo_Share/clsvQuestionnaire_SimEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vQuestionnaire_Sim_GetObjFromJsonObj = exports.vQuestionnaire_Sim_CopyObjTo = exports.vQuestionnaire_Sim_GetCombineCondition = exports.vQuestionnaire_Sim_GetObjByJSONStr = exports.vQuestionnaire_Sim_GetObjLstByJSONObjLst = exports.vQuestionnaire_Sim_GetObjLstByJSONStr = exports.vQuestionnaire_Sim_GetJSONStrByObj = exports.vQuestionnaire_Sim_ReFreshThisCache = exports.vQuestionnaire_Sim_GetWebApiUrl = exports.vQuestionnaire_Sim_GetRecCountByCond_Cache = exports.vQuestionnaire_Sim_GetRecCountByCondAsync = exports.vQuestionnaire_Sim_IsExistAsync = exports.vQuestionnaire_Sim_IsExist_Cache = exports.vQuestionnaire_Sim_IsExist = exports.vQuestionnaire_Sim_IsExistRecordAsync = exports.vQuestionnaire_Sim_IsExistRecord_Cache = exports.vQuestionnaire_Sim_GetObjLstByPagerAsync = exports.vQuestionnaire_Sim_GetObjLstByPager_Cache = exports.vQuestionnaire_Sim_GetObjLstByRange = exports.vQuestionnaire_Sim_GetObjLstByRangeAsync = exports.vQuestionnaire_Sim_GetTopObjLstAsync = exports.vQuestionnaire_Sim_GetObjLstByQuestionIDLst_Cache = exports.vQuestionnaire_Sim_GetObjLstByQuestionIDLstAsync = exports.vQuestionnaire_Sim_GetSubObjLst_Cache = exports.vQuestionnaire_Sim_GetObjLst_PureCache = exports.vQuestionnaire_Sim_GetObjLst_Cache = exports.vQuestionnaire_Sim_GetObjLst_sessionStorage_PureCache = exports.vQuestionnaire_Sim_GetObjLst_sessionStorage = exports.vQuestionnaire_Sim_GetObjLstAsync = exports.vQuestionnaire_Sim_GetObjLst_localStorage_PureCache = exports.vQuestionnaire_Sim_GetObjLst_localStorage = exports.vQuestionnaire_Sim_GetObjLst_ClientCache = exports.vQuestionnaire_Sim_GetFirstObjAsync = exports.vQuestionnaire_Sim_GetFirstID = exports.vQuestionnaire_Sim_GetFirstIDAsync = exports.vQuestionnaire_Sim_funcKey = exports.vQuestionnaire_Sim_FilterFunByKey = exports.vQuestionnaire_Sim_SortFunByKey = exports.vQuestionnaire_Sim_SortFun_Defa_2Fld = exports.vQuestionnaire_Sim_SortFun_Defa = exports.vQuestionnaire_Sim_func = exports.vQuestionnaire_Sim_GetNameByQuestionID_Cache = exports.vQuestionnaire_Sim_GetObjByQuestionID_localStorage = exports.vQuestionnaire_Sim_GetObjByQuestionID_Cache = exports.vQuestionnaire_Sim_GetObjByQuestionIDAsync = exports.vQuestionnaire_Sim_ConstructorName = exports.vQuestionnaire_Sim_Controller = void 0;
    /**
     * vQuestionnaire_Sim(vQuestionnaire_Sim)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const CacheHelper_js_3 = require("../../PubFun/CacheHelper.js");
    const clsvQuestionnaire_SimEN_js_1 = require("../../L0_Entity/BaseInfo_Share/clsvQuestionnaire_SimEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vQuestionnaire_Sim_Controller = "vQuestionnaire_SimApi";
    exports.vQuestionnaire_Sim_ConstructorName = "vQuestionnaire_Sim";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strQuestionID:关键字
    * @returns 对象
    **/
    async function vQuestionnaire_Sim_GetObjByQuestionIDAsync(strQuestionID) {
        const strThisFuncName = "GetObjByQuestionIDAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaire_SimWApi.GetObjByQuestionIDAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaire_SimWApi.GetObjByQuestionIDAsync)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByQuestionID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const objvQuestionnaire_Sim = vQuestionnaire_Sim_GetObjFromJsonObj(returnObj);
                return objvQuestionnaire_Sim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetObjByQuestionIDAsync = vQuestionnaire_Sim_GetObjByQuestionIDAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_Sim_GetObjByQuestionID_Cache(strQuestionID, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByQuestionID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaire_SimWApi.GetObjByQuestionID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaire_SimWApi.GetObjByQuestionID_Cache)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        try {
            const arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache.filter(x => x.questionID == strQuestionID);
            let objvQuestionnaire_Sim;
            if (arrvQuestionnaire_Sim_Sel.length > 0) {
                objvQuestionnaire_Sim = arrvQuestionnaire_Sim_Sel[0];
                return objvQuestionnaire_Sim;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvQuestionnaire_Sim_Const = await vQuestionnaire_Sim_GetObjByQuestionIDAsync(strQuestionID);
                    if (objvQuestionnaire_Sim_Const != null) {
                        vQuestionnaire_Sim_ReFreshThisCache(strCourseId);
                        return objvQuestionnaire_Sim_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionID, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vQuestionnaire_Sim_GetObjByQuestionID_Cache = vQuestionnaire_Sim_GetObjByQuestionID_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_Sim_GetObjByQuestionID_localStorage(strQuestionID) {
        const strThisFuncName = "GetObjByQuestionID_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaire_SimWApi.GetObjByQuestionID_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaire_SimWApi.GetObjByQuestionID_localStorage)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strQuestionID);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvQuestionnaire_Sim_Cache = JSON.parse(strTempObj);
            return objvQuestionnaire_Sim_Cache;
        }
        try {
            const objvQuestionnaire_Sim = await vQuestionnaire_Sim_GetObjByQuestionIDAsync(strQuestionID);
            if (objvQuestionnaire_Sim != null) {
                localStorage.setItem(strKey, JSON.stringify(objvQuestionnaire_Sim));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvQuestionnaire_Sim;
            }
            return objvQuestionnaire_Sim;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strQuestionID, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vQuestionnaire_Sim_GetObjByQuestionID_localStorage = vQuestionnaire_Sim_GetObjByQuestionID_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_Sim_GetNameByQuestionID_Cache(strQuestionID, strCourseId) {
        const strThisFuncName = "GetNameByQuestionID_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strQuestionID) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strQuestionID]不能为空！(In clsvQuestionnaire_SimWApi.GetNameByQuestionID_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strQuestionID.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strQuestionID]的长度:[{0}]不正确！(clsvQuestionnaire_SimWApi.GetNameByQuestionID_Cache)", strQuestionID.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaire_SimObjLst_Cache == null)
            return "";
        try {
            const arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache.filter(x => x.questionID == strQuestionID);
            let objvQuestionnaire_Sim;
            if (arrvQuestionnaire_Sim_Sel.length > 0) {
                objvQuestionnaire_Sim = arrvQuestionnaire_Sim_Sel[0];
                return objvQuestionnaire_Sim.questionName;
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
    exports.vQuestionnaire_Sim_GetNameByQuestionID_Cache = vQuestionnaire_Sim_GetNameByQuestionID_Cache;
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
    async function vQuestionnaire_Sim_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvQuestionnaire_SimWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvQuestionnaire_SimWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strQuestionID = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvQuestionnaire_Sim = await vQuestionnaire_Sim_GetObjByQuestionID_Cache(strQuestionID, strCourseId_C);
        if (objvQuestionnaire_Sim == null)
            return "";
        if (objvQuestionnaire_Sim.GetFldValue(strOutFldName) == null)
            return "";
        return objvQuestionnaire_Sim.GetFldValue(strOutFldName).toString();
    }
    exports.vQuestionnaire_Sim_func = vQuestionnaire_Sim_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQuestionnaire_Sim_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.questionID.localeCompare(b.questionID);
    }
    exports.vQuestionnaire_Sim_SortFun_Defa = vQuestionnaire_Sim_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQuestionnaire_Sim_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.questionName == b.questionName)
            return a.questionIndex - b.questionIndex;
        else
            return a.questionName.localeCompare(b.questionName);
    }
    exports.vQuestionnaire_Sim_SortFun_Defa_2Fld = vQuestionnaire_Sim_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vQuestionnaire_Sim_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID:
                    return (a, b) => {
                        if (a.questionID == null)
                            return -1;
                        if (b.questionID == null)
                            return 1;
                        return a.questionID.localeCompare(b.questionID);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionName:
                    return (a, b) => {
                        if (a.questionName == null)
                            return -1;
                        if (b.questionName == null)
                            return 1;
                        return a.questionName.localeCompare(b.questionName);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionIndex:
                    return (a, b) => {
                        return a.questionIndex - b.questionIndex;
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionNo:
                    return (a, b) => {
                        if (a.questionNo == null)
                            return -1;
                        if (b.questionNo == null)
                            return 1;
                        return a.questionNo.localeCompare(b.questionNo);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseChapterId:
                    return (a, b) => {
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_ParentQuestionId:
                    return (a, b) => {
                        if (a.parentQuestionId == null)
                            return -1;
                        if (b.parentQuestionId == null)
                            return 1;
                        return a.parentQuestionId.localeCompare(b.parentQuestionId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId:
                    return (a, b) => {
                        if (a.questionTypeId == null)
                            return -1;
                        if (b.questionTypeId == null)
                            return 1;
                        return a.questionTypeId.localeCompare(b.questionTypeId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId4Course:
                    return (a, b) => {
                        return a.questionTypeId4Course.localeCompare(b.questionTypeId4Course);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (a.answerTypeId == null)
                            return -1;
                        if (b.answerTypeId == null)
                            return 1;
                        return a.answerTypeId.localeCompare(b.answerTypeId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQuestionnaire_Sim]中不存在！(in ${exports.vQuestionnaire_Sim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID:
                    return (a, b) => {
                        if (b.questionID == null)
                            return -1;
                        if (a.questionID == null)
                            return 1;
                        return b.questionID.localeCompare(a.questionID);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionName:
                    return (a, b) => {
                        if (b.questionName == null)
                            return -1;
                        if (a.questionName == null)
                            return 1;
                        return b.questionName.localeCompare(a.questionName);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionIndex:
                    return (a, b) => {
                        return b.questionIndex - a.questionIndex;
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionNo:
                    return (a, b) => {
                        if (b.questionNo == null)
                            return -1;
                        if (a.questionNo == null)
                            return 1;
                        return b.questionNo.localeCompare(a.questionNo);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseChapterId:
                    return (a, b) => {
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_ParentQuestionId:
                    return (a, b) => {
                        if (b.parentQuestionId == null)
                            return -1;
                        if (a.parentQuestionId == null)
                            return 1;
                        return b.parentQuestionId.localeCompare(a.parentQuestionId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId:
                    return (a, b) => {
                        if (b.questionTypeId == null)
                            return -1;
                        if (a.questionTypeId == null)
                            return 1;
                        return b.questionTypeId.localeCompare(a.questionTypeId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId4Course:
                    return (a, b) => {
                        return b.questionTypeId4Course.localeCompare(a.questionTypeId4Course);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_AnswerTypeId:
                    return (a, b) => {
                        if (b.answerTypeId == null)
                            return -1;
                        if (a.answerTypeId == null)
                            return 1;
                        return b.answerTypeId.localeCompare(a.answerTypeId);
                    };
                case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vQuestionnaire_Sim]中不存在！(in ${exports.vQuestionnaire_Sim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vQuestionnaire_Sim_SortFunByKey = vQuestionnaire_Sim_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vQuestionnaire_Sim_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID:
                return (obj) => {
                    return obj.questionID === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionName:
                return (obj) => {
                    return obj.questionName === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionIndex:
                return (obj) => {
                    return obj.questionIndex === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionNo:
                return (obj) => {
                    return obj.questionNo === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_ParentQuestionId:
                return (obj) => {
                    return obj.parentQuestionId === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId:
                return (obj) => {
                    return obj.questionTypeId === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId4Course:
                return (obj) => {
                    return obj.questionTypeId4Course === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_AnswerTypeId:
                return (obj) => {
                    return obj.answerTypeId === value;
                };
            case clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vQuestionnaire_Sim]中不存在！(in ${exports.vQuestionnaire_Sim_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vQuestionnaire_Sim_FilterFunByKey = vQuestionnaire_Sim_FilterFunByKey;
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
    async function vQuestionnaire_Sim_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvQuestionnaire_SimWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvQuestionnaire_SimWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvQuestionnaire_Sim = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId_C);
        if (arrvQuestionnaire_Sim == null)
            return [];
        let arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvQuestionnaire_Sim_Sel.length == 0)
            return [];
        return arrvQuestionnaire_Sim_Sel.map(x => x.questionID);
    }
    exports.vQuestionnaire_Sim_funcKey = vQuestionnaire_Sim_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vQuestionnaire_Sim_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetFirstIDAsync = vQuestionnaire_Sim_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vQuestionnaire_Sim_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetFirstID = vQuestionnaire_Sim_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vQuestionnaire_Sim_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const objvQuestionnaire_Sim = vQuestionnaire_Sim_GetObjFromJsonObj(returnObj);
                return objvQuestionnaire_Sim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetFirstObjAsync = vQuestionnaire_Sim_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvQuestionnaire_SimExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvQuestionnaire_SimObjLst_T = vQuestionnaire_Sim_GetObjLstByJSONObjLst(arrvQuestionnaire_SimExObjLst_Cache);
            return arrvQuestionnaire_SimObjLst_T;
        }
        try {
            const arrvQuestionnaire_SimExObjLst = await vQuestionnaire_Sim_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvQuestionnaire_SimExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQuestionnaire_SimExObjLst.length);
            console.log(strInfo);
            return arrvQuestionnaire_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQuestionnaire_Sim_GetObjLst_ClientCache = vQuestionnaire_Sim_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQuestionnaire_SimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQuestionnaire_SimObjLst_T = vQuestionnaire_Sim_GetObjLstByJSONObjLst(arrvQuestionnaire_SimExObjLst_Cache);
            return arrvQuestionnaire_SimObjLst_T;
        }
        try {
            const arrvQuestionnaire_SimExObjLst = await vQuestionnaire_Sim_GetObjLstAsync(strWhereCond);
            const strPrefix = (0, clsString_js_1.Format)("{0}_", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName);
            const arrCacheKeyLst = (0, CacheHelper_js_2.LocalStorage_GetKeyByPrefix)(strPrefix);
            arrCacheKeyLst.forEach(x => localStorage.removeItem(x));
            localStorage.setItem(strKey, JSON.stringify(arrvQuestionnaire_SimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQuestionnaire_SimExObjLst.length);
            console.log(strInfo);
            return arrvQuestionnaire_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQuestionnaire_Sim_GetObjLst_localStorage = vQuestionnaire_Sim_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvQuestionnaire_SimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQuestionnaire_SimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQuestionnaire_Sim_GetObjLst_localStorage_PureCache = vQuestionnaire_Sim_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetObjLstAsync = vQuestionnaire_Sim_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQuestionnaire_SimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvQuestionnaire_SimObjLst_T = vQuestionnaire_Sim_GetObjLstByJSONObjLst(arrvQuestionnaire_SimExObjLst_Cache);
            return arrvQuestionnaire_SimObjLst_T;
        }
        try {
            const arrvQuestionnaire_SimExObjLst = await vQuestionnaire_Sim_GetObjLstAsync(strWhereCond);
            const strPrefix = (0, clsString_js_1.Format)("{0}_", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName);
            const arrCacheKeyLst = (0, CacheHelper_js_3.SessionStorage_GetKeyByPrefix)(strPrefix);
            arrCacheKeyLst.forEach(x => sessionStorage.removeItem(x));
            sessionStorage.setItem(strKey, JSON.stringify(arrvQuestionnaire_SimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvQuestionnaire_SimExObjLst.length);
            console.log(strInfo);
            return arrvQuestionnaire_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vQuestionnaire_Sim_GetObjLst_sessionStorage = vQuestionnaire_Sim_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvQuestionnaire_SimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvQuestionnaire_SimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vQuestionnaire_Sim_GetObjLst_sessionStorage_PureCache = vQuestionnaire_Sim_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[CourseId]不能为空！(in clsvQuestionnaire_SimWApi.vQuestionnaire_Sim_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsvQuestionnaire_SimWApi.vQuestionnaire_Sim_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvQuestionnaire_SimObjLst_Cache;
        switch (clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrvQuestionnaire_SimObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst(arrvQuestionnaire_SimObjLst_Cache);
        return arrvQuestionnaire_SimObjLst_Cache;
    }
    exports.vQuestionnaire_Sim_GetObjLst_Cache = vQuestionnaire_Sim_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvQuestionnaire_SimObjLst_Cache;
        switch (clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrvQuestionnaire_SimObjLst_Cache = null;
                break;
            default:
                arrvQuestionnaire_SimObjLst_Cache = null;
                break;
        }
        return arrvQuestionnaire_SimObjLst_Cache;
    }
    exports.vQuestionnaire_Sim_GetObjLst_PureCache = vQuestionnaire_Sim_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrQuestionID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQuestionnaire_Sim_GetSubObjLst_Cache(objvQuestionnaire_Sim_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        let arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache;
        if (objvQuestionnaire_Sim_Cond.sf_FldComparisonOp == null || objvQuestionnaire_Sim_Cond.sf_FldComparisonOp == "")
            return arrvQuestionnaire_Sim_Sel;
        const dicFldComparisonOp = JSON.parse(objvQuestionnaire_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvQuestionnaire_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQuestionnaire_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQuestionnaire_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvQuestionnaire_Sim_Cond), exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQuestionnaire_Sim_GetSubObjLst_Cache = vQuestionnaire_Sim_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrQuestionID:关键字列表
    * @returns 对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLstByQuestionIDLstAsync(arrQuestionID) {
        const strThisFuncName = "GetObjLstByQuestionIDLstAsync";
        const strAction = "GetObjLstByQuestionIDLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrQuestionID);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetObjLstByQuestionIDLstAsync = vQuestionnaire_Sim_GetObjLstByQuestionIDLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrQuestionIDLst:关键字列表
     * @returns 对象列表
    */
    async function vQuestionnaire_Sim_GetObjLstByQuestionIDLst_Cache(arrQuestionIDLst, strCourseId) {
        const strThisFuncName = "GetObjLstByQuestionIDLst_Cache";
        try {
            const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
            const arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache.filter(x => arrQuestionIDLst.indexOf(x.questionID) > -1);
            return arrvQuestionnaire_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrQuestionIDLst.join(","), exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vQuestionnaire_Sim_GetObjLstByQuestionIDLst_Cache = vQuestionnaire_Sim_GetObjLstByQuestionIDLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vQuestionnaire_Sim_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetTopObjLstAsync = vQuestionnaire_Sim_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetObjLstByRangeAsync = vQuestionnaire_Sim_GetObjLstByRangeAsync;
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
    async function vQuestionnaire_Sim_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetObjLstByRange = vQuestionnaire_Sim_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vQuestionnaire_Sim_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaire_SimObjLst_Cache.length == 0)
            return arrvQuestionnaire_SimObjLst_Cache;
        let arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvQuestionnaire_Sim_Cond = new clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQuestionnaire_Sim_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvQuestionnaire_SimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQuestionnaire_Sim_Sel.length == 0)
                return arrvQuestionnaire_Sim_Sel;
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
                arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.sort(vQuestionnaire_Sim_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.sort(objPagerPara.sortFun);
            }
            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.slice(intStart, intEnd);
            return arrvQuestionnaire_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vQuestionnaire_Sim_GetObjLstByPager_Cache = vQuestionnaire_Sim_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vQuestionnaire_Sim_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetObjLstByPagerAsync = vQuestionnaire_Sim_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrQuestionID_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vQuestionnaire_Sim_IsExistRecord_Cache(objvQuestionnaire_Sim_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaire_SimObjLst_Cache == null)
            return false;
        let arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache;
        if (objvQuestionnaire_Sim_Cond.sf_FldComparisonOp == null || objvQuestionnaire_Sim_Cond.sf_FldComparisonOp == "")
            return arrvQuestionnaire_Sim_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvQuestionnaire_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvQuestionnaire_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQuestionnaire_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvQuestionnaire_Sim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvQuestionnaire_Sim_Cond), exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vQuestionnaire_Sim_IsExistRecord_Cache = vQuestionnaire_Sim_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vQuestionnaire_Sim_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_IsExistRecordAsync = vQuestionnaire_Sim_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strQuestionID:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vQuestionnaire_Sim_IsExist(strQuestionID, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_IsExist = vQuestionnaire_Sim_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strQuestionID:所给的关键字
     * @returns 对象
    */
    async function vQuestionnaire_Sim_IsExist_Cache(strQuestionID, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaire_SimObjLst_Cache == null)
            return false;
        try {
            const arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache.filter(x => x.questionID == strQuestionID);
            if (arrvQuestionnaire_Sim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strQuestionID, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vQuestionnaire_Sim_IsExist_Cache = vQuestionnaire_Sim_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strQuestionID:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vQuestionnaire_Sim_IsExistAsync(strQuestionID) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_IsExistAsync = vQuestionnaire_Sim_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vQuestionnaire_Sim_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vQuestionnaire_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vQuestionnaire_Sim_GetRecCountByCondAsync = vQuestionnaire_Sim_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvQuestionnaire_Sim_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vQuestionnaire_Sim_GetRecCountByCond_Cache(objvQuestionnaire_Sim_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvQuestionnaire_SimObjLst_Cache = await vQuestionnaire_Sim_GetObjLst_Cache(strCourseId);
        if (arrvQuestionnaire_SimObjLst_Cache == null)
            return 0;
        let arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_SimObjLst_Cache;
        if (objvQuestionnaire_Sim_Cond.sf_FldComparisonOp == null || objvQuestionnaire_Sim_Cond.sf_FldComparisonOp == "")
            return arrvQuestionnaire_Sim_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvQuestionnaire_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvQuestionnaire_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvQuestionnaire_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvQuestionnaire_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvQuestionnaire_Sim_Sel = arrvQuestionnaire_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvQuestionnaire_Sim_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvQuestionnaire_Sim_Cond), exports.vQuestionnaire_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vQuestionnaire_Sim_GetRecCountByCond_Cache = vQuestionnaire_Sim_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vQuestionnaire_Sim_GetWebApiUrl(strController, strAction) {
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
    exports.vQuestionnaire_Sim_GetWebApiUrl = vQuestionnaire_Sim_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vQuestionnaire_Sim_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN._CurrTabName, strCourseId);
            switch (clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.CacheModeId) {
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
    exports.vQuestionnaire_Sim_ReFreshThisCache = vQuestionnaire_Sim_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQuestionnaire_Sim_GetJSONStrByObj(pobjvQuestionnaire_SimEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvQuestionnaire_SimEN);
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
    exports.vQuestionnaire_Sim_GetJSONStrByObj = vQuestionnaire_Sim_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vQuestionnaire_Sim_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvQuestionnaire_SimObjLst = new Array();
        if (strJSON === "") {
            return arrvQuestionnaire_SimObjLst;
        }
        try {
            arrvQuestionnaire_SimObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvQuestionnaire_SimObjLst;
        }
        return arrvQuestionnaire_SimObjLst;
    }
    exports.vQuestionnaire_Sim_GetObjLstByJSONStr = vQuestionnaire_Sim_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvQuestionnaire_SimObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vQuestionnaire_Sim_GetObjLstByJSONObjLst(arrvQuestionnaire_SimObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvQuestionnaire_SimObjLst = new Array();
        for (const objInFor of arrvQuestionnaire_SimObjLstS) {
            const obj1 = vQuestionnaire_Sim_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvQuestionnaire_SimObjLst.push(obj1);
        }
        return arrvQuestionnaire_SimObjLst;
    }
    exports.vQuestionnaire_Sim_GetObjLstByJSONObjLst = vQuestionnaire_Sim_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vQuestionnaire_Sim_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvQuestionnaire_SimEN = new clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN();
        if (strJSON === "") {
            return pobjvQuestionnaire_SimEN;
        }
        try {
            pobjvQuestionnaire_SimEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvQuestionnaire_SimEN;
        }
        return pobjvQuestionnaire_SimEN;
    }
    exports.vQuestionnaire_Sim_GetObjByJSONStr = vQuestionnaire_Sim_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vQuestionnaire_Sim_GetCombineCondition(objvQuestionnaire_Sim_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID) == true) {
            const strComparisonOp_QuestionID = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionID, objvQuestionnaire_Sim_Cond.questionID, strComparisonOp_QuestionID);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionName) == true) {
            const strComparisonOp_QuestionName = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionName, objvQuestionnaire_Sim_Cond.questionName, strComparisonOp_QuestionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionIndex) == true) {
            const strComparisonOp_QuestionIndex = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionIndex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionIndex, objvQuestionnaire_Sim_Cond.questionIndex, strComparisonOp_QuestionIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionNo) == true) {
            const strComparisonOp_QuestionNo = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionNo, objvQuestionnaire_Sim_Cond.questionNo, strComparisonOp_QuestionNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseId, objvQuestionnaire_Sim_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_CourseChapterId, objvQuestionnaire_Sim_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_ParentQuestionId) == true) {
            const strComparisonOp_ParentQuestionId = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_ParentQuestionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_ParentQuestionId, objvQuestionnaire_Sim_Cond.parentQuestionId, strComparisonOp_ParentQuestionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId) == true) {
            const strComparisonOp_QuestionTypeId = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId, objvQuestionnaire_Sim_Cond.questionTypeId, strComparisonOp_QuestionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId4Course) == true) {
            const strComparisonOp_QuestionTypeId4Course = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId4Course];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_QuestionTypeId4Course, objvQuestionnaire_Sim_Cond.questionTypeId4Course, strComparisonOp_QuestionTypeId4Course);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_AnswerTypeId) == true) {
            const strComparisonOp_AnswerTypeId = objvQuestionnaire_Sim_Cond.dicFldComparisonOp[clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_AnswerTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_AnswerTypeId, objvQuestionnaire_Sim_Cond.answerTypeId, strComparisonOp_AnswerTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvQuestionnaire_Sim_Cond.dicFldComparisonOp, clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_IsShow) == true) {
            if (objvQuestionnaire_Sim_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN.con_IsShow);
            }
        }
        return strWhereCond;
    }
    exports.vQuestionnaire_Sim_GetCombineCondition = vQuestionnaire_Sim_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvQuestionnaire_SimENS:源对象
     * @param objvQuestionnaire_SimENT:目标对象
    */
    function vQuestionnaire_Sim_CopyObjTo(objvQuestionnaire_SimENS, objvQuestionnaire_SimENT) {
        objvQuestionnaire_SimENT.questionID = objvQuestionnaire_SimENS.questionID; //题目ID
        objvQuestionnaire_SimENT.questionName = objvQuestionnaire_SimENS.questionName; //题目名称
        objvQuestionnaire_SimENT.questionIndex = objvQuestionnaire_SimENS.questionIndex; //题目序号
        objvQuestionnaire_SimENT.questionNo = objvQuestionnaire_SimENS.questionNo; //题目编号
        objvQuestionnaire_SimENT.courseId = objvQuestionnaire_SimENS.courseId; //课程Id
        objvQuestionnaire_SimENT.courseChapterId = objvQuestionnaire_SimENS.courseChapterId; //课程章节ID
        objvQuestionnaire_SimENT.parentQuestionId = objvQuestionnaire_SimENS.parentQuestionId; //父题目Id
        objvQuestionnaire_SimENT.questionTypeId = objvQuestionnaire_SimENS.questionTypeId; //题目类型Id
        objvQuestionnaire_SimENT.questionTypeId4Course = objvQuestionnaire_SimENS.questionTypeId4Course; //题目类型Id4课程
        objvQuestionnaire_SimENT.answerTypeId = objvQuestionnaire_SimENS.answerTypeId; //答案类型ID
        objvQuestionnaire_SimENT.isShow = objvQuestionnaire_SimENS.isShow; //是否启用
    }
    exports.vQuestionnaire_Sim_CopyObjTo = vQuestionnaire_Sim_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvQuestionnaire_SimENS:源对象
     * @param objvQuestionnaire_SimENT:目标对象
    */
    function vQuestionnaire_Sim_GetObjFromJsonObj(objvQuestionnaire_SimENS) {
        const objvQuestionnaire_SimENT = new clsvQuestionnaire_SimEN_js_1.clsvQuestionnaire_SimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvQuestionnaire_SimENT, objvQuestionnaire_SimENS);
        return objvQuestionnaire_SimENT;
    }
    exports.vQuestionnaire_Sim_GetObjFromJsonObj = vQuestionnaire_Sim_GetObjFromJsonObj;
});
