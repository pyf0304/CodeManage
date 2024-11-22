/**
* 类名:clsvTeacherInfoWApi
* 表名:vTeacherInfo(01120094)
* 版本:2023.02.24.1(服务器:WIN-SRV103-116)
* 日期:2023/02/24 13:47:54
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/BaseInfo/clsvTeacherInfoEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vTeacherInfo_GetObjFromJsonObj = exports.vTeacherInfo_CopyObjTo = exports.vTeacherInfo_GetCombineCondition = exports.vTeacherInfo_GetObjByJSONStr = exports.vTeacherInfo_GetObjLstByJSONObjLst = exports.vTeacherInfo_GetObjLstByJSONStr = exports.vTeacherInfo_GetJSONStrByObj = exports.vTeacherInfo__Cache = exports.vTeacherInfo_ReFreshThisCache = exports.vTeacherInfo_GetWebApiUrl = exports.vTeacherInfo_GetRecCountByCond_Cache = exports.vTeacherInfo_GetRecCountByCondAsync = exports.vTeacherInfo_IsExistAsync = exports.vTeacherInfo_IsExist_Cache = exports.vTeacherInfo_IsExist = exports.vTeacherInfo_IsExistRecordAsync = exports.vTeacherInfo_IsExistRecord_Cache = exports.vTeacherInfo_GetObjLstByPagerAsync = exports.vTeacherInfo_GetObjLstByPager_Cache = exports.vTeacherInfo_GetObjLstByRange = exports.vTeacherInfo_GetObjLstByRangeAsync = exports.vTeacherInfo_GetTopObjLstAsync = exports.vTeacherInfo_GetObjLstByid_TeacherLst_Cache = exports.vTeacherInfo_GetObjLstByid_TeacherLstAsync = exports.vTeacherInfo_GetSubObjLst_Cache = exports.vTeacherInfo_GetObjLst_PureCache = exports.vTeacherInfo_GetObjLst_Cache = exports.vTeacherInfo_GetObjLst_sessionStorage_PureCache = exports.vTeacherInfo_GetObjLst_sessionStorage = exports.vTeacherInfo_GetObjLstAsync = exports.vTeacherInfo_GetObjLst_localStorage_PureCache = exports.vTeacherInfo_GetObjLst_localStorage = exports.vTeacherInfo_GetObjLst_ClientCache = exports.vTeacherInfo_GetFirstObjAsync = exports.vTeacherInfo_GetFirstID = exports.vTeacherInfo_GetFirstIDAsync = exports.vTeacherInfo_funcKey = exports.vTeacherInfo_FilterFunByKey = exports.vTeacherInfo_SortFunByKey = exports.vTeacherInfo_SortFun_Defa_2Fld = exports.vTeacherInfo_SortFun_Defa = exports.vTeacherInfo_func = exports.vTeacherInfo_GetNameByid_Teacher_Cache = exports.vTeacherInfo_GetObjByid_Teacher_localStorage = exports.vTeacherInfo_GetObjByid_Teacher_Cache = exports.vTeacherInfo_GetObjByid_TeacherAsync = exports.vTeacherInfo_ConstructorName = exports.vTeacherInfo_Controller = void 0;
    /**
     * v教师(vTeacherInfo)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年02月24日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvTeacherInfoEN_js_1 = require("../../L0_Entity/BaseInfo/clsvTeacherInfoEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vTeacherInfo_Controller = "vTeacherInfoApi";
    exports.vTeacherInfo_ConstructorName = "vTeacherInfo";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strid_Teacher:关键字
    * @returns 对象
    **/
    async function vTeacherInfo_GetObjByid_TeacherAsync(strid_Teacher) {
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
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const objvTeacherInfo = vTeacherInfo_GetObjFromJsonObj(returnObj);
                return objvTeacherInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjByid_TeacherAsync = vTeacherInfo_GetObjByid_TeacherAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function vTeacherInfo_GetObjByid_Teacher_Cache(strid_Teacher, bolTryAsyncOnce = true) {
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
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        try {
            const arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
            let objvTeacherInfo;
            if (arrvTeacherInfo_Sel.length > 0) {
                objvTeacherInfo = arrvTeacherInfo_Sel[0];
                return objvTeacherInfo;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvTeacherInfo_Const = await vTeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
                    if (objvTeacherInfo_Const != null) {
                        vTeacherInfo_ReFreshThisCache();
                        return objvTeacherInfo_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Teacher, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vTeacherInfo_GetObjByid_Teacher_Cache = vTeacherInfo_GetObjByid_Teacher_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function vTeacherInfo_GetObjByid_Teacher_localStorage(strid_Teacher) {
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
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName, strid_Teacher);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvTeacherInfo_Cache = JSON.parse(strTempObj);
            return objvTeacherInfo_Cache;
        }
        try {
            const objvTeacherInfo = await vTeacherInfo_GetObjByid_TeacherAsync(strid_Teacher);
            if (objvTeacherInfo != null) {
                localStorage.setItem(strKey, JSON.stringify(objvTeacherInfo));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvTeacherInfo;
            }
            return objvTeacherInfo;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strid_Teacher, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vTeacherInfo_GetObjByid_Teacher_localStorage = vTeacherInfo_GetObjByid_Teacher_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function vTeacherInfo_GetNameByid_Teacher_Cache(strid_Teacher) {
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
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        if (arrvTeacherInfoObjLst_Cache == null)
            return "";
        try {
            const arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
            let objvTeacherInfo;
            if (arrvTeacherInfo_Sel.length > 0) {
                objvTeacherInfo = arrvTeacherInfo_Sel[0];
                return objvTeacherInfo.teacherName;
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
    exports.vTeacherInfo_GetNameByid_Teacher_Cache = vTeacherInfo_GetNameByid_Teacher_Cache;
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
    async function vTeacherInfo_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strid_Teacher = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvTeacherInfo = await vTeacherInfo_GetObjByid_Teacher_Cache(strid_Teacher);
        if (objvTeacherInfo == null)
            return "";
        if (objvTeacherInfo.GetFldValue(strOutFldName) == null)
            return "";
        return objvTeacherInfo.GetFldValue(strOutFldName).toString();
    }
    exports.vTeacherInfo_func = vTeacherInfo_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTeacherInfo_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.id_Teacher.localeCompare(b.id_Teacher);
    }
    exports.vTeacherInfo_SortFun_Defa = vTeacherInfo_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTeacherInfo_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.teacherID == b.teacherID)
            return a.teacherName.localeCompare(b.teacherName);
        else
            return a.teacherID.localeCompare(b.teacherID);
    }
    exports.vTeacherInfo_SortFun_Defa_2Fld = vTeacherInfo_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vTeacherInfo_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher:
                    return (a, b) => {
                        return a.id_Teacher.localeCompare(b.id_Teacher);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID:
                    return (a, b) => {
                        return a.teacherID.localeCompare(b.teacherID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName:
                    return (a, b) => {
                        return a.teacherName.localeCompare(b.teacherName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex:
                    return (a, b) => {
                        return a.id_Sex.localeCompare(b.id_Sex);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc:
                    return (a, b) => {
                        if (a.sexDesc == null)
                            return -1;
                        if (b.sexDesc == null)
                            return 1;
                        return a.sexDesc.localeCompare(b.sexDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps:
                    return (a, b) => {
                        if (a.id_School_Ps == null)
                            return -1;
                        if (b.id_School_Ps == null)
                            return 1;
                        return a.id_School_Ps.localeCompare(b.id_School_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId:
                    return (a, b) => {
                        if (a.schoolId == null)
                            return -1;
                        if (b.schoolId == null)
                            return 1;
                        return a.schoolId.localeCompare(b.schoolId);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName:
                    return (a, b) => {
                        if (a.schoolName == null)
                            return -1;
                        if (b.schoolName == null)
                            return 1;
                        return a.schoolName.localeCompare(b.schoolName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps:
                    return (a, b) => {
                        if (a.id_Discipline_Ps == null)
                            return -1;
                        if (b.id_Discipline_Ps == null)
                            return 1;
                        return a.id_Discipline_Ps.localeCompare(b.id_Discipline_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone:
                    return (a, b) => {
                        return a.id_UniZone.localeCompare(b.id_UniZone);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc:
                    return (a, b) => {
                        if (a.uniZoneDesc == null)
                            return -1;
                        if (b.uniZoneDesc == null)
                            return 1;
                        return a.uniZoneDesc.localeCompare(b.uniZoneDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        return a.id_Ethnic.localeCompare(b.id_Ethnic);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName:
                    return (a, b) => {
                        if (a.ethnicName == null)
                            return -1;
                        if (b.ethnicName == null)
                            return 1;
                        return a.ethnicName.localeCompare(b.ethnicName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics:
                    return (a, b) => {
                        return a.id_Politics.localeCompare(b.id_Politics);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName:
                    return (a, b) => {
                        return a.politicsName.localeCompare(b.politicsName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade:
                    return (a, b) => {
                        return a.id_AdminGrade.localeCompare(b.id_AdminGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc:
                    return (a, b) => {
                        return a.adminGradeDesc.localeCompare(b.adminGradeDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade:
                    return (a, b) => {
                        return a.id_ProfGrade.localeCompare(b.id_ProfGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName:
                    return (a, b) => {
                        return a.profenssionalGradeName.localeCompare(b.profenssionalGradeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif:
                    return (a, b) => {
                        return a.id_Qualif.localeCompare(b.id_Qualif);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc:
                    return (a, b) => {
                        if (a.qualifDesc == null)
                            return -1;
                        if (b.qualifDesc == null)
                            return 1;
                        return a.qualifDesc.localeCompare(b.qualifDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree:
                    return (a, b) => {
                        return a.id_Degree.localeCompare(b.id_Degree);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName:
                    return (a, b) => {
                        return a.degreeName.localeCompare(b.degreeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType:
                    return (a, b) => {
                        return a.id_StaffType.localeCompare(b.id_StaffType);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName:
                    return (a, b) => {
                        if (a.staffTypeName == null)
                            return -1;
                        if (b.staffTypeName == null)
                            return 1;
                        return a.staffTypeName.localeCompare(b.staffTypeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province:
                    return (a, b) => {
                        return a.id_Province.localeCompare(b.id_Province);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName:
                    return (a, b) => {
                        if (a.provinceName == null)
                            return -1;
                        if (b.provinceName == null)
                            return 1;
                        return a.provinceName.localeCompare(b.provinceName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID:
                    return (a, b) => {
                        if (a.citizenID == null)
                            return -1;
                        if (b.citizenID == null)
                            return 1;
                        return a.citizenID.localeCompare(b.citizenID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo:
                    return (a, b) => {
                        if (a.cardNo == null)
                            return -1;
                        if (b.cardNo == null)
                            return 1;
                        return a.cardNo.localeCompare(b.cardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday:
                    return (a, b) => {
                        if (a.birthday == null)
                            return -1;
                        if (b.birthday == null)
                            return 1;
                        return a.birthday.localeCompare(b.birthday);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor:
                    return (a, b) => {
                        if (a.graduationMajor == null)
                            return -1;
                        if (b.graduationMajor == null)
                            return 1;
                        return a.graduationMajor.localeCompare(b.graduationMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo:
                    return (a, b) => {
                        if (a.telNo == null)
                            return -1;
                        if (b.telNo == null)
                            return 1;
                        return a.telNo.localeCompare(b.telNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email:
                    return (a, b) => {
                        if (a.email == null)
                            return -1;
                        if (b.email == null)
                            return 1;
                        return a.email.localeCompare(b.email);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite:
                    return (a, b) => {
                        if (a.webSite == null)
                            return -1;
                        if (b.webSite == null)
                            return 1;
                        return a.webSite.localeCompare(b.webSite);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog:
                    return (a, b) => {
                        if (a.personBlog == null)
                            return -1;
                        if (b.personBlog == null)
                            return 1;
                        return a.personBlog.localeCompare(b.personBlog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate:
                    return (a, b) => {
                        if (a.entryDate == null)
                            return -1;
                        if (b.entryDate == null)
                            return 1;
                        return a.entryDate.localeCompare(b.entryDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed:
                    return (a, b) => {
                        if (a.offed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (a.id_CardNo == null)
                            return -1;
                        if (b.id_CardNo == null)
                            return 1;
                        return a.id_CardNo.localeCompare(b.id_CardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (a.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (a.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (a.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit:
                    return (a, b) => {
                        if (a.fromUnit == null)
                            return -1;
                        if (b.fromUnit == null)
                            return 1;
                        return a.fromUnit.localeCompare(b.fromUnit);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID:
                    return (a, b) => {
                        if (a.collegeID == null)
                            return -1;
                        if (b.collegeID == null)
                            return 1;
                        return a.collegeID.localeCompare(b.collegeID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA:
                    return (a, b) => {
                        if (a.collegeNameA == null)
                            return -1;
                        if (b.collegeNameA == null)
                            return 1;
                        return a.collegeNameA.localeCompare(b.collegeNameA);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay:
                    return (a, b) => {
                        if (a.entryDay == null)
                            return -1;
                        if (b.entryDay == null)
                            return 1;
                        return a.entryDay.localeCompare(b.entryDay);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo:
                    return (a, b) => {
                        if (a.id_Photo == null)
                            return -1;
                        if (b.id_Photo == null)
                            return 1;
                        return a.id_Photo.localeCompare(b.id_Photo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion:
                    return (a, b) => {
                        if (a.id_Religion == null)
                            return -1;
                        if (b.id_Religion == null)
                            return 1;
                        return a.id_Religion.localeCompare(b.id_Religion);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName:
                    return (a, b) => {
                        if (a.religionName == null)
                            return -1;
                        if (b.religionName == null)
                            return 1;
                        return a.religionName.localeCompare(b.religionName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (a.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog:
                    return (a, b) => {
                        if (a.microblog == null)
                            return -1;
                        if (b.microblog == null)
                            return 1;
                        return a.microblog.localeCompare(b.microblog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID:
                    return (a, b) => {
                        if (a.modifyUserID == null)
                            return -1;
                        if (b.modifyUserID == null)
                            return 1;
                        return a.modifyUserID.localeCompare(b.modifyUserID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak:
                    return (a, b) => {
                        if (a.offedBak == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (a.phoneNumber == null)
                            return -1;
                        if (b.phoneNumber == null)
                            return 1;
                        return a.phoneNumber.localeCompare(b.phoneNumber);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ:
                    return (a, b) => {
                        if (a.qQ == null)
                            return -1;
                        if (b.qQ == null)
                            return 1;
                        return a.qQ.localeCompare(b.qQ);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College:
                    return (a, b) => {
                        if (a.teach_id_College == null)
                            return -1;
                        if (b.teach_id_College == null)
                            return 1;
                        return a.teach_id_College.localeCompare(b.teach_id_College);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major:
                    return (a, b) => {
                        if (a.teach_id_Major == null)
                            return -1;
                        if (b.teach_id_Major == null)
                            return 1;
                        return a.teach_id_Major.localeCompare(b.teach_id_Major);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel:
                    return (a, b) => {
                        if (a.tel == null)
                            return -1;
                        if (b.tel == null)
                            return 1;
                        return a.tel.localeCompare(b.tel);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate:
                    return (a, b) => {
                        if (a.modifyDate == null)
                            return -1;
                        if (b.modifyDate == null)
                            return 1;
                        return a.modifyDate.localeCompare(b.modifyDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (a.registerPassword == null)
                            return -1;
                        if (b.registerPassword == null)
                            return 1;
                        return a.registerPassword.localeCompare(b.registerPassword);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear:
                    return (a, b) => {
                        if (a.entryYear == null)
                            return -1;
                        if (b.entryYear == null)
                            return 1;
                        return a.entryYear.localeCompare(b.entryYear);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps:
                    return (a, b) => {
                        if (a.disciplineName_ps == null)
                            return -1;
                        if (b.disciplineName_ps == null)
                            return 1;
                        return a.disciplineName_ps.localeCompare(b.disciplineName_ps);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${exports.vTeacherInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher:
                    return (a, b) => {
                        return b.id_Teacher.localeCompare(a.id_Teacher);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID:
                    return (a, b) => {
                        return b.teacherID.localeCompare(a.teacherID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName:
                    return (a, b) => {
                        return b.teacherName.localeCompare(a.teacherName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex:
                    return (a, b) => {
                        return b.id_Sex.localeCompare(a.id_Sex);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc:
                    return (a, b) => {
                        if (b.sexDesc == null)
                            return -1;
                        if (a.sexDesc == null)
                            return 1;
                        return b.sexDesc.localeCompare(a.sexDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps:
                    return (a, b) => {
                        if (b.id_School_Ps == null)
                            return -1;
                        if (a.id_School_Ps == null)
                            return 1;
                        return b.id_School_Ps.localeCompare(a.id_School_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId:
                    return (a, b) => {
                        if (b.schoolId == null)
                            return -1;
                        if (a.schoolId == null)
                            return 1;
                        return b.schoolId.localeCompare(a.schoolId);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName:
                    return (a, b) => {
                        if (b.schoolName == null)
                            return -1;
                        if (a.schoolName == null)
                            return 1;
                        return b.schoolName.localeCompare(a.schoolName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps:
                    return (a, b) => {
                        if (b.id_Discipline_Ps == null)
                            return -1;
                        if (a.id_Discipline_Ps == null)
                            return 1;
                        return b.id_Discipline_Ps.localeCompare(a.id_Discipline_Ps);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone:
                    return (a, b) => {
                        return b.id_UniZone.localeCompare(a.id_UniZone);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc:
                    return (a, b) => {
                        if (b.uniZoneDesc == null)
                            return -1;
                        if (a.uniZoneDesc == null)
                            return 1;
                        return b.uniZoneDesc.localeCompare(a.uniZoneDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic:
                    return (a, b) => {
                        return b.id_Ethnic.localeCompare(a.id_Ethnic);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName:
                    return (a, b) => {
                        if (b.ethnicName == null)
                            return -1;
                        if (a.ethnicName == null)
                            return 1;
                        return b.ethnicName.localeCompare(a.ethnicName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics:
                    return (a, b) => {
                        return b.id_Politics.localeCompare(a.id_Politics);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName:
                    return (a, b) => {
                        return b.politicsName.localeCompare(a.politicsName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade:
                    return (a, b) => {
                        return b.id_AdminGrade.localeCompare(a.id_AdminGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc:
                    return (a, b) => {
                        return b.adminGradeDesc.localeCompare(a.adminGradeDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade:
                    return (a, b) => {
                        return b.id_ProfGrade.localeCompare(a.id_ProfGrade);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName:
                    return (a, b) => {
                        return b.profenssionalGradeName.localeCompare(a.profenssionalGradeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif:
                    return (a, b) => {
                        return b.id_Qualif.localeCompare(a.id_Qualif);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc:
                    return (a, b) => {
                        if (b.qualifDesc == null)
                            return -1;
                        if (a.qualifDesc == null)
                            return 1;
                        return b.qualifDesc.localeCompare(a.qualifDesc);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree:
                    return (a, b) => {
                        return b.id_Degree.localeCompare(a.id_Degree);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName:
                    return (a, b) => {
                        return b.degreeName.localeCompare(a.degreeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType:
                    return (a, b) => {
                        return b.id_StaffType.localeCompare(a.id_StaffType);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName:
                    return (a, b) => {
                        if (b.staffTypeName == null)
                            return -1;
                        if (a.staffTypeName == null)
                            return 1;
                        return b.staffTypeName.localeCompare(a.staffTypeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province:
                    return (a, b) => {
                        return b.id_Province.localeCompare(a.id_Province);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName:
                    return (a, b) => {
                        if (b.provinceName == null)
                            return -1;
                        if (a.provinceName == null)
                            return 1;
                        return b.provinceName.localeCompare(a.provinceName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID:
                    return (a, b) => {
                        if (b.citizenID == null)
                            return -1;
                        if (a.citizenID == null)
                            return 1;
                        return b.citizenID.localeCompare(a.citizenID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo:
                    return (a, b) => {
                        if (b.cardNo == null)
                            return -1;
                        if (a.cardNo == null)
                            return 1;
                        return b.cardNo.localeCompare(a.cardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday:
                    return (a, b) => {
                        if (b.birthday == null)
                            return -1;
                        if (a.birthday == null)
                            return 1;
                        return b.birthday.localeCompare(a.birthday);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor:
                    return (a, b) => {
                        if (b.graduationMajor == null)
                            return -1;
                        if (a.graduationMajor == null)
                            return 1;
                        return b.graduationMajor.localeCompare(a.graduationMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo:
                    return (a, b) => {
                        if (b.telNo == null)
                            return -1;
                        if (a.telNo == null)
                            return 1;
                        return b.telNo.localeCompare(a.telNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email:
                    return (a, b) => {
                        if (b.email == null)
                            return -1;
                        if (a.email == null)
                            return 1;
                        return b.email.localeCompare(a.email);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite:
                    return (a, b) => {
                        if (b.webSite == null)
                            return -1;
                        if (a.webSite == null)
                            return 1;
                        return b.webSite.localeCompare(a.webSite);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog:
                    return (a, b) => {
                        if (b.personBlog == null)
                            return -1;
                        if (a.personBlog == null)
                            return 1;
                        return b.personBlog.localeCompare(a.personBlog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate:
                    return (a, b) => {
                        if (b.entryDate == null)
                            return -1;
                        if (a.entryDate == null)
                            return 1;
                        return b.entryDate.localeCompare(a.entryDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed:
                    return (a, b) => {
                        if (b.offed == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo:
                    return (a, b) => {
                        if (b.id_CardNo == null)
                            return -1;
                        if (a.id_CardNo == null)
                            return 1;
                        return b.id_CardNo.localeCompare(a.id_CardNo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser:
                    return (a, b) => {
                        if (b.isAvconUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser:
                    return (a, b) => {
                        if (b.isGpUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser:
                    return (a, b) => {
                        if (b.isLocalUser == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit:
                    return (a, b) => {
                        if (b.fromUnit == null)
                            return -1;
                        if (a.fromUnit == null)
                            return 1;
                        return b.fromUnit.localeCompare(a.fromUnit);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID:
                    return (a, b) => {
                        if (b.collegeID == null)
                            return -1;
                        if (a.collegeID == null)
                            return 1;
                        return b.collegeID.localeCompare(a.collegeID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA:
                    return (a, b) => {
                        if (b.collegeNameA == null)
                            return -1;
                        if (a.collegeNameA == null)
                            return 1;
                        return b.collegeNameA.localeCompare(a.collegeNameA);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay:
                    return (a, b) => {
                        if (b.entryDay == null)
                            return -1;
                        if (a.entryDay == null)
                            return 1;
                        return b.entryDay.localeCompare(a.entryDay);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo:
                    return (a, b) => {
                        if (b.id_Photo == null)
                            return -1;
                        if (a.id_Photo == null)
                            return 1;
                        return b.id_Photo.localeCompare(a.id_Photo);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion:
                    return (a, b) => {
                        if (b.id_Religion == null)
                            return -1;
                        if (a.id_Religion == null)
                            return 1;
                        return b.id_Religion.localeCompare(a.id_Religion);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName:
                    return (a, b) => {
                        if (b.religionName == null)
                            return -1;
                        if (a.religionName == null)
                            return 1;
                        return b.religionName.localeCompare(a.religionName);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage:
                    return (a, b) => {
                        if (b.isMessage == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog:
                    return (a, b) => {
                        if (b.microblog == null)
                            return -1;
                        if (a.microblog == null)
                            return 1;
                        return b.microblog.localeCompare(a.microblog);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID:
                    return (a, b) => {
                        if (b.modifyUserID == null)
                            return -1;
                        if (a.modifyUserID == null)
                            return 1;
                        return b.modifyUserID.localeCompare(a.modifyUserID);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak:
                    return (a, b) => {
                        if (b.offedBak == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber:
                    return (a, b) => {
                        if (b.phoneNumber == null)
                            return -1;
                        if (a.phoneNumber == null)
                            return 1;
                        return b.phoneNumber.localeCompare(a.phoneNumber);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ:
                    return (a, b) => {
                        if (b.qQ == null)
                            return -1;
                        if (a.qQ == null)
                            return 1;
                        return b.qQ.localeCompare(a.qQ);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College:
                    return (a, b) => {
                        if (b.teach_id_College == null)
                            return -1;
                        if (a.teach_id_College == null)
                            return 1;
                        return b.teach_id_College.localeCompare(a.teach_id_College);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major:
                    return (a, b) => {
                        if (b.teach_id_Major == null)
                            return -1;
                        if (a.teach_id_Major == null)
                            return 1;
                        return b.teach_id_Major.localeCompare(a.teach_id_Major);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel:
                    return (a, b) => {
                        if (b.tel == null)
                            return -1;
                        if (a.tel == null)
                            return 1;
                        return b.tel.localeCompare(a.tel);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate:
                    return (a, b) => {
                        if (b.modifyDate == null)
                            return -1;
                        if (a.modifyDate == null)
                            return 1;
                        return b.modifyDate.localeCompare(a.modifyDate);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword:
                    return (a, b) => {
                        if (b.registerPassword == null)
                            return -1;
                        if (a.registerPassword == null)
                            return 1;
                        return b.registerPassword.localeCompare(a.registerPassword);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear:
                    return (a, b) => {
                        if (b.entryYear == null)
                            return -1;
                        if (a.entryYear == null)
                            return 1;
                        return b.entryYear.localeCompare(a.entryYear);
                    };
                case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps:
                    return (a, b) => {
                        if (b.disciplineName_ps == null)
                            return -1;
                        if (a.disciplineName_ps == null)
                            return 1;
                        return b.disciplineName_ps.localeCompare(a.disciplineName_ps);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${exports.vTeacherInfo_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vTeacherInfo_SortFunByKey = vTeacherInfo_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vTeacherInfo_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher:
                return (obj) => {
                    return obj.id_Teacher === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID:
                return (obj) => {
                    return obj.teacherID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName:
                return (obj) => {
                    return obj.teacherName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex:
                return (obj) => {
                    return obj.id_Sex === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc:
                return (obj) => {
                    return obj.sexDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps:
                return (obj) => {
                    return obj.id_School_Ps === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId:
                return (obj) => {
                    return obj.schoolId === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName:
                return (obj) => {
                    return obj.schoolName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps:
                return (obj) => {
                    return obj.id_Discipline_Ps === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone:
                return (obj) => {
                    return obj.id_UniZone === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc:
                return (obj) => {
                    return obj.uniZoneDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic:
                return (obj) => {
                    return obj.id_Ethnic === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName:
                return (obj) => {
                    return obj.ethnicName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics:
                return (obj) => {
                    return obj.id_Politics === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName:
                return (obj) => {
                    return obj.politicsName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade:
                return (obj) => {
                    return obj.id_AdminGrade === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc:
                return (obj) => {
                    return obj.adminGradeDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade:
                return (obj) => {
                    return obj.id_ProfGrade === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName:
                return (obj) => {
                    return obj.profenssionalGradeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif:
                return (obj) => {
                    return obj.id_Qualif === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc:
                return (obj) => {
                    return obj.qualifDesc === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree:
                return (obj) => {
                    return obj.id_Degree === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName:
                return (obj) => {
                    return obj.degreeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType:
                return (obj) => {
                    return obj.id_StaffType === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName:
                return (obj) => {
                    return obj.staffTypeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province:
                return (obj) => {
                    return obj.id_Province === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName:
                return (obj) => {
                    return obj.provinceName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID:
                return (obj) => {
                    return obj.citizenID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo:
                return (obj) => {
                    return obj.cardNo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday:
                return (obj) => {
                    return obj.birthday === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor:
                return (obj) => {
                    return obj.graduationMajor === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo:
                return (obj) => {
                    return obj.telNo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email:
                return (obj) => {
                    return obj.email === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite:
                return (obj) => {
                    return obj.webSite === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog:
                return (obj) => {
                    return obj.personBlog === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate:
                return (obj) => {
                    return obj.entryDate === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed:
                return (obj) => {
                    return obj.offed === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo:
                return (obj) => {
                    return obj.id_CardNo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser:
                return (obj) => {
                    return obj.isAvconUser === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser:
                return (obj) => {
                    return obj.isGpUser === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser:
                return (obj) => {
                    return obj.isLocalUser === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit:
                return (obj) => {
                    return obj.fromUnit === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID:
                return (obj) => {
                    return obj.collegeID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA:
                return (obj) => {
                    return obj.collegeNameA === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay:
                return (obj) => {
                    return obj.entryDay === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo:
                return (obj) => {
                    return obj.id_Photo === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion:
                return (obj) => {
                    return obj.id_Religion === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName:
                return (obj) => {
                    return obj.religionName === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage:
                return (obj) => {
                    return obj.isMessage === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog:
                return (obj) => {
                    return obj.microblog === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID:
                return (obj) => {
                    return obj.modifyUserID === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak:
                return (obj) => {
                    return obj.offedBak === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber:
                return (obj) => {
                    return obj.phoneNumber === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ:
                return (obj) => {
                    return obj.qQ === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College:
                return (obj) => {
                    return obj.teach_id_College === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major:
                return (obj) => {
                    return obj.teach_id_Major === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel:
                return (obj) => {
                    return obj.tel === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate:
                return (obj) => {
                    return obj.modifyDate === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword:
                return (obj) => {
                    return obj.registerPassword === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear:
                return (obj) => {
                    return obj.entryYear === value;
                };
            case clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps:
                return (obj) => {
                    return obj.disciplineName_ps === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vTeacherInfo]中不存在！(in ${exports.vTeacherInfo_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vTeacherInfo_FilterFunByKey = vTeacherInfo_FilterFunByKey;
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
    async function vTeacherInfo_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvTeacherInfo = await vTeacherInfo_GetObjLst_Cache();
        if (arrvTeacherInfo == null)
            return [];
        let arrvTeacherInfo_Sel = arrvTeacherInfo;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvTeacherInfo_Sel.length == 0)
            return [];
        return arrvTeacherInfo_Sel.map(x => x.id_Teacher);
    }
    exports.vTeacherInfo_funcKey = vTeacherInfo_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vTeacherInfo_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetFirstIDAsync = vTeacherInfo_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vTeacherInfo_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetFirstID = vTeacherInfo_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vTeacherInfo_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const objvTeacherInfo = vTeacherInfo_GetObjFromJsonObj(returnObj);
                return objvTeacherInfo;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetFirstObjAsync = vTeacherInfo_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName;
        clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvTeacherInfoExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvTeacherInfoObjLst_T = vTeacherInfo_GetObjLstByJSONObjLst(arrvTeacherInfoExObjLst_Cache);
            return arrvTeacherInfoObjLst_T;
        }
        try {
            const arrvTeacherInfoExObjLst = await vTeacherInfo_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvTeacherInfoExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvTeacherInfoExObjLst.length);
            console.log(strInfo);
            return arrvTeacherInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vTeacherInfo_GetObjLst_ClientCache = vTeacherInfo_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName;
        clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvTeacherInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvTeacherInfoObjLst_T = vTeacherInfo_GetObjLstByJSONObjLst(arrvTeacherInfoExObjLst_Cache);
            return arrvTeacherInfoObjLst_T;
        }
        try {
            const arrvTeacherInfoExObjLst = await vTeacherInfo_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvTeacherInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvTeacherInfoExObjLst.length);
            console.log(strInfo);
            return arrvTeacherInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vTeacherInfo_GetObjLst_localStorage = vTeacherInfo_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvTeacherInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvTeacherInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.vTeacherInfo_GetObjLst_localStorage_PureCache = vTeacherInfo_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vTeacherInfo_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstAsync = vTeacherInfo_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName;
        clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvTeacherInfoExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvTeacherInfoObjLst_T = vTeacherInfo_GetObjLstByJSONObjLst(arrvTeacherInfoExObjLst_Cache);
            return arrvTeacherInfoObjLst_T;
        }
        try {
            const arrvTeacherInfoExObjLst = await vTeacherInfo_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvTeacherInfoExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvTeacherInfoExObjLst.length);
            console.log(strInfo);
            return arrvTeacherInfoExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vTeacherInfo_GetObjLst_sessionStorage = vTeacherInfo_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvTeacherInfoObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvTeacherInfoObjLst_Cache;
        }
        else
            return null;
    }
    exports.vTeacherInfo_GetObjLst_sessionStorage_PureCache = vTeacherInfo_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvTeacherInfoObjLst_Cache;
        switch (clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_ClientCache();
                break;
            default:
                arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_ClientCache();
                break;
        }
        const arrvTeacherInfoObjLst = vTeacherInfo_GetObjLstByJSONObjLst(arrvTeacherInfoObjLst_Cache);
        return arrvTeacherInfoObjLst_Cache;
    }
    exports.vTeacherInfo_GetObjLst_Cache = vTeacherInfo_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vTeacherInfo_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvTeacherInfoObjLst_Cache;
        switch (clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheModeId) {
            case "04": //sessionStorage
                arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvTeacherInfoObjLst_Cache = null;
                break;
            default:
                arrvTeacherInfoObjLst_Cache = null;
                break;
        }
        return arrvTeacherInfoObjLst_Cache;
    }
    exports.vTeacherInfo_GetObjLst_PureCache = vTeacherInfo_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrid_Teacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vTeacherInfo_GetSubObjLst_Cache(objvTeacherInfo_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        let arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache;
        if (objvTeacherInfo_Cond.sf_FldComparisonOp == null || objvTeacherInfo_Cond.sf_FldComparisonOp == "")
            return arrvTeacherInfo_Sel;
        const dicFldComparisonOp = JSON.parse(objvTeacherInfo_Cond.sf_FldComparisonOp);
        //console.log("clsvTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvTeacherInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvTeacherInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvTeacherInfo_Cond), exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTeacherInfo_GetSubObjLst_Cache = vTeacherInfo_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrid_Teacher:关键字列表
    * @returns 对象列表
    **/
    async function vTeacherInfo_GetObjLstByid_TeacherLstAsync(arrid_Teacher) {
        const strThisFuncName = "GetObjLstByid_TeacherLstAsync";
        const strAction = "GetObjLstByid_TeacherLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrid_Teacher);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByid_TeacherLstAsync = vTeacherInfo_GetObjLstByid_TeacherLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrid_TeacherLst:关键字列表
     * @returns 对象列表
    */
    async function vTeacherInfo_GetObjLstByid_TeacherLst_Cache(arrid_TeacherLst) {
        const strThisFuncName = "GetObjLstByid_TeacherLst_Cache";
        try {
            const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
            const arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache.filter(x => arrid_TeacherLst.indexOf(x.id_Teacher) > -1);
            return arrvTeacherInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrid_TeacherLst.join(","), exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTeacherInfo_GetObjLstByid_TeacherLst_Cache = vTeacherInfo_GetObjLstByid_TeacherLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vTeacherInfo_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetTopObjLstAsync = vTeacherInfo_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vTeacherInfo_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByRangeAsync = vTeacherInfo_GetObjLstByRangeAsync;
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
    async function vTeacherInfo_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByRange = vTeacherInfo_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vTeacherInfo_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        if (arrvTeacherInfoObjLst_Cache.length == 0)
            return arrvTeacherInfoObjLst_Cache;
        let arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvTeacherInfo_Cond = new clsvTeacherInfoEN_js_1.clsvTeacherInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvTeacherInfo_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvTeacherInfoWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvTeacherInfo_Sel.length == 0)
                return arrvTeacherInfo_Sel;
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
                arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.sort(vTeacherInfo_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.sort(objPagerPara.sortFun);
            }
            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.slice(intStart, intEnd);
            return arrvTeacherInfo_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vTeacherInfo_GetObjLstByPager_Cache = vTeacherInfo_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vTeacherInfo_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vTeacherInfo_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vTeacherInfo_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetObjLstByPagerAsync = vTeacherInfo_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrid_Teacher_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vTeacherInfo_IsExistRecord_Cache(objvTeacherInfo_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        if (arrvTeacherInfoObjLst_Cache == null)
            return false;
        let arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache;
        if (objvTeacherInfo_Cond.sf_FldComparisonOp == null || objvTeacherInfo_Cond.sf_FldComparisonOp == "")
            return arrvTeacherInfo_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvTeacherInfo_Cond.sf_FldComparisonOp);
        //console.log("clsvTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvTeacherInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvTeacherInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvTeacherInfo_Cond), exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vTeacherInfo_IsExistRecord_Cache = vTeacherInfo_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vTeacherInfo_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_IsExistRecordAsync = vTeacherInfo_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strid_Teacher:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vTeacherInfo_IsExist(strid_Teacher, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_IsExist = vTeacherInfo_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strid_Teacher:所给的关键字
     * @returns 对象
    */
    async function vTeacherInfo_IsExist_Cache(strid_Teacher) {
        const strThisFuncName = "IsExist_Cache";
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        if (arrvTeacherInfoObjLst_Cache == null)
            return false;
        try {
            const arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache.filter(x => x.id_Teacher == strid_Teacher);
            if (arrvTeacherInfo_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strid_Teacher, exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vTeacherInfo_IsExist_Cache = vTeacherInfo_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strid_Teacher:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vTeacherInfo_IsExistAsync(strid_Teacher) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_IsExistAsync = vTeacherInfo_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vTeacherInfo_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vTeacherInfo_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vTeacherInfo_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vTeacherInfo_GetRecCountByCondAsync = vTeacherInfo_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvTeacherInfo_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vTeacherInfo_GetRecCountByCond_Cache(objvTeacherInfo_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvTeacherInfoObjLst_Cache = await vTeacherInfo_GetObjLst_Cache();
        if (arrvTeacherInfoObjLst_Cache == null)
            return 0;
        let arrvTeacherInfo_Sel = arrvTeacherInfoObjLst_Cache;
        if (objvTeacherInfo_Cond.sf_FldComparisonOp == null || objvTeacherInfo_Cond.sf_FldComparisonOp == "")
            return arrvTeacherInfo_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvTeacherInfo_Cond.sf_FldComparisonOp);
        //console.log("clsvTeacherInfoWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvTeacherInfo_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvTeacherInfo_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvTeacherInfo_Sel = arrvTeacherInfo_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvTeacherInfo_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvTeacherInfo_Cond), exports.vTeacherInfo_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vTeacherInfo_GetRecCountByCond_Cache = vTeacherInfo_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vTeacherInfo_GetWebApiUrl(strController, strAction) {
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
    exports.vTeacherInfo_GetWebApiUrl = vTeacherInfo_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vTeacherInfo_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvTeacherInfoEN_js_1.clsvTeacherInfoEN._CurrTabName;
            switch (clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.CacheModeId) {
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
    exports.vTeacherInfo_ReFreshThisCache = vTeacherInfo_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vTeacherInfo__Cache(strDivName, strDdlName) {
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
        const arrObjLst_Sel = await vTeacherInfo_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName, "v教师");
    }
    exports.vTeacherInfo__Cache = vTeacherInfo__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vTeacherInfo_GetJSONStrByObj(pobjvTeacherInfoEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvTeacherInfoEN);
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
    exports.vTeacherInfo_GetJSONStrByObj = vTeacherInfo_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vTeacherInfo_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvTeacherInfoObjLst = new Array();
        if (strJSON === "") {
            return arrvTeacherInfoObjLst;
        }
        try {
            arrvTeacherInfoObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvTeacherInfoObjLst;
        }
        return arrvTeacherInfoObjLst;
    }
    exports.vTeacherInfo_GetObjLstByJSONStr = vTeacherInfo_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvTeacherInfoObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vTeacherInfo_GetObjLstByJSONObjLst(arrvTeacherInfoObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvTeacherInfoObjLst = new Array();
        for (const objInFor of arrvTeacherInfoObjLstS) {
            const obj1 = vTeacherInfo_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvTeacherInfoObjLst.push(obj1);
        }
        return arrvTeacherInfoObjLst;
    }
    exports.vTeacherInfo_GetObjLstByJSONObjLst = vTeacherInfo_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-02-24
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vTeacherInfo_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvTeacherInfoEN = new clsvTeacherInfoEN_js_1.clsvTeacherInfoEN();
        if (strJSON === "") {
            return pobjvTeacherInfoEN;
        }
        try {
            pobjvTeacherInfoEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvTeacherInfoEN;
        }
        return pobjvTeacherInfoEN;
    }
    exports.vTeacherInfo_GetObjByJSONStr = vTeacherInfo_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vTeacherInfo_GetCombineCondition(objvTeacherInfo_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher) == true) {
            const strComparisonOp_id_Teacher = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Teacher, objvTeacherInfo_Cond.id_Teacher, strComparisonOp_id_Teacher);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID) == true) {
            const strComparisonOp_TeacherID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherID, objvTeacherInfo_Cond.teacherID, strComparisonOp_TeacherID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName) == true) {
            const strComparisonOp_TeacherName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TeacherName, objvTeacherInfo_Cond.teacherName, strComparisonOp_TeacherName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex) == true) {
            const strComparisonOp_id_Sex = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Sex, objvTeacherInfo_Cond.id_Sex, strComparisonOp_id_Sex);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc) == true) {
            const strComparisonOp_SexDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SexDesc, objvTeacherInfo_Cond.sexDesc, strComparisonOp_SexDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps) == true) {
            const strComparisonOp_id_School_Ps = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_School_Ps, objvTeacherInfo_Cond.id_School_Ps, strComparisonOp_id_School_Ps);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId) == true) {
            const strComparisonOp_SchoolId = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolId, objvTeacherInfo_Cond.schoolId, strComparisonOp_SchoolId);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName) == true) {
            const strComparisonOp_SchoolName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_SchoolName, objvTeacherInfo_Cond.schoolName, strComparisonOp_SchoolName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps) == true) {
            const strComparisonOp_id_Discipline_Ps = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Discipline_Ps, objvTeacherInfo_Cond.id_Discipline_Ps, strComparisonOp_id_Discipline_Ps);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone) == true) {
            const strComparisonOp_id_UniZone = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_UniZone, objvTeacherInfo_Cond.id_UniZone, strComparisonOp_id_UniZone);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc) == true) {
            const strComparisonOp_UniZoneDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_UniZoneDesc, objvTeacherInfo_Cond.uniZoneDesc, strComparisonOp_UniZoneDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic) == true) {
            const strComparisonOp_id_Ethnic = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Ethnic, objvTeacherInfo_Cond.id_Ethnic, strComparisonOp_id_Ethnic);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName) == true) {
            const strComparisonOp_EthnicName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EthnicName, objvTeacherInfo_Cond.ethnicName, strComparisonOp_EthnicName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics) == true) {
            const strComparisonOp_id_Politics = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Politics, objvTeacherInfo_Cond.id_Politics, strComparisonOp_id_Politics);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName) == true) {
            const strComparisonOp_PoliticsName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PoliticsName, objvTeacherInfo_Cond.politicsName, strComparisonOp_PoliticsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade) == true) {
            const strComparisonOp_id_AdminGrade = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_AdminGrade, objvTeacherInfo_Cond.id_AdminGrade, strComparisonOp_id_AdminGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc) == true) {
            const strComparisonOp_AdminGradeDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_AdminGradeDesc, objvTeacherInfo_Cond.adminGradeDesc, strComparisonOp_AdminGradeDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade) == true) {
            const strComparisonOp_id_ProfGrade = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_ProfGrade, objvTeacherInfo_Cond.id_ProfGrade, strComparisonOp_id_ProfGrade);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName) == true) {
            const strComparisonOp_ProfenssionalGradeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProfenssionalGradeName, objvTeacherInfo_Cond.profenssionalGradeName, strComparisonOp_ProfenssionalGradeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif) == true) {
            const strComparisonOp_id_Qualif = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Qualif, objvTeacherInfo_Cond.id_Qualif, strComparisonOp_id_Qualif);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc) == true) {
            const strComparisonOp_QualifDesc = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QualifDesc, objvTeacherInfo_Cond.qualifDesc, strComparisonOp_QualifDesc);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree) == true) {
            const strComparisonOp_id_Degree = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Degree, objvTeacherInfo_Cond.id_Degree, strComparisonOp_id_Degree);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName) == true) {
            const strComparisonOp_DegreeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DegreeName, objvTeacherInfo_Cond.degreeName, strComparisonOp_DegreeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType) == true) {
            const strComparisonOp_id_StaffType = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_StaffType, objvTeacherInfo_Cond.id_StaffType, strComparisonOp_id_StaffType);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName) == true) {
            const strComparisonOp_StaffTypeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_StaffTypeName, objvTeacherInfo_Cond.staffTypeName, strComparisonOp_StaffTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province) == true) {
            const strComparisonOp_id_Province = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Province, objvTeacherInfo_Cond.id_Province, strComparisonOp_id_Province);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName) == true) {
            const strComparisonOp_ProvinceName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ProvinceName, objvTeacherInfo_Cond.provinceName, strComparisonOp_ProvinceName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID) == true) {
            const strComparisonOp_CitizenID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CitizenID, objvTeacherInfo_Cond.citizenID, strComparisonOp_CitizenID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo) == true) {
            const strComparisonOp_CardNo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CardNo, objvTeacherInfo_Cond.cardNo, strComparisonOp_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday) == true) {
            const strComparisonOp_Birthday = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Birthday, objvTeacherInfo_Cond.birthday, strComparisonOp_Birthday);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor) == true) {
            const strComparisonOp_GraduationMajor = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_GraduationMajor, objvTeacherInfo_Cond.graduationMajor, strComparisonOp_GraduationMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo) == true) {
            const strComparisonOp_TelNo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_TelNo, objvTeacherInfo_Cond.telNo, strComparisonOp_TelNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email) == true) {
            const strComparisonOp_Email = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Email, objvTeacherInfo_Cond.email, strComparisonOp_Email);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite) == true) {
            const strComparisonOp_WebSite = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_WebSite, objvTeacherInfo_Cond.webSite, strComparisonOp_WebSite);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog) == true) {
            const strComparisonOp_PersonBlog = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PersonBlog, objvTeacherInfo_Cond.personBlog, strComparisonOp_PersonBlog);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate) == true) {
            const strComparisonOp_EntryDate = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDate, objvTeacherInfo_Cond.entryDate, strComparisonOp_EntryDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed) == true) {
            if (objvTeacherInfo_Cond.offed == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Offed);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo) == true) {
            const strComparisonOp_Id_CardNo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Id_CardNo, objvTeacherInfo_Cond.id_CardNo, strComparisonOp_Id_CardNo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser) == true) {
            if (objvTeacherInfo_Cond.isAvconUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsAvconUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser) == true) {
            if (objvTeacherInfo_Cond.isGpUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsGpUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser) == true) {
            if (objvTeacherInfo_Cond.isLocalUser == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsLocalUser);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit) == true) {
            const strComparisonOp_FromUnit = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_FromUnit, objvTeacherInfo_Cond.fromUnit, strComparisonOp_FromUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Memo, objvTeacherInfo_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzCollege, objvTeacherInfo_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID) == true) {
            const strComparisonOp_CollegeID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeID, objvTeacherInfo_Cond.collegeID, strComparisonOp_CollegeID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeName, objvTeacherInfo_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA) == true) {
            const strComparisonOp_CollegeNameA = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_CollegeNameA, objvTeacherInfo_Cond.collegeNameA, strComparisonOp_CollegeNameA);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_XzMajor, objvTeacherInfo_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay) == true) {
            const strComparisonOp_EntryDay = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryDay, objvTeacherInfo_Cond.entryDay, strComparisonOp_EntryDay);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo) == true) {
            const strComparisonOp_id_Photo = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Photo, objvTeacherInfo_Cond.id_Photo, strComparisonOp_id_Photo);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion) == true) {
            const strComparisonOp_id_Religion = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_id_Religion, objvTeacherInfo_Cond.id_Religion, strComparisonOp_id_Religion);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName) == true) {
            const strComparisonOp_ReligionName = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ReligionName, objvTeacherInfo_Cond.religionName, strComparisonOp_ReligionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage) == true) {
            if (objvTeacherInfo_Cond.isMessage == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_IsMessage);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog) == true) {
            const strComparisonOp_Microblog = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Microblog, objvTeacherInfo_Cond.microblog, strComparisonOp_Microblog);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID) == true) {
            const strComparisonOp_ModifyUserID = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyUserID, objvTeacherInfo_Cond.modifyUserID, strComparisonOp_ModifyUserID);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak) == true) {
            if (objvTeacherInfo_Cond.offedBak == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_OffedBak);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber) == true) {
            const strComparisonOp_PhoneNumber = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_PhoneNumber, objvTeacherInfo_Cond.phoneNumber, strComparisonOp_PhoneNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ) == true) {
            const strComparisonOp_QQ = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_QQ, objvTeacherInfo_Cond.qQ, strComparisonOp_QQ);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College) == true) {
            const strComparisonOp_Teach_id_College = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_College, objvTeacherInfo_Cond.teach_id_College, strComparisonOp_Teach_id_College);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major) == true) {
            const strComparisonOp_Teach_id_Major = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Teach_id_Major, objvTeacherInfo_Cond.teach_id_Major, strComparisonOp_Teach_id_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel) == true) {
            const strComparisonOp_Tel = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_Tel, objvTeacherInfo_Cond.tel, strComparisonOp_Tel);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate) == true) {
            const strComparisonOp_ModifyDate = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_ModifyDate, objvTeacherInfo_Cond.modifyDate, strComparisonOp_ModifyDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword) == true) {
            const strComparisonOp_RegisterPassword = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_RegisterPassword, objvTeacherInfo_Cond.registerPassword, strComparisonOp_RegisterPassword);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear) == true) {
            const strComparisonOp_EntryYear = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_EntryYear, objvTeacherInfo_Cond.entryYear, strComparisonOp_EntryYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvTeacherInfo_Cond.dicFldComparisonOp, clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps) == true) {
            const strComparisonOp_DisciplineName_ps = objvTeacherInfo_Cond.dicFldComparisonOp[clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvTeacherInfoEN_js_1.clsvTeacherInfoEN.con_DisciplineName_ps, objvTeacherInfo_Cond.disciplineName_ps, strComparisonOp_DisciplineName_ps);
        }
        return strWhereCond;
    }
    exports.vTeacherInfo_GetCombineCondition = vTeacherInfo_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvTeacherInfoENS:源对象
     * @param objvTeacherInfoENT:目标对象
    */
    function vTeacherInfo_CopyObjTo(objvTeacherInfoENS, objvTeacherInfoENT) {
        objvTeacherInfoENT.id_Teacher = objvTeacherInfoENS.id_Teacher; //教师流水号
        objvTeacherInfoENT.teacherID = objvTeacherInfoENS.teacherID; //教师工号
        objvTeacherInfoENT.teacherName = objvTeacherInfoENS.teacherName; //教师姓名
        objvTeacherInfoENT.id_Sex = objvTeacherInfoENS.id_Sex; //性别流水号
        objvTeacherInfoENT.sexDesc = objvTeacherInfoENS.sexDesc; //性别名称
        objvTeacherInfoENT.id_School_Ps = objvTeacherInfoENS.id_School_Ps; //学校流水号
        objvTeacherInfoENT.schoolId = objvTeacherInfoENS.schoolId; //学校编号
        objvTeacherInfoENT.schoolName = objvTeacherInfoENS.schoolName; //学校名称
        objvTeacherInfoENT.id_Discipline_Ps = objvTeacherInfoENS.id_Discipline_Ps; //学科流水号
        objvTeacherInfoENT.id_UniZone = objvTeacherInfoENS.id_UniZone; //校区流水号
        objvTeacherInfoENT.uniZoneDesc = objvTeacherInfoENS.uniZoneDesc; //校区名称
        objvTeacherInfoENT.id_Ethnic = objvTeacherInfoENS.id_Ethnic; //民族流水号
        objvTeacherInfoENT.ethnicName = objvTeacherInfoENS.ethnicName; //民族名称
        objvTeacherInfoENT.id_Politics = objvTeacherInfoENS.id_Politics; //政治面貌流水号
        objvTeacherInfoENT.politicsName = objvTeacherInfoENS.politicsName; //政治面貌
        objvTeacherInfoENT.id_AdminGrade = objvTeacherInfoENS.id_AdminGrade; //行政职务流水号
        objvTeacherInfoENT.adminGradeDesc = objvTeacherInfoENS.adminGradeDesc; //行政职务描述
        objvTeacherInfoENT.id_ProfGrade = objvTeacherInfoENS.id_ProfGrade; //专业职称流水号
        objvTeacherInfoENT.profenssionalGradeName = objvTeacherInfoENS.profenssionalGradeName; //专业职称
        objvTeacherInfoENT.id_Qualif = objvTeacherInfoENS.id_Qualif; //学历流水号
        objvTeacherInfoENT.qualifDesc = objvTeacherInfoENS.qualifDesc; //QualifDesc
        objvTeacherInfoENT.id_Degree = objvTeacherInfoENS.id_Degree; //学位流水号
        objvTeacherInfoENT.degreeName = objvTeacherInfoENS.degreeName; //学位名称
        objvTeacherInfoENT.id_StaffType = objvTeacherInfoENS.id_StaffType; //职工类型流水号
        objvTeacherInfoENT.staffTypeName = objvTeacherInfoENS.staffTypeName; //职工类型名称
        objvTeacherInfoENT.id_Province = objvTeacherInfoENS.id_Province; //省份流水号
        objvTeacherInfoENT.provinceName = objvTeacherInfoENS.provinceName; //ProvinceName
        objvTeacherInfoENT.citizenID = objvTeacherInfoENS.citizenID; //身份证号
        objvTeacherInfoENT.cardNo = objvTeacherInfoENS.cardNo; //卡号
        objvTeacherInfoENT.birthday = objvTeacherInfoENS.birthday; //出生日期
        objvTeacherInfoENT.graduationMajor = objvTeacherInfoENS.graduationMajor; //毕业专业
        objvTeacherInfoENT.telNo = objvTeacherInfoENS.telNo; //电话
        objvTeacherInfoENT.email = objvTeacherInfoENS.email; //电子邮箱
        objvTeacherInfoENT.webSite = objvTeacherInfoENS.webSite; //个人主页
        objvTeacherInfoENT.personBlog = objvTeacherInfoENS.personBlog; //个人博客
        objvTeacherInfoENT.entryDate = objvTeacherInfoENS.entryDate; //进校日期
        objvTeacherInfoENT.offed = objvTeacherInfoENS.offed; //是否离校
        objvTeacherInfoENT.id_CardNo = objvTeacherInfoENS.id_CardNo; //内卡号
        objvTeacherInfoENT.isAvconUser = objvTeacherInfoENS.isAvconUser; //IsAvconUser
        objvTeacherInfoENT.isGpUser = objvTeacherInfoENS.isGpUser; //是否Gp用户
        objvTeacherInfoENT.isLocalUser = objvTeacherInfoENS.isLocalUser; //是否本地用户
        objvTeacherInfoENT.fromUnit = objvTeacherInfoENS.fromUnit; //来自单位
        objvTeacherInfoENT.memo = objvTeacherInfoENS.memo; //备注
        objvTeacherInfoENT.id_XzCollege = objvTeacherInfoENS.id_XzCollege; //学院流水号
        objvTeacherInfoENT.collegeID = objvTeacherInfoENS.collegeID; //学院ID
        objvTeacherInfoENT.collegeName = objvTeacherInfoENS.collegeName; //学院名称
        objvTeacherInfoENT.collegeNameA = objvTeacherInfoENS.collegeNameA; //学院名称简写
        objvTeacherInfoENT.id_XzMajor = objvTeacherInfoENS.id_XzMajor; //专业流水号
        objvTeacherInfoENT.entryDay = objvTeacherInfoENS.entryDay; //EntryDay
        objvTeacherInfoENT.id_Photo = objvTeacherInfoENS.id_Photo; //id_Photo
        objvTeacherInfoENT.id_Religion = objvTeacherInfoENS.id_Religion; //id_Religion
        objvTeacherInfoENT.religionName = objvTeacherInfoENS.religionName; //ReligionName
        objvTeacherInfoENT.isMessage = objvTeacherInfoENS.isMessage; //IsMessage
        objvTeacherInfoENT.microblog = objvTeacherInfoENS.microblog; //Microblog
        objvTeacherInfoENT.modifyUserID = objvTeacherInfoENS.modifyUserID; //修改人
        objvTeacherInfoENT.offedBak = objvTeacherInfoENS.offedBak; //OffedBak
        objvTeacherInfoENT.phoneNumber = objvTeacherInfoENS.phoneNumber; //PhoneNumber
        objvTeacherInfoENT.qQ = objvTeacherInfoENS.qQ; //QQ
        objvTeacherInfoENT.teach_id_College = objvTeacherInfoENS.teach_id_College; //Teach_id_College
        objvTeacherInfoENT.teach_id_Major = objvTeacherInfoENS.teach_id_Major; //Teach_id_Major
        objvTeacherInfoENT.tel = objvTeacherInfoENS.tel; //Tel
        objvTeacherInfoENT.modifyDate = objvTeacherInfoENS.modifyDate; //修改日期
        objvTeacherInfoENT.registerPassword = objvTeacherInfoENS.registerPassword; //RegisterPassword
        objvTeacherInfoENT.entryYear = objvTeacherInfoENS.entryYear; //EntryYear
        objvTeacherInfoENT.disciplineName_ps = objvTeacherInfoENS.disciplineName_ps; //学科
    }
    exports.vTeacherInfo_CopyObjTo = vTeacherInfo_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvTeacherInfoENS:源对象
     * @param objvTeacherInfoENT:目标对象
    */
    function vTeacherInfo_GetObjFromJsonObj(objvTeacherInfoENS) {
        const objvTeacherInfoENT = new clsvTeacherInfoEN_js_1.clsvTeacherInfoEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvTeacherInfoENT, objvTeacherInfoENS);
        return objvTeacherInfoENT;
    }
    exports.vTeacherInfo_GetObjFromJsonObj = vTeacherInfo_GetObjFromJsonObj;
});
