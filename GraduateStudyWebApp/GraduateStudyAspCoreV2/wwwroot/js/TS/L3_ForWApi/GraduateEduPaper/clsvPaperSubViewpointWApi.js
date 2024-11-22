/**
* 类名:clsvPaperSubViewpointWApi
* 表名:vPaperSubViewpoint(01120551)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:54:36
* 生成者:pyf
* 生成服务器IP:
工程名称:问卷调查(0112)
CM工程:研究生论文学习(变量首字母小写)-全部函数集
* 相关数据库:103.116.76.183,9433EduHigh_Jsie
* PrjDataBaseId:0170
模块中文名:研培论文(GraduateEduPaper)
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperSubViewpoint_GetObjFromJsonObj = exports.vPaperSubViewpoint_CopyObjTo = exports.vPaperSubViewpoint_GetCombineCondition = exports.vPaperSubViewpoint_GetObjByJSONStr = exports.vPaperSubViewpoint_GetObjLstByJSONObjLst = exports.vPaperSubViewpoint_GetObjLstByJSONStr = exports.vPaperSubViewpoint_GetJSONStrByObj = exports.vPaperSubViewpoint_ReFreshThisCache = exports.vPaperSubViewpoint_GetWebApiUrl = exports.vPaperSubViewpoint_GetRecCountByCond_Cache = exports.vPaperSubViewpoint_GetRecCountByCondAsync = exports.vPaperSubViewpoint_IsExistAsync = exports.vPaperSubViewpoint_IsExist_Cache = exports.vPaperSubViewpoint_IsExist = exports.vPaperSubViewpoint_IsExistRecordAsync = exports.vPaperSubViewpoint_IsExistRecord_Cache = exports.vPaperSubViewpoint_GetObjLstByPagerAsync = exports.vPaperSubViewpoint_GetObjLstByPager_Cache = exports.vPaperSubViewpoint_GetObjLstByRange = exports.vPaperSubViewpoint_GetObjLstByRangeAsync = exports.vPaperSubViewpoint_GetTopObjLstAsync = exports.vPaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache = exports.vPaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync = exports.vPaperSubViewpoint_GetSubObjLst_Cache = exports.vPaperSubViewpoint_GetObjLst_PureCache = exports.vPaperSubViewpoint_GetObjLst_Cache = exports.vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache = exports.vPaperSubViewpoint_GetObjLst_sessionStorage = exports.vPaperSubViewpoint_GetObjLstAsync = exports.vPaperSubViewpoint_GetObjLst_localStorage_PureCache = exports.vPaperSubViewpoint_GetObjLst_localStorage = exports.vPaperSubViewpoint_GetObjLst_ClientCache = exports.vPaperSubViewpoint_GetFirstObjAsync = exports.vPaperSubViewpoint_GetFirstID = exports.vPaperSubViewpoint_GetFirstIDAsync = exports.vPaperSubViewpoint_funcKey = exports.vPaperSubViewpoint_FilterFunByKey = exports.vPaperSubViewpoint_SortFunByKey = exports.vPaperSubViewpoint_SortFun_Defa_2Fld = exports.vPaperSubViewpoint_SortFun_Defa = exports.vPaperSubViewpoint_func = exports.vPaperSubViewpoint_GetObjBySubViewpointId_localStorage = exports.vPaperSubViewpoint_GetObjBySubViewpointId_Cache = exports.vPaperSubViewpoint_GetObjBySubViewpointIdAsync = exports.vPaperSubViewpoint_ConstructorName = exports.vPaperSubViewpoint_Controller = void 0;
    /**
     * v子观点表(vPaperSubViewpoint)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvPaperSubViewpointEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperSubViewpoint_Controller = "vPaperSubViewpointApi";
    exports.vPaperSubViewpoint_ConstructorName = "vPaperSubViewpoint";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strSubViewpointId:关键字
    * @returns 对象
    **/
    async function vPaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId) {
        const strThisFuncName = "GetObjBySubViewpointIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubViewpointId]不能为空！(In clsvPaperSubViewpointWApi.GetObjBySubViewpointIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.GetObjBySubViewpointIdAsync)", strSubViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjBySubViewpointId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strSubViewpointId": strSubViewpointId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvPaperSubViewpoint = vPaperSubViewpoint_GetObjFromJsonObj(returnObj);
                return objvPaperSubViewpoint;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetObjBySubViewpointIdAsync = vPaperSubViewpoint_GetObjBySubViewpointIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strSubViewpointId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjBySubViewpointId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubViewpointId]不能为空！(In clsvPaperSubViewpointWApi.GetObjBySubViewpointId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.GetObjBySubViewpointId_Cache)", strSubViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache.filter(x => x.subViewpointId == strSubViewpointId);
            let objvPaperSubViewpoint;
            if (arrvPaperSubViewpoint_Sel.length > 0) {
                objvPaperSubViewpoint = arrvPaperSubViewpoint_Sel[0];
                return objvPaperSubViewpoint;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvPaperSubViewpoint_Const = await vPaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
                    if (objvPaperSubViewpoint_Const != null) {
                        vPaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls);
                        return objvPaperSubViewpoint_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vPaperSubViewpoint_GetObjBySubViewpointId_Cache = vPaperSubViewpoint_GetObjBySubViewpointId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strSubViewpointId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpoint_GetObjBySubViewpointId_localStorage(strSubViewpointId) {
        const strThisFuncName = "GetObjBySubViewpointId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strSubViewpointId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strSubViewpointId]不能为空！(In clsvPaperSubViewpointWApi.GetObjBySubViewpointId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strSubViewpointId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strSubViewpointId]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.GetObjBySubViewpointId_localStorage)", strSubViewpointId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strSubViewpointId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvPaperSubViewpoint_Cache = JSON.parse(strTempObj);
            return objvPaperSubViewpoint_Cache;
        }
        try {
            const objvPaperSubViewpoint = await vPaperSubViewpoint_GetObjBySubViewpointIdAsync(strSubViewpointId);
            if (objvPaperSubViewpoint != null) {
                localStorage.setItem(strKey, JSON.stringify(objvPaperSubViewpoint));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvPaperSubViewpoint;
            }
            return objvPaperSubViewpoint;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strSubViewpointId, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vPaperSubViewpoint_GetObjBySubViewpointId_localStorage = vPaperSubViewpoint_GetObjBySubViewpointId_localStorage;
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
    async function vPaperSubViewpoint_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvPaperSubViewpointWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strSubViewpointId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvPaperSubViewpoint = await vPaperSubViewpoint_GetObjBySubViewpointId_Cache(strSubViewpointId, strid_CurrEduCls_C);
        if (objvPaperSubViewpoint == null)
            return "";
        if (objvPaperSubViewpoint.GetFldValue(strOutFldName) == null)
            return "";
        return objvPaperSubViewpoint.GetFldValue(strOutFldName).toString();
    }
    exports.vPaperSubViewpoint_func = vPaperSubViewpoint_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpoint_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.subViewpointId.localeCompare(b.subViewpointId);
    }
    exports.vPaperSubViewpoint_SortFun_Defa = vPaperSubViewpoint_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpoint_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperRWId == b.paperRWId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.paperRWId.localeCompare(b.paperRWId);
    }
    exports.vPaperSubViewpoint_SortFun_Defa_2Fld = vPaperSubViewpoint_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpoint_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId:
                    return (a, b) => {
                        return a.subViewpointId.localeCompare(b.subViewpointId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId:
                    return (a, b) => {
                        if (a.paperRWId == null)
                            return -1;
                        if (b.paperRWId == null)
                            return 1;
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId:
                    return (a, b) => {
                        if (a.sectionId == null)
                            return -1;
                        if (b.sectionId == null)
                            return 1;
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionName:
                    return (a, b) => {
                        if (a.sectionName == null)
                            return -1;
                        if (b.sectionName == null)
                            return 1;
                        return a.sectionName.localeCompare(b.sectionName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId:
                    return (a, b) => {
                        return a.subViewpointTypeId.localeCompare(b.subViewpointTypeId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeName:
                    return (a, b) => {
                        if (a.subViewpointTypeName == null)
                            return -1;
                        if (b.subViewpointTypeName == null)
                            return 1;
                        return a.subViewpointTypeName.localeCompare(b.subViewpointTypeName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_DefaTitle:
                    return (a, b) => {
                        if (a.defaTitle == null)
                            return -1;
                        if (b.defaTitle == null)
                            return 1;
                        return a.defaTitle.localeCompare(b.defaTitle);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_RWTitle:
                    return (a, b) => {
                        if (a.rwTitle == null)
                            return -1;
                        if (b.rwTitle == null)
                            return 1;
                        return a.rwTitle.localeCompare(b.rwTitle);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointContent:
                    return (a, b) => {
                        if (a.subViewpointContent == null)
                            return -1;
                        if (b.subViewpointContent == null)
                            return 1;
                        return a.subViewpointContent.localeCompare(b.subViewpointContent);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId:
                    return (a, b) => {
                        if (a.explainTypeId == null)
                            return -1;
                        if (b.explainTypeId == null)
                            return 1;
                        return a.explainTypeId.localeCompare(b.explainTypeId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeName:
                    return (a, b) => {
                        if (a.explainTypeName == null)
                            return -1;
                        if (b.explainTypeName == null)
                            return 1;
                        return a.explainTypeName.localeCompare(b.explainTypeName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainContent:
                    return (a, b) => {
                        if (a.explainContent == null)
                            return -1;
                        if (b.explainContent == null)
                            return 1;
                        return a.explainContent.localeCompare(b.explainContent);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_LiteratureSourcesId:
                    return (a, b) => {
                        if (a.literatureSourcesId == null)
                            return -1;
                        if (b.literatureSourcesId == null)
                            return 1;
                        return a.literatureSourcesId.localeCompare(b.literatureSourcesId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PageNumber:
                    return (a, b) => {
                        return a.pageNumber - b.pageNumber;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperLineNum:
                    return (a, b) => {
                        return a.paperLineNum - b.paperLineNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperPageNum:
                    return (a, b) => {
                        return a.paperPageNum - b.paperPageNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AppraiseCount:
                    return (a, b) => {
                        return a.appraiseCount - b.appraiseCount;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_StuScore:
                    return (a, b) => {
                        return a.stuScore - b.stuScore;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TeaScore:
                    return (a, b) => {
                        return a.teaScore - b.teaScore;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ShareId:
                    return (a, b) => {
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId:
                    return (a, b) => {
                        if (a.topicId == null)
                            return -1;
                        if (b.topicId == null)
                            return 1;
                        return a.topicId.localeCompare(b.topicId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesId:
                    return (a, b) => {
                        return a.attitudesId.localeCompare(b.attitudesId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesName:
                    return (a, b) => {
                        if (a.attitudesName == null)
                            return -1;
                        if (b.attitudesName == null)
                            return 1;
                        return a.attitudesName.localeCompare(b.attitudesName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionOrderNum:
                    return (a, b) => {
                        return a.sectionOrderNum - b.sectionOrderNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
                    return (a, b) => {
                        return a.subViewpointTypeOrderNum - b.subViewpointTypeOrderNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpoint]中不存在！(in ${exports.vPaperSubViewpoint_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId:
                    return (a, b) => {
                        return b.subViewpointId.localeCompare(a.subViewpointId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId:
                    return (a, b) => {
                        if (b.paperRWId == null)
                            return -1;
                        if (a.paperRWId == null)
                            return 1;
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId:
                    return (a, b) => {
                        if (b.sectionId == null)
                            return -1;
                        if (a.sectionId == null)
                            return 1;
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionName:
                    return (a, b) => {
                        if (b.sectionName == null)
                            return -1;
                        if (a.sectionName == null)
                            return 1;
                        return b.sectionName.localeCompare(a.sectionName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId:
                    return (a, b) => {
                        return b.subViewpointTypeId.localeCompare(a.subViewpointTypeId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeName:
                    return (a, b) => {
                        if (b.subViewpointTypeName == null)
                            return -1;
                        if (a.subViewpointTypeName == null)
                            return 1;
                        return b.subViewpointTypeName.localeCompare(a.subViewpointTypeName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_DefaTitle:
                    return (a, b) => {
                        if (b.defaTitle == null)
                            return -1;
                        if (a.defaTitle == null)
                            return 1;
                        return b.defaTitle.localeCompare(a.defaTitle);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_RWTitle:
                    return (a, b) => {
                        if (b.rwTitle == null)
                            return -1;
                        if (a.rwTitle == null)
                            return 1;
                        return b.rwTitle.localeCompare(a.rwTitle);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointContent:
                    return (a, b) => {
                        if (b.subViewpointContent == null)
                            return -1;
                        if (a.subViewpointContent == null)
                            return 1;
                        return b.subViewpointContent.localeCompare(a.subViewpointContent);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId:
                    return (a, b) => {
                        if (b.explainTypeId == null)
                            return -1;
                        if (a.explainTypeId == null)
                            return 1;
                        return b.explainTypeId.localeCompare(a.explainTypeId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeName:
                    return (a, b) => {
                        if (b.explainTypeName == null)
                            return -1;
                        if (a.explainTypeName == null)
                            return 1;
                        return b.explainTypeName.localeCompare(a.explainTypeName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainContent:
                    return (a, b) => {
                        if (b.explainContent == null)
                            return -1;
                        if (a.explainContent == null)
                            return 1;
                        return b.explainContent.localeCompare(a.explainContent);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_LiteratureSourcesId:
                    return (a, b) => {
                        if (b.literatureSourcesId == null)
                            return -1;
                        if (a.literatureSourcesId == null)
                            return 1;
                        return b.literatureSourcesId.localeCompare(a.literatureSourcesId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PageNumber:
                    return (a, b) => {
                        return b.pageNumber - a.pageNumber;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperLineNum:
                    return (a, b) => {
                        return b.paperLineNum - a.paperLineNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperPageNum:
                    return (a, b) => {
                        return b.paperPageNum - a.paperPageNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AppraiseCount:
                    return (a, b) => {
                        return b.appraiseCount - a.appraiseCount;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_StuScore:
                    return (a, b) => {
                        return b.stuScore - a.stuScore;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TeaScore:
                    return (a, b) => {
                        return b.teaScore - a.teaScore;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ShareId:
                    return (a, b) => {
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId:
                    return (a, b) => {
                        if (b.topicId == null)
                            return -1;
                        if (a.topicId == null)
                            return 1;
                        return b.topicId.localeCompare(a.topicId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesId:
                    return (a, b) => {
                        return b.attitudesId.localeCompare(a.attitudesId);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesName:
                    return (a, b) => {
                        if (b.attitudesName == null)
                            return -1;
                        if (a.attitudesName == null)
                            return 1;
                        return b.attitudesName.localeCompare(a.attitudesName);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionOrderNum:
                    return (a, b) => {
                        return b.sectionOrderNum - a.sectionOrderNum;
                    };
                case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
                    return (a, b) => {
                        return b.subViewpointTypeOrderNum - a.subViewpointTypeOrderNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpoint]中不存在！(in ${exports.vPaperSubViewpoint_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperSubViewpoint_SortFunByKey = vPaperSubViewpoint_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperSubViewpoint_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId:
                return (obj) => {
                    return obj.subViewpointId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionName:
                return (obj) => {
                    return obj.sectionName === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId:
                return (obj) => {
                    return obj.subViewpointTypeId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeName:
                return (obj) => {
                    return obj.subViewpointTypeName === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_DefaTitle:
                return (obj) => {
                    return obj.defaTitle === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_RWTitle:
                return (obj) => {
                    return obj.rwTitle === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointContent:
                return (obj) => {
                    return obj.subViewpointContent === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId:
                return (obj) => {
                    return obj.explainTypeId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeName:
                return (obj) => {
                    return obj.explainTypeName === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainContent:
                return (obj) => {
                    return obj.explainContent === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_LiteratureSourcesId:
                return (obj) => {
                    return obj.literatureSourcesId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PageNumber:
                return (obj) => {
                    return obj.pageNumber === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperLineNum:
                return (obj) => {
                    return obj.paperLineNum === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperPageNum:
                return (obj) => {
                    return obj.paperPageNum === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AppraiseCount:
                return (obj) => {
                    return obj.appraiseCount === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_StuScore:
                return (obj) => {
                    return obj.stuScore === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TeaScore:
                return (obj) => {
                    return obj.teaScore === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId:
                return (obj) => {
                    return obj.topicId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesId:
                return (obj) => {
                    return obj.attitudesId === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesName:
                return (obj) => {
                    return obj.attitudesName === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionOrderNum:
                return (obj) => {
                    return obj.sectionOrderNum === value;
                };
            case clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum:
                return (obj) => {
                    return obj.subViewpointTypeOrderNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpoint]中不存在！(in ${exports.vPaperSubViewpoint_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperSubViewpoint_FilterFunByKey = vPaperSubViewpoint_FilterFunByKey;
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
    async function vPaperSubViewpoint_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvPaperSubViewpointWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvPaperSubViewpointWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvPaperSubViewpoint = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvPaperSubViewpoint == null)
            return [];
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvPaperSubViewpoint_Sel.length == 0)
            return [];
        return arrvPaperSubViewpoint_Sel.map(x => x.subViewpointId);
    }
    exports.vPaperSubViewpoint_funcKey = vPaperSubViewpoint_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperSubViewpoint_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetFirstIDAsync = vPaperSubViewpoint_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperSubViewpoint_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetFirstID = vPaperSubViewpoint_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperSubViewpoint_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
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
                const objvPaperSubViewpoint = vPaperSubViewpoint_GetObjFromJsonObj(returnObj);
                return objvPaperSubViewpoint;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetFirstObjAsync = vPaperSubViewpoint_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvPaperSubViewpointExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvPaperSubViewpointObjLst_T = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointExObjLst_Cache);
            return arrvPaperSubViewpointObjLst_T;
        }
        try {
            const arrvPaperSubViewpointExObjLst = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvPaperSubViewpointExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpoint_GetObjLst_ClientCache = vPaperSubViewpoint_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperSubViewpointExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperSubViewpointObjLst_T = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointExObjLst_Cache);
            return arrvPaperSubViewpointObjLst_T;
        }
        try {
            const arrvPaperSubViewpointExObjLst = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpoint_GetObjLst_localStorage = vPaperSubViewpoint_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperSubViewpointObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSubViewpointObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperSubViewpoint_GetObjLst_localStorage_PureCache = vPaperSubViewpoint_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubViewpoint_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetObjLstAsync = vPaperSubViewpoint_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperSubViewpointExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperSubViewpointObjLst_T = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointExObjLst_Cache);
            return arrvPaperSubViewpointObjLst_T;
        }
        try {
            const arrvPaperSubViewpointExObjLst = await vPaperSubViewpoint_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpoint_GetObjLst_sessionStorage = vPaperSubViewpoint_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperSubViewpointObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSubViewpointObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache = vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvPaperSubViewpointWApi.vPaperSubViewpoint_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvPaperSubViewpointWApi.vPaperSubViewpoint_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvPaperSubViewpointObjLst_Cache;
        switch (clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvPaperSubViewpointObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointObjLst_Cache);
        return arrvPaperSubViewpointObjLst_Cache;
    }
    exports.vPaperSubViewpoint_GetObjLst_Cache = vPaperSubViewpoint_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpoint_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvPaperSubViewpointObjLst_Cache;
        switch (clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperSubViewpointObjLst_Cache = null;
                break;
            default:
                arrvPaperSubViewpointObjLst_Cache = null;
                break;
        }
        return arrvPaperSubViewpointObjLst_Cache;
    }
    exports.vPaperSubViewpoint_GetObjLst_PureCache = vPaperSubViewpoint_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrSubViewpointId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperSubViewpoint_GetSubObjLst_Cache(objvPaperSubViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache;
        if (objvPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objvPaperSubViewpoint_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpoint_Sel;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSubViewpoint_Cond), exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpoint_GetSubObjLst_Cache = vPaperSubViewpoint_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrSubViewpointId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync(arrSubViewpointId) {
        const strThisFuncName = "GetObjLstBySubViewpointIdLstAsync";
        const strAction = "GetObjLstBySubViewpointIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrSubViewpointId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync = vPaperSubViewpoint_GetObjLstBySubViewpointIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrSubViewpointIdLst:关键字列表
     * @returns 对象列表
    */
    async function vPaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache(arrSubViewpointIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstBySubViewpointIdLst_Cache";
        try {
            const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
            const arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache.filter(x => arrSubViewpointIdLst.indexOf(x.subViewpointId) > -1);
            return arrvPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrSubViewpointIdLst.join(","), exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vPaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache = vPaperSubViewpoint_GetObjLstBySubViewpointIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubViewpoint_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetTopObjLstAsync = vPaperSubViewpoint_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubViewpoint_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetObjLstByRangeAsync = vPaperSubViewpoint_GetObjLstByRangeAsync;
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
    async function vPaperSubViewpoint_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetObjLstByRange = vPaperSubViewpoint_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSubViewpoint_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperSubViewpointObjLst_Cache.length == 0)
            return arrvPaperSubViewpointObjLst_Cache;
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperSubViewpoint_Cond = new clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpoint_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperSubViewpointWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpoint_Sel.length == 0)
                return arrvPaperSubViewpoint_Sel;
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
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(vPaperSubViewpoint_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.slice(intStart, intEnd);
            return arrvPaperSubViewpoint_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpoint_GetObjLstByPager_Cache = vPaperSubViewpoint_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubViewpoint_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetObjLstByPagerAsync = vPaperSubViewpoint_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrSubViewpointId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperSubViewpoint_IsExistRecord_Cache(objvPaperSubViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperSubViewpointObjLst_Cache == null)
            return false;
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache;
        if (objvPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objvPaperSubViewpoint_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpoint_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpoint_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaperSubViewpoint_Cond), exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vPaperSubViewpoint_IsExistRecord_Cache = vPaperSubViewpoint_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperSubViewpoint_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_IsExistRecordAsync = vPaperSubViewpoint_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strSubViewpointId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperSubViewpoint_IsExist(strSubViewpointId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "SubViewpointId": strSubViewpointId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_IsExist = vPaperSubViewpoint_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strSubViewpointId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpoint_IsExist_Cache(strSubViewpointId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperSubViewpointObjLst_Cache == null)
            return false;
        try {
            const arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache.filter(x => x.subViewpointId == strSubViewpointId);
            if (arrvPaperSubViewpoint_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strSubViewpointId, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vPaperSubViewpoint_IsExist_Cache = vPaperSubViewpoint_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strSubViewpointId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperSubViewpoint_IsExistAsync(strSubViewpointId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strSubViewpointId": strSubViewpointId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_IsExistAsync = vPaperSubViewpoint_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperSubViewpoint_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpoint_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpoint_GetRecCountByCondAsync = vPaperSubViewpoint_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvPaperSubViewpoint_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vPaperSubViewpoint_GetRecCountByCond_Cache(objvPaperSubViewpoint_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvPaperSubViewpointObjLst_Cache = await vPaperSubViewpoint_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperSubViewpointObjLst_Cache == null)
            return 0;
        let arrvPaperSubViewpoint_Sel = arrvPaperSubViewpointObjLst_Cache;
        if (objvPaperSubViewpoint_Cond.sf_FldComparisonOp == null || objvPaperSubViewpoint_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpoint_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpoint_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpoint_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpoint_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpoint_Sel = arrvPaperSubViewpoint_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSubViewpoint_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSubViewpoint_Cond), exports.vPaperSubViewpoint_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperSubViewpoint_GetRecCountByCond_Cache = vPaperSubViewpoint_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperSubViewpoint_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperSubViewpoint_GetWebApiUrl = vPaperSubViewpoint_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vPaperSubViewpoint_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN._CurrTabName, strid_CurrEduCls);
            switch (clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.CacheModeId) {
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
    exports.vPaperSubViewpoint_ReFreshThisCache = vPaperSubViewpoint_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubViewpoint_GetJSONStrByObj(pobjvPaperSubViewpointEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperSubViewpointEN);
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
    exports.vPaperSubViewpoint_GetJSONStrByObj = vPaperSubViewpoint_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubViewpoint_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperSubViewpointObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperSubViewpointObjLst;
        }
        try {
            arrvPaperSubViewpointObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperSubViewpointObjLst;
        }
        return arrvPaperSubViewpointObjLst;
    }
    exports.vPaperSubViewpoint_GetObjLstByJSONStr = vPaperSubViewpoint_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperSubViewpointObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubViewpoint_GetObjLstByJSONObjLst(arrvPaperSubViewpointObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperSubViewpointObjLst = new Array();
        for (const objInFor of arrvPaperSubViewpointObjLstS) {
            const obj1 = vPaperSubViewpoint_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperSubViewpointObjLst.push(obj1);
        }
        return arrvPaperSubViewpointObjLst;
    }
    exports.vPaperSubViewpoint_GetObjLstByJSONObjLst = vPaperSubViewpoint_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubViewpoint_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperSubViewpointEN = new clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN();
        if (strJSON === "") {
            return pobjvPaperSubViewpointEN;
        }
        try {
            pobjvPaperSubViewpointEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperSubViewpointEN;
        }
        return pobjvPaperSubViewpointEN;
    }
    exports.vPaperSubViewpoint_GetObjByJSONStr = vPaperSubViewpoint_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperSubViewpoint_GetCombineCondition(objvPaperSubViewpoint_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId) == true) {
            const strComparisonOp_SubViewpointId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointId, objvPaperSubViewpoint_Cond.subViewpointId, strComparisonOp_SubViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperRWId, objvPaperSubViewpoint_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperId, objvPaperSubViewpoint_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperTitle, objvPaperSubViewpoint_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsSubmit) == true) {
            if (objvPaperSubViewpoint_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_id_CurrEduCls, objvPaperSubViewpoint_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UserId, objvPaperSubViewpoint_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionId, objvPaperSubViewpoint_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionName) == true) {
            const strComparisonOp_SectionName = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionName, objvPaperSubViewpoint_Cond.sectionName, strComparisonOp_SectionName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId) == true) {
            const strComparisonOp_SubViewpointTypeId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeId, objvPaperSubViewpoint_Cond.subViewpointTypeId, strComparisonOp_SubViewpointTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeName) == true) {
            const strComparisonOp_SubViewpointTypeName = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeName, objvPaperSubViewpoint_Cond.subViewpointTypeName, strComparisonOp_SubViewpointTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_DefaTitle) == true) {
            const strComparisonOp_DefaTitle = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_DefaTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_DefaTitle, objvPaperSubViewpoint_Cond.defaTitle, strComparisonOp_DefaTitle);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_RWTitle) == true) {
            const strComparisonOp_RWTitle = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_RWTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_RWTitle, objvPaperSubViewpoint_Cond.rwTitle, strComparisonOp_RWTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId) == true) {
            const strComparisonOp_ExplainTypeId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeId, objvPaperSubViewpoint_Cond.explainTypeId, strComparisonOp_ExplainTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeName) == true) {
            const strComparisonOp_ExplainTypeName = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainTypeName, objvPaperSubViewpoint_Cond.explainTypeName, strComparisonOp_ExplainTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainContent) == true) {
            const strComparisonOp_ExplainContent = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ExplainContent, objvPaperSubViewpoint_Cond.explainContent, strComparisonOp_ExplainContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsPublic) == true) {
            if (objvPaperSubViewpoint_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_LiteratureSourcesId) == true) {
            const strComparisonOp_LiteratureSourcesId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_LiteratureSourcesId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_LiteratureSourcesId, objvPaperSubViewpoint_Cond.literatureSourcesId, strComparisonOp_LiteratureSourcesId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PageNumber) == true) {
            const strComparisonOp_PageNumber = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PageNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PageNumber, objvPaperSubViewpoint_Cond.pageNumber, strComparisonOp_PageNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OrderNum, objvPaperSubViewpoint_Cond.orderNum, strComparisonOp_OrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperLineNum) == true) {
            const strComparisonOp_PaperLineNum = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperLineNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperLineNum, objvPaperSubViewpoint_Cond.paperLineNum, strComparisonOp_PaperLineNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperPageNum) == true) {
            const strComparisonOp_PaperPageNum = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperPageNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_PaperPageNum, objvPaperSubViewpoint_Cond.paperPageNum, strComparisonOp_PaperPageNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AppraiseCount) == true) {
            const strComparisonOp_AppraiseCount = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AppraiseCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AppraiseCount, objvPaperSubViewpoint_Cond.appraiseCount, strComparisonOp_AppraiseCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_OkCount, objvPaperSubViewpoint_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Score) == true) {
            const strComparisonOp_Score = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Score, objvPaperSubViewpoint_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_StuScore) == true) {
            const strComparisonOp_StuScore = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_StuScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_StuScore, objvPaperSubViewpoint_Cond.stuScore, strComparisonOp_StuScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TeaScore) == true) {
            const strComparisonOp_TeaScore = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TeaScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TeaScore, objvPaperSubViewpoint_Cond.teaScore, strComparisonOp_TeaScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_CreateDate, objvPaperSubViewpoint_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_ShareId, objvPaperSubViewpoint_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId) == true) {
            const strComparisonOp_TopicId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_TopicId, objvPaperSubViewpoint_Cond.topicId, strComparisonOp_TopicId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesId) == true) {
            const strComparisonOp_AttitudesId = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesId, objvPaperSubViewpoint_Cond.attitudesId, strComparisonOp_AttitudesId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesName) == true) {
            const strComparisonOp_AttitudesName = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_AttitudesName, objvPaperSubViewpoint_Cond.attitudesName, strComparisonOp_AttitudesName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdDate, objvPaperSubViewpoint_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_UpdUser, objvPaperSubViewpoint_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_Memo, objvPaperSubViewpoint_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionOrderNum) == true) {
            const strComparisonOp_SectionOrderNum = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionOrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SectionOrderNum, objvPaperSubViewpoint_Cond.sectionOrderNum, strComparisonOp_SectionOrderNum);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpoint_Cond.dicFldComparisonOp, clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum) == true) {
            const strComparisonOp_SubViewpointTypeOrderNum = objvPaperSubViewpoint_Cond.dicFldComparisonOp[clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN.con_SubViewpointTypeOrderNum, objvPaperSubViewpoint_Cond.subViewpointTypeOrderNum, strComparisonOp_SubViewpointTypeOrderNum);
        }
        return strWhereCond;
    }
    exports.vPaperSubViewpoint_GetCombineCondition = vPaperSubViewpoint_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperSubViewpointENS:源对象
     * @param objvPaperSubViewpointENT:目标对象
    */
    function vPaperSubViewpoint_CopyObjTo(objvPaperSubViewpointENS, objvPaperSubViewpointENT) {
        objvPaperSubViewpointENT.subViewpointId = objvPaperSubViewpointENS.subViewpointId; //子观点Id
        objvPaperSubViewpointENT.paperRWId = objvPaperSubViewpointENS.paperRWId; //课文阅读
        objvPaperSubViewpointENT.paperId = objvPaperSubViewpointENS.paperId; //论文Id
        objvPaperSubViewpointENT.paperTitle = objvPaperSubViewpointENS.paperTitle; //论文标题
        objvPaperSubViewpointENT.isSubmit = objvPaperSubViewpointENS.isSubmit; //是否提交
        objvPaperSubViewpointENT.id_CurrEduCls = objvPaperSubViewpointENS.id_CurrEduCls; //教学班流水号
        objvPaperSubViewpointENT.userId = objvPaperSubViewpointENS.userId; //用户ID
        objvPaperSubViewpointENT.sectionId = objvPaperSubViewpointENS.sectionId; //节Id
        objvPaperSubViewpointENT.sectionName = objvPaperSubViewpointENS.sectionName; //节名
        objvPaperSubViewpointENT.subViewpointTypeId = objvPaperSubViewpointENS.subViewpointTypeId; //类型Id
        objvPaperSubViewpointENT.subViewpointTypeName = objvPaperSubViewpointENS.subViewpointTypeName; //类型名称
        objvPaperSubViewpointENT.defaTitle = objvPaperSubViewpointENS.defaTitle; //默认标题
        objvPaperSubViewpointENT.rwTitle = objvPaperSubViewpointENS.rwTitle; //读写标题
        objvPaperSubViewpointENT.subViewpointContent = objvPaperSubViewpointENS.subViewpointContent; //详情内容
        objvPaperSubViewpointENT.explainTypeId = objvPaperSubViewpointENS.explainTypeId; //说明类型Id
        objvPaperSubViewpointENT.explainTypeName = objvPaperSubViewpointENS.explainTypeName; //说明类型名
        objvPaperSubViewpointENT.explainContent = objvPaperSubViewpointENS.explainContent; //说明内容
        objvPaperSubViewpointENT.isPublic = objvPaperSubViewpointENS.isPublic; //是否公开
        objvPaperSubViewpointENT.literatureSourcesId = objvPaperSubViewpointENS.literatureSourcesId; //文献来源
        objvPaperSubViewpointENT.pageNumber = objvPaperSubViewpointENS.pageNumber; //页码
        objvPaperSubViewpointENT.orderNum = objvPaperSubViewpointENS.orderNum; //序号
        objvPaperSubViewpointENT.paperLineNum = objvPaperSubViewpointENS.paperLineNum; //论文行号
        objvPaperSubViewpointENT.paperPageNum = objvPaperSubViewpointENS.paperPageNum; //论文页码
        objvPaperSubViewpointENT.appraiseCount = objvPaperSubViewpointENS.appraiseCount; //评论数
        objvPaperSubViewpointENT.okCount = objvPaperSubViewpointENS.okCount; //点赞统计
        objvPaperSubViewpointENT.score = objvPaperSubViewpointENS.score; //评分
        objvPaperSubViewpointENT.stuScore = objvPaperSubViewpointENS.stuScore; //学生平均分
        objvPaperSubViewpointENT.teaScore = objvPaperSubViewpointENS.teaScore; //教师评分
        objvPaperSubViewpointENT.createDate = objvPaperSubViewpointENS.createDate; //建立日期
        objvPaperSubViewpointENT.shareId = objvPaperSubViewpointENS.shareId; //分享Id
        objvPaperSubViewpointENT.topicId = objvPaperSubViewpointENS.topicId; //主题Id
        objvPaperSubViewpointENT.attitudesId = objvPaperSubViewpointENS.attitudesId; //态度Id
        objvPaperSubViewpointENT.attitudesName = objvPaperSubViewpointENS.attitudesName; //名称
        objvPaperSubViewpointENT.updDate = objvPaperSubViewpointENS.updDate; //修改日期
        objvPaperSubViewpointENT.updUser = objvPaperSubViewpointENS.updUser; //修改人
        objvPaperSubViewpointENT.memo = objvPaperSubViewpointENS.memo; //备注
        objvPaperSubViewpointENT.sectionOrderNum = objvPaperSubViewpointENS.sectionOrderNum; //SectionOrderNum
        objvPaperSubViewpointENT.subViewpointTypeOrderNum = objvPaperSubViewpointENS.subViewpointTypeOrderNum; //子观点类型序号
    }
    exports.vPaperSubViewpoint_CopyObjTo = vPaperSubViewpoint_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperSubViewpointENS:源对象
     * @param objvPaperSubViewpointENT:目标对象
    */
    function vPaperSubViewpoint_GetObjFromJsonObj(objvPaperSubViewpointENS) {
        const objvPaperSubViewpointENT = new clsvPaperSubViewpointEN_js_1.clsvPaperSubViewpointEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpointENT, objvPaperSubViewpointENS);
        return objvPaperSubViewpointENT;
    }
    exports.vPaperSubViewpoint_GetObjFromJsonObj = vPaperSubViewpoint_GetObjFromJsonObj;
});
