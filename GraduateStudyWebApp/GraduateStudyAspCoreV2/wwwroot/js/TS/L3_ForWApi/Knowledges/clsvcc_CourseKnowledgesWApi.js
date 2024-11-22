/**
* 类名:clsvcc_CourseKnowledgesWApi
* 表名:vcc_CourseKnowledges(01120141)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:48:05
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:知识点相关(Knowledges)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges/clsvcc_CourseKnowledgesEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CourseKnowledges_GetObjFromJsonObj = exports.vcc_CourseKnowledges_CopyObjTo = exports.vcc_CourseKnowledges_GetCombineCondition = exports.vcc_CourseKnowledges_GetObjByJSONStr = exports.vcc_CourseKnowledges_GetObjLstByJSONObjLst = exports.vcc_CourseKnowledges_GetObjLstByJSONStr = exports.vcc_CourseKnowledges_GetJSONStrByObj = exports.vcc_CourseKnowledges_ReFreshThisCache = exports.vcc_CourseKnowledges_GetWebApiUrl = exports.vcc_CourseKnowledges_GetRecCountByCond_Cache = exports.vcc_CourseKnowledges_GetRecCountByCondAsync = exports.vcc_CourseKnowledges_IsExistAsync = exports.vcc_CourseKnowledges_IsExist_Cache = exports.vcc_CourseKnowledges_IsExist = exports.vcc_CourseKnowledges_IsExistRecordAsync = exports.vcc_CourseKnowledges_IsExistRecord_Cache = exports.vcc_CourseKnowledges_GetObjLstByPagerAsync = exports.vcc_CourseKnowledges_GetObjLstByPager_Cache = exports.vcc_CourseKnowledges_GetObjLstByRange = exports.vcc_CourseKnowledges_GetObjLstByRangeAsync = exports.vcc_CourseKnowledges_GetTopObjLstAsync = exports.vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLst_Cache = exports.vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync = exports.vcc_CourseKnowledges_GetSubObjLst_Cache = exports.vcc_CourseKnowledges_GetObjLst_PureCache = exports.vcc_CourseKnowledges_GetObjLst_Cache = exports.vcc_CourseKnowledges_GetObjLst_sessionStorage_PureCache = exports.vcc_CourseKnowledges_GetObjLst_sessionStorage = exports.vcc_CourseKnowledges_GetObjLstAsync = exports.vcc_CourseKnowledges_GetObjLst_localStorage_PureCache = exports.vcc_CourseKnowledges_GetObjLst_localStorage = exports.vcc_CourseKnowledges_GetObjLst_ClientCache = exports.vcc_CourseKnowledges_GetFirstObjAsync = exports.vcc_CourseKnowledges_GetFirstID = exports.vcc_CourseKnowledges_GetFirstIDAsync = exports.vcc_CourseKnowledges_funcKey = exports.vcc_CourseKnowledges_FilterFunByKey = exports.vcc_CourseKnowledges_SortFunByKey = exports.vcc_CourseKnowledges_SortFun_Defa_2Fld = exports.vcc_CourseKnowledges_SortFun_Defa = exports.vcc_CourseKnowledges_func = exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeId_localStorage = exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache = exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync = exports.vcc_CourseKnowledges_ConstructorName = exports.vcc_CourseKnowledges_Controller = void 0;
    /**
     * v课程知识点(vcc_CourseKnowledges)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvcc_CourseKnowledgesEN_js_1 = require("../../L0_Entity/Knowledges/clsvcc_CourseKnowledgesEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_CourseKnowledges_Controller = "vcc_CourseKnowledgesApi";
    exports.vcc_CourseKnowledges_ConstructorName = "vcc_CourseKnowledges";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseKnowledgeId:关键字
    * @returns 对象
    **/
    async function vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId) {
        const strThisFuncName = "GetObjByCourseKnowledgeIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseKnowledgeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseKnowledgeId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseKnowledgeId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseKnowledgeId": strCourseKnowledgeId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvcc_CourseKnowledges = vcc_CourseKnowledges_GetObjFromJsonObj(returnObj);
                return objvcc_CourseKnowledges;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync = vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseKnowledgeId:所给的关键字
     * @returns 对象
    */
    async function vcc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache(strCourseKnowledgeId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseKnowledgeId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseKnowledgeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseKnowledgeId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
        try {
            const arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache.filter(x => x.courseKnowledgeId == strCourseKnowledgeId);
            let objvcc_CourseKnowledges;
            if (arrvcc_CourseKnowledges_Sel.length > 0) {
                objvcc_CourseKnowledges = arrvcc_CourseKnowledges_Sel[0];
                return objvcc_CourseKnowledges;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvcc_CourseKnowledges_Const = await vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId);
                    if (objvcc_CourseKnowledges_Const != null) {
                        vcc_CourseKnowledges_ReFreshThisCache(strCourseId);
                        return objvcc_CourseKnowledges_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseKnowledgeId, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache = vcc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseKnowledgeId:所给的关键字
     * @returns 对象
    */
    async function vcc_CourseKnowledges_GetObjByCourseKnowledgeId_localStorage(strCourseKnowledgeId) {
        const strThisFuncName = "GetObjByCourseKnowledgeId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseKnowledgeId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseKnowledgeId]不能为空！(In GetObjByCourseKnowledgeId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseKnowledgeId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseKnowledgeId]的长度:[{0}]不正确！", strCourseKnowledgeId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseKnowledgeId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvcc_CourseKnowledges_Cache = JSON.parse(strTempObj);
            return objvcc_CourseKnowledges_Cache;
        }
        try {
            const objvcc_CourseKnowledges = await vcc_CourseKnowledges_GetObjByCourseKnowledgeIdAsync(strCourseKnowledgeId);
            if (objvcc_CourseKnowledges != null) {
                localStorage.setItem(strKey, JSON.stringify(objvcc_CourseKnowledges));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvcc_CourseKnowledges;
            }
            return objvcc_CourseKnowledges;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseKnowledgeId, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vcc_CourseKnowledges_GetObjByCourseKnowledgeId_localStorage = vcc_CourseKnowledges_GetObjByCourseKnowledgeId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vcc_CourseKnowledges_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseKnowledgeId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvcc_CourseKnowledges = await vcc_CourseKnowledges_GetObjByCourseKnowledgeId_Cache(strCourseKnowledgeId, strCourseId_C);
        if (objvcc_CourseKnowledges == null)
            return "";
        if (objvcc_CourseKnowledges.GetFldValue(strOutFldName) == null)
            return "";
        return objvcc_CourseKnowledges.GetFldValue(strOutFldName).toString();
    }
    exports.vcc_CourseKnowledges_func = vcc_CourseKnowledges_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseKnowledges_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
    }
    exports.vcc_CourseKnowledges_SortFun_Defa = vcc_CourseKnowledges_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseKnowledges_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.knowledgeName == b.knowledgeName)
            return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
        else
            return a.knowledgeName.localeCompare(b.knowledgeName);
    }
    exports.vcc_CourseKnowledges_SortFun_Defa_2Fld = vcc_CourseKnowledges_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseKnowledges_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    return (a, b) => {
                        return a.courseKnowledgeId.localeCompare(b.courseKnowledgeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                    return (a, b) => {
                        return a.knowledgeName.localeCompare(b.knowledgeName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                    return (a, b) => {
                        if (a.knowledgeTitle == null)
                            return -1;
                        if (b.knowledgeTitle == null)
                            return 1;
                        return a.knowledgeTitle.localeCompare(b.knowledgeTitle);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                    return (a, b) => {
                        if (a.knowledgeContent == null)
                            return -1;
                        if (b.knowledgeContent == null)
                            return 1;
                        return a.knowledgeContent.localeCompare(b.knowledgeContent);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                    return (a, b) => {
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId:
                    return (a, b) => {
                        if (a.chapterId == null)
                            return -1;
                        if (b.chapterId == null)
                            return 1;
                        return a.chapterId.localeCompare(b.chapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate:
                    return (a, b) => {
                        if (a.uploadDate == null)
                            return -1;
                        if (b.uploadDate == null)
                            return 1;
                        return a.uploadDate.localeCompare(b.uploadDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName:
                    return (a, b) => {
                        if (a.chapterName == null)
                            return -1;
                        if (b.chapterName == null)
                            return 1;
                        return a.chapterName.localeCompare(b.chapterName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast:
                    return (a, b) => {
                        if (a.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (a.chapterName_Sim == null)
                            return -1;
                        if (b.chapterName_Sim == null)
                            return 1;
                        return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (a.sectionName_Sim == null)
                            return -1;
                        if (b.sectionName_Sim == null)
                            return 1;
                        return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum:
                    return (a, b) => {
                        return a.questionNum - b.questionNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    return (a, b) => {
                        if (a.knowledgeTypeId == null)
                            return -1;
                        if (b.knowledgeTypeId == null)
                            return 1;
                        return a.knowledgeTypeId.localeCompare(b.knowledgeTypeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                    return (a, b) => {
                        if (a.knowledgeTypeName == null)
                            return -1;
                        if (b.knowledgeTypeName == null)
                            return 1;
                        return a.knowledgeTypeName.localeCompare(b.knowledgeTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${exports.vcc_CourseKnowledges_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                    return (a, b) => {
                        return b.courseKnowledgeId.localeCompare(a.courseKnowledgeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                    return (a, b) => {
                        return b.knowledgeName.localeCompare(a.knowledgeName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                    return (a, b) => {
                        if (b.knowledgeTitle == null)
                            return -1;
                        if (a.knowledgeTitle == null)
                            return 1;
                        return b.knowledgeTitle.localeCompare(a.knowledgeTitle);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                    return (a, b) => {
                        if (b.knowledgeContent == null)
                            return -1;
                        if (a.knowledgeContent == null)
                            return 1;
                        return b.knowledgeContent.localeCompare(a.knowledgeContent);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                    return (a, b) => {
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId:
                    return (a, b) => {
                        if (b.chapterId == null)
                            return -1;
                        if (a.chapterId == null)
                            return 1;
                        return b.chapterId.localeCompare(a.chapterId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate:
                    return (a, b) => {
                        if (b.uploadDate == null)
                            return -1;
                        if (a.uploadDate == null)
                            return 1;
                        return b.uploadDate.localeCompare(a.uploadDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName:
                    return (a, b) => {
                        if (b.chapterName == null)
                            return -1;
                        if (a.chapterName == null)
                            return 1;
                        return b.chapterName.localeCompare(a.chapterName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast:
                    return (a, b) => {
                        if (b.isCast == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (b.chapterName_Sim == null)
                            return -1;
                        if (a.chapterName_Sim == null)
                            return 1;
                        return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (b.sectionName_Sim == null)
                            return -1;
                        if (a.sectionName_Sim == null)
                            return 1;
                        return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum:
                    return (a, b) => {
                        return b.questionNum - a.questionNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                    return (a, b) => {
                        if (b.knowledgeTypeId == null)
                            return -1;
                        if (a.knowledgeTypeId == null)
                            return 1;
                        return b.knowledgeTypeId.localeCompare(a.knowledgeTypeId);
                    };
                case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                    return (a, b) => {
                        if (b.knowledgeTypeName == null)
                            return -1;
                        if (a.knowledgeTypeName == null)
                            return 1;
                        return b.knowledgeTypeName.localeCompare(a.knowledgeTypeName);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${exports.vcc_CourseKnowledges_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_CourseKnowledges_SortFunByKey = vcc_CourseKnowledges_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CourseKnowledges_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId:
                return (obj) => {
                    return obj.courseKnowledgeId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName:
                return (obj) => {
                    return obj.knowledgeName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle:
                return (obj) => {
                    return obj.knowledgeTitle === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeContent:
                return (obj) => {
                    return obj.knowledgeContent === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId:
                return (obj) => {
                    return obj.chapterId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate:
                return (obj) => {
                    return obj.uploadDate === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName:
                return (obj) => {
                    return obj.chapterName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast:
                return (obj) => {
                    return obj.isCast === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim:
                return (obj) => {
                    return obj.chapterName_Sim === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim:
                return (obj) => {
                    return obj.sectionName_Sim === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum:
                return (obj) => {
                    return obj.questionNum === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId:
                return (obj) => {
                    return obj.knowledgeTypeId === value;
                };
            case clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName:
                return (obj) => {
                    return obj.knowledgeTypeName === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseKnowledges]中不存在！(in ${exports.vcc_CourseKnowledges_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_CourseKnowledges_FilterFunByKey = vcc_CourseKnowledges_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vcc_CourseKnowledges_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvcc_CourseKnowledges = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId_C);
        if (arrvcc_CourseKnowledges == null)
            return [];
        let arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvcc_CourseKnowledges_Sel.length == 0)
            return [];
        return arrvcc_CourseKnowledges_Sel.map(x => x.courseKnowledgeId);
    }
    exports.vcc_CourseKnowledges_funcKey = vcc_CourseKnowledges_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_CourseKnowledges_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetFirstIDAsync = vcc_CourseKnowledges_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_CourseKnowledges_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetFirstID = vcc_CourseKnowledges_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_CourseKnowledges_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const objvcc_CourseKnowledges = vcc_CourseKnowledges_GetObjFromJsonObj(returnObj);
                return objvcc_CourseKnowledges;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetFirstObjAsync = vcc_CourseKnowledges_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
        clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvcc_CourseKnowledgesExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvcc_CourseKnowledgesObjLst_T = vcc_CourseKnowledges_GetObjLstByJSONObjLst(arrvcc_CourseKnowledgesExObjLst_Cache);
            return arrvcc_CourseKnowledgesObjLst_T;
        }
        try {
            const arrvcc_CourseKnowledgesExObjLst = await vcc_CourseKnowledges_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvcc_CourseKnowledgesExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseKnowledgesExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseKnowledgesExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_CourseKnowledges_GetObjLst_ClientCache = vcc_CourseKnowledges_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
        clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_CourseKnowledgesExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_CourseKnowledgesObjLst_T = vcc_CourseKnowledges_GetObjLstByJSONObjLst(arrvcc_CourseKnowledgesExObjLst_Cache);
            return arrvcc_CourseKnowledgesObjLst_T;
        }
        try {
            const arrvcc_CourseKnowledgesExObjLst = await vcc_CourseKnowledges_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvcc_CourseKnowledgesExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseKnowledgesExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseKnowledgesExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_CourseKnowledges_GetObjLst_localStorage = vcc_CourseKnowledges_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_CourseKnowledgesObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_CourseKnowledgesObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_CourseKnowledges_GetObjLst_localStorage_PureCache = vcc_CourseKnowledges_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstAsync = vcc_CourseKnowledges_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
        clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_CourseKnowledgesExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_CourseKnowledgesObjLst_T = vcc_CourseKnowledges_GetObjLstByJSONObjLst(arrvcc_CourseKnowledgesExObjLst_Cache);
            return arrvcc_CourseKnowledgesObjLst_T;
        }
        try {
            const arrvcc_CourseKnowledgesExObjLst = await vcc_CourseKnowledges_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvcc_CourseKnowledgesExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseKnowledgesExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseKnowledgesExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_CourseKnowledges_GetObjLst_sessionStorage = vcc_CourseKnowledges_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_CourseKnowledgesObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_CourseKnowledgesObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_CourseKnowledges_GetObjLst_sessionStorage_PureCache = vcc_CourseKnowledges_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[CourseId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvcc_CourseKnowledgesObjLst_Cache;
        switch (clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrvcc_CourseKnowledgesObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(arrvcc_CourseKnowledgesObjLst_Cache);
        return arrvcc_CourseKnowledgesObjLst_Cache;
    }
    exports.vcc_CourseKnowledges_GetObjLst_Cache = vcc_CourseKnowledges_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvcc_CourseKnowledgesObjLst_Cache;
        switch (clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrvcc_CourseKnowledgesObjLst_Cache = null;
                break;
            default:
                arrvcc_CourseKnowledgesObjLst_Cache = null;
                break;
        }
        return arrvcc_CourseKnowledgesObjLst_Cache;
    }
    exports.vcc_CourseKnowledges_GetObjLst_PureCache = vcc_CourseKnowledges_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseKnowledgeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_CourseKnowledges_GetSubObjLst_Cache(objvcc_CourseKnowledges_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
        let arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache;
        if (objvcc_CourseKnowledges_Cond.sf_FldComparisonOp == null || objvcc_CourseKnowledges_Cond.sf_FldComparisonOp == "")
            return arrvcc_CourseKnowledges_Sel;
        const dicFldComparisonOp = JSON.parse(objvcc_CourseKnowledges_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseKnowledgesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_CourseKnowledges_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseKnowledges_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_CourseKnowledges_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvcc_CourseKnowledges_Cond), exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseKnowledges_GetSubObjLst_Cache = vcc_CourseKnowledges_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseKnowledgeId:关键字列表
    * @returns 对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync(arrCourseKnowledgeId) {
        const strThisFuncName = "GetObjLstByCourseKnowledgeIdLstAsync";
        const strAction = "GetObjLstByCourseKnowledgeIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseKnowledgeId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync = vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseKnowledgeIdLst:关键字列表
     * @returns 对象列表
    */
    async function vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLst_Cache(arrCourseKnowledgeIdLst, strCourseId) {
        const strThisFuncName = "GetObjLstByCourseKnowledgeIdLst_Cache";
        try {
            const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
            const arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache.filter(x => arrCourseKnowledgeIdLst.indexOf(x.courseKnowledgeId) > -1);
            return arrvcc_CourseKnowledges_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseKnowledgeIdLst.join(","), exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLst_Cache = vcc_CourseKnowledges_GetObjLstByCourseKnowledgeIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseKnowledges_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetTopObjLstAsync = vcc_CourseKnowledges_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByRangeAsync = vcc_CourseKnowledges_GetObjLstByRangeAsync;
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
    async function vcc_CourseKnowledges_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByRange = vcc_CourseKnowledges_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_CourseKnowledges_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseKnowledgesObjLst_Cache.length == 0)
            return arrvcc_CourseKnowledgesObjLst_Cache;
        let arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvcc_CourseKnowledges_Cond = new clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseKnowledges_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvcc_CourseKnowledgesWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseKnowledges_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_CourseKnowledges_Sel.length == 0)
                return arrvcc_CourseKnowledges_Sel;
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
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.sort(vcc_CourseKnowledges_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.slice(intStart, intEnd);
            return arrvcc_CourseKnowledges_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseKnowledges_GetObjLstByPager_Cache = vcc_CourseKnowledges_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseKnowledges_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetObjLstByPagerAsync = vcc_CourseKnowledges_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseKnowledgeId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_CourseKnowledges_IsExistRecord_Cache(objvcc_CourseKnowledges_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseKnowledgesObjLst_Cache == null)
            return false;
        let arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache;
        if (objvcc_CourseKnowledges_Cond.sf_FldComparisonOp == null || objvcc_CourseKnowledges_Cond.sf_FldComparisonOp == "")
            return arrvcc_CourseKnowledges_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvcc_CourseKnowledges_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseKnowledgesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_CourseKnowledges_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseKnowledges_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_CourseKnowledges_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvcc_CourseKnowledges_Cond), exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vcc_CourseKnowledges_IsExistRecord_Cache = vcc_CourseKnowledges_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_CourseKnowledges_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_IsExistRecordAsync = vcc_CourseKnowledges_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseKnowledgeId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_CourseKnowledges_IsExist(strCourseKnowledgeId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseKnowledgeId": strCourseKnowledgeId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_IsExist = vcc_CourseKnowledges_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseKnowledgeId:所给的关键字
     * @returns 对象
    */
    async function vcc_CourseKnowledges_IsExist_Cache(strCourseKnowledgeId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseKnowledgesObjLst_Cache == null)
            return false;
        try {
            const arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache.filter(x => x.courseKnowledgeId == strCourseKnowledgeId);
            if (arrvcc_CourseKnowledges_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseKnowledgeId, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vcc_CourseKnowledges_IsExist_Cache = vcc_CourseKnowledges_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseKnowledgeId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_CourseKnowledges_IsExistAsync(strCourseKnowledgeId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseKnowledgeId": strCourseKnowledgeId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_IsExistAsync = vcc_CourseKnowledges_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_CourseKnowledges_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseKnowledges_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseKnowledges_GetRecCountByCondAsync = vcc_CourseKnowledges_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvcc_CourseKnowledges_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vcc_CourseKnowledges_GetRecCountByCond_Cache(objvcc_CourseKnowledges_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvcc_CourseKnowledgesObjLst_Cache = await vcc_CourseKnowledges_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseKnowledgesObjLst_Cache == null)
            return 0;
        let arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledgesObjLst_Cache;
        if (objvcc_CourseKnowledges_Cond.sf_FldComparisonOp == null || objvcc_CourseKnowledges_Cond.sf_FldComparisonOp == "")
            return arrvcc_CourseKnowledges_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvcc_CourseKnowledges_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseKnowledgesWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_CourseKnowledges_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseKnowledges_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseKnowledges_Sel = arrvcc_CourseKnowledges_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_CourseKnowledges_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvcc_CourseKnowledges_Cond), exports.vcc_CourseKnowledges_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vcc_CourseKnowledges_GetRecCountByCond_Cache = vcc_CourseKnowledges_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_CourseKnowledges_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CourseKnowledges_GetWebApiUrl = vcc_CourseKnowledges_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vcc_CourseKnowledges_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN._CurrTabName, strCourseId);
            switch (clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.CacheModeId) {
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
    exports.vcc_CourseKnowledges_ReFreshThisCache = vcc_CourseKnowledges_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseKnowledges_GetJSONStrByObj(pobjvcc_CourseKnowledgesEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_CourseKnowledgesEN);
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
    exports.vcc_CourseKnowledges_GetJSONStrByObj = vcc_CourseKnowledges_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseKnowledges_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_CourseKnowledgesObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_CourseKnowledgesObjLst;
        }
        try {
            arrvcc_CourseKnowledgesObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_CourseKnowledgesObjLst;
        }
        return arrvcc_CourseKnowledgesObjLst;
    }
    exports.vcc_CourseKnowledges_GetObjLstByJSONStr = vcc_CourseKnowledges_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_CourseKnowledgesObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseKnowledges_GetObjLstByJSONObjLst(arrvcc_CourseKnowledgesObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_CourseKnowledgesObjLst = new Array();
        for (const objInFor of arrvcc_CourseKnowledgesObjLstS) {
            const obj1 = vcc_CourseKnowledges_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_CourseKnowledgesObjLst.push(obj1);
        }
        return arrvcc_CourseKnowledgesObjLst;
    }
    exports.vcc_CourseKnowledges_GetObjLstByJSONObjLst = vcc_CourseKnowledges_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseKnowledges_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_CourseKnowledgesEN = new clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN();
        if (strJSON === "") {
            return pobjvcc_CourseKnowledgesEN;
        }
        try {
            pobjvcc_CourseKnowledgesEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_CourseKnowledgesEN;
        }
        return pobjvcc_CourseKnowledgesEN;
    }
    exports.vcc_CourseKnowledges_GetObjByJSONStr = vcc_CourseKnowledges_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_CourseKnowledges_GetCombineCondition(objvcc_CourseKnowledges_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId) == true) {
            const strComparisonOp_CourseKnowledgeId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseKnowledgeId, objvcc_CourseKnowledges_Cond.courseKnowledgeId, strComparisonOp_CourseKnowledgeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName) == true) {
            const strComparisonOp_KnowledgeName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeName, objvcc_CourseKnowledges_Cond.knowledgeName, strComparisonOp_KnowledgeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle) == true) {
            const strComparisonOp_KnowledgeTitle = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTitle, objvcc_CourseKnowledges_Cond.knowledgeTitle, strComparisonOp_KnowledgeTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseId, objvcc_CourseKnowledges_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseCode, objvcc_CourseKnowledges_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseName, objvcc_CourseKnowledges_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_CourseChapterId, objvcc_CourseKnowledges_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UserId, objvcc_CourseKnowledges_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId) == true) {
            const strComparisonOp_ChapterId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterId, objvcc_CourseKnowledges_Cond.chapterId, strComparisonOp_ChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate) == true) {
            const strComparisonOp_UploadDate = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UploadDate, objvcc_CourseKnowledges_Cond.uploadDate, strComparisonOp_UploadDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionId, objvcc_CourseKnowledges_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow) == true) {
            if (objvcc_CourseKnowledges_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsShow);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName) == true) {
            const strComparisonOp_ChapterName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName, objvcc_CourseKnowledges_Cond.chapterName, strComparisonOp_ChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast) == true) {
            if (objvcc_CourseKnowledges_Cond.isCast == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_IsCast);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName, objvcc_CourseKnowledges_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_LikeCount, objvcc_CourseKnowledges_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim) == true) {
            const strComparisonOp_ChapterName_Sim = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_ChapterName_Sim, objvcc_CourseKnowledges_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdDate, objvcc_CourseKnowledges_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim) == true) {
            const strComparisonOp_SectionName_Sim = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_SectionName_Sim, objvcc_CourseKnowledges_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_Memo, objvcc_CourseKnowledges_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum) == true) {
            const strComparisonOp_QuestionNum = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_QuestionNum, objvcc_CourseKnowledges_Cond.questionNum, strComparisonOp_QuestionNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_OrderNum, objvcc_CourseKnowledges_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_UpdUser, objvcc_CourseKnowledges_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId) == true) {
            const strComparisonOp_KnowledgeTypeId = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeId, objvcc_CourseKnowledges_Cond.knowledgeTypeId, strComparisonOp_KnowledgeTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseKnowledges_Cond.dicFldComparisonOp, clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName) == true) {
            const strComparisonOp_KnowledgeTypeName = objvcc_CourseKnowledges_Cond.dicFldComparisonOp[clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN.con_KnowledgeTypeName, objvcc_CourseKnowledges_Cond.knowledgeTypeName, strComparisonOp_KnowledgeTypeName);
        }
        return strWhereCond;
    }
    exports.vcc_CourseKnowledges_GetCombineCondition = vcc_CourseKnowledges_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_CourseKnowledgesENS:源对象
     * @param objvcc_CourseKnowledgesENT:目标对象
    */
    function vcc_CourseKnowledges_CopyObjTo(objvcc_CourseKnowledgesENS, objvcc_CourseKnowledgesENT) {
        objvcc_CourseKnowledgesENT.courseKnowledgeId = objvcc_CourseKnowledgesENS.courseKnowledgeId; //知识点Id
        objvcc_CourseKnowledgesENT.knowledgeName = objvcc_CourseKnowledgesENS.knowledgeName; //知识点名称
        objvcc_CourseKnowledgesENT.knowledgeTitle = objvcc_CourseKnowledgesENS.knowledgeTitle; //知识点标题
        objvcc_CourseKnowledgesENT.knowledgeContent = objvcc_CourseKnowledgesENS.knowledgeContent; //知识点内容
        objvcc_CourseKnowledgesENT.courseId = objvcc_CourseKnowledgesENS.courseId; //课程Id
        objvcc_CourseKnowledgesENT.courseCode = objvcc_CourseKnowledgesENS.courseCode; //课程代码
        objvcc_CourseKnowledgesENT.courseName = objvcc_CourseKnowledgesENS.courseName; //课程名称
        objvcc_CourseKnowledgesENT.courseChapterId = objvcc_CourseKnowledgesENS.courseChapterId; //课程章节ID
        objvcc_CourseKnowledgesENT.userId = objvcc_CourseKnowledgesENS.userId; //用户ID
        objvcc_CourseKnowledgesENT.chapterId = objvcc_CourseKnowledgesENS.chapterId; //章Id
        objvcc_CourseKnowledgesENT.uploadDate = objvcc_CourseKnowledgesENS.uploadDate; //上传时间
        objvcc_CourseKnowledgesENT.sectionId = objvcc_CourseKnowledgesENS.sectionId; //节Id
        objvcc_CourseKnowledgesENT.isShow = objvcc_CourseKnowledgesENS.isShow; //是否启用
        objvcc_CourseKnowledgesENT.chapterName = objvcc_CourseKnowledgesENS.chapterName; //章名
        objvcc_CourseKnowledgesENT.isCast = objvcc_CourseKnowledgesENS.isCast; //是否播放
        objvcc_CourseKnowledgesENT.sectionName = objvcc_CourseKnowledgesENS.sectionName; //节名
        objvcc_CourseKnowledgesENT.likeCount = objvcc_CourseKnowledgesENS.likeCount; //资源喜欢数量
        objvcc_CourseKnowledgesENT.chapterName_Sim = objvcc_CourseKnowledgesENS.chapterName_Sim; //章名简称
        objvcc_CourseKnowledgesENT.updDate = objvcc_CourseKnowledgesENS.updDate; //修改日期
        objvcc_CourseKnowledgesENT.sectionName_Sim = objvcc_CourseKnowledgesENS.sectionName_Sim; //节名简称
        objvcc_CourseKnowledgesENT.memo = objvcc_CourseKnowledgesENS.memo; //备注
        objvcc_CourseKnowledgesENT.questionNum = objvcc_CourseKnowledgesENS.questionNum; //题目数
        objvcc_CourseKnowledgesENT.orderNum = objvcc_CourseKnowledgesENS.orderNum; //序号
        objvcc_CourseKnowledgesENT.updUser = objvcc_CourseKnowledgesENS.updUser; //修改人
        objvcc_CourseKnowledgesENT.knowledgeTypeId = objvcc_CourseKnowledgesENS.knowledgeTypeId; //知识点类型Id
        objvcc_CourseKnowledgesENT.knowledgeTypeName = objvcc_CourseKnowledgesENS.knowledgeTypeName; //知识点类型名
    }
    exports.vcc_CourseKnowledges_CopyObjTo = vcc_CourseKnowledges_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_CourseKnowledgesENS:源对象
     * @param objvcc_CourseKnowledgesENT:目标对象
    */
    function vcc_CourseKnowledges_GetObjFromJsonObj(objvcc_CourseKnowledgesENS) {
        const objvcc_CourseKnowledgesENT = new clsvcc_CourseKnowledgesEN_js_1.clsvcc_CourseKnowledgesEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseKnowledgesENT, objvcc_CourseKnowledgesENS);
        return objvcc_CourseKnowledgesENT;
    }
    exports.vcc_CourseKnowledges_GetObjFromJsonObj = vcc_CourseKnowledges_GetObjFromJsonObj;
});
