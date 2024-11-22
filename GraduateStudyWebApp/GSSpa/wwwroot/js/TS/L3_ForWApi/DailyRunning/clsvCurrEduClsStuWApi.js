/**
* 类名:clsvCurrEduClsStuWApi
* 表名:vCurrEduClsStu(01120127)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vCurrEduClsStu_GetObjFromJsonObj = exports.vCurrEduClsStu_CopyObjTo = exports.vCurrEduClsStu_GetCombineCondition = exports.vCurrEduClsStu_GetObjByJSONStr = exports.vCurrEduClsStu_GetObjLstByJSONObjLst = exports.vCurrEduClsStu_GetObjLstByJSONStr = exports.vCurrEduClsStu_GetJSONStrByObj = exports.vCurrEduClsStu_ReFreshThisCache = exports.vCurrEduClsStu_GetWebApiUrl = exports.vCurrEduClsStu_GetRecCountByCond_Cache = exports.vCurrEduClsStu_GetRecCountByCondAsync = exports.vCurrEduClsStu_IsExistAsync = exports.vCurrEduClsStu_IsExist_Cache = exports.vCurrEduClsStu_IsExist = exports.vCurrEduClsStu_IsExistRecordAsync = exports.vCurrEduClsStu_IsExistRecord_Cache = exports.vCurrEduClsStu_GetObjLstByPagerAsync = exports.vCurrEduClsStu_GetObjLstByPager_Cache = exports.vCurrEduClsStu_GetObjLstByRange = exports.vCurrEduClsStu_GetObjLstByRangeAsync = exports.vCurrEduClsStu_GetTopObjLstAsync = exports.vCurrEduClsStu_GetObjLstByid_EduClsStuLst_Cache = exports.vCurrEduClsStu_GetObjLstByid_EduClsStuLstAsync = exports.vCurrEduClsStu_GetSubObjLst_Cache = exports.vCurrEduClsStu_GetObjLst_PureCache = exports.vCurrEduClsStu_GetObjLst_Cache = exports.vCurrEduClsStu_GetObjLst_sessionStorage_PureCache = exports.vCurrEduClsStu_GetObjLst_sessionStorage = exports.vCurrEduClsStu_GetObjLstAsync = exports.vCurrEduClsStu_GetObjLst_localStorage_PureCache = exports.vCurrEduClsStu_GetObjLst_localStorage = exports.vCurrEduClsStu_GetObjLst_ClientCache = exports.vCurrEduClsStu_GetFirstObjAsync = exports.vCurrEduClsStu_GetFirstID = exports.vCurrEduClsStu_GetFirstIDAsync = exports.vCurrEduClsStu_FilterFunByKey = exports.vCurrEduClsStu_SortFunByKey = exports.vCurrEduClsStu_SortFun_Defa_2Fld = exports.vCurrEduClsStu_SortFun_Defa = exports.vCurrEduClsStu_func = exports.vCurrEduClsStu_GetObjByid_EduClsStu_localStorage = exports.vCurrEduClsStu_GetObjByid_EduClsStu_Cache = exports.vCurrEduClsStu_GetObjByid_EduClsStuAsync = exports.vCurrEduClsStu_ConstructorName = exports.vCurrEduClsStu_Controller = void 0;
    /**
     * v教学班与学生关系(vCurrEduClsStu)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvCurrEduClsStuEN_js_1 = require("../../L0_Entity/DailyRunning/clsvCurrEduClsStuEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vCurrEduClsStu_Controller = "vCurrEduClsStuApi";
    exports.vCurrEduClsStu_ConstructorName = "vCurrEduClsStu";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngid_EduClsStu:关键字
    * @returns 对象
    **/
    async function vCurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu) {
        const strThisFuncName = "GetObjByid_EduClsStuAsync";
        if (lngid_EduClsStu == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStuAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_EduClsStu";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngid_EduClsStu": lngid_EduClsStu,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvCurrEduClsStu = vCurrEduClsStu_GetObjFromJsonObj(returnObj);
                return objvCurrEduClsStu;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetObjByid_EduClsStuAsync = vCurrEduClsStu_GetObjByid_EduClsStuAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngid_EduClsStu:所给的关键字
     * @returns 对象
    */
    async function vCurrEduClsStu_GetObjByid_EduClsStu_Cache(lngid_EduClsStu, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_EduClsStu_Cache";
        if (lngid_EduClsStu == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStu_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache.filter(x => x.id_EduClsStu == lngid_EduClsStu);
            let objvCurrEduClsStu;
            if (arrvCurrEduClsStu_Sel.length > 0) {
                objvCurrEduClsStu = arrvCurrEduClsStu_Sel[0];
                return objvCurrEduClsStu;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvCurrEduClsStu = await vCurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu);
                    if (objvCurrEduClsStu != null) {
                        vCurrEduClsStu_ReFreshThisCache(strid_CurrEduCls);
                        return objvCurrEduClsStu;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsStu, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vCurrEduClsStu_GetObjByid_EduClsStu_Cache = vCurrEduClsStu_GetObjByid_EduClsStu_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngid_EduClsStu:所给的关键字
     * @returns 对象
    */
    async function vCurrEduClsStu_GetObjByid_EduClsStu_localStorage(lngid_EduClsStu) {
        const strThisFuncName = "GetObjByid_EduClsStu_localStorage";
        if (lngid_EduClsStu == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngid_EduClsStu]不能为空！(In GetObjByid_EduClsStu_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, lngid_EduClsStu);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvCurrEduClsStu_Cache = JSON.parse(strTempObj);
            return objvCurrEduClsStu_Cache;
        }
        try {
            const objvCurrEduClsStu = await vCurrEduClsStu_GetObjByid_EduClsStuAsync(lngid_EduClsStu);
            if (objvCurrEduClsStu != null) {
                localStorage.setItem(strKey, JSON.stringify(objvCurrEduClsStu));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvCurrEduClsStu;
            }
            return objvCurrEduClsStu;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngid_EduClsStu, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vCurrEduClsStu_GetObjByid_EduClsStu_localStorage = vCurrEduClsStu_GetObjByid_EduClsStu_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strid_CurrEduCls:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function vCurrEduClsStu_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngid_EduClsStu = Number(strInValue);
        if (lngid_EduClsStu == 0) {
            return "";
        }
        const objvCurrEduClsStu = await vCurrEduClsStu_GetObjByid_EduClsStu_Cache(lngid_EduClsStu, strid_CurrEduCls_C);
        if (objvCurrEduClsStu == null)
            return "";
        return objvCurrEduClsStu.GetFldValue(strOutFldName).toString();
    }
    exports.vCurrEduClsStu_func = vCurrEduClsStu_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsStu_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_EduClsStu - b.id_EduClsStu;
    }
    exports.vCurrEduClsStu_SortFun_Defa = vCurrEduClsStu_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsStu_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.id_CurrEduCls == b.id_CurrEduCls)
            return a.currEduClsId.localeCompare(b.currEduClsId);
        else
            return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
    }
    exports.vCurrEduClsStu_SortFun_Defa_2Fld = vCurrEduClsStu_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vCurrEduClsStu_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu:
                    return (a, b) => {
                        return a.id_EduClsStu - b.id_EduClsStu;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId:
                    return (a, b) => {
                        return a.currEduClsId.localeCompare(b.currEduClsId);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseId:
                    return (a, b) => {
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseCode:
                    return (a, b) => {
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseName:
                    return (a, b) => {
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionId:
                    return (a, b) => {
                        return a.teachingSolutionId.localeCompare(b.teachingSolutionId);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionName:
                    return (a, b) => {
                        return a.teachingSolutionName.localeCompare(b.teachingSolutionName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeID:
                    return (a, b) => {
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return a.lessonQtyPerWeek - b.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Mark:
                    return (a, b) => {
                        return a.mark - b.mark;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_UniZone:
                    return (a, b) => {
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GradeBaseName:
                    return (a, b) => {
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsEffective:
                    return (a, b) => {
                        if (a.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CourseType:
                    return (a, b) => {
                        return a.id_CourseType.localeCompare(b.id_CourseType);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeID:
                    return (a, b) => {
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeName:
                    return (a, b) => {
                        return a.courseTypeName.localeCompare(b.courseTypeName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsDegree:
                    return (a, b) => {
                        if (a.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrStuNum:
                    return (a, b) => {
                        return a.currStuNum - b.currStuNum;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Stu:
                    return (a, b) => {
                        return a.id_Stu.localeCompare(b.id_Stu);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID:
                    return (a, b) => {
                        return a.stuID.localeCompare(b.stuID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuName:
                    return (a, b) => {
                        return a.stuName.localeCompare(b.stuName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SexDesc:
                    return (a, b) => {
                        return a.sexDesc.localeCompare(b.sexDesc);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorID:
                    return (a, b) => {
                        return a.majorID.localeCompare(b.majorID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_AdminCls:
                    return (a, b) => {
                        return a.id_AdminCls.localeCompare(b.id_AdminCls);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Birthday:
                    return (a, b) => {
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsStuStateID:
                    return (a, b) => {
                        return a.eduClsStuStateID.localeCompare(b.eduClsStuStateID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GetScoreTimes:
                    return (a, b) => {
                        return a.getScoreTimes - b.getScoreTimes;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TotalScores:
                    return (a, b) => {
                        return a.totalScores - b.totalScores;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Ranking:
                    return (a, b) => {
                        return a.ranking - b.ranking;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Percentile:
                    return (a, b) => {
                        return a.percentile - b.percentile;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Confirmed:
                    return (a, b) => {
                        if (a.confirmed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolTerm:
                    return (a, b) => {
                        return a.schoolTerm.localeCompare(b.schoolTerm);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolYear:
                    return (a, b) => {
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInDate:
                    return (a, b) => {
                        return a.signInDate.localeCompare(b.signInDate);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInStateID:
                    return (a, b) => {
                        return a.signInStateID.localeCompare(b.signInStateID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInUser:
                    return (a, b) => {
                        return a.signInUser.localeCompare(b.signInUser);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyDate:
                    return (a, b) => {
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyUserID:
                    return (a, b) => {
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName4Stu:
                    return (a, b) => {
                        return a.collegeName4Stu.localeCompare(b.collegeName4Stu);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeName:
                    return (a, b) => {
                        return a.eduClsTypeName.localeCompare(b.eduClsTypeName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsSynScore:
                    return (a, b) => {
                        if (a.isSynScore == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeId:
                    return (a, b) => {
                        return a.eduClsTypeId.localeCompare(b.eduClsTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsStu]中不存在！(in ${exports.vCurrEduClsStu_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu:
                    return (a, b) => {
                        return b.id_EduClsStu - a.id_EduClsStu;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId:
                    return (a, b) => {
                        return b.currEduClsId.localeCompare(a.currEduClsId);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseId:
                    return (a, b) => {
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseCode:
                    return (a, b) => {
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseName:
                    return (a, b) => {
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionId:
                    return (a, b) => {
                        return b.teachingSolutionId.localeCompare(a.teachingSolutionId);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionName:
                    return (a, b) => {
                        return b.teachingSolutionName.localeCompare(a.teachingSolutionName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeID:
                    return (a, b) => {
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
                    return (a, b) => {
                        return b.lessonQtyPerWeek - a.lessonQtyPerWeek;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Mark:
                    return (a, b) => {
                        return b.mark - a.mark;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_UniZone:
                    return (a, b) => {
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GradeBaseName:
                    return (a, b) => {
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsEffective:
                    return (a, b) => {
                        if (b.isEffective == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CourseType:
                    return (a, b) => {
                        return b.id_CourseType.localeCompare(a.id_CourseType);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeID:
                    return (a, b) => {
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeName:
                    return (a, b) => {
                        return b.courseTypeName.localeCompare(a.courseTypeName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsDegree:
                    return (a, b) => {
                        if (b.isDegree == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrStuNum:
                    return (a, b) => {
                        return b.currStuNum - a.currStuNum;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Stu:
                    return (a, b) => {
                        return b.id_Stu.localeCompare(a.id_Stu);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID:
                    return (a, b) => {
                        return b.stuID.localeCompare(a.stuID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuName:
                    return (a, b) => {
                        return b.stuName.localeCompare(a.stuName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SexDesc:
                    return (a, b) => {
                        return b.sexDesc.localeCompare(a.sexDesc);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorID:
                    return (a, b) => {
                        return b.majorID.localeCompare(a.majorID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_AdminCls:
                    return (a, b) => {
                        return b.id_AdminCls.localeCompare(a.id_AdminCls);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Birthday:
                    return (a, b) => {
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsStuStateID:
                    return (a, b) => {
                        return b.eduClsStuStateID.localeCompare(a.eduClsStuStateID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GetScoreTimes:
                    return (a, b) => {
                        return b.getScoreTimes - a.getScoreTimes;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TotalScores:
                    return (a, b) => {
                        return b.totalScores - a.totalScores;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Ranking:
                    return (a, b) => {
                        return b.ranking - a.ranking;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Percentile:
                    return (a, b) => {
                        return b.percentile - a.percentile;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Confirmed:
                    return (a, b) => {
                        if (b.confirmed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolTerm:
                    return (a, b) => {
                        return b.schoolTerm.localeCompare(a.schoolTerm);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolYear:
                    return (a, b) => {
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInDate:
                    return (a, b) => {
                        return b.signInDate.localeCompare(a.signInDate);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInStateID:
                    return (a, b) => {
                        return b.signInStateID.localeCompare(a.signInStateID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInUser:
                    return (a, b) => {
                        return b.signInUser.localeCompare(a.signInUser);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyDate:
                    return (a, b) => {
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyUserID:
                    return (a, b) => {
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName4Stu:
                    return (a, b) => {
                        return b.collegeName4Stu.localeCompare(a.collegeName4Stu);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeName:
                    return (a, b) => {
                        return b.eduClsTypeName.localeCompare(a.eduClsTypeName);
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsSynScore:
                    return (a, b) => {
                        if (b.isSynScore == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeId:
                    return (a, b) => {
                        return b.eduClsTypeId.localeCompare(a.eduClsTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsStu]中不存在！(in ${exports.vCurrEduClsStu_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vCurrEduClsStu_SortFunByKey = vCurrEduClsStu_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vCurrEduClsStu_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu:
                return (obj) => {
                    return obj.id_EduClsStu === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId:
                return (obj) => {
                    return obj.currEduClsId === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionId:
                return (obj) => {
                    return obj.teachingSolutionId === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionName:
                return (obj) => {
                    return obj.teachingSolutionName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_LessonQtyPerWeek:
                return (obj) => {
                    return obj.lessonQtyPerWeek === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Mark:
                return (obj) => {
                    return obj.mark === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsEffective:
                return (obj) => {
                    return obj.isEffective === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CourseType:
                return (obj) => {
                    return obj.id_CourseType === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeName:
                return (obj) => {
                    return obj.courseTypeName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsDegree:
                return (obj) => {
                    return obj.isDegree === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrStuNum:
                return (obj) => {
                    return obj.currStuNum === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Stu:
                return (obj) => {
                    return obj.id_Stu === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID:
                return (obj) => {
                    return obj.stuID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuName:
                return (obj) => {
                    return obj.stuName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SexDesc:
                return (obj) => {
                    return obj.sexDesc === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorID:
                return (obj) => {
                    return obj.majorID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_AdminCls:
                return (obj) => {
                    return obj.id_AdminCls === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsStuStateID:
                return (obj) => {
                    return obj.eduClsStuStateID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GetScoreTimes:
                return (obj) => {
                    return obj.getScoreTimes === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TotalScores:
                return (obj) => {
                    return obj.totalScores === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Ranking:
                return (obj) => {
                    return obj.ranking === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Percentile:
                return (obj) => {
                    return obj.percentile === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Confirmed:
                return (obj) => {
                    return obj.confirmed === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolTerm:
                return (obj) => {
                    return obj.schoolTerm === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInDate:
                return (obj) => {
                    return obj.signInDate === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInStateID:
                return (obj) => {
                    return obj.signInStateID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInUser:
                return (obj) => {
                    return obj.signInUser === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName4Stu:
                return (obj) => {
                    return obj.collegeName4Stu === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeName:
                return (obj) => {
                    return obj.eduClsTypeName === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsSynScore:
                return (obj) => {
                    return obj.isSynScore === value;
                };
            case clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeId:
                return (obj) => {
                    return obj.eduClsTypeId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vCurrEduClsStu]中不存在！(in ${exports.vCurrEduClsStu_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vCurrEduClsStu_FilterFunByKey = vCurrEduClsStu_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vCurrEduClsStu_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetFirstIDAsync = vCurrEduClsStu_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vCurrEduClsStu_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetFirstID = vCurrEduClsStu_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vCurrEduClsStu_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvCurrEduClsStu = vCurrEduClsStu_GetObjFromJsonObj(returnObj);
                return objvCurrEduClsStu;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetFirstObjAsync = vCurrEduClsStu_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
        clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvCurrEduClsStuExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvCurrEduClsStuObjLst_T = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuExObjLst_Cache);
            return arrvCurrEduClsStuObjLst_T;
        }
        try {
            const arrvCurrEduClsStuExObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvCurrEduClsStuExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsStuExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsStuExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduClsStu_GetObjLst_ClientCache = vCurrEduClsStu_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
        clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduClsStuExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduClsStuObjLst_T = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuExObjLst_Cache);
            return arrvCurrEduClsStuObjLst_T;
        }
        try {
            const arrvCurrEduClsStuExObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsStuExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsStuExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsStuExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduClsStu_GetObjLst_localStorage = vCurrEduClsStu_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvCurrEduClsStuObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduClsStuObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduClsStu_GetObjLst_localStorage_PureCache = vCurrEduClsStu_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduClsStu_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetObjLstAsync = vCurrEduClsStu_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
        clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduClsStuExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvCurrEduClsStuObjLst_T = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuExObjLst_Cache);
            return arrvCurrEduClsStuObjLst_T;
        }
        try {
            const arrvCurrEduClsStuExObjLst = await vCurrEduClsStu_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvCurrEduClsStuExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvCurrEduClsStuExObjLst.length);
            console.log(strInfo);
            return arrvCurrEduClsStuExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vCurrEduClsStu_GetObjLst_sessionStorage = vCurrEduClsStu_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvCurrEduClsStuObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvCurrEduClsStuObjLst_Cache;
        }
        else
            return null;
    }
    exports.vCurrEduClsStu_GetObjLst_sessionStorage_PureCache = vCurrEduClsStu_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvCurrEduClsStuObjLst_Cache;
        switch (clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvCurrEduClsStuObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuObjLst_Cache);
        return arrvCurrEduClsStuObjLst_Cache;
    }
    exports.vCurrEduClsStu_GetObjLst_Cache = vCurrEduClsStu_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vCurrEduClsStu_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvCurrEduClsStuObjLst_Cache;
        switch (clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheModeId) {
            case "04": //sessionStorage
                arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvCurrEduClsStuObjLst_Cache = null;
                break;
            default:
                arrvCurrEduClsStuObjLst_Cache = null;
                break;
        }
        return arrvCurrEduClsStuObjLst_Cache;
    }
    exports.vCurrEduClsStu_GetObjLst_PureCache = vCurrEduClsStu_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngid_EduClsStu_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduClsStu_GetSubObjLst_Cache(objvCurrEduClsStu_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
        let arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache;
        if (objvCurrEduClsStu_Cond.sf_FldComparisonOp == null || objvCurrEduClsStu_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduClsStu_Sel;
        const dicFldComparisonOp = JSON.parse(objvCurrEduClsStu_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduClsStu_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduClsStu_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduClsStu_Cond), exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsStu_GetSubObjLst_Cache = vCurrEduClsStu_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_EduClsStu:关键字列表
    * @returns 对象列表
    **/
    async function vCurrEduClsStu_GetObjLstByid_EduClsStuLstAsync(arrid_EduClsStu) {
        const strThisFuncName = "GetObjLstByid_EduClsStuLstAsync";
        const strAction = "GetObjLstByid_EduClsStuLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_EduClsStu);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetObjLstByid_EduClsStuLstAsync = vCurrEduClsStu_GetObjLstByid_EduClsStuLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngid_EduClsStuLst:关键字列表
     * @returns 对象列表
    */
    async function vCurrEduClsStu_GetObjLstByid_EduClsStuLst_Cache(arrid_EduClsStuLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByid_EduClsStuLst_Cache";
        try {
            const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
            const arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache.filter(x => arrid_EduClsStuLst.indexOf(x.id_EduClsStu) > -1);
            return arrvCurrEduClsStu_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_EduClsStuLst.join(","), exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsStu_GetObjLstByid_EduClsStuLst_Cache = vCurrEduClsStu_GetObjLstByid_EduClsStuLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vCurrEduClsStu_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetTopObjLstAsync = vCurrEduClsStu_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduClsStu_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetObjLstByRangeAsync = vCurrEduClsStu_GetObjLstByRangeAsync;
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
    async function vCurrEduClsStu_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetObjLstByRange = vCurrEduClsStu_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vCurrEduClsStu_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsStuObjLst_Cache.length == 0)
            return arrvCurrEduClsStuObjLst_Cache;
        let arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvCurrEduClsStu_Cond = new clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsStu_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvCurrEduClsStuWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduClsStu_Sel.length == 0)
                return arrvCurrEduClsStu_Sel;
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
                arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.sort(vCurrEduClsStu_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.sort(objPagerPara.sortFun);
            }
            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.slice(intStart, intEnd);
            return arrvCurrEduClsStu_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vCurrEduClsStu_GetObjLstByPager_Cache = vCurrEduClsStu_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vCurrEduClsStu_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetObjLstByPagerAsync = vCurrEduClsStu_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngid_EduClsStu_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vCurrEduClsStu_IsExistRecord_Cache(objvCurrEduClsStu_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsStuObjLst_Cache == null)
            return false;
        let arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache;
        if (objvCurrEduClsStu_Cond.sf_FldComparisonOp == null || objvCurrEduClsStu_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduClsStu_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvCurrEduClsStu_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduClsStu_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvCurrEduClsStu_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvCurrEduClsStu_Cond), exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vCurrEduClsStu_IsExistRecord_Cache = vCurrEduClsStu_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vCurrEduClsStu_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_IsExistRecordAsync = vCurrEduClsStu_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngid_EduClsStu:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vCurrEduClsStu_IsExist(lngid_EduClsStu, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_EduClsStu": lngid_EduClsStu,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_IsExist = vCurrEduClsStu_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngid_EduClsStu:所给的关键字
     * @returns 对象
    */
    async function vCurrEduClsStu_IsExist_Cache(lngid_EduClsStu, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsStuObjLst_Cache == null)
            return false;
        try {
            const arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache.filter(x => x.id_EduClsStu == lngid_EduClsStu);
            if (arrvCurrEduClsStu_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngid_EduClsStu, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vCurrEduClsStu_IsExist_Cache = vCurrEduClsStu_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngid_EduClsStu:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vCurrEduClsStu_IsExistAsync(lngid_EduClsStu) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngid_EduClsStu": lngid_EduClsStu }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_IsExistAsync = vCurrEduClsStu_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vCurrEduClsStu_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vCurrEduClsStu_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vCurrEduClsStu_GetRecCountByCondAsync = vCurrEduClsStu_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvCurrEduClsStu_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vCurrEduClsStu_GetRecCountByCond_Cache(objvCurrEduClsStu_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvCurrEduClsStuObjLst_Cache = await vCurrEduClsStu_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvCurrEduClsStuObjLst_Cache == null)
            return 0;
        let arrvCurrEduClsStu_Sel = arrvCurrEduClsStuObjLst_Cache;
        if (objvCurrEduClsStu_Cond.sf_FldComparisonOp == null || objvCurrEduClsStu_Cond.sf_FldComparisonOp == "")
            return arrvCurrEduClsStu_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvCurrEduClsStu_Cond.sf_FldComparisonOp);
        //console.log("clsvCurrEduClsStuWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvCurrEduClsStu_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvCurrEduClsStu_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvCurrEduClsStu_Sel = arrvCurrEduClsStu_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvCurrEduClsStu_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvCurrEduClsStu_Cond), exports.vCurrEduClsStu_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vCurrEduClsStu_GetRecCountByCond_Cache = vCurrEduClsStu_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vCurrEduClsStu_GetWebApiUrl(strController, strAction) {
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
    exports.vCurrEduClsStu_GetWebApiUrl = vCurrEduClsStu_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vCurrEduClsStu_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN._CurrTabName, strid_CurrEduCls);
            switch (clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.CacheModeId) {
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
    exports.vCurrEduClsStu_ReFreshThisCache = vCurrEduClsStu_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduClsStu_GetJSONStrByObj(pobjvCurrEduClsStuEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvCurrEduClsStuEN);
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
    exports.vCurrEduClsStu_GetJSONStrByObj = vCurrEduClsStu_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduClsStu_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvCurrEduClsStuObjLst = new Array();
        if (strJSON === "") {
            return arrvCurrEduClsStuObjLst;
        }
        try {
            arrvCurrEduClsStuObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvCurrEduClsStuObjLst;
        }
        return arrvCurrEduClsStuObjLst;
    }
    exports.vCurrEduClsStu_GetObjLstByJSONStr = vCurrEduClsStu_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvCurrEduClsStuObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vCurrEduClsStu_GetObjLstByJSONObjLst(arrvCurrEduClsStuObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvCurrEduClsStuObjLst = new Array();
        for (const objInFor of arrvCurrEduClsStuObjLstS) {
            const obj1 = vCurrEduClsStu_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvCurrEduClsStuObjLst.push(obj1);
        }
        return arrvCurrEduClsStuObjLst;
    }
    exports.vCurrEduClsStu_GetObjLstByJSONObjLst = vCurrEduClsStu_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vCurrEduClsStu_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvCurrEduClsStuEN = new clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN();
        if (strJSON === "") {
            return pobjvCurrEduClsStuEN;
        }
        try {
            pobjvCurrEduClsStuEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvCurrEduClsStuEN;
        }
        return pobjvCurrEduClsStuEN;
    }
    exports.vCurrEduClsStu_GetObjByJSONStr = vCurrEduClsStu_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vCurrEduClsStu_GetCombineCondition(objvCurrEduClsStu_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu) == true) {
            const strComparisonOp_id_EduClsStu = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_EduClsStu, objvCurrEduClsStu_Cond.id_EduClsStu, strComparisonOp_id_EduClsStu);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CurrEduCls, objvCurrEduClsStu_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId) == true) {
            const strComparisonOp_CurrEduClsId = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrEduClsId, objvCurrEduClsStu_Cond.currEduClsId, strComparisonOp_CurrEduClsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsName, objvCurrEduClsStu_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseId, objvCurrEduClsStu_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseCode, objvCurrEduClsStu_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseName, objvCurrEduClsStu_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionId) == true) {
            const strComparisonOp_TeachingSolutionId = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionId, objvCurrEduClsStu_Cond.teachingSolutionId, strComparisonOp_TeachingSolutionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionName) == true) {
            const strComparisonOp_TeachingSolutionName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TeachingSolutionName, objvCurrEduClsStu_Cond.teachingSolutionName, strComparisonOp_TeachingSolutionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_XzCollege, objvCurrEduClsStu_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeID, objvCurrEduClsStu_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName, objvCurrEduClsStu_Cond.collegeName, strComparisonOp_CollegeName);
        }
        //数据类型number(smallint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Mark) == true) {
            const strComparisonOp_Mark = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Mark];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Mark, objvCurrEduClsStu_Cond.mark, strComparisonOp_Mark);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_UniZone, objvCurrEduClsStu_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_GradeBaseName, objvCurrEduClsStu_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsEffective) == true) {
            if (objvCurrEduClsStu_Cond.isEffective == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsEffective);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsEffective);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CourseType) == true) {
            const strComparisonOp_id_CourseType = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CourseType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_CourseType, objvCurrEduClsStu_Cond.id_CourseType, strComparisonOp_id_CourseType);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeID, objvCurrEduClsStu_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeName) == true) {
            const strComparisonOp_CourseTypeName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CourseTypeName, objvCurrEduClsStu_Cond.courseTypeName, strComparisonOp_CourseTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsDegree) == true) {
            if (objvCurrEduClsStu_Cond.isDegree == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsDegree);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsDegree);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrStuNum) == true) {
            const strComparisonOp_CurrStuNum = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrStuNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CurrStuNum, objvCurrEduClsStu_Cond.currStuNum, strComparisonOp_CurrStuNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Stu) == true) {
            const strComparisonOp_id_Stu = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Stu];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Stu, objvCurrEduClsStu_Cond.id_Stu, strComparisonOp_id_Stu);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID) == true) {
            const strComparisonOp_StuID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuID, objvCurrEduClsStu_Cond.stuID, strComparisonOp_StuID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuName) == true) {
            const strComparisonOp_StuName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_StuName, objvCurrEduClsStu_Cond.stuName, strComparisonOp_StuName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_Sex, objvCurrEduClsStu_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SexDesc) == true) {
            const strComparisonOp_SexDesc = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SexDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SexDesc, objvCurrEduClsStu_Cond.sexDesc, strComparisonOp_SexDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorID) == true) {
            const strComparisonOp_MajorID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorID, objvCurrEduClsStu_Cond.majorID, strComparisonOp_MajorID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_MajorName, objvCurrEduClsStu_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_AdminCls) == true) {
            const strComparisonOp_id_AdminCls = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_AdminCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_id_AdminCls, objvCurrEduClsStu_Cond.id_AdminCls, strComparisonOp_id_AdminCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Birthday, objvCurrEduClsStu_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsStuStateID) == true) {
            const strComparisonOp_EduClsStuStateID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsStuStateID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsStuStateID, objvCurrEduClsStu_Cond.eduClsStuStateID, strComparisonOp_EduClsStuStateID);
        }
        //数据类型number(tinyint)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Score) == true) {
            const strComparisonOp_Score = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Score, objvCurrEduClsStu_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TotalScores) == true) {
            const strComparisonOp_TotalScores = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TotalScores];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_TotalScores, objvCurrEduClsStu_Cond.totalScores, strComparisonOp_TotalScores);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Ranking) == true) {
            const strComparisonOp_Ranking = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Ranking];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Ranking, objvCurrEduClsStu_Cond.ranking, strComparisonOp_Ranking);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Percentile) == true) {
            const strComparisonOp_Percentile = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Percentile];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Percentile, objvCurrEduClsStu_Cond.percentile, strComparisonOp_Percentile);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Confirmed) == true) {
            if (objvCurrEduClsStu_Cond.confirmed == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Confirmed);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_Confirmed);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolTerm) == true) {
            const strComparisonOp_SchoolTerm = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolTerm];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolTerm, objvCurrEduClsStu_Cond.schoolTerm, strComparisonOp_SchoolTerm);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SchoolYear, objvCurrEduClsStu_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInDate) == true) {
            const strComparisonOp_SignInDate = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInDate, objvCurrEduClsStu_Cond.signInDate, strComparisonOp_SignInDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInStateID) == true) {
            const strComparisonOp_SignInStateID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInStateID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInStateID, objvCurrEduClsStu_Cond.signInStateID, strComparisonOp_SignInStateID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInUser) == true) {
            const strComparisonOp_SignInUser = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_SignInUser, objvCurrEduClsStu_Cond.signInUser, strComparisonOp_SignInUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyDate, objvCurrEduClsStu_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_ModifyUserID, objvCurrEduClsStu_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName4Stu) == true) {
            const strComparisonOp_CollegeName4Stu = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName4Stu];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_CollegeName4Stu, objvCurrEduClsStu_Cond.collegeName4Stu, strComparisonOp_CollegeName4Stu);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeName) == true) {
            const strComparisonOp_EduClsTypeName = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeName, objvCurrEduClsStu_Cond.eduClsTypeName, strComparisonOp_EduClsTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsSynScore) == true) {
            if (objvCurrEduClsStu_Cond.isSynScore == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsSynScore);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_IsSynScore);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvCurrEduClsStu_Cond.dicFldComparisonOp, clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeId) == true) {
            const strComparisonOp_EduClsTypeId = objvCurrEduClsStu_Cond.dicFldComparisonOp[clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN.con_EduClsTypeId, objvCurrEduClsStu_Cond.eduClsTypeId, strComparisonOp_EduClsTypeId);
        }
        return strWhereCond;
    }
    exports.vCurrEduClsStu_GetCombineCondition = vCurrEduClsStu_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvCurrEduClsStuENS:源对象
     * @param objvCurrEduClsStuENT:目标对象
    */
    function vCurrEduClsStu_CopyObjTo(objvCurrEduClsStuENS, objvCurrEduClsStuENT) {
        objvCurrEduClsStuENT.id_EduClsStu = objvCurrEduClsStuENS.id_EduClsStu; //教学班学生流水号
        objvCurrEduClsStuENT.id_CurrEduCls = objvCurrEduClsStuENS.id_CurrEduCls; //教学班流水号
        objvCurrEduClsStuENT.currEduClsId = objvCurrEduClsStuENS.currEduClsId; //教学班Id
        objvCurrEduClsStuENT.eduClsName = objvCurrEduClsStuENS.eduClsName; //教学班名
        objvCurrEduClsStuENT.courseId = objvCurrEduClsStuENS.courseId; //课程Id
        objvCurrEduClsStuENT.courseCode = objvCurrEduClsStuENS.courseCode; //课程代码
        objvCurrEduClsStuENT.courseName = objvCurrEduClsStuENS.courseName; //课程名称
        objvCurrEduClsStuENT.teachingSolutionId = objvCurrEduClsStuENS.teachingSolutionId; //教学方案Id
        objvCurrEduClsStuENT.teachingSolutionName = objvCurrEduClsStuENS.teachingSolutionName; //教学方案名称
        objvCurrEduClsStuENT.id_XzCollege = objvCurrEduClsStuENS.id_XzCollege; //学院流水号
        objvCurrEduClsStuENT.collegeID = objvCurrEduClsStuENS.collegeID; //学院ID
        objvCurrEduClsStuENT.collegeName = objvCurrEduClsStuENS.collegeName; //学院名称
        objvCurrEduClsStuENT.lessonQtyPerWeek = objvCurrEduClsStuENS.lessonQtyPerWeek; //周课时数
        objvCurrEduClsStuENT.mark = objvCurrEduClsStuENS.mark; //获得学分
        objvCurrEduClsStuENT.id_UniZone = objvCurrEduClsStuENS.id_UniZone; //校区流水号
        objvCurrEduClsStuENT.gradeBaseName = objvCurrEduClsStuENS.gradeBaseName; //年级名称
        objvCurrEduClsStuENT.isEffective = objvCurrEduClsStuENS.isEffective; //是否有效
        objvCurrEduClsStuENT.id_CourseType = objvCurrEduClsStuENS.id_CourseType; //课程类型流水号
        objvCurrEduClsStuENT.courseTypeID = objvCurrEduClsStuENS.courseTypeID; //课程类型ID
        objvCurrEduClsStuENT.courseTypeName = objvCurrEduClsStuENS.courseTypeName; //课程类型名称
        objvCurrEduClsStuENT.isDegree = objvCurrEduClsStuENS.isDegree; //是否学位课
        objvCurrEduClsStuENT.currStuNum = objvCurrEduClsStuENS.currStuNum; //当前学生数
        objvCurrEduClsStuENT.id_Stu = objvCurrEduClsStuENS.id_Stu; //学生流水号
        objvCurrEduClsStuENT.stuID = objvCurrEduClsStuENS.stuID; //学号
        objvCurrEduClsStuENT.stuName = objvCurrEduClsStuENS.stuName; //姓名
        objvCurrEduClsStuENT.id_Sex = objvCurrEduClsStuENS.id_Sex; //性别流水号
        objvCurrEduClsStuENT.sexDesc = objvCurrEduClsStuENS.sexDesc; //性别名称
        objvCurrEduClsStuENT.majorID = objvCurrEduClsStuENS.majorID; //专业ID
        objvCurrEduClsStuENT.majorName = objvCurrEduClsStuENS.majorName; //专业名称
        objvCurrEduClsStuENT.id_AdminCls = objvCurrEduClsStuENS.id_AdminCls; //行政班流水号
        objvCurrEduClsStuENT.birthday = objvCurrEduClsStuENS.birthday; //出生日期
        objvCurrEduClsStuENT.eduClsStuStateID = objvCurrEduClsStuENS.eduClsStuStateID; //教学班学生状态编号
        objvCurrEduClsStuENT.getScoreTimes = objvCurrEduClsStuENS.getScoreTimes; //获得成绩次数
        objvCurrEduClsStuENT.score = objvCurrEduClsStuENS.score; //得分
        objvCurrEduClsStuENT.totalScores = objvCurrEduClsStuENS.totalScores; //总分值
        objvCurrEduClsStuENT.ranking = objvCurrEduClsStuENS.ranking; //名次
        objvCurrEduClsStuENT.percentile = objvCurrEduClsStuENS.percentile; //百分位
        objvCurrEduClsStuENT.confirmed = objvCurrEduClsStuENS.confirmed; //是否确认
        objvCurrEduClsStuENT.schoolTerm = objvCurrEduClsStuENS.schoolTerm; //学期
        objvCurrEduClsStuENT.schoolYear = objvCurrEduClsStuENS.schoolYear; //学年
        objvCurrEduClsStuENT.signInDate = objvCurrEduClsStuENS.signInDate; //签入时间
        objvCurrEduClsStuENT.signInStateID = objvCurrEduClsStuENS.signInStateID; //签入状态表流水号
        objvCurrEduClsStuENT.signInUser = objvCurrEduClsStuENS.signInUser; //签入人
        objvCurrEduClsStuENT.modifyDate = objvCurrEduClsStuENS.modifyDate; //修改日期
        objvCurrEduClsStuENT.modifyUserID = objvCurrEduClsStuENS.modifyUserID; //修改人
        objvCurrEduClsStuENT.collegeName4Stu = objvCurrEduClsStuENS.collegeName4Stu; //CollegeName4Stu
        objvCurrEduClsStuENT.eduClsTypeName = objvCurrEduClsStuENS.eduClsTypeName; //教学班类型名称
        objvCurrEduClsStuENT.isSynScore = objvCurrEduClsStuENS.isSynScore; //是否同步成绩
        objvCurrEduClsStuENT.eduClsTypeId = objvCurrEduClsStuENS.eduClsTypeId; //教学班类型Id
    }
    exports.vCurrEduClsStu_CopyObjTo = vCurrEduClsStu_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvCurrEduClsStuENS:源对象
     * @param objvCurrEduClsStuENT:目标对象
    */
    function vCurrEduClsStu_GetObjFromJsonObj(objvCurrEduClsStuENS) {
        const objvCurrEduClsStuENT = new clsvCurrEduClsStuEN_js_1.clsvCurrEduClsStuEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvCurrEduClsStuENT, objvCurrEduClsStuENS);
        return objvCurrEduClsStuENT;
    }
    exports.vCurrEduClsStu_GetObjFromJsonObj = vCurrEduClsStu_GetObjFromJsonObj;
});
