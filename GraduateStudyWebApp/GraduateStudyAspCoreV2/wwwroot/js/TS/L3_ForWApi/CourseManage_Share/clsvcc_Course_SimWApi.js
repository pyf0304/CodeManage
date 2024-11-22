/**
* 类名:clsvcc_Course_SimWApi
* 表名:vcc_Course_Sim(01120950)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/14 00:08:00
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:游戏化教育平台(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:课程管理(CourseManage)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/CourseManage_Share/clsvcc_Course_SimEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vcc_Course_Sim_GetObjFromJsonObj = exports.vcc_Course_Sim_CopyObjTo = exports.vcc_Course_Sim_GetCombineCondition = exports.vcc_Course_Sim_GetObjByJSONStr = exports.vcc_Course_Sim_GetObjLstByJSONObjLst = exports.vcc_Course_Sim_GetObjLstByJSONStr = exports.vcc_Course_Sim_GetJSONStrByObj = exports.vcc_Course_Sim_BindDdl_CourseIdInDiv_Cache = exports.vcc_Course_Sim_ReFreshThisCache = exports.vcc_Course_Sim_GetWebApiUrl = exports.vcc_Course_Sim_GetRecCountByCond_Cache = exports.vcc_Course_Sim_GetRecCountByCondAsync = exports.vcc_Course_Sim_IsExistAsync = exports.vcc_Course_Sim_IsExist_Cache = exports.vcc_Course_Sim_IsExist = exports.vcc_Course_Sim_IsExistRecordAsync = exports.vcc_Course_Sim_IsExistRecord_Cache = exports.vcc_Course_Sim_GetObjLstByPagerAsync = exports.vcc_Course_Sim_GetObjLstByPager_Cache = exports.vcc_Course_Sim_GetObjLstByRange = exports.vcc_Course_Sim_GetObjLstByRangeAsync = exports.vcc_Course_Sim_GetTopObjLstAsync = exports.vcc_Course_Sim_GetObjLstByCourseIdLst_Cache = exports.vcc_Course_Sim_GetObjLstByCourseIdLstAsync = exports.vcc_Course_Sim_GetSubObjLst_Cache = exports.vcc_Course_Sim_GetObjLst_PureCache = exports.vcc_Course_Sim_GetObjLst_Cache = exports.vcc_Course_Sim_GetObjLst_sessionStorage_PureCache = exports.vcc_Course_Sim_GetObjLst_sessionStorage = exports.vcc_Course_Sim_GetObjLstAsync = exports.vcc_Course_Sim_GetObjLst_localStorage_PureCache = exports.vcc_Course_Sim_GetObjLst_localStorage = exports.vcc_Course_Sim_GetObjLst_ClientCache = exports.vcc_Course_Sim_GetFirstObjAsync = exports.vcc_Course_Sim_GetFirstID = exports.vcc_Course_Sim_GetFirstIDAsync = exports.vcc_Course_Sim_funcKey = exports.vcc_Course_Sim_FilterFunByKey = exports.vcc_Course_Sim_SortFunByKey = exports.vcc_Course_Sim_SortFun_Defa_2Fld = exports.vcc_Course_Sim_SortFun_Defa = exports.vcc_Course_Sim_func = exports.vcc_Course_Sim_GetNameByCourseId_Cache = exports.vcc_Course_Sim_GetObjByCourseId_localStorage = exports.vcc_Course_Sim_GetObjByCourseId_Cache = exports.vcc_Course_Sim_GetObjByCourseIdAsync = exports.vcc_Course_Sim_ConstructorName = exports.vcc_Course_Sim_Controller = void 0;
    /**
     * vcc_Course_Sim(vcc_Course_Sim)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月14日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvcc_Course_SimEN_js_1 = require("../../L0_Entity/CourseManage_Share/clsvcc_Course_SimEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vcc_Course_Sim_Controller = "vcc_Course_SimApi";
    exports.vcc_Course_Sim_ConstructorName = "vcc_Course_Sim";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCourseId:关键字
    * @returns 对象
    **/
    async function vcc_Course_Sim_GetObjByCourseIdAsync(strCourseId) {
        const strThisFuncName = "GetObjByCourseIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvcc_Course_SimWApi.GetObjByCourseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvcc_Course_SimWApi.GetObjByCourseIdAsync)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCourseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCourseId": strCourseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvcc_Course_Sim = vcc_Course_Sim_GetObjFromJsonObj(returnObj);
                return objvcc_Course_Sim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetObjByCourseIdAsync = vcc_Course_Sim_GetObjByCourseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_Sim_GetObjByCourseId_Cache(strCourseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCourseId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvcc_Course_SimWApi.GetObjByCourseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvcc_Course_SimWApi.GetObjByCourseId_Cache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        try {
            const arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache.filter(x => x.courseId == strCourseId);
            let objvcc_Course_Sim;
            if (arrvcc_Course_Sim_Sel.length > 0) {
                objvcc_Course_Sim = arrvcc_Course_Sim_Sel[0];
                return objvcc_Course_Sim;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvcc_Course_Sim_Const = await vcc_Course_Sim_GetObjByCourseIdAsync(strCourseId);
                    if (objvcc_Course_Sim_Const != null) {
                        vcc_Course_Sim_ReFreshThisCache();
                        return objvcc_Course_Sim_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vcc_Course_Sim_GetObjByCourseId_Cache = vcc_Course_Sim_GetObjByCourseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_Sim_GetObjByCourseId_localStorage(strCourseId) {
        const strThisFuncName = "GetObjByCourseId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvcc_Course_SimWApi.GetObjByCourseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvcc_Course_SimWApi.GetObjByCourseId_localStorage)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName, strCourseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvcc_Course_Sim_Cache = JSON.parse(strTempObj);
            return objvcc_Course_Sim_Cache;
        }
        try {
            const objvcc_Course_Sim = await vcc_Course_Sim_GetObjByCourseIdAsync(strCourseId);
            if (objvcc_Course_Sim != null) {
                localStorage.setItem(strKey, JSON.stringify(objvcc_Course_Sim));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvcc_Course_Sim;
            }
            return objvcc_Course_Sim;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCourseId, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vcc_Course_Sim_GetObjByCourseId_localStorage = vcc_Course_Sim_GetObjByCourseId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_Sim_GetNameByCourseId_Cache(strCourseId) {
        const strThisFuncName = "GetNameByCourseId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCourseId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCourseId]不能为空！(In clsvcc_Course_SimWApi.GetNameByCourseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCourseId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCourseId]的长度:[{0}]不正确！(clsvcc_Course_SimWApi.GetNameByCourseId_Cache)", strCourseId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrvcc_Course_SimObjLst_Cache == null)
            return "";
        try {
            const arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache.filter(x => x.courseId == strCourseId);
            let objvcc_Course_Sim;
            if (arrvcc_Course_Sim_Sel.length > 0) {
                objvcc_Course_Sim = arrvcc_Course_Sim_Sel[0];
                return objvcc_Course_Sim.courseName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strCourseId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vcc_Course_Sim_GetNameByCourseId_Cache = vcc_Course_Sim_GetNameByCourseId_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vcc_Course_Sim_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCourseId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvcc_Course_Sim = await vcc_Course_Sim_GetObjByCourseId_Cache(strCourseId);
        if (objvcc_Course_Sim == null)
            return "";
        if (objvcc_Course_Sim.GetFldValue(strOutFldName) == null)
            return "";
        return objvcc_Course_Sim.GetFldValue(strOutFldName).toString();
    }
    exports.vcc_Course_Sim_func = vcc_Course_Sim_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_Course_Sim_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.courseId.localeCompare(b.courseId);
    }
    exports.vcc_Course_Sim_SortFun_Defa = vcc_Course_Sim_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_Course_Sim_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.courseCode == b.courseCode)
            return a.courseName.localeCompare(b.courseName);
        else
            return a.courseCode.localeCompare(b.courseCode);
    }
    exports.vcc_Course_Sim_SortFun_Defa_2Fld = vcc_Course_Sim_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vcc_Course_Sim_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId:
                    return (a, b) => {
                        if (a.courseId == null)
                            return -1;
                        if (b.courseId == null)
                            return 1;
                        return a.courseId.localeCompare(b.courseId);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseCode:
                    return (a, b) => {
                        if (a.courseCode == null)
                            return -1;
                        if (b.courseCode == null)
                            return 1;
                        return a.courseCode.localeCompare(b.courseCode);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName:
                    return (a, b) => {
                        if (a.courseName == null)
                            return -1;
                        if (b.courseName == null)
                            return 1;
                        return a.courseName.localeCompare(b.courseName);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseTypeID:
                    return (a, b) => {
                        return a.courseTypeID.localeCompare(b.courseTypeID);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (a.excellentTypeId == null)
                            return -1;
                        if (b.excellentTypeId == null)
                            return 1;
                        return a.excellentTypeId.localeCompare(b.excellentTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_Course_Sim]中不存在！(in ${exports.vcc_Course_Sim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId:
                    return (a, b) => {
                        if (b.courseId == null)
                            return -1;
                        if (a.courseId == null)
                            return 1;
                        return b.courseId.localeCompare(a.courseId);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseCode:
                    return (a, b) => {
                        if (b.courseCode == null)
                            return -1;
                        if (a.courseCode == null)
                            return 1;
                        return b.courseCode.localeCompare(a.courseCode);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName:
                    return (a, b) => {
                        if (b.courseName == null)
                            return -1;
                        if (a.courseName == null)
                            return 1;
                        return b.courseName.localeCompare(a.courseName);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseTypeID:
                    return (a, b) => {
                        return b.courseTypeID.localeCompare(a.courseTypeID);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_ExcellentTypeId:
                    return (a, b) => {
                        if (b.excellentTypeId == null)
                            return -1;
                        if (a.excellentTypeId == null)
                            return 1;
                        return b.excellentTypeId.localeCompare(a.excellentTypeId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vcc_Course_Sim]中不存在！(in ${exports.vcc_Course_Sim_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vcc_Course_Sim_SortFunByKey = vcc_Course_Sim_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vcc_Course_Sim_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId:
                return (obj) => {
                    return obj.courseId === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseCode:
                return (obj) => {
                    return obj.courseCode === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName:
                return (obj) => {
                    return obj.courseName === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseTypeID:
                return (obj) => {
                    return obj.courseTypeID === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_ExcellentTypeId:
                return (obj) => {
                    return obj.excellentTypeId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vcc_Course_Sim]中不存在！(in ${exports.vcc_Course_Sim_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vcc_Course_Sim_FilterFunByKey = vcc_Course_Sim_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vcc_Course_Sim_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvcc_Course_Sim = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrvcc_Course_Sim == null)
            return [];
        let arrvcc_Course_Sim_Sel = arrvcc_Course_Sim;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvcc_Course_Sim_Sel.length == 0)
            return [];
        return arrvcc_Course_Sim_Sel.map(x => x.courseId);
    }
    exports.vcc_Course_Sim_funcKey = vcc_Course_Sim_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vcc_Course_Sim_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetFirstIDAsync = vcc_Course_Sim_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vcc_Course_Sim_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetFirstID = vcc_Course_Sim_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vcc_Course_Sim_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
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
                const objvcc_Course_Sim = vcc_Course_Sim_GetObjFromJsonObj(returnObj);
                return objvcc_Course_Sim;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetFirstObjAsync = vcc_Course_Sim_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvcc_Course_SimExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvcc_Course_SimObjLst_T = vcc_Course_Sim_GetObjLstByJSONObjLst(arrvcc_Course_SimExObjLst_Cache);
            return arrvcc_Course_SimObjLst_T;
        }
        try {
            const arrvcc_Course_SimExObjLst = await vcc_Course_Sim_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvcc_Course_SimExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_Course_SimExObjLst.length);
            console.log(strInfo);
            return arrvcc_Course_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_Course_Sim_GetObjLst_ClientCache = vcc_Course_Sim_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_Course_SimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_Course_SimObjLst_T = vcc_Course_Sim_GetObjLstByJSONObjLst(arrvcc_Course_SimExObjLst_Cache);
            return arrvcc_Course_SimObjLst_T;
        }
        try {
            const arrvcc_Course_SimExObjLst = await vcc_Course_Sim_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvcc_Course_SimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_Course_SimExObjLst.length);
            console.log(strInfo);
            return arrvcc_Course_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_Course_Sim_GetObjLst_localStorage = vcc_Course_Sim_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvcc_Course_SimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_Course_SimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_Course_Sim_GetObjLst_localStorage_PureCache = vcc_Course_Sim_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vcc_Course_Sim_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetObjLstAsync = vcc_Course_Sim_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_Course_SimExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvcc_Course_SimObjLst_T = vcc_Course_Sim_GetObjLstByJSONObjLst(arrvcc_Course_SimExObjLst_Cache);
            return arrvcc_Course_SimObjLst_T;
        }
        try {
            const arrvcc_Course_SimExObjLst = await vcc_Course_Sim_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvcc_Course_SimExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvcc_Course_SimExObjLst.length);
            console.log(strInfo);
            return arrvcc_Course_SimExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vcc_Course_Sim_GetObjLst_sessionStorage = vcc_Course_Sim_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvcc_Course_SimObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvcc_Course_SimObjLst_Cache;
        }
        else
            return null;
    }
    exports.vcc_Course_Sim_GetObjLst_sessionStorage_PureCache = vcc_Course_Sim_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvcc_Course_SimObjLst_Cache;
        switch (clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_ClientCache();
                break;
            default:
                arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_ClientCache();
                break;
        }
        const arrvcc_Course_SimObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst(arrvcc_Course_SimObjLst_Cache);
        return arrvcc_Course_SimObjLst_Cache;
    }
    exports.vcc_Course_Sim_GetObjLst_Cache = vcc_Course_Sim_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vcc_Course_Sim_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvcc_Course_SimObjLst_Cache;
        switch (clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheModeId) {
            case "04": //sessionStorage
                arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvcc_Course_SimObjLst_Cache = null;
                break;
            default:
                arrvcc_Course_SimObjLst_Cache = null;
                break;
        }
        return arrvcc_Course_SimObjLst_Cache;
    }
    exports.vcc_Course_Sim_GetObjLst_PureCache = vcc_Course_Sim_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCourseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_Course_Sim_GetSubObjLst_Cache(objvcc_Course_Sim_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        let arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache;
        if (objvcc_Course_Sim_Cond.sf_FldComparisonOp == null || objvcc_Course_Sim_Cond.sf_FldComparisonOp == "")
            return arrvcc_Course_Sim_Sel;
        const dicFldComparisonOp = JSON.parse(objvcc_Course_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_Course_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_Course_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_Course_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvcc_Course_Sim_Cond), exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_Course_Sim_GetSubObjLst_Cache = vcc_Course_Sim_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCourseId:关键字列表
    * @returns 对象列表
    **/
    async function vcc_Course_Sim_GetObjLstByCourseIdLstAsync(arrCourseId) {
        const strThisFuncName = "GetObjLstByCourseIdLstAsync";
        const strAction = "GetObjLstByCourseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCourseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetObjLstByCourseIdLstAsync = vcc_Course_Sim_GetObjLstByCourseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCourseIdLst:关键字列表
     * @returns 对象列表
    */
    async function vcc_Course_Sim_GetObjLstByCourseIdLst_Cache(arrCourseIdLst) {
        const strThisFuncName = "GetObjLstByCourseIdLst_Cache";
        try {
            const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
            const arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache.filter(x => arrCourseIdLst.indexOf(x.courseId) > -1);
            return arrvcc_Course_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCourseIdLst.join(","), exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vcc_Course_Sim_GetObjLstByCourseIdLst_Cache = vcc_Course_Sim_GetObjLstByCourseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vcc_Course_Sim_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetTopObjLstAsync = vcc_Course_Sim_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_Course_Sim_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetObjLstByRangeAsync = vcc_Course_Sim_GetObjLstByRangeAsync;
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
    async function vcc_Course_Sim_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetObjLstByRange = vcc_Course_Sim_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vcc_Course_Sim_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrvcc_Course_SimObjLst_Cache.length == 0)
            return arrvcc_Course_SimObjLst_Cache;
        let arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvcc_Course_Sim_Cond = new clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_Course_Sim_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvcc_Course_SimWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_Course_Sim_Sel.length == 0)
                return arrvcc_Course_Sim_Sel;
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
                arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.sort(vcc_Course_Sim_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.sort(objPagerPara.sortFun);
            }
            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.slice(intStart, intEnd);
            return arrvcc_Course_Sim_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vcc_Course_Sim_GetObjLstByPager_Cache = vcc_Course_Sim_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vcc_Course_Sim_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetObjLstByPagerAsync = vcc_Course_Sim_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCourseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vcc_Course_Sim_IsExistRecord_Cache(objvcc_Course_Sim_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrvcc_Course_SimObjLst_Cache == null)
            return false;
        let arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache;
        if (objvcc_Course_Sim_Cond.sf_FldComparisonOp == null || objvcc_Course_Sim_Cond.sf_FldComparisonOp == "")
            return arrvcc_Course_Sim_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvcc_Course_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_Course_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_Course_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvcc_Course_Sim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvcc_Course_Sim_Cond), exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vcc_Course_Sim_IsExistRecord_Cache = vcc_Course_Sim_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vcc_Course_Sim_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_IsExistRecordAsync = vcc_Course_Sim_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCourseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vcc_Course_Sim_IsExist(strCourseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CourseId": strCourseId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_IsExist = vcc_Course_Sim_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCourseId:所给的关键字
     * @returns 对象
    */
    async function vcc_Course_Sim_IsExist_Cache(strCourseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrvcc_Course_SimObjLst_Cache == null)
            return false;
        try {
            const arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache.filter(x => x.courseId == strCourseId);
            if (arrvcc_Course_Sim_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCourseId, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vcc_Course_Sim_IsExist_Cache = vcc_Course_Sim_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCourseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vcc_Course_Sim_IsExistAsync(strCourseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCourseId": strCourseId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_IsExistAsync = vcc_Course_Sim_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vcc_Course_Sim_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vcc_Course_Sim_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vcc_Course_Sim_GetRecCountByCondAsync = vcc_Course_Sim_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvcc_Course_Sim_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vcc_Course_Sim_GetRecCountByCond_Cache(objvcc_Course_Sim_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvcc_Course_SimObjLst_Cache = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrvcc_Course_SimObjLst_Cache == null)
            return 0;
        let arrvcc_Course_Sim_Sel = arrvcc_Course_SimObjLst_Cache;
        if (objvcc_Course_Sim_Cond.sf_FldComparisonOp == null || objvcc_Course_Sim_Cond.sf_FldComparisonOp == "")
            return arrvcc_Course_Sim_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvcc_Course_Sim_Cond.sf_FldComparisonOp);
        //console.log("clsvcc_Course_SimWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvcc_Course_Sim_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvcc_Course_Sim_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvcc_Course_Sim_Sel = arrvcc_Course_Sim_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvcc_Course_Sim_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvcc_Course_Sim_Cond), exports.vcc_Course_Sim_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vcc_Course_Sim_GetRecCountByCond_Cache = vcc_Course_Sim_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vcc_Course_Sim_GetWebApiUrl(strController, strAction) {
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
    exports.vcc_Course_Sim_GetWebApiUrl = vcc_Course_Sim_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vcc_Course_Sim_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN._CurrTabName;
            switch (clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.CacheModeId) {
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
    exports.vcc_Course_Sim_ReFreshThisCache = vcc_Course_Sim_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vcc_Course_Sim_BindDdl_CourseIdInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_CourseIdInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_CourseIdInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_CourseIdInDiv_Cache");
        const arrObjLst_Sel = await vcc_Course_Sim_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName, "vcc_Course_Sim");
    }
    exports.vcc_Course_Sim_BindDdl_CourseIdInDiv_Cache = vcc_Course_Sim_BindDdl_CourseIdInDiv_Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_Course_Sim_GetJSONStrByObj(pobjvcc_Course_SimEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvcc_Course_SimEN);
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
    exports.vcc_Course_Sim_GetJSONStrByObj = vcc_Course_Sim_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vcc_Course_Sim_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvcc_Course_SimObjLst = new Array();
        if (strJSON === "") {
            return arrvcc_Course_SimObjLst;
        }
        try {
            arrvcc_Course_SimObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvcc_Course_SimObjLst;
        }
        return arrvcc_Course_SimObjLst;
    }
    exports.vcc_Course_Sim_GetObjLstByJSONStr = vcc_Course_Sim_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvcc_Course_SimObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vcc_Course_Sim_GetObjLstByJSONObjLst(arrvcc_Course_SimObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvcc_Course_SimObjLst = new Array();
        for (const objInFor of arrvcc_Course_SimObjLstS) {
            const obj1 = vcc_Course_Sim_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvcc_Course_SimObjLst.push(obj1);
        }
        return arrvcc_Course_SimObjLst;
    }
    exports.vcc_Course_Sim_GetObjLstByJSONObjLst = vcc_Course_Sim_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-14
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vcc_Course_Sim_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvcc_Course_SimEN = new clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN();
        if (strJSON === "") {
            return pobjvcc_Course_SimEN;
        }
        try {
            pobjvcc_Course_SimEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvcc_Course_SimEN;
        }
        return pobjvcc_Course_SimEN;
    }
    exports.vcc_Course_Sim_GetObjByJSONStr = vcc_Course_Sim_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vcc_Course_Sim_GetCombineCondition(objvcc_Course_Sim_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId) == true) {
            const strComparisonOp_CourseId = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseId, objvcc_Course_Sim_Cond.courseId, strComparisonOp_CourseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseCode) == true) {
            const strComparisonOp_CourseCode = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseCode];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseCode, objvcc_Course_Sim_Cond.courseCode, strComparisonOp_CourseCode);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName) == true) {
            const strComparisonOp_CourseName = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseName, objvcc_Course_Sim_Cond.courseName, strComparisonOp_CourseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_OrderNum, objvcc_Course_Sim_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseTypeID) == true) {
            const strComparisonOp_CourseTypeID = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseTypeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_CourseTypeID, objvcc_Course_Sim_Cond.courseTypeID, strComparisonOp_CourseTypeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzMajor, objvcc_Course_Sim_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_id_XzCollege, objvcc_Course_Sim_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvcc_Course_Sim_Cond.dicFldComparisonOp, clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_ExcellentTypeId) == true) {
            const strComparisonOp_ExcellentTypeId = objvcc_Course_Sim_Cond.dicFldComparisonOp[clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_ExcellentTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN.con_ExcellentTypeId, objvcc_Course_Sim_Cond.excellentTypeId, strComparisonOp_ExcellentTypeId);
        }
        return strWhereCond;
    }
    exports.vcc_Course_Sim_GetCombineCondition = vcc_Course_Sim_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvcc_Course_SimENS:源对象
     * @param objvcc_Course_SimENT:目标对象
    */
    function vcc_Course_Sim_CopyObjTo(objvcc_Course_SimENS, objvcc_Course_SimENT) {
        objvcc_Course_SimENT.courseId = objvcc_Course_SimENS.courseId; //课程Id
        objvcc_Course_SimENT.courseCode = objvcc_Course_SimENS.courseCode; //课程代码
        objvcc_Course_SimENT.courseName = objvcc_Course_SimENS.courseName; //课程名称
        objvcc_Course_SimENT.orderNum = objvcc_Course_SimENS.orderNum; //序号
        objvcc_Course_SimENT.courseTypeID = objvcc_Course_SimENS.courseTypeID; //课程类型ID
        objvcc_Course_SimENT.id_XzMajor = objvcc_Course_SimENS.id_XzMajor; //专业流水号
        objvcc_Course_SimENT.id_XzCollege = objvcc_Course_SimENS.id_XzCollege; //学院流水号
        objvcc_Course_SimENT.excellentTypeId = objvcc_Course_SimENS.excellentTypeId; //精品课程类型Id
    }
    exports.vcc_Course_Sim_CopyObjTo = vcc_Course_Sim_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvcc_Course_SimENS:源对象
     * @param objvcc_Course_SimENT:目标对象
    */
    function vcc_Course_Sim_GetObjFromJsonObj(objvcc_Course_SimENS) {
        const objvcc_Course_SimENT = new clsvcc_Course_SimEN_js_1.clsvcc_Course_SimEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvcc_Course_SimENT, objvcc_Course_SimENS);
        return objvcc_Course_SimENT;
    }
    exports.vcc_Course_Sim_GetObjFromJsonObj = vcc_Course_Sim_GetObjFromJsonObj;
});
