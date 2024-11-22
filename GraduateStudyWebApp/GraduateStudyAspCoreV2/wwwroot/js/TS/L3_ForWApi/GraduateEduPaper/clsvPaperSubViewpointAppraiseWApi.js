/**
* 类名:clsvPaperSubViewpointAppraiseWApi
* 表名:vPaperSubViewpointAppraise(01120562)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:44:12
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointAppraiseEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperSubViewpointAppraise_GetObjFromJsonObj = exports.vPaperSubViewpointAppraise_CopyObjTo = exports.vPaperSubViewpointAppraise_GetCombineCondition = exports.vPaperSubViewpointAppraise_GetObjByJSONStr = exports.vPaperSubViewpointAppraise_GetObjLstByJSONObjLst = exports.vPaperSubViewpointAppraise_GetObjLstByJSONStr = exports.vPaperSubViewpointAppraise_GetJSONStrByObj = exports.vPaperSubViewpointAppraise_ReFreshThisCache = exports.vPaperSubViewpointAppraise_GetWebApiUrl = exports.vPaperSubViewpointAppraise_GetRecCountByCond_Cache = exports.vPaperSubViewpointAppraise_GetRecCountByCondAsync = exports.vPaperSubViewpointAppraise_IsExistAsync = exports.vPaperSubViewpointAppraise_IsExist_Cache = exports.vPaperSubViewpointAppraise_IsExist = exports.vPaperSubViewpointAppraise_IsExistRecordAsync = exports.vPaperSubViewpointAppraise_IsExistRecord_Cache = exports.vPaperSubViewpointAppraise_GetObjLstByPagerAsync = exports.vPaperSubViewpointAppraise_GetObjLstByPager_Cache = exports.vPaperSubViewpointAppraise_GetObjLstByRange = exports.vPaperSubViewpointAppraise_GetObjLstByRangeAsync = exports.vPaperSubViewpointAppraise_GetTopObjLstAsync = exports.vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache = exports.vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync = exports.vPaperSubViewpointAppraise_GetSubObjLst_Cache = exports.vPaperSubViewpointAppraise_GetObjLst_PureCache = exports.vPaperSubViewpointAppraise_GetObjLst_Cache = exports.vPaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache = exports.vPaperSubViewpointAppraise_GetObjLst_sessionStorage = exports.vPaperSubViewpointAppraise_GetObjLstAsync = exports.vPaperSubViewpointAppraise_GetObjLst_localStorage_PureCache = exports.vPaperSubViewpointAppraise_GetObjLst_localStorage = exports.vPaperSubViewpointAppraise_GetObjLst_ClientCache = exports.vPaperSubViewpointAppraise_GetFirstObjAsync = exports.vPaperSubViewpointAppraise_GetFirstID = exports.vPaperSubViewpointAppraise_GetFirstIDAsync = exports.vPaperSubViewpointAppraise_funcKey = exports.vPaperSubViewpointAppraise_FilterFunByKey = exports.vPaperSubViewpointAppraise_SortFunByKey = exports.vPaperSubViewpointAppraise_SortFun_Defa_2Fld = exports.vPaperSubViewpointAppraise_SortFun_Defa = exports.vPaperSubViewpointAppraise_func = exports.vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage = exports.vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache = exports.vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync = exports.vPaperSubViewpointAppraise_ConstructorName = exports.vPaperSubViewpointAppraise_Controller = void 0;
    /**
     * v子观点评论表(vPaperSubViewpointAppraise)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvPaperSubViewpointAppraiseEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperSubViewpointAppraiseEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperSubViewpointAppraise_Controller = "vPaperSubViewpointAppraiseApi";
    exports.vPaperSubViewpointAppraise_ConstructorName = "vPaperSubViewpointAppraise";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperSubViewpointAppraiseId:关键字
    * @returns 对象
    **/
    async function vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "GetObjByPaperSubViewpointAppraiseIdAsync";
        if (lngPaperSubViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointAppraiseId]不能为空！(In clsvPaperSubViewpointAppraiseWApi.GetObjByPaperSubViewpointAppraiseIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperSubViewpointAppraiseId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperSubViewpointAppraiseId": lngPaperSubViewpointAppraiseId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvPaperSubViewpointAppraise = vPaperSubViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objvPaperSubViewpointAppraise;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync = vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperSubViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache(lngPaperSubViewpointAppraiseId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperSubViewpointAppraiseId_Cache";
        if (lngPaperSubViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointAppraiseId]不能为空！(In clsvPaperSubViewpointAppraiseWApi.GetObjByPaperSubViewpointAppraiseId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        try {
            const arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache.filter(x => x.paperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId);
            let objvPaperSubViewpointAppraise;
            if (arrvPaperSubViewpointAppraise_Sel.length > 0) {
                objvPaperSubViewpointAppraise = arrvPaperSubViewpointAppraise_Sel[0];
                return objvPaperSubViewpointAppraise;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvPaperSubViewpointAppraise_Const = await vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync(lngPaperSubViewpointAppraiseId);
                    if (objvPaperSubViewpointAppraise_Const != null) {
                        vPaperSubViewpointAppraise_ReFreshThisCache();
                        return objvPaperSubViewpointAppraise_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointAppraiseId, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache = vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperSubViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "GetObjByPaperSubViewpointAppraiseId_localStorage";
        if (lngPaperSubViewpointAppraiseId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperSubViewpointAppraiseId]不能为空！(In clsvPaperSubViewpointAppraiseWApi.GetObjByPaperSubViewpointAppraiseId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName, lngPaperSubViewpointAppraiseId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvPaperSubViewpointAppraise_Cache = JSON.parse(strTempObj);
            return objvPaperSubViewpointAppraise_Cache;
        }
        try {
            const objvPaperSubViewpointAppraise = await vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseIdAsync(lngPaperSubViewpointAppraiseId);
            if (objvPaperSubViewpointAppraise != null) {
                localStorage.setItem(strKey, JSON.stringify(objvPaperSubViewpointAppraise));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvPaperSubViewpointAppraise;
            }
            return objvPaperSubViewpointAppraise;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperSubViewpointAppraiseId, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage = vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_localStorage;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function vPaperSubViewpointAppraise_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperSubViewpointAppraiseId = Number(strInValue);
        if (lngPaperSubViewpointAppraiseId == 0) {
            return "";
        }
        const objvPaperSubViewpointAppraise = await vPaperSubViewpointAppraise_GetObjByPaperSubViewpointAppraiseId_Cache(lngPaperSubViewpointAppraiseId);
        if (objvPaperSubViewpointAppraise == null)
            return "";
        if (objvPaperSubViewpointAppraise.GetFldValue(strOutFldName) == null)
            return "";
        return objvPaperSubViewpointAppraise.GetFldValue(strOutFldName).toString();
    }
    exports.vPaperSubViewpointAppraise_func = vPaperSubViewpointAppraise_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointAppraise_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperSubViewpointAppraiseId - b.paperSubViewpointAppraiseId;
    }
    exports.vPaperSubViewpointAppraise_SortFun_Defa = vPaperSubViewpointAppraise_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointAppraise_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.subViewpointId == b.subViewpointId)
            return a.appraiseScore - b.appraiseScore;
        else
            return a.subViewpointId.localeCompare(b.subViewpointId);
    }
    exports.vPaperSubViewpointAppraise_SortFun_Defa_2Fld = vPaperSubViewpointAppraise_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperSubViewpointAppraise_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId:
                    return (a, b) => {
                        return a.paperSubViewpointAppraiseId - b.paperSubViewpointAppraiseId;
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointId:
                    return (a, b) => {
                        if (a.subViewpointId == null)
                            return -1;
                        if (b.subViewpointId == null)
                            return 1;
                        return a.subViewpointId.localeCompare(b.subViewpointId);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseScore:
                    return (a, b) => {
                        return a.appraiseScore - b.appraiseScore;
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        if (a.appraiseContent == null)
                            return -1;
                        if (b.appraiseContent == null)
                            return 1;
                        return a.appraiseContent.localeCompare(b.appraiseContent);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_Meno:
                    return (a, b) => {
                        if (a.meno == null)
                            return -1;
                        if (b.meno == null)
                            return 1;
                        return a.meno.localeCompare(b.meno);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_RWTitle:
                    return (a, b) => {
                        if (a.rwTitle == null)
                            return -1;
                        if (b.rwTitle == null)
                            return 1;
                        return a.rwTitle.localeCompare(b.rwTitle);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointContent:
                    return (a, b) => {
                        if (a.subViewpointContent == null)
                            return -1;
                        if (b.subViewpointContent == null)
                            return 1;
                        return a.subViewpointContent.localeCompare(b.subViewpointContent);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_ExplainContent:
                    return (a, b) => {
                        if (a.explainContent == null)
                            return -1;
                        if (b.explainContent == null)
                            return 1;
                        return a.explainContent.localeCompare(b.explainContent);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperRWId:
                    return (a, b) => {
                        if (a.paperRWId == null)
                            return -1;
                        if (b.paperRWId == null)
                            return 1;
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointAppraise]中不存在！(in ${exports.vPaperSubViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId:
                    return (a, b) => {
                        return b.paperSubViewpointAppraiseId - a.paperSubViewpointAppraiseId;
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointId:
                    return (a, b) => {
                        if (b.subViewpointId == null)
                            return -1;
                        if (a.subViewpointId == null)
                            return 1;
                        return b.subViewpointId.localeCompare(a.subViewpointId);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseScore:
                    return (a, b) => {
                        return b.appraiseScore - a.appraiseScore;
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseContent:
                    return (a, b) => {
                        if (b.appraiseContent == null)
                            return -1;
                        if (a.appraiseContent == null)
                            return 1;
                        return b.appraiseContent.localeCompare(a.appraiseContent);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_Meno:
                    return (a, b) => {
                        if (b.meno == null)
                            return -1;
                        if (a.meno == null)
                            return 1;
                        return b.meno.localeCompare(a.meno);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_RWTitle:
                    return (a, b) => {
                        if (b.rwTitle == null)
                            return -1;
                        if (a.rwTitle == null)
                            return 1;
                        return b.rwTitle.localeCompare(a.rwTitle);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointContent:
                    return (a, b) => {
                        if (b.subViewpointContent == null)
                            return -1;
                        if (a.subViewpointContent == null)
                            return 1;
                        return b.subViewpointContent.localeCompare(a.subViewpointContent);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_ExplainContent:
                    return (a, b) => {
                        if (b.explainContent == null)
                            return -1;
                        if (a.explainContent == null)
                            return 1;
                        return b.explainContent.localeCompare(a.explainContent);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperRWId:
                    return (a, b) => {
                        if (b.paperRWId == null)
                            return -1;
                        if (a.paperRWId == null)
                            return 1;
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointAppraise]中不存在！(in ${exports.vPaperSubViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperSubViewpointAppraise_SortFunByKey = vPaperSubViewpointAppraise_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperSubViewpointAppraise_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId:
                return (obj) => {
                    return obj.paperSubViewpointAppraiseId === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointId:
                return (obj) => {
                    return obj.subViewpointId === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseScore:
                return (obj) => {
                    return obj.appraiseScore === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseContent:
                return (obj) => {
                    return obj.appraiseContent === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_Meno:
                return (obj) => {
                    return obj.meno === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_RWTitle:
                return (obj) => {
                    return obj.rwTitle === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointContent:
                return (obj) => {
                    return obj.subViewpointContent === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_ExplainContent:
                return (obj) => {
                    return obj.explainContent === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperSubViewpointAppraise]中不存在！(in ${exports.vPaperSubViewpointAppraise_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperSubViewpointAppraise_FilterFunByKey = vPaperSubViewpointAppraise_FilterFunByKey;
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_funcKey)
     * @param strInFldName:输入字段名
     * @param strInValue:输入字段值
     * @param strComparisonOp:比较操作符
     * @returns 返回一个关键字值列表
    */
    async function vPaperSubViewpointAppraise_funcKey(strInFldName, strInValue, strComparisonOp) {
        //const strThisFuncName = "funcKey";
        if (strInFldName == clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (Number(strInValue) == 0) {
            return [];
        }
        const arrvPaperSubViewpointAppraise = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrvPaperSubViewpointAppraise == null)
            return [];
        let arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvPaperSubViewpointAppraise_Sel.length == 0)
            return [];
        return arrvPaperSubViewpointAppraise_Sel.map(x => x.paperSubViewpointAppraiseId);
    }
    exports.vPaperSubViewpointAppraise_funcKey = vPaperSubViewpointAppraise_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperSubViewpointAppraise_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetFirstIDAsync = vPaperSubViewpointAppraise_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperSubViewpointAppraise_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetFirstID = vPaperSubViewpointAppraise_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperSubViewpointAppraise_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
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
                const objvPaperSubViewpointAppraise = vPaperSubViewpointAppraise_GetObjFromJsonObj(returnObj);
                return objvPaperSubViewpointAppraise;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetFirstObjAsync = vPaperSubViewpointAppraise_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvPaperSubViewpointAppraiseExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvPaperSubViewpointAppraiseObjLst_T = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrvPaperSubViewpointAppraiseExObjLst_Cache);
            return arrvPaperSubViewpointAppraiseObjLst_T;
        }
        try {
            const arrvPaperSubViewpointAppraiseExObjLst = await vPaperSubViewpointAppraise_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvPaperSubViewpointAppraiseExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_ClientCache = vPaperSubViewpointAppraise_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperSubViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperSubViewpointAppraiseObjLst_T = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrvPaperSubViewpointAppraiseExObjLst_Cache);
            return arrvPaperSubViewpointAppraiseObjLst_T;
        }
        try {
            const arrvPaperSubViewpointAppraiseExObjLst = await vPaperSubViewpointAppraise_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_localStorage = vPaperSubViewpointAppraise_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperSubViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSubViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_localStorage_PureCache = vPaperSubViewpointAppraise_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLstAsync = vPaperSubViewpointAppraise_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName;
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperSubViewpointAppraiseExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperSubViewpointAppraiseObjLst_T = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrvPaperSubViewpointAppraiseExObjLst_Cache);
            return arrvPaperSubViewpointAppraiseObjLst_T;
        }
        try {
            const arrvPaperSubViewpointAppraiseExObjLst = await vPaperSubViewpointAppraise_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperSubViewpointAppraiseExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperSubViewpointAppraiseExObjLst.length);
            console.log(strInfo);
            return arrvPaperSubViewpointAppraiseExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_sessionStorage = vPaperSubViewpointAppraise_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperSubViewpointAppraiseObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperSubViewpointAppraiseObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache = vPaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvPaperSubViewpointAppraiseObjLst_Cache;
        switch (clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_ClientCache();
                break;
            default:
                arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_ClientCache();
                break;
        }
        const arrvPaperSubViewpointAppraiseObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrvPaperSubViewpointAppraiseObjLst_Cache);
        return arrvPaperSubViewpointAppraiseObjLst_Cache;
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_Cache = vPaperSubViewpointAppraise_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvPaperSubViewpointAppraiseObjLst_Cache;
        switch (clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvPaperSubViewpointAppraiseObjLst_Cache = null;
                break;
            default:
                arrvPaperSubViewpointAppraiseObjLst_Cache = null;
                break;
        }
        return arrvPaperSubViewpointAppraiseObjLst_Cache;
    }
    exports.vPaperSubViewpointAppraise_GetObjLst_PureCache = vPaperSubViewpointAppraise_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperSubViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperSubViewpointAppraise_GetSubObjLst_Cache(objvPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        let arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache;
        if (objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpointAppraise_Sel;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSubViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSubViewpointAppraise_Cond), exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpointAppraise_GetSubObjLst_Cache = vPaperSubViewpointAppraise_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperSubViewpointAppraiseId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync(arrPaperSubViewpointAppraiseId) {
        const strThisFuncName = "GetObjLstByPaperSubViewpointAppraiseIdLstAsync";
        const strAction = "GetObjLstByPaperSubViewpointAppraiseIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperSubViewpointAppraiseId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync = vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperSubViewpointAppraiseIdLst:关键字列表
     * @returns 对象列表
    */
    async function vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache(arrPaperSubViewpointAppraiseIdLst) {
        const strThisFuncName = "GetObjLstByPaperSubViewpointAppraiseIdLst_Cache";
        try {
            const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
            const arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache.filter(x => arrPaperSubViewpointAppraiseIdLst.indexOf(x.paperSubViewpointAppraiseId) > -1);
            return arrvPaperSubViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperSubViewpointAppraiseIdLst.join(","), exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache = vPaperSubViewpointAppraise_GetObjLstByPaperSubViewpointAppraiseIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperSubViewpointAppraise_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetTopObjLstAsync = vPaperSubViewpointAppraise_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByRangeAsync = vPaperSubViewpointAppraise_GetObjLstByRangeAsync;
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
    async function vPaperSubViewpointAppraise_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByRange = vPaperSubViewpointAppraise_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperSubViewpointAppraise_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrvPaperSubViewpointAppraiseObjLst_Cache.length == 0)
            return arrvPaperSubViewpointAppraiseObjLst_Cache;
        let arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperSubViewpointAppraise_Cond = new clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpointAppraise_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperSubViewpointAppraiseWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpointAppraise_Sel.length == 0)
                return arrvPaperSubViewpointAppraise_Sel;
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
                arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.sort(vPaperSubViewpointAppraise_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.slice(intStart, intEnd);
            return arrvPaperSubViewpointAppraise_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByPager_Cache = vPaperSubViewpointAppraise_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperSubViewpointAppraise_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByPagerAsync = vPaperSubViewpointAppraise_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperSubViewpointAppraiseId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperSubViewpointAppraise_IsExistRecord_Cache(objvPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrvPaperSubViewpointAppraiseObjLst_Cache == null)
            return false;
        let arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache;
        if (objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpointAppraise_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperSubViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaperSubViewpointAppraise_Cond), exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vPaperSubViewpointAppraise_IsExistRecord_Cache = vPaperSubViewpointAppraise_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperSubViewpointAppraise_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_IsExistRecordAsync = vPaperSubViewpointAppraise_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperSubViewpointAppraiseId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperSubViewpointAppraise_IsExist(lngPaperSubViewpointAppraiseId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperSubViewpointAppraiseId": lngPaperSubViewpointAppraiseId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_IsExist = vPaperSubViewpointAppraise_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperSubViewpointAppraiseId:所给的关键字
     * @returns 对象
    */
    async function vPaperSubViewpointAppraise_IsExist_Cache(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrvPaperSubViewpointAppraiseObjLst_Cache == null)
            return false;
        try {
            const arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache.filter(x => x.paperSubViewpointAppraiseId == lngPaperSubViewpointAppraiseId);
            if (arrvPaperSubViewpointAppraise_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperSubViewpointAppraiseId, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vPaperSubViewpointAppraise_IsExist_Cache = vPaperSubViewpointAppraise_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperSubViewpointAppraiseId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperSubViewpointAppraise_IsExistAsync(lngPaperSubViewpointAppraiseId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperSubViewpointAppraiseId": lngPaperSubViewpointAppraiseId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_IsExistAsync = vPaperSubViewpointAppraise_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperSubViewpointAppraise_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperSubViewpointAppraise_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperSubViewpointAppraise_GetRecCountByCondAsync = vPaperSubViewpointAppraise_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvPaperSubViewpointAppraise_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vPaperSubViewpointAppraise_GetRecCountByCond_Cache(objvPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvPaperSubViewpointAppraiseObjLst_Cache = await vPaperSubViewpointAppraise_GetObjLst_Cache();
        if (arrvPaperSubViewpointAppraiseObjLst_Cache == null)
            return 0;
        let arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraiseObjLst_Cache;
        if (objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == null || objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp == "")
            return arrvPaperSubViewpointAppraise_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvPaperSubViewpointAppraise_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperSubViewpointAppraiseWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperSubViewpointAppraise_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperSubViewpointAppraise_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperSubViewpointAppraise_Sel = arrvPaperSubViewpointAppraise_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperSubViewpointAppraise_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaperSubViewpointAppraise_Cond), exports.vPaperSubViewpointAppraise_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperSubViewpointAppraise_GetRecCountByCond_Cache = vPaperSubViewpointAppraise_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperSubViewpointAppraise_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperSubViewpointAppraise_GetWebApiUrl = vPaperSubViewpointAppraise_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vPaperSubViewpointAppraise_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN._CurrTabName;
            switch (clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.CacheModeId) {
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
    exports.vPaperSubViewpointAppraise_ReFreshThisCache = vPaperSubViewpointAppraise_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubViewpointAppraise_GetJSONStrByObj(pobjvPaperSubViewpointAppraiseEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperSubViewpointAppraiseEN);
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
    exports.vPaperSubViewpointAppraise_GetJSONStrByObj = vPaperSubViewpointAppraise_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubViewpointAppraise_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperSubViewpointAppraiseObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperSubViewpointAppraiseObjLst;
        }
        try {
            arrvPaperSubViewpointAppraiseObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperSubViewpointAppraiseObjLst;
        }
        return arrvPaperSubViewpointAppraiseObjLst;
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByJSONStr = vPaperSubViewpointAppraise_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperSubViewpointAppraiseObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperSubViewpointAppraise_GetObjLstByJSONObjLst(arrvPaperSubViewpointAppraiseObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperSubViewpointAppraiseObjLst = new Array();
        for (const objInFor of arrvPaperSubViewpointAppraiseObjLstS) {
            const obj1 = vPaperSubViewpointAppraise_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperSubViewpointAppraiseObjLst.push(obj1);
        }
        return arrvPaperSubViewpointAppraiseObjLst;
    }
    exports.vPaperSubViewpointAppraise_GetObjLstByJSONObjLst = vPaperSubViewpointAppraise_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperSubViewpointAppraise_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperSubViewpointAppraiseEN = new clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN();
        if (strJSON === "") {
            return pobjvPaperSubViewpointAppraiseEN;
        }
        try {
            pobjvPaperSubViewpointAppraiseEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperSubViewpointAppraiseEN;
        }
        return pobjvPaperSubViewpointAppraiseEN;
    }
    exports.vPaperSubViewpointAppraise_GetObjByJSONStr = vPaperSubViewpointAppraise_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperSubViewpointAppraise_GetCombineCondition(objvPaperSubViewpointAppraise_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId) == true) {
            const strComparisonOp_PaperSubViewpointAppraiseId = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperSubViewpointAppraiseId, objvPaperSubViewpointAppraise_Cond.paperSubViewpointAppraiseId, strComparisonOp_PaperSubViewpointAppraiseId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointId) == true) {
            const strComparisonOp_SubViewpointId = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_SubViewpointId, objvPaperSubViewpointAppraise_Cond.subViewpointId, strComparisonOp_SubViewpointId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseScore) == true) {
            const strComparisonOp_AppraiseScore = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseScore];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseScore, objvPaperSubViewpointAppraise_Cond.appraiseScore, strComparisonOp_AppraiseScore);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseContent) == true) {
            const strComparisonOp_AppraiseContent = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_AppraiseContent, objvPaperSubViewpointAppraise_Cond.appraiseContent, strComparisonOp_AppraiseContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdDate, objvPaperSubViewpointAppraise_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_Meno) == true) {
            const strComparisonOp_Meno = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_Meno];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_Meno, objvPaperSubViewpointAppraise_Cond.meno, strComparisonOp_Meno);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_RWTitle) == true) {
            const strComparisonOp_RWTitle = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_RWTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_RWTitle, objvPaperSubViewpointAppraise_Cond.rwTitle, strComparisonOp_RWTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_ExplainContent) == true) {
            const strComparisonOp_ExplainContent = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_ExplainContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_ExplainContent, objvPaperSubViewpointAppraise_Cond.explainContent, strComparisonOp_ExplainContent);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_PaperRWId, objvPaperSubViewpointAppraise_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp, clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperSubViewpointAppraise_Cond.dicFldComparisonOp[clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN.con_UpdUser, objvPaperSubViewpointAppraise_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.vPaperSubViewpointAppraise_GetCombineCondition = vPaperSubViewpointAppraise_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperSubViewpointAppraiseENS:源对象
     * @param objvPaperSubViewpointAppraiseENT:目标对象
    */
    function vPaperSubViewpointAppraise_CopyObjTo(objvPaperSubViewpointAppraiseENS, objvPaperSubViewpointAppraiseENT) {
        objvPaperSubViewpointAppraiseENT.paperSubViewpointAppraiseId = objvPaperSubViewpointAppraiseENS.paperSubViewpointAppraiseId; //子观点评价Id
        objvPaperSubViewpointAppraiseENT.subViewpointId = objvPaperSubViewpointAppraiseENS.subViewpointId; //子观点Id
        objvPaperSubViewpointAppraiseENT.appraiseScore = objvPaperSubViewpointAppraiseENS.appraiseScore; //打分
        objvPaperSubViewpointAppraiseENT.appraiseContent = objvPaperSubViewpointAppraiseENS.appraiseContent; //评议内容
        objvPaperSubViewpointAppraiseENT.updDate = objvPaperSubViewpointAppraiseENS.updDate; //修改日期
        objvPaperSubViewpointAppraiseENT.meno = objvPaperSubViewpointAppraiseENS.meno; //备注
        objvPaperSubViewpointAppraiseENT.rwTitle = objvPaperSubViewpointAppraiseENS.rwTitle; //读写标题
        objvPaperSubViewpointAppraiseENT.subViewpointContent = objvPaperSubViewpointAppraiseENS.subViewpointContent; //详情内容
        objvPaperSubViewpointAppraiseENT.explainContent = objvPaperSubViewpointAppraiseENS.explainContent; //说明内容
        objvPaperSubViewpointAppraiseENT.paperRWId = objvPaperSubViewpointAppraiseENS.paperRWId; //课文阅读
        objvPaperSubViewpointAppraiseENT.updUser = objvPaperSubViewpointAppraiseENS.updUser; //修改人
    }
    exports.vPaperSubViewpointAppraise_CopyObjTo = vPaperSubViewpointAppraise_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperSubViewpointAppraiseENS:源对象
     * @param objvPaperSubViewpointAppraiseENT:目标对象
    */
    function vPaperSubViewpointAppraise_GetObjFromJsonObj(objvPaperSubViewpointAppraiseENS) {
        const objvPaperSubViewpointAppraiseENT = new clsvPaperSubViewpointAppraiseEN_js_1.clsvPaperSubViewpointAppraiseEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperSubViewpointAppraiseENT, objvPaperSubViewpointAppraiseENS);
        return objvPaperSubViewpointAppraiseENT;
    }
    exports.vPaperSubViewpointAppraise_GetObjFromJsonObj = vPaperSubViewpointAppraise_GetObjFromJsonObj;
});
