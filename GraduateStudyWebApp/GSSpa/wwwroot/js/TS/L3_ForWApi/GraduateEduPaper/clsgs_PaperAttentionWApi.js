/**
* 类名:clsgs_PaperAttentionWApi
* 表名:gs_PaperAttention(01120748)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:42
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js", "../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperAttention_GetObjFromJsonObj = exports.gs_PaperAttention_CopyObjTo = exports.gs_PaperAttention_GetUniCondStr4Update_PaperId_UserId = exports.gs_PaperAttention_GetUniCondStr_PaperId_UserId = exports.gs_PaperAttention_GetCombineCondition = exports.gs_PaperAttention_GetObjByJSONStr = exports.gs_PaperAttention_GetObjLstByJSONObjLst = exports.gs_PaperAttention_GetObjLstByJSONStr = exports.gs_PaperAttention_GetJSONStrByObj = exports.gs_PaperAttention_CheckProperty4Update = exports.gs_PaperAttention_CheckPropertyNew = exports.gs_PaperAttention_ReFreshThisCache = exports.gs_PaperAttention_ReFreshCache = exports.gs_PaperAttention_GetWebApiUrl = exports.gs_PaperAttention_GetMaxStrIdByPrefix = exports.gs_PaperAttention_GetRecCountByCond_Cache = exports.gs_PaperAttention_GetRecCountByCondAsync = exports.gs_PaperAttention_IsExistAsync = exports.gs_PaperAttention_IsExist_Cache = exports.gs_PaperAttention_IsExist = exports.gs_PaperAttention_IsExistRecordAsync = exports.gs_PaperAttention_IsExistRecord_Cache = exports.gs_PaperAttention_UpdateWithConditionAsync = exports.gs_PaperAttention_UpdateRecordAsync = exports.gs_PaperAttention_AddNewRecordWithReturnKey = exports.gs_PaperAttention_AddNewRecordWithReturnKeyAsync = exports.gs_PaperAttention_AddNewRecordAsync = exports.gs_PaperAttention_Delgs_PaperAttentionsByCondAsync = exports.gs_PaperAttention_Delgs_PaperAttentionsAsync = exports.gs_PaperAttention_DelRecordAsync = exports.gs_PaperAttention_GetObjLstByPagerAsync = exports.gs_PaperAttention_GetObjLstByPager_Cache = exports.gs_PaperAttention_GetObjLstByRange = exports.gs_PaperAttention_GetObjLstByRangeAsync = exports.gs_PaperAttention_GetTopObjLstAsync = exports.gs_PaperAttention_GetObjLstByPaperAttentionIdLst_Cache = exports.gs_PaperAttention_GetObjLstByPaperAttentionIdLstAsync = exports.gs_PaperAttention_GetSubObjLst_Cache = exports.gs_PaperAttention_GetObjLst_PureCache = exports.gs_PaperAttention_GetObjLst_Cache = exports.gs_PaperAttention_GetObjLst_sessionStorage_PureCache = exports.gs_PaperAttention_GetObjLst_sessionStorage = exports.gs_PaperAttention_GetObjLstAsync = exports.gs_PaperAttention_GetObjLst_localStorage_PureCache = exports.gs_PaperAttention_GetObjLst_localStorage = exports.gs_PaperAttention_GetObjLst_ClientCache = exports.gs_PaperAttention_GetFirstObjAsync = exports.gs_PaperAttention_GetFirstID = exports.gs_PaperAttention_GetFirstIDAsync = exports.gs_PaperAttention_FilterFunByKey = exports.gs_PaperAttention_SortFunByKey = exports.gs_PaperAttention_SortFun_Defa_2Fld = exports.gs_PaperAttention_SortFun_Defa = exports.gs_PaperAttention_func = exports.gs_PaperAttention_UpdateObjInLst_Cache = exports.gs_PaperAttention_GetObjByPaperAttentionId_localStorage = exports.gs_PaperAttention_GetObjByPaperAttentionId_Cache = exports.gs_PaperAttention_GetObjByPaperAttentionIdAsync = exports.gs_PaperAttention_ConstructorName = exports.gs_PaperAttention_Controller = void 0;
    /**
     * 论文关注(gs_PaperAttention)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_PaperAttentionEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperAttentionEN.js");
    const clsvgs_PaperAttentionWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperAttentionWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_PaperAttention_Controller = "gs_PaperAttentionApi";
    exports.gs_PaperAttention_ConstructorName = "gs_PaperAttention";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param lngPaperAttentionId:关键字
    * @returns 对象
    **/
    async function gs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId) {
        const strThisFuncName = "GetObjByPaperAttentionIdAsync";
        if (lngPaperAttentionId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperAttentionId]不能为空！(In GetObjByPaperAttentionIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperAttentionId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "lngPaperAttentionId": lngPaperAttentionId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperAttention = gs_PaperAttention_GetObjFromJsonObj(returnObj);
                return objgs_PaperAttention;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetObjByPaperAttentionIdAsync = gs_PaperAttention_GetObjByPaperAttentionIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param lngPaperAttentionId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperAttention_GetObjByPaperAttentionId_Cache(lngPaperAttentionId, strUserId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperAttentionId_Cache";
        if (lngPaperAttentionId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperAttentionId]不能为空！(In GetObjByPaperAttentionId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
        try {
            const arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache.filter(x => x.paperAttentionId == lngPaperAttentionId);
            let objgs_PaperAttention;
            if (arrgs_PaperAttention_Sel.length > 0) {
                objgs_PaperAttention = arrgs_PaperAttention_Sel[0];
                return objgs_PaperAttention;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_PaperAttention = await gs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
                    if (objgs_PaperAttention != null) {
                        gs_PaperAttention_ReFreshThisCache(strUserId);
                        return objgs_PaperAttention;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAttentionId, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_PaperAttention_GetObjByPaperAttentionId_Cache = gs_PaperAttention_GetObjByPaperAttentionId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param lngPaperAttentionId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperAttention_GetObjByPaperAttentionId_localStorage(lngPaperAttentionId) {
        const strThisFuncName = "GetObjByPaperAttentionId_localStorage";
        if (lngPaperAttentionId == 0) {
            const strMsg = (0, clsString_js_1.Format)("参数:[lngPaperAttentionId]不能为空！(In GetObjByPaperAttentionId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, lngPaperAttentionId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_PaperAttention_Cache = JSON.parse(strTempObj);
            return objgs_PaperAttention_Cache;
        }
        try {
            const objgs_PaperAttention = await gs_PaperAttention_GetObjByPaperAttentionIdAsync(lngPaperAttentionId);
            if (objgs_PaperAttention != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_PaperAttention));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_PaperAttention;
            }
            return objgs_PaperAttention;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, lngPaperAttentionId, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_PaperAttention_GetObjByPaperAttentionId_localStorage = gs_PaperAttention_GetObjByPaperAttentionId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_PaperAttention:所给的对象
     * @returns 对象
    */
    async function gs_PaperAttention_UpdateObjInLst_Cache(objgs_PaperAttention, strUserId) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
            const obj = arrgs_PaperAttentionObjLst_Cache.find(x => x.paperId == objgs_PaperAttention.paperId && x.userId == objgs_PaperAttention.userId);
            if (obj != null) {
                objgs_PaperAttention.paperAttentionId = obj.paperAttentionId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_PaperAttention);
            }
            else {
                arrgs_PaperAttentionObjLst_Cache.push(objgs_PaperAttention);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_PaperAttention_UpdateObjInLst_Cache = gs_PaperAttention_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     @param strUserId:缓存的分类字段
     * @returns 返回一个输出字段值
    */
    async function gs_PaperAttention_func(strInFldName, strOutFldName, strInValue, strUserId_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId_C]不能为空！(In func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const lngPaperAttentionId = Number(strInValue);
        if (lngPaperAttentionId == 0) {
            return "";
        }
        const objgs_PaperAttention = await gs_PaperAttention_GetObjByPaperAttentionId_Cache(lngPaperAttentionId, strUserId_C);
        if (objgs_PaperAttention == null)
            return "";
        return objgs_PaperAttention.GetFldValue(strOutFldName).toString();
    }
    exports.gs_PaperAttention_func = gs_PaperAttention_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperAttention_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperAttentionId - b.paperAttentionId;
    }
    exports.gs_PaperAttention_SortFun_Defa = gs_PaperAttention_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperAttention_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.userId.localeCompare(b.userId);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.gs_PaperAttention_SortFun_Defa_2Fld = gs_PaperAttention_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperAttention_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId:
                    return (a, b) => {
                        return a.paperAttentionId - b.paperAttentionId;
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperGroupId:
                    return (a, b) => {
                        return a.paperGroupId.localeCompare(b.paperGroupId);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_Meno:
                    return (a, b) => {
                        return a.meno.localeCompare(b.meno);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperAttention]中不存在！(in ${exports.gs_PaperAttention_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId:
                    return (a, b) => {
                        return b.paperAttentionId - a.paperAttentionId;
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperGroupId:
                    return (a, b) => {
                        return b.paperGroupId.localeCompare(a.paperGroupId);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_Meno:
                    return (a, b) => {
                        return b.meno.localeCompare(a.meno);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperAttention]中不存在！(in ${exports.gs_PaperAttention_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperAttention_SortFunByKey = gs_PaperAttention_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperAttention_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId:
                return (obj) => {
                    return obj.paperAttentionId === value;
                };
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperGroupId:
                return (obj) => {
                    return obj.paperGroupId === value;
                };
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_Meno:
                return (obj) => {
                    return obj.meno === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperAttention]中不存在！(in ${exports.gs_PaperAttention_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperAttention_FilterFunByKey = gs_PaperAttention_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperAttention_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetFirstIDAsync = gs_PaperAttention_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperAttention_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetFirstID = gs_PaperAttention_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperAttention_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperAttention = gs_PaperAttention_GetObjFromJsonObj(returnObj);
                return objgs_PaperAttention;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetFirstObjAsync = gs_PaperAttention_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_ClientCache(strUserId) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
        clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_PaperAttentionExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_PaperAttentionObjLst_T = gs_PaperAttention_GetObjLstByJSONObjLst(arrgs_PaperAttentionExObjLst_Cache);
            return arrgs_PaperAttentionObjLst_T;
        }
        try {
            const arrgs_PaperAttentionExObjLst = await gs_PaperAttention_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_PaperAttentionExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperAttentionExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperAttentionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperAttention_GetObjLst_ClientCache = gs_PaperAttention_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_localStorage(strUserId) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
        clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperAttentionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperAttentionObjLst_T = gs_PaperAttention_GetObjLstByJSONObjLst(arrgs_PaperAttentionExObjLst_Cache);
            return arrgs_PaperAttentionObjLst_T;
        }
        try {
            const arrgs_PaperAttentionExObjLst = await gs_PaperAttention_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_PaperAttentionExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperAttentionExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperAttentionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperAttention_GetObjLst_localStorage = gs_PaperAttention_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_localStorage_PureCache(strUserId) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperAttentionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperAttentionObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperAttention_GetObjLst_localStorage_PureCache = gs_PaperAttention_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperAttention_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetObjLstAsync = gs_PaperAttention_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_sessionStorage(strUserId) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
        clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperAttentionExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperAttentionObjLst_T = gs_PaperAttention_GetObjLstByJSONObjLst(arrgs_PaperAttentionExObjLst_Cache);
            return arrgs_PaperAttentionObjLst_T;
        }
        try {
            const arrgs_PaperAttentionExObjLst = await gs_PaperAttention_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperAttentionExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperAttentionExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperAttentionExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperAttention_GetObjLst_sessionStorage = gs_PaperAttention_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_sessionStorage_PureCache(strUserId) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("UserId='{0}'", strUserId);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperAttentionObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperAttentionObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperAttention_GetObjLst_sessionStorage_PureCache = gs_PaperAttention_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_Cache(strUserId) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[UserId]不能为空！");
            console.error(strMsg);
            throw (strMsg);
        }
        let arrgs_PaperAttentionObjLst_Cache;
        switch (clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_sessionStorage(strUserId);
                break;
            case "03": //localStorage
                arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_localStorage(strUserId);
                break;
            case "02": //ClientCache
                arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_ClientCache(strUserId);
                break;
            default:
                arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_ClientCache(strUserId);
                break;
        }
        const arrgs_PaperAttentionObjLst = gs_PaperAttention_GetObjLstByJSONObjLst(arrgs_PaperAttentionObjLst_Cache);
        return arrgs_PaperAttentionObjLst_Cache;
    }
    exports.gs_PaperAttention_GetObjLst_Cache = gs_PaperAttention_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperAttention_GetObjLst_PureCache(strUserId) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_PaperAttentionObjLst_Cache;
        switch (clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_sessionStorage_PureCache(strUserId);
                break;
            case "03": //localStorage
                arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_localStorage_PureCache(strUserId);
                break;
            case "02": //ClientCache
                arrgs_PaperAttentionObjLst_Cache = null;
                break;
            default:
                arrgs_PaperAttentionObjLst_Cache = null;
                break;
        }
        return arrgs_PaperAttentionObjLst_Cache;
    }
    exports.gs_PaperAttention_GetObjLst_PureCache = gs_PaperAttention_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objlngPaperAttentionId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperAttention_GetSubObjLst_Cache(objgs_PaperAttention_Cond, strUserId) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
        let arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache;
        if (objgs_PaperAttention_Cond.sf_FldComparisonOp == null || objgs_PaperAttention_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperAttention_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_PaperAttention_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperAttention_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperAttention_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperAttention_Cond), exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperAttention_GetSubObjLst_Cache = gs_PaperAttention_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperAttentionId:关键字列表
    * @returns 对象列表
    **/
    async function gs_PaperAttention_GetObjLstByPaperAttentionIdLstAsync(arrPaperAttentionId) {
        const strThisFuncName = "GetObjLstByPaperAttentionIdLstAsync";
        const strAction = "GetObjLstByPaperAttentionIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperAttentionId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetObjLstByPaperAttentionIdLstAsync = gs_PaperAttention_GetObjLstByPaperAttentionIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrlngPaperAttentionIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_PaperAttention_GetObjLstByPaperAttentionIdLst_Cache(arrPaperAttentionIdLst, strUserId) {
        const strThisFuncName = "GetObjLstByPaperAttentionIdLst_Cache";
        try {
            const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
            const arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache.filter(x => arrPaperAttentionIdLst.indexOf(x.paperAttentionId) > -1);
            return arrgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperAttentionIdLst.join(","), exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperAttention_GetObjLstByPaperAttentionIdLst_Cache = gs_PaperAttention_GetObjLstByPaperAttentionIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperAttention_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetTopObjLstAsync = gs_PaperAttention_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperAttention_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetObjLstByRangeAsync = gs_PaperAttention_GetObjLstByRangeAsync;
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
    async function gs_PaperAttention_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetObjLstByRange = gs_PaperAttention_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperAttention_GetObjLstByPager_Cache(objPagerPara, strUserId) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
        if (arrgs_PaperAttentionObjLst_Cache.length == 0)
            return arrgs_PaperAttentionObjLst_Cache;
        let arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_PaperAttention_Cond = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperAttention_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_PaperAttentionWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperAttention_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperAttention_Sel.length == 0)
                return arrgs_PaperAttention_Sel;
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
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort(gs_PaperAttention_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.slice(intStart, intEnd);
            return arrgs_PaperAttention_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperAttention_GetObjLstByPager_Cache = gs_PaperAttention_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperAttention_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperAttention_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetObjLstByPagerAsync = gs_PaperAttention_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param lngPaperAttentionId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperAttention_DelRecordAsync(lngPaperAttentionId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, lngPaperAttentionId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": lngPaperAttentionId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_DelRecordAsync = gs_PaperAttention_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperAttentionId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperAttention_Delgs_PaperAttentionsAsync(arrPaperAttentionId) {
        const strThisFuncName = "Delgs_PaperAttentionsAsync";
        const strAction = "Delgs_PaperAttentions";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperAttentionId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_Delgs_PaperAttentionsAsync = gs_PaperAttention_Delgs_PaperAttentionsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperAttention_Delgs_PaperAttentionsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperAttentionsByCondAsync";
        const strAction = "Delgs_PaperAttentionsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_Delgs_PaperAttentionsByCondAsync = gs_PaperAttention_Delgs_PaperAttentionsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperAttentionEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperAttention_AddNewRecordAsync(objgs_PaperAttentionEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperAttentionEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperAttentionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_AddNewRecordAsync = gs_PaperAttention_AddNewRecordAsync;
    /* 数据类型不是字符型，不可以最大关键字的方式添加记录。*/
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperAttentionEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperAttention_AddNewRecordWithReturnKeyAsync(objgs_PaperAttentionEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperAttentionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_AddNewRecordWithReturnKeyAsync = gs_PaperAttention_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperAttentionEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperAttention_AddNewRecordWithReturnKey(objgs_PaperAttentionEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperAttentionEN.paperAttentionId === null || objgs_PaperAttentionEN.paperAttentionId === 0) {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperAttentionEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_AddNewRecordWithReturnKey = gs_PaperAttention_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperAttentionEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperAttention_UpdateRecordAsync(objgs_PaperAttentionEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperAttentionEN.sf_UpdFldSetStr === undefined || objgs_PaperAttentionEN.sf_UpdFldSetStr === null || objgs_PaperAttentionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperAttentionEN.paperAttentionId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperAttentionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_UpdateRecordAsync = gs_PaperAttention_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperAttentionEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperAttention_UpdateWithConditionAsync(objgs_PaperAttentionEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperAttentionEN.sf_UpdFldSetStr === undefined || objgs_PaperAttentionEN.sf_UpdFldSetStr === null || objgs_PaperAttentionEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperAttentionEN.paperAttentionId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        objgs_PaperAttentionEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperAttentionEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_UpdateWithConditionAsync = gs_PaperAttention_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objlngPaperAttentionId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperAttention_IsExistRecord_Cache(objgs_PaperAttention_Cond, strUserId) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
        if (arrgs_PaperAttentionObjLst_Cache == null)
            return false;
        let arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache;
        if (objgs_PaperAttention_Cond.sf_FldComparisonOp == null || objgs_PaperAttention_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperAttention_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_PaperAttention_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperAttention_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperAttention_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperAttention_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_PaperAttention_Cond), exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_PaperAttention_IsExistRecord_Cache = gs_PaperAttention_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperAttention_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_IsExistRecordAsync = gs_PaperAttention_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param lngPaperAttentionId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperAttention_IsExist(lngPaperAttentionId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperAttentionId": lngPaperAttentionId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_IsExist = gs_PaperAttention_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param lngPaperAttentionId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperAttention_IsExist_Cache(lngPaperAttentionId, strUserId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
        if (arrgs_PaperAttentionObjLst_Cache == null)
            return false;
        try {
            const arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache.filter(x => x.paperAttentionId == lngPaperAttentionId);
            if (arrgs_PaperAttention_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", lngPaperAttentionId, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_PaperAttention_IsExist_Cache = gs_PaperAttention_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param lngPaperAttentionId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperAttention_IsExistAsync(lngPaperAttentionId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "lngPaperAttentionId": lngPaperAttentionId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_IsExistAsync = gs_PaperAttention_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperAttention_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetRecCountByCondAsync = gs_PaperAttention_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_PaperAttention_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_PaperAttention_GetRecCountByCond_Cache(objgs_PaperAttention_Cond, strUserId) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_PaperAttentionObjLst_Cache = await gs_PaperAttention_GetObjLst_Cache(strUserId);
        if (arrgs_PaperAttentionObjLst_Cache == null)
            return 0;
        let arrgs_PaperAttention_Sel = arrgs_PaperAttentionObjLst_Cache;
        if (objgs_PaperAttention_Cond.sf_FldComparisonOp == null || objgs_PaperAttention_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperAttention_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_PaperAttention_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperAttentionWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperAttention_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperAttention_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperAttention_Sel = arrgs_PaperAttention_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperAttention_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperAttention_Cond), exports.gs_PaperAttention_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_PaperAttention_GetRecCountByCond_Cache = gs_PaperAttention_GetRecCountByCond_Cache;
    /*该表的关键字类型不是字符型自增，不需要生成获取最大关键字函数！*/
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_PaperAttention_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperAttention_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperAttention_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperAttention_GetMaxStrIdByPrefix = gs_PaperAttention_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperAttention_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperAttention_GetWebApiUrl = gs_PaperAttention_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_PaperAttention_ReFreshCache(strUserId) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strUserId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strUserId]不能为空！(In clsgs_PaperAttentionWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
        switch (clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheModeId) {
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
        (0, clsvgs_PaperAttentionWApi_js_1.vgs_PaperAttention_ReFreshThisCache)(strUserId);
    }
    exports.gs_PaperAttention_ReFreshCache = gs_PaperAttention_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_PaperAttention_ReFreshThisCache(strUserId) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN._CurrTabName, strUserId);
            switch (clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.CacheModeId) {
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
    exports.gs_PaperAttention_ReFreshThisCache = gs_PaperAttention_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperAttention_CheckPropertyNew(pobjgs_PaperAttentionEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updUser) === true) {
            throw new Error("(errid:Watl000058)字段[修改人]不能为空(In 论文关注)!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.paperId)(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.userId)(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperGroupId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.paperGroupId) > 8) {
            throw new Error("(errid:Watl000059)字段[组Id(paperGroupId)]的长度不能超过8(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.paperGroupId)(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.updUser)(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.updDate)(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.meno) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.meno) > 2000) {
            throw new Error("(errid:Watl000059)字段[备注(meno)]的长度不能超过2000(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.meno)(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperAttentionEN.paperAttentionId && undefined !== pobjgs_PaperAttentionEN.paperAttentionId && jsString_js_1.tzDataType.isNumber(pobjgs_PaperAttentionEN.paperAttentionId) === false) {
            throw new Error("(errid:Watl000060)字段[论文收藏Id(paperAttentionId)]的值:[$(pobjgs_PaperAttentionEN.paperAttentionId)], 非法，应该为数值型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperId) == false && undefined !== pobjgs_PaperAttentionEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperAttentionEN.paperId)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.userId) == false && undefined !== pobjgs_PaperAttentionEN.userId && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjgs_PaperAttentionEN.userId)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperGroupId) == false && undefined !== pobjgs_PaperAttentionEN.paperGroupId && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.paperGroupId) === false) {
            throw new Error("(errid:Watl000060)字段[组Id(paperGroupId)]的值:[$(pobjgs_PaperAttentionEN.paperGroupId)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updUser) == false && undefined !== pobjgs_PaperAttentionEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperAttentionEN.updUser)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updDate) == false && undefined !== pobjgs_PaperAttentionEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperAttentionEN.updDate)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.meno) == false && undefined !== pobjgs_PaperAttentionEN.meno && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.meno) === false) {
            throw new Error("(errid:Watl000060)字段[备注(meno)]的值:[$(pobjgs_PaperAttentionEN.meno)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperAttentionEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperAttention_CheckPropertyNew = gs_PaperAttention_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperAttention_CheckProperty4Update(pobjgs_PaperAttentionEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.paperId)(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.userId)(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperGroupId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.paperGroupId) > 8) {
            throw new Error("(errid:Watl000062)字段[组Id(paperGroupId)]的长度不能超过8(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.paperGroupId)(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.updUser)(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.updDate)(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.meno) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperAttentionEN.meno) > 2000) {
            throw new Error("(errid:Watl000062)字段[备注(meno)]的长度不能超过2000(In 论文关注(gs_PaperAttention))!值:$(pobjgs_PaperAttentionEN.meno)(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if (null != pobjgs_PaperAttentionEN.paperAttentionId && undefined !== pobjgs_PaperAttentionEN.paperAttentionId && jsString_js_1.tzDataType.isNumber(pobjgs_PaperAttentionEN.paperAttentionId) === false) {
            throw new Error("(errid:Watl000063)字段[论文收藏Id(paperAttentionId)]的值:[$(pobjgs_PaperAttentionEN.paperAttentionId)], 非法，应该为数值型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperId) == false && undefined !== pobjgs_PaperAttentionEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperAttentionEN.paperId)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.userId) == false && undefined !== pobjgs_PaperAttentionEN.userId && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjgs_PaperAttentionEN.userId)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.paperGroupId) == false && undefined !== pobjgs_PaperAttentionEN.paperGroupId && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.paperGroupId) === false) {
            throw new Error("(errid:Watl000063)字段[组Id(paperGroupId)]的值:[$(pobjgs_PaperAttentionEN.paperGroupId)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updUser) == false && undefined !== pobjgs_PaperAttentionEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperAttentionEN.updUser)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.updDate) == false && undefined !== pobjgs_PaperAttentionEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperAttentionEN.updDate)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperAttentionEN.meno) == false && undefined !== pobjgs_PaperAttentionEN.meno && jsString_js_1.tzDataType.isString(pobjgs_PaperAttentionEN.meno) === false) {
            throw new Error("(errid:Watl000063)字段[备注(meno)]的值:[$(pobjgs_PaperAttentionEN.meno)], 非法，应该为字符型(In 论文关注(gs_PaperAttention))!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if (null === pobjgs_PaperAttentionEN.paperAttentionId
            || pobjgs_PaperAttentionEN.paperAttentionId != null && pobjgs_PaperAttentionEN.paperAttentionId.toString() === "") {
            throw new Error("(errid:Watl000064)字段[论文收藏Id]不能为空(In 论文关注)!(clsgs_PaperAttentionBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperAttentionEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperAttention_CheckProperty4Update = gs_PaperAttention_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperAttention_GetJSONStrByObj(pobjgs_PaperAttentionEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperAttentionEN.sf_UpdFldSetStr = pobjgs_PaperAttentionEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperAttentionEN);
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
    exports.gs_PaperAttention_GetJSONStrByObj = gs_PaperAttention_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperAttention_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperAttentionObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperAttentionObjLst;
        }
        try {
            arrgs_PaperAttentionObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperAttentionObjLst;
        }
        return arrgs_PaperAttentionObjLst;
    }
    exports.gs_PaperAttention_GetObjLstByJSONStr = gs_PaperAttention_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperAttentionObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperAttention_GetObjLstByJSONObjLst(arrgs_PaperAttentionObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperAttentionObjLst = new Array();
        for (const objInFor of arrgs_PaperAttentionObjLstS) {
            const obj1 = gs_PaperAttention_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperAttentionObjLst.push(obj1);
        }
        return arrgs_PaperAttentionObjLst;
    }
    exports.gs_PaperAttention_GetObjLstByJSONObjLst = gs_PaperAttention_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperAttention_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperAttentionEN = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
        if (strJSON === "") {
            return pobjgs_PaperAttentionEN;
        }
        try {
            pobjgs_PaperAttentionEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperAttentionEN;
        }
        return pobjgs_PaperAttentionEN;
    }
    exports.gs_PaperAttention_GetObjByJSONStr = gs_PaperAttention_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperAttention_GetCombineCondition(objgs_PaperAttention_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId) == true) {
            const strComparisonOp_PaperAttentionId = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperAttentionId, objgs_PaperAttention_Cond.paperAttentionId, strComparisonOp_PaperAttentionId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperId, objgs_PaperAttention_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UserId) == true) {
            const strComparisonOp_UserId = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UserId, objgs_PaperAttention_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperGroupId) == true) {
            const strComparisonOp_PaperGroupId = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperGroupId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_PaperGroupId, objgs_PaperAttention_Cond.paperGroupId, strComparisonOp_PaperGroupId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdUser, objgs_PaperAttention_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_UpdDate, objgs_PaperAttention_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperAttention_Cond.dicFldComparisonOp, clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_Meno) == true) {
            const strComparisonOp_Meno = objgs_PaperAttention_Cond.dicFldComparisonOp[clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_Meno];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN.con_Meno, objgs_PaperAttention_Cond.meno, strComparisonOp_Meno);
        }
        return strWhereCond;
    }
    exports.gs_PaperAttention_GetCombineCondition = gs_PaperAttention_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperAttention(论文关注),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperAttention_GetUniCondStr_PaperId_UserId(objgs_PaperAttentionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objgs_PaperAttentionEN.paperId);
        strWhereCond += (0, clsString_js_1.Format)(" and UserId = '{0}'", objgs_PaperAttentionEN.userId);
        return strWhereCond;
    }
    exports.gs_PaperAttention_GetUniCondStr_PaperId_UserId = gs_PaperAttention_GetUniCondStr_PaperId_UserId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperAttention(论文关注),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @param strUserId: 用户ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperAttention_GetUniCondStr4Update_PaperId_UserId(objgs_PaperAttentionEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and PaperAttentionId <> '{0}'", objgs_PaperAttentionEN.paperAttentionId);
        strWhereCond += (0, clsString_js_1.Format)(" and PaperId = '{0}'", objgs_PaperAttentionEN.paperId);
        strWhereCond += (0, clsString_js_1.Format)(" and UserId = '{0}'", objgs_PaperAttentionEN.userId);
        return strWhereCond;
    }
    exports.gs_PaperAttention_GetUniCondStr4Update_PaperId_UserId = gs_PaperAttention_GetUniCondStr4Update_PaperId_UserId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperAttentionENS:源对象
     * @param objgs_PaperAttentionENT:目标对象
    */
    function gs_PaperAttention_CopyObjTo(objgs_PaperAttentionENS, objgs_PaperAttentionENT) {
        objgs_PaperAttentionENT.paperAttentionId = objgs_PaperAttentionENS.paperAttentionId; //论文收藏Id
        objgs_PaperAttentionENT.paperId = objgs_PaperAttentionENS.paperId; //论文Id
        objgs_PaperAttentionENT.userId = objgs_PaperAttentionENS.userId; //用户ID
        objgs_PaperAttentionENT.paperGroupId = objgs_PaperAttentionENS.paperGroupId; //组Id
        objgs_PaperAttentionENT.updUser = objgs_PaperAttentionENS.updUser; //修改人
        objgs_PaperAttentionENT.updDate = objgs_PaperAttentionENS.updDate; //修改日期
        objgs_PaperAttentionENT.meno = objgs_PaperAttentionENS.meno; //备注
        objgs_PaperAttentionENT.sf_UpdFldSetStr = objgs_PaperAttentionENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperAttention_CopyObjTo = gs_PaperAttention_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperAttentionENS:源对象
     * @param objgs_PaperAttentionENT:目标对象
    */
    function gs_PaperAttention_GetObjFromJsonObj(objgs_PaperAttentionENS) {
        const objgs_PaperAttentionENT = new clsgs_PaperAttentionEN_js_1.clsgs_PaperAttentionEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperAttentionENT, objgs_PaperAttentionENS);
        return objgs_PaperAttentionENT;
    }
    exports.gs_PaperAttention_GetObjFromJsonObj = gs_PaperAttention_GetObjFromJsonObj;
});
