/**
* 类名:clsDiscussionTopicsWApi
* 表名:DiscussionTopics(01120588)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:47
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsDiscussionTopicsEN.js", "../../L3_ForWApi/GraduateEduTools/clsvDiscussionTopicsWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.DiscussionTopics_GetObjFromJsonObj = exports.DiscussionTopics_CopyObjTo = exports.DiscussionTopics_GetCombineCondition = exports.DiscussionTopics_GetObjByJSONStr = exports.DiscussionTopics_GetObjLstByJSONObjLst = exports.DiscussionTopics_GetObjLstByJSONStr = exports.DiscussionTopics_GetJSONStrByObj = exports.DiscussionTopics_CheckProperty4Update = exports.DiscussionTopics_CheckPropertyNew = exports.DiscussionTopics_ReFreshThisCache = exports.DiscussionTopics_ReFreshCache = exports.DiscussionTopics_GetWebApiUrl = exports.DiscussionTopics_GetMaxStrIdByPrefix = exports.DiscussionTopics_GetRecCountByCond_Cache = exports.DiscussionTopics_GetRecCountByCondAsync = exports.DiscussionTopics_IsExistAsync = exports.DiscussionTopics_IsExist_Cache = exports.DiscussionTopics_IsExist = exports.DiscussionTopics_IsExistRecordAsync = exports.DiscussionTopics_IsExistRecord_Cache = exports.DiscussionTopics_UpdateWithConditionAsync = exports.DiscussionTopics_UpdateRecordAsync = exports.DiscussionTopics_AddNewRecordWithReturnKey = exports.DiscussionTopics_AddNewRecordWithReturnKeyAsync = exports.DiscussionTopics_AddNewRecordWithMaxIdAsync = exports.DiscussionTopics_AddNewRecordAsync = exports.DiscussionTopics_DelDiscussionTopicssByCondAsync = exports.DiscussionTopics_DelDiscussionTopicssAsync = exports.DiscussionTopics_DelRecordAsync = exports.DiscussionTopics_GetObjLstByPagerAsync = exports.DiscussionTopics_GetObjLstByPager_Cache = exports.DiscussionTopics_GetObjLstByRange = exports.DiscussionTopics_GetObjLstByRangeAsync = exports.DiscussionTopics_GetTopObjLstAsync = exports.DiscussionTopics_GetObjLstByTopicsIdLst_Cache = exports.DiscussionTopics_GetObjLstByTopicsIdLstAsync = exports.DiscussionTopics_GetSubObjLst_Cache = exports.DiscussionTopics_GetObjLst_PureCache = exports.DiscussionTopics_GetObjLst_Cache = exports.DiscussionTopics_GetObjLst_sessionStorage_PureCache = exports.DiscussionTopics_GetObjLst_sessionStorage = exports.DiscussionTopics_GetObjLstAsync = exports.DiscussionTopics_GetObjLst_localStorage_PureCache = exports.DiscussionTopics_GetObjLst_localStorage = exports.DiscussionTopics_GetObjLst_ClientCache = exports.DiscussionTopics_GetFirstObjAsync = exports.DiscussionTopics_GetFirstID = exports.DiscussionTopics_GetFirstIDAsync = exports.DiscussionTopics_funcKey = exports.DiscussionTopics_FilterFunByKey = exports.DiscussionTopics_SortFunByKey = exports.DiscussionTopics_SortFun_Defa_2Fld = exports.DiscussionTopics_SortFun_Defa = exports.DiscussionTopics_func = exports.DiscussionTopics_UpdateObjInLst_Cache = exports.DiscussionTopics_GetObjByTopicsId_localStorage = exports.DiscussionTopics_GetObjByTopicsId_Cache = exports.DiscussionTopics_GetObjByTopicsIdAsync = exports.discussionTopics_ConstructorName = exports.discussionTopics_Controller = void 0;
    /**
     * 讨论主题(DiscussionTopics)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsDiscussionTopicsEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsDiscussionTopicsEN.js");
    const clsvDiscussionTopicsWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsvDiscussionTopicsWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.discussionTopics_Controller = "DiscussionTopicsApi";
    exports.discussionTopics_ConstructorName = "discussionTopics";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicsId:关键字
    * @returns 对象
    **/
    async function DiscussionTopics_GetObjByTopicsIdAsync(strTopicsId) {
        const strThisFuncName = "GetObjByTopicsIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicsId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicsId]不能为空！(In clsDiscussionTopicsWApi.GetObjByTopicsIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicsId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsDiscussionTopicsWApi.GetObjByTopicsIdAsync)", strTopicsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicsId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strTopicsId": strTopicsId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objDiscussionTopics = DiscussionTopics_GetObjFromJsonObj(returnObj);
                return objDiscussionTopics;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetObjByTopicsIdAsync = DiscussionTopics_GetObjByTopicsIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicsId:所给的关键字
     * @returns 对象
    */
    async function DiscussionTopics_GetObjByTopicsId_Cache(strTopicsId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicsId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicsId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicsId]不能为空！(In clsDiscussionTopicsWApi.GetObjByTopicsId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicsId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsDiscussionTopicsWApi.GetObjByTopicsId_Cache)", strTopicsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache.filter(x => x.topicsId == strTopicsId);
            let objDiscussionTopics;
            if (arrDiscussionTopics_Sel.length > 0) {
                objDiscussionTopics = arrDiscussionTopics_Sel[0];
                return objDiscussionTopics;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objDiscussionTopics_Const = await DiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
                    if (objDiscussionTopics_Const != null) {
                        DiscussionTopics_ReFreshThisCache(strid_CurrEduCls);
                        return objDiscussionTopics_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicsId, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.DiscussionTopics_GetObjByTopicsId_Cache = DiscussionTopics_GetObjByTopicsId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicsId:所给的关键字
     * @returns 对象
    */
    async function DiscussionTopics_GetObjByTopicsId_localStorage(strTopicsId) {
        const strThisFuncName = "GetObjByTopicsId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strTopicsId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strTopicsId]不能为空！(In clsDiscussionTopicsWApi.GetObjByTopicsId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicsId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsDiscussionTopicsWApi.GetObjByTopicsId_localStorage)", strTopicsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strTopicsId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objDiscussionTopics_Cache = JSON.parse(strTempObj);
            return objDiscussionTopics_Cache;
        }
        try {
            const objDiscussionTopics = await DiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
            if (objDiscussionTopics != null) {
                localStorage.setItem(strKey, JSON.stringify(objDiscussionTopics));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objDiscussionTopics;
            }
            return objDiscussionTopics;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicsId, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.DiscussionTopics_GetObjByTopicsId_localStorage = DiscussionTopics_GetObjByTopicsId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objDiscussionTopics:所给的对象
     * @returns 对象
    */
    async function DiscussionTopics_UpdateObjInLst_Cache(objDiscussionTopics, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrDiscussionTopicsObjLst_Cache.find(x => x.topicsId == objDiscussionTopics.topicsId);
            if (obj != null) {
                objDiscussionTopics.topicsId = obj.topicsId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objDiscussionTopics);
            }
            else {
                arrDiscussionTopicsObjLst_Cache.push(objDiscussionTopics);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.DiscussionTopics_UpdateObjInLst_Cache = DiscussionTopics_UpdateObjInLst_Cache;
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
    async function DiscussionTopics_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsDiscussionTopicsWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsDiscussionTopicsWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicsId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objDiscussionTopics = await DiscussionTopics_GetObjByTopicsId_Cache(strTopicsId, strid_CurrEduCls_C);
        if (objDiscussionTopics == null)
            return "";
        if (objDiscussionTopics.GetFldValue(strOutFldName) == null)
            return "";
        return objDiscussionTopics.GetFldValue(strOutFldName).toString();
    }
    exports.DiscussionTopics_func = DiscussionTopics_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function DiscussionTopics_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicsId.localeCompare(b.topicsId);
    }
    exports.DiscussionTopics_SortFun_Defa = DiscussionTopics_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function DiscussionTopics_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.discussionTypeId == b.discussionTypeId)
            return a.topicsTitle.localeCompare(b.topicsTitle);
        else
            return a.discussionTypeId.localeCompare(b.discussionTypeId);
    }
    exports.DiscussionTopics_SortFun_Defa_2Fld = DiscussionTopics_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function DiscussionTopics_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId:
                    return (a, b) => {
                        return a.topicsId.localeCompare(b.topicsId);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_DiscussionTypeId:
                    return (a, b) => {
                        return a.discussionTypeId.localeCompare(b.discussionTypeId);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsTitle:
                    return (a, b) => {
                        if (a.topicsTitle == null)
                            return -1;
                        if (b.topicsTitle == null)
                            return 1;
                        return a.topicsTitle.localeCompare(b.topicsTitle);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsContent:
                    return (a, b) => {
                        if (a.topicsContent == null)
                            return -1;
                        if (b.topicsContent == null)
                            return 1;
                        return a.topicsContent.localeCompare(b.topicsContent);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsAudit:
                    return (a, b) => {
                        if (a.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsTop:
                    return (a, b) => {
                        if (a.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_SubCount:
                    return (a, b) => {
                        return a.subCount - b.subCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[DiscussionTopics]中不存在！(in ${exports.discussionTopics_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId:
                    return (a, b) => {
                        return b.topicsId.localeCompare(a.topicsId);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_DiscussionTypeId:
                    return (a, b) => {
                        return b.discussionTypeId.localeCompare(a.discussionTypeId);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsTitle:
                    return (a, b) => {
                        if (b.topicsTitle == null)
                            return -1;
                        if (a.topicsTitle == null)
                            return 1;
                        return b.topicsTitle.localeCompare(a.topicsTitle);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsContent:
                    return (a, b) => {
                        if (b.topicsContent == null)
                            return -1;
                        if (a.topicsContent == null)
                            return 1;
                        return b.topicsContent.localeCompare(a.topicsContent);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsAudit:
                    return (a, b) => {
                        if (b.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsTop:
                    return (a, b) => {
                        if (b.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_SubCount:
                    return (a, b) => {
                        return b.subCount - a.subCount;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[DiscussionTopics]中不存在！(in ${exports.discussionTopics_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.DiscussionTopics_SortFunByKey = DiscussionTopics_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function DiscussionTopics_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId:
                return (obj) => {
                    return obj.topicsId === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_DiscussionTypeId:
                return (obj) => {
                    return obj.discussionTypeId === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsTitle:
                return (obj) => {
                    return obj.topicsTitle === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsContent:
                return (obj) => {
                    return obj.topicsContent === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsAudit:
                return (obj) => {
                    return obj.isAudit === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsTop:
                return (obj) => {
                    return obj.isTop === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_SubCount:
                return (obj) => {
                    return obj.subCount === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[DiscussionTopics]中不存在！(in ${exports.discussionTopics_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.DiscussionTopics_FilterFunByKey = DiscussionTopics_FilterFunByKey;
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
    async function DiscussionTopics_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsDiscussionTopicsWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsDiscussionTopicsWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrDiscussionTopics = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrDiscussionTopics == null)
            return [];
        let arrDiscussionTopics_Sel = arrDiscussionTopics;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrDiscussionTopics_Sel.length == 0)
            return [];
        return arrDiscussionTopics_Sel.map(x => x.topicsId);
    }
    exports.DiscussionTopics_funcKey = DiscussionTopics_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function DiscussionTopics_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetFirstIDAsync = DiscussionTopics_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function DiscussionTopics_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetFirstID = DiscussionTopics_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function DiscussionTopics_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const objDiscussionTopics = DiscussionTopics_GetObjFromJsonObj(returnObj);
                return objDiscussionTopics;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetFirstObjAsync = DiscussionTopics_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrDiscussionTopicsExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrDiscussionTopicsObjLst_T = DiscussionTopics_GetObjLstByJSONObjLst(arrDiscussionTopicsExObjLst_Cache);
            return arrDiscussionTopicsObjLst_T;
        }
        try {
            const arrDiscussionTopicsExObjLst = await DiscussionTopics_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrDiscussionTopicsExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrDiscussionTopicsExObjLst.length);
            console.log(strInfo);
            return arrDiscussionTopicsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.DiscussionTopics_GetObjLst_ClientCache = DiscussionTopics_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrDiscussionTopicsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrDiscussionTopicsObjLst_T = DiscussionTopics_GetObjLstByJSONObjLst(arrDiscussionTopicsExObjLst_Cache);
            return arrDiscussionTopicsObjLst_T;
        }
        try {
            const arrDiscussionTopicsExObjLst = await DiscussionTopics_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrDiscussionTopicsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrDiscussionTopicsExObjLst.length);
            console.log(strInfo);
            return arrDiscussionTopicsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.DiscussionTopics_GetObjLst_localStorage = DiscussionTopics_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrDiscussionTopicsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrDiscussionTopicsObjLst_Cache;
        }
        else
            return null;
    }
    exports.DiscussionTopics_GetObjLst_localStorage_PureCache = DiscussionTopics_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function DiscussionTopics_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetObjLstAsync = DiscussionTopics_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrDiscussionTopicsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrDiscussionTopicsObjLst_T = DiscussionTopics_GetObjLstByJSONObjLst(arrDiscussionTopicsExObjLst_Cache);
            return arrDiscussionTopicsObjLst_T;
        }
        try {
            const arrDiscussionTopicsExObjLst = await DiscussionTopics_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrDiscussionTopicsExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrDiscussionTopicsExObjLst.length);
            console.log(strInfo);
            return arrDiscussionTopicsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.DiscussionTopics_GetObjLst_sessionStorage = DiscussionTopics_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrDiscussionTopicsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrDiscussionTopicsObjLst_Cache;
        }
        else
            return null;
    }
    exports.DiscussionTopics_GetObjLst_sessionStorage_PureCache = DiscussionTopics_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsDiscussionTopicsWApi.DiscussionTopics_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsDiscussionTopicsWApi.DiscussionTopics_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrDiscussionTopicsObjLst_Cache;
        switch (clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheModeId) {
            case "04": //sessionStorage
                arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrDiscussionTopicsObjLst = DiscussionTopics_GetObjLstByJSONObjLst(arrDiscussionTopicsObjLst_Cache);
        return arrDiscussionTopicsObjLst_Cache;
    }
    exports.DiscussionTopics_GetObjLst_Cache = DiscussionTopics_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function DiscussionTopics_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrDiscussionTopicsObjLst_Cache;
        switch (clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheModeId) {
            case "04": //sessionStorage
                arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrDiscussionTopicsObjLst_Cache = null;
                break;
            default:
                arrDiscussionTopicsObjLst_Cache = null;
                break;
        }
        return arrDiscussionTopicsObjLst_Cache;
    }
    exports.DiscussionTopics_GetObjLst_PureCache = DiscussionTopics_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function DiscussionTopics_GetSubObjLst_Cache(objDiscussionTopics_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        let arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache;
        if (objDiscussionTopics_Cond.sf_FldComparisonOp == null || objDiscussionTopics_Cond.sf_FldComparisonOp == "")
            return arrDiscussionTopics_Sel;
        const dicFldComparisonOp = JSON.parse(objDiscussionTopics_Cond.sf_FldComparisonOp);
        //console.log("clsDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objDiscussionTopics_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrDiscussionTopics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objDiscussionTopics_Cond), exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.DiscussionTopics_GetSubObjLst_Cache = DiscussionTopics_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicsId:关键字列表
    * @returns 对象列表
    **/
    async function DiscussionTopics_GetObjLstByTopicsIdLstAsync(arrTopicsId) {
        const strThisFuncName = "GetObjLstByTopicsIdLstAsync";
        const strAction = "GetObjLstByTopicsIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicsId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetObjLstByTopicsIdLstAsync = DiscussionTopics_GetObjLstByTopicsIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicsIdLst:关键字列表
     * @returns 对象列表
    */
    async function DiscussionTopics_GetObjLstByTopicsIdLst_Cache(arrTopicsIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByTopicsIdLst_Cache";
        try {
            const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
            const arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache.filter(x => arrTopicsIdLst.indexOf(x.topicsId) > -1);
            return arrDiscussionTopics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicsIdLst.join(","), exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.DiscussionTopics_GetObjLstByTopicsIdLst_Cache = DiscussionTopics_GetObjLstByTopicsIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function DiscussionTopics_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetTopObjLstAsync = DiscussionTopics_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function DiscussionTopics_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetObjLstByRangeAsync = DiscussionTopics_GetObjLstByRangeAsync;
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
    async function DiscussionTopics_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetObjLstByRange = DiscussionTopics_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function DiscussionTopics_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrDiscussionTopicsObjLst_Cache.length == 0)
            return arrDiscussionTopicsObjLst_Cache;
        let arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objDiscussionTopics_Cond = new clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objDiscussionTopics_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsDiscussionTopicsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrDiscussionTopics_Sel.length == 0)
                return arrDiscussionTopics_Sel;
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
                arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.sort(DiscussionTopics_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.sort(objPagerPara.sortFun);
            }
            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.slice(intStart, intEnd);
            return arrDiscussionTopics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.DiscussionTopics_GetObjLstByPager_Cache = DiscussionTopics_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function DiscussionTopics_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.discussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = DiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetObjLstByPagerAsync = DiscussionTopics_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strTopicsId:关键字
    * @returns 获取删除的结果
    **/
    async function DiscussionTopics_DelRecordAsync(strTopicsId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strTopicsId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_DelRecordAsync = DiscussionTopics_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrTopicsId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function DiscussionTopics_DelDiscussionTopicssAsync(arrTopicsId) {
        const strThisFuncName = "DelDiscussionTopicssAsync";
        const strAction = "DelDiscussionTopicss";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicsId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_DelDiscussionTopicssAsync = DiscussionTopics_DelDiscussionTopicssAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function DiscussionTopics_DelDiscussionTopicssByCondAsync(strWhereCond) {
        const strThisFuncName = "DelDiscussionTopicssByCondAsync";
        const strAction = "DelDiscussionTopicssByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_DelDiscussionTopicssByCondAsync = DiscussionTopics_DelDiscussionTopicssByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objDiscussionTopicsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function DiscussionTopics_AddNewRecordAsync(objDiscussionTopicsEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        if (objDiscussionTopicsEN.topicsId === null || objDiscussionTopicsEN.topicsId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            throw strMsg;
        }
        //var strJSON = JSON.stringify(objDiscussionTopicsEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionTopicsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_AddNewRecordAsync = DiscussionTopics_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objDiscussionTopicsEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function DiscussionTopics_AddNewRecordWithMaxIdAsync(objDiscussionTopicsEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionTopicsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_AddNewRecordWithMaxIdAsync = DiscussionTopics_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objDiscussionTopicsEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function DiscussionTopics_AddNewRecordWithReturnKeyAsync(objDiscussionTopicsEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionTopicsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_AddNewRecordWithReturnKeyAsync = DiscussionTopics_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objDiscussionTopicsEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function DiscussionTopics_AddNewRecordWithReturnKey(objDiscussionTopicsEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objDiscussionTopicsEN.topicsId === null || objDiscussionTopicsEN.topicsId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionTopicsEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_AddNewRecordWithReturnKey = DiscussionTopics_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objDiscussionTopicsEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function DiscussionTopics_UpdateRecordAsync(objDiscussionTopicsEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objDiscussionTopicsEN.sf_UpdFldSetStr === undefined || objDiscussionTopicsEN.sf_UpdFldSetStr === null || objDiscussionTopicsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objDiscussionTopicsEN.topicsId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionTopicsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_UpdateRecordAsync = DiscussionTopics_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objDiscussionTopicsEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function DiscussionTopics_UpdateWithConditionAsync(objDiscussionTopicsEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objDiscussionTopicsEN.sf_UpdFldSetStr === undefined || objDiscussionTopicsEN.sf_UpdFldSetStr === null || objDiscussionTopicsEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objDiscussionTopicsEN.topicsId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        objDiscussionTopicsEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objDiscussionTopicsEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_UpdateWithConditionAsync = DiscussionTopics_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function DiscussionTopics_IsExistRecord_Cache(objDiscussionTopics_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrDiscussionTopicsObjLst_Cache == null)
            return false;
        let arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache;
        if (objDiscussionTopics_Cond.sf_FldComparisonOp == null || objDiscussionTopics_Cond.sf_FldComparisonOp == "")
            return arrDiscussionTopics_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objDiscussionTopics_Cond.sf_FldComparisonOp);
        //console.log("clsDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objDiscussionTopics_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrDiscussionTopics_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objDiscussionTopics_Cond), exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.DiscussionTopics_IsExistRecord_Cache = DiscussionTopics_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function DiscussionTopics_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_IsExistRecordAsync = DiscussionTopics_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicsId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function DiscussionTopics_IsExist(strTopicsId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "TopicsId": strTopicsId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_IsExist = DiscussionTopics_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicsId:所给的关键字
     * @returns 对象
    */
    async function DiscussionTopics_IsExist_Cache(strTopicsId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrDiscussionTopicsObjLst_Cache == null)
            return false;
        try {
            const arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache.filter(x => x.topicsId == strTopicsId);
            if (arrDiscussionTopics_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicsId, exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.DiscussionTopics_IsExist_Cache = DiscussionTopics_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicsId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function DiscussionTopics_IsExistAsync(strTopicsId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strTopicsId": strTopicsId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_IsExistAsync = DiscussionTopics_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function DiscussionTopics_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetRecCountByCondAsync = DiscussionTopics_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objDiscussionTopics_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function DiscussionTopics_GetRecCountByCond_Cache(objDiscussionTopics_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrDiscussionTopicsObjLst_Cache = await DiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrDiscussionTopicsObjLst_Cache == null)
            return 0;
        let arrDiscussionTopics_Sel = arrDiscussionTopicsObjLst_Cache;
        if (objDiscussionTopics_Cond.sf_FldComparisonOp == null || objDiscussionTopics_Cond.sf_FldComparisonOp == "")
            return arrDiscussionTopics_Sel.length;
        const dicFldComparisonOp = JSON.parse(objDiscussionTopics_Cond.sf_FldComparisonOp);
        //console.log("clsDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objDiscussionTopics_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrDiscussionTopics_Sel = arrDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrDiscussionTopics_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objDiscussionTopics_Cond), exports.discussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.DiscussionTopics_GetRecCountByCond_Cache = DiscussionTopics_GetRecCountByCond_Cache;
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
    async function DiscussionTopics_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.discussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.discussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.DiscussionTopics_GetMaxStrIdByPrefix = DiscussionTopics_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function DiscussionTopics_GetWebApiUrl(strController, strAction) {
        const strThisFuncName = "GetWebApiUrl";
        let strServiceUrl;
        let strCurrIPAddressAndPort = "";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.bolIsLocalHost == false) {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort;
        }
        else {
            strCurrIPAddressAndPort = clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrIPAddressAndPort_Local;
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx) == true) {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}", strCurrIPAddressAndPort, strController, strAction);
        }
        else {
            strServiceUrl = (0, clsString_js_2.Format)("{0}/{1}/{2}/{3}", strCurrIPAddressAndPort, clsSysPara4WebApi_js_1.clsSysPara4WebApi.CurrPrx, strController, strAction);
        }
        return strServiceUrl;
    }
    exports.DiscussionTopics_GetWebApiUrl = DiscussionTopics_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function DiscussionTopics_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsDiscussionTopicsWApi.clsDiscussionTopicsWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsDiscussionTopicsWApi.clsDiscussionTopicsWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        switch (clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheModeId) {
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
        (0, clsvDiscussionTopicsWApi_js_1.vDiscussionTopics_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.DiscussionTopics_ReFreshCache = DiscussionTopics_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function DiscussionTopics_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
            switch (clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.CacheModeId) {
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
            const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
            console.trace(strMsg);
        }
        else {
            const strMsg = (0, clsString_js_2.Format)("刷新缓存已经关闭。");
            console.trace(strMsg);
        }
    }
    exports.DiscussionTopics_ReFreshThisCache = DiscussionTopics_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function DiscussionTopics_CheckPropertyNew(pobjDiscussionTopicsEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) === true
            || pobjDiscussionTopicsEN.discussionTypeId.toString() === "0") {
            throw new Error("(errid:Watl000058)字段[讨论类型Id]不能为空(In 讨论主题)!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.topicsId) > 8) {
            throw new Error("(errid:Watl000059)字段[主题Id(topicsId)]的长度不能超过8(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.topicsId)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.discussionTypeId) > 8) {
            throw new Error("(errid:Watl000059)字段[讨论类型Id(discussionTypeId)]的长度不能超过8(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.discussionTypeId)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsTitle) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.topicsTitle) > 200) {
            throw new Error("(errid:Watl000059)字段[主题标题(topicsTitle)]的长度不能超过200(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.topicsTitle)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.updDate)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.updUser)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.memo)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.id_CurrEduCls)(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsId) == false && undefined !== pobjDiscussionTopicsEN.topicsId && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.topicsId) === false) {
            throw new Error("(errid:Watl000060)字段[主题Id(topicsId)]的值:[$(pobjDiscussionTopicsEN.topicsId)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) == false && undefined !== pobjDiscussionTopicsEN.discussionTypeId && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.discussionTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[讨论类型Id(discussionTypeId)]的值:[$(pobjDiscussionTopicsEN.discussionTypeId)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsTitle) == false && undefined !== pobjDiscussionTopicsEN.topicsTitle && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.topicsTitle) === false) {
            throw new Error("(errid:Watl000060)字段[主题标题(topicsTitle)]的值:[$(pobjDiscussionTopicsEN.topicsTitle)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsContent) == false && undefined !== pobjDiscussionTopicsEN.topicsContent && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.topicsContent) === false) {
            throw new Error("(errid:Watl000060)字段[主题内容(topicsContent)]的值:[$(pobjDiscussionTopicsEN.topicsContent)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if (null != pobjDiscussionTopicsEN.isAudit && undefined !== pobjDiscussionTopicsEN.isAudit && clsString_js_1.tzDataType.isBoolean(pobjDiscussionTopicsEN.isAudit) === false) {
            throw new Error("(errid:Watl000060)字段[是否审核(isAudit)]的值:[$(pobjDiscussionTopicsEN.isAudit)], 非法，应该为布尔型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if (null != pobjDiscussionTopicsEN.isTop && undefined !== pobjDiscussionTopicsEN.isTop && clsString_js_1.tzDataType.isBoolean(pobjDiscussionTopicsEN.isTop) === false) {
            throw new Error("(errid:Watl000060)字段[是否置顶(isTop)]的值:[$(pobjDiscussionTopicsEN.isTop)], 非法，应该为布尔型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if (null != pobjDiscussionTopicsEN.browseNumber && undefined !== pobjDiscussionTopicsEN.browseNumber && clsString_js_1.tzDataType.isNumber(pobjDiscussionTopicsEN.browseNumber) === false) {
            throw new Error("(errid:Watl000060)字段[浏览量(browseNumber)]的值:[$(pobjDiscussionTopicsEN.browseNumber)], 非法，应该为数值型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updDate) == false && undefined !== pobjDiscussionTopicsEN.updDate && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjDiscussionTopicsEN.updDate)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updUser) == false && undefined !== pobjDiscussionTopicsEN.updUser && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjDiscussionTopicsEN.updUser)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.memo) == false && undefined !== pobjDiscussionTopicsEN.memo && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjDiscussionTopicsEN.memo)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.id_CurrEduCls) == false && undefined !== pobjDiscussionTopicsEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjDiscussionTopicsEN.id_CurrEduCls)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        if (null != pobjDiscussionTopicsEN.subCount && undefined !== pobjDiscussionTopicsEN.subCount && clsString_js_1.tzDataType.isNumber(pobjDiscussionTopicsEN.subCount) === false) {
            throw new Error("(errid:Watl000060)字段[SubCount(subCount)]的值:[$(pobjDiscussionTopicsEN.subCount)], 非法，应该为数值型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.discussionTypeId) != 8) {
            throw ("(errid:Watl000061)字段[讨论类型Id]作为外键字段,长度应该为8(In 讨论主题)!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjDiscussionTopicsEN.SetIsCheckProperty(true);
    }
    exports.DiscussionTopics_CheckPropertyNew = DiscussionTopics_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function DiscussionTopics_CheckProperty4Update(pobjDiscussionTopicsEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.topicsId) > 8) {
            throw new Error("(errid:Watl000062)字段[主题Id(topicsId)]的长度不能超过8(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.topicsId)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.discussionTypeId) > 8) {
            throw new Error("(errid:Watl000062)字段[讨论类型Id(discussionTypeId)]的长度不能超过8(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.discussionTypeId)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsTitle) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.topicsTitle) > 200) {
            throw new Error("(errid:Watl000062)字段[主题标题(topicsTitle)]的长度不能超过200(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.topicsTitle)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.updDate)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.updUser)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.memo)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 讨论主题(DiscussionTopics))!值:$(pobjDiscussionTopicsEN.id_CurrEduCls)(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsId) == false && undefined !== pobjDiscussionTopicsEN.topicsId && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.topicsId) === false) {
            throw new Error("(errid:Watl000063)字段[主题Id(topicsId)]的值:[$(pobjDiscussionTopicsEN.topicsId)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) == false && undefined !== pobjDiscussionTopicsEN.discussionTypeId && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.discussionTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[讨论类型Id(discussionTypeId)]的值:[$(pobjDiscussionTopicsEN.discussionTypeId)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsTitle) == false && undefined !== pobjDiscussionTopicsEN.topicsTitle && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.topicsTitle) === false) {
            throw new Error("(errid:Watl000063)字段[主题标题(topicsTitle)]的值:[$(pobjDiscussionTopicsEN.topicsTitle)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsContent) == false && undefined !== pobjDiscussionTopicsEN.topicsContent && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.topicsContent) === false) {
            throw new Error("(errid:Watl000063)字段[主题内容(topicsContent)]的值:[$(pobjDiscussionTopicsEN.topicsContent)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if (null != pobjDiscussionTopicsEN.isAudit && undefined !== pobjDiscussionTopicsEN.isAudit && clsString_js_1.tzDataType.isBoolean(pobjDiscussionTopicsEN.isAudit) === false) {
            throw new Error("(errid:Watl000063)字段[是否审核(isAudit)]的值:[$(pobjDiscussionTopicsEN.isAudit)], 非法，应该为布尔型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if (null != pobjDiscussionTopicsEN.isTop && undefined !== pobjDiscussionTopicsEN.isTop && clsString_js_1.tzDataType.isBoolean(pobjDiscussionTopicsEN.isTop) === false) {
            throw new Error("(errid:Watl000063)字段[是否置顶(isTop)]的值:[$(pobjDiscussionTopicsEN.isTop)], 非法，应该为布尔型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if (null != pobjDiscussionTopicsEN.browseNumber && undefined !== pobjDiscussionTopicsEN.browseNumber && clsString_js_1.tzDataType.isNumber(pobjDiscussionTopicsEN.browseNumber) === false) {
            throw new Error("(errid:Watl000063)字段[浏览量(browseNumber)]的值:[$(pobjDiscussionTopicsEN.browseNumber)], 非法，应该为数值型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updDate) == false && undefined !== pobjDiscussionTopicsEN.updDate && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjDiscussionTopicsEN.updDate)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.updUser) == false && undefined !== pobjDiscussionTopicsEN.updUser && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjDiscussionTopicsEN.updUser)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.memo) == false && undefined !== pobjDiscussionTopicsEN.memo && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjDiscussionTopicsEN.memo)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.id_CurrEduCls) == false && undefined !== pobjDiscussionTopicsEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjDiscussionTopicsEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjDiscussionTopicsEN.id_CurrEduCls)], 非法，应该为字符型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        if (null != pobjDiscussionTopicsEN.subCount && undefined !== pobjDiscussionTopicsEN.subCount && clsString_js_1.tzDataType.isNumber(pobjDiscussionTopicsEN.subCount) === false) {
            throw new Error("(errid:Watl000063)字段[SubCount(subCount)]的值:[$(pobjDiscussionTopicsEN.subCount)], 非法，应该为数值型(In 讨论主题(DiscussionTopics))!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.topicsId) === true) {
            throw new Error("(errid:Watl000064)字段[主题Id]不能为空(In 讨论主题)!(clsDiscussionTopicsBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjDiscussionTopicsEN.discussionTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjDiscussionTopicsEN.discussionTypeId) != 8) {
            throw ("(errid:Watl000065)字段[讨论类型Id]作为外键字段,长度应该为8(In 讨论主题)!(clsDiscussionTopicsBL:CheckPropertyNew)");
        }
        pobjDiscussionTopicsEN.SetIsCheckProperty(true);
    }
    exports.DiscussionTopics_CheckProperty4Update = DiscussionTopics_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function DiscussionTopics_GetJSONStrByObj(pobjDiscussionTopicsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjDiscussionTopicsEN.sf_UpdFldSetStr = pobjDiscussionTopicsEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjDiscussionTopicsEN);
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
    exports.DiscussionTopics_GetJSONStrByObj = DiscussionTopics_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function DiscussionTopics_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrDiscussionTopicsObjLst = new Array();
        if (strJSON === "") {
            return arrDiscussionTopicsObjLst;
        }
        try {
            arrDiscussionTopicsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrDiscussionTopicsObjLst;
        }
        return arrDiscussionTopicsObjLst;
    }
    exports.DiscussionTopics_GetObjLstByJSONStr = DiscussionTopics_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrDiscussionTopicsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function DiscussionTopics_GetObjLstByJSONObjLst(arrDiscussionTopicsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrDiscussionTopicsObjLst = new Array();
        for (const objInFor of arrDiscussionTopicsObjLstS) {
            const obj1 = DiscussionTopics_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrDiscussionTopicsObjLst.push(obj1);
        }
        return arrDiscussionTopicsObjLst;
    }
    exports.DiscussionTopics_GetObjLstByJSONObjLst = DiscussionTopics_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function DiscussionTopics_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjDiscussionTopicsEN = new clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN();
        if (strJSON === "") {
            return pobjDiscussionTopicsEN;
        }
        try {
            pobjDiscussionTopicsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjDiscussionTopicsEN;
        }
        return pobjDiscussionTopicsEN;
    }
    exports.DiscussionTopics_GetObjByJSONStr = DiscussionTopics_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function DiscussionTopics_GetCombineCondition(objDiscussionTopics_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId) == true) {
            const strComparisonOp_TopicsId = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsId, objDiscussionTopics_Cond.topicsId, strComparisonOp_TopicsId);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_DiscussionTypeId) == true) {
            const strComparisonOp_DiscussionTypeId = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_DiscussionTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_DiscussionTypeId, objDiscussionTopics_Cond.discussionTypeId, strComparisonOp_DiscussionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsTitle) == true) {
            const strComparisonOp_TopicsTitle = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsTitle];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_TopicsTitle, objDiscussionTopics_Cond.topicsTitle, strComparisonOp_TopicsTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsAudit) == true) {
            if (objDiscussionTopics_Cond.isAudit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsAudit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsAudit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsTop) == true) {
            if (objDiscussionTopics_Cond.isTop == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsTop);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_IsTop);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_BrowseNumber, objDiscussionTopics_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdDate, objDiscussionTopics_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_UpdUser, objDiscussionTopics_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_Memo, objDiscussionTopics_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_id_CurrEduCls, objDiscussionTopics_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objDiscussionTopics_Cond.dicFldComparisonOp, clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_SubCount) == true) {
            const strComparisonOp_SubCount = objDiscussionTopics_Cond.dicFldComparisonOp[clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_SubCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN.con_SubCount, objDiscussionTopics_Cond.subCount, strComparisonOp_SubCount);
        }
        return strWhereCond;
    }
    exports.DiscussionTopics_GetCombineCondition = DiscussionTopics_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objDiscussionTopicsENS:源对象
     * @param objDiscussionTopicsENT:目标对象
    */
    function DiscussionTopics_CopyObjTo(objDiscussionTopicsENS, objDiscussionTopicsENT) {
        objDiscussionTopicsENT.topicsId = objDiscussionTopicsENS.topicsId; //主题Id
        objDiscussionTopicsENT.discussionTypeId = objDiscussionTopicsENS.discussionTypeId; //讨论类型Id
        objDiscussionTopicsENT.topicsTitle = objDiscussionTopicsENS.topicsTitle; //主题标题
        objDiscussionTopicsENT.topicsContent = objDiscussionTopicsENS.topicsContent; //主题内容
        objDiscussionTopicsENT.isAudit = objDiscussionTopicsENS.isAudit; //是否审核
        objDiscussionTopicsENT.isTop = objDiscussionTopicsENS.isTop; //是否置顶
        objDiscussionTopicsENT.browseNumber = objDiscussionTopicsENS.browseNumber; //浏览量
        objDiscussionTopicsENT.updDate = objDiscussionTopicsENS.updDate; //修改日期
        objDiscussionTopicsENT.updUser = objDiscussionTopicsENS.updUser; //修改人
        objDiscussionTopicsENT.memo = objDiscussionTopicsENS.memo; //备注
        objDiscussionTopicsENT.id_CurrEduCls = objDiscussionTopicsENS.id_CurrEduCls; //教学班流水号
        objDiscussionTopicsENT.subCount = objDiscussionTopicsENS.subCount; //SubCount
        objDiscussionTopicsENT.sf_UpdFldSetStr = objDiscussionTopicsENS.updFldString; //sf_UpdFldSetStr
    }
    exports.DiscussionTopics_CopyObjTo = DiscussionTopics_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objDiscussionTopicsENS:源对象
     * @param objDiscussionTopicsENT:目标对象
    */
    function DiscussionTopics_GetObjFromJsonObj(objDiscussionTopicsENS) {
        const objDiscussionTopicsENT = new clsDiscussionTopicsEN_js_1.clsDiscussionTopicsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objDiscussionTopicsENT, objDiscussionTopicsENS);
        return objDiscussionTopicsENT;
    }
    exports.DiscussionTopics_GetObjFromJsonObj = DiscussionTopics_GetObjFromJsonObj;
});
