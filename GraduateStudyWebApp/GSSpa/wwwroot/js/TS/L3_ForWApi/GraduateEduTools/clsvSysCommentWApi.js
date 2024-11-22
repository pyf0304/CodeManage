/**
* 类名:clsvSysCommentWApi
* 表名:vSysComment(01120624)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:58
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduTools/clsvSysCommentEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vSysComment_GetObjFromJsonObj = exports.vSysComment_CopyObjTo = exports.vSysComment_GetCombineCondition = exports.vSysComment_GetObjByJSONStr = exports.vSysComment_GetObjLstByJSONObjLst = exports.vSysComment_GetObjLstByJSONStr = exports.vSysComment_GetJSONStrByObj = exports.vSysComment_ReFreshThisCache = exports.vSysComment_GetWebApiUrl = exports.vSysComment_GetRecCountByCond_Cache = exports.vSysComment_GetRecCountByCondAsync = exports.vSysComment_IsExistAsync = exports.vSysComment_IsExist_Cache = exports.vSysComment_IsExist = exports.vSysComment_IsExistRecordAsync = exports.vSysComment_IsExistRecord_Cache = exports.vSysComment_GetObjLstByPagerAsync = exports.vSysComment_GetObjLstByPager_Cache = exports.vSysComment_GetObjLstByRange = exports.vSysComment_GetObjLstByRangeAsync = exports.vSysComment_GetTopObjLstAsync = exports.vSysComment_GetObjLstByCommentIdLst_Cache = exports.vSysComment_GetObjLstByCommentIdLstAsync = exports.vSysComment_GetSubObjLst_Cache = exports.vSysComment_GetObjLst_PureCache = exports.vSysComment_GetObjLst_Cache = exports.vSysComment_GetObjLst_sessionStorage_PureCache = exports.vSysComment_GetObjLst_sessionStorage = exports.vSysComment_GetObjLstAsync = exports.vSysComment_GetObjLst_localStorage_PureCache = exports.vSysComment_GetObjLst_localStorage = exports.vSysComment_GetObjLst_ClientCache = exports.vSysComment_GetFirstObjAsync = exports.vSysComment_GetFirstID = exports.vSysComment_GetFirstIDAsync = exports.vSysComment_FilterFunByKey = exports.vSysComment_SortFunByKey = exports.vSysComment_SortFun_Defa_2Fld = exports.vSysComment_SortFun_Defa = exports.vSysComment_func = exports.vSysComment_GetObjByCommentId_localStorage = exports.vSysComment_GetObjByCommentId_Cache = exports.vSysComment_GetObjByCommentIdAsync = exports.vSysComment_ConstructorName = exports.vSysComment_Controller = void 0;
    /**
     * v系统评论表(vSysComment)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvSysCommentEN_js_1 = require("../../L0_Entity/GraduateEduTools/clsvSysCommentEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vSysComment_Controller = "vSysCommentApi";
    exports.vSysComment_ConstructorName = "vSysComment";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strCommentId:关键字
    * @returns 对象
    **/
    async function vSysComment_GetObjByCommentIdAsync(strCommentId) {
        const strThisFuncName = "GetObjByCommentIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCommentId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCommentId]不能为空！(In GetObjByCommentIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCommentId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCommentId]的长度:[{0}]不正确！", strCommentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByCommentId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysComment = vSysComment_GetObjFromJsonObj(returnObj);
                return objvSysComment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetObjByCommentIdAsync = vSysComment_GetObjByCommentIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strCommentId:所给的关键字
     * @returns 对象
    */
    async function vSysComment_GetObjByCommentId_Cache(strCommentId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByCommentId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCommentId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCommentId]不能为空！(In GetObjByCommentId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCommentId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCommentId]的长度:[{0}]不正确！", strCommentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvSysComment_Sel = arrvSysCommentObjLst_Cache.filter(x => x.commentId == strCommentId);
            let objvSysComment;
            if (arrvSysComment_Sel.length > 0) {
                objvSysComment = arrvSysComment_Sel[0];
                return objvSysComment;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvSysComment = await vSysComment_GetObjByCommentIdAsync(strCommentId);
                    if (objvSysComment != null) {
                        vSysComment_ReFreshThisCache(strid_CurrEduCls);
                        return objvSysComment;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vSysComment_GetObjByCommentId_Cache = vSysComment_GetObjByCommentId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strCommentId:所给的关键字
     * @returns 对象
    */
    async function vSysComment_GetObjByCommentId_localStorage(strCommentId) {
        const strThisFuncName = "GetObjByCommentId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strCommentId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strCommentId]不能为空！(In GetObjByCommentId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strCommentId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strCommentId]的长度:[{0}]不正确！", strCommentId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strCommentId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvSysComment_Cache = JSON.parse(strTempObj);
            return objvSysComment_Cache;
        }
        try {
            const objvSysComment = await vSysComment_GetObjByCommentIdAsync(strCommentId);
            if (objvSysComment != null) {
                localStorage.setItem(strKey, JSON.stringify(objvSysComment));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvSysComment;
            }
            return objvSysComment;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strCommentId, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vSysComment_GetObjByCommentId_localStorage = vSysComment_GetObjByCommentId_localStorage;
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
    async function vSysComment_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
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
        if (strInFldName != clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvSysCommentEN_js_1.clsvSysCommentEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvSysCommentEN_js_1.clsvSysCommentEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strCommentId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvSysComment = await vSysComment_GetObjByCommentId_Cache(strCommentId, strid_CurrEduCls_C);
        if (objvSysComment == null)
            return "";
        return objvSysComment.GetFldValue(strOutFldName).toString();
    }
    exports.vSysComment_func = vSysComment_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysComment_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.commentId.localeCompare(b.commentId);
    }
    exports.vSysComment_SortFun_Defa = vSysComment_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysComment_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.comment == b.comment)
            return a.score - b.score;
        else
            return a.comment.localeCompare(b.comment);
    }
    exports.vSysComment_SortFun_Defa_2Fld = vSysComment_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vSysComment_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId:
                    return (a, b) => {
                        return a.commentId.localeCompare(b.commentId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_Comment:
                    return (a, b) => {
                        return a.comment.localeCompare(b.comment);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_score:
                    return (a, b) => {
                        return a.score - b.score;
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId:
                    return (a, b) => {
                        return a.commentTypeId.localeCompare(b.commentTypeId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType:
                    return (a, b) => {
                        return a.scoreType.localeCompare(b.scoreType);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_ParentId:
                    return (a, b) => {
                        return a.parentId.localeCompare(b.parentId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_TableKey:
                    return (a, b) => {
                        return a.tableKey.localeCompare(b.tableKey);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeName:
                    return (a, b) => {
                        return a.commentTypeName.localeCompare(b.commentTypeName);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTable:
                    return (a, b) => {
                        return a.commentTable.localeCompare(b.commentTable);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTableId:
                    return (a, b) => {
                        return a.commentTableId.localeCompare(b.commentTableId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_OkCount:
                    return (a, b) => {
                        return a.okCount - b.okCount;
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_PubParentId:
                    return (a, b) => {
                        return a.pubParentId.localeCompare(b.pubParentId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UserId:
                    return (a, b) => {
                        return a.userId.localeCompare(b.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysComment]中不存在！(in ${exports.vSysComment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId:
                    return (a, b) => {
                        return b.commentId.localeCompare(a.commentId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_Comment:
                    return (a, b) => {
                        return b.comment.localeCompare(a.comment);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_score:
                    return (a, b) => {
                        return b.score - a.score;
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId:
                    return (a, b) => {
                        return b.commentTypeId.localeCompare(a.commentTypeId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType:
                    return (a, b) => {
                        return b.scoreType.localeCompare(a.scoreType);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_ParentId:
                    return (a, b) => {
                        return b.parentId.localeCompare(a.parentId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_TableKey:
                    return (a, b) => {
                        return b.tableKey.localeCompare(a.tableKey);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeName:
                    return (a, b) => {
                        return b.commentTypeName.localeCompare(a.commentTypeName);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTable:
                    return (a, b) => {
                        return b.commentTable.localeCompare(a.commentTable);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTableId:
                    return (a, b) => {
                        return b.commentTableId.localeCompare(a.commentTableId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_OkCount:
                    return (a, b) => {
                        return b.okCount - a.okCount;
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_PubParentId:
                    return (a, b) => {
                        return b.pubParentId.localeCompare(a.pubParentId);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_id_CurrEduCls:
                    return (a, b) => {
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UserId:
                    return (a, b) => {
                        return b.userId.localeCompare(a.userId);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vSysComment]中不存在！(in ${exports.vSysComment_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vSysComment_SortFunByKey = vSysComment_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vSysComment_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId:
                return (obj) => {
                    return obj.commentId === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_Comment:
                return (obj) => {
                    return obj.comment === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_score:
                return (obj) => {
                    return obj.score === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId:
                return (obj) => {
                    return obj.commentTypeId === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType:
                return (obj) => {
                    return obj.scoreType === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_ParentId:
                return (obj) => {
                    return obj.parentId === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_TableKey:
                return (obj) => {
                    return obj.tableKey === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeName:
                return (obj) => {
                    return obj.commentTypeName === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTable:
                return (obj) => {
                    return obj.commentTable === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTableId:
                return (obj) => {
                    return obj.commentTableId === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_OkCount:
                return (obj) => {
                    return obj.okCount === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_PubParentId:
                return (obj) => {
                    return obj.pubParentId === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvSysCommentEN_js_1.clsvSysCommentEN.con_UserId:
                return (obj) => {
                    return obj.userId === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vSysComment]中不存在！(in ${exports.vSysComment_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vSysComment_FilterFunByKey = vSysComment_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vSysComment_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetFirstIDAsync = vSysComment_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vSysComment_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetFirstID = vSysComment_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vSysComment_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvSysComment = vSysComment_GetObjFromJsonObj(returnObj);
                return objvSysComment;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetFirstObjAsync = vSysComment_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
        clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvSysCommentExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvSysCommentObjLst_T = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentExObjLst_Cache);
            return arrvSysCommentObjLst_T;
        }
        try {
            const arrvSysCommentExObjLst = await vSysComment_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvSysCommentExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysCommentExObjLst.length);
            console.log(strInfo);
            return arrvSysCommentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysComment_GetObjLst_ClientCache = vSysComment_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
        clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysCommentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysCommentObjLst_T = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentExObjLst_Cache);
            return arrvSysCommentObjLst_T;
        }
        try {
            const arrvSysCommentExObjLst = await vSysComment_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvSysCommentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysCommentExObjLst.length);
            console.log(strInfo);
            return arrvSysCommentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysComment_GetObjLst_localStorage = vSysComment_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvSysCommentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysCommentObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysComment_GetObjLst_localStorage_PureCache = vSysComment_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vSysComment_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetObjLstAsync = vSysComment_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
        clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvSysCommentEN_js_1.clsvSysCommentEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysCommentExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvSysCommentObjLst_T = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentExObjLst_Cache);
            return arrvSysCommentObjLst_T;
        }
        try {
            const arrvSysCommentExObjLst = await vSysComment_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvSysCommentExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvSysCommentExObjLst.length);
            console.log(strInfo);
            return arrvSysCommentExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vSysComment_GetObjLst_sessionStorage = vSysComment_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvSysCommentObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvSysCommentObjLst_Cache;
        }
        else
            return null;
    }
    exports.vSysComment_GetObjLst_sessionStorage_PureCache = vSysComment_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_Cache(strid_CurrEduCls) {
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
        let arrvSysCommentObjLst_Cache;
        switch (clsvSysCommentEN_js_1.clsvSysCommentEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvSysCommentObjLst = vSysComment_GetObjLstByJSONObjLst(arrvSysCommentObjLst_Cache);
        return arrvSysCommentObjLst_Cache;
    }
    exports.vSysComment_GetObjLst_Cache = vSysComment_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vSysComment_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvSysCommentObjLst_Cache;
        switch (clsvSysCommentEN_js_1.clsvSysCommentEN.CacheModeId) {
            case "04": //sessionStorage
                arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvSysCommentObjLst_Cache = null;
                break;
            default:
                arrvSysCommentObjLst_Cache = null;
                break;
        }
        return arrvSysCommentObjLst_Cache;
    }
    exports.vSysComment_GetObjLst_PureCache = vSysComment_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrCommentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysComment_GetSubObjLst_Cache(objvSysComment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
        let arrvSysComment_Sel = arrvSysCommentObjLst_Cache;
        if (objvSysComment_Cond.sf_FldComparisonOp == null || objvSysComment_Cond.sf_FldComparisonOp == "")
            return arrvSysComment_Sel;
        const dicFldComparisonOp = JSON.parse(objvSysComment_Cond.sf_FldComparisonOp);
        //console.log("clsvSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysComment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvSysComment_Cond), exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysComment_GetSubObjLst_Cache = vSysComment_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrCommentId:关键字列表
    * @returns 对象列表
    **/
    async function vSysComment_GetObjLstByCommentIdLstAsync(arrCommentId) {
        const strThisFuncName = "GetObjLstByCommentIdLstAsync";
        const strAction = "GetObjLstByCommentIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrCommentId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetObjLstByCommentIdLstAsync = vSysComment_GetObjLstByCommentIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrCommentIdLst:关键字列表
     * @returns 对象列表
    */
    async function vSysComment_GetObjLstByCommentIdLst_Cache(arrCommentIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByCommentIdLst_Cache";
        try {
            const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
            const arrvSysComment_Sel = arrvSysCommentObjLst_Cache.filter(x => arrCommentIdLst.indexOf(x.commentId) > -1);
            return arrvSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrCommentIdLst.join(","), exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysComment_GetObjLstByCommentIdLst_Cache = vSysComment_GetObjLstByCommentIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vSysComment_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetTopObjLstAsync = vSysComment_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysComment_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetObjLstByRangeAsync = vSysComment_GetObjLstByRangeAsync;
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
    async function vSysComment_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetObjLstByRange = vSysComment_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vSysComment_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysCommentObjLst_Cache.length == 0)
            return arrvSysCommentObjLst_Cache;
        let arrvSysComment_Sel = arrvSysCommentObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvSysComment_Cond = new clsvSysCommentEN_js_1.clsvSysCommentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysComment_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvSysCommentWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysComment_Sel.length == 0)
                return arrvSysComment_Sel;
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
                arrvSysComment_Sel = arrvSysComment_Sel.sort(vSysComment_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvSysComment_Sel = arrvSysComment_Sel.sort(objPagerPara.sortFun);
            }
            arrvSysComment_Sel = arrvSysComment_Sel.slice(intStart, intEnd);
            return arrvSysComment_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vSysComment_GetObjLstByPager_Cache = vSysComment_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vSysComment_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vSysComment_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vSysComment_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetObjLstByPagerAsync = vSysComment_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrCommentId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vSysComment_IsExistRecord_Cache(objvSysComment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysCommentObjLst_Cache == null)
            return false;
        let arrvSysComment_Sel = arrvSysCommentObjLst_Cache;
        if (objvSysComment_Cond.sf_FldComparisonOp == null || objvSysComment_Cond.sf_FldComparisonOp == "")
            return arrvSysComment_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvSysComment_Cond.sf_FldComparisonOp);
        //console.log("clsvSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysComment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvSysComment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvSysComment_Cond), exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vSysComment_IsExistRecord_Cache = vSysComment_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vSysComment_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_IsExistRecordAsync = vSysComment_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strCommentId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vSysComment_IsExist(strCommentId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_IsExist = vSysComment_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strCommentId:所给的关键字
     * @returns 对象
    */
    async function vSysComment_IsExist_Cache(strCommentId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysCommentObjLst_Cache == null)
            return false;
        try {
            const arrvSysComment_Sel = arrvSysCommentObjLst_Cache.filter(x => x.commentId == strCommentId);
            if (arrvSysComment_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strCommentId, exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vSysComment_IsExist_Cache = vSysComment_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strCommentId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vSysComment_IsExistAsync(strCommentId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_IsExistAsync = vSysComment_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vSysComment_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vSysComment_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vSysComment_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vSysComment_GetRecCountByCondAsync = vSysComment_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvSysComment_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vSysComment_GetRecCountByCond_Cache(objvSysComment_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvSysCommentObjLst_Cache = await vSysComment_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvSysCommentObjLst_Cache == null)
            return 0;
        let arrvSysComment_Sel = arrvSysCommentObjLst_Cache;
        if (objvSysComment_Cond.sf_FldComparisonOp == null || objvSysComment_Cond.sf_FldComparisonOp == "")
            return arrvSysComment_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvSysComment_Cond.sf_FldComparisonOp);
        //console.log("clsvSysCommentWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvSysComment_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvSysComment_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvSysComment_Sel = arrvSysComment_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvSysComment_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvSysComment_Cond), exports.vSysComment_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vSysComment_GetRecCountByCond_Cache = vSysComment_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vSysComment_GetWebApiUrl(strController, strAction) {
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
    exports.vSysComment_GetWebApiUrl = vSysComment_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vSysComment_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvSysCommentEN_js_1.clsvSysCommentEN._CurrTabName, strid_CurrEduCls);
            switch (clsvSysCommentEN_js_1.clsvSysCommentEN.CacheModeId) {
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
    exports.vSysComment_ReFreshThisCache = vSysComment_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysComment_GetJSONStrByObj(pobjvSysCommentEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvSysCommentEN);
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
    exports.vSysComment_GetJSONStrByObj = vSysComment_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vSysComment_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvSysCommentObjLst = new Array();
        if (strJSON === "") {
            return arrvSysCommentObjLst;
        }
        try {
            arrvSysCommentObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvSysCommentObjLst;
        }
        return arrvSysCommentObjLst;
    }
    exports.vSysComment_GetObjLstByJSONStr = vSysComment_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvSysCommentObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vSysComment_GetObjLstByJSONObjLst(arrvSysCommentObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvSysCommentObjLst = new Array();
        for (const objInFor of arrvSysCommentObjLstS) {
            const obj1 = vSysComment_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvSysCommentObjLst.push(obj1);
        }
        return arrvSysCommentObjLst;
    }
    exports.vSysComment_GetObjLstByJSONObjLst = vSysComment_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vSysComment_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvSysCommentEN = new clsvSysCommentEN_js_1.clsvSysCommentEN();
        if (strJSON === "") {
            return pobjvSysCommentEN;
        }
        try {
            pobjvSysCommentEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvSysCommentEN;
        }
        return pobjvSysCommentEN;
    }
    exports.vSysComment_GetObjByJSONStr = vSysComment_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vSysComment_GetCombineCondition(objvSysComment_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId) == true) {
            const strComparisonOp_CommentId = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentId, objvSysComment_Cond.commentId, strComparisonOp_CommentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_Comment) == true) {
            const strComparisonOp_Comment = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_Comment];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_Comment, objvSysComment_Cond.comment, strComparisonOp_Comment);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_score) == true) {
            const strComparisonOp_score = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_score];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCommentEN_js_1.clsvSysCommentEN.con_score, objvSysComment_Cond.score, strComparisonOp_score);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId) == true) {
            const strComparisonOp_CommentTypeId = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeId, objvSysComment_Cond.commentTypeId, strComparisonOp_CommentTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType) == true) {
            const strComparisonOp_ScoreType = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_ScoreType, objvSysComment_Cond.scoreType, strComparisonOp_ScoreType);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_ParentId) == true) {
            const strComparisonOp_ParentId = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_ParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_ParentId, objvSysComment_Cond.parentId, strComparisonOp_ParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_TableKey) == true) {
            const strComparisonOp_TableKey = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_TableKey];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_TableKey, objvSysComment_Cond.tableKey, strComparisonOp_TableKey);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdUser, objvSysComment_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_UpdDate, objvSysComment_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_Memo, objvSysComment_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeName) == true) {
            const strComparisonOp_CommentTypeName = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTypeName, objvSysComment_Cond.commentTypeName, strComparisonOp_CommentTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTable) == true) {
            const strComparisonOp_CommentTable = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTable];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTable, objvSysComment_Cond.commentTable, strComparisonOp_CommentTable);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTableId) == true) {
            const strComparisonOp_CommentTableId = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTableId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_CommentTableId, objvSysComment_Cond.commentTableId, strComparisonOp_CommentTableId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_OkCount) == true) {
            const strComparisonOp_OkCount = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_OkCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvSysCommentEN_js_1.clsvSysCommentEN.con_OkCount, objvSysComment_Cond.okCount, strComparisonOp_OkCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_PubParentId) == true) {
            const strComparisonOp_PubParentId = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_PubParentId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_PubParentId, objvSysComment_Cond.pubParentId, strComparisonOp_PubParentId);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_id_CurrEduCls, objvSysComment_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvSysComment_Cond.dicFldComparisonOp, clsvSysCommentEN_js_1.clsvSysCommentEN.con_UserId) == true) {
            const strComparisonOp_UserId = objvSysComment_Cond.dicFldComparisonOp[clsvSysCommentEN_js_1.clsvSysCommentEN.con_UserId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvSysCommentEN_js_1.clsvSysCommentEN.con_UserId, objvSysComment_Cond.userId, strComparisonOp_UserId);
        }
        return strWhereCond;
    }
    exports.vSysComment_GetCombineCondition = vSysComment_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvSysCommentENS:源对象
     * @param objvSysCommentENT:目标对象
    */
    function vSysComment_CopyObjTo(objvSysCommentENS, objvSysCommentENT) {
        objvSysCommentENT.commentId = objvSysCommentENS.commentId; //评论Id
        objvSysCommentENT.comment = objvSysCommentENS.comment; //评论
        objvSysCommentENT.score = objvSysCommentENS.score; //评分
        objvSysCommentENT.commentTypeId = objvSysCommentENS.commentTypeId; //评论类型Id
        objvSysCommentENT.scoreType = objvSysCommentENS.scoreType; //评分类型
        objvSysCommentENT.parentId = objvSysCommentENS.parentId; //父Id
        objvSysCommentENT.tableKey = objvSysCommentENS.tableKey; //表主键
        objvSysCommentENT.updUser = objvSysCommentENS.updUser; //修改人
        objvSysCommentENT.updDate = objvSysCommentENS.updDate; //修改日期
        objvSysCommentENT.memo = objvSysCommentENS.memo; //备注
        objvSysCommentENT.commentTypeName = objvSysCommentENS.commentTypeName; //评论类型名
        objvSysCommentENT.commentTable = objvSysCommentENS.commentTable; //评论表
        objvSysCommentENT.commentTableId = objvSysCommentENS.commentTableId; //评论表Id
        objvSysCommentENT.okCount = objvSysCommentENS.okCount; //点赞统计
        objvSysCommentENT.pubParentId = objvSysCommentENS.pubParentId; //公共父Id
        objvSysCommentENT.id_CurrEduCls = objvSysCommentENS.id_CurrEduCls; //教学班流水号
        objvSysCommentENT.userId = objvSysCommentENS.userId; //用户ID
    }
    exports.vSysComment_CopyObjTo = vSysComment_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvSysCommentENS:源对象
     * @param objvSysCommentENT:目标对象
    */
    function vSysComment_GetObjFromJsonObj(objvSysCommentENS) {
        const objvSysCommentENT = new clsvSysCommentEN_js_1.clsvSysCommentEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvSysCommentENT, objvSysCommentENS);
        return objvSysCommentENT;
    }
    exports.vSysComment_GetObjFromJsonObj = vSysComment_GetObjFromJsonObj;
});
