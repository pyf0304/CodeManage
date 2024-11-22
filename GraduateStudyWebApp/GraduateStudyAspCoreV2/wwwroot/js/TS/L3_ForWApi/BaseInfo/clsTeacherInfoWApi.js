/**
* 类名:clsTeacherInfoWApi
* 表名:TeacherInfo(01120093)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:39:31
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:基本信息维护(BaseInfo)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsTeacherInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.TeacherInfo_GetObjFromJsonObj = exports.TeacherInfo_CopyObjTo = exports.TeacherInfo_GetUniCondStr4Update_TeacherID = exports.TeacherInfo_GetUniCondStr_TeacherID = exports.TeacherInfo_GetCombineCondition = exports.TeacherInfo_GetObjByJSONStr = exports.TeacherInfo_GetObjLstByJSONObjLst = exports.TeacherInfo_GetObjLstByJSONStr = exports.TeacherInfo_GetJSONStrByObj = exports.TeacherInfo_CheckProperty4Update = exports.TeacherInfo_CheckPropertyNew = exports.TeacherInfo_BindDdl_id_TeacherInDiv_Cache = exports.TeacherInfo_ReFreshThisCache = exports.TeacherInfo_ReFreshCache = exports.TeacherInfo_GetWebApiUrl = exports.TeacherInfo_GetMaxStrIdByPrefix = exports.TeacherInfo_GetMaxStrIdAsync = exports.TeacherInfo_GetRecCountByCond_Cache = exports.TeacherInfo_GetRecCountByCondAsync = exports.TeacherInfo_IsExistAsync = exports.TeacherInfo_IsExist_Cache = exports.TeacherInfo_IsExist = exports.TeacherInfo_IsExistRecordAsync = exports.TeacherInfo_IsExistRecord_Cache = exports.TeacherInfo_UpdateWithConditionAsync = exports.TeacherInfo_UpdateRecordAsync = exports.TeacherInfo_AddNewRecordWithReturnKey = exports.TeacherInfo_AddNewRecordWithReturnKeyAsync = exports.TeacherInfo_AddNewRecordWithMaxIdAsync = exports.TeacherInfo_AddNewRecordAsync = exports.TeacherInfo_DelTeacherInfosByCondAsync = exports.TeacherInfo_DelTeacherInfosAsync = exports.TeacherInfo_DelRecordAsync = exports.TeacherInfo_GetObjLstByPagerAsync = exports.TeacherInfo_GetObjLstByPager_Cache = exports.TeacherInfo_GetObjLstByRange = exports.TeacherInfo_GetObjLstByRangeAsync = exports.TeacherInfo_GetTopObjLstAsync = exports.TeacherInfo_GetObjLstByid_TeacherLst_Cache = exports.TeacherInfo_GetObjLstByid_TeacherLstAsync = exports.TeacherInfo_GetSubObjLst_Cache = exports.TeacherInfo_GetObjLst_PureCache = exports.TeacherInfo_GetObjLst_Cache = exports.TeacherInfo_GetObjLst_sessionStorage_PureCache = exports.TeacherInfo_GetObjLst_sessionStorage = exports.TeacherInfo_GetObjLstAsync = exports.TeacherInfo_GetObjLst_localStorage_PureCache = exports.TeacherInfo_GetObjLst_localStorage = exports.TeacherInfo_GetObjLst_ClientCache = exports.TeacherInfo_GetFirstObjAsync = exports.TeacherInfo_GetFirstID = exports.TeacherInfo_GetFirstIDAsync = exports.TeacherInfo_funcKey = exports.TeacherInfo_FilterFunByKey = exports.TeacherInfo_SortFunByKey = exports.TeacherInfo_SortFun_Defa_2Fld = exports.TeacherInfo_SortFun_Defa = exports.TeacherInfo_func = exports.TeacherInfo_GetNameByid_Teacher_Cache = exports.TeacherInfo_UpdateObjInLst_Cache = exports.TeacherInfo_GetObjByid_Teacher_localStorage = exports.TeacherInfo_GetObjByid_Teacher_Cache = exports.TeacherInfo_GetObjByid_TeacherAsync = exports.teacherInfo_ConstructorName = exports.teacherInfo_Controller = void 0;
    /**
     * 教师(TeacherInfo)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsTeacherInfoEN_js_1 = require("../../L0_Entity/BaseInfo/clsTeacherInfoEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.teacherInfo_Controller = "TeacherInfoApi";
    exports.teacherInfo_ConstructorName = "teacherInfo";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_Teacher:关键字
    * @returns 对象
    **/
    async function TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher) {
        const strThisFuncName = "GetObjByid_TeacherAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_Teacher) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_Teacher]不能为空！(In GetObjByid_TeacherAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Teacher.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByid_Teacher";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strid_Teacher": strid_Teacher,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objTeacherInfo = TeacherInfo_GetObjFromJsonObj(returnObj);
                return objTeacherInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetObjByid_TeacherAsync = TeacherInfo_GetObjByid_TeacherAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function TeacherInfo_GetObjByid_Teacher_Cache(strid_Teacher, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByid_Teacher_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_Teacher) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_Teacher]不能为空！(In GetObjByid_Teacher_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Teacher.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        try {
            const arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
            let objTeacherInfo;
            if (arrTeacherInfo_Sel.length > 0) {
                objTeacherInfo = arrTeacherInfo_Sel[0];
                return objTeacherInfo;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objTeacherInfo_Const = await TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
                    if (objTeacherInfo_Const != null) {
                        TeacherInfo_ReFreshThisCache();
                        return objTeacherInfo_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Teacher, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.TeacherInfo_GetObjByid_Teacher_Cache = TeacherInfo_GetObjByid_Teacher_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function TeacherInfo_GetObjByid_Teacher_localStorage(strid_Teacher) {
        const strThisFuncName = "GetObjByid_Teacher_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_Teacher) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_Teacher]不能为空！(In GetObjByid_Teacher_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Teacher.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName, strid_Teacher);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objTeacherInfo_Cache = JSON.parse(strTempObj);
            return objTeacherInfo_Cache;
        }
        try {
            const objTeacherInfo = await TeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
            if (objTeacherInfo != null) {
                localStorage.setItem(strKey, JSON.stringify(objTeacherInfo));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objTeacherInfo;
            }
            return objTeacherInfo;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Teacher, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.TeacherInfo_GetObjByid_Teacher_localStorage = TeacherInfo_GetObjByid_Teacher_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objTeacherInfo:所给的对象
     * @returns 对象
    */
    async function TeacherInfo_UpdateObjInLst_Cache(objTeacherInfo) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
            const obj = arrTeacherInfoObjLst_Cache.find(x => x.teacherID == objTeacherInfo.teacherID);
            if (obj != null) {
                objTeacherInfo.id_Teacher = obj.id_Teacher;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objTeacherInfo);
            }
            else {
                arrTeacherInfoObjLst_Cache.push(objTeacherInfo);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.TeacherInfo_UpdateObjInLst_Cache = TeacherInfo_UpdateObjInLst_Cache;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function TeacherInfo_GetNameByid_Teacher_Cache(strid_Teacher) {
        const strThisFuncName = "GetNameByid_Teacher_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_Teacher) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_Teacher]不能为空！(In GetNameByid_Teacher_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_Teacher.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_Teacher]的长度:[{0}]不正确！", strid_Teacher.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        if (arrTeacherInfoObjLst_Cache == null)
            return "";
        try {
            const arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
            let objTeacherInfo;
            if (arrTeacherInfo_Sel.length > 0) {
                objTeacherInfo = arrTeacherInfo_Sel[0];
                return objTeacherInfo.teacherName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strid_Teacher);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.TeacherInfo_GetNameByid_Teacher_Cache = TeacherInfo_GetNameByid_Teacher_Cache;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function TeacherInfo_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsTeacherInfoEN_js_1.clsTeacherInfoEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsTeacherInfoEN_js_1.clsTeacherInfoEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_Teacher = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objTeacherInfo = await TeacherInfo_GetObjByid_Teacher_Cache(strid_Teacher);
        if (objTeacherInfo == null)
            return "";
        if (objTeacherInfo.GetFldValue(strOutFldName) == null)
            return "";
        return objTeacherInfo.GetFldValue(strOutFldName).toString();
    }
    exports.TeacherInfo_func = TeacherInfo_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TeacherInfo_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_Teacher.localeCompare(b.id_Teacher);
    }
    exports.TeacherInfo_SortFun_Defa = TeacherInfo_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TeacherInfo_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.teacherID == b.teacherID)
            return a.teacherName.localeCompare(b.teacherName);
        else
            return a.teacherID.localeCompare(b.teacherID);
    }
    exports.TeacherInfo_SortFun_Defa_2Fld = TeacherInfo_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function TeacherInfo_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher:
                    return (a, b) => {
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherID:
                    return (a, b) => {
                        return a.teacherID.localeCompare(b.teacherID);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName:
                    return (a, b) => {
                        return a.teacherName.localeCompare(b.teacherName);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_School_Ps:
                    return (a, b) => {
                        if (a.id_School_Ps == null)
                            return -1;
                        if (b.id_School_Ps == null)
                            return 1;
                        return a.id_School_Ps.localeCompare(b.id_School_Ps);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Discipline_Ps:
                    return (a, b) => {
                        if (a.id_Discipline_Ps == null)
                            return -1;
                        if (b.id_Discipline_Ps == null)
                            return 1;
                        return a.id_Discipline_Ps.localeCompare(b.id_Discipline_Ps);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_UniZone:
                    return (a, b) => {
                        if (a.id_UniZone == null)
                            return -1;
                        if (b.id_UniZone == null)
                            return 1;
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        if (a.id_Ethnic == null)
                            return -1;
                        if (b.id_Ethnic == null)
                            return 1;
                        return a.id_Ethnic.localeCompare(b.id_Ethnic);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Politics:
                    return (a, b) => {
                        if (a.id_Politics == null)
                            return -1;
                        if (b.id_Politics == null)
                            return 1;
                        return a.id_Politics.localeCompare(b.id_Politics);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_AdminGrade:
                    return (a, b) => {
                        if (a.id_AdminGrade == null)
                            return -1;
                        if (b.id_AdminGrade == null)
                            return 1;
                        return a.id_AdminGrade.localeCompare(b.id_AdminGrade);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_ProfGrade:
                    return (a, b) => {
                        if (a.id_ProfGrade == null)
                            return -1;
                        if (b.id_ProfGrade == null)
                            return 1;
                        return a.id_ProfGrade.localeCompare(b.id_ProfGrade);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Qualif:
                    return (a, b) => {
                        if (a.id_Qualif == null)
                            return -1;
                        if (b.id_Qualif == null)
                            return 1;
                        return a.id_Qualif.localeCompare(b.id_Qualif);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Degree:
                    return (a, b) => {
                        if (a.id_Degree == null)
                            return -1;
                        if (b.id_Degree == null)
                            return 1;
                        return a.id_Degree.localeCompare(b.id_Degree);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_StaffType:
                    return (a, b) => {
                        if (a.id_StaffType == null)
                            return -1;
                        if (b.id_StaffType == null)
                            return 1;
                        return a.id_StaffType.localeCompare(b.id_StaffType);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Province:
                    return (a, b) => {
                        if (a.id_Province == null)
                            return -1;
                        if (b.id_Province == null)
                            return 1;
                        return a.id_Province.localeCompare(b.id_Province);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CitizenID:
                    return (a, b) => {
                        if (a.citizenID == null)
                            return -1;
                        if (b.citizenID == null)
                            return 1;
                        return a.citizenID.localeCompare(b.citizenID);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CardNo:
                    return (a, b) => {
                        if (a.cardNo == null)
                            return -1;
                        if (b.cardNo == null)
                            return 1;
                        return a.cardNo.localeCompare(b.cardNo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Birthday:
                    return (a, b) => {
                        if (a.birthday == null)
                            return -1;
                        if (b.birthday == null)
                            return 1;
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_GraduationMajor:
                    return (a, b) => {
                        if (a.graduationMajor == null)
                            return -1;
                        if (b.graduationMajor == null)
                            return 1;
                        return a.graduationMajor.localeCompare(b.graduationMajor);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TelNo:
                    return (a, b) => {
                        if (a.telNo == null)
                            return -1;
                        if (b.telNo == null)
                            return 1;
                        return a.telNo.localeCompare(b.telNo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_WebSite:
                    return (a, b) => {
                        if (a.webSite == null)
                            return -1;
                        if (b.webSite == null)
                            return 1;
                        return a.webSite.localeCompare(b.webSite);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PersonBlog:
                    return (a, b) => {
                        if (a.personBlog == null)
                            return -1;
                        if (b.personBlog == null)
                            return 1;
                        return a.personBlog.localeCompare(b.personBlog);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDate:
                    return (a, b) => {
                        if (a.entryDate == null)
                            return -1;
                        if (b.entryDate == null)
                            return 1;
                        return a.entryDate.localeCompare(b.entryDate);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Offed:
                    return (a, b) => {
                        if (a.offed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (a.id_CardNo == null)
                            return -1;
                        if (b.id_CardNo == null)
                            return 1;
                        return a.id_CardNo.localeCompare(b.id_CardNo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (a.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (a.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_FromUnit:
                    return (a, b) => {
                        if (a.fromUnit == null)
                            return -1;
                        if (b.fromUnit == null)
                            return 1;
                        return a.fromUnit.localeCompare(b.fromUnit);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDay:
                    return (a, b) => {
                        if (a.entryDay == null)
                            return -1;
                        if (b.entryDay == null)
                            return 1;
                        return a.entryDay.localeCompare(b.entryDay);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Photo:
                    return (a, b) => {
                        if (a.id_Photo == null)
                            return -1;
                        if (b.id_Photo == null)
                            return 1;
                        return a.id_Photo.localeCompare(b.id_Photo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Religion:
                    return (a, b) => {
                        if (a.id_Religion == null)
                            return -1;
                        if (b.id_Religion == null)
                            return 1;
                        return a.id_Religion.localeCompare(b.id_Religion);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (a.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Microblog:
                    return (a, b) => {
                        if (a.microblog == null)
                            return -1;
                        if (b.microblog == null)
                            return 1;
                        return a.microblog.localeCompare(b.microblog);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_OffedBak:
                    return (a, b) => {
                        if (a.offedBak == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_QQ:
                    return (a, b) => {
                        if (a.qQ == null)
                            return -1;
                        if (b.qQ == null)
                            return 1;
                        return a.qQ.localeCompare(b.qQ);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_College:
                    return (a, b) => {
                        if (a.teach_id_College == null)
                            return -1;
                        if (b.teach_id_College == null)
                            return 1;
                        return a.teach_id_College.localeCompare(b.teach_id_College);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_Major:
                    return (a, b) => {
                        if (a.teach_id_Major == null)
                            return -1;
                        if (b.teach_id_Major == null)
                            return 1;
                        return a.teach_id_Major.localeCompare(b.teach_id_Major);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Tel:
                    return (a, b) => {
                        if (a.tel == null)
                            return -1;
                        if (b.tel == null)
                            return 1;
                        return a.tel.localeCompare(b.tel);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Headphoto:
                    return (a, b) => {
                        if (a.headphoto == null)
                            return -1;
                        if (b.headphoto == null)
                            return 1;
                        return a.headphoto.localeCompare(b.headphoto);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (a.registerPassword == null)
                            return -1;
                        if (b.registerPassword == null)
                            return 1;
                        return a.registerPassword.localeCompare(b.registerPassword);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherPhoto:
                    return (a, b) => {
                        if (a.teacherPhoto == null)
                            return -1;
                        if (b.teacherPhoto == null)
                            return 1;
                        return a.teacherPhoto.localeCompare(b.teacherPhoto);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TeacherInfo]中不存在！(in ${exports.teacherInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher:
                    return (a, b) => {
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherID:
                    return (a, b) => {
                        return b.teacherID.localeCompare(a.teacherID);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName:
                    return (a, b) => {
                        return b.teacherName.localeCompare(a.teacherName);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_School_Ps:
                    return (a, b) => {
                        if (b.id_School_Ps == null)
                            return -1;
                        if (a.id_School_Ps == null)
                            return 1;
                        return b.id_School_Ps.localeCompare(a.id_School_Ps);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Discipline_Ps:
                    return (a, b) => {
                        if (b.id_Discipline_Ps == null)
                            return -1;
                        if (a.id_Discipline_Ps == null)
                            return 1;
                        return b.id_Discipline_Ps.localeCompare(a.id_Discipline_Ps);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_UniZone:
                    return (a, b) => {
                        if (b.id_UniZone == null)
                            return -1;
                        if (a.id_UniZone == null)
                            return 1;
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        if (b.id_Ethnic == null)
                            return -1;
                        if (a.id_Ethnic == null)
                            return 1;
                        return b.id_Ethnic.localeCompare(a.id_Ethnic);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Politics:
                    return (a, b) => {
                        if (b.id_Politics == null)
                            return -1;
                        if (a.id_Politics == null)
                            return 1;
                        return b.id_Politics.localeCompare(a.id_Politics);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_AdminGrade:
                    return (a, b) => {
                        if (b.id_AdminGrade == null)
                            return -1;
                        if (a.id_AdminGrade == null)
                            return 1;
                        return b.id_AdminGrade.localeCompare(a.id_AdminGrade);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_ProfGrade:
                    return (a, b) => {
                        if (b.id_ProfGrade == null)
                            return -1;
                        if (a.id_ProfGrade == null)
                            return 1;
                        return b.id_ProfGrade.localeCompare(a.id_ProfGrade);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Qualif:
                    return (a, b) => {
                        if (b.id_Qualif == null)
                            return -1;
                        if (a.id_Qualif == null)
                            return 1;
                        return b.id_Qualif.localeCompare(a.id_Qualif);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Degree:
                    return (a, b) => {
                        if (b.id_Degree == null)
                            return -1;
                        if (a.id_Degree == null)
                            return 1;
                        return b.id_Degree.localeCompare(a.id_Degree);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_StaffType:
                    return (a, b) => {
                        if (b.id_StaffType == null)
                            return -1;
                        if (a.id_StaffType == null)
                            return 1;
                        return b.id_StaffType.localeCompare(a.id_StaffType);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Province:
                    return (a, b) => {
                        if (b.id_Province == null)
                            return -1;
                        if (a.id_Province == null)
                            return 1;
                        return b.id_Province.localeCompare(a.id_Province);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CitizenID:
                    return (a, b) => {
                        if (b.citizenID == null)
                            return -1;
                        if (a.citizenID == null)
                            return 1;
                        return b.citizenID.localeCompare(a.citizenID);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CardNo:
                    return (a, b) => {
                        if (b.cardNo == null)
                            return -1;
                        if (a.cardNo == null)
                            return 1;
                        return b.cardNo.localeCompare(a.cardNo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Birthday:
                    return (a, b) => {
                        if (b.birthday == null)
                            return -1;
                        if (a.birthday == null)
                            return 1;
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_GraduationMajor:
                    return (a, b) => {
                        if (b.graduationMajor == null)
                            return -1;
                        if (a.graduationMajor == null)
                            return 1;
                        return b.graduationMajor.localeCompare(a.graduationMajor);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TelNo:
                    return (a, b) => {
                        if (b.telNo == null)
                            return -1;
                        if (a.telNo == null)
                            return 1;
                        return b.telNo.localeCompare(a.telNo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_WebSite:
                    return (a, b) => {
                        if (b.webSite == null)
                            return -1;
                        if (a.webSite == null)
                            return 1;
                        return b.webSite.localeCompare(a.webSite);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PersonBlog:
                    return (a, b) => {
                        if (b.personBlog == null)
                            return -1;
                        if (a.personBlog == null)
                            return 1;
                        return b.personBlog.localeCompare(a.personBlog);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDate:
                    return (a, b) => {
                        if (b.entryDate == null)
                            return -1;
                        if (a.entryDate == null)
                            return 1;
                        return b.entryDate.localeCompare(a.entryDate);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Offed:
                    return (a, b) => {
                        if (b.offed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (b.id_CardNo == null)
                            return -1;
                        if (a.id_CardNo == null)
                            return 1;
                        return b.id_CardNo.localeCompare(a.id_CardNo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (b.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (b.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_FromUnit:
                    return (a, b) => {
                        if (b.fromUnit == null)
                            return -1;
                        if (a.fromUnit == null)
                            return 1;
                        return b.fromUnit.localeCompare(a.fromUnit);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDay:
                    return (a, b) => {
                        if (b.entryDay == null)
                            return -1;
                        if (a.entryDay == null)
                            return 1;
                        return b.entryDay.localeCompare(a.entryDay);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Photo:
                    return (a, b) => {
                        if (b.id_Photo == null)
                            return -1;
                        if (a.id_Photo == null)
                            return 1;
                        return b.id_Photo.localeCompare(a.id_Photo);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Religion:
                    return (a, b) => {
                        if (b.id_Religion == null)
                            return -1;
                        if (a.id_Religion == null)
                            return 1;
                        return b.id_Religion.localeCompare(a.id_Religion);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (b.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Microblog:
                    return (a, b) => {
                        if (b.microblog == null)
                            return -1;
                        if (a.microblog == null)
                            return 1;
                        return b.microblog.localeCompare(a.microblog);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_OffedBak:
                    return (a, b) => {
                        if (b.offedBak == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_QQ:
                    return (a, b) => {
                        if (b.qQ == null)
                            return -1;
                        if (a.qQ == null)
                            return 1;
                        return b.qQ.localeCompare(a.qQ);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_College:
                    return (a, b) => {
                        if (b.teach_id_College == null)
                            return -1;
                        if (a.teach_id_College == null)
                            return 1;
                        return b.teach_id_College.localeCompare(a.teach_id_College);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_Major:
                    return (a, b) => {
                        if (b.teach_id_Major == null)
                            return -1;
                        if (a.teach_id_Major == null)
                            return 1;
                        return b.teach_id_Major.localeCompare(a.teach_id_Major);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Tel:
                    return (a, b) => {
                        if (b.tel == null)
                            return -1;
                        if (a.tel == null)
                            return 1;
                        return b.tel.localeCompare(a.tel);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Headphoto:
                    return (a, b) => {
                        if (b.headphoto == null)
                            return -1;
                        if (a.headphoto == null)
                            return 1;
                        return b.headphoto.localeCompare(a.headphoto);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (b.registerPassword == null)
                            return -1;
                        if (a.registerPassword == null)
                            return 1;
                        return b.registerPassword.localeCompare(a.registerPassword);
                    };
                case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherPhoto:
                    return (a, b) => {
                        if (b.teacherPhoto == null)
                            return -1;
                        if (a.teacherPhoto == null)
                            return 1;
                        return b.teacherPhoto.localeCompare(a.teacherPhoto);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[TeacherInfo]中不存在！(in ${exports.teacherInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.TeacherInfo_SortFunByKey = TeacherInfo_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function TeacherInfo_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherID:
                return (obj) => {
                    return obj.teacherID === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName:
                return (obj) => {
                    return obj.teacherName === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_School_Ps:
                return (obj) => {
                    return obj.id_School_Ps === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Discipline_Ps:
                return (obj) => {
                    return obj.id_Discipline_Ps === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Ethnic:
                return (obj) => {
                    return obj.id_Ethnic === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Politics:
                return (obj) => {
                    return obj.id_Politics === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_AdminGrade:
                return (obj) => {
                    return obj.id_AdminGrade === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_ProfGrade:
                return (obj) => {
                    return obj.id_ProfGrade === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Qualif:
                return (obj) => {
                    return obj.id_Qualif === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Degree:
                return (obj) => {
                    return obj.id_Degree === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_StaffType:
                return (obj) => {
                    return obj.id_StaffType === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Province:
                return (obj) => {
                    return obj.id_Province === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CitizenID:
                return (obj) => {
                    return obj.citizenID === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CardNo:
                return (obj) => {
                    return obj.cardNo === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_GraduationMajor:
                return (obj) => {
                    return obj.graduationMajor === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TelNo:
                return (obj) => {
                    return obj.telNo === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_WebSite:
                return (obj) => {
                    return obj.webSite === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PersonBlog:
                return (obj) => {
                    return obj.personBlog === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDate:
                return (obj) => {
                    return obj.entryDate === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Offed:
                return (obj) => {
                    return obj.offed === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Id_CardNo:
                return (obj) => {
                    return obj.id_CardNo === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsAvconUser:
                return (obj) => {
                    return obj.isAvconUser === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsLocalUser:
                return (obj) => {
                    return obj.isLocalUser === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_FromUnit:
                return (obj) => {
                    return obj.fromUnit === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDay:
                return (obj) => {
                    return obj.entryDay === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Photo:
                return (obj) => {
                    return obj.id_Photo === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Religion:
                return (obj) => {
                    return obj.id_Religion === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsMessage:
                return (obj) => {
                    return obj.isMessage === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Microblog:
                return (obj) => {
                    return obj.microblog === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_OffedBak:
                return (obj) => {
                    return obj.offedBak === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_QQ:
                return (obj) => {
                    return obj.qQ === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_College:
                return (obj) => {
                    return obj.teach_id_College === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_Major:
                return (obj) => {
                    return obj.teach_id_Major === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Tel:
                return (obj) => {
                    return obj.tel === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Headphoto:
                return (obj) => {
                    return obj.headphoto === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_RegisterPassword:
                return (obj) => {
                    return obj.registerPassword === value;
                };
            case clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherPhoto:
                return (obj) => {
                    return obj.teacherPhoto === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[TeacherInfo]中不存在！(in ${exports.teacherInfo_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.TeacherInfo_FilterFunByKey = TeacherInfo_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function TeacherInfo_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrTeacherInfo = await TeacherInfo_GetObjLst_Cache();
        if (arrTeacherInfo == null)
            return [];
        let arrTeacherInfo_Sel = arrTeacherInfo;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrTeacherInfo_Sel.length == 0)
            return [];
        return arrTeacherInfo_Sel.map(x => x.id_Teacher);
    }
    exports.TeacherInfo_funcKey = TeacherInfo_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function TeacherInfo_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetFirstIDAsync = TeacherInfo_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function TeacherInfo_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetFirstID = TeacherInfo_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function TeacherInfo_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const objTeacherInfo = TeacherInfo_GetObjFromJsonObj(returnObj);
                return objTeacherInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetFirstObjAsync = TeacherInfo_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
        clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrTeacherInfoExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrTeacherInfoObjLst_T = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoExObjLst_Cache);
            return arrTeacherInfoObjLst_T;
        }
        try {
            const arrTeacherInfoExObjLst = await TeacherInfo_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrTeacherInfoExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTeacherInfoExObjLst.length);
            console.log(strInfo);
            return arrTeacherInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TeacherInfo_GetObjLst_ClientCache = TeacherInfo_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
        clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrTeacherInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrTeacherInfoObjLst_T = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoExObjLst_Cache);
            return arrTeacherInfoObjLst_T;
        }
        try {
            const arrTeacherInfoExObjLst = await TeacherInfo_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrTeacherInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTeacherInfoExObjLst.length);
            console.log(strInfo);
            return arrTeacherInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TeacherInfo_GetObjLst_localStorage = TeacherInfo_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrTeacherInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrTeacherInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.TeacherInfo_GetObjLst_localStorage_PureCache = TeacherInfo_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function TeacherInfo_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.teacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetObjLstAsync = TeacherInfo_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
        clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrTeacherInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrTeacherInfoObjLst_T = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoExObjLst_Cache);
            return arrTeacherInfoObjLst_T;
        }
        try {
            const arrTeacherInfoExObjLst = await TeacherInfo_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrTeacherInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrTeacherInfoExObjLst.length);
            console.log(strInfo);
            return arrTeacherInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.TeacherInfo_GetObjLst_sessionStorage = TeacherInfo_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrTeacherInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrTeacherInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.TeacherInfo_GetObjLst_sessionStorage_PureCache = TeacherInfo_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrTeacherInfoObjLst_Cache;
        switch (clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_ClientCache();
                break;
            default:
                arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_ClientCache();
                break;
        }
        const arrTeacherInfoObjLst = TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoObjLst_Cache);
        return arrTeacherInfoObjLst_Cache;
    }
    exports.TeacherInfo_GetObjLst_Cache = TeacherInfo_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function TeacherInfo_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrTeacherInfoObjLst_Cache;
        switch (clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrTeacherInfoObjLst_Cache = null;
                break;
            default:
                arrTeacherInfoObjLst_Cache = null;
                break;
        }
        return arrTeacherInfoObjLst_Cache;
    }
    exports.TeacherInfo_GetObjLst_PureCache = TeacherInfo_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_Teacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function TeacherInfo_GetSubObjLst_Cache(objTeacherInfo_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        let arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache;
        if (objTeacherInfo_Cond.sf_FldComparisonOp == null || objTeacherInfo_Cond.sf_FldComparisonOp == "")
            return arrTeacherInfo_Sel;
        const dicFldComparisonOp = JSON.parse(objTeacherInfo_Cond.sf_FldComparisonOp);
        //console.log("clsTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTeacherInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrTeacherInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objTeacherInfo_Cond), exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TeacherInfo_GetSubObjLst_Cache = TeacherInfo_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_Teacher:关键字列表
    * @returns 对象列表
    **/
    async function TeacherInfo_GetObjLstByid_TeacherLstAsync(arrid_Teacher) {
        const strThisFuncName = "GetObjLstByid_TeacherLstAsync";
        const strAction = "GetObjLstByid_TeacherLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Teacher);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.teacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetObjLstByid_TeacherLstAsync = TeacherInfo_GetObjLstByid_TeacherLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_TeacherLst:关键字列表
     * @returns 对象列表
    */
    async function TeacherInfo_GetObjLstByid_TeacherLst_Cache(arrid_TeacherLst) {
        const strThisFuncName = "GetObjLstByid_TeacherLst_Cache";
        try {
            const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
            const arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache.filter(x => arrid_TeacherLst.indexOf(x.id_Teacher) > -1);
            return arrTeacherInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_TeacherLst.join(","), exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TeacherInfo_GetObjLstByid_TeacherLst_Cache = TeacherInfo_GetObjLstByid_TeacherLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function TeacherInfo_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.teacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetTopObjLstAsync = TeacherInfo_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TeacherInfo_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.teacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetObjLstByRangeAsync = TeacherInfo_GetObjLstByRangeAsync;
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
    async function TeacherInfo_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetObjLstByRange = TeacherInfo_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function TeacherInfo_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        if (arrTeacherInfoObjLst_Cache.length == 0)
            return arrTeacherInfoObjLst_Cache;
        let arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objTeacherInfo_Cond = new clsTeacherInfoEN_js_1.clsTeacherInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTeacherInfo_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsTeacherInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrTeacherInfo_Sel.length == 0)
                return arrTeacherInfo_Sel;
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
                arrTeacherInfo_Sel = arrTeacherInfo_Sel.sort(TeacherInfo_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrTeacherInfo_Sel = arrTeacherInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrTeacherInfo_Sel = arrTeacherInfo_Sel.slice(intStart, intEnd);
            return arrTeacherInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.TeacherInfo_GetObjLstByPager_Cache = TeacherInfo_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function TeacherInfo_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.teacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = TeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetObjLstByPagerAsync = TeacherInfo_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strid_Teacher:关键字
    * @returns 获取删除的结果
    **/
    async function TeacherInfo_DelRecordAsync(strid_Teacher) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strid_Teacher);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_DelRecordAsync = TeacherInfo_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrid_Teacher:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function TeacherInfo_DelTeacherInfosAsync(arrid_Teacher) {
        const strThisFuncName = "DelTeacherInfosAsync";
        const strAction = "DelTeacherInfos";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Teacher);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_DelTeacherInfosAsync = TeacherInfo_DelTeacherInfosAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function TeacherInfo_DelTeacherInfosByCondAsync(strWhereCond) {
        const strThisFuncName = "DelTeacherInfosByCondAsync";
        const strAction = "DelTeacherInfosByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_DelTeacherInfosByCondAsync = TeacherInfo_DelTeacherInfosByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objTeacherInfoEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TeacherInfo_AddNewRecordAsync(objTeacherInfoEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objTeacherInfoEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTeacherInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_AddNewRecordAsync = TeacherInfo_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objTeacherInfoEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function TeacherInfo_AddNewRecordWithMaxIdAsync(objTeacherInfoEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTeacherInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_AddNewRecordWithMaxIdAsync = TeacherInfo_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objTeacherInfoEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function TeacherInfo_AddNewRecordWithReturnKeyAsync(objTeacherInfoEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTeacherInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_AddNewRecordWithReturnKeyAsync = TeacherInfo_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objTeacherInfoEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function TeacherInfo_AddNewRecordWithReturnKey(objTeacherInfoEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objTeacherInfoEN.id_Teacher === null || objTeacherInfoEN.id_Teacher === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTeacherInfoEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_AddNewRecordWithReturnKey = TeacherInfo_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objTeacherInfoEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function TeacherInfo_UpdateRecordAsync(objTeacherInfoEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objTeacherInfoEN.sf_UpdFldSetStr === undefined || objTeacherInfoEN.sf_UpdFldSetStr === null || objTeacherInfoEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTeacherInfoEN.id_Teacher);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTeacherInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_UpdateRecordAsync = TeacherInfo_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objTeacherInfoEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function TeacherInfo_UpdateWithConditionAsync(objTeacherInfoEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objTeacherInfoEN.sf_UpdFldSetStr === undefined || objTeacherInfoEN.sf_UpdFldSetStr === null || objTeacherInfoEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objTeacherInfoEN.id_Teacher);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        objTeacherInfoEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objTeacherInfoEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_UpdateWithConditionAsync = TeacherInfo_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_Teacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function TeacherInfo_IsExistRecord_Cache(objTeacherInfo_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        if (arrTeacherInfoObjLst_Cache == null)
            return false;
        let arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache;
        if (objTeacherInfo_Cond.sf_FldComparisonOp == null || objTeacherInfo_Cond.sf_FldComparisonOp == "")
            return arrTeacherInfo_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objTeacherInfo_Cond.sf_FldComparisonOp);
        //console.log("clsTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTeacherInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrTeacherInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objTeacherInfo_Cond), exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.TeacherInfo_IsExistRecord_Cache = TeacherInfo_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function TeacherInfo_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_IsExistRecordAsync = TeacherInfo_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_Teacher:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function TeacherInfo_IsExist(strid_Teacher, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "id_Teacher": strid_Teacher,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_IsExist = TeacherInfo_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function TeacherInfo_IsExist_Cache(strid_Teacher) {
        const strThisFuncName = "IsExist_Cache";
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        if (arrTeacherInfoObjLst_Cache == null)
            return false;
        try {
            const arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
            if (arrTeacherInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_Teacher, exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.TeacherInfo_IsExist_Cache = TeacherInfo_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_Teacher:关键字
    * @returns 是否存在?存在返回True
    **/
    async function TeacherInfo_IsExistAsync(strid_Teacher) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strid_Teacher": strid_Teacher }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_IsExistAsync = TeacherInfo_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function TeacherInfo_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetRecCountByCondAsync = TeacherInfo_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objTeacherInfo_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function TeacherInfo_GetRecCountByCond_Cache(objTeacherInfo_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrTeacherInfoObjLst_Cache = await TeacherInfo_GetObjLst_Cache();
        if (arrTeacherInfoObjLst_Cache == null)
            return 0;
        let arrTeacherInfo_Sel = arrTeacherInfoObjLst_Cache;
        if (objTeacherInfo_Cond.sf_FldComparisonOp == null || objTeacherInfo_Cond.sf_FldComparisonOp == "")
            return arrTeacherInfo_Sel.length;
        const dicFldComparisonOp = JSON.parse(objTeacherInfo_Cond.sf_FldComparisonOp);
        //console.log("clsTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objTeacherInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrTeacherInfo_Sel = arrTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrTeacherInfo_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objTeacherInfo_Cond), exports.teacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.TeacherInfo_GetRecCountByCond_Cache = TeacherInfo_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function TeacherInfo_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetMaxStrIdAsync = TeacherInfo_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function TeacherInfo_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.teacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.teacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.TeacherInfo_GetMaxStrIdByPrefix = TeacherInfo_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function TeacherInfo_GetWebApiUrl(strController, strAction) {
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
    exports.TeacherInfo_GetWebApiUrl = TeacherInfo_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function TeacherInfo_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
        switch (clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheModeId) {
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
    }
    exports.TeacherInfo_ReFreshCache = TeacherInfo_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function TeacherInfo_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsTeacherInfoEN_js_1.clsTeacherInfoEN._CurrTabName;
            switch (clsTeacherInfoEN_js_1.clsTeacherInfoEN.CacheModeId) {
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
    exports.TeacherInfo_ReFreshThisCache = TeacherInfo_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function TeacherInfo_BindDdl_id_TeacherInDiv_Cache(strDivName, strDdlName) {
        const strThisFuncName = "BindDdl_id_TeacherInDiv_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In BindDdl_id_TeacherInDiv)", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：BindDdl_id_TeacherInDiv_Cache");
        const arrObjLst_Sel = await TeacherInfo_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv)(strDivName, strDdlName, arrObjLst_Sel, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName, "教师");
    }
    exports.TeacherInfo_BindDdl_id_TeacherInDiv_Cache = TeacherInfo_BindDdl_id_TeacherInDiv_Cache;
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TeacherInfo_CheckPropertyNew(pobjTeacherInfoEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherID) === true) {
            throw new Error("(errid:Watl000058)字段[教师工号]不能为空(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherName) === true) {
            throw new Error("(errid:Watl000058)字段[教师姓名]不能为空(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Sex) === true) {
            throw new Error("(errid:Watl000058)字段[性别流水号]不能为空(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Teacher) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Teacher) > 8) {
            throw new Error("(errid:Watl000059)字段[教师流水号(id_Teacher)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Teacher)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherID) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teacherID) > 12) {
            throw new Error("(errid:Watl000059)字段[教师工号(teacherID)]的长度不能超过12(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherID)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherName) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teacherName) > 50) {
            throw new Error("(errid:Watl000059)字段[教师姓名(teacherName)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherName)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Sex) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000059)字段[性别流水号(id_Sex)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Sex)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_School_Ps) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_School_Ps) > 4) {
            throw new Error("(errid:Watl000059)字段[学校流水号(id_School_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_School_Ps)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Discipline_Ps) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Discipline_Ps) > 4) {
            throw new Error("(errid:Watl000059)字段[学科流水号(id_Discipline_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Discipline_Ps)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_UniZone) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000059)字段[校区流水号(id_UniZone)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_UniZone)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Ethnic) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Ethnic) > 4) {
            throw new Error("(errid:Watl000059)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Ethnic)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Politics) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Politics) > 4) {
            throw new Error("(errid:Watl000059)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Politics)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_AdminGrade) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_AdminGrade) > 4) {
            throw new Error("(errid:Watl000059)字段[行政职务流水号(id_AdminGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_AdminGrade)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_ProfGrade) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_ProfGrade) > 4) {
            throw new Error("(errid:Watl000059)字段[专业职称流水号(id_ProfGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_ProfGrade)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Qualif) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Qualif) > 4) {
            throw new Error("(errid:Watl000059)字段[学历流水号(id_Qualif)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Qualif)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Degree) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Degree) > 4) {
            throw new Error("(errid:Watl000059)字段[学位流水号(id_Degree)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Degree)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_StaffType) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_StaffType) > 4) {
            throw new Error("(errid:Watl000059)字段[职工类型流水号(id_StaffType)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_StaffType)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Province) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Province) > 4) {
            throw new Error("(errid:Watl000059)字段[省份流水号(id_Province)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Province)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.citizenID) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.citizenID) > 25) {
            throw new Error("(errid:Watl000059)字段[身份证号(citizenID)]的长度不能超过25(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.citizenID)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.cardNo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.cardNo) > 18) {
            throw new Error("(errid:Watl000059)字段[卡号(cardNo)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.cardNo)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.birthday) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.birthday) > 8) {
            throw new Error("(errid:Watl000059)字段[出生日期(birthday)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.birthday)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.graduationMajor) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.graduationMajor) > 40) {
            throw new Error("(errid:Watl000059)字段[毕业专业(graduationMajor)]的长度不能超过40(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.graduationMajor)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.telNo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.telNo) > 50) {
            throw new Error("(errid:Watl000059)字段[电话(telNo)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.telNo)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.email) > 100) {
            throw new Error("(errid:Watl000059)字段[电子邮箱(email)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.email)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.webSite) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.webSite) > 60) {
            throw new Error("(errid:Watl000059)字段[个人主页(webSite)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.webSite)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.personBlog) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.personBlog) > 60) {
            throw new Error("(errid:Watl000059)字段[个人博客(personBlog)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.personBlog)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDate) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.entryDate) > 8) {
            throw new Error("(errid:Watl000059)字段[进校日期(entryDate)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDate)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_CardNo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_CardNo) > 20) {
            throw new Error("(errid:Watl000059)字段[内卡号(id_CardNo)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_CardNo)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.fromUnit) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.fromUnit) > 100) {
            throw new Error("(errid:Watl000059)字段[来自单位(fromUnit)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.fromUnit)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.memo)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000059)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzCollege)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000059)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzMajor)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDay) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.entryDay) > 8) {
            throw new Error("(errid:Watl000059)字段[EntryDay(entryDay)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDay)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Photo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Photo) > 8) {
            throw new Error("(errid:Watl000059)字段[id_Photo(id_Photo)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Photo)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Religion) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Religion) > 4) {
            throw new Error("(errid:Watl000059)字段[id_Religion(id_Religion)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Religion)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.microblog) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.microblog) > 200) {
            throw new Error("(errid:Watl000059)字段[Microblog(microblog)]的长度不能超过200(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.microblog)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000059)字段[修改人(modifyUserID)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyUserID)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000059)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.phoneNumber)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.qQ) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.qQ) > 100) {
            throw new Error("(errid:Watl000059)字段[QQ(qQ)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.qQ)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_College) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teach_id_College) > 6) {
            throw new Error("(errid:Watl000059)字段[Teach_id_College(teach_id_College)]的长度不能超过6(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_College)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_Major) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teach_id_Major) > 8) {
            throw new Error("(errid:Watl000059)字段[Teach_id_Major(teach_id_Major)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_Major)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.tel) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.tel) > 50) {
            throw new Error("(errid:Watl000059)字段[Tel(tel)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.tel)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.headphoto) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.headphoto) > 500) {
            throw new Error("(errid:Watl000059)字段[Headphoto(headphoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.headphoto)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(modifyDate)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyDate)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.registerPassword) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.registerPassword) > 30) {
            throw new Error("(errid:Watl000059)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.registerPassword)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherPhoto) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teacherPhoto) > 500) {
            throw new Error("(errid:Watl000059)字段[TeacherPhoto(teacherPhoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherPhoto)(clsTeacherInfoBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Teacher) == false && undefined !== pobjTeacherInfoEN.id_Teacher && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Teacher) === false) {
            throw new Error("(errid:Watl000060)字段[教师流水号(id_Teacher)]的值:[$(pobjTeacherInfoEN.id_Teacher)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherID) == false && undefined !== pobjTeacherInfoEN.teacherID && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teacherID) === false) {
            throw new Error("(errid:Watl000060)字段[教师工号(teacherID)]的值:[$(pobjTeacherInfoEN.teacherID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherName) == false && undefined !== pobjTeacherInfoEN.teacherName && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teacherName) === false) {
            throw new Error("(errid:Watl000060)字段[教师姓名(teacherName)]的值:[$(pobjTeacherInfoEN.teacherName)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Sex) == false && undefined !== pobjTeacherInfoEN.id_Sex && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Sex) === false) {
            throw new Error("(errid:Watl000060)字段[性别流水号(id_Sex)]的值:[$(pobjTeacherInfoEN.id_Sex)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_School_Ps) == false && undefined !== pobjTeacherInfoEN.id_School_Ps && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_School_Ps) === false) {
            throw new Error("(errid:Watl000060)字段[学校流水号(id_School_Ps)]的值:[$(pobjTeacherInfoEN.id_School_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Discipline_Ps) == false && undefined !== pobjTeacherInfoEN.id_Discipline_Ps && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Discipline_Ps) === false) {
            throw new Error("(errid:Watl000060)字段[学科流水号(id_Discipline_Ps)]的值:[$(pobjTeacherInfoEN.id_Discipline_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_UniZone) == false && undefined !== pobjTeacherInfoEN.id_UniZone && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000060)字段[校区流水号(id_UniZone)]的值:[$(pobjTeacherInfoEN.id_UniZone)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Ethnic) == false && undefined !== pobjTeacherInfoEN.id_Ethnic && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Ethnic) === false) {
            throw new Error("(errid:Watl000060)字段[民族流水号(id_Ethnic)]的值:[$(pobjTeacherInfoEN.id_Ethnic)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Politics) == false && undefined !== pobjTeacherInfoEN.id_Politics && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Politics) === false) {
            throw new Error("(errid:Watl000060)字段[政治面貌流水号(id_Politics)]的值:[$(pobjTeacherInfoEN.id_Politics)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_AdminGrade) == false && undefined !== pobjTeacherInfoEN.id_AdminGrade && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_AdminGrade) === false) {
            throw new Error("(errid:Watl000060)字段[行政职务流水号(id_AdminGrade)]的值:[$(pobjTeacherInfoEN.id_AdminGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_ProfGrade) == false && undefined !== pobjTeacherInfoEN.id_ProfGrade && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_ProfGrade) === false) {
            throw new Error("(errid:Watl000060)字段[专业职称流水号(id_ProfGrade)]的值:[$(pobjTeacherInfoEN.id_ProfGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Qualif) == false && undefined !== pobjTeacherInfoEN.id_Qualif && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Qualif) === false) {
            throw new Error("(errid:Watl000060)字段[学历流水号(id_Qualif)]的值:[$(pobjTeacherInfoEN.id_Qualif)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Degree) == false && undefined !== pobjTeacherInfoEN.id_Degree && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Degree) === false) {
            throw new Error("(errid:Watl000060)字段[学位流水号(id_Degree)]的值:[$(pobjTeacherInfoEN.id_Degree)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_StaffType) == false && undefined !== pobjTeacherInfoEN.id_StaffType && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_StaffType) === false) {
            throw new Error("(errid:Watl000060)字段[职工类型流水号(id_StaffType)]的值:[$(pobjTeacherInfoEN.id_StaffType)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Province) == false && undefined !== pobjTeacherInfoEN.id_Province && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Province) === false) {
            throw new Error("(errid:Watl000060)字段[省份流水号(id_Province)]的值:[$(pobjTeacherInfoEN.id_Province)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.citizenID) == false && undefined !== pobjTeacherInfoEN.citizenID && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.citizenID) === false) {
            throw new Error("(errid:Watl000060)字段[身份证号(citizenID)]的值:[$(pobjTeacherInfoEN.citizenID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.cardNo) == false && undefined !== pobjTeacherInfoEN.cardNo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.cardNo) === false) {
            throw new Error("(errid:Watl000060)字段[卡号(cardNo)]的值:[$(pobjTeacherInfoEN.cardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.birthday) == false && undefined !== pobjTeacherInfoEN.birthday && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.birthday) === false) {
            throw new Error("(errid:Watl000060)字段[出生日期(birthday)]的值:[$(pobjTeacherInfoEN.birthday)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.graduationMajor) == false && undefined !== pobjTeacherInfoEN.graduationMajor && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.graduationMajor) === false) {
            throw new Error("(errid:Watl000060)字段[毕业专业(graduationMajor)]的值:[$(pobjTeacherInfoEN.graduationMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.telNo) == false && undefined !== pobjTeacherInfoEN.telNo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.telNo) === false) {
            throw new Error("(errid:Watl000060)字段[电话(telNo)]的值:[$(pobjTeacherInfoEN.telNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.email) == false && undefined !== pobjTeacherInfoEN.email && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.email) === false) {
            throw new Error("(errid:Watl000060)字段[电子邮箱(email)]的值:[$(pobjTeacherInfoEN.email)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.webSite) == false && undefined !== pobjTeacherInfoEN.webSite && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.webSite) === false) {
            throw new Error("(errid:Watl000060)字段[个人主页(webSite)]的值:[$(pobjTeacherInfoEN.webSite)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.personBlog) == false && undefined !== pobjTeacherInfoEN.personBlog && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.personBlog) === false) {
            throw new Error("(errid:Watl000060)字段[个人博客(personBlog)]的值:[$(pobjTeacherInfoEN.personBlog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDate) == false && undefined !== pobjTeacherInfoEN.entryDate && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.entryDate) === false) {
            throw new Error("(errid:Watl000060)字段[进校日期(entryDate)]的值:[$(pobjTeacherInfoEN.entryDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if (null != pobjTeacherInfoEN.offed && undefined !== pobjTeacherInfoEN.offed && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.offed) === false) {
            throw new Error("(errid:Watl000060)字段[是否离校(offed)]的值:[$(pobjTeacherInfoEN.offed)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_CardNo) == false && undefined !== pobjTeacherInfoEN.id_CardNo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_CardNo) === false) {
            throw new Error("(errid:Watl000060)字段[内卡号(id_CardNo)]的值:[$(pobjTeacherInfoEN.id_CardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if (null != pobjTeacherInfoEN.isAvconUser && undefined !== pobjTeacherInfoEN.isAvconUser && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isAvconUser) === false) {
            throw new Error("(errid:Watl000060)字段[IsAvconUser(isAvconUser)]的值:[$(pobjTeacherInfoEN.isAvconUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if (null != pobjTeacherInfoEN.isGpUser && undefined !== pobjTeacherInfoEN.isGpUser && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isGpUser) === false) {
            throw new Error("(errid:Watl000060)字段[是否Gp用户(isGpUser)]的值:[$(pobjTeacherInfoEN.isGpUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if (null != pobjTeacherInfoEN.isLocalUser && undefined !== pobjTeacherInfoEN.isLocalUser && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isLocalUser) === false) {
            throw new Error("(errid:Watl000060)字段[是否本地用户(isLocalUser)]的值:[$(pobjTeacherInfoEN.isLocalUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.fromUnit) == false && undefined !== pobjTeacherInfoEN.fromUnit && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.fromUnit) === false) {
            throw new Error("(errid:Watl000060)字段[来自单位(fromUnit)]的值:[$(pobjTeacherInfoEN.fromUnit)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.memo) == false && undefined !== pobjTeacherInfoEN.memo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjTeacherInfoEN.memo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzCollege) == false && undefined !== pobjTeacherInfoEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000060)字段[学院流水号(id_XzCollege)]的值:[$(pobjTeacherInfoEN.id_XzCollege)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzMajor) == false && undefined !== pobjTeacherInfoEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000060)字段[专业流水号(id_XzMajor)]的值:[$(pobjTeacherInfoEN.id_XzMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDay) == false && undefined !== pobjTeacherInfoEN.entryDay && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.entryDay) === false) {
            throw new Error("(errid:Watl000060)字段[EntryDay(entryDay)]的值:[$(pobjTeacherInfoEN.entryDay)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Photo) == false && undefined !== pobjTeacherInfoEN.id_Photo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Photo) === false) {
            throw new Error("(errid:Watl000060)字段[id_Photo(id_Photo)]的值:[$(pobjTeacherInfoEN.id_Photo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Religion) == false && undefined !== pobjTeacherInfoEN.id_Religion && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Religion) === false) {
            throw new Error("(errid:Watl000060)字段[id_Religion(id_Religion)]的值:[$(pobjTeacherInfoEN.id_Religion)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if (null != pobjTeacherInfoEN.isMessage && undefined !== pobjTeacherInfoEN.isMessage && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isMessage) === false) {
            throw new Error("(errid:Watl000060)字段[IsMessage(isMessage)]的值:[$(pobjTeacherInfoEN.isMessage)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.microblog) == false && undefined !== pobjTeacherInfoEN.microblog && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.microblog) === false) {
            throw new Error("(errid:Watl000060)字段[Microblog(microblog)]的值:[$(pobjTeacherInfoEN.microblog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyUserID) == false && undefined !== pobjTeacherInfoEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(modifyUserID)]的值:[$(pobjTeacherInfoEN.modifyUserID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if (null != pobjTeacherInfoEN.offedBak && undefined !== pobjTeacherInfoEN.offedBak && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.offedBak) === false) {
            throw new Error("(errid:Watl000060)字段[OffedBak(offedBak)]的值:[$(pobjTeacherInfoEN.offedBak)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.phoneNumber) == false && undefined !== pobjTeacherInfoEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000060)字段[PhoneNumber(phoneNumber)]的值:[$(pobjTeacherInfoEN.phoneNumber)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.qQ) == false && undefined !== pobjTeacherInfoEN.qQ && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.qQ) === false) {
            throw new Error("(errid:Watl000060)字段[QQ(qQ)]的值:[$(pobjTeacherInfoEN.qQ)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_College) == false && undefined !== pobjTeacherInfoEN.teach_id_College && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teach_id_College) === false) {
            throw new Error("(errid:Watl000060)字段[Teach_id_College(teach_id_College)]的值:[$(pobjTeacherInfoEN.teach_id_College)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_Major) == false && undefined !== pobjTeacherInfoEN.teach_id_Major && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teach_id_Major) === false) {
            throw new Error("(errid:Watl000060)字段[Teach_id_Major(teach_id_Major)]的值:[$(pobjTeacherInfoEN.teach_id_Major)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.tel) == false && undefined !== pobjTeacherInfoEN.tel && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.tel) === false) {
            throw new Error("(errid:Watl000060)字段[Tel(tel)]的值:[$(pobjTeacherInfoEN.tel)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.headphoto) == false && undefined !== pobjTeacherInfoEN.headphoto && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.headphoto) === false) {
            throw new Error("(errid:Watl000060)字段[Headphoto(headphoto)]的值:[$(pobjTeacherInfoEN.headphoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyDate) == false && undefined !== pobjTeacherInfoEN.modifyDate && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.modifyDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(modifyDate)]的值:[$(pobjTeacherInfoEN.modifyDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.registerPassword) == false && undefined !== pobjTeacherInfoEN.registerPassword && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.registerPassword) === false) {
            throw new Error("(errid:Watl000060)字段[RegisterPassword(registerPassword)]的值:[$(pobjTeacherInfoEN.registerPassword)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherPhoto) == false && undefined !== pobjTeacherInfoEN.teacherPhoto && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teacherPhoto) === false) {
            throw new Error("(errid:Watl000060)字段[TeacherPhoto(teacherPhoto)]的值:[$(pobjTeacherInfoEN.teacherPhoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_StaffType) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_StaffType) != 4) {
            throw ("(errid:Watl000061)字段[职工类型流水号]作为外键字段,长度应该为4(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjTeacherInfoEN.SetIsCheckProperty(true);
    }
    exports.TeacherInfo_CheckPropertyNew = TeacherInfo_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function TeacherInfo_CheckProperty4Update(pobjTeacherInfoEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Teacher) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Teacher) > 8) {
            throw new Error("(errid:Watl000062)字段[教师流水号(id_Teacher)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Teacher)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherID) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teacherID) > 12) {
            throw new Error("(errid:Watl000062)字段[教师工号(teacherID)]的长度不能超过12(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherID)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherName) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teacherName) > 50) {
            throw new Error("(errid:Watl000062)字段[教师姓名(teacherName)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherName)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Sex) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Sex) > 4) {
            throw new Error("(errid:Watl000062)字段[性别流水号(id_Sex)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Sex)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_School_Ps) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_School_Ps) > 4) {
            throw new Error("(errid:Watl000062)字段[学校流水号(id_School_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_School_Ps)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Discipline_Ps) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Discipline_Ps) > 4) {
            throw new Error("(errid:Watl000062)字段[学科流水号(id_Discipline_Ps)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Discipline_Ps)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_UniZone) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_UniZone) > 4) {
            throw new Error("(errid:Watl000062)字段[校区流水号(id_UniZone)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_UniZone)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Ethnic) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Ethnic) > 4) {
            throw new Error("(errid:Watl000062)字段[民族流水号(id_Ethnic)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Ethnic)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Politics) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Politics) > 4) {
            throw new Error("(errid:Watl000062)字段[政治面貌流水号(id_Politics)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Politics)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_AdminGrade) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_AdminGrade) > 4) {
            throw new Error("(errid:Watl000062)字段[行政职务流水号(id_AdminGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_AdminGrade)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_ProfGrade) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_ProfGrade) > 4) {
            throw new Error("(errid:Watl000062)字段[专业职称流水号(id_ProfGrade)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_ProfGrade)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Qualif) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Qualif) > 4) {
            throw new Error("(errid:Watl000062)字段[学历流水号(id_Qualif)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Qualif)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Degree) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Degree) > 4) {
            throw new Error("(errid:Watl000062)字段[学位流水号(id_Degree)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Degree)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_StaffType) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_StaffType) > 4) {
            throw new Error("(errid:Watl000062)字段[职工类型流水号(id_StaffType)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_StaffType)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Province) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Province) > 4) {
            throw new Error("(errid:Watl000062)字段[省份流水号(id_Province)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Province)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.citizenID) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.citizenID) > 25) {
            throw new Error("(errid:Watl000062)字段[身份证号(citizenID)]的长度不能超过25(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.citizenID)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.cardNo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.cardNo) > 18) {
            throw new Error("(errid:Watl000062)字段[卡号(cardNo)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.cardNo)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.birthday) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.birthday) > 8) {
            throw new Error("(errid:Watl000062)字段[出生日期(birthday)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.birthday)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.graduationMajor) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.graduationMajor) > 40) {
            throw new Error("(errid:Watl000062)字段[毕业专业(graduationMajor)]的长度不能超过40(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.graduationMajor)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.telNo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.telNo) > 50) {
            throw new Error("(errid:Watl000062)字段[电话(telNo)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.telNo)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.email) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.email) > 100) {
            throw new Error("(errid:Watl000062)字段[电子邮箱(email)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.email)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.webSite) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.webSite) > 60) {
            throw new Error("(errid:Watl000062)字段[个人主页(webSite)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.webSite)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.personBlog) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.personBlog) > 60) {
            throw new Error("(errid:Watl000062)字段[个人博客(personBlog)]的长度不能超过60(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.personBlog)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDate) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.entryDate) > 8) {
            throw new Error("(errid:Watl000062)字段[进校日期(entryDate)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDate)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_CardNo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_CardNo) > 20) {
            throw new Error("(errid:Watl000062)字段[内卡号(id_CardNo)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_CardNo)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.fromUnit) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.fromUnit) > 100) {
            throw new Error("(errid:Watl000062)字段[来自单位(fromUnit)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.fromUnit)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.memo)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzCollege) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_XzCollege) > 4) {
            throw new Error("(errid:Watl000062)字段[学院流水号(id_XzCollege)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzCollege)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzMajor) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_XzMajor) > 8) {
            throw new Error("(errid:Watl000062)字段[专业流水号(id_XzMajor)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_XzMajor)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDay) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.entryDay) > 8) {
            throw new Error("(errid:Watl000062)字段[EntryDay(entryDay)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.entryDay)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Photo) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Photo) > 8) {
            throw new Error("(errid:Watl000062)字段[id_Photo(id_Photo)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Photo)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Religion) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_Religion) > 4) {
            throw new Error("(errid:Watl000062)字段[id_Religion(id_Religion)]的长度不能超过4(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.id_Religion)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.microblog) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.microblog) > 200) {
            throw new Error("(errid:Watl000062)字段[Microblog(microblog)]的长度不能超过200(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.microblog)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyUserID) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.modifyUserID) > 18) {
            throw new Error("(errid:Watl000062)字段[修改人(modifyUserID)]的长度不能超过18(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyUserID)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.phoneNumber) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.phoneNumber) > 15) {
            throw new Error("(errid:Watl000062)字段[PhoneNumber(phoneNumber)]的长度不能超过15(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.phoneNumber)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.qQ) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.qQ) > 100) {
            throw new Error("(errid:Watl000062)字段[QQ(qQ)]的长度不能超过100(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.qQ)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_College) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teach_id_College) > 6) {
            throw new Error("(errid:Watl000062)字段[Teach_id_College(teach_id_College)]的长度不能超过6(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_College)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_Major) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teach_id_Major) > 8) {
            throw new Error("(errid:Watl000062)字段[Teach_id_Major(teach_id_Major)]的长度不能超过8(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teach_id_Major)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.tel) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.tel) > 50) {
            throw new Error("(errid:Watl000062)字段[Tel(tel)]的长度不能超过50(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.tel)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.headphoto) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.headphoto) > 500) {
            throw new Error("(errid:Watl000062)字段[Headphoto(headphoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.headphoto)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyDate) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.modifyDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(modifyDate)]的长度不能超过20(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.modifyDate)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.registerPassword) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.registerPassword) > 30) {
            throw new Error("(errid:Watl000062)字段[RegisterPassword(registerPassword)]的长度不能超过30(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.registerPassword)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherPhoto) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.teacherPhoto) > 500) {
            throw new Error("(errid:Watl000062)字段[TeacherPhoto(teacherPhoto)]的长度不能超过500(In 教师(TeacherInfo))!值:$(pobjTeacherInfoEN.teacherPhoto)(clsTeacherInfoBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Teacher) == false && undefined !== pobjTeacherInfoEN.id_Teacher && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Teacher) === false) {
            throw new Error("(errid:Watl000063)字段[教师流水号(id_Teacher)]的值:[$(pobjTeacherInfoEN.id_Teacher)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherID) == false && undefined !== pobjTeacherInfoEN.teacherID && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teacherID) === false) {
            throw new Error("(errid:Watl000063)字段[教师工号(teacherID)]的值:[$(pobjTeacherInfoEN.teacherID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherName) == false && undefined !== pobjTeacherInfoEN.teacherName && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teacherName) === false) {
            throw new Error("(errid:Watl000063)字段[教师姓名(teacherName)]的值:[$(pobjTeacherInfoEN.teacherName)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Sex) == false && undefined !== pobjTeacherInfoEN.id_Sex && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Sex) === false) {
            throw new Error("(errid:Watl000063)字段[性别流水号(id_Sex)]的值:[$(pobjTeacherInfoEN.id_Sex)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_School_Ps) == false && undefined !== pobjTeacherInfoEN.id_School_Ps && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_School_Ps) === false) {
            throw new Error("(errid:Watl000063)字段[学校流水号(id_School_Ps)]的值:[$(pobjTeacherInfoEN.id_School_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Discipline_Ps) == false && undefined !== pobjTeacherInfoEN.id_Discipline_Ps && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Discipline_Ps) === false) {
            throw new Error("(errid:Watl000063)字段[学科流水号(id_Discipline_Ps)]的值:[$(pobjTeacherInfoEN.id_Discipline_Ps)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_UniZone) == false && undefined !== pobjTeacherInfoEN.id_UniZone && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_UniZone) === false) {
            throw new Error("(errid:Watl000063)字段[校区流水号(id_UniZone)]的值:[$(pobjTeacherInfoEN.id_UniZone)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Ethnic) == false && undefined !== pobjTeacherInfoEN.id_Ethnic && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Ethnic) === false) {
            throw new Error("(errid:Watl000063)字段[民族流水号(id_Ethnic)]的值:[$(pobjTeacherInfoEN.id_Ethnic)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Politics) == false && undefined !== pobjTeacherInfoEN.id_Politics && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Politics) === false) {
            throw new Error("(errid:Watl000063)字段[政治面貌流水号(id_Politics)]的值:[$(pobjTeacherInfoEN.id_Politics)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_AdminGrade) == false && undefined !== pobjTeacherInfoEN.id_AdminGrade && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_AdminGrade) === false) {
            throw new Error("(errid:Watl000063)字段[行政职务流水号(id_AdminGrade)]的值:[$(pobjTeacherInfoEN.id_AdminGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_ProfGrade) == false && undefined !== pobjTeacherInfoEN.id_ProfGrade && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_ProfGrade) === false) {
            throw new Error("(errid:Watl000063)字段[专业职称流水号(id_ProfGrade)]的值:[$(pobjTeacherInfoEN.id_ProfGrade)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Qualif) == false && undefined !== pobjTeacherInfoEN.id_Qualif && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Qualif) === false) {
            throw new Error("(errid:Watl000063)字段[学历流水号(id_Qualif)]的值:[$(pobjTeacherInfoEN.id_Qualif)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Degree) == false && undefined !== pobjTeacherInfoEN.id_Degree && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Degree) === false) {
            throw new Error("(errid:Watl000063)字段[学位流水号(id_Degree)]的值:[$(pobjTeacherInfoEN.id_Degree)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_StaffType) == false && undefined !== pobjTeacherInfoEN.id_StaffType && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_StaffType) === false) {
            throw new Error("(errid:Watl000063)字段[职工类型流水号(id_StaffType)]的值:[$(pobjTeacherInfoEN.id_StaffType)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Province) == false && undefined !== pobjTeacherInfoEN.id_Province && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Province) === false) {
            throw new Error("(errid:Watl000063)字段[省份流水号(id_Province)]的值:[$(pobjTeacherInfoEN.id_Province)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.citizenID) == false && undefined !== pobjTeacherInfoEN.citizenID && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.citizenID) === false) {
            throw new Error("(errid:Watl000063)字段[身份证号(citizenID)]的值:[$(pobjTeacherInfoEN.citizenID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.cardNo) == false && undefined !== pobjTeacherInfoEN.cardNo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.cardNo) === false) {
            throw new Error("(errid:Watl000063)字段[卡号(cardNo)]的值:[$(pobjTeacherInfoEN.cardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.birthday) == false && undefined !== pobjTeacherInfoEN.birthday && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.birthday) === false) {
            throw new Error("(errid:Watl000063)字段[出生日期(birthday)]的值:[$(pobjTeacherInfoEN.birthday)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.graduationMajor) == false && undefined !== pobjTeacherInfoEN.graduationMajor && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.graduationMajor) === false) {
            throw new Error("(errid:Watl000063)字段[毕业专业(graduationMajor)]的值:[$(pobjTeacherInfoEN.graduationMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.telNo) == false && undefined !== pobjTeacherInfoEN.telNo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.telNo) === false) {
            throw new Error("(errid:Watl000063)字段[电话(telNo)]的值:[$(pobjTeacherInfoEN.telNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.email) == false && undefined !== pobjTeacherInfoEN.email && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.email) === false) {
            throw new Error("(errid:Watl000063)字段[电子邮箱(email)]的值:[$(pobjTeacherInfoEN.email)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.webSite) == false && undefined !== pobjTeacherInfoEN.webSite && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.webSite) === false) {
            throw new Error("(errid:Watl000063)字段[个人主页(webSite)]的值:[$(pobjTeacherInfoEN.webSite)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.personBlog) == false && undefined !== pobjTeacherInfoEN.personBlog && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.personBlog) === false) {
            throw new Error("(errid:Watl000063)字段[个人博客(personBlog)]的值:[$(pobjTeacherInfoEN.personBlog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDate) == false && undefined !== pobjTeacherInfoEN.entryDate && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.entryDate) === false) {
            throw new Error("(errid:Watl000063)字段[进校日期(entryDate)]的值:[$(pobjTeacherInfoEN.entryDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if (null != pobjTeacherInfoEN.offed && undefined !== pobjTeacherInfoEN.offed && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.offed) === false) {
            throw new Error("(errid:Watl000063)字段[是否离校(offed)]的值:[$(pobjTeacherInfoEN.offed)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_CardNo) == false && undefined !== pobjTeacherInfoEN.id_CardNo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_CardNo) === false) {
            throw new Error("(errid:Watl000063)字段[内卡号(id_CardNo)]的值:[$(pobjTeacherInfoEN.id_CardNo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if (null != pobjTeacherInfoEN.isAvconUser && undefined !== pobjTeacherInfoEN.isAvconUser && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isAvconUser) === false) {
            throw new Error("(errid:Watl000063)字段[IsAvconUser(isAvconUser)]的值:[$(pobjTeacherInfoEN.isAvconUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if (null != pobjTeacherInfoEN.isGpUser && undefined !== pobjTeacherInfoEN.isGpUser && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isGpUser) === false) {
            throw new Error("(errid:Watl000063)字段[是否Gp用户(isGpUser)]的值:[$(pobjTeacherInfoEN.isGpUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if (null != pobjTeacherInfoEN.isLocalUser && undefined !== pobjTeacherInfoEN.isLocalUser && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isLocalUser) === false) {
            throw new Error("(errid:Watl000063)字段[是否本地用户(isLocalUser)]的值:[$(pobjTeacherInfoEN.isLocalUser)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.fromUnit) == false && undefined !== pobjTeacherInfoEN.fromUnit && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.fromUnit) === false) {
            throw new Error("(errid:Watl000063)字段[来自单位(fromUnit)]的值:[$(pobjTeacherInfoEN.fromUnit)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.memo) == false && undefined !== pobjTeacherInfoEN.memo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjTeacherInfoEN.memo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzCollege) == false && undefined !== pobjTeacherInfoEN.id_XzCollege && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_XzCollege) === false) {
            throw new Error("(errid:Watl000063)字段[学院流水号(id_XzCollege)]的值:[$(pobjTeacherInfoEN.id_XzCollege)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_XzMajor) == false && undefined !== pobjTeacherInfoEN.id_XzMajor && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_XzMajor) === false) {
            throw new Error("(errid:Watl000063)字段[专业流水号(id_XzMajor)]的值:[$(pobjTeacherInfoEN.id_XzMajor)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.entryDay) == false && undefined !== pobjTeacherInfoEN.entryDay && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.entryDay) === false) {
            throw new Error("(errid:Watl000063)字段[EntryDay(entryDay)]的值:[$(pobjTeacherInfoEN.entryDay)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Photo) == false && undefined !== pobjTeacherInfoEN.id_Photo && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Photo) === false) {
            throw new Error("(errid:Watl000063)字段[id_Photo(id_Photo)]的值:[$(pobjTeacherInfoEN.id_Photo)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Religion) == false && undefined !== pobjTeacherInfoEN.id_Religion && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.id_Religion) === false) {
            throw new Error("(errid:Watl000063)字段[id_Religion(id_Religion)]的值:[$(pobjTeacherInfoEN.id_Religion)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if (null != pobjTeacherInfoEN.isMessage && undefined !== pobjTeacherInfoEN.isMessage && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.isMessage) === false) {
            throw new Error("(errid:Watl000063)字段[IsMessage(isMessage)]的值:[$(pobjTeacherInfoEN.isMessage)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.microblog) == false && undefined !== pobjTeacherInfoEN.microblog && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.microblog) === false) {
            throw new Error("(errid:Watl000063)字段[Microblog(microblog)]的值:[$(pobjTeacherInfoEN.microblog)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyUserID) == false && undefined !== pobjTeacherInfoEN.modifyUserID && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.modifyUserID) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(modifyUserID)]的值:[$(pobjTeacherInfoEN.modifyUserID)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if (null != pobjTeacherInfoEN.offedBak && undefined !== pobjTeacherInfoEN.offedBak && jsString_js_1.tzDataType.isBoolean(pobjTeacherInfoEN.offedBak) === false) {
            throw new Error("(errid:Watl000063)字段[OffedBak(offedBak)]的值:[$(pobjTeacherInfoEN.offedBak)], 非法，应该为布尔型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.phoneNumber) == false && undefined !== pobjTeacherInfoEN.phoneNumber && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.phoneNumber) === false) {
            throw new Error("(errid:Watl000063)字段[PhoneNumber(phoneNumber)]的值:[$(pobjTeacherInfoEN.phoneNumber)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.qQ) == false && undefined !== pobjTeacherInfoEN.qQ && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.qQ) === false) {
            throw new Error("(errid:Watl000063)字段[QQ(qQ)]的值:[$(pobjTeacherInfoEN.qQ)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_College) == false && undefined !== pobjTeacherInfoEN.teach_id_College && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teach_id_College) === false) {
            throw new Error("(errid:Watl000063)字段[Teach_id_College(teach_id_College)]的值:[$(pobjTeacherInfoEN.teach_id_College)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teach_id_Major) == false && undefined !== pobjTeacherInfoEN.teach_id_Major && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teach_id_Major) === false) {
            throw new Error("(errid:Watl000063)字段[Teach_id_Major(teach_id_Major)]的值:[$(pobjTeacherInfoEN.teach_id_Major)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.tel) == false && undefined !== pobjTeacherInfoEN.tel && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.tel) === false) {
            throw new Error("(errid:Watl000063)字段[Tel(tel)]的值:[$(pobjTeacherInfoEN.tel)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.headphoto) == false && undefined !== pobjTeacherInfoEN.headphoto && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.headphoto) === false) {
            throw new Error("(errid:Watl000063)字段[Headphoto(headphoto)]的值:[$(pobjTeacherInfoEN.headphoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.modifyDate) == false && undefined !== pobjTeacherInfoEN.modifyDate && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.modifyDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(modifyDate)]的值:[$(pobjTeacherInfoEN.modifyDate)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.registerPassword) == false && undefined !== pobjTeacherInfoEN.registerPassword && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.registerPassword) === false) {
            throw new Error("(errid:Watl000063)字段[RegisterPassword(registerPassword)]的值:[$(pobjTeacherInfoEN.registerPassword)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.teacherPhoto) == false && undefined !== pobjTeacherInfoEN.teacherPhoto && jsString_js_1.tzDataType.isString(pobjTeacherInfoEN.teacherPhoto) === false) {
            throw new Error("(errid:Watl000063)字段[TeacherPhoto(teacherPhoto)]的值:[$(pobjTeacherInfoEN.teacherPhoto)], 非法，应该为字符型(In 教师(TeacherInfo))!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_Teacher) === true
            || pobjTeacherInfoEN.id_Teacher.toString() === "0") {
            throw new Error("(errid:Watl000064)字段[教师流水号]不能为空(In 教师)!(clsTeacherInfoBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjTeacherInfoEN.id_StaffType) == false && (0, clsString_js_1.GetStrLen)(pobjTeacherInfoEN.id_StaffType) != 4) {
            throw ("(errid:Watl000065)字段[职工类型流水号]作为外键字段,长度应该为4(In 教师)!(clsTeacherInfoBL:CheckPropertyNew)");
        }
        pobjTeacherInfoEN.SetIsCheckProperty(true);
    }
    exports.TeacherInfo_CheckProperty4Update = TeacherInfo_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TeacherInfo_GetJSONStrByObj(pobjTeacherInfoEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjTeacherInfoEN.sf_UpdFldSetStr = pobjTeacherInfoEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjTeacherInfoEN);
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
    exports.TeacherInfo_GetJSONStrByObj = TeacherInfo_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function TeacherInfo_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrTeacherInfoObjLst = new Array();
        if (strJSON === "") {
            return arrTeacherInfoObjLst;
        }
        try {
            arrTeacherInfoObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrTeacherInfoObjLst;
        }
        return arrTeacherInfoObjLst;
    }
    exports.TeacherInfo_GetObjLstByJSONStr = TeacherInfo_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrTeacherInfoObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function TeacherInfo_GetObjLstByJSONObjLst(arrTeacherInfoObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrTeacherInfoObjLst = new Array();
        for (const objInFor of arrTeacherInfoObjLstS) {
            const obj1 = TeacherInfo_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrTeacherInfoObjLst.push(obj1);
        }
        return arrTeacherInfoObjLst;
    }
    exports.TeacherInfo_GetObjLstByJSONObjLst = TeacherInfo_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function TeacherInfo_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjTeacherInfoEN = new clsTeacherInfoEN_js_1.clsTeacherInfoEN();
        if (strJSON === "") {
            return pobjTeacherInfoEN;
        }
        try {
            pobjTeacherInfoEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjTeacherInfoEN;
        }
        return pobjTeacherInfoEN;
    }
    exports.TeacherInfo_GetObjByJSONStr = TeacherInfo_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function TeacherInfo_GetCombineCondition(objTeacherInfo_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Teacher, objTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherID) == true) {
            const strComparisonOp_TeacherID = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherID, objTeacherInfo_Cond.teacherID, strComparisonOp_TeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName) == true) {
            const strComparisonOp_TeacherName = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherName, objTeacherInfo_Cond.teacherName, strComparisonOp_TeacherName);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Sex, objTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_School_Ps) == true) {
            const strComparisonOp_id_School_Ps = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_School_Ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_School_Ps, objTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Discipline_Ps) == true) {
            const strComparisonOp_id_Discipline_Ps = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Discipline_Ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Discipline_Ps, objTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_UniZone, objTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Ethnic) == true) {
            const strComparisonOp_id_Ethnic = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Ethnic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Ethnic, objTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Politics) == true) {
            const strComparisonOp_id_Politics = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Politics];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Politics, objTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_AdminGrade) == true) {
            const strComparisonOp_id_AdminGrade = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_AdminGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_AdminGrade, objTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_ProfGrade) == true) {
            const strComparisonOp_id_ProfGrade = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_ProfGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_ProfGrade, objTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Qualif) == true) {
            const strComparisonOp_id_Qualif = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Qualif];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Qualif, objTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Degree) == true) {
            const strComparisonOp_id_Degree = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Degree];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Degree, objTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_StaffType) == true) {
            const strComparisonOp_id_StaffType = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_StaffType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_StaffType, objTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Province) == true) {
            const strComparisonOp_id_Province = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Province];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Province, objTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CitizenID) == true) {
            const strComparisonOp_CitizenID = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CitizenID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CitizenID, objTeacherInfo_Cond.citizenID, strComparisonOp_CitizenID);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CardNo) == true) {
            const strComparisonOp_CardNo = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_CardNo, objTeacherInfo_Cond.cardNo, strComparisonOp_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Birthday, objTeacherInfo_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_GraduationMajor) == true) {
            const strComparisonOp_GraduationMajor = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_GraduationMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_GraduationMajor, objTeacherInfo_Cond.graduationMajor, strComparisonOp_GraduationMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TelNo) == true) {
            const strComparisonOp_TelNo = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TelNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TelNo, objTeacherInfo_Cond.telNo, strComparisonOp_TelNo);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Email) == true) {
            const strComparisonOp_Email = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Email, objTeacherInfo_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_WebSite) == true) {
            const strComparisonOp_WebSite = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_WebSite];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_WebSite, objTeacherInfo_Cond.webSite, strComparisonOp_WebSite);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PersonBlog) == true) {
            const strComparisonOp_PersonBlog = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PersonBlog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PersonBlog, objTeacherInfo_Cond.personBlog, strComparisonOp_PersonBlog);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDate) == true) {
            const strComparisonOp_EntryDate = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDate, objTeacherInfo_Cond.entryDate, strComparisonOp_EntryDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Offed) == true) {
            if (objTeacherInfo_Cond.offed == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Offed);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Offed);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Id_CardNo) == true) {
            const strComparisonOp_Id_CardNo = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Id_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Id_CardNo, objTeacherInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsAvconUser) == true) {
            if (objTeacherInfo_Cond.isAvconUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsAvconUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsAvconUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsGpUser) == true) {
            if (objTeacherInfo_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsLocalUser) == true) {
            if (objTeacherInfo_Cond.isLocalUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsLocalUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsLocalUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_FromUnit) == true) {
            const strComparisonOp_FromUnit = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_FromUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_FromUnit, objTeacherInfo_Cond.fromUnit, strComparisonOp_FromUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Memo) == true) {
            const strComparisonOp_Memo = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Memo, objTeacherInfo_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzCollege, objTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_XzMajor, objTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDay) == true) {
            const strComparisonOp_EntryDay = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDay];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_EntryDay, objTeacherInfo_Cond.entryDay, strComparisonOp_EntryDay);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Photo) == true) {
            const strComparisonOp_id_Photo = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Photo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Photo, objTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Religion) == true) {
            const strComparisonOp_id_Religion = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Religion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_id_Religion, objTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsMessage) == true) {
            if (objTeacherInfo_Cond.isMessage == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsMessage);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_IsMessage);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Microblog) == true) {
            const strComparisonOp_Microblog = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Microblog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Microblog, objTeacherInfo_Cond.microblog, strComparisonOp_Microblog);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyUserID, objTeacherInfo_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_OffedBak) == true) {
            if (objTeacherInfo_Cond.offedBak == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_OffedBak);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_OffedBak);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_PhoneNumber, objTeacherInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_QQ) == true) {
            const strComparisonOp_QQ = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_QQ];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_QQ, objTeacherInfo_Cond.qQ, strComparisonOp_QQ);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_College) == true) {
            const strComparisonOp_Teach_id_College = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_College];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_College, objTeacherInfo_Cond.teach_id_College, strComparisonOp_Teach_id_College);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_Major) == true) {
            const strComparisonOp_Teach_id_Major = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Teach_id_Major, objTeacherInfo_Cond.teach_id_Major, strComparisonOp_Teach_id_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Tel) == true) {
            const strComparisonOp_Tel = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Tel];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Tel, objTeacherInfo_Cond.tel, strComparisonOp_Tel);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Headphoto) == true) {
            const strComparisonOp_Headphoto = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Headphoto];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_Headphoto, objTeacherInfo_Cond.headphoto, strComparisonOp_Headphoto);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_ModifyDate, objTeacherInfo_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_RegisterPassword) == true) {
            const strComparisonOp_RegisterPassword = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_RegisterPassword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_RegisterPassword, objTeacherInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
        }
        if (Object.prototype.hasOwnProperty.call(objTeacherInfo_Cond.dicFldComparisonOp, clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherPhoto) == true) {
            const strComparisonOp_TeacherPhoto = objTeacherInfo_Cond.dicFldComparisonOp[clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherPhoto];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsTeacherInfoEN_js_1.clsTeacherInfoEN.con_TeacherPhoto, objTeacherInfo_Cond.teacherPhoto, strComparisonOp_TeacherPhoto);
        }
        return strWhereCond;
    }
    exports.TeacherInfo_GetCombineCondition = TeacherInfo_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--TeacherInfo(教师),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strTeacherID: 教师工号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TeacherInfo_GetUniCondStr_TeacherID(objTeacherInfoEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and TeacherID = '{0}'", objTeacherInfoEN.teacherID);
        return strWhereCond;
    }
    exports.TeacherInfo_GetUniCondStr_TeacherID = TeacherInfo_GetUniCondStr_TeacherID;
    /**
    *获取唯一性条件串(Uniqueness)--TeacherInfo(教师),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strTeacherID: 教师工号(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function TeacherInfo_GetUniCondStr4Update_TeacherID(objTeacherInfoEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and id_Teacher <> '{0}'", objTeacherInfoEN.id_Teacher);
        strWhereCond += (0, clsString_js_1.Format)(" and TeacherID = '{0}'", objTeacherInfoEN.teacherID);
        return strWhereCond;
    }
    exports.TeacherInfo_GetUniCondStr4Update_TeacherID = TeacherInfo_GetUniCondStr4Update_TeacherID;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objTeacherInfoENS:源对象
     * @param objTeacherInfoENT:目标对象
    */
    function TeacherInfo_CopyObjTo(objTeacherInfoENS, objTeacherInfoENT) {
        objTeacherInfoENT.id_Teacher = objTeacherInfoENS.id_Teacher; //教师流水号
        objTeacherInfoENT.teacherID = objTeacherInfoENS.teacherID; //教师工号
        objTeacherInfoENT.teacherName = objTeacherInfoENS.teacherName; //教师姓名
        objTeacherInfoENT.id_Sex = objTeacherInfoENS.id_Sex; //性别流水号
        objTeacherInfoENT.id_School_Ps = objTeacherInfoENS.id_School_Ps; //学校流水号
        objTeacherInfoENT.id_Discipline_Ps = objTeacherInfoENS.id_Discipline_Ps; //学科流水号
        objTeacherInfoENT.id_UniZone = objTeacherInfoENS.id_UniZone; //校区流水号
        objTeacherInfoENT.id_Ethnic = objTeacherInfoENS.id_Ethnic; //民族流水号
        objTeacherInfoENT.id_Politics = objTeacherInfoENS.id_Politics; //政治面貌流水号
        objTeacherInfoENT.id_AdminGrade = objTeacherInfoENS.id_AdminGrade; //行政职务流水号
        objTeacherInfoENT.id_ProfGrade = objTeacherInfoENS.id_ProfGrade; //专业职称流水号
        objTeacherInfoENT.id_Qualif = objTeacherInfoENS.id_Qualif; //学历流水号
        objTeacherInfoENT.id_Degree = objTeacherInfoENS.id_Degree; //学位流水号
        objTeacherInfoENT.id_StaffType = objTeacherInfoENS.id_StaffType; //职工类型流水号
        objTeacherInfoENT.id_Province = objTeacherInfoENS.id_Province; //省份流水号
        objTeacherInfoENT.citizenID = objTeacherInfoENS.citizenID; //身份证号
        objTeacherInfoENT.cardNo = objTeacherInfoENS.cardNo; //卡号
        objTeacherInfoENT.birthday = objTeacherInfoENS.birthday; //出生日期
        objTeacherInfoENT.graduationMajor = objTeacherInfoENS.graduationMajor; //毕业专业
        objTeacherInfoENT.telNo = objTeacherInfoENS.telNo; //电话
        objTeacherInfoENT.email = objTeacherInfoENS.email; //电子邮箱
        objTeacherInfoENT.webSite = objTeacherInfoENS.webSite; //个人主页
        objTeacherInfoENT.personBlog = objTeacherInfoENS.personBlog; //个人博客
        objTeacherInfoENT.entryDate = objTeacherInfoENS.entryDate; //进校日期
        objTeacherInfoENT.offed = objTeacherInfoENS.offed; //是否离校
        objTeacherInfoENT.id_CardNo = objTeacherInfoENS.id_CardNo; //内卡号
        objTeacherInfoENT.isAvconUser = objTeacherInfoENS.isAvconUser; //IsAvconUser
        objTeacherInfoENT.isGpUser = objTeacherInfoENS.isGpUser; //是否Gp用户
        objTeacherInfoENT.isLocalUser = objTeacherInfoENS.isLocalUser; //是否本地用户
        objTeacherInfoENT.fromUnit = objTeacherInfoENS.fromUnit; //来自单位
        objTeacherInfoENT.memo = objTeacherInfoENS.memo; //备注
        objTeacherInfoENT.id_XzCollege = objTeacherInfoENS.id_XzCollege; //学院流水号
        objTeacherInfoENT.id_XzMajor = objTeacherInfoENS.id_XzMajor; //专业流水号
        objTeacherInfoENT.entryDay = objTeacherInfoENS.entryDay; //EntryDay
        objTeacherInfoENT.id_Photo = objTeacherInfoENS.id_Photo; //id_Photo
        objTeacherInfoENT.id_Religion = objTeacherInfoENS.id_Religion; //id_Religion
        objTeacherInfoENT.isMessage = objTeacherInfoENS.isMessage; //IsMessage
        objTeacherInfoENT.microblog = objTeacherInfoENS.microblog; //Microblog
        objTeacherInfoENT.modifyUserID = objTeacherInfoENS.modifyUserID; //修改人
        objTeacherInfoENT.offedBak = objTeacherInfoENS.offedBak; //OffedBak
        objTeacherInfoENT.phoneNumber = objTeacherInfoENS.phoneNumber; //PhoneNumber
        objTeacherInfoENT.qQ = objTeacherInfoENS.qQ; //QQ
        objTeacherInfoENT.teach_id_College = objTeacherInfoENS.teach_id_College; //Teach_id_College
        objTeacherInfoENT.teach_id_Major = objTeacherInfoENS.teach_id_Major; //Teach_id_Major
        objTeacherInfoENT.tel = objTeacherInfoENS.tel; //Tel
        objTeacherInfoENT.headphoto = objTeacherInfoENS.headphoto; //Headphoto
        objTeacherInfoENT.modifyDate = objTeacherInfoENS.modifyDate; //修改日期
        objTeacherInfoENT.registerPassword = objTeacherInfoENS.registerPassword; //RegisterPassword
        objTeacherInfoENT.teacherPhoto = objTeacherInfoENS.teacherPhoto; //TeacherPhoto
        objTeacherInfoENT.sf_UpdFldSetStr = objTeacherInfoENS.updFldString; //sf_UpdFldSetStr
    }
    exports.TeacherInfo_CopyObjTo = TeacherInfo_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objTeacherInfoENS:源对象
     * @param objTeacherInfoENT:目标对象
    */
    function TeacherInfo_GetObjFromJsonObj(objTeacherInfoENS) {
        const objTeacherInfoENT = new clsTeacherInfoEN_js_1.clsTeacherInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objTeacherInfoENT, objTeacherInfoENS);
        return objTeacherInfoENT;
    }
    exports.TeacherInfo_GetObjFromJsonObj = TeacherInfo_GetObjFromJsonObj;
});
