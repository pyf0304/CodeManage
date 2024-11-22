/**
* 类名:clsgs_PaperParagraphWApi
* 表名:gs_PaperParagraph(01120744)
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js", "../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/jsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.gs_PaperParagraph_GetObjFromJsonObj = exports.gs_PaperParagraph_CopyObjTo = exports.gs_PaperParagraph_GetUniCondStr4Update_ParagraphId = exports.gs_PaperParagraph_GetUniCondStr_ParagraphId = exports.gs_PaperParagraph_GetCombineCondition = exports.gs_PaperParagraph_GetObjByJSONStr = exports.gs_PaperParagraph_GetObjLstByJSONObjLst = exports.gs_PaperParagraph_GetObjLstByJSONStr = exports.gs_PaperParagraph_GetJSONStrByObj = exports.gs_PaperParagraph_CheckProperty4Update = exports.gs_PaperParagraph_CheckPropertyNew = exports.gs_PaperParagraph_ReFreshThisCache = exports.gs_PaperParagraph_ReFreshCache = exports.gs_PaperParagraph_GetWebApiUrl = exports.gs_PaperParagraph_GetMaxStrIdByPrefix = exports.gs_PaperParagraph_GetMaxStrIdAsync = exports.gs_PaperParagraph_GetRecCountByCond_Cache = exports.gs_PaperParagraph_GetRecCountByCondAsync = exports.gs_PaperParagraph_IsExistAsync = exports.gs_PaperParagraph_IsExist_Cache = exports.gs_PaperParagraph_IsExist = exports.gs_PaperParagraph_IsExistRecordAsync = exports.gs_PaperParagraph_IsExistRecord_Cache = exports.gs_PaperParagraph_UpdateWithConditionAsync = exports.gs_PaperParagraph_UpdateRecordAsync = exports.gs_PaperParagraph_AddNewRecordWithReturnKey = exports.gs_PaperParagraph_AddNewRecordWithReturnKeyAsync = exports.gs_PaperParagraph_ReOrderAsync = exports.gs_PaperParagraph_GoBottomAsync = exports.gs_PaperParagraph_DownMoveAsync = exports.gs_PaperParagraph_UpMoveAsync = exports.gs_PaperParagraph_GoTopAsync = exports.gs_PaperParagraph_AddNewRecordWithMaxIdAsync = exports.gs_PaperParagraph_AddNewRecordAsync = exports.gs_PaperParagraph_Delgs_PaperParagraphsByCondAsync = exports.gs_PaperParagraph_Delgs_PaperParagraphsAsync = exports.gs_PaperParagraph_DelRecordAsync = exports.gs_PaperParagraph_GetObjLstByPagerAsync = exports.gs_PaperParagraph_GetObjLstByPager_Cache = exports.gs_PaperParagraph_GetObjLstByRange = exports.gs_PaperParagraph_GetObjLstByRangeAsync = exports.gs_PaperParagraph_GetTopObjLstAsync = exports.gs_PaperParagraph_GetObjLstByParagraphIdLst_Cache = exports.gs_PaperParagraph_GetObjLstByParagraphIdLstAsync = exports.gs_PaperParagraph_GetSubObjLst_Cache = exports.gs_PaperParagraph_GetObjLst_PureCache = exports.gs_PaperParagraph_GetObjLst_Cache = exports.gs_PaperParagraph_GetObjLst_sessionStorage_PureCache = exports.gs_PaperParagraph_GetObjLst_sessionStorage = exports.gs_PaperParagraph_GetObjLstAsync = exports.gs_PaperParagraph_GetObjLst_localStorage_PureCache = exports.gs_PaperParagraph_GetObjLst_localStorage = exports.gs_PaperParagraph_GetObjLst_ClientCache = exports.gs_PaperParagraph_GetFirstObjAsync = exports.gs_PaperParagraph_GetFirstID = exports.gs_PaperParagraph_GetFirstIDAsync = exports.gs_PaperParagraph_FilterFunByKey = exports.gs_PaperParagraph_SortFunByKey = exports.gs_PaperParagraph_SortFun_Defa_2Fld = exports.gs_PaperParagraph_SortFun_Defa = exports.gs_PaperParagraph_func = exports.gs_PaperParagraph_UpdateObjInLst_Cache = exports.gs_PaperParagraph_GetObjByParagraphId_localStorage = exports.gs_PaperParagraph_GetObjByParagraphId_Cache = exports.gs_PaperParagraph_GetObjByParagraphIdAsync = exports.gs_PaperParagraph_ConstructorName = exports.gs_PaperParagraph_Controller = void 0;
    /**
     * 论文段落表(gs_PaperParagraph)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsgs_PaperParagraphEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsgs_PaperParagraphEN.js");
    const clsvgs_PaperParagraphWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvgs_PaperParagraphWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const jsString_js_1 = require("../../PubFun/jsString.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.gs_PaperParagraph_Controller = "gs_PaperParagraphApi";
    exports.gs_PaperParagraph_ConstructorName = "gs_PaperParagraph";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strParagraphId:关键字
    * @returns 对象
    **/
    async function gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId) {
        const strThisFuncName = "GetObjByParagraphIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphId]不能为空！(In GetObjByParagraphIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByParagraphId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strParagraphId": strParagraphId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperParagraph = gs_PaperParagraph_GetObjFromJsonObj(returnObj);
                return objgs_PaperParagraph;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetObjByParagraphIdAsync = gs_PaperParagraph_GetObjByParagraphIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByParagraphId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphId]不能为空！(In GetObjByParagraphId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
        try {
            const arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
            let objgs_PaperParagraph;
            if (arrgs_PaperParagraph_Sel.length > 0) {
                objgs_PaperParagraph = arrgs_PaperParagraph_Sel[0];
                return objgs_PaperParagraph;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objgs_PaperParagraph = await gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
                    if (objgs_PaperParagraph != null) {
                        gs_PaperParagraph_ReFreshThisCache();
                        return objgs_PaperParagraph;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.gs_PaperParagraph_GetObjByParagraphId_Cache = gs_PaperParagraph_GetObjByParagraphId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperParagraph_GetObjByParagraphId_localStorage(strParagraphId) {
        const strThisFuncName = "GetObjByParagraphId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphId]不能为空！(In GetObjByParagraphId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName, strParagraphId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objgs_PaperParagraph_Cache = JSON.parse(strTempObj);
            return objgs_PaperParagraph_Cache;
        }
        try {
            const objgs_PaperParagraph = await gs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
            if (objgs_PaperParagraph != null) {
                localStorage.setItem(strKey, JSON.stringify(objgs_PaperParagraph));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objgs_PaperParagraph;
            }
            return objgs_PaperParagraph;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.gs_PaperParagraph_GetObjByParagraphId_localStorage = gs_PaperParagraph_GetObjByParagraphId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objgs_PaperParagraph:所给的对象
     * @returns 对象
    */
    async function gs_PaperParagraph_UpdateObjInLst_Cache(objgs_PaperParagraph) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
            const obj = arrgs_PaperParagraphObjLst_Cache.find(x => x.paragraphId == objgs_PaperParagraph.paragraphId);
            if (obj != null) {
                objgs_PaperParagraph.paragraphId = obj.paragraphId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objgs_PaperParagraph);
            }
            else {
                arrgs_PaperParagraphObjLst_Cache.push(objgs_PaperParagraph);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.gs_PaperParagraph_UpdateObjInLst_Cache = gs_PaperParagraph_UpdateObjInLst_Cache;
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
    async function gs_PaperParagraph_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strParagraphId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objgs_PaperParagraph = await gs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId);
        if (objgs_PaperParagraph == null)
            return "";
        return objgs_PaperParagraph.GetFldValue(strOutFldName).toString();
    }
    exports.gs_PaperParagraph_func = gs_PaperParagraph_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraph_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paragraphId.localeCompare(b.paragraphId);
    }
    exports.gs_PaperParagraph_SortFun_Defa = gs_PaperParagraph_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraph_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paperId == b.paperId)
            return a.sectionId.localeCompare(b.sectionId);
        else
            return a.paperId.localeCompare(b.paperId);
    }
    exports.gs_PaperParagraph_SortFun_Defa_2Fld = gs_PaperParagraph_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function gs_PaperParagraph_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId:
                    return (a, b) => {
                        return a.paragraphId.localeCompare(b.paragraphId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphStateId:
                    return (a, b) => {
                        return a.paragraphStateId.localeCompare(b.paragraphStateId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphContent:
                    return (a, b) => {
                        return a.paragraphContent.localeCompare(b.paragraphContent);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CommentCount:
                    return (a, b) => {
                        return a.commentCount - b.commentCount;
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateUser:
                    return (a, b) => {
                        return a.createUser.localeCompare(b.createUser);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraph]中不存在！(in ${exports.gs_PaperParagraph_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId:
                    return (a, b) => {
                        return b.paragraphId.localeCompare(a.paragraphId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphStateId:
                    return (a, b) => {
                        return b.paragraphStateId.localeCompare(a.paragraphStateId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphContent:
                    return (a, b) => {
                        return b.paragraphContent.localeCompare(a.paragraphContent);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CommentCount:
                    return (a, b) => {
                        return b.commentCount - a.commentCount;
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateUser:
                    return (a, b) => {
                        return b.createUser.localeCompare(a.createUser);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraph]中不存在！(in ${exports.gs_PaperParagraph_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.gs_PaperParagraph_SortFunByKey = gs_PaperParagraph_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function gs_PaperParagraph_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId:
                return (obj) => {
                    return obj.paragraphId === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphStateId:
                return (obj) => {
                    return obj.paragraphStateId === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphTypeId:
                return (obj) => {
                    return obj.paragraphTypeId === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphContent:
                return (obj) => {
                    return obj.paragraphContent === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CommentCount:
                return (obj) => {
                    return obj.commentCount === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateUser:
                return (obj) => {
                    return obj.createUser === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[gs_PaperParagraph]中不存在！(in ${exports.gs_PaperParagraph_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.gs_PaperParagraph_FilterFunByKey = gs_PaperParagraph_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperParagraph_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetFirstIDAsync = gs_PaperParagraph_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function gs_PaperParagraph_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetFirstID = gs_PaperParagraph_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function gs_PaperParagraph_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objgs_PaperParagraph = gs_PaperParagraph_GetObjFromJsonObj(returnObj);
                return objgs_PaperParagraph;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetFirstObjAsync = gs_PaperParagraph_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
        clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrgs_PaperParagraphExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrgs_PaperParagraphObjLst_T = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphExObjLst_Cache);
            return arrgs_PaperParagraphObjLst_T;
        }
        try {
            const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrgs_PaperParagraphExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperParagraphExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperParagraphExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperParagraph_GetObjLst_ClientCache = gs_PaperParagraph_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
        clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperParagraphExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperParagraphObjLst_T = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphExObjLst_Cache);
            return arrgs_PaperParagraphObjLst_T;
        }
        try {
            const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrgs_PaperParagraphExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperParagraphExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperParagraphExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperParagraph_GetObjLst_localStorage = gs_PaperParagraph_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrgs_PaperParagraphObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperParagraphObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperParagraph_GetObjLst_localStorage_PureCache = gs_PaperParagraph_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperParagraph_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetObjLstAsync = gs_PaperParagraph_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
        clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperParagraphExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrgs_PaperParagraphObjLst_T = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphExObjLst_Cache);
            return arrgs_PaperParagraphObjLst_T;
        }
        try {
            const arrgs_PaperParagraphExObjLst = await gs_PaperParagraph_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrgs_PaperParagraphExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrgs_PaperParagraphExObjLst.length);
            console.log(strInfo);
            return arrgs_PaperParagraphExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.gs_PaperParagraph_GetObjLst_sessionStorage = gs_PaperParagraph_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrgs_PaperParagraphObjLst_Cache = JSON.parse(strTempObjLst);
            return arrgs_PaperParagraphObjLst_Cache;
        }
        else
            return null;
    }
    exports.gs_PaperParagraph_GetObjLst_sessionStorage_PureCache = gs_PaperParagraph_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrgs_PaperParagraphObjLst_Cache;
        switch (clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_ClientCache();
                break;
            default:
                arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_ClientCache();
                break;
        }
        const arrgs_PaperParagraphObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphObjLst_Cache);
        return arrgs_PaperParagraphObjLst_Cache;
    }
    exports.gs_PaperParagraph_GetObjLst_Cache = gs_PaperParagraph_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function gs_PaperParagraph_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrgs_PaperParagraphObjLst_Cache;
        switch (clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheModeId) {
            case "04": //sessionStorage
                arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrgs_PaperParagraphObjLst_Cache = null;
                break;
            default:
                arrgs_PaperParagraphObjLst_Cache = null;
                break;
        }
        return arrgs_PaperParagraphObjLst_Cache;
    }
    exports.gs_PaperParagraph_GetObjLst_PureCache = gs_PaperParagraph_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrParagraphId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperParagraph_GetSubObjLst_Cache(objgs_PaperParagraph_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
        let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache;
        if (objgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objgs_PaperParagraph_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperParagraph_Sel;
        const dicFldComparisonOp = JSON.parse(objgs_PaperParagraph_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperParagraph_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperParagraph_Cond), exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperParagraph_GetSubObjLst_Cache = gs_PaperParagraph_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrParagraphId:关键字列表
    * @returns 对象列表
    **/
    async function gs_PaperParagraph_GetObjLstByParagraphIdLstAsync(arrParagraphId) {
        const strThisFuncName = "GetObjLstByParagraphIdLstAsync";
        const strAction = "GetObjLstByParagraphIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetObjLstByParagraphIdLstAsync = gs_PaperParagraph_GetObjLstByParagraphIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrParagraphIdLst:关键字列表
     * @returns 对象列表
    */
    async function gs_PaperParagraph_GetObjLstByParagraphIdLst_Cache(arrParagraphIdLst) {
        const strThisFuncName = "GetObjLstByParagraphIdLst_Cache";
        try {
            const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
            const arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache.filter(x => arrParagraphIdLst.indexOf(x.paragraphId) > -1);
            return arrgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrParagraphIdLst.join(","), exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperParagraph_GetObjLstByParagraphIdLst_Cache = gs_PaperParagraph_GetObjLstByParagraphIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function gs_PaperParagraph_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetTopObjLstAsync = gs_PaperParagraph_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperParagraph_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetObjLstByRangeAsync = gs_PaperParagraph_GetObjLstByRangeAsync;
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
    async function gs_PaperParagraph_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetObjLstByRange = gs_PaperParagraph_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function gs_PaperParagraph_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
        if (arrgs_PaperParagraphObjLst_Cache.length == 0)
            return arrgs_PaperParagraphObjLst_Cache;
        let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objgs_PaperParagraph_Cond = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperParagraph_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsgs_PaperParagraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperParagraph_Sel.length == 0)
                return arrgs_PaperParagraph_Sel;
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
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(gs_PaperParagraph_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
            }
            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.slice(intStart, intEnd);
            return arrgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.gs_PaperParagraph_GetObjLstByPager_Cache = gs_PaperParagraph_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function gs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetObjLstByPagerAsync = gs_PaperParagraph_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strParagraphId:关键字
    * @returns 获取删除的结果
    **/
    async function gs_PaperParagraph_DelRecordAsync(strParagraphId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        strUrl = (0, clsString_js_1.Format)("{0}/?Id={1}", strUrl, strParagraphId);
        try {
            const response = await axios_1.default.delete(strUrl, {
                params: { "Id": strParagraphId, }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_DelRecordAsync = gs_PaperParagraph_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrParagraphId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperParagraph_Delgs_PaperParagraphsAsync(arrParagraphId) {
        const strThisFuncName = "Delgs_PaperParagraphsAsync";
        const strAction = "Delgs_PaperParagraphs";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphId);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_Delgs_PaperParagraphsAsync = gs_PaperParagraph_Delgs_PaperParagraphsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function gs_PaperParagraph_Delgs_PaperParagraphsByCondAsync(strWhereCond) {
        const strThisFuncName = "Delgs_PaperParagraphsByCondAsync";
        const strAction = "Delgs_PaperParagraphsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_Delgs_PaperParagraphsByCondAsync = gs_PaperParagraph_Delgs_PaperParagraphsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_AddNewRecordAsync(objgs_PaperParagraphEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_AddNewRecordAsync = gs_PaperParagraph_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_AddNewRecordWithMaxIdAsync(objgs_PaperParagraphEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_AddNewRecordWithMaxIdAsync = gs_PaperParagraph_AddNewRecordWithMaxIdAsync;
    /**
    * 把所给的关键字列表相关的记录移顶
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoTopAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_GoTopAsync(objOrderByData) {
        const strThisFuncName = "GoTopAsync";
        let strMsg = "";
        const strAction = "GoTop";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置顶时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GoTopAsync = gs_PaperParagraph_GoTopAsync;
    /**
    * 把所给的关键字列表相关的记录上移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpMoveAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_UpMoveAsync(objOrderByData) {
        const strThisFuncName = "UpMoveAsync";
        let strMsg = "";
        const strAction = "UpMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表上移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_UpMoveAsync = gs_PaperParagraph_UpMoveAsync;
    /**
    * 把所给的关键字列表相关的记录下移
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DownMoveAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_DownMoveAsync(objOrderByData) {
        const strThisFuncName = "DownMoveAsync";
        let strMsg = "";
        const strAction = "DownMove";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表下移时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_DownMoveAsync = gs_PaperParagraph_DownMoveAsync;
    /**
    * 把所给的关键字列表相关的记录移底
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GoBottomAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_GoBottomAsync(objOrderByData) {
        const strThisFuncName = "GoBottomAsync";
        let strMsg = "";
        const strAction = "GoBottom";
        if (objOrderByData.KeyIdLst.length == 0) {
            strMsg = "根据关键字列表置底时，给定的关键字值列表不能为空!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GoBottomAsync = gs_PaperParagraph_GoBottomAsync;
    /**
    * 把列表记录重序
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReOrderAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function gs_PaperParagraph_ReOrderAsync(objOrderByData) {
        const strThisFuncName = "ReOrderAsync";
        const strAction = "ReOrder";
        //var strJSON = JSON.stringify(objgs_PaperParagraphEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objOrderByData);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_ReOrderAsync = gs_PaperParagraph_ReOrderAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objgs_PaperParagraphEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function gs_PaperParagraph_AddNewRecordWithReturnKeyAsync(objgs_PaperParagraphEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_AddNewRecordWithReturnKeyAsync = gs_PaperParagraph_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objgs_PaperParagraphEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function gs_PaperParagraph_AddNewRecordWithReturnKey(objgs_PaperParagraphEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objgs_PaperParagraphEN.paragraphId === null || objgs_PaperParagraphEN.paragraphId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_AddNewRecordWithReturnKey = gs_PaperParagraph_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objgs_PaperParagraphEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function gs_PaperParagraph_UpdateRecordAsync(objgs_PaperParagraphEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objgs_PaperParagraphEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphEN.sf_UpdFldSetStr === null || objgs_PaperParagraphEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphEN.paragraphId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_UpdateRecordAsync = gs_PaperParagraph_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objgs_PaperParagraphEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function gs_PaperParagraph_UpdateWithConditionAsync(objgs_PaperParagraphEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objgs_PaperParagraphEN.sf_UpdFldSetStr === undefined || objgs_PaperParagraphEN.sf_UpdFldSetStr === null || objgs_PaperParagraphEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_1.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objgs_PaperParagraphEN.paragraphId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        objgs_PaperParagraphEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objgs_PaperParagraphEN);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_UpdateWithConditionAsync = gs_PaperParagraph_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrParagraphId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function gs_PaperParagraph_IsExistRecord_Cache(objgs_PaperParagraph_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
        if (arrgs_PaperParagraphObjLst_Cache == null)
            return false;
        let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache;
        if (objgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objgs_PaperParagraph_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperParagraph_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objgs_PaperParagraph_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperParagraph_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrgs_PaperParagraph_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objgs_PaperParagraph_Cond), exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.gs_PaperParagraph_IsExistRecord_Cache = gs_PaperParagraph_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function gs_PaperParagraph_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_IsExistRecordAsync = gs_PaperParagraph_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strParagraphId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function gs_PaperParagraph_IsExist(strParagraphId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "ParagraphId": strParagraphId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_IsExist = gs_PaperParagraph_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function gs_PaperParagraph_IsExist_Cache(strParagraphId) {
        const strThisFuncName = "IsExist_Cache";
        const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
        if (arrgs_PaperParagraphObjLst_Cache == null)
            return false;
        try {
            const arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
            if (arrgs_PaperParagraph_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strParagraphId, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.gs_PaperParagraph_IsExist_Cache = gs_PaperParagraph_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strParagraphId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function gs_PaperParagraph_IsExistAsync(strParagraphId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strParagraphId": strParagraphId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_IsExistAsync = gs_PaperParagraph_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function gs_PaperParagraph_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetRecCountByCondAsync = gs_PaperParagraph_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objgs_PaperParagraph_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function gs_PaperParagraph_GetRecCountByCond_Cache(objgs_PaperParagraph_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrgs_PaperParagraphObjLst_Cache = await gs_PaperParagraph_GetObjLst_Cache();
        if (arrgs_PaperParagraphObjLst_Cache == null)
            return 0;
        let arrgs_PaperParagraph_Sel = arrgs_PaperParagraphObjLst_Cache;
        if (objgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objgs_PaperParagraph_Cond.sf_FldComparisonOp == "")
            return arrgs_PaperParagraph_Sel.length;
        const dicFldComparisonOp = JSON.parse(objgs_PaperParagraph_Cond.sf_FldComparisonOp);
        //console.log("clsgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objgs_PaperParagraph_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrgs_PaperParagraph_Sel = arrgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrgs_PaperParagraph_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objgs_PaperParagraph_Cond), exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.gs_PaperParagraph_GetRecCountByCond_Cache = gs_PaperParagraph_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function gs_PaperParagraph_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetMaxStrIdAsync = gs_PaperParagraph_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function gs_PaperParagraph_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.gs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.gs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.gs_PaperParagraph_GetMaxStrIdByPrefix = gs_PaperParagraph_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function gs_PaperParagraph_GetWebApiUrl(strController, strAction) {
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
    exports.gs_PaperParagraph_GetWebApiUrl = gs_PaperParagraph_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function gs_PaperParagraph_ReFreshCache() {
        const strThisFuncName = "ReFreshCache";
        const strMsg = (0, clsString_js_1.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
        switch (clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheModeId) {
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
        (0, clsvgs_PaperParagraphWApi_js_1.vgs_PaperParagraph_ReFreshThisCache)();
    }
    exports.gs_PaperParagraph_ReFreshCache = gs_PaperParagraph_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function gs_PaperParagraph_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN._CurrTabName;
            switch (clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.CacheModeId) {
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
    exports.gs_PaperParagraph_ReFreshThisCache = gs_PaperParagraph_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperParagraph_CheckPropertyNew(pobjgs_PaperParagraphEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paperId) === true
            || pobjgs_PaperParagraphEN.paperId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[论文Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.sectionId) === true) {
            throw new Error("(errid:Watl000058)字段[节Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphStateId) === true) {
            throw new Error("(errid:Watl000058)字段[段落状态Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[段落类型Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paragraphId) > 10) {
            throw new Error("(errid:Watl000059)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paperId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.sectionId) > 8) {
            throw new Error("(errid:Watl000059)字段[节Id(sectionId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.sectionId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphStateId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paragraphStateId) > 2) {
            throw new Error("(errid:Watl000059)字段[段落状态Id(paragraphStateId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphStateId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphTypeId)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createDate)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.createUser) > 50) {
            throw new Error("(errid:Watl000059)字段[建立用户(createUser)]的长度不能超过50(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createUser)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updDate)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updUser)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.memo)(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphId) === false) {
            throw new Error("(errid:Watl000060)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphEN.paragraphId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paperId) == false && undefined !== pobjgs_PaperParagraphEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphEN.paperId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.sectionId) == false && undefined !== pobjgs_PaperParagraphEN.sectionId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.sectionId) === false) {
            throw new Error("(errid:Watl000060)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphEN.sectionId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphStateId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphStateId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphStateId) === false) {
            throw new Error("(errid:Watl000060)字段[段落状态Id(paragraphStateId)]的值:[$(pobjgs_PaperParagraphEN.paragraphStateId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphTypeId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphEN.paragraphContent && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphContent) === false) {
            throw new Error("(errid:Watl000060)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphEN.paragraphContent)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperParagraphEN.voteCount && undefined !== pobjgs_PaperParagraphEN.voteCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.voteCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞计数(voteCount)]的值:[$(pobjgs_PaperParagraphEN.voteCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperParagraphEN.commentCount && undefined !== pobjgs_PaperParagraphEN.commentCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.commentCount) === false) {
            throw new Error("(errid:Watl000060)字段[评论数(commentCount)]的值:[$(pobjgs_PaperParagraphEN.commentCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperParagraphEN.versionCount && undefined !== pobjgs_PaperParagraphEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.versionCount) === false) {
            throw new Error("(errid:Watl000060)字段[版本统计(versionCount)]的值:[$(pobjgs_PaperParagraphEN.versionCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createDate) == false && undefined !== pobjgs_PaperParagraphEN.createDate && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjgs_PaperParagraphEN.createDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createUser) == false && undefined !== pobjgs_PaperParagraphEN.createUser && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.createUser) === false) {
            throw new Error("(errid:Watl000060)字段[建立用户(createUser)]的值:[$(pobjgs_PaperParagraphEN.createUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updDate) == false && undefined !== pobjgs_PaperParagraphEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphEN.updDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updUser) == false && undefined !== pobjgs_PaperParagraphEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphEN.updUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.memo) == false && undefined !== pobjgs_PaperParagraphEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphEN.memo)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        if (null != pobjgs_PaperParagraphEN.orderNum && undefined !== pobjgs_PaperParagraphEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.orderNum) === false) {
            throw new Error("(errid:Watl000060)字段[序号(orderNum)]的值:[$(pobjgs_PaperParagraphEN.orderNum)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjgs_PaperParagraphEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperParagraph_CheckPropertyNew = gs_PaperParagraph_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function gs_PaperParagraph_CheckProperty4Update(pobjgs_PaperParagraphEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paragraphId) > 10) {
            throw new Error("(errid:Watl000062)字段[段落Id(paragraphId)]的长度不能超过10(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paperId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paperId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.sectionId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.sectionId) > 8) {
            throw new Error("(errid:Watl000062)字段[节Id(sectionId)]的长度不能超过8(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.sectionId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphStateId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paragraphStateId) > 2) {
            throw new Error("(errid:Watl000062)字段[段落状态Id(paragraphStateId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphStateId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphTypeId) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.paragraphTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[段落类型Id(paragraphTypeId)]的长度不能超过2(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.paragraphTypeId)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createDate)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.createUser) > 50) {
            throw new Error("(errid:Watl000062)字段[建立用户(createUser)]的长度不能超过50(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.createUser)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updDate) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updDate)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updUser) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.updUser)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.memo) == false && (0, clsString_js_1.GetStrLen)(pobjgs_PaperParagraphEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文段落表(gs_PaperParagraph))!值:$(pobjgs_PaperParagraphEN.memo)(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphId) === false) {
            throw new Error("(errid:Watl000063)字段[段落Id(paragraphId)]的值:[$(pobjgs_PaperParagraphEN.paragraphId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paperId) == false && undefined !== pobjgs_PaperParagraphEN.paperId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjgs_PaperParagraphEN.paperId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.sectionId) == false && undefined !== pobjgs_PaperParagraphEN.sectionId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.sectionId) === false) {
            throw new Error("(errid:Watl000063)字段[节Id(sectionId)]的值:[$(pobjgs_PaperParagraphEN.sectionId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphStateId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphStateId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphStateId) === false) {
            throw new Error("(errid:Watl000063)字段[段落状态Id(paragraphStateId)]的值:[$(pobjgs_PaperParagraphEN.paragraphStateId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphTypeId) == false && undefined !== pobjgs_PaperParagraphEN.paragraphTypeId && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[段落类型Id(paragraphTypeId)]的值:[$(pobjgs_PaperParagraphEN.paragraphTypeId)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphContent) == false && undefined !== pobjgs_PaperParagraphEN.paragraphContent && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.paragraphContent) === false) {
            throw new Error("(errid:Watl000063)字段[段落内容(paragraphContent)]的值:[$(pobjgs_PaperParagraphEN.paragraphContent)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperParagraphEN.voteCount && undefined !== pobjgs_PaperParagraphEN.voteCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.voteCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞计数(voteCount)]的值:[$(pobjgs_PaperParagraphEN.voteCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperParagraphEN.commentCount && undefined !== pobjgs_PaperParagraphEN.commentCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.commentCount) === false) {
            throw new Error("(errid:Watl000063)字段[评论数(commentCount)]的值:[$(pobjgs_PaperParagraphEN.commentCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperParagraphEN.versionCount && undefined !== pobjgs_PaperParagraphEN.versionCount && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.versionCount) === false) {
            throw new Error("(errid:Watl000063)字段[版本统计(versionCount)]的值:[$(pobjgs_PaperParagraphEN.versionCount)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createDate) == false && undefined !== pobjgs_PaperParagraphEN.createDate && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjgs_PaperParagraphEN.createDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.createUser) == false && undefined !== pobjgs_PaperParagraphEN.createUser && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.createUser) === false) {
            throw new Error("(errid:Watl000063)字段[建立用户(createUser)]的值:[$(pobjgs_PaperParagraphEN.createUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updDate) == false && undefined !== pobjgs_PaperParagraphEN.updDate && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjgs_PaperParagraphEN.updDate)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.updUser) == false && undefined !== pobjgs_PaperParagraphEN.updUser && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjgs_PaperParagraphEN.updUser)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.memo) == false && undefined !== pobjgs_PaperParagraphEN.memo && jsString_js_1.tzDataType.isString(pobjgs_PaperParagraphEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjgs_PaperParagraphEN.memo)], 非法，应该为字符型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        if (null != pobjgs_PaperParagraphEN.orderNum && undefined !== pobjgs_PaperParagraphEN.orderNum && jsString_js_1.tzDataType.isNumber(pobjgs_PaperParagraphEN.orderNum) === false) {
            throw new Error("(errid:Watl000063)字段[序号(orderNum)]的值:[$(pobjgs_PaperParagraphEN.orderNum)], 非法，应该为数值型(In 论文段落表(gs_PaperParagraph))!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_1.IsNullOrEmpty)(pobjgs_PaperParagraphEN.paragraphId) === true) {
            throw new Error("(errid:Watl000064)字段[段落Id]不能为空(In 论文段落表)!(clsgs_PaperParagraphBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjgs_PaperParagraphEN.SetIsCheckProperty(true);
    }
    exports.gs_PaperParagraph_CheckProperty4Update = gs_PaperParagraph_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperParagraph_GetJSONStrByObj(pobjgs_PaperParagraphEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjgs_PaperParagraphEN.sf_UpdFldSetStr = pobjgs_PaperParagraphEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjgs_PaperParagraphEN);
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
    exports.gs_PaperParagraph_GetJSONStrByObj = gs_PaperParagraph_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperParagraph_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrgs_PaperParagraphObjLst = new Array();
        if (strJSON === "") {
            return arrgs_PaperParagraphObjLst;
        }
        try {
            arrgs_PaperParagraphObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrgs_PaperParagraphObjLst;
        }
        return arrgs_PaperParagraphObjLst;
    }
    exports.gs_PaperParagraph_GetObjLstByJSONStr = gs_PaperParagraph_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrgs_PaperParagraphObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function gs_PaperParagraph_GetObjLstByJSONObjLst(arrgs_PaperParagraphObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrgs_PaperParagraphObjLst = new Array();
        for (const objInFor of arrgs_PaperParagraphObjLstS) {
            const obj1 = gs_PaperParagraph_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrgs_PaperParagraphObjLst.push(obj1);
        }
        return arrgs_PaperParagraphObjLst;
    }
    exports.gs_PaperParagraph_GetObjLstByJSONObjLst = gs_PaperParagraph_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function gs_PaperParagraph_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjgs_PaperParagraphEN = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
        if (strJSON === "") {
            return pobjgs_PaperParagraphEN;
        }
        try {
            pobjgs_PaperParagraphEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjgs_PaperParagraphEN;
        }
        return pobjgs_PaperParagraphEN;
    }
    exports.gs_PaperParagraph_GetObjByJSONStr = gs_PaperParagraph_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function gs_PaperParagraph_GetCombineCondition(objgs_PaperParagraph_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId) == true) {
            const strComparisonOp_ParagraphId = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphId, objgs_PaperParagraph_Cond.paragraphId, strComparisonOp_ParagraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_PaperId, objgs_PaperParagraph_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_SectionId, objgs_PaperParagraph_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphStateId) == true) {
            const strComparisonOp_ParagraphStateId = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphStateId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphStateId, objgs_PaperParagraph_Cond.paragraphStateId, strComparisonOp_ParagraphStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphTypeId) == true) {
            const strComparisonOp_ParagraphTypeId = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_ParagraphTypeId, objgs_PaperParagraph_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VoteCount, objgs_PaperParagraph_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CommentCount) == true) {
            const strComparisonOp_CommentCount = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CommentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CommentCount, objgs_PaperParagraph_Cond.commentCount, strComparisonOp_CommentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_VersionCount, objgs_PaperParagraph_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateDate, objgs_PaperParagraph_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateUser) == true) {
            const strComparisonOp_CreateUser = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_CreateUser, objgs_PaperParagraph_Cond.createUser, strComparisonOp_CreateUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdDate, objgs_PaperParagraph_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_UpdUser, objgs_PaperParagraph_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_Memo) == true) {
            const strComparisonOp_Memo = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_Memo, objgs_PaperParagraph_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objgs_PaperParagraph_Cond.dicFldComparisonOp, clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objgs_PaperParagraph_Cond.dicFldComparisonOp[clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN.con_OrderNum, objgs_PaperParagraph_Cond.orderNum, strComparisonOp_OrderNum);
        }
        return strWhereCond;
    }
    exports.gs_PaperParagraph_GetCombineCondition = gs_PaperParagraph_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperParagraph(论文段落表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strParagraphId: 段落Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperParagraph_GetUniCondStr_ParagraphId(objgs_PaperParagraphEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphId = '{0}'", objgs_PaperParagraphEN.paragraphId);
        return strWhereCond;
    }
    exports.gs_PaperParagraph_GetUniCondStr_ParagraphId = gs_PaperParagraph_GetUniCondStr_ParagraphId;
    /**
    *获取唯一性条件串(Uniqueness)--gs_PaperParagraph(论文段落表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strParagraphId: 段落Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function gs_PaperParagraph_GetUniCondStr4Update_ParagraphId(objgs_PaperParagraphEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphId <> '{0}'", objgs_PaperParagraphEN.paragraphId);
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphId = '{0}'", objgs_PaperParagraphEN.paragraphId);
        return strWhereCond;
    }
    exports.gs_PaperParagraph_GetUniCondStr4Update_ParagraphId = gs_PaperParagraph_GetUniCondStr4Update_ParagraphId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objgs_PaperParagraphENS:源对象
     * @param objgs_PaperParagraphENT:目标对象
    */
    function gs_PaperParagraph_CopyObjTo(objgs_PaperParagraphENS, objgs_PaperParagraphENT) {
        objgs_PaperParagraphENT.paragraphId = objgs_PaperParagraphENS.paragraphId; //段落Id
        objgs_PaperParagraphENT.paperId = objgs_PaperParagraphENS.paperId; //论文Id
        objgs_PaperParagraphENT.sectionId = objgs_PaperParagraphENS.sectionId; //节Id
        objgs_PaperParagraphENT.paragraphStateId = objgs_PaperParagraphENS.paragraphStateId; //段落状态Id
        objgs_PaperParagraphENT.paragraphTypeId = objgs_PaperParagraphENS.paragraphTypeId; //段落类型Id
        objgs_PaperParagraphENT.paragraphContent = objgs_PaperParagraphENS.paragraphContent; //段落内容
        objgs_PaperParagraphENT.voteCount = objgs_PaperParagraphENS.voteCount; //点赞计数
        objgs_PaperParagraphENT.commentCount = objgs_PaperParagraphENS.commentCount; //评论数
        objgs_PaperParagraphENT.versionCount = objgs_PaperParagraphENS.versionCount; //版本统计
        objgs_PaperParagraphENT.createDate = objgs_PaperParagraphENS.createDate; //建立日期
        objgs_PaperParagraphENT.createUser = objgs_PaperParagraphENS.createUser; //建立用户
        objgs_PaperParagraphENT.updDate = objgs_PaperParagraphENS.updDate; //修改日期
        objgs_PaperParagraphENT.updUser = objgs_PaperParagraphENS.updUser; //修改人
        objgs_PaperParagraphENT.memo = objgs_PaperParagraphENS.memo; //备注
        objgs_PaperParagraphENT.orderNum = objgs_PaperParagraphENS.orderNum; //序号
        objgs_PaperParagraphENT.sf_UpdFldSetStr = objgs_PaperParagraphENS.updFldString; //sf_UpdFldSetStr
    }
    exports.gs_PaperParagraph_CopyObjTo = gs_PaperParagraph_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objgs_PaperParagraphENS:源对象
     * @param objgs_PaperParagraphENT:目标对象
    */
    function gs_PaperParagraph_GetObjFromJsonObj(objgs_PaperParagraphENS) {
        const objgs_PaperParagraphENT = new clsgs_PaperParagraphEN_js_1.clsgs_PaperParagraphEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objgs_PaperParagraphENT, objgs_PaperParagraphENS);
        return objgs_PaperParagraphENT;
    }
    exports.gs_PaperParagraph_GetObjFromJsonObj = gs_PaperParagraph_GetObjFromJsonObj;
});
