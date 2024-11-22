/**
* 类名:clsvPaperReadWriteWApi
* 表名:vPaperReadWrite(01120550)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:55:16
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.vPaperReadWrite_GetObjFromJsonObj = exports.vPaperReadWrite_CopyObjTo = exports.vPaperReadWrite_GetCombineCondition = exports.vPaperReadWrite_GetObjByJSONStr = exports.vPaperReadWrite_GetObjLstByJSONObjLst = exports.vPaperReadWrite_GetObjLstByJSONStr = exports.vPaperReadWrite_GetJSONStrByObj = exports.vPaperReadWrite__Cache = exports.vPaperReadWrite_ReFreshThisCache = exports.vPaperReadWrite_GetWebApiUrl = exports.vPaperReadWrite_GetRecCountByCond_Cache = exports.vPaperReadWrite_GetRecCountByCondAsync = exports.vPaperReadWrite_IsExistAsync = exports.vPaperReadWrite_IsExist_Cache = exports.vPaperReadWrite_IsExist = exports.vPaperReadWrite_IsExistRecordAsync = exports.vPaperReadWrite_IsExistRecord_Cache = exports.vPaperReadWrite_GetObjLstByPagerAsync = exports.vPaperReadWrite_GetObjLstByPager_Cache = exports.vPaperReadWrite_GetObjLstByRange = exports.vPaperReadWrite_GetObjLstByRangeAsync = exports.vPaperReadWrite_GetTopObjLstAsync = exports.vPaperReadWrite_GetObjLstByPaperRWIdLst_Cache = exports.vPaperReadWrite_GetObjLstByPaperRWIdLstAsync = exports.vPaperReadWrite_GetSubObjLst_Cache = exports.vPaperReadWrite_GetObjLst_PureCache = exports.vPaperReadWrite_GetObjLst_Cache = exports.vPaperReadWrite_GetObjLst_sessionStorage_PureCache = exports.vPaperReadWrite_GetObjLst_sessionStorage = exports.vPaperReadWrite_GetObjLstAsync = exports.vPaperReadWrite_GetObjLst_localStorage_PureCache = exports.vPaperReadWrite_GetObjLst_localStorage = exports.vPaperReadWrite_GetObjLst_ClientCache = exports.vPaperReadWrite_GetFirstObjAsync = exports.vPaperReadWrite_GetFirstID = exports.vPaperReadWrite_GetFirstIDAsync = exports.vPaperReadWrite_funcKey = exports.vPaperReadWrite_FilterFunByKey = exports.vPaperReadWrite_SortFunByKey = exports.vPaperReadWrite_SortFun_Defa_2Fld = exports.vPaperReadWrite_SortFun_Defa = exports.vPaperReadWrite_func = exports.vPaperReadWrite_GetNameByPaperRWId_Cache = exports.vPaperReadWrite_GetObjByPaperRWId_localStorage = exports.vPaperReadWrite_GetObjByPaperRWId_Cache = exports.vPaperReadWrite_GetObjByPaperRWIdAsync = exports.vPaperReadWrite_ConstructorName = exports.vPaperReadWrite_Controller = void 0;
    /**
     * v论文读写表(vPaperReadWrite)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsvPaperReadWriteEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsvPaperReadWriteEN.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    exports.vPaperReadWrite_Controller = "vPaperReadWriteApi";
    exports.vPaperReadWrite_ConstructorName = "vPaperReadWrite";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPaperRWId:关键字
    * @returns 对象
    **/
    async function vPaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId) {
        const strThisFuncName = "GetObjByPaperRWIdAsync";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperRWId]不能为空！(In clsvPaperReadWriteWApi.GetObjByPaperRWIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.GetObjByPaperRWIdAsync)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperRWId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "strPaperRWId": strPaperRWId,
                }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObj = data.returnObj;
                if (returnObj == null) {
                    return null;
                }
                //console.log(returnObj);
                const objvPaperReadWrite = vPaperReadWrite_GetObjFromJsonObj(returnObj);
                return objvPaperReadWrite;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetObjByPaperRWIdAsync = vPaperReadWrite_GetObjByPaperRWIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function vPaperReadWrite_GetObjByPaperRWId_Cache(strPaperRWId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperRWId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperRWId]不能为空！(In clsvPaperReadWriteWApi.GetObjByPaperRWId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.GetObjByPaperRWId_Cache)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache.filter(x => x.paperRWId == strPaperRWId);
            let objvPaperReadWrite;
            if (arrvPaperReadWrite_Sel.length > 0) {
                objvPaperReadWrite = arrvPaperReadWrite_Sel[0];
                return objvPaperReadWrite;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objvPaperReadWrite_Const = await vPaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId);
                    if (objvPaperReadWrite_Const != null) {
                        vPaperReadWrite_ReFreshThisCache(strid_CurrEduCls);
                        return objvPaperReadWrite_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperRWId, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.vPaperReadWrite_GetObjByPaperRWId_Cache = vPaperReadWrite_GetObjByPaperRWId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function vPaperReadWrite_GetObjByPaperRWId_localStorage(strPaperRWId) {
        const strThisFuncName = "GetObjByPaperRWId_localStorage";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperRWId]不能为空！(In clsvPaperReadWriteWApi.GetObjByPaperRWId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.GetObjByPaperRWId_localStorage)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strPaperRWId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objvPaperReadWrite_Cache = JSON.parse(strTempObj);
            return objvPaperReadWrite_Cache;
        }
        try {
            const objvPaperReadWrite = await vPaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId);
            if (objvPaperReadWrite != null) {
                localStorage.setItem(strKey, JSON.stringify(objvPaperReadWrite));
                const strInfo = (0, clsString_js_1.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objvPaperReadWrite;
            }
            return objvPaperReadWrite;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperRWId, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.vPaperReadWrite_GetObjByPaperRWId_localStorage = vPaperReadWrite_GetObjByPaperRWId_localStorage;
    /**
     * 根据关键字获取相关对象的名称属性, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetNameByKeyId_Cache)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function vPaperReadWrite_GetNameByPaperRWId_Cache(strPaperRWId, strid_CurrEduCls) {
        const strThisFuncName = "GetNameByPaperRWId_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strPaperRWId]不能为空！(In clsvPaperReadWriteWApi.GetNameByPaperRWId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.GetNameByPaperRWId_Cache)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperReadWriteObjLst_Cache == null)
            return "";
        try {
            const arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache.filter(x => x.paperRWId == strPaperRWId);
            let objvPaperReadWrite;
            if (arrvPaperReadWrite_Sel.length > 0) {
                objvPaperReadWrite = arrvPaperReadWrite_Sel[0];
                return objvPaperReadWrite.operationTypeName;
            }
            else {
                return "";
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象名称属性不成功!", e, strPaperRWId);
            console.error(strMsg);
            alert(strMsg);
        }
        return "";
    }
    exports.vPaperReadWrite_GetNameByPaperRWId_Cache = vPaperReadWrite_GetNameByPaperRWId_Cache;
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
    async function vPaperReadWrite_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvPaperReadWriteWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_1.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPaperRWId = strInValue;
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objvPaperReadWrite = await vPaperReadWrite_GetObjByPaperRWId_Cache(strPaperRWId, strid_CurrEduCls_C);
        if (objvPaperReadWrite == null)
            return "";
        if (objvPaperReadWrite.GetFldValue(strOutFldName) == null)
            return "";
        return objvPaperReadWrite.GetFldValue(strOutFldName).toString();
    }
    exports.vPaperReadWrite_func = vPaperReadWrite_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperReadWrite_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperRWId.localeCompare(b.paperRWId);
    }
    exports.vPaperReadWrite_SortFun_Defa = vPaperReadWrite_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperReadWrite_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.readerId == b.readerId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.readerId.localeCompare(b.readerId);
    }
    exports.vPaperReadWrite_SortFun_Defa_2Fld = vPaperReadWrite_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function vPaperReadWrite_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId:
                    return (a, b) => {
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ReaderId:
                    return (a, b) => {
                        if (a.readerId == null)
                            return -1;
                        if (b.readerId == null)
                            return 1;
                        return a.readerId.localeCompare(b.readerId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle:
                    return (a, b) => {
                        if (a.paperTitle == null)
                            return -1;
                        if (b.paperTitle == null)
                            return 1;
                        return a.paperTitle.localeCompare(b.paperTitle);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperContent:
                    return (a, b) => {
                        if (a.paperContent == null)
                            return -1;
                        if (b.paperContent == null)
                            return 1;
                        return a.paperContent.localeCompare(b.paperContent);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Periodical:
                    return (a, b) => {
                        if (a.periodical == null)
                            return -1;
                        if (b.periodical == null)
                            return 1;
                        return a.periodical.localeCompare(b.periodical);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Author:
                    return (a, b) => {
                        if (a.author == null)
                            return -1;
                        if (b.author == null)
                            return 1;
                        return a.author.localeCompare(b.author);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Keyword:
                    return (a, b) => {
                        if (a.keyword == null)
                            return -1;
                        if (b.keyword == null)
                            return 1;
                        return a.keyword.localeCompare(b.keyword);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId:
                    return (a, b) => {
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName:
                    return (a, b) => {
                        return a.operationTypeName.localeCompare(b.operationTypeName);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate:
                    return (a, b) => {
                        if (a.updDate == null)
                            return -1;
                        if (b.updDate == null)
                            return 1;
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureLink:
                    return (a, b) => {
                        if (a.literatureLink == null)
                            return -1;
                        if (b.literatureLink == null)
                            return 1;
                        return a.literatureLink.localeCompare(b.literatureLink);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureSources:
                    return (a, b) => {
                        if (a.literatureSources == null)
                            return -1;
                        if (b.literatureSources == null)
                            return 1;
                        return a.literatureSources.localeCompare(b.literatureSources);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeId:
                    return (a, b) => {
                        if (a.literatureTypeId == null)
                            return -1;
                        if (b.literatureTypeId == null)
                            return 1;
                        return a.literatureTypeId.localeCompare(b.literatureTypeId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeName:
                    return (a, b) => {
                        if (a.literatureTypeName == null)
                            return -1;
                        if (b.literatureTypeName == null)
                            return 1;
                        return a.literatureTypeName.localeCompare(b.literatureTypeName);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (a.uploadfileUrl == null)
                            return -1;
                        if (b.uploadfileUrl == null)
                            return 1;
                        return a.uploadfileUrl.localeCompare(b.uploadfileUrl);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Submitter:
                    return (a, b) => {
                        if (a.submitter == null)
                            return -1;
                        if (b.submitter == null)
                            return 1;
                        return a.submitter.localeCompare(b.submitter);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Pcount:
                    return (a, b) => {
                        return a.pcount - b.pcount;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_TeaCount:
                    return (a, b) => {
                        return a.teaCount - b.teaCount;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_SubVCount:
                    return (a, b) => {
                        return a.subVCount - b.subVCount;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperReadWrite]中不存在！(in ${exports.vPaperReadWrite_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId:
                    return (a, b) => {
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ReaderId:
                    return (a, b) => {
                        if (b.readerId == null)
                            return -1;
                        if (a.readerId == null)
                            return 1;
                        return b.readerId.localeCompare(a.readerId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle:
                    return (a, b) => {
                        if (b.paperTitle == null)
                            return -1;
                        if (a.paperTitle == null)
                            return 1;
                        return b.paperTitle.localeCompare(a.paperTitle);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperContent:
                    return (a, b) => {
                        if (b.paperContent == null)
                            return -1;
                        if (a.paperContent == null)
                            return 1;
                        return b.paperContent.localeCompare(a.paperContent);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Periodical:
                    return (a, b) => {
                        if (b.periodical == null)
                            return -1;
                        if (a.periodical == null)
                            return 1;
                        return b.periodical.localeCompare(a.periodical);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Author:
                    return (a, b) => {
                        if (b.author == null)
                            return -1;
                        if (a.author == null)
                            return 1;
                        return b.author.localeCompare(a.author);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Keyword:
                    return (a, b) => {
                        if (b.keyword == null)
                            return -1;
                        if (a.keyword == null)
                            return 1;
                        return b.keyword.localeCompare(a.keyword);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId:
                    return (a, b) => {
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName:
                    return (a, b) => {
                        return b.operationTypeName.localeCompare(a.operationTypeName);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate:
                    return (a, b) => {
                        if (b.updDate == null)
                            return -1;
                        if (a.updDate == null)
                            return 1;
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureLink:
                    return (a, b) => {
                        if (b.literatureLink == null)
                            return -1;
                        if (a.literatureLink == null)
                            return 1;
                        return b.literatureLink.localeCompare(a.literatureLink);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureSources:
                    return (a, b) => {
                        if (b.literatureSources == null)
                            return -1;
                        if (a.literatureSources == null)
                            return 1;
                        return b.literatureSources.localeCompare(a.literatureSources);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeId:
                    return (a, b) => {
                        if (b.literatureTypeId == null)
                            return -1;
                        if (a.literatureTypeId == null)
                            return 1;
                        return b.literatureTypeId.localeCompare(a.literatureTypeId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeName:
                    return (a, b) => {
                        if (b.literatureTypeName == null)
                            return -1;
                        if (a.literatureTypeName == null)
                            return 1;
                        return b.literatureTypeName.localeCompare(a.literatureTypeName);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UploadfileUrl:
                    return (a, b) => {
                        if (b.uploadfileUrl == null)
                            return -1;
                        if (a.uploadfileUrl == null)
                            return 1;
                        return b.uploadfileUrl.localeCompare(a.uploadfileUrl);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Submitter:
                    return (a, b) => {
                        if (b.submitter == null)
                            return -1;
                        if (a.submitter == null)
                            return 1;
                        return b.submitter.localeCompare(a.submitter);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Pcount:
                    return (a, b) => {
                        return b.pcount - a.pcount;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_TeaCount:
                    return (a, b) => {
                        return b.teaCount - a.teaCount;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_SubVCount:
                    return (a, b) => {
                        return b.subVCount - a.subVCount;
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[vPaperReadWrite]中不存在！(in ${exports.vPaperReadWrite_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.vPaperReadWrite_SortFunByKey = vPaperReadWrite_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function vPaperReadWrite_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ReaderId:
                return (obj) => {
                    return obj.readerId === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle:
                return (obj) => {
                    return obj.paperTitle === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperContent:
                return (obj) => {
                    return obj.paperContent === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Periodical:
                return (obj) => {
                    return obj.periodical === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Author:
                return (obj) => {
                    return obj.author === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Keyword:
                return (obj) => {
                    return obj.keyword === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName:
                return (obj) => {
                    return obj.operationTypeName === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureLink:
                return (obj) => {
                    return obj.literatureLink === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureSources:
                return (obj) => {
                    return obj.literatureSources === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeId:
                return (obj) => {
                    return obj.literatureTypeId === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeName:
                return (obj) => {
                    return obj.literatureTypeName === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UploadfileUrl:
                return (obj) => {
                    return obj.uploadfileUrl === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Submitter:
                return (obj) => {
                    return obj.submitter === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Pcount:
                return (obj) => {
                    return obj.pcount === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_TeaCount:
                return (obj) => {
                    return obj.teaCount === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_SubVCount:
                return (obj) => {
                    return obj.subVCount === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[vPaperReadWrite]中不存在！(in ${exports.vPaperReadWrite_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.vPaperReadWrite_FilterFunByKey = vPaperReadWrite_FilterFunByKey;
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
    async function vPaperReadWrite_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsvPaperReadWriteWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId) {
            const strMsg = (0, clsString_js_1.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_1.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrvPaperReadWrite = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrvPaperReadWrite == null)
            return [];
        let arrvPaperReadWrite_Sel = arrvPaperReadWrite;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrvPaperReadWrite_Sel.length == 0)
            return [];
        return arrvPaperReadWrite_Sel.map(x => x.paperRWId);
    }
    exports.vPaperReadWrite_funcKey = vPaperReadWrite_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function vPaperReadWrite_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetFirstIDAsync = vPaperReadWrite_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function vPaperReadWrite_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetFirstID = vPaperReadWrite_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function vPaperReadWrite_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
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
                const objvPaperReadWrite = vPaperReadWrite_GetObjFromJsonObj(returnObj);
                return objvPaperReadWrite;
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetFirstObjAsync = vPaperReadWrite_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrvPaperReadWriteExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrvPaperReadWriteObjLst_T = vPaperReadWrite_GetObjLstByJSONObjLst(arrvPaperReadWriteExObjLst_Cache);
            return arrvPaperReadWriteObjLst_T;
        }
        try {
            const arrvPaperReadWriteExObjLst = await vPaperReadWrite_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrvPaperReadWriteExObjLst);
            const strInfo = (0, clsString_js_1.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperReadWriteExObjLst.length);
            console.log(strInfo);
            return arrvPaperReadWriteExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperReadWrite_GetObjLst_ClientCache = vPaperReadWrite_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperReadWriteExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperReadWriteObjLst_T = vPaperReadWrite_GetObjLstByJSONObjLst(arrvPaperReadWriteExObjLst_Cache);
            return arrvPaperReadWriteObjLst_T;
        }
        try {
            const arrvPaperReadWriteExObjLst = await vPaperReadWrite_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrvPaperReadWriteExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperReadWriteExObjLst.length);
            console.log(strInfo);
            return arrvPaperReadWriteExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperReadWrite_GetObjLst_localStorage = vPaperReadWrite_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrvPaperReadWriteObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperReadWriteObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperReadWrite_GetObjLst_localStorage_PureCache = vPaperReadWrite_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function vPaperReadWrite_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetObjLstAsync = vPaperReadWrite_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_1.Format)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_1.IsNullOrEmpty)(clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_1.Format)(" and {0}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperReadWriteExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrvPaperReadWriteObjLst_T = vPaperReadWrite_GetObjLstByJSONObjLst(arrvPaperReadWriteExObjLst_Cache);
            return arrvPaperReadWriteObjLst_T;
        }
        try {
            const arrvPaperReadWriteExObjLst = await vPaperReadWrite_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrvPaperReadWriteExObjLst));
            const strInfo = (0, clsString_js_1.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrvPaperReadWriteExObjLst.length);
            console.log(strInfo);
            return arrvPaperReadWriteExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.vPaperReadWrite_GetObjLst_sessionStorage = vPaperReadWrite_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_1.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrvPaperReadWriteObjLst_Cache = JSON.parse(strTempObjLst);
            return arrvPaperReadWriteObjLst_Cache;
        }
        else
            return null;
    }
    exports.vPaperReadWrite_GetObjLst_sessionStorage_PureCache = vPaperReadWrite_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsvPaperReadWriteWApi.vPaperReadWrite_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsvPaperReadWriteWApi.vPaperReadWrite_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrvPaperReadWriteObjLst_Cache;
        switch (clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrvPaperReadWriteObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(arrvPaperReadWriteObjLst_Cache);
        return arrvPaperReadWriteObjLst_Cache;
    }
    exports.vPaperReadWrite_GetObjLst_Cache = vPaperReadWrite_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function vPaperReadWrite_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrvPaperReadWriteObjLst_Cache;
        switch (clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheModeId) {
            case "04": //sessionStorage
                arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrvPaperReadWriteObjLst_Cache = null;
                break;
            default:
                arrvPaperReadWriteObjLst_Cache = null;
                break;
        }
        return arrvPaperReadWriteObjLst_Cache;
    }
    exports.vPaperReadWrite_GetObjLst_PureCache = vPaperReadWrite_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPaperRWId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperReadWrite_GetSubObjLst_Cache(objvPaperReadWrite_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        let arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache;
        if (objvPaperReadWrite_Cond.sf_FldComparisonOp == null || objvPaperReadWrite_Cond.sf_FldComparisonOp == "")
            return arrvPaperReadWrite_Sel;
        const dicFldComparisonOp = JSON.parse(objvPaperReadWrite_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperReadWriteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperReadWrite_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objvPaperReadWrite_Cond), exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperReadWrite_GetSubObjLst_Cache = vPaperReadWrite_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperRWId:关键字列表
    * @returns 对象列表
    **/
    async function vPaperReadWrite_GetObjLstByPaperRWIdLstAsync(arrPaperRWId) {
        const strThisFuncName = "GetObjLstByPaperRWIdLstAsync";
        const strAction = "GetObjLstByPaperRWIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperRWId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetObjLstByPaperRWIdLstAsync = vPaperReadWrite_GetObjLstByPaperRWIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPaperRWIdLst:关键字列表
     * @returns 对象列表
    */
    async function vPaperReadWrite_GetObjLstByPaperRWIdLst_Cache(arrPaperRWIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPaperRWIdLst_Cache";
        try {
            const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
            const arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache.filter(x => arrPaperRWIdLst.indexOf(x.paperRWId) > -1);
            return arrvPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperRWIdLst.join(","), exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.vPaperReadWrite_GetObjLstByPaperRWIdLst_Cache = vPaperReadWrite_GetObjLstByPaperRWIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function vPaperReadWrite_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetTopObjLstAsync = vPaperReadWrite_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperReadWrite_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetObjLstByRangeAsync = vPaperReadWrite_GetObjLstByRangeAsync;
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
    async function vPaperReadWrite_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetObjLstByRange = vPaperReadWrite_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function vPaperReadWrite_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperReadWriteObjLst_Cache.length == 0)
            return arrvPaperReadWriteObjLst_Cache;
        let arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objvPaperReadWrite_Cond = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperReadWrite_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsvPaperReadWriteWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperReadWrite_Sel.length == 0)
                return arrvPaperReadWrite_Sel;
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
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.sort(vPaperReadWrite_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.sort(objPagerPara.sortFun);
            }
            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.slice(intStart, intEnd);
            return arrvPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.vPaperReadWrite_GetObjLstByPager_Cache = vPaperReadWrite_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function vPaperReadWrite_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_1.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = vPaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetObjLstByPagerAsync = vPaperReadWrite_GetObjLstByPagerAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPaperRWId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function vPaperReadWrite_IsExistRecord_Cache(objvPaperReadWrite_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperReadWriteObjLst_Cache == null)
            return false;
        let arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache;
        if (objvPaperReadWrite_Cond.sf_FldComparisonOp == null || objvPaperReadWrite_Cond.sf_FldComparisonOp == "")
            return arrvPaperReadWrite_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objvPaperReadWrite_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperReadWriteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperReadWrite_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrvPaperReadWrite_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objvPaperReadWrite_Cond), exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.vPaperReadWrite_IsExistRecord_Cache = vPaperReadWrite_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function vPaperReadWrite_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_IsExistRecordAsync = vPaperReadWrite_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPaperRWId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function vPaperReadWrite_IsExist(strPaperRWId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: {
                    "PaperRWId": strPaperRWId,
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_IsExist = vPaperReadWrite_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function vPaperReadWrite_IsExist_Cache(strPaperRWId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperReadWriteObjLst_Cache == null)
            return false;
        try {
            const arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache.filter(x => x.paperRWId == strPaperRWId);
            if (arrvPaperReadWrite_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperRWId, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.vPaperReadWrite_IsExist_Cache = vPaperReadWrite_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPaperRWId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function vPaperReadWrite_IsExistAsync(strPaperRWId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strPaperRWId": strPaperRWId }
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_IsExistAsync = vPaperReadWrite_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function vPaperReadWrite_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.vPaperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_1.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.vPaperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.vPaperReadWrite_GetRecCountByCondAsync = vPaperReadWrite_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objvPaperReadWrite_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function vPaperReadWrite_GetRecCountByCond_Cache(objvPaperReadWrite_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrvPaperReadWriteObjLst_Cache = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrvPaperReadWriteObjLst_Cache == null)
            return 0;
        let arrvPaperReadWrite_Sel = arrvPaperReadWriteObjLst_Cache;
        if (objvPaperReadWrite_Cond.sf_FldComparisonOp == null || objvPaperReadWrite_Cond.sf_FldComparisonOp == "")
            return arrvPaperReadWrite_Sel.length;
        const dicFldComparisonOp = JSON.parse(objvPaperReadWrite_Cond.sf_FldComparisonOp);
        //console.log("clsvPaperReadWriteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objvPaperReadWrite_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objvPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrvPaperReadWrite_Sel = arrvPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrvPaperReadWrite_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_1.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objvPaperReadWrite_Cond), exports.vPaperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.vPaperReadWrite_GetRecCountByCond_Cache = vPaperReadWrite_GetRecCountByCond_Cache;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function vPaperReadWrite_GetWebApiUrl(strController, strAction) {
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
    exports.vPaperReadWrite_GetWebApiUrl = vPaperReadWrite_GetWebApiUrl;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function vPaperReadWrite_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_1.Format)("{0}_{1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
            switch (clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.CacheModeId) {
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
    exports.vPaperReadWrite_ReFreshThisCache = vPaperReadWrite_ReFreshThisCache;
    /**
     * 绑定基于Web的下拉框,在某一层下的下拉框
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_TabFeature_DdlBindFunctionInDiv)
     * @param objDDL:需要绑定当前表的下拉框
    */
    async function vPaperReadWrite__Cache(strDivName, strDdlName, strid_CurrEduCls) {
        const strThisFuncName = "_Cache";
        if ((0, clsString_js_1.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_1.Format)("参数:[strid_CurrEduCls]不能为空！(In clsvPaperReadWriteWApi.)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_1.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsvPaperReadWriteWApi.)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const objDdl = document.getElementById(strDdlName);
        if (objDdl == null) {
            const strMsg = (0, clsString_js_1.Format)("下拉框：{0} 不存在！(In )", strDdlName);
            alert(strMsg);
            console.error(strMsg);
            throw (strMsg);
        }
        //为数据源于表的下拉框设置内容
        //console.log("开始：_Cache");
        const arrObjLst_Sel = await vPaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrObjLst_Sel == null)
            return;
        (0, clsCommFunc4Web_js_1.BindDdl_ObjLstInDiv_V)(strDivName, strDdlName, arrObjLst_Sel, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName, "v论文读写表");
    }
    exports.vPaperReadWrite__Cache = vPaperReadWrite__Cache;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperReadWrite_GetJSONStrByObj(pobjvPaperReadWriteEN) {
        const strThisFuncName = "GetJSONStrByObj";
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjvPaperReadWriteEN);
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
    exports.vPaperReadWrite_GetJSONStrByObj = vPaperReadWrite_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function vPaperReadWrite_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrvPaperReadWriteObjLst = new Array();
        if (strJSON === "") {
            return arrvPaperReadWriteObjLst;
        }
        try {
            arrvPaperReadWriteObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrvPaperReadWriteObjLst;
        }
        return arrvPaperReadWriteObjLst;
    }
    exports.vPaperReadWrite_GetObjLstByJSONStr = vPaperReadWrite_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrvPaperReadWriteObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function vPaperReadWrite_GetObjLstByJSONObjLst(arrvPaperReadWriteObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrvPaperReadWriteObjLst = new Array();
        for (const objInFor of arrvPaperReadWriteObjLstS) {
            const obj1 = vPaperReadWrite_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrvPaperReadWriteObjLst.push(obj1);
        }
        return arrvPaperReadWriteObjLst;
    }
    exports.vPaperReadWrite_GetObjLstByJSONObjLst = vPaperReadWrite_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function vPaperReadWrite_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjvPaperReadWriteEN = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
        if (strJSON === "") {
            return pobjvPaperReadWriteEN;
        }
        try {
            pobjvPaperReadWriteEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjvPaperReadWriteEN;
        }
        return pobjvPaperReadWriteEN;
    }
    exports.vPaperReadWrite_GetObjByJSONStr = vPaperReadWrite_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function vPaperReadWrite_GetCombineCondition(objvPaperReadWrite_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperRWId, objvPaperReadWrite_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ReaderId) == true) {
            const strComparisonOp_ReaderId = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ReaderId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ReaderId, objvPaperReadWrite_Cond.readerId, strComparisonOp_ReaderId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperId, objvPaperReadWrite_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle) == true) {
            const strComparisonOp_PaperTitle = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_PaperTitle, objvPaperReadWrite_Cond.paperTitle, strComparisonOp_PaperTitle);
        }
        //数据类型string(text)在函数:[AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj]中没有处理！
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Periodical) == true) {
            const strComparisonOp_Periodical = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Periodical];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Periodical, objvPaperReadWrite_Cond.periodical, strComparisonOp_Periodical);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Author) == true) {
            const strComparisonOp_Author = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Author];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Author, objvPaperReadWrite_Cond.author, strComparisonOp_Author);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Keyword) == true) {
            const strComparisonOp_Keyword = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Keyword];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Keyword, objvPaperReadWrite_Cond.keyword, strComparisonOp_Keyword);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ResearchQuestion, objvPaperReadWrite_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeId, objvPaperReadWrite_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName) == true) {
            const strComparisonOp_OperationTypeName = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_OperationTypeName, objvPaperReadWrite_Cond.operationTypeName, strComparisonOp_OperationTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdDate, objvPaperReadWrite_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Memo) == true) {
            const strComparisonOp_Memo = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Memo];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Memo, objvPaperReadWrite_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureLink) == true) {
            const strComparisonOp_LiteratureLink = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureLink];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureLink, objvPaperReadWrite_Cond.literatureLink, strComparisonOp_LiteratureLink);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureSources) == true) {
            const strComparisonOp_LiteratureSources = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureSources];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureSources, objvPaperReadWrite_Cond.literatureSources, strComparisonOp_LiteratureSources);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeId) == true) {
            const strComparisonOp_LiteratureTypeId = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeId, objvPaperReadWrite_Cond.literatureTypeId, strComparisonOp_LiteratureTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeName) == true) {
            const strComparisonOp_LiteratureTypeName = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeName];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_LiteratureTypeName, objvPaperReadWrite_Cond.literatureTypeName, strComparisonOp_LiteratureTypeName);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UploadfileUrl) == true) {
            const strComparisonOp_UploadfileUrl = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UploadfileUrl];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UploadfileUrl, objvPaperReadWrite_Cond.uploadfileUrl, strComparisonOp_UploadfileUrl);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsPublic) == true) {
            if (objvPaperReadWrite_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsSubmit) == true) {
            if (objvPaperReadWrite_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '1'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_1.Format)(" And {0} = '0'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Submitter) == true) {
            const strComparisonOp_Submitter = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Submitter];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Submitter, objvPaperReadWrite_Cond.submitter, strComparisonOp_Submitter);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Pcount) == true) {
            const strComparisonOp_Pcount = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Pcount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_Pcount, objvPaperReadWrite_Cond.pcount, strComparisonOp_Pcount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_TeaCount) == true) {
            const strComparisonOp_TeaCount = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_TeaCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_TeaCount, objvPaperReadWrite_Cond.teaCount, strComparisonOp_TeaCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_id_CurrEduCls, objvPaperReadWrite_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_SubVCount) == true) {
            const strComparisonOp_SubVCount = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_SubVCount];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} {1}", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_SubVCount, objvPaperReadWrite_Cond.subVCount, strComparisonOp_SubVCount);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_CreateDate];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_CreateDate, objvPaperReadWrite_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ShareId];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_ShareId, objvPaperReadWrite_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objvPaperReadWrite_Cond.dicFldComparisonOp, clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objvPaperReadWrite_Cond.dicFldComparisonOp[clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser];
            strWhereCond += (0, clsString_js_1.Format)(" And {0} {2} '{1}'", clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN.con_UpdUser, objvPaperReadWrite_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.vPaperReadWrite_GetCombineCondition = vPaperReadWrite_GetCombineCondition;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objvPaperReadWriteENS:源对象
     * @param objvPaperReadWriteENT:目标对象
    */
    function vPaperReadWrite_CopyObjTo(objvPaperReadWriteENS, objvPaperReadWriteENT) {
        objvPaperReadWriteENT.paperRWId = objvPaperReadWriteENS.paperRWId; //课文阅读
        objvPaperReadWriteENT.readerId = objvPaperReadWriteENS.readerId; //阅读者Id
        objvPaperReadWriteENT.paperId = objvPaperReadWriteENS.paperId; //论文Id
        objvPaperReadWriteENT.paperTitle = objvPaperReadWriteENS.paperTitle; //论文标题
        objvPaperReadWriteENT.paperContent = objvPaperReadWriteENS.paperContent; //主题内容
        objvPaperReadWriteENT.periodical = objvPaperReadWriteENS.periodical; //期刊
        objvPaperReadWriteENT.author = objvPaperReadWriteENS.author; //作者
        objvPaperReadWriteENT.keyword = objvPaperReadWriteENS.keyword; //关键字
        objvPaperReadWriteENT.researchQuestion = objvPaperReadWriteENS.researchQuestion; //研究问题
        objvPaperReadWriteENT.operationTypeId = objvPaperReadWriteENS.operationTypeId; //操作类型ID
        objvPaperReadWriteENT.operationTypeName = objvPaperReadWriteENS.operationTypeName; //操作类型名
        objvPaperReadWriteENT.updDate = objvPaperReadWriteENS.updDate; //修改日期
        objvPaperReadWriteENT.memo = objvPaperReadWriteENS.memo; //备注
        objvPaperReadWriteENT.literatureLink = objvPaperReadWriteENS.literatureLink; //文献链接
        objvPaperReadWriteENT.literatureSources = objvPaperReadWriteENS.literatureSources; //文献来源
        objvPaperReadWriteENT.literatureTypeId = objvPaperReadWriteENS.literatureTypeId; //作文类型Id
        objvPaperReadWriteENT.literatureTypeName = objvPaperReadWriteENS.literatureTypeName; //作文类型名
        objvPaperReadWriteENT.uploadfileUrl = objvPaperReadWriteENS.uploadfileUrl; //文件地址
        objvPaperReadWriteENT.isPublic = objvPaperReadWriteENS.isPublic; //是否公开
        objvPaperReadWriteENT.isSubmit = objvPaperReadWriteENS.isSubmit; //是否提交
        objvPaperReadWriteENT.submitter = objvPaperReadWriteENS.submitter; //提交人
        objvPaperReadWriteENT.pcount = objvPaperReadWriteENS.pcount; //读写数
        objvPaperReadWriteENT.teaCount = objvPaperReadWriteENS.teaCount; //TeaCount
        objvPaperReadWriteENT.id_CurrEduCls = objvPaperReadWriteENS.id_CurrEduCls; //教学班流水号
        objvPaperReadWriteENT.subVCount = objvPaperReadWriteENS.subVCount; //论文子观点数
        objvPaperReadWriteENT.createDate = objvPaperReadWriteENS.createDate; //建立日期
        objvPaperReadWriteENT.shareId = objvPaperReadWriteENS.shareId; //分享Id
        objvPaperReadWriteENT.updUser = objvPaperReadWriteENS.updUser; //修改人
    }
    exports.vPaperReadWrite_CopyObjTo = vPaperReadWrite_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objvPaperReadWriteENS:源对象
     * @param objvPaperReadWriteENT:目标对象
    */
    function vPaperReadWrite_GetObjFromJsonObj(objvPaperReadWriteENS) {
        const objvPaperReadWriteENT = new clsvPaperReadWriteEN_js_1.clsvPaperReadWriteEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objvPaperReadWriteENT, objvPaperReadWriteENS);
        return objvPaperReadWriteENT;
    }
    exports.vPaperReadWrite_GetObjFromJsonObj = vPaperReadWrite_GetObjFromJsonObj;
});
