/**
* 类名:clsSysSocialRelationsWApi
* 表名:SysSocialRelations(01120644)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:57
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js", "../../L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysSocialRelations_GetObjFromJsonObj = exports.SysSocialRelations_CopyObjTo = exports.SysSocialRelations_GetUniCondStr4Update_SocialId = exports.SysSocialRelations_GetUniCondStr_SocialId = exports.SysSocialRelations_GetCombineCondition = exports.SysSocialRelations_GetObjByJSONStr = exports.SysSocialRelations_GetObjLstByJSONObjLst = exports.SysSocialRelations_GetObjLstByJSONStr = exports.SysSocialRelations_GetJSONStrByObj = exports.SysSocialRelations_CheckProperty4Update = exports.SysSocialRelations_CheckPropertyNew = exports.SysSocialRelations_ReFreshThisCache = exports.SysSocialRelations_ReFreshCache = exports.SysSocialRelations_GetWebApiUrl = exports.SysSocialRelations_GetMaxStrIdByPrefix = exports.SysSocialRelations_GetMaxStrIdAsync = exports.SysSocialRelations_GetRecCountByCond_Cache = exports.SysSocialRelations_GetRecCountByCondAsync = exports.SysSocialRelations_IsExistAsync = exports.SysSocialRelations_IsExist_Cache = exports.SysSocialRelations_IsExist = exports.SysSocialRelations_IsExistRecordAsync = exports.SysSocialRelations_IsExistRecord_Cache = exports.SysSocialRelations_UpdateWithConditionAsync = exports.SysSocialRelations_UpdateRecordAsync = exports.SysSocialRelations_AddNewRecordWithReturnKey = exports.SysSocialRelations_AddNewRecordWithReturnKeyAsync = exports.SysSocialRelations_AddNewRecordWithMaxIdAsync = exports.SysSocialRelations_AddNewRecordAsync = exports.SysSocialRelations_DelSysSocialRelationssByCondAsync = exports.SysSocialRelations_DelSysSocialRelationssAsync = exports.SysSocialRelations_DelRecordAsync = exports.SysSocialRelations_GetObjLstByPagerAsync = exports.SysSocialRelations_GetObjLstByPager_Cache = exports.SysSocialRelations_GetObjLstByRange = exports.SysSocialRelations_GetObjLstByRangeAsync = exports.SysSocialRelations_GetTopObjLstAsync = exports.SysSocialRelations_GetObjLstBySocialIdLst_Cache = exports.SysSocialRelations_GetObjLstBySocialIdLstAsync = exports.SysSocialRelations_GetSubObjLst_Cache = exports.SysSocialRelations_GetObjLst_PureCache = exports.SysSocialRelations_GetObjLst_Cache = exports.SysSocialRelations_GetObjLst_sessionStorage_PureCache = exports.SysSocialRelations_GetObjLst_sessionStorage = exports.SysSocialRelations_GetObjLstAsync = exports.SysSocialRelations_GetObjLst_localStorage_PureCache = exports.SysSocialRelations_GetObjLst_localStorage = exports.SysSocialRelations_GetObjLst_ClientCache = exports.SysSocialRelations_GetFirstObjAsync = exports.SysSocialRelations_GetFirstID = exports.SysSocialRelations_GetFirstIDAsync = exports.SysSocialRelations_FilterFunByKey = exports.SysSocialRelations_SortFunByKey = exports.SysSocialRelations_SortFun_Defa_2Fld = exports.SysSocialRelations_SortFun_Defa = exports.SysSocialRelations_func = exports.SysSocialRelations_UpdateObjInLst_Cache = exports.SysSocialRelations_GetObjBySocialId_localStorage = exports.SysSocialRelations_GetObjBySocialId_Cache = exports.SysSocialRelations_GetObjBySocialIdAsync = exports.sysSocialRelations_ConstructorName = exports.sysSocialRelations_Controller = void 0;
    /**
     * 社会关系表(SysSocialRelations)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSysSocialRelationsEN_js_1 = require("../../L0_Entity/GraduateEduTopic/clsSysSocialRelationsEN.js");
    const clsvSysSocialRelationsWApi_js_1 = require("../../L3_ForWApi/GraduateEduTopic/clsvSysSocialRelationsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.sysSocialRelations_Controller = "SysSocialRelationsApi";
    exports.sysSocialRelations_ConstructorName = "sysSocialRelations";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSocialId:关键字
    * @returns 对象
    **/
    async function SysSocialRelations_GetObjBySocialIdAsync(strSocialId) {
        const strThisFuncName = "GetObjBySocialIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In GetObjBySocialIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySocialId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysSocialRelations = SysSocialRelations_GetObjFromJsonObj(returnObj);
                return objSysSocialRelations;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetObjBySocialIdAsync = SysSocialRelations_GetObjBySocialIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function SysSocialRelations_GetObjBySocialId_Cache(strSocialId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySocialId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In GetObjBySocialId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
            let objSysSocialRelations;
            if (arrSysSocialRelations_Sel.length > 0) {
                objSysSocialRelations = arrSysSocialRelations_Sel[0];
                return objSysSocialRelations;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objSysSocialRelations = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
                    if (objSysSocialRelations != null) {
                        SysSocialRelations_ReFreshThisCache(strid_CurrEduCls);
                        return objSysSocialRelations;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSocialId, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SysSocialRelations_GetObjBySocialId_Cache = SysSocialRelations_GetObjBySocialId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function SysSocialRelations_GetObjBySocialId_localStorage(strSocialId) {
        const strThisFuncName = "GetObjBySocialId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSocialId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSocialId]不能为空！(In GetObjBySocialId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSocialId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSocialId]的长度:[{0}]不正确！", strSocialId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strSocialId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSysSocialRelations_Cache = JSON.parse(strTempObj);
            return objSysSocialRelations_Cache;
        }
        try {
            const objSysSocialRelations = await SysSocialRelations_GetObjBySocialIdAsync(strSocialId);
            if (objSysSocialRelations != null) {
                localStorage.setItem(strKey, JSON.stringify(objSysSocialRelations));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSysSocialRelations;
            }
            return objSysSocialRelations;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSocialId, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SysSocialRelations_GetObjBySocialId_localStorage = SysSocialRelations_GetObjBySocialId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSysSocialRelations:所给的对象
     * @returns 对象
    */
    async function SysSocialRelations_UpdateObjInLst_Cache(objSysSocialRelations, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrSysSocialRelationsObjLst_Cache.find(x => x.socialId == objSysSocialRelations.socialId);
            if (obj != null) {
                objSysSocialRelations.socialId = obj.socialId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSysSocialRelations);
            }
            else {
                arrSysSocialRelationsObjLst_Cache.push(objSysSocialRelations);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SysSocialRelations_UpdateObjInLst_Cache = SysSocialRelations_UpdateObjInLst_Cache;
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
    async function SysSocialRelations_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSocialId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSysSocialRelations = await SysSocialRelations_GetObjBySocialId_Cache(strSocialId, strid_CurrEduCls_C);
        if (objSysSocialRelations == null)
            return "";
        return objSysSocialRelations.GetFldValue(strOutFldName).toString();
    }
    exports.SysSocialRelations_func = SysSocialRelations_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelations_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.socialId.localeCompare(b.socialId);
    }
    exports.SysSocialRelations_SortFun_Defa = SysSocialRelations_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelations_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.fullName == b.fullName)
            return a.nationality.localeCompare(b.nationality);
        else
            return a.fullName.localeCompare(b.fullName);
    }
    exports.SysSocialRelations_SortFun_Defa_2Fld = SysSocialRelations_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysSocialRelations_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId:
                    return (a, b) => {
                        return a.socialId.localeCompare(b.socialId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_FullName:
                    return (a, b) => {
                        return a.fullName.localeCompare(b.fullName);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Nationality:
                    return (a, b) => {
                        return a.nationality.localeCompare(b.nationality);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_WorkUnit:
                    return (a, b) => {
                        return a.workUnit.localeCompare(b.workUnit);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Major:
                    return (a, b) => {
                        return a.major.localeCompare(b.major);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Achievement:
                    return (a, b) => {
                        return a.achievement.localeCompare(b.achievement);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_DetailedDescription:
                    return (a, b) => {
                        return a.detailedDescription.localeCompare(b.detailedDescription);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_LevelId:
                    return (a, b) => {
                        return a.levelId.localeCompare(b.levelId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationCount:
                    return (a, b) => {
                        return a.citationCount - b.citationCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationId:
                    return (a, b) => {
                        return a.citationId.localeCompare(b.citationId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfContent:
                    return (a, b) => {
                        return a.pdfContent.localeCompare(b.pdfContent);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfPageNum:
                    return (a, b) => {
                        return a.pdfPageNum - b.pdfPageNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelations]中不存在！(in ${exports.sysSocialRelations_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId:
                    return (a, b) => {
                        return b.socialId.localeCompare(a.socialId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_FullName:
                    return (a, b) => {
                        return b.fullName.localeCompare(a.fullName);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Nationality:
                    return (a, b) => {
                        return b.nationality.localeCompare(a.nationality);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_WorkUnit:
                    return (a, b) => {
                        return b.workUnit.localeCompare(a.workUnit);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Major:
                    return (a, b) => {
                        return b.major.localeCompare(a.major);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Achievement:
                    return (a, b) => {
                        return b.achievement.localeCompare(a.achievement);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_DetailedDescription:
                    return (a, b) => {
                        return b.detailedDescription.localeCompare(a.detailedDescription);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_LevelId:
                    return (a, b) => {
                        return b.levelId.localeCompare(a.levelId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationCount:
                    return (a, b) => {
                        return b.citationCount - a.citationCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationId:
                    return (a, b) => {
                        return b.citationId.localeCompare(a.citationId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfContent:
                    return (a, b) => {
                        return b.pdfContent.localeCompare(a.pdfContent);
                    };
                case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfPageNum:
                    return (a, b) => {
                        return b.pdfPageNum - a.pdfPageNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelations]中不存在！(in ${exports.sysSocialRelations_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysSocialRelations_SortFunByKey = SysSocialRelations_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysSocialRelations_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId:
                return (obj) => {
                    return obj.socialId === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_FullName:
                return (obj) => {
                    return obj.fullName === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Nationality:
                return (obj) => {
                    return obj.nationality === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_WorkUnit:
                return (obj) => {
                    return obj.workUnit === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Major:
                return (obj) => {
                    return obj.major === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Achievement:
                return (obj) => {
                    return obj.achievement === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_DetailedDescription:
                return (obj) => {
                    return obj.detailedDescription === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_LevelId:
                return (obj) => {
                    return obj.levelId === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationCount:
                return (obj) => {
                    return obj.citationCount === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationId:
                return (obj) => {
                    return obj.citationId === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfContent:
                return (obj) => {
                    return obj.pdfContent === value;
                };
            case clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfPageNum:
                return (obj) => {
                    return obj.pdfPageNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysSocialRelations]中不存在！(in ${exports.sysSocialRelations_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysSocialRelations_FilterFunByKey = SysSocialRelations_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSocialRelations_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetFirstIDAsync = SysSocialRelations_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysSocialRelations_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetFirstID = SysSocialRelations_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysSocialRelations_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objSysSocialRelations = SysSocialRelations_GetObjFromJsonObj(returnObj);
                return objSysSocialRelations;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetFirstObjAsync = SysSocialRelations_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSysSocialRelationsExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrSysSocialRelationsObjLst_T = SysSocialRelations_GetObjLstByJSONObjLst(arrSysSocialRelationsExObjLst_Cache);
            return arrSysSocialRelationsObjLst_T;
        }
        try {
            const arrSysSocialRelationsExObjLst = await SysSocialRelations_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrSysSocialRelationsExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSocialRelationsExObjLst.length);
            console.log(strInfo);
            return arrSysSocialRelationsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSocialRelations_GetObjLst_ClientCache = SysSocialRelations_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysSocialRelationsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysSocialRelationsObjLst_T = SysSocialRelations_GetObjLstByJSONObjLst(arrSysSocialRelationsExObjLst_Cache);
            return arrSysSocialRelationsObjLst_T;
        }
        try {
            const arrSysSocialRelationsExObjLst = await SysSocialRelations_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSysSocialRelationsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSocialRelationsExObjLst.length);
            console.log(strInfo);
            return arrSysSocialRelationsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSocialRelations_GetObjLst_localStorage = SysSocialRelations_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysSocialRelationsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysSocialRelationsObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysSocialRelations_GetObjLst_localStorage_PureCache = SysSocialRelations_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysSocialRelations_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetObjLstAsync = SysSocialRelations_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysSocialRelationsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysSocialRelationsObjLst_T = SysSocialRelations_GetObjLstByJSONObjLst(arrSysSocialRelationsExObjLst_Cache);
            return arrSysSocialRelationsObjLst_T;
        }
        try {
            const arrSysSocialRelationsExObjLst = await SysSocialRelations_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSysSocialRelationsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysSocialRelationsExObjLst.length);
            console.log(strInfo);
            return arrSysSocialRelationsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysSocialRelations_GetObjLst_sessionStorage = SysSocialRelations_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysSocialRelationsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysSocialRelationsObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysSocialRelations_GetObjLst_sessionStorage_PureCache = SysSocialRelations_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrSysSocialRelationsObjLst_Cache;
        switch (clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrSysSocialRelationsObjLst = SysSocialRelations_GetObjLstByJSONObjLst(arrSysSocialRelationsObjLst_Cache);
        return arrSysSocialRelationsObjLst_Cache;
    }
    exports.SysSocialRelations_GetObjLst_Cache = SysSocialRelations_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysSocialRelations_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSysSocialRelationsObjLst_Cache;
        switch (clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrSysSocialRelationsObjLst_Cache = null;
                break;
            default:
                arrSysSocialRelationsObjLst_Cache = null;
                break;
        }
        return arrSysSocialRelationsObjLst_Cache;
    }
    exports.SysSocialRelations_GetObjLst_PureCache = SysSocialRelations_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSocialId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysSocialRelations_GetSubObjLst_Cache(objSysSocialRelations_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        let arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache;
        if (objSysSocialRelations_Cond.sf_FldComparisonOp == null || objSysSocialRelations_Cond.sf_FldComparisonOp == "")
            return arrSysSocialRelations_Sel;
        const dicFldComparisonOp = JSON.parse(objSysSocialRelations_Cond.sf_FldComparisonOp);
        //console.log("clsSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSocialRelations_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysSocialRelations_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSysSocialRelations_Cond), exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSocialRelations_GetSubObjLst_Cache = SysSocialRelations_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSocialId:关键字列表
    * @returns 对象列表
    **/
    async function SysSocialRelations_GetObjLstBySocialIdLstAsync(arrSocialId) {
        const strThisFuncName = "GetObjLstBySocialIdLstAsync";
        const strAction = "GetObjLstBySocialIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSocialId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetObjLstBySocialIdLstAsync = SysSocialRelations_GetObjLstBySocialIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSocialIdLst:关键字列表
     * @returns 对象列表
    */
    async function SysSocialRelations_GetObjLstBySocialIdLst_Cache(arrSocialIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBySocialIdLst_Cache";
        try {
            const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
            const arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache.filter(x => arrSocialIdLst.indexOf(x.socialId) > -1);
            return arrSysSocialRelations_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSocialIdLst.join(","), exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSocialRelations_GetObjLstBySocialIdLst_Cache = SysSocialRelations_GetObjLstBySocialIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysSocialRelations_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetTopObjLstAsync = SysSocialRelations_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSocialRelations_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetObjLstByRangeAsync = SysSocialRelations_GetObjLstByRangeAsync;
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
    async function SysSocialRelations_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetObjLstByRange = SysSocialRelations_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysSocialRelations_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSocialRelationsObjLst_Cache.length == 0)
            return arrSysSocialRelationsObjLst_Cache;
        let arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysSocialRelations_Cond = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSocialRelations_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysSocialRelationsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSocialRelations_Sel.length == 0)
                return arrSysSocialRelations_Sel;
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
                arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.sort(SysSocialRelations_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.sort(objPagerPara.sortFun);
            }
            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.slice(intStart, intEnd);
            return arrSysSocialRelations_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysSocialRelations_GetObjLstByPager_Cache = SysSocialRelations_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysSocialRelations_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysSocialRelations_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysSocialRelations_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetObjLstByPagerAsync = SysSocialRelations_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strSocialId:关键字
    * @returns 获取删除的结果
    **/
    async function SysSocialRelations_DelRecordAsync(strSocialId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strSocialId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strSocialId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_DelRecordAsync = SysSocialRelations_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrSocialId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysSocialRelations_DelSysSocialRelationssAsync(arrSocialId) {
        const strThisFuncName = "DelSysSocialRelationssAsync";
        const strAction = "DelSysSocialRelationss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSocialId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_DelSysSocialRelationssAsync = SysSocialRelations_DelSysSocialRelationssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysSocialRelations_DelSysSocialRelationssByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysSocialRelationssByCondAsync";
        const strAction = "DelSysSocialRelationssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_DelSysSocialRelationssByCondAsync = SysSocialRelations_DelSysSocialRelationssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysSocialRelationsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSocialRelations_AddNewRecordAsync(objSysSocialRelationsEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysSocialRelationsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_AddNewRecordAsync = SysSocialRelations_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysSocialRelationsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysSocialRelations_AddNewRecordWithMaxIdAsync(objSysSocialRelationsEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_AddNewRecordWithMaxIdAsync = SysSocialRelations_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysSocialRelationsEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysSocialRelations_AddNewRecordWithReturnKeyAsync(objSysSocialRelationsEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_AddNewRecordWithReturnKeyAsync = SysSocialRelations_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysSocialRelationsEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysSocialRelations_AddNewRecordWithReturnKey(objSysSocialRelationsEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysSocialRelationsEN.socialId === null || objSysSocialRelationsEN.socialId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_AddNewRecordWithReturnKey = SysSocialRelations_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysSocialRelationsEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysSocialRelations_UpdateRecordAsync(objSysSocialRelationsEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysSocialRelationsEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsEN.sf_UpdFldSetStr === null || objSysSocialRelationsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsEN.socialId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_UpdateRecordAsync = SysSocialRelations_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysSocialRelationsEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysSocialRelations_UpdateWithConditionAsync(objSysSocialRelationsEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysSocialRelationsEN.sf_UpdFldSetStr === undefined || objSysSocialRelationsEN.sf_UpdFldSetStr === null || objSysSocialRelationsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysSocialRelationsEN.socialId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
        objSysSocialRelationsEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysSocialRelationsEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_UpdateWithConditionAsync = SysSocialRelations_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSocialId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysSocialRelations_IsExistRecord_Cache(objSysSocialRelations_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSocialRelationsObjLst_Cache == null)
            return false;
        let arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache;
        if (objSysSocialRelations_Cond.sf_FldComparisonOp == null || objSysSocialRelations_Cond.sf_FldComparisonOp == "")
            return arrSysSocialRelations_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSysSocialRelations_Cond.sf_FldComparisonOp);
        //console.log("clsSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSocialRelations_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysSocialRelations_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSysSocialRelations_Cond), exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SysSocialRelations_IsExistRecord_Cache = SysSocialRelations_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysSocialRelations_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_IsExistRecordAsync = SysSocialRelations_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSocialId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysSocialRelations_IsExist(strSocialId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_IsExist = SysSocialRelations_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSocialId:所给的关键字
     * @returns 对象
    */
    async function SysSocialRelations_IsExist_Cache(strSocialId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSocialRelationsObjLst_Cache == null)
            return false;
        try {
            const arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache.filter(x => x.socialId == strSocialId);
            if (arrSysSocialRelations_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSocialId, exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SysSocialRelations_IsExist_Cache = SysSocialRelations_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSocialId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysSocialRelations_IsExistAsync(strSocialId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_IsExistAsync = SysSocialRelations_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysSocialRelations_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetRecCountByCondAsync = SysSocialRelations_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSysSocialRelations_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SysSocialRelations_GetRecCountByCond_Cache(objSysSocialRelations_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSysSocialRelationsObjLst_Cache = await SysSocialRelations_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysSocialRelationsObjLst_Cache == null)
            return 0;
        let arrSysSocialRelations_Sel = arrSysSocialRelationsObjLst_Cache;
        if (objSysSocialRelations_Cond.sf_FldComparisonOp == null || objSysSocialRelations_Cond.sf_FldComparisonOp == "")
            return arrSysSocialRelations_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSysSocialRelations_Cond.sf_FldComparisonOp);
        //console.log("clsSysSocialRelationsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysSocialRelations_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysSocialRelations_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysSocialRelations_Sel = arrSysSocialRelations_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysSocialRelations_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSysSocialRelations_Cond), exports.sysSocialRelations_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SysSocialRelations_GetRecCountByCond_Cache = SysSocialRelations_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function SysSocialRelations_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetMaxStrIdAsync = SysSocialRelations_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function SysSocialRelations_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysSocialRelations_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysSocialRelations_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysSocialRelations_GetMaxStrIdByPrefix = SysSocialRelations_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysSocialRelations_GetWebApiUrl(strController, strAction) {
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
    exports.SysSocialRelations_GetWebApiUrl = SysSocialRelations_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SysSocialRelations_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsSysSocialRelationsWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
        switch (clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheModeId) {
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
        (0, clsvSysSocialRelationsWApi_js_1.vSysSocialRelations_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.SysSocialRelations_ReFreshCache = SysSocialRelations_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SysSocialRelations_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN._CurrTabName, strid_CurrEduCls);
            switch (clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.CacheModeId) {
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
    exports.SysSocialRelations_ReFreshThisCache = SysSocialRelations_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSocialRelations_CheckPropertyNew(pobjSysSocialRelationsEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.socialId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.socialId) > 10) {
            throw new Error("(errid:Watl000059)字段[社会Id(socialId)]的长度不能超过10(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.socialId)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.fullName) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.fullName) > 50) {
            throw new Error("(errid:Watl000059)字段[姓名(fullName)]的长度不能超过50(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.fullName)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.nationality) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.nationality) > 50) {
            throw new Error("(errid:Watl000059)字段[国籍(nationality)]的长度不能超过50(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.nationality)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.workUnit) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.workUnit) > 100) {
            throw new Error("(errid:Watl000059)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.workUnit)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.major) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.major) > 50) {
            throw new Error("(errid:Watl000059)字段[专业(major)]的长度不能超过50(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.major)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.achievement) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.achievement) > 5000) {
            throw new Error("(errid:Watl000059)字段[成就(achievement)]的长度不能超过5000(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.achievement)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.levelId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.levelId) > 2) {
            throw new Error("(errid:Watl000059)字段[级别Id(levelId)]的长度不能超过2(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.levelId)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.updUser)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.updDate)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.id_CurrEduCls)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.memo)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.citationId) > 8) {
            throw new Error("(errid:Watl000059)字段[引用Id(citationId)]的长度不能超过8(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.citationId)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.createDate)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.shareId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.shareId)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.pdfContent)(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.socialId) == false && undefined !== pobjSysSocialRelationsEN.socialId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.socialId) === false) {
            throw new Error("(errid:Watl000060)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsEN.socialId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.fullName) == false && undefined !== pobjSysSocialRelationsEN.fullName && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.fullName) === false) {
            throw new Error("(errid:Watl000060)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsEN.fullName)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.nationality) == false && undefined !== pobjSysSocialRelationsEN.nationality && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.nationality) === false) {
            throw new Error("(errid:Watl000060)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsEN.nationality)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.workUnit) == false && undefined !== pobjSysSocialRelationsEN.workUnit && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.workUnit) === false) {
            throw new Error("(errid:Watl000060)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsEN.workUnit)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.major) == false && undefined !== pobjSysSocialRelationsEN.major && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.major) === false) {
            throw new Error("(errid:Watl000060)字段[专业(major)]的值:[$(pobjSysSocialRelationsEN.major)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.achievement) == false && undefined !== pobjSysSocialRelationsEN.achievement && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.achievement) === false) {
            throw new Error("(errid:Watl000060)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsEN.achievement)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsEN.detailedDescription && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.detailedDescription) === false) {
            throw new Error("(errid:Watl000060)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsEN.detailedDescription)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.levelId) == false && undefined !== pobjSysSocialRelationsEN.levelId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.levelId) === false) {
            throw new Error("(errid:Watl000060)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsEN.levelId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updUser) == false && undefined !== pobjSysSocialRelationsEN.updUser && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsEN.updUser)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updDate) == false && undefined !== pobjSysSocialRelationsEN.updDate && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsEN.updDate)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.isSubmit && undefined !== pobjSysSocialRelationsEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjSysSocialRelationsEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjSysSocialRelationsEN.isSubmit)], 非法，应该为布尔型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.okCount && undefined !== pobjSysSocialRelationsEN.okCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjSysSocialRelationsEN.okCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.citationCount && undefined !== pobjSysSocialRelationsEN.citationCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.citationCount) === false) {
            throw new Error("(errid:Watl000060)字段[引用统计(citationCount)]的值:[$(pobjSysSocialRelationsEN.citationCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.versionCount && undefined !== pobjSysSocialRelationsEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjSysSocialRelationsEN.versionCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.memo) == false && undefined !== pobjSysSocialRelationsEN.memo && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysSocialRelationsEN.memo)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.appraiseCount && undefined !== pobjSysSocialRelationsEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(appraiseCount)]的值:[$(pobjSysSocialRelationsEN.appraiseCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.score && undefined !== pobjSysSocialRelationsEN.score && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysSocialRelationsEN.score)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.stuScore && undefined !== pobjSysSocialRelationsEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.stuScore) === false) {
            throw new Error("(errid:Watl000060)字段[学生平均分(stuScore)]的值:[$(pobjSysSocialRelationsEN.stuScore)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.teaScore && undefined !== pobjSysSocialRelationsEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.teaScore) === false) {
            throw new Error("(errid:Watl000060)字段[教师评分(teaScore)]的值:[$(pobjSysSocialRelationsEN.teaScore)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.citationId) == false && undefined !== pobjSysSocialRelationsEN.citationId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.citationId) === false) {
            throw new Error("(errid:Watl000060)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsEN.citationId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.createDate) == false && undefined !== pobjSysSocialRelationsEN.createDate && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjSysSocialRelationsEN.createDate)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.shareId) == false && undefined !== pobjSysSocialRelationsEN.shareId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjSysSocialRelationsEN.shareId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.pdfContent) == false && undefined !== pobjSysSocialRelationsEN.pdfContent && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.pdfContent) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSocialRelationsEN.pdfContent)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        if (null != pobjSysSocialRelationsEN.pdfPageNum && undefined !== pobjSysSocialRelationsEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000060)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSocialRelationsEN.pdfPageNum)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysSocialRelationsEN.SetIsCheckProperty(true);
    }
    exports.SysSocialRelations_CheckPropertyNew = SysSocialRelations_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysSocialRelations_CheckProperty4Update(pobjSysSocialRelationsEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.socialId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.socialId) > 10) {
            throw new Error("(errid:Watl000062)字段[社会Id(socialId)]的长度不能超过10(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.socialId)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.fullName) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.fullName) > 50) {
            throw new Error("(errid:Watl000062)字段[姓名(fullName)]的长度不能超过50(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.fullName)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.nationality) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.nationality) > 50) {
            throw new Error("(errid:Watl000062)字段[国籍(nationality)]的长度不能超过50(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.nationality)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.workUnit) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.workUnit) > 100) {
            throw new Error("(errid:Watl000062)字段[工作单位(workUnit)]的长度不能超过100(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.workUnit)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.major) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.major) > 50) {
            throw new Error("(errid:Watl000062)字段[专业(major)]的长度不能超过50(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.major)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.achievement) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.achievement) > 5000) {
            throw new Error("(errid:Watl000062)字段[成就(achievement)]的长度不能超过5000(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.achievement)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.levelId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.levelId) > 2) {
            throw new Error("(errid:Watl000062)字段[级别Id(levelId)]的长度不能超过2(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.levelId)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.updUser)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.updDate)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.id_CurrEduCls)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.memo)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.citationId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.citationId) > 8) {
            throw new Error("(errid:Watl000062)字段[引用Id(citationId)]的长度不能超过8(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.citationId)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.createDate)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.shareId) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.shareId)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.pdfContent) == false && (0, clsString_js_1.GetStrLen)(pobjSysSocialRelationsEN.pdfContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[Pdf内容(pdfContent)]的长度不能超过2000(In 社会关系表(SysSocialRelations))!值:$(pobjSysSocialRelationsEN.pdfContent)(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.socialId) == false && undefined !== pobjSysSocialRelationsEN.socialId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.socialId) === false) {
            throw new Error("(errid:Watl000063)字段[社会Id(socialId)]的值:[$(pobjSysSocialRelationsEN.socialId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.fullName) == false && undefined !== pobjSysSocialRelationsEN.fullName && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.fullName) === false) {
            throw new Error("(errid:Watl000063)字段[姓名(fullName)]的值:[$(pobjSysSocialRelationsEN.fullName)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.nationality) == false && undefined !== pobjSysSocialRelationsEN.nationality && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.nationality) === false) {
            throw new Error("(errid:Watl000063)字段[国籍(nationality)]的值:[$(pobjSysSocialRelationsEN.nationality)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.workUnit) == false && undefined !== pobjSysSocialRelationsEN.workUnit && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.workUnit) === false) {
            throw new Error("(errid:Watl000063)字段[工作单位(workUnit)]的值:[$(pobjSysSocialRelationsEN.workUnit)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.major) == false && undefined !== pobjSysSocialRelationsEN.major && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.major) === false) {
            throw new Error("(errid:Watl000063)字段[专业(major)]的值:[$(pobjSysSocialRelationsEN.major)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.achievement) == false && undefined !== pobjSysSocialRelationsEN.achievement && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.achievement) === false) {
            throw new Error("(errid:Watl000063)字段[成就(achievement)]的值:[$(pobjSysSocialRelationsEN.achievement)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.detailedDescription) == false && undefined !== pobjSysSocialRelationsEN.detailedDescription && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.detailedDescription) === false) {
            throw new Error("(errid:Watl000063)字段[详细说明(detailedDescription)]的值:[$(pobjSysSocialRelationsEN.detailedDescription)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.levelId) == false && undefined !== pobjSysSocialRelationsEN.levelId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.levelId) === false) {
            throw new Error("(errid:Watl000063)字段[级别Id(levelId)]的值:[$(pobjSysSocialRelationsEN.levelId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updUser) == false && undefined !== pobjSysSocialRelationsEN.updUser && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysSocialRelationsEN.updUser)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.updDate) == false && undefined !== pobjSysSocialRelationsEN.updDate && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysSocialRelationsEN.updDate)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.isSubmit && undefined !== pobjSysSocialRelationsEN.isSubmit && jsString_js_1.tzDataType.isBoolean(pobjSysSocialRelationsEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjSysSocialRelationsEN.isSubmit)], 非法，应该为布尔型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.okCount && undefined !== pobjSysSocialRelationsEN.okCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjSysSocialRelationsEN.okCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.citationCount && undefined !== pobjSysSocialRelationsEN.citationCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.citationCount) === false) {
            throw new Error("(errid:Watl000063)字段[引用统计(citationCount)]的值:[$(pobjSysSocialRelationsEN.citationCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.versionCount && undefined !== pobjSysSocialRelationsEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjSysSocialRelationsEN.versionCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.id_CurrEduCls) == false && undefined !== pobjSysSocialRelationsEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysSocialRelationsEN.id_CurrEduCls)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.memo) == false && undefined !== pobjSysSocialRelationsEN.memo && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysSocialRelationsEN.memo)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.appraiseCount && undefined !== pobjSysSocialRelationsEN.appraiseCount && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.appraiseCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(appraiseCount)]的值:[$(pobjSysSocialRelationsEN.appraiseCount)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.score && undefined !== pobjSysSocialRelationsEN.score && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysSocialRelationsEN.score)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.stuScore && undefined !== pobjSysSocialRelationsEN.stuScore && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.stuScore) === false) {
            throw new Error("(errid:Watl000063)字段[学生平均分(stuScore)]的值:[$(pobjSysSocialRelationsEN.stuScore)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.teaScore && undefined !== pobjSysSocialRelationsEN.teaScore && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.teaScore) === false) {
            throw new Error("(errid:Watl000063)字段[教师评分(teaScore)]的值:[$(pobjSysSocialRelationsEN.teaScore)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.citationId) == false && undefined !== pobjSysSocialRelationsEN.citationId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.citationId) === false) {
            throw new Error("(errid:Watl000063)字段[引用Id(citationId)]的值:[$(pobjSysSocialRelationsEN.citationId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.createDate) == false && undefined !== pobjSysSocialRelationsEN.createDate && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjSysSocialRelationsEN.createDate)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.shareId) == false && undefined !== pobjSysSocialRelationsEN.shareId && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjSysSocialRelationsEN.shareId)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.pdfContent) == false && undefined !== pobjSysSocialRelationsEN.pdfContent && jsString_js_1.tzDataType.isString(pobjSysSocialRelationsEN.pdfContent) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf内容(pdfContent)]的值:[$(pobjSysSocialRelationsEN.pdfContent)], 非法，应该为字符型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        if (null != pobjSysSocialRelationsEN.pdfPageNum && undefined !== pobjSysSocialRelationsEN.pdfPageNum && jsString_js_1.tzDataType.isNumber(pobjSysSocialRelationsEN.pdfPageNum) === false) {
            throw new Error("(errid:Watl000063)字段[Pdf页码(pdfPageNum)]的值:[$(pobjSysSocialRelationsEN.pdfPageNum)], 非法，应该为数值型(In 社会关系表(SysSocialRelations))!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjSysSocialRelationsEN.socialId) === true) {
            throw new Error("(errid:Watl000064)字段[社会Id]不能为空(In 社会关系表)!(clsSysSocialRelationsBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysSocialRelationsEN.SetIsCheckProperty(true);
    }
    exports.SysSocialRelations_CheckProperty4Update = SysSocialRelations_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSocialRelations_GetJSONStrByObj(pobjSysSocialRelationsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysSocialRelationsEN.sf_UpdFldSetStr = pobjSysSocialRelationsEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysSocialRelationsEN);
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
    exports.SysSocialRelations_GetJSONStrByObj = SysSocialRelations_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysSocialRelations_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysSocialRelationsObjLst = new Array();
        if (strJSON === "") {
            return arrSysSocialRelationsObjLst;
        }
        try {
            arrSysSocialRelationsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysSocialRelationsObjLst;
        }
        return arrSysSocialRelationsObjLst;
    }
    exports.SysSocialRelations_GetObjLstByJSONStr = SysSocialRelations_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysSocialRelationsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysSocialRelations_GetObjLstByJSONObjLst(arrSysSocialRelationsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysSocialRelationsObjLst = new Array();
        for (const objInFor of arrSysSocialRelationsObjLstS) {
            const obj1 = SysSocialRelations_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysSocialRelationsObjLst.push(obj1);
        }
        return arrSysSocialRelationsObjLst;
    }
    exports.SysSocialRelations_GetObjLstByJSONObjLst = SysSocialRelations_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysSocialRelations_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysSocialRelationsEN = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
        if (strJSON === "") {
            return pobjSysSocialRelationsEN;
        }
        try {
            pobjSysSocialRelationsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysSocialRelationsEN;
        }
        return pobjSysSocialRelationsEN;
    }
    exports.SysSocialRelations_GetObjByJSONStr = SysSocialRelations_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysSocialRelations_GetCombineCondition(objSysSocialRelations_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId) == true) {
            const strComparisonOp_SocialId = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_SocialId, objSysSocialRelations_Cond.socialId, strComparisonOp_SocialId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_FullName) == true) {
            const strComparisonOp_FullName = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_FullName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_FullName, objSysSocialRelations_Cond.fullName, strComparisonOp_FullName);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Nationality) == true) {
            const strComparisonOp_Nationality = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Nationality];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Nationality, objSysSocialRelations_Cond.nationality, strComparisonOp_Nationality);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_WorkUnit) == true) {
            const strComparisonOp_WorkUnit = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_WorkUnit];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_WorkUnit, objSysSocialRelations_Cond.workUnit, strComparisonOp_WorkUnit);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Major) == true) {
            const strComparisonOp_Major = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Major];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Major, objSysSocialRelations_Cond.major, strComparisonOp_Major);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Achievement) == true) {
            const strComparisonOp_Achievement = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Achievement];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Achievement, objSysSocialRelations_Cond.achievement, strComparisonOp_Achievement);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_LevelId) == true) {
            const strComparisonOp_LevelId = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_LevelId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_LevelId, objSysSocialRelations_Cond.levelId, strComparisonOp_LevelId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdUser, objSysSocialRelations_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_UpdDate, objSysSocialRelations_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_IsSubmit) == true) {
            if (objSysSocialRelations_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_OkCount, objSysSocialRelations_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationCount) == true) {
            const strComparisonOp_CitationCount = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationCount, objSysSocialRelations_Cond.citationCount, strComparisonOp_CitationCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_VersionCount, objSysSocialRelations_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_id_CurrEduCls, objSysSocialRelations_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_Memo, objSysSocialRelations_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_AppraiseCount, objSysSocialRelations_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_score) == true) {
            const strComparisonOp_score = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_score, objSysSocialRelations_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_StuScore, objSysSocialRelations_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_TeaScore, objSysSocialRelations_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationId) == true) {
            const strComparisonOp_CitationId = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CitationId, objSysSocialRelations_Cond.citationId, strComparisonOp_CitationId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_CreateDate, objSysSocialRelations_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_ShareId, objSysSocialRelations_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfContent) == true) {
            const strComparisonOp_PdfContent = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfContent, objSysSocialRelations_Cond.pdfContent, strComparisonOp_PdfContent);
        }
        if (Object.prototype.hasOwnProperty.call(objSysSocialRelations_Cond.dicFldComparisonOp, clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfPageNum) == true) {
            const strComparisonOp_PdfPageNum = objSysSocialRelations_Cond.dicFldComparisonOp[clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN.con_PdfPageNum, objSysSocialRelations_Cond.pdfPageNum, strComparisonOp_PdfPageNum);
        }
        return strWhereCond;
    }
    exports.SysSocialRelations_GetCombineCondition = SysSocialRelations_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysSocialRelations(社会关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strSocialId: 社会Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSocialRelations_GetUniCondStr_SocialId(objSysSocialRelationsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SocialId = '{0}'", objSysSocialRelationsEN.socialId);
        return strWhereCond;
    }
    exports.SysSocialRelations_GetUniCondStr_SocialId = SysSocialRelations_GetUniCondStr_SocialId;
    /**
    *获取唯一性条件串(Uniqueness)--SysSocialRelations(社会关系表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strSocialId: 社会Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysSocialRelations_GetUniCondStr4Update_SocialId(objSysSocialRelationsEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and SocialId <> '{0}'", objSysSocialRelationsEN.socialId);
        strWhereCond += (0, clsString_js_1.Format)(" and SocialId = '{0}'", objSysSocialRelationsEN.socialId);
        return strWhereCond;
    }
    exports.SysSocialRelations_GetUniCondStr4Update_SocialId = SysSocialRelations_GetUniCondStr4Update_SocialId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysSocialRelationsENS:源对象
     * @param objSysSocialRelationsENT:目标对象
    */
    function SysSocialRelations_CopyObjTo(objSysSocialRelationsENS, objSysSocialRelationsENT) {
        objSysSocialRelationsENT.socialId = objSysSocialRelationsENS.socialId; //社会Id
        objSysSocialRelationsENT.fullName = objSysSocialRelationsENS.fullName; //姓名
        objSysSocialRelationsENT.nationality = objSysSocialRelationsENS.nationality; //国籍
        objSysSocialRelationsENT.workUnit = objSysSocialRelationsENS.workUnit; //工作单位
        objSysSocialRelationsENT.major = objSysSocialRelationsENS.major; //专业
        objSysSocialRelationsENT.achievement = objSysSocialRelationsENS.achievement; //成就
        objSysSocialRelationsENT.detailedDescription = objSysSocialRelationsENS.detailedDescription; //详细说明
        objSysSocialRelationsENT.levelId = objSysSocialRelationsENS.levelId; //级别Id
        objSysSocialRelationsENT.updUser = objSysSocialRelationsENS.updUser; //修改人
        objSysSocialRelationsENT.updDate = objSysSocialRelationsENS.updDate; //修改日期
        objSysSocialRelationsENT.isSubmit = objSysSocialRelationsENS.isSubmit; //是否提交
        objSysSocialRelationsENT.okCount = objSysSocialRelationsENS.okCount; //点赞统计
        objSysSocialRelationsENT.citationCount = objSysSocialRelationsENS.citationCount; //引用统计
        objSysSocialRelationsENT.versionCount = objSysSocialRelationsENS.versionCount; //版本统计
        objSysSocialRelationsENT.id_CurrEduCls = objSysSocialRelationsENS.id_CurrEduCls; //教学班流水号
        objSysSocialRelationsENT.memo = objSysSocialRelationsENS.memo; //备注
        objSysSocialRelationsENT.appraiseCount = objSysSocialRelationsENS.appraiseCount; //评论数
        objSysSocialRelationsENT.score = objSysSocialRelationsENS.score; //评分
        objSysSocialRelationsENT.stuScore = objSysSocialRelationsENS.stuScore; //学生平均分
        objSysSocialRelationsENT.teaScore = objSysSocialRelationsENS.teaScore; //教师评分
        objSysSocialRelationsENT.citationId = objSysSocialRelationsENS.citationId; //引用Id
        objSysSocialRelationsENT.createDate = objSysSocialRelationsENS.createDate; //建立日期
        objSysSocialRelationsENT.shareId = objSysSocialRelationsENS.shareId; //分享Id
        objSysSocialRelationsENT.pdfContent = objSysSocialRelationsENS.pdfContent; //Pdf内容
        objSysSocialRelationsENT.pdfPageNum = objSysSocialRelationsENS.pdfPageNum; //Pdf页码
        objSysSocialRelationsENT.sf_UpdFldSetStr = objSysSocialRelationsENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysSocialRelations_CopyObjTo = SysSocialRelations_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysSocialRelationsENS:源对象
     * @param objSysSocialRelationsENT:目标对象
    */
    function SysSocialRelations_GetObjFromJsonObj(objSysSocialRelationsENS) {
        const objSysSocialRelationsENT = new clsSysSocialRelationsEN_js_1.clsSysSocialRelationsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysSocialRelationsENT, objSysSocialRelationsENS);
        return objSysSocialRelationsENT;
    }
    exports.SysSocialRelations_GetObjFromJsonObj = SysSocialRelations_GetObjFromJsonObj;
});
