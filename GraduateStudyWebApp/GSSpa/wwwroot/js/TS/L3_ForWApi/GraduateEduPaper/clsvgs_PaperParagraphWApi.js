/**
* 类名:clsvgs_PaperParagraphWApi
* 表名:vgs_PaperParagraph(01120747)
* 生成代码版本:2022.11.02.1
* 生成日期:2022/11/02 12:02:43
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
        define(["require", "exports", "axios", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubFun/clsSysPara4WebApi.js", "../../PubFun/CacheHelper.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vgs_PaperParagraph_GetObjFromJsonObj = exports.vgs_PaperParagraph_CopyObjTo = exports.vgs_PaperParagraph_GetUniCondStr4Update_ParagraphId = exports.vgs_PaperParagraph_GetUniCondStr_ParagraphId = exports.vgs_PaperParagraph_GetCombineCondition = exports.vgs_PaperParagraph_GetObjByJSONStr = exports.vgs_PaperParagraph_GetObjLstByJSONObjLst = exports.vgs_PaperParagraph_GetObjLstByJSONStr = exports.vgs_PaperParagraph_GetJSONStrByObj = exports.vgs_PaperParagraph__Cache = exports.vgs_PaperParagraph_ReFreshThisCache = exports.vgs_PaperParagraph_GetWebApiUrl = exports.vgs_PaperParagraph_GetRecCountByCond_Cache = exports.vgs_PaperParagraph_GetRecCountByCondAsync = exports.vgs_PaperParagraph_IsExistAsync = exports.vgs_PaperParagraph_IsExist_Cache = exports.vgs_PaperParagraph_IsExist = exports.vgs_PaperParagraph_IsExistRecordAsync = exports.vgs_PaperParagraph_IsExistRecord_Cache = exports.vgs_PaperParagraph_GetObjLstByPagerAsync = exports.vgs_PaperParagraph_GetObjLstByPager_Cache = exports.vgs_PaperParagraph_GetObjLstByRange = exports.vgs_PaperParagraph_GetObjLstByRangeAsync = exports.vgs_PaperParagraph_GetTopObjLstAsync = exports.vgs_PaperParagraph_GetObjLstByParagraphIdLst_Cache = exports.vgs_PaperParagraph_GetObjLstByParagraphIdLstAsync = exports.vgs_PaperParagraph_GetSubObjLst_Cache = exports.vgs_PaperParagraph_GetObjLst_PureCache = exports.vgs_PaperParagraph_GetObjLst_Cache = exports.vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache = exports.vgs_PaperParagraph_GetObjLst_sessionStorage = exports.vgs_PaperParagraph_GetObjLstAsync = exports.vgs_PaperParagraph_GetObjLst_localStorage_PureCache = exports.vgs_PaperParagraph_GetObjLst_localStorage = exports.vgs_PaperParagraph_GetObjLst_ClientCache = exports.vgs_PaperParagraph_GetFirstObjAsync = exports.vgs_PaperParagraph_GetFirstID = exports.vgs_PaperParagraph_GetFirstIDAsync = exports.vgs_PaperParagraph_FilterFunByKey = exports.vgs_PaperParagraph_SortFunByKey = exports.vgs_PaperParagraph_SortFun_Defa_2Fld = exports.vgs_PaperParagraph_SortFun_Defa = exports.vgs_PaperParagraph_func = exports.vgs_PaperParagraph_GetNameByParagraphId_Cache = exports.vgs_PaperParagraph_GetObjByParagraphId_localStorage = exports.vgs_PaperParagraph_GetObjByParagraphId_Cache = exports.vgs_PaperParagraph_GetObjByParagraphIdAsync = exports.vgs_PaperParagraph_ConstructorName = exports.vgs_PaperParagraph_Controller = void 0;
    /**
     * 论文段落视图(vgs_PaperParagraph)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2022年11月02日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvgs_PaperParagraphEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvgs_PaperParagraphEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubFun/clsSysPara4WebApi.js");
    const CacheHelper_js_2 = require("../../PubFun/CacheHelper.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vgs_PaperParagraph_Controller = "vgs_PaperParagraphApi";
    exports.vgs_PaperParagraph_ConstructorName = "vgs_PaperParagraph";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strParagraphId:关键字
    * @returns 对象
    **/
    async function vgs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId) {
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
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_PaperParagraph = vgs_PaperParagraph_GetObjFromJsonObj(returnObj);
                return objvgs_PaperParagraph;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetObjByParagraphIdAsync = vgs_PaperParagraph_GetObjByParagraphIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId, bolTryAsyncOnce = true) {
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
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        try {
            const arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
            let objvgs_PaperParagraph;
            if (arrvgs_PaperParagraph_Sel.length > 0) {
                objvgs_PaperParagraph = arrvgs_PaperParagraph_Sel[0];
                return objvgs_PaperParagraph;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    objvgs_PaperParagraph = await vgs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
                    if (objvgs_PaperParagraph != null) {
                        vgs_PaperParagraph_ReFreshThisCache();
                        return objvgs_PaperParagraph;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vgs_PaperParagraph_GetObjByParagraphId_Cache = vgs_PaperParagraph_GetObjByParagraphId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperParagraph_GetObjByParagraphId_localStorage(strParagraphId) {
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
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName, strParagraphId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvgs_PaperParagraph_Cache = JSON.parse(strTempObj);
            return objvgs_PaperParagraph_Cache;
        }
        try {
            const objvgs_PaperParagraph = await vgs_PaperParagraph_GetObjByParagraphIdAsync(strParagraphId);
            if (objvgs_PaperParagraph != null) {
                localStorage.setItem(strKey, JSON.stringify(objvgs_PaperParagraph));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvgs_PaperParagraph;
            }
            return objvgs_PaperParagraph;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strParagraphId, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vgs_PaperParagraph_GetObjByParagraphId_localStorage = vgs_PaperParagraph_GetObjByParagraphId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperParagraph_GetNameByParagraphId_Cache(strParagraphId) {
        const strThisFuncName = "GetNameByParagraphId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strParagraphId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strParagraphId]不能为空！(In GetNameByParagraphId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strParagraphId.length != 10) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strParagraphId]的长度:[{0}]不正确！", strParagraphId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        if (arrvgs_PaperParagraphObjLst_Cache == null)
            return "";
        try {
            const arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
            let objvgs_PaperParagraph;
            if (arrvgs_PaperParagraph_Sel.length > 0) {
                objvgs_PaperParagraph = arrvgs_PaperParagraph_Sel[0];
                return objvgs_PaperParagraph.paragraphStateName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strParagraphId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vgs_PaperParagraph_GetNameByParagraphId_Cache = vgs_PaperParagraph_GetNameByParagraphId_Cache;
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
    async function vgs_PaperParagraph_func(strInFldName, strOutFldName, strInValue) {
        //const strThisFuncName = "func";
        if (strInFldName != clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strInFldName, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strParagraphId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvgs_PaperParagraph = await vgs_PaperParagraph_GetObjByParagraphId_Cache(strParagraphId);
        if (objvgs_PaperParagraph == null)
            return "";
        return objvgs_PaperParagraph.GetFldValue(strOutFldName).toString();
    }
    exports.vgs_PaperParagraph_func = vgs_PaperParagraph_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperParagraph_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paragraphId.localeCompare(b.paragraphId);
    }
    exports.vgs_PaperParagraph_SortFun_Defa = vgs_PaperParagraph_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperParagraph_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.paragraphStateName == b.paragraphStateName)
            return a.paragraphTypeName.localeCompare(b.paragraphTypeName);
        else
            return a.paragraphStateName.localeCompare(b.paragraphStateName);
    }
    exports.vgs_PaperParagraph_SortFun_Defa_2Fld = vgs_PaperParagraph_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vgs_PaperParagraph_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId:
                    return (a, b) => {
                        return a.paragraphId.localeCompare(b.paragraphId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName:
                    return (a, b) => {
                        return a.paragraphStateName.localeCompare(b.paragraphStateName);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeName:
                    return (a, b) => {
                        return a.paragraphTypeName.localeCompare(b.paragraphTypeName);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId:
                    return (a, b) => {
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_SectionId:
                    return (a, b) => {
                        return a.sectionId.localeCompare(b.sectionId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateId:
                    return (a, b) => {
                        return a.paragraphStateId.localeCompare(b.paragraphStateId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return a.paragraphTypeId.localeCompare(b.paragraphTypeId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphContent:
                    return (a, b) => {
                        return a.paragraphContent.localeCompare(b.paragraphContent);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VoteCount:
                    return (a, b) => {
                        return a.voteCount - b.voteCount;
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CommentCount:
                    return (a, b) => {
                        return a.commentCount - b.commentCount;
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VersionCount:
                    return (a, b) => {
                        return a.versionCount - b.versionCount;
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateDate:
                    return (a, b) => {
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateUser:
                    return (a, b) => {
                        return a.createUser.localeCompare(b.createUser);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdUser:
                    return (a, b) => {
                        return a.updUser.localeCompare(b.updUser);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_Memo:
                    return (a, b) => {
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_OrderNum:
                    return (a, b) => {
                        return a.orderNum - b.orderNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperParagraph]中不存在！(in ${exports.vgs_PaperParagraph_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId:
                    return (a, b) => {
                        return b.paragraphId.localeCompare(a.paragraphId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName:
                    return (a, b) => {
                        return b.paragraphStateName.localeCompare(a.paragraphStateName);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeName:
                    return (a, b) => {
                        return b.paragraphTypeName.localeCompare(a.paragraphTypeName);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId:
                    return (a, b) => {
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_SectionId:
                    return (a, b) => {
                        return b.sectionId.localeCompare(a.sectionId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateId:
                    return (a, b) => {
                        return b.paragraphStateId.localeCompare(a.paragraphStateId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeId:
                    return (a, b) => {
                        return b.paragraphTypeId.localeCompare(a.paragraphTypeId);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphContent:
                    return (a, b) => {
                        return b.paragraphContent.localeCompare(a.paragraphContent);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VoteCount:
                    return (a, b) => {
                        return b.voteCount - a.voteCount;
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CommentCount:
                    return (a, b) => {
                        return b.commentCount - a.commentCount;
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VersionCount:
                    return (a, b) => {
                        return b.versionCount - a.versionCount;
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateDate:
                    return (a, b) => {
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateUser:
                    return (a, b) => {
                        return b.createUser.localeCompare(a.createUser);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdUser:
                    return (a, b) => {
                        return b.updUser.localeCompare(a.updUser);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_Memo:
                    return (a, b) => {
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_OrderNum:
                    return (a, b) => {
                        return b.orderNum - a.orderNum;
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperParagraph]中不存在！(in ${exports.vgs_PaperParagraph_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vgs_PaperParagraph_SortFunByKey = vgs_PaperParagraph_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vgs_PaperParagraph_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId:
                return (obj) => {
                    return obj.paragraphId === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName:
                return (obj) => {
                    return obj.paragraphStateName === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeName:
                return (obj) => {
                    return obj.paragraphTypeName === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_SectionId:
                return (obj) => {
                    return obj.sectionId === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateId:
                return (obj) => {
                    return obj.paragraphStateId === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeId:
                return (obj) => {
                    return obj.paragraphTypeId === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphContent:
                return (obj) => {
                    return obj.paragraphContent === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VoteCount:
                return (obj) => {
                    return obj.voteCount === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CommentCount:
                return (obj) => {
                    return obj.commentCount === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VersionCount:
                return (obj) => {
                    return obj.versionCount === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateUser:
                return (obj) => {
                    return obj.createUser === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_OrderNum:
                return (obj) => {
                    return obj.orderNum === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vgs_PaperParagraph]中不存在！(in ${exports.vgs_PaperParagraph_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vgs_PaperParagraph_FilterFunByKey = vgs_PaperParagraph_FilterFunByKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vgs_PaperParagraph_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetFirstIDAsync = vgs_PaperParagraph_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vgs_PaperParagraph_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetFirstID = vgs_PaperParagraph_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vgs_PaperParagraph_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObj);
                const objvgs_PaperParagraph = vgs_PaperParagraph_GetObjFromJsonObj(returnObj);
                return objvgs_PaperParagraph;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetFirstObjAsync = vgs_PaperParagraph_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_ClientCache() {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName;
        clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_2.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvgs_PaperParagraphExObjLst_Cache = CacheHelper_js_2.CacheHelper.Get(strKey);
            const arrvgs_PaperParagraphObjLst_T = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphExObjLst_Cache);
            return arrvgs_PaperParagraphObjLst_T;
        }
        try {
            const arrvgs_PaperParagraphExObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond);
            CacheHelper_js_2.CacheHelper.Add(strKey, arrvgs_PaperParagraphExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperParagraphExObjLst.length);
            console.log(strInfo);
            return arrvgs_PaperParagraphExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_PaperParagraph_GetObjLst_ClientCache = vgs_PaperParagraph_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_localStorage() {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName;
        clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_PaperParagraphExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_PaperParagraphObjLst_T = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphExObjLst_Cache);
            return arrvgs_PaperParagraphObjLst_T;
        }
        try {
            const arrvgs_PaperParagraphExObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvgs_PaperParagraphExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperParagraphExObjLst.length);
            console.log(strInfo);
            return arrvgs_PaperParagraphExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_PaperParagraph_GetObjLst_localStorage = vgs_PaperParagraph_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_localStorage_PureCache() {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvgs_PaperParagraphObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_PaperParagraphObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_PaperParagraph_GetObjLst_localStorage_PureCache = vgs_PaperParagraph_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperParagraph_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetObjLstAsync = vgs_PaperParagraph_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_sessionStorage() {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        const strKey = clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName;
        clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition = (0, CacheHelper_js_1.GetSession_CacheAdditionCondition)(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_PaperParagraphExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvgs_PaperParagraphObjLst_T = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphExObjLst_Cache);
            return arrvgs_PaperParagraphObjLst_T;
        }
        try {
            const arrvgs_PaperParagraphExObjLst = await vgs_PaperParagraph_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvgs_PaperParagraphExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvgs_PaperParagraphExObjLst.length);
            console.log(strInfo);
            return arrvgs_PaperParagraphExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vgs_PaperParagraph_GetObjLst_sessionStorage = vgs_PaperParagraph_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache() {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        const strWhereCond = "1=1";
        const strKey = clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName;
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvgs_PaperParagraphObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvgs_PaperParagraphObjLst_Cache;
        }
        else
            return null;
    }
    exports.vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache = vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_Cache() {
        //const strThisFuncName = "GetObjLst_Cache";
        let arrvgs_PaperParagraphObjLst_Cache;
        switch (clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_sessionStorage();
                break;
            case "03": //localStorage
                arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_localStorage();
                break;
            case "02": //ClientCache
                arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_ClientCache();
                break;
            default:
                arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_ClientCache();
                break;
        }
        const arrvgs_PaperParagraphObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphObjLst_Cache);
        return arrvgs_PaperParagraphObjLst_Cache;
    }
    exports.vgs_PaperParagraph_GetObjLst_Cache = vgs_PaperParagraph_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vgs_PaperParagraph_GetObjLst_PureCache() {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvgs_PaperParagraphObjLst_Cache;
        switch (clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheModeId) {
            case "04": //sessionStorage
                arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_sessionStorage_PureCache();
                break;
            case "03": //localStorage
                arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_localStorage_PureCache();
                break;
            case "02": //ClientCache
                arrvgs_PaperParagraphObjLst_Cache = null;
                break;
            default:
                arrvgs_PaperParagraphObjLst_Cache = null;
                break;
        }
        return arrvgs_PaperParagraphObjLst_Cache;
    }
    exports.vgs_PaperParagraph_GetObjLst_PureCache = vgs_PaperParagraph_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrParagraphId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_PaperParagraph_GetSubObjLst_Cache(objvgs_PaperParagraph_Cond) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        let arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache;
        if (objvgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objvgs_PaperParagraph_Cond.sf_FldComparisonOp == "")
            return arrvgs_PaperParagraph_Sel;
        const dicFldComparisonOp = JSON.parse(objvgs_PaperParagraph_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_PaperParagraph_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvgs_PaperParagraph_Cond), exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperParagraph_GetSubObjLst_Cache = vgs_PaperParagraph_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrParagraphId:关键字列表
    * @returns 对象列表
    **/
    async function vgs_PaperParagraph_GetObjLstByParagraphIdLstAsync(arrParagraphId) {
        const strThisFuncName = "GetObjLstByParagraphIdLstAsync";
        const strAction = "GetObjLstByParagraphIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrParagraphId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetObjLstByParagraphIdLstAsync = vgs_PaperParagraph_GetObjLstByParagraphIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrParagraphIdLst:关键字列表
     * @returns 对象列表
    */
    async function vgs_PaperParagraph_GetObjLstByParagraphIdLst_Cache(arrParagraphIdLst) {
        const strThisFuncName = "GetObjLstByParagraphIdLst_Cache";
        try {
            const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
            const arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache.filter(x => arrParagraphIdLst.indexOf(x.paragraphId) > -1);
            return arrvgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrParagraphIdLst.join(","), exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperParagraph_GetObjLstByParagraphIdLst_Cache = vgs_PaperParagraph_GetObjLstByParagraphIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vgs_PaperParagraph_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetTopObjLstAsync = vgs_PaperParagraph_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperParagraph_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetObjLstByRangeAsync = vgs_PaperParagraph_GetObjLstByRangeAsync;
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
    async function vgs_PaperParagraph_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetObjLstByRange = vgs_PaperParagraph_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vgs_PaperParagraph_GetObjLstByPager_Cache(objPagerPara) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        if (arrvgs_PaperParagraphObjLst_Cache.length == 0)
            return arrvgs_PaperParagraphObjLst_Cache;
        let arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvgs_PaperParagraph_Cond = new clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperParagraph_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvgs_PaperParagraphWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_PaperParagraph_Sel.length == 0)
                return arrvgs_PaperParagraph_Sel;
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
                arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.sort(vgs_PaperParagraph_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.sort(objPagerPara.sortFun);
            }
            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.slice(intStart, intEnd);
            return arrvgs_PaperParagraph_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vgs_PaperParagraph_GetObjLstByPager_Cache = vgs_PaperParagraph_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vgs_PaperParagraph_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetObjLstByPagerAsync = vgs_PaperParagraph_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrParagraphId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vgs_PaperParagraph_IsExistRecord_Cache(objvgs_PaperParagraph_Cond) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        if (arrvgs_PaperParagraphObjLst_Cache == null)
            return false;
        let arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache;
        if (objvgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objvgs_PaperParagraph_Cond.sf_FldComparisonOp == "")
            return arrvgs_PaperParagraph_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvgs_PaperParagraph_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_PaperParagraph_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvgs_PaperParagraph_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvgs_PaperParagraph_Cond), exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vgs_PaperParagraph_IsExistRecord_Cache = vgs_PaperParagraph_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vgs_PaperParagraph_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_IsExistRecordAsync = vgs_PaperParagraph_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strParagraphId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vgs_PaperParagraph_IsExist(strParagraphId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_IsExist = vgs_PaperParagraph_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strParagraphId:所给的关键字
     * @returns 对象
    */
    async function vgs_PaperParagraph_IsExist_Cache(strParagraphId) {
        const strThisFuncName = "IsExist_Cache";
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        if (arrvgs_PaperParagraphObjLst_Cache == null)
            return false;
        try {
            const arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache.filter(x => x.paragraphId == strParagraphId);
            if (arrvgs_PaperParagraph_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strParagraphId, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vgs_PaperParagraph_IsExist_Cache = vgs_PaperParagraph_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strParagraphId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vgs_PaperParagraph_IsExistAsync(strParagraphId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_IsExistAsync = vgs_PaperParagraph_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vgs_PaperParagraph_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vgs_PaperParagraph_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vgs_PaperParagraph_GetRecCountByCondAsync = vgs_PaperParagraph_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvgs_PaperParagraph_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vgs_PaperParagraph_GetRecCountByCond_Cache(objvgs_PaperParagraph_Cond) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvgs_PaperParagraphObjLst_Cache = await vgs_PaperParagraph_GetObjLst_Cache();
        if (arrvgs_PaperParagraphObjLst_Cache == null)
            return 0;
        let arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraphObjLst_Cache;
        if (objvgs_PaperParagraph_Cond.sf_FldComparisonOp == null || objvgs_PaperParagraph_Cond.sf_FldComparisonOp == "")
            return arrvgs_PaperParagraph_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvgs_PaperParagraph_Cond.sf_FldComparisonOp);
        //console.log("clsvgs_PaperParagraphWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvgs_PaperParagraph_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvgs_PaperParagraph_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvgs_PaperParagraph_Sel = arrvgs_PaperParagraph_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvgs_PaperParagraph_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvgs_PaperParagraph_Cond), exports.vgs_PaperParagraph_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vgs_PaperParagraph_GetRecCountByCond_Cache = vgs_PaperParagraph_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vgs_PaperParagraph_GetWebApiUrl(strController, strAction) {
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
    exports.vgs_PaperParagraph_GetWebApiUrl = vgs_PaperParagraph_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vgs_PaperParagraph_ReFreshThisCache() {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN._CurrTabName;
            switch (clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.CacheModeId) {
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
    exports.vgs_PaperParagraph_ReFreshThisCache = vgs_PaperParagraph_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vgs_PaperParagraph__Cache(strDivName, strDdlName) {
        const strThisFuncName = "_Cache";
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vgs_PaperParagraph_GetObjLst_Cache();
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName, "论文段落视图");
    }
    exports.vgs_PaperParagraph__Cache = vgs_PaperParagraph__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperParagraph_GetJSONStrByObj(pobjvgs_PaperParagraphEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvgs_PaperParagraphEN);
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
    exports.vgs_PaperParagraph_GetJSONStrByObj = vgs_PaperParagraph_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperParagraph_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvgs_PaperParagraphObjLst = new Array();
        if (strJSON === "") {
            return arrvgs_PaperParagraphObjLst;
        }
        try {
            arrvgs_PaperParagraphObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvgs_PaperParagraphObjLst;
        }
        return arrvgs_PaperParagraphObjLst;
    }
    exports.vgs_PaperParagraph_GetObjLstByJSONStr = vgs_PaperParagraph_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvgs_PaperParagraphObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vgs_PaperParagraph_GetObjLstByJSONObjLst(arrvgs_PaperParagraphObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvgs_PaperParagraphObjLst = new Array();
        for (const objInFor of arrvgs_PaperParagraphObjLstS) {
            const obj1 = vgs_PaperParagraph_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvgs_PaperParagraphObjLst.push(obj1);
        }
        return arrvgs_PaperParagraphObjLst;
    }
    exports.vgs_PaperParagraph_GetObjLstByJSONObjLst = vgs_PaperParagraph_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2022-11-02
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vgs_PaperParagraph_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvgs_PaperParagraphEN = new clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN();
        if (strJSON === "") {
            return pobjvgs_PaperParagraphEN;
        }
        try {
            pobjvgs_PaperParagraphEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvgs_PaperParagraphEN;
        }
        return pobjvgs_PaperParagraphEN;
    }
    exports.vgs_PaperParagraph_GetObjByJSONStr = vgs_PaperParagraph_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vgs_PaperParagraph_GetCombineCondition(objvgs_PaperParagraph_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId) == true) {
            const strComparisonOp_ParagraphId = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphId, objvgs_PaperParagraph_Cond.paragraphId, strComparisonOp_ParagraphId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName) == true) {
            const strComparisonOp_ParagraphStateName = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateName, objvgs_PaperParagraph_Cond.paragraphStateName, strComparisonOp_ParagraphStateName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeName) == true) {
            const strComparisonOp_ParagraphTypeName = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeName, objvgs_PaperParagraph_Cond.paragraphTypeName, strComparisonOp_ParagraphTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_PaperId, objvgs_PaperParagraph_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_SectionId) == true) {
            const strComparisonOp_SectionId = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_SectionId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_SectionId, objvgs_PaperParagraph_Cond.sectionId, strComparisonOp_SectionId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateId) == true) {
            const strComparisonOp_ParagraphStateId = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphStateId, objvgs_PaperParagraph_Cond.paragraphStateId, strComparisonOp_ParagraphStateId);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeId) == true) {
            const strComparisonOp_ParagraphTypeId = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_ParagraphTypeId, objvgs_PaperParagraph_Cond.paragraphTypeId, strComparisonOp_ParagraphTypeId);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VoteCount) == true) {
            const strComparisonOp_VoteCount = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VoteCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VoteCount, objvgs_PaperParagraph_Cond.voteCount, strComparisonOp_VoteCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CommentCount) == true) {
            const strComparisonOp_CommentCount = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CommentCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CommentCount, objvgs_PaperParagraph_Cond.commentCount, strComparisonOp_CommentCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VersionCount) == true) {
            const strComparisonOp_VersionCount = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VersionCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_VersionCount, objvgs_PaperParagraph_Cond.versionCount, strComparisonOp_VersionCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateDate, objvgs_PaperParagraph_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateUser) == true) {
            const strComparisonOp_CreateUser = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_CreateUser, objvgs_PaperParagraph_Cond.createUser, strComparisonOp_CreateUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdDate, objvgs_PaperParagraph_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_UpdUser, objvgs_PaperParagraph_Cond.updUser, strComparisonOp_UpdUser);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_Memo, objvgs_PaperParagraph_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvgs_PaperParagraph_Cond.dicFldComparisonOp, clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_OrderNum) == true) {
            const strComparisonOp_OrderNum = objvgs_PaperParagraph_Cond.dicFldComparisonOp[clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_OrderNum];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN.con_OrderNum, objvgs_PaperParagraph_Cond.orderNum, strComparisonOp_OrderNum);
        }
        return strWhereCond;
    }
    exports.vgs_PaperParagraph_GetCombineCondition = vgs_PaperParagraph_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--vgs_PaperParagraph(论文段落视图),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strParagraphId: 段落Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vgs_PaperParagraph_GetUniCondStr_ParagraphId(objvgs_PaperParagraphEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.paragraphId);
        return strWhereCond;
    }
    exports.vgs_PaperParagraph_GetUniCondStr_ParagraphId = vgs_PaperParagraph_GetUniCondStr_ParagraphId;
    /**
    *获取唯一性条件串(Uniqueness)--vgs_PaperParagraph(论文段落视图),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strParagraphId: 段落Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function vgs_PaperParagraph_GetUniCondStr4Update_ParagraphId(objvgs_PaperParagraphEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphId <> '{0}'", objvgs_PaperParagraphEN.paragraphId);
        strWhereCond += (0, clsString_js_1.Format)(" and ParagraphId = '{0}'", objvgs_PaperParagraphEN.paragraphId);
        return strWhereCond;
    }
    exports.vgs_PaperParagraph_GetUniCondStr4Update_ParagraphId = vgs_PaperParagraph_GetUniCondStr4Update_ParagraphId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvgs_PaperParagraphENS:源对象
     * @param objvgs_PaperParagraphENT:目标对象
    */
    function vgs_PaperParagraph_CopyObjTo(objvgs_PaperParagraphENS, objvgs_PaperParagraphENT) {
        objvgs_PaperParagraphENT.paragraphId = objvgs_PaperParagraphENS.paragraphId; //段落Id
        objvgs_PaperParagraphENT.paragraphStateName = objvgs_PaperParagraphENS.paragraphStateName; //段落状态
        objvgs_PaperParagraphENT.paragraphTypeName = objvgs_PaperParagraphENS.paragraphTypeName; //段落类型
        objvgs_PaperParagraphENT.paperId = objvgs_PaperParagraphENS.paperId; //论文Id
        objvgs_PaperParagraphENT.sectionId = objvgs_PaperParagraphENS.sectionId; //节Id
        objvgs_PaperParagraphENT.paragraphStateId = objvgs_PaperParagraphENS.paragraphStateId; //段落状态Id
        objvgs_PaperParagraphENT.paragraphTypeId = objvgs_PaperParagraphENS.paragraphTypeId; //段落类型Id
        objvgs_PaperParagraphENT.paragraphContent = objvgs_PaperParagraphENS.paragraphContent; //段落内容
        objvgs_PaperParagraphENT.voteCount = objvgs_PaperParagraphENS.voteCount; //点赞计数
        objvgs_PaperParagraphENT.commentCount = objvgs_PaperParagraphENS.commentCount; //评论数
        objvgs_PaperParagraphENT.versionCount = objvgs_PaperParagraphENS.versionCount; //版本统计
        objvgs_PaperParagraphENT.createDate = objvgs_PaperParagraphENS.createDate; //建立日期
        objvgs_PaperParagraphENT.createUser = objvgs_PaperParagraphENS.createUser; //建立用户
        objvgs_PaperParagraphENT.updDate = objvgs_PaperParagraphENS.updDate; //修改日期
        objvgs_PaperParagraphENT.updUser = objvgs_PaperParagraphENS.updUser; //修改人
        objvgs_PaperParagraphENT.memo = objvgs_PaperParagraphENS.memo; //备注
        objvgs_PaperParagraphENT.orderNum = objvgs_PaperParagraphENS.orderNum; //序号
    }
    exports.vgs_PaperParagraph_CopyObjTo = vgs_PaperParagraph_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvgs_PaperParagraphENS:源对象
     * @param objvgs_PaperParagraphENT:目标对象
    */
    function vgs_PaperParagraph_GetObjFromJsonObj(objvgs_PaperParagraphENS) {
        const objvgs_PaperParagraphENT = new clsvgs_PaperParagraphEN_js_1.clsvgs_PaperParagraphEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvgs_PaperParagraphENT, objvgs_PaperParagraphENS);
        return objvgs_PaperParagraphENT;
    }
    exports.vgs_PaperParagraph_GetObjFromJsonObj = vgs_PaperParagraph_GetObjFromJsonObj;
});
