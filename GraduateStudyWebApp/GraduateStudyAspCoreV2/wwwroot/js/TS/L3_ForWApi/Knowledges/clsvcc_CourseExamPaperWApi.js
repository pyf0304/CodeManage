/**
* 类名:clsvcc_CourseExamPaperWApi
* 表名:vcc_CourseExamPaper(01120098)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/15 23:43:48
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/Knowledges/clsvcc_CourseExamPaperEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_CourseExamPaper_GetObjFromJsonObj = exports.vcc_CourseExamPaper_CopyObjTo = exports.vcc_CourseExamPaper_GetCombineCondition = exports.vcc_CourseExamPaper_GetObjByJSONStr = exports.vcc_CourseExamPaper_GetObjLstByJSONObjLst = exports.vcc_CourseExamPaper_GetObjLstByJSONStr = exports.vcc_CourseExamPaper_GetJSONStrByObj = exports.vcc_CourseExamPaper_ReFreshThisCache = exports.vcc_CourseExamPaper_GetWebApiUrl = exports.vcc_CourseExamPaper_GetRecCountByCond_Cache = exports.vcc_CourseExamPaper_GetRecCountByCondAsync = exports.vcc_CourseExamPaper_IsExistAsync = exports.vcc_CourseExamPaper_IsExist_Cache = exports.vcc_CourseExamPaper_IsExist = exports.vcc_CourseExamPaper_IsExistRecordAsync = exports.vcc_CourseExamPaper_IsExistRecord_Cache = exports.vcc_CourseExamPaper_GetObjLstByPagerAsync = exports.vcc_CourseExamPaper_GetObjLstByPager_Cache = exports.vcc_CourseExamPaper_GetObjLstByRange = exports.vcc_CourseExamPaper_GetObjLstByRangeAsync = exports.vcc_CourseExamPaper_GetTopObjLstAsync = exports.vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache = exports.vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync = exports.vcc_CourseExamPaper_GetSubObjLst_Cache = exports.vcc_CourseExamPaper_GetObjLst_PureCache = exports.vcc_CourseExamPaper_GetObjLst_Cache = exports.vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache = exports.vcc_CourseExamPaper_GetObjLst_sessionStorage = exports.vcc_CourseExamPaper_GetObjLstAsync = exports.vcc_CourseExamPaper_GetObjLst_localStorage_PureCache = exports.vcc_CourseExamPaper_GetObjLst_localStorage = exports.vcc_CourseExamPaper_GetObjLst_ClientCache = exports.vcc_CourseExamPaper_GetFirstObjAsync = exports.vcc_CourseExamPaper_GetFirstID = exports.vcc_CourseExamPaper_GetFirstIDAsync = exports.vcc_CourseExamPaper_funcKey = exports.vcc_CourseExamPaper_FilterFunByKey = exports.vcc_CourseExamPaper_SortFunByKey = exports.vcc_CourseExamPaper_SortFun_Defa_2Fld = exports.vcc_CourseExamPaper_SortFun_Defa = exports.vcc_CourseExamPaper_func = exports.vcc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage = exports.vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache = exports.vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync = exports.vcc_CourseExamPaper_ConstructorName = exports.vcc_CourseExamPaper_Controller = void 0;
    /**
     * v考卷(vcc_CourseExamPaper)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月15日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvcc_CourseExamPaperEN_js_1 = require("../../L0_Entity/Knowledges/clsvcc_CourseExamPaperEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_CourseExamPaper_Controller = "vcc_CourseExamPaperApi";
    exports.vcc_CourseExamPaper_ConstructorName = "vcc_CourseExamPaper";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseExamPaperId:关键字
    * @returns 对象
    **/
    async function vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId) {
        const strThisFuncName = "GetObjByCourseExamPaperIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseExamPaperId]不能为空！(In clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperIdAsync)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseExamPaperId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseExamPaperId": strCourseExamPaperId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvcc_CourseExamPaper = vcc_CourseExamPaper_GetObjFromJsonObj(returnObj);
                return objvcc_CourseExamPaper;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync = vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache(strCourseExamPaperId, strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseExamPaperId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseExamPaperId]不能为空！(In clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperId_Cache)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        try {
            const arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
            let objvcc_CourseExamPaper;
            if (arrvcc_CourseExamPaper_Sel.length > 0) {
                objvcc_CourseExamPaper = arrvcc_CourseExamPaper_Sel[0];
                return objvcc_CourseExamPaper;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvcc_CourseExamPaper_Const = await vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId);
                    if (objvcc_CourseExamPaper_Const != null) {
                        vcc_CourseExamPaper_ReFreshThisCache(strCourseId);
                        return objvcc_CourseExamPaper_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseExamPaperId, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache = vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function vcc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage(strCourseExamPaperId) {
        const strThisFuncName = "GetObjByCourseExamPaperId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseExamPaperId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseExamPaperId]不能为空！(In clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseExamPaperId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseExamPaperId]的长度:[{0}]不正确！(clsvcc_CourseExamPaperWApi.GetObjByCourseExamPaperId_localStorage)", strCourseExamPaperId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseExamPaperId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvcc_CourseExamPaper_Cache = JSON.parse(strTempObj);
            return objvcc_CourseExamPaper_Cache;
        }
        try {
            const objvcc_CourseExamPaper = await vcc_CourseExamPaper_GetObjByCourseExamPaperIdAsync(strCourseExamPaperId);
            if (objvcc_CourseExamPaper != null) {
                localStorage.setItem(strKey, JSON.stringify(objvcc_CourseExamPaper));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvcc_CourseExamPaper;
            }
            return objvcc_CourseExamPaper;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseExamPaperId, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vcc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage = vcc_CourseExamPaper_GetObjByCourseExamPaperId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strCourseId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vcc_CourseExamPaper_func(strInFldName, strOutFldName, strInValue, strCourseId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvcc_CourseExamPaperWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvcc_CourseExamPaperWApi.func)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseExamPaperId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvcc_CourseExamPaper = await vcc_CourseExamPaper_GetObjByCourseExamPaperId_Cache(strCourseExamPaperId, strCourseId_C);
        if (objvcc_CourseExamPaper == null)
            return "";
        if (objvcc_CourseExamPaper.GetFldValue(strOutFldName) == null)
            return "";
        return objvcc_CourseExamPaper.GetFldValue(strOutFldName).toString();
    }
    exports.vcc_CourseExamPaper_func = vcc_CourseExamPaper_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseExamPaper_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
    }
    exports.vcc_CourseExamPaper_SortFun_Defa = vcc_CourseExamPaper_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseExamPaper_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseId == b.courseId)
            return a.courseName.localeCompare(b.courseName);
        else
            return a.courseId.localeCompare(b.courseId);
    }
    exports.vcc_CourseExamPaper_SortFun_Defa_2Fld = vcc_CourseExamPaper_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_CourseExamPaper_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
                    return (a, b) => {
                        return a.courseExamPaperId.localeCompare(b.courseExamPaperId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperName:
                    return (a, b) => {
                        if (a.examPaperName == null)
                            return -1;
                        if (b.examPaperName == null)
                            return 1;
                        return a.examPaperName.localeCompare(b.examPaperName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperIndex:
                    return (a, b) => {
                        return a.paperIndex - b.paperIndex;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
                    return (a, b) => {
                        return a.examPaperTypeId.localeCompare(b.examPaperTypeId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
                    return (a, b) => {
                        if (a.examPaperTypeName == null)
                            return -1;
                        if (b.examPaperTypeName == null)
                            return 1;
                        return a.examPaperTypeName.localeCompare(b.examPaperTypeName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsShow:
                    return (a, b) => {
                        if (a.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_TotalScore:
                    return (a, b) => {
                        return a.totalScore - b.totalScore;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DoneNumber:
                    return (a, b) => {
                        return a.doneNumber - b.doneNumber;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperTime:
                    return (a, b) => {
                        return a.paperTime - b.paperTime;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DownloadNumber:
                    return (a, b) => {
                        return a.downloadNumber - b.downloadNumber;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return a.collectionCount - b.collectionCount;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_LikeCount:
                    return (a, b) => {
                        return a.likeCount - b.likeCount;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeId:
                    return (a, b) => {
                        if (a.paperDispModeId == null)
                            return -1;
                        if (b.paperDispModeId == null)
                            return 1;
                        return a.paperDispModeId.localeCompare(b.paperDispModeId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeName:
                    return (a, b) => {
                        if (a.paperDispModeName == null)
                            return -1;
                        if (b.paperDispModeName == null)
                            return 1;
                        return a.paperDispModeName.localeCompare(b.paperDispModeName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamCreateTime:
                    return (a, b) => {
                        if (a.examCreateTime == null)
                            return -1;
                        if (b.examCreateTime == null)
                            return 1;
                        return a.examCreateTime.localeCompare(b.examCreateTime);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CreateUserID:
                    return (a, b) => {
                        if (a.createUserID == null)
                            return -1;
                        if (b.createUserID == null)
                            return 1;
                        return a.createUserID.localeCompare(b.createUserID);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
                    return (a, b) => {
                        if (a.isOpenToAllStu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
                    return (a, b) => {
                        if (a.isOpenToSchool == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
                    return (a, b) => {
                        if (a.isOpenToSocial == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterId:
                    return (a, b) => {
                        if (a.courseChapterId == null)
                            return -1;
                        if (b.courseChapterId == null)
                            return 1;
                        return a.courseChapterId.localeCompare(b.courseChapterId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterName:
                    return (a, b) => {
                        if (a.courseChapterName == null)
                            return -1;
                        if (b.courseChapterName == null)
                            return 1;
                        return a.courseChapterName.localeCompare(b.courseChapterName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterId:
                    return (a, b) => {
                        if (a.chapterId == null)
                            return -1;
                        if (b.chapterId == null)
                            return 1;
                        return a.chapterId.localeCompare(b.chapterId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName:
                    return (a, b) => {
                        if (a.chapterName == null)
                            return -1;
                        if (b.chapterName == null)
                            return 1;
                        return a.chapterName.localeCompare(b.chapterName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (a.chapterName_Sim == null)
                            return -1;
                        if (b.chapterName_Sim == null)
                            return 1;
                        return a.chapterName_Sim.localeCompare(b.chapterName_Sim);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (a.sectionName_Sim == null)
                            return -1;
                        if (b.sectionName_Sim == null)
                            return 1;
                        return a.sectionName_Sim.localeCompare(b.sectionName_Sim);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    return (a, b) => {
                        if (a.isAutoGeneQuestion == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
                    return (a, b) => {
                        if (a.isCanMultiDo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdUserId:
                    return (a, b) => {
                        if (a.updUserId == null)
                            return -1;
                        if (b.updUserId == null)
                            return 1;
                        return a.updUserId.localeCompare(b.updUserId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_QuestionNum:
                    return (a, b) => {
                        return a.questionNum - b.questionNum;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_BigTopicNum:
                    return (a, b) => {
                        return a.bigTopicNum - b.bigTopicNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${exports.vcc_CourseExamPaper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
                    return (a, b) => {
                        return b.courseExamPaperId.localeCompare(a.courseExamPaperId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperName:
                    return (a, b) => {
                        if (b.examPaperName == null)
                            return -1;
                        if (a.examPaperName == null)
                            return 1;
                        return b.examPaperName.localeCompare(a.examPaperName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperIndex:
                    return (a, b) => {
                        return b.paperIndex - a.paperIndex;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
                    return (a, b) => {
                        return b.examPaperTypeId.localeCompare(a.examPaperTypeId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
                    return (a, b) => {
                        if (b.examPaperTypeName == null)
                            return -1;
                        if (a.examPaperTypeName == null)
                            return 1;
                        return b.examPaperTypeName.localeCompare(a.examPaperTypeName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsShow:
                    return (a, b) => {
                        if (b.isShow == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_TotalScore:
                    return (a, b) => {
                        return b.totalScore - a.totalScore;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DoneNumber:
                    return (a, b) => {
                        return b.doneNumber - a.doneNumber;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperTime:
                    return (a, b) => {
                        return b.paperTime - a.paperTime;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DownloadNumber:
                    return (a, b) => {
                        return b.downloadNumber - a.downloadNumber;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CollectionCount:
                    return (a, b) => {
                        return b.collectionCount - a.collectionCount;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_LikeCount:
                    return (a, b) => {
                        return b.likeCount - a.likeCount;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeId:
                    return (a, b) => {
                        if (b.paperDispModeId == null)
                            return -1;
                        if (a.paperDispModeId == null)
                            return 1;
                        return b.paperDispModeId.localeCompare(a.paperDispModeId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeName:
                    return (a, b) => {
                        if (b.paperDispModeName == null)
                            return -1;
                        if (a.paperDispModeName == null)
                            return 1;
                        return b.paperDispModeName.localeCompare(a.paperDispModeName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamCreateTime:
                    return (a, b) => {
                        if (b.examCreateTime == null)
                            return -1;
                        if (a.examCreateTime == null)
                            return 1;
                        return b.examCreateTime.localeCompare(a.examCreateTime);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CreateUserID:
                    return (a, b) => {
                        if (b.createUserID == null)
                            return -1;
                        if (a.createUserID == null)
                            return 1;
                        return b.createUserID.localeCompare(a.createUserID);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
                    return (a, b) => {
                        if (b.isOpenToAllStu == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
                    return (a, b) => {
                        if (b.isOpenToSchool == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
                    return (a, b) => {
                        if (b.isOpenToSocial == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterId:
                    return (a, b) => {
                        if (b.courseChapterId == null)
                            return -1;
                        if (a.courseChapterId == null)
                            return 1;
                        return b.courseChapterId.localeCompare(a.courseChapterId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterName:
                    return (a, b) => {
                        if (b.courseChapterName == null)
                            return -1;
                        if (a.courseChapterName == null)
                            return 1;
                        return b.courseChapterName.localeCompare(a.courseChapterName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterId:
                    return (a, b) => {
                        if (b.chapterId == null)
                            return -1;
                        if (a.chapterId == null)
                            return 1;
                        return b.chapterId.localeCompare(a.chapterId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName:
                    return (a, b) => {
                        if (b.chapterName == null)
                            return -1;
                        if (a.chapterName == null)
                            return 1;
                        return b.chapterName.localeCompare(a.chapterName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
                    return (a, b) => {
                        if (b.chapterName_Sim == null)
                            return -1;
                        if (a.chapterName_Sim == null)
                            return 1;
                        return b.chapterName_Sim.localeCompare(a.chapterName_Sim);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName_Sim:
                    return (a, b) => {
                        if (b.sectionName_Sim == null)
                            return -1;
                        if (a.sectionName_Sim == null)
                            return 1;
                        return b.sectionName_Sim.localeCompare(a.sectionName_Sim);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                    return (a, b) => {
                        if (b.isAutoGeneQuestion == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
                    return (a, b) => {
                        if (b.isCanMultiDo == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdUserId:
                    return (a, b) => {
                        if (b.updUserId == null)
                            return -1;
                        if (a.updUserId == null)
                            return 1;
                        return b.updUserId.localeCompare(a.updUserId);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_QuestionNum:
                    return (a, b) => {
                        return b.questionNum - a.questionNum;
                    };
                case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_BigTopicNum:
                    return (a, b) => {
                        return b.bigTopicNum - a.bigTopicNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${exports.vcc_CourseExamPaper_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_CourseExamPaper_SortFunByKey = vcc_CourseExamPaper_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_CourseExamPaper_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId:
                return (obj) => {
                    return obj.courseExamPaperId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperName:
                return (obj) => {
                    return obj.examPaperName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperIndex:
                return (obj) => {
                    return obj.paperIndex === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeId:
                return (obj) => {
                    return obj.examPaperTypeId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeName:
                return (obj) => {
                    return obj.examPaperTypeName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsShow:
                return (obj) => {
                    return obj.isShow === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_TotalScore:
                return (obj) => {
                    return obj.totalScore === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DoneNumber:
                return (obj) => {
                    return obj.doneNumber === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperTime:
                return (obj) => {
                    return obj.paperTime === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DownloadNumber:
                return (obj) => {
                    return obj.downloadNumber === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CollectionCount:
                return (obj) => {
                    return obj.collectionCount === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_LikeCount:
                return (obj) => {
                    return obj.likeCount === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeId:
                return (obj) => {
                    return obj.paperDispModeId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeName:
                return (obj) => {
                    return obj.paperDispModeName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamCreateTime:
                return (obj) => {
                    return obj.examCreateTime === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CreateUserID:
                return (obj) => {
                    return obj.createUserID === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToAllStu:
                return (obj) => {
                    return obj.isOpenToAllStu === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSchool:
                return (obj) => {
                    return obj.isOpenToSchool === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSocial:
                return (obj) => {
                    return obj.isOpenToSocial === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterId:
                return (obj) => {
                    return obj.courseChapterId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterName:
                return (obj) => {
                    return obj.courseChapterName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterId:
                return (obj) => {
                    return obj.chapterId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName:
                return (obj) => {
                    return obj.chapterName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName_Sim:
                return (obj) => {
                    return obj.chapterName_Sim === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName_Sim:
                return (obj) => {
                    return obj.sectionName_Sim === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion:
                return (obj) => {
                    return obj.isAutoGeneQuestion === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsCanMultiDo:
                return (obj) => {
                    return obj.isCanMultiDo === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdUserId:
                return (obj) => {
                    return obj.updUserId === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_QuestionNum:
                return (obj) => {
                    return obj.questionNum === value;
                };
            case clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_BigTopicNum:
                return (obj) => {
                    return obj.bigTopicNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_CourseExamPaper]中不存在！(in ${exports.vcc_CourseExamPaper_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_CourseExamPaper_FilterFunByKey = vcc_CourseExamPaper_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     @param strCourseId:缓存的分类字段
     * @returns 返回一个关键字值列表
    */
    async function vcc_CourseExamPaper_funcKey(strInFldName, strInValue, strComparisonOp, strCourseId_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId_C]不能为空！(In clsvcc_CourseExamPaperWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId_C]的长度:[{0}]不正确！(clsvcc_CourseExamPaperWApi.funcKey)", strCourseId_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvcc_CourseExamPaper = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId_C);
        if (arrvcc_CourseExamPaper == null)
            return [];
        let arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvcc_CourseExamPaper_Sel.length == 0)
            return [];
        return arrvcc_CourseExamPaper_Sel.map(x => x.courseExamPaperId);
    }
    exports.vcc_CourseExamPaper_funcKey = vcc_CourseExamPaper_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_CourseExamPaper_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetFirstIDAsync = vcc_CourseExamPaper_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_CourseExamPaper_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetFirstID = vcc_CourseExamPaper_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_CourseExamPaper_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
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
                const objvcc_CourseExamPaper = vcc_CourseExamPaper_GetObjFromJsonObj(returnObj);
                return objvcc_CourseExamPaper;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetFirstObjAsync = vcc_CourseExamPaper_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_ClientCache(strCourseId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvcc_CourseExamPaperExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvcc_CourseExamPaperObjLst_T = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperExObjLst_Cache);
            return arrvcc_CourseExamPaperObjLst_T;
        }
        try {
            const arrvcc_CourseExamPaperExObjLst = await vcc_CourseExamPaper_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvcc_CourseExamPaperExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExamPaperExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseExamPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_CourseExamPaper_GetObjLst_ClientCache = vcc_CourseExamPaper_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_localStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_CourseExamPaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_CourseExamPaperObjLst_T = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperExObjLst_Cache);
            return arrvcc_CourseExamPaperObjLst_T;
        }
        try {
            const arrvcc_CourseExamPaperExObjLst = await vcc_CourseExamPaper_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExamPaperExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExamPaperExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseExamPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_CourseExamPaper_GetObjLst_localStorage = vcc_CourseExamPaper_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_localStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_CourseExamPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_CourseExamPaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_CourseExamPaper_GetObjLst_localStorage_PureCache = vcc_CourseExamPaper_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetObjLstAsync = vcc_CourseExamPaper_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_sessionStorage(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.WhereFormat, strCourseId);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_CourseExamPaperExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_CourseExamPaperObjLst_T = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperExObjLst_Cache);
            return arrvcc_CourseExamPaperObjLst_T;
        }
        try {
            const arrvcc_CourseExamPaperExObjLst = await vcc_CourseExamPaper_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvcc_CourseExamPaperExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_CourseExamPaperExObjLst.length);
            console.log(strInfo);
            return arrvcc_CourseExamPaperExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_CourseExamPaper_GetObjLst_sessionStorage = vcc_CourseExamPaper_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache(strCourseId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("CourseId='{0}'", strCourseId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_CourseExamPaperObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_CourseExamPaperObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache = vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_Cache(strCourseId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[CourseId]不能为空！(in clsvcc_CourseExamPaperWApi.vcc_CourseExamPaper_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(in clsvcc_CourseExamPaperWApi.vcc_CourseExamPaper_GetObjLst_Cache() )", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvcc_CourseExamPaperObjLst_Cache;
        switch (clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_sessionStorage(strCourseId);
                break;
            case "03": //localStorage
                arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_localStorage(strCourseId);
                break;
            case "02": //ClientCache
                arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_ClientCache(strCourseId);
                break;
            default:
                arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_ClientCache(strCourseId);
                break;
        }
        const arrvcc_CourseExamPaperObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperObjLst_Cache);
        return arrvcc_CourseExamPaperObjLst_Cache;
    }
    exports.vcc_CourseExamPaper_GetObjLst_Cache = vcc_CourseExamPaper_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLst_PureCache(strCourseId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvcc_CourseExamPaperObjLst_Cache;
        switch (clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_sessionStorage_PureCache(strCourseId);
                break;
            case "03": //localStorage
                arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_localStorage_PureCache(strCourseId);
                break;
            case "02": //ClientCache
                arrvcc_CourseExamPaperObjLst_Cache = null;
                break;
            default:
                arrvcc_CourseExamPaperObjLst_Cache = null;
                break;
        }
        return arrvcc_CourseExamPaperObjLst_Cache;
    }
    exports.vcc_CourseExamPaper_GetObjLst_PureCache = vcc_CourseExamPaper_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseExamPaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_CourseExamPaper_GetSubObjLst_Cache(objvcc_CourseExamPaper_Cond, strCourseId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        let arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache;
        if (objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == "")
            return arrvcc_CourseExamPaper_Sel;
        const dicFldComparisonOp = JSON.parse(objvcc_CourseExamPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_CourseExamPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_CourseExamPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvcc_CourseExamPaper_Cond), exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseExamPaper_GetSubObjLst_Cache = vcc_CourseExamPaper_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseExamPaperId:关键字列表
    * @returns 对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync(arrCourseExamPaperId) {
        const strThisFuncName = "GetObjLstByCourseExamPaperIdLstAsync";
        const strAction = "GetObjLstByCourseExamPaperIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseExamPaperId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync = vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseExamPaperIdLst:关键字列表
     * @returns 对象列表
    */
    async function vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache(arrCourseExamPaperIdLst, strCourseId) {
        const strThisFuncName = "GetObjLstByCourseExamPaperIdLst_Cache";
        try {
            const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
            const arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache.filter(x => arrCourseExamPaperIdLst.indexOf(x.courseExamPaperId) > -1);
            return arrvcc_CourseExamPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseExamPaperIdLst.join(","), exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache = vcc_CourseExamPaper_GetObjLstByCourseExamPaperIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_CourseExamPaper_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetTopObjLstAsync = vcc_CourseExamPaper_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetObjLstByRangeAsync = vcc_CourseExamPaper_GetObjLstByRangeAsync;
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
    async function vcc_CourseExamPaper_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetObjLstByRange = vcc_CourseExamPaper_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_CourseExamPaper_GetObjLstByPager_Cache(objPagerPara, strCourseId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseExamPaperObjLst_Cache.length == 0)
            return arrvcc_CourseExamPaperObjLst_Cache;
        let arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvcc_CourseExamPaper_Cond = new clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseExamPaper_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvcc_CourseExamPaperWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_CourseExamPaper_Sel.length == 0)
                return arrvcc_CourseExamPaper_Sel;
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
                arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.sort(vcc_CourseExamPaper_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.slice(intStart, intEnd);
            return arrvcc_CourseExamPaper_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_CourseExamPaper_GetObjLstByPager_Cache = vcc_CourseExamPaper_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_CourseExamPaper_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetObjLstByPagerAsync = vcc_CourseExamPaper_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseExamPaperId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_CourseExamPaper_IsExistRecord_Cache(objvcc_CourseExamPaper_Cond, strCourseId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseExamPaperObjLst_Cache == null)
            return false;
        let arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache;
        if (objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == "")
            return arrvcc_CourseExamPaper_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvcc_CourseExamPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_CourseExamPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_CourseExamPaper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvcc_CourseExamPaper_Cond), exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vcc_CourseExamPaper_IsExistRecord_Cache = vcc_CourseExamPaper_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_CourseExamPaper_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_IsExistRecordAsync = vcc_CourseExamPaper_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseExamPaperId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_CourseExamPaper_IsExist(strCourseExamPaperId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseExamPaperId": strCourseExamPaperId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_IsExist = vcc_CourseExamPaper_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseExamPaperId:所给的关键字
     * @returns 对象
    */
    async function vcc_CourseExamPaper_IsExist_Cache(strCourseExamPaperId, strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseExamPaperObjLst_Cache == null)
            return false;
        try {
            const arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache.filter(x => x.courseExamPaperId == strCourseExamPaperId);
            if (arrvcc_CourseExamPaper_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseExamPaperId, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vcc_CourseExamPaper_IsExist_Cache = vcc_CourseExamPaper_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseExamPaperId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_CourseExamPaper_IsExistAsync(strCourseExamPaperId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseExamPaperId": strCourseExamPaperId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_IsExistAsync = vcc_CourseExamPaper_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_CourseExamPaper_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_CourseExamPaper_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_CourseExamPaper_GetRecCountByCondAsync = vcc_CourseExamPaper_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvcc_CourseExamPaper_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vcc_CourseExamPaper_GetRecCountByCond_Cache(objvcc_CourseExamPaper_Cond, strCourseId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvcc_CourseExamPaperObjLst_Cache = await vcc_CourseExamPaper_GetObjLst_Cache(strCourseId);
        if (arrvcc_CourseExamPaperObjLst_Cache == null)
            return 0;
        let arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaperObjLst_Cache;
        if (objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == null || objvcc_CourseExamPaper_Cond.sf_FldComparisonOp == "")
            return arrvcc_CourseExamPaper_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvcc_CourseExamPaper_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_CourseExamPaperWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_CourseExamPaper_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_CourseExamPaper_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_CourseExamPaper_Sel = arrvcc_CourseExamPaper_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_CourseExamPaper_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvcc_CourseExamPaper_Cond), exports.vcc_CourseExamPaper_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vcc_CourseExamPaper_GetRecCountByCond_Cache = vcc_CourseExamPaper_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_CourseExamPaper_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_CourseExamPaper_GetWebApiUrl = vcc_CourseExamPaper_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vcc_CourseExamPaper_ReFreshThisCache(strCourseId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN._CurrTabName, strCourseId);
            switch (clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.CacheModeId) {
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
    exports.vcc_CourseExamPaper_ReFreshThisCache = vcc_CourseExamPaper_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseExamPaper_GetJSONStrByObj(pobjvcc_CourseExamPaperEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_CourseExamPaperEN);
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
    exports.vcc_CourseExamPaper_GetJSONStrByObj = vcc_CourseExamPaper_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseExamPaper_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_CourseExamPaperObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_CourseExamPaperObjLst;
        }
        try {
            arrvcc_CourseExamPaperObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_CourseExamPaperObjLst;
        }
        return arrvcc_CourseExamPaperObjLst;
    }
    exports.vcc_CourseExamPaper_GetObjLstByJSONStr = vcc_CourseExamPaper_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_CourseExamPaperObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_CourseExamPaper_GetObjLstByJSONObjLst(arrvcc_CourseExamPaperObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_CourseExamPaperObjLst = new Array();
        for (const objInFor of arrvcc_CourseExamPaperObjLstS) {
            const obj1 = vcc_CourseExamPaper_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_CourseExamPaperObjLst.push(obj1);
        }
        return arrvcc_CourseExamPaperObjLst;
    }
    exports.vcc_CourseExamPaper_GetObjLstByJSONObjLst = vcc_CourseExamPaper_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-15
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_CourseExamPaper_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_CourseExamPaperEN = new clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN();
        if (strJSON === "") {
            return pobjvcc_CourseExamPaperEN;
        }
        try {
            pobjvcc_CourseExamPaperEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_CourseExamPaperEN;
        }
        return pobjvcc_CourseExamPaperEN;
    }
    exports.vcc_CourseExamPaper_GetObjByJSONStr = vcc_CourseExamPaper_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_CourseExamPaper_GetCombineCondition(objvcc_CourseExamPaper_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId) == true) {
            const strComparisonOp_CourseExamPaperId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseExamPaperId, objvcc_CourseExamPaper_Cond.courseExamPaperId, strComparisonOp_CourseExamPaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseId, objvcc_CourseExamPaper_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseName, objvcc_CourseExamPaper_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperName) == true) {
            const strComparisonOp_ExamPaperName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperName, objvcc_CourseExamPaper_Cond.examPaperName, strComparisonOp_ExamPaperName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperIndex) == true) {
            const strComparisonOp_PaperIndex = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperIndex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperIndex, objvcc_CourseExamPaper_Cond.paperIndex, strComparisonOp_PaperIndex);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeId) == true) {
            const strComparisonOp_ExamPaperTypeId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeId, objvcc_CourseExamPaper_Cond.examPaperTypeId, strComparisonOp_ExamPaperTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeName) == true) {
            const strComparisonOp_ExamPaperTypeName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamPaperTypeName, objvcc_CourseExamPaper_Cond.examPaperTypeName, strComparisonOp_ExamPaperTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsShow) == true) {
            if (objvcc_CourseExamPaper_Cond.isShow == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsShow);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsShow);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_TotalScore) == true) {
            const strComparisonOp_TotalScore = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_TotalScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_TotalScore, objvcc_CourseExamPaper_Cond.totalScore, strComparisonOp_TotalScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ViewCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ViewCount, objvcc_CourseExamPaper_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DoneNumber) == true) {
            const strComparisonOp_DoneNumber = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DoneNumber, objvcc_CourseExamPaper_Cond.doneNumber, strComparisonOp_DoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperTime) == true) {
            const strComparisonOp_PaperTime = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperTime];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperTime, objvcc_CourseExamPaper_Cond.paperTime, strComparisonOp_PaperTime);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DownloadNumber) == true) {
            const strComparisonOp_DownloadNumber = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DownloadNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_DownloadNumber, objvcc_CourseExamPaper_Cond.downloadNumber, strComparisonOp_DownloadNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CollectionCount) == true) {
            const strComparisonOp_CollectionCount = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CollectionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CollectionCount, objvcc_CourseExamPaper_Cond.collectionCount, strComparisonOp_CollectionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_LikeCount) == true) {
            const strComparisonOp_LikeCount = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_LikeCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_LikeCount, objvcc_CourseExamPaper_Cond.likeCount, strComparisonOp_LikeCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_id_XzMajor, objvcc_CourseExamPaper_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_MajorName, objvcc_CourseExamPaper_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeId) == true) {
            const strComparisonOp_PaperDispModeId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeId, objvcc_CourseExamPaper_Cond.paperDispModeId, strComparisonOp_PaperDispModeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeName) == true) {
            const strComparisonOp_PaperDispModeName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_PaperDispModeName, objvcc_CourseExamPaper_Cond.paperDispModeName, strComparisonOp_PaperDispModeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamCreateTime) == true) {
            const strComparisonOp_ExamCreateTime = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamCreateTime];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ExamCreateTime, objvcc_CourseExamPaper_Cond.examCreateTime, strComparisonOp_ExamCreateTime);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CreateUserID) == true) {
            const strComparisonOp_CreateUserID = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CreateUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CreateUserID, objvcc_CourseExamPaper_Cond.createUserID, strComparisonOp_CreateUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UserName, objvcc_CourseExamPaper_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToAllStu) == true) {
            if (objvcc_CourseExamPaper_Cond.isOpenToAllStu == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToAllStu);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToAllStu);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSchool) == true) {
            if (objvcc_CourseExamPaper_Cond.isOpenToSchool == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSchool);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSchool);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSocial) == true) {
            if (objvcc_CourseExamPaper_Cond.isOpenToSocial == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSocial);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsOpenToSocial);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterId) == true) {
            const strComparisonOp_CourseChapterId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterId, objvcc_CourseExamPaper_Cond.courseChapterId, strComparisonOp_CourseChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterName) == true) {
            const strComparisonOp_CourseChapterName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_CourseChapterName, objvcc_CourseExamPaper_Cond.courseChapterName, strComparisonOp_CourseChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterId) == true) {
            const strComparisonOp_ChapterId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterId, objvcc_CourseExamPaper_Cond.chapterId, strComparisonOp_ChapterId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionId, objvcc_CourseExamPaper_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName) == true) {
            const strComparisonOp_ChapterName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName, objvcc_CourseExamPaper_Cond.chapterName, strComparisonOp_ChapterName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName, objvcc_CourseExamPaper_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName_Sim) == true) {
            const strComparisonOp_ChapterName_Sim = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_ChapterName_Sim, objvcc_CourseExamPaper_Cond.chapterName_Sim, strComparisonOp_ChapterName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName_Sim) == true) {
            const strComparisonOp_SectionName_Sim = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName_Sim];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_SectionName_Sim, objvcc_CourseExamPaper_Cond.sectionName_Sim, strComparisonOp_SectionName_Sim);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion) == true) {
            if (objvcc_CourseExamPaper_Cond.isAutoGeneQuestion == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsAutoGeneQuestion);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsCanMultiDo) == true) {
            if (objvcc_CourseExamPaper_Cond.isCanMultiDo == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsCanMultiDo);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_IsCanMultiDo);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdDate, objvcc_CourseExamPaper_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdUserId) == true) {
            const strComparisonOp_UpdUserId = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdUserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_UpdUserId, objvcc_CourseExamPaper_Cond.updUserId, strComparisonOp_UpdUserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_Memo, objvcc_CourseExamPaper_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_QuestionNum) == true) {
            const strComparisonOp_QuestionNum = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_QuestionNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_QuestionNum, objvcc_CourseExamPaper_Cond.questionNum, strComparisonOp_QuestionNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_CourseExamPaper_Cond.dicFldComparisonOp, clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_BigTopicNum) == true) {
            const strComparisonOp_BigTopicNum = objvcc_CourseExamPaper_Cond.dicFldComparisonOp[clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_BigTopicNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN.con_BigTopicNum, objvcc_CourseExamPaper_Cond.bigTopicNum, strComparisonOp_BigTopicNum);
        }
        return strWhereCond;
    }
    exports.vcc_CourseExamPaper_GetCombineCondition = vcc_CourseExamPaper_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_CourseExamPaperENS:源对象
     * @param objvcc_CourseExamPaperENT:目标对象
    */
    function vcc_CourseExamPaper_CopyObjTo(objvcc_CourseExamPaperENS, objvcc_CourseExamPaperENT) {
        objvcc_CourseExamPaperENT.courseExamPaperId = objvcc_CourseExamPaperENS.courseExamPaperId; //考卷流水号
        objvcc_CourseExamPaperENT.courseId = objvcc_CourseExamPaperENS.courseId; //课程Id
        objvcc_CourseExamPaperENT.courseName = objvcc_CourseExamPaperENS.courseName; //课程名称
        objvcc_CourseExamPaperENT.examPaperName = objvcc_CourseExamPaperENS.examPaperName; //考卷名称
        objvcc_CourseExamPaperENT.paperIndex = objvcc_CourseExamPaperENS.paperIndex; //试卷序号
        objvcc_CourseExamPaperENT.examPaperTypeId = objvcc_CourseExamPaperENS.examPaperTypeId; //试卷类型Id
        objvcc_CourseExamPaperENT.examPaperTypeName = objvcc_CourseExamPaperENS.examPaperTypeName; //试卷类型名称
        objvcc_CourseExamPaperENT.isShow = objvcc_CourseExamPaperENS.isShow; //是否启用
        objvcc_CourseExamPaperENT.totalScore = objvcc_CourseExamPaperENS.totalScore; //总得分
        objvcc_CourseExamPaperENT.viewCount = objvcc_CourseExamPaperENS.viewCount; //浏览量
        objvcc_CourseExamPaperENT.doneNumber = objvcc_CourseExamPaperENS.doneNumber; //已做人数
        objvcc_CourseExamPaperENT.paperTime = objvcc_CourseExamPaperENS.paperTime; //考试时间（分钟）
        objvcc_CourseExamPaperENT.downloadNumber = objvcc_CourseExamPaperENS.downloadNumber; //下载数目
        objvcc_CourseExamPaperENT.collectionCount = objvcc_CourseExamPaperENS.collectionCount; //收藏数量
        objvcc_CourseExamPaperENT.likeCount = objvcc_CourseExamPaperENS.likeCount; //资源喜欢数量
        objvcc_CourseExamPaperENT.id_XzMajor = objvcc_CourseExamPaperENS.id_XzMajor; //专业流水号
        objvcc_CourseExamPaperENT.majorName = objvcc_CourseExamPaperENS.majorName; //专业名称
        objvcc_CourseExamPaperENT.paperDispModeId = objvcc_CourseExamPaperENS.paperDispModeId; //试卷显示模式Id
        objvcc_CourseExamPaperENT.paperDispModeName = objvcc_CourseExamPaperENS.paperDispModeName; //试卷显示模式名称
        objvcc_CourseExamPaperENT.examCreateTime = objvcc_CourseExamPaperENS.examCreateTime; //考卷建立时间
        objvcc_CourseExamPaperENT.createUserID = objvcc_CourseExamPaperENS.createUserID; //建立用户ID
        objvcc_CourseExamPaperENT.userName = objvcc_CourseExamPaperENS.userName; //用户名
        objvcc_CourseExamPaperENT.isOpenToAllStu = objvcc_CourseExamPaperENS.isOpenToAllStu; //全校师生
        objvcc_CourseExamPaperENT.isOpenToSchool = objvcc_CourseExamPaperENS.isOpenToSchool; //全校师生公开
        objvcc_CourseExamPaperENT.isOpenToSocial = objvcc_CourseExamPaperENS.isOpenToSocial; //社会公众
        objvcc_CourseExamPaperENT.courseChapterId = objvcc_CourseExamPaperENS.courseChapterId; //课程章节ID
        objvcc_CourseExamPaperENT.courseChapterName = objvcc_CourseExamPaperENS.courseChapterName; //课程章节名称
        objvcc_CourseExamPaperENT.chapterId = objvcc_CourseExamPaperENS.chapterId; //章Id
        objvcc_CourseExamPaperENT.sectionId = objvcc_CourseExamPaperENS.sectionId; //节Id
        objvcc_CourseExamPaperENT.chapterName = objvcc_CourseExamPaperENS.chapterName; //章名
        objvcc_CourseExamPaperENT.sectionName = objvcc_CourseExamPaperENS.sectionName; //节名
        objvcc_CourseExamPaperENT.chapterName_Sim = objvcc_CourseExamPaperENS.chapterName_Sim; //章名简称
        objvcc_CourseExamPaperENT.sectionName_Sim = objvcc_CourseExamPaperENS.sectionName_Sim; //节名简称
        objvcc_CourseExamPaperENT.isAutoGeneQuestion = objvcc_CourseExamPaperENS.isAutoGeneQuestion; //是否自动生成题目
        objvcc_CourseExamPaperENT.isCanMultiDo = objvcc_CourseExamPaperENS.isCanMultiDo; //是否可以做多次
        objvcc_CourseExamPaperENT.updDate = objvcc_CourseExamPaperENS.updDate; //修改日期
        objvcc_CourseExamPaperENT.updUserId = objvcc_CourseExamPaperENS.updUserId; //修改用户Id
        objvcc_CourseExamPaperENT.memo = objvcc_CourseExamPaperENS.memo; //备注
        objvcc_CourseExamPaperENT.questionNum = objvcc_CourseExamPaperENS.questionNum; //题目数
        objvcc_CourseExamPaperENT.bigTopicNum = objvcc_CourseExamPaperENS.bigTopicNum; //大标题数
    }
    exports.vcc_CourseExamPaper_CopyObjTo = vcc_CourseExamPaper_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_CourseExamPaperENS:源对象
     * @param objvcc_CourseExamPaperENT:目标对象
    */
    function vcc_CourseExamPaper_GetObjFromJsonObj(objvcc_CourseExamPaperENS) {
        const objvcc_CourseExamPaperENT = new clsvcc_CourseExamPaperEN_js_1.clsvcc_CourseExamPaperEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_CourseExamPaperENT, objvcc_CourseExamPaperENS);
        return objvcc_CourseExamPaperENT;
    }
    exports.vcc_CourseExamPaper_GetObjFromJsonObj = vcc_CourseExamPaper_GetObjFromJsonObj;
});
