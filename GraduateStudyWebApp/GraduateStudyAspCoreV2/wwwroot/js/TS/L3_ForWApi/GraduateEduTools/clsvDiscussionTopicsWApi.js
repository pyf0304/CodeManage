/**
* 类名:clsvDiscussionTopicsWApi
* 表名:vDiscussionTopics(01120586)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:47:52
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsvDiscussionTopicsEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vDiscussionTopics_GetObjFromJsonObj = exports.vDiscussionTopics_CopyObjTo = exports.vDiscussionTopics_GetCombineCondition = exports.vDiscussionTopics_GetObjByJSONStr = exports.vDiscussionTopics_GetObjLstByJSONObjLst = exports.vDiscussionTopics_GetObjLstByJSONStr = exports.vDiscussionTopics_GetJSONStrByObj = exports.vDiscussionTopics_ReFreshThisCache = exports.vDiscussionTopics_GetWebApiUrl = exports.vDiscussionTopics_GetRecCountByCond_Cache = exports.vDiscussionTopics_GetRecCountByCondAsync = exports.vDiscussionTopics_IsExistAsync = exports.vDiscussionTopics_IsExist_Cache = exports.vDiscussionTopics_IsExist = exports.vDiscussionTopics_IsExistRecordAsync = exports.vDiscussionTopics_IsExistRecord_Cache = exports.vDiscussionTopics_GetObjLstByPagerAsync = exports.vDiscussionTopics_GetObjLstByPager_Cache = exports.vDiscussionTopics_GetObjLstByRange = exports.vDiscussionTopics_GetObjLstByRangeAsync = exports.vDiscussionTopics_GetTopObjLstAsync = exports.vDiscussionTopics_GetObjLstByTopicsIdLst_Cache = exports.vDiscussionTopics_GetObjLstByTopicsIdLstAsync = exports.vDiscussionTopics_GetSubObjLst_Cache = exports.vDiscussionTopics_GetObjLst_PureCache = exports.vDiscussionTopics_GetObjLst_Cache = exports.vDiscussionTopics_GetObjLst_sessionStorage_PureCache = exports.vDiscussionTopics_GetObjLst_sessionStorage = exports.vDiscussionTopics_GetObjLstAsync = exports.vDiscussionTopics_GetObjLst_localStorage_PureCache = exports.vDiscussionTopics_GetObjLst_localStorage = exports.vDiscussionTopics_GetObjLst_ClientCache = exports.vDiscussionTopics_GetFirstObjAsync = exports.vDiscussionTopics_GetFirstID = exports.vDiscussionTopics_GetFirstIDAsync = exports.vDiscussionTopics_funcKey = exports.vDiscussionTopics_FilterFunByKey = exports.vDiscussionTopics_SortFunByKey = exports.vDiscussionTopics_SortFun_Defa_2Fld = exports.vDiscussionTopics_SortFun_Defa = exports.vDiscussionTopics_func = exports.vDiscussionTopics_GetObjByTopicsId_localStorage = exports.vDiscussionTopics_GetObjByTopicsId_Cache = exports.vDiscussionTopics_GetObjByTopicsIdAsync = exports.vDiscussionTopics_ConstructorName = exports.vDiscussionTopics_Controller = void 0;
    /**
     * v讨论主题视图(vDiscussionTopics)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvDiscussionTopicsEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvDiscussionTopicsEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vDiscussionTopics_Controller = "vDiscussionTopicsApi";
    exports.vDiscussionTopics_ConstructorName = "vDiscussionTopics";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strTopicsId:关键字
    * @returns 对象
    **/
    async function vDiscussionTopics_GetObjByTopicsIdAsync(strTopicsId) {
        const strThisFuncName = "GetObjByTopicsIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicsId]不能为空！(In clsvDiscussionTopicsWApi.GetObjByTopicsIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicsId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.GetObjByTopicsIdAsync)", strTopicsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByTopicsId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const objvDiscussionTopics = vDiscussionTopics_GetObjFromJsonObj(returnObj);
                return objvDiscussionTopics;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetObjByTopicsIdAsync = vDiscussionTopics_GetObjByTopicsIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strTopicsId:所给的关键字
     * @returns 对象
    */
    async function vDiscussionTopics_GetObjByTopicsId_Cache(strTopicsId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByTopicsId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicsId]不能为空！(In clsvDiscussionTopicsWApi.GetObjByTopicsId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicsId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.GetObjByTopicsId_Cache)", strTopicsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache.filter(x => x.topicsId == strTopicsId);
            let objvDiscussionTopics;
            if (arrvDiscussionTopics_Sel.length > 0) {
                objvDiscussionTopics = arrvDiscussionTopics_Sel[0];
                return objvDiscussionTopics;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvDiscussionTopics_Const = await vDiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
                    if (objvDiscussionTopics_Const != null) {
                        vDiscussionTopics_ReFreshThisCache(strid_CurrEduCls);
                        return objvDiscussionTopics_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicsId, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vDiscussionTopics_GetObjByTopicsId_Cache = vDiscussionTopics_GetObjByTopicsId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strTopicsId:所给的关键字
     * @returns 对象
    */
    async function vDiscussionTopics_GetObjByTopicsId_localStorage(strTopicsId) {
        const strThisFuncName = "GetObjByTopicsId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strTopicsId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strTopicsId]不能为空！(In clsvDiscussionTopicsWApi.GetObjByTopicsId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strTopicsId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strTopicsId]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.GetObjByTopicsId_localStorage)", strTopicsId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strTopicsId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvDiscussionTopics_Cache = JSON.parse(strTempObj);
            return objvDiscussionTopics_Cache;
        }
        try {
            const objvDiscussionTopics = await vDiscussionTopics_GetObjByTopicsIdAsync(strTopicsId);
            if (objvDiscussionTopics != null) {
                localStorage.setItem(strKey, JSON.stringify(objvDiscussionTopics));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvDiscussionTopics;
            }
            return objvDiscussionTopics;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strTopicsId, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vDiscussionTopics_GetObjByTopicsId_localStorage = vDiscussionTopics_GetObjByTopicsId_localStorage;
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
    async function vDiscussionTopics_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvDiscussionTopicsWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strTopicsId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvDiscussionTopics = await vDiscussionTopics_GetObjByTopicsId_Cache(strTopicsId, strid_CurrEduCls_C);
        if (objvDiscussionTopics == null)
            return "";
        if (objvDiscussionTopics.GetFldValue(strOutFldName) == null)
            return "";
        return objvDiscussionTopics.GetFldValue(strOutFldName).toString();
    }
    exports.vDiscussionTopics_func = vDiscussionTopics_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vDiscussionTopics_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.topicsId.localeCompare(b.topicsId);
    }
    exports.vDiscussionTopics_SortFun_Defa = vDiscussionTopics_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vDiscussionTopics_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.discussionTypeId == b.discussionTypeId)
            return a.discussionTypeName.localeCompare(b.discussionTypeName);
        else
            return a.discussionTypeId.localeCompare(b.discussionTypeId);
    }
    exports.vDiscussionTopics_SortFun_Defa_2Fld = vDiscussionTopics_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vDiscussionTopics_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId:
                    return (a, b) => {
                        return a.topicsId.localeCompare(b.topicsId);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeId:
                    return (a, b) => {
                        return a.discussionTypeId.localeCompare(b.discussionTypeId);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeName:
                    return (a, b) => {
                        if (a.discussionTypeName == null)
                            return -1;
                        if (b.discussionTypeName == null)
                            return 1;
                        return a.discussionTypeName.localeCompare(b.discussionTypeName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsTitle:
                    return (a, b) => {
                        if (a.topicsTitle == null)
                            return -1;
                        if (b.topicsTitle == null)
                            return 1;
                        return a.topicsTitle.localeCompare(b.topicsTitle);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsContent:
                    return (a, b) => {
                        if (a.topicsContent == null)
                            return -1;
                        if (b.topicsContent == null)
                            return 1;
                        return a.topicsContent.localeCompare(b.topicsContent);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsAudit:
                    return (a, b) => {
                        if (a.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsTop:
                    return (a, b) => {
                        if (a.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_BrowseNumber:
                    return (a, b) => {
                        return a.browseNumber - b.browseNumber;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_CollegeName:
                    return (a, b) => {
                        if (a.collegeName == null)
                            return -1;
                        if (b.collegeName == null)
                            return 1;
                        return a.collegeName.localeCompare(b.collegeName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzCollege:
                    return (a, b) => {
                        if (a.id_XzCollege == null)
                            return -1;
                        if (b.id_XzCollege == null)
                            return 1;
                        return a.id_XzCollege.localeCompare(b.id_XzCollege);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzMajor:
                    return (a, b) => {
                        if (a.id_XzMajor == null)
                            return -1;
                        if (b.id_XzMajor == null)
                            return 1;
                        return a.id_XzMajor.localeCompare(b.id_XzMajor);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_MajorName:
                    return (a, b) => {
                        if (a.majorName == null)
                            return -1;
                        if (b.majorName == null)
                            return 1;
                        return a.majorName.localeCompare(b.majorName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UserName:
                    return (a, b) => {
                        if (a.userName == null)
                            return -1;
                        if (b.userName == null)
                            return 1;
                        return a.userName.localeCompare(b.userName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_SubCount:
                    return (a, b) => {
                        return a.subCount - b.subCount;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vDiscussionTopics]中不存在！(in ${exports.vDiscussionTopics_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId:
                    return (a, b) => {
                        return b.topicsId.localeCompare(a.topicsId);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeId:
                    return (a, b) => {
                        return b.discussionTypeId.localeCompare(a.discussionTypeId);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeName:
                    return (a, b) => {
                        if (b.discussionTypeName == null)
                            return -1;
                        if (a.discussionTypeName == null)
                            return 1;
                        return b.discussionTypeName.localeCompare(a.discussionTypeName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsTitle:
                    return (a, b) => {
                        if (b.topicsTitle == null)
                            return -1;
                        if (a.topicsTitle == null)
                            return 1;
                        return b.topicsTitle.localeCompare(a.topicsTitle);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsContent:
                    return (a, b) => {
                        if (b.topicsContent == null)
                            return -1;
                        if (a.topicsContent == null)
                            return 1;
                        return b.topicsContent.localeCompare(a.topicsContent);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsAudit:
                    return (a, b) => {
                        if (b.isAudit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsTop:
                    return (a, b) => {
                        if (b.isTop == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_BrowseNumber:
                    return (a, b) => {
                        return b.browseNumber - a.browseNumber;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_CollegeName:
                    return (a, b) => {
                        if (b.collegeName == null)
                            return -1;
                        if (a.collegeName == null)
                            return 1;
                        return b.collegeName.localeCompare(a.collegeName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzCollege:
                    return (a, b) => {
                        if (b.id_XzCollege == null)
                            return -1;
                        if (a.id_XzCollege == null)
                            return 1;
                        return b.id_XzCollege.localeCompare(a.id_XzCollege);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzMajor:
                    return (a, b) => {
                        if (b.id_XzMajor == null)
                            return -1;
                        if (a.id_XzMajor == null)
                            return 1;
                        return b.id_XzMajor.localeCompare(a.id_XzMajor);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_MajorName:
                    return (a, b) => {
                        if (b.majorName == null)
                            return -1;
                        if (a.majorName == null)
                            return 1;
                        return b.majorName.localeCompare(a.majorName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UserName:
                    return (a, b) => {
                        if (b.userName == null)
                            return -1;
                        if (a.userName == null)
                            return 1;
                        return b.userName.localeCompare(a.userName);
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_SubCount:
                    return (a, b) => {
                        return b.subCount - a.subCount;
                    };
                case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vDiscussionTopics]中不存在！(in ${exports.vDiscussionTopics_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vDiscussionTopics_SortFunByKey = vDiscussionTopics_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vDiscussionTopics_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId:
                return (obj) => {
                    return obj.topicsId === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeId:
                return (obj) => {
                    return obj.discussionTypeId === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeName:
                return (obj) => {
                    return obj.discussionTypeName === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsTitle:
                return (obj) => {
                    return obj.topicsTitle === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsContent:
                return (obj) => {
                    return obj.topicsContent === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsAudit:
                return (obj) => {
                    return obj.isAudit === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsTop:
                return (obj) => {
                    return obj.isTop === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_BrowseNumber:
                return (obj) => {
                    return obj.browseNumber === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_CollegeName:
                return (obj) => {
                    return obj.collegeName === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzCollege:
                return (obj) => {
                    return obj.id_XzCollege === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzMajor:
                return (obj) => {
                    return obj.id_XzMajor === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_MajorName:
                return (obj) => {
                    return obj.majorName === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UserName:
                return (obj) => {
                    return obj.userName === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_SubCount:
                return (obj) => {
                    return obj.subCount === value;
                };
            case clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vDiscussionTopics]中不存在！(in ${exports.vDiscussionTopics_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vDiscussionTopics_FilterFunByKey = vDiscussionTopics_FilterFunByKey;
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
    async function vDiscussionTopics_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvDiscussionTopicsWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvDiscussionTopicsWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvDiscussionTopics = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvDiscussionTopics == null)
            return [];
        let arrvDiscussionTopics_Sel = arrvDiscussionTopics;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvDiscussionTopics_Sel.length == 0)
            return [];
        return arrvDiscussionTopics_Sel.map(x => x.topicsId);
    }
    exports.vDiscussionTopics_funcKey = vDiscussionTopics_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vDiscussionTopics_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetFirstIDAsync = vDiscussionTopics_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vDiscussionTopics_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetFirstID = vDiscussionTopics_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vDiscussionTopics_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const objvDiscussionTopics = vDiscussionTopics_GetObjFromJsonObj(returnObj);
                return objvDiscussionTopics;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetFirstObjAsync = vDiscussionTopics_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvDiscussionTopicsExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvDiscussionTopicsObjLst_T = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsExObjLst_Cache);
            return arrvDiscussionTopicsObjLst_T;
        }
        try {
            const arrvDiscussionTopicsExObjLst = await vDiscussionTopics_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvDiscussionTopicsExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvDiscussionTopicsExObjLst.length);
            console.log(strInfo);
            return arrvDiscussionTopicsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vDiscussionTopics_GetObjLst_ClientCache = vDiscussionTopics_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvDiscussionTopicsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvDiscussionTopicsObjLst_T = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsExObjLst_Cache);
            return arrvDiscussionTopicsObjLst_T;
        }
        try {
            const arrvDiscussionTopicsExObjLst = await vDiscussionTopics_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvDiscussionTopicsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvDiscussionTopicsExObjLst.length);
            console.log(strInfo);
            return arrvDiscussionTopicsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vDiscussionTopics_GetObjLst_localStorage = vDiscussionTopics_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvDiscussionTopicsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvDiscussionTopicsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vDiscussionTopics_GetObjLst_localStorage_PureCache = vDiscussionTopics_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vDiscussionTopics_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetObjLstAsync = vDiscussionTopics_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvDiscussionTopicsExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvDiscussionTopicsObjLst_T = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsExObjLst_Cache);
            return arrvDiscussionTopicsObjLst_T;
        }
        try {
            const arrvDiscussionTopicsExObjLst = await vDiscussionTopics_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvDiscussionTopicsExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvDiscussionTopicsExObjLst.length);
            console.log(strInfo);
            return arrvDiscussionTopicsExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vDiscussionTopics_GetObjLst_sessionStorage = vDiscussionTopics_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvDiscussionTopicsObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvDiscussionTopicsObjLst_Cache;
        }
        else
            return null;
    }
    exports.vDiscussionTopics_GetObjLst_sessionStorage_PureCache = vDiscussionTopics_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvDiscussionTopicsWApi.vDiscussionTopics_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvDiscussionTopicsWApi.vDiscussionTopics_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvDiscussionTopicsObjLst_Cache;
        switch (clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvDiscussionTopicsObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsObjLst_Cache);
        return arrvDiscussionTopicsObjLst_Cache;
    }
    exports.vDiscussionTopics_GetObjLst_Cache = vDiscussionTopics_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vDiscussionTopics_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvDiscussionTopicsObjLst_Cache;
        switch (clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheModeId) {
            case "04": //sessionStorage
                arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvDiscussionTopicsObjLst_Cache = null;
                break;
            default:
                arrvDiscussionTopicsObjLst_Cache = null;
                break;
        }
        return arrvDiscussionTopicsObjLst_Cache;
    }
    exports.vDiscussionTopics_GetObjLst_PureCache = vDiscussionTopics_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrTopicsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vDiscussionTopics_GetSubObjLst_Cache(objvDiscussionTopics_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        let arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache;
        if (objvDiscussionTopics_Cond.sf_FldComparisonOp == null || objvDiscussionTopics_Cond.sf_FldComparisonOp == "")
            return arrvDiscussionTopics_Sel;
        const dicFldComparisonOp = JSON.parse(objvDiscussionTopics_Cond.sf_FldComparisonOp);
        //console.log("clsvDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvDiscussionTopics_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvDiscussionTopics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvDiscussionTopics_Cond), exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vDiscussionTopics_GetSubObjLst_Cache = vDiscussionTopics_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrTopicsId:关键字列表
    * @returns 对象列表
    **/
    async function vDiscussionTopics_GetObjLstByTopicsIdLstAsync(arrTopicsId) {
        const strThisFuncName = "GetObjLstByTopicsIdLstAsync";
        const strAction = "GetObjLstByTopicsIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrTopicsId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetObjLstByTopicsIdLstAsync = vDiscussionTopics_GetObjLstByTopicsIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrTopicsIdLst:关键字列表
     * @returns 对象列表
    */
    async function vDiscussionTopics_GetObjLstByTopicsIdLst_Cache(arrTopicsIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByTopicsIdLst_Cache";
        try {
            const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
            const arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache.filter(x => arrTopicsIdLst.indexOf(x.topicsId) > -1);
            return arrvDiscussionTopics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrTopicsIdLst.join(","), exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vDiscussionTopics_GetObjLstByTopicsIdLst_Cache = vDiscussionTopics_GetObjLstByTopicsIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vDiscussionTopics_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetTopObjLstAsync = vDiscussionTopics_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vDiscussionTopics_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetObjLstByRangeAsync = vDiscussionTopics_GetObjLstByRangeAsync;
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
    async function vDiscussionTopics_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetObjLstByRange = vDiscussionTopics_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vDiscussionTopics_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvDiscussionTopicsObjLst_Cache.length == 0)
            return arrvDiscussionTopicsObjLst_Cache;
        let arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvDiscussionTopics_Cond = new clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvDiscussionTopics_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvDiscussionTopicsWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvDiscussionTopics_Sel.length == 0)
                return arrvDiscussionTopics_Sel;
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
                arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.sort(vDiscussionTopics_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.sort(objPagerPara.sortFun);
            }
            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.slice(intStart, intEnd);
            return arrvDiscussionTopics_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vDiscussionTopics_GetObjLstByPager_Cache = vDiscussionTopics_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vDiscussionTopics_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vDiscussionTopics_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetObjLstByPagerAsync = vDiscussionTopics_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrTopicsId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vDiscussionTopics_IsExistRecord_Cache(objvDiscussionTopics_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvDiscussionTopicsObjLst_Cache == null)
            return false;
        let arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache;
        if (objvDiscussionTopics_Cond.sf_FldComparisonOp == null || objvDiscussionTopics_Cond.sf_FldComparisonOp == "")
            return arrvDiscussionTopics_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvDiscussionTopics_Cond.sf_FldComparisonOp);
        //console.log("clsvDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvDiscussionTopics_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvDiscussionTopics_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvDiscussionTopics_Cond), exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vDiscussionTopics_IsExistRecord_Cache = vDiscussionTopics_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vDiscussionTopics_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_IsExistRecordAsync = vDiscussionTopics_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strTopicsId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vDiscussionTopics_IsExist(strTopicsId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_IsExist = vDiscussionTopics_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strTopicsId:所给的关键字
     * @returns 对象
    */
    async function vDiscussionTopics_IsExist_Cache(strTopicsId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvDiscussionTopicsObjLst_Cache == null)
            return false;
        try {
            const arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache.filter(x => x.topicsId == strTopicsId);
            if (arrvDiscussionTopics_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strTopicsId, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vDiscussionTopics_IsExist_Cache = vDiscussionTopics_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strTopicsId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vDiscussionTopics_IsExistAsync(strTopicsId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_IsExistAsync = vDiscussionTopics_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vDiscussionTopics_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vDiscussionTopics_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vDiscussionTopics_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vDiscussionTopics_GetRecCountByCondAsync = vDiscussionTopics_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvDiscussionTopics_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vDiscussionTopics_GetRecCountByCond_Cache(objvDiscussionTopics_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvDiscussionTopicsObjLst_Cache = await vDiscussionTopics_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvDiscussionTopicsObjLst_Cache == null)
            return 0;
        let arrvDiscussionTopics_Sel = arrvDiscussionTopicsObjLst_Cache;
        if (objvDiscussionTopics_Cond.sf_FldComparisonOp == null || objvDiscussionTopics_Cond.sf_FldComparisonOp == "")
            return arrvDiscussionTopics_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvDiscussionTopics_Cond.sf_FldComparisonOp);
        //console.log("clsvDiscussionTopicsWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvDiscussionTopics_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvDiscussionTopics_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvDiscussionTopics_Sel = arrvDiscussionTopics_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvDiscussionTopics_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvDiscussionTopics_Cond), exports.vDiscussionTopics_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vDiscussionTopics_GetRecCountByCond_Cache = vDiscussionTopics_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vDiscussionTopics_GetWebApiUrl(strController, strAction) {
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
    exports.vDiscussionTopics_GetWebApiUrl = vDiscussionTopics_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vDiscussionTopics_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN._CurrTabName, strid_CurrEduCls);
            switch (clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.CacheModeId) {
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
    exports.vDiscussionTopics_ReFreshThisCache = vDiscussionTopics_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vDiscussionTopics_GetJSONStrByObj(pobjvDiscussionTopicsEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvDiscussionTopicsEN);
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
    exports.vDiscussionTopics_GetJSONStrByObj = vDiscussionTopics_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vDiscussionTopics_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvDiscussionTopicsObjLst = new Array();
        if (strJSON === "") {
            return arrvDiscussionTopicsObjLst;
        }
        try {
            arrvDiscussionTopicsObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvDiscussionTopicsObjLst;
        }
        return arrvDiscussionTopicsObjLst;
    }
    exports.vDiscussionTopics_GetObjLstByJSONStr = vDiscussionTopics_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvDiscussionTopicsObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vDiscussionTopics_GetObjLstByJSONObjLst(arrvDiscussionTopicsObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvDiscussionTopicsObjLst = new Array();
        for (const objInFor of arrvDiscussionTopicsObjLstS) {
            const obj1 = vDiscussionTopics_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvDiscussionTopicsObjLst.push(obj1);
        }
        return arrvDiscussionTopicsObjLst;
    }
    exports.vDiscussionTopics_GetObjLstByJSONObjLst = vDiscussionTopics_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vDiscussionTopics_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvDiscussionTopicsEN = new clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN();
        if (strJSON === "") {
            return pobjvDiscussionTopicsEN;
        }
        try {
            pobjvDiscussionTopicsEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvDiscussionTopicsEN;
        }
        return pobjvDiscussionTopicsEN;
    }
    exports.vDiscussionTopics_GetObjByJSONStr = vDiscussionTopics_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vDiscussionTopics_GetCombineCondition(objvDiscussionTopics_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId) == true) {
            const strComparisonOp_TopicsId = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsId, objvDiscussionTopics_Cond.topicsId, strComparisonOp_TopicsId);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeId) == true) {
            const strComparisonOp_DiscussionTypeId = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeId, objvDiscussionTopics_Cond.discussionTypeId, strComparisonOp_DiscussionTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeName) == true) {
            const strComparisonOp_DiscussionTypeName = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_DiscussionTypeName, objvDiscussionTopics_Cond.discussionTypeName, strComparisonOp_DiscussionTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsTitle) == true) {
            const strComparisonOp_TopicsTitle = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_TopicsTitle, objvDiscussionTopics_Cond.topicsTitle, strComparisonOp_TopicsTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsAudit) == true) {
            if (objvDiscussionTopics_Cond.isAudit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsAudit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsAudit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsTop) == true) {
            if (objvDiscussionTopics_Cond.isTop == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsTop);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_IsTop);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_BrowseNumber) == true) {
            const strComparisonOp_BrowseNumber = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_BrowseNumber];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_BrowseNumber, objvDiscussionTopics_Cond.browseNumber, strComparisonOp_BrowseNumber);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdDate, objvDiscussionTopics_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UpdUser, objvDiscussionTopics_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_Memo, objvDiscussionTopics_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_CollegeName) == true) {
            const strComparisonOp_CollegeName = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_CollegeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_CollegeName, objvDiscussionTopics_Cond.collegeName, strComparisonOp_CollegeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzCollege) == true) {
            const strComparisonOp_id_XzCollege = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzCollege];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzCollege, objvDiscussionTopics_Cond.id_XzCollege, strComparisonOp_id_XzCollege);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzMajor) == true) {
            const strComparisonOp_id_XzMajor = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzMajor];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_XzMajor, objvDiscussionTopics_Cond.id_XzMajor, strComparisonOp_id_XzMajor);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_MajorName) == true) {
            const strComparisonOp_MajorName = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_MajorName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_MajorName, objvDiscussionTopics_Cond.majorName, strComparisonOp_MajorName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UserName) == true) {
            const strComparisonOp_UserName = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UserName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_UserName, objvDiscussionTopics_Cond.userName, strComparisonOp_UserName);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_SubCount) == true) {
            const strComparisonOp_SubCount = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_SubCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_SubCount, objvDiscussionTopics_Cond.subCount, strComparisonOp_SubCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvDiscussionTopics_Cond.dicFldComparisonOp, clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvDiscussionTopics_Cond.dicFldComparisonOp[clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN.con_id_CurrEduCls, objvDiscussionTopics_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        return strWhereCond;
    }
    exports.vDiscussionTopics_GetCombineCondition = vDiscussionTopics_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvDiscussionTopicsENS:源对象
     * @param objvDiscussionTopicsENT:目标对象
    */
    function vDiscussionTopics_CopyObjTo(objvDiscussionTopicsENS, objvDiscussionTopicsENT) {
        objvDiscussionTopicsENT.topicsId = objvDiscussionTopicsENS.topicsId; //主题Id
        objvDiscussionTopicsENT.discussionTypeId = objvDiscussionTopicsENS.discussionTypeId; //讨论类型Id
        objvDiscussionTopicsENT.discussionTypeName = objvDiscussionTopicsENS.discussionTypeName; //讨论类型名称
        objvDiscussionTopicsENT.topicsTitle = objvDiscussionTopicsENS.topicsTitle; //主题标题
        objvDiscussionTopicsENT.topicsContent = objvDiscussionTopicsENS.topicsContent; //主题内容
        objvDiscussionTopicsENT.isAudit = objvDiscussionTopicsENS.isAudit; //是否审核
        objvDiscussionTopicsENT.isTop = objvDiscussionTopicsENS.isTop; //是否置顶
        objvDiscussionTopicsENT.browseNumber = objvDiscussionTopicsENS.browseNumber; //浏览量
        objvDiscussionTopicsENT.updDate = objvDiscussionTopicsENS.updDate; //修改日期
        objvDiscussionTopicsENT.updUser = objvDiscussionTopicsENS.updUser; //修改人
        objvDiscussionTopicsENT.memo = objvDiscussionTopicsENS.memo; //备注
        objvDiscussionTopicsENT.collegeName = objvDiscussionTopicsENS.collegeName; //学院名称
        objvDiscussionTopicsENT.id_XzCollege = objvDiscussionTopicsENS.id_XzCollege; //学院流水号
        objvDiscussionTopicsENT.id_XzMajor = objvDiscussionTopicsENS.id_XzMajor; //专业流水号
        objvDiscussionTopicsENT.majorName = objvDiscussionTopicsENS.majorName; //专业名称
        objvDiscussionTopicsENT.userName = objvDiscussionTopicsENS.userName; //用户名
        objvDiscussionTopicsENT.subCount = objvDiscussionTopicsENS.subCount; //SubCount
        objvDiscussionTopicsENT.id_CurrEduCls = objvDiscussionTopicsENS.id_CurrEduCls; //教学班流水号
    }
    exports.vDiscussionTopics_CopyObjTo = vDiscussionTopics_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvDiscussionTopicsENS:源对象
     * @param objvDiscussionTopicsENT:目标对象
    */
    function vDiscussionTopics_GetObjFromJsonObj(objvDiscussionTopicsENS) {
        const objvDiscussionTopicsENT = new clsvDiscussionTopicsEN_js_1.clsvDiscussionTopicsEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvDiscussionTopicsENT, objvDiscussionTopicsENS);
        return objvDiscussionTopicsENT;
    }
    exports.vDiscussionTopics_GetObjFromJsonObj = vDiscussionTopics_GetObjFromJsonObj;
});
