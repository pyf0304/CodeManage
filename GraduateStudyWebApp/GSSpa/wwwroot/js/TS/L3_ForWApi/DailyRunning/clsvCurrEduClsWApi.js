/**
* 类名:clsvCurrEduClsWApi
* 表名:vCurrEduCls(01120126)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:28
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning/clsvCurrEduClsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduCls_GetObjFromJsonObj = exports.vCurrEduCls_CopyObjTo = exports.vCurrEduCls_GetCombineCondition = exports.vCurrEduCls_GetObjByJSONStr = exports.vCurrEduCls_GetObjLstByJSONObjLst = exports.vCurrEduCls_GetObjLstByJSONStr = exports.vCurrEduCls_GetJSONStrByObj = exports.vCurrEduCls__Cache = exports.vCurrEduCls_ReFreshThisCache = exports.vCurrEduCls_GetWebApiUrl = exports.vCurrEduCls_GetRecCountByCond_Cache = exports.vCurrEduCls_GetRecCountByCondAsync = exports.vCurrEduCls_IsExistAsync = exports.vCurrEduCls_IsExist_Cache = exports.vCurrEduCls_IsExist = exports.vCurrEduCls_IsExistRecordAsync = exports.vCurrEduCls_IsExistRecord_Cache = exports.vCurrEduCls_GetObjLstByPagerAsync = exports.vCurrEduCls_GetObjLstByPager_Cache = exports.vCurrEduCls_GetObjLstByRange = exports.vCurrEduCls_GetObjLstByRangeAsync = exports.vCurrEduCls_GetTopObjLstAsync = exports.vCurrEduCls_GetObjLstByid_CurrEduClsLst_Cache = exports.vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync = exports.vCurrEduCls_GetSubObjLst_Cache = exports.vCurrEduCls_GetObjLst_PureCache = exports.vCurrEduCls_GetObjLst_Cache = exports.vCurrEduCls_GetObjLst_sessionStorage_PureCache = exports.vCurrEduCls_GetObjLst_sessionStorage = exports.vCurrEduCls_GetObjLstAsync = exports.vCurrEduCls_GetObjLst_localStorage_PureCache = exports.vCurrEduCls_GetObjLst_localStorage = exports.vCurrEduCls_GetObjLst_ClientCache = exports.vCurrEduCls_GetFirstObjAsync = exports.vCurrEduCls_GetFirstID = exports.vCurrEduCls_GetFirstIDAsync = exports.vCurrEduCls_FilterFunByKey = exports.vCurrEduCls_SortFunByKey = exports.vCurrEduCls_SortFun_Defa_2Fld = exports.vCurrEduCls_SortFun_Defa = exports.vCurrEduCls_func = exports.vCurrEduCls_GetNameByid_CurrEduCls_Cache = exports.vCurrEduCls_GetObjByid_CurrEduCls_localStorage = exports.vCurrEduCls_GetObjByid_CurrEduCls_Cache = exports.vCurrEduCls_GetObjByid_CurrEduClsAsync = exports.vCurrEduCls_ConstructorName = exports.vCurrEduCls_Controller = void 0;
    /**
     * v当前教学班(vCurrEduCls)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvCurrEduClsEN_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vCurrEduCls_Controller = "vCurrEduClsApi";
    exports.vCurrEduCls_ConstructorName = "vCurrEduCls";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 对象
    **/
    async function vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls) {
        const strThisFuncName = "GetObjByid_CurrEduClsAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In GetObjByid_CurrEduClsAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_CurrEduCls";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_CurrEduCls": strid_CurrEduCls,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvCurrEduCls = vCurrEduCls_GetObjFromJsonObj(returnObj);
                return objvCurrEduCls;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjByid_CurrEduClsAsync = vCurrEduCls_GetObjByid_CurrEduClsAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_CurrEduCls_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In GetObjByid_CurrEduCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        try {
            const arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
            let objvCurrEduCls;
            if (arrvCurrEduCls_Sel.length > 0) {
                objvCurrEduCls = arrvCurrEduCls_Sel[0];
                return objvCurrEduCls;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvCurrEduCls = await vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
                    if (objvCurrEduCls != null) {
                        vCurrEduCls_ReFreshThisCache();
                        return objvCurrEduCls;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vCurrEduCls_GetObjByid_CurrEduCls_Cache = vCurrEduCls_GetObjByid_CurrEduCls_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_GetObjByid_CurrEduCls_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjByid_CurrEduCls_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In GetObjByid_CurrEduCls_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvCurrEduCls_Cache = JSON.parse(strTempObj);
            return objvCurrEduCls_Cache;
        }
        try {
            const objvCurrEduCls = await vCurrEduCls_GetObjByid_CurrEduClsAsync(strid_CurrEduCls);
            if (objvCurrEduCls != null) {
                localStorage.setItem(strKey, JSON.stringify(objvCurrEduCls));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvCurrEduCls;
            }
            return objvCurrEduCls;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_CurrEduCls, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vCurrEduCls_GetObjByid_CurrEduCls_localStorage = vCurrEduCls_GetObjByid_CurrEduCls_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_GetNameByid_CurrEduCls_Cache(strid_CurrEduCls) {
        const strThisFuncName = "GetNameByid_CurrEduCls_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In GetNameByid_CurrEduCls_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        if (arrvCurrEduClsObjLst_Cache == null)
            return "";
        try {
            const arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
            let objvCurrEduCls;
            if (arrvCurrEduCls_Sel.length > 0) {
                objvCurrEduCls = arrvCurrEduCls_Sel[0];
                return objvCurrEduCls.eduClsName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_CurrEduCls);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vCurrEduCls_GetNameByid_CurrEduCls_Cache = vCurrEduCls_GetNameByid_CurrEduCls_Cache;
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
    async function vCurrEduCls_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_CurrEduCls = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvCurrEduCls = await vCurrEduCls_GetObjByid_CurrEduCls_Cache(strid_CurrEduCls);
        if (objvCurrEduCls == null)
            return "";
        return objvCurrEduCls.GetFldValue(strOutFldName).toString();
    }
    exports.vCurrEduCls_func = vCurrEduCls_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.vCurrEduCls_SortFun_Defa = vCurrEduCls_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.currEduClsId == b.currEduClsId)
            return a.eduClsName.localeCompare(b.eduClsName);
        else
            return a.currEduClsId.localeCompare(b.currEduClsId);
    }
    exports.vCurrEduCls_SortFun_Defa_2Fld = vCurrEduCls_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduCls_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId:
                    return (a, b) => {
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId:
                    return (a, b) => {
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName:
                    return (a, b) => {
                        return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode:
                    return (a, b) => {
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription:
                    return (a, b) => {
                        return a.courseDescription.localeCompare(b.courseDescription);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount:
                    return (a, b) => {
                        return a.viewCount - b.viewCount;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath:
                    return (a, b) => {
                        return a.exampleImgPath.localeCompare(b.exampleImgPath);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId:
                    return (a, b) => {
                        return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName:
                    return (a, b) => {
                        return a.teachingSolutionName.localeCompare(b.teachingSolutionName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher:
                    return (a, b) => {
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID:
                    return (a, b) => {
                        return a.teacherID.localeCompare(b.teacherID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName:
                    return (a, b) => {
                        return a.teacherName.localeCompare(b.teacherName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID:
                    return (a, b) => {
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName:
                    return (a, b) => {
                        return a.clgEnglishName.localeCompare(b.clgEnglishName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber:
                    return (a, b) => {
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay:
                    return (a, b) => {
                        return a.id_EduWay.localeCompare(b.id_EduWay);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType:
                    return (a, b) => {
                        return a.id_ClassRoomType.localeCompare(b.id_ClassRoomType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty:
                    return (a, b) => {
                        return a.totalLessonQty - b.totalLessonQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty:
                    return (a, b) => {
                        return a.maxStuQty - b.maxStuQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty:
                    return (a, b) => {
                        return a.weekQty - b.weekQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ScheUnitPW:
                    return (a, b) => {
                        return a.scheUnitPW - b.scheUnitPW;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID:
                    return (a, b) => {
                        return a.weekStatusID.localeCompare(b.weekStatusID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek:
                    return (a, b) => {
                        return a.customerWeek.localeCompare(b.customerWeek);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return a.lessonQtyPerWeek - b.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark:
                    return (a, b) => {
                        return a.mark - b.mark;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone:
                    return (a, b) => {
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID:
                    return (a, b) => {
                        return a.gradeBaseID.localeCompare(b.gradeBaseID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName:
                    return (a, b) => {
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA:
                    return (a, b) => {
                        return a.gradeBaseNameA.localeCompare(b.gradeBaseNameA);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading:
                    return (a, b) => {
                        if (a.isForPaperReading == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear:
                    return (a, b) => {
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm:
                    return (a, b) => {
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType:
                    return (a, b) => {
                        return a.id_CourseType.localeCompare(b.id_CourseType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID:
                    return (a, b) => {
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName:
                    return (a, b) => {
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree:
                    return (a, b) => {
                        if (a.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType:
                    return (a, b) => {
                        return a.id_ScoreType.localeCompare(b.id_ScoreType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId:
                    return (a, b) => {
                        return a.getScoreWayId.localeCompare(b.getScoreWayId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (a.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType:
                    return (a, b) => {
                        return a.id_ExamType.localeCompare(b.id_ExamType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_BeginWeek:
                    return (a, b) => {
                        return a.beginWeek - b.beginWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid:
                    return (a, b) => {
                        return a.currStuNum_Valid - b.currStuNum_Valid;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum:
                    return (a, b) => {
                        return a.currStuNum - b.currStuNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${exports.vCurrEduCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId:
                    return (a, b) => {
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId:
                    return (a, b) => {
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName:
                    return (a, b) => {
                        return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode:
                    return (a, b) => {
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription:
                    return (a, b) => {
                        return b.courseDescription.localeCompare(a.courseDescription);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount:
                    return (a, b) => {
                        return b.viewCount - a.viewCount;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath:
                    return (a, b) => {
                        return b.exampleImgPath.localeCompare(a.exampleImgPath);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId:
                    return (a, b) => {
                        return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName:
                    return (a, b) => {
                        return b.teachingSolutionName.localeCompare(a.teachingSolutionName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher:
                    return (a, b) => {
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID:
                    return (a, b) => {
                        return b.teacherID.localeCompare(a.teacherID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName:
                    return (a, b) => {
                        return b.teacherName.localeCompare(a.teacherName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID:
                    return (a, b) => {
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName:
                    return (a, b) => {
                        return b.clgEnglishName.localeCompare(a.clgEnglishName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber:
                    return (a, b) => {
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay:
                    return (a, b) => {
                        return b.id_EduWay.localeCompare(a.id_EduWay);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType:
                    return (a, b) => {
                        return b.id_ClassRoomType.localeCompare(a.id_ClassRoomType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty:
                    return (a, b) => {
                        return b.totalLessonQty - a.totalLessonQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty:
                    return (a, b) => {
                        return b.maxStuQty - a.maxStuQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty:
                    return (a, b) => {
                        return b.weekQty - a.weekQty;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ScheUnitPW:
                    return (a, b) => {
                        return b.scheUnitPW - a.scheUnitPW;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID:
                    return (a, b) => {
                        return b.weekStatusID.localeCompare(a.weekStatusID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek:
                    return (a, b) => {
                        return b.customerWeek.localeCompare(a.customerWeek);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return b.lessonQtyPerWeek - a.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark:
                    return (a, b) => {
                        return b.mark - a.mark;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone:
                    return (a, b) => {
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID:
                    return (a, b) => {
                        return b.gradeBaseID.localeCompare(a.gradeBaseID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName:
                    return (a, b) => {
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA:
                    return (a, b) => {
                        return b.gradeBaseNameA.localeCompare(a.gradeBaseNameA);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading:
                    return (a, b) => {
                        if (b.isForPaperReading == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear:
                    return (a, b) => {
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm:
                    return (a, b) => {
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType:
                    return (a, b) => {
                        return b.id_CourseType.localeCompare(a.id_CourseType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID:
                    return (a, b) => {
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName:
                    return (a, b) => {
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree:
                    return (a, b) => {
                        if (b.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType:
                    return (a, b) => {
                        return b.id_ScoreType.localeCompare(a.id_ScoreType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId:
                    return (a, b) => {
                        return b.getScoreWayId.localeCompare(a.getScoreWayId);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl:
                    return (a, b) => {
                        if (b.isProportionalCtrl == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType:
                    return (a, b) => {
                        return b.id_ExamType.localeCompare(a.id_ExamType);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_BeginWeek:
                    return (a, b) => {
                        return b.beginWeek - a.beginWeek;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid:
                    return (a, b) => {
                        return b.currStuNum_Valid - a.currStuNum_Valid;
                    };
                case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum:
                    return (a, b) => {
                        return b.currStuNum - a.currStuNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${exports.vCurrEduCls_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vCurrEduCls_SortFunByKey = vCurrEduCls_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduCls_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName:
                return (obj) => {
                    return obj.eduClsTypeName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription:
                return (obj) => {
                    return obj.courseDescription === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount:
                return (obj) => {
                    return obj.viewCount === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath:
                return (obj) => {
                    return obj.exampleImgPath === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId:
                return (obj) => {
                    return obj.teachingSolutionId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName:
                return (obj) => {
                    return obj.teachingSolutionName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID:
                return (obj) => {
                    return obj.teacherID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName:
                return (obj) => {
                    return obj.teacherName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName:
                return (obj) => {
                    return obj.clgEnglishName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay:
                return (obj) => {
                    return obj.id_EduWay === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType:
                return (obj) => {
                    return obj.id_ClassRoomType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty:
                return (obj) => {
                    return obj.totalLessonQty === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty:
                return (obj) => {
                    return obj.maxStuQty === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty:
                return (obj) => {
                    return obj.weekQty === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ScheUnitPW:
                return (obj) => {
                    return obj.scheUnitPW === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID:
                return (obj) => {
                    return obj.weekStatusID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek:
                return (obj) => {
                    return obj.customerWeek === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_LessonQtyPerWeek:
                return (obj) => {
                    return obj.lessonQtyPerWeek === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark:
                return (obj) => {
                    return obj.mark === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID:
                return (obj) => {
                    return obj.gradeBaseID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA:
                return (obj) => {
                    return obj.gradeBaseNameA === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading:
                return (obj) => {
                    return obj.isForPaperReading === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType:
                return (obj) => {
                    return obj.id_CourseType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree:
                return (obj) => {
                    return obj.isDegree === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType:
                return (obj) => {
                    return obj.id_ScoreType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId:
                return (obj) => {
                    return obj.getScoreWayId === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl:
                return (obj) => {
                    return obj.isProportionalCtrl === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType:
                return (obj) => {
                    return obj.id_ExamType === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_BeginWeek:
                return (obj) => {
                    return obj.beginWeek === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid:
                return (obj) => {
                    return obj.currStuNum_Valid === value;
                };
            case clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum:
                return (obj) => {
                    return obj.currStuNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vCurrEduCls]中不存在！(in ${exports.vCurrEduCls_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vCurrEduCls_FilterFunByKey = vCurrEduCls_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vCurrEduCls_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetFirstIDAsync = vCurrEduCls_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vCurrEduCls_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetFirstID = vCurrEduCls_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vCurrEduCls_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvCurrEduCls = vCurrEduCls_GetObjFromJsonObj(returnObj);
                return objvCurrEduCls;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetFirstObjAsync = vCurrEduCls_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName;
        clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvCurrEduClsExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvCurrEduClsObjLst_T = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsExObjLst_Cache);
            return arrvCurrEduClsObjLst_T;
        }
        try {
            const arrvCurrEduClsExObjLst = await vCurrEduCls_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvCurrEduClsExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduCls_GetObjLst_ClientCache = vCurrEduCls_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName;
        clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduClsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduClsObjLst_T = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsExObjLst_Cache);
            return arrvCurrEduClsObjLst_T;
        }
        try {
            const arrvCurrEduClsExObjLst = await vCurrEduCls_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduCls_GetObjLst_localStorage = vCurrEduCls_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduClsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduCls_GetObjLst_localStorage_PureCache = vCurrEduCls_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduCls_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstAsync = vCurrEduCls_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName;
        clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduClsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduClsObjLst_T = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsExObjLst_Cache);
            return arrvCurrEduClsObjLst_T;
        }
        try {
            const arrvCurrEduClsExObjLst = await vCurrEduCls_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduCls_GetObjLst_sessionStorage = vCurrEduCls_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduClsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduClsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduCls_GetObjLst_sessionStorage_PureCache = vCurrEduCls_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvCurrEduClsObjLst_Cache;
        switch (clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_ClientCache();
                break;
            default:
                arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_ClientCache();
                break;
        }
        const arrvCurrEduClsObjLst = vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsObjLst_Cache);
        return arrvCurrEduClsObjLst_Cache;
    }
    exports.vCurrEduCls_GetObjLst_Cache = vCurrEduCls_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduCls_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvCurrEduClsObjLst_Cache;
        switch (clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvCurrEduClsObjLst_Cache = null;
                break;
            default:
                arrvCurrEduClsObjLst_Cache = null;
                break;
        }
        return arrvCurrEduClsObjLst_Cache;
    }
    exports.vCurrEduCls_GetObjLst_PureCache = vCurrEduCls_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_CurrEduCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduCls_GetSubObjLst_Cache(objvCurrEduCls_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        let arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache;
        if (objvCurrEduCls_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduCls_Sel;
        const dicFldComparisonOp = JSON.parse(objvCurrEduCls_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduCls_Cond), exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduCls_GetSubObjLst_Cache = vCurrEduCls_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_CurrEduCls:关键字列表
    * @returns 对象列表
    **/
    async function vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync(arrid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByid_CurrEduClsLstAsync";
        const strAction = "GetObjLstByid_CurrEduClsLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_CurrEduCls);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync = vCurrEduCls_GetObjLstByid_CurrEduClsLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_CurrEduClsLst:关键字列表
     * @returns 对象列表
    */
    async function vCurrEduCls_GetObjLstByid_CurrEduClsLst_Cache(arrid_CurrEduClsLst) {
        const strThisFuncName = "GetObjLstByid_CurrEduClsLst_Cache";
        try {
            const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
            const arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache.filter(x => arrid_CurrEduClsLst.indexOf(x.id_CurrEduCls) > -1);
            return arrvCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_CurrEduClsLst.join(","), exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduCls_GetObjLstByid_CurrEduClsLst_Cache = vCurrEduCls_GetObjLstByid_CurrEduClsLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduCls_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetTopObjLstAsync = vCurrEduCls_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduCls_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByRangeAsync = vCurrEduCls_GetObjLstByRangeAsync;
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
    async function vCurrEduCls_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByRange = vCurrEduCls_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduCls_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        if (arrvCurrEduClsObjLst_Cache.length == 0)
            return arrvCurrEduClsObjLst_Cache;
        let arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvCurrEduCls_Cond = new clsvCurrEduClsEN_js_1.clsvCurrEduClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduCls_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvCurrEduClsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduCls_Sel.length == 0)
                return arrvCurrEduCls_Sel;
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
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(vCurrEduCls_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.slice(intStart, intEnd);
            return arrvCurrEduCls_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduCls_GetObjLstByPager_Cache = vCurrEduCls_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduCls_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduCls_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduCls_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetObjLstByPagerAsync = vCurrEduCls_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_CurrEduCls_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduCls_IsExistRecord_Cache(objvCurrEduCls_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        if (arrvCurrEduClsObjLst_Cache == null)
            return false;
        let arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache;
        if (objvCurrEduCls_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduCls_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvCurrEduCls_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduCls_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvCurrEduCls_Cond), exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vCurrEduCls_IsExistRecord_Cache = vCurrEduCls_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vCurrEduCls_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_IsExistRecordAsync = vCurrEduCls_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_CurrEduCls:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vCurrEduCls_IsExist(strid_CurrEduCls, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_CurrEduCls": strid_CurrEduCls,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_IsExist = vCurrEduCls_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_CurrEduCls:所给的关键字
     * @returns 对象
    */
    async function vCurrEduCls_IsExist_Cache(strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        if (arrvCurrEduClsObjLst_Cache == null)
            return false;
        try {
            const arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache.filter(x => x.id_CurrEduCls == strid_CurrEduCls);
            if (arrvCurrEduCls_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_CurrEduCls, exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vCurrEduCls_IsExist_Cache = vCurrEduCls_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_CurrEduCls:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vCurrEduCls_IsExistAsync(strid_CurrEduCls) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_CurrEduCls": strid_CurrEduCls }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_IsExistAsync = vCurrEduCls_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vCurrEduCls_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduCls_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduCls_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduCls_GetRecCountByCondAsync = vCurrEduCls_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvCurrEduCls_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vCurrEduCls_GetRecCountByCond_Cache(objvCurrEduCls_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvCurrEduClsObjLst_Cache = await vCurrEduCls_GetObjLst_Cache();
        if (arrvCurrEduClsObjLst_Cache == null)
            return 0;
        let arrvCurrEduCls_Sel = arrvCurrEduClsObjLst_Cache;
        if (objvCurrEduCls_Cond.sf_FldComparisonOp == null || objvCurrEduCls_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduCls_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvCurrEduCls_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduCls_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduCls_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduCls_Sel = arrvCurrEduCls_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduCls_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduCls_Cond), exports.vCurrEduCls_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vCurrEduCls_GetRecCountByCond_Cache = vCurrEduCls_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vCurrEduCls_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduCls_GetWebApiUrl = vCurrEduCls_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vCurrEduCls_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvCurrEduClsEN_js_1.clsvCurrEduClsEN._CurrTabName;
            switch (clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.CacheModeId) {
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
    exports.vCurrEduCls_ReFreshThisCache = vCurrEduCls_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vCurrEduCls__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vCurrEduCls_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName, "v当前教学班");
    }
    exports.vCurrEduCls__Cache = vCurrEduCls__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduCls_GetJSONStrByObj(pobjvCurrEduClsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvCurrEduClsEN);
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
    exports.vCurrEduCls_GetJSONStrByObj = vCurrEduCls_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduCls_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvCurrEduClsObjLst = new Array();
        if (strJSON === "") {
            return arrvCurrEduClsObjLst;
        }
        try {
            arrvCurrEduClsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvCurrEduClsObjLst;
        }
        return arrvCurrEduClsObjLst;
    }
    exports.vCurrEduCls_GetObjLstByJSONStr = vCurrEduCls_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvCurrEduClsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduCls_GetObjLstByJSONObjLst(arrvCurrEduClsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvCurrEduClsObjLst = new Array();
        for (const objInFor of arrvCurrEduClsObjLstS) {
            const obj1 = vCurrEduCls_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvCurrEduClsObjLst.push(obj1);
        }
        return arrvCurrEduClsObjLst;
    }
    exports.vCurrEduCls_GetObjLstByJSONObjLst = vCurrEduCls_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduCls_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvCurrEduClsEN = new clsvCurrEduClsEN_js_1.clsvCurrEduClsEN();
        if (strJSON === "") {
            return pobjvCurrEduClsEN;
        }
        try {
            pobjvCurrEduClsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvCurrEduClsEN;
        }
        return pobjvCurrEduClsEN;
    }
    exports.vCurrEduCls_GetObjByJSONStr = vCurrEduCls_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vCurrEduCls_GetCombineCondition(objvCurrEduCls_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CurrEduCls, objvCurrEduCls_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrEduClsId, objvCurrEduCls_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsName, objvCurrEduCls_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeId, objvCurrEduCls_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName) == true) {
            const strComparisonOp_EduClsTypeName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_EduClsTypeName, objvCurrEduCls_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseId, objvCurrEduCls_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseCode, objvCurrEduCls_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription) == true) {
            const strComparisonOp_CourseDescription = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseDescription, objvCurrEduCls_Cond.courseDescription, strComparisonOp_CourseDescription);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseName, objvCurrEduCls_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount) == true) {
            const strComparisonOp_ViewCount = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ViewCount, objvCurrEduCls_Cond.viewCount, strComparisonOp_ViewCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath) == true) {
            const strComparisonOp_ExampleImgPath = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ExampleImgPath, objvCurrEduCls_Cond.exampleImgPath, strComparisonOp_ExampleImgPath);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId) == true) {
            const strComparisonOp_TeachingSolutionId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionId, objvCurrEduCls_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName) == true) {
            const strComparisonOp_TeachingSolutionName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeachingSolutionName, objvCurrEduCls_Cond.teachingSolutionName, strComparisonOp_TeachingSolutionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_Teacher, objvCurrEduCls_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID) == true) {
            const strComparisonOp_TeacherID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherID, objvCurrEduCls_Cond.teacherID, strComparisonOp_TeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName) == true) {
            const strComparisonOp_TeacherName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TeacherName, objvCurrEduCls_Cond.teacherName, strComparisonOp_TeacherName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzCollege, objvCurrEduCls_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeID, objvCurrEduCls_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CollegeName, objvCurrEduCls_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName) == true) {
            const strComparisonOp_ClgEnglishName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ClgEnglishName, objvCurrEduCls_Cond.clgEnglishName, strComparisonOp_ClgEnglishName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_PhoneNumber, objvCurrEduCls_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_XzMajor, objvCurrEduCls_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MajorName, objvCurrEduCls_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay) == true) {
            const strComparisonOp_id_EduWay = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_EduWay, objvCurrEduCls_Cond.id_EduWay, strComparisonOp_id_EduWay);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType) == true) {
            const strComparisonOp_id_ClassRoomType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ClassRoomType, objvCurrEduCls_Cond.id_ClassRoomType, strComparisonOp_id_ClassRoomType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty) == true) {
            const strComparisonOp_TotalLessonQty = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_TotalLessonQty, objvCurrEduCls_Cond.totalLessonQty, strComparisonOp_TotalLessonQty);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty) == true) {
            const strComparisonOp_MaxStuQty = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_MaxStuQty, objvCurrEduCls_Cond.maxStuQty, strComparisonOp_MaxStuQty);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty) == true) {
            const strComparisonOp_WeekQty = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekQty, objvCurrEduCls_Cond.weekQty, strComparisonOp_WeekQty);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID) == true) {
            const strComparisonOp_WeekStatusID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_WeekStatusID, objvCurrEduCls_Cond.weekStatusID, strComparisonOp_WeekStatusID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek) == true) {
            const strComparisonOp_CustomerWeek = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CustomerWeek, objvCurrEduCls_Cond.customerWeek, strComparisonOp_CustomerWeek);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark) == true) {
            const strComparisonOp_Mark = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Mark, objvCurrEduCls_Cond.mark, strComparisonOp_Mark);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_UniZone, objvCurrEduCls_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_GradeBase, objvCurrEduCls_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID) == true) {
            const strComparisonOp_GradeBaseID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseID, objvCurrEduCls_Cond.gradeBaseID, strComparisonOp_GradeBaseID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseName, objvCurrEduCls_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA) == true) {
            const strComparisonOp_GradeBaseNameA = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GradeBaseNameA, objvCurrEduCls_Cond.gradeBaseNameA, strComparisonOp_GradeBaseNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective) == true) {
            if (objvCurrEduCls_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading) == true) {
            if (objvCurrEduCls_Cond.isForPaperReading == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsForPaperReading);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolYear, objvCurrEduCls_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_SchoolTerm, objvCurrEduCls_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType) == true) {
            const strComparisonOp_id_CourseType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_CourseType, objvCurrEduCls_Cond.id_CourseType, strComparisonOp_id_CourseType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeID, objvCurrEduCls_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CourseTypeName, objvCurrEduCls_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree) == true) {
            if (objvCurrEduCls_Cond.isDegree == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsDegree);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType) == true) {
            const strComparisonOp_id_ScoreType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ScoreType, objvCurrEduCls_Cond.id_ScoreType, strComparisonOp_id_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId) == true) {
            const strComparisonOp_GetScoreWayId = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_GetScoreWayId, objvCurrEduCls_Cond.getScoreWayId, strComparisonOp_GetScoreWayId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl) == true) {
            if (objvCurrEduCls_Cond.isProportionalCtrl == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_IsProportionalCtrl);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType) == true) {
            const strComparisonOp_id_ExamType = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_id_ExamType, objvCurrEduCls_Cond.id_ExamType, strComparisonOp_id_ExamType);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyDate, objvCurrEduCls_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_ModifyUserID, objvCurrEduCls_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_Memo, objvCurrEduCls_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid) == true) {
            const strComparisonOp_CurrStuNum_Valid = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum_Valid, objvCurrEduCls_Cond.currStuNum_Valid, strComparisonOp_CurrStuNum_Valid);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduCls_Cond.dicFldComparisonOp, clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum) == true) {
            const strComparisonOp_CurrStuNum = objvCurrEduCls_Cond.dicFldComparisonOp[clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsEN_js_1.clsvCurrEduClsEN.con_CurrStuNum, objvCurrEduCls_Cond.currStuNum, strComparisonOp_CurrStuNum);
        }
        return strWhereCond;
    }
    exports.vCurrEduCls_GetCombineCondition = vCurrEduCls_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvCurrEduClsENS:源对象
     * @param objvCurrEduClsENT:目标对象
    */
    function vCurrEduCls_CopyObjTo(objvCurrEduClsENS, objvCurrEduClsENT) {
        objvCurrEduClsENT.id_CurrEduCls = objvCurrEduClsENS.id_CurrEduCls; //教学班流水号
        objvCurrEduClsENT.currEduClsId = objvCurrEduClsENS.currEduClsId; //教学班Id
        objvCurrEduClsENT.eduClsName = objvCurrEduClsENS.eduClsName; //教学班名
        objvCurrEduClsENT.eduClsTypeId = objvCurrEduClsENS.eduClsTypeId; //教学班类型Id
        objvCurrEduClsENT.eduClsTypeName = objvCurrEduClsENS.eduClsTypeName; //教学班类型名称
        objvCurrEduClsENT.courseId = objvCurrEduClsENS.courseId; //课程Id
        objvCurrEduClsENT.courseCode = objvCurrEduClsENS.courseCode; //课程代码
        objvCurrEduClsENT.courseDescription = objvCurrEduClsENS.courseDescription; //课程描述
        objvCurrEduClsENT.courseName = objvCurrEduClsENS.courseName; //课程名称
        objvCurrEduClsENT.viewCount = objvCurrEduClsENS.viewCount; //浏览量
        objvCurrEduClsENT.exampleImgPath = objvCurrEduClsENS.exampleImgPath; //示例图路径
        objvCurrEduClsENT.teachingSolutionId = objvCurrEduClsENS.teachingSolutionId; //教学方案Id
        objvCurrEduClsENT.teachingSolutionName = objvCurrEduClsENS.teachingSolutionName; //教学方案名称
        objvCurrEduClsENT.id_Teacher = objvCurrEduClsENS.id_Teacher; //教师流水号
        objvCurrEduClsENT.teacherID = objvCurrEduClsENS.teacherID; //教师工号
        objvCurrEduClsENT.teacherName = objvCurrEduClsENS.teacherName; //教师姓名
        objvCurrEduClsENT.id_XzCollege = objvCurrEduClsENS.id_XzCollege; //学院流水号
        objvCurrEduClsENT.collegeID = objvCurrEduClsENS.collegeID; //学院ID
        objvCurrEduClsENT.collegeName = objvCurrEduClsENS.collegeName; //学院名称
        objvCurrEduClsENT.clgEnglishName = objvCurrEduClsENS.clgEnglishName; //ClgEnglishName
        objvCurrEduClsENT.phoneNumber = objvCurrEduClsENS.phoneNumber; //PhoneNumber
        objvCurrEduClsENT.id_XzMajor = objvCurrEduClsENS.id_XzMajor; //专业流水号
        objvCurrEduClsENT.majorName = objvCurrEduClsENS.majorName; //专业名称
        objvCurrEduClsENT.id_EduWay = objvCurrEduClsENS.id_EduWay; //教学方式流水号
        objvCurrEduClsENT.id_ClassRoomType = objvCurrEduClsENS.id_ClassRoomType; //教室类型流水号
        objvCurrEduClsENT.totalLessonQty = objvCurrEduClsENS.totalLessonQty; //总课时数
        objvCurrEduClsENT.maxStuQty = objvCurrEduClsENS.maxStuQty; //最大学生数
        objvCurrEduClsENT.weekQty = objvCurrEduClsENS.weekQty; //总周数
        objvCurrEduClsENT.scheUnitPW = objvCurrEduClsENS.scheUnitPW; //周排课次数
        objvCurrEduClsENT.weekStatusID = objvCurrEduClsENS.weekStatusID; //周状态编号(单,双,全周)
        objvCurrEduClsENT.customerWeek = objvCurrEduClsENS.customerWeek; //自定义上课周
        objvCurrEduClsENT.lessonQtyPerWeek = objvCurrEduClsENS.lessonQtyPerWeek; //周课时数
        objvCurrEduClsENT.mark = objvCurrEduClsENS.mark; //获得学分
        objvCurrEduClsENT.id_UniZone = objvCurrEduClsENS.id_UniZone; //校区流水号
        objvCurrEduClsENT.id_GradeBase = objvCurrEduClsENS.id_GradeBase; //年级流水号
        objvCurrEduClsENT.gradeBaseID = objvCurrEduClsENS.gradeBaseID; //年级代号
        objvCurrEduClsENT.gradeBaseName = objvCurrEduClsENS.gradeBaseName; //年级名称
        objvCurrEduClsENT.gradeBaseNameA = objvCurrEduClsENS.gradeBaseNameA; //年级名称缩写
        objvCurrEduClsENT.isEffective = objvCurrEduClsENS.isEffective; //是否有效
        objvCurrEduClsENT.isForPaperReading = objvCurrEduClsENS.isForPaperReading; //是否参与论文阅读
        objvCurrEduClsENT.schoolYear = objvCurrEduClsENS.schoolYear; //学年
        objvCurrEduClsENT.schoolTerm = objvCurrEduClsENS.schoolTerm; //学期
        objvCurrEduClsENT.id_CourseType = objvCurrEduClsENS.id_CourseType; //课程类型流水号
        objvCurrEduClsENT.courseTypeID = objvCurrEduClsENS.courseTypeID; //课程类型ID
        objvCurrEduClsENT.courseTypeName = objvCurrEduClsENS.courseTypeName; //课程类型名称
        objvCurrEduClsENT.isDegree = objvCurrEduClsENS.isDegree; //是否学位课
        objvCurrEduClsENT.id_ScoreType = objvCurrEduClsENS.id_ScoreType; //成绩类型流水号
        objvCurrEduClsENT.getScoreWayId = objvCurrEduClsENS.getScoreWayId; //获得成绩方式Id
        objvCurrEduClsENT.isProportionalCtrl = objvCurrEduClsENS.isProportionalCtrl; //是否比例控制
        objvCurrEduClsENT.id_ExamType = objvCurrEduClsENS.id_ExamType; //考试方式流水号
        objvCurrEduClsENT.beginWeek = objvCurrEduClsENS.beginWeek; //开始周
        objvCurrEduClsENT.modifyDate = objvCurrEduClsENS.modifyDate; //修改日期
        objvCurrEduClsENT.modifyUserID = objvCurrEduClsENS.modifyUserID; //修改人
        objvCurrEduClsENT.memo = objvCurrEduClsENS.memo; //备注
        objvCurrEduClsENT.currStuNum_Valid = objvCurrEduClsENS.currStuNum_Valid; //CurrStuNum_Valid
        objvCurrEduClsENT.currStuNum = objvCurrEduClsENS.currStuNum; //当前学生数
    }
    exports.vCurrEduCls_CopyObjTo = vCurrEduCls_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvCurrEduClsENS:源对象
     * @param objvCurrEduClsENT:目标对象
    */
    function vCurrEduCls_GetObjFromJsonObj(objvCurrEduClsENS) {
        const objvCurrEduClsENT = new clsvCurrEduClsEN_js_1.clsvCurrEduClsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsENT, objvCurrEduClsENS);
        return objvCurrEduClsENT;
    }
    exports.vCurrEduCls_GetObjFromJsonObj = vCurrEduCls_GetObjFromJsonObj;
});
