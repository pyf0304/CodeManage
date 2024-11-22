/**
* 类名:clsPaperReadWriteWApi
* 表名:PaperReadWrite(01120547)
* 版本:2023.03.10.1(服务器:WIN-SRV103-116)
* 日期:2023/03/13 00:53:50
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
        define(["require", "exports", "axios", "../../PubFun/enumComparisonOp.js", "../../PubFun/CacheHelper.js", "../../L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js", "../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js", "../../PubFun/clsCommFunc4Web.js", "../../PubConfig/clsSysPara4WebApi.js", "../../PubFun/clsString.js", "../../PubFun/clsString.js"], factory);
    }
})(function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    exports.PaperReadWrite_GetObjFromJsonObj = exports.PaperReadWrite_CopyObjTo = exports.PaperReadWrite_GetUniCondStr4Update_ReaderId_PaperId = exports.PaperReadWrite_GetUniCondStr_ReaderId_PaperId = exports.PaperReadWrite_GetCombineCondition = exports.PaperReadWrite_GetObjByJSONStr = exports.PaperReadWrite_GetObjLstByJSONObjLst = exports.PaperReadWrite_GetObjLstByJSONStr = exports.PaperReadWrite_GetJSONStrByObj = exports.PaperReadWrite_CheckProperty4Update = exports.PaperReadWrite_CheckPropertyNew = exports.PaperReadWrite_ReFreshThisCache = exports.PaperReadWrite_ReFreshCache = exports.PaperReadWrite_GetWebApiUrl = exports.PaperReadWrite_GetMaxStrIdByPrefix = exports.PaperReadWrite_GetMaxStrIdAsync = exports.PaperReadWrite_GetRecCountByCond_Cache = exports.PaperReadWrite_GetRecCountByCondAsync = exports.PaperReadWrite_IsExistAsync = exports.PaperReadWrite_IsExist_Cache = exports.PaperReadWrite_IsExist = exports.PaperReadWrite_IsExistRecordAsync = exports.PaperReadWrite_IsExistRecord_Cache = exports.PaperReadWrite_UpdateWithConditionAsync = exports.PaperReadWrite_UpdateRecordAsync = exports.PaperReadWrite_AddNewRecordWithReturnKey = exports.PaperReadWrite_AddNewRecordWithReturnKeyAsync = exports.PaperReadWrite_AddNewRecordWithMaxIdAsync = exports.PaperReadWrite_AddNewRecordAsync = exports.PaperReadWrite_DelPaperReadWritesByCondAsync = exports.PaperReadWrite_DelPaperReadWritesAsync = exports.PaperReadWrite_DelRecordAsync = exports.PaperReadWrite_GetObjLstByPagerAsync = exports.PaperReadWrite_GetObjLstByPager_Cache = exports.PaperReadWrite_GetObjLstByRange = exports.PaperReadWrite_GetObjLstByRangeAsync = exports.PaperReadWrite_GetTopObjLstAsync = exports.PaperReadWrite_GetObjLstByPaperRWIdLst_Cache = exports.PaperReadWrite_GetObjLstByPaperRWIdLstAsync = exports.PaperReadWrite_GetSubObjLst_Cache = exports.PaperReadWrite_GetObjLst_PureCache = exports.PaperReadWrite_GetObjLst_Cache = exports.PaperReadWrite_GetObjLst_sessionStorage_PureCache = exports.PaperReadWrite_GetObjLst_sessionStorage = exports.PaperReadWrite_GetObjLstAsync = exports.PaperReadWrite_GetObjLst_localStorage_PureCache = exports.PaperReadWrite_GetObjLst_localStorage = exports.PaperReadWrite_GetObjLst_ClientCache = exports.PaperReadWrite_GetFirstObjAsync = exports.PaperReadWrite_GetFirstID = exports.PaperReadWrite_GetFirstIDAsync = exports.PaperReadWrite_funcKey = exports.PaperReadWrite_FilterFunByKey = exports.PaperReadWrite_SortFunByKey = exports.PaperReadWrite_SortFun_Defa_2Fld = exports.PaperReadWrite_SortFun_Defa = exports.PaperReadWrite_func = exports.PaperReadWrite_UpdateObjInLst_Cache = exports.PaperReadWrite_GetObjByPaperRWId_localStorage = exports.PaperReadWrite_GetObjByPaperRWId_Cache = exports.PaperReadWrite_GetObjByPaperRWIdAsync = exports.paperReadWrite_ConstructorName = exports.paperReadWrite_Controller = void 0;
    /**
     * 论文读写表(PaperReadWrite)
     * (AutoGCLib.WA_Access4TypeScript:GeneCode)
    * Created by pyf on 2023年03月13日.
    * 注意:该类必须与调用界面处于同一个包，否则调用不成功!
     **/
    const axios_1 = __importDefault(require("axios"));
    const enumComparisonOp_js_1 = require("../../PubFun/enumComparisonOp.js");
    const CacheHelper_js_1 = require("../../PubFun/CacheHelper.js");
    const clsPaperReadWriteEN_js_1 = require("../../L0_Entity/GraduateEduPaper/clsPaperReadWriteEN.js");
    const clsvPaperReadWriteWApi_js_1 = require("../../L3_ForWApi/GraduateEduPaper/clsvPaperReadWriteWApi.js");
    const clsCommFunc4Web_js_1 = require("../../PubFun/clsCommFunc4Web.js");
    const clsSysPara4WebApi_js_1 = require("../../PubConfig/clsSysPara4WebApi.js");
    const clsString_js_1 = require("../../PubFun/clsString.js");
    const clsString_js_2 = require("../../PubFun/clsString.js");
    exports.paperReadWrite_Controller = "PaperReadWriteApi";
    exports.paperReadWrite_ConstructorName = "paperReadWrite";
    /**
    * 根据关键字获取相应记录的对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyIdAsync)
    * @param strPaperRWId:关键字
    * @returns 对象
    **/
    async function PaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId) {
        const strThisFuncName = "GetObjByPaperRWIdAsync";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperRWId]不能为空！(In clsPaperReadWriteWApi.GetObjByPaperRWIdAsync)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsPaperReadWriteWApi.GetObjByPaperRWIdAsync)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strAction = "GetObjByPaperRWId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const objPaperReadWrite = PaperReadWrite_GetObjFromJsonObj(returnObj);
                return objPaperReadWrite;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetObjByPaperRWIdAsync = PaperReadWrite_GetObjByPaperRWIdAsync;
    /**
     * 根据关键字获取相关对象, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_Cache)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function PaperReadWrite_GetObjByPaperRWId_Cache(strPaperRWId, strid_CurrEduCls, bolTryAsyncOnce = true) {
        const strThisFuncName = "GetObjByPaperRWId_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperRWId]不能为空！(In clsPaperReadWriteWApi.GetObjByPaperRWId_Cache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsPaperReadWriteWApi.GetObjByPaperRWId_Cache)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        try {
            const arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache.filter(x => x.paperRWId == strPaperRWId);
            let objPaperReadWrite;
            if (arrPaperReadWrite_Sel.length > 0) {
                objPaperReadWrite = arrPaperReadWrite_Sel[0];
                return objPaperReadWrite;
            }
            else {
                if (bolTryAsyncOnce == true) {
                    const objPaperReadWrite_Const = await PaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId);
                    if (objPaperReadWrite_Const != null) {
                        PaperReadWrite_ReFreshThisCache(strid_CurrEduCls);
                        return objPaperReadWrite_Const;
                    }
                }
                return null;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperRWId, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
        }
        return null;
    }
    exports.PaperReadWrite_GetObjByPaperRWId_Cache = PaperReadWrite_GetObjByPaperRWId_Cache;
    /**
     * 根据关键字获取相关对象, 从localStorage缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjByKeyId_localStorage)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function PaperReadWrite_GetObjByPaperRWId_localStorage(strPaperRWId) {
        const strThisFuncName = "GetObjByPaperRWId_localStorage";
        if ((0, clsString_js_2.IsNullOrEmpty)(strPaperRWId) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strPaperRWId]不能为空！(In clsPaperReadWriteWApi.GetObjByPaperRWId_localStorage)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strPaperRWId.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strPaperRWId]的长度:[{0}]不正确！(clsPaperReadWriteWApi.GetObjByPaperRWId_localStorage)", strPaperRWId.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strPaperRWId);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObj = localStorage.getItem(strKey);
            const objPaperReadWrite_Cache = JSON.parse(strTempObj);
            return objPaperReadWrite_Cache;
        }
        try {
            const objPaperReadWrite = await PaperReadWrite_GetObjByPaperRWIdAsync(strPaperRWId);
            if (objPaperReadWrite != null) {
                localStorage.setItem(strKey, JSON.stringify(objPaperReadWrite));
                const strInfo = (0, clsString_js_2.Format)("Key:[${ strKey}]的缓存已经建立!");
                console.log(strInfo);
                return objPaperReadWrite;
            }
            return objPaperReadWrite;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取相应的对象不成功!(in {2}.{3})", e, strPaperRWId, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
            return;
        }
    }
    exports.PaperReadWrite_GetObjByPaperRWId_localStorage = PaperReadWrite_GetObjByPaperRWId_localStorage;
    /**
     * 修改在缓存对象列表中的对象, 与后台数据库无关.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateObjInLst_Cache)
     * @param objPaperReadWrite:所给的对象
     * @returns 对象
    */
    async function PaperReadWrite_UpdateObjInLst_Cache(objPaperReadWrite, strid_CurrEduCls) {
        const strThisFuncName = "UpdateObjInLst_Cache";
        try {
            const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
            const obj = arrPaperReadWriteObjLst_Cache.find(x => x.readerId == objPaperReadWrite.readerId && x.paperId == objPaperReadWrite.paperId);
            if (obj != null) {
                objPaperReadWrite.paperRWId = obj.paperRWId;
                (0, clsCommFunc4Web_js_1.ObjectAssign)(obj, objPaperReadWrite);
            }
            else {
                arrPaperReadWriteObjLst_Cache.push(objPaperReadWrite);
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n在列表中修改对象不成功!(in {1}.{2})", e, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
    }
    exports.PaperReadWrite_UpdateObjInLst_Cache = PaperReadWrite_UpdateObjInLst_Cache;
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
    async function PaperReadWrite_func(strInFldName, strOutFldName, strInValue, strid_CurrEduCls_C) {
        //const strThisFuncName = "func";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperReadWriteWApi.func)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperReadWriteWApi.func)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName != clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if (clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.AttributeName.indexOf(strOutFldName) == -1) {
            const strMsg = (0, clsString_js_2.Format)("输出字段名:[{0}]不正确，不在输出字段范围之内!({1})", strOutFldName, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.AttributeName.join(','));
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strPaperRWId = strInValue;
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return "";
        }
        const objPaperReadWrite = await PaperReadWrite_GetObjByPaperRWId_Cache(strPaperRWId, strid_CurrEduCls_C);
        if (objPaperReadWrite == null)
            return "";
        if (objPaperReadWrite.GetFldValue(strOutFldName) == null)
            return "";
        return objPaperReadWrite.GetFldValue(strOutFldName).toString();
    }
    exports.PaperReadWrite_func = PaperReadWrite_func;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperReadWrite_SortFun_Defa(a, b) {
        const strThisFuncName = "SortFun_Defa";
        return a.paperRWId.localeCompare(b.paperRWId);
    }
    exports.PaperReadWrite_SortFun_Defa = PaperReadWrite_SortFun_Defa;
    /**
     * 排序函数。根据表对象中随机两个字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFun)
     * @param  a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperReadWrite_SortFun_Defa_2Fld(a, b) {
        const strThisFuncName = "SortFun_Defa_2Fld";
        if (a.readerId == b.readerId)
            return a.paperId.localeCompare(b.paperId);
        else
            return a.readerId.localeCompare(b.readerId);
    }
    exports.PaperReadWrite_SortFun_Defa_2Fld = PaperReadWrite_SortFun_Defa_2Fld;
    /**
     * 排序函数。根据关键字字段的值进行比较
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_SortFunByKey)
     * @param a:比较的第1个对象
     * @param  b:比较的第1个对象
     * @returns 返回两个对象比较的结果
    */
    function PaperReadWrite_SortFunByKey(strKey, AscOrDesc) {
        const strThisFuncName = "SortFunByKey";
        let strMsg = "";
        if (AscOrDesc == "Asc" || AscOrDesc == "") {
            switch (strKey) {
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId:
                    return (a, b) => {
                        return a.paperRWId.localeCompare(b.paperRWId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ReaderId:
                    return (a, b) => {
                        if (a.readerId == null)
                            return -1;
                        if (b.readerId == null)
                            return 1;
                        return a.readerId.localeCompare(b.readerId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperId:
                    return (a, b) => {
                        if (a.paperId == null)
                            return -1;
                        if (b.paperId == null)
                            return 1;
                        return a.paperId.localeCompare(b.paperId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (a.researchQuestion == null)
                            return -1;
                        if (b.researchQuestion == null)
                            return 1;
                        return a.researchQuestion.localeCompare(b.researchQuestion);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_OperationTypeId:
                    return (a, b) => {
                        return a.operationTypeId.localeCompare(b.operationTypeId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate:
                    return (a, b) => {
                        return a.updDate.localeCompare(b.updDate);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Memo:
                    return (a, b) => {
                        if (a.memo == null)
                            return -1;
                        if (b.memo == null)
                            return 1;
                        return a.memo.localeCompare(b.memo);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsSubmit:
                    return (a, b) => {
                        if (a.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsPublic:
                    return (a, b) => {
                        if (a.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Submitter:
                    return (a, b) => {
                        if (a.submitter == null)
                            return -1;
                        if (b.submitter == null)
                            return 1;
                        return a.submitter.localeCompare(b.submitter);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (a.id_CurrEduCls == null)
                            return -1;
                        if (b.id_CurrEduCls == null)
                            return 1;
                        return a.id_CurrEduCls.localeCompare(b.id_CurrEduCls);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_SubVCount:
                    return (a, b) => {
                        return a.subVCount - b.subVCount;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_TeaCount:
                    return (a, b) => {
                        return a.teaCount - b.teaCount;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_CreateDate:
                    return (a, b) => {
                        if (a.createDate == null)
                            return -1;
                        if (b.createDate == null)
                            return 1;
                        return a.createDate.localeCompare(b.createDate);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ShareId:
                    return (a, b) => {
                        if (a.shareId == null)
                            return -1;
                        if (b.shareId == null)
                            return 1;
                        return a.shareId.localeCompare(b.shareId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdUser:
                    return (a, b) => {
                        if (a.updUser == null)
                            return -1;
                        if (b.updUser == null)
                            return 1;
                        return a.updUser.localeCompare(b.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperReadWrite]中不存在！(in ${exports.paperReadWrite_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
        else {
            switch (strKey) {
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId:
                    return (a, b) => {
                        return b.paperRWId.localeCompare(a.paperRWId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ReaderId:
                    return (a, b) => {
                        if (b.readerId == null)
                            return -1;
                        if (a.readerId == null)
                            return 1;
                        return b.readerId.localeCompare(a.readerId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperId:
                    return (a, b) => {
                        if (b.paperId == null)
                            return -1;
                        if (a.paperId == null)
                            return 1;
                        return b.paperId.localeCompare(a.paperId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ResearchQuestion:
                    return (a, b) => {
                        if (b.researchQuestion == null)
                            return -1;
                        if (a.researchQuestion == null)
                            return 1;
                        return b.researchQuestion.localeCompare(a.researchQuestion);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_OperationTypeId:
                    return (a, b) => {
                        return b.operationTypeId.localeCompare(a.operationTypeId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate:
                    return (a, b) => {
                        return b.updDate.localeCompare(a.updDate);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Memo:
                    return (a, b) => {
                        if (b.memo == null)
                            return -1;
                        if (a.memo == null)
                            return 1;
                        return b.memo.localeCompare(a.memo);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsSubmit:
                    return (a, b) => {
                        if (b.isSubmit == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsPublic:
                    return (a, b) => {
                        if (b.isPublic == true)
                            return 1;
                        else
                            return -1;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Submitter:
                    return (a, b) => {
                        if (b.submitter == null)
                            return -1;
                        if (a.submitter == null)
                            return 1;
                        return b.submitter.localeCompare(a.submitter);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_id_CurrEduCls:
                    return (a, b) => {
                        if (b.id_CurrEduCls == null)
                            return -1;
                        if (a.id_CurrEduCls == null)
                            return 1;
                        return b.id_CurrEduCls.localeCompare(a.id_CurrEduCls);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_SubVCount:
                    return (a, b) => {
                        return b.subVCount - a.subVCount;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_TeaCount:
                    return (a, b) => {
                        return b.teaCount - a.teaCount;
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_CreateDate:
                    return (a, b) => {
                        if (b.createDate == null)
                            return -1;
                        if (a.createDate == null)
                            return 1;
                        return b.createDate.localeCompare(a.createDate);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ShareId:
                    return (a, b) => {
                        if (b.shareId == null)
                            return -1;
                        if (a.shareId == null)
                            return 1;
                        return b.shareId.localeCompare(a.shareId);
                    };
                case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdUser:
                    return (a, b) => {
                        if (b.updUser == null)
                            return -1;
                        if (a.updUser == null)
                            return 1;
                        return b.updUser.localeCompare(a.updUser);
                    };
                default:
                    strMsg = `字段名:[${strKey}]在表对象:[PaperReadWrite]中不存在！(in ${exports.paperReadWrite_ConstructorName}.${strThisFuncName})`;
                    console.error(strMsg);
                    break;
            }
        }
    }
    exports.PaperReadWrite_SortFunByKey = PaperReadWrite_SortFunByKey;
    /**
     * 过滤函数。根据关键字字段的值与给定值进行比较，返回是否相等
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_FilterFunByKey)
     * @param strKey:比较的关键字段名称
     * @param value:给定值
     * @returns 返回对象的字段值是否等于给定值
    */
    async function PaperReadWrite_FilterFunByKey(strKey, value) {
        const strThisFuncName = "FilterFunByKey";
        let strMsg = "";
        switch (strKey) {
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId:
                return (obj) => {
                    return obj.paperRWId === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ReaderId:
                return (obj) => {
                    return obj.readerId === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperId:
                return (obj) => {
                    return obj.paperId === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ResearchQuestion:
                return (obj) => {
                    return obj.researchQuestion === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_OperationTypeId:
                return (obj) => {
                    return obj.operationTypeId === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate:
                return (obj) => {
                    return obj.updDate === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Memo:
                return (obj) => {
                    return obj.memo === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsSubmit:
                return (obj) => {
                    return obj.isSubmit === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsPublic:
                return (obj) => {
                    return obj.isPublic === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Submitter:
                return (obj) => {
                    return obj.submitter === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_id_CurrEduCls:
                return (obj) => {
                    return obj.id_CurrEduCls === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_SubVCount:
                return (obj) => {
                    return obj.subVCount === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_TeaCount:
                return (obj) => {
                    return obj.teaCount === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_CreateDate:
                return (obj) => {
                    return obj.createDate === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ShareId:
                return (obj) => {
                    return obj.shareId === value;
                };
            case clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdUser:
                return (obj) => {
                    return obj.updUser === value;
                };
            default:
                strMsg = `字段名:[${strKey}]在表对象:[PaperReadWrite]中不存在！(in ${exports.paperReadWrite_ConstructorName}.${strThisFuncName})`;
                console.error(strMsg);
                break;
        }
    }
    exports.PaperReadWrite_FilterFunByKey = PaperReadWrite_FilterFunByKey;
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
    async function PaperReadWrite_funcKey(strInFldName, strInValue, strComparisonOp, strid_CurrEduCls_C) {
        //const strThisFuncName = "funcKey";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls_C) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls_C]不能为空！(In clsPaperReadWriteWApi.funcKey)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls_C.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls_C]的长度:[{0}]不正确！(clsPaperReadWriteWApi.funcKey)", strid_CurrEduCls_C.length);
            console.error(strMsg);
            throw (strMsg);
        }
        if (strInFldName == clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId) {
            const strMsg = (0, clsString_js_2.Format)("输入字段名:[{0}]不正确, 不能为关键字段!", strInFldName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(strInValue) == true) {
            return [];
        }
        const arrPaperReadWrite = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls_C);
        if (arrPaperReadWrite == null)
            return [];
        let arrPaperReadWrite_Sel = arrPaperReadWrite;
        const strType = typeof (strInValue);
        switch (strType) {
            case "string":
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01: // " = "
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName).toString() == strInValue.toString());
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.Like_03:
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName).toString().indexOf(strInValue.toString()) != -1);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.In_04:
                        const arrValues = strInValue.split(',');
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strInFldName).toString()) != -1);
                        break;
                }
                break;
            case "boolean":
                if (strInValue == null)
                    return [];
                if (strComparisonOp == enumComparisonOp_js_1.enumComparisonOp.Equal_01) {
                    arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                }
                break;
            case "number":
                if (Number(strInValue) == 0)
                    return [];
                switch (strComparisonOp) {
                    case enumComparisonOp_js_1.enumComparisonOp.Equal_01:
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) == strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotEqual_02:
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) != strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotLessThan_05: //" >= ":
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) >= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.NotGreaterThan_06: //" <= ":
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.GreaterThan_07: //" > ":
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) > strInValue);
                        break;
                    case enumComparisonOp_js_1.enumComparisonOp.LessThan_08: //" < ":
                        arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strInFldName) <= strInValue);
                        break;
                }
                break;
        }
        if (arrPaperReadWrite_Sel.length == 0)
            return [];
        return arrPaperReadWrite_Sel.map(x => x.paperRWId);
    }
    exports.PaperReadWrite_funcKey = PaperReadWrite_funcKey;
    /**
    * 根据条件获取满足条件的第一条记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstIdAsync)
    * @param strWhereCond:条件
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperReadWrite_GetFirstIDAsync(strWhereCond) {
        const strThisFuncName = "GetFirstIDAsync";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetFirstIDAsync = PaperReadWrite_GetFirstIDAsync;
    /**
     * 根据条件获取相应的记录对象列表
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstId)
     * @param strWhereCond:条件
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回的第一条记录的关键字值
    */
    async function PaperReadWrite_GetFirstID(strWhereCond, cb, errorCb) {
        const strThisFuncName = "GetFirstID";
        const strAction = "GetFirstID";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetFirstID = PaperReadWrite_GetFirstID;
    /**
    * 根据条件获取满足条件的第一条记录对象
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetFirstObjAsync)
    * @param strWhereCond:条件
    * @returns 第一条记录对象
    **/
    async function PaperReadWrite_GetFirstObjAsync(strWhereCond) {
        const strThisFuncName = "GetFirstObjAsync";
        const strAction = "GetFirstObj";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const objPaperReadWrite = PaperReadWrite_GetObjFromJsonObj(returnObj);
                return objPaperReadWrite;
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetFirstObjAsync = PaperReadWrite_GetFirstObjAsync;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_ClientCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_ClientCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_ClientCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (CacheHelper_js_1.CacheHelper.Exsits(strKey)) {
            //缓存存在，直接返回
            const arrPaperReadWriteExObjLst_Cache = CacheHelper_js_1.CacheHelper.Get(strKey);
            const arrPaperReadWriteObjLst_T = PaperReadWrite_GetObjLstByJSONObjLst(arrPaperReadWriteExObjLst_Cache);
            return arrPaperReadWriteObjLst_T;
        }
        try {
            const arrPaperReadWriteExObjLst = await PaperReadWrite_GetObjLstAsync(strWhereCond);
            CacheHelper_js_1.CacheHelper.Add(strKey, arrPaperReadWriteExObjLst);
            const strInfo = (0, clsString_js_2.Format)("[ClientCache]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperReadWriteExObjLst.length);
            console.log(strInfo);
            return arrPaperReadWriteExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperReadWrite_GetObjLst_ClientCache = PaperReadWrite_GetObjLst_ClientCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_localStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperReadWriteExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperReadWriteObjLst_T = PaperReadWrite_GetObjLstByJSONObjLst(arrPaperReadWriteExObjLst_Cache);
            return arrPaperReadWriteObjLst_T;
        }
        try {
            const arrPaperReadWriteExObjLst = await PaperReadWrite_GetObjLstAsync(strWhereCond);
            localStorage.setItem(strKey, JSON.stringify(arrPaperReadWriteExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[localStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperReadWriteExObjLst.length);
            console.log(strInfo);
            return arrPaperReadWriteExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从本地缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperReadWrite_GetObjLst_localStorage = PaperReadWrite_GetObjLst_localStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.如果本地不存在就返回null，不会去访问WebApi获取数据。
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_localStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_localStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_localStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(localStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = localStorage.getItem(strKey);
            const arrPaperReadWriteObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperReadWriteObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperReadWrite_GetObjLst_localStorage_PureCache = PaperReadWrite_GetObjLst_localStorage_PureCache;
    /**
    * 根据条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstAsync)
    * @param strWhereCond:条件
    * @returns 获取的相应对象列表
    **/
    async function PaperReadWrite_GetObjLstAsync(strWhereCond) {
        const strThisFuncName = "GetObjLstAsync";
        const strAction = "GetObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.get(strUrl, {
                params: { "strWhereCond": strWhereCond }
            });
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetObjLstAsync = PaperReadWrite_GetObjLstAsync;
    /**
    * 获取本地sessionStorage缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_sessionStorage(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage";
        //初始化列表缓存
        let strWhereCond = "1=1";
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.WhereFormat) == false) {
            strWhereCond = (0, clsString_js_2.Format)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.WhereFormat, strid_CurrEduCls);
        }
        else {
            strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        }
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if ((0, clsString_js_2.IsNullOrEmpty)(clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheAddiCondition) == false) {
            strWhereCond += (0, clsString_js_2.Format)(" and {0}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheAddiCondition);
        }
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperReadWriteExObjLst_Cache = JSON.parse(strTempObjLst);
            const arrPaperReadWriteObjLst_T = PaperReadWrite_GetObjLstByJSONObjLst(arrPaperReadWriteExObjLst_Cache);
            return arrPaperReadWriteObjLst_T;
        }
        try {
            const arrPaperReadWriteExObjLst = await PaperReadWrite_GetObjLstAsync(strWhereCond);
            sessionStorage.setItem(strKey, JSON.stringify(arrPaperReadWriteExObjLst));
            const strInfo = (0, clsString_js_2.Format)("[sessionStorage]Key:[{0}]的缓存已经建立，对象列表数：{1}!", strKey, arrPaperReadWriteExObjLst.length);
            console.log(strInfo);
            return arrPaperReadWriteExObjLst;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("从缓存中获取所有对象列表出错. \n服务器错误：{0}.(in {1}.{2})", e, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw (strMsg);
        }
    }
    exports.PaperReadWrite_GetObjLst_sessionStorage = PaperReadWrite_GetObjLst_sessionStorage;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_sessionStorage_PureCache)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls) {
        const strThisFuncName = "GetObjLst_sessionStorage_PureCache";
        //初始化列表缓存
        let strWhereCond = "1=1";
        strWhereCond = (0, clsString_js_2.Format)("id_CurrEduCls='{0}'", strid_CurrEduCls);
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        if (strKey == "") {
            console.error("关键字为空！不正确");
            throw new Error("关键字为空！不正确");
        }
        if (Object.prototype.hasOwnProperty.call(sessionStorage, strKey)) {
            //缓存存在，直接返回
            const strTempObjLst = sessionStorage.getItem(strKey);
            const arrPaperReadWriteObjLst_Cache = JSON.parse(strTempObjLst);
            return arrPaperReadWriteObjLst_Cache;
        }
        else
            return null;
    }
    exports.PaperReadWrite_GetObjLst_sessionStorage_PureCache = PaperReadWrite_GetObjLst_sessionStorage_PureCache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_CacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_Cache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[id_CurrEduCls]不能为空！(in clsPaperReadWriteWApi.PaperReadWrite_GetObjLst_Cache() )");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(in clsPaperReadWriteWApi.PaperReadWrite_GetObjLst_Cache() )", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        let arrPaperReadWriteObjLst_Cache;
        switch (clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_sessionStorage(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_localStorage(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
            default:
                arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_ClientCache(strid_CurrEduCls);
                break;
        }
        const arrPaperReadWriteObjLst = PaperReadWrite_GetObjLstByJSONObjLst(arrPaperReadWriteObjLst_Cache);
        return arrPaperReadWriteObjLst_Cache;
    }
    exports.PaperReadWrite_GetObjLst_Cache = PaperReadWrite_GetObjLst_Cache;
    /**
    * 获取本地缓存中的对象列表，是整个表中的全部记录，也可是表中某缓存分类的全部记录.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLst_PureCacheAsync)
    * @returns 从本地缓存中获取的对象列表
    **/
    async function PaperReadWrite_GetObjLst_PureCache(strid_CurrEduCls) {
        //const strThisFuncName = "GetObjLst_PureCache";
        let arrPaperReadWriteObjLst_Cache;
        switch (clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheModeId) {
            case "04": //sessionStorage
                arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_sessionStorage_PureCache(strid_CurrEduCls);
                break;
            case "03": //localStorage
                arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_localStorage_PureCache(strid_CurrEduCls);
                break;
            case "02": //ClientCache
                arrPaperReadWriteObjLst_Cache = null;
                break;
            default:
                arrPaperReadWriteObjLst_Cache = null;
                break;
        }
        return arrPaperReadWriteObjLst_Cache;
    }
    exports.PaperReadWrite_GetObjLst_PureCache = PaperReadWrite_GetObjLst_PureCache;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetSubObjLst_Cache)
     * @param objstrPaperRWId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperReadWrite_GetSubObjLst_Cache(objPaperReadWrite_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetSubObjLst_Cache";
        const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        let arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache;
        if (objPaperReadWrite_Cond.sf_FldComparisonOp == null || objPaperReadWrite_Cond.sf_FldComparisonOp == "")
            return arrPaperReadWrite_Sel;
        const dicFldComparisonOp = JSON.parse(objPaperReadWrite_Cond.sf_FldComparisonOp);
        //console.log("clsPaperReadWriteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperReadWrite_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]缓存对象列表中获取子集对象不成功!(in {2}.{3})", e, JSON.stringify(objPaperReadWrite_Cond), exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperReadWrite_GetSubObjLst_Cache = PaperReadWrite_GetSubObjLst_Cache;
    /**
    * 根据关键字列表获取相关对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLstAsync)
    * @param arrPaperRWId:关键字列表
    * @returns 对象列表
    **/
    async function PaperReadWrite_GetObjLstByPaperRWIdLstAsync(arrPaperRWId) {
        const strThisFuncName = "GetObjLstByPaperRWIdLstAsync";
        const strAction = "GetObjLstByPaperRWIdLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperRWId);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetObjLstByPaperRWIdLstAsync = PaperReadWrite_GetObjLstByPaperRWIdLstAsync;
    /**
     * 根据关键字列表获取相关对象列表, 从缓存中获取.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByKeyLst_Cache)
     * @param arrstrPaperRWIdLst:关键字列表
     * @returns 对象列表
    */
    async function PaperReadWrite_GetObjLstByPaperRWIdLst_Cache(arrPaperRWIdLst, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPaperRWIdLst_Cache";
        try {
            const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
            const arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache.filter(x => arrPaperRWIdLst.indexOf(x.paperRWId) > -1);
            return arrPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据关键字:[{1}]获取对象列表不成功!(in {2}.{3})", e, arrPaperRWIdLst.join(","), exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
    }
    exports.PaperReadWrite_GetObjLstByPaperRWIdLst_Cache = PaperReadWrite_GetObjLstByPaperRWIdLst_Cache;
    /**
    * 根据顶部条件获取相应的记录对象列表
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetTopObjLstAsync)
    * @param objTopPara:获取顶部对象列表的参数对象
    * @returns 获取的相应对象列表
    **/
    async function PaperReadWrite_GetTopObjLstAsync(objTopPara) {
        const strThisFuncName = "GetTopObjLstAsync";
        const strAction = "GetTopObjLst";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objTopPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetTopObjLstAsync = PaperReadWrite_GetTopObjLstAsync;
    /**
    * 根据范围条件获取相应的记录对象列表，获取某范围的记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByRangeAsync)
    * @param objRangePara:根据范围获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperReadWrite_GetObjLstByRangeAsync(objRangePara) {
        const strThisFuncName = "GetObjLstByRangeAsync";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objRangePara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetObjLstByRangeAsync = PaperReadWrite_GetObjLstByRangeAsync;
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
    async function PaperReadWrite_GetObjLstByRange(intMinNum, intMaxNum, strWhereCond, strOrderBy = "", cb, errorCb) {
        const strThisFuncName = "GetObjLstByRange";
        const strAction = "GetObjLstByRange";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetObjLstByRange = PaperReadWrite_GetObjLstByRange;
    /**
     * 根据分页条件从缓存中获取分页对象列表，只获取一页.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPager_Cache)
     * @param objPagerPara:分页参数结构
     * @returns 对象列表
    */
    async function PaperReadWrite_GetObjLstByPager_Cache(objPagerPara, strid_CurrEduCls) {
        const strThisFuncName = "GetObjLstByPager_Cache";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperReadWriteObjLst_Cache.length == 0)
            return arrPaperReadWriteObjLst_Cache;
        let arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache;
        const obj_Cond = JSON.parse(objPagerPara.whereCond);
        const objPaperReadWrite_Cond = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperReadWrite_Cond, obj_Cond);
        let dicFldComparisonOp = {};
        if (obj_Cond.sf_FldComparisonOp != "") {
            dicFldComparisonOp = JSON.parse(obj_Cond.sf_FldComparisonOp);
        }
        //console.log("clsPaperReadWriteWApi->GetObjLstByPager_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(obj_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperReadWrite_Sel.length == 0)
                return arrPaperReadWrite_Sel;
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
                arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.sort(PaperReadWrite_SortFunByKey(strSortFld, strSortType));
            }
            else {
                //如果排序字段名[OrderBy]为空，就调用排序函数
                arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.sort(objPagerPara.sortFun);
            }
            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.slice(intStart, intEnd);
            return arrPaperReadWrite_Sel;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]获取分页对象列表不成功!(In {2}.{3})", e, objPagerPara.whereCond, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return new Array();
    }
    exports.PaperReadWrite_GetObjLstByPager_Cache = PaperReadWrite_GetObjLstByPager_Cache;
    /**
    * 根据分页条件获取相应的记录对象列表，只获取一页
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetObjLstByPagerAsync)
    * @param objPagerPara:分页获取对象列表的参数对象
    * @returns 获取的相应记录对象列表
    **/
    async function PaperReadWrite_GetObjLstByPagerAsync(objPagerPara) {
        const strThisFuncName = "GetObjLstByPagerAsync";
        if (objPagerPara.pageIndex == 0)
            return new Array();
        const strAction = "GetObjLstByPager";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPagerPara);
            const data = response.data;
            if (data.errorId == 0) {
                const returnObjLst = data.returnObjLst;
                if (returnObjLst == null) {
                    const strNullInfo = (0, clsString_js_2.Format)("获取数据为null, 请注意!(in {0}.{1})", exports.paperReadWrite_ConstructorName, strThisFuncName);
                    console.error(strNullInfo);
                    throw (strNullInfo);
                }
                //console.log(returnObjLst);
                const arrObjLst = PaperReadWrite_GetObjLstByJSONObjLst(returnObjLst);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetObjLstByPagerAsync = PaperReadWrite_GetObjLstByPagerAsync;
    /**
    * 调用WebApi来删除记录，根据关键字来删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelRecordAsync)
    * @param strPaperRWId:关键字
    * @returns 获取删除的结果
    **/
    async function PaperReadWrite_DelRecordAsync(strPaperRWId) {
        const strThisFuncName = "DelRecordAsync";
        const strAction = "DelRecord";
        let strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        strUrl = (0, clsString_js_2.Format)("{0}/?Id={1}", strUrl, strPaperRWId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_DelRecordAsync = PaperReadWrite_DelRecordAsync;
    /**
    * 根据关键字列表删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordAsync)
    * @param arrPaperRWId:关键字列表
    * @returns 实际删除记录的个数
    **/
    async function PaperReadWrite_DelPaperReadWritesAsync(arrPaperRWId) {
        const strThisFuncName = "DelPaperReadWritesAsync";
        const strAction = "DelPaperReadWrites";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, arrPaperRWId);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_DelPaperReadWritesAsync = PaperReadWrite_DelPaperReadWritesAsync;
    /**
    * 根据条件删除记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_DelMultiRecordByCondAsync)
    * @returns 实际删除记录的个数
    **/
    async function PaperReadWrite_DelPaperReadWritesByCondAsync(strWhereCond) {
        const strThisFuncName = "DelPaperReadWritesByCondAsync";
        const strAction = "DelPaperReadWritesByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_DelPaperReadWritesByCondAsync = PaperReadWrite_DelPaperReadWritesByCondAsync;
    /**
    * 调用WebApi来添加记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordAsync)
    * @param objPaperReadWriteEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperReadWrite_AddNewRecordAsync(objPaperReadWriteEN) {
        const strThisFuncName = "AddNewRecordAsync";
        const strAction = "AddNewRecord";
        //var strJSON = JSON.stringify(objPaperReadWriteEN);
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperReadWriteEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_AddNewRecordAsync = PaperReadWrite_AddNewRecordAsync;
    /**
    * 调用WebApi来添加记录，关键字用最大关键字，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithMaxIdAsync)
    * @param objPaperReadWriteEN:需要添加的对象
    * @returns 获取相应的记录的对象
    **/
    async function PaperReadWrite_AddNewRecordWithMaxIdAsync(objPaperReadWriteEN) {
        const strThisFuncName = "AddNewRecordWithMaxIdAsync";
        const strAction = "AddNewRecordWithMaxId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperReadWriteEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_AddNewRecordWithMaxIdAsync = PaperReadWrite_AddNewRecordWithMaxIdAsync;
    /**
    * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字和自增关键字)
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKeyAsync)
    * @param objPaperReadWriteEN:需要添加的表对象
    * @returns 返回新添加记录的关键字
    **/
    async function PaperReadWrite_AddNewRecordWithReturnKeyAsync(objPaperReadWriteEN) {
        const strThisFuncName = "AddNewRecordWithReturnKeyAsync";
        const strAction = "AddNewRecordWithReturnKey";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperReadWriteEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_AddNewRecordWithReturnKeyAsync = PaperReadWrite_AddNewRecordWithReturnKeyAsync;
    /**
     * 把表对象添加到数据库中,并且返回该记录的关键字(针对Identity关键字)
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_AddNewRecordWithReturnKey)
     * @param objPaperReadWriteEN:需要添加的表对象
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 返回新添加记录的关键字
    */
    async function PaperReadWrite_AddNewRecordWithReturnKey(objPaperReadWriteEN, cb, errorCb) {
        const strThisFuncName = "AddNewRecordWithReturnKey";
        const strAction = "AddNewRecordWithReturnKey";
        if (objPaperReadWriteEN.paperRWId === null || objPaperReadWriteEN.paperRWId === "") {
            const strMsg = "需要的对象的关键字为空，不能添加!";
            console.error(strMsg);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperReadWriteEN);
            const data = response.data;
            cb(data);
        }
        catch (error) {
            console.error(error);
            if (error.statusText == undefined) {
                throw error;
            }
            if (error.statusText == "error") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_AddNewRecordWithReturnKey = PaperReadWrite_AddNewRecordWithReturnKey;
    /**
    * 调用WebApi来修改记录，数据传递使用JSON串
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateRecordAsync)
    * @param objPaperReadWriteEN:需要添加的对象
    * @returns 获取修改是否成功？
    **/
    async function PaperReadWrite_UpdateRecordAsync(objPaperReadWriteEN) {
        const strThisFuncName = "UpdateRecordAsync";
        const strAction = "UpdateRecord";
        if (objPaperReadWriteEN.sf_UpdFldSetStr === undefined || objPaperReadWriteEN.sf_UpdFldSetStr === null || objPaperReadWriteEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperReadWriteEN.paperRWId);
            throw strMsg;
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        try {
            const response = await axios_1.default.post(strUrl, objPaperReadWriteEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_UpdateRecordAsync = PaperReadWrite_UpdateRecordAsync;
    /**
    * 根据条件来修改记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_UpdateWithConditionAsync)
    * @param objPaperReadWriteEN:需要修改的对象
    * @param strWhereCond:条件串
    * @returns 返回的第一条记录的关键字值
    **/
    async function PaperReadWrite_UpdateWithConditionAsync(objPaperReadWriteEN, strWhereCond) {
        const strThisFuncName = "UpdateWithConditionAsync";
        const strAction = "UpdateWithCondition";
        if (objPaperReadWriteEN.sf_UpdFldSetStr === undefined || objPaperReadWriteEN.sf_UpdFldSetStr === null || objPaperReadWriteEN.sf_UpdFldSetStr === "") {
            const strMsg = (0, clsString_js_2.Format)("对象(关键字: {0})的【修改字段集】为空，不能修改!", objPaperReadWriteEN.paperRWId);
            throw new Error(strMsg);
        }
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
        objPaperReadWriteEN.whereCond = strWhereCond;
        try {
            const response = await axios_1.default.post(strUrl, objPaperReadWriteEN);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_UpdateWithConditionAsync = PaperReadWrite_UpdateWithConditionAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取子集.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecord_Cache)
     * @param objstrPaperRWId_Cond:条件对象
     * @returns 对象列表子集
    */
    async function PaperReadWrite_IsExistRecord_Cache(objPaperReadWrite_Cond, strid_CurrEduCls) {
        const strThisFuncName = "IsExistRecord_Cache";
        const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperReadWriteObjLst_Cache == null)
            return false;
        let arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache;
        if (objPaperReadWrite_Cond.sf_FldComparisonOp == null || objPaperReadWrite_Cond.sf_FldComparisonOp == "")
            return arrPaperReadWrite_Sel.length > 0 ? true : false;
        const dicFldComparisonOp = JSON.parse(objPaperReadWrite_Cond.sf_FldComparisonOp);
        //console.log("clsPaperReadWriteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperReadWrite_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            if (arrPaperReadWrite_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据条件:[{0}]判断是否存在不成功!(in {1}.{2})", JSON.stringify(objPaperReadWrite_Cond), exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return false;
    }
    exports.PaperReadWrite_IsExistRecord_Cache = PaperReadWrite_IsExistRecord_Cache;
    /**
    * 根据条件获取是否存在相应的记录？
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistRecordAsync)
    * @param strWhereCond:条件
    * @returns 是否存在记录？
    **/
    async function PaperReadWrite_IsExistRecordAsync(strWhereCond) {
        const strThisFuncName = "IsExistRecordAsync";
        const strAction = "IsExistRecord";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_IsExistRecordAsync = PaperReadWrite_IsExistRecordAsync;
    /**
     * 根据关键字判断是否存在记录
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist)
     * @param strPaperRWId:关键字
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 是否存在?存在返回True
    */
    async function PaperReadWrite_IsExist(strPaperRWId, cb, errorCb) {
        const strThisFuncName = "IsExist";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_IsExist = PaperReadWrite_IsExist;
    /**
     * 根据关键字判断是否存在记录, 从本地缓存中判断.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExist_Cache)
     * @param strPaperRWId:所给的关键字
     * @returns 对象
    */
    async function PaperReadWrite_IsExist_Cache(strPaperRWId, strid_CurrEduCls) {
        const strThisFuncName = "IsExist_Cache";
        const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperReadWriteObjLst_Cache == null)
            return false;
        try {
            const arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache.filter(x => x.paperRWId == strPaperRWId);
            if (arrPaperReadWrite_Sel.length > 0) {
                return true;
            }
            else {
                return false;
            }
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("根据关键字:[{0}]判断是否存在不成功!(in {1}.{2})", strPaperRWId, exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            alert(strMsg);
        }
        return false;
    }
    exports.PaperReadWrite_IsExist_Cache = PaperReadWrite_IsExist_Cache;
    /**
    * 根据关键字判断是否存在记录
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_IsExistAsync)
    * @param strPaperRWId:关键字
    * @returns 是否存在?存在返回True
    **/
    async function PaperReadWrite_IsExistAsync(strPaperRWId) {
        const strThisFuncName = "IsExistAsync";
        //检测记录是否存在
        const strAction = "IsExist";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_IsExistAsync = PaperReadWrite_IsExistAsync;
    /**
    * 获取某一条件的记录数
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCondAsync)
    * @param strWhereCond:条件
    * @returns 获取某一条件的记录数
    **/
    async function PaperReadWrite_GetRecCountByCondAsync(strWhereCond) {
        const strThisFuncName = "GetRecCountByCondAsync";
        const strAction = "GetRecCountByCond";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetRecCountByCondAsync = PaperReadWrite_GetRecCountByCondAsync;
    /**
     * 根据条件对象, 从缓存的对象列表中获取记录数.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetRecCountByCond_Cache)
     * @param objPaperReadWrite_Cond:条件对象
     * @returns 对象列表记录数
    */
    async function PaperReadWrite_GetRecCountByCond_Cache(objPaperReadWrite_Cond, strid_CurrEduCls) {
        const strThisFuncName = "GetRecCountByCond_Cache";
        const arrPaperReadWriteObjLst_Cache = await PaperReadWrite_GetObjLst_Cache(strid_CurrEduCls);
        if (arrPaperReadWriteObjLst_Cache == null)
            return 0;
        let arrPaperReadWrite_Sel = arrPaperReadWriteObjLst_Cache;
        if (objPaperReadWrite_Cond.sf_FldComparisonOp == null || objPaperReadWrite_Cond.sf_FldComparisonOp == "")
            return arrPaperReadWrite_Sel.length;
        const dicFldComparisonOp = JSON.parse(objPaperReadWrite_Cond.sf_FldComparisonOp);
        //console.log("clsPaperReadWriteWApi->GetSubObjLst_Cache->dicFldComparisonOp:");
        //console.log(dicFldComparisonOp);
        try {
            const sstrKeys = (0, clsCommFunc4Web_js_1.GetObjKeys)(objPaperReadWrite_Cond);
            //console.log(sstrKeys);
            for (const strKey of sstrKeys) {
                if (Object.prototype.hasOwnProperty.call(dicFldComparisonOp, strKey) == false)
                    continue;
                arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) != null);
                const strComparisonOp = dicFldComparisonOp[strKey];
                const strValue = objPaperReadWrite_Cond.GetFldValue(strKey);
                const strType = typeof (strValue);
                switch (strType) {
                    case "string":
                        if (strValue == null)
                            continue;
                        if (strValue == "")
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString() == strValue.toString());
                        }
                        else if (strComparisonOp == "like") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().indexOf(strValue.toString()) != -1);
                        }
                        else if (strComparisonOp == "length greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length > Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not greater") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length <= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length not less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length >= Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length less") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length < Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "length equal") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey).toString().length == Number(strValue.toString()));
                        }
                        else if (strComparisonOp == "in") {
                            const arrValues = strValue.toString().split(',');
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => arrValues.indexOf(x.GetFldValue(strKey).toString()) != -1);
                        }
                        break;
                    case "boolean":
                        if (strValue == null)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        break;
                    case "number":
                        if (Number(strValue) == 0)
                            continue;
                        if (strComparisonOp == "=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) == strValue);
                        }
                        else if (strComparisonOp == ">=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) >= strValue);
                        }
                        else if (strComparisonOp == "<=") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        else if (strComparisonOp == ">") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) > strValue);
                        }
                        else if (strComparisonOp == "<") {
                            arrPaperReadWrite_Sel = arrPaperReadWrite_Sel.filter(x => x.GetFldValue(strKey) <= strValue);
                        }
                        break;
                }
            }
            return arrPaperReadWrite_Sel.length;
        }
        catch (e) {
            const strMsg = (0, clsString_js_2.Format)("错误:[{0}]. \n根据条件:[{1}]从缓存对象列表中获取记录数不成功!(in {2}.{3})", e, JSON.stringify(objPaperReadWrite_Cond), exports.paperReadWrite_ConstructorName, strThisFuncName);
            console.error(strMsg);
            throw new Error(strMsg);
        }
        return 0;
    }
    exports.PaperReadWrite_GetRecCountByCond_Cache = PaperReadWrite_GetRecCountByCond_Cache;
    /**
    * 获取表的最大关键字
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdAsync)
    * @returns 获取表的最大关键字
    **/
    async function PaperReadWrite_GetMaxStrIdAsync() {
        const strThisFuncName = "GetMaxStrIdAsync";
        const strAction = "GetMaxStrId";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetMaxStrIdAsync = PaperReadWrite_GetMaxStrIdAsync;
    /*该表的关键字类型不是字符型带前缀自增，不需要生成获取最大关键字函数！*/
    /**
     * 根据前缀获取当前表关键字值的最大值,再加1,避免重复
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetMaxStrIdByPrefix)
     * @param mapParam:参数列表
     * @param cb:CallBack函数，用于显示正确结果数据
     * @param errorCb:CallBack函数，用于显示错误信息
     * @returns 获取当前表关键字值的最大值
    */
    async function PaperReadWrite_GetMaxStrIdByPrefix(strPrefix, cb, errorCb) {
        const strThisFuncName = "GetMaxStrIdByPrefix";
        const strAction = "GetMaxStrIdByPrefix";
        const strUrl = (0, clsSysPara4WebApi_js_1.GetWebApiUrl)(exports.paperReadWrite_Controller, strAction);
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
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}不成功！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else if (error.statusText == "Not Found") {
                const strInfo = (0, clsString_js_2.Format)("网络错误！访问地址:{0}可能不存在！(in {1}.{2})", strUrl, exports.paperReadWrite_ConstructorName, strThisFuncName);
                console.error(strInfo);
                throw (strInfo);
            }
            else {
                throw (error.statusText);
            }
        }
    }
    exports.PaperReadWrite_GetMaxStrIdByPrefix = PaperReadWrite_GetMaxStrIdByPrefix;
    /**
     * 获取WebApi的地址
     * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_GetWebApiUrl)
     * @returns 返回当前文件中Web服务的地址
    */
    function PaperReadWrite_GetWebApiUrl(strController, strAction) {
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
    exports.PaperReadWrite_GetWebApiUrl = PaperReadWrite_GetWebApiUrl;
    /**
    * 刷新缓存.把当前表的缓存以及该表相关视图的缓存清空.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshCache)
    **/
    function PaperReadWrite_ReFreshCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshCache";
        if ((0, clsString_js_2.IsNullOrEmpty)(strid_CurrEduCls) == true) {
            const strMsg = (0, clsString_js_2.Format)("参数:[strid_CurrEduCls]不能为空！(In clsPaperReadWriteWApi.clsPaperReadWriteWApi.ReFreshCache)");
            console.error(strMsg);
            throw (strMsg);
        }
        if (strid_CurrEduCls.length != 8) {
            const strMsg = (0, clsString_js_2.Format)("缓存分类变量:[strid_CurrEduCls]的长度:[{0}]不正确！(clsPaperReadWriteWApi.clsPaperReadWriteWApi.ReFreshCache)", strid_CurrEduCls.length);
            console.error(strMsg);
            throw (strMsg);
        }
        const strMsg = (0, clsString_js_2.Format)("刷新缓存成功！");
        console.trace(strMsg);
        // 静态的对象列表,用于清空相关缓存,针对记录较少,作为参数表可以使用
        const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
        switch (clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheModeId) {
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
        (0, clsvPaperReadWriteWApi_js_1.vPaperReadWrite_ReFreshThisCache)(strid_CurrEduCls);
    }
    exports.PaperReadWrite_ReFreshCache = PaperReadWrite_ReFreshCache;
    /**
    * 刷新本类中的缓存.
    * (AutoGCLib.WA_Access4TypeScript:Gen_4WA_Ts_ReFreshThisCache)
    **/
    function PaperReadWrite_ReFreshThisCache(strid_CurrEduCls) {
        const strThisFuncName = "ReFreshThisCache";
        if (clsSysPara4WebApi_js_1.clsSysPara4WebApi.spSetRefreshCacheOn == true) {
            const strKey = (0, clsString_js_2.Format)("{0}_{1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN._CurrTabName, strid_CurrEduCls);
            switch (clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.CacheModeId) {
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
    exports.PaperReadWrite_ReFreshThisCache = PaperReadWrite_ReFreshThisCache;
    /* 该表的下拉框功能没有设置，不需要生成下拉框绑定函数。*/
    /**
     * 检查对象字段值是否合法,1)检查是否可空;2)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperReadWrite_CheckPropertyNew(pobjPaperReadWriteEN) {
        //检查字段非空， 即数据表要求非常非空的字段，不能为空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.operationTypeId) === true) {
            throw new Error("(errid:Watl000058)字段[操作类型ID]不能为空(In 论文读写表)!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updDate) === true) {
            throw new Error("(errid:Watl000058)字段[修改日期]不能为空(In 论文读写表)!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperRWId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.paperRWId) > 8) {
            throw new Error("(errid:Watl000059)字段[课文阅读(paperRWId)]的长度不能超过8(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.paperRWId)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.readerId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.readerId) > 20) {
            throw new Error("(errid:Watl000059)字段[阅读者Id(readerId)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.readerId)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.paperId) > 8) {
            throw new Error("(errid:Watl000059)字段[论文Id(paperId)]的长度不能超过8(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.paperId)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.researchQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.researchQuestion) > 2000) {
            throw new Error("(errid:Watl000059)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.researchQuestion)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.operationTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000059)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.operationTypeId)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.updDate) > 20) {
            throw new Error("(errid:Watl000059)字段[修改日期(updDate)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.updDate)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.memo) > 1000) {
            throw new Error("(errid:Watl000059)字段[备注(memo)]的长度不能超过1000(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.memo)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.submitter) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.submitter) > 50) {
            throw new Error("(errid:Watl000059)字段[提交人(submitter)]的长度不能超过50(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.submitter)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000059)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.id_CurrEduCls)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.createDate) > 20) {
            throw new Error("(errid:Watl000059)字段[建立日期(createDate)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.createDate)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.shareId) > 2) {
            throw new Error("(errid:Watl000059)字段[分享Id(shareId)]的长度不能超过2(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.shareId)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.updUser) > 20) {
            throw new Error("(errid:Watl000059)字段[修改人(updUser)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.updUser)(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperRWId) == false && undefined !== pobjPaperReadWriteEN.paperRWId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.paperRWId) === false) {
            throw new Error("(errid:Watl000060)字段[课文阅读(paperRWId)]的值:[$(pobjPaperReadWriteEN.paperRWId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.readerId) == false && undefined !== pobjPaperReadWriteEN.readerId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.readerId) === false) {
            throw new Error("(errid:Watl000060)字段[阅读者Id(readerId)]的值:[$(pobjPaperReadWriteEN.readerId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperId) == false && undefined !== pobjPaperReadWriteEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.paperId) === false) {
            throw new Error("(errid:Watl000060)字段[论文Id(paperId)]的值:[$(pobjPaperReadWriteEN.paperId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.researchQuestion) == false && undefined !== pobjPaperReadWriteEN.researchQuestion && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.researchQuestion) === false) {
            throw new Error("(errid:Watl000060)字段[研究问题(researchQuestion)]的值:[$(pobjPaperReadWriteEN.researchQuestion)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.operationTypeId) == false && undefined !== pobjPaperReadWriteEN.operationTypeId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000060)字段[操作类型ID(operationTypeId)]的值:[$(pobjPaperReadWriteEN.operationTypeId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updDate) == false && undefined !== pobjPaperReadWriteEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.updDate) === false) {
            throw new Error("(errid:Watl000060)字段[修改日期(updDate)]的值:[$(pobjPaperReadWriteEN.updDate)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.memo) == false && undefined !== pobjPaperReadWriteEN.memo && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.memo) === false) {
            throw new Error("(errid:Watl000060)字段[备注(memo)]的值:[$(pobjPaperReadWriteEN.memo)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if (null != pobjPaperReadWriteEN.isSubmit && undefined !== pobjPaperReadWriteEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjPaperReadWriteEN.isSubmit) === false) {
            throw new Error("(errid:Watl000060)字段[是否提交(isSubmit)]的值:[$(pobjPaperReadWriteEN.isSubmit)], 非法，应该为布尔型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if (null != pobjPaperReadWriteEN.isPublic && undefined !== pobjPaperReadWriteEN.isPublic && clsString_js_1.tzDataType.isBoolean(pobjPaperReadWriteEN.isPublic) === false) {
            throw new Error("(errid:Watl000060)字段[是否公开(isPublic)]的值:[$(pobjPaperReadWriteEN.isPublic)], 非法，应该为布尔型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.submitter) == false && undefined !== pobjPaperReadWriteEN.submitter && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.submitter) === false) {
            throw new Error("(errid:Watl000060)字段[提交人(submitter)]的值:[$(pobjPaperReadWriteEN.submitter)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.id_CurrEduCls) == false && undefined !== pobjPaperReadWriteEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000060)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperReadWriteEN.id_CurrEduCls)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if (null != pobjPaperReadWriteEN.subVCount && undefined !== pobjPaperReadWriteEN.subVCount && clsString_js_1.tzDataType.isNumber(pobjPaperReadWriteEN.subVCount) === false) {
            throw new Error("(errid:Watl000060)字段[论文子观点数(subVCount)]的值:[$(pobjPaperReadWriteEN.subVCount)], 非法，应该为数值型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if (null != pobjPaperReadWriteEN.teaCount && undefined !== pobjPaperReadWriteEN.teaCount && clsString_js_1.tzDataType.isNumber(pobjPaperReadWriteEN.teaCount) === false) {
            throw new Error("(errid:Watl000060)字段[TeaCount(teaCount)]的值:[$(pobjPaperReadWriteEN.teaCount)], 非法，应该为数值型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.createDate) == false && undefined !== pobjPaperReadWriteEN.createDate && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.createDate) === false) {
            throw new Error("(errid:Watl000060)字段[建立日期(createDate)]的值:[$(pobjPaperReadWriteEN.createDate)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.shareId) == false && undefined !== pobjPaperReadWriteEN.shareId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.shareId) === false) {
            throw new Error("(errid:Watl000060)字段[分享Id(shareId)]的值:[$(pobjPaperReadWriteEN.shareId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updUser) == false && undefined !== pobjPaperReadWriteEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.updUser) === false) {
            throw new Error("(errid:Watl000060)字段[修改人(updUser)]的值:[$(pobjPaperReadWriteEN.updUser)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.paperId) != 8) {
            throw ("(errid:Watl000061)字段[论文Id]作为外键字段,长度应该为8(In 论文读写表)!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        //设置说明该对象已经检查过了，后面不需要再检查，即非法！
        pobjPaperReadWriteEN.SetIsCheckProperty(true);
    }
    exports.PaperReadWrite_CheckPropertyNew = PaperReadWrite_CheckPropertyNew;
    /**
     * 专业针对修改记录,检查对象字段值是否合法,1)检查字段值长度是否超长,如果出错就抛出错误.
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CheckPropertyNew)
    */
    function PaperReadWrite_CheckProperty4Update(pobjPaperReadWriteEN) {
        //检查字段长度， 若字符型字段长度超出规定的长度，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperRWId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.paperRWId) > 8) {
            throw new Error("(errid:Watl000062)字段[课文阅读(paperRWId)]的长度不能超过8(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.paperRWId)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.readerId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.readerId) > 20) {
            throw new Error("(errid:Watl000062)字段[阅读者Id(readerId)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.readerId)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.paperId) > 8) {
            throw new Error("(errid:Watl000062)字段[论文Id(paperId)]的长度不能超过8(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.paperId)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.researchQuestion) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.researchQuestion) > 2000) {
            throw new Error("(errid:Watl000062)字段[研究问题(researchQuestion)]的长度不能超过2000(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.researchQuestion)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.operationTypeId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.operationTypeId) > 4) {
            throw new Error("(errid:Watl000062)字段[操作类型ID(operationTypeId)]的长度不能超过4(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.operationTypeId)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.updDate) > 20) {
            throw new Error("(errid:Watl000062)字段[修改日期(updDate)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.updDate)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.memo) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.memo) > 1000) {
            throw new Error("(errid:Watl000062)字段[备注(memo)]的长度不能超过1000(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.memo)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.submitter) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.submitter) > 50) {
            throw new Error("(errid:Watl000062)字段[提交人(submitter)]的长度不能超过50(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.submitter)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.id_CurrEduCls) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.id_CurrEduCls) > 8) {
            throw new Error("(errid:Watl000062)字段[教学班流水号(id_CurrEduCls)]的长度不能超过8(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.id_CurrEduCls)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.createDate) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.createDate) > 20) {
            throw new Error("(errid:Watl000062)字段[建立日期(createDate)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.createDate)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.shareId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.shareId) > 2) {
            throw new Error("(errid:Watl000062)字段[分享Id(shareId)]的长度不能超过2(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.shareId)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updUser) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.updUser) > 20) {
            throw new Error("(errid:Watl000062)字段[修改人(updUser)]的长度不能超过20(In 论文读写表(PaperReadWrite))!值:$(pobjPaperReadWriteEN.updUser)(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        //检查字段的数据类型是否正确
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperRWId) == false && undefined !== pobjPaperReadWriteEN.paperRWId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.paperRWId) === false) {
            throw new Error("(errid:Watl000063)字段[课文阅读(paperRWId)]的值:[$(pobjPaperReadWriteEN.paperRWId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.readerId) == false && undefined !== pobjPaperReadWriteEN.readerId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.readerId) === false) {
            throw new Error("(errid:Watl000063)字段[阅读者Id(readerId)]的值:[$(pobjPaperReadWriteEN.readerId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperId) == false && undefined !== pobjPaperReadWriteEN.paperId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.paperId) === false) {
            throw new Error("(errid:Watl000063)字段[论文Id(paperId)]的值:[$(pobjPaperReadWriteEN.paperId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.researchQuestion) == false && undefined !== pobjPaperReadWriteEN.researchQuestion && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.researchQuestion) === false) {
            throw new Error("(errid:Watl000063)字段[研究问题(researchQuestion)]的值:[$(pobjPaperReadWriteEN.researchQuestion)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.operationTypeId) == false && undefined !== pobjPaperReadWriteEN.operationTypeId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.operationTypeId) === false) {
            throw new Error("(errid:Watl000063)字段[操作类型ID(operationTypeId)]的值:[$(pobjPaperReadWriteEN.operationTypeId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updDate) == false && undefined !== pobjPaperReadWriteEN.updDate && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.updDate) === false) {
            throw new Error("(errid:Watl000063)字段[修改日期(updDate)]的值:[$(pobjPaperReadWriteEN.updDate)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.memo) == false && undefined !== pobjPaperReadWriteEN.memo && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.memo) === false) {
            throw new Error("(errid:Watl000063)字段[备注(memo)]的值:[$(pobjPaperReadWriteEN.memo)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if (null != pobjPaperReadWriteEN.isSubmit && undefined !== pobjPaperReadWriteEN.isSubmit && clsString_js_1.tzDataType.isBoolean(pobjPaperReadWriteEN.isSubmit) === false) {
            throw new Error("(errid:Watl000063)字段[是否提交(isSubmit)]的值:[$(pobjPaperReadWriteEN.isSubmit)], 非法，应该为布尔型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if (null != pobjPaperReadWriteEN.isPublic && undefined !== pobjPaperReadWriteEN.isPublic && clsString_js_1.tzDataType.isBoolean(pobjPaperReadWriteEN.isPublic) === false) {
            throw new Error("(errid:Watl000063)字段[是否公开(isPublic)]的值:[$(pobjPaperReadWriteEN.isPublic)], 非法，应该为布尔型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.submitter) == false && undefined !== pobjPaperReadWriteEN.submitter && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.submitter) === false) {
            throw new Error("(errid:Watl000063)字段[提交人(submitter)]的值:[$(pobjPaperReadWriteEN.submitter)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.id_CurrEduCls) == false && undefined !== pobjPaperReadWriteEN.id_CurrEduCls && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.id_CurrEduCls) === false) {
            throw new Error("(errid:Watl000063)字段[教学班流水号(id_CurrEduCls)]的值:[$(pobjPaperReadWriteEN.id_CurrEduCls)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if (null != pobjPaperReadWriteEN.subVCount && undefined !== pobjPaperReadWriteEN.subVCount && clsString_js_1.tzDataType.isNumber(pobjPaperReadWriteEN.subVCount) === false) {
            throw new Error("(errid:Watl000063)字段[论文子观点数(subVCount)]的值:[$(pobjPaperReadWriteEN.subVCount)], 非法，应该为数值型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if (null != pobjPaperReadWriteEN.teaCount && undefined !== pobjPaperReadWriteEN.teaCount && clsString_js_1.tzDataType.isNumber(pobjPaperReadWriteEN.teaCount) === false) {
            throw new Error("(errid:Watl000063)字段[TeaCount(teaCount)]的值:[$(pobjPaperReadWriteEN.teaCount)], 非法，应该为数值型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.createDate) == false && undefined !== pobjPaperReadWriteEN.createDate && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.createDate) === false) {
            throw new Error("(errid:Watl000063)字段[建立日期(createDate)]的值:[$(pobjPaperReadWriteEN.createDate)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.shareId) == false && undefined !== pobjPaperReadWriteEN.shareId && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.shareId) === false) {
            throw new Error("(errid:Watl000063)字段[分享Id(shareId)]的值:[$(pobjPaperReadWriteEN.shareId)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.updUser) == false && undefined !== pobjPaperReadWriteEN.updUser && clsString_js_1.tzDataType.isString(pobjPaperReadWriteEN.updUser) === false) {
            throw new Error("(errid:Watl000063)字段[修改人(updUser)]的值:[$(pobjPaperReadWriteEN.updUser)], 非法，应该为字符型(In 论文读写表(PaperReadWrite))!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        //检查主键是否为Null或者空！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperRWId) === true) {
            throw new Error("(errid:Watl000064)字段[课文阅读]不能为空(In 论文读写表)!(clsPaperReadWriteBL:CheckProperty4Update)");
        }
        //检查外键， 作为外键应该和主键的字段长度是一样的， 若不一样，即非法！
        if ((0, clsString_js_2.IsNullOrEmpty)(pobjPaperReadWriteEN.paperId) == false && (0, clsString_js_2.GetStrLen)(pobjPaperReadWriteEN.paperId) != 8) {
            throw ("(errid:Watl000065)字段[论文Id]作为外键字段,长度应该为8(In 论文读写表)!(clsPaperReadWriteBL:CheckPropertyNew)");
        }
        pobjPaperReadWriteEN.SetIsCheckProperty(true);
    }
    exports.PaperReadWrite_CheckProperty4Update = PaperReadWrite_CheckProperty4Update;
    /**
     * 把一个对象转化为一个JSON串
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getJSONStrByRecObj)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperReadWrite_GetJSONStrByObj(pobjPaperReadWriteEN) {
        const strThisFuncName = "GetJSONStrByObj";
        pobjPaperReadWriteEN.sf_UpdFldSetStr = pobjPaperReadWriteEN.updFldString;
        let strJson = "";
        try {
            strJson = JSON.stringify(pobjPaperReadWriteEN);
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
    exports.PaperReadWrite_GetJSONStrByObj = PaperReadWrite_GetJSONStrByObj;
    /**
     * 把一个JSON串转化为一个对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象列表
    */
    function PaperReadWrite_GetObjLstByJSONStr(strJSON) {
        const strThisFuncName = "GetObjLstByJSONStr";
        let arrPaperReadWriteObjLst = new Array();
        if (strJSON === "") {
            return arrPaperReadWriteObjLst;
        }
        try {
            arrPaperReadWriteObjLst = JSON.parse(strJSON);
        }
        catch (objException) {
            return arrPaperReadWriteObjLst;
        }
        return arrPaperReadWriteObjLst;
    }
    exports.PaperReadWrite_GetObjLstByJSONStr = PaperReadWrite_GetObjLstByJSONStr;
    /**
     * 把一个JSON对象列表转化为一个实体对象列表
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getObjLstByJSONObjLst)
     * @param arrPaperReadWriteObjLstS:需要转化的JSON对象列表
     * @returns 返回一个生成的对象列表
    */
    function PaperReadWrite_GetObjLstByJSONObjLst(arrPaperReadWriteObjLstS) {
        const strThisFuncName = "GetObjLstByJSONObjLst";
        const arrPaperReadWriteObjLst = new Array();
        for (const objInFor of arrPaperReadWriteObjLstS) {
            const obj1 = PaperReadWrite_GetObjFromJsonObj(objInFor);
            if (obj1 == null)
                continue;
            arrPaperReadWriteObjLst.push(obj1);
        }
        return arrPaperReadWriteObjLst;
    }
    exports.PaperReadWrite_GetObjLstByJSONObjLst = PaperReadWrite_GetObjLstByJSONObjLst;
    /**
     * 把一个JSON串转化为一个对象
     * 作者:pyf
     * 日期:2023-03-13
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_getRecObjByJSONStr)
     * @param strJSON:需要转化的JSON串
     * @returns 返回一个生成的对象
    */
    function PaperReadWrite_GetObjByJSONStr(strJSON) {
        const strThisFuncName = "GetObjByJSONStr";
        let pobjPaperReadWriteEN = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
        if (strJSON === "") {
            return pobjPaperReadWriteEN;
        }
        try {
            pobjPaperReadWriteEN = JSON.parse(strJSON);
        }
        catch (objException) {
            return pobjPaperReadWriteEN;
        }
        return pobjPaperReadWriteEN;
    }
    exports.PaperReadWrite_GetObjByJSONStr = PaperReadWrite_GetObjByJSONStr;
    /**
     * 根据条件对象中的字段内容组合成一个条件串
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CombineConditionByCondObj)
     * @returns 条件串(strWhereCond)
    */
    function PaperReadWrite_GetCombineCondition(objPaperReadWrite_Cond) {
        const strThisFuncName = "GetCombineCondition";
        //使条件串的初值为"1 = 1",以便在该串的后面用"and "添加其他条件,
        //例如 1 = 1 && UserName = '张三'
        let strWhereCond = " 1 = 1 ";
        //如果该条件控件的内容不为空,就组成一个条件并添加到总条件串中。
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId) == true) {
            const strComparisonOp_PaperRWId = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperRWId, objPaperReadWrite_Cond.paperRWId, strComparisonOp_PaperRWId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ReaderId) == true) {
            const strComparisonOp_ReaderId = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ReaderId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ReaderId, objPaperReadWrite_Cond.readerId, strComparisonOp_ReaderId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperId) == true) {
            const strComparisonOp_PaperId = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_PaperId, objPaperReadWrite_Cond.paperId, strComparisonOp_PaperId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ResearchQuestion) == true) {
            const strComparisonOp_ResearchQuestion = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ResearchQuestion];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ResearchQuestion, objPaperReadWrite_Cond.researchQuestion, strComparisonOp_ResearchQuestion);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_OperationTypeId) == true) {
            const strComparisonOp_OperationTypeId = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_OperationTypeId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_OperationTypeId, objPaperReadWrite_Cond.operationTypeId, strComparisonOp_OperationTypeId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate) == true) {
            const strComparisonOp_UpdDate = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdDate, objPaperReadWrite_Cond.updDate, strComparisonOp_UpdDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Memo) == true) {
            const strComparisonOp_Memo = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Memo];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Memo, objPaperReadWrite_Cond.memo, strComparisonOp_Memo);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsSubmit) == true) {
            if (objPaperReadWrite_Cond.isSubmit == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsSubmit);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsSubmit);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsPublic) == true) {
            if (objPaperReadWrite_Cond.isPublic == true) {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '1'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsPublic);
            }
            else {
                strWhereCond += (0, clsString_js_2.Format)(" And {0} = '0'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_IsPublic);
            }
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Submitter) == true) {
            const strComparisonOp_Submitter = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Submitter];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_Submitter, objPaperReadWrite_Cond.submitter, strComparisonOp_Submitter);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_id_CurrEduCls) == true) {
            const strComparisonOp_id_CurrEduCls = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_id_CurrEduCls];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_id_CurrEduCls, objPaperReadWrite_Cond.id_CurrEduCls, strComparisonOp_id_CurrEduCls);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_SubVCount) == true) {
            const strComparisonOp_SubVCount = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_SubVCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_SubVCount, objPaperReadWrite_Cond.subVCount, strComparisonOp_SubVCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_TeaCount) == true) {
            const strComparisonOp_TeaCount = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_TeaCount];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} {1}", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_TeaCount, objPaperReadWrite_Cond.teaCount, strComparisonOp_TeaCount);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_CreateDate) == true) {
            const strComparisonOp_CreateDate = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_CreateDate];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_CreateDate, objPaperReadWrite_Cond.createDate, strComparisonOp_CreateDate);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ShareId) == true) {
            const strComparisonOp_ShareId = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ShareId];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_ShareId, objPaperReadWrite_Cond.shareId, strComparisonOp_ShareId);
        }
        if (Object.prototype.hasOwnProperty.call(objPaperReadWrite_Cond.dicFldComparisonOp, clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdUser) == true) {
            const strComparisonOp_UpdUser = objPaperReadWrite_Cond.dicFldComparisonOp[clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdUser];
            strWhereCond += (0, clsString_js_2.Format)(" And {0} {2} '{1}'", clsPaperReadWriteEN_js_1.clsPaperReadWriteEN.con_UpdUser, objPaperReadWrite_Cond.updUser, strComparisonOp_UpdUser);
        }
        return strWhereCond;
    }
    exports.PaperReadWrite_GetCombineCondition = PaperReadWrite_GetCombineCondition;
    /**
    *获取唯一性条件串(Uniqueness)--PaperReadWrite(论文读写表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString)
    * @param strReaderId: 阅读者Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperReadWrite_GetUniCondStr_ReaderId_PaperId(objPaperReadWriteEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and ReaderId = '{0}'", objPaperReadWriteEN.readerId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objPaperReadWriteEN.paperId);
        return strWhereCond;
    }
    exports.PaperReadWrite_GetUniCondStr_ReaderId_PaperId = PaperReadWrite_GetUniCondStr_ReaderId_PaperId;
    /**
    *获取唯一性条件串(Uniqueness)--PaperReadWrite(论文读写表),根据唯一约束条件来生成
    * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetUniquenessConditionString4Update)
    * @param strReaderId: 阅读者Id(要求唯一的字段)
    * @param strPaperId: 论文Id(要求唯一的字段)
    * @returns 条件串(strWhereCond)
    **/
    function PaperReadWrite_GetUniCondStr4Update_ReaderId_PaperId(objPaperReadWriteEN) {
        let strWhereCond = " 1 = 1 ";
        strWhereCond += (0, clsString_js_2.Format)(" and PaperRWId <> '{0}'", objPaperReadWriteEN.paperRWId);
        strWhereCond += (0, clsString_js_2.Format)(" and ReaderId = '{0}'", objPaperReadWriteEN.readerId);
        strWhereCond += (0, clsString_js_2.Format)(" and PaperId = '{0}'", objPaperReadWriteEN.paperId);
        return strWhereCond;
    }
    exports.PaperReadWrite_GetUniCondStr4Update_ReaderId_PaperId = PaperReadWrite_GetUniCondStr4Update_ReaderId_PaperId;
    /**
     * 把同一个类的对象,复制到另一个对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_CopyObjTo)
     * @param objPaperReadWriteENS:源对象
     * @param objPaperReadWriteENT:目标对象
    */
    function PaperReadWrite_CopyObjTo(objPaperReadWriteENS, objPaperReadWriteENT) {
        objPaperReadWriteENT.paperRWId = objPaperReadWriteENS.paperRWId; //课文阅读
        objPaperReadWriteENT.readerId = objPaperReadWriteENS.readerId; //阅读者Id
        objPaperReadWriteENT.paperId = objPaperReadWriteENS.paperId; //论文Id
        objPaperReadWriteENT.researchQuestion = objPaperReadWriteENS.researchQuestion; //研究问题
        objPaperReadWriteENT.operationTypeId = objPaperReadWriteENS.operationTypeId; //操作类型ID
        objPaperReadWriteENT.updDate = objPaperReadWriteENS.updDate; //修改日期
        objPaperReadWriteENT.memo = objPaperReadWriteENS.memo; //备注
        objPaperReadWriteENT.isSubmit = objPaperReadWriteENS.isSubmit; //是否提交
        objPaperReadWriteENT.isPublic = objPaperReadWriteENS.isPublic; //是否公开
        objPaperReadWriteENT.submitter = objPaperReadWriteENS.submitter; //提交人
        objPaperReadWriteENT.id_CurrEduCls = objPaperReadWriteENS.id_CurrEduCls; //教学班流水号
        objPaperReadWriteENT.subVCount = objPaperReadWriteENS.subVCount; //论文子观点数
        objPaperReadWriteENT.teaCount = objPaperReadWriteENS.teaCount; //TeaCount
        objPaperReadWriteENT.createDate = objPaperReadWriteENS.createDate; //建立日期
        objPaperReadWriteENT.shareId = objPaperReadWriteENS.shareId; //分享Id
        objPaperReadWriteENT.updUser = objPaperReadWriteENS.updUser; //修改人
        objPaperReadWriteENT.sf_UpdFldSetStr = objPaperReadWriteENS.updFldString; //sf_UpdFldSetStr
    }
    exports.PaperReadWrite_CopyObjTo = PaperReadWrite_CopyObjTo;
    /**
     * 把一个JSON的对象,复制到另一个实体对象
     * (AutoGCLib.WA_Access4TypeScript:Gen_4BL_Ts_GetObjFromJsonObj)
     * @param objPaperReadWriteENS:源对象
     * @param objPaperReadWriteENT:目标对象
    */
    function PaperReadWrite_GetObjFromJsonObj(objPaperReadWriteENS) {
        const objPaperReadWriteENT = new clsPaperReadWriteEN_js_1.clsPaperReadWriteEN();
        (0, clsCommFunc4Web_js_1.ObjectAssign)(objPaperReadWriteENT, objPaperReadWriteENS);
        return objPaperReadWriteENT;
    }
    exports.PaperReadWrite_GetObjFromJsonObj = PaperReadWrite_GetObjFromJsonObj;
});
