/**
* 类名:clsvSysSocialRelationsWApi
* 表名:vSysSocialRelations(01120654)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:45:41
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培主题(GraduateEduTopic)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysSocialRelations_GetObjFromJsonObj = exports.vSysSocialRelations_CopyObjTo = exports.vSysSocialRelations_GetUniCondStr4Update_SocialId = exports.vSysSocialRelations_GetUniCondStr_SocialId = exports.vSysSocialRelations_GetCombineCondition = exports.vSysSocialRelations_GetObjByJSONStr = exports.vSysSocialRelations_GetObjLstByJSONObjLst = exports.vSysSocialRelations_GetObjLstByJSONStr = exports.vSysSocialRelations_GetJSONStrByObj = exports.vSysSocialRelations__Cache = exports.vSysSocialRelations_ReFreshThisCache = exports.vSysSocialRelations_GetWebApiUrl = exports.vSysSocialRelations_GetRecCountByCond_Cache = exports.vSysSocialRelations_GetRecCountByCondAsync = exports.vSysSocialRelations_IsExistAsync = exports.vSysSocialRelations_IsExist_Cache = exports.vSysSocialRelations_IsExist = exports.vSysSocialRelations_IsExistRecordAsync = exports.vSysSocialRelations_IsExistRecord_Cache = exports.vSysSocialRelations_GetObjLstByPagerAsync = exports.vSysSocialRelations_GetObjLstByPager_Cache = exports.vSysSocialRelations_GetObjLstByRange = exports.vSysSocialRelations_GetObjLstByRangeAsync = exports.vSysSocialRelations_GetTopObjLstAsync = exports.vSysSocialRelations_GetObjLstBySocialIdLst_Cache = exports.vSysSocialRelations_GetObjLstBySocialIdLstAsync = exports.vSysSocialRelations_GetSubObjLst_Cache = exports.vSysSocialRelations_GetObjLst_PureCache = exports.vSysSocialRelations_GetObjLst_Cache = exports.vSysSocialRelations_GetObjLst_sessionStorage_PureCache = exports.vSysSocialRelations_GetObjLst_sessionStorage = exports.vSysSocialRelations_GetObjLstAsync = exports.vSysSocialRelations_GetObjLst_localStorage_PureCache = exports.vSysSocialRelations_GetObjLst_localStorage = exports.vSysSocialRelations_GetObjLst_ClientCache = exports.vSysSocialRelations_GetFirstObjAsync = exports.vSysSocialRelations_GetFirstID = exports.vSysSocialRelations_GetFirstIDAsync = exports.vSysSocialRelations_funcKey = exports.vSysSocialRelations_FilterFunByKey = exports.vSysSocialRelations_SortFunByKey = exports.vSysSocialRelations_SortFun_Defa_2Fld = exports.vSysSocialRelations_SortFun_Defa = exports.vSysSocialRelations_func = exports.vSysSocialRelations_GetNameBySocialId_Cache = exports.vSysSocialRelations_GetObjBySocialId_localStorage = exports.vSysSocialRelations_GetObjBySocialId_Cache = exports.vSysSocialRelations_GetObjBySocialIdAsync = exports.vSysSocialRelations_ConstructorName = exports.vSysSocialRelations_Controller = void 0;
    /**
     * 社会关系表视图(vSysSocialRelations)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvSysSocialRelationsEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsvSysSocialRelationsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysSocialRelations_Controller = "vSysSocialRelationsApi";
    exports.vSysSocialRelations_ConstructorName = "vSysSocialRelations";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSocialId:关键字
    * @returns 对象
    **/
    async function vSysSocialRelations_GetObjBySocialIdAsync(strSocialId) {
        const strThisFuncName = "GetObjBySocialIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In clsvSysSocialRelationsWApi.GetObjBySocialIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.GetObjBySocialIdAsync)", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySocialId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSocialId": strSocialId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvSysSocialRelations = vSysSocialRelations_GetObjFromJsonObj(returnObj);
                return objvSysSocialRelations;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetObjBySocialIdAsync = vSysSocialRelations_GetObjBySocialIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function vSysSocialRelations_GetObjBySocialId_Cache(strSocialId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySocialId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In clsvSysSocialRelationsWApi.GetObjBySocialId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.GetObjBySocialId_Cache)", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
            let objvSysSocialRelations;
            if (arrvSysSocialRelations_Sel.length > 0) {
                objvSysSocialRelations = arrvSysSocialRelations_Sel[0];
                return objvSysSocialRelations;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvSysSocialRelations_Const = await vSysSocialRelations_GetObjBySocialIdAsync(strSocialId);
                    if (objvSysSocialRelations_Const != null) {
                        vSysSocialRelations_ReFreshThisCache(strid_CurrEduCls);
                        return objvSysSocialRelations_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSocialId, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vSysSocialRelations_GetObjBySocialId_Cache = vSysSocialRelations_GetObjBySocialId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function vSysSocialRelations_GetObjBySocialId_localStorage(strSocialId) {
        const strThisFuncName = "GetObjBySocialId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In clsvSysSocialRelationsWApi.GetObjBySocialId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.GetObjBySocialId_localStorage)", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strSocialId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvSysSocialRelations_Cache = JSON.parse(strTempObj);
            return objvSysSocialRelations_Cache;
        }
        try {
            const objvSysSocialRelations = await vSysSocialRelations_GetObjBySocialIdAsync(strSocialId);
            if (objvSysSocialRelations != null) {
                localStorage.setItem(strKey, JSON.stringify(objvSysSocialRelations));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvSysSocialRelations;
            }
            return objvSysSocialRelations;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSocialId, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vSysSocialRelations_GetObjBySocialId_localStorage = vSysSocialRelations_GetObjBySocialId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function vSysSocialRelations_GetNameBySocialId_Cache(strSocialId, strid_CurrEduCls) {
        const strThisFuncName = "GetNameBySocialId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In clsvSysSocialRelationsWApi.GetNameBySocialId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.GetNameBySocialId_Cache)", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSocialRelationsObjLst_Cache == null)
            return "";
        try {
            const arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
            let objvSysSocialRelations;
            if (arrvSysSocialRelations_Sel.length > 0) {
                objvSysSocialRelations = arrvSysSocialRelations_Sel[0];
                return objvSysSocialRelations.levelName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strSocialId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vSysSocialRelations_GetNameBySocialId_Cache = vSysSocialRelations_GetNameBySocialId_Cache;
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
    async function vSysSocialRelations_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvSysSocialRelationsWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSocialId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvSysSocialRelations = await vSysSocialRelations_GetObjBySocialId_Cache(strSocialId, strid_CurrEduCls_C);
        if (objvSysSocialRelations == null)
            return "";
        if (objvSysSocialRelations.GetFldValue(strOutFldName) == null)
            return "";
        return objvSysSocialRelations.GetFldValue(strOutFldName).toString();
    }
    exports.vSysSocialRelations_func = vSysSocialRelations_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysSocialRelations_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.socialId.localeCompare(b.socialId);
    }
    exports.vSysSocialRelations_SortFun_Defa = vSysSocialRelations_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysSocialRelations_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.fullName == b.fullName)
            return a.nationality.localeCompare(b.nationality);
        else
            return a.fullName.localeCompare(b.fullName);
    }
    exports.vSysSocialRelations_SortFun_Defa_2Fld = vSysSocialRelations_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysSocialRelations_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName:
                    return (a, b) => {
                        if (a.fullName == null)
                            return -1;
                        if (b.fullName == null)
                            return 1;
                        return a.fullName.localeCompare(b.fullName);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Nationality:
                    return (a, b) => {
                        if (a.nationality == null)
                            return -1;
                        if (b.nationality == null)
                            return 1;
                        return a.nationality.localeCompare(b.nationality);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_WorkUnit:
                    return (a, b) => {
                        if (a.workUnit == null)
                            return -1;
                        if (b.workUnit == null)
                            return 1;
                        return a.workUnit.localeCompare(b.workUnit);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Major:
                    return (a, b) => {
                        if (a.major == null)
                            return -1;
                        if (b.major == null)
                            return 1;
                        return a.major.localeCompare(b.major);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Achievement:
                    return (a, b) => {
                        if (a.achievement == null)
                            return -1;
                        if (b.achievement == null)
                            return 1;
                        return a.achievement.localeCompare(b.achievement);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_DetailedDescription:
                    return (a, b) => {
                        if (a.detailedDescription == null)
                            return -1;
                        if (b.detailedDescription == null)
                            return 1;
                        return a.detailedDescription.localeCompare(b.detailedDescription);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId:
                    return (a, b) => {
                        if (a.levelId == null)
                            return -1;
                        if (b.levelId == null)
                            return 1;
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName:
                    return (a, b) => {
                        if (a.levelName == null)
                            return -1;
                        if (b.levelName == null)
                            return 1;
                        return a.levelName.localeCompare(b.levelName);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId:
                    return (a, b) => {
                        if (a.citationId == null)
                            return -1;
                        if (b.citationId == null)
                            return 1;
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfContent:
                    return (a, b) => {
                        if (a.pdfContent == null)
                            return -1;
                        if (b.pdfContent == null)
                            return 1;
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysSocialRelations]中不存在！(in ${exports.vSysSocialRelations_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName:
                    return (a, b) => {
                        if (b.fullName == null)
                            return -1;
                        if (a.fullName == null)
                            return 1;
                        return b.fullName.localeCompare(a.fullName);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Nationality:
                    return (a, b) => {
                        if (b.nationality == null)
                            return -1;
                        if (a.nationality == null)
                            return 1;
                        return b.nationality.localeCompare(a.nationality);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_WorkUnit:
                    return (a, b) => {
                        if (b.workUnit == null)
                            return -1;
                        if (a.workUnit == null)
                            return 1;
                        return b.workUnit.localeCompare(a.workUnit);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Major:
                    return (a, b) => {
                        if (b.major == null)
                            return -1;
                        if (a.major == null)
                            return 1;
                        return b.major.localeCompare(a.major);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Achievement:
                    return (a, b) => {
                        if (b.achievement == null)
                            return -1;
                        if (a.achievement == null)
                            return 1;
                        return b.achievement.localeCompare(a.achievement);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_DetailedDescription:
                    return (a, b) => {
                        if (b.detailedDescription == null)
                            return -1;
                        if (a.detailedDescription == null)
                            return 1;
                        return b.detailedDescription.localeCompare(a.detailedDescription);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId:
                    return (a, b) => {
                        if (b.levelId == null)
                            return -1;
                        if (a.levelId == null)
                            return 1;
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName:
                    return (a, b) => {
                        if (b.levelName == null)
                            return -1;
                        if (a.levelName == null)
                            return 1;
                        return b.levelName.localeCompare(a.levelName);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId:
                    return (a, b) => {
                        if (b.citationId == null)
                            return -1;
                        if (a.citationId == null)
                            return 1;
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfContent:
                    return (a, b) => {
                        if (b.pdfContent == null)
                            return -1;
                        if (a.pdfContent == null)
                            return 1;
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysSocialRelations]中不存在！(in ${exports.vSysSocialRelations_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysSocialRelations_SortFunByKey = vSysSocialRelations_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysSocialRelations_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName:
                return (obj) => {
                    return obj.fullName === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Nationality:
                return (obj) => {
                    return obj.nationality === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_WorkUnit:
                return (obj) => {
                    return obj.workUnit === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Major:
                return (obj) => {
                    return obj.major === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Achievement:
                return (obj) => {
                    return obj.achievement === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_DetailedDescription:
                return (obj) => {
                    return obj.detailedDescription === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName:
                return (obj) => {
                    return obj.levelName === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysSocialRelations]中不存在！(in ${exports.vSysSocialRelations_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysSocialRelations_FilterFunByKey = vSysSocialRelations_FilterFunByKey;
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
    async function vSysSocialRelations_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvSysSocialRelationsWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvSysSocialRelations = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvSysSocialRelations == null)
            return [];
        let arrvSysSocialRelations_Sel = arrvSysSocialRelations;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvSysSocialRelations_Sel.length == 0)
            return [];
        return arrvSysSocialRelations_Sel.map(x => x.socialId);
    }
    exports.vSysSocialRelations_funcKey = vSysSocialRelations_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysSocialRelations_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetFirstIDAsync = vSysSocialRelations_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysSocialRelations_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetFirstID = vSysSocialRelations_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysSocialRelations_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
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
                const objvSysSocialRelations = vSysSocialRelations_GetObjFromJsonObj(returnObj);
                return objvSysSocialRelations;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetFirstObjAsync = vSysSocialRelations_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvSysSocialRelationsExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvSysSocialRelationsObjLst_T = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsExObjLst_Cache);
            return arrvSysSocialRelationsObjLst_T;
        }
        try {
            const arrvSysSocialRelationsExObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvSysSocialRelationsExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSocialRelationsExObjLst.length);
            console.log(strInfo);
            return arrvSysSocialRelationsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysSocialRelations_GetObjLst_ClientCache = vSysSocialRelations_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysSocialRelationsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysSocialRelationsObjLst_T = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsExObjLst_Cache);
            return arrvSysSocialRelationsObjLst_T;
        }
        try {
            const arrvSysSocialRelationsExObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvSysSocialRelationsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSocialRelationsExObjLst.length);
            console.log(strInfo);
            return arrvSysSocialRelationsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysSocialRelations_GetObjLst_localStorage = vSysSocialRelations_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysSocialRelationsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysSocialRelationsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysSocialRelations_GetObjLst_localStorage_PureCache = vSysSocialRelations_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysSocialRelations_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetObjLstAsync = vSysSocialRelations_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysSocialRelationsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysSocialRelationsObjLst_T = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsExObjLst_Cache);
            return arrvSysSocialRelationsObjLst_T;
        }
        try {
            const arrvSysSocialRelationsExObjLst = await vSysSocialRelations_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvSysSocialRelationsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysSocialRelationsExObjLst.length);
            console.log(strInfo);
            return arrvSysSocialRelationsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysSocialRelations_GetObjLst_sessionStorage = vSysSocialRelations_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysSocialRelationsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysSocialRelationsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysSocialRelations_GetObjLst_sessionStorage_PureCache = vSysSocialRelations_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvSysSocialRelationsWApi.vSysSocialRelations_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvSysSocialRelationsWApi.vSysSocialRelations_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvSysSocialRelationsObjLst_Cache;
        switch (clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvSysSocialRelationsObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsObjLst_Cache);
        return arrvSysSocialRelationsObjLst_Cache;
    }
    exports.vSysSocialRelations_GetObjLst_Cache = vSysSocialRelations_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysSocialRelations_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvSysSocialRelationsObjLst_Cache;
        switch (clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysSocialRelationsObjLst_Cache = null;
                break;
            default:
                arrvSysSocialRelationsObjLst_Cache = null;
                break;
        }
        return arrvSysSocialRelationsObjLst_Cache;
    }
    exports.vSysSocialRelations_GetObjLst_PureCache = vSysSocialRelations_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSocialId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysSocialRelations_GetSubObjLst_Cache(objvSysSocialRelations_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        let arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache;
        if (objvSysSocialRelations_Cond.sf_FldComparisonOp == null || objvSysSocialRelations_Cond.sf_FldComparisonOp == "")
            return arrvSysSocialRelations_Sel;
        const dicFldComparisonOp = JSON.parse(objvSysSocialRelations_Cond.sf_FldComparisonOp);
        //console.log("clsvSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysSocialRelations_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysSocialRelations_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvSysSocialRelations_Cond), exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysSocialRelations_GetSubObjLst_Cache = vSysSocialRelations_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSocialId:关键字列表
    * @returns 对象列表
    **/
    async function vSysSocialRelations_GetObjLstBySocialIdLstAsync(arrSocialId) {
        const strThisFuncName = "GetObjLstBySocialIdLstAsync";
        const strAction = "GetObjLstBySocialIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSocialId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetObjLstBySocialIdLstAsync = vSysSocialRelations_GetObjLstBySocialIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSocialIdLst:关键字列表
     * @returns 对象列表
    */
    async function vSysSocialRelations_GetObjLstBySocialIdLst_Cache(arrSocialIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBySocialIdLst_Cache";
        try {
            const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
            const arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache.filter(x => arrSocialIdLst.indexOf(x.socialId) > -1);
            return arrvSysSocialRelations_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSocialIdLst.join(","), exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vSysSocialRelations_GetObjLstBySocialIdLst_Cache = vSysSocialRelations_GetObjLstBySocialIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysSocialRelations_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetTopObjLstAsync = vSysSocialRelations_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysSocialRelations_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetObjLstByRangeAsync = vSysSocialRelations_GetObjLstByRangeAsync;
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
    async function vSysSocialRelations_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetObjLstByRange = vSysSocialRelations_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vSysSocialRelations_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSocialRelationsObjLst_Cache.length == 0)
            return arrvSysSocialRelationsObjLst_Cache;
        let arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvSysSocialRelations_Cond = new clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysSocialRelations_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvSysSocialRelationsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysSocialRelations_Sel.length == 0)
                return arrvSysSocialRelations_Sel;
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
                arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.sort(vSysSocialRelations_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.sort(objPagerPara.sortFun);
            }
            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.slice(intStart, intEnd);
            return arrvSysSocialRelations_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysSocialRelations_GetObjLstByPager_Cache = vSysSocialRelations_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysSocialRelations_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetObjLstByPagerAsync = vSysSocialRelations_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSocialId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysSocialRelations_IsExistRecord_Cache(objvSysSocialRelations_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSocialRelationsObjLst_Cache == null)
            return false;
        let arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache;
        if (objvSysSocialRelations_Cond.sf_FldComparisonOp == null || objvSysSocialRelations_Cond.sf_FldComparisonOp == "")
            return arrvSysSocialRelations_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvSysSocialRelations_Cond.sf_FldComparisonOp);
        //console.log("clsvSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysSocialRelations_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysSocialRelations_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvSysSocialRelations_Cond), exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vSysSocialRelations_IsExistRecord_Cache = vSysSocialRelations_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysSocialRelations_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_IsExistRecordAsync = vSysSocialRelations_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSocialId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysSocialRelations_IsExist(strSocialId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SocialId": strSocialId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_IsExist = vSysSocialRelations_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function vSysSocialRelations_IsExist_Cache(strSocialId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSocialRelationsObjLst_Cache == null)
            return false;
        try {
            const arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
            if (arrvSysSocialRelations_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSocialId, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vSysSocialRelations_IsExist_Cache = vSysSocialRelations_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSocialId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysSocialRelations_IsExistAsync(strSocialId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSocialId": strSocialId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_IsExistAsync = vSysSocialRelations_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysSocialRelations_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysSocialRelations_GetRecCountByCondAsync = vSysSocialRelations_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvSysSocialRelations_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vSysSocialRelations_GetRecCountByCond_Cache(objvSysSocialRelations_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvSysSocialRelationsObjLst_Cache = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysSocialRelationsObjLst_Cache == null)
            return 0;
        let arrvSysSocialRelations_Sel = arrvSysSocialRelationsObjLst_Cache;
        if (objvSysSocialRelations_Cond.sf_FldComparisonOp == null || objvSysSocialRelations_Cond.sf_FldComparisonOp == "")
            return arrvSysSocialRelations_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvSysSocialRelations_Cond.sf_FldComparisonOp);
        //console.log("clsvSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysSocialRelations_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysSocialRelations_Sel = arrvSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysSocialRelations_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvSysSocialRelations_Cond), exports.vSysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vSysSocialRelations_GetRecCountByCond_Cache = vSysSocialRelations_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysSocialRelations_GetWebApiUrl(strController, strAction) {
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
    exports.vSysSocialRelations_GetWebApiUrl = vSysSocialRelations_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vSysSocialRelations_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
            switch (clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.CacheModeId) {
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
    exports.vSysSocialRelations_ReFreshThisCache = vSysSocialRelations_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vSysSocialRelations__Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvSysSocialRelationsWApi.)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvSysSocialRelationsWApi.)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vSysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName, "社会关系表视图");
    }
    exports.vSysSocialRelations__Cache = vSysSocialRelations__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysSocialRelations_GetJSONStrByObj(pobjvSysSocialRelationsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysSocialRelationsEN);
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
    exports.vSysSocialRelations_GetJSONStrByObj = vSysSocialRelations_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysSocialRelations_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysSocialRelationsObjLst = new Array();
        if (strJSON === "") {
            return arrvSysSocialRelationsObjLst;
        }
        try {
            arrvSysSocialRelationsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysSocialRelationsObjLst;
        }
        return arrvSysSocialRelationsObjLst;
    }
    exports.vSysSocialRelations_GetObjLstByJSONStr = vSysSocialRelations_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysSocialRelationsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysSocialRelations_GetObjLstByJSONObjLst(arrvSysSocialRelationsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysSocialRelationsObjLst = new Array();
        for (const objInFor of arrvSysSocialRelationsObjLstS) {
            const obj1 = vSysSocialRelations_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysSocialRelationsObjLst.push(obj1);
        }
        return arrvSysSocialRelationsObjLst;
    }
    exports.vSysSocialRelations_GetObjLstByJSONObjLst = vSysSocialRelations_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysSocialRelations_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysSocialRelationsEN = new clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN();
        if (strJSON === "") {
            return pobjvSysSocialRelationsEN;
        }
        try {
            pobjvSysSocialRelationsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysSocialRelationsEN;
        }
        return pobjvSysSocialRelationsEN;
    }
    exports.vSysSocialRelations_GetObjByJSONStr = vSysSocialRelations_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysSocialRelations_GetCombineCondition(objvSysSocialRelations_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_SocialId, objvSysSocialRelations_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName) == true) {
            const strComparisonOp_FullName = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_FullName, objvSysSocialRelations_Cond.fullName, strComparisonOp_FullName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Nationality) == true) {
            const strComparisonOp_Nationality = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Nationality];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Nationality, objvSysSocialRelations_Cond.nationality, strComparisonOp_Nationality);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_WorkUnit) == true) {
            const strComparisonOp_WorkUnit = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_WorkUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_WorkUnit, objvSysSocialRelations_Cond.workUnit, strComparisonOp_WorkUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Major) == true) {
            const strComparisonOp_Major = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Major, objvSysSocialRelations_Cond.major, strComparisonOp_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Achievement) == true) {
            const strComparisonOp_Achievement = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Achievement];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Achievement, objvSysSocialRelations_Cond.achievement, strComparisonOp_Achievement);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelId, objvSysSocialRelations_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName) == true) {
            const strComparisonOp_LevelName = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_LevelName, objvSysSocialRelations_Cond.levelName, strComparisonOp_LevelName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdUser, objvSysSocialRelations_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_UpdDate, objvSysSocialRelations_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit) == true) {
            if (objvSysSocialRelations_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_OkCount, objvSysSocialRelations_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationCount, objvSysSocialRelations_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_VersionCount, objvSysSocialRelations_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_id_CurrEduCls, objvSysSocialRelations_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Memo, objvSysSocialRelations_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_AppraiseCount, objvSysSocialRelations_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Score) == true) {
            const strComparisonOp_Score = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_Score, objvSysSocialRelations_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_StuScore, objvSysSocialRelations_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_TeaScore, objvSysSocialRelations_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CitationId, objvSysSocialRelations_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_CreateDate, objvSysSocialRelations_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_ShareId, objvSysSocialRelations_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfContent, objvSysSocialRelations_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysSocialRelations_Cond.dicFldComparisonOp, clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objvSysSocialRelations_Cond.dicFldComparisonOp[clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN.con_PdfPageNum, objvSysSocialRelations_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        return strWhereCond;
    }
    exports.vSysSocialRelations_GetCombineCondition = vSysSocialRelations_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vSysSocialRelations(社会关系表视图),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSocialId: 社会Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vSysSocialRelations_GetUniCondStr_SocialId(objvSysSocialRelationsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SocialId = '{0}'", objvSysSocialRelationsEN.socialId);
        return strWhereCond;
    }
    exports.vSysSocialRelations_GetUniCondStr_SocialId = vSysSocialRelations_GetUniCondStr_SocialId;
    /**
    *获取唯一性条件串(Uniqueness)--vSysSocialRelations(社会关系表视图),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSocialId: 社会Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vSysSocialRelations_GetUniCondStr4Update_SocialId(objvSysSocialRelationsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SocialId <> '{0}'", objvSysSocialRelationsEN.socialId);
        strWhereCond += (0, clsString_js_1.Format)(" and SocialId = '{0}'", objvSysSocialRelationsEN.socialId);
        return strWhereCond;
    }
    exports.vSysSocialRelations_GetUniCondStr4Update_SocialId = vSysSocialRelations_GetUniCondStr4Update_SocialId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysSocialRelationsENS:源对象
     * @param objvSysSocialRelationsENT:目标对象
    */
    function vSysSocialRelations_CopyObjTo(objvSysSocialRelationsENS, objvSysSocialRelationsENT) {
        objvSysSocialRelationsENT.socialId = objvSysSocialRelationsENS.socialId; //社会Id
        objvSysSocialRelationsENT.fullName = objvSysSocialRelationsENS.fullName; //姓名
        objvSysSocialRelationsENT.nationality = objvSysSocialRelationsENS.nationality; //国籍
        objvSysSocialRelationsENT.workUnit = objvSysSocialRelationsENS.workUnit; //工作单位
        objvSysSocialRelationsENT.major = objvSysSocialRelationsENS.major; //专业
        objvSysSocialRelationsENT.achievement = objvSysSocialRelationsENS.achievement; //成就
        objvSysSocialRelationsENT.detailedDescription = objvSysSocialRelationsENS.detailedDescription; //详细说明
        objvSysSocialRelationsENT.levelId = objvSysSocialRelationsENS.levelId; //级别Id
        objvSysSocialRelationsENT.levelName = objvSysSocialRelationsENS.levelName; //级别名称
        objvSysSocialRelationsENT.updUser = objvSysSocialRelationsENS.updUser; //修改人
        objvSysSocialRelationsENT.updDate = objvSysSocialRelationsENS.updDate; //修改日期
        objvSysSocialRelationsENT.isSubmit = objvSysSocialRelationsENS.isSubmit; //是否提交
        objvSysSocialRelationsENT.okCount = objvSysSocialRelationsENS.okCount; //点赞统计
        objvSysSocialRelationsENT.citationCount = objvSysSocialRelationsENS.citationCount; //引用统计
        objvSysSocialRelationsENT.versionCount = objvSysSocialRelationsENS.versionCount; //版本统计
        objvSysSocialRelationsENT.id_CurrEduCls = objvSysSocialRelationsENS.id_CurrEduCls; //教学班流水号
        objvSysSocialRelationsENT.memo = objvSysSocialRelationsENS.memo; //备注
        objvSysSocialRelationsENT.appraiseCount = objvSysSocialRelationsENS.appraiseCount; //评论数
        objvSysSocialRelationsENT.score = objvSysSocialRelationsENS.score; //评分
        objvSysSocialRelationsENT.stuScore = objvSysSocialRelationsENS.stuScore; //学生平均分
        objvSysSocialRelationsENT.teaScore = objvSysSocialRelationsENS.teaScore; //教师评分
        objvSysSocialRelationsENT.citationId = objvSysSocialRelationsENS.citationId; //引用Id
        objvSysSocialRelationsENT.createDate = objvSysSocialRelationsENS.createDate; //建立日期
        objvSysSocialRelationsENT.shareId = objvSysSocialRelationsENS.shareId; //分享Id
        objvSysSocialRelationsENT.pdfContent = objvSysSocialRelationsENS.pdfContent; //Pdf内容
        objvSysSocialRelationsENT.pdfPageNum = objvSysSocialRelationsENS.pdfPageNum; //Pdf页码
    }
    exports.vSysSocialRelations_CopyObjTo = vSysSocialRelations_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysSocialRelationsENS:源对象
     * @param objvSysSocialRelationsENT:目标对象
    */
    function vSysSocialRelations_GetObjFromJsonObj(objvSysSocialRelationsENS) {
        const objvSysSocialRelationsENT = new clsvSysSocialRelationsEN_js_1.clsvSysSocialRelationsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysSocialRelationsENT, objvSysSocialRelationsENS);
        return objvSysSocialRelationsENT;
    }
    exports.vSysSocialRelations_GetObjFromJsonObj = vSysSocialRelations_GetObjFromJsonObj;
});
