/**
* 类名:clsSysCommentWApi
* 表名:SysComment(01120622)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:46:52
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsSysCommentEN.js", "../../L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.SysComment_GetObjFromJsonObj = exports.SysComment_CopyObjTo = exports.SysComment_GetUniCondStr4Update_CommentId = exports.SysComment_GetUniCondStr_CommentId = exports.SysComment_GetCombineCondition = exports.SysComment_GetObjByJSONStr = exports.SysComment_GetObjLstByJSONObjLst = exports.SysComment_GetObjLstByJSONStr = exports.SysComment_GetJSONStrByObj = exports.SysComment_CheckProperty4Update = exports.SysComment_CheckPropertyNew = exports.SysComment_ReFreshThisCache = exports.SysComment_ReFreshCache = exports.SysComment_GetWebApiUrl = exports.SysComment_GetMaxStrIdByPrefix = exports.SysComment_GetMaxStrIdAsync = exports.SysComment_GetRecCountByCond_Cache = exports.SysComment_GetRecCountByCondAsync = exports.SysComment_IsExistAsync = exports.SysComment_IsExist_Cache = exports.SysComment_IsExist = exports.SysComment_IsExistRecordAsync = exports.SysComment_IsExistRecord_Cache = exports.SysComment_UpdateWithConditionAsync = exports.SysComment_UpdateRecordAsync = exports.SysComment_AddNewRecordWithReturnKey = exports.SysComment_AddNewRecordWithReturnKeyAsync = exports.SysComment_AddNewRecordWithMaxIdAsync = exports.SysComment_AddNewRecordAsync = exports.SysComment_DelSysCommentsByCondAsync = exports.SysComment_DelSysCommentsAsync = exports.SysComment_DelRecordAsync = exports.SysComment_GetObjLstByPagerAsync = exports.SysComment_GetObjLstByPager_Cache = exports.SysComment_GetObjLstByRange = exports.SysComment_GetObjLstByRangeAsync = exports.SysComment_GetTopObjLstAsync = exports.SysComment_GetObjLstByCommentIdLst_Cache = exports.SysComment_GetObjLstByCommentIdLstAsync = exports.SysComment_GetSubObjLst_Cache = exports.SysComment_GetObjLst_PureCache = exports.SysComment_GetObjLst_Cache = exports.SysComment_GetObjLst_sessionStorage_PureCache = exports.SysComment_GetObjLst_sessionStorage = exports.SysComment_GetObjLstAsync = exports.SysComment_GetObjLst_localStorage_PureCache = exports.SysComment_GetObjLst_localStorage = exports.SysComment_GetObjLst_ClientCache = exports.SysComment_GetFirstObjAsync = exports.SysComment_GetFirstID = exports.SysComment_GetFirstIDAsync = exports.SysComment_funcKey = exports.SysComment_FilterFunByKey = exports.SysComment_SortFunByKey = exports.SysComment_SortFun_Defa_2Fld = exports.SysComment_SortFun_Defa = exports.SysComment_func = exports.SysComment_UpdateObjInLst_Cache = exports.SysComment_GetObjByCommentId_localStorage = exports.SysComment_GetObjByCommentId_Cache = exports.SysComment_GetObjByCommentIdAsync = exports.sysComment_ConstructorName = exports.sysComment_Controller = void 0;
    /**
     * 系统评论表(SysComment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsSysCommentEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsSysCommentEN.js");
    const clsvSysCommentWApi_js_1 = require("../../L3_ForWApi/GraduateEduTools/clsvSysCommentWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.sysComment_Controller = "SysCommentApi";
    exports.sysComment_ConstructorName = "sysComment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCommentId:关键字
    * @returns 对象
    **/
    async function SysComment_GetObjByCommentIdAsync(strCommentId) {
        const strThisFuncName = "GetObjByCommentIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCommentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCommentId]不能为空！(In clsSysCommentWApi.GetObjByCommentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCommentId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsSysCommentWApi.GetObjByCommentIdAsync)", strCommentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCommentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strCommentId": strCommentId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objSysComment = SysComment_GetObjFromJsonObj(returnObj);
                return objSysComment;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetObjByCommentIdAsync = SysComment_GetObjByCommentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCommentId:所给的关键字
     * @returns 对象
    */
    async function SysComment_GetObjByCommentId_Cache(strCommentId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCommentId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCommentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCommentId]不能为空！(In clsSysCommentWApi.GetObjByCommentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCommentId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsSysCommentWApi.GetObjByCommentId_Cache)", strCommentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrSysComment_Sel = arrSysCommentObjLst_Cache.filter(x => x.commentId == strCommentId);
            let objSysComment;
            if (arrSysComment_Sel.length > 0) {
                objSysComment = arrSysComment_Sel[0];
                return objSysComment;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objSysComment_Const = await SysComment_GetObjByCommentIdAsync(strCommentId);
                    if (objSysComment_Const != null) {
                        SysComment_ReFreshThisCache(strid_CurrEduCls);
                        return objSysComment_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.SysComment_GetObjByCommentId_Cache = SysComment_GetObjByCommentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCommentId:所给的关键字
     * @returns 对象
    */
    async function SysComment_GetObjByCommentId_localStorage(strCommentId) {
        const strThisFuncName = "GetObjByCommentId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strCommentId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strCommentId]不能为空！(In clsSysCommentWApi.GetObjByCommentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCommentId.length != 10) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strCommentId]的长度:[{0}]不正确！(clsSysCommentWApi.GetObjByCommentId_localStorage)", strCommentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strCommentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objSysComment_Cache = JSON.parse(strTempObj);
            return objSysComment_Cache;
        }
        try {
            const objSysComment = await SysComment_GetObjByCommentIdAsync(strCommentId);
            if (objSysComment != null) {
                localStorage.setItem(strKey, JSON.stringify(objSysComment));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objSysComment;
            }
            return objSysComment;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.SysComment_GetObjByCommentId_localStorage = SysComment_GetObjByCommentId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objSysComment:所给的对象
     * @returns 对象
    */
    async function SysComment_UpdateObjInLst_Cache(objSysComment, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrSysCommentObjLst_Cache.find(x => x.commentId == objSysComment.commentId);
            if (obj != null) {
                objSysComment.commentId = obj.commentId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objSysComment);
            }
            else {
                arrSysCommentObjLst_Cache.push(objSysComment);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.SysComment_UpdateObjInLst_Cache = SysComment_UpdateObjInLst_Cache;
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
    async function SysComment_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsSysCommentWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysCommentWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsSysCommentEN_js_1.clsSysCommentEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsSysCommentEN_js_1.clsSysCommentEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCommentId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objSysComment = await SysComment_GetObjByCommentId_Cache(strCommentId, strid_CurrEduCls_C);
        if (objSysComment == null)
            return "";
        if (objSysComment.GetFldValue(strOutFldName) == null)
            return "";
        return objSysComment.GetFldValue(strOutFldName).toString();
    }
    exports.SysComment_func = SysComment_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysComment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.commentId.localeCompare(b.commentId);
    }
    exports.SysComment_SortFun_Defa = SysComment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysComment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.comment == b.comment)
            return a.score - b.score;
        else
            return a.comment.localeCompare(b.comment);
    }
    exports.SysComment_SortFun_Defa_2Fld = SysComment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function SysComment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId:
                    return (a, b) => {
                        return a.commentId.localeCompare(b.commentId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Comment:
                    return (a, b) => {
                        if (a.comment == null)
                            return -1;
                        if (b.comment == null)
                            return 1;
                        return a.comment.localeCompare(b.comment);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_CommentTypeId:
                    return (a, b) => {
                        return a.commentTypeId.localeCompare(b.commentTypeId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_ScoreType:
                    return (a, b) => {
                        if (a.scoreType == null)
                            return -1;
                        if (b.scoreType == null)
                            return 1;
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_TableKey:
                    return (a, b) => {
                        if (a.tableKey == null)
                            return -1;
                        if (b.tableKey == null)
                            return 1;
                        return a.tableKey.localeCompare(b.tableKey);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_PubParentId:
                    return (a, b) => {
                        if (a.pubParentId == null)
                            return -1;
                        if (b.pubParentId == null)
                            return 1;
                        return a.pubParentId.localeCompare(b.pubParentId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_UserId:
                    return (a, b) => {
                        if (a.userId == null)
                            return -1;
                        if (b.userId == null)
                            return 1;
                        return a.userId.localeCompare(b.userId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Month:
                    return (a, b) => {
                        return a.month - b.month;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Week:
                    return (a, b) => {
                        return a.week - b.week;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_WeekTimeRange:
                    return (a, b) => {
                        if (a.weekTimeRange == null)
                            return -1;
                        if (b.weekTimeRange == null)
                            return 1;
                        return a.weekTimeRange.localeCompare(b.weekTimeRange);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysComment]中不存在！(in ${exports.sysComment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId:
                    return (a, b) => {
                        return b.commentId.localeCompare(a.commentId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Comment:
                    return (a, b) => {
                        if (b.comment == null)
                            return -1;
                        if (a.comment == null)
                            return 1;
                        return b.comment.localeCompare(a.comment);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_CommentTypeId:
                    return (a, b) => {
                        return b.commentTypeId.localeCompare(a.commentTypeId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_ScoreType:
                    return (a, b) => {
                        if (b.scoreType == null)
                            return -1;
                        if (a.scoreType == null)
                            return 1;
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_TableKey:
                    return (a, b) => {
                        if (b.tableKey == null)
                            return -1;
                        if (a.tableKey == null)
                            return 1;
                        return b.tableKey.localeCompare(a.tableKey);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_PubParentId:
                    return (a, b) => {
                        if (b.pubParentId == null)
                            return -1;
                        if (a.pubParentId == null)
                            return 1;
                        return b.pubParentId.localeCompare(a.pubParentId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_UserId:
                    return (a, b) => {
                        if (b.userId == null)
                            return -1;
                        if (a.userId == null)
                            return 1;
                        return b.userId.localeCompare(a.userId);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Month:
                    return (a, b) => {
                        return b.month - a.month;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Week:
                    return (a, b) => {
                        return b.week - a.week;
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_WeekTimeRange:
                    return (a, b) => {
                        if (b.weekTimeRange == null)
                            return -1;
                        if (a.weekTimeRange == null)
                            return 1;
                        return b.weekTimeRange.localeCompare(a.weekTimeRange);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsSysCommentEN_js_1.clsSysCommentEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[SysComment]中不存在！(in ${exports.sysComment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.SysComment_SortFunByKey = SysComment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function SysComment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId:
                return (obj) => {
                    return obj.commentId === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_Comment:
                return (obj) => {
                    return obj.comment === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_Score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_CommentTypeId:
                return (obj) => {
                    return obj.commentTypeId === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_TableKey:
                return (obj) => {
                    return obj.tableKey === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_PubParentId:
                return (obj) => {
                    return obj.pubParentId === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_Month:
                return (obj) => {
                    return obj.month === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_Week:
                return (obj) => {
                    return obj.week === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_WeekTimeRange:
                return (obj) => {
                    return obj.weekTimeRange === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsSysCommentEN_js_1.clsSysCommentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[SysComment]中不存在！(in ${exports.sysComment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.SysComment_FilterFunByKey = SysComment_FilterFunByKey;
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
    async function SysComment_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsSysCommentWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsSysCommentWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrSysComment = await SysComment_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrSysComment == null)
            return [];
        let arrSysComment_Sel = arrSysComment;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrSysComment_Sel.length == 0)
            return [];
        return arrSysComment_Sel.map(x => x.commentId);
    }
    exports.SysComment_funcKey = SysComment_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysComment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetFirstIDAsync = SysComment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function SysComment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetFirstID = SysComment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function SysComment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const objSysComment = SysComment_GetObjFromJsonObj(returnObj);
                return objSysComment;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetFirstObjAsync = SysComment_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysCommentEN_js_1.clsSysCommentEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsSysCommentEN_js_1.clsSysCommentEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysCommentEN_js_1.clsSysCommentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSysCommentEN_js_1.clsSysCommentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrSysCommentExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrSysCommentObjLst_T = SysComment_GetObjLstByJSONObjLst(arrSysCommentExObjLst_Cache);
            return arrSysCommentObjLst_T;
        }
        try {
            const arrSysCommentExObjLst = await SysComment_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrSysCommentExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentExObjLst.length);
            console.log(strInfo);
            return arrSysCommentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysComment_GetObjLst_ClientCache = SysComment_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysCommentEN_js_1.clsSysCommentEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsSysCommentEN_js_1.clsSysCommentEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysCommentEN_js_1.clsSysCommentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSysCommentEN_js_1.clsSysCommentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysCommentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysCommentObjLst_T = SysComment_GetObjLstByJSONObjLst(arrSysCommentExObjLst_Cache);
            return arrSysCommentObjLst_T;
        }
        try {
            const arrSysCommentExObjLst = await SysComment_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrSysCommentExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentExObjLst.length);
            console.log(strInfo);
            return arrSysCommentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysComment_GetObjLst_localStorage = SysComment_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrSysCommentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysCommentObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysComment_GetObjLst_localStorage_PureCache = SysComment_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function SysComment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetObjLstAsync = SysComment_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysCommentEN_js_1.clsSysCommentEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsSysCommentEN_js_1.clsSysCommentEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsSysCommentEN_js_1.clsSysCommentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsSysCommentEN_js_1.clsSysCommentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysCommentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrSysCommentObjLst_T = SysComment_GetObjLstByJSONObjLst(arrSysCommentExObjLst_Cache);
            return arrSysCommentObjLst_T;
        }
        try {
            const arrSysCommentExObjLst = await SysComment_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrSysCommentExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrSysCommentExObjLst.length);
            console.log(strInfo);
            return arrSysCommentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.SysComment_GetObjLst_sessionStorage = SysComment_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrSysCommentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrSysCommentObjLst_Cache;
        }
        else
            return null;
    }
    exports.SysComment_GetObjLst_sessionStorage_PureCache = SysComment_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsSysCommentWApi.SysComment_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsSysCommentWApi.SysComment_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrSysCommentObjLst_Cache;
        switch (clsSysCommentEN_js_1.clsSysCommentEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysCommentObjLst_Cache = await SysComment_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrSysCommentObjLst_Cache = await SysComment_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrSysCommentObjLst_Cache = await SysComment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrSysCommentObjLst_Cache = await SysComment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrSysCommentObjLst = SysComment_GetObjLstByJSONObjLst(arrSysCommentObjLst_Cache);
        return arrSysCommentObjLst_Cache;
    }
    exports.SysComment_GetObjLst_Cache = SysComment_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function SysComment_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrSysCommentObjLst_Cache;
        switch (clsSysCommentEN_js_1.clsSysCommentEN.CacheModeId) {
            case "04": //sessionStorage
                arrSysCommentObjLst_Cache = await SysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrSysCommentObjLst_Cache = await SysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrSysCommentObjLst_Cache = null;
                break;
            default:
                arrSysCommentObjLst_Cache = null;
                break;
        }
        return arrSysCommentObjLst_Cache;
    }
    exports.SysComment_GetObjLst_PureCache = SysComment_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCommentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysComment_GetSubObjLst_Cache(objSysComment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
        let arrSysComment_Sel = arrSysCommentObjLst_Cache;
        if (objSysComment_Cond.sf_FldComparisonOp == null || objSysComment_Cond.sf_FldComparisonOp == "")
            return arrSysComment_Sel;
        const dicFldComparisonOp = JSON.parse(objSysComment_Cond.sf_FldComparisonOp);
        //console.log("clsSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysComment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objSysComment_Cond), exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysComment_GetSubObjLst_Cache = SysComment_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCommentId:关键字列表
    * @returns 对象列表
    **/
    async function SysComment_GetObjLstByCommentIdLstAsync(arrCommentId) {
        const strThisFuncName = "GetObjLstByCommentIdLstAsync";
        const strAction = "GetObjLstByCommentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCommentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetObjLstByCommentIdLstAsync = SysComment_GetObjLstByCommentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCommentIdLst:关键字列表
     * @returns 对象列表
    */
    async function SysComment_GetObjLstByCommentIdLst_Cache(arrCommentIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByCommentIdLst_Cache";
        try {
            const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
            const arrSysComment_Sel = arrSysCommentObjLst_Cache.filter(x => arrCommentIdLst.indexOf(x.commentId) > -1);
            return arrSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCommentIdLst.join(","), exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.SysComment_GetObjLstByCommentIdLst_Cache = SysComment_GetObjLstByCommentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function SysComment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetTopObjLstAsync = SysComment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysComment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetObjLstByRangeAsync = SysComment_GetObjLstByRangeAsync;
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
    async function SysComment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetObjLstByRange = SysComment_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function SysComment_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysCommentObjLst_Cache.length == 0)
            return arrSysCommentObjLst_Cache;
        let arrSysComment_Sel = arrSysCommentObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objSysComment_Cond = new clsSysCommentEN_js_1.clsSysCommentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysComment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsSysCommentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysComment_Sel.length == 0)
                return arrSysComment_Sel;
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
                arrSysComment_Sel = arrSysComment_Sel.sort(SysComment_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrSysComment_Sel = arrSysComment_Sel.sort(objPagerPara.sortFun);
            }
            arrSysComment_Sel = arrSysComment_Sel.slice(intStart, intEnd);
            return arrSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.SysComment_GetObjLstByPager_Cache = SysComment_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function SysComment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.sysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = SysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetObjLstByPagerAsync = SysComment_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strCommentId:关键字
    * @returns 获取删除的结果
    **/
    async function SysComment_DelRecordAsync(strCommentId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strCommentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_DelRecordAsync = SysComment_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrCommentId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function SysComment_DelSysCommentsAsync(arrCommentId) {
        const strThisFuncName = "DelSysCommentsAsync";
        const strAction = "DelSysComments";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCommentId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_DelSysCommentsAsync = SysComment_DelSysCommentsAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function SysComment_DelSysCommentsByCondAsync(strWhereCond) {
        const strThisFuncName = "DelSysCommentsByCondAsync";
        const strAction = "DelSysCommentsByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_DelSysCommentsByCondAsync = SysComment_DelSysCommentsByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objSysCommentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysComment_AddNewRecordAsync(objSysCommentEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objSysCommentEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_AddNewRecordAsync = SysComment_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objSysCommentEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function SysComment_AddNewRecordWithMaxIdAsync(objSysCommentEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_AddNewRecordWithMaxIdAsync = SysComment_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objSysCommentEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function SysComment_AddNewRecordWithReturnKeyAsync(objSysCommentEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_AddNewRecordWithReturnKeyAsync = SysComment_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objSysCommentEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function SysComment_AddNewRecordWithReturnKey(objSysCommentEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objSysCommentEN.commentId === null || objSysCommentEN.commentId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_AddNewRecordWithReturnKey = SysComment_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objSysCommentEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function SysComment_UpdateRecordAsync(objSysCommentEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objSysCommentEN.sf_UpdFldSetStr === undefined || objSysCommentEN.sf_UpdFldSetStr === null || objSysCommentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCommentEN.commentId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_UpdateRecordAsync = SysComment_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objSysCommentEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function SysComment_UpdateWithConditionAsync(objSysCommentEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objSysCommentEN.sf_UpdFldSetStr === undefined || objSysCommentEN.sf_UpdFldSetStr === null || objSysCommentEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objSysCommentEN.commentId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        objSysCommentEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objSysCommentEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_UpdateWithConditionAsync = SysComment_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCommentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function SysComment_IsExistRecord_Cache(objSysComment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysCommentObjLst_Cache == null)
            return false;
        let arrSysComment_Sel = arrSysCommentObjLst_Cache;
        if (objSysComment_Cond.sf_FldComparisonOp == null || objSysComment_Cond.sf_FldComparisonOp == "")
            return arrSysComment_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objSysComment_Cond.sf_FldComparisonOp);
        //console.log("clsSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysComment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrSysComment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objSysComment_Cond), exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.SysComment_IsExistRecord_Cache = SysComment_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function SysComment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_IsExistRecordAsync = SysComment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCommentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function SysComment_IsExist(strCommentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "CommentId": strCommentId,
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_IsExist = SysComment_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCommentId:所给的关键字
     * @returns 对象
    */
    async function SysComment_IsExist_Cache(strCommentId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysCommentObjLst_Cache == null)
            return false;
        try {
            const arrSysComment_Sel = arrSysCommentObjLst_Cache.filter(x => x.commentId == strCommentId);
            if (arrSysComment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCommentId, exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.SysComment_IsExist_Cache = SysComment_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCommentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function SysComment_IsExistAsync(strCommentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strCommentId": strCommentId }
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_IsExistAsync = SysComment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function SysComment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetRecCountByCondAsync = SysComment_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objSysComment_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function SysComment_GetRecCountByCond_Cache(objSysComment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrSysCommentObjLst_Cache = await SysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrSysCommentObjLst_Cache == null)
            return 0;
        let arrSysComment_Sel = arrSysCommentObjLst_Cache;
        if (objSysComment_Cond.sf_FldComparisonOp == null || objSysComment_Cond.sf_FldComparisonOp == "")
            return arrSysComment_Sel.length;
        const dicFldComparisonOp = JSON.parse(objSysComment_Cond.sf_FldComparisonOp);
        //console.log("clsSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objSysComment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrSysComment_Sel = arrSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrSysComment_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objSysComment_Cond), exports.sysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.SysComment_GetRecCountByCond_Cache = SysComment_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function SysComment_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetMaxStrIdAsync = SysComment_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function SysComment_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.sysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.sysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.SysComment_GetMaxStrIdByPrefix = SysComment_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function SysComment_GetWebApiUrl(strController, strAction) {
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
    exports.SysComment_GetWebApiUrl = SysComment_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function SysComment_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsSysCommentWApi.clsSysCommentWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsSysCommentWApi.clsSysCommentWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
        switch (clsSysCommentEN_js_1.clsSysCommentEN.CacheModeId) {
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
        (0, clsvSysCommentWApi_js_1.vSysComment_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.SysComment_ReFreshCache = SysComment_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function SysComment_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsSysCommentEN_js_1.clsSysCommentEN._CurrTabName, strid_CurrEduCls);
            switch (clsSysCommentEN_js_1.clsSysCommentEN.CacheModeId) {
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
    exports.SysComment_ReFreshThisCache = SysComment_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysComment_CheckPropertyNew(pobjSysCommentEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[评论类型Id]不能为空(In 系统评论表)!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.parentId) === true) {
            throw new Error("(errid:Watl000058)字段[父Id]不能为空(In 系统评论表)!(clsSysCommentBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.commentId) > 10) {
            throw new Error("(errid:Watl000059)字段[评论Id(commentId)]的长度不能超过10(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentId)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.comment) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.comment) > 2000) {
            throw new Error("(errid:Watl000059)字段[评论(comment)]的长度不能超过2000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.comment)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.commentTypeId) > 2) {
            throw new Error("(errid:Watl000059)字段[评论类型Id(commentTypeId)]的长度不能超过2(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentTypeId)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.scoreType) > 1) {
            throw new Error("(errid:Watl000059)字段[评分类型(scoreType)]的长度不能超过1(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.scoreType)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.parentId) > 20) {
            throw new Error("(errid:Watl000059)字段[父Id(parentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.parentId)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.tableKey) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.tableKey) > 20) {
            throw new Error("(errid:Watl000059)字段[表主键(tableKey)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.tableKey)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.pubParentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.pubParentId) > 20) {
            throw new Error("(errid:Watl000059)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.pubParentId)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.id_CurrEduCls)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.userId) > 18) {
            throw new Error("(errid:Watl000059)字段[用户ID(userId)]的长度不能超过18(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.userId)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.weekTimeRange) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.weekTimeRange) > 100) {
            throw new Error("(errid:Watl000059)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.weekTimeRange)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updUser)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updDate)(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.memo)(clsSysCommentBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentId) == false && undefined !== pobjSysCommentEN.commentId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.commentId) === false) {
            throw new Error("(errid:Watl000060)字段[评论Id(commentId)]的值:[$(pobjSysCommentEN.commentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.comment) == false && undefined !== pobjSysCommentEN.comment && clsString_js_1.tzDataType.isString(pobjSysCommentEN.comment) === false) {
            throw new Error("(errid:Watl000060)字段[评论(comment)]的值:[$(pobjSysCommentEN.comment)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if (null != pobjSysCommentEN.score && undefined !== pobjSysCommentEN.score && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.score) === false) {
            throw new Error("(errid:Watl000060)字段[评分(score)]的值:[$(pobjSysCommentEN.score)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentTypeId) == false && undefined !== pobjSysCommentEN.commentTypeId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.commentTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[评论类型Id(commentTypeId)]的值:[$(pobjSysCommentEN.commentTypeId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.scoreType) == false && undefined !== pobjSysCommentEN.scoreType && clsString_js_1.tzDataType.isString(pobjSysCommentEN.scoreType) === false) {
            throw new Error("(errid:Watl000060)字段[评分类型(scoreType)]的值:[$(pobjSysCommentEN.scoreType)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.parentId) == false && undefined !== pobjSysCommentEN.parentId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.parentId) === false) {
            throw new Error("(errid:Watl000060)字段[父Id(parentId)]的值:[$(pobjSysCommentEN.parentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.tableKey) == false && undefined !== pobjSysCommentEN.tableKey && clsString_js_1.tzDataType.isString(pobjSysCommentEN.tableKey) === false) {
            throw new Error("(errid:Watl000060)字段[表主键(tableKey)]的值:[$(pobjSysCommentEN.tableKey)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if (null != pobjSysCommentEN.okCount && undefined !== pobjSysCommentEN.okCount && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.okCount) === false) {
            throw new Error("(errid:Watl000060)字段[点赞统计(okCount)]的值:[$(pobjSysCommentEN.okCount)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.pubParentId) == false && undefined !== pobjSysCommentEN.pubParentId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.pubParentId) === false) {
            throw new Error("(errid:Watl000060)字段[公共父Id(pubParentId)]的值:[$(pobjSysCommentEN.pubParentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.id_CurrEduCls) == false && undefined !== pobjSysCommentEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysCommentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysCommentEN.id_CurrEduCls)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.userId) == false && undefined !== pobjSysCommentEN.userId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.userId) === false) {
            throw new Error("(errid:Watl000060)字段[用户ID(userId)]的值:[$(pobjSysCommentEN.userId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if (null != pobjSysCommentEN.month && undefined !== pobjSysCommentEN.month && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.month) === false) {
            throw new Error("(errid:Watl000060)字段[月(month)]的值:[$(pobjSysCommentEN.month)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if (null != pobjSysCommentEN.week && undefined !== pobjSysCommentEN.week && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.week) === false) {
            throw new Error("(errid:Watl000060)字段[周(week)]的值:[$(pobjSysCommentEN.week)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.weekTimeRange) == false && undefined !== pobjSysCommentEN.weekTimeRange && clsString_js_1.tzDataType.isString(pobjSysCommentEN.weekTimeRange) === false) {
            throw new Error("(errid:Watl000060)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjSysCommentEN.weekTimeRange)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updUser) == false && undefined !== pobjSysCommentEN.updUser && clsString_js_1.tzDataType.isString(pobjSysCommentEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjSysCommentEN.updUser)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updDate) == false && undefined !== pobjSysCommentEN.updDate && clsString_js_1.tzDataType.isString(pobjSysCommentEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjSysCommentEN.updDate)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.memo) == false && undefined !== pobjSysCommentEN.memo && clsString_js_1.tzDataType.isString(pobjSysCommentEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjSysCommentEN.memo)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjSysCommentEN.SetIsCheckProperty(true);
    }
    exports.SysComment_CheckPropertyNew = SysComment_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function SysComment_CheckProperty4Update(pobjSysCommentEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.commentId) > 10) {
            throw new Error("(errid:Watl000062)字段[评论Id(commentId)]的长度不能超过10(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentId)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.comment) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.comment) > 2000) {
            throw new Error("(errid:Watl000062)字段[评论(comment)]的长度不能超过2000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.comment)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.commentTypeId) > 2) {
            throw new Error("(errid:Watl000062)字段[评论类型Id(commentTypeId)]的长度不能超过2(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.commentTypeId)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.scoreType) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.scoreType) > 1) {
            throw new Error("(errid:Watl000062)字段[评分类型(scoreType)]的长度不能超过1(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.scoreType)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.parentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.parentId) > 20) {
            throw new Error("(errid:Watl000062)字段[父Id(parentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.parentId)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.tableKey) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.tableKey) > 20) {
            throw new Error("(errid:Watl000062)字段[表主键(tableKey)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.tableKey)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.pubParentId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.pubParentId) > 20) {
            throw new Error("(errid:Watl000062)字段[公共父Id(pubParentId)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.pubParentId)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.id_CurrEduCls)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.userId) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.userId) > 18) {
            throw new Error("(errid:Watl000062)字段[用户ID(userId)]的长度不能超过18(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.userId)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.weekTimeRange) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.weekTimeRange) > 100) {
            throw new Error("(errid:Watl000062)字段[WeekTimeRange(weekTimeRange)]的长度不能超过100(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.weekTimeRange)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updUser)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.updDate)(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjSysCommentEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 系统评论表(SysComment))!值:$(pobjSysCommentEN.memo)(clsSysCommentBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentId) == false && undefined !== pobjSysCommentEN.commentId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.commentId) === false) {
            throw new Error("(errid:Watl000063)字段[评论Id(commentId)]的值:[$(pobjSysCommentEN.commentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.comment) == false && undefined !== pobjSysCommentEN.comment && clsString_js_1.tzDataType.isString(pobjSysCommentEN.comment) === false) {
            throw new Error("(errid:Watl000063)字段[评论(comment)]的值:[$(pobjSysCommentEN.comment)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if (null != pobjSysCommentEN.score && undefined !== pobjSysCommentEN.score && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.score) === false) {
            throw new Error("(errid:Watl000063)字段[评分(score)]的值:[$(pobjSysCommentEN.score)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentTypeId) == false && undefined !== pobjSysCommentEN.commentTypeId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.commentTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[评论类型Id(commentTypeId)]的值:[$(pobjSysCommentEN.commentTypeId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.scoreType) == false && undefined !== pobjSysCommentEN.scoreType && clsString_js_1.tzDataType.isString(pobjSysCommentEN.scoreType) === false) {
            throw new Error("(errid:Watl000063)字段[评分类型(scoreType)]的值:[$(pobjSysCommentEN.scoreType)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.parentId) == false && undefined !== pobjSysCommentEN.parentId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.parentId) === false) {
            throw new Error("(errid:Watl000063)字段[父Id(parentId)]的值:[$(pobjSysCommentEN.parentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.tableKey) == false && undefined !== pobjSysCommentEN.tableKey && clsString_js_1.tzDataType.isString(pobjSysCommentEN.tableKey) === false) {
            throw new Error("(errid:Watl000063)字段[表主键(tableKey)]的值:[$(pobjSysCommentEN.tableKey)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if (null != pobjSysCommentEN.okCount && undefined !== pobjSysCommentEN.okCount && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.okCount) === false) {
            throw new Error("(errid:Watl000063)字段[点赞统计(okCount)]的值:[$(pobjSysCommentEN.okCount)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.pubParentId) == false && undefined !== pobjSysCommentEN.pubParentId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.pubParentId) === false) {
            throw new Error("(errid:Watl000063)字段[公共父Id(pubParentId)]的值:[$(pobjSysCommentEN.pubParentId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.id_CurrEduCls) == false && undefined !== pobjSysCommentEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjSysCommentEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjSysCommentEN.id_CurrEduCls)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.userId) == false && undefined !== pobjSysCommentEN.userId && clsString_js_1.tzDataType.isString(pobjSysCommentEN.userId) === false) {
            throw new Error("(errid:Watl000063)字段[用户ID(userId)]的值:[$(pobjSysCommentEN.userId)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if (null != pobjSysCommentEN.month && undefined !== pobjSysCommentEN.month && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.month) === false) {
            throw new Error("(errid:Watl000063)字段[月(month)]的值:[$(pobjSysCommentEN.month)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if (null != pobjSysCommentEN.week && undefined !== pobjSysCommentEN.week && clsString_js_1.tzDataType.isNumber(pobjSysCommentEN.week) === false) {
            throw new Error("(errid:Watl000063)字段[周(week)]的值:[$(pobjSysCommentEN.week)], 非法，应该为数值型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.weekTimeRange) == false && undefined !== pobjSysCommentEN.weekTimeRange && clsString_js_1.tzDataType.isString(pobjSysCommentEN.weekTimeRange) === false) {
            throw new Error("(errid:Watl000063)字段[WeekTimeRange(weekTimeRange)]的值:[$(pobjSysCommentEN.weekTimeRange)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updUser) == false && undefined !== pobjSysCommentEN.updUser && clsString_js_1.tzDataType.isString(pobjSysCommentEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjSysCommentEN.updUser)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.updDate) == false && undefined !== pobjSysCommentEN.updDate && clsString_js_1.tzDataType.isString(pobjSysCommentEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjSysCommentEN.updDate)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.memo) == false && undefined !== pobjSysCommentEN.memo && clsString_js_1.tzDataType.isString(pobjSysCommentEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjSysCommentEN.memo)], 非法，应该为字符型(In 系统评论表(SysComment))!(clsSysCommentBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjSysCommentEN.commentId) === true) {
            throw new Error("(errid:Watl000064)字段[评论Id]不能为空(In 系统评论表)!(clsSysCommentBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        pobjSysCommentEN.SetIsCheckProperty(true);
    }
    exports.SysComment_CheckProperty4Update = SysComment_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysComment_GetJSONStrByObj(pobjSysCommentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjSysCommentEN.sf_UpdFldSetStr = pobjSysCommentEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjSysCommentEN);
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
    exports.SysComment_GetJSONStrByObj = SysComment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function SysComment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrSysCommentObjLst = new Array();
        if (strJSON === "") {
            return arrSysCommentObjLst;
        }
        try {
            arrSysCommentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrSysCommentObjLst;
        }
        return arrSysCommentObjLst;
    }
    exports.SysComment_GetObjLstByJSONStr = SysComment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrSysCommentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function SysComment_GetObjLstByJSONObjLst(arrSysCommentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrSysCommentObjLst = new Array();
        for (const objInFor of arrSysCommentObjLstS) {
            const obj1 = SysComment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrSysCommentObjLst.push(obj1);
        }
        return arrSysCommentObjLst;
    }
    exports.SysComment_GetObjLstByJSONObjLst = SysComment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function SysComment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjSysCommentEN = new clsSysCommentEN_js_1.clsSysCommentEN();
        if (strJSON === "") {
            return pobjSysCommentEN;
        }
        try {
            pobjSysCommentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjSysCommentEN;
        }
        return pobjSysCommentEN;
    }
    exports.SysComment_GetObjByJSONStr = SysComment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function SysComment_GetCombineCondition(objSysComment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId) == true) {
            const strComparisonOp_CommentId = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_CommentId, objSysComment_Cond.commentId, strComparisonOp_CommentId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_Comment) == true) {
            const strComparisonOp_Comment = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_Comment];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_Comment, objSysComment_Cond.comment, strComparisonOp_Comment);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_Score) == true) {
            const strComparisonOp_Score = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_Score];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCommentEN_js_1.clsSysCommentEN.con_Score, objSysComment_Cond.score, strComparisonOp_Score);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_CommentTypeId) == true) {
            const strComparisonOp_CommentTypeId = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_CommentTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_CommentTypeId, objSysComment_Cond.commentTypeId, strComparisonOp_CommentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_ScoreType];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_ScoreType, objSysComment_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_ParentId, objSysComment_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_TableKey) == true) {
            const strComparisonOp_TableKey = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_TableKey];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_TableKey, objSysComment_Cond.tableKey, strComparisonOp_TableKey);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_OkCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCommentEN_js_1.clsSysCommentEN.con_OkCount, objSysComment_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_PubParentId) == true) {
            const strComparisonOp_PubParentId = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_PubParentId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_PubParentId, objSysComment_Cond.pubParentId, strComparisonOp_PubParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_id_CurrEduCls, objSysComment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_UserId) == true) {
            const strComparisonOp_UserId = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_UserId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_UserId, objSysComment_Cond.userId, strComparisonOp_UserId);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_Month) == true) {
            const strComparisonOp_Month = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_Month];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCommentEN_js_1.clsSysCommentEN.con_Month, objSysComment_Cond.month, strComparisonOp_Month);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_Week) == true) {
            const strComparisonOp_Week = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_Week];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsSysCommentEN_js_1.clsSysCommentEN.con_Week, objSysComment_Cond.week, strComparisonOp_Week);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_WeekTimeRange) == true) {
            const strComparisonOp_WeekTimeRange = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_WeekTimeRange];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_WeekTimeRange, objSysComment_Cond.weekTimeRange, strComparisonOp_WeekTimeRange);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_UpdUser, objSysComment_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_UpdDate, objSysComment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objSysComment_Cond.dicFldComparisonOp, clsSysCommentEN_js_1.clsSysCommentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objSysComment_Cond.dicFldComparisonOp[clsSysCommentEN_js_1.clsSysCommentEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsSysCommentEN_js_1.clsSysCommentEN.con_Memo, objSysComment_Cond.memo, strComparisonOp_Memo);
        }
        return strWhereCond;
    }
    exports.SysComment_GetCombineCondition = SysComment_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--SysComment(系统评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strCommentId: 评论Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysComment_GetUniCondStr_CommentId(objSysCommentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CommentId = '{0}'", objSysCommentEN.commentId);
        return strWhereCond;
    }
    exports.SysComment_GetUniCondStr_CommentId = SysComment_GetUniCondStr_CommentId;
    /**
    *获取唯一性条件串(Uniqueness)--SysComment(系统评论表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strCommentId: 评论Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function SysComment_GetUniCondStr4Update_CommentId(objSysCommentEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and CommentId <> '{0}'", objSysCommentEN.commentId);
        strWhereCond += (0, clsString_js_2.Format)(" and CommentId = '{0}'", objSysCommentEN.commentId);
        return strWhereCond;
    }
    exports.SysComment_GetUniCondStr4Update_CommentId = SysComment_GetUniCondStr4Update_CommentId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objSysCommentENS:源对象
     * @param objSysCommentENT:目标对象
    */
    function SysComment_CopyObjTo(objSysCommentENS, objSysCommentENT) {
        objSysCommentENT.commentId = objSysCommentENS.commentId; //评论Id
        objSysCommentENT.comment = objSysCommentENS.comment; //评论
        objSysCommentENT.score = objSysCommentENS.score; //评分
        objSysCommentENT.commentTypeId = objSysCommentENS.commentTypeId; //评论类型Id
        objSysCommentENT.scoreType = objSysCommentENS.scoreType; //评分类型
        objSysCommentENT.parentId = objSysCommentENS.parentId; //父Id
        objSysCommentENT.tableKey = objSysCommentENS.tableKey; //表主键
        objSysCommentENT.okCount = objSysCommentENS.okCount; //点赞统计
        objSysCommentENT.pubParentId = objSysCommentENS.pubParentId; //公共父Id
        objSysCommentENT.id_CurrEduCls = objSysCommentENS.id_CurrEduCls; //教学班流水号
        objSysCommentENT.userId = objSysCommentENS.userId; //用户ID
        objSysCommentENT.month = objSysCommentENS.month; //月
        objSysCommentENT.week = objSysCommentENS.week; //周
        objSysCommentENT.weekTimeRange = objSysCommentENS.weekTimeRange; //WeekTimeRange
        objSysCommentENT.updUser = objSysCommentENS.updUser; //修改人
        objSysCommentENT.updDate = objSysCommentENS.updDate; //修改日期
        objSysCommentENT.memo = objSysCommentENS.memo; //备注
        objSysCommentENT.sf_UpdFldSetStr = objSysCommentENS.updFldString; //sf_UpdFldSetStr
    }
    exports.SysComment_CopyObjTo = SysComment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objSysCommentENS:源对象
     * @param objSysCommentENT:目标对象
    */
    function SysComment_GetObjFromJsonObj(objSysCommentENS) {
        const objSysCommentENT = new clsSysCommentEN_js_1.clsSysCommentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objSysCommentENT, objSysCommentENS);
        return objSysCommentENT;
    }
    exports.SysComment_GetObjFromJsonObj = SysComment_GetObjFromJsonObj;
});
