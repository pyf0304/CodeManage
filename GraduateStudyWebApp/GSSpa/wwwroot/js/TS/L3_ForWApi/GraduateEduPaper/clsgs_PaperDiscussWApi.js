/**
* 类名:clsgs_PaperDiscussWApi
* 表名:gs_PaperDiscuss(01120681)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 11:46:40
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperDiscussEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperDiscuss_GetObjFromJsonObj = exports.gs_PaperDiscuss_CopyObjTo = exports.gs_PaperDiscuss_GetUniCondStr4Update_DiscussId = exports.gs_PaperDiscuss_GetUniCondStr_DiscussId = exports.gs_PaperDiscuss_GetCombineCondition = exports.gs_PaperDiscuss_GetObjByJSONStr = exports.gs_PaperDiscuss_GetObjLstByJSONObjLst = exports.gs_PaperDiscuss_GetObjLstByJSONStr = exports.gs_PaperDiscuss_GetJSONStrByObj = exports.gs_PaperDiscuss_CheckProperty4Update = exports.gs_PaperDiscuss_CheckPropertyNew = exports.gs_PaperDiscuss_ReFreshThisCache = exports.gs_PaperDiscuss_ReFreshCache = exports.gs_PaperDiscuss_GetWebApiUrl = exports.gs_PaperDiscuss_GetMaxStrIdByPrefix = exports.gs_PaperDiscuss_GetMaxStrIdAsync = exports.gs_PaperDiscuss_GetRecCountByCond_Cache = exports.gs_PaperDiscuss_GetRecCountByCondAsync = exports.gs_PaperDiscuss_IsExistAsync = exports.gs_PaperDiscuss_IsExist_Cache = exports.gs_PaperDiscuss_IsExist = exports.gs_PaperDiscuss_IsExistRecordAsync = exports.gs_PaperDiscuss_IsExistRecord_Cache = exports.gs_PaperDiscuss_UpdateWithConditionAsync = exports.gs_PaperDiscuss_UpdateRecordAsync = exports.gs_PaperDiscuss_AddNewRecordWithReturnKey = exports.gs_PaperDiscuss_AddNewRecordWithReturnKeyAsync = exports.gs_PaperDiscuss_AddNewRecordWithMaxIdAsync = exports.gs_PaperDiscuss_AddNewRecordAsync = exports.gs_PaperDiscuss_Delgs_PaperDiscusssByCondAsync = exports.gs_PaperDiscuss_Delgs_PaperDiscusssAsync = exports.gs_PaperDiscuss_DelRecordAsync = exports.gs_PaperDiscuss_GetObjLstByPagerAsync = exports.gs_PaperDiscuss_GetObjLstByPager_Cache = exports.gs_PaperDiscuss_GetObjLstByRange = exports.gs_PaperDiscuss_GetObjLstByRangeAsync = exports.gs_PaperDiscuss_GetTopObjLstAsync = exports.gs_PaperDiscuss_GetObjLstByDiscussIdLst_Cache = exports.gs_PaperDiscuss_GetObjLstByDiscussIdLstAsync = exports.gs_PaperDiscuss_GetSubObjLst_Cache = exports.gs_PaperDiscuss_GetObjLst_PureCache = exports.gs_PaperDiscuss_GetObjLst_Cache = exports.gs_PaperDiscuss_GetObjLst_sessionStorage_PureCache = exports.gs_PaperDiscuss_GetObjLst_sessionStorage = exports.gs_PaperDiscuss_GetObjLstAsync = exports.gs_PaperDiscuss_GetObjLst_localStorage_PureCache = exports.gs_PaperDiscuss_GetObjLst_localStorage = exports.gs_PaperDiscuss_GetObjLst_ClientCache = exports.gs_PaperDiscuss_GetFirstObjAsync = exports.gs_PaperDiscuss_GetFirstID = exports.gs_PaperDiscuss_GetFirstIDAsync = exports.gs_PaperDiscuss_FilterFunByKey = exports.gs_PaperDiscuss_SortFunByKey = exports.gs_PaperDiscuss_SortFun_Defa_2Fld = exports.gs_PaperDiscuss_SortFun_Defa = exports.gs_PaperDiscuss_func = exports.gs_PaperDiscuss_UpdateObjInLst_Cache = exports.gs_PaperDiscuss_GetObjByDiscussId_localStorage = exports.gs_PaperDiscuss_GetObjByDiscussId_Cache = exports.gs_PaperDiscuss_GetObjByDiscussIdAsync = exports.gs_PaperDiscuss_ConstructorName = exports.gs_PaperDiscuss_Controller = void 0;
    /**
     * 论文讨论表(gs_PaperDiscuss)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_PaperDiscussEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperDiscussEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_PaperDiscuss_Controller = "gs_PaperDiscussApi";
    exports.gs_PaperDiscuss_ConstructorName = "gs_PaperDiscuss";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strDiscussId:关键字
    * @returns 对象
    **/
    async function gs_PaperDiscuss_GetObjByDiscussIdAsync(strDiscussId) {
        const strThisFuncName = "GetObjByDiscussIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strDiscussId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strDiscussId]不能为空！(In GetObjByDiscussIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDiscussId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strDiscussId]的长度:[{0}]不正确！", strDiscussId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByDiscussId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strDiscussId": strDiscussId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperDiscuss = gs_PaperDiscuss_GetObjFromJsonObj(returnObj);
                return objgs_PaperDiscuss;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetObjByDiscussIdAsync = gs_PaperDiscuss_GetObjByDiscussIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strDiscussId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperDiscuss_GetObjByDiscussId_Cache(strDiscussId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByDiscussId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strDiscussId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strDiscussId]不能为空！(In GetObjByDiscussId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDiscussId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strDiscussId]的长度:[{0}]不正确！", strDiscussId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
        try {
            const arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache.filter(x => x.discussId == strDiscussId);
            let objgs_PaperDiscuss;
            if (arrgs_PaperDiscuss_Sel.length > 0) {
                objgs_PaperDiscuss = arrgs_PaperDiscuss_Sel[0];
                return objgs_PaperDiscuss;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_PaperDiscuss = await gs_PaperDiscuss_GetObjByDiscussIdAsync(strDiscussId);
                    if (objgs_PaperDiscuss != null) {
                        gs_PaperDiscuss_ReFreshThisCache();
                        return objgs_PaperDiscuss;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDiscussId, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_PaperDiscuss_GetObjByDiscussId_Cache = gs_PaperDiscuss_GetObjByDiscussId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strDiscussId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperDiscuss_GetObjByDiscussId_localStorage(strDiscussId) {
        const strThisFuncName = "GetObjByDiscussId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strDiscussId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strDiscussId]不能为空！(In GetObjByDiscussId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strDiscussId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strDiscussId]的长度:[{0}]不正确！", strDiscussId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName, strDiscussId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_PaperDiscuss_Cache = JSON.parse(strTempObj);
            return objgs_PaperDiscuss_Cache;
        }
        try {
            const objgs_PaperDiscuss = await gs_PaperDiscuss_GetObjByDiscussIdAsync(strDiscussId);
            if (objgs_PaperDiscuss != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_PaperDiscuss));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_PaperDiscuss;
            }
            return objgs_PaperDiscuss;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strDiscussId, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_PaperDiscuss_GetObjByDiscussId_localStorage = gs_PaperDiscuss_GetObjByDiscussId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_PaperDiscuss:所给的对象
     * @returns 对象
    */
    async function gs_PaperDiscuss_UpdateObjInLst_Cache(objgs_PaperDiscuss) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
            const obj = arrgs_PaperDiscussObjLst_Cache.find(x => x.discussId == objgs_PaperDiscuss.discussId);
            if (obj != null) {
                objgs_PaperDiscuss.discussId = obj.discussId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_PaperDiscuss);
            }
            else {
                arrgs_PaperDiscussObjLst_Cache.push(objgs_PaperDiscuss);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_PaperDiscuss_UpdateObjInLst_Cache = gs_PaperDiscuss_UpdateObjInLst_Cache;
    /*该表没有名称字段，不能生成此函数！*/
    /**
     * 映射函数。根据表映射把输入字段值，映射成输出字段值
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_func)
     * @param strInFldName:输入字段名
     * @param strOutFldName:输出字段名
     * @param strInValue:输入字段值
     * @returns 返回一个输出字段值
    */
    async function gs_PaperDiscuss_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strDiscussId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_PaperDiscuss = await gs_PaperDiscuss_GetObjByDiscussId_Cache(strDiscussId);
        if (objgs_PaperDiscuss == null)
            return "";
        return objgs_PaperDiscuss.GetFldValue(strOutFldName).toString();
    }
    exports.gs_PaperDiscuss_func = gs_PaperDiscuss_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperDiscuss_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.discussId.localeCompare(b.discussId);
    }
    exports.gs_PaperDiscuss_SortFun_Defa = gs_PaperDiscuss_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperDiscuss_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.discussContent == b.discussContent)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.discussContent.localeCompare(b.discussContent);
    }
    exports.gs_PaperDiscuss_SortFun_Defa_2Fld = gs_PaperDiscuss_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperDiscuss_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId:
                    return (a, b) => {
                        return a.discussId.localeCompare(b.discussId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussContent:
                    return (a, b) => {
                        return a.discussContent.localeCompare(b.discussContent);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ScoreType:
                    return (a, b) => {
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussTypeId:
                    return (a, b) => {
                        return a.discussTypeId.localeCompare(b.discussTypeId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperDiscuss]中不存在！(in ${exports.gs_PaperDiscuss_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId:
                    return (a, b) => {
                        return b.discussId.localeCompare(a.discussId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussContent:
                    return (a, b) => {
                        return b.discussContent.localeCompare(a.discussContent);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ScoreType:
                    return (a, b) => {
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussTypeId:
                    return (a, b) => {
                        return b.discussTypeId.localeCompare(a.discussTypeId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperDiscuss]中不存在！(in ${exports.gs_PaperDiscuss_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperDiscuss_SortFunByKey = gs_PaperDiscuss_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperDiscuss_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId:
                return (obj) => {
                    return obj.discussId === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussContent:
                return (obj) => {
                    return obj.discussContent === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussTypeId:
                return (obj) => {
                    return obj.discussTypeId === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperDiscuss]中不存在！(in ${exports.gs_PaperDiscuss_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperDiscuss_FilterFunByKey = gs_PaperDiscuss_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperDiscuss_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetFirstIDAsync = gs_PaperDiscuss_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperDiscuss_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetFirstID = gs_PaperDiscuss_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperDiscuss_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperDiscuss = gs_PaperDiscuss_GetObjFromJsonObj(returnObj);
                return objgs_PaperDiscuss;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetFirstObjAsync = gs_PaperDiscuss_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
        clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_PaperDiscussExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_PaperDiscussObjLst_T = gs_PaperDiscuss_GetObjLstByJSONObjLst(arrgs_PaperDiscussExObjLst_Cache);
            return arrgs_PaperDiscussObjLst_T;
        }
        try {
            const arrgs_PaperDiscussExObjLst = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_PaperDiscussExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperDiscussExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperDiscussExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperDiscuss_GetObjLst_ClientCache = gs_PaperDiscuss_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
        clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperDiscussExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperDiscussObjLst_T = gs_PaperDiscuss_GetObjLstByJSONObjLst(arrgs_PaperDiscussExObjLst_Cache);
            return arrgs_PaperDiscussObjLst_T;
        }
        try {
            const arrgs_PaperDiscussExObjLst = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_PaperDiscussExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperDiscussExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperDiscussExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperDiscuss_GetObjLst_localStorage = gs_PaperDiscuss_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperDiscussObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperDiscussObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperDiscuss_GetObjLst_localStorage_PureCache = gs_PaperDiscuss_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperDiscuss_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetObjLstAsync = gs_PaperDiscuss_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
        clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperDiscussExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperDiscussObjLst_T = gs_PaperDiscuss_GetObjLstByJSONObjLst(arrgs_PaperDiscussExObjLst_Cache);
            return arrgs_PaperDiscussObjLst_T;
        }
        try {
            const arrgs_PaperDiscussExObjLst = await gs_PaperDiscuss_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperDiscussExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperDiscussExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperDiscussExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperDiscuss_GetObjLst_sessionStorage = gs_PaperDiscuss_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperDiscussObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperDiscussObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperDiscuss_GetObjLst_sessionStorage_PureCache = gs_PaperDiscuss_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_PaperDiscussObjLst_Cache;
        switch (clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_ClientCache();
                break;
            default:
                arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_ClientCache();
                break;
        }
        const arrgs_PaperDiscussObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst(arrgs_PaperDiscussObjLst_Cache);
        return arrgs_PaperDiscussObjLst_Cache;
    }
    exports.gs_PaperDiscuss_GetObjLst_Cache = gs_PaperDiscuss_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperDiscuss_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_PaperDiscussObjLst_Cache;
        switch (clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_PaperDiscussObjLst_Cache = null;
                break;
            default:
                arrgs_PaperDiscussObjLst_Cache = null;
                break;
        }
        return arrgs_PaperDiscussObjLst_Cache;
    }
    exports.gs_PaperDiscuss_GetObjLst_PureCache = gs_PaperDiscuss_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrDiscussId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperDiscuss_GetSubObjLst_Cache(objgs_PaperDiscuss_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
        let arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache;
        if (objgs_PaperDiscuss_Cond.sf_FldComparisonOp == null || objgs_PaperDiscuss_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperDiscuss_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_PaperDiscuss_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperDiscussWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperDiscuss_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperDiscuss_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperDiscuss_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperDiscuss_Cond), exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperDiscuss_GetSubObjLst_Cache = gs_PaperDiscuss_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrDiscussId:关键字列表
    * @returns 对象列表
    **/
    async function gs_PaperDiscuss_GetObjLstByDiscussIdLstAsync(arrDiscussId) {
        const strThisFuncName = "GetObjLstByDiscussIdLstAsync";
        const strAction = "GetObjLstByDiscussIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrDiscussId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetObjLstByDiscussIdLstAsync = gs_PaperDiscuss_GetObjLstByDiscussIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrDiscussIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_PaperDiscuss_GetObjLstByDiscussIdLst_Cache(arrDiscussIdLst) {
        const strThisFuncName = "GetObjLstByDiscussIdLst_Cache";
        try {
            const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
            const arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache.filter(x => arrDiscussIdLst.indexOf(x.discussId) > -1);
            return arrgs_PaperDiscuss_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrDiscussIdLst.join(","), exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperDiscuss_GetObjLstByDiscussIdLst_Cache = gs_PaperDiscuss_GetObjLstByDiscussIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperDiscuss_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetTopObjLstAsync = gs_PaperDiscuss_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperDiscuss_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetObjLstByRangeAsync = gs_PaperDiscuss_GetObjLstByRangeAsync;
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
    async function gs_PaperDiscuss_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetObjLstByRange = gs_PaperDiscuss_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperDiscuss_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
        if (arrgs_PaperDiscussObjLst_Cache.length == 0)
            return arrgs_PaperDiscussObjLst_Cache;
        let arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_PaperDiscuss_Cond = new clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperDiscuss_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_PaperDiscussWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperDiscuss_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperDiscuss_Sel.length == 0)
                return arrgs_PaperDiscuss_Sel;
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
                arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.sort(gs_PaperDiscuss_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.slice(intStart, intEnd);
            return arrgs_PaperDiscuss_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperDiscuss_GetObjLstByPager_Cache = gs_PaperDiscuss_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperDiscuss_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetObjLstByPagerAsync = gs_PaperDiscuss_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strDiscussId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperDiscuss_DelRecordAsync(strDiscussId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strDiscussId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strDiscussId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_DelRecordAsync = gs_PaperDiscuss_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrDiscussId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperDiscuss_Delgs_PaperDiscusssAsync(arrDiscussId) {
        const strThisFuncName = "Delgs_PaperDiscusssAsync";
        const strAction = "Delgs_PaperDiscusss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrDiscussId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_Delgs_PaperDiscusssAsync = gs_PaperDiscuss_Delgs_PaperDiscusssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperDiscuss_Delgs_PaperDiscusssByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperDiscusssByCondAsync";
        const strAction = "Delgs_PaperDiscusssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_Delgs_PaperDiscusssByCondAsync = gs_PaperDiscuss_Delgs_PaperDiscusssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperDiscussEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperDiscuss_AddNewRecordAsync(objgs_PaperDiscussEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperDiscussEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperDiscussEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_AddNewRecordAsync = gs_PaperDiscuss_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_PaperDiscussEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperDiscuss_AddNewRecordWithMaxIdAsync(objgs_PaperDiscussEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperDiscussEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_AddNewRecordWithMaxIdAsync = gs_PaperDiscuss_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperDiscussEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperDiscuss_AddNewRecordWithReturnKeyAsync(objgs_PaperDiscussEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperDiscussEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_AddNewRecordWithReturnKeyAsync = gs_PaperDiscuss_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperDiscussEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperDiscuss_AddNewRecordWithReturnKey(objgs_PaperDiscussEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperDiscussEN.discussId === null || objgs_PaperDiscussEN.discussId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperDiscussEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_AddNewRecordWithReturnKey = gs_PaperDiscuss_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperDiscussEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperDiscuss_UpdateRecordAsync(objgs_PaperDiscussEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperDiscussEN.sf_UpdFldSetStr === undefined || objgs_PaperDiscussEN.sf_UpdFldSetStr === null || objgs_PaperDiscussEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperDiscussEN.discussId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperDiscussEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_UpdateRecordAsync = gs_PaperDiscuss_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperDiscussEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperDiscuss_UpdateWithConditionAsync(objgs_PaperDiscussEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperDiscussEN.sf_UpdFldSetStr === undefined || objgs_PaperDiscussEN.sf_UpdFldSetStr === null || objgs_PaperDiscussEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperDiscussEN.discussId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        objgs_PaperDiscussEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperDiscussEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_UpdateWithConditionAsync = gs_PaperDiscuss_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrDiscussId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperDiscuss_IsExistRecord_Cache(objgs_PaperDiscuss_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
        if (arrgs_PaperDiscussObjLst_Cache == null)
            return false;
        let arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache;
        if (objgs_PaperDiscuss_Cond.sf_FldComparisonOp == null || objgs_PaperDiscuss_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperDiscuss_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_PaperDiscuss_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperDiscussWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperDiscuss_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperDiscuss_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperDiscuss_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_PaperDiscuss_Cond), exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_PaperDiscuss_IsExistRecord_Cache = gs_PaperDiscuss_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperDiscuss_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_IsExistRecordAsync = gs_PaperDiscuss_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strDiscussId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperDiscuss_IsExist(strDiscussId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "DiscussId": strDiscussId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_IsExist = gs_PaperDiscuss_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strDiscussId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperDiscuss_IsExist_Cache(strDiscussId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
        if (arrgs_PaperDiscussObjLst_Cache == null)
            return false;
        try {
            const arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache.filter(x => x.discussId == strDiscussId);
            if (arrgs_PaperDiscuss_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strDiscussId, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_PaperDiscuss_IsExist_Cache = gs_PaperDiscuss_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strDiscussId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperDiscuss_IsExistAsync(strDiscussId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strDiscussId": strDiscussId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_IsExistAsync = gs_PaperDiscuss_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperDiscuss_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetRecCountByCondAsync = gs_PaperDiscuss_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_PaperDiscuss_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_PaperDiscuss_GetRecCountByCond_Cache(objgs_PaperDiscuss_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_PaperDiscussObjLst_Cache = await gs_PaperDiscuss_GetObjLst_Cache();
        if (arrgs_PaperDiscussObjLst_Cache == null)
            return 0;
        let arrgs_PaperDiscuss_Sel = arrgs_PaperDiscussObjLst_Cache;
        if (objgs_PaperDiscuss_Cond.sf_FldComparisonOp == null || objgs_PaperDiscuss_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperDiscuss_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_PaperDiscuss_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperDiscussWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperDiscuss_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperDiscuss_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperDiscuss_Sel = arrgs_PaperDiscuss_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperDiscuss_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperDiscuss_Cond), exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_PaperDiscuss_GetRecCountByCond_Cache = gs_PaperDiscuss_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_PaperDiscuss_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetMaxStrIdAsync = gs_PaperDiscuss_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_PaperDiscuss_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperDiscuss_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperDiscuss_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperDiscuss_GetMaxStrIdByPrefix = gs_PaperDiscuss_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperDiscuss_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperDiscuss_GetWebApiUrl = gs_PaperDiscuss_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_PaperDiscuss_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
        switch (clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheModeId) {
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
    exports.gs_PaperDiscuss_ReFreshCache = gs_PaperDiscuss_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_PaperDiscuss_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN._CurrTabName;
            switch (clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.CacheModeId) {
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
    exports.gs_PaperDiscuss_ReFreshThisCache = gs_PaperDiscuss_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperDiscuss_CheckPropertyNew(pobjgs_PaperDiscussEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussContent) === true) {
            throw new Error("(errid:Watl000058)字段[讨论内容]不能为空(In 论文讨论表)!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.paperId) === true
            || pobjgs_PaperDiscussEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文讨论表)!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.parentId) === true) {
            throw new Error("(errid:Watl000058)字段[父节点Id]不能为空(In 论文讨论表)!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[讨论类型Id]不能为空(In 论文讨论表)!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.id_CurrEduCls) === true
            || pobjgs_PaperDiscussEN.id_CurrEduCls.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[教学班流水号]不能为空(In 论文讨论表)!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.discussId) > 10) {
            throw new Error("(errid:Watl000059)字段[讨论ID(discussId)]的长度不能超过10(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.discussId)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussContent) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.discussContent) > 2000) {
            throw new Error("(errid:Watl000059)字段[讨论内容(discussContent)]的长度不能超过2000(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.discussContent)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.paperId)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.parentId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.parentId) > 10) {
            throw new Error("(errid:Watl000059)字段[父节点Id(parentId)]的长度不能超过10(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.parentId)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.scoreType) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.scoreType) > 1) {
            throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.scoreType)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.discussTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[讨论类型Id(discussTypeId)]的长度不能超过2(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.discussTypeId)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.userId) > 20) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过20(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.userId)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.updUser)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.updDate)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.id_CurrEduCls)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.memo)(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussId) == false && undefined !== pobjgs_PaperDiscussEN.discussId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.discussId) === false) {
            throw new Error("(errid:Watl000060)字段[讨论ID(discussId)]的值:[$(pobjgs_PaperDiscussEN.discussId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussContent) == false && undefined !== pobjgs_PaperDiscussEN.discussContent && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.discussContent) === false) {
            throw new Error("(errid:Watl000060)字段[讨论内容(discussContent)]的值:[$(pobjgs_PaperDiscussEN.discussContent)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.paperId) == false && undefined !== pobjgs_PaperDiscussEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperDiscussEN.paperId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.parentId) == false && undefined !== pobjgs_PaperDiscussEN.parentId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父节点Id(parentId)]的值:[$(pobjgs_PaperDiscussEN.parentId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperDiscussEN.score && undefined !== pobjgs_PaperDiscussEN.score && jsString_js_1.tzDataType.isNumber(pobjgs_PaperDiscussEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjgs_PaperDiscussEN.score)], 非法，应该为数值型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.scoreType) == false && undefined !== pobjgs_PaperDiscussEN.scoreType && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.scoreType) === false) {
            throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjgs_PaperDiscussEN.scoreType)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussTypeId) == false && undefined !== pobjgs_PaperDiscussEN.discussTypeId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.discussTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[讨论类型Id(discussTypeId)]的值:[$(pobjgs_PaperDiscussEN.discussTypeId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.userId) == false && undefined !== pobjgs_PaperDiscussEN.userId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjgs_PaperDiscussEN.userId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperDiscussEN.voteCount && undefined !== pobjgs_PaperDiscussEN.voteCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperDiscussEN.voteCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjgs_PaperDiscussEN.voteCount)], 非法，应该为数值型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updUser) == false && undefined !== pobjgs_PaperDiscussEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperDiscussEN.updUser)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updDate) == false && undefined !== pobjgs_PaperDiscussEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperDiscussEN.updDate)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperDiscussEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperDiscussEN.id_CurrEduCls)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.memo) == false && undefined !== pobjgs_PaperDiscussEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperDiscussEN.memo)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperDiscussEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperDiscuss_CheckPropertyNew = gs_PaperDiscuss_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperDiscuss_CheckProperty4Update(pobjgs_PaperDiscussEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.discussId) > 10) {
            throw new Error("(errid:Watl000062)字段[讨论ID(discussId)]的长度不能超过10(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.discussId)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussContent) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.discussContent) > 2000) {
            throw new Error("(errid:Watl000062)字段[讨论内容(discussContent)]的长度不能超过2000(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.discussContent)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.paperId)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.parentId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.parentId) > 10) {
            throw new Error("(errid:Watl000062)字段[父节点Id(parentId)]的长度不能超过10(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.parentId)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.scoreType) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.scoreType) > 1) {
            throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.scoreType)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.discussTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[讨论类型Id(discussTypeId)]的长度不能超过2(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.discussTypeId)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.userId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.userId) > 20) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过20(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.userId)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.updUser)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.updDate)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.id_CurrEduCls) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.id_CurrEduCls)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperDiscussEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文讨论表(gs_PaperDiscuss))!值:$(pobjgs_PaperDiscussEN.memo)(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussId) == false && undefined !== pobjgs_PaperDiscussEN.discussId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.discussId) === false) {
            throw new Error("(errid:Watl000063)字段[讨论ID(discussId)]的值:[$(pobjgs_PaperDiscussEN.discussId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussContent) == false && undefined !== pobjgs_PaperDiscussEN.discussContent && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.discussContent) === false) {
            throw new Error("(errid:Watl000063)字段[讨论内容(discussContent)]的值:[$(pobjgs_PaperDiscussEN.discussContent)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.paperId) == false && undefined !== pobjgs_PaperDiscussEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperDiscussEN.paperId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.parentId) == false && undefined !== pobjgs_PaperDiscussEN.parentId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父节点Id(parentId)]的值:[$(pobjgs_PaperDiscussEN.parentId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperDiscussEN.score && undefined !== pobjgs_PaperDiscussEN.score && jsString_js_1.tzDataType.isNumber(pobjgs_PaperDiscussEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjgs_PaperDiscussEN.score)], 非法，应该为数值型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.scoreType) == false && undefined !== pobjgs_PaperDiscussEN.scoreType && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.scoreType) === false) {
            throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjgs_PaperDiscussEN.scoreType)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussTypeId) == false && undefined !== pobjgs_PaperDiscussEN.discussTypeId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.discussTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[讨论类型Id(discussTypeId)]的值:[$(pobjgs_PaperDiscussEN.discussTypeId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.userId) == false && undefined !== pobjgs_PaperDiscussEN.userId && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjgs_PaperDiscussEN.userId)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperDiscussEN.voteCount && undefined !== pobjgs_PaperDiscussEN.voteCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperDiscussEN.voteCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjgs_PaperDiscussEN.voteCount)], 非法，应该为数值型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updUser) == false && undefined !== pobjgs_PaperDiscussEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperDiscussEN.updUser)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.updDate) == false && undefined !== pobjgs_PaperDiscussEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperDiscussEN.updDate)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.id_CurrEduCls) == false && undefined !== pobjgs_PaperDiscussEN.id_CurrEduCls && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjgs_PaperDiscussEN.id_CurrEduCls)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.memo) == false && undefined !== pobjgs_PaperDiscussEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PaperDiscussEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperDiscussEN.memo)], 非法，应该为字符型(In 论文讨论表(gs_PaperDiscuss))!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperDiscussEN.discussId) === true) {
            throw new Error("(errid:Watl000064)字段[讨论ID]不能为空(In 论文讨论表)!(clsgs_PaperDiscussBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperDiscussEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperDiscuss_CheckProperty4Update = gs_PaperDiscuss_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperDiscuss_GetJSONStrByObj(pobjgs_PaperDiscussEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperDiscussEN.sf_UpdFldSetStr = pobjgs_PaperDiscussEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperDiscussEN);
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
    exports.gs_PaperDiscuss_GetJSONStrByObj = gs_PaperDiscuss_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperDiscuss_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperDiscussObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperDiscussObjLst;
        }
        try {
            arrgs_PaperDiscussObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperDiscussObjLst;
        }
        return arrgs_PaperDiscussObjLst;
    }
    exports.gs_PaperDiscuss_GetObjLstByJSONStr = gs_PaperDiscuss_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperDiscussObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperDiscuss_GetObjLstByJSONObjLst(arrgs_PaperDiscussObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperDiscussObjLst = new Array();
        for (const objInFor of arrgs_PaperDiscussObjLstS) {
            const obj1 = gs_PaperDiscuss_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperDiscussObjLst.push(obj1);
        }
        return arrgs_PaperDiscussObjLst;
    }
    exports.gs_PaperDiscuss_GetObjLstByJSONObjLst = gs_PaperDiscuss_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperDiscuss_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperDiscussEN = new clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN();
        if (strJSON === "") {
            return pobjgs_PaperDiscussEN;
        }
        try {
            pobjgs_PaperDiscussEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperDiscussEN;
        }
        return pobjgs_PaperDiscussEN;
    }
    exports.gs_PaperDiscuss_GetObjByJSONStr = gs_PaperDiscuss_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperDiscuss_GetCombineCondition(objgs_PaperDiscuss_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId) == true) {
            const strComparisonOp_DiscussId = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussId, objgs_PaperDiscuss_Cond.discussId, strComparisonOp_DiscussId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussContent) == true) {
            const strComparisonOp_DiscussContent = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussContent];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussContent, objgs_PaperDiscuss_Cond.discussContent, strComparisonOp_DiscussContent);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_PaperId, objgs_PaperDiscuss_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ParentId, objgs_PaperDiscuss_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_score) == true) {
            const strComparisonOp_score = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_score, objgs_PaperDiscuss_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ScoreType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_ScoreType, objgs_PaperDiscuss_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussTypeId) == true) {
            const strComparisonOp_DiscussTypeId = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_DiscussTypeId, objgs_PaperDiscuss_Cond.discussTypeId, strComparisonOp_DiscussTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UserId) == true) {
            const strComparisonOp_UserId = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UserId, objgs_PaperDiscuss_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_VoteCount, objgs_PaperDiscuss_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdUser, objgs_PaperDiscuss_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_UpdDate, objgs_PaperDiscuss_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_id_CurrEduCls, objgs_PaperDiscuss_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperDiscuss_Cond.dicFldComparisonOp, clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PaperDiscuss_Cond.dicFldComparisonOp[clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN.con_Memo, objgs_PaperDiscuss_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.gs_PaperDiscuss_GetCombineCondition = gs_PaperDiscuss_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperDiscuss(论文讨论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strDiscussId: 讨论ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperDiscuss_GetUniCondStr_DiscussId(objgs_PaperDiscussEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and DiscussId = '{0}'", objgs_PaperDiscussEN.discussId);
        return strWhereCond;
    }
    exports.gs_PaperDiscuss_GetUniCondStr_DiscussId = gs_PaperDiscuss_GetUniCondStr_DiscussId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperDiscuss(论文讨论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strDiscussId: 讨论ID(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperDiscuss_GetUniCondStr4Update_DiscussId(objgs_PaperDiscussEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and DiscussId <> '{0}'", objgs_PaperDiscussEN.discussId);
        strWhereCond += (0, clsString_js_1.Format)(" and DiscussId = '{0}'", objgs_PaperDiscussEN.discussId);
        return strWhereCond;
    }
    exports.gs_PaperDiscuss_GetUniCondStr4Update_DiscussId = gs_PaperDiscuss_GetUniCondStr4Update_DiscussId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperDiscussENS:源对象
     * @param objgs_PaperDiscussENT:目标对象
    */
    function gs_PaperDiscuss_CopyObjTo(objgs_PaperDiscussENS, objgs_PaperDiscussENT) {
        objgs_PaperDiscussENT.discussId = objgs_PaperDiscussENS.discussId; //讨论ID
        objgs_PaperDiscussENT.discussContent = objgs_PaperDiscussENS.discussContent; //讨论内容
        objgs_PaperDiscussENT.paperId = objgs_PaperDiscussENS.paperId; //论文Id
        objgs_PaperDiscussENT.parentId = objgs_PaperDiscussENS.parentId; //父节点Id
        objgs_PaperDiscussENT.score = objgs_PaperDiscussENS.score; //评分
        objgs_PaperDiscussENT.scoreType = objgs_PaperDiscussENS.scoreType; //评分类型
        objgs_PaperDiscussENT.discussTypeId = objgs_PaperDiscussENS.discussTypeId; //讨论类型Id
        objgs_PaperDiscussENT.userId = objgs_PaperDiscussENS.userId; //用户ID
        objgs_PaperDiscussENT.voteCount = objgs_PaperDiscussENS.voteCount; //点赞计数
        objgs_PaperDiscussENT.updUser = objgs_PaperDiscussENS.updUser; //修改人
        objgs_PaperDiscussENT.updDate = objgs_PaperDiscussENS.updDate; //修改日期
        objgs_PaperDiscussENT.id_CurrEduCls = objgs_PaperDiscussENS.id_CurrEduCls; //教学班流水号
        objgs_PaperDiscussENT.memo = objgs_PaperDiscussENS.memo; //备注
        objgs_PaperDiscussENT.sf_UpdFldSetStr = objgs_PaperDiscussENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperDiscuss_CopyObjTo = gs_PaperDiscuss_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperDiscussENS:源对象
     * @param objgs_PaperDiscussENT:目标对象
    */
    function gs_PaperDiscuss_GetObjFromJsonObj(objgs_PaperDiscussENS) {
        const objgs_PaperDiscussENT = new clsgs_PaperDiscussEN_js_1.clsgs_PaperDiscussEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperDiscussENT, objgs_PaperDiscussENS);
        return objgs_PaperDiscussENT;
    }
    exports.gs_PaperDiscuss_GetObjFromJsonObj = gs_PaperDiscuss_GetObjFromJsonObj;
});
