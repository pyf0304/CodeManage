/**
* 类名:clsvCurrEduClsTeacherWApi
* 表名:vCurrEduClsTeacher(01120128)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:45
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:日常运行(DailyRunning)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduClsTeacher_GetObjFromJsonObj = exports.vCurrEduClsTeacher_CopyObjTo = exports.vCurrEduClsTeacher_GetCombineCondition = exports.vCurrEduClsTeacher_GetObjByJSONStr = exports.vCurrEduClsTeacher_GetObjLstByJSONObjLst = exports.vCurrEduClsTeacher_GetObjLstByJSONStr = exports.vCurrEduClsTeacher_GetJSONStrByObj = exports.vCurrEduClsTeacher_ReFreshThisCache = exports.vCurrEduClsTeacher_GetWebApiUrl = exports.vCurrEduClsTeacher_GetRecCountByCond_Cache = exports.vCurrEduClsTeacher_GetRecCountByCondAsync = exports.vCurrEduClsTeacher_IsExistAsync = exports.vCurrEduClsTeacher_IsExist_Cache = exports.vCurrEduClsTeacher_IsExist = exports.vCurrEduClsTeacher_IsExistRecordAsync = exports.vCurrEduClsTeacher_IsExistRecord_Cache = exports.vCurrEduClsTeacher_GetObjLstByPagerAsync = exports.vCurrEduClsTeacher_GetObjLstByPager_Cache = exports.vCurrEduClsTeacher_GetObjLstByRange = exports.vCurrEduClsTeacher_GetObjLstByRangeAsync = exports.vCurrEduClsTeacher_GetTopObjLstAsync = exports.vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache = exports.vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync = exports.vCurrEduClsTeacher_GetSubObjLst_Cache = exports.vCurrEduClsTeacher_GetObjLst_PureCache = exports.vCurrEduClsTeacher_GetObjLst_Cache = exports.vCurrEduClsTeacher_GetObjLst_sessionStorage_PureCache = exports.vCurrEduClsTeacher_GetObjLst_sessionStorage = exports.vCurrEduClsTeacher_GetObjLstAsync = exports.vCurrEduClsTeacher_GetObjLst_localStorage_PureCache = exports.vCurrEduClsTeacher_GetObjLst_localStorage = exports.vCurrEduClsTeacher_GetObjLst_ClientCache = exports.vCurrEduClsTeacher_GetFirstObjAsync = exports.vCurrEduClsTeacher_GetFirstID = exports.vCurrEduClsTeacher_GetFirstIDAsync = exports.vCurrEduClsTeacher_funcKey = exports.vCurrEduClsTeacher_FilterFunByKey = exports.vCurrEduClsTeacher_SortFunByKey = exports.vCurrEduClsTeacher_SortFun_Defa_2Fld = exports.vCurrEduClsTeacher_SortFun_Defa = exports.vCurrEduClsTeacher_func = exports.vCurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage = exports.vCurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache = exports.vCurrEduClsTeacher_GetObjByid_EduClsTeacherAsync = exports.vCurrEduClsTeacher_ConstructorName = exports.vCurrEduClsTeacher_Controller = void 0;
    /**
     * v当前教学班教师(vCurrEduClsTeacher)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvCurrEduClsTeacherEN_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsTeacherEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vCurrEduClsTeacher_Controller = "vCurrEduClsTeacherApi";
    exports.vCurrEduClsTeacher_ConstructorName = "vCurrEduClsTeacher";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngid_EduClsTeacher:关键字
    * @returns 对象
    **/
    async function vCurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher) {
        const strThisFuncName = "GetObjByid_EduClsTeacherAsync";
        if (lngid_EduClsTeacher == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsTeacher]不能为空！(In clsvCurrEduClsTeacherWApi.GetObjByid_EduClsTeacherAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_EduClsTeacher";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngid_EduClsTeacher": lngid_EduClsTeacher,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvCurrEduClsTeacher = vCurrEduClsTeacher_GetObjFromJsonObj(returnObj);
                return objvCurrEduClsTeacher;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetObjByid_EduClsTeacherAsync = vCurrEduClsTeacher_GetObjByid_EduClsTeacherAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngid_EduClsTeacher:所给的关键字
     * @returns 对象
    */
    async function vCurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache(lngid_EduClsTeacher, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_EduClsTeacher_Cache";
        if (lngid_EduClsTeacher == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsTeacher]不能为空！(In clsvCurrEduClsTeacherWApi.GetObjByid_EduClsTeacher_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache.filter(x => x.id_EduClsTeacher == lngid_EduClsTeacher);
            let objvCurrEduClsTeacher;
            if (arrvCurrEduClsTeacher_Sel.length > 0) {
                objvCurrEduClsTeacher = arrvCurrEduClsTeacher_Sel[0];
                return objvCurrEduClsTeacher;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvCurrEduClsTeacher_Const = await vCurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
                    if (objvCurrEduClsTeacher_Const != null) {
                        vCurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls);
                        return objvCurrEduClsTeacher_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsTeacher, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vCurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache = vCurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngid_EduClsTeacher:所给的关键字
     * @returns 对象
    */
    async function vCurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage(lngid_EduClsTeacher) {
        const strThisFuncName = "GetObjByid_EduClsTeacher_localStorage";
        if (lngid_EduClsTeacher == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsTeacher]不能为空！(In clsvCurrEduClsTeacherWApi.GetObjByid_EduClsTeacher_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, lngid_EduClsTeacher);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvCurrEduClsTeacher_Cache = JSON.parse(strTempObj);
            return objvCurrEduClsTeacher_Cache;
        }
        try {
            const objvCurrEduClsTeacher = await vCurrEduClsTeacher_GetObjByid_EduClsTeacherAsync(lngid_EduClsTeacher);
            if (objvCurrEduClsTeacher != null) {
                localStorage.setItem(strKey, JSON.stringify(objvCurrEduClsTeacher));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvCurrEduClsTeacher;
            }
            return objvCurrEduClsTeacher;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsTeacher, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vCurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage = vCurrEduClsTeacher_GetObjByid_EduClsTeacher_localStorage;
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
    async function vCurrEduClsTeacher_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvCurrEduClsTeacherWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvCurrEduClsTeacherWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngid_EduClsTeacher = Number(strInValue);
        if (lngid_EduClsTeacher == 0) {
            return "";
        }
        const objvCurrEduClsTeacher = await vCurrEduClsTeacher_GetObjByid_EduClsTeacher_Cache(lngid_EduClsTeacher, strid_CurrEduCls_C);
        if (objvCurrEduClsTeacher == null)
            return "";
        if (objvCurrEduClsTeacher.GetFldValue(strOutFldName) == null)
            return "";
        return objvCurrEduClsTeacher.GetFldValue(strOutFldName).toString();
    }
    exports.vCurrEduClsTeacher_func = vCurrEduClsTeacher_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsTeacher_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_EduClsTeacher - b.id_EduClsTeacher;
    }
    exports.vCurrEduClsTeacher_SortFun_Defa = vCurrEduClsTeacher_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsTeacher_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_CurrEduCls == b.id_CurrEduCls)
            return a.currEduClsId.localeCompare(b.currEduClsId);
        else
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.vCurrEduClsTeacher_SortFun_Defa_2Fld = vCurrEduClsTeacher_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsTeacher_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
                    return (a, b) => {
                        return a.id_EduClsTeacher - b.id_EduClsTeacher;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrEduClsId:
                    return (a, b) => {
                        if (a.currEduClsId == null)
                            return -1;
                        if (b.currEduClsId == null)
                            return 1;
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeId:
                    return (a, b) => {
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeName:
                    return (a, b) => {
                        if (a.eduClsTypeName == null)
                            return -1;
                        if (b.eduClsTypeName == null)
                            return 1;
                        return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (a.exampleImgPath == null)
                            return -1;
                        if (b.exampleImgPath == null)
                            return 1;
                        return a.exampleImgPath.localeCompare(b.exampleImgPath);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
                    return (a, b) => {
                        if (a.teachingSolutionId == null)
                            return -1;
                        if (b.teachingSolutionId == null)
                            return 1;
                        return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
                    return (a, b) => {
                        if (a.teachingSolutionName == null)
                            return -1;
                        if (b.teachingSolutionName == null)
                            return 1;
                        return a.teachingSolutionName.localeCompare(b.teachingSolutionName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduWay:
                    return (a, b) => {
                        if (a.id_EduWay == null)
                            return -1;
                        if (b.id_EduWay == null)
                            return 1;
                        return a.id_EduWay.localeCompare(b.id_EduWay);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TotalLessonQty:
                    return (a, b) => {
                        return a.totalLessonQty - b.totalLessonQty;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_MaxStuQty:
                    return (a, b) => {
                        return a.maxStuQty - b.maxStuQty;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekQty:
                    return (a, b) => {
                        return a.weekQty - b.weekQty;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ScheUnitPW:
                    return (a, b) => {
                        return a.scheUnitPW - b.scheUnitPW;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekStatusID:
                    return (a, b) => {
                        if (a.weekStatusID == null)
                            return -1;
                        if (b.weekStatusID == null)
                            return 1;
                        return a.weekStatusID.localeCompare(b.weekStatusID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CustomerWeek:
                    return (a, b) => {
                        if (a.customerWeek == null)
                            return -1;
                        if (b.customerWeek == null)
                            return 1;
                        return a.customerWeek.localeCompare(b.customerWeek);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return a.lessonQtyPerWeek - b.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_UniZone:
                    return (a, b) => {
                        if (a.id_UniZone == null)
                            return -1;
                        if (b.id_UniZone == null)
                            return 1;
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_GradeBase:
                    return (a, b) => {
                        if (a.id_GradeBase == null)
                            return -1;
                        if (b.id_GradeBase == null)
                            return 1;
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseID:
                    return (a, b) => {
                        if (a.gradeBaseID == null)
                            return -1;
                        if (b.gradeBaseID == null)
                            return 1;
                        return a.gradeBaseID.localeCompare(b.gradeBaseID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseName:
                    return (a, b) => {
                        if (a.gradeBaseName == null)
                            return -1;
                        if (b.gradeBaseName == null)
                            return 1;
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CourseType:
                    return (a, b) => {
                        if (a.id_CourseType == null)
                            return -1;
                        if (b.id_CourseType == null)
                            return 1;
                        return a.id_CourseType.localeCompare(b.id_CourseType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeID:
                    return (a, b) => {
                        if (a.courseTypeID == null)
                            return -1;
                        if (b.courseTypeID == null)
                            return 1;
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeName:
                    return (a, b) => {
                        if (a.courseTypeName == null)
                            return -1;
                        if (b.courseTypeName == null)
                            return 1;
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsDegree:
                    return (a, b) => {
                        if (a.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ScoreType:
                    return (a, b) => {
                        if (a.id_ScoreType == null)
                            return -1;
                        if (b.id_ScoreType == null)
                            return 1;
                        return a.id_ScoreType.localeCompare(b.id_ScoreType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (a.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ExamType:
                    return (a, b) => {
                        if (a.id_ExamType == null)
                            return -1;
                        if (b.id_ExamType == null)
                            return 1;
                        return a.id_ExamType.localeCompare(b.id_ExamType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_BeginWeek:
                    return (a, b) => {
                        return a.beginWeek - b.beginWeek;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
                    return (a, b) => {
                        return a.currStuNum_Valid - b.currStuNum_Valid;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum:
                    return (a, b) => {
                        return a.currStuNum - b.currStuNum;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Teacher:
                    return (a, b) => {
                        if (a.id_Teacher == null)
                            return -1;
                        if (b.id_Teacher == null)
                            return 1;
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherID:
                    return (a, b) => {
                        if (a.teacherID == null)
                            return -1;
                        if (b.teacherID == null)
                            return 1;
                        return a.teacherID.localeCompare(b.teacherID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherName:
                    return (a, b) => {
                        if (a.teacherName == null)
                            return -1;
                        if (b.teacherName == null)
                            return 1;
                        return a.teacherName.localeCompare(b.teacherName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ProfGrade:
                    return (a, b) => {
                        if (a.id_ProfGrade == null)
                            return -1;
                        if (b.id_ProfGrade == null)
                            return 1;
                        return a.id_ProfGrade.localeCompare(b.id_ProfGrade);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
                    return (a, b) => {
                        if (a.profenssionalGradeName == null)
                            return -1;
                        if (b.profenssionalGradeName == null)
                            return 1;
                        return a.profenssionalGradeName.localeCompare(b.profenssionalGradeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_DegreeName:
                    return (a, b) => {
                        if (a.degreeName == null)
                            return -1;
                        if (b.degreeName == null)
                            return 1;
                        return a.degreeName.localeCompare(b.degreeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Birthday:
                    return (a, b) => {
                        if (a.birthday == null)
                            return -1;
                        if (b.birthday == null)
                            return 1;
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                    return (a, b) => {
                        return a.id_Pk2EduClsTeacherType.localeCompare(b.id_Pk2EduClsTeacherType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
                    return (a, b) => {
                        if (a.eduClsTeacherTypeID == null)
                            return -1;
                        if (b.eduClsTeacherTypeID == null)
                            return 1;
                        return a.eduClsTeacherTypeID.localeCompare(b.eduClsTeacherTypeID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
                    return (a, b) => {
                        if (a.eduClsTeacherTypeDesc == null)
                            return -1;
                        if (b.eduClsTeacherTypeDesc == null)
                            return 1;
                        return a.eduClsTeacherTypeDesc.localeCompare(b.eduClsTeacherTypeDesc);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolTerm:
                    return (a, b) => {
                        if (a.schoolTerm == null)
                            return -1;
                        if (b.schoolTerm == null)
                            return 1;
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolYear:
                    return (a, b) => {
                        if (a.schoolYear == null)
                            return -1;
                        if (b.schoolYear == null)
                            return 1;
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenBeginDate:
                    return (a, b) => {
                        if (a.openBeginDate == null)
                            return -1;
                        if (b.openBeginDate == null)
                            return 1;
                        return a.openBeginDate.localeCompare(b.openBeginDate);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenEndDate:
                    return (a, b) => {
                        if (a.openEndDate == null)
                            return -1;
                        if (b.openEndDate == null)
                            return 1;
                        return a.openEndDate.localeCompare(b.openEndDate);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
                    return (a, b) => {
                        if (a.collegeName4EduCls == null)
                            return -1;
                        if (b.collegeName4EduCls == null)
                            return 1;
                        return a.collegeName4EduCls.localeCompare(b.collegeName4EduCls);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
                    return (a, b) => {
                        if (a.collegeName4Teacher == null)
                            return -1;
                        if (b.collegeName4Teacher == null)
                            return 1;
                        return a.collegeName4Teacher.localeCompare(b.collegeName4Teacher);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsTeacher]中不存在！(in ${exports.vCurrEduClsTeacher_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
                    return (a, b) => {
                        return b.id_EduClsTeacher - a.id_EduClsTeacher;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrEduClsId:
                    return (a, b) => {
                        if (b.currEduClsId == null)
                            return -1;
                        if (a.currEduClsId == null)
                            return 1;
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeId:
                    return (a, b) => {
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeName:
                    return (a, b) => {
                        if (b.eduClsTypeName == null)
                            return -1;
                        if (a.eduClsTypeName == null)
                            return 1;
                        return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ExampleImgPath:
                    return (a, b) => {
                        if (b.exampleImgPath == null)
                            return -1;
                        if (a.exampleImgPath == null)
                            return 1;
                        return b.exampleImgPath.localeCompare(a.exampleImgPath);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
                    return (a, b) => {
                        if (b.teachingSolutionId == null)
                            return -1;
                        if (a.teachingSolutionId == null)
                            return 1;
                        return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
                    return (a, b) => {
                        if (b.teachingSolutionName == null)
                            return -1;
                        if (a.teachingSolutionName == null)
                            return 1;
                        return b.teachingSolutionName.localeCompare(a.teachingSolutionName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduWay:
                    return (a, b) => {
                        if (b.id_EduWay == null)
                            return -1;
                        if (a.id_EduWay == null)
                            return 1;
                        return b.id_EduWay.localeCompare(a.id_EduWay);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TotalLessonQty:
                    return (a, b) => {
                        return b.totalLessonQty - a.totalLessonQty;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_MaxStuQty:
                    return (a, b) => {
                        return b.maxStuQty - a.maxStuQty;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekQty:
                    return (a, b) => {
                        return b.weekQty - a.weekQty;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ScheUnitPW:
                    return (a, b) => {
                        return b.scheUnitPW - a.scheUnitPW;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekStatusID:
                    return (a, b) => {
                        if (b.weekStatusID == null)
                            return -1;
                        if (a.weekStatusID == null)
                            return 1;
                        return b.weekStatusID.localeCompare(a.weekStatusID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CustomerWeek:
                    return (a, b) => {
                        if (b.customerWeek == null)
                            return -1;
                        if (a.customerWeek == null)
                            return 1;
                        return b.customerWeek.localeCompare(a.customerWeek);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return b.lessonQtyPerWeek - a.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_UniZone:
                    return (a, b) => {
                        if (b.id_UniZone == null)
                            return -1;
                        if (a.id_UniZone == null)
                            return 1;
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_GradeBase:
                    return (a, b) => {
                        if (b.id_GradeBase == null)
                            return -1;
                        if (a.id_GradeBase == null)
                            return 1;
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseID:
                    return (a, b) => {
                        if (b.gradeBaseID == null)
                            return -1;
                        if (a.gradeBaseID == null)
                            return 1;
                        return b.gradeBaseID.localeCompare(a.gradeBaseID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseName:
                    return (a, b) => {
                        if (b.gradeBaseName == null)
                            return -1;
                        if (a.gradeBaseName == null)
                            return 1;
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CourseType:
                    return (a, b) => {
                        if (b.id_CourseType == null)
                            return -1;
                        if (a.id_CourseType == null)
                            return 1;
                        return b.id_CourseType.localeCompare(a.id_CourseType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeID:
                    return (a, b) => {
                        if (b.courseTypeID == null)
                            return -1;
                        if (a.courseTypeID == null)
                            return 1;
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeName:
                    return (a, b) => {
                        if (b.courseTypeName == null)
                            return -1;
                        if (a.courseTypeName == null)
                            return 1;
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsDegree:
                    return (a, b) => {
                        if (b.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ScoreType:
                    return (a, b) => {
                        if (b.id_ScoreType == null)
                            return -1;
                        if (a.id_ScoreType == null)
                            return 1;
                        return b.id_ScoreType.localeCompare(a.id_ScoreType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (b.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ExamType:
                    return (a, b) => {
                        if (b.id_ExamType == null)
                            return -1;
                        if (a.id_ExamType == null)
                            return 1;
                        return b.id_ExamType.localeCompare(a.id_ExamType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_BeginWeek:
                    return (a, b) => {
                        return b.beginWeek - a.beginWeek;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
                    return (a, b) => {
                        return b.currStuNum_Valid - a.currStuNum_Valid;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum:
                    return (a, b) => {
                        return b.currStuNum - a.currStuNum;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Teacher:
                    return (a, b) => {
                        if (b.id_Teacher == null)
                            return -1;
                        if (a.id_Teacher == null)
                            return 1;
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherID:
                    return (a, b) => {
                        if (b.teacherID == null)
                            return -1;
                        if (a.teacherID == null)
                            return 1;
                        return b.teacherID.localeCompare(a.teacherID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherName:
                    return (a, b) => {
                        if (b.teacherName == null)
                            return -1;
                        if (a.teacherName == null)
                            return 1;
                        return b.teacherName.localeCompare(a.teacherName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ProfGrade:
                    return (a, b) => {
                        if (b.id_ProfGrade == null)
                            return -1;
                        if (a.id_ProfGrade == null)
                            return 1;
                        return b.id_ProfGrade.localeCompare(a.id_ProfGrade);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
                    return (a, b) => {
                        if (b.profenssionalGradeName == null)
                            return -1;
                        if (a.profenssionalGradeName == null)
                            return 1;
                        return b.profenssionalGradeName.localeCompare(a.profenssionalGradeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_DegreeName:
                    return (a, b) => {
                        if (b.degreeName == null)
                            return -1;
                        if (a.degreeName == null)
                            return 1;
                        return b.degreeName.localeCompare(a.degreeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Birthday:
                    return (a, b) => {
                        if (b.birthday == null)
                            return -1;
                        if (a.birthday == null)
                            return 1;
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                    return (a, b) => {
                        return b.id_Pk2EduClsTeacherType.localeCompare(a.id_Pk2EduClsTeacherType);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
                    return (a, b) => {
                        if (b.eduClsTeacherTypeID == null)
                            return -1;
                        if (a.eduClsTeacherTypeID == null)
                            return 1;
                        return b.eduClsTeacherTypeID.localeCompare(a.eduClsTeacherTypeID);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
                    return (a, b) => {
                        if (b.eduClsTeacherTypeDesc == null)
                            return -1;
                        if (a.eduClsTeacherTypeDesc == null)
                            return 1;
                        return b.eduClsTeacherTypeDesc.localeCompare(a.eduClsTeacherTypeDesc);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolTerm:
                    return (a, b) => {
                        if (b.schoolTerm == null)
                            return -1;
                        if (a.schoolTerm == null)
                            return 1;
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolYear:
                    return (a, b) => {
                        if (b.schoolYear == null)
                            return -1;
                        if (a.schoolYear == null)
                            return 1;
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenBeginDate:
                    return (a, b) => {
                        if (b.openBeginDate == null)
                            return -1;
                        if (a.openBeginDate == null)
                            return 1;
                        return b.openBeginDate.localeCompare(a.openBeginDate);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenEndDate:
                    return (a, b) => {
                        if (b.openEndDate == null)
                            return -1;
                        if (a.openEndDate == null)
                            return 1;
                        return b.openEndDate.localeCompare(a.openEndDate);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
                    return (a, b) => {
                        if (b.collegeName4EduCls == null)
                            return -1;
                        if (a.collegeName4EduCls == null)
                            return 1;
                        return b.collegeName4EduCls.localeCompare(a.collegeName4EduCls);
                    };
                case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
                    return (a, b) => {
                        if (b.collegeName4Teacher == null)
                            return -1;
                        if (a.collegeName4Teacher == null)
                            return 1;
                        return b.collegeName4Teacher.localeCompare(a.collegeName4Teacher);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsTeacher]中不存在！(in ${exports.vCurrEduClsTeacher_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vCurrEduClsTeacher_SortFunByKey = vCurrEduClsTeacher_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduClsTeacher_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher:
                return (obj) => {
                    return obj.id_EduClsTeacher === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeName:
                return (obj) => {
                    return obj.eduClsTypeName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ExampleImgPath:
                return (obj) => {
                    return obj.exampleImgPath === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionId:
                return (obj) => {
                    return obj.teachingSolutionId === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionName:
                return (obj) => {
                    return obj.teachingSolutionName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduWay:
                return (obj) => {
                    return obj.id_EduWay === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TotalLessonQty:
                return (obj) => {
                    return obj.totalLessonQty === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_MaxStuQty:
                return (obj) => {
                    return obj.maxStuQty === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekQty:
                return (obj) => {
                    return obj.weekQty === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ScheUnitPW:
                return (obj) => {
                    return obj.scheUnitPW === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekStatusID:
                return (obj) => {
                    return obj.weekStatusID === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CustomerWeek:
                return (obj) => {
                    return obj.customerWeek === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_LessonQtyPerWeek:
                return (obj) => {
                    return obj.lessonQtyPerWeek === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseID:
                return (obj) => {
                    return obj.gradeBaseID === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CourseType:
                return (obj) => {
                    return obj.id_CourseType === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsDegree:
                return (obj) => {
                    return obj.isDegree === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ScoreType:
                return (obj) => {
                    return obj.id_ScoreType === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsProportionalCtrl:
                return (obj) => {
                    return obj.isProportionalCtrl === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ExamType:
                return (obj) => {
                    return obj.id_ExamType === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_BeginWeek:
                return (obj) => {
                    return obj.beginWeek === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid:
                return (obj) => {
                    return obj.currStuNum_Valid === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum:
                return (obj) => {
                    return obj.currStuNum === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherID:
                return (obj) => {
                    return obj.teacherID === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherName:
                return (obj) => {
                    return obj.teacherName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ProfGrade:
                return (obj) => {
                    return obj.id_ProfGrade === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName:
                return (obj) => {
                    return obj.profenssionalGradeName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_DegreeName:
                return (obj) => {
                    return obj.degreeName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType:
                return (obj) => {
                    return obj.id_Pk2EduClsTeacherType === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID:
                return (obj) => {
                    return obj.eduClsTeacherTypeID === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc:
                return (obj) => {
                    return obj.eduClsTeacherTypeDesc === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenBeginDate:
                return (obj) => {
                    return obj.openBeginDate === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenEndDate:
                return (obj) => {
                    return obj.openEndDate === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4EduCls:
                return (obj) => {
                    return obj.collegeName4EduCls === value;
                };
            case clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4Teacher:
                return (obj) => {
                    return obj.collegeName4Teacher === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsTeacher]中不存在！(in ${exports.vCurrEduClsTeacher_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vCurrEduClsTeacher_FilterFunByKey = vCurrEduClsTeacher_FilterFunByKey;
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
    async function vCurrEduClsTeacher_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvCurrEduClsTeacherWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvCurrEduClsTeacherWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvCurrEduClsTeacher = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvCurrEduClsTeacher == null)
            return [];
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvCurrEduClsTeacher_Sel.length == 0)
            return [];
        return arrvCurrEduClsTeacher_Sel.map(x => x.id_EduClsTeacher);
    }
    exports.vCurrEduClsTeacher_funcKey = vCurrEduClsTeacher_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vCurrEduClsTeacher_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetFirstIDAsync = vCurrEduClsTeacher_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vCurrEduClsTeacher_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetFirstID = vCurrEduClsTeacher_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vCurrEduClsTeacher_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
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
                const objvCurrEduClsTeacher = vCurrEduClsTeacher_GetObjFromJsonObj(returnObj);
                return objvCurrEduClsTeacher;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetFirstObjAsync = vCurrEduClsTeacher_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvCurrEduClsTeacherExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvCurrEduClsTeacherObjLst_T = vCurrEduClsTeacher_GetObjLstByJSONObjLst(arrvCurrEduClsTeacherExObjLst_Cache);
            return arrvCurrEduClsTeacherObjLst_T;
        }
        try {
            const arrvCurrEduClsTeacherExObjLst = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvCurrEduClsTeacherExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsTeacherExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsTeacherExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduClsTeacher_GetObjLst_ClientCache = vCurrEduClsTeacher_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduClsTeacherExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduClsTeacherObjLst_T = vCurrEduClsTeacher_GetObjLstByJSONObjLst(arrvCurrEduClsTeacherExObjLst_Cache);
            return arrvCurrEduClsTeacherObjLst_T;
        }
        try {
            const arrvCurrEduClsTeacherExObjLst = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsTeacherExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsTeacherExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsTeacherExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduClsTeacher_GetObjLst_localStorage = vCurrEduClsTeacher_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduClsTeacherObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduClsTeacherObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduClsTeacher_GetObjLst_localStorage_PureCache = vCurrEduClsTeacher_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetObjLstAsync = vCurrEduClsTeacher_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduClsTeacherExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduClsTeacherObjLst_T = vCurrEduClsTeacher_GetObjLstByJSONObjLst(arrvCurrEduClsTeacherExObjLst_Cache);
            return arrvCurrEduClsTeacherObjLst_T;
        }
        try {
            const arrvCurrEduClsTeacherExObjLst = await vCurrEduClsTeacher_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsTeacherExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsTeacherExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsTeacherExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduClsTeacher_GetObjLst_sessionStorage = vCurrEduClsTeacher_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduClsTeacherObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduClsTeacherObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduClsTeacher_GetObjLst_sessionStorage_PureCache = vCurrEduClsTeacher_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvCurrEduClsTeacherWApi.vCurrEduClsTeacher_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvCurrEduClsTeacherWApi.vCurrEduClsTeacher_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvCurrEduClsTeacherObjLst_Cache;
        switch (clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvCurrEduClsTeacherObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst(arrvCurrEduClsTeacherObjLst_Cache);
        return arrvCurrEduClsTeacherObjLst_Cache;
    }
    exports.vCurrEduClsTeacher_GetObjLst_Cache = vCurrEduClsTeacher_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvCurrEduClsTeacherObjLst_Cache;
        switch (clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvCurrEduClsTeacherObjLst_Cache = null;
                break;
            default:
                arrvCurrEduClsTeacherObjLst_Cache = null;
                break;
        }
        return arrvCurrEduClsTeacherObjLst_Cache;
    }
    exports.vCurrEduClsTeacher_GetObjLst_PureCache = vCurrEduClsTeacher_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngid_EduClsTeacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduClsTeacher_GetSubObjLst_Cache(objvCurrEduClsTeacher_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache;
        if (objvCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objvCurrEduClsTeacher_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduClsTeacher_Sel;
        const dicFldComparisonOp = JSON.parse(objvCurrEduClsTeacher_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduClsTeacher_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduClsTeacher_Cond), exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsTeacher_GetSubObjLst_Cache = vCurrEduClsTeacher_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_EduClsTeacher:关键字列表
    * @returns 对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync(arrid_EduClsTeacher) {
        const strThisFuncName = "GetObjLstByid_EduClsTeacherLstAsync";
        const strAction = "GetObjLstByid_EduClsTeacherLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_EduClsTeacher);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync = vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngid_EduClsTeacherLst:关键字列表
     * @returns 对象列表
    */
    async function vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache(arrid_EduClsTeacherLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByid_EduClsTeacherLst_Cache";
        try {
            const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
            const arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache.filter(x => arrid_EduClsTeacherLst.indexOf(x.id_EduClsTeacher) > -1);
            return arrvCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_EduClsTeacherLst.join(","), exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache = vCurrEduClsTeacher_GetObjLstByid_EduClsTeacherLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduClsTeacher_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetTopObjLstAsync = vCurrEduClsTeacher_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetObjLstByRangeAsync = vCurrEduClsTeacher_GetObjLstByRangeAsync;
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
    async function vCurrEduClsTeacher_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetObjLstByRange = vCurrEduClsTeacher_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduClsTeacher_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsTeacherObjLst_Cache.length == 0)
            return arrvCurrEduClsTeacherObjLst_Cache;
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvCurrEduClsTeacher_Cond = new clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsTeacher_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvCurrEduClsTeacherWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduClsTeacher_Sel.length == 0)
                return arrvCurrEduClsTeacher_Sel;
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
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(vCurrEduClsTeacher_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.slice(intStart, intEnd);
            return arrvCurrEduClsTeacher_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsTeacher_GetObjLstByPager_Cache = vCurrEduClsTeacher_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduClsTeacher_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetObjLstByPagerAsync = vCurrEduClsTeacher_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngid_EduClsTeacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduClsTeacher_IsExistRecord_Cache(objvCurrEduClsTeacher_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsTeacherObjLst_Cache == null)
            return false;
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache;
        if (objvCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objvCurrEduClsTeacher_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduClsTeacher_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvCurrEduClsTeacher_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduClsTeacher_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduClsTeacher_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvCurrEduClsTeacher_Cond), exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vCurrEduClsTeacher_IsExistRecord_Cache = vCurrEduClsTeacher_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vCurrEduClsTeacher_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_IsExistRecordAsync = vCurrEduClsTeacher_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngid_EduClsTeacher:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vCurrEduClsTeacher_IsExist(lngid_EduClsTeacher, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_EduClsTeacher": lngid_EduClsTeacher,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_IsExist = vCurrEduClsTeacher_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngid_EduClsTeacher:所给的关键字
     * @returns 对象
    */
    async function vCurrEduClsTeacher_IsExist_Cache(lngid_EduClsTeacher, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsTeacherObjLst_Cache == null)
            return false;
        try {
            const arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache.filter(x => x.id_EduClsTeacher == lngid_EduClsTeacher);
            if (arrvCurrEduClsTeacher_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngid_EduClsTeacher, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vCurrEduClsTeacher_IsExist_Cache = vCurrEduClsTeacher_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngid_EduClsTeacher:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vCurrEduClsTeacher_IsExistAsync(lngid_EduClsTeacher) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngid_EduClsTeacher": lngid_EduClsTeacher }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_IsExistAsync = vCurrEduClsTeacher_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vCurrEduClsTeacher_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsTeacher_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsTeacher_GetRecCountByCondAsync = vCurrEduClsTeacher_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvCurrEduClsTeacher_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vCurrEduClsTeacher_GetRecCountByCond_Cache(objvCurrEduClsTeacher_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvCurrEduClsTeacherObjLst_Cache = await vCurrEduClsTeacher_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsTeacherObjLst_Cache == null)
            return 0;
        let arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacherObjLst_Cache;
        if (objvCurrEduClsTeacher_Cond.sf_FldComparisonOp == null || objvCurrEduClsTeacher_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduClsTeacher_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvCurrEduClsTeacher_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsTeacherWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduClsTeacher_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsTeacher_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsTeacher_Sel = arrvCurrEduClsTeacher_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduClsTeacher_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduClsTeacher_Cond), exports.vCurrEduClsTeacher_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vCurrEduClsTeacher_GetRecCountByCond_Cache = vCurrEduClsTeacher_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vCurrEduClsTeacher_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduClsTeacher_GetWebApiUrl = vCurrEduClsTeacher_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vCurrEduClsTeacher_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN._CurrTabName, strid_CurrEduCls);
            switch (clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.CacheModeId) {
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
    exports.vCurrEduClsTeacher_ReFreshThisCache = vCurrEduClsTeacher_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduClsTeacher_GetJSONStrByObj(pobjvCurrEduClsTeacherEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvCurrEduClsTeacherEN);
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
    exports.vCurrEduClsTeacher_GetJSONStrByObj = vCurrEduClsTeacher_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduClsTeacher_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvCurrEduClsTeacherObjLst = new Array();
        if (strJSON === "") {
            return arrvCurrEduClsTeacherObjLst;
        }
        try {
            arrvCurrEduClsTeacherObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvCurrEduClsTeacherObjLst;
        }
        return arrvCurrEduClsTeacherObjLst;
    }
    exports.vCurrEduClsTeacher_GetObjLstByJSONStr = vCurrEduClsTeacher_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvCurrEduClsTeacherObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduClsTeacher_GetObjLstByJSONObjLst(arrvCurrEduClsTeacherObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvCurrEduClsTeacherObjLst = new Array();
        for (const objInFor of arrvCurrEduClsTeacherObjLstS) {
            const obj1 = vCurrEduClsTeacher_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvCurrEduClsTeacherObjLst.push(obj1);
        }
        return arrvCurrEduClsTeacherObjLst;
    }
    exports.vCurrEduClsTeacher_GetObjLstByJSONObjLst = vCurrEduClsTeacher_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduClsTeacher_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvCurrEduClsTeacherEN = new clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN();
        if (strJSON === "") {
            return pobjvCurrEduClsTeacherEN;
        }
        try {
            pobjvCurrEduClsTeacherEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvCurrEduClsTeacherEN;
        }
        return pobjvCurrEduClsTeacherEN;
    }
    exports.vCurrEduClsTeacher_GetObjByJSONStr = vCurrEduClsTeacher_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vCurrEduClsTeacher_GetCombineCondition(objvCurrEduClsTeacher_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher) == true) {
            const strComparisonOp_id_EduClsTeacher = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduClsTeacher, objvCurrEduClsTeacher_Cond.id_EduClsTeacher, strComparisonOp_id_EduClsTeacher);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CurrEduCls, objvCurrEduClsTeacher_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrEduClsId, objvCurrEduClsTeacher_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsName, objvCurrEduClsTeacher_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeId, objvCurrEduClsTeacher_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeName) == true) {
            const strComparisonOp_EduClsTypeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTypeName, objvCurrEduClsTeacher_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseId, objvCurrEduClsTeacher_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseCode, objvCurrEduClsTeacher_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseName, objvCurrEduClsTeacher_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ExampleImgPath) == true) {
            const strComparisonOp_ExampleImgPath = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ExampleImgPath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ExampleImgPath, objvCurrEduClsTeacher_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionId) == true) {
            const strComparisonOp_TeachingSolutionId = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionId, objvCurrEduClsTeacher_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionName) == true) {
            const strComparisonOp_TeachingSolutionName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeachingSolutionName, objvCurrEduClsTeacher_Cond.teachingSolutionName, strComparisonOp_TeachingSolutionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_XzCollege, objvCurrEduClsTeacher_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeID, objvCurrEduClsTeacher_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduWay) == true) {
            const strComparisonOp_id_EduWay = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduWay];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_EduWay, objvCurrEduClsTeacher_Cond.id_EduWay, strComparisonOp_id_EduWay);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TotalLessonQty) == true) {
            const strComparisonOp_TotalLessonQty = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TotalLessonQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TotalLessonQty, objvCurrEduClsTeacher_Cond.totalLessonQty, strComparisonOp_TotalLessonQty);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_MaxStuQty) == true) {
            const strComparisonOp_MaxStuQty = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_MaxStuQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_MaxStuQty, objvCurrEduClsTeacher_Cond.maxStuQty, strComparisonOp_MaxStuQty);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekQty) == true) {
            const strComparisonOp_WeekQty = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekQty, objvCurrEduClsTeacher_Cond.weekQty, strComparisonOp_WeekQty);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekStatusID) == true) {
            const strComparisonOp_WeekStatusID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekStatusID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_WeekStatusID, objvCurrEduClsTeacher_Cond.weekStatusID, strComparisonOp_WeekStatusID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CustomerWeek) == true) {
            const strComparisonOp_CustomerWeek = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CustomerWeek];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CustomerWeek, objvCurrEduClsTeacher_Cond.customerWeek, strComparisonOp_CustomerWeek);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_UniZone, objvCurrEduClsTeacher_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_GradeBase, objvCurrEduClsTeacher_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseID) == true) {
            const strComparisonOp_GradeBaseID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseID, objvCurrEduClsTeacher_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_GradeBaseName, objvCurrEduClsTeacher_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsEffective) == true) {
            if (objvCurrEduClsTeacher_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CourseType) == true) {
            const strComparisonOp_id_CourseType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CourseType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_CourseType, objvCurrEduClsTeacher_Cond.id_CourseType, strComparisonOp_id_CourseType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeID, objvCurrEduClsTeacher_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CourseTypeName, objvCurrEduClsTeacher_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsDegree) == true) {
            if (objvCurrEduClsTeacher_Cond.isDegree == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsDegree);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsDegree);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ScoreType) == true) {
            const strComparisonOp_id_ScoreType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ScoreType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ScoreType, objvCurrEduClsTeacher_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsProportionalCtrl) == true) {
            if (objvCurrEduClsTeacher_Cond.isProportionalCtrl == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsProportionalCtrl);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsProportionalCtrl);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ExamType) == true) {
            const strComparisonOp_id_ExamType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ExamType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ExamType, objvCurrEduClsTeacher_Cond.id_ExamType, strComparisonOp_id_ExamType);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid) == true) {
            const strComparisonOp_CurrStuNum_Valid = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum_Valid, objvCurrEduClsTeacher_Cond.currStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum) == true) {
            const strComparisonOp_CurrStuNum = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CurrStuNum, objvCurrEduClsTeacher_Cond.currStuNum, strComparisonOp_CurrStuNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Teacher, objvCurrEduClsTeacher_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherID) == true) {
            const strComparisonOp_TeacherID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherID, objvCurrEduClsTeacher_Cond.teacherID, strComparisonOp_TeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherName) == true) {
            const strComparisonOp_TeacherName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_TeacherName, objvCurrEduClsTeacher_Cond.teacherName, strComparisonOp_TeacherName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ProfGrade) == true) {
            const strComparisonOp_id_ProfGrade = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ProfGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_ProfGrade, objvCurrEduClsTeacher_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName) == true) {
            const strComparisonOp_ProfenssionalGradeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_ProfenssionalGradeName, objvCurrEduClsTeacher_Cond.profenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_DegreeName) == true) {
            const strComparisonOp_DegreeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_DegreeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_DegreeName, objvCurrEduClsTeacher_Cond.degreeName, strComparisonOp_DegreeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Birthday, objvCurrEduClsTeacher_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsGpUser) == true) {
            if (objvCurrEduClsTeacher_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName, objvCurrEduClsTeacher_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType) == true) {
            const strComparisonOp_id_Pk2EduClsTeacherType = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_id_Pk2EduClsTeacherType, objvCurrEduClsTeacher_Cond.id_Pk2EduClsTeacherType, strComparisonOp_id_Pk2EduClsTeacherType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID) == true) {
            const strComparisonOp_EduClsTeacherTypeID = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeID, objvCurrEduClsTeacher_Cond.eduClsTeacherTypeID, strComparisonOp_EduClsTeacherTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc) == true) {
            const strComparisonOp_EduClsTeacherTypeDesc = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_EduClsTeacherTypeDesc, objvCurrEduClsTeacher_Cond.eduClsTeacherTypeDesc, strComparisonOp_EduClsTeacherTypeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolTerm, objvCurrEduClsTeacher_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_SchoolYear, objvCurrEduClsTeacher_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenBeginDate) == true) {
            const strComparisonOp_OpenBeginDate = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenBeginDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenBeginDate, objvCurrEduClsTeacher_Cond.openBeginDate, strComparisonOp_OpenBeginDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenEndDate) == true) {
            const strComparisonOp_OpenEndDate = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenEndDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OpenEndDate, objvCurrEduClsTeacher_Cond.openEndDate, strComparisonOp_OpenEndDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_OrderNum, objvCurrEduClsTeacher_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdDate, objvCurrEduClsTeacher_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_UpdUser, objvCurrEduClsTeacher_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_Memo, objvCurrEduClsTeacher_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4EduCls) == true) {
            const strComparisonOp_CollegeName4EduCls = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4EduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4EduCls, objvCurrEduClsTeacher_Cond.collegeName4EduCls, strComparisonOp_CollegeName4EduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsTeacher_Cond.dicFldComparisonOp, clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4Teacher) == true) {
            const strComparisonOp_CollegeName4Teacher = objvCurrEduClsTeacher_Cond.dicFldComparisonOp[clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN.con_CollegeName4Teacher, objvCurrEduClsTeacher_Cond.collegeName4Teacher, strComparisonOp_CollegeName4Teacher);
        }
        return strWhereCond;
    }
    exports.vCurrEduClsTeacher_GetCombineCondition = vCurrEduClsTeacher_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvCurrEduClsTeacherENS:源对象
     * @param objvCurrEduClsTeacherENT:目标对象
    */
    function vCurrEduClsTeacher_CopyObjTo(objvCurrEduClsTeacherENS, objvCurrEduClsTeacherENT) {
        objvCurrEduClsTeacherENT.id_EduClsTeacher = objvCurrEduClsTeacherENS.id_EduClsTeacher; //教学班老师流水号
        objvCurrEduClsTeacherENT.id_CurrEduCls = objvCurrEduClsTeacherENS.id_CurrEduCls; //教学班流水号
        objvCurrEduClsTeacherENT.currEduClsId = objvCurrEduClsTeacherENS.currEduClsId; //教学班Id
        objvCurrEduClsTeacherENT.eduClsName = objvCurrEduClsTeacherENS.eduClsName; //教学班名
        objvCurrEduClsTeacherENT.eduClsTypeId = objvCurrEduClsTeacherENS.eduClsTypeId; //教学班类型Id
        objvCurrEduClsTeacherENT.eduClsTypeName = objvCurrEduClsTeacherENS.eduClsTypeName; //教学班类型名称
        objvCurrEduClsTeacherENT.courseId = objvCurrEduClsTeacherENS.courseId; //课程Id
        objvCurrEduClsTeacherENT.courseCode = objvCurrEduClsTeacherENS.courseCode; //课程代码
        objvCurrEduClsTeacherENT.courseName = objvCurrEduClsTeacherENS.courseName; //课程名称
        objvCurrEduClsTeacherENT.exampleImgPath = objvCurrEduClsTeacherENS.exampleImgPath; //示例图路径
        objvCurrEduClsTeacherENT.teachingSolutionId = objvCurrEduClsTeacherENS.teachingSolutionId; //教学方案Id
        objvCurrEduClsTeacherENT.teachingSolutionName = objvCurrEduClsTeacherENS.teachingSolutionName; //教学方案名称
        objvCurrEduClsTeacherENT.id_XzCollege = objvCurrEduClsTeacherENS.id_XzCollege; //学院流水号
        objvCurrEduClsTeacherENT.collegeID = objvCurrEduClsTeacherENS.collegeID; //学院ID
        objvCurrEduClsTeacherENT.id_EduWay = objvCurrEduClsTeacherENS.id_EduWay; //教学方式流水号
        objvCurrEduClsTeacherENT.totalLessonQty = objvCurrEduClsTeacherENS.totalLessonQty; //总课时数
        objvCurrEduClsTeacherENT.maxStuQty = objvCurrEduClsTeacherENS.maxStuQty; //最大学生数
        objvCurrEduClsTeacherENT.weekQty = objvCurrEduClsTeacherENS.weekQty; //总周数
        objvCurrEduClsTeacherENT.scheUnitPW = objvCurrEduClsTeacherENS.scheUnitPW; //周排课次数
        objvCurrEduClsTeacherENT.weekStatusID = objvCurrEduClsTeacherENS.weekStatusID; //周状态编号(单,双,全周)
        objvCurrEduClsTeacherENT.customerWeek = objvCurrEduClsTeacherENS.customerWeek; //自定义上课周
        objvCurrEduClsTeacherENT.lessonQtyPerWeek = objvCurrEduClsTeacherENS.lessonQtyPerWeek; //周课时数
        objvCurrEduClsTeacherENT.id_UniZone = objvCurrEduClsTeacherENS.id_UniZone; //校区流水号
        objvCurrEduClsTeacherENT.id_GradeBase = objvCurrEduClsTeacherENS.id_GradeBase; //年级流水号
        objvCurrEduClsTeacherENT.gradeBaseID = objvCurrEduClsTeacherENS.gradeBaseID; //年级代号
        objvCurrEduClsTeacherENT.gradeBaseName = objvCurrEduClsTeacherENS.gradeBaseName; //年级名称
        objvCurrEduClsTeacherENT.isEffective = objvCurrEduClsTeacherENS.isEffective; //是否有效
        objvCurrEduClsTeacherENT.id_CourseType = objvCurrEduClsTeacherENS.id_CourseType; //课程类型流水号
        objvCurrEduClsTeacherENT.courseTypeID = objvCurrEduClsTeacherENS.courseTypeID; //课程类型ID
        objvCurrEduClsTeacherENT.courseTypeName = objvCurrEduClsTeacherENS.courseTypeName; //课程类型名称
        objvCurrEduClsTeacherENT.isDegree = objvCurrEduClsTeacherENS.isDegree; //是否学位课
        objvCurrEduClsTeacherENT.id_ScoreType = objvCurrEduClsTeacherENS.id_ScoreType; //成绩类型流水号
        objvCurrEduClsTeacherENT.isProportionalCtrl = objvCurrEduClsTeacherENS.isProportionalCtrl; //是否比例控制
        objvCurrEduClsTeacherENT.id_ExamType = objvCurrEduClsTeacherENS.id_ExamType; //考试方式流水号
        objvCurrEduClsTeacherENT.beginWeek = objvCurrEduClsTeacherENS.beginWeek; //开始周
        objvCurrEduClsTeacherENT.currStuNum_Valid = objvCurrEduClsTeacherENS.currStuNum_Valid; //CurrStuNum_Valid
        objvCurrEduClsTeacherENT.currStuNum = objvCurrEduClsTeacherENS.currStuNum; //当前学生数
        objvCurrEduClsTeacherENT.id_Teacher = objvCurrEduClsTeacherENS.id_Teacher; //教师流水号
        objvCurrEduClsTeacherENT.teacherID = objvCurrEduClsTeacherENS.teacherID; //教师工号
        objvCurrEduClsTeacherENT.teacherName = objvCurrEduClsTeacherENS.teacherName; //教师姓名
        objvCurrEduClsTeacherENT.id_ProfGrade = objvCurrEduClsTeacherENS.id_ProfGrade; //专业职称流水号
        objvCurrEduClsTeacherENT.profenssionalGradeName = objvCurrEduClsTeacherENS.profenssionalGradeName; //专业职称
        objvCurrEduClsTeacherENT.degreeName = objvCurrEduClsTeacherENS.degreeName; //学位名称
        objvCurrEduClsTeacherENT.birthday = objvCurrEduClsTeacherENS.birthday; //出生日期
        objvCurrEduClsTeacherENT.isGpUser = objvCurrEduClsTeacherENS.isGpUser; //是否Gp用户
        objvCurrEduClsTeacherENT.collegeName = objvCurrEduClsTeacherENS.collegeName; //学院名称
        objvCurrEduClsTeacherENT.id_Pk2EduClsTeacherType = objvCurrEduClsTeacherENS.id_Pk2EduClsTeacherType; //教学班老师角色(主讲,辅导)流水号
        objvCurrEduClsTeacherENT.eduClsTeacherTypeID = objvCurrEduClsTeacherENS.eduClsTeacherTypeID; //教学班教学类型ID
        objvCurrEduClsTeacherENT.eduClsTeacherTypeDesc = objvCurrEduClsTeacherENS.eduClsTeacherTypeDesc; //教学班教师类型名
        objvCurrEduClsTeacherENT.schoolTerm = objvCurrEduClsTeacherENS.schoolTerm; //学期
        objvCurrEduClsTeacherENT.schoolYear = objvCurrEduClsTeacherENS.schoolYear; //学年
        objvCurrEduClsTeacherENT.openBeginDate = objvCurrEduClsTeacherENS.openBeginDate; //开放开始日期
        objvCurrEduClsTeacherENT.openEndDate = objvCurrEduClsTeacherENS.openEndDate; //开放结束日期
        objvCurrEduClsTeacherENT.orderNum = objvCurrEduClsTeacherENS.orderNum; //序号
        objvCurrEduClsTeacherENT.updDate = objvCurrEduClsTeacherENS.updDate; //修改日期
        objvCurrEduClsTeacherENT.updUser = objvCurrEduClsTeacherENS.updUser; //修改人
        objvCurrEduClsTeacherENT.memo = objvCurrEduClsTeacherENS.memo; //备注
        objvCurrEduClsTeacherENT.collegeName4EduCls = objvCurrEduClsTeacherENS.collegeName4EduCls; //学院名_教学班
        objvCurrEduClsTeacherENT.collegeName4Teacher = objvCurrEduClsTeacherENS.collegeName4Teacher; //学院名_教师
    }
    exports.vCurrEduClsTeacher_CopyObjTo = vCurrEduClsTeacher_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvCurrEduClsTeacherENS:源对象
     * @param objvCurrEduClsTeacherENT:目标对象
    */
    function vCurrEduClsTeacher_GetObjFromJsonObj(objvCurrEduClsTeacherENS) {
        const objvCurrEduClsTeacherENT = new clsvCurrEduClsTeacherEN_js_1.clsvCurrEduClsTeacherEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsTeacherENT, objvCurrEduClsTeacherENS);
        return objvCurrEduClsTeacherENT;
    }
    exports.vCurrEduClsTeacher_GetObjFromJsonObj = vCurrEduClsTeacher_GetObjFromJsonObj;
});
