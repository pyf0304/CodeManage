/**
* 类名:clsvSysScoreSummaryWApi
* 表名:vSysScoreSummary(01120627)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:59
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培设置(GraduateEduTools)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysScoreSummary_GetObjFromJsonObj = exports.vSysScoreSummary_CopyObjTo = exports.vSysScoreSummary_GetCombineCondition = exports.vSysScoreSummary_GetObjByJSONStr = exports.vSysScoreSummary_GetObjLstByJSONObjLst = exports.vSysScoreSummary_GetObjLstByJSONStr = exports.vSysScoreSummary_GetJSONStrByObj = exports.vSysScoreSummary_ReFreshThisCache = exports.vSysScoreSummary_GetWebApiUrl = exports.vSysScoreSummary_GetRecCountByCond_Cache = exports.vSysScoreSummary_GetRecCountByCondAsync = exports.vSysScoreSummary_IsExistAsync = exports.vSysScoreSummary_IsExist_Cache = exports.vSysScoreSummary_IsExist = exports.vSysScoreSummary_IsExistRecordAsync = exports.vSysScoreSummary_IsExistRecord_Cache = exports.vSysScoreSummary_GetObjLstByPagerAsync = exports.vSysScoreSummary_GetObjLstByPager_Cache = exports.vSysScoreSummary_GetObjLstByRange = exports.vSysScoreSummary_GetObjLstByRangeAsync = exports.vSysScoreSummary_GetTopObjLstAsync = exports.vSysScoreSummary_GetObjLstBymIdLst_Cache = exports.vSysScoreSummary_GetObjLstBymIdLstAsync = exports.vSysScoreSummary_GetSubObjLst_Cache = exports.vSysScoreSummary_GetObjLst_PureCache = exports.vSysScoreSummary_GetObjLst_Cache = exports.vSysScoreSummary_GetObjLst_sessionStorage_PureCache = exports.vSysScoreSummary_GetObjLst_sessionStorage = exports.vSysScoreSummary_GetObjLstAsync = exports.vSysScoreSummary_GetObjLst_localStorage_PureCache = exports.vSysScoreSummary_GetObjLst_localStorage = exports.vSysScoreSummary_GetObjLst_ClientCache = exports.vSysScoreSummary_GetFirstObjAsync = exports.vSysScoreSummary_GetFirstID = exports.vSysScoreSummary_GetFirstIDAsync = exports.vSysScoreSummary_FilterFunByKey = exports.vSysScoreSummary_SortFunByKey = exports.vSysScoreSummary_SortFun_Defa_2Fld = exports.vSysScoreSummary_SortFun_Defa = exports.vSysScoreSummary_func = exports.vSysScoreSummary_GetObjBymId_localStorage = exports.vSysScoreSummary_GetObjBymId_Cache = exports.vSysScoreSummary_GetObjBymIdAsync = exports.vSysScoreSummary_ConstructorName = exports.vSysScoreSummary_Controller = void 0;
    /**
     * v分数汇总视图(vSysScoreSummary)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvSysScoreSummaryEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvSysScoreSummaryEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysScoreSummary_Controller = "vSysScoreSummaryApi";
    exports.vSysScoreSummary_ConstructorName = "vSysScoreSummary";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngmId:关键字
    * @returns 对象
    **/
    async function vSysScoreSummary_GetObjBymIdAsync(lngmId) {
        const strThisFuncName = "GetObjBymIdAsync";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBymId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngmId": lngmId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysScoreSummary = vSysScoreSummary_GetObjFromJsonObj(returnObj);
                return objvSysScoreSummary;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetObjBymIdAsync = vSysScoreSummary_GetObjBymIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vSysScoreSummary_GetObjBymId_Cache(lngmId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBymId_Cache";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache.filter(x => x.mId == lngmId);
            let objvSysScoreSummary;
            if (arrvSysScoreSummary_Sel.length > 0) {
                objvSysScoreSummary = arrvSysScoreSummary_Sel[0];
                return objvSysScoreSummary;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvSysScoreSummary = await vSysScoreSummary_GetObjBymIdAsync(lngmId);
                    if (objvSysScoreSummary != null) {
                        vSysScoreSummary_ReFreshThisCache(strid_CurrEduCls);
                        return objvSysScoreSummary;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vSysScoreSummary_GetObjBymId_Cache = vSysScoreSummary_GetObjBymId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vSysScoreSummary_GetObjBymId_localStorage(lngmId) {
        const strThisFuncName = "GetObjBymId_localStorage";
        if (lngmId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngmId]不能为空！(In GetObjBymId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, lngmId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvSysScoreSummary_Cache = JSON.parse(strTempObj);
            return objvSysScoreSummary_Cache;
        }
        try {
            const objvSysScoreSummary = await vSysScoreSummary_GetObjBymIdAsync(lngmId);
            if (objvSysScoreSummary != null) {
                localStorage.setItem(strKey, JSON.stringify(objvSysScoreSummary));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvSysScoreSummary;
            }
            return objvSysScoreSummary;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngmId, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vSysScoreSummary_GetObjBymId_localStorage = vSysScoreSummary_GetObjBymId_localStorage;
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
    async function vSysScoreSummary_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngmId = Number(strInValue);
        if (lngmId == 0) {
            return "";
        }
        const objvSysScoreSummary = await vSysScoreSummary_GetObjBymId_Cache(lngmId, strid_CurrEduCls_C);
        if (objvSysScoreSummary == null)
            return "";
        return objvSysScoreSummary.GetFldValue(strOutFldName).toString();
    }
    exports.vSysScoreSummary_func = vSysScoreSummary_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysScoreSummary_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.mId - b.mId;
    }
    exports.vSysScoreSummary_SortFun_Defa = vSysScoreSummary_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysScoreSummary_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.userId == b.userId)
            return a.schoolYear.localeCompare(b.schoolYear);
        else
            return a.userId.localeCompare(b.userId);
    }
    exports.vSysScoreSummary_SortFun_Defa_2Fld = vSysScoreSummary_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysScoreSummary_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId:
                    return (a, b) => {
                        return a.mId - b.mId;
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear:
                    return (a, b) => {
                        return a.schoolYear.localeCompare(b.schoolYear);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName:
                    return (a, b) => {
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzCollege:
                    return (a, b) => {
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_CollegeName:
                    return (a, b) => {
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzMajor:
                    return (a, b) => {
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_MajorName:
                    return (a, b) => {
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_GradeBase:
                    return (a, b) => {
                        return a.id_GradeBase.localeCompare(b.id_GradeBase);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_GradeBaseName:
                    return (a, b) => {
                        return a.gradeBaseName.localeCompare(b.gradeBaseName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_OnlyId:
                    return (a, b) => {
                        return a.onlyId.localeCompare(b.onlyId);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId:
                    return (a, b) => {
                        return a.scoreTypeId.localeCompare(b.scoreTypeId);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeName:
                    return (a, b) => {
                        return a.scoreTypeName.localeCompare(b.scoreTypeName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_EduClsName:
                    return (a, b) => {
                        return a.eduClsName.localeCompare(b.eduClsName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysScoreSummary]中不存在！(in ${exports.vSysScoreSummary_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId:
                    return (a, b) => {
                        return b.mId - a.mId;
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear:
                    return (a, b) => {
                        return b.schoolYear.localeCompare(a.schoolYear);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName:
                    return (a, b) => {
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzCollege:
                    return (a, b) => {
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_CollegeName:
                    return (a, b) => {
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzMajor:
                    return (a, b) => {
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_MajorName:
                    return (a, b) => {
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_GradeBase:
                    return (a, b) => {
                        return b.id_GradeBase.localeCompare(a.id_GradeBase);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_GradeBaseName:
                    return (a, b) => {
                        return b.gradeBaseName.localeCompare(a.gradeBaseName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_OnlyId:
                    return (a, b) => {
                        return b.onlyId.localeCompare(a.onlyId);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId:
                    return (a, b) => {
                        return b.scoreTypeId.localeCompare(a.scoreTypeId);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeName:
                    return (a, b) => {
                        return b.scoreTypeName.localeCompare(a.scoreTypeName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_EduClsName:
                    return (a, b) => {
                        return b.eduClsName.localeCompare(a.eduClsName);
                    };
                case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysScoreSummary]中不存在！(in ${exports.vSysScoreSummary_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysScoreSummary_SortFunByKey = vSysScoreSummary_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysScoreSummary_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId:
                return (obj) => {
                    return obj.mId === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear:
                return (obj) => {
                    return obj.schoolYear === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_GradeBase:
                return (obj) => {
                    return obj.id_GradeBase === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_GradeBaseName:
                return (obj) => {
                    return obj.gradeBaseName === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_OnlyId:
                return (obj) => {
                    return obj.onlyId === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId:
                return (obj) => {
                    return obj.scoreTypeId === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeName:
                return (obj) => {
                    return obj.scoreTypeName === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_EduClsName:
                return (obj) => {
                    return obj.eduClsName === value;
                };
            case clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysScoreSummary]中不存在！(in ${exports.vSysScoreSummary_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysScoreSummary_FilterFunByKey = vSysScoreSummary_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysScoreSummary_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetFirstIDAsync = vSysScoreSummary_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysScoreSummary_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetFirstID = vSysScoreSummary_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysScoreSummary_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysScoreSummary = vSysScoreSummary_GetObjFromJsonObj(returnObj);
                return objvSysScoreSummary;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetFirstObjAsync = vSysScoreSummary_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
        clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvSysScoreSummaryExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvSysScoreSummaryObjLst_T = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryExObjLst_Cache);
            return arrvSysScoreSummaryObjLst_T;
        }
        try {
            const arrvSysScoreSummaryExObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvSysScoreSummaryExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreSummaryExObjLst.length);
            console.log(strInfo);
            return arrvSysScoreSummaryExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysScoreSummary_GetObjLst_ClientCache = vSysScoreSummary_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
        clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysScoreSummaryExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysScoreSummaryObjLst_T = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryExObjLst_Cache);
            return arrvSysScoreSummaryObjLst_T;
        }
        try {
            const arrvSysScoreSummaryExObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvSysScoreSummaryExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreSummaryExObjLst.length);
            console.log(strInfo);
            return arrvSysScoreSummaryExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysScoreSummary_GetObjLst_localStorage = vSysScoreSummary_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysScoreSummaryObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysScoreSummaryObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysScoreSummary_GetObjLst_localStorage_PureCache = vSysScoreSummary_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysScoreSummary_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetObjLstAsync = vSysScoreSummary_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
        clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysScoreSummaryExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysScoreSummaryObjLst_T = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryExObjLst_Cache);
            return arrvSysScoreSummaryObjLst_T;
        }
        try {
            const arrvSysScoreSummaryExObjLst = await vSysScoreSummary_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvSysScoreSummaryExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysScoreSummaryExObjLst.length);
            console.log(strInfo);
            return arrvSysScoreSummaryExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysScoreSummary_GetObjLst_sessionStorage = vSysScoreSummary_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysScoreSummaryObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysScoreSummaryObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysScoreSummary_GetObjLst_sessionStorage_PureCache = vSysScoreSummary_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrvSysScoreSummaryObjLst_Cache;
        switch (clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvSysScoreSummaryObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryObjLst_Cache);
        return arrvSysScoreSummaryObjLst_Cache;
    }
    exports.vSysScoreSummary_GetObjLst_Cache = vSysScoreSummary_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysScoreSummary_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvSysScoreSummaryObjLst_Cache;
        switch (clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysScoreSummaryObjLst_Cache = null;
                break;
            default:
                arrvSysScoreSummaryObjLst_Cache = null;
                break;
        }
        return arrvSysScoreSummaryObjLst_Cache;
    }
    exports.vSysScoreSummary_GetObjLst_PureCache = vSysScoreSummary_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysScoreSummary_GetSubObjLst_Cache(objvSysScoreSummary_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
        let arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache;
        if (objvSysScoreSummary_Cond.sf_FldComparisonOp == null || objvSysScoreSummary_Cond.sf_FldComparisonOp == "")
            return arrvSysScoreSummary_Sel;
        const dicFldComparisonOp = JSON.parse(objvSysScoreSummary_Cond.sf_FldComparisonOp);
        //console.log("clsvSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysScoreSummary_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysScoreSummary_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvSysScoreSummary_Cond), exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysScoreSummary_GetSubObjLst_Cache = vSysScoreSummary_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrmId:关键字列表
    * @returns 对象列表
    **/
    async function vSysScoreSummary_GetObjLstBymIdLstAsync(arrmId) {
        const strThisFuncName = "GetObjLstBymIdLstAsync";
        const strAction = "GetObjLstBymIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrmId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetObjLstBymIdLstAsync = vSysScoreSummary_GetObjLstBymIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngmIdLst:关键字列表
     * @returns 对象列表
    */
    async function vSysScoreSummary_GetObjLstBymIdLst_Cache(arrmIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBymIdLst_Cache";
        try {
            const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
            const arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache.filter(x => arrmIdLst.indexOf(x.mId) > -1);
            return arrvSysScoreSummary_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrmIdLst.join(","), exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysScoreSummary_GetObjLstBymIdLst_Cache = vSysScoreSummary_GetObjLstBymIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysScoreSummary_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetTopObjLstAsync = vSysScoreSummary_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysScoreSummary_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetObjLstByRangeAsync = vSysScoreSummary_GetObjLstByRangeAsync;
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
    async function vSysScoreSummary_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetObjLstByRange = vSysScoreSummary_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vSysScoreSummary_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysScoreSummaryObjLst_Cache.length == 0)
            return arrvSysScoreSummaryObjLst_Cache;
        let arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvSysScoreSummary_Cond = new clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysScoreSummary_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvSysScoreSummaryWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysScoreSummary_Sel.length == 0)
                return arrvSysScoreSummary_Sel;
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
                arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.sort(vSysScoreSummary_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.sort(objPagerPara.sortFun);
            }
            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.slice(intStart, intEnd);
            return arrvSysScoreSummary_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysScoreSummary_GetObjLstByPager_Cache = vSysScoreSummary_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysScoreSummary_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysScoreSummary_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetObjLstByPagerAsync = vSysScoreSummary_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngmId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysScoreSummary_IsExistRecord_Cache(objvSysScoreSummary_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysScoreSummaryObjLst_Cache == null)
            return false;
        let arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache;
        if (objvSysScoreSummary_Cond.sf_FldComparisonOp == null || objvSysScoreSummary_Cond.sf_FldComparisonOp == "")
            return arrvSysScoreSummary_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvSysScoreSummary_Cond.sf_FldComparisonOp);
        //console.log("clsvSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysScoreSummary_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysScoreSummary_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvSysScoreSummary_Cond), exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vSysScoreSummary_IsExistRecord_Cache = vSysScoreSummary_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysScoreSummary_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_IsExistRecordAsync = vSysScoreSummary_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngmId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysScoreSummary_IsExist(lngmId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "mId": lngmId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_IsExist = vSysScoreSummary_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngmId:所给的关键字
     * @returns 对象
    */
    async function vSysScoreSummary_IsExist_Cache(lngmId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysScoreSummaryObjLst_Cache == null)
            return false;
        try {
            const arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache.filter(x => x.mId == lngmId);
            if (arrvSysScoreSummary_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngmId, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vSysScoreSummary_IsExist_Cache = vSysScoreSummary_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngmId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysScoreSummary_IsExistAsync(lngmId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngmId": lngmId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_IsExistAsync = vSysScoreSummary_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysScoreSummary_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysScoreSummary_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysScoreSummary_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysScoreSummary_GetRecCountByCondAsync = vSysScoreSummary_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvSysScoreSummary_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vSysScoreSummary_GetRecCountByCond_Cache(objvSysScoreSummary_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvSysScoreSummaryObjLst_Cache = await vSysScoreSummary_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysScoreSummaryObjLst_Cache == null)
            return 0;
        let arrvSysScoreSummary_Sel = arrvSysScoreSummaryObjLst_Cache;
        if (objvSysScoreSummary_Cond.sf_FldComparisonOp == null || objvSysScoreSummary_Cond.sf_FldComparisonOp == "")
            return arrvSysScoreSummary_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvSysScoreSummary_Cond.sf_FldComparisonOp);
        //console.log("clsvSysScoreSummaryWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysScoreSummary_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysScoreSummary_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysScoreSummary_Sel = arrvSysScoreSummary_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysScoreSummary_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvSysScoreSummary_Cond), exports.vSysScoreSummary_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vSysScoreSummary_GetRecCountByCond_Cache = vSysScoreSummary_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysScoreSummary_GetWebApiUrl(strController, strAction) {
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
    exports.vSysScoreSummary_GetWebApiUrl = vSysScoreSummary_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vSysScoreSummary_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN._CurrTabName, strid_CurrEduCls);
            switch (clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.CacheModeId) {
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
    exports.vSysScoreSummary_ReFreshThisCache = vSysScoreSummary_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysScoreSummary_GetJSONStrByObj(pobjvSysScoreSummaryEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysScoreSummaryEN);
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
    exports.vSysScoreSummary_GetJSONStrByObj = vSysScoreSummary_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysScoreSummary_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysScoreSummaryObjLst = new Array();
        if (strJSON === "") {
            return arrvSysScoreSummaryObjLst;
        }
        try {
            arrvSysScoreSummaryObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysScoreSummaryObjLst;
        }
        return arrvSysScoreSummaryObjLst;
    }
    exports.vSysScoreSummary_GetObjLstByJSONStr = vSysScoreSummary_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysScoreSummaryObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysScoreSummary_GetObjLstByJSONObjLst(arrvSysScoreSummaryObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysScoreSummaryObjLst = new Array();
        for (const objInFor of arrvSysScoreSummaryObjLstS) {
            const obj1 = vSysScoreSummary_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysScoreSummaryObjLst.push(obj1);
        }
        return arrvSysScoreSummaryObjLst;
    }
    exports.vSysScoreSummary_GetObjLstByJSONObjLst = vSysScoreSummary_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysScoreSummary_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysScoreSummaryEN = new clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN();
        if (strJSON === "") {
            return pobjvSysScoreSummaryEN;
        }
        try {
            pobjvSysScoreSummaryEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysScoreSummaryEN;
        }
        return pobjvSysScoreSummaryEN;
    }
    exports.vSysScoreSummary_GetObjByJSONStr = vSysScoreSummary_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysScoreSummary_GetCombineCondition(objvSysScoreSummary_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId) == true) {
            const strComparisonOp_mId = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_mId, objvSysScoreSummary_Cond.mId, strComparisonOp_mId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserId, objvSysScoreSummary_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear) == true) {
            const strComparisonOp_SchoolYear = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_SchoolYear, objvSysScoreSummary_Cond.schoolYear, strComparisonOp_SchoolYear);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdDate, objvSysScoreSummary_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_Memo, objvSysScoreSummary_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UserName, objvSysScoreSummary_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzCollege, objvSysScoreSummary_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_CollegeName, objvSysScoreSummary_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_XzMajor, objvSysScoreSummary_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_MajorName, objvSysScoreSummary_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_GradeBase) == true) {
            const strComparisonOp_id_GradeBase = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_GradeBase];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_GradeBase, objvSysScoreSummary_Cond.id_GradeBase, strComparisonOp_id_GradeBase);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_GradeBaseName) == true) {
            const strComparisonOp_GradeBaseName = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_GradeBaseName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_GradeBaseName, objvSysScoreSummary_Cond.gradeBaseName, strComparisonOp_GradeBaseName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_OnlyId) == true) {
            const strComparisonOp_OnlyId = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_OnlyId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_OnlyId, objvSysScoreSummary_Cond.onlyId, strComparisonOp_OnlyId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId) == true) {
            const strComparisonOp_ScoreTypeId = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeId, objvSysScoreSummary_Cond.scoreTypeId, strComparisonOp_ScoreTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeName) == true) {
            const strComparisonOp_ScoreTypeName = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_ScoreTypeName, objvSysScoreSummary_Cond.scoreTypeName, strComparisonOp_ScoreTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_UpdUser, objvSysScoreSummary_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_score) == true) {
            const strComparisonOp_score = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_score, objvSysScoreSummary_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_id_CurrEduCls, objvSysScoreSummary_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_EduClsName) == true) {
            const strComparisonOp_EduClsName = objvSysScoreSummary_Cond.dicFldComparisonOp[clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_EduClsName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_EduClsName, objvSysScoreSummary_Cond.eduClsName, strComparisonOp_EduClsName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysScoreSummary_Cond.dicFldComparisonOp, clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_IsSubmit) == true) {
            if (objvSysScoreSummary_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN.con_IsSubmit);
            }
        }
        return strWhereCond;
    }
    exports.vSysScoreSummary_GetCombineCondition = vSysScoreSummary_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysScoreSummaryENS:源对象
     * @param objvSysScoreSummaryENT:目标对象
    */
    function vSysScoreSummary_CopyObjTo(objvSysScoreSummaryENS, objvSysScoreSummaryENT) {
        objvSysScoreSummaryENT.mId = objvSysScoreSummaryENS.mId; //mId
        objvSysScoreSummaryENT.userId = objvSysScoreSummaryENS.userId; //用户ID
        objvSysScoreSummaryENT.schoolYear = objvSysScoreSummaryENS.schoolYear; //学年
        objvSysScoreSummaryENT.updDate = objvSysScoreSummaryENS.updDate; //修改日期
        objvSysScoreSummaryENT.memo = objvSysScoreSummaryENS.memo; //备注
        objvSysScoreSummaryENT.userName = objvSysScoreSummaryENS.userName; //用户名
        objvSysScoreSummaryENT.id_XzCollege = objvSysScoreSummaryENS.id_XzCollege; //学院流水号
        objvSysScoreSummaryENT.collegeName = objvSysScoreSummaryENS.collegeName; //学院名称
        objvSysScoreSummaryENT.id_XzMajor = objvSysScoreSummaryENS.id_XzMajor; //专业流水号
        objvSysScoreSummaryENT.majorName = objvSysScoreSummaryENS.majorName; //专业名称
        objvSysScoreSummaryENT.id_GradeBase = objvSysScoreSummaryENS.id_GradeBase; //年级流水号
        objvSysScoreSummaryENT.gradeBaseName = objvSysScoreSummaryENS.gradeBaseName; //年级名称
        objvSysScoreSummaryENT.onlyId = objvSysScoreSummaryENS.onlyId; //OnlyId
        objvSysScoreSummaryENT.scoreTypeId = objvSysScoreSummaryENS.scoreTypeId; //分数类型Id
        objvSysScoreSummaryENT.scoreTypeName = objvSysScoreSummaryENS.scoreTypeName; //分数类型名称
        objvSysScoreSummaryENT.updUser = objvSysScoreSummaryENS.updUser; //修改人
        objvSysScoreSummaryENT.score = objvSysScoreSummaryENS.score; //评分
        objvSysScoreSummaryENT.id_CurrEduCls = objvSysScoreSummaryENS.id_CurrEduCls; //教学班流水号
        objvSysScoreSummaryENT.eduClsName = objvSysScoreSummaryENS.eduClsName; //教学班名
        objvSysScoreSummaryENT.isSubmit = objvSysScoreSummaryENS.isSubmit; //是否提交
    }
    exports.vSysScoreSummary_CopyObjTo = vSysScoreSummary_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysScoreSummaryENS:源对象
     * @param objvSysScoreSummaryENT:目标对象
    */
    function vSysScoreSummary_GetObjFromJsonObj(objvSysScoreSummaryENS) {
        const objvSysScoreSummaryENT = new clsvSysScoreSummaryEN_js_1.clsvSysScoreSummaryEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysScoreSummaryENT, objvSysScoreSummaryENS);
        return objvSysScoreSummaryENT;
    }
    exports.vSysScoreSummary_GetObjFromJsonObj = vSysScoreSummary_GetObjFromJsonObj;
});
